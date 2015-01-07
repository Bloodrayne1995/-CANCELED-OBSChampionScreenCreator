Public Class Player

    Private _rolle As String
    Private _banner As Point
    Private _square As Point


    Public Property ROLLE As String
        Get
            Return _rolle
        End Get
        Set(value As String)
            _rolle = value
        End Set
    End Property

    Public Property BANNER As Point
        Get
            Return _banner
        End Get
        Set(value As Point)
            _banner = value
        End Set
    End Property


    Public Property SQUARE As Point
        Get
            Return _square
        End Get
        Set(value As Point)
            _square = value
        End Set
    End Property

End Class
