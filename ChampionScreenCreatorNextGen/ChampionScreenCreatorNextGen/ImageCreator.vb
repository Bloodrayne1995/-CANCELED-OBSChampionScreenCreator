Imports System.Xml
Public Class ImageCreator

    Public _pnl As New Panel
    Private config As String
    Private configObj As OutputSettings
    Private fonts As New FontMemory
    Public side_blue As Side
    Public side_red As Side
    Public img As New Bitmap(1920, 1080, Imaging.PixelFormat.Format48bppRgb)

    Public Event onCreatingFinished(x As Panel)

    Public Sub New()
        configObj = New OutputSettings
        fonts.ladeFonts()
    End Sub


    Public Sub create()
        _pnl.Size = New Size(1920, 1080)
        _pnl.BackgroundImageLayout = ImageLayout.Stretch
        _pnl.BackgroundImage = Image.FromFile(configObj.Einstellungen("backgroundImage").Value)
        
        erstelleTeam(side_red, "rot")
        erstelleTeam(side_blue, "blau")

        _pnl.DrawToBitmap(img, New Rectangle(0, 0, 1920, 1080))


    End Sub

    Private Sub erstelleTeam(team As Side, farbe As String)
        Dim pnlRotBannerTop As Panel = getSpielerbanner("top", team.Team1.Spieler1, farbe)
        Dim pnlRotBannerJungle As Panel = getSpielerbanner("jungle", team.Team1.Spieler2, farbe)
        Dim pnlRotBannerMid As Panel = getSpielerbanner("mid", team.Team1.Spieler3, farbe)
        Dim pnlRotBannerADC As Panel = getSpielerbanner("adc", team.Team1.Spieler4, farbe)
        Dim pnlRotBannerSupport As Panel = getSpielerbanner("support", team.Team1.Spieler5, farbe)

        Dim pnlRotSquareTop As Panel = getSpielerSquare("top", team.Team1.Spieler1, farbe)
        Dim pnlRotSquareJungle As Panel = getSpielerSquare("jungle", team.Team1.Spieler2, farbe)
        Dim pnlRotSquareMid As Panel = getSpielerSquare("mid", team.Team1.Spieler3, farbe)
        Dim pnlRotSquareADC As Panel = getSpielerSquare("adc", team.Team1.Spieler4, farbe)
        Dim pnlRotSquareSupport As Panel = getSpielerSquare("support", team.Team1.Spieler5, farbe)

        Dim pnlRotBan1 As Panel = getBan(0, team.Bans1.Ban1, farbe)
        Dim pnlRotBan2 As Panel = getBan(1, team.Bans1.Ban2, farbe)
        Dim pnlRotBan3 As Panel = getBan(2, team.Bans1.Ban3, farbe)

        If configObj.Einstellungen("showBans").Value = "true" Then
            _pnl.Controls.Add(pnlRotBan1)
            _pnl.Controls.Add(pnlRotBan2)
            _pnl.Controls.Add(pnlRotBan3)
        End If

        If configObj.Einstellungen("showBanner").Value = "true" Then
            _pnl.Controls.Add(pnlRotBannerTop)
            _pnl.Controls.Add(pnlRotBannerJungle)
            _pnl.Controls.Add(pnlRotBannerMid)
            _pnl.Controls.Add(pnlRotBannerADC)
            _pnl.Controls.Add(pnlRotBannerSupport)
        End If

        If configObj.Einstellungen("showSquares").Value = "true" Then
            _pnl.Controls.Add(pnlRotSquareTop)
            _pnl.Controls.Add(pnlRotSquareJungle)
            _pnl.Controls.Add(pnlRotSquareMid)
            _pnl.Controls.Add(pnlRotSquareADC)
            _pnl.Controls.Add(pnlRotSquareSupport)
        End If
    End Sub


    Private Function getSpielerbanner(rolle As String, spieler As Spieler, farbe As String) As Panel
        Dim s As OutputSettings.Spieler = configObj.getSpielerSetting(rolle, farbe)
        Dim x As New Panel
        x.Size = s.banner_size
        x.Location = s.banner_location

        'Farbe
        x.BackgroundImageLayout = ImageLayout.Stretch
        If farbe = "blau" Then
            x.BackgroundImage = Image.FromFile("./data/images/Spielerrahmen.Blau.png")
        Else
            x.BackgroundImage = Image.FromFile("./data/images/Spielerrahmen.Rot.png")
        End If

        'Banner
        Dim pctChamp As New PictureBox
        pctChamp.BackgroundImageLayout = ImageLayout.Stretch
        pctChamp.BackgroundImage = spieler.CHAMPION.BANNER
        pctChamp.Size = New Size(x.Width - 12, x.Height - 24)
        pctChamp.Location = New Point(6, 6)
        x.Controls.Add(pctChamp)

        'Label:
        Dim lbl As New Label
        lbl.Text = spieler.CHAMPION.DISPLAYNAME
        lbl.Width = x.Width
        lbl.Font = fonts.Liste(configObj.Einstellungen("championFontName").Value).schriftart
        lbl.ForeColor = fonts.Liste(configObj.Einstellungen("championFontName").Value).farbe
        lbl.TextAlign = fonts.Liste(configObj.Einstellungen("championFontName").Value).alignment
        lbl.BackColor = Color.Transparent
        lbl.Location = New Point(0, x.Height - 25)

        If configObj.Einstellungen("showChampionNames").Value = "true" Then
            x.Controls.Add(lbl)
            lbl.BringToFront()
        End If

        Return x
    End Function


    Private Function getSpielerSquare(rolle As String, spieler As Spieler, farbe As String) As Panel
        Dim s As OutputSettings.Spieler = configObj.getSpielerSetting(rolle, farbe)
        Dim p As New Panel
        p.Size = s.square_size
        p.Location = s.square_location
        p.BackgroundImageLayout = ImageLayout.Stretch
        p.BackgroundImage = spieler.CHAMPION.ICON
        Return p
    End Function


    Private Function getBan(index As Integer, b As Ban, farbe As String) As Panel
        Dim s As OutputSettings.Spieler = configObj.getBanSetting(index, farbe)
        Dim p As New Panel
        p.Size = s.square_size
        p.Location = s.square_location
        p.BackgroundImage = b.CHAMP.ICON
        p.BackgroundImageLayout = ImageLayout.Stretch
        Return p
    End Function


End Class
