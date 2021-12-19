Module Module1
    '2. Replace selected character with another in entered string.
    Sub Main()
        'Declarations
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        'Initialise
        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0

        'Input data
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to find from the string: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace in the string: ")
        Char3 = Console.ReadLine

        'Process
        For i = 1 To Len(Str1)
            Char2 = Mid(Str1, i, 1)
            If Char1 <> Char2 Then
                Str2 = Str2 & Char2
            Else
                Str2 = Str2 & Char3
            End If
        Next

        'OUTPUT Result
        Console.WriteLine("Processed string after replacement is: " & Str2)

        Console.ReadKey()
    End Sub

End Module
