using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Market_Otomasyonu.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-F5TAIT6\\SQLEXPRESS;Initial Catalog=MarketSistemi;Integrated Security=True;TrustServerCertificate=True");
    public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State==System.Data.ConnectionState.Closed)
            {
                tempConnection.Open();//bağlantı kapalıysa aç
            }
            else
            {

            }

        }
    }
}
