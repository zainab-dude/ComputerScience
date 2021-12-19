Module Module1
    '6.donuts

    Sub Main()
        'Declarations
        Dim numDonuts As String
        Dim donuts As Integer

        'Initialise
        numDonuts = ""
        donuts = 0


        'Input data
        Console.Write("Enter number of donuts: ")
        numDonuts = Console.ReadLine
        donuts = Val(numDonuts)

        'Process
        If donuts > 9 Then
            Console.WriteLine("Number of donuts are: many")
        Else
            Console.WriteLine("Number of donuts are:" & numDonuts)
        End If

        Console.ReadKey()
    End Sub

End Module