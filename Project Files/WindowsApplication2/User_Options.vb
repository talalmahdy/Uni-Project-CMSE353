Public Class User_Options
    Dim state(4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        If (Login.Visible = False) Then
            Login.Close()
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles User_List_B.Click
        Me.WindowState = FormWindowState.Minimized
        Users_List.Show()
        Users_List.Activate()
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip2.SetToolTip(User_List_B, "creating Editing Users" + Environment.NewLine + "adding,removing previlige")
        ToolTip3.SetToolTip(Button4, "change your account password")
        ToolTip4.SetToolTip(Notes_Button, "creating Editing Notes")
        ToolTip1.SetToolTip(Button1, "sign out")
        ToolTip5.SetToolTip(Images_Button, "View add" + Environment.NewLine + " delete images")
        AccessTableAdapter1.Fill(ProjectDataSet1.ACCESS)
        If (Login.admin) Then
            User_List_B.Enabled = True
            User_List_B.Cursor = Cursors.Hand
            Notes_Button.Enabled = True
            Notes_Button.Cursor = Cursors.Hand
            Images_Button.Enabled = True
            Images_Button.Cursor = Cursors.Hand
        Else
            Dim accessvar() As DataRow = ProjectDataSet1.ACCESS.Select("ID='" + Login.userid.ToString + "'")
            If (accessvar.Count) Then

                If (accessvar(0).Item("Users_e")) Then
                    User_List_B.Enabled = True
                End If
                If (accessvar(0).Item("Images")) Then
                    Notes_Button.Enabled = True
                End If
                If (accessvar(0).Item("Notes")) Then
                    Images_Button.Enabled = True
                End If

            End If
        End If
        Label1.Text = Login.userName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pass_change.Show()
    End Sub

    Private Sub Notes_Button_Click(sender As Object, e As EventArgs) Handles Notes_Button.Click
        Me.WindowState = FormWindowState.Minimized
        Notes.Show()
        Notes.Activate()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Login.Show()
        Me.Close()

    End Sub

    Private Sub User_List_B_MouseHover(sender As Object, e As EventArgs) Handles User_List_B.MouseHover
        If User_List_B.Enabled Then

            User_List_B.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub User_List_B_MouseLeave(sender As Object, e As EventArgs) Handles User_List_B.MouseLeave
        User_List_B.FlatAppearance.BorderColor = Color.Purple
    End Sub

    Private Sub Notes_Button_MouseHover(sender As Object, e As EventArgs) Handles Notes_Button.MouseHover
        If Notes_Button.Enabled Then
            Notes_Button.FlatAppearance.BorderColor = Color.Red


        End If
    End Sub

    Private Sub Notes_Button_MouseLeave(sender As Object, e As EventArgs) Handles Notes_Button.MouseLeave
        Notes_Button.FlatAppearance.BorderColor = Color.Green
    End Sub

    Private Sub Images_Button_Click(sender As Object, e As EventArgs) Handles Images_Button.Click
        images_list.Show()
        Me.WindowState = FormWindowState.Minimized
        images_list.Activate()
    End Sub

    Private Sub Images_Button_MouseHover(sender As Object, e As EventArgs) Handles Images_Button.MouseHover
        Images_Button.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub Images_Button_MouseLeave(sender As Object, e As EventArgs) Handles Images_Button.MouseLeave
        Images_Button.FlatAppearance.BorderColor = Color.MediumTurquoise
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Close()
    End Sub



    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Button4.FlatAppearance.BorderColor = Color.Red

    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.FlatAppearance.BorderColor = Color.Navy
    End Sub
End Class
