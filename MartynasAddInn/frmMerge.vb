Imports System.Data
Imports System.Windows.Forms

Public Class frmMerge

    Dim excel_app As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim range As Excel.Range
    Dim colHeader As String
    Dim excelData As Object(,)
    Dim table As DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each item In frmMain.sources
            cmbSource1.Items.Add(item.Key)
        Next
        cmbSource1.SelectedIndex = 0

        For Each item In frmMain.sources
            cmbSource2.Items.Add(item.Key)
        Next
        cmbSource2.SelectedIndex = frmMain.lastSource

    End Sub

    Private Sub cmbSource1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSource1.SelectedIndexChanged

        dgvSource1.Columns.Clear()
        dgvSource1.Rows.Clear()

        'Try
        '    Dim MyConnection As System.Data.OleDb.OleDbConnection
        '    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        '    MyConnection = New System.Data.OleDb.OleDbConnection _
        '    ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & frmMain.sources.Item(cmbSource1.SelectedItem).Item(0) & "'; Extended Properties=Excel 8.0;")
        '    MyCommand = New System.Data.OleDb.OleDbDataAdapter _
        '        ("select * from [Sheet1$]", MyConnection)
        '    MyCommand.TableMappings.Add("Table", "TestTable")
        '    table = New System.Data.DataTable
        '    MyCommand.Fill(table)
        '    MyConnection.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        table = frmMain.tables.Item(cmbSource1.SelectedItem)

        For y As Integer = 0 To table.Columns.Count - 1
            Dim column As New DataGridViewTextBoxColumn
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Name = table.Columns(y).ToString
            column.HeaderText = table.Columns(y).ToString
            dgvSource1.Columns.Add(column)
        Next

        For x As Integer = 0 To 4
            Dim values(table.Columns.Count - 1) As String
            For y As Integer = 0 To table.Columns.Count - 1
                If x < table.Rows.Count Then
                    values(y) = table.Rows(x)(y)
                End If
            Next
            dgvSource1.Rows.Add(values)
        Next

        'xlWorkBook = excel_app.Workbooks.Open(frmMain.sources.Item(cmbSource1.SelectedItem).Item(0))
        'xlWorkSheet = xlWorkBook.Sheets(frmMain.sources.Item(cmbSource1.SelectedItem).Item(1))
        'range = xlWorkSheet.UsedRange

        'excelData = range.Value

        'For y As Integer = 1 To range.Columns.Count
        '    Dim column As New DataGridViewTextBoxColumn
        '    column.SortMode = DataGridViewColumnSortMode.NotSortable
        '    column.Name = excelData(1, y)
        '    column.HeaderText = excelData(1, y)
        '    dgvSource1.Columns.Add(column)
        'Next

        'For x As Integer = 2 To 6
        '    Dim values(range.Columns.Count - 1) As String
        '    For y As Integer = 1 To range.Columns.Count
        '        values(y - 1) = excelData(x, y)
        '    Next
        '    dgvSource1.Rows.Add(values)
        'Next
    End Sub


    Private Sub cmbSource2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSource2.SelectedIndexChanged

        dgvSource2.Columns.Clear()
        dgvSource2.Rows.Clear()

        'Try
        '    Dim MyConnection As System.Data.OleDb.OleDbConnection
        '    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        '    MyConnection = New System.Data.OleDb.OleDbConnection _
        '    ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & frmMain.sources.Item(cmbSource2.SelectedItem).Item(0) & "'; Extended Properties=Excel 8.0;")
        '    MyCommand = New System.Data.OleDb.OleDbDataAdapter _
        '        ("select * from [Sheet1$]", MyConnection)
        '    MyCommand.TableMappings.Add("Table", "TestTable")
        '    table = New System.Data.DataTable
        '    MyCommand.Fill(table)
        '    MyConnection.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        table = frmMain.tables.Item(cmbSource2.SelectedItem)

        For y As Integer = 0 To table.Columns.Count - 1
            Dim column As New DataGridViewTextBoxColumn
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Name = table.Columns(y).ToString
            column.HeaderText = table.Columns(y).ToString
            dgvSource2.Columns.Add(column)
        Next

        For x As Integer = 0 To 4
            Dim values(table.Columns.Count - 1) As String
            For y As Integer = 0 To table.Columns.Count - 1
                If x < table.Rows.Count Then
                    values(y) = table.Rows(x)(y)
                End If
            Next
            dgvSource2.Rows.Add(values)
        Next
    End Sub

    Private Sub btnMerge_Click(sender As Object, e As EventArgs) Handles btnMerge.Click
        frmMain.mergeAccepted = True
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class