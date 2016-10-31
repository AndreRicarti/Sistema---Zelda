Public Class ClsFornecedor

  Private _codigo As Integer
  Private _cnpj As String
  Private _ie As String
  Private _razaoSocial As String
  Private _endereco As String
  Private _telefone As String
  Private _email As String
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

  Property cnpj As String
    Get
      Return _cnpj
    End Get
    Set(ByVal value As String)
      _cnpj = value
    End Set
  End Property

  Property ie As String
    Get
      Return _ie
    End Get
    Set(ByVal value As String)
      _ie = value
    End Set
  End Property

  Property razaoSocial As String
    Get
      Return _razaoSocial
    End Get
    Set(ByVal value As String)
      _razaoSocial = value
    End Set
  End Property

  Property endereco As String
    Get
      Return _endereco
    End Get
    Set(ByVal value As String)
      _endereco = value
    End Set
  End Property

  Property telefone As String
    Get
      Return _telefone
    End Get
    Set(ByVal value As String)
      _telefone = value
    End Set
  End Property

  Property email As String
    Get
      Return _email
    End Get
    Set(ByVal value As String)
      _email = value
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
