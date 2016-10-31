Public Class ClsUsuario

  Private _codigo As Integer
  Private _nome As String
  Private _login As String
  Private _senha As String
  Private _ativo As Char
  Private _dataCadastro As DateTime

  Public Sub New()
  End Sub

  Property codigo As Integer
    Get
      Return _codigo
    End Get
    Set(ByVal value As Integer)
      _codigo = value
    End Set
  End Property

  Property nome As String
    Get
      Return _nome
    End Get
    Set(ByVal value As String)
      _nome = value
    End Set
  End Property

  Property login As String
    Get
      Return _login
    End Get
    Set(ByVal value As String)
      _login = value
    End Set
  End Property

  Property senha As String
    Get
      Return _senha
    End Get
    Set(ByVal value As String)
      _senha = value
    End Set
  End Property

  Property ativo As Char
    Get
      Return _ativo
    End Get
    Set(ByVal value As Char)
      _ativo = value
    End Set
  End Property

  Property dataCadastro As DateTime
    Get
      Return _dataCadastro
    End Get
    Set(ByVal value As DateTime)
      _dataCadastro = value
    End Set
  End Property

End Class
