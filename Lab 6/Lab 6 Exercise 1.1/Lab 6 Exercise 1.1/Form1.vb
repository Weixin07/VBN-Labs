Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        Dim num As Integer = 1
        Dim total As Integer = 0

        Do
            total = total + num
            num = num + 1
        Loop Until num >= 100

        MessageBox.Show(total)
    End Sub
End Class
