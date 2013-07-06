Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class BattlePlayer
    Inherits BattleMember

    ' shouldve enum'd these
    Public Shared ReadOnly STAT_STR As UInteger = 0
    Public Shared ReadOnly STAT_AGI As UInteger = 1
    Public Shared ReadOnly STAT_INT As UInteger = 2
    Public Shared ReadOnly STAT_WIL As UInteger = 3
    Public Shared ReadOnly STAT_END As UInteger = 4

    'battle players are just members with added complexity.
    Private curPower, maxPower As Integer
    Friend WithEvents Label4 As System.Windows.Forms.Label

    'player member vars
    Private plID As Integer
    Private PSkillsBaseDict As New Dictionary(Of String, Integer)
    '0-str, 1-agi, 2-int, 3-wil, 4-end
    Private PStat(5) As Integer
    Public PSkillsDmgBonusDict As New Dictionary(Of String, Integer)
    Private PPowerType As String 'Mana or Energy
    Private PAttackType As String ' either 'm' for melee only or 'mr' for melee and ranged.
    Public PBonusMelee, PBonusMinMelee, PBonusRanged, PBonusMinRanged, PBonusMagic, PDefense As Integer
    Private PEquippedLeftType, PEquippedRightType, PEquippedRangedType As String
    Private PSpells As New List(Of UInteger)
    Private PUsableItems As New List(Of UInteger)
    Private PColor As String
    Private PBlocks As Integer
    Private DontSave As Boolean

    Private Sub InitializeLabel4()
        'initialise component
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 19)
        Me.Label4.MaximumSize = New System.Drawing.Size(77, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pow XXX/XXX"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Panel1.Controls.Add(Me.Label4)
    End Sub

    Property MembPowerCur() As Integer
        Get
            Return curPower
        End Get
        Set(ByVal value As Integer)
            curPower = value
            If (curPower < 0) Then curPower = 0
            If (curPower > maxPower) Then curPower = maxPower
            Label4.Text = "Pow " & curPower.ToString() & "/" & maxPower.ToString()
        End Set
    End Property
    Property MembPowerMax() As Integer
        Get
            Return maxPower
        End Get
        Set(ByVal value As Integer)
            maxPower = value
            Label4.Text = "Pow " & curPower.ToString() & "/" & maxPower.ToString()
        End Set
    End Property

    ''' <summary>
    ''' Creating brand new player
    ''' </summary>
    ''' <param name="plID"></param>
    ''' <param name="tID"></param>
    ''' <param name="srcBtl"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal plID As UInteger, ByVal tID As Byte, ByRef srcBtl As Battle, Optional ByVal virtual As Boolean = False)
        InitializeLabel4()

        If (maxMembID = -1) Then
            'initialise maxMembID
            Dim mID = New SQLite.SQLiteCommand("SELECT MAX(id) FROM battle_members", Common.sqLiteCon).ExecuteScalar()
            If (IsDBNull(mID)) Then maxMembID = 0 Else maxMembID = mID + 1
        End If
        membID = maxMembID
        maxMembID += 1

        Me.DontSave = virtual
        Me.plID = plID
        Me.teamID = tID
        Me.battle = srcBtl
        'time to load it all...
        LoadDefaultInfo()
        Save()
    End Sub

    ''' <summary>
    ''' Loading player from DB
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="battle"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal id As Integer, ByRef battle As MediCalc.Battle)
        InitializeLabel4()

        Me.battle = battle
        bDead = False
        LoadInfoByMembID(id)
    End Sub

    Public Shared Function CalcScalar(ByVal val As Integer, ByVal isMagic As Boolean) As Double
        Dim ret As Double = 1
        If (val = 0) Then
            ret = 0.5
        ElseIf (val = 1) Then
            ret = 0.75
        ElseIf (val = 2) Then
            ret = 1
        ElseIf (val = 3) Then
            ret = 1.1
        ElseIf (val = 4) Then
            ret = 1.2
        ElseIf (val = 5) Then
            ret = 1.25
        ElseIf (val = 6) Then
            ret = 1.4
        End If
        'if magic then we want mana cost reduction
        If (isMagic) Then
            If (ret < 1) Then
                ret = ret + 1
            ElseIf (ret > 1) Then
                ret = 2.0 - ret
            End If
        End If
        Return ret
    End Function

    ''' <summary>
    ''' Add stats, skills, rating bonuses to this battle member from the specified item
    ''' </summary>
    ''' <param name="itemQ">The query reader for the item in question, should be on correct row with all columns available</param>
    ''' <param name="scalar">What we need to modify certain ratings by</param>
    ''' <param name="itemType">Either "weapon" or "armor", determines what the scalar needs to apply to</param>
    ''' <remarks></remarks>
    Public Sub AddStatsWithScalar(ByRef itemQ As SQLiteDataReader, ByVal scalar As Double, ByVal itemType As String)
        '6-10 is stats
        '11 is skills
        '12-20 is ratings. (maxhp, maxmana, maxeng, melee, minmelee, ranged, minranged, magic, defense)
        For i As Integer = 6 To 10
            PStat(i - 6) += itemQ.GetInt32(i)
        Next
        Dim skillsRay() As String = itemQ.GetString(11).Split(",")
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) += Integer.Parse(skillsRay(i))
        Next
        For i As Integer = 12 To 20
            Select Case i
                Case 12
                    MembHpMax += itemQ.GetInt32(i)
                Case 13
                    If (PPowerType = "Mana") Then
                        MembPowerMax += itemQ.GetInt32(i)
                    End If
                Case 14
                    If (PPowerType = "Energy") Then
                        MembPowerMax += itemQ.GetInt32(i)
                    End If
                Case 15
                    If (itemType = "weapon") Then
                        PBonusMelee += scalar * itemQ.GetInt32(i)
                    Else
                        PBonusMelee += itemQ.GetInt32(i)
                    End If
                Case 16
                    If (itemType = "weapon") Then
                        PBonusMinMelee += scalar * itemQ.GetInt32(i)
                    Else
                        PBonusMinMelee += itemQ.GetInt32(i)
                    End If
                Case 17
                    If (itemType = "weapon") Then
                        PBonusRanged += scalar * itemQ.GetInt32(i)
                    Else
                        PBonusRanged += itemQ.GetInt32(i)
                    End If
                Case 18
                    If (itemType = "weapon") Then
                        PBonusMinRanged += scalar * itemQ.GetInt32(i)
                    Else
                        PBonusMinRanged += itemQ.GetInt32(i)
                    End If
                Case 19
                    PBonusMagic += itemQ.GetInt32(i)
                Case 20
                    If (itemType = "armor") Then
                        PDefense += scalar * itemQ.GetInt32(i)
                    Else
                        PDefense += itemQ.GetInt32(i)
                    End If
            End Select
        Next
    End Sub

    Public Function GetPlayerID() As UInteger
        Return plID
    End Function

    ''' <summary>
    ''' Saves the BattlePlayer to the database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Save()
        If (DontSave) Then Return
        Dim q = New SQLiteCommand(Common.sqLiteCon)
        q.CommandText = "BEGIN TRANSACTION;" & vbNewLine & "DELETE FROM battle_members WHERE id=" & membID & ";" & vbNewLine
        q.CommandText &= "INSERT INTO battle_members (id, battle_id, team_id, player_id, name, MembLevel, MembHpCur, MembHpMax, MembPowerCur, MembPowerMax, skillsbase, stat0, stat1, stat2, stat3, stat4, skillsdmgbonus, powertype, attacktype, bonusmelee, bonusminmelee, bonusranged, bonusminranged, bonusmagic, defense, spells, items, color, leftequiptype, rightequiptype, rangedequiptype, blocks)"
        q.CommandText &= "VALUES (@id, @bid, @tid, @pid, @mname, @mlvl, @mhpc, @mhpm, @mpowc, @mpowm, @skillsb, @s0, @s1, @s2, @s3, @s4, @skillse, @powtype, @atktype, @bmel, @bminmel, @brange, @bminrange, @bmagic, @def, @spells, @items, @color, @let, @rtet, @ret, @blocks);"
        q.CommandText &= vbNewLine & "COMMIT;"
        q.Parameters.AddWithValue("@id", GetID())
        q.Parameters.AddWithValue("@bid", GetBattleID())
        q.Parameters.AddWithValue("@tid", GetTeamID())
        q.Parameters.AddWithValue("@pid", GetPlayerID())
        q.Parameters.AddWithValue("@mname", MembName)
        q.Parameters.AddWithValue("@mlvl", MembLevel)
        q.Parameters.AddWithValue("@mhpc", MembHpCur)
        q.Parameters.AddWithValue("@mhpm", MembHpMax)
        q.Parameters.AddWithValue("@mpowc", MembPowerCur)
        q.Parameters.AddWithValue("@mpowm", MembPowerMax)
        q.Parameters.AddWithValue("@skillsb", Common.ListToCommaSep(PSkillsBaseDict))
        For i = 0 To 4
            q.Parameters.AddWithValue("@s" & i, PStat(i))
        Next
        q.Parameters.AddWithValue("@skillse", Common.ListToCommaSep(PSkillsDmgBonusDict))
        q.Parameters.AddWithValue("@powtype", PPowerType)
        q.Parameters.AddWithValue("@atktype", PAttackType)
        q.Parameters.AddWithValue("@bmel", PBonusMelee)
        q.Parameters.AddWithValue("@bminmel", PBonusMinMelee)
        q.Parameters.AddWithValue("@brange", PBonusRanged)
        q.Parameters.AddWithValue("@bminrange", PBonusMinRanged)
        q.Parameters.AddWithValue("@bmagic", PBonusMagic)
        q.Parameters.AddWithValue("@def", PDefense)
        q.Parameters.AddWithValue("@spells", Common.ListToCommaSep(PSpells))
        q.Parameters.AddWithValue("@items", Common.ListToCommaSep(PUsableItems))
        q.Parameters.AddWithValue("@color", PColor)
        q.Parameters.AddWithValue("@let", PEquippedLeftType)
        q.Parameters.AddWithValue("@rtet", PEquippedRightType)
        q.Parameters.AddWithValue("@ret", PEquippedRangedType)
        q.Parameters.AddWithValue("@blocks", PBlocks)
        q.ExecuteNonQuery()
        SaveEffects()
    End Sub

    ''' <summary>
    ''' Resets the BattlePlayer's information to defaults.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadDefaultInfo()
        PAttackType = "m" 'by default

        'initialise all.
        PBonusMelee = 0
        PBonusMinMelee = 0
        PBonusRanged = 0
        PBonusMinRanged = 0
        PBonusMagic = 0
        PDefense = 0
        PEquippedLeftType = ""
        PEquippedRightType = "Unarmed Combat"
        PEquippedRangedType = ""
        bDead = False
        PBlocks = 0
        MembPowerMax = 0
        MembHpMax = 1
        MembPowerCur = 0
        MembHpCur = 1
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) = 0
        Next

        Dim plInfoQuery = New SQLiteCommand("SELECT * FROM players WHERE id=" & plID, Common.sqLiteCon)
        'plInfo holds name, level, base stats, base skill and colour.
        Dim plInfoQ = plInfoQuery.ExecuteReader()
        plInfoQ.Read()
        MembName = plInfoQ.Item("name").ToString()
        MembLevel = plInfoQ.Item("level").ToString()
        For i As Integer = 11 To 15
            PStat(i - 11) = plInfoQ.GetInt32(i)
        Next
        PColor = plInfoQ.Item("color").ToString()
        Dim skillsRay() As String = plInfoQ.Item("skills").ToString().Split(",")
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsBaseDict(SkillsListView.GetSkillName(i)) = Integer.Parse(skillsRay(i))
        Next
        'now we work out powertype based on class
        Dim powerQ = New SQLiteCommand("SELECT powertype FROM classes WHERE name=@name", Common.sqLiteCon)
        powerQ.Parameters.AddWithValue("@name", plInfoQ.Item("class"))
        PPowerType = powerQ.ExecuteScalar()
        'player_items contains usable items list, and equipped items, whose stats need to be added on to base.
        'armor and weapon ratings needs to take skill into account.
        plInfoQ.Close()
        Dim plItemQuery = New SQLiteCommand("SELECT * FROM player_items WHERE player_id=" & plID, Common.sqLiteCon)
        Dim plItemQ = plItemQuery.ExecuteReader()
        While (plItemQ.Read())
            'for each item...
            Dim thisItemQuery = New SQLiteCommand("SELECT * FROM items WHERE id=" & plItemQ.Item("item_id").ToString(), Common.sqLiteCon)
            Dim thisItemQ = thisItemQuery.ExecuteReader()
            thisItemQ.Read()
            If (Not IsDBNull(thisItemQ.Item("type"))) Then
                'if usable item
                If ((Integer.Parse(thisItemQ.Item("type")) And 2) > 0) Then
                    PUsableItems.Add(UInteger.Parse(plItemQ.Item("item_id")))
                End If

                Dim slot As String = plItemQ.Item("equip_slot").ToString()
                If (slot <> "") Then
                    'there's an item equipped here...
                    If (slot = "LeftArm" Or slot = "RightArm" Or slot = "Ranged") Then
                        'it's a weapon
                        Dim wepType As String = thisItemQ.Item("weapon_type").ToString()
                        If (slot = "Ranged" And Not PAttackType.Contains("r")) Then
                            PAttackType &= "r"
                            PEquippedRangedType = wepType
                        End If
                        If (slot = "LeftArm") Then
                            PEquippedLeftType = wepType
                        ElseIf (slot = "RightArm") Then
                            PEquippedRightType = wepType
                        End If
                        Dim scalar As Double = 1.0
                        If (wepType <> "None" And wepType <> "") Then
                            scalar = CalcScalar(PSkillsBaseDict(wepType), False)
                        Else
                            If (slot = "LeftArm") Then
                                PEquippedLeftType = ""
                            ElseIf (slot = "Ranged") Then
                                PEquippedRangedType = ""
                            ElseIf (slot = "RightArm") Then
                                PEquippedRightType = "Unarmed Combat"
                            End If
                        End If
                        AddStatsWithScalar(thisItemQ, scalar, "weapon")
                    Else
                        'it's armor of some kind
                        Dim eqType As String = thisItemQ.Item("equipment_type").ToString()
                        Dim scalar As Double = 1.0
                        If (eqType <> "None" And eqType <> "") Then
                            scalar = CalcScalar(PSkillsBaseDict(eqType), False)
                        End If
                        AddStatsWithScalar(thisItemQ, scalar, "armor")
                    End If
            End If
            End If
            thisItemQ.Close()
        End While
        plItemQ.Close()
        'add to ratings based on raw stats
        'str
        PBonusMelee += PStat(0)
        PBonusRanged += Math.Floor(PStat(0) / 2)
        'agi
        PBonusRanged += Math.Floor(PStat(1) / 2)
        MembPowerMax += IIf(PPowerType = "Energy", PStat(1) * 5, 0)
        'int
        MembPowerMax += IIf(PPowerType = "Mana", PStat(2) * 5, 0)
        'wil
        PBonusMagic += PStat(3)
        'end
        MembHpMax += PStat(4) * 5
        PDefense += Math.Floor(PStat(4) / 5)
        'load spells
        Dim splstr = New SQLiteCommand("SELECT spells FROM player_spells WHERE player_id=" & plID, Common.sqLiteCon).ExecuteScalar()
        If (Not splstr Is Nothing And splstr <> "") Then
            For Each s As String In splstr.Split(",")
                PSpells.Add(UInteger.Parse(s))
            Next
        End If
        'set cur to max
        MembPowerCur = MembPowerMax
        MembHpCur = MembHpMax
    End Sub

    ''' <summary>
    ''' Loads the BattlePlayer's fields with information from the DB.
    ''' </summary>
    ''' <param name="membID">ID of member.</param>
    ''' <remarks></remarks>
    Private Sub LoadInfoByMembID(ByVal membID As UInteger)
        PSkillsBaseDict.Clear()
        PSkillsDmgBonusDict.Clear()
        PSpells.Clear()
        PUsableItems.Clear()

        Dim info = New SQLiteCommand("SELECT * FROM battle_members WHERE id=" & membID, Common.sqLiteCon)
        Dim infoQ = info.ExecuteReader()
        If (Not infoQ.Read()) Then
            MsgBox("Tried to create non existant member #" & membID, MsgBoxStyle.Critical, "Error")
            Dispose()
            Return
        End If
        If (infoQ.Item("player_id") = -1) Then
            MsgBox("Tried to create non existant player member #" & membID, MsgBoxStyle.Critical, "Error")
            Dispose()
            Return
        End If
        Me.membID = membID
        teamID = infoQ.GetByte(2)
        plID = infoQ.GetInt32(3)
        MembName = infoQ.GetString(4)
        MembLevel = infoQ.GetString(5)
        MembHpMax = infoQ.GetInt32(7)
        If (bDead And infoQ.GetInt32(6) > 0) Then
            Revive(infoQ.GetInt32(6))
        Else
            MembHpCur = infoQ.GetInt32(6)
        End If
        MembPowerMax = infoQ.GetInt32(9)
        MembPowerCur = infoQ.GetInt32(8)
        Dim sks() As String = infoQ.GetString(10).Split(",")
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsBaseDict(SkillsListView.GetSkillName(i)) = sks(i)
        Next
        For i As Integer = 11 To 15
            PStat(i - 11) = infoQ.GetInt32(i)
        Next
        sks = infoQ.GetString(16).Split(",")
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            PSkillsDmgBonusDict(SkillsListView.GetSkillName(i)) = sks(i)
        Next
        PPowerType = infoQ.GetString(17)
        PAttackType = infoQ.GetString(18)
        PBonusMelee = infoQ.GetInt32(19)
        PBonusMinMelee = infoQ.GetInt32(20)
        PBonusRanged = infoQ.GetInt32(21)
        PBonusMinRanged = infoQ.GetInt32(22)
        PBonusMagic = infoQ.GetInt32(23)
        PDefense = infoQ.GetInt32(24)
        Dim comsep As String = infoQ.GetString(25)
        If (Not comsep Is Nothing And comsep <> "") Then
            For Each s As String In comsep.Split(",")
                PSpells.Add(UInteger.Parse(s))
            Next
        End If
        comsep = infoQ.GetString(26)
        If (Not comsep Is Nothing And comsep <> "") Then
            For Each s As String In comsep.Split(",")
                PUsableItems.Add(UInteger.Parse(s))
            Next
        End If
        PColor = infoQ.GetString(27)
        PEquippedLeftType = infoQ.GetString(28)
        PEquippedRightType = infoQ.GetString(29)
        PEquippedRangedType = infoQ.GetString(30)
        PBlocks = infoQ.GetInt32(31)
        infoQ.Close()
        info.CommandText = "SELECT * FROM battle_actions WHERE member_id=" & membID
        Dim res = info.ExecuteReader()
        If (res.Read()) Then
            actID = res.Item("id")
            FlagAction(actID, BattlePlayerAction.GenerateActionText(res.Item("p_attacktype"), res.Item("p_attackextra"), res.Item("targettype"), res.Item("targetextra")))
        End If
        res.Close()
        LoadEffects()
    End Sub

    ''' <summary>
    ''' Reloads this player's info, getting values from the DB.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReloadInfoFromDB()
        LoadInfoByMembID(GetID())
    End Sub

    Protected Overrides Sub BTN_Edit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        BattlePlayerEdit.open(Me)
    End Sub

    Protected Overrides Sub BTN_Action_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        BattlePlayerAction.open(Me, actID)
    End Sub

    Public Overrides Function IsPlayer() As Boolean
        Return True
    End Function

    Public Function CanRanged() As Boolean
        Return PAttackType.Contains("r")
    End Function

    Public Function GetSpell(ByVal i As UInteger) As UInteger
        Return PSpells(i)
    End Function

    Public Function GetUsableItem(ByVal i As UInteger) As UInteger
        Return PUsableItems(i)
    End Function

    Public Function GetSpellsCount() As UInteger
        Return PSpells.Count
    End Function

    Public Function GetUsableItemsCount() As UInteger
        Return PUsableItems.Count
    End Function

    Public Function GetStat(ByVal idx As Integer) As Integer
        Return PStat(idx)
    End Function

    Public Sub AddToStat(ByVal idx As Integer, ByVal val As Integer)
        PStat(idx) += val
    End Sub

    Public Function GetPowerType() As String
        Return PPowerType
    End Function

    Public Overrides Function ApplyReductions(ByVal baseDamage As Integer) As Integer
        Dim reducted As Integer = baseDamage

        If (PBlocks = 1) Then
            reducted = 0
        ElseIf (PBlocks = 2) Then
            reducted = Math.Floor(reducted / 2)
        End If

        reducted -= PDefense
        Return IIf(reducted > 0, reducted, 0)
    End Function

    Public Sub DoPlayerAction(ByRef targets As List(Of BattleMember), ByVal atype As Integer, ByVal aextra As Integer)
        If (targets.Count = 0) Then
            Return
        ElseIf (targets.Count = 1) Then
            DoPlayerAction(targets(0), atype, aextra)
        Else
            Select Case atype
                Case BattlePlayerAction.ATYPE_MELEE
                    For Each target As BattleMember In targets
                        DoMelee(target)
                    Next
                Case BattlePlayerAction.ATYPE_RANGED
                    For Each target As BattleMember In targets
                        DoRanged(target)
                    Next
                Case BattlePlayerAction.ATYPE_BLOCK
                    DoBlock()
                Case BattlePlayerAction.ATYPE_SPELL
                    Dim multicast = New SQLiteCommand("SELECT multicast FROM spells WHERE id=" & aextra, Common.sqLiteCon).ExecuteScalar()
                    If (multicast = 1) Then
                        DoSpell(targets(0), aextra, False)
                        For i As Integer = 1 To targets.Count - 1
                            DoSpell(targets(i), aextra, True)
                        Next
                    ElseIf (multicast = 0) Then
                        For Each target As BattleMember In targets
                            DoSpell(target, aextra, False)
                        Next
                    Else
                        MsgBox("Member " & MembName & " casting non-existant spell # " & aextra & ", action ignored", MsgBoxStyle.Critical, "Error")
                        Return
                    End If
                Case BattlePlayerAction.ATYPE_ITEM
                    For Each target As BattleMember In targets
                        DoItem(target, aextra)
                    Next
            End Select
        End If
    End Sub

    Public Sub DoPlayerAction(ByRef target As BattleMember, ByVal atype As Integer, ByVal aextra As Integer)
        'aextra is only used for spell/item, in that case it's spell/item id that's being done.

        'up here we'll reset block count if not blocking any more.
        If (atype <> BattlePlayerAction.ATYPE_BLOCK) Then
            PBlocks = 0
        End If

        Select Case atype
            Case BattlePlayerAction.ATYPE_MELEE
                DoMelee(target)
            Case BattlePlayerAction.ATYPE_RANGED
                DoRanged(target)
            Case BattlePlayerAction.ATYPE_BLOCK
                DoBlock()
            Case BattlePlayerAction.ATYPE_SPELL
                DoSpell(target, aextra, False)
            Case BattlePlayerAction.ATYPE_ITEM
                DoItem(target, aextra)
        End Select
    End Sub

    Private Sub DoMelee(ByRef target As BattleMember)
        Dim rand As New Random()
        Dim min As Integer = PBonusMinMelee
        If (min = 0) Then min = 1
        Dim max As Integer = PBonusMelee
        If (min > max) Then max = min
        Dim damage As Integer = rand.Next(min, max)

        damage += PSkillsDmgBonusDict(PEquippedRightType)
        If (PEquippedLeftType <> "") Then
            damage += PSkillsDmgBonusDict(PEquippedLeftType)
        End If

        damage = target.ApplyReductions(damage)
        target.MembHpCur -= damage

        battle.Log.AddAction(membID, MembName & " melee attacked " & target.MembName & " for " & damage & " damage!")
        If (target.IsDead()) Then
            battle.Log.AddAction(membID, target.MembName & " died.")
        End If
    End Sub

    Private Sub DoRanged(ByRef target As BattleMember)
        Dim rand As New Random()
        Dim min As Integer = PBonusMinRanged
        If (min = 0) Then min = 1
        Dim max As Integer = PBonusRanged
        If (min > max) Then max = min
        Dim damage As Integer = rand.Next(min, max)

        damage += PSkillsDmgBonusDict(PEquippedRangedType)

        damage = target.ApplyReductions(damage)
        target.MembHpCur -= damage

        battle.Log.AddAction(membID, MembName & " ranged attacked " & target.MembName & " for " & damage & " damage!")
        If (target.IsDead()) Then
            battle.Log.AddAction(membID, target.MembName & " died.")
        End If
    End Sub

    Private Sub DoBlock()
        PBlocks += 1
        battle.Log.AddAction(membID, MembName & " tried to block incoming damage.")
    End Sub

    Private Sub DoSpell(ByRef target As BattleMember, ByVal spellID As Integer, ByVal costless As Boolean)
        Dim spellQ = New SQLiteCommand("SELECT * FROM spells WHERE id=" & spellID, Common.sqLiteCon).ExecuteReader()
        If (Not spellQ.Read()) Then
            MsgBox("Member " & MembName & " casting non-existent spell # " & spellID & ", action ignored", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Dim cost = 0
        If (Not costless) Then
            cost = spellQ.Item("power_cost")
            Dim skill As String = spellQ.Item("skill")
            If (skill <> "" And skill <> "Non-elemental" And spellQ.Item("power_type") = 1) Then
                ' if it's an elemental spell, using mana, apply scalar
                cost = cost * CalcScalar(PSkillsBaseDict(skill), True)
            End If
        End If
        If (MembPowerCur < cost) Then
            MsgBox("Member " & MembName & " did not have enough power to cast spell # " & spellID & ". Spell not cast.", MsgBoxStyle.Exclamation, "Warning")
            battle.Log.AddAction(membID, MembName & " did not have enough power to cast spell " & spellQ.Item("name"))
            Return
        End If

        ' now: evaluate damage
        Dim damage As Integer = EvaluateFormula(spellQ.Item("damage_formula").ToString(), target)
        If (damage = Integer.MinValue) Then
            MsgBox("Error evaluating action performed by Member " & MembName & ", action ignored", MsgBoxStyle.Critical, "Error")
        End If
        If (spellQ.Item("is_healing") = 1) Then
            target.MembHpCur += damage
            battle.Log.AddAction(membID, MembName & " cast " & spellQ.Item("name") & " at " & target.MembName & ", healing them for " & damage & "!")
        Else
            damage = target.ApplyReductions(damage)
            target.MembHpCur -= damage
            battle.Log.AddAction(membID, MembName & " cast " & spellQ.Item("name") & " at " & target.MembName & " for " & damage & " damage!")
        End If
        MembPowerCur -= cost
        If (target.IsDead()) Then
            battle.Log.AddAction(membID, target.MembName & " died.")
            Return
        End If

        Dim spellEff As New BattleEffect(spellQ.Item("name"), spellQ.Item("eff_duration"), Me, target)
        spellEff.LoadFromDB(spellQ)
        If (Not spellEff.IsEmpty()) Then
            spellEff.Apply()
            battle.Log.AddAction(membID, target.MembName & " received the effect of " & spellEff.GetName())
            battle.Log.AddAction(membID, "Effect: " & Spells.GenerateSpellString(spellID))
        Else
            spellEff = Nothing
        End If
        If (spellQ.Item("custom_string") <> "") Then
            battle.Log.AddAction(membID, "Additional effects: " & spellQ.Item("custom_string"))
        End If

        spellQ.Close()
    End Sub

    Private Sub DoItem(ByRef target As BattleMember, ByVal itemID As Integer)
        ' assuming item is usable.
        Dim itemQ = New SQLiteCommand("SELECT name, use_duration, use_stat_str, use_stat_agi, use_stat_int, use_stat_wil, use_stat_end, use_skills, use_hp, use_maxhp, use_mana, use_maxmana, use_energy, use_maxenergy, use_melee, use_minmelee, use_ranged, use_minranged, use_magic, use_defense, use_custom FROM items WHERE id=" & itemID, Common.sqLiteCon).ExecuteReader()
        If (Not itemQ.Read()) Then
            MsgBox("Member " & MembName & " using non-existent item # " & itemID & ", action ignored", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim itemEff = New BattleEffect(itemQ.Item("name") & " Effect", itemQ.Item("use_duration"), Me, target)
        itemEff.LoadFromDB(itemQ)
        If (Not itemEff.IsEmpty()) Then
            itemEff.Apply()
            battle.Log.AddAction(membID, target.MembName & " was affected by " & itemEff.GetName() & ".")
            battle.Log.AddAction(membID, "Effect: " & Items.GenerateItemString(itemID))
        Else
            itemEff = Nothing
        End If
        If (itemQ.Item("use_custom") <> "") Then
            battle.Log.AddAction(membID, "Additional effects: " & itemQ.Item("use_custom"))
        End If

    End Sub

    ''' <summary>
    ''' Evaluates the specified formula using this player's stats, and the specified target's.
    ''' </summary>
    ''' <param name="formula">The formula</param>
    ''' <param name="target">The target to use during evaluation.</param>
    ''' <returns>What it evaluates to, accounting for random ranges.</returns>
    ''' <remarks></remarks>
    Public Function EvaluateFormula(ByVal formula As String, ByVal target As BattleMember) As Integer
        Dim rand As New Random()
        If (formula = "") Then Return 0
        ' first, detect if there's any kind of range (a | b)
        Dim rangeReg = New Regex("^(.+) *\| *(.+)$").Match(formula)
        If (rangeReg.Success) Then
            Dim value1 As Integer = ResolveToNumber(rangeReg.Groups(1).Value, target)
            Dim value2 As Integer = ResolveToNumber(rangeReg.Groups(2).Value, target)
            Dim minDamage, maxDamage As Integer
            minDamage = Math.Min(value1, value2)
            maxDamage = Math.Max(value1, value2)
            Return rand.Next(minDamage, maxDamage)
        Else
            Return ResolveToNumber(formula, target)
        End If
    End Function

    ''' <summary>
    ''' Resolves a non-range formula into a number based on this player's stats.
    ''' </summary>
    ''' <param name="rawFormula">The formula.</param>
    ''' <returns>The number resolved from the formula, or Integer.MinValue on error</returns>
    ''' <remarks></remarks>
    Public Function ResolveToNumber(ByVal rawFormula As String, ByVal target As BattleMember) As Integer
        ' STR, AGI, INT, WIL, END -> player stats
        ' LVL -> level
        ' (MAX_){ENERGY, HP, MANA}, (MIN_){MELEE, RANGED}, MAGIC, DEF -> ratings
        ' SKILL:skillname; -> player skill, eg SKILL:Unarmed Combat; would evaluate to the player's damage+ with unarmed combat skill
        ' t PREFIX means TARGET's stat.

        Dim PTarget As BattlePlayer = Nothing
        If (target.IsPlayer()) Then
            PTarget = DirectCast(target, BattlePlayer)
        End If
        Dim tokens As New Dictionary(Of String, Integer)
        With (tokens)
            If (PTarget IsNot Nothing) Then
                .Add("tSTR", PTarget.PStat(STAT_STR))
                .Add("tAGI", PTarget.PStat(STAT_AGI))
                .Add("tINT", PTarget.PStat(STAT_INT))
                .Add("tWIL", PTarget.PStat(STAT_WIL))
                .Add("tEND", PTarget.PStat(STAT_END))
                .Add("tMAX_ENERGY", IIf(PTarget.PPowerType = "Energy", PTarget.MembPowerMax, 0))
                .Add("tMAX_MANA", IIf(PTarget.PPowerType = "Mana", PTarget.MembPowerMax, 0))
                .Add("tENERGY", IIf(PTarget.PPowerType = "Energy", PTarget.MembPowerCur, 0))
                .Add("tMANA", IIf(PTarget.PPowerType = "Mana", PTarget.MembPowerCur, 0))
                .Add("tMIN_MELEE", PTarget.PBonusMinMelee)
                .Add("tMIN_RANGED", PTarget.PBonusMinRanged)
                .Add("tMELEE", PTarget.PBonusMelee)
                .Add("tRANGED", PTarget.PBonusRanged)
                .Add("tMAGIC", PTarget.PBonusMagic)
                .Add("tDEF", PTarget.PDefense)
            End If

            .Add("tHP", target.MembHpCur)
            .Add("tMAX_HP", target.MembHpMax)
            .Add("tLVL", target.MembLevel)

            .Add("STR", PStat(STAT_STR))
            .Add("AGI", PStat(STAT_AGI))
            .Add("INT", PStat(STAT_INT))
            .Add("WIL", PStat(STAT_WIL))
            .Add("END", PStat(STAT_END))
            .Add("LVL", MembLevel)
            .Add("MAX_ENERGY", IIf(PPowerType = "Energy", MembPowerMax, 0))
            .Add("MAX_HP", MembHpMax)
            .Add("MAX_MANA", IIf(PPowerType = "Mana", MembPowerMax, 0))
            .Add("ENERGY", IIf(PPowerType = "Energy", MembPowerCur, 0))
            .Add("HP", MembHpCur)
            .Add("MANA", IIf(PPowerType = "Mana", MembPowerCur, 0))
            .Add("MIN_MELEE", PBonusMinMelee)
            .Add("MIN_RANGED", PBonusMinRanged)
            .Add("MELEE", PBonusMelee)
            .Add("RANGED", PBonusRanged)
            .Add("MAGIC", PBonusMagic)
            .Add("DEF", PDefense)
        End With

        Dim formula As String = rawFormula
        For Each p As KeyValuePair(Of String, Integer) In tokens
            Common.HardReplace(formula, p.Key, p.Value)
        Next

        ' now: skills
        Dim skillsReg As New Regex("(t?)SKILL:(.+?);")
        Dim isMatch As Boolean = skillsReg.IsMatch(formula)
        While (isMatch)
            Dim match As Match = skillsReg.Match(formula)
            Dim skillName As String = match.Groups(2).Value
            Dim skillV = 0
            If (PTarget IsNot Nothing And match.Groups(1).Value = "t") Then
                skillV = PTarget.PSkillsDmgBonusDict(skillName)
            Else
                skillV = PSkillsDmgBonusDict(skillName)
            End If
            If (SkillsListView.IsSkill(skillName)) Then
                formula = formula.Insert(match.Groups(0).Index, skillV.ToString())
                formula = formula.Remove(match.Groups(0).Index + (skillV.ToString().Length), match.Groups(0).Length)
            Else
                Return Integer.MinValue
            End If
            isMatch = skillsReg.IsMatch(formula)
        End While

        Try
            Dim a As New DataTable()
            Dim res As Integer = a.Compute(formula, Nothing)
            Return res
        Catch
            Return Integer.MinValue
        End Try

    End Function

End Class
