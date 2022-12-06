namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            this.Detay_Soyad = new System.Windows.Forms.Label();
            this.Detay_Ad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Detay_Tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_guncel = new System.Windows.Forms.LinkLabel();
            this.Detay_button = new System.Windows.Forms.Button();
            this.Doktor_Combo = new System.Windows.Forms.ComboBox();
            this.Sikayet_rich = new System.Windows.Forms.RichTextBox();
            this.Brans_Combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Detay_Soyad);
            this.groupBox1.Controls.Add(this.Detay_Ad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Detay_Tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detay";
            // 
            // Detay_Soyad
            // 
            this.Detay_Soyad.AutoSize = true;
            this.Detay_Soyad.Location = new System.Drawing.Point(55, 73);
            this.Detay_Soyad.Name = "Detay_Soyad";
            this.Detay_Soyad.Size = new System.Drawing.Size(28, 13);
            this.Detay_Soyad.TabIndex = 5;
            this.Detay_Soyad.Text = "-------";
            // 
            // Detay_Ad
            // 
            this.Detay_Ad.AutoSize = true;
            this.Detay_Ad.Location = new System.Drawing.Point(55, 50);
            this.Detay_Ad.Name = "Detay_Ad";
            this.Detay_Ad.Size = new System.Drawing.Size(28, 13);
            this.Detay_Ad.TabIndex = 4;
            this.Detay_Ad.Text = "-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // Detay_Tc
            // 
            this.Detay_Tc.AutoSize = true;
            this.Detay_Tc.Location = new System.Drawing.Point(55, 28);
            this.Detay_Tc.Name = "Detay_Tc";
            this.Detay_Tc.Size = new System.Drawing.Size(28, 13);
            this.Detay_Tc.TabIndex = 1;
            this.Detay_Tc.Text = "-------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_guncel);
            this.groupBox2.Controls.Add(this.Detay_button);
            this.groupBox2.Controls.Add(this.Doktor_Combo);
            this.groupBox2.Controls.Add(this.Sikayet_rich);
            this.groupBox2.Controls.Add(this.Brans_Combo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(55, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(121, 20);
            this.id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "id";
            // 
            // lbl_guncel
            // 
            this.lbl_guncel.AutoSize = true;
            this.lbl_guncel.Location = new System.Drawing.Point(6, 148);
            this.lbl_guncel.Name = "lbl_guncel";
            this.lbl_guncel.Size = new System.Drawing.Size(69, 13);
            this.lbl_guncel.TabIndex = 9;
            this.lbl_guncel.TabStop = true;
            this.lbl_guncel.Text = "Bilgi güncelle";
            this.lbl_guncel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_guncel_LinkClicked);
            // 
            // Detay_button
            // 
            this.Detay_button.Location = new System.Drawing.Point(104, 141);
            this.Detay_button.Name = "Detay_button";
            this.Detay_button.Size = new System.Drawing.Size(75, 23);
            this.Detay_button.TabIndex = 8;
            this.Detay_button.Text = "Randevu Al";
            this.Detay_button.UseVisualStyleBackColor = true;
            // 
            // Doktor_Combo
            // 
            this.Doktor_Combo.FormattingEnabled = true;
            this.Doktor_Combo.Location = new System.Drawing.Point(55, 70);
            this.Doktor_Combo.Name = "Doktor_Combo";
            this.Doktor_Combo.Size = new System.Drawing.Size(121, 21);
            this.Doktor_Combo.TabIndex = 7;
            this.Doktor_Combo.SelectedIndexChanged += new System.EventHandler(this.Doktor_Combo_SelectedIndexChanged);
            // 
            // Sikayet_rich
            // 
            this.Sikayet_rich.Location = new System.Drawing.Point(58, 97);
            this.Sikayet_rich.Name = "Sikayet_rich";
            this.Sikayet_rich.Size = new System.Drawing.Size(121, 38);
            this.Sikayet_rich.TabIndex = 7;
            this.Sikayet_rich.Text = "";
            // 
            // Brans_Combo
            // 
            this.Brans_Combo.FormattingEnabled = true;
            this.Brans_Combo.Location = new System.Drawing.Point(55, 43);
            this.Brans_Combo.Name = "Brans_Combo";
            this.Brans_Combo.Size = new System.Drawing.Size(121, 21);
            this.Brans_Combo.TabIndex = 6;
            this.Brans_Combo.SelectedIndexChanged += new System.EventHandler(this.Brans_Combo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doktor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Şikayet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Branş";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(220, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 139);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 120);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(220, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 132);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(320, 113);
            this.dataGridView2.TabIndex = 6;
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 297);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Detay_Soyad;
        private System.Windows.Forms.Label Detay_Ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Detay_Tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Detay_button;
        private System.Windows.Forms.ComboBox Doktor_Combo;
        private System.Windows.Forms.RichTextBox Sikayet_rich;
        private System.Windows.Forms.ComboBox Brans_Combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lbl_guncel;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
    }
}