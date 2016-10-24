Public Class TimerForm

#Region " Fields "

    Private _MyTask As TaskX = Nothing
    Private TimerTS As TimeSpan = New TimeSpan(0)

#End Region

#Region " Properties "


    Public ReadOnly Property MyTask() As TaskX
        Get
            Return TimerManagerX.LoadedTask
        End Get
    End Property

#End Region

#Region " Form Events "

    Private Sub TimerForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Init MyTimer
        MyTimer.Enabled = False
        MyTimer.Interval = 1000

        ' Set Task Title
        lblTitle.Text = MyTask.Name

        ' Set Task Estimated Time
        TimerTS = MyTask.EstimatedTime
        UpdateTimerText()

    End Sub

#End Region

#Region " MyTimer "

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        ' Verify if time for task has not expired else raise event
        If TimerTS.Ticks > 0 Then
            TimerTS = TimerTS.Subtract(New TimeSpan((10000000)))
            UpdateTimerText()
        Else
            MsgBox("Tiempo Alcanzado")
            btnStartTask.ImageIndex = 0
            OnTaskTimeExpired()
        End If
    End Sub

    Private Sub UpdateTimerText()
        lblHours.Text = TimerTS.Hours.ToString("00")
        lblMinutes.Text = TimerTS.Minutes.ToString("00")
        lblSeconds.Text = TimerTS.Seconds.ToString("00")
    End Sub

    Private Sub ResetTimerText()
        lblHours.Text = "00"
        lblMinutes.Text = "00"
        lblSeconds.Text = "00"
    End Sub

#End Region

#Region " btnStarTask "
    Private Sub btnStartTask_Click(sender As Object, e As EventArgs) Handles btnStartTask.Click
        MyTimer.Start()
        btnStartTask.ImageIndex = 1
    End Sub

#End Region

#Region " Subs "

#End Region

#Region " Events "

#Region " Events Declaration "

    Public Event TaskTimeExpired As EventHandler

#End Region

#Region " Events Raising "

    Protected Overridable Sub OnTaskTimeExpired()
        RaiseEvent TaskTimeExpired(Me, EventArgs.Empty)
    End Sub

    Private Sub TimerForm_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Debug.WriteLine("Hover")
    End Sub



#End Region

#End Region

End Class

