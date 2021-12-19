Module Module1
    '3. Count and output the NUMBER of an entered character in a string. Also output separate counts for alphabets (cap & small together; case neutral), digits and other characters in same entered string. 
    Sub Main()
        'Declarations
        Dim Str1 As String
        Dim Char1 As Char
        Dim i, digitCounter, alphaCounter, symbolCounter As Integer

        'Initialise
        Str1 = ""
        Char1 = ""
        i = 0
        digitCounter = 0
        alphaCounter = 0
        symbolCounter = 0

        'Input data
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        'Process
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                alphaCounter = alphaCounter + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                digitCounter = digitCounter + 1
            ElseIf Char1 >= " " And Char1 <= "/" Then
                symbolCounter = symbolCounter + 1
            ElseIf Char1 >= ":" And Char1 <= "@" Then
                symbolCounter = symbolCounter + 1
            ElseIf Char1 >= "[" And Char1 <= "`" Then
                symbolCounter = symbolCounter + 1
            ElseIf Char1 >= "{" And Char1 <= "~" Then
                symbolCounter = symbolCounter + 1
            End If
        Next

        'OUTPUT Result
        Console.WriteLine("Alphabets are: " & alphaCounter)
        Console.WriteLine("Digits are: " & digitCounter)
        Console.WriteLine("Symbols are: " & symbolCounter)

        Console.ReadKey()
    End Sub

End Module