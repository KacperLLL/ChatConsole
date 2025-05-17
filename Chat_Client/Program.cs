using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;


class Chat_Client
{
    public static void Main()
    {
        try
        {
            TcpClient tcpClient = new TcpClient();
            IPAddress address = new IPAddress(new Byte[] { 192, 168, 2, 203 });
            tcpClient.Connect(address, 13000);
            if (tcpClient.Connected)
            {
                Console.WriteLine("Connected");
            }
            while (true) ;
            
        }
        catch(Exception e)
        { 
            Console.WriteLine(e.Message);
            while (true) ;
        }

    }

}