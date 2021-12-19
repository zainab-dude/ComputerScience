Module Module1
    '10.verbing:
    Sub Main()
        Dim string1, string2 As String
        Dim length1 As Integer

        string1 = ""
        
        length1 = 0
        string2 = ""

        Console.WriteLine("Enter word")
        string1 = Console.ReadLine
        length1 = Len(string1)
        string1 = LCase(string1)
        string2 = Right(string1, 3)
        If length1 <= 2 Then
            Console.WriteLine(string1)
        Else
            If string2 <> "ing" Then
                Console.WriteLine(string1 & "ing")
            Else
                Console.WriteLine(string1 & "ly")
            End If
        End If




        Console.ReadKey()
    End Sub
End Module