Imports System.Net.Sockets
Imports System.IO

Module TCP
    Sub Client(ByVal port As Integer, ByVal ip As String, ByVal prefix As String)
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim client As New TcpClient(ip, port)
        Dim stream As NetworkStream = client.GetStream()
        streamw = New StreamWriter(stream)
        streamr = New StreamReader(stream)
        streamw.WriteLine(prefix + "§sc_handshake")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine(prefix + "§login_request§Acheloos")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine(prefix + "§chat_request§Testing...")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine(prefix + "§get_infos")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine(prefix + "§my_room")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine(prefix + "§change_room§help")
        streamw.Flush()
        stream.Flush()
        streamw.WriteLine(prefix + "§my_room")
        streamw.Flush()
        stream.Flush()
        Do
            Try
                OutN(streamr.ReadLine())
            Catch ex As Exception

            End Try
        Loop

    End Sub
End Module
