using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CodeRender : Form
    {
        public CodeRender()
        {
            InitializeComponent();
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            openFileForLogo.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|" +
            "Windows Bitmap(*.bmp)|*.bmp|" +
            "Windows Icon(*.ico)|*.ico|" +
            "Graphics Interchange Format (*.gif)|(*.gif)|" +
            "JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|" +
            "Portable Network Graphics (*.png)|*.png|" +
            "Tag Image File Format (*.tif)|*.tif;*.tiff";
            openFileForLogo.ShowDialog();
        }

        private void Encoder_Click(object sender, EventArgs e)
        {
            pic_show.Image=EncoderDo();
        }

        private Bitmap EncoderDo()
        {
            Bitmap result;
            if (logo_File.Text.Trim() == "")
            {
                Bitmap logoimg = new Bitmap(logo_File.Text);
                result = CodeZx.RenderQR(plain_Text_inputs.Text, Convert.ToInt32(img_width.Text), Convert.ToInt32(img_height.Text), logoimg);
            }
            else
            {
                result = CodeZx.RenderQR(plain_Text_inputs.Text, Convert.ToInt32(img_width.Text), Convert.ToInt32(img_height.Text));
            }
             return result;
        }

        private void Input_numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Util.IsCharCanInput("0123456789\b".ToCharArray(), e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void OpenFileForLogo_FileOk(object sender, CancelEventArgs e)
        {
            logo_File.Text = openFileForLogo.FileName;
        }
        private void Save_img_Click(object sender, EventArgs e)
        {
            EncoderDo().Save(DateTime.Now+"_QRCODE.png");
        }
    }
}
