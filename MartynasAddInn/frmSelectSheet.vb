Imports System.Data
Imports System.Windows.Forms

Public Class frmSelectSheet

    Dim table As DataTable
    Dim sheets As New List(Of String)
    Dim charsToTrim() As Char = {"$"c, "'"c}
    Dim temp As String

    Private Sub frmSelectSheet1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim excel_app As New Excel.Application
        'Dim xlWorkBook As Excel.Workbook

        'xlWorkBook = excel_app.Workbooks.Open(frmMain.fileName)
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & frmMain.fileName & "'; Extended Properties=Excel 8.0;")
        MyConnection.Open()

        For x As Integer = 0 To MyConnection.GetSchema("Tables").Rows.Count - 1
            temp = MyConnection.GetSchema("Tables").Rows(x)("TABLE_NAME")
            sheets.Add(temp.Trim(charsToTrim))
        Next x
        MyConnection.Close()

        For Each sheet In sheets
            cmbSheets.Items.Add(sheet)
        Next
        cmbSheets.SelectedIndex = 0

    End Sub

    Private Sub cmbSheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheets.SelectedIndexChanged

        dgvSheet.Columns.Clear()
        dgvSheet.Rows.Clear()

        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & frmMain.fileName & "'; Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                ("select * from [" & cmbSheets.SelectedItem & "$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            table = New System.Data.DataTable
            MyCommand.Fill(table)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        For y As Integer = 0 To table.Columns.Count - 1
            Dim column As New DataGridViewTextBoxColumn
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Name = table.Columns(y).ToString
            column.HeaderText = table.Columns(y).ToString
            dgvSheet.Columns.Add(column)
        Next

        For x As Integer = 0 To 4
            Dim values(table.Columns.Count - 1) As String
            For y As Integer = 0 To table.Columns.Count - 1
                If x < table.Rows.Count Then
                    values(y) = table.Rows(x)(y)
                End If
            Next
            dgvSheet.Rows.Add(values)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmMain.addSource = True
        frmMain.selectedSheet = cmbSheets.SelectedItem
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Close()
    End Sub
End Class