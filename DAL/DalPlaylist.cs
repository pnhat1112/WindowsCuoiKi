using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DalPlaylist:DBConnect
    {
        public DataTable getAll()
        {
            MySqlDataAdapter conn = new MySqlDataAdapter("SELECT * FROM playlist", _conn);
            DataTable datatb = new DataTable();
            conn.Fill(datatb);
            return datatb;
        }
        public int getSongId(string name)
        {
            MySqlDataAdapter conn = new MySqlDataAdapter($"SELECT song.id FROM `song` WHERE song.name = '{name}';", _conn);
            DataTable datatb = new DataTable();
            conn.Fill(datatb);
            return Convert.ToInt16(datatb.Rows[0][0].ToString());
        }
        public void addSongToPlaylist(string playlist_name,string song_name )
        {
            int id =  getSongId(song_name);
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO `playlist_songs` (`playlist_name`, `song_id`) VALUES('{playlist_name}', '{id}');\r\n", _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataTable getPlaylist(string name)
        {
            MySqlDataAdapter conn = new MySqlDataAdapter($"SELECT song.id, song.name, song.artist, song.path\r\nFROM song\r\nINNER JOIN playlist_songs ON playlist_songs.song_id=song.id\r\nWHERE playlist_songs.playlist_name = '{name}';", _conn);
            DataTable datatb = new DataTable();
            conn.Fill(datatb);
            return datatb;
        }
            public void removePlaylist(string name)
        {

            MySqlCommand cmd = new MySqlCommand($"DELETE FROM playlist WHERE playlist.name = '{name}';\r\n", _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void addPlaylist(string name)
        {

            MySqlCommand cmd = new MySqlCommand($"INSERT INTO `playlist` (`name`) VALUES('{name}');", _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
