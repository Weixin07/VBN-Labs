Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim multiplier As Integer
        Dim answer As Integer
        Dim i As Integer

        number1 = Val(txtStart.Text)
        number2 = Val(txtEnd.Text)
        multiplier = 2

        For i = number1 To number2
            answer = i * multiplier
            listboxAnswer.Items.Add(i & " X " & multiplier & " = " & answer)
        Next
    End Sub

End Class
