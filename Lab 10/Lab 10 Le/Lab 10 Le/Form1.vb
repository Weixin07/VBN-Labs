Public Class Form1
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Dim index As Integer
    Dim Total_Records As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider=Microsoft.jet.oledb.4.0;"
        dbSource = "Data Source=Lecture 8 1.mdb"
        con.ConnectionString = dbProvider & dbSource

        con.Open()
        MessageBox.Show("Connection Opened.")

        sql = "select * from Student" ' where Student_TP = '" & TextBox3.Text & "'
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Student List")

        con.Close()
        MessageBox.Show("Connection Closed.")

        DataGridView1.DataSource = ds.Tables("Student List")

        index = 0
        Total_Records = ds.Tables("Student List").Rows.Count
        Navigate_Records() 'call statement

    End Sub

    Sub Navigate_Records()
        If ds.Tables("Student List").Rows.Count > 0 Then
            txtFirstName.Text = ds.Tables("Student List").Rows(index).Item(1)
            txtLastName.Text = ds.Tables("Student List").Rows(index).Item(2)
        Else
            MessageBox.Show("Record Not Found.")
        End If

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        index = 0
        Navigate_Records()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index = index - 1
            Navigate_Records()
        Else
            MessageBox.Show("No more previous record.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < Total_Records - 1 Then
            index = index + 1
            Navigate_Records()
        Else
            MessageBox.Show("Last record reached.")
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        index = Total_Records - 1
        Navigate_Records()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Once useful now useless leaving it there just for the ecstatics 
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        ds.Tables("Student List").Rows(index).Item(1) = txtFirstName.Text
        ds.Tables("Student List").Rows(index).Item(2) = txtLastName.Text
        da.Update(ds, "Student List")

        MessageBox.Show("Updated Successfully.")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtStudentTP.Clear()

        btnAdd.Enabled = False
        btnCommit.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        btnCommit.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        If txtStudentTP.Text <> "" And txtFirstName.Text <> "" And txtLastName.Text <> "" Then
            dsNewRow = ds.Tables("Student List").NewRow()
            dsNewRow.Item(0) = txtStudentTP.Text
            dsNewRow.Item(1) = txtFirstName.Text
            dsNewRow.Item(2) = txtLastName.Text

            ds.Tables("Student List").Rows.Add(dsNewRow)
            da.Update(ds, "Student List")
            MessageBox.Show("New record added to the database.")
            Total_Records = Total_Records + 1
        Else
            MessageBox.Show("Please fill in all of the details.")
        End If

        btnCommit.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        ds.Tables("Student List").Rows(index).Delete()

        da.Update(ds, "Student List")
        Total_Records = Total_Records - 1

        MessageBox.Show("Record deleted from database.")
    End Sub
End Class
