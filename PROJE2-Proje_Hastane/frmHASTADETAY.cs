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
    public partial class frmHASTADETAY : Form
    {
        public frmHASTADETAY()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void frmHASTADETAY_Load(object sender, EventArgs e)
        {
            //HASTA GİRİŞ PANELİNE GİRİLEN TC'SİNE GÖRE HASTADETAYA AD-SOYAD ÇEKME

            lblTC.Text = tc;//hasta giriş e bak ilk önce form acılınca hasta girişteki tc(msktc.text) bizim labelımıza aktarılsın
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad FROM TBL_hastalar where HastaTC=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAD_SOYAD.Text = dr[0] +" "+dr[1];//dr[0]=ad " "dr[1]=soyad
            }
            bgl.bağlanti().Close();


           

            //DATAGRİEDVİEWE RANDEVU GEÇMİŞİNİ ÇEKME
            SqlCommand komut2 = new SqlCommand("select * from TBL_randevular where HastaTC = '" + tc + "'", bgl.bağlanti());//randevuları listele şartımız hastatc=tc(hasta_giriş formundan tcsini giren kulanıcı)
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.bağlanti().Close();




            //sql kaydettiğimiz BRANŞLARI comboboxa ÇEKME
            SqlCommand komut3 = new SqlCommand("select BranşAd from TBL_branşlar", bgl.bağlanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBRANŞ.Items.Add(dr3[0]);//dr3[0]= BranşAd
            }
            bgl.bağlanti().Close();

        }

        private void cmbBRANŞ_SelectedIndexChanged(object sender, EventArgs e)
        {//BRANŞ Seçidikten sonra Doktorlar doktorcombobox'a gelsin
            cmbDOKTOR.Items.Clear();//burada sen göz seçtin diyelim doktorcomboboxın'da veli doktor geldi sonra burunu sectin doktorcomboboxın'da veli doktoru temizlemen gerek o yuzedn bu islemleri yaptık
            SqlCommand komut4 = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_doktorlar where DoktorBranş=@p1", bgl.bağlanti());//seçilen brans=@p1
            komut4.Parameters.AddWithValue("@p1", cmbBRANŞ.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                cmbDOKTOR.Items.Add(dr4[0] + " " + dr4[1]);//dr4[0]=ad + " " + dr4[1]=soyad
            }
            bgl.bağlanti().Close();



        }

        private void cmbDOKTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DOKTOR Seçildikten sonra (Branş ve doktor)'a ait randevular Aktif Randevulara eklenecek
            SqlCommand komut = new SqlCommand("select  * from TBL_randevular where RandevuBranş='" + cmbBRANŞ.Text + "'"+"and RandevuDoktor='"+cmbDOKTOR.Text+"'and RandevuDurum=0" ,bgl.bağlanti());//sqlde kelime bazlı arama yaptığımızda (')kullanmamız gerekiyor
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkBİLGİDÜZENLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Bilgileri düzeleyeceksek 
            Bilgi_Güncelleme fr = new Bilgi_Güncelleme();//bilgi düzenleyi açsın
            fr.tcno = lblTC.Text;//bilgi düzenleye strinf tcno tanımladık ve burada cagırdık 
            //artık bilgi düzenleye tıklayınca tc no maskelitextbox'da gorunceek
            fr.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //mause çift tıklama
            int seçilen;
            seçilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİD.Text = dataGridView2.Rows[seçilen].Cells[0].Value.ToString();
        }

        private void btnRANDEVU_AL_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_randevular set RandevuDurum=1,HastaTC=@p1,HastaŞikayet=@p2 where Randevuid=@p3", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rhcSİKATET.Text);
            komut.Parameters.AddWithValue("@p3", txtİD.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
