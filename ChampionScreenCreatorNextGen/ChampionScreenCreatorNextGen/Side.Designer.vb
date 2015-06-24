<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Side
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
        Me.Bans1 = New ChampionScreenCreatorNextGen.Bans()
        Me.Team1 = New ChampionScreenCreatorNextGen.Team()
        Me.SuspendLayout()
        '
        'Bans1
        '
        Me.Bans1.Location = New System.Drawing.Point(4, 418)
        Me.Bans1.Name = "Bans1"
        Me.Bans1.Size = New System.Drawing.Size(326, 101)
        Me.Bans1.TabIndex = 1
        '
        'Team1
        '
        Me.Team1.AllowDrop = True
        Me.Team1.Location = New System.Drawing.Point(4, 4)
        Me.Team1.Name = "Team1"
        Me.Team1.Size = New System.Drawing.Size(236, 419)
        Me.Team1.TabIndex = 0
        '
        'Side
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Bans1)
        Me.Controls.Add(Me.Team1)
        Me.Name = "Side"
        Me.Size = New System.Drawing.Size(332, 521)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Team1 As ChampionScreenCreatorNextGen.Team
    Friend WithEvents Bans1 As ChampionScreenCreatorNextGen.Bans

End Class
