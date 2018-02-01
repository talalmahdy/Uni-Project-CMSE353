
Imports System.Data.SqlClient

Imports System.Security.Cryptography
Imports System.Security
Imports System.Text
Imports System.IO
Imports System.Math



Public Class Login



    Public wrapper As New SimpleDes("57962384")
    Public wrapperfornotes As New SimpleDes("57962384")
    Public kn As Boolean = False
    Public userid As Integer = 0
    Public userName As String
    Public passv As String
    Public admin As Boolean = False
    Private deswrap As Object

    Public Function seperatedenc_withpassword(ByVal sr As String, ByVal ps As String) As String
        Dim n As Integer = sr.Length() Mod 8
        Dim m As Integer = Truncate(sr.Length() / 8)
        Dim st As String = ""
        Dim inpass As String = ""
        Dim full As String = ""
        Dim ctrm As Int64 = 25698742
        If (ps.Length() > 8) Then
            For i As Integer = 0 To 7
                inpass += ps(i)
            Next
            wrapperfornotes.newpass(inpass)

        ElseIf (ps.Length() < 8) Then
            inpass = ps
            For i As Integer = (ps.Length() - 1) To 7
                inpass += " "
            Next
            wrapperfornotes.newpass(inpass)
        Else
            wrapperfornotes.newpass(ps)
        End If

        If m > 0 Then
            For i As Integer = 0 To (m - 1)
                For j As Integer = 0 To 7
                    st += sr((i * 8) + j)
                Next
                full += wrapperfornotes.EncryptData(((ctrm + i) Mod 99999999).ToString, System.Text.ASCIIEncoding.ASCII.GetBytes(st))
                st = ""

            Next
        End If

        Dim extra As String = ""
        If n <> 0 Then
            For i As Integer = 0 To n - 1
                extra += sr((m * 8) + i)
            Next
            For i As Integer = n To 7
                extra += Nothing
            Next
            Dim tryit(7) As Byte
            For i As Integer = 0 To n - 1
                tryit(i) = System.Text.ASCIIEncoding.ASCII.GetBytes(extra).ToArray(i)
            Next
            full += wrapperfornotes.EncryptData(((ctrm + m) Mod 99999999).ToString, tryit)
        End If
        Return full

    End Function
    Public Function seperatedenc(ByVal sr As String) As String
        Dim n As Integer = sr.Length() Mod 8
        Dim m As Integer = Truncate(sr.Length() / 8)
        Dim st As String = ""
        Dim full As String = ""
        Dim ctrm As Int64 = 25698742
        If m > 0 Then
            For i As Integer = 0 To (m - 1)
                For j As Integer = 0 To 7
                    st += sr((i * 8) + j)
                Next
                full += wrapper.EncryptData(((ctrm + i) Mod 99999999).ToString, System.Text.ASCIIEncoding.ASCII.GetBytes(st))
                st = ""

            Next
        End If

        Dim extra As String = ""
        If n <> 0 Then
            For i As Integer = 0 To n - 1
                extra += sr((m * 8) + i)
            Next
            For i As Integer = n To 7
                extra += " "
            Next
            full += wrapper.EncryptData(((ctrm + m) Mod 99999999).ToString, System.Text.ASCIIEncoding.ASCII.GetBytes(extra))
        End If
        Return full

    End Function

    Public Function seperateddecwithpass(ByVal sr As String, ByVal ps As String) As String
        Dim n As Integer = sr.Length() Mod 12
        Dim m As Integer = sr.Length() / 12
        Dim st As String = ""
        Dim full As String = ""
        Dim ctrm As Int64 = 25698742
        wrapperfornotes.newpass(ps)
        If m > 0 Then
            For i As Integer = 0 To (m - 1)
                For j As Integer = 0 To 11
                    st += sr((i * 12) + j)
                Next
                full += wrapperfornotes.EncryptData2(((ctrm + i) Mod 99999999).ToString, Convert.FromBase64String(st))
                st = ""

            Next
        End If

        Dim extra As String = ""
        If n <> 0 Then
            For i As Integer = 0 To n - 1
                extra += sr((m * 12) + i)
            Next
            For i As Integer = n To 11
                extra += " "
            Next
            full += wrapperfornotes.EncryptData2(((ctrm + m) Mod 99999999).ToString, Convert.FromBase64String(extra))
        End If
        Return full

    End Function
    Public Function seperateddec(ByVal sr As String) As String
        Dim n As Integer = sr.Length() Mod 12
        Dim m As Integer = sr.Length() / 12
        Dim st As String = ""
        Dim full As String = ""
        Dim ctrm As Int64 = 25698742
        If m > 0 Then
            For i As Integer = 0 To (m - 1)
                For j As Integer = 0 To 11
                    st += sr((i * 12) + j)
                Next
                full += wrapper.EncryptData2(((ctrm + i) Mod 99999999).ToString, Convert.FromBase64String(st))
                st = ""

            Next
        End If

        Dim extra As String = ""
        If n <> 0 Then
            For i As Integer = 0 To n - 1
                extra += sr((m * 12) + i)
            Next
            For i As Integer = n To 11
                extra += " "
            Next
            full += wrapper.EncryptData2(((ctrm + m) Mod 99999999).ToString, Convert.FromBase64String(extra))
        End If
        Return full

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogIn_Button.Click
        On Error Resume Next
        If (User_Name.Text = "") Then
            MsgBox("enter username")
            Exit Sub
        ElseIf (Password.Text = "") Then
            MsgBox("enter Password")
            Exit Sub
        End If
        UsersTableAdapter1.FillBynamefullrow(ProjectDataSet1.Users, User_Name.Text)

        'Dim value As Integer = UsersTableAdapter.usernamecheck(User_Name.Text)
        Dim usersrows() As DataRow = ProjectDataSet1.Users.Select


        If (usersrows.Count = 0) Then
            MsgBox("Wrong UserName Or Password", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        ElseIf (usersrows.Count = 1) Then
            passv = usersrows(0).Item("Password")
            'passv = UsersTableAdapter.getPass(User_Name.Text)
            passv = passv.Replace(" ", "") 'should be fixed
        Else
            MsgBox("Wrong UserName Or Password", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
        If (seperatedenc(Password.Text) = passv) Then


            'userid = UsersTableAdapter.GetID_login(User_Name.Text)
            userid = usersrows(0).Item("ID")
            userName = (usersrows(0).Item("User_Name")).replace(" ", "")
            admin = (usersrows(0).Item("Admin"))
            Me.User_Name.Text = ""
            Me.Password.Text = ""
            User_Options.Show()

            Me.Hide()
        Else
            MsgBox("Wrong UserName Or Password", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If



    End Sub




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UsersTableAdapter1.Insert("Admin", seperatedenc("123456"), Date.Now, Date.Now, 1)
    End Sub

    Public NotInheritable Class SimpleDes
        Private myDes As New DESCryptoServiceProvider



        Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            myDes.Key = System.Text.Encoding.ASCII.GetBytes(key)
            myDes.IV = System.Text.Encoding.ASCII.GetBytes("12345678")
            myDes.Mode = CipherMode.ECB
            myDes.BlockSize = 64
            myDes.Padding = PaddingMode.None
            'myDes.Key = TruncateHash(key, myDes.KeySize \ 8)
            'myDes.IV = TruncateHash("", myDes.BlockSize \ 8)
        End Sub
        Public Function newpass(ByVal passin As String)
            myDes.Key = System.Text.Encoding.ASCII.GetBytes(passin)
        End Function
        Public Function DecryptData(
            ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
                    myDes.CreateDecryptor(),
                    System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.ASCII.GetString(ms.ToArray)
        End Function

        Public Function EncryptData(
            ByVal plaintext As String, ByVal plaintext2() As Byte) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.ASCII.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                myDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Dim bity(7) As Byte
            For i As Integer = 0 To 7
                bity(i) = ms.ToArray(i) Xor plaintext2(i)
            Next

            Return Convert.ToBase64String(bity)

        End Function
        Public Function EncryptData2(
            ByVal plaintext As String, ByVal plaintext2() As Byte) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.ASCII.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                myDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Dim bity(7) As Byte
            For i As Integer = 0 To 7
                bity(i) = ms.ToArray(i) Xor plaintext2(i)
            Next

            Return System.Text.ASCIIEncoding.ASCII.GetString(bity)

        End Function
    End Class

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
    End Sub
End Class
