Public Class BattlePlayerEdit
    Inherits DBInputForm

    Private player As BattlePlayer
    Public Shared openEdits As New List(Of BattlePlayer)
    Public effectEdit As BattlePlayerEditEffects = Nothing

    ''' <summary>
    ''' Provides interface for directly editing a player.
    ''' Does nothing if player to edit is already being edited.
    ''' </summary>
    ''' <param name="player">The BattlePlayer who will be edited.</param>
    ''' <remarks></remarks>
    Public Shared Sub open(ByRef player As BattlePlayer)
        If (openEdits.Contains(player)) Then
            Return
        End If
        openEdits.Add(player)
        Dim p As New BattlePlayerEdit(player)
        p.Show()
    End Sub

    Public Function GetPlayer() As BattlePlayer
        Return player
    End Function


    Private Sub New(ByRef player As BattlePlayer)
        InitializeComponent()
        Me.player = player

        SetTableName("battle_members")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("battle_id", Nothing)
        AssocField("team_id", Nothing)
        AssocField("player_id", Nothing)
        AssocField("name", TBX_Name)
        AssocField("MembLevel", TBX_Level)
        AssocField("MembHpCur", TBX_HPCur)
        AssocField("MembHpMax", TBX_HP)
        AssocField("MembPowerCur", TBX_PowCur)
        AssocField("MembPowerMax", TBX_Pow)
        AssocField("skillsbase", SLV_BaseSkills)
        AssocField("stat0", NUD_Str)
        AssocField("stat1", NUD_Agi)
        AssocField("stat2", NUD_Int)
        AssocField("stat3", NUD_Wil)
        AssocField("stat4", NUD_End)
        AssocField("skillsdmgbonus", SLV_DmgExtraSkills)
        AssocField("powertype", Nothing)
        AssocField("attacktype", Nothing)
        AssocField("bonusmelee", NUD_Melee)
        AssocField("bonusminmelee", NUD_MinMelee)
        AssocField("bonusranged", NUD_Ranged)
        AssocField("bonusminranged", NUD_MinRanged)
        AssocField("bonusmagic", NUD_Magic)
        AssocField("defense", NUD_Defense)
        AssocField("spells", Nothing)
        AssocField("items", Nothing)
        AssocField("color", Nothing)
        AssocField("leftequiptype", Nothing)
        AssocField("rightequiptype", Nothing)
        AssocField("rangedequiptype", Nothing)
        AssocField("blocks", Nothing)
    End Sub

    Private Sub BattlePlayerEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBInputForm_Load()
    End Sub

    Private Sub BTN_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_OK.Click
        'validate HP and power as usual
        If (Not Common.ValidateHPLikeField(TBX_HPCur.Text, TBX_HP.Text) Or Not Common.ValidateHPLikeField(TBX_PowCur.Text, TBX_Pow.Text)) Then
            MsgBox("Invalid HP/Power values", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        SaveContent() 'to database
        player.ReloadInfoFromDB()
        Me.Close()
    End Sub

    Public Sub ReloadData()
        Dim fieldQ = New SQLite.SQLiteCommand("SELECT * FROM 'battle_members' WHERE id = " & player.GetID(), Common.sqLiteCon)
        Dim fieldQuery = fieldQ.ExecuteReader()
        fieldQuery.Read()
        For col As Integer = 0 To fieldQuery.FieldCount - 1
            '######### we know everything is handled, this is not the general case.
            'If (Not fieldControls.ContainsKey(fieldQuery.GetName(col))) Then
            'MsgBox("Field '" & fieldQuery.GetName(col) & "' not handled in '" & tableName & "' form", MsgBoxStyle.Exclamation)
            'Continue For
            'End If
            Dim fieldCtrl As Control = GetAssocControl(fieldQuery.GetName(col))
            SetControlValue(fieldCtrl, fieldQuery.GetValue(col))
        Next
        fieldQuery.Close()
    End Sub

    Protected Overrides Sub DBInputForm_HandleNameListChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Unfortunately we need a bit more direct control here. Not a completely standard DBInputForm.
        'populate form
        ReloadData()
        'end populate form
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        If (MsgBox("Are you sure you want to delete this player from the battle?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirm action") = MsgBoxResult.Yes) Then
            player.GetBattle().DeleteMember(player.GetID())
            Me.Close()
        End If
    End Sub

    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BTN_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Reset.Click
        player.LoadDefaultInfo()
        player.Save()
        DBInputForm_HandleNameListChange(Nothing, Nothing)
    End Sub

    Private Sub MeClosing() Handles Me.FormClosed
        openEdits.Remove(player)
    End Sub

    Private Sub BTN_Effects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Effects.Click
        If (effectEdit Is Nothing) Then
            effectEdit = BattlePlayerEditEffects.open(Me)
        End If
    End Sub
End Class