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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public int sayi, puan = 100;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void ClosingEvent(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            puan = 100;
            Random rndm = new Random();
            sayi = rndm.Next(1, 101);
            btnSayiUret.Visible = false;
            btnTahmin.Visible = true;
            textBox1.Visible = true;
            lblPuan.Visible = true;
            textBox1.Text = "";
            lblPuan.Text ="Puan = 100";
            label1.Text = "Sayıyı bulabilecek misin?(1-100)";
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text)>100||int.Parse(textBox1.Text)<=0)
                    MessageBox.Show("Lütfen 1 ile 100 arasında bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (int.Parse(textBox1.Text) == sayi)
                    {
                        label1.Text = "Tebrikler Sayıyı Buldun!";
                        btnTahmin.Visible = false;
                        textBox1.Visible = false;
                        btnSayiUret.Visible = true;
                    }
                    else if (int.Parse(textBox1.Text) >= sayi)
                    {
                        label1.Text = "Büyük bir sayı girdin.";
                        puan -= 10;
                    }
                    else
                    {
                        label1.Text = "Küçük bir sayı girdin.";
                        puan -= 10;
                    }
                    if (puan==0)
                    {
                        label1.Text = "Oyunu Kaybettin!";
                        btnTahmin.Visible = false;
                        textBox1.Visible = false;
                        btnSayiUret.Visible = true;
                    }
                    lblPuan.Text = "Puan = "+puan.ToString();
                    textBox1.Text="";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir sayı giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
