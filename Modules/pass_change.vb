Public Class pass_change
    Public sqlcon As String = "Data Source=termproject2.database.windows.net;Initial Catalog=termproject;User ID=Talal;Password=15935736mM"
    Dim here As New PROJECTDataSet.UsersDataTable
    Public old_password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Old_Pass.Text = "") Then
            MsgBox("Please Enter your old password")
            Exit Sub
        ElseIf (New_Pass.Text = "") Then
            MsgBox("Please enter your new passwors")
            Exit Sub
        ElseIf (New_Pass2.Text = "") Then
            MsgBox("Please confirm your new passwors")
            Exit Sub
        Else

            UsersTableAdapter1.Fillpassbyid(here, Login.userid)
            If here.Count = 0 Then
                MsgBox("Error")
                Exit Sub
            End If
            If (here(0).Password.Replace(" ", "") = Login.seperatedenc(Old_Pass.Text)) Then


                If (New_Pass.Text = New_Pass2.Text) Then
                    UsersTableAdapter1.Updatepassbyid(Login.seperatedenc(New_Pass.Text), Date.Now, Login.userid)
                Else
                    MsgBox("your new password and confirm are not the same")
                    New_Pass2.Text = ""
                    Exit Sub
                End If
            Else
                MsgBox("Wrong old password")
                Exit Sub
            End If
            Me.Close()
        End If

    End Sub

    Private Sub New_Pass2_TextChanged(sender As Object, e As EventArgs) Handles New_Pass2.TextChanged
        If (New_Pass2.Text <> New_Pass.Text And New_Pass2.Text <> "") Then
            New_Pass2.BackColor = Color.Red
        Else
            New_Pass2.BackColor = Color.White
        End If
    End Sub

    Private Sub pass_change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTableAdapter1.Fillpassbyid(here, Login.userid)
    End Sub
End Class