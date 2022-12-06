﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void UyeOl_Button_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", UyeAd_Text.Text);
            komut.Parameters.AddWithValue("@p2", UyeSoyad_Text.Text);
            komut.Parameters.AddWithValue("@p3", UyeTC_Text.Text);
            komut.Parameters.AddWithValue("@p4", Uyetel_Text.Text);
            komut.Parameters.AddWithValue("@p5", UyeSifre_Text.Text);
            komut.Parameters.AddWithValue("@p6", UyeCinsiyet_Text.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir.","Bilgi");
        }
    }
}
