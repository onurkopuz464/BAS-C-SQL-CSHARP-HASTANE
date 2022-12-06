using System;
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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tcno;
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            UyeTC_Text.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", UyeTC_Text.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                UyeAd_Text.Text = dr[1].ToString();
                UyeSoyad_Text.Text = dr[2].ToString();
                UyeTC_Text.Text = dr[3].ToString();
                Uyetel_Text.Text = dr[4].ToString();
                UyeCinsiyet_Text.Text = dr[5].ToString();
                UyeSifre_Text.Text = dr[6].ToString();
               
            }
            bgl.baglanti().Close();

        }

        private void guncelle_Button_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", UyeAd_Text.Text);
            komut2.Parameters.AddWithValue("@p2", UyeSoyad_Text.Text);
            komut2.Parameters.AddWithValue("@p3", Uyetel_Text.Text);
            komut2.Parameters.AddWithValue("@p4", UyeSifre_Text.Text);
            komut2.Parameters.AddWithValue("@p5", UyeCinsiyet_Text.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi...");
        }
    }
}
