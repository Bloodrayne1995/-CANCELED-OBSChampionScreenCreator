Public Class Side

    Private DB As ChampionDatabase

    Public Sub setDB(ByRef d As ChampionDatabase)
        DB = d
    End Sub

    Public Sub showPlayerNames()
        Team1.showPlayerNames()
    End Sub

    Public Sub hidePlayerNames()
        Team1.hidePlayerNames()
    End Sub

    Public Sub setSide(blau As Boolean)
        If blau Then
            Me.BackColor = Color.LightBlue
        Else
            Me.BackColor = Color.FromArgb(255, 250, 95, 95)
        End If
    End Sub

    Public Sub resetChampionsAndBans()
        Team1.resetChampions()
        Bans1.resetBans()
    End Sub

    
End Class
