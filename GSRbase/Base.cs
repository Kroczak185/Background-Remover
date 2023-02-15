using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighLevelDll;
using System.Linq;


namespace GSRbase
{
    public partial class Base : Form
    {


        private usun pusun = new usun() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private opcje popcje = new opcje() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private autor aautor = new autor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private bool tryb = true;

        public Base()
        {
            InitializeComponent();
            this.pusun.przyciskkolor.Click += new System.EventHandler(this.kolor_Click);
            this.popcje.pictureBox1.Click += new System.EventHandler(this.obrazek_click);
            this.popcje.pictureBox2.Click += new System.EventHandler(this.obrazek2_click);
            this.popcje.labelopcjelewo.Click += new System.EventHandler(this.obrazek_click);
            this.popcje.labelopcjeprawo.Click += new System.EventHandler(this.obrazek2_click);
            this.pusun.przyciskusuntlo.Click += new System.EventHandler(this.przyciskusuntlo_Click);
            if (tryb)
            {
                this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
            }
            else
            {
                this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
            }
        }

        [DllImport(@"C:\Users\milos\source\repos\GSRbase\x64\Debug\JAAsm.dll")]
        //[DllImport(@"C:\Users\milos\source\repos\GSRbase\x64\Release\LowLvlDll.dll")]
        static extern void Process(int[] buffer, int endx, int endy, int depth, float tolerancja, int R, int G, int B);
        //static extern int Process(int x, int y);

        private Color sciemnij_zjasnij(Color kolor, bool jasniej, int ile)
        {
            int r = kolor.R;
            int g = kolor.G;
            int b = kolor.B;
            if (jasniej)
            {
                r += ile;
                g += ile;
                b += ile;
                if (r > 255)
                {
                    r = 255;
                }
                if (g > 255)
                {
                    g = 255;
                }
                if (b > 255)
                {
                    b = 255;
                }
            }
            else
            {
                r -= ile;
                g -= ile;
                b -= ile;
                if (r < 0)
                {
                    r = 0;
                }
                if (g < 0)
                {
                    g = 0;
                }
                if (b < 0)
                {
                    b = 0;
                }
            }
            return Color.FromArgb(r, g, b);
        }

        public void kolor_Click(object sender, EventArgs e)
        {
            //kotrolki usun
            this.pusun.colorDialog1.ShowDialog();
            this.pusun.panel2.BackColor = pusun.colorDialog1.Color;
            this.pusun.panelprawydol.BackColor = pusun.colorDialog1.Color;
            this.pusun.BackColor = sciemnij_zjasnij(pusun.colorDialog1.Color, true, 100);
            this.pusun.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            this.pusun.label3.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            this.pusun.label2.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, true, 150);
            this.popcje.trackBar2.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 100);

            //kontrolki glowne lewo
            this.panel1.BackColor = pusun.colorDialog1.Color;
            this.panel1.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            
            //kontrolki opcje
            this.popcje.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            this.popcje.BackColor = sciemnij_zjasnij(pusun.colorDialog1.Color, true, 100);

            if (tryb)
            {
                this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
            }
            else
            {
                this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
            }

