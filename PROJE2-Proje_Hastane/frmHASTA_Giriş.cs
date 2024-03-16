using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql küütphanesini ekledik

namespace PROJE2_Proje_Hastane
{
    public partial class frmHASTA_Giriş : Form
    {
        public frmHASTA_Giriş()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void linkÜYEOL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHASTAKAYIT fr = new frmHASTAKAYIT();//üye ola tıklayınca hastakayıta atsın
            fr.Show();
        }
        private void btnGİRİŞYAP_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * FROM TBL_hastalar where HastaTC=@p1 and HastaŞifre=@p2", bgl.bağlanti());//sifre ve tc yi @p1,@p2 ye atatdık
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtŞİFRE.Text);
            SqlDataReader dr = komut.ExecuteReader();  //sqldatareder veri okuyucdur  dr yi okuyacak
            if(dr.Read())//dr doğru bir okuma işlemi yapıyorsa aşadakileri yapacak
            {
                frmHASTADETAY fr = new frmHASTADETAY();//hasta detay sayfasına at
                fr.tc = mskTC.Text;//hasta tcyi(mskTC.Text) girince hastadetayda tc diye tanımlama yaptık oraya atsın 
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//tc veya sifre yanlışsa else ye geclecek ve hata mesajı verileccek
            }
            bgl.bağlanti().Close();

            



        }
    }
}
