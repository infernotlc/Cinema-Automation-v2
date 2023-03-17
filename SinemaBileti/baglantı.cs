using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinemaBileti
{
    class baglantı
    {
        public static SqlConnection conn;

        public void a1()
        {
            conn = new SqlConnection(@"Server=DESKTOP-AM9OJ92;Initial Catalog=Sinema_Bileti;Integrated Security=True");

            conn.Open();

        }
    }
}
//SQLEXPRESS;