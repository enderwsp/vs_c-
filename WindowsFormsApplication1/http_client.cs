using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
namespace SimiliarTool
{
    public partial class HttpClient : Form
    {
        
        public HttpClient()
        {
            InitializeComponent();
        }

        private void VartrsUrlTextChanged(object sender, EventArgs e)
        {
            RefreshDestUrlPreview(sender, e);
        }

        private void UrlComTextChanged(object sender, EventArgs e)
        {
            RefreshDestUrlPreview(sender, e);
        }
        private void RefreshDestUrlPreview(object sender, EventArgs e)
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

        private void ConsoleOutOutAppendText(String add)
        {
            if (!String.IsNullOrEmpty(add))
            {
                this.ConsoleOut_out.AppendText("\r\n" + DateTime.Now + " _ " + add);
            }
        }
        private void SendbtClick(object sender, EventArgs e)
        {
            String destUrl = this.url_preview.Text;
            String encodeSelected = this.selected_encode.Text;
            String contentType = "";
            if (Constant.httpdataType[0].Equals(this.dataType_select.Text))
            {
                ConsoleOutOutAppendText("httpdataType_0:" + this.dataType_select.Text);

            }
            else
            {
                contentType = "application/x-www-form-urlencoded";
                ConsoleOutOutAppendText("httpdataType:" + this.dataType_select.Text);
            }
            String charset = "charset=" + encodeSelected;
            ConsoleOutOutAppendText("http——POST ready for datas:");
            
            Encoding myEncoding = Encoding.GetEncoding(encodeSelected);
            string param = HttpUtility.UrlEncode(this.data_content.Text, myEncoding);
            byte[] postBytes = Encoding.ASCII.GetBytes(param);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(destUrl);
            req.Method = "POST";
            ConsoleOutOutAppendText("httpdataType:Method:" + req.Method);
            req.ContentType = contentType + ";" + charset;
            ConsoleOutOutAppendText("httpdataType:ContentType:" + req.ContentType);
            req.ContentLength = postBytes.Length;
            ConsoleOutOutAppendText("httpdataType:ContentLength:" + req.ContentLength);

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
                            bool tryYes = Enum.TryParse(strs[0], out HttpRequestHeader one);
                            if (tryYes)
                            {
                                headersmf.Set(one, strs[1]);
                                ConsoleOutOutAppendText("httpdataType:Headers[" + one + ":" + strs[1] + "]");
                            }

                        }
                    }
                    req.Headers = headersmf;
                }

            }
            #endregion

            using (Stream reqStream = req.GetRequestStream())
            {
                ConsoleOutOutAppendText("http requesting");
                reqStream.Write(postBytes, 0, postBytes.Length);
            }
            string reader = "";
            using (WebResponse wr = req.GetResponse())
            {
                ConsoleOutOutAppendText("http geting webresponse");
                //在这里对接收到的页面内容进行处理
                reader = new StreamReader(wr.GetResponseStream(), myEncoding).ReadToEnd();
            }
            ConsoleOutOutAppendText("http geted webresponse:" + reader);
        }
    }
}
