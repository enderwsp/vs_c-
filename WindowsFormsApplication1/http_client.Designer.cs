using System.Text;

namespace SimiliarTool
{
    partial class HttpClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.url_com = new System.Windows.Forms.TextBox();
            this.dest_url = new System.Windows.Forms.Label();
            this.vartrs_url = new System.Windows.Forms.TextBox();
            this.dest_url_preview = new System.Windows.Forms.Label();
            this.url_preview = new System.Windows.Forms.TextBox();
            this.dataType_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.more_headers = new System.Windows.Forms.Label();
            this.headers_add = new System.Windows.Forms.TextBox();
            this.datacontentlb = new System.Windows.Forms.Label();
            this.data_content = new System.Windows.Forms.TextBox();
            this.ConsoleOut_out = new System.Windows.Forms.TextBox();
            this.ConsoleOutout = new System.Windows.Forms.Label();
            this.sendbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_encode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaAndPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // url_com
            // 
            this.url_com.Location = new System.Drawing.Point(194, 41);
            this.url_com.Name = "url_com";
            this.url_com.Size = new System.Drawing.Size(504, 21);
            this.url_com.TabIndex = 0;
            this.url_com.Tag = "dest_url";
            this.url_com.TextChanged += new System.EventHandler(this.UrlComTextChanged);
            // 
            // dest_url
            // 
            this.dest_url.AutoSize = true;
            this.dest_url.Location = new System.Drawing.Point(33, 44);
            this.dest_url.Name = "dest_url";
            this.dest_url.Size = new System.Drawing.Size(155, 12);
            this.dest_url.TabIndex = 1;
            this.dest_url.Text = "dest_url[common + vartrs]";
            // 
            // vartrs_url
            // 
            this.vartrs_url.Location = new System.Drawing.Point(194, 80);
            this.vartrs_url.Name = "vartrs_url";
            this.vartrs_url.Size = new System.Drawing.Size(247, 21);
            this.vartrs_url.TabIndex = 2;
            this.vartrs_url.Tag = "vartrs_url";
            this.vartrs_url.TextChanged += new System.EventHandler(this.VartrsUrlTextChanged);
            // 
            // dest_url_preview
            // 
            this.dest_url_preview.AutoSize = true;
            this.dest_url_preview.Location = new System.Drawing.Point(33, 130);
            this.dest_url_preview.Name = "dest_url_preview";
            this.dest_url_preview.Size = new System.Drawing.Size(101, 12);
            this.dest_url_preview.TabIndex = 3;
            this.dest_url_preview.Text = "dest_url_preview";
            // 
            // url_preview
            // 
            this.url_preview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.url_preview.Location = new System.Drawing.Point(140, 127);
            this.url_preview.Name = "url_preview";
            this.url_preview.ReadOnly = true;
            this.url_preview.Size = new System.Drawing.Size(558, 21);
            this.url_preview.TabIndex = 4;
            this.url_preview.Tag = "url_preview";
            // 
            // dataType_select
            // 
            this.dataType_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataType_select.FormattingEnabled = true;
            this.dataType_select.Items.AddRange(new object[] {
            "jsonData",
            "params&"});
            this.dataType_select.Location = new System.Drawing.Point(140, 195);
            this.dataType_select.Name = "dataType_select";
            this.dataType_select.Size = new System.Drawing.Size(121, 20);
            this.dataType_select.Sorted = true;
            this.dataType_select.TabIndex = 5;
            this.dataType_select.Tag = "dataType_select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "select dataType";
            // 
            // more_headers
            // 
            this.more_headers.AutoSize = true;
            this.more_headers.Location = new System.Drawing.Point(294, 198);
            this.more_headers.Name = "more_headers";
            this.more_headers.Size = new System.Drawing.Size(77, 12);
            this.more_headers.TabIndex = 7;
            this.more_headers.Tag = "more_headers";
            this.more_headers.Text = "more_headers";
            // 
            // headers_add
            // 
            this.headers_add.Location = new System.Drawing.Point(392, 154);
            this.headers_add.Multiline = true;
            this.headers_add.Name = "headers_add";
            this.headers_add.Size = new System.Drawing.Size(306, 117);
            this.headers_add.TabIndex = 8;
            this.headers_add.Tag = "headers_add";
            // 
            // datacontentlb
            // 
            this.datacontentlb.AutoSize = true;
            this.datacontentlb.Location = new System.Drawing.Point(33, 279);
            this.datacontentlb.Name = "datacontentlb";
            this.datacontentlb.Size = new System.Drawing.Size(71, 12);
            this.datacontentlb.TabIndex = 9;
            this.datacontentlb.Tag = "datacontentlb";
            this.datacontentlb.Text = "datacontent";
            // 
            // data_content
            // 
            this.data_content.Location = new System.Drawing.Point(140, 279);
            this.data_content.Multiline = true;
            this.data_content.Name = "data_content";
            this.data_content.Size = new System.Drawing.Size(558, 117);
            this.data_content.TabIndex = 10;
            this.data_content.Tag = "data_content";
            // 
            // ConsoleOut_out
            // 
            this.ConsoleOut_out.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConsoleOut_out.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConsoleOut_out.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ConsoleOut_out.Location = new System.Drawing.Point(35, 436);
            this.ConsoleOut_out.Multiline = true;
            this.ConsoleOut_out.Name = "ConsoleOut_out";
            this.ConsoleOut_out.ReadOnly = true;
            this.ConsoleOut_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleOut_out.Size = new System.Drawing.Size(663, 173);
            this.ConsoleOut_out.TabIndex = 11;
            this.ConsoleOut_out.Tag = "ConsoleOut_out";
            this.ConsoleOut_out.Text = "ConsoleOut_out_here";
            // 
            // ConsoleOutout
            // 
            this.ConsoleOutout.AutoSize = true;
            this.ConsoleOutout.Location = new System.Drawing.Point(33, 398);
            this.ConsoleOutout.Name = "ConsoleOutout";
            this.ConsoleOutout.Size = new System.Drawing.Size(65, 12);
            this.ConsoleOutout.TabIndex = 12;
            this.ConsoleOutout.Tag = "ConsoleOutout";
            this.ConsoleOutout.Text = "ConsoleOutout";
            // 
            // sendbt
            // 
            this.sendbt.Location = new System.Drawing.Point(35, 360);
            this.sendbt.Name = "sendbt";
            this.sendbt.Size = new System.Drawing.Size(93, 23);
            this.sendbt.TabIndex = 13;
            this.sendbt.Tag = "sendbt";
            this.sendbt.Text = "send_request";
            this.sendbt.UseVisualStyleBackColor = true;
            this.sendbt.Click += new System.EventHandler(this.SendbtClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "select Encoding";
            // 
            // selected_encode
            // 
            this.selected_encode.FormattingEnabled = true;
            this.selected_encode.Items.AddRange(new object[] {
            "ASMO-708",
            "big5",
            "cp1025",
            "cp866",
            "cp875",
            "csISO2022JP",
            "DOS-720",
            "DOS-862",
            "EUC-CN",
            "euc-jp",
            "EUC-JP",
            "euc-kr",
            "GB18030",
            "gb2312",
            "hz-gb-2312",
            "IBM-Thai",
            "IBM00858",
            "IBM00924",
            "IBM01047",
            "IBM01140",
            "IBM01141",
            "IBM01142",
            "IBM01143",
            "IBM01144",
            "IBM01145",
            "IBM01146",
            "IBM01147",
            "IBM01148",
            "IBM01149",
            "IBM037",
            "IBM1026",
            "IBM273",
            "IBM277",
            "IBM278",
            "IBM280",
            "IBM284",
            "IBM285",
            "IBM290",
            "IBM297",
            "IBM420",
            "IBM423",
            "IBM424",
            "IBM437",
            "IBM500",
            "ibm737",
            "ibm775",
            "ibm850",
            "ibm852",
            "IBM855",
            "ibm857",
            "IBM860",
            "ibm861",
            "IBM863",
            "IBM864",
            "IBM865",
            "ibm869",
            "IBM870",
            "IBM871",
            "IBM880",
            "IBM905",
            "iso-2022-jp",
            "iso-2022-jp",
            "iso-2022-kr",
            "iso-8859-1",
            "iso-8859-13",
            "iso-8859-15",
            "iso-8859-2",
            "iso-8859-3",
            "iso-8859-4",
            "iso-8859-5",
            "iso-8859-6",
            "iso-8859-7",
            "iso-8859-8",
            "iso-8859-8-i",
            "iso-8859-9",
            "Johab",
            "koi8-r",
            "koi8-u",
            "ks_c_5601-1987",
            "macintosh",
            "shift_jis",
            "us-ascii",
            "utf-16",
            "utf-16BE",
            "utf-32",
            "utf-32BE",
            "utf-7",
            "utf-8",
            "windows-1250",
            "windows-1251",
            "Windows-1252",
            "windows-1253",
            "windows-1254",
            "windows-1255",
            "windows-1256",
            "windows-1257",
            "windows-1258",
            "windows-874",
            "x-Chinese-CNS",
            "x-Chinese-Eten",
            "x-cp20001",
            "x-cp20003",
            "x-cp20004",
            "x-cp20005",
            "x-cp20261",
            "x-cp20269",
            "x-cp20936",
            "x-cp20949",
            "x-cp50227",
            "x-EBCDIC-KoreanExtended",
            "x-Europa",
            "x-IA5",
            "x-IA5-German",
            "x-IA5-Norwegian",
            "x-IA5-Swedish",
            "x-iscii-as",
            "x-iscii-be",
            "x-iscii-de",
            "x-iscii-gu",
            "x-iscii-ka",
            "x-iscii-ma",
            "x-iscii-or",
            "x-iscii-pa",
            "x-iscii-ta",
            "x-iscii-te",
            "x-mac-arabic",
            "x-mac-ce",
            "x-mac-chinesesimp",
            "x-mac-chinesetrad",
            "x-mac-croatian",
            "x-mac-cyrillic",
            "x-mac-greek",
            "x-mac-hebrew",
            "x-mac-icelandic",
            "x-mac-japanese",
            "x-mac-korean",
            "x-mac-romanian",
            "x-mac-thai",
            "x-mac-turkish",
            "x-mac-ukrainian"});
            this.selected_encode.Location = new System.Drawing.Point(140, 239);
            this.selected_encode.Name = "selected_encode";
            this.selected_encode.Size = new System.Drawing.Size(121, 20);
            this.selected_encode.Sorted = true;
            this.selected_encode.TabIndex = 15;
            this.selected_encode.Tag = "selected_encode";
            this.selected_encode.Text = "utf-8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "url_area&port";
            // 
            // areaAndPort
            // 
            this.areaAndPort.AutoSize = true;
            this.areaAndPort.Location = new System.Drawing.Point(140, 166);
            this.areaAndPort.Name = "areaAndPort";
            this.areaAndPort.Size = new System.Drawing.Size(0, 12);
            this.areaAndPort.TabIndex = 17;
            // 
            // http_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 621);
            this.Controls.Add(this.areaAndPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selected_encode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendbt);
            this.Controls.Add(this.ConsoleOutout);
            this.Controls.Add(this.ConsoleOut_out);
            this.Controls.Add(this.data_content);
            this.Controls.Add(this.datacontentlb);
            this.Controls.Add(this.headers_add);
            this.Controls.Add(this.more_headers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataType_select);
            this.Controls.Add(this.url_preview);
            this.Controls.Add(this.dest_url_preview);
            this.Controls.Add(this.vartrs_url);
            this.Controls.Add(this.dest_url);
            this.Controls.Add(this.url_com);
            this.Name = "http_client";
            this.Text = "http_client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_com;
        private System.Windows.Forms.Label dest_url;
        private System.Windows.Forms.TextBox vartrs_url;
        private System.Windows.Forms.Label dest_url_preview;
        private System.Windows.Forms.TextBox url_preview;
        private System.Windows.Forms.ComboBox dataType_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label more_headers;
        private System.Windows.Forms.TextBox headers_add;
        private System.Windows.Forms.Label datacontentlb;
        private System.Windows.Forms.TextBox data_content;
        private System.Windows.Forms.TextBox ConsoleOut_out;
        private System.Windows.Forms.Label ConsoleOutout;
        private System.Windows.Forms.Button sendbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selected_encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areaAndPort;
    }
}