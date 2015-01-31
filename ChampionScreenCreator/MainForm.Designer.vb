<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZeigeTestImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusgabeOptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchriftartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTeamBlue = New System.Windows.Forms.Panel()
        Me.grpBlauAufstellung = New System.Windows.Forms.GroupBox()
        Me.grpBlauTeam = New System.Windows.Forms.GroupBox()
        Me.grpBlauBanns = New System.Windows.Forms.GroupBox()
        Me.pnlTeamRed = New System.Windows.Forms.Panel()
        Me.grpRotAufstellung = New System.Windows.Forms.GroupBox()
        Me.grpRotTeam = New System.Windows.Forms.GroupBox()
        Me.grpRotBanns = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdVorschau = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTeamBlue.SuspendLayout()
        Me.pnlTeamRed.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.OptionenToolStripMenuItem1, Me.ToolStripComboBox1, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1079, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Abwechselnde Wahl", "Freie Wahl"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(150, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZeigeTestImageToolStripMenuItem, Me.SaveTestToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(90, 23)
        Me.ToolStripMenuItem1.Text = "Debug-Menu"
        '
        'ZeigeTestImageToolStripMenuItem
        '
        Me.ZeigeTestImageToolStripMenuItem.Name = "ZeigeTestImageToolStripMenuItem"
        Me.ZeigeTestImageToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ZeigeTestImageToolStripMenuItem.Text = "zeige Test Image"
        '
        'SaveTestToolStripMenuItem
        '
        Me.SaveTestToolStripMenuItem.Name = "SaveTestToolStripMenuItem"
        Me.SaveTestToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveTestToolStripMenuItem.Text = "save-Test"
        '
        'OptionenToolStripMenuItem1
        '
        Me.OptionenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusgabeOptionenToolStripMenuItem, Me.SchriftartenToolStripMenuItem})
        Me.OptionenToolStripMenuItem1.Name = "OptionenToolStripMenuItem1"
        Me.OptionenToolStripMenuItem1.Size = New System.Drawing.Size(69, 23)
        Me.OptionenToolStripMenuItem1.Text = "Optionen"
        '
        'AusgabeOptionenToolStripMenuItem
        '
        Me.AusgabeOptionenToolStripMenuItem.Name = "AusgabeOptionenToolStripMenuItem"
        Me.AusgabeOptionenToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AusgabeOptionenToolStripMenuItem.Text = "Ausgabe-Optionen"
        '
        'SchriftartenToolStripMenuItem
        '
        Me.SchriftartenToolStripMenuItem.Name = "SchriftartenToolStripMenuItem"
        Me.SchriftartenToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SchriftartenToolStripMenuItem.Text = "Schriftarten"
        '
        'pnlTeamBlue
        '
        Me.pnlTeamBlue.BackColor = System.Drawing.Color.Transparent
        Me.pnlTeamBlue.Controls.Add(Me.grpBlauAufstellung)
        Me.pnlTeamBlue.Controls.Add(Me.grpBlauTeam)
        Me.pnlTeamBlue.Controls.Add(Me.grpBlauBanns)
        Me.pnlTeamBlue.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeamBlue.Location = New System.Drawing.Point(0, 27)
        Me.pnlTeamBlue.Name = "pnlTeamBlue"
        Me.pnlTeamBlue.Size = New System.Drawing.Size(267, 578)
        Me.pnlTeamBlue.TabIndex = 1
        '
        'grpBlauAufstellung
        '
        Me.grpBlauAufstellung.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBlauAufstellung.Location = New System.Drawing.Point(0, 0)
        Me.grpBlauAufstellung.Name = "grpBlauAufstellung"
        Me.grpBlauAufstellung.Size = New System.Drawing.Size(267, 362)
        Me.grpBlauAufstellung.TabIndex = 2
        Me.grpBlauAufstellung.TabStop = False
        Me.grpBlauAufstellung.Text = "Aufstellung"
        '
        'grpBlauTeam
        '
        Me.grpBlauTeam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpBlauTeam.Location = New System.Drawing.Point(0, 368)
        Me.grpBlauTeam.Name = "grpBlauTeam"
        Me.grpBlauTeam.Size = New System.Drawing.Size(267, 100)
        Me.grpBlauTeam.TabIndex = 1
        Me.grpBlauTeam.TabStop = False
        Me.grpBlauTeam.Text = "Team:"
        '
        'grpBlauBanns
        '
        Me.grpBlauBanns.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpBlauBanns.Location = New System.Drawing.Point(0, 468)
        Me.grpBlauBanns.Name = "grpBlauBanns"
        Me.grpBlauBanns.Size = New System.Drawing.Size(267, 110)
        Me.grpBlauBanns.TabIndex = 0
        Me.grpBlauBanns.TabStop = False
        Me.grpBlauBanns.Text = "Banns:"
        '
        'pnlTeamRed
        '
        Me.pnlTeamRed.BackColor = System.Drawing.Color.Transparent
        Me.pnlTeamRed.Controls.Add(Me.grpRotAufstellung)
        Me.pnlTeamRed.Controls.Add(Me.grpRotTeam)
        Me.pnlTeamRed.Controls.Add(Me.grpRotBanns)
        Me.pnlTeamRed.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTeamRed.Location = New System.Drawing.Point(812, 27)
        Me.pnlTeamRed.Name = "pnlTeamRed"
        Me.pnlTeamRed.Size = New System.Drawing.Size(267, 578)
        Me.pnlTeamRed.TabIndex = 2
        '
        'grpRotAufstellung
        '
        Me.grpRotAufstellung.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRotAufstellung.Location = New System.Drawing.Point(0, 0)
        Me.grpRotAufstellung.Name = "grpRotAufstellung"
        Me.grpRotAufstellung.Size = New System.Drawing.Size(267, 362)
        Me.grpRotAufstellung.TabIndex = 3
        Me.grpRotAufstellung.TabStop = False
        Me.grpRotAufstellung.Text = "Aufstellung"
        '
        'grpRotTeam
        '
        Me.grpRotTeam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpRotTeam.Location = New System.Drawing.Point(0, 368)
        Me.grpRotTeam.Name = "grpRotTeam"
        Me.grpRotTeam.Size = New System.Drawing.Size(267, 100)
        Me.grpRotTeam.TabIndex = 2
        Me.grpRotTeam.TabStop = False
        Me.grpRotTeam.Text = "Team:"
        '
        'grpRotBanns
        '
        Me.grpRotBanns.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpRotBanns.Location = New System.Drawing.Point(0, 468)
        Me.grpRotBanns.Name = "grpRotBanns"
        Me.grpRotBanns.Size = New System.Drawing.Size(267, 110)
        Me.grpRotBanns.TabIndex = 1
        Me.grpRotBanns.TabStop = False
        Me.grpRotBanns.Text = "Banns:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(267, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOK)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdVorschau)
        Me.SplitContainer1.Size = New System.Drawing.Size(545, 578)
        Me.SplitContainer1.SplitterDistance = 478
        Me.SplitContainer1.TabIndex = 3
        '
        'cmdReset
        '
        Me.cmdReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReset.Location = New System.Drawing.Point(302, 61)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 2
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(464, 61)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "Generieren"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdVorschau
        '
        Me.cmdVorschau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdVorschau.Location = New System.Drawing.Point(383, 61)
        Me.cmdVorschau.Name = "cmdVorschau"
        Me.cmdVorschau.Size = New System.Drawing.Size(75, 23)
        Me.cmdVorschau.TabIndex = 1
        Me.cmdVorschau.Text = "Vorschau"
        Me.cmdVorschau.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 605)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlTeamRed)
        Me.Controls.Add(Me.pnlTeamBlue)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Champion Screen Creator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTeamBlue.ResumeLayout(False)
        Me.pnlTeamRed.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents pnlTeamBlue As System.Windows.Forms.Panel
    Friend WithEvents grpBlauAufstellung As System.Windows.Forms.GroupBox
    Friend WithEvents grpBlauTeam As System.Windows.Forms.GroupBox
    Friend WithEvents grpBlauBanns As System.Windows.Forms.GroupBox
    Friend WithEvents pnlTeamRed As System.Windows.Forms.Panel
    Friend WithEvents grpRotAufstellung As System.Windows.Forms.GroupBox
    Friend WithEvents grpRotTeam As System.Windows.Forms.GroupBox
    Friend WithEvents grpRotBanns As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdVorschau As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZeigeTestImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusgabeOptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchriftartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
