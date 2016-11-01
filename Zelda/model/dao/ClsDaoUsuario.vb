Imports System.Text
Imports System.Data.SqlClient
Imports Zelda

Public Class ClsDaoUsuario
  Implements IDatabase(Of ClsUsuario)

  Private Const _tabela As String = "Usuario"
  Private Const _codigo As String = "usu_Codigo"
  Private Const _nome As String = "usu_Nome"
  Private Const _login As String = "usu_Login"
  Private Const _senha As String = "usu_Senha"
  Private Const _ativo As String = "usu_Ativo"
  Private Const _dataCadastro As String = "usu_DataCadastro"

  Public Sub delete(codigo As Integer) Implements IDatabase(Of ClsUsuario).delete
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela)
    sb.AppendLine(" " & _ativo & " = 0")
    sb.AppendLine("WHERE cli_Codigo = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub insert(usuario As ClsUsuario) Implements IDatabase(Of ClsUsuario).insert
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("INSERT INTO " & _tabela)
    sb.AppendLine(" (" & _nome & ", " & _login & ", " & _senha & ", " & _ativo & ", " & _dataCadastro & ")")
    sb.AppendLine(" VALUES")
    sb.AppendLine(" (")
    sb.AppendLine(" '" & usuario.nome & "',")
    sb.AppendLine(" '" & usuario.login & "',")
    sb.AppendLine(" '" & usuario.senha & "',")
    sb.AppendLine(" '" & usuario.ativo & "',")
    sb.AppendLine(" '" & usuario.dataCadastro & "'")
    sb.AppendLine(")")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub update(usuario As ClsUsuario) Implements IDatabase(Of ClsUsuario).update
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela & " SET")
    sb.AppendLine(" " & _nome & "'" & usuario.nome & "',")
    sb.AppendLine(" " & _login & "'" & usuario.login & "',")
    sb.AppendLine(" " & _senha & "'" & usuario.senha & "',")
    sb.AppendLine(" " & _ativo & "'" & usuario.ativo & "',")
    sb.AppendLine(" " & _dataCadastro & "'" & usuario.dataCadastro & "'")
    sb.AppendLine(" WHERE " & _codigo & " = " & usuario.codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Function getAllList() As List(Of ClsUsuario) Implements IDatabase(Of ClsUsuario).getAllList
    Dim connection As Connection = Connection.getInstance()
    Dim usuarios As New List(Of ClsUsuario)

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _login & ", " & _senha)
    sb.AppendLine(", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim usuario As New ClsUsuario

      usuario.codigo = Integer.Parse(dr(_codigo).ToString())
      usuario.nome = dr(_nome).ToString()
      usuario.login = dr(_login).ToString()
      usuario.senha = dr(_senha).ToString()
      usuario.ativo = dr(_ativo).ToString()
      usuario.dataCadastro = dr(_dataCadastro).ToString()

      usuarios.Add(usuario)
    End While

    Return usuarios
  End Function

  Public Function getElement(codigo As Integer) As ClsUsuario Implements IDatabase(Of ClsUsuario).getElement
    Dim connection As Connection = Connection.getInstance()

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _login & ", " & _senha)
    sb.AppendLine(", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _codigo & " = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim usuario As New ClsUsuario

      usuario.codigo = Integer.Parse(dr(_codigo).ToString())
      usuario.nome = dr(_nome).ToString()
      usuario.login = dr(_login).ToString()
      usuario.senha = dr(_senha).ToString()
      usuario.ativo = dr(_ativo).ToString()
      usuario.dataCadastro = dr(_dataCadastro).ToString()

      Return usuario
    End While

    Return Nothing
  End Function

  Public Function getList(qry As String) As List(Of ClsUsuario) Implements IDatabase(Of ClsUsuario).getList
    Throw New NotImplementedException()
  End Function
End Class
