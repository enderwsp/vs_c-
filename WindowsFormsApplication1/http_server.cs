using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class http_server : Form
    {
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            TimingMessageBox messageBox = new TimingMessageBox("aaaaaaa", 3);
            messageBox.ShowDialog();
        }
    }
}
