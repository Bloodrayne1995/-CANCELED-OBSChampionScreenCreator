<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.pctIcon = New System.Windows.Forms.PictureBox()
        Me.lblLade1 = New System.Windows.Forms.Label()
        Me.lblChamp = New System.Windows.Forms.Label()
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctIcon
        '
        Me.pctIcon.BackColor = System.Drawing.Color.Transparent
        Me.pctIcon.Image = Global.ChampionScreenCreatorNextGen.My.Resources.Resources.icon
        Me.pctIcon.Location = New System.Drawing.Point(12, 12)
        Me.pctIcon.Name = "pctIcon"
        Me.pctIcon.Size = New System.Drawing.Size(128, 128)
        Me.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIcon.TabIndex = 0
        Me.pctIcon.TabStop = False
        '
        'lblLade1
        '
        Me.lblLade1.BackColor = System.Drawing.Color.Transparent
        Me.lblLade1.ForeColor = System.Drawing.Color.Lime
        Me.lblLade1.Location = New System.Drawing.Point(183, 234)
        Me.lblLade1.Name = "lblLade1"
        Me.lblLade1.Size = New System.Drawing.Size(301, 19)
        Me.lblLade1.TabIndex = 1
        Me.lblLade1.Text = "Lade"
        '
        'lblChamp
        '
        Me.lblChamp.BackColor = System.Drawing.Color.Transparent
        Me.lblChamp.ForeColor = System.Drawing.Color.Lime
        Me.lblChamp.Location = New System.Drawing.Point(183, 253)
        Me.lblChamp.Name = "lblChamp"
        Me.lblChamp.Size = New System.Drawing.Size(301, 23)
        Me.lblChamp.TabIndex = 2
        Me.lblChamp.Text = "Lade"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ChampionScreenCreatorNextGen.My.Resources.Resources.morgana_vs_ahri_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblChamp)
        Me.Controls.Add(Me.lblLade1)
        Me.Controls.Add(Me.pctIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblLade1 As System.Windows.Forms.Label
    Friend WithEvents lblChamp As System.Windows.Forms.Label

End Class
