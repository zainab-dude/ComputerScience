Module Module1
    '1 Find if the input string has all the alphabets (case neutral).
    Sub Main()
        'DECLARATIONS
        Dim Sentence, alphabets As String
        Dim isPangram As Boolean
        Dim i As Integer
        Dim Char1 As Char

        'INITIALISATION
        Sentence = ""
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        isPangram = True
        i = 0
        Char1 = ""

        'INPUT
        Console.Write("Enter string to process: ")
        Sentence = Console.ReadLine
        Sentence = LCase(Sentence)

        'PROCESS
        For i = 1 To Len(alphabets)
            Char1 = Mid(alphabets, i, 1)
            If InStr(Sentence, Char1) = 0 Then isPangram = False
            If isPangram = False Then Exit For
        Next i

        'OUTPUT
        If isPangram = True Then
            Console.WriteLine("Entered string is a Pangram.")
        Else
            Console.WriteLine("Entered string is NOT a Pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module
