namespace WindowsFormsApplication1
{
    partial class http_server
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
            this.http_server_portVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.http_local_IP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.request_URL_VAL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Trans_ID_VAL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.console_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "http_server_Port";
            // 
            // http_server_portVal
            // 
            this.http_server_portVal.Location = new System.Drawing.Point(144, 19);
            this.http_server_portVal.MaxLength = 5;
            this.http_server_portVal.Name = "http_server_portVal";
            this.http_server_portVal.Size = new System.Drawing.Size(43, 21);
            this.http_server_portVal.TabIndex = 1;
            this.http_server_portVal.Text = "8091";
            this.http_server_portVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.http_server_portVal_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "http_server_ip";
            // 
            // http_local_IP
            // 
            this.http_local_IP.Location = new System.Drawing.Point(700, 20);
            this.http_local_IP.MaxLength = 24;
            this.http_local_IP.Name = "http_local_IP";
            this.http_local_IP.ReadOnly = true;
            this.http_local_IP.Size = new System.Drawing.Size(122, 21);
            this.http_local_IP.TabIndex = 3;
            this.http_local_IP.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "startServer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "request_url";
            // 
            // request_URL_VAL
            // 
            this.request_URL_VAL.Location = new System.Drawing.Point(113, 66);
            this.request_URL_VAL.MaxLength = 24;
            this.request_URL_VAL.Name = "request_URL_VAL";
            this.request_URL_VAL.ReadOnly = true;
            this.request_URL_VAL.Size = new System.Drawing.Size(571, 21);
            this.request_URL_VAL.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "console_log";
            // 
            // Trans_ID_VAL
            // 
            this.Trans_ID_VAL.Location = new System.Drawing.Point(486, 18);
            this.Trans_ID_VAL.MaxLength = 10;
            this.Trans_ID_VAL.Name = "Trans_ID_VAL";
            this.Trans_ID_VAL.Size = new System.Drawing.Size(75, 21);
            this.Trans_ID_VAL.TabIndex = 11;
            this.Trans_ID_VAL.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "trans_ID";
            // 
            // console_log
            // 
            this.console_log.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.console_log.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.console_log.Location = new System.Drawing.Point(113, 108);
            this.console_log.Multiline = true;
            this.console_log.Name = "console_log";
            this.console_log.ReadOnly = true;
            this.console_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.console_log.Size = new System.Drawing.Size(844, 432);
            this.console_log.TabIndex = 12;
            // 
            // http_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 552);
            this.Controls.Add(this.console_log);
            this.Controls.Add(this.Trans_ID_VAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.request_URL_VAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.http_local_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.http_server_portVal);
            this.Controls.Add(this.label1);
            this.Name = "http_server";
            this.Text = "http_server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.http_server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox http_server_portVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox http_local_IP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox request_URL_VAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Trans_ID_VAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox console_log;
    }
}