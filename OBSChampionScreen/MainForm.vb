Public Class MainForm
    Private pnl As ImagePainterV2


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        SharedMem.database.init()
        SharedMem.liste = SharedMem.database.getList
        SharedMem.teams.init()
        setComboboxes()

    End Sub


    Private Sub setComboboxes()
        cmbTeamBlue.Items.Clear()
        cmbTeamRed.Items.Clear()


        cmbTeamBlue.Items.Add("=== Team ===")
        cmbTeamRed.Items.Add("=== Team ===")


        For Each d As Team In SharedMem.teams._liste
            If d.REGION = d.NAME Then
                cmbTeamBlue.Items.Add("=== " & d.REGION & " ===")
                cmbTeamRed.Items.Add("=== " & d.REGION & " ===")

                For Each x As Team In SharedMem.getTeamsByRegion(d.REGION)
                    cmbTeamBlue.Items.Add(x.NAME)
                    cmbTeamRed.Items.Add(x.NAME)
                Next
            End If
        Next

        cmbTeamBlue.SelectedIndex = 0
        cmbTeamRed.SelectedIndex = 0
    End Sub

    Private Sub handleButton(sender As Object, e As System.EventArgs) Handles cmdRedADC.Click, cmdRedJungle.Click, cmdRedMid.Click, cmdRedSupport.Click, cmdRedTop.Click, cmdBlauADC.Click, cmdBlauJungle.Click, cmdBlauMid.Click, cmdBlauSupport.Click, cmdBlauTop.Click
        Dim x As Button = DirectCast(sender, Button)
        Dim d As New ChampionSelecterV2
        d.ShowDialog(x)
    End Sub
    
    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click

        If preparePanel() Then
            Dim p As New Preview
            p.Controls.Add(pnl)

            p.ShowDialog()
        End If
        
    End Sub


    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If Not TextBox1.Text = String.Empty Then
            Try
                If preparePanel() Then
                    Dim b As New Bitmap(1920, 1080, Imaging.PixelFormat.Format32bppRgb)
                    pnl.DrawToBitmap(b, pnl.DisplayRectangle)
                    Select Case My.Settings.imageFormat
                        Case "PNG"
                            b.Save(TextBox1.Text, Imaging.ImageFormat.Png)
                            Exit Select
                        Case "JPG"
                            b.Save(TextBox1.Text, Imaging.ImageFormat.Jpeg)
                            Exit Select
                    End Select
                End If
                MsgBox("Fertig")
            Catch ex As Exception
                MsgBox("Fehler: " & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If
    End Sub


    Private Function preparePanel() As Boolean
        If areChampsSelected() Then
            pnl = New ImagePainterV2
            pnl.blueTeam.Add(SharedMem.getChampionByName(cmdBlauTop.Tag))
            pnl.blueTeam.Add(SharedMem.getChampionByName(cmdBlauJungle.Tag))
            pnl.blueTeam.Add(SharedMem.getChampionByName(cmdBlauMid.Tag))
            pnl.blueTeam.Add(SharedMem.getChampionByName(cmdBlauADC.Tag))
            pnl.blueTeam.Add(SharedMem.getChampionByName(cmdBlauSupport.Tag))

            pnl.redTeam.Add(SharedMem.getChampionByName(cmdRedTop.Tag))
            pnl.redTeam.Add(SharedMem.getChampionByName(cmdRedJungle.Tag))
            pnl.redTeam.Add(SharedMem.getChampionByName(cmdRedMid.Tag))
            pnl.redTeam.Add(SharedMem.getChampionByName(cmdRedADC.Tag))
            pnl.redTeam.Add(SharedMem.getChampionByName(cmdRedSupport.Tag))

            If Not getItem(cmbTeamBlue).Contains("===") And Not getItem(cmbTeamRed).Contains("===") Then
                pnl.addTeamPanels(getItem(cmbTeamRed), getItem(cmbTeamBlue))
            Else
                pnl.addTeamPanels()
            End If
            Return True
        Else
            MsgBox("Es wurden noch nicht alle Champions ausgewählt!")
            Return False
        End If
    End Function


    Private Function areChampsSelected() As Boolean
        If areBlueChampsSelected() Then
            Return False
        End If

        If areRedChampsSelected() Then
            Return False
        End If

        Return True
    End Function

    Private Function areBlueChampsSelected() As Boolean
        Return cmdBlauADC.Tag = "" And cmdBlauJungle.Tag = "" And cmdBlauMid.Tag = "" And cmdBlauSupport.Tag = "" And cmdBlauTop.Tag = ""
    End Function

    Private Function areRedChampsSelected() As Boolean
        Return cmdRedTop.Tag = "" And cmdRedJungle.Tag = "" And cmdRedMid.Tag = "" And cmdRedADC.Tag = "" And cmdRedSupport.Tag = ""
    End Function

    Private Sub cmdShowFileDialog_Click(sender As Object, e As EventArgs) Handles cmdShowFileDialog.Click
        Dim sfd As New SaveFileDialog
        sfd.SupportMultiDottedExtensions = True
        sfd.Title = "Wähle Ausgabe-Datei"
        sfd.AddExtension = True

        sfd.Filter = My.Settings.imageFormat & "(." & My.Settings.imageFormat & ")|*." & My.Settings.imageFormat

        sfd.CheckFileExists = False
        sfd.CheckPathExists = True

        Dim rst As DialogResult = sfd.ShowDialog
        If rst = Windows.Forms.DialogResult.OK Or rst = Windows.Forms.DialogResult.Yes Then
            TextBox1.Text = sfd.FileName
        End If

    End Sub

    Private Function getItem(d As ComboBox) As String
        Return d.SelectedItem.ToString
    End Function

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Dim d As New SettingsForm
        d.ShowDialog()
    End Sub

    Private Sub TeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamsToolStripMenuItem.Click
        Dim x As New Team_Editor
        x.ShowDialog()

        setComboboxes()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class