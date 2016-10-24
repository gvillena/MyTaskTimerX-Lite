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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMyTasks = New System.Windows.Forms.Button()
        Me.btnQuickTask = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblWelcome, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNewTask, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMyTasks, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnQuickTask, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 14)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 141)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblWelcome, 3)
        Me.lblWelcome.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblWelcome.Location = New System.Drawing.Point(108, 16)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(87, 25)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "BIENVENIDO"
        '
        'btnNewTask
        '
        Me.btnNewTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewTask.FlatAppearance.BorderSize = 0
        Me.btnNewTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTask.Font = New System.Drawing.Font("Bauhaus Md BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTask.ImageIndex = 0
        Me.btnNewTask.ImageList = Me.MyImageList
        Me.btnNewTask.Location = New System.Drawing.Point(13, 63)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(75, 71)
        Me.btnNewTask.TabIndex = 2
        Me.btnNewTask.Text = "Agregar Tarea"
        Me.btnNewTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "electron (1).png")
        Me.MyImageList.Images.SetKeyName(1, "lightning39 (1).png")
        Me.MyImageList.Images.SetKeyName(2, "tasks2 (1).png")
        '
        'btnMyTasks
        '
        Me.btnMyTasks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMyTasks.FlatAppearance.BorderSize = 0
        Me.btnMyTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMyTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyTasks.Font = New System.Drawing.Font("Bauhaus Md BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyTasks.ImageIndex = 2
        Me.btnMyTasks.ImageList = Me.MyImageList
        Me.btnMyTasks.Location = New System.Drawing.Point(114, 63)
        Me.btnMyTasks.Name = "btnMyTasks"
        Me.btnMyTasks.Size = New System.Drawing.Size(75, 71)
        Me.btnMyTasks.TabIndex = 2
        Me.btnMyTasks.Text = "Agregar Tarea"
        Me.btnMyTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMyTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMyTasks.UseVisualStyleBackColor = True
        '
        'btnQuickTask
        '
        Me.btnQuickTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQuickTask.FlatAppearance.BorderSize = 0
        Me.btnQuickTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnQuickTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickTask.Font = New System.Drawing.Font("Bauhaus Md BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickTask.ImageIndex = 1
        Me.btnQuickTask.ImageList = Me.MyImageList
        Me.btnQuickTask.Location = New System.Drawing.Point(215, 63)
        Me.btnQuickTask.Name = "btnQuickTask"
        Me.btnQuickTask.Size = New System.Drawing.Size(75, 71)
        Me.btnQuickTask.TabIndex = 2
        Me.btnQuickTask.Text = "Agregar Tarea"
        Me.btnQuickTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuickTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQuickTask.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HomePanel"
        Me.Size = New System.Drawing.Size(321, 163)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnNewTask As Button
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents btnMyTasks As Button
    Friend WithEvents btnQuickTask As Button
End Class
