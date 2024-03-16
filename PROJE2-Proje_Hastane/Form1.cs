using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE2_Proje_Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHASTA_Giriş fr = new frmHASTA_Giriş();
            fr.Show();//hastanın üstüne tıklanırsa hasta giris sekmesine atacak
            this.Hide();//hasta butınuna tıklanırsa form1 kapanacak sadece o kalacak
        }

        private void btnDOKTOR_GİRİŞİ_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btnSEKRETER_GİRİŞİ_Click(object sender, EventArgs e)
        {

            frmSEKRETER_GİRİŞ fr = new frmSEKRETER_GİRİŞ();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
