Public Class FrmMain
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub CadastroUsuario_Click(sender As Object, e As EventArgs) Handles CadastroCliente.Click
    Dim frmCliente As New FrmCliente
    frmCliente.MdiParent = Me
    frmCliente.Show()
  End Sub

End Class
