<Serializable()>
Public Class ClsCliente

  Private _codigo As Integer
  Private _nome As String
  Private _endereco As String
  Private _numero As Integer
  Private _cidade As String
  Private _uf As String
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

  Property nome As String
    Get
      Return _nome
    End Get
    Set(ByVal value As String)
      _nome = value
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

  Property numero As Integer
    Get
      Return _numero
    End Get
    Set(ByVal value As Integer)
      _numero = value
    End Set
  End Property

  Property cidade As String
    Get
      Return _cidade
    End Get
    Set(ByVal value As String)
      _cidade = value
    End Set
  End Property

  Property uf As String
    Get
      Return _uf
    End Get
    Set(ByVal value As String)
      _uf = value
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
