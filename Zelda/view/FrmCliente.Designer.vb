<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
  Inherits Zelda.FrmBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.gbxCliente = New System.Windows.Forms.GroupBox()
    Me.txtUF = New System.Windows.Forms.TextBox()
    Me.lblUF = New System.Windows.Forms.Label()
    Me.txtCidade = New System.Windows.Forms.TextBox()
    Me.lblCidade = New System.Windows.Forms.Label()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.lblNumero = New System.Windows.Forms.Label()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.lblEmail = New System.Windows.Forms.Label()
    Me.txtTelefone = New System.Windows.Forms.TextBox()
    Me.lblTelefone = New System.Windows.Forms.Label()
    Me.txtEndereco = New System.Windows.Forms.TextBox()
    Me.lblEndereco = New System.Windows.Forms.Label()
    Me.txtNome = New System.Windows.Forms.TextBox()
    Me.lblNome = New System.Windows.Forms.Label()
    Me.gbxPesquisa = New System.Windows.Forms.GroupBox()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.txtPesquisaNome = New System.Windows.Forms.TextBox()
    Me.lblPesquisaNome = New System.Windows.Forms.Label()
    Me.txtPesquisaCodigo = New System.Windows.Forms.TextBox()
    Me.lblPesquisaCodigo = New System.Windows.Forms.Label()
    Me.dgvCliente = New System.Windows.Forms.DataGridView()
    Me.lblSalvar = New System.Windows.Forms.Label()
    Me.lblAtualizar = New System.Windows.Forms.Label()
    Me.lblExcluir = New System.Windows.Forms.Label()
    Me.btnExcluir = New System.Windows.Forms.Button()
    Me.btnAtualizar = New System.Windows.Forms.Button()
    Me.btnSalvar = New System.Windows.Forms.Button()
    Me.gbxCliente.SuspendLayout()
    Me.gbxPesquisa.SuspendLayout()
    CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbxCliente
    '
    Me.gbxCliente.Controls.Add(Me.txtUF)
    Me.gbxCliente.Controls.Add(Me.lblUF)
    Me.gbxCliente.Controls.Add(Me.txtCidade)
    Me.gbxCliente.Controls.Add(Me.lblCidade)
    Me.gbxCliente.Controls.Add(Me.txtNumero)
    Me.gbxCliente.Controls.Add(Me.lblNumero)
    Me.gbxCliente.Controls.Add(Me.txtEmail)
    Me.gbxCliente.Controls.Add(Me.lblEmail)
    Me.gbxCliente.Controls.Add(Me.txtTelefone)
    Me.gbxCliente.Controls.Add(Me.lblTelefone)
    Me.gbxCliente.Controls.Add(Me.txtEndereco)
    Me.gbxCliente.Controls.Add(Me.lblEndereco)
    Me.gbxCliente.Controls.Add(Me.txtNome)
    Me.gbxCliente.Controls.Add(Me.lblNome)
    Me.gbxCliente.Location = New System.Drawing.Point(442, 12)
    Me.gbxCliente.Name = "gbxCliente"
    Me.gbxCliente.Size = New System.Drawing.Size(549, 296)
    Me.gbxCliente.TabIndex = 2
    Me.gbxCliente.TabStop = False
    Me.gbxCliente.Text = "Cliente"
    '
    'txtUF
    '
    Me.txtUF.Location = New System.Drawing.Point(450, 152)
    Me.txtUF.MaxLength = 100
    Me.txtUF.Name = "txtUF"
    Me.txtUF.Size = New System.Drawing.Size(93, 26)
    Me.txtUF.TabIndex = 9
    '
    'lblUF
    '
    Me.lblUF.AutoSize = True
    Me.lblUF.Location = New System.Drawing.Point(450, 129)
    Me.lblUF.Name = "lblUF"
    Me.lblUF.Size = New System.Drawing.Size(31, 20)
    Me.lblUF.TabIndex = 8
    Me.lblUF.Text = "UF"
    '
    'txtCidade
    '
    Me.txtCidade.Location = New System.Drawing.Point(10, 152)
    Me.txtCidade.MaxLength = 100
    Me.txtCidade.Name = "txtCidade"
    Me.txtCidade.Size = New System.Drawing.Size(434, 26)
    Me.txtCidade.TabIndex = 7
    '
    'lblCidade
    '
    Me.lblCidade.AutoSize = True
    Me.lblCidade.Location = New System.Drawing.Point(6, 129)
    Me.lblCidade.Name = "lblCidade"
    Me.lblCidade.Size = New System.Drawing.Size(59, 20)
    Me.lblCidade.TabIndex = 6
    Me.lblCidade.Text = "Cidade"
    '
    'txtNumero
    '
    Me.txtNumero.Location = New System.Drawing.Point(450, 100)
    Me.txtNumero.MaxLength = 100
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(93, 26)
    Me.txtNumero.TabIndex = 5
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Location = New System.Drawing.Point(450, 77)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(65, 20)
    Me.lblNumero.TabIndex = 4
    Me.lblNumero.Text = "Número"
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(10, 204)
    Me.txtEmail.MaxLength = 100
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(533, 26)
    Me.txtEmail.TabIndex = 11
    '
    'lblEmail
    '
    Me.lblEmail.AutoSize = True
    Me.lblEmail.Location = New System.Drawing.Point(6, 181)
    Me.lblEmail.Name = "lblEmail"
    Me.lblEmail.Size = New System.Drawing.Size(48, 20)
    Me.lblEmail.TabIndex = 10
    Me.lblEmail.Text = "Email"
    '
    'txtTelefone
    '
    Me.txtTelefone.Location = New System.Drawing.Point(10, 256)
    Me.txtTelefone.MaxLength = 100
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(240, 26)
    Me.txtTelefone.TabIndex = 13
    '
    'lblTelefone
    '
    Me.lblTelefone.AutoSize = True
    Me.lblTelefone.Location = New System.Drawing.Point(6, 233)
    Me.lblTelefone.Name = "lblTelefone"
    Me.lblTelefone.Size = New System.Drawing.Size(71, 20)
    Me.lblTelefone.TabIndex = 12
    Me.lblTelefone.Text = "Telefone"
    '
    'txtEndereco
    '
    Me.txtEndereco.Location = New System.Drawing.Point(10, 100)
    Me.txtEndereco.MaxLength = 100
    Me.txtEndereco.Name = "txtEndereco"
    Me.txtEndereco.Size = New System.Drawing.Size(434, 26)
    Me.txtEndereco.TabIndex = 3
    '
    'lblEndereco
    '
    Me.lblEndereco.AutoSize = True
    Me.lblEndereco.Location = New System.Drawing.Point(6, 77)
    Me.lblEndereco.Name = "lblEndereco"
    Me.lblEndereco.Size = New System.Drawing.Size(78, 20)
    Me.lblEndereco.TabIndex = 2
    Me.lblEndereco.Text = "Endereço"
    '
    'txtNome
    '
    Me.txtNome.Location = New System.Drawing.Point(10, 48)
    Me.txtNome.MaxLength = 100
    Me.txtNome.Name = "txtNome"
    Me.txtNome.Size = New System.Drawing.Size(533, 26)
    Me.txtNome.TabIndex = 1
    '
    'lblNome
    '
    Me.lblNome.AutoSize = True
    Me.lblNome.Location = New System.Drawing.Point(6, 25)
    Me.lblNome.Name = "lblNome"
    Me.lblNome.Size = New System.Drawing.Size(51, 20)
    Me.lblNome.TabIndex = 0
    Me.lblNome.Text = "Nome"
    '
    'gbxPesquisa
    '
    Me.gbxPesquisa.Controls.Add(Me.Button4)
    Me.gbxPesquisa.Controls.Add(Me.txtPesquisaNome)
    Me.gbxPesquisa.Controls.Add(Me.lblPesquisaNome)
    Me.gbxPesquisa.Controls.Add(Me.txtPesquisaCodigo)
    Me.gbxPesquisa.Controls.Add(Me.lblPesquisaCodigo)
    Me.gbxPesquisa.Location = New System.Drawing.Point(12, 12)
    Me.gbxPesquisa.Name = "gbxPesquisa"
    Me.gbxPesquisa.Size = New System.Drawing.Size(424, 145)
    Me.gbxPesquisa.TabIndex = 0
    Me.gbxPesquisa.TabStop = False
    Me.gbxPesquisa.Text = "Pesquisa"
    '
    'Button4
    '
    Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button4.Image = Global.Zelda.My.Resources.Resources.ic_pesquisar1
    Me.Button4.Location = New System.Drawing.Point(373, 92)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(45, 45)
    Me.Button4.TabIndex = 4
    Me.Button4.UseVisualStyleBackColor = False
    '
    'txtPesquisaNome
    '
    Me.txtPesquisaNome.Location = New System.Drawing.Point(75, 60)
    Me.txtPesquisaNome.Name = "txtPesquisaNome"
    Me.txtPesquisaNome.Size = New System.Drawing.Size(343, 26)
    Me.txtPesquisaNome.TabIndex = 3
    '
    'lblPesquisaNome
    '
    Me.lblPesquisaNome.AutoSize = True
    Me.lblPesquisaNome.Location = New System.Drawing.Point(14, 63)
    Me.lblPesquisaNome.Name = "lblPesquisaNome"
    Me.lblPesquisaNome.Size = New System.Drawing.Size(55, 20)
    Me.lblPesquisaNome.TabIndex = 2
    Me.lblPesquisaNome.Text = "Nome:"
    '
    'txtPesquisaCodigo
    '
    Me.txtPesquisaCodigo.Location = New System.Drawing.Point(75, 28)
    Me.txtPesquisaCodigo.Name = "txtPesquisaCodigo"
    Me.txtPesquisaCodigo.Size = New System.Drawing.Size(146, 26)
    Me.txtPesquisaCodigo.TabIndex = 1
    '
    'lblPesquisaCodigo
    '
    Me.lblPesquisaCodigo.AutoSize = True
    Me.lblPesquisaCodigo.Location = New System.Drawing.Point(6, 31)
    Me.lblPesquisaCodigo.Name = "lblPesquisaCodigo"
    Me.lblPesquisaCodigo.Size = New System.Drawing.Size(63, 20)
    Me.lblPesquisaCodigo.TabIndex = 0
    Me.lblPesquisaCodigo.Text = "Código:"
    '
    'dgvCliente
    '
    Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCliente.Location = New System.Drawing.Point(12, 163)
    Me.dgvCliente.Name = "dgvCliente"
    Me.dgvCliente.Size = New System.Drawing.Size(424, 488)
    Me.dgvCliente.TabIndex = 1
    '
    'lblSalvar
    '
    Me.lblSalvar.AutoSize = True
    Me.lblSalvar.Location = New System.Drawing.Point(915, 626)
    Me.lblSalvar.Name = "lblSalvar"
    Me.lblSalvar.Size = New System.Drawing.Size(53, 20)
    Me.lblSalvar.TabIndex = 4
    Me.lblSalvar.Text = "Salvar"
    '
    'lblAtualizar
    '
    Me.lblAtualizar.AutoSize = True
    Me.lblAtualizar.Location = New System.Drawing.Point(799, 626)
    Me.lblAtualizar.Name = "lblAtualizar"
    Me.lblAtualizar.Size = New System.Drawing.Size(71, 20)
    Me.lblAtualizar.TabIndex = 6
    Me.lblAtualizar.Text = "Atualizar"
    '
    'lblExcluir
    '
    Me.lblExcluir.AutoSize = True
    Me.lblExcluir.Location = New System.Drawing.Point(703, 626)
    Me.lblExcluir.Name = "lblExcluir"
    Me.lblExcluir.Size = New System.Drawing.Size(55, 20)
    Me.lblExcluir.TabIndex = 8
    Me.lblExcluir.Text = "Excluir"
    '
    'btnExcluir
    '
    Me.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnExcluir.Image = Global.Zelda.My.Resources.Resources.ic_delete1
    Me.btnExcluir.Location = New System.Drawing.Point(679, 552)
    Me.btnExcluir.Name = "btnExcluir"
    Me.btnExcluir.Size = New System.Drawing.Size(100, 71)
    Me.btnExcluir.TabIndex = 7
    Me.btnExcluir.UseVisualStyleBackColor = False
    '
    'btnAtualizar
    '
    Me.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAtualizar.Image = Global.Zelda.My.Resources.Resources.ic_atualizar
    Me.btnAtualizar.Location = New System.Drawing.Point(785, 552)
    Me.btnAtualizar.Name = "btnAtualizar"
    Me.btnAtualizar.Size = New System.Drawing.Size(100, 71)
    Me.btnAtualizar.TabIndex = 5
    Me.btnAtualizar.UseVisualStyleBackColor = False
    '
    'btnSalvar
    '
    Me.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.btnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSalvar.Image = Global.Zelda.My.Resources.Resources.ic_salvar
    Me.btnSalvar.Location = New System.Drawing.Point(891, 552)
    Me.btnSalvar.Name = "btnSalvar"
    Me.btnSalvar.Size = New System.Drawing.Size(100, 71)
    Me.btnSalvar.TabIndex = 3
    Me.btnSalvar.UseVisualStyleBackColor = False
    '
    'FrmCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.ClientSize = New System.Drawing.Size(1003, 663)
    Me.Controls.Add(Me.btnSalvar)
    Me.Controls.Add(Me.btnAtualizar)
    Me.Controls.Add(Me.btnExcluir)
    Me.Controls.Add(Me.lblExcluir)
    Me.Controls.Add(Me.lblAtualizar)
    Me.Controls.Add(Me.lblSalvar)
    Me.Controls.Add(Me.dgvCliente)
    Me.Controls.Add(Me.gbxPesquisa)
    Me.Controls.Add(Me.gbxCliente)
    Me.Name = "FrmCliente"
    Me.gbxCliente.ResumeLayout(False)
    Me.gbxCliente.PerformLayout()
    Me.gbxPesquisa.ResumeLayout(False)
    Me.gbxPesquisa.PerformLayout()
    CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents gbxCliente As GroupBox
  Friend WithEvents gbxPesquisa As GroupBox
  Friend WithEvents txtPesquisaNome As TextBox
  Friend WithEvents lblPesquisaNome As Label
  Friend WithEvents txtPesquisaCodigo As TextBox
  Friend WithEvents lblPesquisaCodigo As Label
  Friend WithEvents dgvCliente As DataGridView
  Friend WithEvents txtNome As TextBox
  Friend WithEvents lblNome As Label
  Friend WithEvents txtUF As TextBox
  Friend WithEvents lblUF As Label
  Friend WithEvents txtCidade As TextBox
  Friend WithEvents lblCidade As Label
  Friend WithEvents txtNumero As TextBox
  Friend WithEvents lblNumero As Label
  Friend WithEvents txtEmail As TextBox
  Private WithEvents lblEmail As Label
  Friend WithEvents txtTelefone As TextBox
  Friend WithEvents lblTelefone As Label
  Friend WithEvents txtEndereco As TextBox
  Friend WithEvents lblEndereco As Label
  Friend WithEvents lblSalvar As Label
  Friend WithEvents lblAtualizar As Label
  Friend WithEvents lblExcluir As Label
  Friend WithEvents btnExcluir As Button
  Friend WithEvents btnAtualizar As Button
  Friend WithEvents btnSalvar As Button
  Friend WithEvents Button4 As Button
End Class
