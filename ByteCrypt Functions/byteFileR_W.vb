Module byteFileR_W
    Sub WriteBytes(ByRef binary As Byte(), ByRef filePath As String)
        File.WriteAllBytes(filePath, binary)
    End Sub
    Function ReadBytes(ByRef filePath As String)
        Dim data() As Byte = File.ReadAllBytes(filePath)
        Console.Write("read")
        Return data
    End Function
End Module
