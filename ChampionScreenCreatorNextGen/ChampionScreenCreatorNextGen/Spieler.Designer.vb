<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spieler
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.pnlChampionImage = New System.Windows.Forms.Panel()
        Me.lblRolle = New System.Windows.Forms.Label()
        Me.lblChampion = New System.Windows.Forms.Label()
        Me.lblPlayername = New System.Windows.Forms.Label()
        Me.cmdSwap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnlChampionImage
        '
        Me.pnlChampionImage.AllowDrop = True
        Me.pnlChampionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlChampionImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChampionImage.Location = New System.Drawing.Point(4, 4)
        Me.pnlChampionImage.Name = "pnlChampionImage"
        Me.pnlChampionImage.Size = New System.Drawing.Size(64, 64)
        Me.pnlChampionImage.TabIndex = 0
        '
        'lblRolle
        '
        Me.lblRolle.AutoSize = True
        Me.lblRolle.Location = New System.Drawing.Point(75, 4)
        Me.lblRolle.Name = "lblRolle"
        Me.lblRolle.Size = New System.Drawing.Size(38, 13)
        Me.lblRolle.TabIndex = 1
        Me.lblRolle.Text = "<rolle>"
        '
        'lblChampion
        '
        Me.lblChampion.AutoSize = True
        Me.lblChampion.Location = New System.Drawing.Point(75, 27)
        Me.lblChampion.Name = "lblChampion"
        Me.lblChampion.Size = New System.Drawing.Size(65, 13)
        Me.lblChampion.TabIndex = 2
        Me.lblChampion.Text = "<champion>"
        '
        'lblPlayername
        '
        Me.lblPlayername.AutoSize = True
        Me.lblPlayername.Location = New System.Drawing.Point(75, 55)
        Me.lblPlayername.Name = "lblPlayername"
        Me.lblPlayername.Size = New System.Drawing.Size(73, 13)
        Me.lblPlayername.TabIndex = 3
        Me.lblPlayername.Text = "<playername>"
        '
        'cmdSwap
        '
        Me.cmdSwap.BackgroundImage = Global.ChampionScreenCreatorNextGen.My.Resources.Resources.Arrow_Updown_icon
        Me.cmdSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSwap.FlatAppearance.BorderSize = 0
        Me.cmdSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSwap.Location = New System.Drawing.Point(196, 4)
        Me.cmdSwap.Name = "cmdSwap"
        Me.cmdSwap.Size = New System.Drawing.Size(24, 24)
        Me.cmdSwap.TabIndex = 4
        Me.cmdSwap.UseVisualStyleBackColor = True
        '
        'Spieler
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdSwap)
        Me.Controls.Add(Me.lblPlayername)
        Me.Controls.Add(Me.lblChampion)
        Me.Controls.Add(Me.lblRolle)
        Me.Controls.Add(Me.pnlChampionImage)
        Me.Name = "Spieler"
        Me.Size = New System.Drawing.Size(223, 72)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlChampionImage As System.Windows.Forms.Panel
    Friend WithEvents lblRolle As System.Windows.Forms.Label
    Friend WithEvents lblChampion As System.Windows.Forms.Label
    Friend WithEvents lblPlayername As System.Windows.Forms.Label
    Friend WithEvents cmdSwap As System.Windows.Forms.Button

End Class
