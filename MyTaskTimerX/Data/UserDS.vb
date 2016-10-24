Imports System.IO

''
' Class for managing configuration persistence
''
Public Class UserDS

    ' This DataSet is used as a memory data
    ' structure to hold config key/value pairs
    ' Inside this DataSet, a single DataTable named ConfigValues is created
    Private Shared DSusers As DataSet

    ' This is the filename for the DataSet XML serialization
    Private Shared mUserDSFileName As String

    ' This property is read-only, because it is set
    ' through Initialize or Store methods
    Public Shared ReadOnly Property ConfigFileName() As String
        Get
            Return mUserDSFileName
        End Get
    End Property

    ' This method has to be invoked before using
    ' any other method of UserDS class
    ' UserDSFile parameter is the name of the user file to be read
    ' (if that file doesn't exists, the method
    ' simply initialize the data structure
    ' and the UserDSFile property)
    Public Shared Function Initialize(ByVal UserDSFile As String) As Boolean
        mUserDSFileName = UserDSFile
        DSusers = New DataSet("UserDS")
        If File.Exists(UserDSFile) Then
            ' If the specified user file exists,
            ' it is read to populate the DataSet
            DSusers.ReadXml(UserDSFile)
            Return True
        Else
            ' If the specified config file doesn't exists, 
            ' the DataSet is simply initialized (and left empty):
            ' the Users DataTable is created
            Dim dt As New DataTable("Users")
            dt.Columns.Add("Id", System.Type.GetType("System.String"))
            dt.Columns.Add("Name", System.Type.GetType("System.String"))
            dt.Columns.Add("LastName", System.Type.GetType("System.String"))
            DSusers.Tables.Add(dt)
            Return False
        End If
        Return False
    End Function

    ' This method serializes the memory data
    ' structure holding the user parameters
    ' The filename used is the one defined calling Initialize method
    Public Shared Sub Store()
        Store(mUserDSFileName)
    End Sub

    ' Same as Store() method, but with the ability
    ' to serialize on a different filename
    Public Shared Sub Store(ByVal UserDSFile As String)
        mUserDSFileName = UserDSFile
        DSusers.WriteXml(UserDSFile)
    End Sub

    ' Read the user data ,
    ' given its Id 
    ' If the user id is not found, it returns nothing 
    Public Shared Function GetUser(ByVal UserId As String) As UserX
        Dim dv As DataView = DSusers.Tables("Users").DefaultView
        dv.RowFilter = "Id='" & UserId & "'"
        If dv.Count > 0 Then
            Dim MyUserX As UserX = New UserX()
            With MyUserX
                .Id = Integer.Parse(CStr(dv.Item(0).Item("Id")))
                .Name = CStr(dv.Item(0).Item("Name"))
                .LastName = CStr(dv.Item(0).Item("LastName"))
            End With
            Return MyUserX
        Else
            Return Nothing
        End If
    End Function

    ' Write in the memory data structure a Key/Value
    ' pair for a configuration setting
    ' If the Key already exists, the Value is simply updated,
    ' else the Key/Value pair is added
    ' Warning: to update the written Key/Value pair
    ' on the config file, you need to call Store
    Public Shared Function SetUser(ByVal UserId _
             As String, ByVal UserValue As UserX) As Boolean
        Dim dv As DataView = DSusers.Tables("Users").DefaultView
        dv.RowFilter = "Id='" & UserId & "'"
        If dv.Count > 0 Then
            dv.Item(0).Item("Name") = UserValue.Name
            dv.Item(0).Item("LastName") = UserValue.LastName
        Else
            Dim dr As DataRow = DSusers.Tables("Users").NewRow()
            dr("Id") = UserId
            dr("Name") = UserValue.Name
            dr("LastName") = UserValue.LastName
            DSusers.Tables("Users").Rows.Add(dr)
        End If
    End Function

End Class
