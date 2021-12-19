Module Module1
    '6) Finding the number of vowels (aeiou) in a string
    Sub Main()
        'Declarations
        Dim Str1 As String
        Dim Char1 As Char
        Dim index, a, e, i, o, u As Integer

        'Initialise
        Str1 = ""
        Char1 = ""
        index = 0
        a = 0
        e = 0
        i = 0
        o = 0
        u = 0

        'Input data
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        'Process
        For index = 1 To Len(Str1)
            Char1 = Mid(Str1, index, 1)
            Char1 = UCase(Char1)
            If Char1 = "A" Then
                a = a + 1
            ElseIf Char1 = "E" Then
                e = e + 1
            ElseIf Char1 = "I" Then
                i = i + 1
            ElseIf Char1 = "O" Then
                o = o + 1
            ElseIf Char1 = "U" Then
                u = u + 1
            End If
        Next

        'OUTPUT Result
        Console.WriteLine("'a' in string are: " & a)
        Console.WriteLine("'e' in string are: " & e)
        Console.WriteLine("'i' in string are: " & i)
        Console.WriteLine("'o' in string are: " & o)
        Console.WriteLine("'u' in string are: " & u)

        Console.ReadKey()
    End Sub

End Module