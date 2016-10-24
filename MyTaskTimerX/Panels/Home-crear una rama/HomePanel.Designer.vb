<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePanel))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnMyTasks = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Bauhaus Md BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(6, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(112, 26)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "bienvenido"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Bauhaus Md BT", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblUserName.Location = New System.Drawing.Point(4, 35)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(226, 36)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Giancarlo Villena"
        '
        'btnMyTasks
        '
        Me.btnMyTasks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMyTasks.FlatAppearance.BorderSize = 0
        Me.btnMyTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyTasks.ImageIndex = 0
        Me.btnMyTasks.ImageList = Me.MyImageList
        Me.btnMyTasks.Location = New System.Drawing.Point(235, 93)
        Me.btnMyTasks.Name = "btnMyTasks"
        Me.btnMyTasks.Size = New System.Drawing.Size(83, 88)
        Me.btnMyTasks.TabIndex = 1
        Me.btnMyTasks.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "tasks2.png")
        '
        'HomePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnMyTasks)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HomePanel"
        Me.Size = New System.Drawing.Size(561, 242)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnMyTasks As Button
    Friend WithEvents MyImageList As ImageList
End Class
