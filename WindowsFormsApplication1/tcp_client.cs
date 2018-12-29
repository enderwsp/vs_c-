using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tcp_client : Form
    {
        public tcp_client()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput(".0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void target_PORT_VAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string datactx = this.send_DATA_CTX.Text;
            Encoding default_encode = Encoding.Default;
            Encoding set_encode = Encoding.GetEncoding(this.tcp_target_encode_select.Text);
            datactx = set_encode.GetString(default_encode.GetBytes(datactx));
            int lenOfData = datactx.Length;
            this.send_data_len_VAL.Text = tcp_com.fulllength(lenOfData, Convert.ToInt32(this.data_len_SET_VAL.Text));
            String sendData = this.send_data_len_VAL.Text + lenOfData;
            byte[] contentBytes = set_encode.GetBytes(sendData);
            TcpClient tcpcz = new TcpClient();
            tcpcz.BeginConnect(this.target_IP_VAL.Text, Convert.ToInt32(this.target_PORT_VAL.Text), new AsyncCallback(tcp_com.ConnectCallback), tcpcz);//根据服务器的IP地址和端口号 异步连接服务器
            byte[] retBytes = tcp_com.tcpReciveAfterSend(tcpcz,contentBytes);
        }
    }
}
