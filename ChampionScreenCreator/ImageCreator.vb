Public Class ImageCreator

    Private mem As MemoryManagement
    Public Event on_image_created(pnl As Panel)

    'Zu Testzwecke:
    Dim blau_top As ChampionData
    Dim blau_jng As ChampionData
    Dim blau_mid As ChampionData
    Dim blau_adc As ChampionData
    Dim blau_sup As ChampionData

    Dim rot_top As ChampionData
    Dim rot_jng As ChampionData
    Dim rot_mid As ChampionData
    Dim rot_adc As ChampionData
    Dim rot_sup As ChampionData


    Public Sub New(ByRef memor As MemoryManagement)
        mem = memor
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
        mainP.BackgroundImage = Image.FromFile(mem.outputSettings.settings("backgroundImage"))

        If mem.outputSettings.settings("showBanner") = "true" Then
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

        RaiseEvent on_image_created(mainP)
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


End Class
