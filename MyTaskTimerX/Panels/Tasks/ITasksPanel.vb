
Public Interface ITasksPanel

    Event HomeLoadTask As EventHandler(Of LoadIdEventArgs)
    Event HomeAddTask As EventHandler(Of AddTaskEventArgs)
    Event HomeUpdateTask As EventHandler(Of AddTaskEventArgs)

    Sub LoadTaskPanel()

End Interface
