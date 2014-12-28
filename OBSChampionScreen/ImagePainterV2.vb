Public Class ImagePainterV2
    Inherits Panel

    Public blueTeam As New List(Of ChampionData)
    Public redTeam As New List(Of ChampionData)

    Public Sub New()
        Me.Size = New Size(1920, 1080)
        Me.BackgroundImage = Image.FromFile(My.Settings.hintergrundbild)
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub


    Public Sub addTeamPanels(Optional teamRed As String = "", Optional teamBlue As String = "")
        If Not teamRed = "" And Not teamBlue = "" Then
            Me.BackgroundImage = getTeamBackground(teamRed, teamBlue)
        End If
        addBlueTeam(teamBlue)
        addRedTeam(teamRed)
    End Sub

    Private Sub loadTeamImages(teamRed As String, teamBlue As String)
        Dim b As Team = SharedMem.getTeamByName(teamBlue)
        Dim r As Team = SharedMem.getTeamByName(teamRed)

        Dim teamLogoPanel As New Panel
        teamLogoPanel.BackgroundImageLayout = ImageLayout.Zoom
        If b.LOGOEXISTS Then
            teamLogoPanel.BackColor = Color.Transparent
            teamLogoPanel.BackgroundImage = b.LOGO
        End If

        teamLogoPanel.Size = New Size(960, 1080)
        teamLogoPanel.Location = New Point(0, 0)
        Me.Controls.Add(teamLogoPanel)
        teamLogoPanel.SendToBack()

        Dim teamLogoPanel2 As New Panel
        teamLogoPanel2.BackgroundImageLayout = ImageLayout.Zoom
        If r.LOGOEXISTS Then
            teamLogoPanel2.BackColor = Color.Transparent
            teamLogoPanel2.BackgroundImage = r.LOGO
        End If

        teamLogoPanel2.Size = New Size(960, 1080)
        teamLogoPanel2.Location = New Point(960, 0)
        Me.Controls.Add(teamLogoPanel2)
        teamLogoPanel2.SendToBack()
    End Sub


    Private Sub addBlueTeam(Optional teamName As String = "")
        Dim x As Integer = 150
        Dim y As Integer = 30

        Dim r As Integer = 0

        For Each d As ChampionData In blueTeam
            Dim p As Panel
            If teamName = "" Then
                p = getChampionPanel(d, True)
            Else
                Dim t As Team = SharedMem.getTeamByName(teamName)
                p = getChampionPanel(d, True, t.getData(r))
                r += 1
            End If
            p.Location = New Point(x, y)
            Me.Controls.Add(p)
            p.BringToFront()
            x += 355
        Next
    End Sub


    Private Sub addRedTeam(Optional teamName As String = "")
        Dim x As Integer = 150
        Dim y As Integer = 650

        Dim r As Integer = 0

        For Each d As ChampionData In redTeam
            Dim p As Panel
            If teamName = "" Then
                p = getChampionPanel(d, False)
            Else
                Dim t As Team = SharedMem.getTeamByName(teamName)
                p = getChampionPanel(d, False, t.getData(r))
                r += 1
            End If
            p.Location = New Point(x, y)
            Me.Controls.Add(p)
            p.BringToFront()
            x += 355
        Next
    End Sub


    Private Function getChampionPanel(d As ChampionData, teamBlue As Boolean, Optional playerName As String = "") As Panel
        Dim main As New Panel
        main.BackColor = Color.Transparent
        main.Size = New Size(170, 359)


        'Champion
        Dim x As New Panel
        x.BackgroundImage = d.Banner
        x.BackgroundImageLayout = ImageLayout.Stretch
        x.Size = New Size(170, 300)


        'Label Champ

        Dim lblChamp As New Label
        lblChamp.Size = New Size(170, 59)
        lblChamp.Text = d.Name
        If teamBlue Then
            lblChamp.TextAlign = ContentAlignment.TopCenter
            lblChamp.ForeColor = Color.Blue
            If Not playerName = "" Then
                lblChamp.Text &= vbCrLf & playerName
            End If
        Else
            lblChamp.TextAlign = ContentAlignment.BottomCenter
            lblChamp.ForeColor = Color.Red
            If Not playerName = "" Then
                lblChamp.Text = playerName & vbCrLf & lblChamp.Text
            End If
        End If
        lblChamp.Font = New Font("Arial", 14)
        lblChamp.BackColor = Color.Transparent

        If teamBlue Then
            lblChamp.Location = New Point(0, 300)
            x.Location = New Point(0, 0)
        Else
            lblChamp.Location = New Point(0, 0)
            x.Location = New Point(0, 59)
        End If
        main.Controls.Add(lblChamp)
        main.Controls.Add(x)
        Return main
    End Function

    Public Function getTeamBackground(teamRed As String, teamBlue As String) As Bitmap
        Dim erg As New Bitmap(1920, 1080, Imaging.PixelFormat.Format32bppRgb)
        Dim pnl As New Panel
        pnl.Size = New Size(1980, 1080)

        pnl.BackgroundImage = Image.FromFile(My.Settings.hintergrundbild)
        pnl.BackgroundImageLayout = ImageLayout.Stretch

        Dim b As Team = SharedMem.getTeamByName(teamBlue)
        Dim r As Team = SharedMem.getTeamByName(teamRed)

        Dim teamLogoPanel As New Panel
        teamLogoPanel.BackgroundImageLayout = ImageLayout.Center
        If b.LOGOEXISTS Then
            teamLogoPanel.BackColor = Color.Transparent
            teamLogoPanel.BackgroundImage = b.LOGO
        End If

        teamLogoPanel.Size = New Size(960, 1080)
        teamLogoPanel.Location = New Point(0, 0)
        pnl.Controls.Add(teamLogoPanel)
        teamLogoPanel.SendToBack()

        Dim teamLogoPanel2 As New Panel
        teamLogoPanel2.BackgroundImageLayout = ImageLayout.Center
        If r.LOGOEXISTS Then
            teamLogoPanel2.BackColor = Color.Transparent
            teamLogoPanel2.BackgroundImage = r.LOGO
        End If

        teamLogoPanel2.Size = New Size(960, 1080)
        teamLogoPanel2.Location = New Point(960, 0)
        pnl.Controls.Add(teamLogoPanel2)
        teamLogoPanel2.SendToBack()


        pnl.DrawToBitmap(erg, pnl.DisplayRectangle)
        Return erg
    End Function

End Class
