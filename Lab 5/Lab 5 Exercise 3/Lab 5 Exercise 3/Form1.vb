Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirst.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblSecond.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim First As Integer
        Dim Second As Integer


        First = TxtFirst.Text
        Second = TxtSecond.Text

        If First > Second Then
            lblAnswer.Text = " The larger number is " & First & "."
        ElseIf Second > First Then
            lblAnswer.Text = " The larger number is " & Second & "."
        ElseIf First = Second Then
            lblAnswer.Text = " The numbers are equal. "
        End If
    End Sub
End Class
