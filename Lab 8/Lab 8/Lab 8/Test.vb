Public Class Test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers(9) As Integer

        For index = 0 To numbers.Length - 1
            numbers(index) = InputBox("Enter A Value:")
        Next
    End Sub
End Class