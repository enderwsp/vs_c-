using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void http_server_portVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false) {
                e.Handled = true;
            }     
    
        }
        private void console(String msg) {
            this.console_log.AppendText("\r\n" + DateTime.Now +" _ "+ msg);
        }
        private void button1_Click(object sender, System.EventArgs e)
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
                        httpServer.stop();
                    }
                }
                catch (Exception ex)
                {
                    console(ex.Message);
                }
                finally {
                    thread = null;
                    if (httpServer != null)
                    {
                        httpServer.stop();
                    }
                }
                
                this.http_server_portVal.ReadOnly = false;
                this.button1.Text = "start_SERVER";
                serverStarted = false;
            }
            else {
                
                httpServer = new MyHttpServer(Convert.ToInt16(this.http_server_portVal.Text), this.console_log);
                
                thread = new Thread(new ThreadStart(httpServer.listen));
                thread.Start();
                this.http_server_portVal.ReadOnly = true;
                this.button1.Text = "STOP_SERVER";
                serverStarted = true;
            }
        }

        private void http_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverStarted) {
                this.button1.PerformClick();
            }
        }
    }
}
