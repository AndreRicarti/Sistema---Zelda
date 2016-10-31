Public Interface IDatabase(Of T)

  Sub insert(ByVal t As T)
  Sub update(ByVal t As T)
  Sub delete(ByVal codigo As Integer)
  Function getList(ByVal codigo As Integer) As List(Of T)
  Function getAllList() As List(Of T)

End Interface
