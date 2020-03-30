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
    public partial class giriş : Form
    {
        
       yeniKayit yenikayit = new yeniKayit();
        anaSayfa anasayfa = new anaSayfa();
       
        public giriş()
        {
            InitializeComponent();
        }

        ilerlemeTakipEntities ent1 = new ilerlemeTakipEntities();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            yenikayit.Show();
            

        }

        private void giriş_Load(object sender, EventArgs e)
        {

        }

        

      

        private void btngiris_Click_1(object sender, EventArgs e)
        {
            kayit kyt = new kayit();
            string sifre = txtgsifre.Text;
            kayit m = ent1.kayit.Where(x => x.şifre == sifre).SingleOrDefault();
            if (m == null)
            {
                MessageBox.Show("Hatalı Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m != null)
            {
                this.Hide();
                anasayfa.Show();

            }
        }
    }
}
