﻿namespace WindowsFormsApplication1
{
    partial class similiar
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpclientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcpclientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcpserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.newToolStripMenuItem.Text = "new";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpclientToolStripMenuItem,
            this.tcpclientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.clientToolStripMenuItem.Text = "client";
            // 
            // httpclientToolStripMenuItem
            // 
            this.httpclientToolStripMenuItem.Name = "httpclientToolStripMenuItem";
            this.httpclientToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.httpclientToolStripMenuItem.Text = "http_client";
            this.httpclientToolStripMenuItem.Click += new System.EventHandler(this.httpclientToolStripMenuItem_Click);
            // 
            // tcpclientToolStripMenuItem
            // 
            this.tcpclientToolStripMenuItem.Name = "tcpclientToolStripMenuItem";
            this.tcpclientToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tcpclientToolStripMenuItem.Text = "tcp_client";
            this.tcpclientToolStripMenuItem.Click += new System.EventHandler(this.tcpclientToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpserverToolStripMenuItem,
            this.tcpserverToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.serverToolStripMenuItem.Text = "server";
            // 
            // httpserverToolStripMenuItem
            // 
            this.httpserverToolStripMenuItem.Name = "httpserverToolStripMenuItem";
            this.httpserverToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.httpserverToolStripMenuItem.Text = "http_server";
            this.httpserverToolStripMenuItem.Click += new System.EventHandler(this.httpserverToolStripMenuItem_Click);
            // 
            // tcpserverToolStripMenuItem
            // 
            this.tcpserverToolStripMenuItem.Name = "tcpserverToolStripMenuItem";
            this.tcpserverToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tcpserverToolStripMenuItem.Text = "tcp_server";
            this.tcpserverToolStripMenuItem.Click += new System.EventHandler(this.tcpserverToolStripMenuItem_Click);
            // 
            // similiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 211);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "similiar";
            this.Text = "similiar";
            this.Load += new System.EventHandler(this.similiar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpclientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcpclientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcpserverToolStripMenuItem;
    }
}

