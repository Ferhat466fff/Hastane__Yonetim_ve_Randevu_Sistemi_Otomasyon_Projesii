using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE2_Proje_Hastane
{
    public partial class Bilgi_Güncelleme : Form
    {
        public Bilgi_Güncelleme()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        public string tcno;
        private void frmBİLGİ_DÜZENLE_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;
            SqlCommand komut = new SqlCommand("select* from TBL_hastalar where HastaTC=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAD.Text = dr[1].ToString();
                txtSOYAD.Text = dr[2].ToString();
                mskTELEFON.Text = dr[4].ToString();
                txtŞİFRE.Text = dr[5].ToString();
                cmbCİNSİYET.Text = dr[6].ToString();
                
            }
            bgl.bağlanti().Close();

        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_hastalar SET HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaŞifre=@p4, HastaCinsiyet=@p5 WHERE HastaTC=@p6", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", mskTELEFON.Text);
            komut.Parameters.AddWithValue("@p4", txtŞİFRE.Text);
            komut.Parameters.AddWithValue("@p5", cmbCİNSİYET.Text);
            komut.Parameters.AddWithValue("@p6", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();

            MessageBox.Show("Kişisel Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
