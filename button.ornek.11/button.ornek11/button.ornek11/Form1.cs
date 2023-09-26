using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float kisakenar, uzunkenar, cevre, alan;
            kisakenar = Convert.ToSingle(txtKisaKenar.Text);
            uzunkenar = Convert.ToSingle(txtUzunKenar.Text);
            cevre = (kisakenar + uzunkenar) * 2;
            lblCevre.Text = "Çevre: " + cevre.ToString();
            

            
            
            alan =kisakenar*uzunkenar;
            lblAlan.Text= "Alan"+alan.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
