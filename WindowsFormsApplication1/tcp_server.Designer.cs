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
            this.button1.Location = new System.Drawing.Point(688, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "startSERVER";
            this.button1.UseVisualStyleBackColor = true;
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
            // tcp_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 569);
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
    }
}