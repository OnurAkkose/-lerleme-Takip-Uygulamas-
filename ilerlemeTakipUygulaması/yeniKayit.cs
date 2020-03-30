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
    
    public partial class yeniKayit : Form
    {
        
        
       
        public yeniKayit()
        {
            InitializeComponent();
        }


        


        private void btnkayit_Click_1(object sender, EventArgs e)
            
        {
            giriş giris = new giriş();
            ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
            kayit kyt = new kayit();
            kyt.isim = txtsifre.Text;
            kyt.şifre = txtsifre.Text;
            ent.kayit.Add(kyt);
            ent.SaveChanges();
            MessageBox.Show("Kayıt Oldunuz","Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            giris.Show();
        }
    }
}
