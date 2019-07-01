using System.Drawing;
using System.Windows.Forms;

namespace Similiar
{
    public partial class ImgForm : Form
    {
        public ImgForm()
        {
            InitializeComponent();
        }
        public void Show_Img(Bitmap src)
        {
            show_pic.Image = src;
            this.Width = src.Width + src.Width / 6;
            this.Height = src.Height + src.Height / 6;
            this.Show();
        }
    }
}
