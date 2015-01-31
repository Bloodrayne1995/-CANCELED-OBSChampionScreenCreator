Public Class OutputSettings

    Private db As MemoryManagement
    Private prev As ImageCreator
    Private selectedObject As String = "-1"



    Public Sub New(ByRef mem As MemoryManagement)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        db = mem

        prev = New ImageCreator(db)
        AddHandler prev.on_image_created, AddressOf bildHandler
        prev.testImage()

        ladeHintergrundBild()
        ladeCheckBoxen()
    End Sub


    Private Sub bildHandler(pnl As Bitmap)
        pnlEdit.BackgroundImageLayout = ImageLayout.Stretch
        pnlEdit.BackgroundImage = pnl
    End Sub

    Private Sub ladeHintergrundBild()
        pctWallPaper.BackgroundImageLayout = ImageLayout.Stretch
        pctWallPaper.BackgroundImage = Image.FromFile(db.outputSettings.settings("backgroundImage").value)
        txtBildPath.Text = db.outputSettings.settings("backgroundImage").value
    End Sub

    Private Sub ladeCheckBoxen()
        flpFlags.Controls.Clear()
        For Each x As String In db.outputSettings.settings.Keys
            If db.outputSettings.settings(x).value = "true" Or db.outputSettings.settings(x).value = "false" Then
                Dim chk As New CheckBox
                chk.Text = db.outputSettings.settings(x).desc
                If db.outputSettings.settings(x).value = "true" Then
                    chk.Checked = True
                Else
                    chk.Checked = False
                End If
                chk.Tag = x
                chk.AutoSize = True
                flpFlags.Controls.Add(chk)
            End If
        Next
    End Sub


    Private Sub cmbObjekt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbObjekt.SelectedIndexChanged

        Dim selected As String = cmbObjekt.Items(cmbObjekt.SelectedIndex)
        loadData(selected)
    End Sub

    Private Sub loadData(selected As String)
        Dim farbe As String = ""
        Dim rolle As String = ""
        Dim obj As String = ""

        If selected.StartsWith("=") Or selected = String.Empty Then
            numHöe.Value = 0
            numPosX.Value = 0
            numPosY.Value = 0
            numWidth.Value = 0
            Exit Sub
        End If

        If selected.Contains("[Rot]") Then
            farbe = "rot"
        Else
            farbe = "blau"
        End If

        If selected.Contains("Jungle") Then
            rolle = "jungle"
        Else
            If selected.Contains("Top") Then
                rolle = "top"
            Else
                If selected.Contains("Carry") Then
                    rolle = "adc"
                Else
                    If selected.Contains("Mid") Then
                        rolle = "mid"
                    Else
                        If selected.Contains("Support") Then
                            rolle = "support"
                        ElseIf selected.Contains("1") Then
                            rolle = "1"
                        ElseIf selected.Contains("2") Then
                            rolle = "2"
                        ElseIf selected.Contains("3") Then
                            rolle = "3"
                        End If
                    End If
                End If
            End If
        End If

        If selected.Contains("Banner") Then
            obj = "banner"
        ElseIf selected.Contains("Icon") Then
            obj = "square"
        Else
            obj = "ban"
        End If

        selectedObject = farbe & ";" & obj & ";" & rolle

        If Not rolle = "1" And Not rolle = "2" And Not rolle = "3" Then
            numHöe.Enabled = True
            numWidth.Enabled = True
            Select Case obj
                Case "banner"
                    numHöe.Value = db.outputSettings.getPlayer(farbe, rolle).BANNER_Size.Height
                    numPosX.Value = db.outputSettings.getPlayer(farbe, rolle).BANNER.X
                    numPosY.Value = db.outputSettings.getPlayer(farbe, rolle).BANNER.Y
                    numWidth.Value = db.outputSettings.getPlayer(farbe, rolle).BANNER_Size.Width
                    Exit Select
                Case "square"
                    numHöe.Value = db.outputSettings.getPlayer(farbe, rolle).SQUARE_Size.Height
                    numPosX.Value = db.outputSettings.getPlayer(farbe, rolle).SQUARE.X
                    numPosY.Value = db.outputSettings.getPlayer(farbe, rolle).SQUARE.Y
                    numWidth.Value = db.outputSettings.getPlayer(farbe, rolle).SQUARE_Size.Width
                    Exit Select
            End Select
        Else
            Dim i As Integer = Integer.Parse(rolle)
            Dim banObj As Ban = Nothing
            If farbe = "blau" Then
                For Each x As Ban In db.outputSettings.bans_blue
                    If x.INDEX = i Then
                        banObj = x
                        Exit For
                    End If
                Next
            Else
                For Each x As Ban In db.outputSettings.bans_red
                    If x.INDEX = i Then
                        banObj = x
                        Exit For
                    End If
                Next
            End If

            numHöe.Enabled = False
            numWidth.Enabled = False
            numPosX.Value = banObj.LOCATION.X
            numPosY.Value = banObj.LOCATION.Y
        End If

    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim data() As String = selectedObject.Split(";")
        Dim rolle As String = data(2)
        Dim farbe As String = data(0)
        Dim obj As String = data(1)

        If obj = "ban" Then
            Dim index As Integer = db.outputSettings.getBanIndex(farbe, rolle)
            If farbe = "blau" Then
                db.outputSettings.bans_blue(index).LOCATION = New Point(numPosX.Value, numPosY.Value)
            Else
                db.outputSettings.bans_red(index).LOCATION = New Point(numPosX.Value, numPosY.Value)
            End If

        Else

            db.outputSettings.setPlayer(farbe, rolle, obj, "pos", New Point(numPosX.Value, numPosY.Value))
            db.outputSettings.setPlayer(farbe, rolle, obj, "size", New Size(numWidth.Value, numHöe.Value))
        End If

        prev.testImage()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Dim data() As String = selectedObject.Split(";")
        Dim farbe As String = data(0)
        Dim obj As String = data(1)
        Dim rolle As String = data(2)

        Dim txt As String = ""

        If farbe = "blau" Then
            farbe = "[Blau]"
        Else
            farbe = "[Rot]"
        End If

        txt &= farbe

        If Not obj = "ban" Then
            If rolle = "top" Or rolle = "mid" Then
                rolle &= "-Lane"
            End If
            Dim b As String = rolle.ToCharArray(0, 1)(0).ToString
            b = b.ToUpper
            rolle = rolle.Remove(0, 1)
            rolle = rolle.Insert(0, b)

            b = obj.ToCharArray(0, 1)(0).ToString
            b = b.ToUpper
            obj = obj.Remove(0, 1)
            obj = obj.Insert(0, b)

            If rolle = "Adc" Then
                rolle = "Carry"
            End If

            txt &= " " & rolle & " (" & obj & ")"
        Else
            Dim i As Integer = Integer.Parse(rolle)
            txt &= " " & i & ". Bann"
        End If

        loadData(txt)
    End Sub

    Private Sub cmdResetAllg_Click(sender As Object, e As EventArgs) Handles cmdResetAllg.Click
        ladeHintergrundBild()
        ladeCheckBoxen()

    End Sub

    Private Sub cmdSelectPic_Click(sender As Object, e As EventArgs) Handles cmdSelectPic.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bild-Dateien(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp"
        ofd.Multiselect = False
        Dim rs As DialogResult = ofd.ShowDialog
        If rs = Windows.Forms.DialogResult.Yes Or rs = Windows.Forms.DialogResult.OK Then
            txtBildPath.Text = ofd.FileName
            pctWallPaper.BackgroundImage = Image.FromFile(txtBildPath.Text)
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        'Checkboxen
        For Each x As CheckBox In flpFlags.Controls
            If x.Checked Then
                db.outputSettings.settings(x.Tag).value = "true"
            Else
                db.outputSettings.settings(x.Tag).value = "false"
            End If
        Next

        'Hintergrund-Bild
        db.outputSettings.settings("backgroundImage").value = txtBildPath.Text

        prev.testImage()
    End Sub
End Class