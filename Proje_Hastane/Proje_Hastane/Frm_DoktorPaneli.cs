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
    public partial class Frm_DoktorPaneli : Form
    {
        public Frm_DoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //combo ekleme
            SqlCommand komut4 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p4", txt_tc.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutdelete = new SqlCommand("Delete From Tbl_Doktorlar where Doktor=@p1", bgl.baglanti());
            komutdelete.Parameters.AddWithValue("@p1", txt_tc);
            komutdelete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutupdate = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@u1,DoktorSoyad=@u2,DoktorBrans=@u3,DoktorSifre=@u4,DoktorTC=@u5 where DoktorTC=@u5", bgl.baglanti());
            komutupdate.Parameters.AddWithValue("@u1", txt_ad.Text);
            komutupdate.Parameters.AddWithValue("@u2", txt_soyad.Text);
            komutupdate.Parameters.AddWithValue("@u3", cmb_brans.Text);
            komutupdate.Parameters.AddWithValue("@u5", txt_tc.Text);
            komutupdate.Parameters.AddWithValue("@u4", txt_sifre.Text);
            komutupdate.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncellendi");
        }
    }
}
