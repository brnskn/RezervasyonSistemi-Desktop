namespace RezervasyonSistemiClient.Isletme
{
    partial class Isletmelerim
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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.isletmeData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeData)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(385, 361);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(162, 52);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Düzenle";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(553, 361);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 52);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // isletmeData
            // 
            this.isletmeData.AllowUserToAddRows = false;
            this.isletmeData.AllowUserToDeleteRows = false;
            this.isletmeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.isletmeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isletmeData.Location = new System.Drawing.Point(0, 0);
            this.isletmeData.MultiSelect = false;
            this.isletmeData.Name = "isletmeData";
            this.isletmeData.ReadOnly = true;
            this.isletmeData.RowTemplate.ReadOnly = true;
            this.isletmeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.isletmeData.Size = new System.Drawing.Size(939, 355);
            this.isletmeData.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Isletmelerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isletmeData);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 462);
            this.MinimumSize = new System.Drawing.Size(955, 462);
            this.Name = "Isletmelerim";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşletme Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.isletmeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView isletmeData;
        private System.Windows.Forms.Button button1;
    }
}