using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilerlemeTakipUygulaması
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giriş giris = new giriş();
            giris.Show();

        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            using (Font myFont = new Font("Arial", 14))
            {
                g.DrawString("Bugün Ne Yaptın?", myFont, Brushes.Green, new Point(2, 3));
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ayarlar ayar = new ayarlar();
            ayar.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            destek dstk = new destek();
            dstk.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ilerleme ilr = new ilerleme();
            ilr.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            bugün bgn = new bugün();
            bgn.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            gecmis gcm = new gecmis();
            gcm.Show();
        }
    }
}
