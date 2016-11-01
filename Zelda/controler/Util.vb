Module Util

  Public Function converteData(ByVal data As DateTime) As String
    Dim dataRetorno As String = data.ToString("yyyy-MM-dd HH:mm")
    Return dataRetorno
  End Function

  Public Function validaNumero(ByVal numero As String) As String
    Dim retorno As String = ""

    For i = 0 To numero.Count - 1
      If Char.IsNumber(numero.Chars(i)) Then
        retorno += numero.Chars(i)
      Else
        Return Nothing
      End If
    Next

    Return retorno
  End Function

End Module
