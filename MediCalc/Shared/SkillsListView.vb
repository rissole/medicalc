''' <summary>
''' A class that represents a special ListView containing MediCalc skills.
''' Also contains helper shared methods related to skills.
''' </summary>
''' <remarks></remarks>
Public Class SkillsListView

    Private Shared ReadOnly WEAPON_SKILLS As New List(Of String)({
                                                                    "Unarmed Combat",
                                                                    "Daggers and Knives",
                                                                    "Swords and Claymores",
                                                                    "Axes",
                                                                    "Hammers",
                                                                    "Staves",
                                                                    "Wands",
                                                                    "Polearms and Spears",
                                                                    "Bows",
                                                                    "Crossbows",
                                                                    "Thrown"
                                                                 })

    Private Shared ReadOnly ARMOR_SKILLS As New List(Of String)({
                                                                    "Unarmored",
                                                                    "Cloth",
                                                                    "Leather",
                                                                    "Chainmail",
                                                                    "Plate",
                                                                    "Shields"
                                                                 })

    Private Shared ReadOnly MAGIC_SKILLS As New List(Of String)({
                                                                    "Arcane",
                                                                    "Fire",
                                                                    "Water",
                                                                    "Wind/Air",
                                                                    "Electrical/Shock",
                                                                    "Stone/Earth",
                                                                    "Nature",
                                                                    "Light",
                                                                    "Shadow"
                                                                 })

    Private Shared SKILLS As New List(Of String)(Common.CombineLists(WEAPON_SKILLS, ARMOR_SKILLS, MAGIC_SKILLS))

    ''' <summary>
    ''' Set to true if you would like the values of this SkillsListView to be editable.
    ''' </summary>
    ''' <value>Indicates whether this SkillsListView can be edited.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Editable() As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' initialise InnerLVW, and SKILLS
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("Weapons", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As ListViewGroup = New ListViewGroup("Armor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As ListViewGroup = New ListViewGroup("Magic", System.Windows.Forms.HorizontalAlignment.Left)
        ListViewGroup1.Header = "Weapons"
        ListViewGroup1.Name = "Weapons"
        ListViewGroup2.Header = "Armor"
        ListViewGroup2.Name = "Armor"
        ListViewGroup3.Header = "Magic"
        ListViewGroup3.Name = "Magic"
        InnerLVW.Groups.AddRange(New ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})

        For i As Integer = 0 To WEAPON_SKILLS.Count - 1
            Dim LVWItem As ListViewItem = New ListViewItem(New String() {WEAPON_SKILLS(i), "0"}, -1)
            LVWItem.Group = ListViewGroup1
            InnerLVW.Items.Add(LVWItem)
        Next
        For i As Integer = 0 To ARMOR_SKILLS.Count - 1
            Dim LVWItem As ListViewItem = New ListViewItem(New String() {ARMOR_SKILLS(i), "0"}, -1)
            LVWItem.Group = ListViewGroup2
            InnerLVW.Items.Add(LVWItem)
        Next
        For i As Integer = 0 To MAGIC_SKILLS.Count - 1
            Dim LVWItem As ListViewItem = New ListViewItem(New String() {MAGIC_SKILLS(i), "0"}, -1)
            LVWItem.Group = ListViewGroup3
            InnerLVW.Items.Add(LVWItem)
        Next
        ' end that stuff

    End Sub

    ''' <summary>
    ''' Gets the number of skills in the game.
    ''' </summary>
    ''' <returns>The total number of skills.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetSkillsCount() As Integer
        Return SKILLS.Count
    End Function

    Public Shared Function GetWeaponSkillsCount() As Integer
        Return WEAPON_SKILLS.Count
    End Function

    Public Shared Function GetArmorSkillsCount() As Integer
        Return ARMOR_SKILLS.Count
    End Function

    Public Shared Function GetMagicSkillsCount() As Integer
        Return MAGIC_SKILLS.Count
    End Function

    ''' <summary>
    ''' Gets the name of a skill for the specified index.
    ''' </summary>
    ''' <param name="index">Skill index.</param>
    ''' <returns>The skill name for the specified index.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetSkillName(ByVal index As Integer) As String
        Return SKILLS(index)
    End Function

    ''' <summary>
    ''' Checks that the specified skill name is a real skill.
    ''' </summary>
    ''' <param name="name">The name to check</param>
    ''' <returns>True if a valid skill, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function IsSkill(ByVal name As String) As Boolean
        Return SKILLS.Contains(name)
    End Function

    ''' <summary>
    ''' Gets the values of the skills in this SkillsListView.
    ''' </summary>
    ''' <returns>A comma separated string containing the values of the SkillsListView.</returns>
    ''' <remarks></remarks>
    Public Function GetValues() As String
        Dim retString As String = ""
        For i As Integer = 0 To InnerLVW.Items.Count - 1
            retString &= InnerLVW.Items(i).SubItems(1).Text & ","
        Next
        Common.RemoveLastChars(retString, 1)
        Return retString
    End Function

    Public Overloads Function GetValue(ByVal skillName As String) As Integer
        For i As Integer = 0 To InnerLVW.Items.Count - 1
            If (InnerLVW.Items(i).SubItems(0).Text = skillName) Then
                Return Integer.Parse(InnerLVW.Items(i).SubItems(1).Text)
            End If
        Next
        Return -1
    End Function

    Public Overloads Function GetValue(ByVal skillIndex As Integer) As Integer
        Return Integer.Parse(InnerLVW.Items(skillIndex).SubItems(1).Text)
    End Function

    ''' <summary>
    ''' Sets the values of the SkillsListView
    ''' </summary>
    ''' <param name="values">A comma separated string containing each skill's value.</param>
    ''' <remarks>Throws an exception if the string specified is invalid</remarks>
    Public Sub SetValues(ByVal values As String)
        Dim valArray As String() = values.Split(",")
        If (valArray.Length <> InnerLVW.Items.Count) Then
            Throw New Exception("Count mismatch during SetValues on SkillsListView (got " & valArray.Length & ", expected " & InnerLVW.Items.Count & ")")
        End If
        For i As Integer = 0 To InnerLVW.Items.Count - 1
            InnerLVW.Items(i).SubItems(1).Text = valArray(i)
        Next
    End Sub

    Private Sub LVW_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles InnerLVW.MouseDoubleClick
        If (Editable And InnerLVW.SelectedIndices.Count > 0) Then
            SimpleInput.open(InnerLVW.Items(InnerLVW.SelectedIndices(0)).SubItems(1), "#0999")
        End If
    End Sub

    Private Sub ScaleInnerLVW(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        InnerLVW.Width = Width
        InnerLVW.Height = Height
    End Sub

End Class
