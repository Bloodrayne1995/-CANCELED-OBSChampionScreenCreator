Imports RiotSharp
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As RiotApi = RiotApi.GetInstance("47b32f02-72d1-4a24-acb9-9623d6a75e28")
        Dim s As StaticRiotApi = StaticRiotApi.GetInstance("47b32f02-72d1-4a24-acb9-9623d6a75e28")
        Try
            Dim x As SummonerEndpoint.Summoner = d.GetSummoner(RiotSharp.Region.euw, "EONA Bloodrayne")
            Dim txt As String = ""
            For Each a As GameEndpoint.Game In x.GetRecentGames()
                txt &= s.GetChampion(RiotSharp.Region.euw, a.ChampionId).Name & vbCrLf
            Next

            Label1.Text = txt
        Catch ex As Exception

        End Try

    End Sub
End Class