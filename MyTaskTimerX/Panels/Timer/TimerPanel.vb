Public Class TimerPanel

#Region " Fields "
    Private TimerTS As TimeSpan = New TimeSpan(0)
#End Region

#Region " Properties "

#End Region

#Region " Constructor and Initialization "

    Private Sub TimerPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        ' Init MyTimer
        MyTimer.Enabled = False
        MyTimer.Interval = 1000
    End Sub

#End Region

#Region " Functions "

#End Region

#Region " MyTimer "
    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        ' Verify if time for task has not expired else raise event
        If TimerTS.Ticks > 0 Then
            TimerTS = TimerTS.Subtract(New TimeSpan((10000000)))
            UpdateTimerText()
        Else
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

#End Region

#End Region

End Class
