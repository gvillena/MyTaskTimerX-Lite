Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Windows.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<CodedUITest()>
Public Class CodedUITest1

    <TestMethod()>
    Public Sub CodedUITestMethod1()
        '            
        ' Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
        '
    End Sub

#Region "Atributos de prueba adicionales"
    '
    ' Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
    '
    '' Use TestInitialize para ejecutar el código antes de ejecutar cada prueba
    '<TestInitialize()> Public Sub MyTestInitialize()
    '    '
    '    ' Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
    '    '
    'End Sub

    '' Use TestCleanup para ejecutar el código después de ejecutar cada prueba
    '<TestCleanup()> Public Sub MyTestCleanup()
    '    '
    '    ' Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
    '    '
    'End Sub

#End Region

    '''<summary>
    '''Obtiene o establece el contexto de las pruebas que proporciona
    '''información y funcionalidad para la serie de pruebas actual.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

    Private testContextInstance As TestContext
End Class
