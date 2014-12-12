Imports System.IO

Module ioCMD

    Sub OutN(ByVal t As String)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(t)
    End Sub

    Sub OutD(ByVal t As String)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(t)
    End Sub

    Sub OutE(ByVal t As String)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(t)
    End Sub

    Function Input() As String
        Dim t As String
        t = Console.ReadLine()
        Return t
    End Function

End Module
