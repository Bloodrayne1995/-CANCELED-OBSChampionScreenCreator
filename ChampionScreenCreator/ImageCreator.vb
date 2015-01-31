Public Class ImageCreator

    Private mem As MemoryManagement
    Public Event on_image_created(pnl As Bitmap)

    'Blau
    Dim blau_top As ChampionData
    Dim blau_jng As ChampionData
    Dim blau_mid As ChampionData
    Dim blau_adc As ChampionData
    Dim blau_sup As ChampionData

    Dim blau_b1 As ChampionData
    Dim blau_b2 As ChampionData
    Dim blau_b3 As ChampionData


    'Rot
    Dim rot_top As ChampionData
    Dim rot_jng As ChampionData
    Dim rot_mid As ChampionData
    Dim rot_adc As ChampionData
    Dim rot_sup As ChampionData

    Dim rot_b1 As ChampionData
    Dim rot_b2 As ChampionData
    Dim rot_b3 As ChampionData


    Public Sub New(ByRef memor As MemoryManagement)
        mem = memor
    End Sub


    Public Sub setTeam(name As String, ByRef team As TeamPanel)
        If name = "blau" Then
            blau_top = team.TOPLane
            blau_adc = team.CARRY
            blau_sup = team.SUPPORT
            blau_mid = team.MID
            blau_jng = team.JUNGLE
        Else
            rot_top = team.TOPLane
            rot_adc = team.CARRY
            rot_sup = team.SUPPORT
            rot_mid = team.MID
            rot_jng = team.JUNGLE
        End If
    End Sub

    Public Sub setBans(name As String, ByRef ban As BanPanel)
        If name = "blau" Then
            blau_b1 = ban.BAN1
            blau_b2 = ban.BAN2
            blau_b3 = ban.BAN3
        Else
            rot_b1 = ban.BAN1
            rot_b2 = ban.BAN2
            rot_b3 = ban.BAN3
        End If
    End Sub

    Public Sub testImage()
        blau_adc = mem.championDB.getByName("Ashe")
        blau_sup = mem.championDB.getByName("Braum")
        blau_mid = mem.championDB.getByName("Anivia")
        blau_jng = mem.championDB.getByName("Sejuani")
        blau_top = mem.championDB.getByName("Lissandra")

        rot_adc = mem.championDB.getByName("Ezreal")
        rot_sup = mem.championDB.getByName("Lux")
        rot_mid = mem.championDB.getByName("Galio")
        rot_jng = mem.championDB.getByName("Jarvan IV")
        rot_top = mem.championDB.getByName("Garen")

        create(True)
    End Sub

    Public Sub create(ByVal thr As Boolean)
        If thr Then
            Dim x As New Threading.Thread(AddressOf internalCreate)
            x.Start()
        Else
            internalCreate()
        End If
    End Sub


    Private Sub internalCreate()
        'HauptPanel
        Dim mainP As New Panel
        mainP.Size = New Size(1920, 1080)
        mainP.BackgroundImageLayout = ImageLayout.Stretch
        mainP.BackgroundImage = Image.FromFile(mem.outputSettings.settings("backgroundImage").value)

        If mem.outputSettings.settings("showBanner").value = "true" Then
            'Team-Blau:
            mainP.Controls.Add(getChampionPanel(blau_top, "blau", "top"))
            mainP.Controls.Add(getChampionPanel(blau_jng, "blau", "jungle"))
            mainP.Controls.Add(getChampionPanel(blau_mid, "blau", "mid"))
            mainP.Controls.Add(getChampionPanel(blau_adc, "blau", "adc"))
            mainP.Controls.Add(getChampionPanel(blau_sup, "blau", "support"))


            'Team-Rot:
            mainP.Controls.Add(getChampionPanel(rot_top, "rot", "top"))
            mainP.Controls.Add(getChampionPanel(rot_jng, "rot", "jungle"))
            mainP.Controls.Add(getChampionPanel(rot_mid, "rot", "mid"))
            mainP.Controls.Add(getChampionPanel(rot_adc, "rot", "adc"))
            mainP.Controls.Add(getChampionPanel(rot_sup, "rot", "support"))
        End If

        If mem.outputSettings.settings("showSquareIcons").value = "true" Then
            'Team Blau
            mainP.Controls.Add(getChampionSquare(blau_top, "blau", "top"))
            mainP.Controls.Add(getChampionSquare(blau_jng, "blau", "jungle"))
            mainP.Controls.Add(getChampionSquare(blau_mid, "blau", "mid"))
            mainP.Controls.Add(getChampionSquare(blau_adc, "blau", "adc"))
            mainP.Controls.Add(getChampionSquare(blau_sup, "blau", "support"))

            'Team Rot
            mainP.Controls.Add(getChampionSquare(rot_top, "rot", "top"))
            mainP.Controls.Add(getChampionSquare(rot_jng, "rot", "jungle"))
            mainP.Controls.Add(getChampionSquare(rot_mid, "rot", "mid"))
            mainP.Controls.Add(getChampionSquare(rot_adc, "rot", "adc"))
            mainP.Controls.Add(getChampionSquare(rot_sup, "rot", "support"))
        End If


        Dim bild As New Bitmap(1920, 1080, Imaging.PixelFormat.Format48bppRgb)
        mainP.DrawToBitmap(bild, New Rectangle(0, 0, 1920, 1080))



        RaiseEvent on_image_created(bild)
    End Sub


    Private Function getChampionPanel(ByRef chd As ChampionData, farbe As String, rolle As String) As ChampionPanel
        Dim x As New ChampionPanel(chd, mem, farbe)
        x.lade(False)

        x.Dock = DockStyle.None

        Dim plDat As Player = mem.outputSettings.getPlayer(farbe, rolle)
        x.Size = plDat.BANNER_Size
        x.Location = plDat.BANNER

        Return x
    End Function


    Private Function getChampionSquare(ByRef chd As ChampionData, farbe As String, rolle As String) As PictureBox
        Dim x As New PictureBox
        x.BackgroundImageLayout = ImageLayout.Stretch
        x.Size = mem.outputSettings.getPlayer(farbe, rolle).SQUARE_Size
        x.Location = mem.outputSettings.getPlayer(farbe, rolle).SQUARE
        x.BackgroundImage = chd.Square
        Return x
    End Function


End Class
