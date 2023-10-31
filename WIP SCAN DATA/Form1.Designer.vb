<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ScanWIPBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_PURDataSet1 = New WIP_SCAN_DATA.App_PURDataSet1()
        Me.ScanWIPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_PURDataSet = New WIP_SCAN_DATA.App_PURDataSet()
        Me.Scan_WIPTableAdapter = New WIP_SCAN_DATA.App_PURDataSetTableAdapters.Scan_WIPTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Scan_WIPTableAdapter1 = New WIP_SCAN_DATA.App_PURDataSet1TableAdapters.Scan_WIPTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CameraDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.ScanWIPBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.App_PURDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScanWIPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.App_PURDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanWIPBindingSource1
        '
        Me.ScanWIPBindingSource1.DataMember = "Scan_WIP"
        Me.ScanWIPBindingSource1.DataSource = Me.App_PURDataSet1
        '
        'App_PURDataSet1
        '
        Me.App_PURDataSet1.DataSetName = "App_PURDataSet1"
        Me.App_PURDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScanWIPBindingSource
        '
        Me.ScanWIPBindingSource.DataMember = "Scan_WIP"
        Me.ScanWIPBindingSource.DataSource = Me.App_PURDataSet
        '
        'App_PURDataSet
        '
        Me.App_PURDataSet.DataSetName = "App_PURDataSet"
        Me.App_PURDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Scan_WIPTableAdapter
        '
        Me.Scan_WIPTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1089, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Export Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Scan_WIPTableAdapter1
        '
        Me.Scan_WIPTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RecipientDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn, Me.CameraDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ScanWIPBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(27, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1137, 542)
        Me.DataGridView1.TabIndex = 6
        '
        'JobDataGridViewTextBoxColumn
        '
        Me.JobDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JobDataGridViewTextBoxColumn.DataPropertyName = "Job"
        Me.JobDataGridViewTextBoxColumn.HeaderText = "Job"
        Me.JobDataGridViewTextBoxColumn.Name = "JobDataGridViewTextBoxColumn"
        Me.JobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "Item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        Me.ItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecipientDataGridViewTextBoxColumn
        '
        Me.RecipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient"
        Me.RecipientDataGridViewTextBoxColumn.HeaderText = "Recipient"
        Me.RecipientDataGridViewTextBoxColumn.Name = "RecipientDataGridViewTextBoxColumn"
        Me.RecipientDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        Me.PictureDataGridViewImageColumn.ReadOnly = True
        '
        'CameraDataGridViewImageColumn
        '
        Me.CameraDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CameraDataGridViewImageColumn.DataPropertyName = "Camera"
        Me.CameraDataGridViewImageColumn.HeaderText = "Camera"
        Me.CameraDataGridViewImageColumn.Name = "CameraDataGridViewImageColumn"
        Me.CameraDataGridViewImageColumn.ReadOnly = True
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.LightGreen
        Me.AddButton.Location = New System.Drawing.Point(353, 20)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 7
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.LightCoral
        Me.DeleteButton.Location = New System.Drawing.Point(463, 20)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 8
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 646)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "WIP SCAN DATA"
        CType(Me.ScanWIPBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.App_PURDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScanWIPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.App_PURDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents App_PURDataSet As App_PURDataSet
    Friend WithEvents ScanWIPBindingSource As BindingSource
    Friend WithEvents Scan_WIPTableAdapter As App_PURDataSetTableAdapters.Scan_WIPTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents App_PURDataSet1 As App_PURDataSet1
    Friend WithEvents ScanWIPBindingSource1 As BindingSource
    Friend WithEvents Scan_WIPTableAdapter1 As App_PURDataSet1TableAdapters.Scan_WIPTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecipientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents CameraDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents AddButton As Button
    Friend WithEvents DeleteButton As Button
End Class
