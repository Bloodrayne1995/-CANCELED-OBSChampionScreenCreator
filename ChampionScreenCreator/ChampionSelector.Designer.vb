<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChampionSelector
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtSuche = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lstChampions = New System.Windows.Forms.ListView()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSuche)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdOK)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstChampions)
        Me.SplitContainer1.Size = New System.Drawing.Size(528, 451)
        Me.SplitContainer1.SplitterDistance = 32
        Me.SplitContainer1.TabIndex = 0
        '
        'txtSuche
        '
        Me.txtSuche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtSuche.Location = New System.Drawing.Point(3, 7)
        Me.txtSuche.Name = "txtSuche"
        Me.txtSuche.Size = New System.Drawing.Size(444, 20)
        Me.txtSuche.TabIndex = 1
        '
        'cmdOK
        '
        Me.cmdOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdOK.Location = New System.Drawing.Point(453, 0)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 32)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "Setzen"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lstChampions
        '
        Me.lstChampions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstChampions.LargeImageList = Me.icons
        Me.lstChampions.Location = New System.Drawing.Point(0, 0)
        Me.lstChampions.MultiSelect = False
        Me.lstChampions.Name = "lstChampions"
        Me.lstChampions.Size = New System.Drawing.Size(528, 415)
        Me.lstChampions.TabIndex = 0
        Me.lstChampions.UseCompatibleStateImageBehavior = False
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.icons.ImageSize = New System.Drawing.Size(64, 64)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'ChampionSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ChampionSelector"
        Me.Size = New System.Drawing.Size(528, 451)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSuche As System.Windows.Forms.TextBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents lstChampions As System.Windows.Forms.ListView
    Friend WithEvents icons As System.Windows.Forms.ImageList

End Class
