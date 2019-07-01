using similiar;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimiliarTool
{
    public partial class CodeRender : Form
    {
        ImgForm hc = new ImgForm();
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
            hc.Show_Img(EncoderDo());
        }

        private Bitmap EncoderDo()
        {
            Bitmap result;
            if (openFileForLogo.FileName != "" && openFileForLogo.FileName.IndexOf(".") > 0)
            {
                Bitmap logoimg = new Bitmap(Util.ZoomPicture(Image.FromFile(logo_File.Text), Convert.ToInt32(logo_MAX_width.Text), Convert.ToInt32(logo_MAX_height.Text)));
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
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
            string name = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_QRCODE.png";
            Bitmap encodemap = EncoderDo();
            hc.Show_Img(encodemap);
            encodemap.Save(filepath + name, ImageFormat.Png);
            TimingMessageBox messageBox = new TimingMessageBox("qrcode.png file saved to:\r\n" + filepath + "\r\n" + name, 10);
            messageBox.ShowDialog();
        }
    }
}
