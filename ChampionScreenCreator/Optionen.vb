Public Class Optionen

    Private memory As MemoryManagement

    Public Sub New(ByRef mem As MemoryManagement)
        InitializeComponent()
        memory = mem
        lade()



    End Sub


    Private Sub lade()
        'Checkboxen:
        For Each x As CheckBox In GroupBox1.Controls
            If memory.outputSettings.settings(x.Tag) = "true" Then
                x.Checked = True
            Else
                x.Checked = False
            End If
        Next


        'Hintergrund
        Dim backp As New IO.FileInfo(memory.outputSettings.settings("backgroundImage"))
        txtBackgroundPath.Text = backp.FullName
        pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        pctBackground.BackgroundImage = Image.FromFile(backp.FullName)
    End Sub


    Public Sub save() Handles cmdSave.Click
        'Ausgabe-Settings


        'Font-Settings

    End Sub

    Public Sub cancel() Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub


End Class