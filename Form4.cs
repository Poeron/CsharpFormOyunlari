using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalOdevim
{
    public partial class Form4 : Form
    {
        public Form1 frm1;
        string pathKelime = AppDomain.CurrentDomain.BaseDirectory+@"dosyalar\AdamAsmacaKelimeleri.txt";
        string pathPuan = AppDomain.CurrentDomain.BaseDirectory+@"dosyalar\AdamAsmacaPuan.txt";
        string kelime;
        char[] yeniKelime;
        int yanlisSayisi, puan;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }

        string KelimeCek()
        {
            if (File.Exists(pathKelime))
            {
                Random rndm = new Random();
                int a = rndm.Next(1, 51);
                int sayi = 0;
                foreach (string satirmetni in File.ReadAllLines(pathKelime))
                {
                    sayi++;
                    if (sayi==a)
                    {
                        return satirmetni;
                    }
                }
            }
            else
                MessageBox.Show(pathKelime + "dosyası bulunamadı.");
            return "";
        }
        void AdamCiz()
        {
            switch (yanlisSayisi)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca (5).png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca (4).png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca (3).png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca (2).png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca (1).png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\adamasmaca.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"adamlar\full.png");
                    break;
                default:
                    break;
            }
        }
        void AdamAsmaca(char harf, string kelime, char[] yeniKelime)
        {
            lblHarfler.Text +=" "+ harf;
            bool bittiMi = true, degisim = false;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i]==harf)
                {
                    yeniKelime[i] = harf;
                    degisim = true;
                }
            }
            if (!degisim)
                yanlisSayisi++;
            lblKelime.Text = "Kelime = ";
            for (int i = 0; i < kelime.Length; i++)
                lblKelime.Text += yeniKelime[i]+" ";
            for (int i = 0; i < kelime.Length; i++)
            {
                if (yeniKelime[i]!=kelime[i])
                {
                    bittiMi = false;
                    break;
                }
            }
            if (yanlisSayisi==7)
            {
                lblKelime.Text = "Kelime = "+kelime;
                btnBegin.Visible = true;
                btnHarf.Visible = false;
                btnKelime.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Visible = false;
                lblAgain.Visible = true;
                lblInfo.Text = "";
            }
            if (bittiMi)
            {
                if (yanlisSayisi == 0)
                    yanlisSayisi = 1;
                puan = (2000 * kelime.Length) / yanlisSayisi;
                lblKelime.Text = "Tebrikler Kelimeyi Buldun.("+kelime+") Puanın : "+ puan.ToString();
                btnBegin.Visible = true;
                txtNick.Visible = true;
                btnPuanKaydet.Visible = true;
                btnHarf.Visible = false;
                btnKelime.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Visible = false;
                lblInfo.Text = "";
                lblHarfler.Text ="";
            }
            AdamCiz();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnBegin.Visible = false;
            btnHarf.Visible = true;
            btnKelime.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Visible = true;
            txtNick.Visible = false;
            btnPuanKaydet.Visible = false;
            lblAgain.Visible = false;

            lblInfo.Text ="Buraya bir harf veya kelime yazın.";
            textBox1.Text ="";
            lblHarfler.Text = "Kullanılan Harfler :\n";
            lblKelime.Text = "Kelime = ";
            yanlisSayisi = 0;
            puan=0;
            kelime = KelimeCek();
            yeniKelime = new char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
                yeniKelime[i] = '_';
            AdamCiz();
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            try
            {
                char harf = textBox1.Text[0];
                AdamAsmaca(harf, kelime, yeniKelime);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen harf tahmininizi yazın.");
            }
            
        }

        private void txtNick_Click(object sender, EventArgs e)
        {
            txtNick.Text ="";
        }

        private void btnPuanKaydet_Click(object sender, EventArgs e)
        {
            string nick = "";
            if (File.Exists(pathPuan))
            {
                nick = txtNick.Text;
                File.AppendAllText(pathPuan, nick+" "+puan+" puan\n");
                MessageBox.Show("Puanınız başarıyla kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnPuanKaydet.Visible=false;
                txtNick.Visible=false;
            }
            else
            {
                MessageBox.Show(pathPuan + "dosyası bulunamadı.");
            }
        }


        private void btnKelime_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text=="") MessageBox.Show("Lütfen tahmininizi yazın.");
                else
                {
                    if (kelime==textBox1.Text)
                    {
                        if (yanlisSayisi == 0)
                            yanlisSayisi = 1;
                        puan = (2000 * kelime.Length) / yanlisSayisi;
                        lblKelime.Text = "Tebrikler Kelimeyi Buldun.("+kelime+") Puanın : "+ puan.ToString();
                        btnBegin.Visible = true;
                        txtNick.Visible = true;
                        btnPuanKaydet.Visible = true;
                        btnHarf.Visible = false;
                        btnKelime.Visible = false;
                        textBox1.Visible = false;
                        pictureBox1.Visible = false;
                        lblInfo.Text = "";
                        lblHarfler.Text ="";
                    }
                    else
                    {
                        yanlisSayisi++;
                        AdamCiz();
                        if (yanlisSayisi==7)
                        {
                            lblKelime.Text = "Kelime = "+kelime;
                            btnBegin.Visible = true;
                            btnHarf.Visible = false;
                            btnKelime.Visible = false;
                            textBox1.Visible = false;
                            pictureBox1.Visible = false;
                            lblAgain.Visible = true;
                            lblInfo.Text = "";
                        }
                    }
                    textBox1.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tahmininizi yazın.");
            }
        }
    }
}
