Public Class TimerManagerX

#Region " Fields "

    Private _Status As TimerStatus = TimerStatus.Empty
    Private _LoadedTaskId As Integer = -1
    Private _TimerForm As TimerForm = Nothing
#End Region

#Region " Creation "

    Private Shared _instance As TimerManagerX = Nothing

    Private Sub New()
        _TimerForm = New TimerForm()
    End Sub

    Public Shared ReadOnly Property Instance() As TimerManagerX
        Get
            If _instance Is Nothing Then
                _instance = New TimerManagerX
            End If
            Return _instance
        End Get
    End Property

#End Region

#Region " Properties "

    Public Property LoadedTaskId() As Integer
        Get
            Return _LoadedTaskId
        End Get
        Set(ByVal value As Integer)
            _LoadedTaskId = value
        End Set
    End Property

    Public Shared ReadOnly Property LoadedTask() As TaskX
        Get
            If Instance.Status = TimerStatus.Empty Then Return Nothing
            Return TaskManagerX.GetTask(Instance.LoadedTaskId)
        End Get
    End Property


    Public Property Status() As TimerStatus
        Get
            Return _Status
        End Get
        Set(ByVal value As TimerStatus)
            _Status = value
        End Set
    End Property

#End Region

#Region " Functions "

    Public Shared Function GetRunningTask() As TaskX
        If Not Instance.Status = TimerStatus.Running Then Return Nothing
        Return TaskManagerX.GetTask(Instance.LoadedTaskId)
    End Function

    Public Shared Function LoadTask(TaskId As Integer) As Boolean
        If Not Instance.Status = TimerStatus.Empty Then Return False
        Instance.LoadedTaskId = TaskId
        Instance.Status = TimerStatus.Idle
        Return True
    End Function

    Public Shared Function DisplayForm() As Boolean
        If Not Instance.Status = TimerStatus.Idle Then Return False
        Instance._TimerForm.Show()
        Return True
    End Function


    Public Shared Function StartTask() As Boolean
        If Not Instance.Status = TimerStatus.Idle Then Return False
        Instance.Status = TimerStatus.Running
        Return True
    End Function

    Public Shared Function ResumeTask() As Boolean
        If Not Instance.Status = TimerStatus.Paused Then Return False
        Instance.Status = TimerStatus.Running
        Return True
    End Function

    Public Shared Function PauseTask() As Boolean
        If Not Instance.Status = TimerStatus.Running Then Return False
        Instance.Status = TimerStatus.Paused
        Return True
    End Function

    Public Shared Function RestartTask(TaskId As Integer) As Boolean
        If Not Instance.Status = TimerStatus.Running Then Return False
        ' TODO Implement RestartTask
        'Instance.LoadedTaskId = TaskId
        'Instance.Status = TimerStatus.Idle
        Return True
    End Function

    Public Shared Function UnloadTask() As Boolean
        If Not Instance.Status = TimerStatus.Idle Then Return False
        Instance.Status = TimerStatus.Empty
        Instance.LoadedTaskId = -1
        Return True
    End Function

#End Region
End Class

Public Enum TimerStatus
    Empty
    Idle
    Paused
    Running
End Enum

