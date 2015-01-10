Imports System.Threading

Public Class TeamPanel

    Private farbe As Color = Color.LightSkyBlue
    Private _team As String = "blau"
    Private _top As ChampionData
    Private _jungle As ChampionData
    Private _mid As ChampionData
    Private _carry As ChampionData
    Private _support As ChampionData

    Private _swap1 As String = ""
    Private _swap2 As String = ""
    Private _selected As Integer = -1


    'Internal
    Private _loadedButtons As Boolean = False
    Private _loadedPanels As Boolean = False

    'Events
    Public Event ChampionPanelSelected(team As String)

#Region "Konstruktoren"

    Public Sub New(Optional ByVal team_farbe As String = "blau")

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        If team_farbe = "rot" Then
            farbe = Color.IndianRed
            _team = "rot"
        End If


    End Sub

#End Region

#Region "Properties"

    Public Property TOPLane As ChampionData
        Get
            Return _top
        End Get
        Set(value As ChampionData)
            _top = value
        End Set
    End Property

    Public Property JUNGLE As ChampionData
        Get
            Return _jungle
        End Get
        Set(value As ChampionData)
            _jungle = value
        End Set
    End Property

    Public Property MID As ChampionData
        Get
            Return _mid
        End Get
        Set(value As ChampionData)
            _mid = value
        End Set
    End Property

    Public Property CARRY As ChampionData
        Get
            Return _carry
        End Get
        Set(value As ChampionData)
            _carry = value
        End Set
    End Property

    Public Property SUPPORT As ChampionData
        Get
            Return _support
        End Get
        Set(value As ChampionData)
            _support = value
        End Set
    End Property

#End Region

