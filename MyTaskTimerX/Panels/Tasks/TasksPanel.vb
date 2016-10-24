Imports System.ComponentModel
Imports MyTaskTimerX
Imports MyTaskTimerX.Panels.Tasks

Public Class TasksPanel

#Region " Fields "

    Private _SelectedTask As Integer = 0
    Private _EditMode As String = False
    Private _SelectedTaskName As String = String.Empty
    Private _CurrentPanelLayout As PanelLayout

#End Region

#Region " Events "

    Public Event TimerActivated As EventHandler

#End Region

#Region " Properties "

    Public Property SelectedTask() As Integer
        Get
            Return _SelectedTask
        End Get
        Set(ByVal value As Integer)
            _SelectedTask = value
        End Set
    End Property

    Public Property EditMode() As String
        Get
            Return _EditMode
        End Get
        Set(ByVal value As String)
            _EditMode = value
        End Set
    End Property

    Public Property SelectedTaskName() As String
        Get
            Return _SelectedTaskName
        End Get
        Set(ByVal value As String)
            _SelectedTaskName = value
        End Set
    End Property


    Private Property CurrentPanelLayout() As PanelLayout
        Get
            Return _CurrentPanelLayout
        End Get
        Set(ByVal value As PanelLayout)
            _CurrentPanelLayout = value
        End Set
    End Property

    Private ReadOnly Property IsReadyToSave() As Boolean
        Get
            ' TODO Implement Task Ready Validation
            Return True
        End Get
    End Property

#End Region

#Region " Panel Events "

    Private Sub TasksPanel_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Initialize Panels
        InitializePanels()

        ' If there are not pending tasks then show TasksCompletedPanel 
        ' otherwise show SummayTasksPanel
        If TaskManagerX.RemainingTasks = 0 Then
            SetPanelLayout(PanelLayout.Single)
            LoadTasksCompletedPanel()
        Else
            SetPanelLayout(PanelLayout.Double)
            LoadTaskListPanel()
            LoadSummaryPanel()
        End If
    End Sub


#End Region

#Region " Panels "

#Region " Panel Declaration "

    Friend WithEvents MyTaskListPanel As TaskListPanel
    Friend WithEvents MySummaryPanel As TasksSummaryPanel
    Friend WithEvents MyTasksCompletedPanel As TasksCompletedPanel
    Friend WithEvents MyAddTaskPanel As AddTaskPanel
    Friend WithEvents MyTaskInfoPanel As TaskInfoPanel

#End Region

