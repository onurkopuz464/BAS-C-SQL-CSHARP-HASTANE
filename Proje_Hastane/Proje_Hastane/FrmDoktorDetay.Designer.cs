namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.tc_label = new System.Windows.Forms.Label();
            this.ad_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soyad_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.sikayet_rich = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guncelle_bilgi = new System.Windows.Forms.Button();
            this.duyuru_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.soyad_label);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ad_label);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tc_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // tc_label
            // 
            this.tc_label.AutoSize = true;
            this.tc_label.Location = new System.Drawing.Point(55, 25);
            this.tc_label.Name = "tc_label";
            this.tc_label.Size = new System.Drawing.Size(34, 13);
            this.tc_label.TabIndex = 1;
            this.tc_label.Text = "---------";
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Location = new System.Drawing.Point(55, 48);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(34, 13);
            this.ad_label.TabIndex = 3;
            this.ad_label.Text = "---------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Soyad";
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Location = new System.Drawing.Point(55, 74);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(34, 13);
            this.soyad_label.TabIndex = 5;
            this.soyad_label.Text = "---------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sikayet_rich);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(218, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 299);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Şikayet";
            // 
            // sikayet_rich
            // 
            this.sikayet_rich.Location = new System.Drawing.Point(9, 53);
            this.sikayet_rich.Name = "sikayet_rich";
            this.sikayet_rich.Size = new System.Drawing.Size(167, 167);
            this.sikayet_rich.TabIndex = 7;
            this.sikayet_rich.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cikis_button);
            this.groupBox4.Controls.Add(this.duyuru_button);
            this.groupBox4.Controls.Add(this.guncelle_bilgi);
            this.groupBox4.Location = new System.Drawing.Point(221, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgi Güncelleme";
            // 
            // guncelle_bilgi
            // 
            this.guncelle_bilgi.Location = new System.Drawing.Point(6, 19);
            this.guncelle_bilgi.Name = "guncelle_bilgi";
            this.guncelle_bilgi.Size = new System.Drawing.Size(125, 23);
            this.guncelle_bilgi.TabIndex = 0;
            this.guncelle_bilgi.Text = "Bilgi Düzenle";
            this.guncelle_bilgi.UseVisualStyleBackColor = true;
            // 
            // duyuru_button
            // 
            this.duyuru_button.Location = new System.Drawing.Point(137, 19);
            this.duyuru_button.Name = "duyuru_button";
            this.duyuru_button.Size = new System.Drawing.Size(128, 23);
            this.duyuru_button.TabIndex = 1;
            this.duyuru_button.Text = "Duyurular";
            this.duyuru_button.UseVisualStyleBackColor = true;
            // 
            // cikis_button
            // 
            this.cikis_button.Location = new System.Drawing.Point(282, 19);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(140, 23);
            this.cikis_button.TabIndex = 2;
            this.cikis_button.Text = "Çıkış";
            this.cikis_button.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 367);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tc_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox sikayet_rich;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cikis_button;
        private System.Windows.Forms.Button duyuru_button;
        private System.Windows.Forms.Button guncelle_bilgi;
    }
}