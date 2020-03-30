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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ilerlemeTakipEntities ent =new ilerlemeTakipEntities();
            if (checkedListBox1.Text == "OCAK")
            {
                               
                dataGridView1.DataSource = ent.Ocak.ToList();

            }
           else if (checkedListBox1.Text == "ŞUBAT")
            {

                dataGridView1.DataSource = ent.Şubat.ToList();

            }

        }
    }
}
