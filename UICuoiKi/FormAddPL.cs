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
    public partial class FormAddPL : Form
    {
        public string name { get; set; }

        public FormAddPL()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = txt_name.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
