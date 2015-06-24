<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChampionAuswahl
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
        Me.dgvChampions = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAssassin = New System.Windows.Forms.CheckBox()
        Me.chkFighter = New System.Windows.Forms.CheckBox()
        Me.chkSupport = New System.Windows.Forms.CheckBox()
        Me.chkMarksman = New System.Windows.Forms.CheckBox()
        Me.chkTank = New System.Windows.Forms.CheckBox()
        Me.chkMage = New System.Windows.Forms.CheckBox()
        Me.cmdSuche = New System.Windows.Forms.Button()
        CType(Me.dgvChampions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvChampions
        '
        Me.dgvChampions.AllowUserToAddRows = False
        Me.dgvChampions.AllowUserToDeleteRows = False
        Me.dgvChampions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChampions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvChampions.Location = New System.Drawing.Point(4, 4)
        Me.dgvChampions.Name = "dgvChampions"
        Me.dgvChampions.ReadOnly = True
        Me.dgvChampions.RowHeadersVisible = False
        Me.dgvChampions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChampions.Size = New System.Drawing.Size(445, 421)
        Me.dgvChampions.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(456, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAssassin)
        Me.GroupBox1.Controls.Add(Me.chkFighter)
        Me.GroupBox1.Controls.Add(Me.chkSupport)
        Me.GroupBox1.Controls.Add(Me.chkMarksman)
        Me.GroupBox1.Controls.Add(Me.chkTank)
        Me.GroupBox1.Controls.Add(Me.chkMage)
        Me.GroupBox1.Location = New System.Drawing.Point(456, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 163)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rolle"
        '
        'chkAssassin
        '
        Me.chkAssassin.AutoSize = True
        Me.chkAssassin.Location = New System.Drawing.Point(7, 135)
        Me.chkAssassin.Name = "chkAssassin"
        Me.chkAssassin.Size = New System.Drawing.Size(73, 17)
        Me.chkAssassin.TabIndex = 5
        Me.chkAssassin.Tag = "Assassin"
        Me.chkAssassin.Text = "Assassine"
        Me.chkAssassin.UseVisualStyleBackColor = True
        '
        'chkFighter
        '
        Me.chkFighter.AutoSize = True
        Me.chkFighter.Location = New System.Drawing.Point(7, 112)
        Me.chkFighter.Name = "chkFighter"
        Me.chkFighter.Size = New System.Drawing.Size(65, 17)
        Me.chkFighter.TabIndex = 4
        Me.chkFighter.Tag = "Fighter"
        Me.chkFighter.Text = "Kämpfer"
        Me.chkFighter.UseVisualStyleBackColor = True
        '
        'chkSupport
        '
        Me.chkSupport.AutoSize = True
        Me.chkSupport.Location = New System.Drawing.Point(7, 89)
        Me.chkSupport.Name = "chkSupport"
        Me.chkSupport.Size = New System.Drawing.Size(92, 17)
        Me.chkSupport.TabIndex = 3
        Me.chkSupport.Tag = "Support"
        Me.chkSupport.Text = "Unterstützung"
        Me.chkSupport.UseVisualStyleBackColor = True
        '
        'chkMarksman
        '
        Me.chkMarksman.AutoSize = True
        Me.chkMarksman.Location = New System.Drawing.Point(7, 66)
        Me.chkMarksman.Name = "chkMarksman"
        Me.chkMarksman.Size = New System.Drawing.Size(94, 17)
        Me.chkMarksman.TabIndex = 2
        Me.chkMarksman.Tag = "Marksman"
        Me.chkMarksman.Text = "Scharfschütze"
        Me.chkMarksman.UseVisualStyleBackColor = True
        '
        'chkTank
        '
        Me.chkTank.AutoSize = True
        Me.chkTank.Location = New System.Drawing.Point(7, 43)
        Me.chkTank.Name = "chkTank"
        Me.chkTank.Size = New System.Drawing.Size(51, 17)
        Me.chkTank.TabIndex = 1
        Me.chkTank.Tag = "Tank"
        Me.chkTank.Text = "Tank"
        Me.chkTank.UseVisualStyleBackColor = True
        '
        'chkMage
        '
        Me.chkMage.AutoSize = True
        Me.chkMage.Location = New System.Drawing.Point(7, 20)
        Me.chkMage.Name = "chkMage"
        Me.chkMage.Size = New System.Drawing.Size(58, 17)
        Me.chkMage.TabIndex = 0
        Me.chkMage.Tag = "Mage"
        Me.chkMage.Text = "Magier"
        Me.chkMage.UseVisualStyleBackColor = True
        '
        'cmdSuche
        '
        Me.cmdSuche.Location = New System.Drawing.Point(456, 402)
        Me.cmdSuche.Name = "cmdSuche"
        Me.cmdSuche.Size = New System.Drawing.Size(159, 23)
        Me.cmdSuche.TabIndex = 3
        Me.cmdSuche.Text = "Suchen"
        Me.cmdSuche.UseVisualStyleBackColor = True
        '
        'ChampionAuswahl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvChampions)
        Me.Controls.Add(Me.cmdSuche)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ChampionAuswahl"
        Me.Size = New System.Drawing.Size(618, 428)
        CType(Me.dgvChampions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvChampions As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAssassin As System.Windows.Forms.CheckBox
    Friend WithEvents chkFighter As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupport As System.Windows.Forms.CheckBox
    Friend WithEvents chkMarksman As System.Windows.Forms.CheckBox
    Friend WithEvents chkTank As System.Windows.Forms.CheckBox
    Friend WithEvents chkMage As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSuche As System.Windows.Forms.Button

End Class
