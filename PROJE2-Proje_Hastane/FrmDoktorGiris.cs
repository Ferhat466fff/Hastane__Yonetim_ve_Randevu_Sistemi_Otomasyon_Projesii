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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void btnGİRİŞYAP_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("select * from TBL_doktorlar where DoktorTC=@p1 and DoktorŞifre=@p2", bgl.bağlanti());
                komut.Parameters.AddWithValue("@p1", mskTC.Text);
                komut.Parameters.AddWithValue("@p2", mskŞİFRE.Text);

                SqlDataReader dt = komut.ExecuteReader();
                if (dt.Read())
                {
                    FrmDoktorDetay fr = new FrmDoktorDetay();
                    fr.TC = mskTC.Text; // Doktor TC'sini aktar
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı adı&Şifre");
                }
            bgl.bağlanti().Close();

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
