Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeight.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim height, weight, bmi As Single
        height = txtHeight.Text
        weight = txtWeight.Text
        bmi = (weight) / (height ^ 2)
        lblShowBMI.Text = bmi

    End Sub
End Class
