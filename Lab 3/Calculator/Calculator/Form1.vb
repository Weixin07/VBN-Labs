Public Class Calculator
    Dim total1 As Single
    Dim Total2 As Single
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = btn0.Text + txtDisplay.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = btn1.Text + txtDisplay.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = btn2.Text + txtDisplay.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = btn3.Text + txtDisplay.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = btn4.Text + txtDisplay.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = btn5.Text + txtDisplay.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = btn6.Text + txtDisplay.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = btn7.Text + txtDisplay.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = btn8.Text + txtDisplay.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = btn9.Text + txtDisplay.Text
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        total1 = total1 + Val(txtDisplay.Text)
        txtDisplay.Clear()
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Total2 = total1 + txtDisplay.Text
        txtDisplay.Text = Total2
        total1 = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        total1 = 0
        Total2 = 0
    End Sub
End Class
