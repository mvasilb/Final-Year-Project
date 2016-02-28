Public Class frmSelectTable

    Dim SQL As New SQLControl
    Dim databaseName As String
    Dim tableName As String

    Private Sub frmSelectTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each db In SQL.getDatabaseTables("SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');")
            cmbDatabase.Items.Add(db)
        Next
    End Sub

    Private Sub cmbDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatabase.SelectedIndexChanged
        databaseName = cmbDatabase.SelectedItem
        cmbTable.Items.Clear()
        For Each db In SQL.getDatabaseTables("SELECT table_name FROM " & databaseName & ".information_schema.tables;")
            cmbTable.Items.Add(db)
        Next
    End Sub

    Private Sub cmbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTable.SelectedIndexChanged
        tableName = cmbTable.SelectedItem
        SQL.getDataSet("USE " & databaseName & " SELECT * FROM " & tableName)

        If SQL.SQLDataSet.Tables.Count > 0 Then
            dgvTable.DataSource = SQL.SQLDataSet.Tables(0)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmMain.addSource = True
        frmMain.selectedDatabase = databaseName
        frmMain.selectedTable = tableName
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class