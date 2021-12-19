Module Module1
    '9.MixUp:
    Sub Main()
        Dim string1, string2, replaced1, replaced2 As String
        Dim length1, length2 As Integer

        string1 = ""
        string2 = ""
        replaced1 = ""
        replaced2 = ""
        length1 = 0
        length2 = 0

        Console.WriteLine("Enter word")
        string1 = Console.ReadLine
        Console.WriteLine("Enter word")
        string2 = Console.ReadLine
        replaced1 = Left(string1, 2)
        replaced2 = Left(string2, 2)
        length1 = Len(string1)
        string1 = Right(string1, length1 - 2)
        length2 = Len(string2)
        string2 = Right(string2, length2 - 2)

        Console.WriteLine(replaced1 & string2 & " " & replaced2 & string1)



        Console.ReadKey()
    End Sub
End Module