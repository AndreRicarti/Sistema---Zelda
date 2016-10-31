Public Class FrmMain
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub CadastroUsuario_Click(sender As Object, e As EventArgs) Handles CadastroCliente.Click
    Dim NewMDIChild As New FrmCliente
    NewMDIChild.MdiParent = Me
    NewMDIChild.Show()
  End Sub

End Class
