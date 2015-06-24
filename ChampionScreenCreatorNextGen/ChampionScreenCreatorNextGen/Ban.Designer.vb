<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ban
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
        Me.pnlChamp = New System.Windows.Forms.Panel()
        Me.lblChampName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlChamp
        '
        Me.pnlChamp.AllowDrop = True
        Me.pnlChamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlChamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChamp.Location = New System.Drawing.Point(20, 3)
        Me.pnlChamp.Name = "pnlChamp"
        Me.pnlChamp.Size = New System.Drawing.Size(64, 64)
        Me.pnlChamp.TabIndex = 0
        '
        'lblChampName
        '
        Me.lblChampName.Location = New System.Drawing.Point(3, 70)
        Me.lblChampName.Name = "lblChampName"
        Me.lblChampName.Size = New System.Drawing.Size(98, 19)
        Me.lblChampName.TabIndex = 1
        Me.lblChampName.Text = "<champion>"
        Me.lblChampName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Ban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblChampName)
        Me.Controls.Add(Me.pnlChamp)
        Me.Name = "Ban"
        Me.Size = New System.Drawing.Size(104, 93)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlChamp As System.Windows.Forms.Panel
    Friend WithEvents lblChampName As System.Windows.Forms.Label

End Class
