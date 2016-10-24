<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskInfoPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskInfoPanel))
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.btnStartTask = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCompletedTime = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTaskName.Location = New System.Drawing.Point(17, 18)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(166, 41)
        Me.lblTaskName.TabIndex = 5
        Me.lblTaskName.Text = "HACER TESIS"
        '
        'btnStartTask
        '
        Me.btnStartTask.FlatAppearance.BorderSize = 0
        Me.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTask.ForeColor = System.Drawing.Color.Black
        Me.btnStartTask.ImageIndex = 1
        Me.btnStartTask.ImageList = Me.MyImageList
        Me.btnStartTask.Location = New System.Drawing.Point(75, 148)
        Me.btnStartTask.Name = "btnStartTask"
        Me.btnStartTask.Size = New System.Drawing.Size(108, 76)
        Me.btnStartTask.TabIndex = 7
        Me.btnStartTask.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "play91.png")
        Me.MyImageList.Images.SetKeyName(1, "history6.png")
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatus.Location = New System.Drawing.Point(19, 59)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 20)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "[ESPERA]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bauhaus Md BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(325, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tiempo Completado"
        '
        'lblCompletedTime
        '
        Me.lblCompletedTime.AutoSize = True
        Me.lblCompletedTime.Font = New System.Drawing.Font("Bauhaus Md BT", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedTime.ForeColor = System.Drawing.Color.Black
        Me.lblCompletedTime.Location = New System.Drawing.Point(246, 122)
        Me.lblCompletedTime.Name = "lblCompletedTime"
        Me.lblCompletedTime.Size = New System.Drawing.Size(309, 41)
        Me.lblCompletedTime.TabIndex = 6
        Me.lblCompletedTime.Text = "00 horas 00 minutos"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Bauhaus Md BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblSubtitle.Location = New System.Drawing.Point(325, 190)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(146, 22)
        Me.lblSubtitle.TabIndex = 6
        Me.lblSubtitle.Text = "Tiempo Restante"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.Font = New System.Drawing.Font("Bauhaus Md BT", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.Black
        Me.lblRemainingTime.Location = New System.Drawing.Point(265, 229)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(273, 41)
        Me.lblRemainingTime.TabIndex = 6
        Me.lblRemainingTime.Text = "2 horas 3 minutos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus Md BT", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "EMPEZAR"
        '
        'TaskInfoPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnStartTask)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCompletedTime)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTaskName)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TaskInfoPanel"
        Me.Size = New System.Drawing.Size(584, 351)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaskName As Label
    Friend WithEvents btnStartTask As Button
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCompletedTime As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents Label1 As Label
End Class
