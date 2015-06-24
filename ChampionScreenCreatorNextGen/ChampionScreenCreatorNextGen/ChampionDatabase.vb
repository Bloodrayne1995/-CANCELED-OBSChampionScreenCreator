Imports System.Xml

Public Class ChampionDatabase

#Region "Intern"

    Private _champions As New Dictionary(Of Integer, Champion)

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
    Public Function getChampionsWithRoles(ParamArray rollen() As String) As Champion()
        Dim erg As New List(Of Champion)
        For i As Integer = 0 To getChampionCount()
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

#Region "Verwaltung"

    Public Sub addChampion(id As Integer, display_name As String, banner As Image, icon As Image, Optional primaryRole As String = "", Optional secondaryRole As String = "")
        Dim x As New Champion
        x.ID = id
        x.DISPLAYNAME = display_name
        x.BANNER = banner
        x.ICON = icon
        x.PRIMARY_ROLE = primaryRole
        x.SECOND_ROLE = secondaryRole
        If Not isChampionInDB(id) And Not isChampionInDB(display_name) Then
            _champions.Add(id, x)
        Else
            setChampion(id, x)
        End If
    End Sub

    Public Sub addChampion(cha As Champion)
        _champions.Add(cha.ID, cha)
    End Sub

    Public Function isChampionInDB(id As Integer) As Boolean
        Return _champions.ContainsKey(id)
    End Function

    Public Function isChampionInDB(name As String) As Boolean
        Dim erg As Boolean = False
        For i As Integer = 0 To _champions.Count - 1
            Dim k As Integer = _champions.Keys(i)
            If (_champions(k).isChampion(name)) Then
                erg = True
            End If
        Next
        Return erg
    End Function

    Public Sub setChampion(id As Integer, cha As Champion)
        If isChampionInDB(id) Then
            _champions(id) = cha
        Else
            addChampion(cha)
        End If
    End Sub

    Public Sub removeChampion(id As Integer)
        If isChampionInDB(id) Then
            _champions.Remove(id)
        End If
    End Sub

    Public Sub removeChampion(name As String)
        If isChampionInDB(name) Then
            removeChampion(getChampionIdByName(name))
        End If
    End Sub
#End Region

#Region "Lade-Methoden"

    Public Sub ladeDB()
        _champions.Clear()
        Dim xmlDoc As New XmlDocument
        xmlDoc.Load(My.Settings.championDB_XML)
        Dim root As XmlNode = xmlDoc.LastChild

        For Each x As XmlNode In root.ChildNodes
            If x.Name = "champion" Then
                Dim name As String = x.Attributes("display_name").Value
                Dim id As Integer = Integer.Parse(x.Attributes("id").Value)
                Dim banner As Image = Image.FromFile(".\data\champions\banner\" & x.Attributes("banner").Value & "_0.jpg")
                Dim icon As Image = Image.FromFile(".\data\champions\icons\" & x.Attributes("icon").Value & "_Square_0.png")
                Dim pRole As String = x.Attributes("primary").Value
                Dim sRole As String = x.Attributes("secondary").Value

                Console.WriteLine("Champion " & name & " [" & id & "] hinzugefügt")
                addChampion(id, name, banner, icon, pRole, sRole)
            End If
        Next
    End Sub


#End Region


End Class
