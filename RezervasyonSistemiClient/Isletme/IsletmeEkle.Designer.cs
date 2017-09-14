namespace RezervasyonSistemiClient.Isletme
{
    partial class IsletmeEkle
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
            this.isletmeIsmiText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isletmeNumarasiText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isletmeAciklamasiText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isletmeAdresiText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isletmeIsmiText
            // 
            this.isletmeIsmiText.Location = new System.Drawing.Point(38, 41);
            this.isletmeIsmiText.Name = "isletmeIsmiText";
            this.isletmeIsmiText.Size = new System.Drawing.Size(278, 20);
            this.isletmeIsmiText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşletme İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İşletme Numarası";
            // 
            // isletmeNumarasiText
            // 
            this.isletmeNumarasiText.Location = new System.Drawing.Point(347, 41);
            this.isletmeNumarasiText.Name = "isletmeNumarasiText";
            this.isletmeNumarasiText.Size = new System.Drawing.Size(278, 20);
            this.isletmeNumarasiText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşletme Açıklaması";
            // 
            // isletmeAciklamasiText
            // 
            this.isletmeAciklamasiText.Location = new System.Drawing.Point(38, 95);
            this.isletmeAciklamasiText.Multiline = true;
            this.isletmeAciklamasiText.Name = "isletmeAciklamasiText";
            this.isletmeAciklamasiText.Size = new System.Drawing.Size(278, 93);
            this.isletmeAciklamasiText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İşletme Adresi";
            // 
            // isletmeAdresiText
            // 
            this.isletmeAdresiText.Location = new System.Drawing.Point(347, 95);
            this.isletmeAdresiText.Multiline = true;
            this.isletmeAdresiText.Name = "isletmeAdresiText";
            this.isletmeAdresiText.Size = new System.Drawing.Size(278, 93);
            this.isletmeAdresiText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsletmeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isletmeAdresiText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isletmeAciklamasiText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isletmeNumarasiText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isletmeIsmiText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IsletmeEkle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşletme Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isletmeIsmiText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isletmeNumarasiText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isletmeAciklamasiText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isletmeAdresiText;
        private System.Windows.Forms.Button button1;
    }
}