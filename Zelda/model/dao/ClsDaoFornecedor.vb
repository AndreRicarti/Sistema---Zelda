Imports System.Text
Imports System.Data.SqlClient
Imports Zelda

Public Class ClsDaoFornecedor
  Implements IDatabase(Of ClsFornecedor)

  Private Const _tabela As String = "Fornecedor"
  Private Const _codigo As String = "for_Codigo"
  Private Const _cnpj As String = "for_CNPJ"
  Private Const _ie As String = "for_IE"
  Private Const _razaoSocial As String = "for_RazaoSocial"
  Private Const _endereco As String = "for_Endereco"
  Private Const _telefone As String = "for_Telefone"
  Private Const _email As String = "for_Email"
  Private Const _ativo As String = "for_Ativo"
  Private Const _dataCadastro As String = "for_DataCadastro"

  Public Sub delete(codigo As Integer) Implements IDatabase(Of ClsFornecedor).delete
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela)
    sb.AppendLine(" " & _ativo & " = 0")
    sb.AppendLine("WHERE cli_Codigo = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub insert(fornecedor As ClsFornecedor) Implements IDatabase(Of ClsFornecedor).insert
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("INSERT INTO " & _tabela)
    sb.AppendLine(" (" & _cnpj & ", " & _ie & ", " & _razaoSocial & ", " & _endereco & ", " & _telefone)
    sb.AppendLine(", " & _email & ", " & _ativo & ", " & _dataCadastro & ")")
    sb.AppendLine(" VALUES")
    sb.AppendLine(" (")
    sb.AppendLine(" '" & fornecedor.cnpj & "',")
    sb.AppendLine(" '" & fornecedor.ie & "',")
    sb.AppendLine(" '" & fornecedor.razaoSocial & "',")
    sb.AppendLine(" '" & fornecedor.endereco & "',")
    sb.AppendLine(" '" & fornecedor.telefone & "',")
    sb.AppendLine(" '" & fornecedor.email & "',")
    sb.AppendLine(" '" & fornecedor.ativo & "',")
    sb.AppendLine(" '" & fornecedor.dataCadastro & "'")
    sb.AppendLine(")")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Sub update(fornecedor As ClsFornecedor) Implements IDatabase(Of ClsFornecedor).update
    Dim connection As Connection = Connection.getInstance()
    Dim sb As New StringBuilder

    sb.AppendLine("UPDATE " & _tabela & " SET")
    sb.AppendLine(" " & _cnpj & "'" & fornecedor.cnpj & "',")
    sb.AppendLine(" " & _ie & "'" & fornecedor.ie & "',")
    sb.AppendLine(" " & _razaoSocial & "'" & fornecedor.razaoSocial & "',")
    sb.AppendLine(" " & _endereco & "'" & fornecedor.endereco & "',")
    sb.AppendLine(" " & _telefone & "'" & fornecedor.telefone & "',")
    sb.AppendLine(" " & _email & "'" & fornecedor.email & "',")
    sb.AppendLine(" " & _ativo & "'" & fornecedor.ativo & "',")
    sb.AppendLine(" " & _dataCadastro & "'" & fornecedor.dataCadastro & "'")
    sb.AppendLine(" WHERE " & _codigo & " = " & fornecedor.codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    connection.ExecuteNonQuery(cmd)
  End Sub

  Public Function getAllList() As List(Of ClsFornecedor) Implements IDatabase(Of ClsFornecedor).getAllList
    Dim connection As Connection = Connection.getInstance()
    Dim fornecedores As New List(Of ClsFornecedor)

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _cnpj & ", " & _ie & ", " & _razaoSocial & ", " & _endereco)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1")

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim fornecedor As New ClsFornecedor

      fornecedor.codigo = Integer.Parse(dr(_codigo).ToString())
      fornecedor.cnpj = dr(_cnpj).ToString()
      fornecedor.ie = dr(_ie).ToString()
      fornecedor.razaoSocial = dr(_razaoSocial).ToString()
      fornecedor.endereco = dr(_endereco).ToString()
      fornecedor.telefone = dr(_telefone).ToString()
      fornecedor.email = dr(_email).ToString()
      fornecedor.ativo = dr(_ativo).ToString()
      fornecedor.dataCadastro = dr(_dataCadastro).ToString()

      fornecedores.Add(fornecedor)
    End While

    Return fornecedores
  End Function

  Public Function getList(codigo As Integer) As List(Of ClsFornecedor) Implements IDatabase(Of ClsFornecedor).getList
    Dim connection As Connection = Connection.getInstance()
    Dim fornecedores As New List(Of ClsFornecedor)

    Dim sb As New StringBuilder
    sb.AppendLine("SELECT " & _codigo & ", " & _cnpj & ", " & _ie & ", " & _razaoSocial & ", " & _endereco)
    sb.AppendLine(", " & _telefone & ", " & _email & ", " & _ativo & ", " & _dataCadastro)
    sb.AppendLine(" FROM " & _tabela & " WHERE " & _ativo & " = 1 AND " & _codigo & " = " & codigo)

    Dim cmd As New SqlCommand(sb.ToString)
    cmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = connection.executeReader(cmd)

    While (dr.Read())
      Dim fornecedor As New ClsFornecedor

      fornecedor.codigo = Integer.Parse(dr(_codigo).ToString())
      fornecedor.cnpj = dr(_cnpj).ToString()
      fornecedor.ie = dr(_ie).ToString()
      fornecedor.razaoSocial = dr(_razaoSocial).ToString()
      fornecedor.endereco = dr(_endereco).ToString()
      fornecedor.telefone = dr(_telefone).ToString()
      fornecedor.email = dr(_email).ToString()
      fornecedor.ativo = dr(_ativo).ToString()
      fornecedor.dataCadastro = dr(_dataCadastro).ToString()

      fornecedores.Add(fornecedor)
    End While

    Return fornecedores
  End Function
End Class
