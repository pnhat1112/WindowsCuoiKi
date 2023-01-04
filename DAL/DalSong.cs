using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DalSong : DBConnect
    {
        public DataTable getAll()
        {
            MySqlDataAdapter conn = new MySqlDataAdapter("SELECT * FROM song", _conn);
            DataTable datatb = new DataTable();
            conn.Fill(datatb);
            return datatb;
        }
        public void saveSong(DataTable dt)
        {

            MySqlCommand cmd = new MySqlCommand($"TRUNCATE TABLE `final`.`song`", _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                string name = "";
                string artist = "";
                string path = "";
                try
                {
                    name = (string)row["name"];
                }
                catch
                {

                }
                try
                {
                    artist = (string)row["artist"];
                }
                catch
                {

                }
                try
                {
                    path = (string)row["path"];
                }
                catch
                {

                }

                cmd = new MySqlCommand($"INSERT INTO song(name, artist, path) VALUES('{name}','{artist}','{path}')", _conn);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
        }
    }
}
