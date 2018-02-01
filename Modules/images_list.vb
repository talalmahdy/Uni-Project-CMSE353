Imports System.IO

Public Class images_list
    Private Sub images_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim width As Integer = My.Computer.Screen.WorkingArea.Width
        Dim height As Integer = My.Computer.Screen.WorkingArea.Height
        If (Login.admin = True) Then
            ImagesTableAdapter.Fill(PROJECTDataSet.Images)
        Else
            ImagesTableAdapter.FillByid(PROJECTDataSet.Images, Login.userid)
        End If

        Me.Size = New Size(0.8 * width, 0.8 * height)
        PictureBox1.Location = New Point(Me.Size.Width * 0.02, Me.Size.Height * 0.02)
        PictureBox1.Size = New Size(Me.Size.Width * 0.8, Me.Size.Height * 0.8)
        ListBox1.Location = New Point(Me.Size.Width * 0.83, Me.Size.Height * 0.06)
        Button1.Location = New Point(Me.Size.Width * 0.02, Me.Size.Height * 0.84)
        ListBox1.Size = New Size(Me.Size.Width * 0.15, Me.Size.Height * 0.76)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        delete.Location = New Point(Me.Size.Width * 0.86, Me.Size.Height * 0.84)
        addnew.Location = New Point(Me.Size.Width * 0.91, Me.Size.Height * 0.84)
        Button2.Location = New Point(Me.Size.Width * 0.68, Me.Size.Height * 0.84)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If PictureBox1.Image.Width > 150 Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Button2.Visible = True
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Button2.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImagesDataTableAdapter1.FillBy(PROJECTDataSet.ImagesData, ListBox1.SelectedValue)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Dim pic() As Byte = PROJECTDataSet.ImagesData.Item(0).Image
        Dim strm As New MemoryStream()
        strm.Write(pic, 0, pic.Length())

        PictureBox1.Image = Image.FromStream(strm)
        Button2.Visible = True
    End Sub

    Private Sub images_list_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (addingImages.Visible = False) Then
            User_Options.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub addnew_Click(sender As Object, e As EventArgs) Handles addnew.Click
        addingImages.Show()
        Me.Close()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ImagesDataTableAdapter1.Delete(ListBox1.SelectedValue)
        ImagesTableAdapter.Deletebyimageid(ListBox1.SelectedValue)
        If (Login.admin = True) Then
            ImagesTableAdapter.Fill(PROJECTDataSet.Images)
        Else
            ImagesTableAdapter.FillByid(PROJECTDataSet.Images, Login.userid)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName)
        End If

    End Sub
End Class