using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MyTcpServer
    {
        TextBox logbox;
        Boolean started = false;
        TcpListener listener;
        private String Encode;
        private int Port;
        public MyTcpServer(String port, TextBox log, String encode)
        {
            Port = Convert.ToInt32(port);
            logbox = log;
            Encode = encode;
        }
        public void startServer()
        {
            listener = new TcpListener(IPAddress.Any, Port);//ip为服务器IP地址，port为监听的端口
            
            listener.Start();//开启监听
            Encoding set_encode = Encoding.GetEncoding(Encode);
            started = true;
            String response;
            byte[] recieveData;
            while (started)
            {
                TcpClient remoteClient = null;
                try
                {
                    remoteClient = listener.AcceptTcpClient();
                    logbox.AppendText("\r\n" + DateTime.Now + " _ " + " client request: " + remoteClient.Client.RemoteEndPoint.ToString());
                    lock (remoteClient)//为了保证数据的完整性以及安全性  锁定数据流

                    {

                        recieveData = tcp_com.tcpOnlyRecive(remoteClient);
                    }

                    response = set_encode.GetString(recieveData);

                    lock (remoteClient)

                    {

                        tcp_com.tcpOnlySend(remoteClient, set_encode.GetBytes(response));//异步为发送的字符数组                   

                    }
                    remoteClient.Close();
                    //释放数据流中的数据
                }
                catch (Exception ee)
                {
                    try
                    {
                        logbox.AppendText("\r\n" + DateTime.Now + " _ " + "ee request: " + ee.Message);
                        //释放数据流中的数据
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        public void stopServer()
        {
            if (started) {
                started = false;
                listener.Stop();
                listener = null;
            } 
        }
    }
}
