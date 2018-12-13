namespace WindowsFormsApplication1
{
    partial class tcp_client
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
            this.target_IP_VAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.target_PORT_VAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_PORT_VAL_KeyPress);
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
            this.label4.Text = "console_log";
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
            this.tcp_target_encode_select.Items.AddRange(Constant.encodingType);
            this.tcp_target_encode_select.Location = new System.Drawing.Point(503, 18);
            this.tcp_target_encode_select.Name = "tcp_target_encode_select";
            this.tcp_target_encode_select.Size = new System.Drawing.Size(121, 20);
            this.tcp_target_encode_select.TabIndex = 10;
            // 
            // tcp_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 598);
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
            this.Name = "tcp_client";
            this.Text = "tcp_client";
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
    }
}