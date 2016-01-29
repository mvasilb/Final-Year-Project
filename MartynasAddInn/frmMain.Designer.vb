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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.refreshCount = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemoveDim = New System.Windows.Forms.Button()
        Me.btnAddDim = New System.Windows.Forms.Button()
        Me.lbDimensions = New System.Windows.Forms.ListBox()
        Me.btnPreviousTab = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataName = New System.Windows.Forms.TextBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkForecast = New System.Windows.Forms.CheckBox()
        Me.chkBudget = New System.Windows.Forms.CheckBox()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.cmbSelectedKPI = New System.Windows.Forms.ListBox()
        Me.cmbKPIList = New System.Windows.Forms.ListBox()
        Me.btnNextTab = New System.Windows.Forms.Button()
        Me.btnCreateNewKPI = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKPIGroup = New System.Windows.Forms.ComboBox()
        Me.btnRemoveKPI = New System.Windows.Forms.Button()
        Me.btnAddKPI = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.KPIGroupArrayListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KPIGroupArrayListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.KPIGroupArrayListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KPIGroupArrayListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.refreshCount)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btnRemoveDim)
        Me.TabPage2.Controls.Add(Me.btnAddDim)
        Me.TabPage2.Controls.Add(Me.lbDimensions)
        Me.TabPage2.Controls.Add(Me.btnPreviousTab)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtDataName)
        Me.TabPage2.Controls.Add(Me.btnFinish)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(713, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dimensions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'refreshCount
        '
        Me.refreshCount.Location = New System.Drawing.Point(505, 81)
        Me.refreshCount.Name = "refreshCount"
        Me.refreshCount.Size = New System.Drawing.Size(75, 23)
        Me.refreshCount.TabIndex = 30
        Me.refreshCount.Text = "Refresh"
        Me.refreshCount.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 30)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "No of Items for each Data:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "What data contributes to your measurements?"
        '
        'btnRemoveDim
        '
        Me.btnRemoveDim.Location = New System.Drawing.Point(242, 327)
        Me.btnRemoveDim.Name = "btnRemoveDim"
        Me.btnRemoveDim.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveDim.TabIndex = 27
        Me.btnRemoveDim.Text = "Remove"
        Me.btnRemoveDim.UseVisualStyleBackColor = True
        '
        'btnAddDim
        '
        Me.btnAddDim.Location = New System.Drawing.Point(242, 80)
        Me.btnAddDim.Name = "btnAddDim"
        Me.btnAddDim.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDim.TabIndex = 26
        Me.btnAddDim.Text = "Add"
        Me.btnAddDim.UseVisualStyleBackColor = True
        '
        'lbDimensions
        '
        Me.lbDimensions.FormattingEnabled = True
        Me.lbDimensions.Location = New System.Drawing.Point(18, 109)
        Me.lbDimensions.Name = "lbDimensions"
        Me.lbDimensions.Size = New System.Drawing.Size(299, 212)
        Me.lbDimensions.TabIndex = 25
        '
        'btnPreviousTab
        '
        Me.btnPreviousTab.Location = New System.Drawing.Point(437, 379)
        Me.btnPreviousTab.Name = "btnPreviousTab"
        Me.btnPreviousTab.Size = New System.Drawing.Size(75, 23)
        Me.btnPreviousTab.TabIndex = 24
        Me.btnPreviousTab.Text = "Previous"
        Me.btnPreviousTab.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Data Name"
        '
        'txtDataName
        '
        Me.txtDataName.Location = New System.Drawing.Point(18, 81)
        Me.txtDataName.Name = "txtDataName"
        Me.txtDataName.Size = New System.Drawing.Size(218, 20)
        Me.txtDataName.TabIndex = 3
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(518, 379)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 2
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkForecast)
        Me.TabPage1.Controls.Add(Me.chkBudget)
        Me.TabPage1.Controls.Add(Me.chkActual)
        Me.TabPage1.Controls.Add(Me.cmbSelectedKPI)
        Me.TabPage1.Controls.Add(Me.cmbKPIList)
        Me.TabPage1.Controls.Add(Me.btnNextTab)
        Me.TabPage1.Controls.Add(Me.btnCreateNewKPI)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmbKPIGroup)
        Me.TabPage1.Controls.Add(Me.btnRemoveKPI)
        Me.TabPage1.Controls.Add(Me.btnAddKPI)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "KPI's"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkForecast
        '
        Me.chkForecast.AutoSize = True
        Me.chkForecast.Location = New System.Drawing.Point(489, 88)
        Me.chkForecast.Name = "chkForecast"
        Me.chkForecast.Size = New System.Drawing.Size(67, 17)
        Me.chkForecast.TabIndex = 15
        Me.chkForecast.Text = "Forecast"
        Me.chkForecast.UseVisualStyleBackColor = True
        '
        'chkBudget
        '
        Me.chkBudget.AutoSize = True
        Me.chkBudget.Location = New System.Drawing.Point(410, 88)
        Me.chkBudget.Name = "chkBudget"
        Me.chkBudget.Size = New System.Drawing.Size(60, 17)
        Me.chkBudget.TabIndex = 14
        Me.chkBudget.Text = "Budget"
        Me.chkBudget.UseVisualStyleBackColor = True
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(336, 88)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(56, 17)
        Me.chkActual.TabIndex = 13
        Me.chkActual.Text = "Actual"
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'cmbSelectedKPI
        '
        Me.cmbSelectedKPI.FormattingEnabled = True
        Me.cmbSelectedKPI.Location = New System.Drawing.Point(344, 132)
        Me.cmbSelectedKPI.Name = "cmbSelectedKPI"
        Me.cmbSelectedKPI.Size = New System.Drawing.Size(213, 225)
        Me.cmbSelectedKPI.TabIndex = 12
        '
        'cmbKPIList
        '
        Me.cmbKPIList.FormattingEnabled = True
        Me.cmbKPIList.Location = New System.Drawing.Point(17, 132)
        Me.cmbKPIList.Name = "cmbKPIList"
        Me.cmbKPIList.Size = New System.Drawing.Size(213, 225)
        Me.cmbKPIList.TabIndex = 11
        '
        'btnNextTab
        '
        Me.btnNextTab.Location = New System.Drawing.Point(518, 379)
        Me.btnNextTab.Name = "btnNextTab"
        Me.btnNextTab.Size = New System.Drawing.Size(75, 23)
        Me.btnNextTab.TabIndex = 10
        Me.btnNextTab.Text = "Next"
        Me.btnNextTab.UseVisualStyleBackColor = True
        '
        'btnCreateNewKPI
        '
        Me.btnCreateNewKPI.Location = New System.Drawing.Point(113, 363)
        Me.btnCreateNewKPI.Name = "btnCreateNewKPI"
        Me.btnCreateNewKPI.Size = New System.Drawing.Size(117, 23)
        Me.btnCreateNewKPI.TabIndex = 9
        Me.btnCreateNewKPI.Text = "Create New KPI"
        Me.btnCreateNewKPI.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Selected KPI's"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "KPI List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "KPI Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "What is to be measured:"
        '
        'cmbKPIGroup
        '
        Me.cmbKPIGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKPIGroup.FormattingEnabled = True
        Me.cmbKPIGroup.Location = New System.Drawing.Point(17, 88)
        Me.cmbKPIGroup.Name = "cmbKPIGroup"
        Me.cmbKPIGroup.Size = New System.Drawing.Size(213, 21)
        Me.cmbKPIGroup.TabIndex = 4
        '
        'btnRemoveKPI
        '
        Me.btnRemoveKPI.Location = New System.Drawing.Point(250, 209)
        Me.btnRemoveKPI.Name = "btnRemoveKPI"
        Me.btnRemoveKPI.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveKPI.TabIndex = 3
        Me.btnRemoveKPI.Text = "<< Remove"
        Me.btnRemoveKPI.UseVisualStyleBackColor = True
        '
        'btnAddKPI
        '
        Me.btnAddKPI.Location = New System.Drawing.Point(250, 166)
        Me.btnAddKPI.Name = "btnAddKPI"
        Me.btnAddKPI.Size = New System.Drawing.Size(75, 23)
        Me.btnAddKPI.TabIndex = 2
        Me.btnAddKPI.Text = "Add >>"
        Me.btnAddKPI.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 437)
        Me.TabControl1.TabIndex = 0
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
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "BI Model"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.KPIGroupArrayListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KPIGroupArrayListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KPIGroupArrayListBindingSource1 As Windows.Forms.BindingSource
    Friend WithEvents KPIGroupArrayListBindingSource As Windows.Forms.BindingSource
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents btnRemoveDim As Windows.Forms.Button
    Friend WithEvents btnAddDim As Windows.Forms.Button
    Friend WithEvents lbDimensions As Windows.Forms.ListBox
    Friend WithEvents btnPreviousTab As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtDataName As Windows.Forms.TextBox
    Friend WithEvents btnFinish As Windows.Forms.Button
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents cmbSelectedKPI As Windows.Forms.ListBox
    Friend WithEvents cmbKPIList As Windows.Forms.ListBox
    Friend WithEvents btnNextTab As Windows.Forms.Button
    Friend WithEvents btnCreateNewKPI As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cmbKPIGroup As Windows.Forms.ComboBox
    Friend WithEvents btnRemoveKPI As Windows.Forms.Button
    Friend WithEvents btnAddKPI As Windows.Forms.Button
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents chkForecast As Windows.Forms.CheckBox
    Friend WithEvents chkBudget As Windows.Forms.CheckBox
    Friend WithEvents chkActual As Windows.Forms.CheckBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents refreshCount As Windows.Forms.Button
End Class
