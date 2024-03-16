using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//sql sınııfı

namespace PROJE2_Proje_Hastane
{
    internal class SqlBağlantısı//project kısmından acıtıgmız sınıfımızın adı
    {
        public SqlConnection bağlanti()//methodumuzun adı bunu niye yapıyoz her defasında sql adresimizi yazmayalim diye method yazdık 
        {
            SqlConnection bağlan = new SqlConnection("Data source =SQLNCLIRDA11;Data Source=MONSTER;Integrated Security=SSPI;Initial Catalog=hastane_proje");
            bağlan.Open();
            return bağlan;
        }
    }
}
