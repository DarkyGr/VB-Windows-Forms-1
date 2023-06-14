Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module ConnectionMaster

    Public connection As New SqlConnection("Server= localhost;Database= db_VBWindowsFormsCrud_1;User Id= sa; Password= 12345")

    'Open connection
    Sub OpenConnection()
        If connection.State = 0 Then
            connection.Open()
        End If
    End Sub

    'Close connection
    Sub CloseConnection()
        If connection.State = 1 Then
            connection.Close()
        End If
    End Sub

End Module
