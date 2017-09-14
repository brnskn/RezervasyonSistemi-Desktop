namespace RezervasyonSistemiClient.Masa
{
    partial class MasaListesi
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
            this.masaData = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.katCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.masaData)).BeginInit();
            this.SuspendLayout();
            // 
            // isletmeCombo
            // 
            this.isletmeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isletmeCombo.FormattingEnabled = true;
            this.isletmeCombo.Location = new System.Drawing.Point(40, 363);
            this.isletmeCombo.Name = "isletmeCombo";
            this.isletmeCombo.Size = new System.Drawing.Size(121, 21);
            this.isletmeCombo.TabIndex = 14;
            this.isletmeCombo.SelectedIndexChanged += new System.EventHandler(this.isletmeCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masaData
            // 
            this.masaData.AllowUserToAddRows = false;
            this.masaData.AllowUserToDeleteRows = false;
            this.masaData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.masaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masaData.Location = new System.Drawing.Point(0, 0);
            this.masaData.MultiSelect = false;
            this.masaData.Name = "masaData";
            this.masaData.ReadOnly = true;
            this.masaData.RowTemplate.ReadOnly = true;
            this.masaData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.masaData.Size = new System.Drawing.Size(939, 355);
            this.masaData.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(554, 363);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 52);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(386, 363);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(162, 52);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Düzenle";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // katCombo
            // 
            this.katCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.katCombo.FormattingEnabled = true;
            this.katCombo.Location = new System.Drawing.Point(40, 394);
            this.katCombo.Name = "katCombo";
            this.katCombo.Size = new System.Drawing.Size(121, 21);
            this.katCombo.TabIndex = 15;
            this.katCombo.SelectedIndexChanged += new System.EventHandler(this.katCombo_SelectedIndexChanged);
            // 
            // MasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 423);
            this.Controls.Add(this.katCombo);
            this.Controls.Add(this.isletmeCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.masaData);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 462);
            this.MinimumSize = new System.Drawing.Size(955, 462);
            this.Name = "MasaListesi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.masaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox isletmeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView masaData;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox katCombo;
    }
}