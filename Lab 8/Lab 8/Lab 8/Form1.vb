Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim MyNumbers(4) As Integer
        'Dim i As Integer

        'MyNumbers(0) = 10
        'MyNumbers(1) = 20
        'MyNumbers(2) = 30
        'MyNumbers(3) = 40
        'MyNumbers(4) = 50

        'For i = 0 To 4

        'ListBox1.Items.Add(MyNumbers(i))
        'Next

        ''''''''''''''''''''''''''''''''''
        'MyNumbers(0) = TextBox1.Text
        'MyNumbers(1) = TextBox2.Text

        'For i = 0 To 1

        'ListBox1.Items.Add(MyNumbers(i))

        'Next

        'Dim Numbers(10) As Integer
        'Dim Times As Integer
        'Dim StoreAnswer As Integer
        'Dim i As Integer

        'ListBox1.Items.Clear()

        'Times = Val(TextBox1.Text)

        'For i = 1 To 10
        'StoreAnswer = i * Times
        'Numbers(i) = StoreAnswer
        'ListBox1.Items.Add(Times & "times" & i & Numbers(i))
        'Next

        Dim Numbers() As Integer
        Dim StartAt As Integer
        Dim EndAt As Integer
        Dim Times As Integer
        Dim StoreAnswer As Integer
        Dim i As Integer

        Times = Val(TextBox1.Text)
        StartAt = Val(TextBox2.Text)
        EndAt = Val(TextBox3.Text)

        ReDim Numbers(EndAt)

        For i = StartAt To EndAt

            StoreAnswer = i * Times
            Numbers(i) = StoreAnswer
            ListBox1.Items.Add(Times & "times" & i & Numbers(i))

        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
