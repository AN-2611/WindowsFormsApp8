namespace WindowsFormsApp8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cbxFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbxSize = new System.Windows.Forms.ToolStripComboBox();
            this.indam = new System.Windows.Forms.ToolStripButton();
            this.innghien_ = new System.Windows.Forms.ToolStripButton();
            this.gachchan_ = new System.Windows.Forms.ToolStripButton();
            this.tạoVănBảngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.dinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảngMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dinhDang
            // 
            this.dinhDang.Name = "dinhDang";
            this.dinhDang.Size = new System.Drawing.Size(94, 24);
            this.dinhDang.Text = "Định Dạng";
            this.dinhDang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cbxFont,
            this.cbxSize,
            this.indam,
            this.innghien_,
            this.gachchan_});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // cbxFont
            // 
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 28);
            this.cbxFont.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(121, 28);
            // 
            // indam
            // 
            this.indam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indam.Image = ((System.Drawing.Image)(resources.GetObject("indam.Image")));
            this.indam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indam.Name = "indam";
            this.indam.Size = new System.Drawing.Size(29, 25);
            this.indam.Text = "toolStripButton3";
            this.indam.Click += new System.EventHandler(this.indam_Click_1);
            // 
            // innghien_
            // 
            this.innghien_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.innghien_.Image = ((System.Drawing.Image)(resources.GetObject("innghien_.Image")));
            this.innghien_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.innghien_.Name = "innghien_";
            this.innghien_.Size = new System.Drawing.Size(29, 25);
            this.innghien_.Text = "toolStripButton4";
            this.innghien_.Click += new System.EventHandler(this.innghien__Click);
            // 
            // gachchan_
            // 
            this.gachchan_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gachchan_.Image = ((System.Drawing.Image)(resources.GetObject("gachchan_.Image")));
            this.gachchan_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gachchan_.Name = "gachchan_";
            this.gachchan_.Size = new System.Drawing.Size(29, 25);
            this.gachchan_.Text = "toolStripButton5";
            this.gachchan_.Click += new System.EventHandler(this.gachchan__Click_1);
            // 
            // tạoVănBảngMớiToolStripMenuItem
            // 
            this.tạoVănBảngMớiToolStripMenuItem.Name = "tạoVănBảngMớiToolStripMenuItem";
            this.tạoVănBảngMớiToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tạoVănBảngMớiToolStripMenuItem.Text = "tạo văn bảng mới";
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.mởTậpTinToolStripMenuItem.Text = "mở tập tin ";
            // 
            // lưuVănBảnToolStripMenuItem
            // 
            this.lưuVănBảnToolStripMenuItem.Name = "lưuVănBảnToolStripMenuItem";
            this.lưuVănBảnToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.lưuVănBảnToolStripMenuItem.Text = "lưu nội dung văn bản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.thoátToolStripMenuItem.Text = "thoát ";
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 59);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(707, 339);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cbxFont;
        private System.Windows.Forms.ToolStripComboBox cbxSize;
        private System.Windows.Forms.ToolStripButton indam;
        private System.Windows.Forms.ToolStripButton innghien_;
        private System.Windows.Forms.ToolStripButton gachchan_;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richText;
    }
}

