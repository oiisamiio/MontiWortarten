Module modDataTable

    Public Sub Init(ByRef dtValue As DataTable)

        With dtValue.Columns
            .Add("Text", GetType(String))
            .Add("Value", GetType(Byte))
            .Add("Check", GetType(Byte))
        End With

        dtValue.Rows.Add("", 0, 0)

    End Sub

End Module
