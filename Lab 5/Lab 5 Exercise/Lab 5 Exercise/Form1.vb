Public Class Form1
    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        Dim Number As Integer
        Number = txtNumber.Text

        If Number >= 10 And Number <= 20 Then
            MessageBox.Show(Number)

        Else
            MessageBox.Show("Please Try Again!")

        End If

        txtNumber.Clear()
    End Sub
End Class
