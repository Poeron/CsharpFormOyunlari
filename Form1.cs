using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdevim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.frm1 = this;
            frm2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.frm1 = this;
            frm4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.frm1 = this;
            frm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.frm1 = this;
            frm6.Show();
            this.Hide();
        }
    }
}
