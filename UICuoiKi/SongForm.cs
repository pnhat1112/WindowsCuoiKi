using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICuoiKi
{
    public partial class SongForm : Form
    {
        public string name { get; set; }
        public string artist { get; set; }
        public string path { get; set; }

        public SongForm(string name, string artist, string path)
        {
            InitializeComponent();
            txt_name.Text = name;
            txt_artist.Text = artist;
            txt_path.Text = path;

        }
        public SongForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.name = txt_name.Text;
            this.artist = txt_artist.Text;
            this.path = txt_path.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
