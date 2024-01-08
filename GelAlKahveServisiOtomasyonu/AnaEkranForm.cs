using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GelAlKahveServisiOtomasyonu
{
    public partial class AnaEkranForm : Form
    {
        public AnaEkranForm()
        {
            InitializeComponent();


        }


        private void pictureBoxGirisEkrani_Click(object sender, EventArgs e)
        {
            pictureBoxGirisEkrani.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxGirisEkrani.Image = Image.FromFile("C:\\Users\\melis\\Downloads\\coffee.jpg");

        }

        private void groupBoxButonlar_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelGirisYazisi_Click(object sender, EventArgs e)
        {

        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void buttonHesap_Click(object sender, EventArgs e)
        {

        }

        private void buttonKahveler_Click(object sender, EventArgs e)
        {
            KahveMenuForm form4 = new KahveMenuForm();
            form4.ShowDialog();
        }
    }
}