using System;
using System.Threading;
using System.Windows.Forms;

namespace SimiliarTool
{
    public partial class http_server : Form
    {
        Thread thread = null;
        HttpServer httpServer=null;
        Boolean serverStarted = false;
        public http_server()
        {
            InitializeComponent();
        }

        private void HttpServerPortValKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false) {
                e.Handled = true;
            }     
    
        }
        private void ConsoleOut(String msg) {
            this.ConsoleOut_log.AppendText("\r\n" + DateTime.Now +" _ "+ msg);
        }
        private void Button1Click(object sender, System.EventArgs e)
        {
            // TimingMessageBox messageBox = new TimingMessageBox("aaaaaaa", 3);
            //messageBox.ShowDialog();

            if (thread !=null&& thread.ThreadState.Equals(ThreadState.Running) && thread.IsAlive)
            {

                try
                {
                    thread.Abort();
                    if (httpServer != null)
                    {
                        httpServer.Stop();
                    }
                }
                catch (Exception ex)
                {
                    ConsoleOut(ex.Message);
                }
                finally {
                    thread = null;
                    if (httpServer != null)
                    {
                        httpServer.Stop();
                    }
                }
                
                this.http_server_portVal.ReadOnly = false;
                this.button1.Text = "start_SERVER";
                serverStarted = false;
            }
            else {
                
                httpServer = new MyHttpServer(Convert.ToInt16(this.http_server_portVal.Text), this.ConsoleOut_log);
                
                thread = new Thread(new ThreadStart(httpServer.Listen));
                thread.Start();
                this.http_server_portVal.ReadOnly = true;
                this.button1.Text = "STOP_SERVER";
                serverStarted = true;
            }
        }

        private void HttpServerFormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverStarted) {
                this.button1.PerformClick();
            }
        }
    }
}
