Imports System.Text

Module ListWithCommas
    Dim list As String
    Dim numbersList As List(Of Double) = New List(Of Double)

    Sub Main()
        Console.WriteLine("Input a list of unsorted numbers:")
        list = Console.ReadLine()
        list = Filter(list, ",")
        ConvertToArray(list)
        numbersList = BubbleSort(numbersList)
        Console.WriteLine(vbNewLine + "Here is your sorted list:")
        For Each num In numbersList
            Console.Write(num.ToString + " ")
        Next
        Console.ReadLine()
    End Sub

    Public Function BubbleSort(toSort As List(Of Double))
        Dim swapped As Boolean = True
        Dim temp As Double
        Do Until swapped = False
            swapped = False
            For i = 0 To toSort.Count - 2
                If toSort(i) > toSort(i + 1) Then
                    swapped = True
                    temp = toSort(i)
                    toSort(i) = toSort(i + 1)
                    toSort(i + 1) = temp
                End If
            Next
        Loop
        Return toSort
    End Function

    Public Sub ConvertToArray(lists As String)
        Dim storage() As String = lists.Split(vbNullChar)
        For Each num As String In storage
            numbersList.Add(Double.Parse(num))
        Next
    End Sub
    Public Function Filter(lists As String, removalchar As String)
        'remove all commas from the list
        If lists.Contains(removalchar) Then
            lists = lists.Replace(removalchar, vbNullChar)
        End If
        Return lists
    End Function

End Module
