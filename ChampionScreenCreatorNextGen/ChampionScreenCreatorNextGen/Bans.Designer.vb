<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bans
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
        Me.Ban1 = New ChampionScreenCreatorNextGen.Ban()
        Me.Ban2 = New ChampionScreenCreatorNextGen.Ban()
        Me.Ban3 = New ChampionScreenCreatorNextGen.Ban()
        Me.SuspendLayout()
        '
        'Ban1
        '
        Me.Ban1.CHAMP = Nothing
        Me.Ban1.Location = New System.Drawing.Point(3, 3)
        Me.Ban1.Name = "Ban1"
        Me.Ban1.Size = New System.Drawing.Size(104, 93)
        Me.Ban1.TabIndex = 0
        '
        'Ban2
        '
        Me.Ban2.CHAMP = Nothing
        Me.Ban2.Location = New System.Drawing.Point(110, 3)
        Me.Ban2.Name = "Ban2"
        Me.Ban2.Size = New System.Drawing.Size(104, 93)
        Me.Ban2.TabIndex = 1
        '
        'Ban3
        '
        Me.Ban3.CHAMP = Nothing
        Me.Ban3.Location = New System.Drawing.Point(217, 3)
        Me.Ban3.Name = "Ban3"
        Me.Ban3.Size = New System.Drawing.Size(104, 93)
        Me.Ban3.TabIndex = 2
        '
        'Bans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Ban3)
        Me.Controls.Add(Me.Ban2)
        Me.Controls.Add(Me.Ban1)
        Me.Name = "Bans"
        Me.Size = New System.Drawing.Size(326, 101)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ban1 As ChampionScreenCreatorNextGen.Ban
    Friend WithEvents Ban2 As ChampionScreenCreatorNextGen.Ban
    Friend WithEvents Ban3 As ChampionScreenCreatorNextGen.Ban

End Class
