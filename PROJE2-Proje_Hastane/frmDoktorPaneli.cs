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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE2_Proje_Hastane
{
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();

        void doktor_bilgilerini_listele()
        {   //doktor bilgilerini LİSTELEME
            SqlCommand komut = new SqlCommand("select * from TBL_doktorlar", bgl.bağlanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.bağlanti().Close();
        }

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            doktor_bilgilerini_listele();

            //Bramnşları comboboxa aktarma
            SqlCommand komut = new SqlCommand("select BranşAd from TBL_branşlar", bgl.bağlanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBRANŞ.Items.Add(dr[0]);//dr3[0]= BranşAd
            }
            bgl.bağlanti().Close();
           
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {   //Doktor Ekleme
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_doktorlar (DoktorAd,DoktorSoyad,DoktorBranş,DoktorTC,DoktorŞifre)values(@p1,@p2,@p3,@p4,@p5)", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", cmbBRANŞ.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtŞİFRE.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşti", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktor_bilgilerini_listele();//ekledikden sonra listelesin tekrar

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //Çift Tıklandığında bilgileri çekme 
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//textbox metinini=datagrid'in satırına seçtiğim satırın indexini cells[0](kategorııd yi alıyo )stringe cevir 
            txtSOYAD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbBRANŞ.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtŞİFRE.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        
        private void btnSİL_Click(object sender, EventArgs e)
        {   //SİLME
            SqlCommand komut = new SqlCommand("Delete from TBL_doktorlar where DoktorTC=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti","uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            doktor_bilgilerini_listele();//ekledikden sonra listelesin tekrar

        }
      
        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {   
            //GÜNCELLEME
            SqlCommand komut = new SqlCommand("UPDATE TBL_doktorlar SET DoktorAd=@p1, DoktorSoyad=@p2, DoktorBranş=@p3, DoktorŞifre=@p5 WHERE DoktorTC=@p4", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", cmbBRANŞ.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtŞİFRE.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktor_bilgilerini_listele();
            //ekledikden sonra listelesin tekrar
        }

     
    }
}
