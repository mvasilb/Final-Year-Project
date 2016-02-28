Imports System.Data
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=localhost;Integrated Security=SSPI;"}
    Public SQLServer As String
    Public SQLDB As String
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataSet As DataSet
    Public DatabaseList As List(Of String)


    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub getDataSet(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)

            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataSet = New DataSet
            SQLDA.Fill(SQLDataSet)

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub

    Public Function getDatabaseTables(Query As String) As List(Of String)
        DatabaseList = New List(Of String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)

            SQLDA = New SqlDataAdapter(SQLCmd)
            Using sqlReader As SqlDataReader = SQLCmd.ExecuteReader()
                While (sqlReader.Read())
                    DatabaseList.Add(sqlReader.GetString(0))
                End While
            End Using

            SQLCon.Close()
            Return DatabaseList
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
            Return DatabaseList
        End Try
    End Function
End Class
