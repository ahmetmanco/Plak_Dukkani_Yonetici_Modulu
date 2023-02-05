namespace _03_UI
{
    partial class YoneticiGirisBolumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisBolumu));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(6, 61);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(42, 15);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Email :";
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(6, 110);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(89, 15);
            this.lblKullaniciSifre.TabIndex = 1;
            this.lblKullaniciSifre.Text = "Kullanıcı Şifre *:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "birisi@gmail.com";
            this.txtEmail.Size = new System.Drawing.Size(263, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKullaniciSifre.Location = new System.Drawing.Point(122, 107);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PlaceholderText = "Şifrenizi giriniz";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(263, 23);
            this.txtKullaniciSifre.TabIndex = 3;
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnYeniKayit.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnYeniKayit.ForeColor = System.Drawing.Color.Black;
            this.btnYeniKayit.Location = new System.Drawing.Point(227, 497);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(210, 33);
            this.btnYeniKayit.TabIndex = 7;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chbSifreGoster);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblKullaniciSifre);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtKullaniciSifre);
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 242);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Giriş Bilgileri";
            // 
            // chbSifreGoster
            // 
            this.chbSifreGoster.AutoSize = true;
            this.chbSifreGoster.Location = new System.Drawing.Point(122, 149);
            this.chbSifreGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSifreGoster.Name = "chbSifreGoster";
            this.chbSifreGoster.Size = new System.Drawing.Size(95, 19);
            this.chbSifreGoster.TabIndex = 7;
            this.chbSifreGoster.Text = "Şifreyi Göster";
            this.chbSifreGoster.UseVisualStyleBackColor = true;
            this.chbSifreGoster.CheckedChanged += new System.EventHandler(this.chbSifreGoster_CheckedChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(122, 189);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(263, 31);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALBÜM DÜKKANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "HS-8 EF MARATON GRUP-3:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Açelya GÜNER GÖKÇEASLAN\r\nAhmet GÜNDÜZ\r\nSevde BAŞARAN";
            // 
            // YoneticiGirisBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYeniKayit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiGirisBolumu";
            this.Text = "KULLANICI GİRİŞ EKRANI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoneticiGirisBolumu_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblKullaniciSifre;
        private TextBox txtEmail;
        private TextBox txtKullaniciSifre;
        private Button btnYeniKayit;
        private GroupBox groupBox1;
        private CheckBox chbSifreGoster;
        private Button btnGirisYap;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}