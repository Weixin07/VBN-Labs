Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTP.Focus()
            'txtTP.Select()
            'Focus & Select is the same
        End If
    End Sub

    Private Sub txtTP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTP.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Select()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegister.Focus()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MessageBox.Show("Registered Successfully")
    End Sub
End Class
