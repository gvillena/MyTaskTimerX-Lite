Public Class TaskListPanel


#Region " Events "

    Public Event TaskSelected As EventHandler(Of TaskInfoEventArgs)
    Public Event AddTask As EventHandler

#End Region

#Region " TasksList Management "

    Public Sub UpdateTaskList()
        Dim TaskArray As TaskX() = Nothing
        TaskArray = TaskManagerX.GetAllTask()
        UpdateTaskList(TaskArray)
    End Sub

    Public Sub UpdateTaskList(TaskArray As TaskX())

        ' Checking if TaskArray is not Nothing
        If TaskArray Is Nothing Then Exit Sub

        ' If there are rows in dgvTaskList row collection then clear the collection
        If dgvTaskList.Rows.Count > 0 Then dgvTaskList.Rows.Clear()

        ' If TaskArray collection is empty then exit sub 
        If TaskArray.Count = 0 Then Exit Sub

        ' Add TaskArray elements on dgvTaskList row collection 
        For Each task As TaskX In TaskArray
            dgvTaskList.Rows.Add(New Object() {task.Id, task.Name, "ToDo"})
        Next

        ' Clear selection
        dgvTaskList.ClearSelection()

    End Sub
#End Region

#Region " Controls "

#Region " (DataGridView) dgvTaskList "

    Private Sub dgvTaskList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaskList.CellClick
        Dim TaskId As Integer = CInt(dgvTaskList.Item("TaskId", e.RowIndex).Value)
        Dim ea As TaskInfoEventArgs = New TaskInfoEventArgs
        ea.TaskId = TaskId
        RaiseEvent TaskSelected(Me, ea)
    End Sub

#End Region

#Region " (Button) btnAddTask "
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        RaiseEvent AddTask(Me, EventArgs.Empty)
    End Sub


#End Region



#End Region











End Class


#Region " TaskList EventsArgs Definition "

Public Class TaskInfoEventArgs
    Inherits EventArgs

    Public Property TaskId As Integer = 0

End Class


#End Region

