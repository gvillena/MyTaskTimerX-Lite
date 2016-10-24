Public Class TaskManagerX

#Region " Fields "

    Private _TaskHashTable As Hashtable = Nothing
    Private NextId As Integer = 1
#End Region


#Region " Creation "

    Private Shared _instance As TaskManagerX = Nothing

    Private Sub New()
        _TaskHashTable = New Hashtable()
    End Sub

    Public Shared ReadOnly Property Instance() As TaskManagerX
        Get
            If _instance Is Nothing Then
                _instance = New TaskManagerX
            End If
            Return _instance
        End Get
    End Property

#End Region


#Region " Sub "

    Public Shared Sub AddTask(Nombre As String, DuracionEstimada As TimeSpan)
        Dim newTask As New TaskX
        With newTask
            .Id = Instance.NextId
            .Name = Nombre
            .EstimatedTime = DuracionEstimada
        End With
        AddTask(newTask)
    End Sub

    Public Shared Sub AddTask(Task As TaskX)
        Task.Id = Instance.NextId
        Instance._TaskHashTable.Add(Task.Id, Task)
        Instance.UpdateKeys()
        Instance.NextId += 1
    End Sub

    Public Shared Function DeleteTask(TaskId As Integer) As Boolean
        If Not Instance._TaskHashTable.ContainsKey(TaskId) Then Return False
        Instance._TaskHashTable.Remove(TaskId)
        Instance.UpdateKeys()
        Return True
    End Function

    Public Shared Function GetTask(TaskId As Integer) As TaskX
        If Not Instance._TaskHashTable.ContainsKey(TaskId) Then Return Nothing
        Return Instance._TaskHashTable.Item(TaskId)
    End Function

    Public Shared Function TaskCount() As Integer
        Return Instance._TaskHashTable.Count
    End Function

    Public Shared Function RemainingTasks() As Integer
        Return Instance._TaskHashTable.Count
    End Function

    Public Shared Function GetAllTask() As TaskX()
        If Instance._TaskHashTable.Count = 0 Then Return Nothing
        Dim al As New ArrayList(Instance._TaskHashTable.Values)
        Return CType(al.ToArray(GetType(TaskX)), TaskX())
    End Function

    Private Sub UpdateKeys()
        If _TaskHashTable.Count = 0 Then Exit Sub
        Dim newHT As New Hashtable()
        Dim i As Integer = 1
        For Each task As TaskX In _TaskHashTable.Values
            task.Id = i
            newHT.Add(task.Id, task)
            i += 1
        Next
        _TaskHashTable = newHT
    End Sub




#End Region

End Class
