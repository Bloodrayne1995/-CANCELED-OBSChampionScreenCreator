Public Class Optionen

    Private memory As MemoryManagement


    'Fonts:
    Private _selectedFontName As String = ""
    Private _change As Boolean = False

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
        ladeFonts()
        


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

    Private Sub ladeFonts()
        lstFonts.Items.Clear()
        'System-Fonts laden:
        For Each x As FontFamily In System.Drawing.FontFamily.Families
            cmbAvaibleFonts.Items.Add(x.Name)
        Next

        'Settings laden
        For Each x As String In memory.fonts.getFonts.Keys
            lstFonts.Items.Add(x)
        Next

        cmdSaveFont.Enabled = False
        cmdDelete.Enabled = False
        tblFontForm.Enabled = False
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
        Dim c As Color = memory.fonts.getColor(key)
        Dim b As ContentAlignment = memory.fonts.getAlign(key)

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

        Select Case b
            Case ContentAlignment.MiddleCenter
                cmbFontAlignment.SelectedIndex = 1
                Exit Select
            Case ContentAlignment.MiddleLeft
                cmbFontAlignment.SelectedIndex = 0
                Exit Select
            Case ContentAlignment.MiddleRight
                cmbFontAlignment.SelectedIndex = 2
                Exit Select
        End Select

        pctFontColor.BackColor = c
        lblFontRGB.Text = "Rot: " & Integer.Parse(c.R) & " Grün: " & Integer.Parse(c.G) & " Blau: " & Integer.Parse(c.B)
        numFontSize.Value = x.Size

        updateFontVorschau()

        _change = True
        cmdSaveFont.Tag = "save"

        cmdSaveFont.Enabled = True
        cmdDelete.Enabled = True
        tblFontForm.Enabled = True
    End Sub



    Private Sub pctFontColor_Click(sender As Object, e As EventArgs) Handles pctFontColor.Click
        Dim cd As New ColorDialog
        cd.Color = pctFontColor.BackColor
        cd.SolidColorOnly = True
        If cd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctFontColor.BackColor = cd.Color
            lblFontRGB.Text = "Rot: " & Integer.Parse(cd.Color.R) & " Grün: " & Integer.Parse(cd.Color.G) & " Blau: " & Integer.Parse(cd.Color.B)
            updateFontVorschau()
        End If

    End Sub


    Private Sub updateFontVorschau()
        lblFontvorschau.ForeColor = pctFontColor.BackColor
        lblFontvorschau.Font = New Font(cmbAvaibleFonts.Items(cmbAvaibleFonts.SelectedIndex).ToString, numFontSize.Value)
        Select Case cmbFontAlignment.SelectedIndex
            Case 0
                lblFontvorschau.TextAlign = ContentAlignment.MiddleLeft
                Exit Select
            Case 1
                lblFontvorschau.TextAlign = ContentAlignment.MiddleCenter
                Exit Select
            Case 2
                lblFontvorschau.TextAlign = ContentAlignment.MiddleRight
                Exit Select
        End Select
    End Sub

    Private Sub cmbFontausrichtungChanged() Handles cmbFontAlignment.SelectedIndexChanged
        If _change Then
            updateFontVorschau()
        End If
    End Sub


    Private Sub numFontSizedChanged() Handles numFontSize.ValueChanged
        If _change Then
            updateFontVorschau()
        End If
    End Sub

    Private Sub cmbAvaibleFontsChanged() Handles cmbAvaibleFonts.SelectedIndexChanged
        If _change Then
            updateFontVorschau()
        End If
    End Sub

    Private Sub clearFontForm()
        txtFontName.Text = ""
        lblFontRGB.Text = ""
        pctBackground.BackColor = Color.Transparent
        numFontSize.Value = 8
        cmbAvaibleFonts.SelectedIndex = 0
        cmbFontAlignment.SelectedIndex = 0
        tblFontForm.Enabled = False
        cmdSaveFont.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub FontButtonClicked(sender As Object, e As EventArgs) Handles cmdDelete.Click, cmdFontAdd.Click, cmdSaveFont.Click
        Dim btn As Button = DirectCast(sender, Button)

        Select Case btn.Tag
            Case "new"
                memory.fonts.addNewFont("font" & lstFonts.Items.Count + 1)
                Exit Select
            Case "del"
                _change = False
                memory.fonts.removeByKey(txtFontName.Text)
                clearFontForm()
                Exit Select
            Case "save"
                ''TODO

        End Select

        ladeFonts()
    End Sub
End Class