Public Class Team_Editor

    Private _selectedRegion As String = ""
    Private _selectedTeam As String = ""
    Private _selectedTeamO As Team = Nothing

    Private _addNewTeamB As Boolean = False
    Private _newTeam As Team = Nothing


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        initTeamList()


    End Sub


    Public Sub initTeamList()
        trvTeams.Nodes.Clear()
        For Each x As Team In SharedMem.teams._liste
            If x.REGION = x.NAME Then
                Dim a As TreeNode = trvTeams.Nodes.Add(x.REGION)
                For Each d As Team In SharedMem.getTeamsByRegion(x.REGION)
                    a.Nodes.Add(d.NAME)
                Next
            End If
        Next
    End Sub

    Private Sub trvTeams_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvTeams.NodeMouseClick
        If e.Node.Nodes.Count > 0 Then
            'Region
            _selectedRegion = e.Node.Text
        Else

            'Team
            Dim t As Team = SharedMem.getTeamByName(e.Node.Text)
            If Not t.REGION = t.NAME Then

                txtCarry.Text = t.ADC
                txtJungle.Text = t.JNG
                txtMid.Text = t.MID
                txtName.Text = t.NAME
                txtRegion.Text = t.REGION
                txtSupport.Text = t.SUP
                txtTop.Text = t.TOP
                cmdSelectLogo.Tag = t.LOGOPFAD

                _selectedTeamO = t
                _selectedRegion = t.REGION
                _selectedTeam = e.Node.Text
            Else
                _selectedRegion = e.Node.Text
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveTeam_Click(sender As Object, e As EventArgs) Handles cmdSaveTeam.Click
        If _addNewTeamB Then
            If Not cmdSelectLogo.Tag = "" Then
                _newTeam.LOGOPFAD = cmdSelectLogo.Tag
                _newTeam.LOGOEXISTS = True
                _newTeam.LOGO = Image.FromFile(cmdSelectLogo.Tag)
            Else
                _newTeam.LOGOEXISTS = False
            End If
            _newTeam.NAME = txtName.Text
            _newTeam.ADC = txtCarry.Text
            _newTeam.TOP = txtTop.Text
            _newTeam.SUP = txtSupport.Text
            _newTeam.MID = txtMid.Text
            _newTeam.JNG = txtJungle.Text
            SharedMem.teams._liste.Add(_newTeam)
        Else
            Dim t As New Team(_selectedRegion)
            t.NAME = txtName.Text
            t.SUP = txtSupport.Text
            t.TOP = txtTop.Text
            t.MID = txtMid.Text
            t.ADC = txtCarry.Text
            If Not cmdSelectLogo.Tag = "" Then
                t.LOGO = Image.FromFile(cmdSelectLogo.Tag)
                t.LOGOPFAD = cmdSelectLogo.Tag
                t.LOGOEXISTS = True
            Else
                t.LOGOEXISTS = False
            End If

            SharedMem.replaceTeamByName(_selectedTeam, t)
            SharedMem.teams.save()
        End If
        _selectedRegion = ""
        _selectedTeam = ""
        _selectedTeamO = Nothing
        clearTeamdata()
        initTeamList()
        SharedMem.teams.save()
    End Sub

    Private Sub cmdDeleteTeam_Click(sender As Object, e As EventArgs) Handles cmdDeleteTeam.Click
        Dim msgResult As MsgBoxResult = MsgBox("Wollen Sie wirklich dieses Team löschen?", MsgBoxStyle.YesNo, "Löschen bestätigen")
        If msgResult = MsgBoxResult.Yes Then
            SharedMem.removeTeamByName(_selectedTeam)
            SharedMem.teams.save()
        End If
        _selectedTeam = ""
        _selectedRegion = ""
        clearTeamdata()
        initTeamList()
    End Sub


    Private Sub clearTeamdata()
        txtCarry.Text = ""
        txtJungle.Text = ""
        txtMid.Text = ""
        txtName.Text = ""
        txtRegion.Text = ""
        txtSupport.Text = ""
        txtSupport.Text = ""
        txtTop.Text = ""
        
    End Sub

    Private Sub cmdSelectLogo_Click(sender As Object, e As EventArgs) Handles cmdSelectLogo.Click
        Dim ofd As New OpenFileDialog
        ofd.Multiselect = False
        ofd.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp"
        ofd.CheckPathExists = True
        ofd.CheckFileExists = False

        Dim dres As DialogResult = ofd.ShowDialog
        If dres = Windows.Forms.DialogResult.OK Or dres = Windows.Forms.DialogResult.Yes Then
            cmdSelectLogo.Tag = ofd.FileName
            cmdSelectLogo.BackgroundImage = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub cmdAddNewTeam_Click(sender As Object, e As EventArgs) Handles cmdAddNewTeam.Click
        If _selectedRegion = "" Then
            MsgBox("Sie müssen erst eine Region auswählen um ein Team  zu erstellen")
        Else
            _addNewTeamB = True
            _newTeam = New Team(_selectedRegion)
            txtRegion.Text = _selectedRegion
            txtName.Focus()
        End If
    End Sub

    Private Sub cmdAddNewRegion_Click(sender As Object, e As EventArgs) Handles cmdAddNewRegion.Click
        Dim input As String = InputBox("Region-Name eingeben", "NewRegion")
        If input = "" Then
            MsgBox("Sie müssen ein Name eintragen um eine Region zu erstellen")
        Else
            Dim t As New Team(input)
            t.NAME = input
            SharedMem.teams._liste.Add(t)
            SharedMem.teams.save()
            initTeamList()
            clearTeamdata()
            _selectedRegion = ""
            _selectedTeam = ""
            _selectedTeamO = Nothing
        End If
    End Sub
End Class