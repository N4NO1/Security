Module binaryToByte
    Private outputByteArray As Byte()
    ReadOnly Settings As New ParallelOptions With {.MaxDegreeOfParallelism = Environment.ProcessorCount}
    Function BintoBytes(binary As String)
        ReDim outputByteArray((binary.Length / 8) - 1)
        Parallel.For(0, CInt(Math.Round((binary.Length - 1) / 8)), Settings, Sub(i) BtB(i, binary.Substring(i * 8, 8)))
        Return outputByteArray
    End Function
    Sub BtB(i As Integer, binary As String)
        outputByteArray(i) = Convert.ToByte(binary, 2)
        Console.WriteLine(i)
    End Sub
End Module
