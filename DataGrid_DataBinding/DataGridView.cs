﻿using System;
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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataMhsiswa dt = new DataMhsiswa();

            dt.NoMhs.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dt.Nama.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dt.Alamat.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt.Jeka.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dt.Nopon.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dt.Show();
            this.Hide();
        }
    }
}
