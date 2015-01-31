Public Class MainForm

    Public memory As MemoryManagement
    Public champSelector As ChampionSelector
    Public banSelector As ChampionSelector

    Private firstRun As Integer = 1
    Private selectedSlot As PictureBox = Nothing
    Public modus As Integer = 0


    Private team_blau As TeamPanel
    Private team_rot As TeamPanel
    Private ban_blau As BanPanel
    Private ban_rot As BanPanel


    Private _selectedTeam As String = ""

    Public Sub New()
        CheckForIllegalCrossThreadCalls = False
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        memory = New MemoryManagement
        memory.load()

        champSelector = New ChampionSelector
        champSelector.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(champSelector)

        banSelector = New ChampionSelector
        banSelector.OVERRIDE_MAIN_MODE = True
        banSelector.Dock = DockStyle.Fill


        declareHandlers()

        ToolStripComboBox1.SelectedIndex = 0
    End Sub


    Private Sub ladeTeamPanels()
        team_blau = New TeamPanel()
        team_blau.lade(True)
        team_blau.Dock = DockStyle.Fill
        grpBlauAufstellung.Controls.Add(team_blau)
        AddHandler team_blau.ChampionPanelSelected, AddressOf wennTeamPanelGesetzt

        team_rot = New TeamPanel("rot")
        team_rot.lade(True)
        team_rot.Dock = DockStyle.Fill
        grpRotAufstellung.Controls.Add(team_rot)
        AddHandler team_rot.ChampionPanelSelected, AddressOf wennTeamPanelGesetzt
    End Sub

    Private Sub ladeBanPanels()
        ban_blau = New BanPanel
        ban_blau.lade(True)
        ban_blau.Dock = DockStyle.Fill
        grpBlauBanns.Controls.Add(ban_blau)
        AddHandler ban_blau.Panel_OnClick, AddressOf wennTeamPanelGesetzt


        ban_rot = New BanPanel("rot")
        ban_rot.lade(True)
        ban_rot.Dock = DockStyle.Fill
        grpRotBanns.Controls.Add(ban_rot)
        AddHandler ban_rot.Panel_OnClick, AddressOf wennTeamPanelGesetzt

    End Sub

    Private Sub declareHandlers()

    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        champSelector.lade(Me)
        banSelector.lade(Me)
        ladeTeamPanels()
        ladeBanPanels()
    End Sub



    Public Sub setzeChampion(champName As String)
        If Not _selectedTeam.Contains("ban") Then
            If _selectedTeam = "rot" Then
                team_rot.setChampion(memory.championDB.getByName(champName))
            ElseIf _selectedTeam = "blau" Then
                team_blau.setChampion(memory.championDB.getByName(champName))
            End If
            banSelector.hideRowByName(champName)
        Else
            If _selectedTeam = "ban_rot" Then
                ban_rot.setChampion(memory.championDB.getByName(champName))
            ElseIf _selectedTeam = "ban_blau" Then
                ban_blau.setChampion(memory.championDB.getByName(champName))
            End If
            champSelector.hideRowByName(champName)
        End If
    End Sub


    Private Sub wennTeamPanelGesetzt(team As String)
        If team = "rot" Then
            team_blau.deselect()
            ban_blau.deselect()
            ban_rot.deselect()
            SplitContainer1.Panel1.Controls.Clear()
            SplitContainer1.Panel1.Controls.Add(champSelector)
        ElseIf team = "blau" Then
            team_rot.deselect()
            ban_blau.deselect()
            ban_rot.deselect()
            SplitContainer1.Panel1.Controls.Clear()
            SplitContainer1.Panel1.Controls.Add(champSelector)
        ElseIf team = "ban_blau" Then
            team_blau.deselect()
            team_rot.deselect()
            ban_rot.deselect()
            SplitContainer1.Panel1.Controls.Clear()
            SplitContainer1.Panel1.Controls.Add(banSelector)
        Else
            team_blau.deselect()
            team_rot.deselect()
            ban_blau.deselect()
            SplitContainer1.Panel1.Controls.Clear()
            SplitContainer1.Panel1.Controls.Add(banSelector)
        End If
        _selectedTeam = team
    End Sub

   
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If firstRun = 1 Then
            firstRun = 0
        Else
            modus = ToolStripComboBox1.SelectedIndex
        End If
    End Sub

    Private Sub ZeigeTestImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZeigeTestImageToolStripMenuItem.Click
        Dim x As New ImageCreator(memory)
        AddHandler x.on_image_created, AddressOf test
        x.testImage()
    End Sub

    Private Sub test(x As Bitmap)
        Dim a As New Form
        a.Size = New Size(1280, 720)

        a.BackgroundImageLayout = ImageLayout.Stretch
        a.BackgroundImage = x
        a.ShowDialog()
    End Sub


    Private Sub SaveTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTestToolStripMenuItem.Click
        memory.outputSettings.save()
    End Sub

    Private Sub cmdVorschau_Click(sender As Object, e As EventArgs) Handles cmdVorschau.Click
        Dim x As New ImageCreator(memory)
        x.setBans("blau", ban_blau)
        x.setBans("rot", ban_rot)

        x.setTeam("blau", team_blau)
        x.setTeam("rot", team_rot)

        AddHandler x.on_image_created, AddressOf test
        x.create(True)
    End Sub

    Private Sub AusgabeOptionenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusgabeOptionenToolStripMenuItem.Click
        Dim x As New OutputSettings(memory)
        x.ShowDialog()

    End Sub
End Class