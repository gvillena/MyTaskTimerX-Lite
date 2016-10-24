Imports System.ComponentModel

Public Interface ITaskTimerX
    Event CreateNewTask As EventHandler
    Event CreateQuickTask As EventHandler
    Event TimerStart As CancelEventHandler
    Event TimerPause As EventHandler
    Event TimerRestart As EventHandler
    Event ShowTaskList As EventHandler
    Event HideTaskList As EventHandler
    Event TaskTimeExpired As EventHandler(Of TaskTimerExpired)
    Event Tick As EventHandler


    Sub InitilizeUserControls()



End Interface
