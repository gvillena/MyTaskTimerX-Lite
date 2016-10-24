<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TasksPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TasksPanel))
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.plLeftContainer = New System.Windows.Forms.Panel()
        Me.plRightContainer = New System.Windows.Forms.Panel()
        Me.plMain = New System.Windows.Forms.Panel()
        Me.plMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "electron.png")
        Me.MyImageList.Images.SetKeyName(1, "create3.png")
        Me.MyImageList.Images.SetKeyName(2, "download168.png")
        '
        'plLeftContainer
        '
        Me.plLeftContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.plLeftContainer.Location = New System.Drawing.Point(0, 0)
        Me.plLeftContainer.Name = "plLeftContainer"
        Me.plLeftContainer.Size = New System.Drawing.Size(184, 351)
        Me.plLeftContainer.TabIndex = 10
        '
        'plRightContainer
        '
        Me.plRightContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plRightContainer.Location = New System.Drawing.Point(184, 0)
        Me.plRightContainer.Name = "plRightContainer"
        Me.plRightContainer.Size = New System.Drawing.Size(538, 351)
        Me.plRightContainer.TabIndex = 11
        '
        'plMain
        '
        Me.plMain.Controls.Add(Me.plRightContainer)
        Me.plMain.Controls.Add(Me.plLeftContainer)
        Me.plMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plMain.Location = New System.Drawing.Point(0, 0)
        Me.plMain.Margin = New System.Windows.Forms.Padding(0)
        Me.plMain.Name = "plMain"
        Me.plMain.Size = New System.Drawing.Size(722, 351)
        Me.plMain.TabIndex = 2
        '
        'TasksPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.plMain)
        Me.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TasksPanel"
        Me.Size = New System.Drawing.Size(722, 351)
        Me.plMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents plLeftContainer As Panel
    Friend WithEvents plRightContainer As Panel
    Friend WithEvents plMain As Panel
End Class
