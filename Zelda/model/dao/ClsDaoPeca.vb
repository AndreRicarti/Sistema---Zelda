Imports System.Text
Imports System.Data.SqlClient
Imports Zelda

Public Class ClsDaoPeca
  Implements IDatabase(Of ClsPeca)

  Private Const _tabela As String = "Peca"
  Private Const _codigo As String = "pec_Codigo"
  Private Const _nome As String = "pec_Nome"
  Private Const _valor As String = "pec_Valor"
  Private Const _ativo As String = "pec_Ativo"
  Private Const _dataCadastro As String = "pec_DataCadastro"

  Public Sub delete(codigo As Integer) Implements IDatabase(Of ClsPeca).delete
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela)
    sb.AppendLine(" " & _ativo & " = 0")
    sb.AppendLine("WHERE cli_Codigo = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub insert(peca As ClsPeca) Implements IDatabase(Of ClsPeca).insert
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("INSERT INTO " & _tabela)
    sb.AppendLine(" (" & _nome & ", " & _valor & ", " & _ativo & ", " & _dataCadastro & ")")
    sb.AppendLine(" VALUES")
    sb.AppendLine(" (")
    sb.AppendLine(" '" & peca.nome & "',")
    sb.AppendLine(" '" & peca.valor & "',")
    sb.AppendLine(" '" & peca.ativo & "',")
    sb.AppendLine(" '" & peca.dataCadastro & "'")
    sb.AppendLine(")")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub update(peca As ClsPeca) Implements IDatabase(Of ClsPeca).update
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela & " SET")
    sb.AppendLine(" " & _nome & "'" & peca.nome & "',")
    sb.AppendLine(" " & _valor & "'" & peca.valor & "',")
    sb.AppendLine(" " & _ativo & "'" & peca.ativo & "',")
    sb.AppendLine(" " & _dataCadastro & "'" & peca.dataCadastro & "'")
    sb.AppendLine(" WHERE " & _codigo & " = " & peca.codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Function getAllList() As List(Of ClsPeca) Implements IDatabase(Of ClsPeca).getAllList
    Dim connection As Connection = Connection.getInstance()
    Dim pecas As New List(Of ClsPeca)

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _valor)
    sb.AppendLine(", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim peca As New ClsPeca

      peca.codigo = Integer.Parse(dr(_codigo).ToString())
      peca.nome = dr(_nome).ToString()
      peca.valor = Double.Parse(dr(_valor).ToString())
      peca.ativo = dr(_ativo).ToString()
      peca.dataCadastro = dr(_dataCadastro).ToString()

      pecas.Add(peca)
    End While

    Return pecas
  End Function

  Public Function getElement(codigo As Integer) As ClsPeca Implements IDatabase(Of ClsPeca).getElement
    Dim connection As Connection = Connection.getInstance()

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _nome & ", " & _valor)
    sb.AppendLine(", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _codigo & " = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim peca As New ClsPeca

      peca.codigo = Integer.Parse(dr(_codigo).ToString())
      peca.nome = dr(_nome).ToString()
      peca.valor = Double.Parse(dr(_valor).ToString())
      peca.ativo = dr(_ativo).ToString()
      peca.dataCadastro = dr(_dataCadastro).ToString()

      Return peca
    End While

    Return Nothing
  End Function

  Public Function getList(qry As String) As List(Of ClsPeca) Implements IDatabase(Of ClsPeca).getList
    Throw New NotImplementedException()
  End Function
End Class
