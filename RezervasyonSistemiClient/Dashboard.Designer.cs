namespace RezervasyonSistemiClient
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.isletmeCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işletmeBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işletmelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işletmeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katBilgisiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonTarihleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygunSaatlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaBilgileriList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.katBilgileriCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isletmeCombo
            // 
            this.isletmeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isletmeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isletmeCombo.FormattingEnabled = true;
            this.isletmeCombo.Location = new System.Drawing.Point(784, 1);
            this.isletmeCombo.Name = "isletmeCombo";
            this.isletmeCombo.Size = new System.Drawing.Size(121, 21);
            this.isletmeCombo.TabIndex = 1;
            this.isletmeCombo.SelectedIndexChanged += new System.EventHandler(this.isletmeCombo_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimToolStripMenuItem,
            this.işletmeBilgileriToolStripMenuItem,
            this.katBilgileriToolStripMenuItem,
            this.masaBilgileriToolStripMenuItem,
            this.rezervasyonTarihleriToolStripMenuItem,
            this.müşteriBilgileriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.profilimToolStripMenuItem.Text = "Profilim";
            this.profilimToolStripMenuItem.Click += new System.EventHandler(this.profilimToolStripMenuItem_Click);
            // 
            // işletmeBilgileriToolStripMenuItem
            // 
            this.işletmeBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işletmelerimToolStripMenuItem,
            this.işletmeEkleToolStripMenuItem});
            this.işletmeBilgileriToolStripMenuItem.Name = "işletmeBilgileriToolStripMenuItem";
            this.işletmeBilgileriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.işletmeBilgileriToolStripMenuItem.Text = "İşletme Bilgileri";
            // 
            // işletmelerimToolStripMenuItem
            // 
            this.işletmelerimToolStripMenuItem.Name = "işletmelerimToolStripMenuItem";
            this.işletmelerimToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.işletmelerimToolStripMenuItem.Text = "İşletme Listesi";
            this.işletmelerimToolStripMenuItem.Click += new System.EventHandler(this.işletmelerimToolStripMenuItem_Click);
            // 
            // işletmeEkleToolStripMenuItem
            // 
            this.işletmeEkleToolStripMenuItem.Name = "işletmeEkleToolStripMenuItem";
            this.işletmeEkleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.işletmeEkleToolStripMenuItem.Text = "İşletme Ekle";
            this.işletmeEkleToolStripMenuItem.Click += new System.EventHandler(this.işletmeEkleToolStripMenuItem_Click);
            // 
            // katBilgileriToolStripMenuItem
            // 
            this.katBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katListesiToolStripMenuItem,
            this.katBilgisiEkleToolStripMenuItem});
            this.katBilgileriToolStripMenuItem.Name = "katBilgileriToolStripMenuItem";
            this.katBilgileriToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.katBilgileriToolStripMenuItem.Text = "Kat Bilgileri";
            // 
            // katListesiToolStripMenuItem
            // 
            this.katListesiToolStripMenuItem.Name = "katListesiToolStripMenuItem";
            this.katListesiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.katListesiToolStripMenuItem.Text = "Kat Listesi";
            this.katListesiToolStripMenuItem.Click += new System.EventHandler(this.katListesiToolStripMenuItem_Click);
            // 
            // katBilgisiEkleToolStripMenuItem
            // 
            this.katBilgisiEkleToolStripMenuItem.Name = "katBilgisiEkleToolStripMenuItem";
            this.katBilgisiEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.katBilgisiEkleToolStripMenuItem.Text = "Kat Bilgisi Ekle";
            this.katBilgisiEkleToolStripMenuItem.Click += new System.EventHandler(this.katBilgisiEkleToolStripMenuItem_Click);
            // 
            // masaBilgileriToolStripMenuItem
            // 
            this.masaBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaListesiToolStripMenuItem,
            this.masaEkleToolStripMenuItem});
            this.masaBilgileriToolStripMenuItem.Name = "masaBilgileriToolStripMenuItem";
            this.masaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.masaBilgileriToolStripMenuItem.Text = "Masa Bilgileri";
            // 
            // masaListesiToolStripMenuItem
            // 
            this.masaListesiToolStripMenuItem.Name = "masaListesiToolStripMenuItem";
            this.masaListesiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.masaListesiToolStripMenuItem.Text = "Masa Listesi";
            this.masaListesiToolStripMenuItem.Click += new System.EventHandler(this.masaListesiToolStripMenuItem_Click);
            // 
            // masaEkleToolStripMenuItem
            // 
            this.masaEkleToolStripMenuItem.Name = "masaEkleToolStripMenuItem";
            this.masaEkleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.masaEkleToolStripMenuItem.Text = "Masa Ekle";
            this.masaEkleToolStripMenuItem.Click += new System.EventHandler(this.masaEkleToolStripMenuItem_Click);
            // 
            // rezervasyonTarihleriToolStripMenuItem
            // 
            this.rezervasyonTarihleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygunSaatlerToolStripMenuItem,
            this.taleplerToolStripMenuItem});
            this.rezervasyonTarihleriToolStripMenuItem.Name = "rezervasyonTarihleriToolStripMenuItem";
            this.rezervasyonTarihleriToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.rezervasyonTarihleriToolStripMenuItem.Text = "Rezervasyon Bilgileri";
            // 
            // uygunSaatlerToolStripMenuItem
            // 
            this.uygunSaatlerToolStripMenuItem.Name = "uygunSaatlerToolStripMenuItem";
            this.uygunSaatlerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.uygunSaatlerToolStripMenuItem.Text = "Planlar";
            this.uygunSaatlerToolStripMenuItem.Click += new System.EventHandler(this.uygunSaatlerToolStripMenuItem_Click);
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.taleplerToolStripMenuItem.Text = "Talepler";
            this.taleplerToolStripMenuItem.Click += new System.EventHandler(this.taleplerToolStripMenuItem_Click);
            // 
            // müşteriBilgileriToolStripMenuItem
            // 
            this.müşteriBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem});
            this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
            this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // masaBilgileriList
            // 
            this.masaBilgileriList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masaBilgileriList.LargeImageList = this.imageList1;
            this.masaBilgileriList.Location = new System.Drawing.Point(0, 24);
            this.masaBilgileriList.Name = "masaBilgileriList";
            this.masaBilgileriList.Size = new System.Drawing.Size(1034, 635);
            this.masaBilgileriList.TabIndex = 3;
            this.masaBilgileriList.UseCompatibleStateImageBehavior = false;
            this.masaBilgileriList.DoubleClick += new System.EventHandler(this.masaBilgileriList_DoubleClick);
            this.masaBilgileriList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.masaBilgileriList_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // katBilgileriCombo
            // 
            this.katBilgileriCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.katBilgileriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.katBilgileriCombo.FormattingEnabled = true;
            this.katBilgileriCombo.Location = new System.Drawing.Point(911, 1);
            this.katBilgileriCombo.Name = "katBilgileriCombo";
            this.katBilgileriCombo.Size = new System.Drawing.Size(121, 21);
            this.katBilgileriCombo.TabIndex = 4;
            this.katBilgileriCombo.SelectedIndexChanged += new System.EventHandler(this.katBilgileriCombo_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 659);
            this.Controls.Add(this.katBilgileriCombo);
            this.Controls.Add(this.masaBilgileriList);
            this.Controls.Add(this.isletmeCombo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1050, 698);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox isletmeCombo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işletmeBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işletmelerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işletmeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katBilgisiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonTarihleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygunSaatlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ListView masaBilgileriList;
        private System.Windows.Forms.ComboBox katBilgileriCombo;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
    }
}