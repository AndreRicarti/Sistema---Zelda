Imports System.Text
Imports System.Data.SqlClient
Imports Zelda

Public Class ClsDaoCliente
  Implements IDatabase(Of ClsCliente)

  Private Const _tabela As String = "Cliente"
  Private Const _codigo As String = "cli_Codigo"
  Private Const _nome As String = "cli_Nome"
  Private Const _endereco As String = "cli_Endereco"
  Private Const _numero As String = "cli_Numero"
  Private Const _cidade As String = "cli_Cidade"
  Private Const _uf As String = "cli_UF"
  Private Const _telefone As String = "cli_Telefone"
  Private Const _email As String = "cli_Email"
  Private Const _ativo As String = "cli_ativo"
  Private Const _dataCadastro As String = "cli_DataCadastro"

  Public Sub delete(codigo As Integer) Implements IDatabase(Of ClsCliente).delete
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela)
    sb.AppendLine(" " & _ativo & " = 0")
    sb.AppendLine("WHERE cli_Codigo = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub insert(cliente As ClsCliente) Implements IDatabase(Of ClsCliente).insert
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("INSERT INTO " & _tabela)
    sb.AppendLine(" (" & _nome & ", " & _endereco & ", " & _numero & ", " & _cidade & ", " & _uf & ", " & _telefone)
    sb.AppendLine(", " & _email & ", " & _ativo & ", " & _dataCadastro & ")")
    sb.AppendLine(" VALUES")
    sb.AppendLine(" (")
    sb.AppendLine(" '" & cliente.nome & "',")
    sb.AppendLine(" '" & cliente.endereco & "',")
    sb.AppendLine(" '" & cliente.numero & "',")
    sb.AppendLine(" '" & cliente.cidade & "',")
    sb.AppendLine(" '" & cliente.uf & "',")
    sb.AppendLine(" '" & cliente.telefone & "',")
    sb.AppendLine(" '" & cliente.email & "',")
    sb.AppendLine(" '" & cliente.ativo & "',")
    sb.AppendLine(" '" & converteData(cliente.dataCadastro) & "'")
    sb.AppendLine(")")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub update(cliente As ClsCliente) Implements IDatabase(Of ClsCliente).update
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela & " SET")
    sb.AppendLine(" " & _nome & "'" & cliente.nome & "',")
    sb.AppendLine(" " & _endereco & "'" & cliente.endereco & "',")
    sb.AppendLine(" " & _numero & "'" & cliente.numero & "',")
    sb.AppendLine(" " & _cidade & "'" & cliente.cidade & "',")
    sb.AppendLine(" " & _uf & "'" & cliente.uf & "',")
    sb.AppendLine(" " & _telefone & "'" & cliente.telefone & "',")
    sb.AppendLine(" " & _email & "'" & cliente.email & "',")
    sb.AppendLine(" " & _ativo & "'" & cliente.ativo & "',")
    sb.AppendLine(" " & _dataCadastro & "'" & cliente.dataCadastro & "'")
    sb.AppendLine(" WHERE " & _codigo & " = " & cliente.codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Function getList(qry As String) As List(Of ClsCliente) Implements IDatabase(Of ClsCliente).getList
    Dim connection As Connection = Connection.getInstance()
    Dim clientes As New List(Of ClsCliente)

    Dim cmd As New SqlCommand(qry)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim cliente As New ClsCliente

      cliente.codigo = Integer.Parse(dr(_codigo).ToString())
      cliente.nome = dr(_nome).ToString()
      cliente.endereco = dr(_endereco).ToString()
      cliente.numero = Integer.Parse(dr(_numero).ToString())
      cliente.cidade = dr(_cidade).ToString()
      cliente.uf = dr(_uf).ToString()
      cliente.telefone = dr(_telefone).ToString()
      cliente.email = dr(_email).ToString()
      cliente.ativo = dr(_ativo).ToString()
      cliente.dataCadastro = dr(_dataCadastro).ToString()

      clientes.Add(cliente)
    End While

    Return clientes
  End Function

  Public Function getAllList() As List(Of ClsCliente) Implements IDatabase(Of ClsCliente).getAllList

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _endereco & ", " & _numero & ", " & _cidade & ", " & _uf)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1")

    Return getList(sb.ToString)
  End Function

  Public Function getListByCode(codigo As Integer) As List(Of ClsCliente)
    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _endereco & ", " & _numero & ", " & _cidade & ", " & _uf)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _codigo & " = " & codigo)

    Return getList(sb.ToString)
  End Function

  Public Function getListByName(nome As String) As List(Of ClsCliente)
    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _endereco & ", " & _numero & ", " & _cidade & ", " & _uf)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _nome & " = '" & nome & "'")

    Return getList(sb.ToString)
  End Function

  Public Function getElement(codigo As Integer) As ClsCliente Implements IDatabase(Of ClsCliente).getElement
    Dim connection As Connection = Connection.getInstance()

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _endereco & ", " & _numero & ", " & _cidade & ", " & _uf)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _codigo & " = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim cliente As New ClsCliente

      cliente.codigo = Integer.Parse(dr(_codigo).ToString())
      cliente.nome = dr(_nome).ToString()
      cliente.endereco = dr(_endereco).ToString()
      cliente.numero = Integer.Parse(dr(_numero).ToString())
      cliente.cidade = dr(_cidade).ToString()
      cliente.uf = dr(_uf).ToString()
      cliente.telefone = dr(_telefone).ToString()
      cliente.email = dr(_email).ToString()
      cliente.ativo = dr(_ativo).ToString()
      cliente.dataCadastro = dr(_dataCadastro).ToString()

      Return cliente
    End While

    Return Nothing
  End Function

End Class
