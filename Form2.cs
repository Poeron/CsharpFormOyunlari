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

    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        public void BardakOyunu(int bardak)
        {
            Random random = new Random();
            int top = random.Next(1, 4);
            if (top == bardak)
            {
                label1.Text = "Tebrikler doğru bildin!!!";
            }
            else
            {
                label1.Text = "Yanlış, top "+(top).ToString()+". bardaktaydı.";
            }
            if (top == 1)
            {
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\toplu1.png");
                pictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak2.png");
                pictureBox3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak3.png");
            }
            else if (top == 2)
            {
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak1.png");
                pictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\toplu2.png");
                pictureBox3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak3.png");
            }
            else if (top == 3)
            {
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak1.png");
                pictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\bardak2.png");
                pictureBox3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"bardaklar\toplu3.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BardakOyunu(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BardakOyunu(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BardakOyunu(3);
        }

        private void a(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }
    }
}