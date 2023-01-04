using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BusSong
    {
        private DataTable save;
        public DataTable getAll()
        {
            DalSong dalsong = new DalSong();
            DataTable a = dalsong.getAll();
            a.Columns.Remove("id");
            return a;
        }

        public void saveSong(DataTable dt)
        {
            DalSong dalsong = new DalSong();
            dalsong.saveSong(dt);
        }
    }
}
