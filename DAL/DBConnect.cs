using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected MySqlConnection _conn = new MySqlConnection("server=localhost;database=final;uid=root;pwd=");
    }
}
