Module byteMask
    Function StringToByteMask(inputString As String, length As Integer) As Byte()

        Dim inputStringInteger As Integer

        For i = 0 To inputString.Length - 1

            inputStringInteger += Asc(inputString.Substring(i, 1))

            If i <> inputString.Length - 1 Then

                inputStringInteger /= Asc(inputString.Substring(i + 1, 1))
            Else

                inputStringInteger *= Asc(inputString.Substring(0, 1))
            End If
        Next

        inputStringInteger *= (length Mod inputStringInteger + 1)

        inputString = Convert.ToString(inputStringInteger, 2)

        Console.WriteLine(inputStringInteger)

        Dim bytesRequired As Integer = Math.Ceiling(inputString.Length / 8)

        inputString = inputString.PadLeft(bytesRequired * 8, "0"c)

        Return BintoBytes(inputString)

    End Function
End Module
