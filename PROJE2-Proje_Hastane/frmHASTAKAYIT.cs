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
    public partial class frmHASTAKAYIT : Form
    {
        public frmHASTAKAYIT()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();//sqlbağlantı sınıfı acmıstık simdi ordan veri cekmek icin bgl adında sınıf acıp cekecgiz
        private void btnKAYITYAP_Click(object sender, EventArgs e)
        {
          
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaŞifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.bağlanti());//sql kısımında ekledik
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTELEFON.Text);
            komut.Parameters.AddWithValue("@p5", txtŞİFRE.Text);
            komut.Parameters.AddWithValue("@p6", cmbCİNSİYET.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz :" + txtŞİFRE.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

           
        }
    }
}
