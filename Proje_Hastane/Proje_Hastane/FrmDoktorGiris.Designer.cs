namespace Proje_Hastane
{
    partial class FrmDoktorGiris
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
            this.Giris_Button = new System.Windows.Forms.Button();
            this.Tc_Text = new System.Windows.Forms.TextBox();
            this.Sifre_Text = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Giris_Button
            // 
            this.Giris_Button.Location = new System.Drawing.Point(77, 101);
            this.Giris_Button.Name = "Giris_Button";
            this.Giris_Button.Size = new System.Drawing.Size(75, 23);
            this.Giris_Button.TabIndex = 11;
            this.Giris_Button.Text = "Giris";
            this.Giris_Button.UseVisualStyleBackColor = true;
            // 
            // Tc_Text
            // 
            this.Tc_Text.Location = new System.Drawing.Point(52, 75);
            this.Tc_Text.Name = "Tc_Text";
            this.Tc_Text.Size = new System.Drawing.Size(100, 20);
            this.Tc_Text.TabIndex = 10;
            // 
            // Sifre_Text
            // 
            this.Sifre_Text.Location = new System.Drawing.Point(52, 45);
            this.Sifre_Text.Mask = "00000000000";
            this.Sifre_Text.Name = "Sifre_Text";
            this.Sifre_Text.Size = new System.Drawing.Size(100, 20);
            this.Sifre_Text.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doktor Giris Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 135);
            this.Controls.Add(this.Giris_Button);
            this.Controls.Add(this.Tc_Text);
            this.Controls.Add(this.Sifre_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoktorGiris";
            this.Text = "FrmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Giris_Button;
        private System.Windows.Forms.TextBox Tc_Text;
        private System.Windows.Forms.MaskedTextBox Sifre_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}