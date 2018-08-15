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


namespace _3510
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint localSetting, remoteSetting;

        public Form1()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            send.Enabled = false; //연결 전에 비활성화
        }

        private void MsgCallBack(IAsyncResult ar)
        {
            try
            {
                int size = socket.EndReceiveFrom(ar, ref remoteSetting); //데이터 받는 거 끝내기
                if (size > 0)
                {
                    byte[] receivedMsg = new byte[60];

                    receivedMsg = (byte[])ar.AsyncState;

                    string receivedMessage = System.Text.Encoding.UTF8.GetString(receivedMsg);

                    content.AppendText(yourIP.Text + " >> " + receivedMessage);
                    content.AppendText(Environment.NewLine);
                }
                byte[] messageBuffer = new byte[60];
                socket.BeginReceiveFrom(messageBuffer, 0, messageBuffer.Length, SocketFlags.None, ref remoteSetting, new AsyncCallback(MsgCallBack), messageBuffer); //다시 받기 시작
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (myIP.Text == "" || myPort.Text == "" || yourIP.Text == "" || yourPort.Text == "")
            {
                MessageBox.Show("입력하지 않은 항목이 있습니다");
            }
            else
            {
                try
                {
                    //연결버튼 누르면 재연결 되게
                    socket.Close();
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                    //소켓에 연결
                    localSetting = new IPEndPoint(IPAddress.Parse(myIP.Text), Convert.ToInt32(myPort.Text));
                    socket.Bind(localSetting);

                    remoteSetting = new IPEndPoint(IPAddress.Parse(yourIP.Text), Convert.ToInt32(yourPort.Text));
                    socket.Connect(remoteSetting);

                    byte[] messageBuffer = new byte[60];
                    //데이터 받기 시작
                    socket.BeginReceiveFrom(messageBuffer, 0, messageBuffer.Length, SocketFlags.None, ref remoteSetting, new AsyncCallback(MsgCallBack), messageBuffer);

                    send.Enabled = true;

                    nickname.Text = myIP.Text; //닉네임 초기설정->자신의 아이피
                    content.Clear();

                    sendText.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] msg = new byte[60];
                msg = Encoding.UTF8.GetBytes(sendText.Text);

                socket.Send(msg);
 
                content.AppendText(nickname.Text + " >> " + sendText.Text);
                content.AppendText(Environment.NewLine);

                sendText.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
