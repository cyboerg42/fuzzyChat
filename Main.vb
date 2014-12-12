
Imports System.Net.Sockets
Imports System.Net
Imports FuzzyChat.TCP
Imports FuzzyChat.ioCMD
Imports System.Threading



Module Main
    Sub Main()
        Dim ip As String
        Dim port As Integer
        OutN("Start....")
        OutN("IP : ")
        ip = Input()
        OutN("Port : ")
        port = Input()
        Dim c = New Thread(Sub() Client(port, ip))
        c.Start()
    End Sub
End Module
