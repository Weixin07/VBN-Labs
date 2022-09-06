Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Number As Integer
        Number = TextBox1.Text

        MessageBox.Show(Number, "WELCOME", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)

        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My First VB.Net Program"
        Me.BackColor = Color.BlueViolet
        Me.ForeColor = Color.Red


    End Sub
End Class
