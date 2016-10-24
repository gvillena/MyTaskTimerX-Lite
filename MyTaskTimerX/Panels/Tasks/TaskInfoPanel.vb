Public Class TaskInfoPanel

#Region " Fields "

    Private _TaskId As Integer = 0

#End Region

#Region " Properties "
    Public Property TaskId() As Integer
        Get
            Return _TaskId
        End Get
        Set(ByVal value As Integer)
            _TaskId = value
        End Set
    End Property

#End Region

#Region " Events "

    Public Event StartTask As EventHandler(Of TaskInfoEventArgs)
    Public Event TimerActivated As EventHandler

#End Region

#Region " Form Events "
    Private Sub TaskInfoPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateTaskInfo()
    End Sub
#End Region

#Region " Controls "

#Region " (Button) btnStartTask "
    Private Sub btnStartTask_Click(sender As Object, e As EventArgs) Handles btnStartTask.Click
        TimerManagerX.LoadTask(TaskId)
        TimerManagerX.DisplayForm()
        RaiseEvent TimerActivated(Me, EventArgs.Empty)
    End Sub
#End Region

#End Region

#Region " TaskInfo Methods "

    Public Sub UpdateTaskInfo()

        Dim MyTaskX As TaskX = TaskManagerX.GetTask(TaskId)
        If MyTaskX IsNot Nothing Then

            ' Setting Task Name
            lblTaskName.Text = MyTaskX.Name

            ' Setting Task Duration
            Dim strHours As String = MyTaskX.EstimatedTime.Hours.ToString("00")
            Dim strMinutes As String = MyTaskX.EstimatedTime.Minutes.ToString("00")
            lblRemainingTime.Text = String.Format("{0} horas {1} minutos", strHours, strMinutes)
        End If
    End Sub


#End Region


End Class
