using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace GirisEkranı
{
    class sqlbaglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-094I7K9;Initial Catalog=HMI;Integrated Security=True");
            baglanti.Open();
            return baglanti;
    }
    
        
    }
}
