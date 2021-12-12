Module Module1

    Dim word1 As String
    Dim word2 As String
    Dim word3 As String
    Dim word4 As String
    Dim word5 As String
    Dim word6 As String
    Dim word7 As String
    Dim word8 As String
    Dim word9 As String
    Dim word10 As String
    Dim boardA(15, 15)
    Dim D1 As String
    Dim column As Integer
    Dim row As Integer
    Dim num As Integer = 0
    Dim num1 As Integer = 0
    Sub Main()
      
        For x As Integer = 0 To 14
            For y As Integer = 0 To 14
                boardA(x, y) = " "
            Next
        Next

        Console.WriteLine("WORD SEARCH GENERATOR")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Please enter 10 words related to a topic of your choice to put into the word search.")
        Console.WriteLine("Then enter the direction and co-ordinates of where the word will be placed")
        Console.WriteLine("[ENTER] to continue")
        Console.ReadLine()


        wordA()
        wordA()
        word2 = word1
        wordA()
        word3 = word1
        wordA()
        word4 = word1
        wordA()
        word5 = word1
        wordA()
        word6 = word1
        wordA()
        word7 = word1
        wordA()
        word8 = word1
        wordA()
        word9 = word1
        wordA()
        word10 = word1
        Rnd_letters()
        Console.Clear()

        grid()
        Console.WriteLine()
        Console.WriteLine("WORDS:")
        Console.WriteLine()
        Console.WriteLine(" 1. " + word1 + "   2. " + word2 + "   3. " + word3 + "")
        Console.WriteLine(" 4. " + word4 + "   5. " + word5 + "   6. " + word6 + "")
        Console.WriteLine(" 7. " + word7 + "   8. " + word8 + "   9. " + word9 + "")
        Console.WriteLine("10. " + word10 + "")
        Console.ReadLine()

    End Sub
    Sub direction_coords()
        Console.WriteLine("Please choose one of the following directions:")
        Console.WriteLine()
        Console.WriteLine("Horizontal - Left to Right [a]")
        Console.WriteLine("Horizontal - Right to Left [b]")
        Console.WriteLine("Vertical - Down [c]")
        Console.WriteLine("Vertical - Up [d]")
        Console.WriteLine("Diagonal Down - Right to Left [e]")
        Console.WriteLine("Diagonal Down - Left to Right [f]")
        Console.WriteLine("Diagonal Up - Right to Left [g]")
        Console.WriteLine("Diagonal Up - Left to Right [h]")
        D1 = Console.ReadLine
        Console.Clear()

        grid()
        Console.WriteLine()
        Console.WriteLine()
        If D1 = "a" Then
            Console.WriteLine("DIRECTION: Horizontal - Left to Right")
        ElseIf D1 = "b" Then
            Console.WriteLine("DIRECTION: Horizontal - Right to Left")
        ElseIf D1 = "c" Then
            Console.WriteLine("DIRECTION: Vertical - Down")
        ElseIf D1 = "d" Then
            Console.WriteLine("DIRECTION: Vertical - Up")
        ElseIf D1 = "e" Then
            Console.WriteLine("DIRECTION: Diagonal Down - Right to Left")
        ElseIf D1 = "f" Then
            Console.WriteLine("DIRECTION: Diagonal Down - Left to Right")
        ElseIf D1 = "g" Then
            Console.WriteLine("DIRECTION: Diagonal Up - Right to Left")
        ElseIf D1 = "h" Then
            Console.WriteLine("DIRECTION: Diagonal Up - Left to Right")
        End If
        Console.WriteLine()

        column = 0
        row = 0
        num = 0
        num1 = 0
        Console.WriteLine("Please enter a co-ordinate for your word to start")
        Console.WriteLine("Column:")
        column = Console.ReadLine
        column = column - 1
        Console.WriteLine("Row:")
        row = Console.ReadLine
        row = row - 1

    End Sub
    Sub Rnd_letters()

        Dim alp1 As String = "QWERTYUIOPASDFGHJKLZJDIDGSHBQPEIEYITOXBVYCBD"
        Dim alp() As Char = alp1.ToCharArray

        column = 0
        row = 0
        num = 0

        Do
            If boardA(row, column) = " " Then
                boardA(row, column) = alp(num)
            End If
            column = column + 1
            num = num + 1
            If num = 40 Then
                num = 0
            End If
            If column = 15 Then
                column = 0
                row = row + 1
            End If
        Loop Until column And row = 15

    End Sub
    Sub grid()

        Console.WriteLine("                             COLUMN      ")
        Console.WriteLine()
        Console.WriteLine("            1  2  3  4  5  6  7  8  9 10 11 12 13 14 15  ")
        Console.WriteLine("         1 [" + boardA(0, 0) + "][" + boardA(0, 1) + "][" + boardA(0, 2) + "][" + boardA(0, 3) + "][" + boardA(0, 4) + "][" + boardA(0, 5) + "][" + boardA(0, 6) + "][" + boardA(0, 7) + "][" + boardA(0, 8) + "][" + boardA(0, 9) + "][" + boardA(0, 10) + "][" + boardA(0, 11) + "][" + boardA(0, 12) + "][" + boardA(0, 13) + "][" + boardA(0, 14) + "]")
        Console.WriteLine("         2 [" + boardA(1, 0) + "][" + boardA(1, 1) + "][" + boardA(1, 2) + "][" + boardA(1, 3) + "][" + boardA(1, 4) + "][" + boardA(1, 5) + "][" + boardA(1, 6) + "][" + boardA(1, 7) + "][" + boardA(1, 8) + "][" + boardA(1, 9) + "][" + boardA(1, 10) + "][" + boardA(1, 11) + "][" + boardA(1, 12) + "][" + boardA(1, 13) + "][" + boardA(1, 14) + "]")
        Console.WriteLine("         3 [" + boardA(2, 0) + "][" + boardA(2, 1) + "][" + boardA(2, 2) + "][" + boardA(2, 3) + "][" + boardA(2, 4) + "][" + boardA(2, 5) + "][" + boardA(2, 6) + "][" + boardA(2, 7) + "][" + boardA(2, 8) + "][" + boardA(2, 9) + "][" + boardA(2, 10) + "][" + boardA(2, 11) + "][" + boardA(2, 12) + "][" + boardA(2, 13) + "][" + boardA(2, 14) + "]")
        Console.WriteLine("         4 [" + boardA(3, 0) + "][" + boardA(3, 1) + "][" + boardA(3, 2) + "][" + boardA(3, 3) + "][" + boardA(3, 4) + "][" + boardA(3, 5) + "][" + boardA(3, 6) + "][" + boardA(3, 7) + "][" + boardA(3, 8) + "][" + boardA(3, 9) + "][" + boardA(3, 10) + "][" + boardA(3, 11) + "][" + boardA(3, 12) + "][" + boardA(3, 13) + "][" + boardA(3, 14) + "]")
        Console.WriteLine("         5 [" + boardA(4, 0) + "][" + boardA(4, 1) + "][" + boardA(4, 2) + "][" + boardA(4, 3) + "][" + boardA(4, 4) + "][" + boardA(4, 5) + "][" + boardA(4, 6) + "][" + boardA(4, 7) + "][" + boardA(4, 8) + "][" + boardA(4, 9) + "][" + boardA(4, 10) + "][" + boardA(4, 11) + "][" + boardA(4, 12) + "][" + boardA(4, 13) + "][" + boardA(4, 14) + "]")
        Console.WriteLine("         6 [" + boardA(5, 0) + "][" + boardA(5, 1) + "][" + boardA(5, 2) + "][" + boardA(5, 3) + "][" + boardA(5, 4) + "][" + boardA(5, 5) + "][" + boardA(5, 6) + "][" + boardA(5, 7) + "][" + boardA(5, 8) + "][" + boardA(5, 9) + "][" + boardA(5, 10) + "][" + boardA(5, 11) + "][" + boardA(5, 12) + "][" + boardA(5, 13) + "][" + boardA(5, 14) + "]")
        Console.WriteLine("         7 [" + boardA(6, 0) + "][" + boardA(6, 1) + "][" + boardA(6, 2) + "][" + boardA(6, 3) + "][" + boardA(6, 4) + "][" + boardA(6, 5) + "][" + boardA(6, 6) + "][" + boardA(6, 7) + "][" + boardA(6, 8) + "][" + boardA(6, 9) + "][" + boardA(6, 10) + "][" + boardA(6, 11) + "][" + boardA(6, 12) + "][" + boardA(6, 13) + "][" + boardA(6, 14) + "]")
        Console.WriteLine(" ROW     8 [" + boardA(7, 0) + "][" + boardA(7, 1) + "][" + boardA(7, 2) + "][" + boardA(7, 3) + "][" + boardA(7, 4) + "][" + boardA(7, 5) + "][" + boardA(7, 6) + "][" + boardA(7, 7) + "][" + boardA(7, 8) + "][" + boardA(7, 9) + "][" + boardA(7, 10) + "][" + boardA(7, 11) + "][" + boardA(7, 12) + "][" + boardA(7, 13) + "][" + boardA(7, 14) + "]")
        Console.WriteLine("         9 [" + boardA(8, 0) + "][" + boardA(8, 1) + "][" + boardA(8, 2) + "][" + boardA(8, 3) + "][" + boardA(8, 4) + "][" + boardA(8, 5) + "][" + boardA(8, 6) + "][" + boardA(8, 7) + "][" + boardA(8, 8) + "][" + boardA(8, 9) + "][" + boardA(8, 10) + "][" + boardA(8, 11) + "][" + boardA(8, 12) + "][" + boardA(8, 13) + "][" + boardA(8, 14) + "]")
        Console.WriteLine("         10[" + boardA(9, 0) + "][" + boardA(9, 1) + "][" + boardA(9, 2) + "][" + boardA(9, 3) + "][" + boardA(9, 4) + "][" + boardA(9, 5) + "][" + boardA(9, 6) + "][" + boardA(9, 7) + "][" + boardA(9, 8) + "][" + boardA(9, 9) + "][" + boardA(9, 10) + "][" + boardA(9, 11) + "][" + boardA(9, 12) + "][" + boardA(9, 13) + "][" + boardA(9, 14) + "]")
        Console.WriteLine("         11[" + boardA(10, 0) + "][" + boardA(10, 1) + "][" + boardA(10, 2) + "][" + boardA(10, 3) + "][" + boardA(10, 4) + "][" + boardA(10, 5) + "][" + boardA(10, 6) + "][" + boardA(10, 7) + "][" + boardA(10, 8) + "][" + boardA(10, 9) + "][" + boardA(10, 10) + "][" + boardA(10, 11) + "][" + boardA(10, 12) + "][" + boardA(10, 13) + "][" + boardA(10, 14) + "]")
        Console.WriteLine("         12[" + boardA(11, 0) + "][" + boardA(11, 1) + "][" + boardA(11, 2) + "][" + boardA(11, 3) + "][" + boardA(11, 4) + "][" + boardA(11, 5) + "][" + boardA(11, 6) + "][" + boardA(11, 7) + "][" + boardA(11, 8) + "][" + boardA(11, 9) + "][" + boardA(11, 10) + "][" + boardA(11, 11) + "][" + boardA(11, 12) + "][" + boardA(11, 13) + "][" + boardA(11, 14) + "]")
        Console.WriteLine("         13[" + boardA(12, 0) + "][" + boardA(12, 1) + "][" + boardA(12, 2) + "][" + boardA(12, 3) + "][" + boardA(12, 4) + "][" + boardA(12, 5) + "][" + boardA(12, 6) + "][" + boardA(12, 7) + "][" + boardA(12, 8) + "][" + boardA(12, 9) + "][" + boardA(12, 10) + "][" + boardA(12, 11) + "][" + boardA(12, 12) + "][" + boardA(12, 13) + "][" + boardA(12, 14) + "]")
        Console.WriteLine("         14[" + boardA(13, 0) + "][" + boardA(13, 1) + "][" + boardA(13, 2) + "][" + boardA(13, 3) + "][" + boardA(13, 4) + "][" + boardA(13, 5) + "][" + boardA(13, 6) + "][" + boardA(13, 7) + "][" + boardA(13, 8) + "][" + boardA(13, 9) + "][" + boardA(13, 10) + "][" + boardA(13, 11) + "][" + boardA(13, 12) + "][" + boardA(13, 13) + "][" + boardA(13, 14) + "]")
        Console.WriteLine("         15[" + boardA(14, 0) + "][" + boardA(14, 1) + "][" + boardA(14, 2) + "][" + boardA(14, 3) + "][" + boardA(14, 4) + "][" + boardA(14, 5) + "][" + boardA(14, 6) + "][" + boardA(14, 7) + "][" + boardA(14, 8) + "][" + boardA(14, 9) + "][" + boardA(14, 10) + "][" + boardA(14, 11) + "][" + boardA(14, 12) + "][" + boardA(14, 13) + "][" + boardA(14, 14) + "]")
        Console.WriteLine()

    End Sub
    Sub wordA()
