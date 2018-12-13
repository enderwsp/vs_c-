using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tcp_client : Form
    {
        public tcp_client()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput(".0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void target_PORT_VAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
