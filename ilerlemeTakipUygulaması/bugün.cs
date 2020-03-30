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
    public partial class bugün : Form
    {
        public bugün()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bugün_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblgun.Text = DateTime.Now.ToLongDateString();
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text == "ŞUBAT")
            {
                ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
                Şubat sbt = new Şubat();
                sbt.veri = txtbugun.Text;

                ent.Şubat.Add(sbt);
                ent.SaveChanges();
                MessageBox.Show("Eklendi", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                 }
           else if (checkedListBox1.Text == "MART")
            {
                ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
                Mart mrt = new Mart();
                mrt.veri = txtbugun.Text;

                ent.Mart.Add(mrt);
                ent.SaveChanges();
                MessageBox.Show("Eklendi", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
          else  if (checkedListBox1.Text == "NİSAN")
            {
                ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
                Nisan nsn = new Nisan();
                nsn.veri = txtbugun.Text;

                ent.Nisan.Add(nsn);
                ent.SaveChanges();
                MessageBox.Show("Eklendi", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Ay Seçimi Yapınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }
    }
}
