using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SimiliarTool
{
    public partial class TcpClientForm : Form
    {
        public TcpClientForm()
        {
            InitializeComponent();
        }

        private void TextBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput(".0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TargetPortValKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void Button1Click(object sender, System.EventArgs e)
        {
            if (CheckInput() == false) {
                return;
            }
            ConnectAndSend(PreparedData());
        }

        private byte[] PreparedData()
        {
            string datactx = send_DATA_CTX.Text;
            Encoding default_encode = Encoding.Default;
            Encoding set_encode = Encoding.GetEncoding(tcp_target_encode_select.Text);
            datactx = set_encode.GetString(default_encode.GetBytes(datactx));
            int lenOfData = datactx.Length;
            send_data_len_VAL.Text = TcpCommon.FullLength(lenOfData, Convert.ToInt32(data_len_SET_VAL.Text));
            string sendData = send_data_len_VAL.Text + lenOfData;
            return set_encode.GetBytes(sendData);
        }

        private void ConnectAndSend(byte[] contentBytes)
        {
            TcpClient tcpcz = new TcpClient();
            tcpcz.BeginConnect(target_IP_VAL.Text, Convert.ToInt32(target_PORT_VAL.Text), new AsyncCallback(TcpCommon.ConnectCallback), tcpcz);//根据服务器的IP地址和端口号 异步连接服务器
            //if (tcpcz.Connected)
            //{
                byte[] retBytes = TcpCommon.TcpReciveAfterSend(tcpcz, contentBytes);
            //}
            //else {
              //  TimingMessageBox messageBox = new TimingMessageBox("target cannot be connected", 5);
                //messageBox.ShowDialog();
                return;
            //}
            
        }

        private Boolean CheckInput()
        {
            if (string.IsNullOrEmpty(target_IP_VAL.Text)) {
                TimingMessageBox messageBox = new TimingMessageBox("target_IP must be input", 5);
                messageBox.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(target_PORT_VAL.Text))
            {
                TimingMessageBox messageBox = new TimingMessageBox("target_PORT must be input", 5);
                messageBox.ShowDialog();
                return false;
            }
            return true;
        }
    }
}
