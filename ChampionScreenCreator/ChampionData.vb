Public Class ChampionData

    Private _name As String = "Undefined"
    Private _square As Image = Nothing
    Private _banner As Image = Nothing

    Public Property Name As String
        Set(value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property

    Public Property Square As Image
        Set(value As Image)
            _square = value
        End Set
        Get
            Return _square
        End Get
    End Property

    Public Property Banner As Image
        Set(value As Image)
            _banner = value
        End Set
        Get
            Return _banner
        End Get
    End Property



End Class
