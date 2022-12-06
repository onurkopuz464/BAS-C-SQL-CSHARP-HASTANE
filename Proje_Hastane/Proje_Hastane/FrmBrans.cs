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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_brans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutdelete = new SqlCommand("Delete From Tbl_Branslar where BransAd=@p1", bgl.baglanti());
            komutdelete.Parameters.AddWithValue("@p1", txt_brans);
            komutdelete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutupdate = new SqlCommand("Update Tbl_Branslar set DoktorAd=@u1,DoktorSoyad=@u2,DoktorBrans=@u3,DoktorSifre=@u4,DoktorTC=@u5 where DoktorTC=@u5", bgl.baglanti());
            komutupdate.Parameters.AddWithValue("@u1", txt_brans.Text);
            komutupdate.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncellendi");
        }
    }
}
