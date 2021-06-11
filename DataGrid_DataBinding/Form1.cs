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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Menu mn = new Menu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //EXIT button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LOGIN button
        private void button2_Click(object sender, EventArgs e)
        {
            //jika uname dan password blum diisi
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                //jika uname dan password bnr
                if(textBox1.Text == "denis" && textBox2.Text== "12345")
                {
                    Menu mn = new Menu();

                    //jika checkbox di centang
                    if (checkBox1.Checked == true)
                    {
                        mn.ceklis = true;
                    }
                    else
                    {
                        mn.ceklis = false;
                    }
                    this.Hide();
                    mn.Show();
                }
                else
                {
                    //jika uname atau password tidak sesuai
                    MessageBox.Show("Something wrong.");
                }
            }
            else
            {
                //uname dan pass kosong
                MessageBox.Show("Username and password cannot be empty");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
