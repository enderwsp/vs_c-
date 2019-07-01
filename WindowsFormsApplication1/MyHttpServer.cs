using System;
using System.IO;
using System.Windows.Forms;

namespace SimiliarTool
{
    public class MyHttpServer : HttpServer
    {
       readonly TextBox logbox;
        public MyHttpServer(int port, TextBox log)
            : base(port)
        {
            logbox = log;
        }
        public override void HandleGETRequest(HttpProcessor p)
        {
            logbox.AppendText("\r\n" + DateTime.Now + " _ " + "request: " + p.http_url);
            p.WriteSuccess();
            p.outputStream.WriteLine("<html><meta charset=\"utf-8\"><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\">");
            p.outputStream.WriteLine("<body><h1>test server</h1>");
            p.outputStream.WriteLine("Current Time: " + DateTime.Now.ToString());
            p.outputStream.WriteLine("url : {0}", p.http_url);

            p.outputStream.WriteLine("<form method=post action=/form>");
            p.outputStream.WriteLine("<input type=text name=foo value=foovalue>");
            p.outputStream.WriteLine("<input type=submit name=bar value=barvalue>");
            p.outputStream.WriteLine("</form></body></html>");
        }

        public override void HandlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            logbox.AppendText("\r\n" + DateTime.Now + " _ " + "POST request: " + p.http_url);
            string data = inputData.ReadToEnd();
            logbox.AppendText("\r\n" + DateTime.Now + " _ " + "POST request data: " + data);
            p.outputStream.WriteLine("<html><meta charset=\"utf-8\"><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\">");
            p.outputStream.WriteLine("<body><h1>test server</h1>");
            p.outputStream.WriteLine("<a href=/test>return</a><p>");
            p.outputStream.WriteLine("postbody: <pre>{0}</pre>", data);
            p.outputStream.WriteLine("</body></html>");
        }
    }
}
