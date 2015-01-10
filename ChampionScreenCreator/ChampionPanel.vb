''' <summary>
''' Schnittstelle 
''' </summary>
''' <remarks></remarks>

Public Class ChampionPanel

    Private team_farbe As String = "blau"
    Private champ As ChampionData
    Public Event on_load_finished(x As ChampionPanel)
    Public mem As MemoryManagement


    Public Sub New(ByVal championD As ChampionData, ByRef memo As MemoryManagement, Optional ByVal farbe As String = "blau")

        InitializeComponent()

        Me.team_farbe = farbe
        Me.champ = championD
        Me.mem = memo
    End Sub


    Public Sub lade(thr As Boolean)
        If thr Then
            Dim x As New Threading.Thread(AddressOf internalLade)
            x.Start()
        Else
            internalLade()
        End If
    End Sub

    Private Sub internalLade()

        'Hintergrund-Bild
        Me.BackgroundImageLayout = ImageLayout.Stretch
        If Me.team_farbe = "blau" Then
            Me.BackgroundImage = Image.FromFile(".\data\images\output\Spielerrahmen.Blau.png")
        Else
            Me.BackgroundImage = Image.FromFile(".\data\images\output\Spielerrahmen.Rot.png")
        End If
        Me.Size = Me.BackgroundImage.Size


        'Champion-Bild
        Dim pctChamp As New PictureBox
        pctChamp.BackgroundImageLayout = ImageLayout.Stretch
        pctChamp.BackgroundImage = champ.Banner
        pctChamp.Size = New Size(213, 376)
        pctChamp.Location = New Point(6, 6)
        Me.Controls.Add(pctChamp)


        'Label:
        Dim lbl As New Label
        lbl.Text = champ.Name
        lbl.Width = Me.Width
        lbl.Font = mem.fonts.getFontByID("ChampionFont")
        lbl.ForeColor = mem.fonts.getColor("ChampionFont")
        lbl.TextAlign = mem.fonts.getAlign("ChampionFont")
        lbl.BackColor = Color.Transparent
        lbl.Location = New Point(0, pctChamp.Height + 6)

        If mem.outputSettings.settings("showChampionNames") = "true" Then
            Me.Controls.Add(lbl)
        End If

        RaiseEvent on_load_finished(Me)
    End Sub



End Class
