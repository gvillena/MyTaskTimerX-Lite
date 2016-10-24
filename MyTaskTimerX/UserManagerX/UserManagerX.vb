Public Class UserManagerX

#Region " Fields "

    Private _CurrentUser As UserX

#End Region

#Region " Properties "

    Public Shared ReadOnly Property CurrentUser() As UserX
        Get
            Return Instance._CurrentUser
        End Get
    End Property

#End Region

#Region " Methods "

    Public Shared Sub SetCurrentUser(ByVal CurrentUser As UserX)
        Instance._CurrentUser = CurrentUser
    End Sub

#End Region

#Region " Creation "

    Private Shared _instance As UserManagerX = Nothing

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As UserManagerX
        Get
            If _instance Is Nothing Then
                _instance = New UserManagerX
            End If
            Return _instance
        End Get
    End Property

#End Region

End Class
