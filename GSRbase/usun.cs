using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GSRbase
{
    public partial class usun : Form
    {
        public usun()
        {
            InitializeComponent();
        }

        private void przyciskotworz_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try { 
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
            catch
            {
            }

        }

        private void uswaktolerancji_ValueChanged(object sender, EventArgs e)
        {
            labeltolerancji.Text = uswaktolerancji.Value.ToString();
        }

        private void usun_Load(object sender, EventArgs e)
        {
            labeltolerancji.Text = uswaktolerancji.Value.ToString();
        }

        private void przyciskzapisz_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            try{ 
            pictureBox3.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch
            {
            }
        }


        private void przyciskreset_Click(object sender, EventArgs e)
        {
            try 
            { 
                File.Delete(Environment.CurrentDirectory + "/plikoperowany.png");
                pictureBox3.Image = null; ;
            }
            catch
            {
            }
        }

        private void panel5_SizeChanged(object sender, EventArgs e)
        {
            panel2.Size = new Size((panel5.Size.Width-30)/2,0);
            panel3.Size = new Size((panel5.Size.Width-30)/2,0);
        }

        private void panelprawydol_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size((panelprawydol.Size.Width - 60) / 2, 0);
            panel4.Size = new Size((panelprawydol.Size.Width - 60) / 2, 0);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            przyciskotworz.Size = new Size(panel1.Size.Width / 2+1, 0);
            przyciskzapisz.Size = new Size(panel1.Size.Width / 2+1, 0);
        }

        private void panel4_SizeChanged(object sender, EventArgs e)
        {
            uswaktolerancji.Size = new Size(panel4.Size.Width / 2+1, 0);
            przyciskkolor.Size = new Size(panel4.Size.Width / 2+1, 0);
        }
    }
}
