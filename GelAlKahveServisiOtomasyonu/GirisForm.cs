using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GelAlKahveServisiOtomasyonu
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxkullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGirisButon_Click(object sender, EventArgs e)
        {
            if (textBoxkullaniciAdi.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanici Adi ve/veya Sifre Bos Birakilamaz!");
            }
            else
            {
                if (textBoxkullaniciAdi.Text == "melis" && textBoxSifre.Text == "123456")
                {
                    MessageBox.Show("Giris Basarili");

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adi ve/veya Sifre Hatali");

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Yeni Sifre Olusturunuz");
        }

        private void textBoxkullaniciAdi_Click(object sender, EventArgs e)
        {
            textBoxkullaniciAdi.Text = "";
        }

        private void textBoxSifre_Click(object sender, EventArgs e)
        {
            textBoxSifre.Text = "";
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster.Checked)
            {

                textBoxSifre.PasswordChar = '\0';
            }

            else
            {
                textBoxSifre.PasswordChar = '.';
            }
        }

        private void checkBoxGoster_Click(object sender, EventArgs e)
        {

        }
    }
}
