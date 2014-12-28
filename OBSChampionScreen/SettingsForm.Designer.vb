<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctHintergrund = New System.Windows.Forms.PictureBox()
        Me.txtPfad = New System.Windows.Forms.TextBox()
        Me.cmdSelectBackground = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmFormat = New System.Windows.Forms.ComboBox()
        CType(Me.pctHintergrund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(291, 281)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Speichern"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(210, 281)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Abbrechen"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hintergrundbild: "
        '
        'pctHintergrund
        '
        Me.pctHintergrund.Location = New System.Drawing.Point(16, 36)
        Me.pctHintergrund.Name = "pctHintergrund"
        Me.pctHintergrund.Size = New System.Drawing.Size(350, 198)
        Me.pctHintergrund.TabIndex = 4
        Me.pctHintergrund.TabStop = False
        '
        'txtPfad
        '
        Me.txtPfad.Location = New System.Drawing.Point(97, 10)
        Me.txtPfad.Name = "txtPfad"
        Me.txtPfad.Size = New System.Drawing.Size(188, 20)
        Me.txtPfad.TabIndex = 5
        '
        'cmdSelectBackground
        '
        Me.cmdSelectBackground.Location = New System.Drawing.Point(291, 8)
        Me.cmdSelectBackground.Name = "cmdSelectBackground"
        Me.cmdSelectBackground.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelectBackground.TabIndex = 6
        Me.cmdSelectBackground.Text = "Auswählen"
        Me.cmdSelectBackground.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Format: "
        '
        'cmFormat
        '
        Me.cmFormat.FormattingEnabled = True
        Me.cmFormat.Items.AddRange(New Object() {"PNG", "JPG"})
        Me.cmFormat.Location = New System.Drawing.Point(64, 245)
        Me.cmFormat.Name = "cmFormat"
        Me.cmFormat.Size = New System.Drawing.Size(121, 21)
        Me.cmFormat.TabIndex = 8
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 310)
        Me.Controls.Add(Me.cmFormat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSelectBackground)
        Me.Controls.Add(Me.txtPfad)
        Me.Controls.Add(Me.pctHintergrund)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SettingsForm"
        Me.Text = "Einstellungen"
        CType(Me.pctHintergrund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pctHintergrund As System.Windows.Forms.PictureBox
    Friend WithEvents txtPfad As System.Windows.Forms.TextBox
    Friend WithEvents cmdSelectBackground As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmFormat As System.Windows.Forms.ComboBox
End Class
