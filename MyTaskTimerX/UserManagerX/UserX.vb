Public Class UserX

#Region " Fields "

    Private _Name As String = String.Empty
    Private _LastName As String = String.Empty
    Private _Id As Integer = 0

#End Region

#Region " Properties "


    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            If String.IsNullOrWhiteSpace(_Name) Then
                Return "[Nombre]"
            Else
                Return _Name
            End If
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            If String.IsNullOrWhiteSpace(_LastName) Then
                Return "[Apellidos]"
            Else
                Return _LastName
            End If
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property


    Public ReadOnly Property FullName() As String
        Get
            Return String.Format("{0} {1}", Name, LastName)
        End Get
    End Property

#End Region





End Class
