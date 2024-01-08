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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBoxKafepic_Click(object sender, EventArgs e)
        {

        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            GirisForm form3 = new GirisForm();
            form3.ShowDialog();
        }
    }
}
