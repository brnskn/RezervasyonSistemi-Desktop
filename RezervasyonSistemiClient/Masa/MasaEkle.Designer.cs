namespace RezervasyonSistemiClient.Masa
{
    partial class MasaEkle
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
            this.isletmeCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.katCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masaIsmiText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masaNumarasiText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.masaNumarasiText)).BeginInit();
            this.SuspendLayout();
            // 
            // isletmeCombo
            // 
            this.isletmeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isletmeCombo.FormattingEnabled = true;
            this.isletmeCombo.Location = new System.Drawing.Point(32, 41);
            this.isletmeCombo.Name = "isletmeCombo";
            this.isletmeCombo.Size = new System.Drawing.Size(278, 21);
            this.isletmeCombo.TabIndex = 25;
            this.isletmeCombo.SelectedIndexChanged += new System.EventHandler(this.isletmeCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "İşletme";
            // 
            // katCombo
            // 
            this.katCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.katCombo.FormattingEnabled = true;
            this.katCombo.Location = new System.Drawing.Point(341, 41);
            this.katCombo.Name = "katCombo";
            this.katCombo.Size = new System.Drawing.Size(278, 21);
            this.katCombo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Masa İsmi";
            // 
            // masaIsmiText
            // 
            this.masaIsmiText.Location = new System.Drawing.Point(32, 90);
            this.masaIsmiText.Name = "masaIsmiText";
            this.masaIsmiText.Size = new System.Drawing.Size(278, 20);
            this.masaIsmiText.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Masa Numarası";
            // 
            // masaNumarasiText
            // 
            this.masaNumarasiText.Location = new System.Drawing.Point(341, 90);
            this.masaNumarasiText.Name = "masaNumarasiText";
            this.masaNumarasiText.Size = new System.Drawing.Size(278, 20);
            this.masaNumarasiText.TabIndex = 31;
            // 
            // MasaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 164);
            this.Controls.Add(this.masaNumarasiText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.masaIsmiText);
            this.Controls.Add(this.katCombo);
            this.Controls.Add(this.isletmeCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 203);
            this.MinimumSize = new System.Drawing.Size(681, 203);
            this.Name = "MasaEkle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.masaNumarasiText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox isletmeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox katCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox masaIsmiText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown masaNumarasiText;
    }
}