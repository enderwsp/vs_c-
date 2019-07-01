using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
namespace SimiliarTool
{
    public partial class http_client : Form
    {
        
        public http_client()
        {
            InitializeComponent();
        }

        private void vartrs_url_TextChanged(object sender, EventArgs e)
        {
            refresh_dest_url_preview(sender, e);
        }

        private void url_com_TextChanged(object sender, EventArgs e)
        {
            refresh_dest_url_preview(sender, e);
        }
        private void refresh_dest_url_preview(object sender, EventArgs e)
        {
            this.url_preview.Text = this.url_com.Text + this.vartrs_url.Text;
            if (this.url_preview.Text.StartsWith("http") == false)
            {
                this.url_preview.Text = "http://" + this.url_preview.Text;
            }
            if (this.url_preview.Text.IndexOf("//") > 0)
            {
                String areaPre = this.url_preview.Text.Substring(this.url_preview.Text.IndexOf("//") + 2);
                String port = areaPre.IndexOf(":") > 0 ? areaPre.Substring(areaPre.IndexOf(":") + 1) : (this.url_preview.Text.StartsWith("https") ? "443" : "80");
                port = port.IndexOf("/") > 0 ? port.Substring(0, port.IndexOf("/")) : port;
                areaPre = areaPre.IndexOf(":") > 0 ? areaPre.Substring(0, areaPre.IndexOf(":")) : (areaPre.IndexOf("/") > 0 ? areaPre.Substring(0, areaPre.IndexOf("/")) : areaPre);
                this.areaAndPort.Text = " AREA:" + areaPre + ";--PORT:" + port;
            }
        }

        private void console_out_AppendText(String add)
        {
            if (!String.IsNullOrEmpty(add))
            {
                this.console_out.AppendText("\r\n" + DateTime.Now + " _ " + add);
            }
        }
        private void sendbt_Click(object sender, EventArgs e)
        {
            String destUrl = this.url_preview.Text;
            String encodeSelected = this.selected_encode.Text;
            String contentType = "";
            if (Constant.httpdataType[0].Equals(this.dataType_select.Text))
            {
                console_out_AppendText("httpdataType_0:" + this.dataType_select.Text);

            }
            else
            {
                contentType = "application/x-www-form-urlencoded";
                console_out_AppendText("httpdataType:" + this.dataType_select.Text);
            }
            String charset = "charset=" + encodeSelected;
            console_out_AppendText("http——POST ready for datas:");
            
            Encoding myEncoding = Encoding.GetEncoding(encodeSelected);
            string param = HttpUtility.UrlEncode(this.data_content.Text, myEncoding);
            byte[] postBytes = Encoding.ASCII.GetBytes(param);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(destUrl);
            req.Method = "POST";
            console_out_AppendText("httpdataType:Method:" + req.Method);
            req.ContentType = contentType + ";" + charset;
            console_out_AppendText("httpdataType:ContentType:" + req.ContentType);
            req.ContentLength = postBytes.Length;
            console_out_AppendText("httpdataType:ContentLength:" + req.ContentLength);

            #region headerscopy
            if (!String.IsNullOrWhiteSpace(this.headers_add.Text))
            {
                String[] keyAndValue = this.headers_add.Text.Split(new String[] { "\r\n" }, StringSplitOptions.None);
                if (keyAndValue.Length > 0)
                {
                    WebHeaderCollection headersmf = new WebHeaderCollection();

                    for (int x = 0; x < keyAndValue.Length; x++)
                    {
                        String onepara = keyAndValue[x];
                        String[] strs = onepara.Split(new String[] { "=" }, StringSplitOptions.None);
                        if (onepara.Contains(":") && strs.Length == 2)
                        {
                            HttpRequestHeader one;
                            bool tryYes = Enum.TryParse(strs[0], out one);
                            if (tryYes)
                            {
                                headersmf.Set(one, strs[1]);
                                console_out_AppendText("httpdataType:Headers[" + one + ":" + strs[1] + "]");
                            }

                        }
                    }
                    req.Headers = headersmf;
                }

            }
            #endregion

            using (Stream reqStream = req.GetRequestStream())
            {
                console_out_AppendText("http requesting");
                reqStream.Write(postBytes, 0, postBytes.Length);
            }
            string reader = "";
            using (WebResponse wr = req.GetResponse())
            {
                console_out_AppendText("http geting webresponse");
                //在这里对接收到的页面内容进行处理
                reader = new StreamReader(wr.GetResponseStream(), myEncoding).ReadToEnd();
            }
            console_out_AppendText("http geted webresponse:" + reader);
        }
    }
}
