
using System.Drawing;

namespace GSRbase
{
    partial class Base
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.przyciskautor = new System.Windows.Forms.Button();
            this.przyciskusun = new System.Windows.Forms.Button();
            this.przyciskopcje = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelprawy = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 587);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.przyciskopcje);
            this.panel2.Controls.Add(this.przyciskautor);
            this.panel2.Controls.Add(this.przyciskusun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(250, 280);
            this.panel2.TabIndex = 2;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // przyciskautor
            // 
            this.przyciskautor.BackColor = System.Drawing.Color.White;
            this.przyciskautor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.przyciskautor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskautor.FlatAppearance.BorderSize = 0;
            this.przyciskautor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskautor.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskautor.Location = new System.Drawing.Point(15, 182);
            this.przyciskautor.Name = "przyciskautor";
            this.przyciskautor.Size = new System.Drawing.Size(220, 83);
            this.przyciskautor.TabIndex = 1;
            this.przyciskautor.Text = "AUTOR";
            this.przyciskautor.UseVisualStyleBackColor = false;
            this.przyciskautor.Click += new System.EventHandler(this.przyciskautor_Click);
            // 
            // przyciskusun
            // 
            this.przyciskusun.BackColor = System.Drawing.Color.White;
            this.przyciskusun.Dock = System.Windows.Forms.DockStyle.Top;
            this.przyciskusun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskusun.FlatAppearance.BorderSize = 0;
            this.przyciskusun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskusun.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskusun.Location = new System.Drawing.Point(15, 15);
            this.przyciskusun.Name = "przyciskusun";
            this.przyciskusun.Size = new System.Drawing.Size(220, 83);
            this.przyciskusun.TabIndex = 1;
            this.przyciskusun.Text = "USUŃ";
            this.przyciskusun.UseVisualStyleBackColor = false;
            this.przyciskusun.Click += new System.EventHandler(this.przyciskusun_Click);
            // 
            // przyciskopcje
            // 
            this.przyciskopcje.BackColor = System.Drawing.Color.White;
            this.przyciskopcje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.przyciskopcje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.przyciskopcje.FlatAppearance.BorderSize = 0;
            this.przyciskopcje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskopcje.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskopcje.Location = new System.Drawing.Point(15, 98);
            this.przyciskopcje.Name = "przyciskopcje";
            this.przyciskopcje.Size = new System.Drawing.Size(220, 84);
            this.przyciskopcje.TabIndex = 1;
            this.przyciskopcje.Text = "OPCJE";
            this.przyciskopcje.UseVisualStyleBackColor = false;
            this.przyciskopcje.Click += new System.EventHandler(this.przyciskopcje_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.panel3.Size = new System.Drawing.Size(250, 307);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GSRbase.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(220, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelprawy
            // 
            this.panelprawy.BackColor = System.Drawing.Color.White;
            this.panelprawy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelprawy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprawy.Location = new System.Drawing.Point(250, 0);
            this.panelprawy.Margin = new System.Windows.Forms.Padding(0);
            this.panelprawy.MinimumSize = new System.Drawing.Size(126, 39);
            this.panelprawy.Name = "panelprawy";
            this.panelprawy.Size = new System.Drawing.Size(728, 587);
            this.panelprawy.TabIndex = 1;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 587);
            this.Controls.Add(this.panelprawy);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(978, 587);
            this.Name = "Base";
            this.Text = "GSR";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Base_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelprawy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button przyciskusun;
        private System.Windows.Forms.Button przyciskautor;
        private System.Windows.Forms.Button przyciskopcje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}