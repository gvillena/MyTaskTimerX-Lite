Public Class HomePanel

#Region " Events "
    Public Event AddTask As EventHandler
    Public Event MyTasks As EventHandler
    Public Event QuickTask As EventHandler
#End Region

#Region " Form Events "

    Private Sub HomePanel_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Setting Up User Information
        lblUserName.Text = UserManagerX.CurrentUser.FullName

    End Sub

#End Region

#Region " Control Events "

#Region " (Button) btnMyTasks "

    Private Sub btnMyTasks_Click(sender As Object, e As EventArgs) Handles btnMyTasks.Click
        RaiseEvent MyTasks(Me, EventArgs.Empty)
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

#End Region

#End Region

End Class