#Region "Methoden"
    Public Sub lade(withThr As Boolean)
        If withThr Then
            Dim x As New Thread(AddressOf ladeSync)
            x.Name = "Team-Panel Aufbau-Thread"
            x.Start()
        Else
            ladeSync()
        End If
    End Sub


    Private Sub ladeSync()
        setFarbe()
        setButtons()
        setPanels()
    End Sub

    Private Sub setButtons()
        'Hintergrundbild
        Dim bild As Image = Image.FromFile(".\data\images\swap_icon.png")
        cmdTauscheCarry.BackgroundImage = bild.Clone
        cmdTauscheSupport.BackgroundImage = bild.Clone
        cmdTauscheMid.BackgroundImage = bild.Clone
        cmdTauscheTop.BackgroundImage = bild.Clone
        cmdTauscheJungle.BackgroundImage = bild.Clone
        bild.Dispose()

        'Button-Format
        cmdTauscheCarry.FlatStyle = FlatStyle.Flat
        cmdTauscheSupport.FlatStyle = FlatStyle.Flat
        cmdTauscheMid.FlatStyle = FlatStyle.Flat
        cmdTauscheTop.FlatStyle = FlatStyle.Flat
        cmdTauscheJungle.FlatStyle = FlatStyle.Flat

        'Hintergrundformat
        cmdTauscheCarry.BackgroundImageLayout = ImageLayout.Zoom
        cmdTauscheSupport.BackgroundImageLayout = ImageLayout.Zoom
        cmdTauscheMid.BackgroundImageLayout = ImageLayout.Zoom
        cmdTauscheJungle.BackgroundImageLayout = ImageLayout.Zoom
        cmdTauscheTop.BackgroundImageLayout = ImageLayout.Zoom

        'Rahmen
        cmdTauscheCarry.FlatAppearance.BorderSize = 0
        cmdTauscheSupport.FlatAppearance.BorderSize = 0
        cmdTauscheMid.FlatAppearance.BorderSize = 0
        cmdTauscheTop.FlatAppearance.BorderSize = 0
        cmdTauscheJungle.FlatAppearance.BorderSize = 0

        'Text
        cmdTauscheCarry.Text = ""
        cmdTauscheSupport.Text = ""
        cmdTauscheMid.Text = ""
        cmdTauscheTop.Text = ""
        cmdTauscheJungle.Text = ""

        'Handler
        If Not _loadedButtons Then
            AddHandler cmdTauscheCarry.Click, AddressOf onTauschClick
            AddHandler cmdTauscheSupport.Click, AddressOf onTauschClick
            AddHandler cmdTauscheMid.Click, AddressOf onTauschClick
            AddHandler cmdTauscheTop.Click, AddressOf onTauschClick
            AddHandler cmdTauscheJungle.Click, AddressOf onTauschClick
            _loadedButtons = True
        End If
    End Sub

    Private Sub setFarbe()
        pnlCarry.BackColor = farbe
        pnlJungle.BackColor = farbe
        pnlMid.BackColor = farbe
        pnlSupport.BackColor = farbe
        pnlTop.BackColor = farbe
    End Sub


    Private Sub setPanels()
        If Not _loadedPanels Then
            AddHandler pnlCarry.Click, AddressOf onChampionPanelGeklickt
            AddHandler pnlJungle.Click, AddressOf onChampionPanelGeklickt
            AddHandler pnlMid.Click, AddressOf onChampionPanelGeklickt
            AddHandler pnlTop.Click, AddressOf onChampionPanelGeklickt
            AddHandler pnlSupport.Click, AddressOf onChampionPanelGeklickt
            _loadedPanels = True
        End If
    End Sub

    Private Sub tausche()
        Dim swap1_cd As ChampionData = Nothing
        Dim swap2_cd As ChampionData = Nothing

        Select Case _swap1
            Case "Top"
                swap1_cd = TOPLane
                Exit Select
            Case "Jungle"
                swap1_cd = JUNGLE
                Exit Select
            Case "Mid"
                swap1_cd = MID
                Exit Select
            Case "Carry"
                swap1_cd = CARRY
                Exit Select
            Case "Support"
                swap1_cd = SUPPORT
                Exit Select
        End Select


        Select Case _swap2
            Case "Top"
                swap2_cd = TOPLane
                TOPLane = swap1_cd
                Exit Select
            Case "Jungle"
                swap2_cd = JUNGLE
                JUNGLE = swap1_cd
                Exit Select
            Case "Mid"
                swap2_cd = MID
                MID = swap1_cd
                Exit Select
            Case "Carry"
                swap2_cd = CARRY
                CARRY = swap1_cd
                Exit Select
            Case "Support"
                swap2_cd = SUPPORT
                SUPPORT = swap1_cd
                Exit Select
        End Select

        Select Case _swap1
            Case "Top"
                TOPLane = swap2_cd
                Exit Select
            Case "Jungle"
                JUNGLE = swap2_cd
                Exit Select
            Case "Mid"
                MID = swap2_cd
                Exit Select
            Case "Carry"
                CARRY = swap2_cd
                Exit Select
            Case "Support"
                SUPPORT = swap2_cd
                Exit Select
        End Select

        setButtons()
        _swap1 = ""
        _swap2 = ""
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If Not IsNothing(TOPLane) Then
            pnlTop.BackgroundImage = TOPLane.Square
        Else
            pnlTop.BackgroundImage = Nothing
        End If

        If Not IsNothing(JUNGLE) Then
            pnlJungle.BackgroundImage = JUNGLE.Square
        Else
            pnlJungle.BackgroundImage = Nothing
        End If

        If Not IsNothing(MID) Then
            pnlMid.BackgroundImage = MID.Square
        Else
            pnlMid.BackgroundImage = Nothing
        End If

        If Not IsNothing(CARRY) Then
            pnlCarry.BackgroundImage = CARRY.Square
        Else
            pnlCarry.BackgroundImage = Nothing
        End If

        If Not IsNothing(SUPPORT) Then
            pnlSupport.BackgroundImage = SUPPORT.Square
        Else
            pnlSupport.BackgroundImage = Nothing
        End If

        MyBase.OnPaint(e)
    End Sub

    Private Sub resetPanel()
        Select Case _selected
            Case 0
                pnlTop.BackColor = farbe
                Exit Select
            Case 1
                pnlJungle.BackColor = farbe
                Exit Select
            Case 2
                pnlMid.BackColor = farbe
                Exit Select
            Case 3
                pnlCarry.BackColor = farbe
                Exit Select
            Case 4
                pnlSupport.BackColor = farbe
                Exit Select
        End Select
    End Sub

    Public Overloads Sub setChampion(chd As ChampionData)
        resetPanel()
        Select Case _selected
            Case 0
                TOPLane = chd
                Exit Select
            Case 1
                JUNGLE = chd
                Exit Select
            Case 2
                MID = chd
                Exit Select
            Case 3
                CARRY = chd
                Exit Select
            Case 4
                SUPPORT = chd
                Exit Select
        End Select
        Invalidate()
    End Sub

    Public Sub deselect()
        resetPanel()
        _selected = -1
    End Sub

#End Region


#Region "Handler"

    Private Sub onTauschClick(sender As Object, e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn.FlatAppearance.BorderSize = 1 Then
            Exit Sub
        End If
        If _swap1 = "" Then
            _swap1 = btn.Tag
        ElseIf _swap2 = "" Then
            _swap2 = btn.Tag
        Else
            Exit Sub
        End If


        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.BorderColor = Color.Yellow

        If Not _swap1 = "" And Not _swap2 = "" Then
            tausche()
        End If
    End Sub


    Public Sub onChampionPanelGeklickt(sender As Object, e As System.EventArgs)
        resetPanel()
        Dim pnl As Panel = DirectCast(sender, Panel)
        Select Case pnl.Tag
            Case "Top"
                _selected = 0
                Exit Select
            Case "Jungle"
                _selected = 1
                Exit Select
            Case "Mid"
                _selected = 2
                Exit Select
            Case "Carry"
                _selected = 3
                Exit Select
            Case "Support"
                _selected = 4
                Exit Select
        End Select
        pnl.BackColor = Color.Yellow
        Debug.WriteLine(_selected)
        RaiseEvent ChampionPanelSelected(_team)
    End Sub


#End Region


End Class
