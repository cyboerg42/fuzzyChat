Imports System.Net.Sockets
Imports System.IO

Module TCP
    Sub Client(ByVal port As Integer, ByVal ip As String)
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim client As New TcpClient(ip, port)
        Dim stream As NetworkStream = client.GetStream()
        streamw = New StreamWriter(stream)
        streamr = New StreamReader(stream)
        streamw.WriteLine("TTT§sc_handshake")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine("TTT§login_request§Acheloos")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine("TTT§chat_request§Testing...")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine("TTT§get_infos")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine("TTT§my_room")
        streamw.Flush()
        stream.Flush()
        Console.WriteLine(streamr.ReadLine())
        streamw.WriteLine("TTT§change_room§help")
        streamw.Flush()
        stream.Flush()
        streamw.WriteLine("TTT§my_room")
        streamw.Flush()
        stream.Flush()
        Do
            Try
                Console.WriteLine(streamr.ReadLine())
            Catch ex As Exception

            End Try
        Loop

    End Sub
End Module
