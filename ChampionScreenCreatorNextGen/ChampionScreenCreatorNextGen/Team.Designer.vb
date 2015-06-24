<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Spieler1 = New ChampionScreenCreatorNextGen.Spieler()
        Me.Spieler2 = New ChampionScreenCreatorNextGen.Spieler()
        Me.Spieler3 = New ChampionScreenCreatorNextGen.Spieler()
        Me.Spieler4 = New ChampionScreenCreatorNextGen.Spieler()
        Me.Spieler5 = New ChampionScreenCreatorNextGen.Spieler()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Spieler1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Spieler2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Spieler3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Spieler4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Spieler5, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(225, 378)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Spieler1
        '
        Me.Spieler1.AllowDrop = True
        Me.Spieler1.CHAMPION = Nothing
        Me.Spieler1.Location = New System.Drawing.Point(3, 3)
        Me.Spieler1.Name = "Spieler1"
        Me.Spieler1.PLAYERNAME = "<playername>"
        Me.Spieler1.ROLLE = "<rolle>"
        Me.Spieler1.Size = New System.Drawing.Size(223, 68)
        Me.Spieler1.TabIndex = 0
        '
        'Spieler2
        '
        Me.Spieler2.AllowDrop = True
        Me.Spieler2.CHAMPION = Nothing
        Me.Spieler2.Location = New System.Drawing.Point(3, 77)
        Me.Spieler2.Name = "Spieler2"
        Me.Spieler2.PLAYERNAME = "<playername>"
        Me.Spieler2.ROLLE = "<rolle>"
        Me.Spieler2.Size = New System.Drawing.Size(223, 68)
        Me.Spieler2.TabIndex = 1
        '
        'Spieler3
        '
        Me.Spieler3.AllowDrop = True
        Me.Spieler3.CHAMPION = Nothing
        Me.Spieler3.Location = New System.Drawing.Point(3, 151)
        Me.Spieler3.Name = "Spieler3"
        Me.Spieler3.PLAYERNAME = "<playername>"
        Me.Spieler3.ROLLE = "<rolle>"
        Me.Spieler3.Size = New System.Drawing.Size(223, 68)
        Me.Spieler3.TabIndex = 2
        '
        'Spieler4
        '
        Me.Spieler4.AllowDrop = True
        Me.Spieler4.CHAMPION = Nothing
        Me.Spieler4.Location = New System.Drawing.Point(3, 225)
        Me.Spieler4.Name = "Spieler4"
        Me.Spieler4.PLAYERNAME = "<playername>"
        Me.Spieler4.ROLLE = "<rolle>"
        Me.Spieler4.Size = New System.Drawing.Size(223, 68)
        Me.Spieler4.TabIndex = 3
        '
        'Spieler5
        '
        Me.Spieler5.AllowDrop = True
        Me.Spieler5.CHAMPION = Nothing
        Me.Spieler5.Location = New System.Drawing.Point(3, 299)
        Me.Spieler5.Name = "Spieler5"
        Me.Spieler5.PLAYERNAME = "<playername>"
        Me.Spieler5.ROLLE = "<rolle>"
        Me.Spieler5.Size = New System.Drawing.Size(223, 72)
        Me.Spieler5.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 389)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Team
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Team"
        Me.Size = New System.Drawing.Size(236, 421)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Spieler1 As ChampionScreenCreatorNextGen.Spieler
    Friend WithEvents Spieler2 As ChampionScreenCreatorNextGen.Spieler
    Friend WithEvents Spieler3 As ChampionScreenCreatorNextGen.Spieler
    Friend WithEvents Spieler4 As ChampionScreenCreatorNextGen.Spieler
    Friend WithEvents Spieler5 As ChampionScreenCreatorNextGen.Spieler
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
