Public Class FrmCliente
  Private estado As Estado = Estado.None
  Private codigoCliente As Integer

  Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    atualizarTela()
    toolTip()
    carregarDGV()
    carregarComboUF()
  End Sub

  Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
    If (txtPesquisaCodigo.Text.Trim <> Nothing) Then
      carregarDGVCodigo(validaNumero(txtPesquisaCodigo.Text.Trim))
    End If

    If (txtPesquisaNome.Text.Trim <> Nothing) Then
      carregarDGVNome(txtPesquisaNome.Text.Trim)
    End If
  End Sub

  Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
    estado = Estado.Inserir
    atualizarTela()
    limparCampos()
  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    estado = Estado.None
    atualizarTela()

    ErrorNome.Clear()
    ErrorEndereco.Clear()
    ErrorNumero.Clear()
  End Sub

  Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
    estado = Estado.Alterar
    atualizarTela()
  End Sub

  Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
    deletar(codigoCliente)
  End Sub

  Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

    If (consiste()) Then
      Select Case estado
        Case Estado.Inserir
          salvar()
        Case Estado.Alterar
          atualizar()
        Case Else
          MessageBox.Show("Operação inválida!")
      End Select
    End If

  End Sub

  Private Sub dgvCliente_Click(sender As Object, e As System.EventArgs) Handles dgvCliente.Click
    If dgvCliente.Rows.Count <> 0 Then
      codigoCliente = dgvCliente.CurrentRow.Cells(0).Value
      carregarCampos(codigoCliente)
    End If

    estado = Estado.Visualizar
    atualizarTela()
  End Sub

  Private Function consiste() As Boolean
    Dim retorno As Boolean = True

    If (txtNome.Text.Trim = Nothing) Then
      ErrorNome.SetError(txtNome, "Por favor informe um nome.")
      retorno = False
    Else
      ErrorNome.Clear()
    End If

    If (txtEndereco.Text.Trim = Nothing) Then
      ErrorEndereco.SetError(txtEndereco, "Por favor informe um endereço.")
      retorno = False
    Else
      ErrorEndereco.Clear()
    End If

    If (txtNumero.Text.Trim = Nothing Or validaNumero(txtNumero.Text.Trim) = Nothing) Then
      ErrorNumero.SetError(txtNumero, "Por favor informe um número.")
      retorno = False
    Else
      ErrorNumero.Clear()
    End If

    Return retorno
  End Function

  Private Sub salvar()
    Try
      Dim clienteDAO As New ClsDaoCliente
      Dim cliente As New ClsCliente

      cliente.nome = txtNome.Text
      cliente.endereco = txtEndereco.Text
      cliente.numero = txtNumero.Text
      cliente.cidade = txtCidade.Text
      cliente.uf = cboUF.SelectedValue
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
      cliente.uf = cboUF.SelectedValue
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

  Private Sub deletar(codigo As Integer)
    Try
      Dim clienteDAO As New ClsDaoCliente
      clienteDAO.delete(codigo)

      MessageBox.Show("Deletado com sucesso.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      limparCampos()
      estado = Estado.None
      atualizarTela()

      carregarDGV()
    Catch ex As Exception
      MessageBox.Show("Houve erro ao excluir: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub carregarComboUF()
    Dim ufDao As New ClsDaoUF
    cboUF.DataSource = ufDao.getListUf()
    cboUF.SelectedIndex = 25
  End Sub

  Private Sub carregarDGV()
    Dim clienteDao As New ClsDaoCliente
    Dim clientes As List(Of ClsCliente) = clienteDao.getAllList()
    carregarDGV(clientes)
  End Sub

  Private Sub carregarDGVCodigo(codigo As Integer)
    Dim clienteDao As New ClsDaoCliente
    Dim clientes As List(Of ClsCliente) = clienteDao.getListByCode(codigo)
    carregarDGV(clientes)
  End Sub

  Private Sub carregarDGVNome(nome As String)
    Dim clienteDao As New ClsDaoCliente
    Dim clientes As List(Of ClsCliente) = clienteDao.getListByName(nome)
    carregarDGV(clientes)
  End Sub

  Private Sub carregarDGV(clientes As List(Of ClsCliente))
    ajustarDGV()

    If clientes.Count = 0 Then
      dgvCliente.Rows.Clear()
      Exit Sub
    Else
      Dim linhaDGV(clientes.Count - 1) As String

      For i = 0 To clientes.Count - 1
        linhaDGV = {clientes.Item(i).codigo.ToString(), clientes.Item(i).nome.ToString()}
        dgvCliente.Rows.Add(linhaDGV)
      Next

    End If
  End Sub

  Private Sub ajustarDGV()
    With dgvCliente
      .Columns.Clear()
      .TabStop = False
      .ColumnCount = 2
    End With

    With dgvCliente.ColumnHeadersDefaultCellStyle
      .BackColor = Color.Navy
      .ForeColor = Color.White
      .Font = New Font("Garamond", 10, FontStyle.Bold)
    End With

    With dgvCliente
      .Columns(0).HeaderText = "Código"
      .Columns(0).Name = "codigoCliente"
      .Columns(0).Width = 121
      .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
      .Columns(0).DividerWidth = 1 ' Adiciona traço na Coluna
      .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable ' Não deixa a coluna orderna

      .Columns(1).HeaderText = "Nome"
      .Columns(1).Name = "nomeCliente"
      .Columns(1).Width = 301
      .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
      .Columns(1).DividerWidth = 1 ' Adiciona traço na Coluna
      .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
      .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable ' Não deixa a coluna orderna

      .GridColor = Color.Black
      .AllowUserToAddRows = False ' Fais o DGV fica sem linha
      .RowHeadersVisible = False ' Fais a coluna que tem a cetinha desaparecer
      .SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Fais selecionar a linha toda
      .ReadOnly = True ' Não deixa você editar o DGV 
      .AllowUserToResizeColumns = False ' Trava as Colunas
      .AllowUserToResizeRows = False ' Trava linhas
      .CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal ' Fais não buga o | do dgv
      .DefaultCellStyle.SelectionForeColor = Color.Black
      .DefaultCellStyle.SelectionBackColor = Color.Beige
      .CurrentCell = Nothing
    End With

  End Sub

  Private Sub atualizarTela()
    txtNome.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    txtEndereco.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    txtNumero.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    txtCidade.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    cboUF.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    txtEmail.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    txtTelefone.Enabled = (estado <> Estado.None And estado <> Estado.Visualizar)
    ''--------------------------------------------
    btnIncluir.Enabled = (estado <> Estado.Alterar)
    btnSalvar.Enabled = (estado = Estado.Inserir Or estado = Estado.Alterar)
    btnCancelar.Enabled = (estado = Estado.Inserir Or estado = Estado.Alterar)
    btnAlterar.Enabled = (estado = Estado.Visualizar)
    btnExcluir.Enabled = (estado = Estado.Alterar)
  End Sub

  Private Sub limparCampos()
    txtNome.Clear()
    txtEndereco.Clear()
    txtNumero.Clear()
    txtCidade.Clear()
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
    toolTip.SetToolTip(Me.pbxHome, "Home")
  End Sub

  Private Sub carregarCampos(codigo As Integer)
    Dim clienteDao As New ClsDaoCliente
    Dim cliente As ClsCliente = clienteDao.getElement(codigo)

    If (Not cliente Is Nothing) Then
      txtNome.Text = cliente.nome
      txtEndereco.Text = cliente.endereco
      txtNumero.Text = cliente.numero
      txtCidade.Text = cliente.cidade
      cboUF.SelectedItem = cliente.uf
      txtEmail.Text = cliente.email
      txtTelefone.Text = cliente.telefone
    End If

  End Sub
End Class
