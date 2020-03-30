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
    public partial class ilerleme : Form
    {
        public ilerleme()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkonu.Text != ""&& rchadımlar.Text!="")
            {
                ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
                tblilerleme tbl = new tblilerleme();
                tblkayıtlar tblkyt = new tblkayıtlar();
                tbl.konu = txtkonu.Text;
                tbl.adımları = rchadımlar.Text;
                tblkyt.kayıtlar = txtkonu.Text;
                ent.tblilerleme.Add(tbl);
                ent.tblkayıtlar.Add(tblkyt);
                ent.SaveChanges();
                MessageBox.Show("Kaydedildi!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

       

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string knu = txtgkonu.Text;
            ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
           tblilerleme tbl = ent.tblilerleme.First(f => f.konu == knu);

            rchadımlar2.Text = tbl.adımları;
        }

        private void ilerleme_Load(object sender, EventArgs e)
        {
            ilerlemeTakipEntities ent = new ilerlemeTakipEntities();
            tblkayıtlar tblkyt = new tblkayıtlar();
            dataGridView1.DataSource = ent.tblkayıtlar.ToList();
        }
    }
}
