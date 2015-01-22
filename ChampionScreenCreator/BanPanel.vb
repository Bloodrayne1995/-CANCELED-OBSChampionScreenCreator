Public Class BanPanel

    Public Event Panel_OnClick(str As String)

    Private farbe As Color = Color.LightSkyBlue
    Private _team As String = "blau"
    Private _ban1 As ChampionData
    Private _ban2 As ChampionData
    Private _ban3 As ChampionData

    Private _selected As Integer = -1


#Region "Properties"

    Public ReadOnly Property BAN1 As ChampionData
        Get
            Return _ban1
        End Get
    End Property

    Public ReadOnly Property BAN2 As ChampionData
        Get
            Return _ban2
        End Get
    End Property

    Public ReadOnly Property BAN3 As ChampionData
        Get
            Return _ban3
        End Get
    End Property

#End Region

    Public Sub New(Optional farbe As String = "blau")

        InitializeComponent()

        If farbe = "rot" Then
            Me.farbe = Color.IndianRed
            _team = "rot"
        End If

    End Sub

    Public Sub lade(thr As Boolean)
        If thr Then
            Dim x As New Threading.Thread(AddressOf internalLade)
            x.Name = "Ban-Panel"
            x.Start()
        Else
            internalLade()
        End If
    End Sub

    Private Sub internalLade()
        setPanels()
    End Sub





    Private Sub setPanels()
        pctBan1.BackColor = farbe
        pctBan2.BackColor = farbe
        pctBan3.BackColor = farbe

        pctBan1.BackgroundImageLayout = ImageLayout.Zoom
        pctBan2.BackgroundImageLayout = ImageLayout.Zoom
        pctBan3.BackgroundImageLayout = ImageLayout.Zoom

        AddHandler pctBan1.Click, AddressOf onBanClick
        AddHandler pctBan2.Click, AddressOf onBanClick
        AddHandler pctBan3.Click, AddressOf onBanClick

        Invalidate()
    End Sub


    Public Sub setChampion(chd As ChampionData)
        Select Case _selected
            Case 0
                _ban1 = chd
                Exit Select
            Case 1
                _ban2 = chd
                Exit Select
            Case 2
                _ban3 = chd
                Exit Select 
        End Select
        Invalidate()
    End Sub


    Private Sub resetPanels()
        Select Case _selected
            Case 0
                pctBan1.BackColor = farbe
                Exit Select
            Case 1
                pctBan2.BackColor = farbe
                Exit Select
            Case 2
                pctBan3.BackColor = farbe
                Exit Select
        End Select
    End Sub

    Private Sub onBanClick(sender As Object, e As EventArgs)
        resetPanels()
        Dim x As Panel = DirectCast(sender, Panel)
        Select Case x.Name
            Case "pctBan1"
                _selected = 0
                Exit Select
            Case "pctBan2"
                _selected = 1
                Exit Select
            Case "pctBan3"
                _selected = 2
                Exit Select
        End Select
        x.BackColor = Color.Yellow
        RaiseEvent Panel_OnClick("ban_" & _team)
    End Sub

    Public Sub deselect()
        resetPanels()
        _selected = -1
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If Not IsNothing(_ban1) Then
            pctBan1.BackgroundImage = _ban1.Square
        End If

        If Not IsNothing(_ban2) Then
            pctBan2.BackgroundImage = _ban2.Square
        End If

        If Not IsNothing(_ban3) Then
            pctBan3.BackgroundImage = _ban3.Square
        End If

        MyBase.OnPaint(e)
    End Sub


End Class
