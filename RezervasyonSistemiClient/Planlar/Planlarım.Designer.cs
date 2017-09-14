namespace RezervasyonSistemiClient.Planlar
{
    partial class Planlarım
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.planlarData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.planDetaylariData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bitisSaatiPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.baslangicSaatiPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.haftaninGunuCombo = new System.Windows.Forms.ComboBox();
            this.isletmeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planlarData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planDetaylariData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.planlarData);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planlar";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(217, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Aktifleştir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // planlarData
            // 
            this.planlarData.AllowUserToAddRows = false;
            this.planlarData.AllowUserToDeleteRows = false;
            this.planlarData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planlarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planlarData.Location = new System.Drawing.Point(6, 19);
            this.planlarData.MultiSelect = false;
            this.planlarData.Name = "planlarData";
            this.planlarData.ReadOnly = true;
            this.planlarData.RowTemplate.ReadOnly = true;
            this.planlarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.planlarData.Size = new System.Drawing.Size(286, 207);
            this.planlarData.TabIndex = 4;
            this.planlarData.SelectionChanged += new System.EventHandler(this.planlarData_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.planDetaylariData);
            this.groupBox2.Location = new System.Drawing.Point(308, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan Detayları";
            // 
            // planDetaylariData
            // 
            this.planDetaylariData.AllowUserToAddRows = false;
            this.planDetaylariData.AllowUserToDeleteRows = false;
            this.planDetaylariData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planDetaylariData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.planDetaylariData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planDetaylariData.Location = new System.Drawing.Point(6, 19);
            this.planDetaylariData.MultiSelect = false;
            this.planDetaylariData.Name = "planDetaylariData";
            this.planDetaylariData.ReadOnly = true;
            this.planDetaylariData.RowTemplate.ReadOnly = true;
            this.planDetaylariData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.planDetaylariData.Size = new System.Drawing.Size(341, 238);
            this.planDetaylariData.TabIndex = 5;
            this.planDetaylariData.SelectionChanged += new System.EventHandler(this.planDetaylariData_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bitisSaatiPicker);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.baslangicSaatiPicker);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.haftaninGunuCombo);
            this.groupBox3.Location = new System.Drawing.Point(667, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekle/Düzenle";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yeni Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bitiş Saati";
            // 
            // bitisSaatiPicker
            // 
            this.bitisSaatiPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bitisSaatiPicker.Location = new System.Drawing.Point(7, 154);
            this.bitisSaatiPicker.Name = "bitisSaatiPicker";
            this.bitisSaatiPicker.ShowUpDown = true;
            this.bitisSaatiPicker.Size = new System.Drawing.Size(233, 20);
            this.bitisSaatiPicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Başlangıç Saati";
            // 
            // baslangicSaatiPicker
            // 
            this.baslangicSaatiPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.baslangicSaatiPicker.Location = new System.Drawing.Point(6, 102);
            this.baslangicSaatiPicker.Name = "baslangicSaatiPicker";
            this.baslangicSaatiPicker.ShowUpDown = true;
            this.baslangicSaatiPicker.Size = new System.Drawing.Size(233, 20);
            this.baslangicSaatiPicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haftanın Günü";
            // 
            // haftaninGunuCombo
            // 
            this.haftaninGunuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.haftaninGunuCombo.FormattingEnabled = true;
            this.haftaninGunuCombo.Location = new System.Drawing.Point(7, 49);
            this.haftaninGunuCombo.Name = "haftaninGunuCombo";
            this.haftaninGunuCombo.Size = new System.Drawing.Size(233, 21);
            this.haftaninGunuCombo.TabIndex = 0;
            // 
            // isletmeCombo
            // 
            this.isletmeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isletmeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isletmeCombo.FormattingEnabled = true;
            this.isletmeCombo.Location = new System.Drawing.Point(793, 244);
            this.isletmeCombo.Name = "isletmeCombo";
            this.isletmeCombo.Size = new System.Drawing.Size(121, 21);
            this.isletmeCombo.TabIndex = 3;
            this.isletmeCombo.SelectedIndexChanged += new System.EventHandler(this.isletmeCombo_SelectedIndexChanged);
            // 
            // Planlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 269);
            this.Controls.Add(this.isletmeCombo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(935, 308);
            this.MinimumSize = new System.Drawing.Size(935, 308);
            this.Name = "Planlarım";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planlar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planlarData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planDetaylariData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView planlarData;
        private System.Windows.Forms.DataGridView planDetaylariData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bitisSaatiPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker baslangicSaatiPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox haftaninGunuCombo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox isletmeCombo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}