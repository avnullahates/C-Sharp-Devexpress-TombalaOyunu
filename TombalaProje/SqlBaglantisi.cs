using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombalaProje
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FA6RBVRG;Initial Catalog=OyunTombala;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
