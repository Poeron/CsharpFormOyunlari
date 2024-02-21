namespace FinalOdevim
{
    partial class Form3
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
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiUret.Location = new System.Drawing.Point(149, 87);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(230, 93);
            this.btnSayiUret.TabIndex = 0;
            this.btnSayiUret.Text = "Yeni sayı üret";
            this.btnSayiUret.UseVisualStyleBackColor = true;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 1;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(311, 115);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(153, 37);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "Tahmin Et!";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Visible = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuan.Location = new System.Drawing.Point(221, 183);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(0, 20);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 223);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSayiUret);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayiUret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPuan;
    }
}