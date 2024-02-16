using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Global
{
    public class Server(string IP, string Port)
    {
        TcpListener server = new TcpListener(IPAddress.Parse(IP), int.Parse(Port));
        public bool isRunning = true;
        TcpClient client;
        public static List<Thread> clientThreads = new List<Thread>();
        public static List<TcpClient> clientList = new List<TcpClient>();
        public static List<string> EndPointList = new List<string>();
        public void Start()
        {
            try
            {
                server.Start();

                while (isRunning)
                {
                    client = server.AcceptTcpClient();

                    //Console.WriteLine("Yeni bir istemci bağlandı.");

                    // Yeni bir istemci için thread oluşturma
                    Thread clientThread = null;

                    clientThread = new Thread(() => HandleClient(client, clientThread));

                    clientThread.Start();
                    // Thread'i listeye ekleme
                    clientThreads.Add(clientThread);
                    clientList.Add(client);
                    //  MessageBox.Show("+"+(clientThreads.Count - 1).ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }
        void HandleClient(TcpClient client, Thread calisan)
        {
            bool devam = true;
            while (devam)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    string strEndPoint = stream.Socket.RemoteEndPoint.ToString();
                    EndPointList.Add(strEndPoint);
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0 || !client.Connected)
                    {
                        client.Close();
                        clientThreads.Remove(calisan);
                        clientList.Remove(client);
                        EndPointList.Remove(strEndPoint);
                        //  MessageBox.Show("-"+index.ToString());
                        devam = false;
                    }
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    bool kapatilacak_mi = false;

                    byte[] response = Encoding.ASCII.GetBytes("Sunucudan gelen cevap: " + dataReceived);

                    if (dataReceived.Contains("#Close"))
                    {
                        kapatilacak_mi = true;
                        dataReceived = dataReceived.Replace("#Close", "");
                        Send_data(dataReceived, false, EndPointList);
                    }
                    else
                    {

                        stream.Write(response, 0, response.Length);
                    }
                    if (kapatilacak_mi)
                    {
                        client.Close();
                        clientThreads.Remove(calisan);
                        clientList.Remove(client);
                        EndPointList.Remove(strEndPoint);
                        //  MessageBox.Show("-"+index.ToString());
                        devam = false;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void Close()
        {
            try
            {
                isRunning = false;


                foreach (Thread clientThread in clientThreads)
                {
                    clientThread.Join();
                }
                server.Stop();
            }
            catch (Exception ex)
            {

            }

        }

        public void Send_data(string data, bool hepsi, List<string> EndpoinListt)
        {
            try
            {
                if (hepsi)
                {
                    foreach (TcpClient client in clientList)
                    {
                        NetworkStream stream = client.GetStream();

                        byte[] response = Encoding.ASCII.GetBytes(data);
                        stream.Write(response, 0, response.Length);

                    }
                }
                else
                {
                    foreach (TcpClient client in clientList)
                    {
                        foreach (string endpoint in EndPointList)
                        {

                            NetworkStream stream = client.GetStream();
                            if (endpoint == stream.Socket.RemoteEndPoint.ToString())
                            {
                                byte[] response = Encoding.ASCII.GetBytes(data);
                                stream.Write(response, 0, response.Length);
                                break;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }

    }


}
