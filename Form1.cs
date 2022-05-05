using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Local_Network_Chat
{
    public partial class FrmMain : Form
    {

        private Socket socket;
        private EndPoint epLocal, epRemote;

        public FrmMain()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            TxtIpHost.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(var ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";//throw Exception???
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(TxtIpHost.Text), Int32.Parse(TxtPortHost.Text));
                socket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(TxtIpClient.Text), Int32.Parse(TxtPortClient.Text));
                socket.Connect(epRemote);

                byte[] buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                BtnConnect.Enabled = false;
                BtnDisconect.Enabled = true;
                BtnSendMessage.Enabled = true;


                this.Text = $"Connected to {TxtIpClient.Text}:{TxtPortClient.Text}";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisconect_Click(object sender, EventArgs e)
        {
            socket.Close();

            BtnConnect.Enabled = true;
            BtnDisconect.Enabled = false;
            BtnSendMessage.Enabled = false;

            this.Text = "Local Network Chat";
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] msg = new byte[1024];

                msg = encoding.GetBytes(TxtMessage.Text);

                socket.Send(msg);

                LbxChat.Items.Add("[You] " + TxtMessage.Text);
                TxtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(aResult, ref epRemote);

                if (size != 0)
                {
                    byte[] receivedData = new byte[1024];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string recievedMessage = encoding.GetString(receivedData);

                    LbxChat.Items.Add("[Friend] " + recievedMessage);
                }

                byte[] buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
