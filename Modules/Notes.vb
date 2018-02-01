Public Class Notes
    Dim edit As New PROJECTDataSet.Notes_AccessDataTable
    Private Sub Notes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (new_form.Visible = False) Then
            User_Options.WindowState = FormWindowState.Normal
            User_Options.Activate()
        End If
    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Login.admin) Then
            NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
            Button4.Visible = True
            Button4.Enabled = True
        Else
            NotesTableAdapter1.Fillbyid(ProjectDataSet1.Notes, Login.userid)
        End If
        If (ListBox1.Items.Count = 0) Then
            If (ListBox1.Items.Count = 0) Then
                Button3.Enabled = False
            End If
        Else
            Button3.Enabled = True
        End If
        Notes_AccessTableAdapter1.FillBy(edit, ListBox1.SelectedValue, Login.userid)
        If (edit.Count = 0) Then
            Exit Sub
        End If

        If (edit(0).Item("edit")) Then
            Button1.Enabled = True
            Button3.Enabled = True
        Else
            Button1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Edit") Then
            Button1.Text = "Update"
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
        ElseIf (Button1.Text = "Update") Then
            NotesTableAdapter1.Updatebynoteid(TextBox2.Text, TextBox1.Text, ListBox1.SelectedValue)
            Button1.Text = "Edit"
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            If (Login.admin) Then
                NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
            Else
                NotesTableAdapter1.Fillbyid(ProjectDataSet1.Notes, Login.userid)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As Integer = MessageBox.Show("Are You sure you want to delete '" + TextBox2.SelectedText + "' Note?", "confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If
        Notes_AccessTableAdapter1.DeleteQuery(ListBox1.SelectedValue)
        NotesTableAdapter1.DeleteQuery(ListBox1.SelectedValue)

        If (Login.admin) Then
            NotesTableAdapter1.Fill(ProjectDataSet1.Notes)
        Else
            NotesTableAdapter1.Fillbyid(ProjectDataSet1.Notes, Login.userid)
        End If

        If (ListBox1.Items.Count = 0) Then
            Button3.Enabled = False
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If (Button1.Text = "Update") Then
            Button1.Text = "Edit"
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
        End If
        Notes_AccessTableAdapter1.FillBy(edit, ListBox1.SelectedValue, Login.userid)
        If (edit.Count = 0) Then
            Exit Sub
        End If

        If (edit(0).Item("edit")) Then
            Button1.Enabled = True
            Button3.Enabled = True
        Else
            Button1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        new_form.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Notes_Access.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pass As String = InputBox("password", "enter your encryption password", "")
        If pass = "" Then
            Exit Sub
        End If
        TextBox1.Text = Login.seperateddecwithpass(TextBox1.Text, pass)
    End Sub
End Class