Public Interface IDatabase(Of T)

  ''' <summary>
  ''' Método responsavel por inserir objeto no banco de dados
  ''' </summary>
  ''' <param name="t">Tipo generico</param>
  Sub insert(ByVal t As T)

  ''' <summary>
  ''' Método responsavel por atualizar registros já existentes no banco de dados
  ''' </summary>
  ''' <param name="t">Tipo generico</param>
  Sub update(ByVal t As T)

  ''' <summary>
  ''' Método responsavel por realizar a exclusão lógica no banco de dados
  ''' </summary>
  ''' <param name="codigo"></param>
  Sub delete(ByVal codigo As Integer)

  ''' <summary>
  ''' Método responsavel por retornar uma unico objeto do banco de dados
  ''' </summary>
  ''' <param name="codigo">Integer</param>
  ''' <returns>Objeto</returns>
  Function getElement(ByVal codigo As Integer) As T

  ''' <summary>
  ''' Método responsavel por retornar todos os objetos do banco de dados
  ''' </summary>
  ''' <returns>Lista de objeto</returns>
  Function getAllList() As List(Of T)

  ''' <summary>
  ''' Método responsavel por retornar lista de objetos do banco de dados
  ''' </summary>
  ''' <returns>Lista de objeto</returns>
  Function getList(qry As String) As List(Of T)

End Interface
