Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim salary As Double
        Dim estimation As Integer = 0
        Dim age As Integer

        salary = Val(txtSalary.Text)
        age = Val(txtAge.Text)

        Do While age < 65
            age = age + 1
            estimation = estimation + salary
            salary = salary * 1.05
        Loop

        lblAnswer.Text = txtName.Text & " will earn about RM" & estimation & "."
    End Sub
End Class