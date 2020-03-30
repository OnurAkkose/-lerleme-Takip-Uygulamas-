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
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {
            string sifre = txtesifre.Text;
            ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
            kayit kyt = ent.kayit.First(f => f.şifre == sifre);
            kyt.şifre = sifre;
            MessageBox.Show("Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnisim_Click(object sender, EventArgs e)
        {
            string sifre = txtsifre.Text;
            ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
            kayit kyt = ent.kayit.First(f => f.şifre == sifre);
            kyt.isim = txtisim.Text;
            MessageBox.Show("Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
