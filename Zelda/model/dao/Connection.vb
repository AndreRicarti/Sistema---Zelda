Imports System.Data.SqlClient

Public Class Connection

  Private Shared conn As Connection
  Private Shared stringConexao As String = "Server=192.168.56.1; DATABASE=Zelda; User Id=sa; Pwd=sql2012"

  Private connection As SqlConnection

  Public Shared Function getInstance() As Connection

    If (conn Is Nothing) Then
      conn = New Connection()
    End If

    conn.setConnection(stringConexao)
    Return conn
  End Function

  Private Sub setConnection(ByVal conexao As String)
    connection = New SqlConnection(conexao)
  End Sub

  Private Sub prepareCommand(ByVal command As SqlCommand)
    command.Connection = connection
  End Sub

  Public Function executeReader(ByVal command As SqlCommand) As SqlDataReader
    prepareCommand(command)
    connection.Open()
    Return command.ExecuteReader()
  End Function

  Public Function ExecutaScalar(ByVal command As SqlCommand) As Object
    prepareCommand(command)
    Return command.ExecuteScalar()
  End Function

  Public Function ExecuteNonQuery(ByVal command As SqlCommand) As Integer
    prepareCommand(command)
    connection.Open()
    Return command.ExecuteNonQuery()
  End Function

End Class
