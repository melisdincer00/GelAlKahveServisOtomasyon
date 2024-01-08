using Otomasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelAlKahveServisiOtomasyonu
{
    public partial class KahveMenuForm : Form
    {
        public KahveMenuForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var espressoSiparis = new Espresso
            {
                Fiyat = 50,
                BardakBoy = "Büyük",
                SekerMiktar = 0,
                KahveAdet = 1,

            };
            MessageBox.Show(espressoSiparis.ToString(), "Espresso Siparişi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var americanoSiparis = new Americano
            {
                Fiyat = 58,
                BardakBoy = "Orta",
                SekerMiktar = 25,
                KahveAdet = 1,

            };
            MessageBox.Show(americanoSiparis.ToString(), "Americano Siparişi");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var americanoSiparis = new Americano
            {
                Fiyat = 65,
                BardakBoy = "Küçük",
                SekerMiktar = 12,
                KahveAdet = 1,

            };
            MessageBox.Show(americanoSiparis.ToString(), "Cappucino Siparişi");
        }
    }
}
