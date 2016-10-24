<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskListPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskListPanel))
        Me.dgvTaskList = New System.Windows.Forms.DataGridView()
        Me.TaskId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTaskList
        '
        Me.dgvTaskList.AllowUserToAddRows = False
        Me.dgvTaskList.AllowUserToDeleteRows = False
        Me.dgvTaskList.AllowUserToResizeColumns = False
        Me.dgvTaskList.AllowUserToResizeRows = False
        Me.dgvTaskList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTaskList.BackgroundColor = System.Drawing.Color.White
        Me.dgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTaskList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTaskList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskList.ColumnHeadersVisible = False
        Me.dgvTaskList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskId, Me.TaskName, Me.EstimatedTime})
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgvTaskList, 3)
        Me.dgvTaskList.Location = New System.Drawing.Point(0, 23)
        Me.dgvTaskList.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvTaskList.MultiSelect = False
        Me.dgvTaskList.Name = "dgvTaskList"
        Me.dgvTaskList.ReadOnly = True
        Me.dgvTaskList.RowHeadersVisible = False
        Me.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTaskList.Size = New System.Drawing.Size(207, 326)
        Me.dgvTaskList.TabIndex = 2
        '
        'TaskId
        '
        Me.TaskId.HeaderText = "TaskId"
        Me.TaskId.Name = "TaskId"
        Me.TaskId.ReadOnly = True
        Me.TaskId.Visible = False
        '
        'TaskName
        '
        Me.TaskName.HeaderText = "TaskName"
        Me.TaskName.Name = "TaskName"
        Me.TaskName.ReadOnly = True
        Me.TaskName.Width = 120
        '
        'EstimatedTime
        '
        Me.EstimatedTime.HeaderText = "EstimatedTime"
        Me.EstimatedTime.Name = "EstimatedTime"
        Me.EstimatedTime.ReadOnly = True
        Me.EstimatedTime.Width = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tareas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvTaskList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddTask, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.837607!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.16239!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(207, 349)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnAddTask
        '
        Me.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddTask.FlatAppearance.BorderSize = 0
        Me.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTask.ImageIndex = 0
        Me.btnAddTask.ImageList = Me.MyImageList
        Me.btnAddTask.Location = New System.Drawing.Point(179, 3)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(25, 17)
        Me.btnAddTask.TabIndex = 4
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "plus sign22.png")
        Me.MyImageList.Images.SetKeyName(1, "minus-sign2.png")
        '
        'TaskListPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TaskListPanel"
        Me.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Size = New System.Drawing.Size(207, 351)
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTaskList As DataGridView
    Friend WithEvents TaskId As DataGridViewTextBoxColumn
    Friend WithEvents TaskName As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedTime As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAddTask As Button
    Friend WithEvents MyImageList As ImageList
End Class
