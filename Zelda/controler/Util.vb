Module Util

  Public Function converteData(ByVal data As DateTime) As String
    Dim dataRetorno As String = data.ToString("yyyy-MM-dd HH:mm")
    Return dataRetorno
  End Function

End Module
