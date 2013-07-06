'Public Class BattleCustomEvent
'    Inherits DBInputForm

'    Private btl As Battle
'    Private RBS_isBefore As RadioButtonSet

'    Public Shared Function open(ByRef btl As Battle) As BattleCustomEvent
'        Dim m As New BattleCustomEvent(btl)
'        m.Show()
'        Return m
'    End Function

'    Public Sub New(ByRef btl As Battle)
'        ' This call is required by the designer.
'        InitializeComponent()
'        Me.btl = btl
'        RBS_isBefore = New RadioButtonSet()
'        RBS_isBefore.Add(RBN_After, 0)
'        RBS_isBefore.Add(RBN_Before, 1)

'        SetTableName("battle_events")
'        AssocField("!NameList", CBX_Names)
'        AssocField("id", TBX_ID)
'        AssocField("battle_id", TBX_BID)
'        AssocField("name", TBX_Name)
'        AssocField("isBefore", RBS_isBefore)
'        AssocField("event", TBX_Text)

'        TBX_BID.Text = btl.GetID().ToString()

'    End Sub

'    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_OK.Click
'        SaveContent(True)
'        Me.Close()
'    End Sub

'    'Private Sub BattleCustomEvent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
'    '    btl.eventsWindow = Nothing
'    'End Sub

'    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        'populate drop down
'        Dim CBNAMES As ComboBox = CType(GetAssocControl("!NameList"), ComboBox)
'        AddHandler CBNAMES.SelectedIndexChanged, AddressOf DBInputForm_HandleNameListChange
'        Dim nameListQ = New SQLite.SQLiteCommand("SELECT name FROM 'battle_events' WHERE battle_id=" & btl.GetID(), Common.sqLiteCon).ExecuteReader()
'        While (nameListQ.Read())
'            CBNAMES.Items.Add(nameListQ.Item(0))
'        End While
'        If (CBNAMES.Items.Count > 0) Then
'            CBNAMES.SelectedIndex = 0
'        End If
'        nameListQ.Close()
'        'end populate drop down
'    End Sub

'    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        SaveContent()
'    End Sub

'    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
'        AddNew()
'        TBX_BID.Text = btl.GetID().ToString()

'        Dim count As Integer = New SQLite.SQLiteCommand("SELECT COUNT(id) FROM battle_events WHERE battle_id=" & btl.GetID(), Common.sqLiteCon).ExecuteScalar()
'        TBX_Name.Text = "Battle_" & btl.GetID() & "_" & IIf(RBS_isBefore.GetSelectedValue() = 1, "Before", "After") & " " & (count + 1)
'        SaveContent(True)
'    End Sub

'    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
'        DeleteEntry()
'        TBX_BID.Text = btl.GetID().ToString()
'    End Sub

'    Private Sub RBN_CheckedChanged() Handles RBN_After.CheckedChanged, RBN_Before.CheckedChanged
'        If (TBX_Name.Text.Contains("After") And RBN_Before.Checked) Then
'            TBX_Name.Text = CBX_Names.SelectedItem.Replace("After", "Before")
'        ElseIf (TBX_Name.Text.Contains("Before") And RBN_After.Checked) Then
'            TBX_Name.Text = CBX_Names.SelectedItem.Replace("Before", "After")
'        End If
'        SaveContent(True)
'    End Sub

'    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
'        Me.Close()
'    End Sub
'End Class