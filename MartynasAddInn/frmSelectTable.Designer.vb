<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbDatabase = New System.Windows.Forms.ComboBox()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSourceName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDatabase
        '
        Me.cmbDatabase.FormattingEnabled = True
        Me.cmbDatabase.Location = New System.Drawing.Point(83, 59)
        Me.cmbDatabase.Name = "cmbDatabase"
        Me.cmbDatabase.Size = New System.Drawing.Size(193, 21)
        Me.cmbDatabase.TabIndex = 0
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Location = New System.Drawing.Point(337, 59)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(182, 21)
        Me.cmbTable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Table:"
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(25, 100)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(494, 163)
        Me.dgvTable.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Source Name:"
        '
        'txtSourceName
        '
        Me.txtSourceName.Location = New System.Drawing.Point(106, 20)
        Me.txtSourceName.Name = "txtSourceName"
        Me.txtSourceName.Size = New System.Drawing.Size(170, 20)
        Me.txtSourceName.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(363, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(444, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSelectTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(538, 318)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSourceName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTable)
        Me.Controls.Add(Me.cmbDatabase)
        Me.Name = "frmSelectTable"
        Me.Text = "Form2"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbDatabase As Windows.Forms.ComboBox
    Friend WithEvents cmbTable As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dgvTable As Windows.Forms.DataGridView
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtSourceName As Windows.Forms.TextBox
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
End Class
