namespace similiar
{
    partial class ImgForm
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
            this.show_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // show_pic
            // 
            this.show_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_pic.Location = new System.Drawing.Point(12, 12);
            this.show_pic.Name = "show_pic";
            this.show_pic.Size = new System.Drawing.Size(776, 426);
            this.show_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.show_pic.TabIndex = 0;
            this.show_pic.TabStop = false;
            // 
            // ImgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_pic);
            this.Name = "ImgForm";
            this.Text = "ImgForm";
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox show_pic;
    }
}