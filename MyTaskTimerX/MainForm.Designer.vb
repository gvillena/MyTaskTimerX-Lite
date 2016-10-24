<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.plMainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.plGreyLine = New System.Windows.Forms.Panel()
        Me.plTitlePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.plTitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'plMainPanel
        '
        Me.plMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plMainPanel.Location = New System.Drawing.Point(0, 90)
        Me.plMainPanel.Name = "plMainPanel"
        Me.plMainPanel.Size = New System.Drawing.Size(722, 351)
        Me.plMainPanel.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 441)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 30)
        Me.Panel1.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(722, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton1.Text = "Home"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton2.Text = "Back"
        '
        'plGreyLine
        '
        Me.plGreyLine.BackColor = System.Drawing.Color.Gainsboro
        Me.plGreyLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.plGreyLine.Location = New System.Drawing.Point(0, 87)
        Me.plGreyLine.Name = "plGreyLine"
        Me.plGreyLine.Size = New System.Drawing.Size(722, 3)
        Me.plGreyLine.TabIndex = 0
        '
        'plTitlePanel
        '
        Me.plTitlePanel.BackColor = System.Drawing.Color.DodgerBlue
        Me.plTitlePanel.Controls.Add(Me.Label1)
        Me.plTitlePanel.Controls.Add(Me.lblTitle)
        Me.plTitlePanel.Controls.Add(Me.plGreyLine)
        Me.plTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.plTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.plTitlePanel.Name = "plTitlePanel"
        Me.plTitlePanel.Size = New System.Drawing.Size(722, 90)
        Me.plTitlePanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MyTaskTimerX"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(10, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(214, 39)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "PAGINA PRINCIPAL"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(722, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.plMainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.plTitlePanel)
        Me.Font = New System.Drawing.Font("BordeauxMedium", 8.249999!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.plTitlePanel.ResumeLayout(False)
        Me.plTitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents plMainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents plGreyLine As Panel
    Friend WithEvents plTitlePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
End Class
