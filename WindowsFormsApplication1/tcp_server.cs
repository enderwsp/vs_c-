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
        private void console(String msg)
        {
            this.ConsoleLogOUT.AppendText("\r\n" + DateTime.Now + " _ " + msg);
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (thread != null && thread.ThreadState.Equals(ThreadState.Running) && thread.IsAlive)
            {

                try
                {
                    if (tcpServer != null)
                    {
                        tcpServer.stopServer();
                    }
                    thread.Abort();

                }
                catch (Exception ex)
                {
                    console(ex.Message);
                }
                finally
                {
                    if (tcpServer != null)
                    {
                        tcpServer.stopServer();
                    }
                    thread = null;

                }
                this.tcp_server_PORT_VAL.ReadOnly = false;
                this.button1.Text = "StartServer";
            }
            else {
                tcpServer = new MyTcpServer(this.tcp_server_PORT_VAL.Text, this.ConsoleLogOUT, this.encode_select.Text);
                thread = new Thread(new ThreadStart(tcpServer.startServer));
                thread.Start();
                this.tcp_server_PORT_VAL.ReadOnly = true;
                this.button1.Text = "Stop_Server";
            }
            
            
        }
    }
}
