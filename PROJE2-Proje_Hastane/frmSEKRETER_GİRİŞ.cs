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
    public partial class frmSEKRETER_GİRİŞ : Form
    {
        public frmSEKRETER_GİRİŞ()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void btnGİRİŞYAP_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *  from TBL_sekreter where @p1=SekreterTC and @p2=SekreterŞifre ",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", mskŞİFRE.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmSEKRETER_DETAY fr = new frmSEKRETER_DETAY();
                fr.TCnumara = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı Adı&Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.bağlanti().Close();
            
        }
    }
}
