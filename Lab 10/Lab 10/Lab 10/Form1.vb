Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myConn As SqlConnection

        myConn = New SqlConnection("Initial Catalog=Lab_6;" &
                "Data Source=localhost;Integrated Security=SSPI;")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        Server = myServerAddress;
Database = myDataBase;
Trusted_Connection = True;

        dbProvider = "Provider=SQLOLEDB;"
        dbSource = "Data Source=FaithlinHoeWeiXinTP055347.sql"
        con.ConnectionString = dbProvider & dbSource

        con.Open()
        MessageBox.Show("Connection Opened.")

        sql = "select * From Book"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Book List")

        con.Close()
        MessageBox.Show("Connection Closed.")
    End Sub
End Class





'Dim con As New SqlConnection

'Dim dbProvider As String
'Dim dbSource As String

'Dim sql As String
'Dim da As OleDb.OleDbDataAdapter
'Dim ds As New DataSet


'dbProvider = "Server=myServerAddress;"
'dbSource = "Data Source=Faithlin Hoe Wei Xin TP055347.sql"
'con.ConnectionString = dbProvider & dbSource

'con.Open()
'MessageBox.Show("Connection Opened.")

'sql = "select * From Book"
'da = New OleDb.OleDbDataAdapter(sql, con)
'da.Fill(ds, "Book List")

'con.Close()
'MessageBox.Show("Connection Closed.")

'myServerAddress