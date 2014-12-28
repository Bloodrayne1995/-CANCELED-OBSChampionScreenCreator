Public Class SharedMem

    Public Shared database As New ChampionDatabase
    Public Shared liste As ListBox
    Public Shared teams As New TeamList


    Public Shared Function getChampionByName(name As String) As ChampionData
        For Each x As ChampionData In database.ChampionDataList
            If (x.Name = name) Then
                Return x
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function getTeamByName(name As String) As Team
        For Each x As Team In teams._liste
            If x.NAME = name Then
                Return x
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function getTeamsByRegion(regionname As String) As List(Of Team)
        Dim x As New List(Of Team)
        For Each s As Team In teams._liste
            If s.REGION = regionname And Not s.REGION = s.NAME Then
                x.Add(s)
            End If
        Next
        Return x
    End Function


    Public Shared Sub replaceTeamByName(replace As String, replacement As Team)
        'Suchen und löschen
       
        removeTeamByName(replace)
      
        'Hinzufügen

        teams._liste.Add(replacement)


    End Sub

    Public Shared Sub removeTeamByName(remove As String)
        Dim index As Integer = -1
        For i As Integer = 0 To teams._liste.Count - 1
            If teams._liste(i).NAME = remove Then
                index = i
            End If
        Next
        If Not index = -1 Then
            teams._liste.RemoveAt(index)
        End If
    End Sub


End Class
