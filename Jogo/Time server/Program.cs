using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace Time_server
{
    class Program
    {
        private static ArrayList arrSocket = new ArrayList();
        private static ArrayList arrNames = new ArrayList();

        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadLine();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server...");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(5);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            Console.WriteLine("Server set up");
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);
            arrSocket.Add(socket);
            Console.WriteLine("Client Connected");


            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveNameCallBack), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private static void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        private static void ReceiveNameCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;

            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);
            arrNames.Add(text);

            text = "User connected: " + text;
            Console.WriteLine(text);

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;

            TcpClient broadcastSocket = new TcpClient();
            broadcastSocket.Client = socket;

            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);
            Console.WriteLine(text);

            string response;
            response = text;

            foreach (object obj in arrNames)
            {
                if (response == obj + ": /Get time")
                {
                    int hour = DateTime.Now.Hour;
                    int min = DateTime.Now.Minute;
                    int sec = DateTime.Now.Second;

                    response = "Server: " + hour + ":" + min + ":" + sec;
                }
                else if (response == obj + ": /Get date")
                {
                    int month = DateTime.Now.Month;
                    int day = DateTime.Now.Day;

                    response = "Server: " + day + "/" + month;
                }
                else { }
            }

            foreach (object obj in arrSocket)
            {
                Socket clientSocket = (Socket)obj;

                byte[] data = Encoding.ASCII.GetBytes(response);
                clientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), clientSocket);
                clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
            }
        }
    }
}