            this.popcje.circularProgressBar1.ProgressColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            this.popcje.circularProgressBar1.OuterColor = sciemnij_zjasnij(pusun.colorDialog1.Color, true, 100);
            this.popcje.circularProgressBar1.InnerColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 100);
            this.popcje.circularProgressBar1.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);
            this.popcje.circularProgressBar1.SuperscriptColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 80);
            this.popcje.circularProgressBar1.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 100);
            

            //kontrolki autor
            this.aautor.BackColor = sciemnij_zjasnij(pusun.colorDialog1.Color, true, 100);
            this.aautor.ForeColor = sciemnij_zjasnij(pusun.colorDialog1.Color, false, 100);

        }

        public void obrazek_click(object sender, EventArgs e)
        {
            if(tryb==false)
            { 
                tryb = true;
                try
                {
                    this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                    this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                    this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
                    this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                }
                catch
                {
                    this.popcje.panelopcjelewo.BackColor = Color.FromArgb(0, 255, 0);
                    this.popcje.panelopcjeprawo.BackColor = Color.FromArgb(0, 155, 0);
                    this.popcje.panelopcjelewo.ForeColor = Color.FromArgb(0, 155, 0);
                    this.popcje.panelopcjeprawo.ForeColor = Color.FromArgb(0, 255, 0);
                }
            }
        }
        public void obrazek2_click(object sender, EventArgs e)
        {
            if (tryb == true)
            {
                tryb = false;
                try
                {
                    this.popcje.panelopcjeprawo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 20);
                    this.popcje.panelopcjelewo.BackColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                    this.popcje.panelopcjeprawo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, true, 80);
                    this.popcje.panelopcjelewo.ForeColor = sciemnij_zjasnij(this.pusun.colorDialog1.Color, false, 80);
                }
                catch
                {
                    this.popcje.panelopcjeprawo.BackColor = Color.FromArgb(0, 255, 0);
                    this.popcje.panelopcjelewo.BackColor = Color.FromArgb(0, 155, 0);
                    this.popcje.panelopcjeprawo.ForeColor = Color.FromArgb(0, 155, 0);
                    this.popcje.panelopcjelewo.ForeColor = Color.FromArgb(0, 255, 0);
                }
            }
        }

        private void przyciskusun_Click(object sender, EventArgs e)
        {
            this.panelprawy.Controls.Clear();
            pusun.FormBorderStyle = FormBorderStyle.None;
            this.panelprawy.Controls.Add(pusun);
            pusun.Show();
        }

        private void przyciskopcje_Click(object sender, EventArgs e)
        {
            this.panelprawy.Controls.Clear();
            popcje.FormBorderStyle = FormBorderStyle.None;
            this.panelprawy.Controls.Add(popcje);
            popcje.Show();
        }

        private void przyciskautor_Click(object sender, EventArgs e)
        {
            this.panelprawy.Controls.Clear();
            aautor.FormBorderStyle = FormBorderStyle.None;
            this.panelprawy.Controls.Add(aautor);
            aautor.Show();
        }


        private void Base_Load(object sender, EventArgs e)
        {
            this.panelprawy.Controls.Clear();
            pusun.FormBorderStyle = FormBorderStyle.None;
            this.panelprawy.Controls.Add(pusun);
            pusun.Show();
        }

        

        private void przyciskusuntlo_Click(object sender, EventArgs e)
        {
            //try
            { 
                Bitmap bmp = new Bitmap(pusun.pictureBox2.Image);
                bmp.MakeTransparent(Color.White);

                var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
                var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
                var buffer = new byte[data.Width * data.Height * depth];
                Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);


                DateTime startTime = DateTime.Now;
                if (tryb)
                {
                    HighLeveLDll imagetransp = new HighLeveLDll(pusun.colorDialog1.Color);
                    ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = popcje.trackBar2.Value };
                    Parallel.Invoke(options,
                        () => {
                            imagetransp.Process(buffer, data.Width, data.Height, depth, pusun.uswaktolerancji.Value);
                        }
                    );
                    options = null;
                    imagetransp = null;
                }
                else
                {
                    int[] tablica = Array.ConvertAll(buffer, c => (int)c);
                    Process(tablica, data.Width, data.Height, depth, pusun.uswaktolerancji.Value, pusun.colorDialog1.Color.R, pusun.colorDialog1.Color.G, pusun.colorDialog1.Color.B);
                    buffer = Array.ConvertAll(tablica, c => (byte)c);
                }
                
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                popcje.label1.Text = (roznica.TotalMilliseconds+ "ms");
                Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
                bmp.UnlockBits(data);

                pusun.pictureBox3.Image = bmp;
                pusun.pictureBox3.Refresh();
            }
            //catch
            { }
        }
        
        
        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            przyciskautor.Size = new Size(0,(panel2.Size.Height-30)/3);
            przyciskusun.Size = new Size(0,(panel2.Size.Height-30)/3);
        }
    }
}
