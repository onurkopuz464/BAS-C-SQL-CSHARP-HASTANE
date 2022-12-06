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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            //ADSOYAD
            Tc_sekreter.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Tc_sekreter.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Ad_Sekreter.Text = dr[1].ToString();
                Tc_sekreter.Text = dr[2].ToString();

            }
            bgl.baglanti().Close();

            //Branşları Datagiride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransad from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorlar listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //combobax aktarım brans
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                txt_branslar.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
            //combo doktor
            




        }

        private void kaydet_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", txt_tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", txt_saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", txt_branslar.Text);
            komutkaydet.Parameters.AddWithValue("@r4", txt_doktorlar.Text);
            komutkaydet.Parameters.AddWithValue("@r5", txt_tc.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");
        }

        private void txt_branslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_doktorlar.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txt_branslar.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                txt_doktorlar.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void duyuru_olustur_button_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@d1", duyuru_olustur_rich.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void doktor_paneli_Click(object sender, EventArgs e)
        {
            Frm_DoktorPaneli drp = new Frm_DoktorPaneli();
            drp.Show();
        }

        private void Brans_paneli_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
            
        }

        private void Randevu_paneli_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void Duzenle_randevu_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular dr = new FrmDuyurular();
            dr.Show();
        }
    }
}
