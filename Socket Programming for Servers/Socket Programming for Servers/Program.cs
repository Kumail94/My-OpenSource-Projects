using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Socket_Programming_for_Servers
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(4000);
            server.Start();
            Console.WriteLine("\nServer is start and waiting for their clients:");
            Socket socketForClients = server.AcceptSocket();

            if (socketForClients.Connected)
            {
                //Send message to Client:
                NetworkStream ns = new NetworkStream(socketForClients);
                StreamWriter sw = new StreamWriter(ns);
                Console.WriteLine("\nSrever: >> Welcome to client");
                sw.WriteLine("\nWellocme to Client");

                sw.Flush();

                //Get Message from Client
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine("\nClient: >> " + sr.ReadLine());
                sw.Close();
                ns.Close();
            }
            socketForClients.Close();
        }
    }
}
