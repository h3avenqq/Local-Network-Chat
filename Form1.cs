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

        private string hostNickname;


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
                BtnSendMessage.Enabled = true;

                TxtNicknameHost.Enabled = false;
                TxtIpClient.Enabled = false;
                TxtIpHost.Enabled = false;
                TxtPortClient.Enabled = false;
                TxtPortHost.Enabled = false;

                if (!string.IsNullOrEmpty(TxtNicknameHost.Text))
                    hostNickname = TxtNicknameHost.Text;
                else
                    hostNickname = "Anonimus";

                this.Text = $"Connected to {TxtIpClient.Text}:{TxtPortClient.Text}";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] msg = new byte[1024];

                msg = encoding.GetBytes($"[{hostNickname}] " + TxtMessage.Text);

                socket.Send(msg);

                LbxChat.Items.Add($"[{hostNickname}] " + TxtMessage.Text);
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

                    ASCIIEncoding encoding = new ASCIIEncoding();

                    receivedData = (byte[])aResult.AsyncState;

                    string receivedMessage = encoding.GetString(receivedData);

                    LbxChat.Items.Add(receivedMessage);
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
