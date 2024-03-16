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

namespace PROJE2_Proje_Hastane
{
    public partial class frmDoktor_Bilgi_Düzenle : Form
    {
        public frmDoktor_Bilgi_Düzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void frmDoktor_Bilgi_Düzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;//Bilgi düzenleye tc yi tasıyoruz
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAD.Text = dr[1].ToString();
                txtSOYAD.Text = dr[2].ToString();
                cmbBRANŞ.Text = dr[3].ToString();
                txtŞİFRE.Text = dr[5].ToString();
            }
            bgl.bağlanti().Close();
           


        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            //Doktor bilgilerini Güncelleme

            try
            {
                SqlCommand komut = new SqlCommand("update TBL_doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorŞifre=@p4 where DoktorTC=@p5", bgl.bağlanti());
                komut.Parameters.AddWithValue("@p1", txtAD.Text);
                komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
                komut.Parameters.AddWithValue("@p3", cmbBRANŞ.Text);
                komut.Parameters.AddWithValue("@p4", txtŞİFRE.Text);
                komut.Parameters.AddWithValue("@p5", mskTC.Text);
                komut.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
