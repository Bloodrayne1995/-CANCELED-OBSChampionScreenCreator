Imports System.IO
Public Class Champion
    Implements IDisposable


#Region "Internal"

    Private _name As String = "ChampionX"
    Private _squareStream As FileStream = Nothing
    Private _bannerStream As FileStream = Nothing
    Private _bannerFile As String = ""
    Private _squareFile As String = ""
    Private _displayName As String = "dChampionX"

#End Region

#Region "Konstruktoren"

    Public Sub New(name As String, banner As String, square As String)
        _name = name
        _bannerFile = banner
        _squareFile = square
        _displayName = name
    End Sub

#End Region


#Region "Properties"

    Public ReadOnly Property NAME As String
        Get
            Return _name
        End Get
    End Property


    Public ReadOnly Property DISPLAYNAME As String
        Get
            Return _displayName
        End Get
    End Property


    Public ReadOnly Property SQUARE As BitmapImage
        Get
            Dim x As New BitmapImage
            openStream(True)

            If Not IsNothing(_squareStream) Then
                With _squareStream
                    x.BeginInit()
                    x.CacheOption = BitmapCacheOption.OnLoad
                    x.StreamSource = _squareStream
                    x.EndInit()
                End With
            End If
            _squareStream.Close()
            Return x
        End Get
    End Property


    Public ReadOnly Property BANNER As BitmapImage
        Get
            Dim x As New BitmapImage
            openStream(False)
            If Not IsNothing(_bannerStream) Then
                With _bannerStream
                    x.BeginInit()
                    x.CacheOption = BitmapCacheOption.OnLoad
                    x.StreamSource = _bannerStream
                    x.EndInit()
                End With
            End If
            _bannerStream.Close()
            Return x
        End Get
    End Property

#End Region


#Region "Utils"

    Private Sub openStream(square As Boolean)
        If square Then
            _squareStream = New FileStream(".\data\champions\squares\" & _squareFile, FileMode.Open)
        Else
            _bannerStream = New FileStream(".\data\champions\banner\" & _bannerFile, FileMode.Open)
        End If
    End Sub


#End Region


#Region "IDisposable Support"
    Private disposedValue As Boolean ' So ermitteln Sie überflüssige Aufrufe

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _squareStream.Close()
                _squareStream.Dispose()
                _bannerStream.Close()
                _bannerStream.Dispose()
            End If

            ' TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalize() unten überschreiben.
            ' TODO: Große Felder auf NULL festlegen.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: Finalize() nur überschreiben, wenn Dispose(ByVal disposing As Boolean) oben über Code zum Freigeben von nicht verwalteten Ressourcen verfügt.
    'Protected Overrides Sub Finalize()
    '    ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(ByVal disposing As Boolean) Bereinigungscode ein.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Dieser Code wird von Visual Basic hinzugefügt, um das Dispose-Muster richtig zu implementieren.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(disposing As Boolean) Bereinigungscode ein.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
