Module Module1

    Sub Main()
        Dim string1 As String
        Dim string2, char1 As Char

        string1 = ""
        string2 = ""
        char1 = ""

        Console.WriteLine("Enter a sentence")
        string1 = Console.ReadLine
        string2 = Left(string1, 1)
        Console.Write(string2)
        For COUNT = 1 To Len(string1) - 1
            char1 = Mid(string1, (COUNT + 1), 1)
            If char1 = string2 Then
                char1 = "*"
            End If
            Console.Write(char1)
        Next
        Console.ReadKey()
    End Sub
End Module