<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.btnRemoveMeasure = New System.Windows.Forms.Button()
        Me.btnRemoveDim = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPreviousTab = New System.Windows.Forms.Button()
        Me.lbDimensions = New System.Windows.Forms.ListView()
        Me.myData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.myItems = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbSelectedKPI = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Members = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveKPI = New System.Windows.Forms.Button()
        Me.btnAddKPI = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSources = New System.Windows.Forms.TabPage()
        Me.btnNextTab = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDatabaseTable = New System.Windows.Forms.Button()
        Me.lvDataSources = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColWorkbookDatabase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSheetTable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KPIGroupArrayListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KPIGroupArrayListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabData.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabSources.SuspendLayout()
        CType(Me.KPIGroupArrayListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KPIGroupArrayListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabData
        '
        Me.TabData.Controls.Add(Me.btnRemoveMeasure)
        Me.TabData.Controls.Add(Me.btnRemoveDim)
        Me.TabData.Controls.Add(Me.Button2)
        Me.TabData.Controls.Add(Me.Label6)
        Me.TabData.Controls.Add(Me.btnPreviousTab)
        Me.TabData.Controls.Add(Me.lbDimensions)
        Me.TabData.Controls.Add(Me.cmbSelectedKPI)
        Me.TabData.Controls.Add(Me.Label4)
        Me.TabData.Controls.Add(Me.Label1)
        Me.TabData.Controls.Add(Me.btnRemoveKPI)
        Me.TabData.Controls.Add(Me.btnAddKPI)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(609, 411)
        Me.TabData.TabIndex = 0
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'btnRemoveMeasure
        '
        Me.btnRemoveMeasure.Location = New System.Drawing.Point(14, 329)
        Me.btnRemoveMeasure.Name = "btnRemoveMeasure"
        Me.btnRemoveMeasure.Size = New System.Drawing.Size(215, 23)
        Me.btnRemoveMeasure.TabIndex = 38
        Me.btnRemoveMeasure.Text = "Remove"
        Me.btnRemoveMeasure.UseVisualStyleBackColor = True
        '
        'btnRemoveDim
        '
        Me.btnRemoveDim.Location = New System.Drawing.Point(355, 329)
        Me.btnRemoveDim.Name = "btnRemoveDim"
        Me.btnRemoveDim.Size = New System.Drawing.Size(212, 23)
        Me.btnRemoveDim.TabIndex = 37
        Me.btnRemoveDim.Text = "Remove"
        Me.btnRemoveDim.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Data: "
        '
        'btnPreviousTab
        '
        Me.btnPreviousTab.Location = New System.Drawing.Point(426, 379)
        Me.btnPreviousTab.Name = "btnPreviousTab"
        Me.btnPreviousTab.Size = New System.Drawing.Size(75, 23)
        Me.btnPreviousTab.TabIndex = 33
        Me.btnPreviousTab.Text = "Previous"
        Me.btnPreviousTab.UseVisualStyleBackColor = True
        '
        'lbDimensions
        '
        Me.lbDimensions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.myData, Me.myItems})
        Me.lbDimensions.Location = New System.Drawing.Point(355, 70)
        Me.lbDimensions.Name = "lbDimensions"
        Me.lbDimensions.Size = New System.Drawing.Size(212, 253)
        Me.lbDimensions.TabIndex = 32
        Me.lbDimensions.UseCompatibleStateImageBehavior = False
        Me.lbDimensions.View = System.Windows.Forms.View.Details
        '
        'myData
        '
        Me.myData.Text = "Data"
        Me.myData.Width = 148
        '
        'myItems
        '
        Me.myItems.Text = "Members"
        '
        'cmbSelectedKPI
        '
        Me.cmbSelectedKPI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.Members})
        Me.cmbSelectedKPI.Location = New System.Drawing.Point(14, 70)
        Me.cmbSelectedKPI.MultiSelect = False
        Me.cmbSelectedKPI.Name = "cmbSelectedKPI"
        Me.cmbSelectedKPI.Size = New System.Drawing.Size(215, 253)
        Me.cmbSelectedKPI.TabIndex = 17
        Me.cmbSelectedKPI.UseCompatibleStateImageBehavior = False
        Me.cmbSelectedKPI.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "Name"
        Me.Name.Width = 134
        '
        'Members
        '
        Me.Members.Text = "Members"
        Me.Members.Width = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Measures:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Your Data:"
        '
        'btnRemoveKPI
        '
        Me.btnRemoveKPI.Location = New System.Drawing.Point(252, 197)
        Me.btnRemoveKPI.Name = "btnRemoveKPI"
        Me.btnRemoveKPI.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveKPI.TabIndex = 3
        Me.btnRemoveKPI.Text = "<<"
        Me.btnRemoveKPI.UseVisualStyleBackColor = True
        '
        'btnAddKPI
        '
        Me.btnAddKPI.Location = New System.Drawing.Point(252, 154)
        Me.btnAddKPI.Name = "btnAddKPI"
        Me.btnAddKPI.Size = New System.Drawing.Size(75, 23)
        Me.btnAddKPI.TabIndex = 2
        Me.btnAddKPI.Text = ">>"
        Me.btnAddKPI.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSources)
        Me.TabControl1.Controls.Add(Me.TabData)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 437)
        Me.TabControl1.TabIndex = 0
        '
        'TabSources
        '
        Me.TabSources.Controls.Add(Me.btnNextTab)
        Me.TabSources.Controls.Add(Me.Button3)
        Me.TabSources.Controls.Add(Me.Button1)
        Me.TabSources.Controls.Add(Me.btnDatabaseTable)
        Me.TabSources.Controls.Add(Me.lvDataSources)
        Me.TabSources.Controls.Add(Me.Label7)
        Me.TabSources.Location = New System.Drawing.Point(4, 22)
        Me.TabSources.Name = "TabSources"
        Me.TabSources.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSources.Size = New System.Drawing.Size(609, 411)
        Me.TabSources.TabIndex = 2
        Me.TabSources.Text = "Data Sources"
        Me.TabSources.UseVisualStyleBackColor = True
        '
        'btnNextTab
        '
        Me.btnNextTab.Location = New System.Drawing.Point(510, 379)
        Me.btnNextTab.Name = "btnNextTab"
        Me.btnNextTab.Size = New System.Drawing.Size(75, 23)
        Me.btnNextTab.TabIndex = 16
        Me.btnNextTab.Text = "Next"
        Me.btnNextTab.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(204, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 26)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "CSV"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(12, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDatabaseTable
        '
        Me.btnDatabaseTable.Location = New System.Drawing.Point(399, 316)
        Me.btnDatabaseTable.Name = "btnDatabaseTable"
        Me.btnDatabaseTable.Size = New System.Drawing.Size(186, 26)
        Me.btnDatabaseTable.TabIndex = 12
        Me.btnDatabaseTable.Text = "SQL Database"
        Me.btnDatabaseTable.UseVisualStyleBackColor = True
        '
        'lvDataSources
        '
        Me.lvDataSources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColSource, Me.ColWorkbookDatabase, Me.ColSheetTable})
        Me.lvDataSources.Location = New System.Drawing.Point(12, 57)
        Me.lvDataSources.MultiSelect = False
        Me.lvDataSources.Name = "lvDataSources"
        Me.lvDataSources.Size = New System.Drawing.Size(573, 253)
        Me.lvDataSources.TabIndex = 7
        Me.lvDataSources.UseCompatibleStateImageBehavior = False
        Me.lvDataSources.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        Me.ColName.Width = 93
        '
        'ColSource
        '
        Me.ColSource.Text = "Source"
        Me.ColSource.Width = 82
        '
        'ColWorkbookDatabase
        '
        Me.ColWorkbookDatabase.Text = "Workbook/Database"
        Me.ColWorkbookDatabase.Width = 250
        '
        'ColSheetTable
        '
        Me.ColSheetTable.Text = "Sheet/Table"
        Me.ColSheetTable.Width = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Choose Data Sources:"
        '
        'KPIGroupArrayListBindingSource1
        '
        Me.KPIGroupArrayListBindingSource1.DataSource = GetType(MartynasAddInn.KPIGroupArrayList)
        '
        'KPIGroupArrayListBindingSource
        '
        Me.KPIGroupArrayListBindingSource.DataSource = GetType(MartynasAddInn.KPIGroupArrayList)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(609, 436)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        'Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BI Model"
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabSources.ResumeLayout(False)
        Me.TabSources.PerformLayout()
        CType(Me.KPIGroupArrayListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KPIGroupArrayListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KPIGroupArrayListBindingSource1 As Windows.Forms.BindingSource
    Friend WithEvents KPIGroupArrayListBindingSource As Windows.Forms.BindingSource
    Friend WithEvents TabData As Windows.Forms.TabPage
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnRemoveKPI As Windows.Forms.Button
    Friend WithEvents btnAddKPI As Windows.Forms.Button
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents cmbSelectedKPI As Windows.Forms.ListView
    Friend WithEvents Name As Windows.Forms.ColumnHeader
    Friend WithEvents Members As Windows.Forms.ColumnHeader
    Friend WithEvents TabSources As Windows.Forms.TabPage
    Friend WithEvents btnDatabaseTable As Windows.Forms.Button
    Friend WithEvents lvDataSources As Windows.Forms.ListView
    Friend WithEvents ColName As Windows.Forms.ColumnHeader
    Friend WithEvents ColSource As Windows.Forms.ColumnHeader
    Friend WithEvents ColWorkbookDatabase As Windows.Forms.ColumnHeader
    Friend WithEvents ColSheetTable As Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnPreviousTab As Windows.Forms.Button
    Friend WithEvents lbDimensions As Windows.Forms.ListView
    Friend WithEvents myData As Windows.Forms.ColumnHeader
    Friend WithEvents myItems As Windows.Forms.ColumnHeader
    Friend WithEvents btnNextTab As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents btnRemoveDim As Windows.Forms.Button
    Friend WithEvents btnRemoveMeasure As Windows.Forms.Button
End Class
