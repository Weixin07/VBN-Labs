Public Class Form1
    Private Sub btnForLoop_Click(sender As Object, e As EventArgs) Handles btnForLoop.Click
        Dim answer As Integer = 0
        Dim i As Integer

        For i = txtStart.Text To txtEnd.Text
            answer = answer + i
        Next
        MessageBox.Show(answer)
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        Dim number As Integer
        number = 1
        Do While number < 5
            MessageBox.Show(number)
            number = number + 1
        Loop
    End Sub
End Class
