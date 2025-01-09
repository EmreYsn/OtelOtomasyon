using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtelOtomasyonu.DataAccessLayer
{
    public class Connection
    {
        public MySqlConnection connectionGet()
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.253;Database=25_132330017;User=25_132330017;Password=!nif.ogr17KA;");
            connection.Open();
            return connection;
        }
    }
}
