using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimiliarTool
{
    public partial class CodeDer : Form
    {
        public CodeDer()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            openFileForPic.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|" +
            "Windows Bitmap(*.bmp)|*.bmp|" +
            "Windows Icon(*.ico)|*.ico|" +
            "Graphics Interchange Format (*.gif)|(*.gif)|" +
            "JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|" +
            "Portable Network Graphics (*.png)|*.png|" +
            "Tag Image File Format (*.tif)|*.tif;*.tiff";
            openFileForPic.ShowDialog();
        }

        private void OpenFileForPicFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            file_Path.Text = openFileForPic.FileName;
            Bitmap img = new Bitmap(openFileForPic.FileName);
            decode_plain.Text = CodeZx.Decode(img);
        }
    }
}
