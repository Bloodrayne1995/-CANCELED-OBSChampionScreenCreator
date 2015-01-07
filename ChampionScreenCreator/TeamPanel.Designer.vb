<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamPanel
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
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblJungle = New System.Windows.Forms.Label()
        Me.lblMid = New System.Windows.Forms.Label()
        Me.lblCarry = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlJungle = New System.Windows.Forms.Panel()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.pnlCarry = New System.Windows.Forms.Panel()
        Me.pnlSupport = New System.Windows.Forms.Panel()
        Me.cmdTauscheTop = New System.Windows.Forms.Button()
        Me.cmdTauscheJungle = New System.Windows.Forms.Button()
        Me.cmdTauscheMid = New System.Windows.Forms.Button()
        Me.cmdTauscheCarry = New System.Windows.Forms.Button()
        Me.cmdTauscheSupport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlSupport, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCarry, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlMid, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSupport, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCarry, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMid, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblJungle, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTop, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlJungle, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTauscheTop, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTauscheJungle, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTauscheMid, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTauscheCarry, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTauscheSupport, 2, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(277, 340)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTop
        '
        Me.lblTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(67, 25)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(143, 13)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "Top:"
        '
        'lblJungle
        '
        Me.lblJungle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJungle.AutoSize = True
        Me.lblJungle.Location = New System.Drawing.Point(67, 94)
        Me.lblJungle.Name = "lblJungle"
        Me.lblJungle.Size = New System.Drawing.Size(143, 13)
        Me.lblJungle.TabIndex = 5
        Me.lblJungle.Text = "Jungle:"
        '
        'lblMid
        '
        Me.lblMid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMid.AutoSize = True
        Me.lblMid.Location = New System.Drawing.Point(67, 163)
        Me.lblMid.Name = "lblMid"
        Me.lblMid.Size = New System.Drawing.Size(143, 13)
        Me.lblMid.TabIndex = 9
        Me.lblMid.Text = "Mid: "
        '
        'lblCarry
        '
        Me.lblCarry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCarry.AutoSize = True
        Me.lblCarry.Location = New System.Drawing.Point(67, 232)
        Me.lblCarry.Name = "lblCarry"
        Me.lblCarry.Size = New System.Drawing.Size(143, 13)
        Me.lblCarry.TabIndex = 13
        Me.lblCarry.Text = "Carry: "
        '
        'lblSupport
        '
        Me.lblSupport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupport.AutoSize = True
        Me.lblSupport.Location = New System.Drawing.Point(67, 301)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(143, 13)
        Me.lblSupport.TabIndex = 17
        Me.lblSupport.Text = "Support: "
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Location = New System.Drawing.Point(3, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(58, 58)
        Me.pnlTop.TabIndex = 18
        Me.pnlTop.Tag = "Top"
        '
        'pnlJungle
        '
        Me.pnlJungle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlJungle.Location = New System.Drawing.Point(3, 72)
        Me.pnlJungle.Name = "pnlJungle"
        Me.pnlJungle.Size = New System.Drawing.Size(58, 58)
        Me.pnlJungle.TabIndex = 19
        Me.pnlJungle.Tag = "Jungle"
        '
        'pnlMid
        '
        Me.pnlMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMid.Location = New System.Drawing.Point(3, 141)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(58, 58)
        Me.pnlMid.TabIndex = 19
        Me.pnlMid.Tag = "Mid"
        '
        'pnlCarry
        '
        Me.pnlCarry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlCarry.Location = New System.Drawing.Point(3, 210)
        Me.pnlCarry.Name = "pnlCarry"
        Me.pnlCarry.Size = New System.Drawing.Size(58, 58)
        Me.pnlCarry.TabIndex = 19
        Me.pnlCarry.Tag = "Carry"
        '
        'pnlSupport
        '
        Me.pnlSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSupport.Location = New System.Drawing.Point(3, 279)
        Me.pnlSupport.Name = "pnlSupport"
        Me.pnlSupport.Size = New System.Drawing.Size(58, 58)
        Me.pnlSupport.TabIndex = 19
        Me.pnlSupport.Tag = "Support"
        '
        'cmdTauscheTop
        '
        Me.cmdTauscheTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTauscheTop.Location = New System.Drawing.Point(216, 3)
        Me.cmdTauscheTop.Name = "cmdTauscheTop"
        Me.cmdTauscheTop.Size = New System.Drawing.Size(58, 58)
        Me.cmdTauscheTop.TabIndex = 20
        Me.cmdTauscheTop.Tag = "Top"
        Me.cmdTauscheTop.Text = "Tausche"
        Me.cmdTauscheTop.UseVisualStyleBackColor = True
        '
        'cmdTauscheJungle
        '
        Me.cmdTauscheJungle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTauscheJungle.Location = New System.Drawing.Point(216, 72)
        Me.cmdTauscheJungle.Name = "cmdTauscheJungle"
        Me.cmdTauscheJungle.Size = New System.Drawing.Size(58, 58)
        Me.cmdTauscheJungle.TabIndex = 21
        Me.cmdTauscheJungle.Tag = "Jungle"
        Me.cmdTauscheJungle.Text = "Tausche"
        Me.cmdTauscheJungle.UseVisualStyleBackColor = True
        '
        'cmdTauscheMid
        '
        Me.cmdTauscheMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTauscheMid.Location = New System.Drawing.Point(216, 141)
        Me.cmdTauscheMid.Name = "cmdTauscheMid"
        Me.cmdTauscheMid.Size = New System.Drawing.Size(58, 58)
        Me.cmdTauscheMid.TabIndex = 22
        Me.cmdTauscheMid.Tag = "Mid"
        Me.cmdTauscheMid.Text = "Tausche"
        Me.cmdTauscheMid.UseVisualStyleBackColor = True
        '
        'cmdTauscheCarry
        '
        Me.cmdTauscheCarry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTauscheCarry.Location = New System.Drawing.Point(216, 210)
        Me.cmdTauscheCarry.Name = "cmdTauscheCarry"
        Me.cmdTauscheCarry.Size = New System.Drawing.Size(58, 58)
        Me.cmdTauscheCarry.TabIndex = 23
        Me.cmdTauscheCarry.Tag = "Carry"
        Me.cmdTauscheCarry.Text = "Tausche"
        Me.cmdTauscheCarry.UseVisualStyleBackColor = True
        '
        'cmdTauscheSupport
        '
        Me.cmdTauscheSupport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTauscheSupport.Location = New System.Drawing.Point(216, 279)
        Me.cmdTauscheSupport.Name = "cmdTauscheSupport"
        Me.cmdTauscheSupport.Size = New System.Drawing.Size(58, 58)
        Me.cmdTauscheSupport.TabIndex = 24
        Me.cmdTauscheSupport.Tag = "Support"
        Me.cmdTauscheSupport.Text = "Tausche"
        Me.cmdTauscheSupport.UseVisualStyleBackColor = True
        '
        'TeamPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TeamPanel"
        Me.Size = New System.Drawing.Size(277, 340)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSupport As System.Windows.Forms.Panel
    Friend WithEvents pnlCarry As System.Windows.Forms.Panel
    Friend WithEvents pnlMid As System.Windows.Forms.Panel
    Friend WithEvents lblSupport As System.Windows.Forms.Label
    Friend WithEvents lblCarry As System.Windows.Forms.Label
    Friend WithEvents lblMid As System.Windows.Forms.Label
    Friend WithEvents lblJungle As System.Windows.Forms.Label
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlJungle As System.Windows.Forms.Panel
    Friend WithEvents cmdTauscheTop As System.Windows.Forms.Button
    Friend WithEvents cmdTauscheJungle As System.Windows.Forms.Button
    Friend WithEvents cmdTauscheMid As System.Windows.Forms.Button
    Friend WithEvents cmdTauscheCarry As System.Windows.Forms.Button
    Friend WithEvents cmdTauscheSupport As System.Windows.Forms.Button

End Class
