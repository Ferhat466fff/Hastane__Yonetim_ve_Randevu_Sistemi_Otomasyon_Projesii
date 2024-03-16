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
    public partial class frmRandevu_Listesi : Form
    {
        public frmRandevu_Listesi()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void frmRandevu_Listesi_Load(object sender, EventArgs e)
        {
            //Randevuları listeleme
            SqlCommand komut = new SqlCommand("Select * from TBL_randevular", bgl.bağlanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.bağlanti().Close();
           
        }
    }
}
