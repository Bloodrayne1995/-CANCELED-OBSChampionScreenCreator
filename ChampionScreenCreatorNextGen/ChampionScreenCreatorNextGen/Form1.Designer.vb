<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ZurücksetzenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedSide = New ChampionScreenCreatorNextGen.Side()
        Me.BlueSide = New ChampionScreenCreatorNextGen.Side()
        Me.ChampionAuswahl1 = New ChampionScreenCreatorNextGen.ChampionAuswahl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ZurücksetzenToolStripMenuItem, Me.TeamManagementToolStripMenuItem, Me.OptionenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1326, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'ZurücksetzenToolStripMenuItem
        '
        Me.ZurücksetzenToolStripMenuItem.Name = "ZurücksetzenToolStripMenuItem"
        Me.ZurücksetzenToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ZurücksetzenToolStripMenuItem.Text = "Zurücksetzen"
        '
        'TeamManagementToolStripMenuItem
        '
        Me.TeamManagementToolStripMenuItem.Name = "TeamManagementToolStripMenuItem"
        Me.TeamManagementToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.TeamManagementToolStripMenuItem.Text = "Team-Management"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'RedSide
        '
        Me.RedSide.AllowDrop = True
        Me.RedSide.Location = New System.Drawing.Point(983, 31)
        Me.RedSide.Name = "RedSide"
        Me.RedSide.Size = New System.Drawing.Size(332, 521)
        Me.RedSide.TabIndex = 2
        '
        'BlueSide
        '
        Me.BlueSide.AllowDrop = True
        Me.BlueSide.Location = New System.Drawing.Point(13, 31)
        Me.BlueSide.Name = "BlueSide"
        Me.BlueSide.Size = New System.Drawing.Size(332, 521)
        Me.BlueSide.TabIndex = 1
        '
        'ChampionAuswahl1
        '
        Me.ChampionAuswahl1.Location = New System.Drawing.Point(351, 31)
        Me.ChampionAuswahl1.Name = "ChampionAuswahl1"
        Me.ChampionAuswahl1.Size = New System.Drawing.Size(625, 428)
        Me.ChampionAuswahl1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 555)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RedSide)
        Me.Controls.Add(Me.BlueSide)
        Me.Controls.Add(Me.ChampionAuswahl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Next generation ChampionScreenCreator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChampionAuswahl1 As ChampionScreenCreatorNextGen.ChampionAuswahl
    Friend WithEvents BlueSide As ChampionScreenCreatorNextGen.Side
    Friend WithEvents RedSide As ChampionScreenCreatorNextGen.Side
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZurücksetzenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
