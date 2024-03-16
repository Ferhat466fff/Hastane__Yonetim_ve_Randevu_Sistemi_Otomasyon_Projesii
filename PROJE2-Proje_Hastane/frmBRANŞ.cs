using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql küütphanesini tanımladık

namespace PROJE2_Proje_Hastane
{
    public partial class frmBRANŞ : Form
    {
        public frmBRANŞ()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        void Branş_Listele()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_branşlar  ", bgl.bağlanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmBRANŞ_Load(object sender, EventArgs e)
        {
            //Form Yüklendiğinde Branşlar Datagriedview'e gelsin
            Branş_Listele();
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            //Branş Ekleme
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_branşlar (BranşAd) values(@p1)  ", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Ekleme İşlemi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Branş_Listele();
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {   //Branş Silme
            SqlCommand komut = new SqlCommand("Delete from TBL_branşlar where Branşid=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Branş_Listele();
        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            //Branş GÜNCELLEME
            SqlCommand komut = new SqlCommand("UPDATE TBL_branşlar SET BranşAd=@p1 WHERE Branşid=@p2", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Branş_Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //Çift Tıklandığında Ekrana gelisn branşad-ıd
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//textbox metinini=datagrid'in satırına seçtiğim satırın indexini cells[0](kategorııd yi alıyo )stringe cevir 
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
