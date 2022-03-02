Module byteInversion
    Private binaryLam As Byte()
    ReadOnly settings As New ParallelOptions With {.MaxDegreeOfParallelism = Environment.ProcessorCount}
    Function Invert(ByRef binary As Byte(), pstr As Byte()) As Byte()

        binaryLam = binary

        Parallel.For(0, binaryLam.Length, settings, Sub(i) InvertLambda(i, pstr))

        Return binaryLam
    End Function
    Sub InvertLambda(i As Integer, ByVal pbyte As Byte())
        binaryLam(i) = binaryLam(i) Xor pbyte(i Mod pbyte.Length)
    End Sub

End Module
