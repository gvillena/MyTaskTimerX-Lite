<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskDetailPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskDetailPanel))
        Me.btnStartTask = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblEstimatedTime = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStartTask
        '
        Me.btnStartTask.FlatAppearance.BorderSize = 0
        Me.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTask.ForeColor = System.Drawing.Color.Black
        Me.btnStartTask.ImageIndex = 0
        Me.btnStartTask.ImageList = Me.MyImageList
        Me.btnStartTask.Location = New System.Drawing.Point(22, 160)
        Me.btnStartTask.Name = "btnStartTask"
        Me.btnStartTask.Size = New System.Drawing.Size(108, 76)
        Me.btnStartTask.TabIndex = 12
        Me.btnStartTask.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "play91.png")
        '
        'lblEstimatedTime
        '
        Me.lblEstimatedTime.AutoSize = True
        Me.lblEstimatedTime.Font = New System.Drawing.Font("Bauhaus Md BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimatedTime.ForeColor = System.Drawing.Color.Black
        Me.lblEstimatedTime.Location = New System.Drawing.Point(219, 82)
        Me.lblEstimatedTime.Name = "lblEstimatedTime"
        Me.lblEstimatedTime.Size = New System.Drawing.Size(178, 26)
        Me.lblEstimatedTime.TabIndex = 10
        Me.lblEstimatedTime.Text = "2 horas 3 minutos"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Bauhaus Md BT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(241, 48)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(125, 18)
        Me.lblSubtitle.TabIndex = 11
        Me.lblSubtitle.Text = "Duración Estimada"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatus.Location = New System.Drawing.Point(17, 46)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 20)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "[ESPERA]"
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Font = New System.Drawing.Font("Agency FB", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTaskName.Location = New System.Drawing.Point(17, 18)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(105, 28)
        Me.lblTaskName.TabIndex = 9
        Me.lblTaskName.Text = "HACER TESIS"
        '
        'TaskDetailPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnStartTask)
        Me.Controls.Add(Me.lblEstimatedTime)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTaskName)
        Me.Font = New System.Drawing.Font("Bauhaus Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TaskDetailPanel"
        Me.Size = New System.Drawing.Size(424, 250)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartTask As Button
    Friend WithEvents lblEstimatedTime As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTaskName As Label
    Friend WithEvents MyImageList As ImageList
End Class
