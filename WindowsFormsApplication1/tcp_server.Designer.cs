namespace WindowsFormsApplication1
{
    partial class tcp_server
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
            this.label1 = new System.Windows.Forms.Label();
            this.tcp_server_PORT_VAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.local_IP_VAL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsoleLogOUT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encode_select = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "tcp_server_port";
            // 
            // tcp_server_PORT_VAL
            // 
            this.tcp_server_PORT_VAL.Location = new System.Drawing.Point(129, 18);
            this.tcp_server_PORT_VAL.Name = "tcp_server_PORT_VAL";
            this.tcp_server_PORT_VAL.Size = new System.Drawing.Size(54, 21);
            this.tcp_server_PORT_VAL.TabIndex = 1;
            this.tcp_server_PORT_VAL.Text = "5188";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "serverIp";
            // 
            // local_IP_VAL
            // 
            this.local_IP_VAL.Location = new System.Drawing.Point(267, 18);
            this.local_IP_VAL.Name = "local_IP_VAL";
            this.local_IP_VAL.ReadOnly = true;
            this.local_IP_VAL.Size = new System.Drawing.Size(158, 21);
            this.local_IP_VAL.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "startSERVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "console_log";
            // 
            // ConsoleLogOUT
            // 
            this.ConsoleLogOUT.BackColor = System.Drawing.SystemColors.GrayText;
            this.ConsoleLogOUT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConsoleLogOUT.Location = new System.Drawing.Point(36, 93);
            this.ConsoleLogOUT.Multiline = true;
            this.ConsoleLogOUT.Name = "ConsoleLogOUT";
            this.ConsoleLogOUT.ReadOnly = true;
            this.ConsoleLogOUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleLogOUT.Size = new System.Drawing.Size(858, 433);
            this.ConsoleLogOUT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "encoding";
            // 
            // encode_select
            // 
            this.encode_select.FormattingEnabled = true;
            this.encode_select.Items.AddRange(new object[] {
            "big5",
            "Johab",
            "cp866",
            "cp875",
            "utf-7",
            "utf-8",
            "x-IA5",
            "EUC-CN",
            "EUC-JP",
            "IBM037",
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
            "IBM855",
            "IBM860",
            "IBM863",
            "IBM864",
            "IBM865",
            "IBM870",
            "IBM871",
            "IBM880",
            "IBM905",
            "cp1025",
            "euc-jp",
            "euc-kr",
            "gb2312",
            "ibm737",
            "ibm775",
            "ibm850",
            "ibm852",
            "ibm857",
            "ibm861",
            "ibm869",
            "koi8-r",
            "koi8-u",
            "utf-16",
            "utf-32",
            "DOS-720",
            "DOS-862",
            "GB18030",
            "IBM1026",
            "ASMO-708",
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
            "us-ascii",
            "utf-16BE",
            "utf-32BE",
            "x-Europa",
            "x-mac-ce",
            "macintosh",
            "shift_jis",
            "x-cp20001",
            "x-cp20003",
            "x-cp20004",
            "x-cp20005",
            "x-cp20261",
            "x-cp20269",
            "x-cp20936",
            "x-cp20949",
            "x-cp50227",
            "hz-gb-2312",
            "iso-8859-1",
            "iso-8859-2",
            "iso-8859-3",
            "iso-8859-4",
            "iso-8859-5",
            "iso-8859-6",
            "iso-8859-7",
            "iso-8859-8",
            "iso-8859-9",
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
            "x-mac-thai",
            "csISO2022JP",
            "iso-2022-jp",
            "iso-2022-jp",
            "iso-2022-kr",
            "iso-8859-13",
            "iso-8859-15",
            "windows-874",
            "x-mac-greek",
            "Windows-1252",
            "iso-8859-8-i",
            "windows-1250",
            "windows-1251",
            "windows-1253",
            "windows-1254",
            "windows-1255",
            "windows-1256",
            "windows-1257",
            "windows-1258",
            "x-IA5-German",
            "x-mac-arabic",
            "x-mac-hebrew",
            "x-mac-korean",
            "x-Chinese-CNS",
            "x-IA5-Swedish",
            "x-mac-turkish",
            "ks_c_5601-1987",
            "x-Chinese-Eten",
            "x-mac-croatian",
            "x-mac-cyrillic",
            "x-mac-japanese",
            "x-mac-romanian",
            "x-IA5-Norwegian",
            "x-mac-icelandic",
            "x-mac-ukrainian",
            "x-mac-chinesesimp",
            "x-mac-chinesetrad",
            "x-EBCDIC-KoreanExtended"});
            this.encode_select.Location = new System.Drawing.Point(490, 20);
            this.encode_select.Name = "encode_select";
            this.encode_select.Size = new System.Drawing.Size(121, 20);
            this.encode_select.TabIndex = 11;
            this.encode_select.Text = "utf-8";
            // 
            // tcp_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 569);
            this.Controls.Add(this.encode_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConsoleLogOUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.local_IP_VAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcp_server_PORT_VAL);
            this.Controls.Add(this.label1);
            this.Name = "tcp_server";
            this.Text = "tcp_server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcp_server_PORT_VAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox local_IP_VAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConsoleLogOUT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox encode_select;
    }
}