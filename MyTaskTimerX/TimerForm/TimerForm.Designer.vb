<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimerForm))
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblHrs = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnStartTask = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.Color.Gray
        Me.lblSec.Location = New System.Drawing.Point(174, 63)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(34, 19)
        Me.lblSec.TabIndex = 12
        Me.lblSec.Text = "seg"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Gray
        Me.lblMin.Location = New System.Drawing.Point(97, 63)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(32, 19)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "min"
        '
        'lblHrs
        '
        Me.lblHrs.AutoSize = True
        Me.lblHrs.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrs.ForeColor = System.Drawing.Color.Gray
        Me.lblHrs.Location = New System.Drawing.Point(21, 63)
        Me.lblHrs.Name = "lblHrs"
        Me.lblHrs.Size = New System.Drawing.Size(29, 19)
        Me.lblHrs.TabIndex = 14
        Me.lblHrs.Text = "hrs"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.Black
        Me.lblMinutes.Location = New System.Drawing.Point(81, 16)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(68, 47)
        Me.lblMinutes.TabIndex = 7
        Me.lblMinutes.Text = "00"
        '
        'lblC1
        '
        Me.lblC1.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1.ForeColor = System.Drawing.Color.DarkGray
        Me.lblC1.Location = New System.Drawing.Point(60, 8)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(25, 47)
        Me.lblC1.TabIndex = 9
        Me.lblC1.Text = ":"
        Me.lblC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblHours.ForeColor = System.Drawing.Color.Black
        Me.lblHours.Location = New System.Drawing.Point(3, 16)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(68, 47)
        Me.lblHours.TabIndex = 10
        Me.lblHours.Text = "00"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Location = New System.Drawing.Point(8, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 25)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "HACER TESIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TaskTimerX"
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "play91 (2).png")
        Me.MyImageList.Images.SetKeyName(1, "pause37.png")
        '
        'btnStartTask
        '
        Me.btnStartTask.FlatAppearance.BorderSize = 0
        Me.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTask.ImageIndex = 0
        Me.btnStartTask.ImageList = Me.MyImageList
        Me.btnStartTask.Location = New System.Drawing.Point(24, 0)
        Me.btnStartTask.Name = "btnStartTask"
        Me.btnStartTask.Size = New System.Drawing.Size(56, 56)
        Me.btnStartTask.TabIndex = 15
        Me.btnStartTask.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblHours)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblSec)
        Me.Panel1.Controls.Add(Me.lblC1)
        Me.Panel1.Controls.Add(Me.lblMin)
        Me.Panel1.Controls.Add(Me.lblSeconds)
        Me.Panel1.Controls.Add(Me.lblHrs)
        Me.Panel1.Controls.Add(Me.lblMinutes)
        Me.Panel1.Location = New System.Drawing.Point(17, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 91)
        Me.Panel1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(138, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 47)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.Black
        Me.lblSeconds.Location = New System.Drawing.Point(159, 16)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(68, 47)
        Me.lblSeconds.TabIndex = 7
        Me.lblSeconds.Text = "00"
        '
        'MyTimer
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 56)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnStartTask)
        Me.Panel3.Location = New System.Drawing.Point(164, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(96, 56)
        Me.Panel3.TabIndex = 18
        '
        'TimerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(264, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bauhaus Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TimerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSec As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblHrs As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblC1 As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents btnStartTask As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents MyTimer As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
