using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class similiar : Form
    {
        

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
    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length) return 1;
            if (s1.Length < s2.Length) return -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return 0;
        }
    }
}
