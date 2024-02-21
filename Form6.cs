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
    public partial class Form6 : Form
    {
        public Form1 frm1;
        string path = AppDomain.CurrentDomain.BaseDirectory+@"dosyalar\AdamAsmacaPuan.txt";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string okunan = "";
            if (File.Exists(path))
            {
                okunan = File.ReadAllText(path);
                lblPuanTablosu.Text = okunan;
            }
            else
            {
                MessageBox.Show(path + "dosyası bulunamadı.");
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }
    }
}
