using NLog;
using System;
using System.Windows.Forms;

namespace SimiliarTool
{

    public partial class similiar : Form
    {

        public static Logger logger;
        public similiar()
        {
            logger = LogManager.GetLogger(GetType().Name);
            logger.Info("similiar starting");
            InitializeComponent();
        }

        private void HttpclientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("http_client starting");
            http_client hc = new http_client();
            hc.Show();
        }

        private void TcpclientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("tcp_client starting");
            tcp_client hc = new tcp_client();
            hc.Show();
        }

        private void HttpserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("http_server starting");
            http_server hc = new http_server();
            hc.Show();
        }

        private void TcpserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("tcp_server starting");
            tcp_server hc = new tcp_server();
            hc.Show();
        }

        private void Similiar_Load(object sender, EventArgs e)
        {
            logger.Info("similiar started");
        }

        private void RenderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logger.Info("CodeRender starting");
            CodeRender hc = new CodeRender();
            hc.Show();
        }

        private void DecoderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logger.Info("CodeDer starting");
            CodeDer hc = new CodeDer();
            hc.Show();
        }

    }
    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length)
            {
                return 1;
            }

            if (s1.Length < s2.Length)
            {
                return -1;
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i])
                {
                    return 1;
                }

                if (s1[i] < s2[i])
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
