Imports RiotSharp.StaticDataEndpoint
Public Class Champion
    Implements IDisposable



#Region "Intern"

    Private _id As Integer = 0
    Private _displayName As String = ""
    Private _banner As Image = Nothing
    Private _icon As Image = Nothing
    Private _rolle1 As String = ""
    Private _rolle2 As String = ""
    Private _useApi As Boolean = False
    Private _chd As ChampionStatic = Nothing

#End Region


#Region "Konstruktor"

    Public Sub New()

    End Sub

    Public Sub New(chd As ChampionStatic)
        _chd = chd
        _useApi = True
    End Sub

#End Region

#Region "Eigenschaften"

    ''' <summary>
    ''' Gibt oder setzt die ID
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID As Integer
        Get
            If _useApi Then
                Return _chd.Id
            Else
                Return _id
            End If
        End Get
        Set(value As Integer)
            If Not _useApi Then
                _id = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt den Anzeige-Name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DISPLAYNAME As String
        Get
            If _useApi Then
                Return _chd.Name
            Else
                Return _displayName
            End If
        End Get
        Set(value As String)
            If Not _useApi Then
                _displayName = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt das Ladebilde des Champions
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BANNER As Image
        Get
            Return _banner
        End Get
        Set(value As Image)
            _banner = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt das Champion-Symbol
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ICON As Image
        Get
            Return _icon
        End Get
        Set(value As Image)
            _icon = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt die Primär-Rolle des Champions
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PRIMARY_ROLE As String
        Get
            If _useApi Then
                Try
                    Return _chd.Tags(0).ToString()
                Catch ex As Exception
                    Return _rolle1
                End Try
            Else
                Return _rolle1
            End If
        End Get
        Set(value As String)
            If Not _useApi Then
                _rolle1 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt die Sekundär-Rolle des Champions
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SECOND_ROLE As String
        Get
            If _useApi Then
                Try
                    Return _chd.Tags(1).ToString
                Catch ex As Exception
                    Return _rolle2
                End Try
            Else
                Return _rolle2
            End If
        End Get
        Set(value As String)
            If Not _useApi Then
                _rolle2 = value
            End If
        End Set
    End Property

#End Region

#Region "Abfrage-Methoden"

    ''' <summary>
    ''' Frägt ab ob ein Champion eine Rolle besitzt
    ''' </summary>
    ''' <param name="eRolle">Abfrage-Rolle</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function hasRole(ByVal eRolle As String) As Boolean
        Dim erg As Boolean = False
        If PRIMARY_ROLE.ToLower.Equals(eRolle.ToLower) Then
            erg = True
        End If

        If SECOND_ROLE.ToLower.Equals(eRolle.ToLower) Then
            erg = True
        End If

        Return erg
    End Function


    Public Function hasRole(ByVal rolle As TagStatic) As Boolean
        If _useApi Then
            Try
                Return _chd.Tags.Contains(rolle)
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Frägt ab ob der Champion der Champion mit dem übergebene Name ist
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isChampion(ByVal name As String) As Boolean
        If DISPLAYNAME.ToLower.StartsWith(name.ToLower) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Overrides Function ToString() As String
        Return DISPLAYNAME & " [" & ID & "]"
    End Function

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' So ermitteln Sie überflüssige Aufrufe

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _icon.Dispose()
                _banner.Dispose()
            End If

            _id = Nothing
            _displayName = Nothing
            _rolle1 = Nothing
            _rolle2 = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: Finalize() nur überschreiben, wenn Dispose(ByVal disposing As Boolean) oben über Code zum Freigeben von nicht verwalteten Ressourcen verfügt.
    Protected Overrides Sub Finalize()
        ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(ByVal disposing As Boolean) Bereinigungscode ein.
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ' Dieser Code wird von Visual Basic hinzugefügt, um das Dispose-Muster richtig zu implementieren.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(disposing As Boolean) Bereinigungscode ein.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
