Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmCSV

    Dim table As DataTable

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmMain.addSource = True
        Close()
    End Sub

    Private Sub frmCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            'Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & frmMain.filePath & "'; Extended Properties=""text;HDR=Yes;FMT=Delimited"";")
            'MyCommand = New System.Data.OleDb.OleDbDataAdapter _
            '    ("select * from [" & cmbSheets.SelectedItem & "$]", MyConnection)
            'MyCommand.TableMappings.Add("Table", "TestTable")
            table = New System.Data.DataTable
            Using MyCommand As New OleDbDataAdapter("Select * From [" & frmMain.fileName & "]", MyConnection)
                MyCommand.Fill(table)
            End Using

            'MyCommand.Fill(table)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        For y As Integer = 0 To table.Columns.Count - 1
            Dim column As New DataGridViewTextBoxColumn
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Name = table.Columns(y).ToString
            column.HeaderText = table.Columns(y).ToString
            dgvCSV.Columns.Add(column)
        Next

        For x As Integer = 0 To 4
            Dim values(table.Columns.Count - 1) As String
            For y As Integer = 0 To table.Columns.Count - 1
                If x < table.Rows.Count Then
                    values(y) = table.Rows(x)(y)
                End If
            Next
            dgvCSV.Rows.Add(values)
        Next

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class