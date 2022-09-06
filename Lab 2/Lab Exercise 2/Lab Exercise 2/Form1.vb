Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Single
        a = TextBox1.Text
        b = TextBox2.Text
        c = (a ^ 2 + b ^ 2) ^ (1 / 2)
        Label1.Text = c

    End Sub
End Class
