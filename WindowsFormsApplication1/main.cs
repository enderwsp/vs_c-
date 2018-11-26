using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class similiar : Form
    {
        public static String[] encodingType = new String[] {
            "utf8", "gbk", "gb2312",
            "iso 8859-1"};
        public similiar()
        {
            InitializeComponent();
        }

        private void httpclientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            http_client hc = new http_client();
            hc.Show();
        }

        private void tcpclientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcp_client hc = new tcp_client();
            hc.Show();
        }

        private void httpserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            http_server hc = new http_server();
            hc.Show();
        }

        private void tcpserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcp_server hc = new tcp_server();
            hc.Show();
        }

        private void similiar_Load(object sender, EventArgs e)
        {

        }
    }
}
