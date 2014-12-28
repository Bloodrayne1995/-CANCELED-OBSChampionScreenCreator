<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChampionSelecterV2
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvChampions = New System.Windows.Forms.ListView()
        Me.imgListChampions = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Location = New System.Drawing.Point(480, 5)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(45, 23)
        Me.cmdOK.TabIndex = 5
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(462, 20)
        Me.txtSearch.TabIndex = 4
        '
        'lvChampions
        '
        Me.lvChampions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvChampions.HideSelection = False
        Me.lvChampions.LargeImageList = Me.imgListChampions
        Me.lvChampions.Location = New System.Drawing.Point(12, 34)
        Me.lvChampions.MultiSelect = False
        Me.lvChampions.Name = "lvChampions"
        Me.lvChampions.ShowGroups = False
        Me.lvChampions.Size = New System.Drawing.Size(515, 301)
        Me.lvChampions.TabIndex = 6
        Me.lvChampions.TabStop = False
        Me.lvChampions.UseCompatibleStateImageBehavior = False
        '
        'imgListChampions
        '
        Me.imgListChampions.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgListChampions.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgListChampions.TransparentColor = System.Drawing.Color.Transparent
        '
        'ChampionSelecterV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 345)
        Me.Controls.Add(Me.lvChampions)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChampionSelecterV2"
        Me.Text = "Champion auswählen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvChampions As System.Windows.Forms.ListView
    Friend WithEvents imgListChampions As System.Windows.Forms.ImageList
End Class
