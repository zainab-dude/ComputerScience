Module Module1
    '4. Find the character that appears most number of times in an entered string and output it.
    Sub Main()
        Dim highestchar, char1, char2 As Char
        Dim Highest, Count, index, charCount As Integer
        Dim Phrase As String

        highestchar = ""
        Highest = 0
        Count = 0

        Console.Write("Enter Phrase: ")
        Phrase = Console.ReadLine

        For index = 1 To Len(Phrase)
            char2 = Mid(Phrase, index, 1)
            Count = 0
            For charCount = 1 To Len(Phrase)
                char1 = Mid(Phrase, charCount, 1)
                If char1 = char2 Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                highestchar = char2
            End If
        Next
        Console.WriteLine(highestchar & " appeared " & Highest & " number of times.")
        Console.ReadKey()
    End Sub

End Module