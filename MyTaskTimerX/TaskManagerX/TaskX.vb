Imports System.Text

Public Class TaskX

#Region " Fields "

    Private _Id As Integer = 0
    Private _Name As String = String.Empty
    Private _EstimatedTime As TimeSpan
    Private _StartTime As DateTime = Nothing
    Private _EndTime As DateTime = Nothing

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
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Public Property EstimatedTime() As TimeSpan
        Get
            Return _EstimatedTime
        End Get
        Set(ByVal value As TimeSpan)
            _EstimatedTime = value
        End Set
    End Property

    Public Property StartTime() As DateTime
        Get
            Return _StartTime
        End Get
        Set(ByVal value As DateTime)
            _StartTime = value
        End Set
    End Property

    Public Property EndTime() As DateTime
        Get
            Return _EndTime
        End Get
        Set(ByVal value As DateTime)
            _EndTime = value
        End Set
    End Property


#End Region

#Region " Functions "

    Friend Function ToArray() As Object()

        Return New Object() {Name, GetEstimatedTimeString(), StartTime.ToString("hh:mm:ss"), EndTime.ToString("hh:mm:ss")}

    End Function

    Private Function GetEstimatedTimeString()
        Dim Horas As String = IIf((EstimatedTime.Hours > 0), EstimatedTime.Hours.ToString("00"), String.Empty)
        Dim Minutos As String = IIf((EstimatedTime.Minutes > 0), EstimatedTime.Minutes.ToString("00"), String.Empty)
        Dim Segundos As String = IIf((EstimatedTime.Seconds > 0), EstimatedTime.Seconds.ToString("00"), String.Empty)

        Dim builder As StringBuilder = New StringBuilder
        If Not String.IsNullOrEmpty(Horas) Then builder.Append(String.Format("{0} Horas ", Horas))
        If Not String.IsNullOrEmpty(Minutos) Then builder.Append(String.Format("{0} Minutos ", Minutos))
        If Not String.IsNullOrEmpty(Segundos) Then builder.Append(String.Format("{0} Segundos", Segundos))
        Return builder.ToString()
    End Function

#End Region


End Class
