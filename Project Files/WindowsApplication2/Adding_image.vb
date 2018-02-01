Imports System.IO

Public Class addingImages
    Private Sub Images_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public thumbimage As Image = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            TextBox1.Text = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            Dim image2 As Image = PictureBox1.Image
            thumbimage = Nothing
            thumbimage = image2.GetThumbnailImage(150, (PictureBox1.Image.Height / PictureBox1.Image.Width) * 150, Nothing, New IntPtr())
            PictureBox2.Image = thumbimage
        End If
    End Sub

    Private Sub Images_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        images_list.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.FileName = "" Then
            MsgBox("Choose a picture first")
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("please enter a name for your image")
            Exit Sub
        End If
        Dim ms As New MemoryStream
        Dim thumbn As New MemoryStream

        PictureBox2.Image.Save(thumbn, Imaging.ImageFormat.Jpeg)
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer
        Dim thdata As Byte() = thumbn.GetBuffer
        ImagesTableAdapter.InsertQuery(thdata, Date.Now, TextBox1.Text, Login.userid)
        ImagesDataTableAdapter1.Insert(data)
        ms.Flush()
        ms.Close()
        thumbn.Flush()
        thumbn.Close()
        Me.Close()

    End Sub

    Public Function ThumbnailCallback() As Boolean
        Return True
    End Function

    Private Sub GetThumbnail(ByVal e As PaintEventArgs)

        Dim callback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
        Dim image As Image = New Bitmap("c:\FakePhoto.jpg")
        Dim pThumbnail As Image = image.GetThumbnailImage(100, 100, callback, New IntPtr())
        e.Graphics.DrawImage(pThumbnail, 10, 10, pThumbnail.Width, pThumbnail.Height)
    End Sub
End Class