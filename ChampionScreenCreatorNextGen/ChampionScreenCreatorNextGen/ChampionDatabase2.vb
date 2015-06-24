Imports RiotSharp
Imports RiotSharp.StaticDataEndpoint

Public Class ChampionDatabase2

#Region "Intern"

    Private _champions As New Dictionary(Of Integer, Champion)
    Private _apikey As String = "47b32f02-72d1-4a24-acb9-9623d6a75e28"

#End Region


#Region "Events"

    Public Event onChampionLoaded(c As Champion)
    Public Event onFinishedLoading()

#End Region

#Region "Abfrage-Methoden"


    ''' <summary>
    ''' Gibt das Champion-Objekt anhand der Champion-ID zurück
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionById(ByVal id As Integer) As Champion
        Return _champions(id)
    End Function

    ''' <summary>
    ''' Ermittelt die ID des Champions anhand des Namens
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionIdByName(ByVal name As String) As Integer
        Dim erg As Integer = -1
        For i As Integer = 0 To _champions.Count - 1
            Dim key As Integer = _champions.Keys(i)
            If (_champions(key).isChampion(name)) Then
                erg = _champions(key).ID
                Exit For
            End If
        Next
        Return erg
    End Function

    ''' <summary>
    ''' Gibt das Champion-Objekt anhand des Namens zurück
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionByName(ByVal name As String) As Champion
        Return getChampionById(getChampionIdByName(name))
    End Function

    ''' <summary>
    ''' Gibt die Anzahl der geladenen Champions zurück
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionCount() As Integer
        Return _champions.Count
    End Function

    ''' <summary>
    ''' Gibt den Champion anhand eines Iterators zurück
    ''' </summary>
    ''' <param name="iter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionByIterator(iter As Integer) As Champion
        Return _champions(_champions.Keys(iter))
    End Function

    ''' <summary>
    ''' Gibt eine Ansammlung von Champions zurück die eine gewisse Rolle haben
    ''' </summary>
    ''' <param name="rollen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionsWithRoles(ParamArray rollen() As TagStatic) As Champion()
        Dim erg As New List(Of Champion)
        For i As Integer = 0 To getChampionCount() - 1
            Dim role2 As Boolean = False
            For j As Integer = 0 To rollen.Count - 1
                If (getChampionByIterator(i).hasRole(rollen(j))) Then
                    role2 = True
                End If
            Next
            If role2 Then
                erg.Add(getChampionByIterator(i))
            End If
        Next

        Return erg.ToArray
    End Function

    ''' <summary>
    ''' Gibt eine Ansammlung von Champions zurück die eine gewisse Rolle haben
    ''' </summary>
    ''' <param name="rolle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getChampionsWithRoles(ByVal rolle As String) As Champion()
        Dim erg As New List(Of Champion)
        Dim rollen() As String = rolle.Split("#")
        For i As Integer = 0 To getChampionCount() - 1
            Dim role2 As Boolean = False
            For j As Integer = 0 To rollen.Count - 1
                If Not rollen(j) = "" Then
                    If (getChampionByIterator(i).hasRole(rollen(j))) Then
                        role2 = True
                    End If
                End If
            Next
            If role2 Then
                erg.Add(getChampionByIterator(i))
            End If
        Next

        Return erg.ToArray
    End Function



#End Region

#Region "Laden"

    Public Sub ladeDB()
        Console.WriteLine("Daten aus RIOTAPI")
        _champions.Clear()
        Dim client As StaticRiotApi = StaticRiotApi.GetInstance(_apikey)
        Dim liste As ChampionListStatic = client.GetChampions(region:=Region.euw, language:=Language.de_DE, championData:=ChampionData.all)

        For i As Integer = 0 To liste.Champions.Keys.Count - 1
            Dim k As String = liste.Champions.Keys(i)
            Dim x As ChampionStatic = liste.Champions(k)
            Dim c As New Champion(x)
            c.BANNER = Image.FromFile(".\data\champions\banner\" & x.Key & "_0.jpg")
            c.ICON = Image.FromFile(".\data\champions\icons\" & x.Key & "_Square_0.png")
            Console.WriteLine(c.ToString)
            _champions.Add(c.ID, c)
            RaiseEvent onChampionLoaded(c)
        Next
        RaiseEvent onFinishedLoading()
    End Sub

#End Region


End Class
