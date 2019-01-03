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
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_show
            // 
            this.pic_show.Location = new System.Drawing.Point(26, 117);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(367, 310);
            this.pic_show.TabIndex = 0;
            this.pic_show.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "code_render";
            // 
            // plain_Text_inputs
            // 
            this.plain_Text_inputs.Location = new System.Drawing.Point(26, 40);
            this.plain_Text_inputs.Name = "plain_Text_inputs";
            this.plain_Text_inputs.Size = new System.Drawing.Size(762, 21);
            this.plain_Text_inputs.TabIndex = 3;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(465, 117);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(59, 12);
            this.width.TabIndex = 4;
            this.width.Text = "width[px]";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(653, 117);
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
            this.img_width.Location = new System.Drawing.Point(539, 114);
            this.img_width.Name = "img_width";
            this.img_width.Size = new System.Drawing.Size(61, 21);
            this.img_width.TabIndex = 6;
            this.img_width.Text = "300";
            this.img_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // img_height
            // 
            this.img_height.Location = new System.Drawing.Point(724, 114);
            this.img_height.Name = "img_height";
            this.img_height.Size = new System.Drawing.Size(61, 21);
            this.img_height.TabIndex = 7;
            this.img_height.Text = "300";
            this.img_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_numbers_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "logoFIle";
            // 
            // logo_File
            // 
            this.logo_File.Location = new System.Drawing.Point(526, 172);
            this.logo_File.Name = "logo_File";
            this.logo_File.ReadOnly = true;
            this.logo_File.Size = new System.Drawing.Size(259, 21);
            this.logo_File.TabIndex = 9;
            this.logo_File.Text = "click me to pick one logo";
            this.logo_File.Click += new System.EventHandler(this.TextBox3_Click);
            // 
            // encoder
            // 
            this.encoder.Location = new System.Drawing.Point(590, 287);
            this.encoder.Name = "encoder";
            this.encoder.Size = new System.Drawing.Size(75, 23);
            this.encoder.TabIndex = 10;
            this.encoder.Text = "encoder";
            this.encoder.UseVisualStyleBackColor = true;
            this.encoder.Click += new System.EventHandler(this.Encoder_Click);
            // 
            // save_img
            // 
            this.save_img.Location = new System.Drawing.Point(590, 369);
            this.save_img.Name = "save_img";
            this.save_img.Size = new System.Drawing.Size(75, 23);
            this.save_img.TabIndex = 11;
            this.save_img.Text = "save_img";
            this.save_img.UseVisualStyleBackColor = true;
            this.save_img.Click += new System.EventHandler(this.Save_img_Click);
            // 
            // CodeRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_img);
            this.Controls.Add(this.encoder);
            this.Controls.Add(this.logo_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_height);
            this.Controls.Add(this.img_width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.plain_Text_inputs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_show);
            this.Name = "CodeRender";
            this.Text = "CodeRender";
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}