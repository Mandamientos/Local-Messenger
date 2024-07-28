using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Local_Messenger
{
    public partial class messengerApp : Form
    {
        private Int32 allocatedPort;
        private Int32 targetPort;

        public messengerApp(Int32 allocatedPort, Int32 targetPort)
        {
            InitializeComponent();
            this.allocatedPort = allocatedPort;
            this.targetPort = targetPort;
            infoLabel.Text = $"Estás comunicandote con el puerto {targetPort}";
            Thread listeningServerThread = new Thread(listeningServer);
            listeningServerThread.Start();
        }

        private void messenger_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string myMsg = entryMsg.Text;
            if (myMsg != "" && !(string.IsNullOrWhiteSpace(myMsg)))
            {
                string log = $"[{DateTime.Now}] Yo : {myMsg}\n";
                msgLog.AppendText(log);
                entryMsg.Text = "";
                Thread SendMessageThread = new Thread(() => SendMessage(myMsg));
                SendMessageThread.Start();
            }
        }

        private void SendMessage(string message)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("127.0.0.1", targetPort);
                NetworkStream netStream = tcpClient.GetStream();
                byte[] encodedMsg = Encoding.UTF8.GetBytes(message);
                netStream.Write(encodedMsg, 0, encodedMsg.Length);
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado en la conexión: {ex}");
            }
            finally
            {
                tcpClient.Close();
            }
        }

        private async void listeningServer()
        {
            IPAddress localIp = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(localIp, allocatedPort);
            listener.Start();
            Console.WriteLine($"Servidor escuchando en {allocatedPort}");

            while (true)
            {
                TcpClient incomingClient = await listener.AcceptTcpClientAsync();

                Thread handleMessageThread = new Thread(() => handleMessage(incomingClient));
                handleMessageThread.Start();
            }

        }

        private async void handleMessage(TcpClient incomingClient)
        {
            NetworkStream clientStream = incomingClient.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await clientStream.ReadAsync(buffer, 0, buffer.Length);
            string incomingMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            msgLog.AppendText($"[{DateTime.Now}] Puerto {targetPort} : {incomingMessage}\n");

            incomingClient.Close();

        }

    }
}
