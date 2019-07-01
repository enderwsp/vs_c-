namespace SimiliarTool
{
    partial class TcpClientForm
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
            this.target_IP_VAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.target_PORT_VAL = new System.Windows.Forms.TextBox();
            this.send_DATA_CTX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tcp_target_encode_select = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data_len_SET_VAL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.send_data_len_VAL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "target_IP";
            // 
            // target_IP_VAL
            // 
            this.target_IP_VAL.Location = new System.Drawing.Point(99, 17);
            this.target_IP_VAL.Name = "target_IP_VAL";
            this.target_IP_VAL.Size = new System.Drawing.Size(100, 21);
            this.target_IP_VAL.TabIndex = 1;
            this.target_IP_VAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "target_port";
            // 
            // target_PORT_VAL
            // 
            this.target_PORT_VAL.Location = new System.Drawing.Point(298, 17);
            this.target_PORT_VAL.Name = "target_PORT_VAL";
            this.target_PORT_VAL.Size = new System.Drawing.Size(50, 21);
            this.target_PORT_VAL.TabIndex = 3;
            this.target_PORT_VAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TargetPortValKeyPress);
            // 
            // send_DATA_CTX
            // 
            this.send_DATA_CTX.Location = new System.Drawing.Point(31, 70);
            this.send_DATA_CTX.Multiline = true;
            this.send_DATA_CTX.Name = "send_DATA_CTX";
            this.send_DATA_CTX.Size = new System.Drawing.Size(919, 173);
            this.send_DATA_CTX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "send_data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ConsoleOut_log";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 283);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(919, 303);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "send_request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "target_encoding";
            // 
            // tcp_target_encode_select
            // 
            this.tcp_target_encode_select.FormattingEnabled = true;
            this.tcp_target_encode_select.Items.AddRange(new object[] {
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
            this.tcp_target_encode_select.Location = new System.Drawing.Point(503, 18);
            this.tcp_target_encode_select.Name = "tcp_target_encode_select";
            this.tcp_target_encode_select.Size = new System.Drawing.Size(121, 20);
            this.tcp_target_encode_select.TabIndex = 10;
            this.tcp_target_encode_select.Text = "utf-8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "len_SIZE";
            // 
            // data_len_SET_VAL
            // 
            this.data_len_SET_VAL.Location = new System.Drawing.Point(298, 46);
            this.data_len_SET_VAL.MaxLength = 2;
            this.data_len_SET_VAL.Name = "data_len_SET_VAL";
            this.data_len_SET_VAL.Size = new System.Drawing.Size(50, 21);
            this.data_len_SET_VAL.TabIndex = 12;
            this.data_len_SET_VAL.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "length_Of_data";
            // 
            // send_data_len_VAL
            // 
            this.send_data_len_VAL.Location = new System.Drawing.Point(503, 46);
            this.send_data_len_VAL.MaxLength = 10;
            this.send_data_len_VAL.Name = "send_data_len_VAL";
            this.send_data_len_VAL.ReadOnly = true;
            this.send_data_len_VAL.Size = new System.Drawing.Size(121, 21);
            this.send_data_len_VAL.TabIndex = 14;
            this.send_data_len_VAL.Text = "6";
            this.send_data_len_VAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 598);
            this.Controls.Add(this.send_data_len_VAL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_len_SET_VAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tcp_target_encode_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send_DATA_CTX);
            this.Controls.Add(this.target_PORT_VAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.target_IP_VAL);
            this.Controls.Add(this.label1);
            this.Name = "TcpClient";
            this.Text = "TcpClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox target_IP_VAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox target_PORT_VAL;
        private System.Windows.Forms.TextBox send_DATA_CTX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tcp_target_encode_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox data_len_SET_VAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox send_data_len_VAL;
    }
}