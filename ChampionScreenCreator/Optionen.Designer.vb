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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstFonts = New System.Windows.Forms.ListBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.txtFontName = New System.Windows.Forms.TextBox()
        Me.cmdSaveNew = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAvaibleFonts = New System.Windows.Forms.ComboBox()
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
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstFonts)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(528, 226)
        Me.SplitContainer2.SplitterDistance = 147
        Me.SplitContainer2.TabIndex = 0
        '
        'lstFonts
        '
        Me.lstFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFonts.FormattingEnabled = True
        Me.lstFonts.Location = New System.Drawing.Point(0, 0)
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(147, 226)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.cmdSaveNew)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtFontName)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer3.Size = New System.Drawing.Size(377, 226)
        Me.SplitContainer3.SplitterDistance = 34
        Me.SplitContainer3.TabIndex = 0
        '
        'txtFontName
        '
        Me.txtFontName.Location = New System.Drawing.Point(3, 7)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(203, 20)
        Me.txtFontName.TabIndex = 0
        '
        'cmdSaveNew
        '
        Me.cmdSaveNew.Location = New System.Drawing.Point(293, 5)
        Me.cmdSaveNew.Name = "cmdSaveNew"
        Me.cmdSaveNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveNew.TabIndex = 1
        Me.cmdSaveNew.Text = "Save / New"
        Me.cmdSaveNew.UseVisualStyleBackColor = True
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.67213!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.32787!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbAvaibleFonts, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 48)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schriftart:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Location = New System.Drawing.Point(3, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Größe:"
        '
        'cmbAvaibleFonts
        '
        Me.cmbAvaibleFonts.FormattingEnabled = True
        Me.cmbAvaibleFonts.Location = New System.Drawing.Point(74, 3)
        Me.cmbAvaibleFonts.Name = "cmbAvaibleFonts"
        Me.cmbAvaibleFonts.Size = New System.Drawing.Size(207, 21)
        Me.cmbAvaibleFonts.TabIndex = 3
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents cmdSaveNew As System.Windows.Forms.Button
    Friend WithEvents txtFontName As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAvaibleFonts As System.Windows.Forms.ComboBox
End Class
