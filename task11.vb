Module Module1
    '11.not_bad:
    Sub Main()
        Dim sentence, string2, string3, rightstring, leftstring As String
        Dim bfr, after As Integer

        after = 0
        bfr = 0
        sentence = ""
        leftstring = ""
        rightstring = ""


        Console.WriteLine("Enter the string : ")
        sentence = Console.ReadLine()
        string2 = "not"
        string3 = "bad"
        bfr = InStr(sentence, string2)
        after = InStr(sentence, string3)


        If bfr > 0 Then
            leftstring = Left(sentence, bfr - 1)

            If after > 0 Then
                rightstring = Mid(sentence, after + 3, Len(sentence))


            End If
        End If

        Console.WriteLine(leftstring & "good" & rightstring)
        Console.ReadKey()
    End Sub

End Module