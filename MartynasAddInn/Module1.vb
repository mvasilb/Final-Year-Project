Module Module1
    Class Dimensions

        Public DimItems As New List(Of String)
        Public dictionary As New Dictionary(Of String, List(Of String))
        Public Sub New(ByVal name As String)
            DimItems.Add("aaa")
            'dictionary.Add(name, DimItems)
        End Sub
        Public Function getItems()
            Return DimItems
        End Function
    End Class
End Module
