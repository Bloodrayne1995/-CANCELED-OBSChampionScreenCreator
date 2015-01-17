Public Class Optionen

    Private memory As MemoryManagement


    'Fonts:
    Private _selectedFontName As String = ""

    Public Sub New(ByRef mem As MemoryManagement)
        InitializeComponent()
        memory = mem
        lade()



    End Sub


    Private Sub lade()
        'Checkboxen:
        For Each x As CheckBox In grpOutputSettings.Controls
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


        'Fonts:
        'System-Fonts laden:
        For Each x As FontFamily In System.Drawing.FontFamily.Families
            cmbAvaibleFonts.Items.Add(x.Name)
        Next

        'Fonts aus den Settings laden
        For Each x As String In memory.fonts.getFonts.Keys
            lstFonts.Items.Add(x)
        Next




    End Sub


    Public Sub save() Handles cmdSave.Click
        'Ausgabe-Settings
        For Each chk As CheckBox In grpOutputSettings.Controls
            If (chk.Checked) Then
                memory.outputSettings.settings(chk.Tag) = "true"
            Else
                memory.outputSettings.settings(chk.Tag) = "false"
            End If
        Next
        memory.outputSettings.settings("backgroundImage") = txtBackgroundPath.Text


        memory.outputSettings.save()


        'Font-Settings



        'Schließen
        Me.Close()
    End Sub

    Public Sub cancel() Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub


    Private Sub cmdBackgroundPathFinder_Click(sender As Object, e As EventArgs) Handles cmdBackgroundPathFinder.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bilddateien (jpg,png,bmp)|*.jpg;*.png;*.bmp"
        ofd.FileName = txtBackgroundPath.Text
        ofd.Multiselect = False
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBackgroundPath.Text = ofd.FileName
            pctBackground.BackgroundImage = Image.FromFile(txtBackgroundPath.Text)
        End If
    End Sub

    Private Sub lstFonts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFonts.SelectedIndexChanged
        Dim key As String = lstFonts.SelectedItem
        _selectedFontName = key
        txtFontName.Text = key

        'Font aus der DB laden
        Dim x As Font = memory.fonts.getFontByID(key)

        'Auswahlbox auf richtige einstellen
        For Each a As String In cmbAvaibleFonts.Items
            For Each a2 As FontFamily In Drawing.FontFamily.Families
                If a = a2.Name Then
                    If x.FontFamily.Name = a2.Name Then
                        cmbAvaibleFonts.SelectedItem = a
                    End If
                End If
            Next
        Next
    End Sub
End Class