Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblN.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim N As Double
        Dim Nb As Double
        Dim Answer As Double
        Dim Start As Integer = 1

        N = txtN.Text

        Do While Start <= N
            Nb = 1 / Start
            Answer = Answer + Nb
            Start = Start + 1
        Loop

        lblAnswer.Text = Answer
    End Sub
End Class
