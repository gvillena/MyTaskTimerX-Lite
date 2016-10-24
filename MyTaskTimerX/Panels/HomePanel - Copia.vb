Public Class HomePanel

#Region " Fields "

#End Region

#Region " Properties "

#End Region

#Region " Constructor "

#End Region

#Region " Functions "

#End Region

#Region " Subs "

#End Region

#Region " Events "
    Public Event AddTask As EventHandler
    Public Event MyTasks As EventHandler
    Public Event QuickTask As EventHandler
#End Region

#Region " Form Events "
    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click
        RaiseEvent AddTask(Me, EventArgs.Empty)
    End Sub

    Private Sub btnMyTasks_Click(sender As Object, e As EventArgs) Handles btnMyTasks.Click
        RaiseEvent MyTasks(Me, EventArgs.Empty)
    End Sub

    Private Sub btnQuickTask_Click(sender As Object, e As EventArgs) Handles btnQuickTask.Click
        RaiseEvent QuickTask(Me, EventArgs.Empty)
    End Sub
#End Region

End Class
