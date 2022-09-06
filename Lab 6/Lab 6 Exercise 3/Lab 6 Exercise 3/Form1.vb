Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim celcius As Integer
        Dim Fahrenheit As Integer = 0

        ListBox1.Items.Add("Celcius" & vbTab & "Fahrenheit")
        ListBox1.Items.Add("-----------" & vbTab & "-----------------")
        For celcius = 0 To 100 Step 10
            Fahrenheit = (9 / 5 * celcius) + 32
            ListBox1.Items.Add(celcius & " °C " & vbTab & Fahrenheit & " °F ")
        Next

    End Sub
End Class
