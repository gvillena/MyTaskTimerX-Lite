Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MyTaskTimerX

<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()

        Dim TForm As New Form1
        Dim Home As New HomePanel
        TForm.AddHomePanel(Home)


    End Sub

End Class