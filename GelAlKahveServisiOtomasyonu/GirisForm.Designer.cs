namespace GelAlKahveServisiOtomasyonu
{
    partial class GirisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            groupBoxMusteriGirisSayfa = new GroupBox();
            checkBoxGoster = new CheckBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            buttonGirisButon = new Button();
            textBoxSifre = new TextBox();
            textBoxkullaniciAdi = new TextBox();
            labelSifre = new Label();
            labelkullaniciadi = new Label();
            groupBoxMusteriGirisSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMusteriGirisSayfa
            // 
            groupBoxMusteriGirisSayfa.Controls.Add(checkBoxGoster);
            groupBoxMusteriGirisSayfa.Controls.Add(linkLabel1);
            groupBoxMusteriGirisSayfa.Controls.Add(pictureBox1);
            groupBoxMusteriGirisSayfa.Controls.Add(buttonGirisButon);
            groupBoxMusteriGirisSayfa.Controls.Add(textBoxSifre);
            groupBoxMusteriGirisSayfa.Controls.Add(textBoxkullaniciAdi);
            groupBoxMusteriGirisSayfa.Controls.Add(labelSifre);
            groupBoxMusteriGirisSayfa.Controls.Add(labelkullaniciadi);
            groupBoxMusteriGirisSayfa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxMusteriGirisSayfa.Location = new Point(163, 22);
            groupBoxMusteriGirisSayfa.Name = "groupBoxMusteriGirisSayfa";
            groupBoxMusteriGirisSayfa.Size = new Size(489, 426);
            groupBoxMusteriGirisSayfa.TabIndex = 0;
            groupBoxMusteriGirisSayfa.TabStop = false;
            // 
            // checkBoxGoster
            // 
            checkBoxGoster.AutoSize = true;
            checkBoxGoster.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxGoster.Location = new Point(420, 170);
            checkBoxGoster.Name = "checkBoxGoster";
            checkBoxGoster.Size = new Size(67, 21);
            checkBoxGoster.TabIndex = 8;
            checkBoxGoster.Text = "Göster";
            checkBoxGoster.UseVisualStyleBackColor = true;
            checkBoxGoster.CheckedChanged += checkBoxGoster_CheckedChanged;
            checkBoxGoster.Click += checkBoxGoster_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.PaleGoldenrod;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = SystemColors.ControlDarkDark;
            linkLabel1.Location = new Point(231, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonGirisButon
            // 
            buttonGirisButon.BackColor = Color.FromArgb(126, 87, 60);
            buttonGirisButon.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGirisButon.ForeColor = SystemColors.ControlLightLight;
            buttonGirisButon.Location = new Point(183, 297);
            buttonGirisButon.Name = "buttonGirisButon";
            buttonGirisButon.Size = new Size(101, 38);
            buttonGirisButon.TabIndex = 6;
            buttonGirisButon.Text = "Giriş Yap";
            buttonGirisButon.UseVisualStyleBackColor = false;
            buttonGirisButon.Click += buttonGirisButon_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxSifre.Location = new Point(226, 168);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(188, 27);
            textBoxSifre.TabIndex = 4;
            textBoxSifre.Text = "Şifre giriniz";
            textBoxSifre.Click += textBoxSifre_Click;
            textBoxSifre.TextChanged += textBoxSifre_TextChanged;
            // 
            // textBoxkullaniciAdi
            // 
            textBoxkullaniciAdi.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxkullaniciAdi.Location = new Point(226, 97);
            textBoxkullaniciAdi.Name = "textBoxkullaniciAdi";
            textBoxkullaniciAdi.Size = new Size(188, 27);
            textBoxkullaniciAdi.TabIndex = 3;
            textBoxkullaniciAdi.Text = "Kullanıcı adınızı giriniz";
            textBoxkullaniciAdi.Click += textBoxkullaniciAdi_Click;
            textBoxkullaniciAdi.TextChanged += textBoxkullaniciAdi_TextChanged;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(226, 140);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(58, 25);
            labelSifre.TabIndex = 2;
            labelSifre.Text = "Şifre:";
            // 
            // labelkullaniciadi
            // 
            labelkullaniciadi.AutoSize = true;
            labelkullaniciadi.Location = new Point(226, 69);
            labelkullaniciadi.Name = "labelkullaniciadi";
            labelkullaniciadi.Size = new Size(127, 25);
            labelkullaniciadi.TabIndex = 1;
            labelkullaniciadi.Text = "Kullanıcı Adı:";
            labelkullaniciadi.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMusteriGirisSayfa);
            ForeColor = SystemColors.ControlText;
            Name = "Form3";
            groupBoxMusteriGirisSayfa.ResumeLayout(false);
            groupBoxMusteriGirisSayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMusteriGirisSayfa;
        private Label labelkullaniciadi;
        private Label labelSifre;
        private TextBox textBoxSifre;
        private TextBox textBoxkullaniciAdi;
        private PictureBox pictureBox1;
        private Button buttonGirisButon;
        private LinkLabel linkLabel1;
        private CheckBox checkBoxGoster;
    }
}