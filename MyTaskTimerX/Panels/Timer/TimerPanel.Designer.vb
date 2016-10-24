<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerPanel
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblHrs = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.lblC2 = New System.Windows.Forms.Label()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Location = New System.Drawing.Point(22, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "HACER TESIS"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Black
        Me.lblHours.Location = New System.Drawing.Point(37, 77)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(61, 52)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "00"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.Black
        Me.lblMinutes.Location = New System.Drawing.Point(104, 77)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(61, 52)
        Me.lblMinutes.TabIndex = 4
        Me.lblMinutes.Text = "00"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.Black
        Me.lblSeconds.Location = New System.Drawing.Point(171, 77)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(61, 52)
        Me.lblSeconds.TabIndex = 4
        Me.lblSeconds.Text = "00"
        '
        'lblHrs
        '
        Me.lblHrs.AutoSize = True
        Me.lblHrs.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrs.ForeColor = System.Drawing.Color.Gray
        Me.lblHrs.Location = New System.Drawing.Point(52, 129)
        Me.lblHrs.Name = "lblHrs"
        Me.lblHrs.Size = New System.Drawing.Size(29, 19)
        Me.lblHrs.TabIndex = 5
        Me.lblHrs.Text = "hrs"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Gray
        Me.lblMin.Location = New System.Drawing.Point(118, 129)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(32, 19)
        Me.lblMin.TabIndex = 5
        Me.lblMin.Text = "min"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Bauhaus Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.Color.Gray
        Me.lblSec.Location = New System.Drawing.Point(176, 129)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(34, 19)
        Me.lblSec.TabIndex = 5
        Me.lblSec.Text = "seg"
        '
        'lblC1
        '
        Me.lblC1.AutoSize = True
        Me.lblC1.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1.ForeColor = System.Drawing.Color.DarkGray
        Me.lblC1.Location = New System.Drawing.Point(85, 70)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(32, 52)
        Me.lblC1.TabIndex = 4
        Me.lblC1.Text = ":"
        Me.lblC1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2
        '
        Me.lblC2.AutoSize = True
        Me.lblC2.Font = New System.Drawing.Font("Agency FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2.ForeColor = System.Drawing.Color.DimGray
        Me.lblC2.Location = New System.Drawing.Point(155, 70)
        Me.lblC2.Name = "lblC2"
        Me.lblC2.Size = New System.Drawing.Size(32, 52)
        Me.lblC2.TabIndex = 4
        Me.lblC2.Text = ":"
        Me.lblC2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MyTimer
        '
        '
        'TimerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblHrs)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblC2)
        Me.Controls.Add(Me.lblC1)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "TimerPanel"
        Me.Size = New System.Drawing.Size(424, 247)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblHrs As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents lblC1 As Label
    Friend WithEvents lblC2 As Label
    Friend WithEvents MyTimer As Timer
End Class
