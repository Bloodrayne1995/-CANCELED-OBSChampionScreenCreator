Public Class RegionPanel

    Private _regionID As Integer = 0
    Private _name As String = "N / V"
    Private _anzahlTeams As Integer = 0
    Private _logo As Image = Nothing

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub New(regionId As Integer, name As String, anzahlT As Integer)
        InitializeComponent()

        _regionID = regionId
        _name = name
        _anzahlTeams = anzahlT

        lblAnzahlTeams.Content = _anzahlTeams
        lblName.Content = _name

    End Sub



End Class
