using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimiliarTool
{
    public partial class tcp_server : Form
    {
        Thread thread = null;
        MyTcpServer tcpServer = null;
        public tcp_server()
        {
            InitializeComponent();
        }
        private void ConsoleOut(String msg)
        {
            this.ConsoleOutLogOUT.AppendText("\r\n" + DateTime.Now + " _ " + msg);
        }
        private void Button1Click(object sender, System.EventArgs e)
        {
            if (thread != null && thread.ThreadState.Equals(ThreadState.Running) && thread.IsAlive)
            {

                try
                {
                    if (tcpServer != null)
                    {
                        tcpServer.StopServer();
                    }
                    thread.Abort();

                }
                catch (Exception ex)
                {
                    ConsoleOut(ex.Message);
                }
                finally
                {
                    if (tcpServer != null)
                    {
                        tcpServer.StopServer();
                    }
                    thread = null;

                }
                this.tcp_server_PORT_VAL.ReadOnly = false;
                this.button1.Text = "StartServer";
            }
            else {
                tcpServer = new MyTcpServer(this.tcp_server_PORT_VAL.Text, this.ConsoleOutLogOUT, this.encode_select.Text);
                thread = new Thread(new ThreadStart(tcpServer.StartServer));
                thread.Start();
                this.tcp_server_PORT_VAL.ReadOnly = true;
                this.button1.Text = "Stop_Server";
            }
            
            
        }
    }
}
