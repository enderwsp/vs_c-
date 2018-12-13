using System.Text;

namespace WindowsFormsApplication1
{
    partial class http_client
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
            this.console_out = new System.Windows.Forms.TextBox();
            this.consoleout = new System.Windows.Forms.Label();
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
            this.url_com.TextChanged += new System.EventHandler(this.url_com_TextChanged);
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
            this.vartrs_url.TextChanged += new System.EventHandler(this.vartrs_url_TextChanged);
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
            this.dataType_select.Items.AddRange(Constant.httpdataType);
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
            // console_out
            // 
            this.console_out.BackColor = System.Drawing.SystemColors.HotTrack;
            this.console_out.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.console_out.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.console_out.Location = new System.Drawing.Point(35, 436);
            this.console_out.Multiline = true;
            this.console_out.Name = "console_out";
            this.console_out.ReadOnly = true;
            this.console_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.console_out.Size = new System.Drawing.Size(663, 173);
            this.console_out.TabIndex = 11;
            this.console_out.Tag = "console_out";
            this.console_out.Text = "console_out_here";
            // 
            // consoleout
            // 
            this.consoleout.AutoSize = true;
            this.consoleout.Location = new System.Drawing.Point(33, 398);
            this.consoleout.Name = "consoleout";
            this.consoleout.Size = new System.Drawing.Size(65, 12);
            this.consoleout.TabIndex = 12;
            this.consoleout.Tag = "consoleout";
            this.consoleout.Text = "consoleout";
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
            this.sendbt.Click += new System.EventHandler(this.sendbt_Click);
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
            //this.selected_encode.Items.AddRange(similiar.encodingType);
            this.selected_encode.Items.AddRange(Constant.encodingType);
            this.selected_encode.Location = new System.Drawing.Point(140, 239);
            this.selected_encode.Name = "selected_encode";
            this.selected_encode.Size = new System.Drawing.Size(121, 20);
            this.selected_encode.Sorted = true;
            this.selected_encode.TabIndex = 15;
            this.selected_encode.Tag = "selected_encode";
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
            this.Controls.Add(this.consoleout);
            this.Controls.Add(this.console_out);
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
        private System.Windows.Forms.TextBox console_out;
        private System.Windows.Forms.Label consoleout;
        private System.Windows.Forms.Button sendbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selected_encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areaAndPort;
    }
}