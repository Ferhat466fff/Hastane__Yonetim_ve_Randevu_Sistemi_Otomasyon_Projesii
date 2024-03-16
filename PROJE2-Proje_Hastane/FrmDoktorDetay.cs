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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {   // Doktor bilgisini TC'ye göre çekme
            lblTC.Text = TC;

            // TC'ye göre Ad-Soyad Çekme
                
                SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_doktorlar where DoktorTC = @p1", bgl.bağlanti());
                komut.Parameters.AddWithValue("@p1", lblTC.Text);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                  lblAD_SOYAD.Text = dr[0] + " " + dr[1];
                }
            bgl.bağlanti().Close();

            SqlCommand komut2 = new SqlCommand("select * from TBL_randevular WHERE RandevuDoktor='"+lblAD_SOYAD.Text+"'", bgl.bağlanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.bağlanti().Close();




        }

        private void btnBilgi_Düzenle_Click(object sender, EventArgs e)
        {   //bilgi düzenleye tıklayınca düzenle formuna atsın
            frmDoktor_Bilgi_Düzenle fr = new frmDoktor_Bilgi_Düzenle();
            fr.TCno = lblTC.Text;//BİLGİDÜZENLE KISMANA TC Yİ TAŞIDIK
            fr.Show();

        }

        private void btnDUYURU_Click(object sender, EventArgs e)
        {   //duyuru butonu
            frmDUYURULAR fr = new frmDUYURULAR();
            fr.Show();
        }

        private void btnÇIKIŞ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Tek tıklamada Randevu detayı(şikayet) Görüntüleme
            int seçilen;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            rchŞİKAYET.Text = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();


        }

        private void FrmDoktorDetay_Load_1(object sender, EventArgs e)
        {

        }
    }
}
