namespace WindowsFormsApplication1
{
    partial class CodeRender
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
            this.plain_Text_inputs = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.openFileForLogo = new System.Windows.Forms.OpenFileDialog();
            this.img_width = new System.Windows.Forms.TextBox();
            this.img_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logo_File = new System.Windows.Forms.TextBox();
            this.encoder = new System.Windows.Forms.Button();
            this.save_img = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logo_MAX_width = new System.Windows.Forms.TextBox();
            this.logo_MAX_height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "plain_text";
            // 
            // plain_Text_inputs
            // 
            this.plain_Text_inputs.Location = new System.Drawing.Point(26, 40);
            this.plain_Text_inputs.Multiline = true;
            this.plain_Text_inputs.Name = "plain_Text_inputs";
            this.plain_Text_inputs.Size = new System.Drawing.Size(762, 59);
            this.plain_Text_inputs.TabIndex = 3;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(29, 130);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(59, 12);
            this.width.TabIndex = 4;
            this.width.Text = "width[px]";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(217, 130);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(65, 12);
            this.height.TabIndex = 5;
            this.height.Text = "height[px]";
            // 
            // openFileForLogo
            // 
            this.openFileForLogo.FileName = "openFileForLogo";
            this.openFileForLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileForLogo_FileOk);
            // 
            // img_width
            // 
            this.img_width.Location = new System.Drawing.Point(103, 127);
            this.img_width.Name = "img_width";
            this.img_width.Size = new System.Drawing.Size(61, 21);
            this.img_width.TabIndex = 6;
            this.img_width.Text = "300";
            this.img_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // img_height
            // 
            this.img_height.Location = new System.Drawing.Point(288, 127);
            this.img_height.Name = "img_height";
            this.img_height.Size = new System.Drawing.Size(61, 21);
            this.img_height.TabIndex = 7;
            this.img_height.Text = "300";
            this.img_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "logoFIle";
            // 
            // logo_File
            // 
            this.logo_File.Location = new System.Drawing.Point(90, 185);
            this.logo_File.Name = "logo_File";
            this.logo_File.ReadOnly = true;
            this.logo_File.Size = new System.Drawing.Size(259, 21);
            this.logo_File.TabIndex = 9;
            this.logo_File.Text = "click me to pick one logo";
            this.logo_File.Click += new System.EventHandler(this.TextBox3_Click);
            // 
            // encoder
            // 
            this.encoder.Location = new System.Drawing.Point(154, 300);
            this.encoder.Name = "encoder";
            this.encoder.Size = new System.Drawing.Size(75, 23);
            this.encoder.TabIndex = 10;
            this.encoder.Text = "encoder";
            this.encoder.UseVisualStyleBackColor = true;
            this.encoder.Click += new System.EventHandler(this.Encoder_Click);
            // 
            // save_img
            // 
            this.save_img.Location = new System.Drawing.Point(154, 382);
            this.save_img.Name = "save_img";
            this.save_img.Size = new System.Drawing.Size(75, 23);
            this.save_img.TabIndex = 11;
            this.save_img.Text = "save_img";
            this.save_img.UseVisualStyleBackColor = true;
            this.save_img.Click += new System.EventHandler(this.Save_img_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "logo_MAX_w";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "logo_MAX_h";
            // 
            // logo_MAX_width
            // 
            this.logo_MAX_width.Location = new System.Drawing.Point(103, 237);
            this.logo_MAX_width.Name = "logo_MAX_width";
            this.logo_MAX_width.Size = new System.Drawing.Size(61, 21);
            this.logo_MAX_width.TabIndex = 14;
            this.logo_MAX_width.Text = "50";
            this.logo_MAX_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // logo_MAX_height
            // 
            this.logo_MAX_height.Location = new System.Drawing.Point(288, 237);
            this.logo_MAX_height.Name = "logo_MAX_height";
            this.logo_MAX_height.Size = new System.Drawing.Size(61, 21);
            this.logo_MAX_height.TabIndex = 15;
            this.logo_MAX_height.Text = "50";
            this.logo_MAX_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // CodeRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.logo_MAX_height);
            this.Controls.Add(this.logo_MAX_width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_img);
            this.Controls.Add(this.encoder);
            this.Controls.Add(this.logo_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_height);
            this.Controls.Add(this.img_width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.plain_Text_inputs);
            this.Controls.Add(this.label1);
            this.Name = "CodeRender";
            this.Text = "CodeRender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plain_Text_inputs;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.OpenFileDialog openFileForLogo;
        private System.Windows.Forms.TextBox img_width;
        private System.Windows.Forms.TextBox img_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logo_File;
        private System.Windows.Forms.Button encoder;
        private System.Windows.Forms.Button save_img;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox logo_MAX_width;
        private System.Windows.Forms.TextBox logo_MAX_height;
    }
}