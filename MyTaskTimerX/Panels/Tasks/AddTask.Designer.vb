<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTaskPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTaskPanel))
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblTengoQue = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.MaskedTextBox()
        Me.txtMinutes = New System.Windows.Forms.MaskedTextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMinUp = New System.Windows.Forms.Button()
        Me.btnMinDown = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHourUp = New System.Windows.Forms.Button()
        Me.btnHourDown = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTaskName
        '
        Me.txtTaskName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTaskName.Font = New System.Drawing.Font("Bauhaus Lt BT", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTaskName.Location = New System.Drawing.Point(3, 36)
        Me.txtTaskName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(655, 48)
        Me.txtTaskName.TabIndex = 11
        Me.txtTaskName.Text = "Escribe el nombre de tu tarea..."
        Me.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMinutes
        '
        Me.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Bauhaus Md BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.Gray
        Me.lblMinutes.Location = New System.Drawing.Point(392, 21)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(106, 32)
        Me.lblMinutes.TabIndex = 8
        Me.lblMinutes.Text = "minutos"
        '
        'lblHours
        '
        Me.lblHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Bauhaus Md BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Gray
        Me.lblHours.Location = New System.Drawing.Point(171, 21)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(80, 32)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "horas"
        '
        'lblDuration
        '
        Me.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDuration.Font = New System.Drawing.Font("Bauhaus Md BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.Gray
        Me.lblDuration.Location = New System.Drawing.Point(3, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(659, 26)
        Me.lblDuration.TabIndex = 10
        Me.lblDuration.Text = "Esto me tomara..."
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTengoQue
        '
        Me.lblTengoQue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTengoQue.AutoSize = True
        Me.lblTengoQue.Font = New System.Drawing.Font("Bauhaus Md BT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTengoQue.ForeColor = System.Drawing.Color.Gray
        Me.lblTengoQue.Location = New System.Drawing.Point(266, 0)
        Me.lblTengoQue.Name = "lblTengoQue"
        Me.lblTengoQue.Size = New System.Drawing.Size(129, 26)
        Me.lblTengoQue.TabIndex = 10
        Me.lblTengoQue.Text = "Tengo qué..."
        '
        'txtHours
        '
        Me.txtHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHours.BackColor = System.Drawing.Color.White
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHours.Font = New System.Drawing.Font("Bauhaus Lt BT", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtHours.Location = New System.Drawing.Point(47, 6)
        Me.txtHours.Mask = "00"
        Me.txtHours.Name = "txtHours"
        Me.txtHours.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtHours.Size = New System.Drawing.Size(87, 68)
        Me.txtHours.TabIndex = 15
        Me.txtHours.Text = "00"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinutes
        '
        Me.txtMinutes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMinutes.BackColor = System.Drawing.Color.White
        Me.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMinutes.Font = New System.Drawing.Font("Bauhaus Lt BT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtMinutes.Location = New System.Drawing.Point(248, -2)
        Me.txtMinutes.Mask = "00"
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtMinutes.Size = New System.Drawing.Size(87, 77)
        Me.txtMinutes.TabIndex = 15
        Me.txtMinutes.Text = "00"
        Me.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ImageKey = "check64.png"
        Me.btnConfirm.ImageList = Me.MyImageList
        Me.btnConfirm.Location = New System.Drawing.Point(3, 0)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(25, 32)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "cancel22.png")
        Me.MyImageList.Images.SetKeyName(1, "check64.png")
        Me.MyImageList.Images.SetKeyName(2, "triangle2 - copia.png")
        Me.MyImageList.Images.SetKeyName(3, "triangle2.png")
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ImageKey = "cancel22.png"
        Me.btnCancel.ImageList = Me.MyImageList
        Me.btnCancel.Location = New System.Drawing.Point(30, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(25, 32)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.Controls.Add(Me.lblTengoQue)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtTaskName)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(14, 20)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(658, 89)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel3.Controls.Add(Me.lblDuration)
        Me.FlowLayoutPanel3.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(9, 148)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(667, 110)
        Me.FlowLayoutPanel3.TabIndex = 18
        Me.FlowLayoutPanel3.WrapContents = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.lblHours)
        Me.Panel2.Controls.Add(Me.lblMinutes)
        Me.Panel2.Controls.Add(Me.txtMinutes)
        Me.Panel2.Controls.Add(Me.txtHours)
        Me.Panel2.Location = New System.Drawing.Point(54, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 81)
        Me.Panel2.TabIndex = 17
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnMinUp, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnMinDown, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(341, 9)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(36, 55)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnMinUp
        '
        Me.btnMinUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMinUp.FlatAppearance.BorderSize = 0
        Me.btnMinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinUp.ImageIndex = 3
        Me.btnMinUp.ImageList = Me.MyImageList
        Me.btnMinUp.Location = New System.Drawing.Point(3, 3)
        Me.btnMinUp.Name = "btnMinUp"
        Me.btnMinUp.Size = New System.Drawing.Size(30, 21)
        Me.btnMinUp.TabIndex = 16
        Me.btnMinUp.UseVisualStyleBackColor = True
        '
        'btnMinDown
        '
        Me.btnMinDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMinDown.FlatAppearance.BorderSize = 0
        Me.btnMinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinDown.ImageIndex = 2
        Me.btnMinDown.ImageList = Me.MyImageList
        Me.btnMinDown.Location = New System.Drawing.Point(3, 30)
        Me.btnMinDown.Name = "btnMinDown"
        Me.btnMinDown.Size = New System.Drawing.Size(30, 22)
        Me.btnMinDown.TabIndex = 16
        Me.btnMinDown.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnHourUp, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnHourDown, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(129, 9)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(36, 55)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'btnHourUp
        '
        Me.btnHourUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHourUp.FlatAppearance.BorderSize = 0
        Me.btnHourUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHourUp.ImageIndex = 3
        Me.btnHourUp.ImageList = Me.MyImageList
        Me.btnHourUp.Location = New System.Drawing.Point(3, 3)
        Me.btnHourUp.Name = "btnHourUp"
        Me.btnHourUp.Size = New System.Drawing.Size(30, 21)
        Me.btnHourUp.TabIndex = 16
        Me.btnHourUp.UseVisualStyleBackColor = True
        '
        'btnHourDown
        '
        Me.btnHourDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHourDown.FlatAppearance.BorderSize = 0
        Me.btnHourDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHourDown.ImageIndex = 2
        Me.btnHourDown.ImageList = Me.MyImageList
        Me.btnHourDown.Location = New System.Drawing.Point(3, 30)
        Me.btnHourDown.Name = "btnHourDown"
        Me.btnHourDown.Size = New System.Drawing.Size(30, 22)
        Me.btnHourDown.TabIndex = 16
        Me.btnHourDown.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnConfirm)
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(636, 302)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(55, 33)
        Me.FlowLayoutPanel4.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.46377!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.53623!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(686, 276)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddTaskPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Font = New System.Drawing.Font("BakerSignet BT", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "AddTaskPanel"
        Me.Size = New System.Drawing.Size(694, 335)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblTengoQue As Label
    Friend WithEvents txtHours As MaskedTextBox
    Friend WithEvents txtMinutes As MaskedTextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnHourDown As Button
    Friend WithEvents btnHourUp As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnMinUp As Button
    Friend WithEvents btnMinDown As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
