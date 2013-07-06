Imports System.Data.SQLite

Public Class BattleEffect

    Private ID As UInteger
    Private Shared maxID As Integer = -1
    Private PHp, PMaxHp, PMana, PMaxMana, PEnergy, PMaxEnergy As Integer
    Private PStat(5) As Integer
    Private PSkillsDmgBonusDict As New Dictionary(Of String, Integer)
    Private PBonusMelee, PBonusMinMelee, PBonusRanged, PBonusMinRanged, PBonusMagic, PDefense As Integer
    Private mMember As BattleMember
    Private empty As Boolean
    Private name As String
    Private turns As UInteger
    Private caster As BattlePlayer

    Public Sub New(ByVal name As String, ByVal duration As UInteger, ByRef caster As BattlePlayer, ByRef target As BattleMember, Optional ByVal existID As Integer = -1)
        If (maxID = -1) Then
            'initialise maxID
            Dim mID = New SQLiteCommand("SELECT MAX(id) FROM battle_effects", Common.sqLiteCon).ExecuteScalar()
            If (IsDBNull(mID)) Then maxID = 0 Else maxID = mID + 1
        End If
        ID = IIf(existID = -1, maxID, existID)
        maxID += 1

        PHp = 0
        PMaxHp = 0
        PMana = 0
        PMaxMana = 0
        PEnergy = 0
        PMaxEnergy = 0
        For i = 0 To 4
            PStat(i) = 0
        Next
        For i = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) = 0
        Next
        PBonusMelee = 0
        PBonusMinMelee = 0
        PBonusRanged = 0
        PBonusMinRanged = 0
        PBonusMagic = 0
        PDefense = 0

        Me.caster = caster
        mMember = target
        empty = True
        Me.name = name
        turns = duration
        If (existID <> -1) Then
            LoadFromDB()
        End If
    End Sub

    Public Function IsEmpty() As Boolean
        Return empty
    End Function

    Public Function GetPlayer() As BattlePlayer
        Return mMember
    End Function

    Public Function GetName() As String
        Return name
    End Function

    Public Function GetTurnsRemaining() As UInteger
        Return turns
    End Function

    ''' <summary>
    ''' Lowers the turns remaining for this Effect
    ''' </summary>
    ''' <returns>True if effect needs to be removed, false otherwise</returns>
    ''' <remarks></remarks>
    Public Function DecrementTurn() As Boolean
        If (turns = 0) Then Return False
        turns -= 1
        If (turns = 0) Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Loads effect values from a database row.
    ''' </summary>
    ''' <param name="query">Query loaded into the correct row to load effects from.</param>
    ''' <remarks></remarks>
    Public Overloads Sub LoadFromDB(ByRef query As SQLiteDataReader)
        For i As Integer = 0 To query.FieldCount - 1
            AddStatByName(query.GetName(i), query.GetValue(i))
        Next
    End Sub

    Public Overloads Sub LoadFromDB()
        Dim query = New SQLiteCommand("SELECT * FROM battle_effects WHERE id=" & ID, Common.sqLiteCon).ExecuteReader()
        If (query.Read()) Then
            LoadFromDB(query)
        End If
    End Sub

    ''' <summary>
    ''' Simple func to give us the right value from the DB.
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ToEffectInt(ByVal v As String, Optional ByVal assignEmpty As Boolean = True) As Integer
        If (v = "") Then
            Return 0
        Else
            Dim i As Integer = 0
            ' have to do this to account for loading raw stats from DB... no caster, no formulae.
            If (Not Integer.TryParse(v, i)) Then
                i = caster.EvaluateFormula(v, mMember)
            End If
            If (i <> 0) Then
                If (assignEmpty) Then empty = False
                Return i
            Else
                Return 0
            End If
            End If
    End Function

    Private Sub AddStatByName(ByVal name As String, ByVal value As Object)
        If (name.Contains("maxhp")) Then
            PMaxHp = ToEffectInt(value)
        ElseIf (name.Contains("maxmana")) Then
            PMaxMana = ToEffectInt(value)
        ElseIf (name.Contains("maxenergy")) Then
            PMaxEnergy = ToEffectInt(value)
        ElseIf (name.Contains("minmelee")) Then
            PBonusMinMelee = ToEffectInt(value)
        ElseIf (name.Contains("minranged")) Then
            PBonusMinRanged = ToEffectInt(value)
        ElseIf (name.Contains("hp")) Then
            PHp = ToEffectInt(value)
        ElseIf (name.Contains("mana")) Then
            PMana = ToEffectInt(value)
        ElseIf (name.Contains("energy")) Then
            PEnergy = ToEffectInt(value)
        ElseIf (name.Contains("melee")) Then
            PBonusMelee = ToEffectInt(value)
        ElseIf (name.Contains("ranged")) Then
            PBonusRanged = ToEffectInt(value)
        ElseIf (name.Contains("magic")) Then
            PBonusMagic = ToEffectInt(value)
        ElseIf (name.Contains("def")) Then
            PDefense = ToEffectInt(value)
        ElseIf (name.Contains("str")) Then
            PStat(BattlePlayer.STAT_STR) = ToEffectInt(value)
        ElseIf (name.Contains("agi")) Then
            PStat(BattlePlayer.STAT_AGI) = ToEffectInt(value)
        ElseIf (name.Contains("int")) Then
            PStat(BattlePlayer.STAT_INT) = ToEffectInt(value)
        ElseIf (name.Contains("wil")) Then
            PStat(BattlePlayer.STAT_WIL) = ToEffectInt(value)
        ElseIf (name.Contains("end")) Then
            PStat(BattlePlayer.STAT_END) = ToEffectInt(value)
        ElseIf (name.Contains("skills")) Then
            Dim valRay() As String = value.ToString().Split(",")
            If (valRay.Count <> SkillsListView.GetSkillsCount()) Then
                MsgBox("Count mismatch in skills field for BattleEffect (got " & valRay.Count & ", expected " & SkillsListView.GetSkillsCount(), MsgBoxStyle.Critical, "Error")
                Return
            End If
            For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
                PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) = Integer.Parse(valRay(i))
                If (valRay(i) <> 0) Then empty = False
            Next
            Return
        End If
    End Sub

    ''' <summary>
    ''' Applies the effect onto the attached player.
    ''' </summary>
    ''' <param name="remove">If True, the effect will be removed instead of applied.</param>
    ''' <remarks></remarks>
    Public Sub Apply(Optional ByVal remove = False)
        If (mMember Is Nothing) Then Return

        If (remove And mMember.Effects.Contains(Me)) Then
            mMember.Effects.Remove(Me)
        ElseIf (Not remove And Not mMember.Effects.Contains(Me)) Then
            mMember.Effects.Add(Me)
        Else
            Return
        End If

        Dim m As Integer = IIf(remove, -1, 1)

        mMember.MembHpCur += m * PHp
        mMember.MembHpMax += m * PMaxHp
        If (mMember.IsPlayer()) Then
            Dim mPlayer As BattlePlayer = DirectCast(mMember, BattlePlayer)
            If (mPlayer.GetPowerType() = "Mana") Then mPlayer.MembPowerCur += m * PMana
            If (mPlayer.GetPowerType() = "Mana") Then mPlayer.MembPowerMax += m * PMaxMana
            If (mPlayer.GetPowerType() = "Energy") Then mPlayer.MembPowerCur += m * PEnergy
            If (mPlayer.GetPowerType() = "Energy") Then mPlayer.MembPowerCur += m * PMaxEnergy
            For i As Integer = 0 To 4
                mPlayer.AddToStat(i, m * PStat(i))
            Next
            For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
                mPlayer.PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) += m * PSkillsDmgBonusDict(SkillsListView.GetSkillName(i))
            Next
            mPlayer.PBonusMelee += m * PBonusMelee
            mPlayer.PBonusMinMelee += m * PBonusMinMelee
            mPlayer.PBonusRanged += m * PBonusRanged
            mPlayer.PBonusMinRanged += m * PBonusMinRanged
            mPlayer.PBonusMagic += m * PBonusMagic
            mPlayer.PDefense += m * PDefense
        End If
    End Sub

    Public Sub Remove()
        Apply(True)
    End Sub

    Public Sub Save()
        If (empty) Then Return
        Dim q As New SQLiteCommand(Common.sqLiteCon)
        q.CommandText = "BEGIN TRANSACTION;" & vbNewLine & "DELETE FROM battle_effects WHERE id=" & ID & ";" & vbNewLine
        q.CommandText &= "INSERT INTO battle_effects (id, member_id, name, turns_left, stat_str, stat_agi, stat_int, stat_wil, stat_end, skills, hp, maxhp, mana, maxmana, energy, maxenergy, melee, minmelee, ranged, minranged, magic, defense) "
        q.CommandText &= "VALUES (@id, @member_id, @name, @turns_left, @stat_str, @stat_agi, @stat_int, @stat_wil, @stat_end, @skills, @hp, @maxhp, @mana, @maxmana, @energy, @maxenergy, @melee, @minmelee, @ranged, @minranged, @magic, @defense);" & vbNewLine & "COMMIT;"
        q.Parameters.AddWithValue("@id", ID)
        q.Parameters.AddWithValue("@member_id", IIf(mMember IsNot Nothing, mMember.GetID(), -1))
        q.Parameters.AddWithValue("@name", name)
        q.Parameters.AddWithValue("@turns_left", turns)
        q.Parameters.AddWithValue("@stat_str", PStat(BattlePlayer.STAT_STR))
        q.Parameters.AddWithValue("@stat_agi", PStat(BattlePlayer.STAT_AGI))
        q.Parameters.AddWithValue("@stat_int", PStat(BattlePlayer.STAT_INT))
        q.Parameters.AddWithValue("@stat_wil", PStat(BattlePlayer.STAT_WIL))
        q.Parameters.AddWithValue("@stat_end", PStat(BattlePlayer.STAT_END))
        q.Parameters.AddWithValue("@skills", Common.ListToCommaSep(PSkillsDmgBonusDict))
        q.Parameters.AddWithValue("@hp", PHp)
        q.Parameters.AddWithValue("@maxhp", PMaxHp)
        q.Parameters.AddWithValue("@mana", PMana)
        q.Parameters.AddWithValue("@maxmana", PMaxMana)
        q.Parameters.AddWithValue("@energy", PEnergy)
        q.Parameters.AddWithValue("@maxenergy", PMaxEnergy)
        q.Parameters.AddWithValue("@melee", PBonusMelee)
        q.Parameters.AddWithValue("@minmelee", PBonusMinMelee)
        q.Parameters.AddWithValue("@ranged", PBonusRanged)
        q.Parameters.AddWithValue("@minranged", PBonusMinRanged)
        q.Parameters.AddWithValue("@magic", PBonusMagic)
        q.Parameters.AddWithValue("@defense", PDefense)
        q.ExecuteNonQuery()
    End Sub

End Class
