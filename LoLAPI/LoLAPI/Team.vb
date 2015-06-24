Namespace LoLObjectModel
    Namespace Team

        Public Class TeamDto

        End Class

        ''' <summary>
        ''' This object contains team member information.
        ''' </summary>
        ''' <remarks></remarks>
        Public Class TeamMemberInfoDto

            Private _inviteDate As Long
            Private _joinDate As Long
            Private _playerID As Long
            Private _status As String


            ''' <summary>
            ''' Date that team member was invited to team specified as epoch milliseconds.
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property InviteDate As Long
                Get
                    Return _inviteDate
                End Get
            End Property

            ''' <summary>
            ''' Date that team member joined team specified as epoch milliseconds.
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property JoinDate As Long
                Get
                    Return _joinDate
                End Get
            End Property

            ''' <summary>
            ''' No Documentation given. 
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property PlayerID As Long
                Get
                    Return _playerID
                End Get
            End Property

            ''' <summary>
            ''' No Documentation given.
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property Status As Long
                Get
                    Return _status
                End Get
            End Property

            ''' <summary>
            ''' TODO: Create New Object
            ''' </summary>
            ''' <param name="data"></param>
            ''' <remarks></remarks>
            Public Sub create(data As Object)

            End Sub

        End Class

        ''' <summary>
        ''' This object contains team statistics detail information.
        ''' </summary>
        ''' <remarks></remarks>
        Public Class TeamStatDetailDto

            Private _averageGamesPlayed As Integer
            Private _losses As Integer
            Private _teamStatType As String
            Private _wins As Integer

            Public ReadOnly Property AverageGamesPlayed As Integer
                Get
                    Return _averageGamesPlayed
                End Get
            End Property


            Public ReadOnly Property Losses As Integer
                Get
                    Return _losses
                End Get
            End Property


        End Class

    End Namespace
End Namespace