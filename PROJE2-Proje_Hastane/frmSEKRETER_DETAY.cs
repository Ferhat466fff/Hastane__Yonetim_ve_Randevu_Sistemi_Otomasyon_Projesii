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
    public partial class frmSEKRETER_DETAY : Form
    {
        public frmSEKRETER_DETAY()
        {
            InitializeComponent();
        }
       public string TCnumara;
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void frmSEKRETER_DETAY_Load(object sender, EventArgs e)
        {    //labele tc cekme islemi sekreter girişe( fr.TCnumara = mskTC.Text;) yapmamız gerek 
            lblTC.Text = TCnumara;

            //label'a AD-Soyad Çekme işlemi (OLAY VALLAJİ ÇOK BASİT)
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from TBL_sekreter where SekreterTC=@p1", bgl.bağlanti());//Ad-Soyadı alacağız ama tcye göre
            komut.Parameters.AddWithValue("@p1", lblTC.Text);//p1=tc'ile eşledik
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAD_SOYAD.Text = dr[0].ToString();//labeladsoyada dr[0]daki değeri alacak(sekreterAdSoyad)
            }
            bgl.bağlanti().Close();

            //Datagriedview1'e branşları çekme
            SqlCommand komut2 = new SqlCommand("select BranşAd from TBL_branşlar", bgl.bağlanti());
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
             bgl.bağlanti().Close();


            //Doktorları Listeye AkTARMA(Datagriedview2)

            SqlCommand komut3 = new SqlCommand("select (DoktorAd+DoktorSoyad)as'Ad&Soyad',DoktorBranş from TBL_doktorlar", bgl.bağlanti());
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            bgl.bağlanti().Close();

            //Combabox'a branşları çekma
            SqlCommand komut4 = new SqlCommand("select BranşAd  from TBL_branşlar", bgl.bağlanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                cmbBRANŞ.Items.Add(dr4[0].ToString());
            }
            bgl.bağlanti().Close();


            


        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {   //Randevu Oluşturma

            SqlCommand komut = new SqlCommand("INSERT INTO TBL_randevular(RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor,HastaTC) values (@p1,@p2,@p3,@p4,@p5)", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", mskTARİH.Text);
            komut.Parameters.AddWithValue("@p2", mskSAAT.Text);
            komut.Parameters.AddWithValue("@p3", cmbBRANŞ.Text);
            komut.Parameters.AddWithValue("@p4",cmbDOKTOR.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void cmbBRANŞ_SelectedIndexChanged(object sender, EventArgs e)
        {    //BRANŞ SEÇİLDİKDEN SONRA DOKTORLARI DOKTOR COMBOBOX'UNA ÇEKME

            //öncelikle neden formloada yazmıyoruz diye düşünebilirsin combobox branş kısmına yazıyoruz cünkü seçecegimiz branşa göre doktor listelemesi gerek 
            cmbDOKTOR.Items.Clear();//branş sectıkden sonra doktorları temizlesin 
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_doktorlar where DoktorBranş=@p1", bgl.bağlanti());//branşa göre listeleyecek
            komut.Parameters.AddWithValue("@p1", cmbBRANŞ.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDOKTOR.Items.Add(dr[0] + " " + dr[1]);//dr[0]=ad dr[1]=soyad

            }
            bgl.bağlanti().Close();
        }

        private void btnDUYURU_OLUŞTUR_Click(object sender, EventArgs e)
        {    //Duyuru Oluşturma 

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular(Duyuru)values(@p1)", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", rchDUYURU.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnDOKTOR_PANELİ_Click(object sender, EventArgs e)
        {   //sekreter kısmında doktor paneline tıklatırsak doktara atsın
            frmDoktorPaneli fr = new frmDoktorPaneli();
            fr.Show();
        }

        private void btnBRANŞ_PANEL_Click(object sender, EventArgs e)
        {
            //BRANŞ Paneline atacak
            frmBRANŞ fr = new frmBRANŞ();
            fr.Show();
        }

        private void btnRANDEVU_LİSTESİ_Click(object sender, EventArgs e)
        {
            frmRandevu_Listesi fr = new frmRandevu_Listesi();
            fr.Show();
        }

        private void btnDUYURULAR_Click(object sender, EventArgs e)
        {
            frmDUYURULAR fr = new frmDUYURULAR();
            fr.Show();
        }
    }
}
