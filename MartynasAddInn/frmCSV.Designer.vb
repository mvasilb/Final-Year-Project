<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCSV
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSourceName = New System.Windows.Forms.TextBox()
        Me.dgvCSV = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Name:"
        '
        'txtSourceName
        '
        Me.txtSourceName.Location = New System.Drawing.Point(93, 14)
        Me.txtSourceName.Name = "txtSourceName"
        Me.txtSourceName.Size = New System.Drawing.Size(181, 20)
        Me.txtSourceName.TabIndex = 1
        '
        'dgvCSV
        '
        Me.dgvCSV.AllowUserToAddRows = False
        Me.dgvCSV.AllowUserToDeleteRows = False
        Me.dgvCSV.AllowUserToResizeColumns = False
        Me.dgvCSV.AllowUserToResizeRows = False
        Me.dgvCSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCSV.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCSV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSV.Location = New System.Drawing.Point(28, 51)
        Me.dgvCSV.Name = "dgvCSV"
        Me.dgvCSV.ReadOnly = True
        Me.dgvCSV.RowHeadersVisible = False
        Me.dgvCSV.Size = New System.Drawing.Size(500, 157)
        Me.dgvCSV.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(453, 225)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(372, 225)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(554, 260)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvCSV)
        Me.Controls.Add(Me.txtSourceName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCSV"
        Me.Text = "CSV Source"
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtSourceName As Windows.Forms.TextBox
    Friend WithEvents dgvCSV As Windows.Forms.DataGridView
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnAdd As Windows.Forms.Button
End Class
