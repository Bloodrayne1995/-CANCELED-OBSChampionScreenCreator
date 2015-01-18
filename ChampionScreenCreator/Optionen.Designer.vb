<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optionen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbcOptionrn = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pctBackground = New System.Windows.Forms.PictureBox()
        Me.cmdBackgroundPathFinder = New System.Windows.Forms.Button()
        Me.txtBackgroundPath = New System.Windows.Forms.TextBox()
        Me.grpOutputSettings = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cmdFontAdd = New System.Windows.Forms.Button()
        Me.lstFonts = New System.Windows.Forms.ListBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSaveFont = New System.Windows.Forms.Button()
        Me.txtFontName = New System.Windows.Forms.TextBox()
        Me.tblFontForm = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAvaibleFonts = New System.Windows.Forms.ComboBox()
        Me.numFontSize = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pctFontColor = New System.Windows.Forms.Panel()
        Me.lblFontRGB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbFontAlignment = New System.Windows.Forms.ComboBox()
        Me.lblFontvorschau = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tbcOptionrn.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutputSettings.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.tblFontForm.SuspendLayout()
        CType(Me.numFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbcOptionrn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(542, 304)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.TabIndex = 0
        '
        'tbcOptionrn
        '
        Me.tbcOptionrn.Controls.Add(Me.TabPage2)
        Me.tbcOptionrn.Controls.Add(Me.TabPage1)
        Me.tbcOptionrn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptionrn.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptionrn.Name = "tbcOptionrn"
        Me.tbcOptionrn.SelectedIndex = 0
        Me.tbcOptionrn.Size = New System.Drawing.Size(542, 258)
        Me.tbcOptionrn.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.grpOutputSettings)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(534, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ausgabe"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pctBackground)
        Me.GroupBox2.Controls.Add(Me.cmdBackgroundPathFinder)
        Me.GroupBox2.Controls.Add(Me.txtBackgroundPath)
        Me.GroupBox2.Location = New System.Drawing.Point(207, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 220)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hintergrund-Bild:"
        '
        'pctBackground
        '
        Me.pctBackground.Location = New System.Drawing.Point(10, 51)
        Me.pctBackground.Name = "pctBackground"
        Me.pctBackground.Size = New System.Drawing.Size(302, 159)
        Me.pctBackground.TabIndex = 2
        Me.pctBackground.TabStop = False
        '
        'cmdBackgroundPathFinder
        '
        Me.cmdBackgroundPathFinder.Location = New System.Drawing.Point(266, 17)
        Me.cmdBackgroundPathFinder.Name = "cmdBackgroundPathFinder"
        Me.cmdBackgroundPathFinder.Size = New System.Drawing.Size(47, 23)
        Me.cmdBackgroundPathFinder.TabIndex = 1
        Me.cmdBackgroundPathFinder.Text = ". . ."
        Me.cmdBackgroundPathFinder.UseVisualStyleBackColor = True
        '
        'txtBackgroundPath
        '
        Me.txtBackgroundPath.Location = New System.Drawing.Point(7, 19)
        Me.txtBackgroundPath.Name = "txtBackgroundPath"
        Me.txtBackgroundPath.Size = New System.Drawing.Size(254, 20)
        Me.txtBackgroundPath.TabIndex = 0
        '
        'grpOutputSettings
        '
        Me.grpOutputSettings.Controls.Add(Me.CheckBox6)
        Me.grpOutputSettings.Controls.Add(Me.CheckBox5)
        Me.grpOutputSettings.Controls.Add(Me.CheckBox4)
        Me.grpOutputSettings.Controls.Add(Me.CheckBox3)
        Me.grpOutputSettings.Controls.Add(Me.CheckBox2)
        Me.grpOutputSettings.Controls.Add(Me.CheckBox1)
        Me.grpOutputSettings.Location = New System.Drawing.Point(8, 6)
        Me.grpOutputSettings.Name = "grpOutputSettings"
        Me.grpOutputSettings.Size = New System.Drawing.Size(193, 220)
        Me.grpOutputSettings.TabIndex = 0
        Me.grpOutputSettings.TabStop = False
        Me.grpOutputSettings.Text = "Einstellungen:"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(6, 134)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox6.TabIndex = 11
        Me.CheckBox6.Tag = "showBanner"
        Me.CheckBox6.Text = "Zeige Champion-Banner"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 111)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(132, 17)
        Me.CheckBox5.TabIndex = 10
        Me.CheckBox5.Tag = "showSquareIcons"
        Me.CheckBox5.Text = "Zeige Champion-Icons"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 88)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Tag = "showChampionNames"
        Me.CheckBox4.Text = "Zeige Champion-Name"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(119, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Tag = "showPlayerNames"
        Me.CheckBox3.Text = "Zeige Spieler-Name"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Tag = "showTeamNames"
        Me.CheckBox2.Text = "Zeige Team-Name"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Tag = "showTeamLogos"
        Me.CheckBox1.Text = "Zeige Team-Logos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(534, 232)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Schriftarten"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdFontAdd)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstFonts)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(528, 226)
        Me.SplitContainer2.SplitterDistance = 147
        Me.SplitContainer2.TabIndex = 0
        '
        'cmdFontAdd
        '
        Me.cmdFontAdd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdFontAdd.Location = New System.Drawing.Point(0, 203)
        Me.cmdFontAdd.Name = "cmdFontAdd"
        Me.cmdFontAdd.Size = New System.Drawing.Size(147, 23)
        Me.cmdFontAdd.TabIndex = 1
        Me.cmdFontAdd.Tag = "new"
        Me.cmdFontAdd.Text = "Hinzufügen"
        Me.cmdFontAdd.UseVisualStyleBackColor = True
        '
        'lstFonts
        '
        Me.lstFonts.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstFonts.FormattingEnabled = True
        Me.lstFonts.Location = New System.Drawing.Point(0, 0)
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(147, 199)
        Me.lstFonts.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.cmdDelete)
        Me.SplitContainer3.Panel1.Controls.Add(Me.cmdSaveFont)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtFontName)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.tblFontForm)
        Me.SplitContainer3.Size = New System.Drawing.Size(377, 226)
        Me.SplitContainer3.SplitterDistance = 34
        Me.SplitContainer3.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(212, 5)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Tag = "del"
        Me.cmdDelete.Text = "Löschen"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSaveFont
        '
        Me.cmdSaveFont.Location = New System.Drawing.Point(293, 5)
        Me.cmdSaveFont.Name = "cmdSaveFont"
        Me.cmdSaveFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveFont.TabIndex = 1
        Me.cmdSaveFont.Text = "Speichern"
        Me.cmdSaveFont.UseVisualStyleBackColor = True
        '
        'txtFontName
        '
        Me.txtFontName.Location = New System.Drawing.Point(3, 7)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(203, 20)
        Me.txtFontName.TabIndex = 0
        '
        'tblFontForm
        '
        Me.tblFontForm.ColumnCount = 2
        Me.tblFontForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31148!))
        Me.tblFontForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68852!))
        Me.tblFontForm.Controls.Add(Me.Label2, 0, 2)
        Me.tblFontForm.Controls.Add(Me.Label3, 0, 1)
        Me.tblFontForm.Controls.Add(Me.Label1, 0, 0)
        Me.tblFontForm.Controls.Add(Me.cmbAvaibleFonts, 1, 0)
        Me.tblFontForm.Controls.Add(Me.numFontSize, 1, 1)
        Me.tblFontForm.Controls.Add(Me.FlowLayoutPanel1, 1, 2)
        Me.tblFontForm.Controls.Add(Me.Label4, 0, 3)
        Me.tblFontForm.Controls.Add(Me.cmbFontAlignment, 1, 3)
        Me.tblFontForm.Controls.Add(Me.lblFontvorschau, 1, 4)
        Me.tblFontForm.Location = New System.Drawing.Point(6, 3)
        Me.tblFontForm.Name = "tblFontForm"
        Me.tblFontForm.RowCount = 5
        Me.tblFontForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblFontForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblFontForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tblFontForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblFontForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tblFontForm.Size = New System.Drawing.Size(366, 168)
        Me.tblFontForm.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Farbe:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Größe:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schriftart:"
        '
        'cmbAvaibleFonts
        '
        Me.cmbAvaibleFonts.FormattingEnabled = True
        Me.cmbAvaibleFonts.Location = New System.Drawing.Point(81, 3)
        Me.cmbAvaibleFonts.Name = "cmbAvaibleFonts"
        Me.cmbAvaibleFonts.Size = New System.Drawing.Size(207, 21)
        Me.cmbAvaibleFonts.TabIndex = 3
        '
        'numFontSize
        '
        Me.numFontSize.Location = New System.Drawing.Point(81, 28)
        Me.numFontSize.Name = "numFontSize"
        Me.numFontSize.Size = New System.Drawing.Size(207, 20)
        Me.numFontSize.TabIndex = 4
        Me.numFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.pctFontColor)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblFontRGB)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(81, 53)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(207, 21)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'pctFontColor
        '
        Me.pctFontColor.Location = New System.Drawing.Point(3, 3)
        Me.pctFontColor.Name = "pctFontColor"
        Me.pctFontColor.Size = New System.Drawing.Size(16, 16)
        Me.pctFontColor.TabIndex = 0
        '
        'lblFontRGB
        '
        Me.lblFontRGB.AutoSize = True
        Me.lblFontRGB.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblFontRGB.Location = New System.Drawing.Point(25, 0)
        Me.lblFontRGB.Name = "lblFontRGB"
        Me.lblFontRGB.Size = New System.Drawing.Size(36, 22)
        Me.lblFontRGB.TabIndex = 1
        Me.lblFontRGB.Text = "RGB: "
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Location = New System.Drawing.Point(3, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ausrichtung: "
        '
        'cmbFontAlignment
        '
        Me.cmbFontAlignment.FormattingEnabled = True
        Me.cmbFontAlignment.Items.AddRange(New Object() {"Linksbündig", "Zentriert", "Rechtsbündig"})
        Me.cmbFontAlignment.Location = New System.Drawing.Point(81, 86)
        Me.cmbFontAlignment.Name = "cmbFontAlignment"
        Me.cmbFontAlignment.Size = New System.Drawing.Size(207, 21)
        Me.cmbFontAlignment.TabIndex = 8
        '
        'lblFontvorschau
        '
        Me.lblFontvorschau.AutoSize = True
        Me.lblFontvorschau.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblFontvorschau.Location = New System.Drawing.Point(81, 155)
        Me.lblFontvorschau.Name = "lblFontvorschau"
        Me.lblFontvorschau.Size = New System.Drawing.Size(282, 13)
        Me.lblFontvorschau.TabIndex = 9
        Me.lblFontvorschau.Text = "Test-Text"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(382, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 36)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Abbrechen"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(463, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 36)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Speichern"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Optionen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 304)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Optionen"
        Me.ShowIcon = False
        Me.Text = "Optionen"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tbcOptionrn.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutputSettings.ResumeLayout(False)
        Me.grpOutputSettings.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.tblFontForm.ResumeLayout(False)
        Me.tblFontForm.PerformLayout()
        CType(Me.numFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tbcOptionrn As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpOutputSettings As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents pctBackground As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBackgroundPathFinder As System.Windows.Forms.Button
    Friend WithEvents txtBackgroundPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstFonts As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSaveFont As System.Windows.Forms.Button
    Friend WithEvents txtFontName As System.Windows.Forms.TextBox
    Friend WithEvents tblFontForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAvaibleFonts As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numFontSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pctFontColor As System.Windows.Forms.Panel
    Friend WithEvents lblFontRGB As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbFontAlignment As System.Windows.Forms.ComboBox
    Friend WithEvents lblFontvorschau As System.Windows.Forms.Label
    Friend WithEvents cmdFontAdd As System.Windows.Forms.Button
End Class
