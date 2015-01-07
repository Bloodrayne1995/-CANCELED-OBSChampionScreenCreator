Public Class MainForm

    Public memory As MemoryManagement
    Public champSelector As ChampionSelector
    Private firstRun As Integer = 1
    Private selectedSlot As PictureBox = Nothing
    Public modus As Integer = 0


    Private team_blau As TeamPanel
    Private team_rot As TeamPanel
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

    Private Sub declareHandlers()

    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        champSelector.lade(Me)
        ladeTeamPanels()
    End Sub



    Public Sub setzeChampion(champName As String)
        If _selectedTeam = "rot" Then
            team_rot.setChampion(memory.championDB.getByName(champName))
        ElseIf _selectedTeam = "blau" Then
            team_blau.setChampion(memory.championDB.getByName(champName))
        End If
    End Sub


    Private Sub wennTeamPanelGesetzt(team As String)
        If team = "rot" Then
            team_blau.deselect()
        Else
            team_rot.deselect()
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
End Class