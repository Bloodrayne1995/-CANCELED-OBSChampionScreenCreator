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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTeamRed = New System.Windows.Forms.ComboBox()
        Me.cmdRedSupport = New System.Windows.Forms.Button()
        Me.cmdRedADC = New System.Windows.Forms.Button()
        Me.cmdRedMid = New System.Windows.Forms.Button()
        Me.cmdRedJungle = New System.Windows.Forms.Button()
        Me.cmdRedTop = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTeamBlue = New System.Windows.Forms.ComboBox()
        Me.cmdBlauSupport = New System.Windows.Forms.Button()
        Me.cmdBlauADC = New System.Windows.Forms.Button()
        Me.cmdBlauMid = New System.Windows.Forms.Button()
        Me.cmdBlauJungle = New System.Windows.Forms.Button()
        Me.cmdBlauTop = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdShowFileDialog = New System.Windows.Forms.Button()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbTeamRed)
        Me.GroupBox1.Controls.Add(Me.cmdRedSupport)
        Me.GroupBox1.Controls.Add(Me.cmdRedADC)
        Me.GroupBox1.Controls.Add(Me.cmdRedMid)
        Me.GroupBox1.Controls.Add(Me.cmdRedJungle)
        Me.GroupBox1.Controls.Add(Me.cmdRedTop)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(13, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 398)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Team Rot"
        '
        'cmbTeamRed
        '
        Me.cmbTeamRed.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbTeamRed.FormattingEnabled = True
        Me.cmbTeamRed.Location = New System.Drawing.Point(3, 374)
        Me.cmbTeamRed.Name = "cmbTeamRed"
        Me.cmbTeamRed.Size = New System.Drawing.Size(227, 21)
        Me.cmbTeamRed.TabIndex = 5
        '
        'cmdRedSupport
        '
        Me.cmdRedSupport.ForeColor = System.Drawing.Color.Red
        Me.cmdRedSupport.Location = New System.Drawing.Point(87, 299)
        Me.cmdRedSupport.Name = "cmdRedSupport"
        Me.cmdRedSupport.Size = New System.Drawing.Size(64, 64)
        Me.cmdRedSupport.TabIndex = 4
        Me.cmdRedSupport.Text = "SUP"
        Me.cmdRedSupport.UseVisualStyleBackColor = True
        '
        'cmdRedADC
        '
        Me.cmdRedADC.ForeColor = System.Drawing.Color.Red
        Me.cmdRedADC.Location = New System.Drawing.Point(87, 229)
        Me.cmdRedADC.Name = "cmdRedADC"
        Me.cmdRedADC.Size = New System.Drawing.Size(64, 64)
        Me.cmdRedADC.TabIndex = 3
        Me.cmdRedADC.Text = "ADC"
        Me.cmdRedADC.UseVisualStyleBackColor = True
        '
        'cmdRedMid
        '
        Me.cmdRedMid.ForeColor = System.Drawing.Color.Red
        Me.cmdRedMid.Location = New System.Drawing.Point(87, 159)
        Me.cmdRedMid.Name = "cmdRedMid"
        Me.cmdRedMid.Size = New System.Drawing.Size(64, 64)
        Me.cmdRedMid.TabIndex = 2
        Me.cmdRedMid.Text = "MID"
        Me.cmdRedMid.UseVisualStyleBackColor = True
        '
        'cmdRedJungle
        '
        Me.cmdRedJungle.ForeColor = System.Drawing.Color.Red
        Me.cmdRedJungle.Location = New System.Drawing.Point(87, 89)
        Me.cmdRedJungle.Name = "cmdRedJungle"
        Me.cmdRedJungle.Size = New System.Drawing.Size(64, 64)
        Me.cmdRedJungle.TabIndex = 1
        Me.cmdRedJungle.Text = "JNG"
        Me.cmdRedJungle.UseVisualStyleBackColor = True
        '
        'cmdRedTop
        '
        Me.cmdRedTop.ForeColor = System.Drawing.Color.Red
        Me.cmdRedTop.Location = New System.Drawing.Point(87, 19)
        Me.cmdRedTop.Name = "cmdRedTop"
        Me.cmdRedTop.Size = New System.Drawing.Size(64, 64)
        Me.cmdRedTop.TabIndex = 0
        Me.cmdRedTop.Text = "TOP"
        Me.cmdRedTop.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbTeamBlue)
        Me.GroupBox2.Controls.Add(Me.cmdBlauSupport)
        Me.GroupBox2.Controls.Add(Me.cmdBlauADC)
        Me.GroupBox2.Controls.Add(Me.cmdBlauMid)
        Me.GroupBox2.Controls.Add(Me.cmdBlauJungle)
        Me.GroupBox2.Controls.Add(Me.cmdBlauTop)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(326, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 398)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Team Blau"
        '
        'cmbTeamBlue
        '
        Me.cmbTeamBlue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbTeamBlue.FormattingEnabled = True
        Me.cmbTeamBlue.Location = New System.Drawing.Point(3, 374)
        Me.cmbTeamBlue.Name = "cmbTeamBlue"
        Me.cmbTeamBlue.Size = New System.Drawing.Size(227, 21)
        Me.cmbTeamBlue.TabIndex = 6
        '
        'cmdBlauSupport
        '
        Me.cmdBlauSupport.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdBlauSupport.Location = New System.Drawing.Point(87, 299)
        Me.cmdBlauSupport.Name = "cmdBlauSupport"
        Me.cmdBlauSupport.Size = New System.Drawing.Size(64, 64)
        Me.cmdBlauSupport.TabIndex = 4
        Me.cmdBlauSupport.Text = "SUP"
        Me.cmdBlauSupport.UseVisualStyleBackColor = True
        '
        'cmdBlauADC
        '
        Me.cmdBlauADC.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdBlauADC.Location = New System.Drawing.Point(87, 229)
        Me.cmdBlauADC.Name = "cmdBlauADC"
        Me.cmdBlauADC.Size = New System.Drawing.Size(64, 64)
        Me.cmdBlauADC.TabIndex = 3
        Me.cmdBlauADC.Text = "ADC"
        Me.cmdBlauADC.UseVisualStyleBackColor = True
        '
        'cmdBlauMid
        '
        Me.cmdBlauMid.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdBlauMid.Location = New System.Drawing.Point(87, 159)
        Me.cmdBlauMid.Name = "cmdBlauMid"
        Me.cmdBlauMid.Size = New System.Drawing.Size(64, 64)
        Me.cmdBlauMid.TabIndex = 2
        Me.cmdBlauMid.Text = "MID"
        Me.cmdBlauMid.UseVisualStyleBackColor = True
        '
        'cmdBlauJungle
        '
        Me.cmdBlauJungle.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdBlauJungle.Location = New System.Drawing.Point(87, 89)
        Me.cmdBlauJungle.Name = "cmdBlauJungle"
        Me.cmdBlauJungle.Size = New System.Drawing.Size(64, 64)
        Me.cmdBlauJungle.TabIndex = 1
        Me.cmdBlauJungle.Text = "JNG"
        Me.cmdBlauJungle.UseVisualStyleBackColor = True
        '
        'cmdBlauTop
        '
        Me.cmdBlauTop.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdBlauTop.Location = New System.Drawing.Point(87, 19)
        Me.cmdBlauTop.Name = "cmdBlauTop"
        Me.cmdBlauTop.Size = New System.Drawing.Size(64, 64)
        Me.cmdBlauTop.TabIndex = 0
        Me.cmdBlauTop.Text = "TOP"
        Me.cmdBlauTop.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmdShowFileDialog)
        Me.GroupBox3.Controls.Add(Me.cmdPreview)
        Me.GroupBox3.Controls.Add(Me.cmdGenerate)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 442)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 45)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ausgabe"
        '
        'cmdShowFileDialog
        '
        Me.cmdShowFileDialog.ForeColor = System.Drawing.Color.Black
        Me.cmdShowFileDialog.Location = New System.Drawing.Point(267, 16)
        Me.cmdShowFileDialog.Name = "cmdShowFileDialog"
        Me.cmdShowFileDialog.Size = New System.Drawing.Size(55, 23)
        Me.cmdShowFileDialog.TabIndex = 3
        Me.cmdShowFileDialog.Text = ". . ."
        Me.cmdShowFileDialog.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.ForeColor = System.Drawing.Color.Black
        Me.cmdPreview.Location = New System.Drawing.Point(328, 16)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(103, 23)
        Me.cmdPreview.TabIndex = 2
        Me.cmdPreview.Text = "Vorschau"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdGenerate
        '
        Me.cmdGenerate.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerate.Location = New System.Drawing.Point(437, 16)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(103, 23)
        Me.cmdGenerate.TabIndex = 1
        Me.cmdGenerate.Text = "Generieren"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(6, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.TeamsToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(571, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem, Me.ToolStripSeparator1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'TeamsToolStripMenuItem
        '
        Me.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem"
        Me.TeamsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.TeamsToolStripMenuItem.Text = "Teams"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 493)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "ChampionScreen Creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRedSupport As System.Windows.Forms.Button
    Friend WithEvents cmdRedADC As System.Windows.Forms.Button
    Friend WithEvents cmdRedMid As System.Windows.Forms.Button
    Friend WithEvents cmdRedJungle As System.Windows.Forms.Button
    Friend WithEvents cmdRedTop As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBlauSupport As System.Windows.Forms.Button
    Friend WithEvents cmdBlauADC As System.Windows.Forms.Button
    Friend WithEvents cmdBlauMid As System.Windows.Forms.Button
    Friend WithEvents cmdBlauJungle As System.Windows.Forms.Button
    Friend WithEvents cmdBlauTop As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdShowFileDialog As System.Windows.Forms.Button
    Friend WithEvents cmbTeamRed As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTeamBlue As System.Windows.Forms.ComboBox
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
