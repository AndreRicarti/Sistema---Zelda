<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
    Me.menu = New System.Windows.Forms.MenuStrip()
    Me.Cadastro = New System.Windows.Forms.ToolStripMenuItem()
    Me.CadastroCliente = New System.Windows.Forms.ToolStripMenuItem()
    Me.CadastroFornecedor = New System.Windows.Forms.ToolStripMenuItem()
    Me.menu.SuspendLayout()
    Me.SuspendLayout()
    '
    'menu
    '
    Me.menu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cadastro})
    Me.menu.Location = New System.Drawing.Point(0, 0)
    Me.menu.Name = "menu"
    Me.menu.Size = New System.Drawing.Size(1008, 28)
    Me.menu.TabIndex = 1
    Me.menu.Text = "MenuStrip1"
    '
    'Cadastro
    '
    Me.Cadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroCliente, Me.CadastroFornecedor})
    Me.Cadastro.Name = "Cadastro"
    Me.Cadastro.Size = New System.Drawing.Size(80, 24)
    Me.Cadastro.Text = "Cadastro"
    '
    'CadastroCliente
    '
    Me.CadastroCliente.Name = "CadastroCliente"
    Me.CadastroCliente.Size = New System.Drawing.Size(153, 24)
    Me.CadastroCliente.Text = "Cliente"
    '
    'CadastroFornecedor
    '
    Me.CadastroFornecedor.Name = "CadastroFornecedor"
    Me.CadastroFornecedor.Size = New System.Drawing.Size(153, 24)
    Me.CadastroFornecedor.Text = "Fornecedor"
    '
    'FrmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ClientSize = New System.Drawing.Size(1008, 691)
    Me.Controls.Add(Me.menu)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.menu
    Me.MaximizeBox = False
    Me.Name = "FrmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Zelda"
    Me.menu.ResumeLayout(False)
    Me.menu.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents menu As MenuStrip
  Friend WithEvents Cadastro As ToolStripMenuItem
  Friend WithEvents CadastroCliente As ToolStripMenuItem
  Friend WithEvents CadastroFornecedor As ToolStripMenuItem
End Class
