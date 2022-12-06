namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.Giris_Button = new System.Windows.Forms.Button();
            this.UyeOl_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(52, 33);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 20);
            this.tc.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(52, 63);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 4;
            // 
            // Giris_Button
            // 
            this.Giris_Button.Location = new System.Drawing.Point(77, 89);
            this.Giris_Button.Name = "Giris_Button";
            this.Giris_Button.Size = new System.Drawing.Size(75, 23);
            this.Giris_Button.TabIndex = 5;
            this.Giris_Button.Text = "Giris";
            this.Giris_Button.UseVisualStyleBackColor = true;
            this.Giris_Button.Click += new System.EventHandler(this.Giris_Button_Click);
            // 
            // UyeOl_label
            // 
            this.UyeOl_label.AutoSize = true;
            this.UyeOl_label.Location = new System.Drawing.Point(169, 33);
            this.UyeOl_label.Name = "UyeOl_label";
            this.UyeOl_label.Size = new System.Drawing.Size(39, 13);
            this.UyeOl_label.TabIndex = 6;
            this.UyeOl_label.TabStop = true;
            this.UyeOl_label.Text = "Üye Ol";
            this.UyeOl_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UyeOl_label_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 124);
            this.Controls.Add(this.UyeOl_label);
            this.Controls.Add(this.Giris_Button);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button Giris_Button;
        private System.Windows.Forms.LinkLabel UyeOl_label;
    }
}