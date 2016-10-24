Imports System.ComponentModel

Public Class AddTaskPanel



#Region " Event Declaration "

    Public Event AddTaskConfirm As EventHandler(Of AddTaskEventArgs)
    Public Event AddTaskCancel As EventHandler

#End Region


    Public Property IsTaskNameEmpty As Boolean = True

#Region " Panel Events "
    Private Sub AddTask_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set TaskNameEmpty to True
        IsTaskNameEmpty = True

        ' Clear Controls
        ClearControls()

    End Sub
#End Region

#Region " AddTaskPanels Methods "
    Private Sub ClearControls()

        ' Clear Controls
        txtTaskName.Text = "Escribe el nombre de tu tarea..."
        txtHours.Text = "00"
        txtMinutes.Text = "00"

    End Sub
#End Region


#Region " AddTaskPanels Validation "

    Private Function PerformValidation() As Boolean

        Dim IsTaskNameValid As Boolean = True
        Dim IsTimeSpanValid As Boolean = True

        ' Validating TaskName 
        If IsTaskNameEmpty Then
            IsTaskNameValid = False
            MsgBox("¡Has olvidado de darle nombre a tu tarea!", MsgBoxStyle.Critical, "Oppss")
        End If

        ' Validating TimeSpan
        Dim ts As TimeSpan = New TimeSpan(Integer.Parse(txtHours.Text), Integer.Parse(txtMinutes.Text), 0)
        If ts.Ticks = 0 Then
            IsTimeSpanValid = False
            MsgBox("¡Tu tarea deberia tener una duración!", MsgBoxStyle.Critical, "Oppss")
        End If

        Return IsTaskNameValid AndAlso IsTimeSpanValid

    End Function

#End Region

#Region " Confirm / Cancel Buttons "

#Region " (Button) btnConfirm "

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Not PerformValidation() Then Exit Sub
        OnAddTaskConfirm()
    End Sub

#End Region

#Region " (Button) btnCancel "

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OnAddTaskCancel()
    End Sub

#End Region

#End Region

#Region " Timer Setting Buttons "

    Private Sub btnHourUp_Click(sender As Object, e As EventArgs) Handles btnHourUp.Click
        Dim Hours As Integer = Integer.Parse(txtHours.Text) + 1
        If Hours > 99 Then Exit Sub
        txtHours.Text = Hours.ToString("00")
    End Sub

    Private Sub btnHourDown_Click(sender As Object, e As EventArgs) Handles btnHourDown.Click
        Dim Hours As Integer = Integer.Parse(txtHours.Text) - 1
        If Hours < 0 Then Exit Sub
        txtHours.Text = Hours.ToString("00")
    End Sub

    Private Sub btnMinUp_Click(sender As Object, e As EventArgs) Handles btnMinUp.Click
        Dim Minutes As Integer = Integer.Parse(txtMinutes.Text) + 1
        If Minutes < 0 Then Exit Sub
        txtMinutes.Text = Minutes.ToString("00")
    End Sub

    Private Sub btnMinDown_Click(sender As Object, e As EventArgs) Handles btnMinDown.Click
        Dim Minutes As Integer = Integer.Parse(txtMinutes.Text) - 1
        If Minutes < 0 Then Exit Sub
        txtMinutes.Text = Minutes.ToString("00")
    End Sub

#End Region

#Region " (TextBox) txtTaskName "

    Private Sub txtTaskName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaskName.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If IsTaskNameEmpty Then
                txtTaskName.Text = ""
                IsTaskNameEmpty = False
            End If
        End If
    End Sub

    Private Sub txtTaskName_TextChanged(sender As Object, e As EventArgs) Handles txtTaskName.TextChanged
        If IsTaskNameEmpty Then Exit Sub
        If txtTaskName.Text.Length = 0 Then
            txtTaskName.Text = "Escribe el nombre de tu tarea..."
            IsTaskNameEmpty = True
        End If
    End Sub

    Private Sub txtTaskName_Enter(sender As Object, e As EventArgs) Handles txtTaskName.Enter
        If IsTaskNameEmpty Then
            txtTaskName.Text = ""
        End If
        'txtTaskName.SelectionStart = txtTaskName.TextLength + 1
    End Sub

    Private Sub txtTaskName_Leave(sender As Object, e As EventArgs) Handles txtTaskName.Leave
        If IsTaskNameEmpty Then
            txtTaskName.Text = "Escribe el nombre de tu tarea..."
        End If
    End Sub


#End Region

#Region " Events Raising "

    ''' <summary>
    ''' OnConfirmAddTask
    ''' </summary>
    Protected Overridable Sub OnAddTaskConfirm()
        Dim e As AddTaskEventArgs = New AddTaskEventArgs
        ' TODO Get Next TaskId
        e.TaskId = 0
        e.TaskName = txtTaskName.Text
        e.TaskEstimatedTime = New TimeSpan(CInt(txtHours.Text), CInt(txtMinutes.Text), 0)
        RaiseEvent AddTaskConfirm(Me, e)
        IsTaskNameEmpty = True
        ClearControls()
    End Sub

    ''' <summary>
    ''' OnCancelAddTask
    ''' </summary>
    Protected Overridable Sub OnAddTaskCancel()
        RaiseEvent AddTaskCancel(Me, EventArgs.Empty)
        IsTaskNameEmpty = True
        ClearControls()
    End Sub

    Private Sub lblMinutes_Click(sender As Object, e As EventArgs) Handles lblMinutes.Click

    End Sub

    Private Sub lblHours_Click(sender As Object, e As EventArgs) Handles lblHours.Click

    End Sub

    Private Sub btnConfirm_Validating(sender As Object, e As CancelEventArgs) Handles btnConfirm.Validating

    End Sub





#End Region

End Class

#Region " EventArgs Class Definition "
Public Class AddTaskEventArgs

    Public Property TaskId As Integer
    Public Property TaskName As String
    Public Property TaskEstimatedTime As TimeSpan

End Class
#End Region

