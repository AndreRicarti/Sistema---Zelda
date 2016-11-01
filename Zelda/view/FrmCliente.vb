Public Class FrmCliente
  Private estado As Estado = Estado.None

  Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    atualizarTela()
    toolTip()
    carregarDGV()
  End Sub

  Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
    If (txtPesquisaCodigo.Text.Trim <> Nothing) Then
      Dim clienteDao As New ClsDaoCliente
      Dim clientes As List(Of ClsCliente) = clienteDao.getListByCode(txtPesquisaCodigo.Text.Trim)
      dgvCliente.DataSource = clientes
    End If

    If (txtPesquisaNome.Text.Trim <> Nothing) Then
      Dim clienteDao As New ClsDaoCliente
      Dim clientes As List(Of ClsCliente) = clienteDao.getListByName(txtPesquisaNome.Text.Trim)
      dgvCliente.DataSource = clientes
    End If
  End Sub

  Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
    estado = Estado.Inserir
    atualizarTela()
  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    estado = Estado.None
    atualizarTela()
  End Sub

  Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

    Select Case estado
      Case Estado.Inserir
        salvar()
      Case Estado.Alterar
        atualizar()
      Case Else
        MessageBox.Show("Operação inválida!")
    End Select

  End Sub

  Private Sub salvar()
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
      limparCampos()
      estado = Estado.None
      atualizarTela()

      carregarDGV()
    Catch ex As Exception
      MessageBox.Show("Houve erro ao inserir: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub atualizar()
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
      limparCampos()
      estado = Estado.None
      atualizarTela()

      carregarDGV()
    Catch ex As Exception
      MessageBox.Show("Houve erro ao alterar: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub carregarDGV()
    Dim clienteDao As New ClsDaoCliente
    Dim clientes As List(Of ClsCliente) = clienteDao.getAllList()
    dgvCliente.DataSource = clientes
  End Sub

  Private Sub atualizarTela()
    txtNome.Enabled = (estado <> Estado.None)
    txtEndereco.Enabled = (estado <> Estado.None)
    txtNumero.Enabled = (estado <> Estado.None)
    txtCidade.Enabled = (estado <> Estado.None)
    txtUF.Enabled = (estado <> Estado.None)
    txtEmail.Enabled = (estado <> Estado.None)
    txtTelefone.Enabled = (estado <> Estado.None)
    ''--------------------------------------------
    btnSalvar.Enabled = (estado <> Estado.None)
    btnCancelar.Enabled = (estado <> Estado.None)
    btnAlterar.Enabled = (estado = Estado.Alterar)
    btnExcluir.Enabled = (estado = Estado.Alterar)

  End Sub

  Private Sub limparCampos()
    txtNome.Clear()
    txtEndereco.Clear()
    txtNumero.Clear()
    txtCidade.Clear()
    txtUF.Clear()
    txtEmail.Clear()
    txtTelefone.Clear()
  End Sub

  Private Sub toolTip()
    Dim toolTip As New ToolTip()
    toolTip.AutoPopDelay = 5000
    toolTip.InitialDelay = 100
    toolTip.ReshowDelay = 500
    toolTip.ShowAlways = True

    toolTip.SetToolTip(Me.btnPesquisar, "Pesquisar")
    toolTip.SetToolTip(Me.btnExcluir, "Excluir")
    toolTip.SetToolTip(Me.btnAlterar, "Alterar")
    toolTip.SetToolTip(Me.btnCancelar, "Cancelar")
    toolTip.SetToolTip(Me.btnIncluir, "Incluir")
    toolTip.SetToolTip(Me.btnSalvar, "Salvar")
  End Sub

  Private Sub ajustarDGV()

  End Sub

End Class
