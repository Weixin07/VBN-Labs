Public Class Form1
    Private Sub lblCentigrade_Click(sender As Object, e As EventArgs) Handles lblCentigrade.Click

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim C, F As Single
        txtC.Text = C
        F = txtF.Text
        C = (F - 32) * 5 / 9


        If C > 100 Then
            MessageBox.Show("High Temperature!")
        ElseIf C <= 100 Then
            MessageBox.Show("Successful Conversion.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtC.Clear()
        txtF.Clear()

    End Sub

End Class

*/Function 2 (txtF.Text = (txtC.Text * 9 / 5) + 32)/*
