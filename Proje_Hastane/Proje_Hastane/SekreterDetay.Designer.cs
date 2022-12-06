namespace Proje_Hastane
{
    partial class SekreterDetay
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
            this.Ad_Sekreter = new System.Windows.Forms.Label();
            this.Tc_sekreter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.duyuru_olustur_button = new System.Windows.Forms.Button();
            this.duyuru_olustur_rich = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kaydet_randevu = new System.Windows.Forms.Button();
            this.Duzenle_randevu = new System.Windows.Forms.Button();
            this.durum_check = new System.Windows.Forms.CheckBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Randevu_paneli = new System.Windows.Forms.Button();
            this.Brans_paneli = new System.Windows.Forms.Button();
            this.doktor_paneli = new System.Windows.Forms.Button();
            this.txt_branslar = new System.Windows.Forms.ComboBox();
            this.txt_doktorlar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ad_Sekreter);
            this.groupBox1.Controls.Add(this.Tc_sekreter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi";
            // 
            // Ad_Sekreter
            // 
            this.Ad_Sekreter.AutoSize = true;
            this.Ad_Sekreter.Location = new System.Drawing.Point(61, 47);
            this.Ad_Sekreter.Name = "Ad_Sekreter";
            this.Ad_Sekreter.Size = new System.Drawing.Size(31, 13);
            this.Ad_Sekreter.TabIndex = 4;
            this.Ad_Sekreter.Text = "--------";
            // 
            // Tc_sekreter
            // 
            this.Tc_sekreter.AutoSize = true;
            this.Tc_sekreter.Location = new System.Drawing.Point(61, 25);
            this.Tc_sekreter.Name = "Tc_sekreter";
            this.Tc_sekreter.Size = new System.Drawing.Size(31, 13);
            this.Tc_sekreter.TabIndex = 3;
            this.Tc_sekreter.Text = "--------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AdSoyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.duyuru_olustur_button);
            this.groupBox2.Controls.Add(this.duyuru_olustur_rich);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DuyuruOlustur";
            // 
            // duyuru_olustur_button
            // 
            this.duyuru_olustur_button.Location = new System.Drawing.Point(119, 100);
            this.duyuru_olustur_button.Name = "duyuru_olustur_button";
            this.duyuru_olustur_button.Size = new System.Drawing.Size(75, 23);
            this.duyuru_olustur_button.TabIndex = 1;
            this.duyuru_olustur_button.Text = "Olustur";
            this.duyuru_olustur_button.UseVisualStyleBackColor = true;
            this.duyuru_olustur_button.Click += new System.EventHandler(this.duyuru_olustur_button_Click);
            // 
            // duyuru_olustur_rich
            // 
            this.duyuru_olustur_rich.Location = new System.Drawing.Point(6, 19);
            this.duyuru_olustur_rich.Name = "duyuru_olustur_rich";
            this.duyuru_olustur_rich.Size = new System.Drawing.Size(188, 75);
            this.duyuru_olustur_rich.TabIndex = 0;
            this.duyuru_olustur_rich.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_doktorlar);
            this.groupBox3.Controls.Add(this.txt_branslar);
            this.groupBox3.Controls.Add(this.kaydet_randevu);
            this.groupBox3.Controls.Add(this.Duzenle_randevu);
            this.groupBox3.Controls.Add(this.durum_check);
            this.groupBox3.Controls.Add(this.txt_tc);
            this.groupBox3.Controls.Add(this.txt_saat);
            this.groupBox3.Controls.Add(this.txt_tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // kaydet_randevu
            // 
            this.kaydet_randevu.Location = new System.Drawing.Point(6, 191);
            this.kaydet_randevu.Name = "kaydet_randevu";
            this.kaydet_randevu.Size = new System.Drawing.Size(90, 23);
            this.kaydet_randevu.TabIndex = 15;
            this.kaydet_randevu.Text = "Kaydet";
            this.kaydet_randevu.UseVisualStyleBackColor = true;
            this.kaydet_randevu.Click += new System.EventHandler(this.kaydet_randevu_Click);
            // 
            // Duzenle_randevu
            // 
            this.Duzenle_randevu.Location = new System.Drawing.Point(102, 191);
            this.Duzenle_randevu.Name = "Duzenle_randevu";
            this.Duzenle_randevu.Size = new System.Drawing.Size(92, 23);
            this.Duzenle_randevu.TabIndex = 2;
            this.Duzenle_randevu.Text = "Duzenle";
            this.Duzenle_randevu.UseVisualStyleBackColor = true;
            this.Duzenle_randevu.Click += new System.EventHandler(this.Duzenle_randevu_Click);
            // 
            // durum_check
            // 
            this.durum_check.AutoSize = true;
            this.durum_check.Location = new System.Drawing.Point(55, 174);
            this.durum_check.Name = "durum_check";
            this.durum_check.Size = new System.Drawing.Size(57, 17);
            this.durum_check.TabIndex = 14;
            this.durum_check.Text = "Durum";
            this.durum_check.UseVisualStyleBackColor = true;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(55, 146);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(139, 20);
            this.txt_tc.TabIndex = 11;
            // 
            // txt_saat
            // 
            this.txt_saat.Location = new System.Drawing.Point(55, 68);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(139, 20);
            this.txt_saat.TabIndex = 8;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(55, 42);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(139, 20);
            this.txt_tarih.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(55, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(139, 20);
            this.txt_id.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doktor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Brans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(424, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(427, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 178);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 159);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.Randevu_paneli);
            this.groupBox6.Controls.Add(this.Brans_paneli);
            this.groupBox6.Controls.Add(this.doktor_paneli);
            this.groupBox6.Location = new System.Drawing.Point(12, 251);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(412, 85);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // Randevu_paneli
            // 
            this.Randevu_paneli.Location = new System.Drawing.Point(261, 19);
            this.Randevu_paneli.Name = "Randevu_paneli";
            this.Randevu_paneli.Size = new System.Drawing.Size(120, 23);
            this.Randevu_paneli.TabIndex = 18;
            this.Randevu_paneli.Text = "Randevu Listesi";
            this.Randevu_paneli.UseVisualStyleBackColor = true;
            this.Randevu_paneli.Click += new System.EventHandler(this.Randevu_paneli_Click);
            // 
            // Brans_paneli
            // 
            this.Brans_paneli.Location = new System.Drawing.Point(126, 19);
            this.Brans_paneli.Name = "Brans_paneli";
            this.Brans_paneli.Size = new System.Drawing.Size(125, 23);
            this.Brans_paneli.TabIndex = 17;
            this.Brans_paneli.Text = "Brans Paneli";
            this.Brans_paneli.UseVisualStyleBackColor = true;
            this.Brans_paneli.Click += new System.EventHandler(this.Brans_paneli_Click);
            // 
            // doktor_paneli
            // 
            this.doktor_paneli.Location = new System.Drawing.Point(6, 19);
            this.doktor_paneli.Name = "doktor_paneli";
            this.doktor_paneli.Size = new System.Drawing.Size(114, 23);
            this.doktor_paneli.TabIndex = 16;
            this.doktor_paneli.Text = "Doktor Paneli";
            this.doktor_paneli.UseVisualStyleBackColor = true;
            this.doktor_paneli.Click += new System.EventHandler(this.doktor_paneli_Click);
            // 
            // txt_branslar
            // 
            this.txt_branslar.FormattingEnabled = true;
            this.txt_branslar.Location = new System.Drawing.Point(55, 93);
            this.txt_branslar.Name = "txt_branslar";
            this.txt_branslar.Size = new System.Drawing.Size(139, 21);
            this.txt_branslar.TabIndex = 16;
            this.txt_branslar.SelectedIndexChanged += new System.EventHandler(this.txt_branslar_SelectedIndexChanged);
            // 
            // txt_doktorlar
            // 
            this.txt_doktorlar.FormattingEnabled = true;
            this.txt_doktorlar.Location = new System.Drawing.Point(55, 120);
            this.txt_doktorlar.Name = "txt_doktorlar";
            this.txt_doktorlar.Size = new System.Drawing.Size(139, 21);
            this.txt_doktorlar.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 341);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SekreterDetay";
            this.Text = "SekreterDetay";
            this.Load += new System.EventHandler(this.SekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Ad_Sekreter;
        private System.Windows.Forms.Label Tc_sekreter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button duyuru_olustur_button;
        private System.Windows.Forms.RichTextBox duyuru_olustur_rich;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kaydet_randevu;
        private System.Windows.Forms.Button Duzenle_randevu;
        private System.Windows.Forms.CheckBox durum_check;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Randevu_paneli;
        private System.Windows.Forms.Button Brans_paneli;
        private System.Windows.Forms.Button doktor_paneli;
        private System.Windows.Forms.ComboBox txt_doktorlar;
        private System.Windows.Forms.ComboBox txt_branslar;
        private System.Windows.Forms.Button button1;
    }
}