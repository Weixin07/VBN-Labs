Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, sum, difference, product, quotient As Single
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        sum = num1 + num2
        difference = num1 - num2
        product = num1 * num2
        quotient = num1 / num2
        Label1.Text = sum
        Label2.Text = difference
        Label3.Text = product
        Label4.Text = quotient

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
