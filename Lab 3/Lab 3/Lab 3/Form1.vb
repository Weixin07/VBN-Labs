Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Y am I here lmao")
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        'MessageBox.Show("Y am I here")

        'If e.Button = MouseButtons.Right Then
        '    MsgBox("Right Button Clicked")
        'End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    TextBox1.Clear()
        '    MsgBox("Help!!!")
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MsgBox("Form Load Event")

        ''Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MessageBox.Show("Test")
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'If e.Button = MouseButtons.Right Then
        '    MessageBox.Show("Interesting")
        'End If

    End Sub
End Class

'For whichever function that you wanna use, remove the "'" in front of the code.
'Some codes disable another codes' function, therefore all codes have a "'" to make sure no confusion will be caused.
