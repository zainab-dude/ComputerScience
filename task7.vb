Module Module1
    'both_ends

    Sub Main()
        'Declarations
        Dim s, string1, string2 As String
        Dim count As Integer


        'Initialise
        s = ""
        string1 = ""
        string2 = ""
        count = 0

        'Input data
        Console.Write("Enter : ")
        s = Console.ReadLine
        count = Len(s)


        'Process
        If count > 2 Then
            string1 = Mid(s, 1, 2)
            string2 = Right(s, 2)
            Console.Write(string1 & string2)
        Else
            Console.WriteLine(s)
        End If

        Console.ReadKey()
    End Sub

End Module