using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.Presentation;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace WindowsFormsApplication1
{
    public class CodeZx
    {
        public static  Bitmap RenderQR(string context,int w,int h) {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.CharacterSet = "UTF-8";
            options.DisableECI = true; // Extended Channel Interpretation (ECI) 主要用于特殊的字符集。并不是所有的扫描器都支持这种编码。
            options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H; // 纠错级别
            options.Width = w;
            options.Height = h;
            options.Margin = 1;
            // options.Hints，更多属性，也可以在这里添加。

            ZXing.BarcodeWriter writer = new ZXing.BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            
            return  writer.Write(context);
        }
        public static Bitmap RenderQR(string context, int w, int h, Bitmap logo)
        {
            //Bitmap logo = new Bitmap(@"H:\桌面\截图\102.jpg");
            //构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            //生成二维码 
            BitMatrix bm = writer.encode(context, BarcodeFormat.QR_CODE, w, h, hint);
            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter();
            Bitmap map = barcodeWriter.Write(bm);


            //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3.5), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3.5), logo.Height);
            int middleL = (map.Width - middleW) / 2;
            int middleT = (map.Height - middleH) / 2;

            //将img转换成bmp格式，否则后面无法创建Graphics对象
            Bitmap bmpimg = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmpimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(map, 0, 0);
            }
            //将二维码插入图片
            Graphics myGraphic = Graphics.FromImage(bmpimg);
            //白底
            myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
            myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH);
            GC.Collect();
            //保存成图片
            //bmpimg.Save(@"H:\桌面\截图\generate3.png", ImageFormat.Png);
            return bmpimg;
        }
        public static Bitmap RenderBR(string context, int w, int h)
        {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true; // Extended Channel Interpretation (ECI) 主要用于特殊的字符集。并不是所有的扫描器都支持这种编码。
            options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H; // 纠错级别
            options.Width = w;
            options.Height = h;
            options.Margin = 1;
            // options.Hints，更多属性，也可以在这里添加。

            ZXing.BarcodeWriter writer = new ZXing.BarcodeWriter();
            writer.Format = BarcodeFormat.ITF;
            writer.Options = options;

            return writer.Write(context);
        }
        public static string Decode(Bitmap imdata)
        {
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
            Result result = reader.Decode(imdata);
            return result.Text;
        }
    }
}
