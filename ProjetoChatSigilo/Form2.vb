Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Security.Cryptography

Public Class Form2
    Public meuip As String
    Public ipexterno As String
    Public chave As String
    Dim cliente As New TcpClient
    Dim escutar As New TcpListener(4444)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            escutar.Start()
            Timer1.Start()
        Catch ex As Exception
            MsgBox("Erro na comunicação com o destino...")
        End Try
    End Sub
    'para enviar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cliente = New TcpClient(ipexterno, 4444)
        Dim escrever As New StreamWriter(cliente.GetStream)
        escrever.Write(Simple3Des.EncryptData(TextBox1.Text, chave))
        RichTextBox1.AppendText(TextBox1.Text + vbNewLine)
        escrever.Flush()
        TextBox1.Clear()
        escrever.Close()
    End Sub
    'para receber
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim encriptada As String
        Dim desencriptada As String
        Try
            If escutar.Pending = True Then
                cliente = escutar.AcceptTcpClient()
                Dim ler As New StreamReader(cliente.GetStream)
                While ler.Peek > -1
                    encriptada &= Convert.ToChar(ler.Read()).ToString
                End While
                desencriptada = Simple3Des.DecryptData(encriptada, chave)
                RichTextBox2.AppendText(desencriptada + vbNewLine)
                ler.Close()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class