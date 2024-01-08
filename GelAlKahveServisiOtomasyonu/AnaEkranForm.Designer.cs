namespace GelAlKahveServisiOtomasyonu
{
    partial class AnaEkranForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkranForm));
            groupBoxButonlar = new GroupBox();
            buttonCikis = new Button();
            buttonHesap = new Button();
            buttonSepet = new Button();
            buttonKahveler = new Button();
            buttonUyeOl = new Button();
            buttonGirisYap = new Button();
            pictureBoxGirisEkrani = new PictureBox();
            labelMarka = new Label();
            labelGirisYazisi = new Label();
            groupBoxButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGirisEkrani).BeginInit();
            SuspendLayout();
            // 
            // groupBoxButonlar
            // 
            groupBoxButonlar.Controls.Add(buttonCikis);
            groupBoxButonlar.Controls.Add(buttonHesap);
            groupBoxButonlar.Controls.Add(buttonSepet);
            groupBoxButonlar.Controls.Add(buttonKahveler);
            groupBoxButonlar.Controls.Add(buttonUyeOl);
            groupBoxButonlar.Controls.Add(buttonGirisYap);
            groupBoxButonlar.Location = new Point(12, 12);
            groupBoxButonlar.Name = "groupBoxButonlar";
            groupBoxButonlar.Size = new Size(776, 428);
            groupBoxButonlar.TabIndex = 0;
            groupBoxButonlar.TabStop = false;
            groupBoxButonlar.Enter += groupBoxButonlar_Enter;
            // 
            // buttonCikis
            // 
            buttonCikis.BackColor = Color.FromArgb(150, 111, 51);
            buttonCikis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCikis.Location = new Point(0, 349);
            buttonCikis.Name = "buttonCikis";
            buttonCikis.Size = new Size(207, 77);
            buttonCikis.TabIndex = 5;
            buttonCikis.Text = "Çıkış Yap";
            buttonCikis.UseVisualStyleBackColor = false;
            // 
            // buttonHesap
            // 
            buttonHesap.BackColor = Color.Beige;
            buttonHesap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHesap.Location = new Point(0, 285);
            buttonHesap.Name = "buttonHesap";
            buttonHesap.Size = new Size(207, 69);
            buttonHesap.TabIndex = 4;
            buttonHesap.Text = "Hesabım";
            buttonHesap.UseVisualStyleBackColor = false;
            buttonHesap.Click += buttonHesap_Click;
            // 
            // buttonSepet
            // 
            buttonSepet.BackColor = Color.FromArgb(150, 111, 51);
            buttonSepet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSepet.Location = new Point(0, 209);
            buttonSepet.Name = "buttonSepet";
            buttonSepet.Size = new Size(207, 80);
            buttonSepet.TabIndex = 3;
            buttonSepet.Text = "Sepetim";
            buttonSepet.UseVisualStyleBackColor = false;
            // 
            // buttonKahveler
            // 
            buttonKahveler.BackColor = Color.Beige;
            buttonKahveler.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKahveler.Location = new Point(0, 140);
            buttonKahveler.Name = "buttonKahveler";
            buttonKahveler.Size = new Size(207, 71);
            buttonKahveler.TabIndex = 2;
            buttonKahveler.Text = "Kahveler";
            buttonKahveler.UseVisualStyleBackColor = false;
            buttonKahveler.Click += buttonKahveler_Click;
            // 
            // buttonUyeOl
            // 
            buttonUyeOl.BackColor = Color.FromArgb(150, 111, 51);
            buttonUyeOl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUyeOl.Location = new Point(0, 71);
            buttonUyeOl.Name = "buttonUyeOl";
            buttonUyeOl.Size = new Size(207, 73);
            buttonUyeOl.TabIndex = 1;
            buttonUyeOl.Text = "Üye Ol";
            buttonUyeOl.UseVisualStyleBackColor = false;
            // 
            // buttonGirisYap
            // 
            buttonGirisYap.BackColor = Color.Beige;
            buttonGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGirisYap.Location = new Point(0, 0);
            buttonGirisYap.Name = "buttonGirisYap";
            buttonGirisYap.Size = new Size(207, 74);
            buttonGirisYap.TabIndex = 0;
            buttonGirisYap.Text = "Giriş Yap";
            buttonGirisYap.UseVisualStyleBackColor = false;
            buttonGirisYap.Click += buttonGirisYap_Click;
            // 
            // pictureBoxGirisEkrani
            // 
            pictureBoxGirisEkrani.BackColor = Color.Snow;
            pictureBoxGirisEkrani.Image = (Image)resources.GetObject("pictureBoxGirisEkrani.Image");
            pictureBoxGirisEkrani.Location = new Point(218, 12);
            pictureBoxGirisEkrani.Name = "pictureBoxGirisEkrani";
            pictureBoxGirisEkrani.Size = new Size(570, 428);
            pictureBoxGirisEkrani.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGirisEkrani.TabIndex = 1;
            pictureBoxGirisEkrani.TabStop = false;
            pictureBoxGirisEkrani.Click += pictureBoxGirisEkrani_Click;
            // 
            // labelMarka
            // 
            labelMarka.AutoSize = true;
            labelMarka.BackColor = Color.FromArgb(244, 239, 233, 255);
            labelMarka.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelMarka.Location = new Point(413, 336);
            labelMarka.Name = "labelMarka";
            labelMarka.Size = new Size(188, 30);
            labelMarka.TabIndex = 6;
            labelMarka.Text = "Gel Al Kahve Servisi";
            // 
            // labelGirisYazisi
            // 
            labelGirisYazisi.AutoSize = true;
            labelGirisYazisi.BackColor = Color.FromArgb(226, 230, 239, 255);
            labelGirisYazisi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelGirisYazisi.Location = new Point(690, 21);
            labelGirisYazisi.Name = "labelGirisYazisi";
            labelGirisYazisi.Size = new Size(86, 17);
            labelGirisYazisi.TabIndex = 6;
            labelGirisYazisi.Text = "Hoşgeldiniz...";
            labelGirisYazisi.Click += labelGirisYazisi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(labelGirisYazisi);
            Controls.Add(labelMarka);
            Controls.Add(pictureBoxGirisEkrani);
            Controls.Add(groupBoxButonlar);
            Name = "Form1";
            Load += Form1_Load;
            groupBoxButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGirisEkrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxButonlar;
        private PictureBox pictureBoxGirisEkrani;
        private Button buttonGirisYap;
        private Button buttonCikis;
        private Button buttonHesap;
        private Button buttonSepet;
        private Button buttonKahveler;
        private Button buttonUyeOl;
        private Label labelMarka;
        private Label labelGirisYazisi;
    }
}