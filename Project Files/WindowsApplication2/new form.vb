Public Class new_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim now As Date = Date.Now
        NotesTableAdapter1.Insert(Login.userid, TextBox1.Text, TextBox2.Text, now)
        If (Login.admin) Then
            NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
        Else
            NotesTableAdapter1.FillByid2(ProjectDataSet1.Notes, Login.userid)
        End If

        Dim row1() As DataRow = ProjectDataSet1.Notes.Select("ID='" + Login.userid.ToString + "' and Note_Title='" + TextBox1.Text + "'")
        Notes_AccessTableAdapter1.Insert(row1(0).Item("Note_ID"), Login.userid, True)
        Me.Close()
    End Sub

    Private Sub new_form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Notes.Show()
    End Sub

    Private Sub new_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim passy As String = InputBox("Enter Password", "Password", "")
        If passy = "" Then
            MsgBox("no password entered")

            Exit Sub
        End If
        Dim now As Date = Date.Now
        NotesTableAdapter1.Insert(Login.userid, TextBox1.Text, Login.seperatedenc_withpassword(TextBox2.Text, passy), now)
        If (Login.admin) Then
            NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
        Else
            NotesTableAdapter1.FillByid2(ProjectDataSet1.Notes, Login.userid)
        End If
        Dim row1() As DataRow = ProjectDataSet1.Notes.Select("ID='" + Login.userid.ToString + "' and Note_Title='" + TextBox1.Text + "'")
        Notes_AccessTableAdapter1.Insert(row1(0).Item("Note_ID"), Login.userid, True)
        Me.Close()
    End Sub
End Class