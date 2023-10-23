using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_ornek_4_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int baslangic, bitis;
            baslangic = Convert.ToInt32(txtBaslangic.Text);
            bitis = Convert.ToInt32(txtBitis.Text);
            for(int i= baslangic; 1 <= bitis; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
