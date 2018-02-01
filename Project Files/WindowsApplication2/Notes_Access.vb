Public Class Notes_Access
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usersh As New PROJECTDataSet.UsersDataTable
        If (ComboBox2.SelectedIndex <> -1 And ComboBox1.SelectedIndex <> -1) Then

            Notes_AccessTableAdapter1.Fillbyid(ProjectDataSet1.Notes_Access, ComboBox2.SelectedValue)
            If (ProjectDataSet1.Notes_Access.Count <> 0) Then
                Notes_AccessTableAdapter1.UpdateQuery(CheckBox1.Checked, ComboBox1.SelectedValue, ComboBox2.SelectedValue)

            Else
                Notes_AccessTableAdapter1.Insert(ComboBox1.SelectedValue, ComboBox2.SelectedValue, CheckBox1.Checked)
            End If
        Else
            MsgBox("check Your Inputs")
            Exit Sub
        End If
        Me.Close()

    End Sub

    Private Sub Notes_Access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
        ProjectDataSet1.Users.AdminColumn.AllowDBNull = True
        ProjectDataSet1.Users.Date_CreatedColumn.AllowDBNull = True
        ProjectDataSet1.Users.Last_UpdateColumn.AllowDBNull = True
        ProjectDataSet1.Users.PasswordColumn.AllowDBNull = True
        UsersTableAdapter1.Fillnameidexept(ProjectDataSet1.Users, Login.userid)
        ToolTip1.SetToolTip(CheckBox1, "if checked user can modify note")
    End Sub
End Class