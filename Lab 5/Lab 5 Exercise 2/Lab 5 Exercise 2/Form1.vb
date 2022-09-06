Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSee.Click
        Dim Weather As String
        Weather = ComboxWeathers.Text
        MessageBox.Show(" The weather is " & ComboxWeathers.Text & " today!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
