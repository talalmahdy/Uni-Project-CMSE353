Public Class Add_New_user
    Dim userid As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adds As String = "INSERT INTO Users ( User_Name, Password, Date_Created, Last_Update) VALUES(@UName,@Password,@DC,@LM)"

        If (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            'UsersTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, Date.Now, Date.Now)
            If (UsersTableAdapter1.checkname(TextBox1.Text)) Then
                MsgBox("name is already taken")
                Exit Sub
            End If
            Dim now As Date = Date.Now
            UsersTableAdapter1.Insert(TextBox1.Text, Login.seperatedenc(TextBox2.Text), now, now, CheckBox1.Checked)
            If (CheckBox1.Checked <> True) Then

                UsersTableAdapter1.Fill(ProjectDataSet1.Users)
                Dim intid() As DataRow = ProjectDataSet1.Users.Select("User_Name='" + TextBox1.Text + "'")

                AccessTableAdapter1.Insert(intid(0).Item("ID"), CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked)

            End If

            Users_List.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Users_List.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False

        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True

        End If
    End Sub

    Private Sub Add_New_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Login.admin) Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        Else
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        End If
    End Sub
End Class