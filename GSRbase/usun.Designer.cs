
using System.Drawing;

namespace GSRbase
{
    partial class usun
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelprawydol = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeltolerancji = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uswaktolerancji = new System.Windows.Forms.TrackBar();
            this.przyciskkolor = new System.Windows.Forms.Button();
            this.przyciskusuntlo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.przyciskzapisz = new System.Windows.Forms.Button();
            this.przyciskotworz = new System.Windows.Forms.Button();
            this.przyciskreset = new System.Windows.Forms.Button();
            this.labeltytul = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelprawydol.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uswaktolerancji)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(335, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(335, 208);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(10, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(315, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "PO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(325, 208);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(10, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRZED";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelprawydol
            // 
            this.panelprawydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelprawydol.Controls.Add(this.panel4);
            this.panelprawydol.Controls.Add(this.panel1);
            this.panelprawydol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelprawydol.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelprawydol.Location = new System.Drawing.Point(20, 324);
            this.panelprawydol.Margin = new System.Windows.Forms.Padding(25);
            this.panelprawydol.Name = "panelprawydol";
            this.panelprawydol.Padding = new System.Windows.Forms.Padding(20);
            this.panelprawydol.Size = new System.Drawing.Size(670, 196);
            this.panelprawydol.TabIndex = 6;
            this.panelprawydol.SizeChanged += new System.EventHandler(this.panelprawydol_SizeChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labeltolerancji);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.uswaktolerancji);
            this.panel4.Controls.Add(this.przyciskkolor);
            this.panel4.Controls.Add(this.przyciskusuntlo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(335, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 156);
            this.panel4.TabIndex = 1;
            this.panel4.SizeChanged += new System.EventHandler(this.panel4_SizeChanged);
            // 
            // labeltolerancji
            // 
            this.labeltolerancji.AutoSize = true;
            this.labeltolerancji.BackColor = System.Drawing.Color.White;
            this.labeltolerancji.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeltolerancji.Location = new System.Drawing.Point(16, 55);
            this.labeltolerancji.Name = "labeltolerancji";
            this.labeltolerancji.Size = new System.Drawing.Size(43, 23);
            this.labeltolerancji.TabIndex = 3;
            this.labeltolerancji.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "TOLERANCJA";
            // 
            // uswaktolerancji
            // 
            this.uswaktolerancji.AutoSize = false;
            this.uswaktolerancji.BackColor = System.Drawing.Color.White;
            this.uswaktolerancji.Dock = System.Windows.Forms.DockStyle.Left;
            this.uswaktolerancji.LargeChange = 1;
            this.uswaktolerancji.Location = new System.Drawing.Point(0, 0);
            this.uswaktolerancji.Maximum = 100;
            this.uswaktolerancji.Name = "uswaktolerancji";
            this.uswaktolerancji.Size = new System.Drawing.Size(148, 78);
            this.uswaktolerancji.TabIndex = 1;
            this.uswaktolerancji.ValueChanged += new System.EventHandler(this.uswaktolerancji_ValueChanged);
            // 
            // przyciskkolor
            // 
            this.przyciskkolor.BackColor = System.Drawing.Color.White;
            this.przyciskkolor.Dock = System.Windows.Forms.DockStyle.Right;
            this.przyciskkolor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskkolor.FlatAppearance.BorderSize = 0;
            this.przyciskkolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskkolor.Location = new System.Drawing.Point(143, 0);
            this.przyciskkolor.Name = "przyciskkolor";
            this.przyciskkolor.Size = new System.Drawing.Size(172, 78);
            this.przyciskkolor.TabIndex = 0;
            this.przyciskkolor.Text = "WYBIERZ KOLOR";
            this.przyciskkolor.UseVisualStyleBackColor = false;
            // 
            // przyciskusuntlo
            // 
            this.przyciskusuntlo.BackColor = System.Drawing.Color.White;
            this.przyciskusuntlo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.przyciskusuntlo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskusuntlo.FlatAppearance.BorderSize = 0;
            this.przyciskusuntlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskusuntlo.Location = new System.Drawing.Point(0, 78);
            this.przyciskusuntlo.Name = "przyciskusuntlo";
            this.przyciskusuntlo.Size = new System.Drawing.Size(315, 78);
            this.przyciskusuntlo.TabIndex = 0;
            this.przyciskusuntlo.Text = "USUŃ TŁO";
            this.przyciskusuntlo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.przyciskzapisz);
            this.panel1.Controls.Add(this.przyciskotworz);
            this.panel1.Controls.Add(this.przyciskreset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 156);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // przyciskzapisz
            // 
            this.przyciskzapisz.BackColor = System.Drawing.Color.White;
            this.przyciskzapisz.Dock = System.Windows.Forms.DockStyle.Right;
            this.przyciskzapisz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskzapisz.FlatAppearance.BorderSize = 0;
            this.przyciskzapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskzapisz.Location = new System.Drawing.Point(149, 0);
            this.przyciskzapisz.Name = "przyciskzapisz";
            this.przyciskzapisz.Size = new System.Drawing.Size(156, 78);
            this.przyciskzapisz.TabIndex = 0;
            this.przyciskzapisz.Text = "ZAPISZ";
            this.przyciskzapisz.UseVisualStyleBackColor = false;
            this.przyciskzapisz.Click += new System.EventHandler(this.przyciskzapisz_Click);
            // 
            // przyciskotworz
            // 
            this.przyciskotworz.BackColor = System.Drawing.Color.White;
            this.przyciskotworz.Dock = System.Windows.Forms.DockStyle.Left;
            this.przyciskotworz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskotworz.FlatAppearance.BorderSize = 0;
            this.przyciskotworz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskotworz.Location = new System.Drawing.Point(0, 0);
            this.przyciskotworz.Name = "przyciskotworz";
            this.przyciskotworz.Size = new System.Drawing.Size(148, 78);
            this.przyciskotworz.TabIndex = 0;
            this.przyciskotworz.Text = "OTWÓRZ";
            this.przyciskotworz.UseVisualStyleBackColor = false;
            this.przyciskotworz.Click += new System.EventHandler(this.przyciskotworz_Click);
            // 
            // przyciskreset
            // 
            this.przyciskreset.BackColor = System.Drawing.Color.White;
            this.przyciskreset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.przyciskreset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskreset.FlatAppearance.BorderSize = 0;
            this.przyciskreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskreset.Location = new System.Drawing.Point(0, 78);
            this.przyciskreset.Name = "przyciskreset";
            this.przyciskreset.Size = new System.Drawing.Size(305, 78);
            this.przyciskreset.TabIndex = 0;
            this.przyciskreset.Text = "RESET";
            this.przyciskreset.UseVisualStyleBackColor = false;
            this.przyciskreset.Click += new System.EventHandler(this.przyciskreset_Click);
            // 
            // labeltytul
            // 
            this.labeltytul.BackColor = System.Drawing.Color.Transparent;
            this.labeltytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltytul.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeltytul.Location = new System.Drawing.Point(20, 20);
            this.labeltytul.Name = "labeltytul";
            this.labeltytul.Size = new System.Drawing.Size(670, 76);
            this.labeltytul.TabIndex = 9;
            this.labeltytul.Text = "USUWANIE TŁA";
            this.labeltytul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Lime;
            this.colorDialog1.FullOpen = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bnp";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(20, 96);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel5.Size = new System.Drawing.Size(670, 228);
            this.panel5.TabIndex = 10;
            this.panel5.SizeChanged += new System.EventHandler(this.panel5_SizeChanged);
            // 
            // usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(710, 540);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labeltytul);
            this.Controls.Add(this.panelprawydol);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usun";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "usun";
            this.Load += new System.EventHandler(this.usun_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelprawydol.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uswaktolerancji)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panelprawydol;
        private System.Windows.Forms.Label labeltolerancji;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TrackBar uswaktolerancji;
        public System.Windows.Forms.Button przyciskusuntlo;
        public System.Windows.Forms.Button przyciskkolor;
        private System.Windows.Forms.Button przyciskreset;
        private System.Windows.Forms.Button przyciskzapisz;
        private System.Windows.Forms.Button przyciskotworz;
        private System.Windows.Forms.Label labeltytul;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}