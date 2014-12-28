<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team_Editor
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
        Me.trvTeams = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDeleteTeam = New System.Windows.Forms.Button()
        Me.cmdSaveTeam = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtJungle = New System.Windows.Forms.TextBox()
        Me.txtMid = New System.Windows.Forms.TextBox()
        Me.txtCarry = New System.Windows.Forms.TextBox()
        Me.txtSupport = New System.Windows.Forms.TextBox()
        Me.cmdSelectLogo = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddNewRegion = New System.Windows.Forms.Button()
        Me.cmdAddNewTeam = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvTeams
        '
        Me.trvTeams.Location = New System.Drawing.Point(13, 13)
        Me.trvTeams.Name = "trvTeams"
        Me.trvTeams.Size = New System.Drawing.Size(138, 308)
        Me.trvTeams.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDeleteTeam)
        Me.GroupBox1.Controls.Add(Me.cmdSaveTeam)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(158, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 351)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Team-Daten"
        '
        'cmdDeleteTeam
        '
        Me.cmdDeleteTeam.Location = New System.Drawing.Point(114, 314)
        Me.cmdDeleteTeam.Name = "cmdDeleteTeam"
        Me.cmdDeleteTeam.Size = New System.Drawing.Size(92, 31)
        Me.cmdDeleteTeam.TabIndex = 2
        Me.cmdDeleteTeam.Text = "Löschen"
        Me.cmdDeleteTeam.UseVisualStyleBackColor = True
        '
        'cmdSaveTeam
        '
        Me.cmdSaveTeam.Location = New System.Drawing.Point(212, 314)
        Me.cmdSaveTeam.Name = "cmdSaveTeam"
        Me.cmdSaveTeam.Size = New System.Drawing.Size(92, 31)
        Me.cmdSaveTeam.TabIndex = 1
        Me.cmdSaveTeam.Text = "Speichern"
        Me.cmdSaveTeam.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRegion, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTop, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtJungle, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMid, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCarry, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSupport, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSelectLogo, 1, 7)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(298, 289)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Logo: "
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Support: "
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Carry: "
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mid-Lane:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jungle: "
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Top-Lane:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region:"
        '
        'txtRegion
        '
        Me.txtRegion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRegion.Location = New System.Drawing.Point(78, 8)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(217, 20)
        Me.txtRegion.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Location = New System.Drawing.Point(78, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 20)
        Me.txtName.TabIndex = 16
        '
        'txtTop
        '
        Me.txtTop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTop.Location = New System.Drawing.Point(78, 80)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(217, 20)
        Me.txtTop.TabIndex = 17
        '
        'txtJungle
        '
        Me.txtJungle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtJungle.Location = New System.Drawing.Point(78, 116)
        Me.txtJungle.Name = "txtJungle"
        Me.txtJungle.Size = New System.Drawing.Size(217, 20)
        Me.txtJungle.TabIndex = 18
        '
        'txtMid
        '
        Me.txtMid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMid.Location = New System.Drawing.Point(78, 152)
        Me.txtMid.Name = "txtMid"
        Me.txtMid.Size = New System.Drawing.Size(217, 20)
        Me.txtMid.TabIndex = 19
        '
        'txtCarry
        '
        Me.txtCarry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCarry.Location = New System.Drawing.Point(78, 188)
        Me.txtCarry.Name = "txtCarry"
        Me.txtCarry.Size = New System.Drawing.Size(217, 20)
        Me.txtCarry.TabIndex = 20
        '
        'txtSupport
        '
        Me.txtSupport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSupport.Location = New System.Drawing.Point(78, 224)
        Me.txtSupport.Name = "txtSupport"
        Me.txtSupport.Size = New System.Drawing.Size(217, 20)
        Me.txtSupport.TabIndex = 21
        '
        'cmdSelectLogo
        '
        Me.cmdSelectLogo.Location = New System.Drawing.Point(78, 255)
        Me.cmdSelectLogo.Name = "cmdSelectLogo"
        Me.cmdSelectLogo.Size = New System.Drawing.Size(217, 31)
        Me.cmdSelectLogo.TabIndex = 23
        Me.cmdSelectLogo.Text = "Auswählen"
        Me.cmdSelectLogo.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(398, 370)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(317, 370)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Abbrechen"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdAddNewRegion
        '
        Me.cmdAddNewRegion.Location = New System.Drawing.Point(13, 327)
        Me.cmdAddNewRegion.Name = "cmdAddNewRegion"
        Me.cmdAddNewRegion.Size = New System.Drawing.Size(60, 31)
        Me.cmdAddNewRegion.TabIndex = 2
        Me.cmdAddNewRegion.Text = "+ Region"
        Me.cmdAddNewRegion.UseVisualStyleBackColor = True
        '
        'cmdAddNewTeam
        '
        Me.cmdAddNewTeam.Location = New System.Drawing.Point(91, 327)
        Me.cmdAddNewTeam.Name = "cmdAddNewTeam"
        Me.cmdAddNewTeam.Size = New System.Drawing.Size(60, 31)
        Me.cmdAddNewTeam.TabIndex = 4
        Me.cmdAddNewTeam.Text = "+ Team"
        Me.cmdAddNewTeam.UseVisualStyleBackColor = True
        '
        'Team_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 404)
        Me.Controls.Add(Me.cmdAddNewTeam)
        Me.Controls.Add(Me.cmdAddNewRegion)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.trvTeams)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Team_Editor"
        Me.Text = "Teams bearbeiten"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvTeams As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDeleteTeam As System.Windows.Forms.Button
    Friend WithEvents cmdSaveTeam As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdAddNewRegion As System.Windows.Forms.Button
    Friend WithEvents cmdAddNewTeam As System.Windows.Forms.Button
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    Friend WithEvents txtJungle As System.Windows.Forms.TextBox
    Friend WithEvents txtMid As System.Windows.Forms.TextBox
    Friend WithEvents txtCarry As System.Windows.Forms.TextBox
    Friend WithEvents txtSupport As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSelectLogo As System.Windows.Forms.Button
End Class
