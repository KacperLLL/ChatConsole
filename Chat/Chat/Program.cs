using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;


class Chat
 {
    

    public static void Main(String[] args)
    {
        List<TcpClient> clients = new List<TcpClient>();

        //inicjalizacja serwera
        TcpListener server= null;
        server = ServerInit(13000, IPAddress.Any);

        //start obsługi servera
        Thread myNewThread = new Thread(() => ServerHandle(server, clients));
        myNewThread.Start();


    }

    
    
    
    
    
    public static void ServerHandle(TcpListener SERVER, List<TcpClient> CLIENTS)
    {
        while(true)
        {
            TcpClient client = SERVER.AcceptTcpClient();
            CLIENTS.Add(client);
            Console.WriteLine("New connection" + client.Client.AddressFamily);
        }
    }
    
    
    public static TcpListener ServerInit(int port, IPAddress ip)
    {
        TcpListener SERVER = null;
        try
        {
            SERVER = new TcpListener(ip, port);
            SERVER.Start();
            Console.WriteLine("Server started");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return SERVER;
    }
 }