using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kelime_Oyunu
{
    internal class sqlconnection
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-K0C08G8;Initial Catalog=KelimeOyunu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
