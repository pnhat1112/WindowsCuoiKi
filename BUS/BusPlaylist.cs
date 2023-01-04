using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BusPlaylist
    {
        DalPlaylist dalsong = new DalPlaylist();

        public DataTable getAll()
        {
            DataTable a = dalsong.getAll();
            a.Columns.Remove("id");
            return a;
        }
        public DataTable getPlaylist(string name)
        {
            DataTable a = dalsong.getPlaylist(name);
            a.Columns.Remove("id");
            return a;
        }
        public void addPlaylist(string name)
        {
            dalsong.addPlaylist(name);
        }
        public void removePlaylist(string name)
        {
            dalsong.removePlaylist(name);
        }
        public void addSongToPlaylist(string playlist_name, string song_name)
        {
            dalsong.addSongToPlaylist(playlist_name, song_name);
        }
    }
}
