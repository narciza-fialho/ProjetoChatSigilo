Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConectarButton.Click
        Form2.meuip = SeuIPTextBox.Text
        Form2.ipexterno = IPExternoTextBox.Text
        Form2.Show()

    End Sub
End Class