A:
        Console.Clear()
        Console.WriteLine("Please enter a word ")
        word1 = Console.ReadLine
        Dim word1a() As Char = word1.ToUpper.ToCharArray
        Console.Clear()


        grid()
        direction_coords()


        If D1 = "a" Then
            If column + Len(word1) <= 14 Then
                num1 = column + Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column + 1
                num = num + 1
            Loop Until column = num1

        ElseIf D1 = "b" Then
            If column - Len(word1) >= 0 Then
                num1 = column - Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column - 1
                num = num + 1
            Loop Until column = num1

        ElseIf D1 = "c" Then
            If row + Len(word1) <= 14 Then
                num1 = row + Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                row = row + 1
                num = num + 1
            Loop Until row = num1

        ElseIf D1 = "d" Then
            If row - Len(word1) >= 0 Then
                num1 = row - Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                row = row - 1
                num = num + 1
            Loop Until row = num1

        ElseIf D1 = "e" Then
            If column - Len(word1) >= 0 Then
                num1 = column - Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column - 1
                row = row + 1
                num = num + 1
            Loop Until column = num1

        ElseIf D1 = "f" Then
            If column + Len(word1) <= 14 Then
                num1 = column + Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column + 1
                row = row + 1
                num = num + 1
            Loop Until column = num1

        ElseIf D1 = "g" Then
            If column - Len(word1) >= 0 Then
                num1 = column - Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column - 1
                row = row - 1
                num = num + 1
            Loop Until column = num1


        ElseIf D1 = "h" Then
            If column + Len(word1) <= 14 Then
                num1 = column + Len(word1)
            Else
                Console.WriteLine("Word doesn't fit in specified position. Please choose a different word or position")
                Console.WriteLine("[ENTER] to continue")
                Console.ReadLine()
                GoTo A
            End If
            Do
                boardA(row, column) = word1a(num)
                column = column + 1
                row = row - 1
                num = num + 1
            Loop Until column = num1

            End If
            Console.Clear()


    End Sub

   

End Module
