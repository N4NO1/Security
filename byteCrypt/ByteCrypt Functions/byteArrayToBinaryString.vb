Module byteArrayToBinaryString
    Public Function ByteToBin(ByVal byteArrayIn() As Byte) As String
        Dim newBin As New Text.StringBuilder
        For Each singleByte In byteArrayIn
            newBin.Append(Convert.ToString(singleByte, 2).PadLeft(8, "0"))
        Next
        Return newBin.ToString
        byteArrayIn = Nothing
    End Function
End Module
