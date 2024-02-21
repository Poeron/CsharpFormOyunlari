namespace FinalOdevim
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnHarf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHarfler = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnKelime = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnPuanKaydet = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBegin.Location = new System.Drawing.Point(308, 178);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(320, 111);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Oyunu Başlat!";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnHarf
            // 
            this.btnHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarf.Location = new System.Drawing.Point(21, 96);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(232, 76);
            this.btnHarf.TabIndex = 8;
            this.btnHarf.Text = "Harf Tahmini Yap";
            this.btnHarf.UseVisualStyleBackColor = true;
            this.btnHarf.Visible = false;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(155, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // lblHarfler
            // 
            this.lblHarfler.AutoSize = true;
            this.lblHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarfler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHarfler.Location = new System.Drawing.Point(31, 178);
            this.lblHarfler.Name = "lblHarfler";
            this.lblHarfler.Size = new System.Drawing.Size(0, 20);
            this.lblHarfler.TabIndex = 10;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKelime.Location = new System.Drawing.Point(31, 404);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 37);
            this.lblKelime.TabIndex = 11;
            // 
            // btnKelime
            // 
            this.btnKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelime.Location = new System.Drawing.Point(259, 96);
            this.btnKelime.Name = "btnKelime";
            this.btnKelime.Size = new System.Drawing.Size(232, 76);
            this.btnKelime.TabIndex = 8;
            this.btnKelime.Text = "Kelime Tahmini Yap";
            this.btnKelime.UseVisualStyleBackColor = true;
            this.btnKelime.Visible = false;
            this.btnKelime.Click += new System.EventHandler(this.btnKelime_Click);
            // 
            // txtNick
            // 
            this.txtNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNick.Location = new System.Drawing.Point(308, 146);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(157, 26);
            this.txtNick.TabIndex = 12;
            this.txtNick.Text = "Buraya adınızı yazın.";
            this.txtNick.Visible = false;
            this.txtNick.Click += new System.EventHandler(this.txtNick_Click);
            // 
            // btnPuanKaydet
            // 
            this.btnPuanKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuanKaydet.Location = new System.Drawing.Point(471, 146);
            this.btnPuanKaydet.Name = "btnPuanKaydet";
            this.btnPuanKaydet.Size = new System.Drawing.Size(157, 26);
            this.btnPuanKaydet.TabIndex = 13;
            this.btnPuanKaydet.Text = "Puanımı Kaydet!";
            this.btnPuanKaydet.UseVisualStyleBackColor = true;
            this.btnPuanKaydet.Visible = false;
            this.btnPuanKaydet.Click += new System.EventHandler(this.btnPuanKaydet_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(118, 41);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 14;
            // 
            // lblAgain
            // 
            this.lblAgain.AutoSize = true;
            this.lblAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgain.Location = new System.Drawing.Point(259, 93);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(453, 37);
            this.lblAgain.TabIndex = 15;
            this.lblAgain.Text = "Tekrar Oynamak İster Misin?";
            this.lblAgain.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPuanKaydet);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.lblHarfler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKelime);
            this.Controls.Add(this.btnHarf);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHarfler;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Button btnKelime;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnPuanKaydet;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAgain;
    }
}