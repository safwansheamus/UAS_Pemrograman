namespace UAS_OOP_1204037
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MhsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarUlangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarUlangToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarUlangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputMenuItem,
            this.viewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.transaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputMenuItem
            // 
            this.inputMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MhsMenuItem,
            this.ProdiMenuItem,
            this.exitMenu});
            this.inputMenuItem.Name = "inputMenuItem";
            this.inputMenuItem.Size = new System.Drawing.Size(57, 24);
            this.inputMenuItem.Text = "I&nput";
            // 
            // MhsMenuItem
            // 
            this.MhsMenuItem.Name = "MhsMenuItem";
            this.MhsMenuItem.Size = new System.Drawing.Size(177, 26);
            this.MhsMenuItem.Text = "Mahasiswa";
            this.MhsMenuItem.Click += new System.EventHandler(this.MhsMenuItem_Click);
            // 
            // ProdiMenuItem
            // 
            this.ProdiMenuItem.Name = "ProdiMenuItem";
            this.ProdiMenuItem.Size = new System.Drawing.Size(177, 26);
            this.ProdiMenuItem.Text = "Prodi";
            this.ProdiMenuItem.Click += new System.EventHandler(this.prodiToolStripMenuItem_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(177, 26);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programStudiToolStripMenuItem,
            this.prodiToolStripMenuItem,
            this.daftarUlangToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // programStudiToolStripMenuItem
            // 
            this.programStudiToolStripMenuItem.Name = "programStudiToolStripMenuItem";
            this.programStudiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.programStudiToolStripMenuItem.Text = "Mahasiswa";
            this.programStudiToolStripMenuItem.Click += new System.EventHandler(this.programStudiToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem,
            this.prodiToolStripMenuItem1,
            this.daftarUlangToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.updateToolStripMenuItem.Text = "&Update";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarUlangToolStripMenuItem2});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.transaksiToolStripMenuItem.Text = "&Transaksi";
            // 
            // prodiToolStripMenuItem
            // 
            this.prodiToolStripMenuItem.Name = "prodiToolStripMenuItem";
            this.prodiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prodiToolStripMenuItem.Text = "Prodi";
            this.prodiToolStripMenuItem.Click += new System.EventHandler(this.prodiToolStripMenuItem_Click_1);
            // 
            // daftarUlangToolStripMenuItem1
            // 
            this.daftarUlangToolStripMenuItem1.Name = "daftarUlangToolStripMenuItem1";
            this.daftarUlangToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.daftarUlangToolStripMenuItem1.Text = "Daftar Ulang";
            this.daftarUlangToolStripMenuItem1.Click += new System.EventHandler(this.daftarUlangToolStripMenuItem1_Click);
            // 
            // daftarUlangToolStripMenuItem2
            // 
            this.daftarUlangToolStripMenuItem2.Name = "daftarUlangToolStripMenuItem2";
            this.daftarUlangToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.daftarUlangToolStripMenuItem2.Text = "Daftar Ulang";
            this.daftarUlangToolStripMenuItem2.Click += new System.EventHandler(this.daftarUlangToolStripMenuItem2_Click);
            // 
            // mahasiswaToolStripMenuItem
            // 
            this.mahasiswaToolStripMenuItem.Name = "mahasiswaToolStripMenuItem";
            this.mahasiswaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mahasiswaToolStripMenuItem.Text = "Mahasiswa";
            this.mahasiswaToolStripMenuItem.Click += new System.EventHandler(this.mahasiswaToolStripMenuItem_Click);
            // 
            // prodiToolStripMenuItem1
            // 
            this.prodiToolStripMenuItem1.Name = "prodiToolStripMenuItem1";
            this.prodiToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.prodiToolStripMenuItem1.Text = "Prodi";
            this.prodiToolStripMenuItem1.Click += new System.EventHandler(this.prodiToolStripMenuItem1_Click);
            // 
            // daftarUlangToolStripMenuItem
            // 
            this.daftarUlangToolStripMenuItem.Name = "daftarUlangToolStripMenuItem";
            this.daftarUlangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.daftarUlangToolStripMenuItem.Text = "Daftar Ulang";
            this.daftarUlangToolStripMenuItem.Click += new System.EventHandler(this.daftarUlangToolStripMenuItem_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 412);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MhsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem programStudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarUlangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem daftarUlangToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem daftarUlangToolStripMenuItem;
    }
}

