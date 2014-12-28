Public Class SettingsForm

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        Me.pctHintergrund.BackgroundImageLayout = ImageLayout.Stretch
        Me.pctHintergrund.BackgroundImage = Image.FromFile(My.Settings.hintergrundbild)
        Me.txtPfad.Text = My.Settings.hintergrundbild
        Me.cmFormat.SelectedItem = My.Settings.imageFormat
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        My.Settings.hintergrundbild = txtPfad.Text
        My.Settings.imageFormat = cmFormat.SelectedItem
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub cmdSelectBackground_Click(sender As Object, e As EventArgs) Handles cmdSelectBackground.Click
        Dim ofd As New OpenFileDialog
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp"
        Dim d As New IO.FileInfo(My.Settings.hintergrundbild)
        ofd.InitialDirectory = d.DirectoryName

        Dim erg As DialogResult = ofd.ShowDialog
        If erg = Windows.Forms.DialogResult.Yes Or erg = Windows.Forms.DialogResult.OK Then
            Me.txtPfad.Text = ofd.FileName
            Me.pctHintergrund.BackgroundImage = Image.FromFile(ofd.FileName)
        End If
    End Sub
End Class