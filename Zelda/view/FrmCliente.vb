Public Class FrmCliente
  Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
    Try
      Dim clienteDAO As New ClsDaoCliente
      Dim cliente As New ClsCliente

      cliente.nome = txtNome.Text
      cliente.endereco = txtEndereco.Text
      cliente.numero = txtNumero.Text
      cliente.cidade = txtCidade.Text
      cliente.uf = txtUF.Text
      cliente.email = txtEmail.Text
      cliente.telefone = txtTelefone.Text
      cliente.ativo = "1"
      cliente.dataCadastro = Date.Now

      clienteDAO.insert(cliente)
      MessageBox.Show("Salvo com sucesso.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show("Houve erro ao inserir: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub limparCampos()

  End Sub

End Class
