Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class Common
#If CONFIG = "Release" Then
    Public Shared ReadOnly sqLiteCon As New SQLiteConnection("Data Source = MediDB.sqlite;")
#Else
    Public Shared ReadOnly sqLiteCon As New SQLiteConnection("Data Source = ../../MediDB.sqlite;")
#End If

    Public Shared Function GetControlByName(ByVal parent As Control, ByVal name As String) As Control
        For Each tempCtrl As Control In parent.Controls()
            If (tempCtrl.Name = name) Then
                Return tempCtrl
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function CountOccurancesOf(ByVal containerObject As Object, ByVal value As Object) As Integer
        Dim count As Integer = 0
        Try
            For Each obj In containerObject
                If (obj.Equals(value)) Then
                    count += 1
                End If
            Next
        Catch
            Return 0
        End Try
        Return count
    End Function

    Public Shared Sub RemoveLastChars(ByRef str As String, ByVal amt As UInteger)
        str = str.Remove(str.Length - amt, amt)
    End Sub

    Public Shared Sub HardReplace(ByRef str As String, ByVal search As String, ByVal replace As String)
        str = str.Replace(search, replace)
    End Sub

    Public Shared Function AddCommaSepIntString(ByVal s1 As String, ByVal s2 As String) As String
        Dim retString As String = ""
        Dim s1a As String() = s1.Split(",")
        Dim s2a As String() = s2.Split(",")
        For i As Integer = 0 To Math.Min(s1a.Length, s2a.Length) - 1
            Dim v1 = Integer.Parse(s1a(i))
            Dim v2 = Integer.Parse(s2a(i))
            retString &= (v1 + v2) & ","
        Next
        RemoveLastChars(retString, 1)
        Return retString
    End Function

    ''' <summary>
    ''' Checks all of the formulae stored in the list of text boxes.
    ''' </summary>
    ''' <param name="list">The list of textboxes</param>
    ''' <returns>Nothing on success, or the textbox that failed validation on failure.</returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ValidateFormula(ByVal list As IEnumerable(Of TextBox)) As TextBox
        For Each tbx As TextBox In list
            If (tbx.Text = "") Then Continue For
            If (ValidateFormula(tbx.Text) = False) Then
                Return tbx
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Validates a formula, indicating if it is valid or not.
    ''' </summary>
    ''' <param name="formula">The formula to check</param>
    ''' <returns>Returns true if the formula is valid, false otherwise.</returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ValidateFormula(ByVal formula As String) As Boolean
        ' first, detect if there's any kind of range (a | b)
        Dim rangeReg = New Regex("^(.+) *\| *(.+)$").Match(formula)
        If (rangeReg.Success) Then
            Dim subFormula1 As String = rangeReg.Groups(1).Value
            Dim subFormula2 As String = rangeReg.Groups(2).Value
            Return (CanResolveToNumber(subFormula1) And CanResolveToNumber(subFormula2))
        Else
            Return CanResolveToNumber(formula)
        End If
    End Function

    ''' <summary>
    ''' Checks if the given formula can be resolved to a single number. No ranges allowed.
    ''' </summary>
    ''' <param name="rawFormula">The rangeless formula</param>
    ''' <returns>True if can be resolved to a number, false otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function CanResolveToNumber(ByVal rawFormula As String) As Boolean
        ' STR, AGI, INT, WIL, END -> player stats
        ' LVL -> level
        ' (MAX_){ENERGY, HP, MANA}, (MIN_){MELEE, RANGED}, MAGIC, DEF -> ratings
        ' SKILL:skillname; -> player skill, eg SKILL:Unarmed Combat; would evaluate to the player's damage+ with unarmed combat skill
        Dim tokens As New List(Of String)
        With (tokens)
            .Add("tSTR")
            .Add("tAGI")
            .Add("tINT")
            .Add("tWIL")
            .Add("tEND")
            .Add("tLVL")
            .Add("tMAX_ENERGY")
            .Add("tMAX_HP")
            .Add("tMAX_MANA")
            .Add("tENERGY")
            .Add("tHP")
            .Add("tMANA")
            .Add("tMIN_MELEE")
            .Add("tMIN_RANGED")
            .Add("tMELEE")
            .Add("tRANGED")
            .Add("tMAGIC")
            .Add("tDEF")

            .Add("STR")
            .Add("AGI")
            .Add("INT")
            .Add("WIL")
            .Add("END")
            .Add("LVL")
            .Add("MAX_ENERGY")
            .Add("MAX_HP")
            .Add("MAX_MANA")
            .Add("ENERGY")
            .Add("HP")
            .Add("MANA")
            .Add("MIN_MELEE")
            .Add("MIN_RANGED")
            .Add("MELEE")
            .Add("RANGED")
            .Add("MAGIC")
            .Add("DEF")
        End With

        ' how we work this: we replace all those tokens above with the magic number, 5.
        ' if our thingo can evaluate the resulting expression to a plain number, it must be valid!
        Dim formula As String = rawFormula
        For i As Integer = 0 To tokens.Count - 1
            HardReplace(formula, tokens.Item(i), "5")
        Next

        ' now: skills
        Dim skillsReg As New Regex("t?SKILL:(.+?);")
        Dim isMatch As Boolean = skillsReg.IsMatch(formula)
        While (isMatch)
            Dim match As Match = skillsReg.Match(formula)
            If (SkillsListView.IsSkill(Match.Groups(1).Value)) Then
                formula = formula.Insert(Match.Groups(0).Index, "5")
                formula = formula.Remove(Match.Groups(0).Index + 1, Match.Groups(0).Length)
            Else
                Exit While
            End If
            isMatch = skillsReg.IsMatch(formula)
        End While

        Try
            Dim a As New DataTable()
            a.Compute(formula, Nothing)
            Return True
        Catch
            Return False
        End Try

    End Function

    Public Shared Function ToTitle(ByVal s As String) As String
        Dim c() As Char = s.ToLower().ToCharArray()
        c(0) = c(0).ToString().ToUpper()
        For i As Integer = 1 To s.Length - 1
            If (c(i) = " " And i + 1 <= s.Length - 1) Then
                c(i + 1) = c(i + 1).ToString().ToUpper()
            End If
        Next
        Return String.Join("", c)
    End Function

    ''' <summary>
    ''' Turns a list into a comma separated string.
    ''' </summary>
    ''' <param name="list">An iterable list object</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ListToCommaSep(ByVal list As IEnumerable) As String
        Dim ret As String = ""
        For Each o As Object In list
            ret &= o.ToString() & ","
        Next
        If (ret.Length > 1) Then
            Common.RemoveLastChars(ret, 1)
        End If
        Return ret
    End Function

    ''' <summary>
    ''' Turns a dictionary's values into a comma separated string.
    ''' </summary>
    ''' <param name="list">A dictionary</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ListToCommaSep(ByVal list As IDictionary) As String
        Dim ret As String = ""
        For Each o As DictionaryEntry In list
            ret &= o.Value.ToString() & ","
        Next
        If (ret.Length > 1) Then
            Common.RemoveLastChars(ret, 1)
        End If
        Return ret
    End Function

    ''' <summary>
    ''' Returns true if the strings provided match the parameters of a typical HP-like value set:
    ''' (cur >= 0 And max >= 0 And max >= cur)
    ''' </summary>
    ''' <param name="sCur">"Current" HP-like value, as a string.</param>
    ''' <param name="sMax">"Maximum" HP-like value, as a string.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ValidateHPLikeField(ByVal sCur As String, ByVal sMax As String) As Boolean
        Dim cur, max As Integer

        If (Not Integer.TryParse(sCur, cur) Or Not Integer.TryParse(sMax, max)) Then
            Return False
        End If

        If (Not (cur >= 0 And max >= 0 And max >= cur)) Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Returns 1 if 0 is passed, or 0 otherwise.
    ''' </summary>
    ''' <param name="tID">Number to compare against</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function OtherTeam(ByVal tID As Byte) As Byte
        If (tID = 0) Then Return 1 Else Return 0
    End Function

    ''' <summary>
    ''' Combines an arbitrary number of lists into a new list.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="lists">A variable number of lists of the same type to combine.</param>
    ''' <returns>The new, combined list.</returns>
    ''' <remarks></remarks>
    Public Shared Function CombineLists(Of T)(ByVal ParamArray lists() As List(Of T)) As List(Of T)
        Dim ret As New List(Of T)
        For i = 0 To lists.Length - 1
            For Each o As T In lists(i)
                ret.Add(o)
            Next
        Next
        Return ret
    End Function

End Class
