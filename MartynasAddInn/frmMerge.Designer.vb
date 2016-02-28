<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMerge
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
        Me.dgvSource1 = New System.Windows.Forms.DataGridView()
        Me.cmbSource1 = New System.Windows.Forms.ComboBox()
        Me.cmbSource2 = New System.Windows.Forms.ComboBox()
        Me.dgvSource2 = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSource1
        '
        Me.dgvSource1.AllowUserToAddRows = False
        Me.dgvSource1.AllowUserToDeleteRows = False
        Me.dgvSource1.AllowUserToResizeColumns = False
        Me.dgvSource1.AllowUserToResizeRows = False
        Me.dgvSource1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSource1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSource1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSource1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSource1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSource1.Location = New System.Drawing.Point(31, 104)
        Me.dgvSource1.Name = "dgvSource1"
        Me.dgvSource1.ReadOnly = True
        Me.dgvSource1.RowHeadersVisible = False
        Me.dgvSource1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.dgvSource1.Size = New System.Drawing.Size(500, 133)
        Me.dgvSource1.TabIndex = 0
        '
        'cmbSource1
        '
        Me.cmbSource1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSource1.FormattingEnabled = True
        Me.cmbSource1.Location = New System.Drawing.Point(31, 77)
        Me.cmbSource1.Name = "cmbSource1"
        Me.cmbSource1.Size = New System.Drawing.Size(174, 21)
        Me.cmbSource1.TabIndex = 1
        '
        'cmbSource2
        '
        Me.cmbSource2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSource2.FormattingEnabled = True
        Me.cmbSource2.Location = New System.Drawing.Point(31, 267)
        Me.cmbSource2.Name = "cmbSource2"
        Me.cmbSource2.Size = New System.Drawing.Size(174, 21)
        Me.cmbSource2.TabIndex = 2
        '
        'dgvSource2
        '
        Me.dgvSource2.AllowUserToAddRows = False
        Me.dgvSource2.AllowUserToDeleteRows = False
        Me.dgvSource2.AllowUserToResizeColumns = False
        Me.dgvSource2.AllowUserToResizeRows = False
        Me.dgvSource2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSource2.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSource2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSource2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSource2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSource2.Location = New System.Drawing.Point(31, 294)
        Me.dgvSource2.Name = "dgvSource2"
        Me.dgvSource2.ReadOnly = True
        Me.dgvSource2.RowHeadersVisible = False
        Me.dgvSource2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.dgvSource2.Size = New System.Drawing.Size(500, 133)
        Me.dgvSource2.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(456, 441)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(375, 441)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(75, 23)
        Me.btnMerge.TabIndex = 5
        Me.btnMerge.Text = "Merge"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select columns in both tables that share a common 'key' value"
        '
        'frmMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(569, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvSource2)
        Me.Controls.Add(Me.cmbSource2)
        Me.Controls.Add(Me.cmbSource1)
        Me.Controls.Add(Me.dgvSource1)
        Me.Name = "frmMerge"
        Me.Text = "Merge Sources"
        CType(Me.dgvSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSource1 As Windows.Forms.DataGridView
    Friend WithEvents cmbSource1 As Windows.Forms.ComboBox
    Friend WithEvents cmbSource2 As Windows.Forms.ComboBox
    Friend WithEvents dgvSource2 As Windows.Forms.DataGridView
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnMerge As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
