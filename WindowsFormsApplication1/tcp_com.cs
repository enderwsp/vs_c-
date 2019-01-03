using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public static class tcp_com
    {
        public static int http_server_readBufferSize = 256 * 8 * 1024;
        public static byte[] tcpReciveAfterSend(TcpClient tcpcz, byte[] contentBytes)
        {
            tcpOnlySend(tcpcz, contentBytes);
            return tcpOnlyRecive(tcpcz);
        }
        public static byte[] tcpOnlyRecive(TcpClient tcpcz)
        {
            NetworkStream stream = tcpcz.GetStream();//创建于服务器连接的数据流
            //接收字符串

            byte[] result = new byte[tcpcz.Available]; // tcp.Available为接受的字符串大小
            try
            {

                stream.BeginRead(result, 0, result.Length, new AsyncCallback(ReadCallback), stream);//异步接受服务器回报的字符串

            }
            catch { }
            return result;
        }
        public static void tcpOnlySend(TcpClient tcpcz, byte[] contentBytes)
        {
            NetworkStream stream = tcpcz.GetStream();//创建于服务器连接的数据流
            try
            {
                stream.BeginWrite(contentBytes, 0, contentBytes.Length, new AsyncCallback(SendCallback), stream);//异步发送数据
            }
            catch
            {
            }


        }
        public static void ConnectCallback(IAsyncResult ar)

        {

            TcpClient t = (TcpClient)ar.AsyncState;

            try

            {

                if (t.Connected)

                {

                    t.EndConnect(ar);//函数运行到这里就说明连接成功

                }

                else

                {

                }

            }

            catch (Exception) { }
        }
        public static void SendCallback(IAsyncResult ar)

        {

            // socket.EndSend(ar, out errorCode);

        }
        public static void ReadCallback(IAsyncResult ar)

        {

            // socket.EndSend(ar, out errorCode);

        }
        public static string fulllength(int lenOfData, int lenSet)
        {
            String len = lenOfData + "";
            while (len.Length < lenSet)
            {
                len = "0" + len;
            }
            return len;
        }
        /// <summary>
        /// 取得外网 IP Address
        /// </summary>
        /// <returns></returns>
        public static string GetExtranetIPAddress()
        {
            HttpWebRequest request = HttpWebRequest.Create("http://www.baidu.com/") as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0";
            string ip = string.Empty;
            WebResponse response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
                ip = Regex.Match(result, pattern).ToString();
            }
            return ip; // result: 210.125.21.xxx
        }
        /// <summary>
        /// 取得本机 IP Address
        /// </summary>
        /// <returns></returns>
        public static List<string> GetHostIPAddress()
        {
            List<string> lstIPAddress = new List<string>();
            IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipa in IpEntry.AddressList)
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                {
                    lstIPAddress.Add(ipa.ToString());
                }
            }
            return lstIPAddress; // result: 192.168.1.17 ......
        }
    }
}
