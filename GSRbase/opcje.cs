using System;
using System.Drawing;
using System.Windows.Forms;

namespace GSRbase
{
    public partial class opcje : Form
    {
        public opcje()
        {
            InitializeComponent();
            circularProgressBar1.Text = Environment.ProcessorCount.ToString();
            circularProgressBar1.Value = Environment.ProcessorCount;
            trackBar2.Value = Environment.ProcessorCount;
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            circularProgressBar1.Value = trackBar2.Value;
            circularProgressBar1.Text = trackBar2.Value.ToString();
        }

        private void panel4_SizeChanged(object sender, EventArgs e)
        {
            panelopcjelewo.Size = new Size(panel4.Width/2, 0);
        }
    }
}