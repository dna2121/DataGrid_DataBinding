using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_DataBinding
{
    public partial class Menu : Form
    {
        public bool ceklis;
        public Menu()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //data binding
            DataBinding dbin = new DataBinding();
            this.Hide();
            dbin.Show();

        }

        private void gridv_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            this.Hide();
            dgv.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 fsatu = new Form1();

            if (ceklis == true)
            {
                fsatu.textBox1.Text = "denis";
                fsatu.textBox2.Text = "12345";
            }
            else
            {
                fsatu.textBox1.Text = "";
                fsatu.textBox2.Text = "";
            }
            fsatu.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
