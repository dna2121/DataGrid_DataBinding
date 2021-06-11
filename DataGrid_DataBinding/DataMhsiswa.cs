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
    public partial class DataMhsiswa : Form
    {
        public DataMhsiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            this.Hide();
            dgv.Show();
        }
    }
}
