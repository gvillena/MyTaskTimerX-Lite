Public Class TasksCompletedPanel

#Region " Event Declaration "

    Public Event AddTask As EventHandler


#End Region

    Private Sub btnAddTasks_Click(sender As Object, e As EventArgs) Handles btnAddTasks.Click
        OnAddTask()
    End Sub

    Private Sub OnAddTask()
        RaiseEvent AddTask(Me, EventArgs.Empty)
    End Sub
End Class
