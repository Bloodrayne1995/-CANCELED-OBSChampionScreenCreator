Public Class ChampionPanel

    Private team_farbe As String = "blau"
    Private champ As ChampionData


    Public Sub New(ByVal championD As ChampionData, Optional ByVal farbe As String = "blau")

        InitializeComponent()

        Me.team_farbe = farbe
        Me.champ = championD

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
        Me.BackgroundImageLayout = ImageLayout.Stretch
        If Me.team_farbe = "blau" Then
            Me.BackgroundImage = Image.FromFile(".\data\images\output\Spielerrahmen.Blau.png")
        Else
            Me.BackgroundImage = Image.FromFile(".\data\images\output\Spielerrahmen.Rot.png")
        End If
    End Sub



End Class
