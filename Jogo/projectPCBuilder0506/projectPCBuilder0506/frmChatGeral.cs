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

namespace projectPCBuilder0506
{
    public partial class frmChatGeral : Form
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string usr;

        public frmChatGeral(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;

            tmrConnect.Enabled = true;
        }

        private void SendUsr()
        {
            string UserName = usr;
            byte[] buffer = Encoding.ASCII.GetBytes(UserName);
            _clientSocket.Send(buffer);
        }

        private void Send()
        {
            string req = usr + ": " + Convert.ToString(txtSendMsg.Text);
            byte[] buffer = Encoding.ASCII.GetBytes(req);
            _clientSocket.Send(buffer);
        }

        private void LoopConnect()
        {
            int attempts = 0;

            while (!_clientSocket.Connected)
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    txtMsgBox.AppendText("Connection attepts: " + attempts.ToString() + "\n");
                }

            txtMsgBox.AppendText("Connected" + "\n");
            SendUsr();

            ReceiveMsgs.RunWorkerAsync();

            btnSend.Enabled = true;
            Application.DoEvents();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtSendMsg.Text != "")
            {
                Send();
                txtSendMsg.Text = "";
            }
            else{ }
        }

        private void ReceiveMsgs_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_clientSocket.Connected)
            {
                byte[] recivedBuf = new byte[1024];
                int rec = _clientSocket.Receive(recivedBuf);
                byte[] data = new byte[rec];
                Array.Copy(recivedBuf, data, rec);

                txtMsgBox.Invoke(new MethodInvoker(delegate ()
                {
                    txtMsgBox.AppendText(Encoding.ASCII.GetString(data) + "\n");
                }));
            }
        }

        private void frmChatGeral_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrConnect_Tick(object sender, EventArgs e)
        {
            LoopConnect();
            tmrConnect.Enabled = false;
        }

        private void frmChatGeral_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}
