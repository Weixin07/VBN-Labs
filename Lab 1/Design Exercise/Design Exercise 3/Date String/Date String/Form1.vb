Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayofMonth.Clear()
        txtDayofWeek.Clear()
        txtMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = ""



    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        lblDateString.Text = txtDayofMonth.Text + ", " + txtDayofWeek.Text + ", " + txtMonth.Text + ", " + txtYear.Text


    End Sub
End Class
