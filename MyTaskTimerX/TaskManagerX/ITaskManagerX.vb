Public Interface ITaskManagerX

    Sub AddTask(Name As String, EstimatedTime As TimeSpan)

    Sub AddTask(MyTaskX As TaskX)

    Function DeleteTask(TaskId As Integer) As Boolean

    Function GetTask(TaskId As Integer) As TaskX

    Function GetAllTask() As TaskX()

    Function TaskCount() As Integer

End Interface
