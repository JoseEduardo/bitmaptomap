<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Export = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XOff = New System.Windows.Forms.NumericUpDown
        Me.YOff = New System.Windows.Forms.NumericUpDown
        Me.LoadFile = New System.Windows.Forms.OpenFileDialog
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.AddID = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.ColorKey = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Colorize = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Imagebx = New System.Windows.Forms.PictureBox
        Me.actionProgress = New System.Windows.Forms.ProgressBar
        Me.Load = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.Flip = New System.Windows.Forms.Button
        Me.RotateRight = New System.Windows.Forms.Button
        Me.RotateLeft = New System.Windows.Forms.Button
        Me.ColorDialog = New System.Windows.Forms.ColorDialog
        Me.Color1 = New System.Windows.Forms.Button
        Me.Color1Dialog = New System.Windows.Forms.Button
        Me.Color2Dialog = New System.Windows.Forms.Button
        Me.Color2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DefAction = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DefinitionMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectFolder = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.XOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Imagebx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Export
        '
        Me.Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Export.Location = New System.Drawing.Point(560, 364)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(144, 25)
        Me.Export.TabIndex = 3
        Me.Export.Text = "Export to .OTBM map"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Exported X Offset:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Exported Y Offset:"
        '
        'XOff
        '
        Me.XOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XOff.Location = New System.Drawing.Point(656, 312)
        Me.XOff.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.XOff.Name = "XOff"
        Me.XOff.Size = New System.Drawing.Size(48, 20)
        Me.XOff.TabIndex = 7
        '
        'YOff
        '
        Me.YOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YOff.Location = New System.Drawing.Point(656, 338)
        Me.YOff.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.YOff.Name = "YOff"
        Me.YOff.Size = New System.Drawing.Size(48, 20)
        Me.YOff.TabIndex = 8
        '
        'LoadFile
        '
        Me.LoadFile.FileName = "OpenFileDialog1"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ItemID"
        Me.ColumnHeader1.Width = 72
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Color1"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Color2"
        Me.ColumnHeader3.Width = 78
        '
        'AddID
        '
        Me.AddID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddID.Location = New System.Drawing.Point(124, 91)
        Me.AddID.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.AddID.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.AddID.Name = "AddID"
        Me.AddID.Size = New System.Drawing.Size(55, 20)
        Me.AddID.TabIndex = 31
        Me.AddID.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Range:"
        '
        'ColorKey
        '
        Me.ColorKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorKey.BackColor = System.Drawing.SystemColors.Window
        Me.ColorKey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ColorKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorKey.FullRowSelect = True
        Me.ColorKey.GridLines = True
        Me.ColorKey.Location = New System.Drawing.Point(253, 270)
        Me.ColorKey.MultiSelect = False
        Me.ColorKey.Name = "ColorKey"
        Me.ColorKey.Size = New System.Drawing.Size(301, 119)
        Me.ColorKey.TabIndex = 90
        Me.ColorKey.UseCompatibleStateImageBehavior = False
        Me.ColorKey.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ItemID"
        Me.ColumnHeader4.Width = 64
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Color1"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Color2"
        Me.ColumnHeader6.Width = 135
        '
        'Colorize
        '
        Me.Colorize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Colorize.Location = New System.Drawing.Point(560, 270)
        Me.Colorize.Name = "Colorize"
        Me.Colorize.Size = New System.Drawing.Size(144, 25)
        Me.Colorize.TabIndex = 91
        Me.Colorize.Text = "Colorize Map"
        Me.Colorize.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Imagebx)
        Me.Panel1.Location = New System.Drawing.Point(4, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 220)
        Me.Panel1.TabIndex = 96
        '
        'Imagebx
        '
        Me.Imagebx.BackColor = System.Drawing.Color.Transparent
        Me.Imagebx.Location = New System.Drawing.Point(0, 0)
        Me.Imagebx.Name = "Imagebx"
        Me.Imagebx.Size = New System.Drawing.Size(0, 0)
        Me.Imagebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Imagebx.TabIndex = 0
        Me.Imagebx.TabStop = False
        '
        'actionProgress
        '
        Me.actionProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actionProgress.Location = New System.Drawing.Point(125, 6)
        Me.actionProgress.Name = "actionProgress"
        Me.actionProgress.Size = New System.Drawing.Size(503, 32)
        Me.actionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.actionProgress.TabIndex = 103
        '
        'Load
        '
        Me.Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Load.Image = Global.BitMapToMap.My.Resources.Resources.Knob_Add
        Me.Load.Location = New System.Drawing.Point(634, 6)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(32, 32)
        Me.Load.TabIndex = 104
        Me.Load.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Load.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Image = Global.BitMapToMap.My.Resources.Resources.Undo_Changes
        Me.Clear.Location = New System.Drawing.Point(672, 6)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(32, 32)
        Me.Clear.TabIndex = 102
        Me.Clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Flip
        '
        Me.Flip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Flip.Image = Global.BitMapToMap.My.Resources.Resources.FlipLeft
        Me.Flip.Location = New System.Drawing.Point(87, 6)
        Me.Flip.Name = "Flip"
        Me.Flip.Size = New System.Drawing.Size(32, 32)
        Me.Flip.TabIndex = 100
        Me.Flip.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Flip.UseVisualStyleBackColor = True
        '
        'RotateRight
        '
        Me.RotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RotateRight.Image = Global.BitMapToMap.My.Resources.Resources.RotateRight
        Me.RotateRight.Location = New System.Drawing.Point(42, 6)
        Me.RotateRight.Name = "RotateRight"
        Me.RotateRight.Size = New System.Drawing.Size(32, 32)
        Me.RotateRight.TabIndex = 99
        Me.RotateRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RotateRight.UseVisualStyleBackColor = True
        '
        'RotateLeft
        '
        Me.RotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RotateLeft.Image = Global.BitMapToMap.My.Resources.Resources.RotateLeft
        Me.RotateLeft.Location = New System.Drawing.Point(4, 6)
        Me.RotateLeft.Name = "RotateLeft"
        Me.RotateLeft.Size = New System.Drawing.Size(32, 32)
        Me.RotateLeft.TabIndex = 98
        Me.RotateLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RotateLeft.UseVisualStyleBackColor = True
        '
        'ColorDialog
        '
        Me.ColorDialog.AnyColor = True
        Me.ColorDialog.FullOpen = True
        '
        'Color1
        '
        Me.Color1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Color1.Location = New System.Drawing.Point(6, 31)
        Me.Color1.Name = "Color1"
        Me.Color1.Size = New System.Drawing.Size(108, 31)
        Me.Color1.TabIndex = 105
        Me.Color1.Text = "Select..."
        Me.Color1.UseVisualStyleBackColor = True
        '
        'Color1Dialog
        '
        Me.Color1Dialog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Color1Dialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Color1Dialog.Location = New System.Drawing.Point(98, 31)
        Me.Color1Dialog.Name = "Color1Dialog"
        Me.Color1Dialog.Size = New System.Drawing.Size(16, 31)
        Me.Color1Dialog.TabIndex = 106
        Me.Color1Dialog.Text = "V"
        Me.Color1Dialog.UseVisualStyleBackColor = True
        '
        'Color2Dialog
        '
        Me.Color2Dialog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Color2Dialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Color2Dialog.Location = New System.Drawing.Point(216, 31)
        Me.Color2Dialog.Name = "Color2Dialog"
        Me.Color2Dialog.Size = New System.Drawing.Size(16, 31)
        Me.Color2Dialog.TabIndex = 108
        Me.Color2Dialog.Text = "V"
        Me.Color2Dialog.UseVisualStyleBackColor = True
        '
        'Color2
        '
        Me.Color2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Color2.Location = New System.Drawing.Point(124, 31)
        Me.Color2.Name = "Color2"
        Me.Color2.Size = New System.Drawing.Size(108, 31)
        Me.Color2.TabIndex = 107
        Me.Color2.Text = "Select..."
        Me.Color2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DefAction)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AddID)
        Me.GroupBox1.Controls.Add(Me.Color2Dialog)
        Me.GroupBox1.Controls.Add(Me.Color1Dialog)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Color2)
        Me.GroupBox1.Controls.Add(Me.Color1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 118)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Color Definition"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Ground ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Label4"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Action:"
        '
        'DefAction
        '
        Me.DefAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DefAction.FormattingEnabled = True
        Me.DefAction.Items.AddRange(New Object() {"Place Ground", "Ignore"})
        Me.DefAction.Location = New System.Drawing.Point(6, 91)
        Me.DefAction.Name = "DefAction"
        Me.DefAction.Size = New System.Drawing.Size(107, 21)
        Me.DefAction.TabIndex = 113
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(185, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 21)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DefinitionMenu
        '
        Me.DefinitionMenu.Name = "DefinitionMenu"
        Me.DefinitionMenu.Size = New System.Drawing.Size(61, 4)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.actionProgress)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Flip)
        Me.Controls.Add(Me.RotateRight)
        Me.Controls.Add(Me.RotateLeft)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Colorize)
        Me.Controls.Add(Me.ColorKey)
        Me.Controls.Add(Me.YOff)
        Me.Controls.Add(Me.XOff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Export)
        Me.MinimumSize = New System.Drawing.Size(727, 427)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "BitmapToMap - By DarkstaR [http://tools.tibiaug.com]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Imagebx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagebx As System.Windows.Forms.PictureBox
    Friend WithEvents Export As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XOff As System.Windows.Forms.NumericUpDown
    Friend WithEvents YOff As System.Windows.Forms.NumericUpDown
    Friend WithEvents LoadFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorKey As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colorize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RotateLeft As System.Windows.Forms.Button
    Friend WithEvents RotateRight As System.Windows.Forms.Button
    Friend WithEvents Flip As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents actionProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Load As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents Color1 As System.Windows.Forms.Button
    Friend WithEvents Color1Dialog As System.Windows.Forms.Button
    Friend WithEvents Color2Dialog As System.Windows.Forms.Button
    Friend WithEvents Color2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefAction As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DefinitionMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectFolder As System.Windows.Forms.FolderBrowserDialog

End Class
