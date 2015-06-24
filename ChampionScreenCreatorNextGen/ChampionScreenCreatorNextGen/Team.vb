Imports ChampionScreenCreatorNextGen.TeamManager

Public Class Team

#Region "Intern"

    Private _teamName As TeamStruct 'TODO: Team-Implementation
    Private _champ1 As Champion
    Private _champ2 As Champion
    Private _sChamp1 As String = ""
    Private _sChamp2 As String = ""


#End Region

#Region "Konstruktoren"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        Spieler1.ROLLE = "Top"

        Spieler2.ROLLE = "Jungle"

        Spieler3.ROLLE = "Mid"

        Spieler4.ROLLE = "Carry"

        Spieler5.ROLLE = "Support"



    End Sub

#End Region

#Region "Event"

    Public Sub swapStart(x As Champion, sender As String) Handles Spieler1.swapStart, Spieler2.swapStart, Spieler3.swapStart, Spieler4.swapStart, Spieler5.swapStart
        If Not IsNothing(_champ1) And Not IsNothing(_champ2) Then
            Exit Sub
        End If

        If IsNothing(_champ1) Then
            _champ1 = x
            _sChamp1 = sender
        Else
            If IsNothing(_champ2) Then
                _champ2 = x
                _sChamp2 = sender
            End If
        End If

        If Not IsNothing(_champ1) And Not IsNothing(_champ2) Then
            swap()
        End If
    End Sub

    Public Sub swapCancel() Handles Spieler1.swapCancel, Spieler2.swapCancel, Spieler3.swapCancel, Spieler4.swapCancel, Spieler5.swapCancel
        _champ1 = Nothing
        _champ2 = Nothing
    End Sub

#End Region


    Private Sub swap()
        If IsNothing(_champ1) Or IsNothing(_champ2) Then
            Exit Sub
        End If

        Select Case _sChamp1
            Case "Spieler1"
                Spieler1.CHAMPION = _champ2
                Spieler1.updateSpieler()
                Exit Select
            Case "Spieler2"
                Spieler2.CHAMPION = _champ2
                Spieler2.updateSpieler()
                Exit Select
            Case "Spieler3"
                Spieler3.CHAMPION = _champ2
                Spieler3.updateSpieler()
                Exit Select
            Case "Spieler4"
                Spieler4.CHAMPION = _champ2
                Spieler4.updateSpieler()
                Exit Select
            Case "Spieler5"
                Spieler5.CHAMPION = _champ2
                Spieler5.updateSpieler()
                Exit Select
        End Select

        Select Case _sChamp2
            Case "Spieler1"
                Spieler1.CHAMPION = _champ1
                Spieler1.updateSpieler()
                Exit Select
            Case "Spieler2"
                Spieler2.CHAMPION = _champ1
                Spieler2.updateSpieler()
                Exit Select
            Case "Spieler3"
                Spieler3.CHAMPION = _champ1
                Spieler3.updateSpieler()
                Exit Select
            Case "Spieler4"
                Spieler4.CHAMPION = _champ1
                Spieler4.updateSpieler()
                Exit Select
            Case "Spieler5"
                Spieler5.CHAMPION = _champ1
                Spieler5.updateSpieler()
                Exit Select
        End Select

        Dim x As New Threading.Thread(Sub()
                                          Threading.Thread.Sleep(100)
                                          completeSwap(_sChamp1)
                                          completeSwap(_sChamp2)
                                      End Sub)
        x.Start()

        swapCancel()
    End Sub

    Public Sub showPlayerNames()
        Spieler1.showPlayerName()
        Spieler2.showPlayerName()
        Spieler3.showPlayerName()
        Spieler4.showPlayerName()
        Spieler5.showPlayerName()
    End Sub


    Public Sub hidePlayerNames()
        Spieler1.hidePlayerName()
        Spieler2.hidePlayerName()
        Spieler3.hidePlayerName()
        Spieler4.hidePlayerName()
        Spieler5.hidePlayerName()
    End Sub


    Public Sub resetChampions()
        Spieler1.resetChampion()
        Spieler2.resetChampion()
        Spieler3.resetChampion()
        Spieler4.resetChampion()
        Spieler5.resetChampion()
    End Sub

    Public Sub completeSwap(spielerN As String)
        Select Case spielerN
            Case "Spieler1"
                Spieler1.swapCompleted()
                Exit Select
            Case "Spieler2"
                Spieler2.swapCompleted()
                Exit Select
            Case "Spieler3"
                Spieler3.swapCompleted()
                Exit Select
            Case "Spieler4"
                Spieler4.swapCompleted()
                Exit Select
            Case "Spieler5"
                Spieler5.swapCompleted()
                Exit Select
        End Select
    End Sub


    Public Sub ladeTeams()
        Dim x As List(Of TeamStruct) = Form1.teamDB.getTeams
        For Each t As TeamStruct In x
            ComboBox1.Items.Add(t)
        Next
    End Sub


    Private Sub changeTeam() Handles ComboBox1.SelectedIndexChanged
        Dim t As TeamStruct = DirectCast(ComboBox1.SelectedItem, TeamStruct)
        Spieler1.lblPlayername.Text = t.top
        Spieler2.lblPlayername.Text = t.jng
        Spieler3.lblPlayername.Text = t.mid
        Spieler4.lblPlayername.Text = t.carry
        Spieler5.lblPlayername.Text = t.support
        _teamName = t
    End Sub

    Public Function getTeam() As TeamStruct
        Return _teamName
    End Function

End Class
