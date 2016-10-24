Public Class TaskTimerExpired
    Inherits EventArgs

    Public Property AddMoreTime As Boolean = False
    Public Property AdditionalHours As Integer = 0
    Public Property AdditionalMinutes As Integer = 0
    Public Property AdditionalSeconds As Integer = 0

End Class