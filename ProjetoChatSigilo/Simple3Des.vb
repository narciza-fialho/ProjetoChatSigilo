Imports System.Text
Imports System.Security.Cryptography

Public NotInheritable Class Simple3Des
    Private Shared TripleDES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    'Private Const key As String = "aloha171248"

    Public Shared Function MD5Hash(value As String) As Byte()
        Dim byteArray() As Byte = ASCIIEncoding.ASCII.GetBytes(value)
        Return MD5.ComputeHash(byteArray)
    End Function

    Public Shared Function EncryptData(stringToEncrypt As String, key As String) As String
        Try
            TripleDES.Key = Simple3Des.MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Public Shared Function DecryptData(encryptedString As String, key As String) As String
        Try
            TripleDES.Key = Simple3Des.MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function
End Class
