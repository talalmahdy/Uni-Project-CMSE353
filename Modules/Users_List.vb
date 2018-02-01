Public Class Users_List
    Dim password As String
    Dim password2 As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TermprojectDataSet.Users' table. You can move, or remove it, as needed.

        Me.AccessTableAdapter1.Fill(Me.ProjectDataSet1.ACCESS)
        If (Login.admin) Then
            delete.Enabled = True
            Me.UsersTableAdapter1.Fillexcept(Me.ProjectDataSet1.Users, Login.userid)
        Else
            delete.Enabled = False
            Me.UsersTableAdapter1.FillBynotadmin(Me.ProjectDataSet1.Users, Login.userid)

        End If
        If (UsersList.Items.Count = 0) Then
            delete.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        Else
            If (Login.admin) Then
                delete.Enabled = True
            End If
            TextBox1.Enabled = True
                TextBox2.Enabled = True
            End If
            AccessTableAdapter1.Fill(ProjectDataSet1.ACCESS)
        If (UsersList.Items.Count = 0) Then
            Exit Sub
        End If

        If (CheckBox1.Checked = False) Then
            Dim anyname() As DataRow = ProjectDataSet1.ACCESS.Select("ID=" + UsersList.SelectedValue.ToString)
            If (anyname.Count <> 0) Then
                CheckBox2.Checked = anyname(0).Item("Users_e")

                CheckBox3.Checked = anyname(0).Item("Images")

                CheckBox4.Checked = anyname(0).Item("Notes")
            End If
        End If
        TextBox1.Text = TextBox1.Text.Replace(" ", "")
        password = TextBox2.Text
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addnew.Click
        Add_New_user.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (Add_New_user.Visible = False) Then
            User_Options.WindowState = FormWindowState.Normal
            User_Options.Activate()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (UsersList.Items.Count = 0) Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Exit Sub
        End If
        'UsersBindingSource.EndEdit()
        If (CheckBox1.Checked = False) Then

            If (ProjectDataSet1.ACCESS.Select("ID='" + UsersList.SelectedValue.ToString + "'").Count = 0) Then

                AccessTableAdapter1.Insert(UsersList.SelectedValue, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked)
            Else
                AccessTableAdapter1.Updatebyid(CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, UsersList.SelectedValue)
            End If
            AccessTableAdapter1.Fill(ProjectDataSet1.ACCESS)

        Else
            AccessTableAdapter1.DeleteQuery(UsersList.SelectedValue)
            AccessTableAdapter1.Fill(ProjectDataSet1.ACCESS)
        End If
        If (TextBox2.Text = password2) Then
            UsersTableAdapter1.UpdateQuery(TextBox1.Text, TextBox2.Text, Date.Now, CheckBox1.Checked, UsersList.SelectedValue)
        Else
            UsersTableAdapter1.UpdateQuery(TextBox1.Text, Login.seperatedenc(TextBox2.Text), Date.Now, CheckBox1.Checked, UsersList.SelectedValue)
        End If

        If (Login.admin) Then
            UsersTableAdapter1.Fillexcept(ProjectDataSet1.Users, Login.userid)
        Else
            UsersTableAdapter1.FillBynotadmin(ProjectDataSet1.Users, Login.userid)

        End If
        Button2.Visible = False
        Button1.Visible = True
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete.Click
        AccessTableAdapter1.DeleteQuery(UsersList.SelectedValue)
        UsersTableAdapter1.deleteuser(UsersList.SelectedValue)
        If (Login.admin) Then
            UsersTableAdapter1.Fillexcept(ProjectDataSet1.Users, Login.userid)
        Else
            UsersTableAdapter1.FillBynotadmin(ProjectDataSet1.Users, Login.userid)

        End If
        If (UsersList.Items.Count = 0) Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            delete.Enabled = False
        End If
        TextBox1.Text = TextBox1.Text.Replace(" ", "")
    End Sub


    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Login.admin) Then
            If (CheckBox1.Checked = False And CheckBox1.Enabled) Then
                CheckBox2.Enabled = True
                CheckBox3.Enabled = True
                CheckBox4.Enabled = True

            Else
                CheckBox2.Enabled = False
                CheckBox3.Enabled = False
                CheckBox4.Enabled = False
            End If
        Else
            If (CheckBox1.Checked = False And CheckBox1.Enabled) Then
                CheckBox2.Enabled = False
                CheckBox3.Enabled = True
                CheckBox4.Enabled = True

            Else
                CheckBox2.Enabled = False
                CheckBox3.Enabled = False
                CheckBox4.Enabled = False
            End If
        End If

    End Sub

    Private Sub UsersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsersList.SelectedValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        If Not TextBox2.ReadOnly Then
            TextBox2.Text = ""
        End If


    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If (TextBox2.Text = "") Then
            TextBox2.Text = password
        Else
            password = TextBox2.Text
        End If
    End Sub

    Private Sub UsersList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles UsersList.SelectedIndexChanged
        On Error GoTo endchange
        password = TextBox2.Text
        Button2.Visible = False
        Button1.Visible = True
        If (Login.admin) Then
            If (CheckBox1.Checked = False) Then
                Dim anyname() As DataRow = ProjectDataSet1.ACCESS.Select("ID=" + UsersList.SelectedValue.ToString)
                If (anyname.Count = 0) Then
                    Exit Sub
                End If

                If (anyname.Count <> 0) Then
                    CheckBox2.Checked = anyname(0).Item("Users_e")

                    CheckBox3.Checked = anyname(0).Item("Images")

                    CheckBox4.Checked = anyname(0).Item("Notes")
                End If
            Else
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
            End If
        Else
            If (CheckBox1.Checked = False) Then
                Dim anyname() As DataRow = ProjectDataSet1.ACCESS.Select("ID=" + UsersList.SelectedValue.ToString)
                If (anyname.Count = 0) Then
                    Exit Sub
                End If
                If (anyname.Count <> 0) Then
                    CheckBox2.Checked = anyname(0).Item("Users_e")

                    CheckBox3.Checked = anyname(0).Item("Images")

                    CheckBox4.Checked = anyname(0).Item("Notes")
                End If
            Else
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
            End If
        End If

        TextBox1.Text = TextBox1.Text.Replace(" ", "")
endchange:
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        Button1.Visible = False
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        If (Login.admin) Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        Else
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        End If
        password2 = TextBox2.Text
    End Sub


End Class