#Region " Panel Initialization "

    Public Sub InitializePanels()

        ' Initialization
        MyTaskListPanel = New TaskListPanel
        MySummaryPanel = New TasksSummaryPanel
        MyTasksCompletedPanel = New TasksCompletedPanel
        MyAddTaskPanel = New AddTaskPanel
        MyTaskInfoPanel = New TaskInfoPanel

        ' TaskListPanel
        MyTaskListPanel.Name = "MyTaskListPanel"

        ' SummaryPanel
        MySummaryPanel.BackColor = Color.White
        MySummaryPanel.Dock = DockStyle.Fill
        MySummaryPanel.Font = New Font("BakerSignet BT", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        MySummaryPanel.ForeColor = Color.Black
        MySummaryPanel.Name = "MySummaryTaskPanel"
        MySummaryPanel.Size = New Size(364, 213)
        MySummaryPanel.TabIndex = 0

        ' MyTasksCompletedPanel 
        MyTasksCompletedPanel.BackColor = Color.White
        MyTasksCompletedPanel.Font = New Font("BakerSignet BT", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        MyTasksCompletedPanel.ForeColor = Color.Black
        MyTasksCompletedPanel.Location = New Point(0, 0)
        MyTasksCompletedPanel.Margin = New Padding(0, 0, 0, 0)
        MyTasksCompletedPanel.Name = "MyTasksCompletedPanel"
        MyTasksCompletedPanel.TabIndex = 0
        MyTasksCompletedPanel.Dock = DockStyle.Fill

    End Sub

#End Region

#Region " Panel Layout "

    Private Sub SetPanelLayout(ByVal panelLayout As PanelLayout)
        plMain.Controls.Clear()
        If panelLayout = PanelLayout.Double Then
            plMain.Controls.Add(plRightContainer)
            plMain.Controls.Add(plLeftContainer)
        End If
    End Sub




#End Region
#Region " Panel Load / Unload "

    Private Sub LoadTaskListPanel()
        If plLeftContainer.Contains(MyTaskListPanel) Then Exit Sub
        plLeftContainer.Controls.Add(MyTaskListPanel)
    End Sub

    Private Sub LoadSummaryPanel()
        plRightContainer.Controls.Clear()
        plRightContainer.Controls.Add(MySummaryPanel)
    End Sub

    Private Sub LoadAddTaskPanel()
        plMain.Controls.Clear()
        plMain.Controls.Add(MyAddTaskPanel)
    End Sub

    Private Sub LoadTasksCompletedPanel()
        plMain.Controls.Clear()
        plMain.Controls.Add(MyTasksCompletedPanel)

    End Sub


    Private Sub LoadTaskInfoPanel(ByVal SelectedTaskId As Integer)
        plRightContainer.Controls.Clear()
        MyTaskInfoPanel.TaskId = SelectedTaskId
        MyTaskInfoPanel.UpdateTaskInfo()
        plRightContainer.Controls.Add(MyTaskInfoPanel)
    End Sub

#End Region


#End Region

#Region " TaskCompletedPanel "

#Region " Event Handlers "

    Private Sub MyTasksCompletedPanel_AddTask(sender As Object, e As EventArgs) Handles MyTasksCompletedPanel.AddTask

        ' Load Add Task Panel
        LoadAddTaskPanel()

    End Sub

#End Region

#End Region

#Region " TaskListPanel "

#Region " Event Handlers "

    Private Sub MyTaskListPanel_AddTask(sender As Object, e As EventArgs) Handles MyTaskListPanel.AddTask
        ' Load AddTask Panel
        LoadAddTaskPanel()
    End Sub

    Private Sub MyTaskListPanel_TaskSelected(sender As Object, e As TaskInfoEventArgs) Handles MyTaskListPanel.TaskSelected
        LoadTaskInfoPanel(e.TaskId)
    End Sub

#End Region

#Region " TaskInfoPanel "

#Region " Event Handlers "
    Private Sub MyTaskInfoPanel_TimerActivated(sender As Object, e As EventArgs) Handles MyTaskInfoPanel.TimerActivated
        RaiseEvent TimerActivated(Me, EventArgs.Empty)
    End Sub

#End Region

#End Region

#End Region

#Region " AddTasksPanel "

    Private Sub MyAddTaskPanel_AddTaskConfirm(sender As Object, e As AddTaskEventArgs) Handles MyAddTaskPanel.AddTaskConfirm

        ' Raise AddTask event
        RaiseEvent AddTask(Me, e)

        ' Switch to double layout panel 
        SetPanelLayout(PanelLayout.Double)

        ' Load TaskList and TaskSummary Panel
        LoadTaskListPanel()
        LoadSummaryPanel()

        ' Updating TaskList 
        MyTaskListPanel.UpdateTaskList()


    End Sub

    Private Sub MyAddTaskPanel_AddTaskCancel(sender As Object, e As EventArgs) Handles MyAddTaskPanel.AddTaskCancel

        ' Switch to double layout panel 
        SetPanelLayout(PanelLayout.Double)

        ' Load TaskList and TaskSummary Panel
        LoadTaskListPanel()
        LoadSummaryPanel()

    End Sub

#End Region

#Region " Left Panel (TaskList) "


#Region " TaskList Methods "



    'Private Sub DisplayTaskDetail(TaskId As Integer)
    '    Dim TaskX As TaskX = TaskManagerX.GetTask(TaskId)
    '    txtTaskName.Text = TaskX.Name
    '    nudHours.Value = TaskX.EstimatedTime.Hours
    '    nudMinutes.Value = TaskX.EstimatedTime.Minutes
    'End Sub


#End Region



#End Region

    '#Region " TaskX UI Panel "


    '#Region " (Button) btnAddTask "

    '    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

    '        ' Clearting Selection 
    '        dgvTaskList.ClearSelection()
    '        SelectedTask = 0

    '        ' Setting Up Controls
    '        EditMode = True
    '        IsTaskNameEmpty = True
    '        txtTaskName.Text = "Nombre de tarea..."
    '        txtTaskName.ForeColor = Color.LightGray
    '        txtTaskName.Select()
    '        txtTaskName.SelectionLength = 0
    '        txtTaskName.SelectionStart = 0
    '        nudHours.Value = 0
    '        nudMinutes.Value = 0

    '    End Sub

    '#End Region

    '#Region " (Button) btnSaveTask "

    '    Private Sub btnSaveTask_Click(sender As Object, e As EventArgs) Handles btnSaveTask.Click

    '        If Not IsReadyToSave Then Exit Sub
    '        OnAddTask()

    '        ' Select Added Task
    '        Dim LastRowIndex As Integer = dgvTaskList.Rows.GetLastRow(DataGridViewElementStates.None)
    '        Dim TaskId As Integer = dgvTaskList.Item("TaskId", LastRowIndex).Value
    '        dgvTaskList.ClearSelection()
    '        dgvTaskList.Rows.Item(LastRowIndex).Selected = True
    '        DisplayTaskDetail(TaskId)
    '        MsgBox("Tarea Agregada Satisfactoriamente")

    '        ' Select Added Task
    '        txtTaskName.ForeColor = Color.Black

    '    End Sub

    '#End Region

    '#Region " (Button) btnEditTask "
    '    Private Sub btnEditTask_Click(sender As Object, e As EventArgs) Handles btnEditTask.Click

    '    End Sub

    '#End Region

    '#End Region

    '#Region " Add New Task "

    '    Private Sub InitAddMode()



    '    End Sub

    '#End Region

#Region " Events "

#Region " Events Declaration "

    Public Event LoadTask As EventHandler(Of LoadIdEventArgs)
    Public Event AddTask As EventHandler(Of AddTaskEventArgs)
    Public Event UpdateTask As EventHandler(Of AddTaskEventArgs)

    Public Event LoadHomePanel As EventHandler

#End Region

#Region " Events Raising "

    'Protected Overridable Sub OnAddTask()

    '    Dim e As AddTaskEventArgs = New AddTaskEventArgs
    '    ' TODO Get Next TaskId
    '    e.TaskId = 0
    '    e.TaskName = txtTaskName.Text
    '    e.TaskEstimatedTime = New TimeSpan(nudHours.Value, nudHours.Value, 0)
    '    RaiseEvent AddTask(Me, e)
    '    OnUpdateTaskList()

    'End Sub



    Protected Overridable Sub OnTimerStart()
        Dim e As CancelEventArgs = New CancelEventArgs
        'RaiseEvent TimerStart(Me, e)
        'If Not e.Cancel Then
        '    StartTimer()
        'End If
    End Sub

    Private Sub dgvTaskList_RowHeaderCellChanged(sender As Object, e As DataGridViewRowEventArgs)

    End Sub

    'Private Sub txtTaskName_GotFocus(sender As Object, e As EventArgs)

    '    txtTaskName.SelectionStart = txtTaskName.TextLength + 1
    'End Sub

    Private Sub FlowLayoutPanel1_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub MyTaskInfoPanel_StartTask(sender As Object, e As TaskInfoEventArgs) Handles MyTaskInfoPanel.StartTask

    End Sub



#End Region

#End Region

End Class

#Region " EventsArgs Class Definition "


Public Class LoadIdEventArgs
    Inherits EventArgs

    Public Property TaskId As Integer = 0

End Class

Enum PanelLayout
    [Single]
    [Double]
End Enum


#End Region
