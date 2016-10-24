Imports System.ComponentModel
Imports MyTaskTimerX

Public Class MainForm
    Implements ITaskTimerX, ITaskManagerX, IHomePanel, ITasksPanel

#Region " Fields "
    Private CurrentPanel As TaskTimerXPanel = TaskTimerXPanel.None
#End Region

#Region " Properties "

#End Region

#Region " Form Events "

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Setting Up User Information
        Dim MyUser As UserX = New UserX()
        With MyUser
            .Id = 1
            .Name = "Giancarlo"
            .LastName = "Villena"
        End With
        UserManagerX.SetCurrentUser(MyUser)

        ' InitializePanels
        Initialize()

        ' LoadHomePanel
        LoadPanel(TaskTimerXPanel.Home)
    End Sub

#End Region

#Region " TaskTimerX Panels "

#Region " Panel Declaration "
    Friend WithEvents MyHomePanel As HomePanel
    Friend WithEvents MyTasksPanel As TasksPanel
    Friend WithEvents MyTimerPanel As TimerPanel

#End Region

#Region " Panel Initialization "

    Public Sub Initialize()

        ' Initialization
        MyHomePanel = New HomePanel()
        MyTasksPanel = New TasksPanel()
        MyTimerPanel = New TimerPanel()

        ' HomePanel
        MyHomePanel.BackColor = System.Drawing.Color.White
        MyHomePanel.Dock = DockStyle.Fill
        MyHomePanel.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyHomePanel.ForeColor = System.Drawing.Color.Black
        MyHomePanel.Location = New System.Drawing.Point(0, 0)
        MyHomePanel.Name = "MyHomePanel"


        ' MyTasksPanel
        MyTasksPanel.BackColor = System.Drawing.Color.White
        MyTasksPanel.Dock = DockStyle.Fill
        MyTasksPanel.Font = New System.Drawing.Font("BakerSignet BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyTasksPanel.ForeColor = System.Drawing.Color.Black
        MyTasksPanel.Location = New System.Drawing.Point(0, 0)
        MyTasksPanel.Name = "MyTasksPanel"

        ' TODO Faltan Declarar otros paneles 

    End Sub

#End Region

#Region " Panel Load and Unload "

    Private Sub LoadPanel(PanelToLoad As TaskTimerXPanel) Implements ITaskTimerX.LoadPanel

        ' Clear Current Panel
        plMainPanel.Controls.Clear()

        ' Adding and Load Panel to Container
        Select Case PanelToLoad
            Case TaskTimerXPanel.Home
                LoadHomePanel()
            Case TaskTimerXPanel.Tasks
                LoadTaskPanel()
        End Select

    End Sub

#End Region

#Region " Panel TimerPanel - Event Handler"

    Private Sub MyTimerPanel_TaskTimeExpired(sender As Object, e As EventArgs) Handles MyTimerPanel.TaskTimeExpired

    End Sub

#End Region


#End Region

#Region " MyHomePanel "

#Region " Load MyHomePanel "

    Public Sub LoadHomePanel() Implements IHomePanel.LoadHomePanel
        plMainPanel.Controls.Clear()
        plMainPanel.Controls.Add(MyHomePanel)
        lblTitle.Text = "PAGINA PRINCIPAL"
    End Sub

#End Region

#Region " Event Handlers "

    Private Sub MyHomePanel_MyTasks(sender As Object, e As EventArgs) Handles MyHomePanel.MyTasks
        LoadPanel(TaskTimerXPanel.Tasks)
    End Sub

#End Region

#End Region


#Region " MyTasksPanel "

#Region " EventHandlers "

    Private Sub MyTasksPanel_TimerActivated(sender As Object, e As EventArgs) Handles MyTasksPanel.TimerActivated
        WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region " Load MyTasksPanel "

    Private Sub LoadTaskPanel() Implements ITasksPanel.LoadTaskPanel
        plMainPanel.Controls.Clear()
        plMainPanel.Controls.Add(MyTasksPanel)
        lblTitle.Text = "MIS TAREAS"
    End Sub


#End Region


#Region " Event Handlers "
    Private Sub MyTasksPanel_AddTask(sender As Object, e As AddTaskEventArgs) Handles MyTasksPanel.AddTask

        Dim newTask As TaskX = New TaskX()
        With newTask
            .Id = e.TaskId
            .Name = e.TaskName
            .EstimatedTime = e.TaskEstimatedTime
        End With

        TaskManagerX.AddTask(newTask)


    End Sub

    Private Sub MyTasksPanel_LoadTask(sender As Object, e As LoadIdEventArgs) Handles MyTasksPanel.LoadTask

    End Sub

    Private Sub MyTasksPanel_UpdateTask(sender As Object, e As AddTaskEventArgs) Handles MyTasksPanel.UpdateTask

    End Sub

#End Region

#End Region

#Region " ITaskManagerX "

    Public Sub AddTask(Name As String, EstimatedTime As TimeSpan) Implements ITaskManagerX.AddTask
        Throw New NotImplementedException()
    End Sub

    Public Sub AddTask(MyTaskX As TaskX) Implements ITaskManagerX.AddTask
        Throw New NotImplementedException()
    End Sub

    Public Function DeleteTask(TaskId As Integer) As Boolean Implements ITaskManagerX.DeleteTask
        Throw New NotImplementedException()
    End Function

    Public Function GetTask(TaskId As Integer) As TaskX Implements ITaskManagerX.GetTask
        Throw New NotImplementedException()
    End Function

    Public Function GetAllTask() As TaskX() Implements ITaskManagerX.GetAllTask
        Throw New NotImplementedException()
    End Function

    Public Function TaskCount() As Integer Implements ITaskManagerX.TaskCount
        Throw New NotImplementedException()
    End Function

#End Region

#Region " Error Messages "

    Private AddingErrorMessage As String = "Debe Ingresar..."
    Public Event HomeLoadTask As EventHandler(Of LoadIdEventArgs) Implements ITasksPanel.HomeLoadTask
    Public Event HomeAddTask As EventHandler(Of AddTaskEventArgs) Implements ITasksPanel.HomeAddTask
    Public Event HomeUpdateTask As EventHandler(Of AddTaskEventArgs) Implements ITasksPanel.HomeUpdateTask

    Private Sub ShowErrorMessage(errorType As ErrorType, args As Object())

        Dim ErrorMessage As String = String.Empty

        Select Case errorType
            Case ErrorType.Adding

        End Select

    End Sub

    Private Sub IHomePanel_Initialize() Implements IHomePanel.Initialize
        Throw New NotImplementedException()
    End Sub


    Protected Enum ErrorType

        Adding

    End Enum


#End Region




End Class


