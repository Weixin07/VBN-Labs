Imports System.Windows.Forms.VisualStyles
Imports System.Xml.Schema

Public Class Last_Exercise
    Private Sub Last_Exercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numbers() As Integer = {1, 5, 7, 8, 9, 4, 3, 18, 56, 43}
        Dim Total As Integer
        Dim Max As Integer
        Dim Min As Integer

        Max = Numbers(0)
        Min = Numbers(0)

        For index = 0 To Numbers.Length - 1
            Total = Total + Numbers(index)
        Next

        For index = 0 To Numbers.Length - 1
            If Max < Numbers(index) Then
                Max = Numbers(index)
            End If
        Next

        For index = 0 To Numbers.Length - 1
            If Min > Numbers(index) Then
                Min = Numbers(index)
            End If
        Next

        TextBox1.Text = Total
        TextBox2.Text = Max
        TextBox3.Text = Min

    End Sub
End Class