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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //ad soyad
            Detay_Tc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Detay_Tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Detay_Ad.Text = dr[0].ToString();
                Detay_Soyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            //randevu geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları çekme
            SqlCommand komut2 = new SqlCommand ("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                Brans_Combo.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void Brans_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor_Combo.Text = " ";
            Doktor_Combo.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", Brans_Combo.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                Doktor_Combo.Items.Add(dr3[0] + " "+ dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void Doktor_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + Brans_Combo.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lbl_guncel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcno = Detay_Tc.Text;
            fr.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
