Module Module1

    Sub Main()
        Dim n As Integer = Console.ReadLine()

        For i = 1 To n
            Console.Write("$")
            For k = 1 To i - 1
                Console.Write(" $")
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
