using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Kontrol
{
    internal class connet
    {
        String connect = "Data Source=10.11.04.128;Initial Catalog=Stock;User ID=umut;Password=2408";
        public SqlConnection conn;


        public  connet() => conn = new SqlConnection(connect);
        public void connopen()=> conn.Open();

        public void connclose() => conn.Close();    
     



    }
}
