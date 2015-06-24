Public Class Spieler

#Region "Intern"

    Private _playername As String = "<playername>"
    Private _champion As Champion = Nothing
    Private _rolle As String = "<rolle>"

    Private _swap As Boolean = False
    Public Event swapStart(x As Champion, sender As String)
    Public Event swapCancel()

#End Region
    
#Region "Eigenschaften"

    ''' <summary>
    ''' Gibt oder setzt den Spieler-Name (im Team)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PLAYERNAME As String
        Get
            Return _playername
        End Get
        Set(value As String)
            _playername = value
            updateSpieler()
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt den Champion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CHAMPION As Champion
        Get
            Return _champion
        End Get
        Set(value As Champion)
            _champion = value
            updateSpieler()
        End Set
    End Property

    ''' <summary>
    ''' Gibt oder setzt die Rolle
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ROLLE As String
        Get
            Return _rolle
        End Get
        Set(value As String)
            _rolle = value
            updateSpieler()
        End Set
    End Property

#End Region

#Region "Werkzeuge"

    ''' <summary>
    ''' Updatet die Ansicht, sobald eine Eigenschaft geändert wurde
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub updateSpieler()
        If Not IsNothing(_champion) Then
            lblChampion.Text = _champion.DISPLAYNAME
            pnlChampionImage.BackgroundImage = _champion.ICON
        Else
            lblChampion.Text = "<champion>"
            pnlChampionImage.BackgroundImage = Nothing
        End If

        lblPlayername.Text = _playername
        lblRolle.Text = _rolle
    End Sub


    Public Sub showPlayerName()
        lblPlayername.Visible = True
    End Sub

    Public Sub hidePlayerName()
        lblPlayername.Visible = False
    End Sub

    Public Sub resetChampion()
        CHAMPION = Nothing
        _swap = False
        cmdSwap.BackColor = Color.Transparent
        updateSpieler()
    End Sub

#End Region


#Region "EventHandler"

    Private Sub dragHandler(sender As Object, e As DragEventArgs) Handles pnlChampionImage.DragDrop
        Try
            Dim x As DataObject = DirectCast(e.Data, DataObject)
            CHAMPION = DirectCast(x.GetData(GetType(Champion)), Champion)
            updateSpieler()
            Form1.onDragCompletedSub()
            pnlChampionImage.BackColor = Me.BackColor
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dragHandler2(sender As Object, e As DragEventArgs) Handles pnlChampionImage.DragEnter
        If (e.AllowedEffect = DragDropEffects.Copy) Then
            pnlChampionImage.BackColor = Color.Yellow
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub dragHandler3(sender As Object, e As EventArgs) Handles pnlChampionImage.DragLeave
        'Debug.WriteLine("DragLeave")
        pnlChampionImage.BackColor = Me.BackColor
    End Sub


    Private Sub cmdSwap_Click(sender As Object, e As EventArgs) Handles cmdSwap.Click
        If Not IsNothing(_champion) Then
            If _swap Then
                RaiseEvent swapCancel()
                cmdSwap.BackColor = Color.Transparent
                _swap = False
            Else
                RaiseEvent swapStart(_champion, Me.Name)
                _swap = True
                cmdSwap.BackColor = Color.LightYellow
            End If
        End If
    End Sub

    Public Sub swapCompleted()
        _swap = False
        cmdSwap.BackColor = Color.Transparent
    End Sub
    


#End Region

    

End Class
