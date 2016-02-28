<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSheet
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
        Me.dgvSheet = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSourceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSheets = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSheet
        '
        Me.dgvSheet.AllowUserToAddRows = False
        Me.dgvSheet.AllowUserToDeleteRows = False
        Me.dgvSheet.AllowUserToResizeColumns = False
        Me.dgvSheet.AllowUserToResizeRows = False
        Me.dgvSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSheet.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSheet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSheet.Location = New System.Drawing.Point(28, 51)
        Me.dgvSheet.Name = "dgvSheet"
        Me.dgvSheet.ReadOnly = True
        Me.dgvSheet.RowHeadersVisible = False
        Me.dgvSheet.Size = New System.Drawing.Size(500, 157)
        Me.dgvSheet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Name:"
        '
        'txtSourceName
        '
        Me.txtSourceName.Location = New System.Drawing.Point(93, 14)
        Me.txtSourceName.Name = "txtSourceName"
        Me.txtSourceName.Size = New System.Drawing.Size(176, 20)
        Me.txtSourceName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Sheet:"
        '
        'cmbSheets
        '
        Me.cmbSheets.FormattingEnabled = True
        Me.cmbSheets.Location = New System.Drawing.Point(352, 14)
        Me.cmbSheets.Name = "cmbSheets"
        Me.cmbSheets.Size = New System.Drawing.Size(176, 21)
        Me.cmbSheets.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(372, 224)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(453, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSelectSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(554, 260)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbSheets)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSourceName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSheet)
        Me.Name = "frmSelectSheet"
        Me.Text = "Select Sheet"
        CType(Me.dgvSheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSheet As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtSourceName As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cmbSheets As Windows.Forms.ComboBox
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
End Class
