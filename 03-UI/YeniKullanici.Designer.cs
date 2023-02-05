namespace _03_UI
{
    partial class YeniKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKullanici));
            this.grpYeniKullanici = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniKayitEkle = new System.Windows.Forms.Button();
            this.lblSifreKontrol = new System.Windows.Forms.Label();
            this.txtSifreKontrol = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKullaniciSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpYeniKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYeniKullanici
            // 
            this.grpYeniKullanici.BackColor = System.Drawing.Color.Transparent;
            this.grpYeniKullanici.Controls.Add(this.label2);
            this.grpYeniKullanici.Controls.Add(this.btnYeniKayitEkle);
            this.grpYeniKullanici.Controls.Add(this.lblSifreKontrol);
            this.grpYeniKullanici.Controls.Add(this.txtSifreKontrol);
            this.grpYeniKullanici.Controls.Add(this.txtSifre);
            this.grpYeniKullanici.Controls.Add(this.txtEmail);
            this.grpYeniKullanici.Controls.Add(this.txtKullaniciSoyadi);
            this.grpYeniKullanici.Controls.Add(this.txtAdi);
            this.grpYeniKullanici.Controls.Add(this.lblKullaniciSifre);
            this.grpYeniKullanici.Controls.Add(this.lblEmail);
            this.grpYeniKullanici.Controls.Add(this.lblSoyadi);
            this.grpYeniKullanici.Controls.Add(this.lblAdi);
            this.grpYeniKullanici.Location = new System.Drawing.Point(19, 67);
            this.grpYeniKullanici.Name = "grpYeniKullanici";
            this.grpYeniKullanici.Size = new System.Drawing.Size(389, 393);
            this.grpYeniKullanici.TabIndex = 0;
            this.grpYeniKullanici.TabStop = false;
            this.grpYeniKullanici.Text = "Yeni Kullanıcı Kayıt";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnYeniKayitEkle
            // 
            this.btnYeniKayitEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnYeniKayitEkle.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnYeniKayitEkle.Location = new System.Drawing.Point(19, 335);
            this.btnYeniKayitEkle.Name = "btnYeniKayitEkle";
            this.btnYeniKayitEkle.Size = new System.Drawing.Size(344, 40);
            this.btnYeniKayitEkle.TabIndex = 6;
            this.btnYeniKayitEkle.Text = "Yeni Kayıt Ekle";
            this.btnYeniKayitEkle.UseVisualStyleBackColor = false;
            this.btnYeniKayitEkle.Click += new System.EventHandler(this.btnYeniKayitEkle_Click);
            // 
            // lblSifreKontrol
            // 
            this.lblSifreKontrol.AutoSize = true;
            this.lblSifreKontrol.Location = new System.Drawing.Point(19, 217);
            this.lblSifreKontrol.Name = "lblSifreKontrol";
            this.lblSifreKontrol.Size = new System.Drawing.Size(41, 15);
            this.lblSifreKontrol.TabIndex = 5;
            this.lblSifreKontrol.Text = "Şifre* :";
            // 
            // txtSifreKontrol
            // 
            this.txtSifreKontrol.Location = new System.Drawing.Point(108, 215);
            this.txtSifreKontrol.Name = "txtSifreKontrol";
            this.txtSifreKontrol.Size = new System.Drawing.Size(255, 23);
            this.txtSifreKontrol.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(107, 168);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(255, 23);
            this.txtSifre.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "birisi@gmail.com";
            this.txtEmail.Size = new System.Drawing.Size(255, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(107, 82);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(255, 23);
            this.txtKullaniciSoyadi.TabIndex = 2;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(107, 38);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(255, 23);
            this.txtAdi.TabIndex = 1;
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(18, 170);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(41, 15);
            this.lblKullaniciSifre.TabIndex = 3;
            this.lblKullaniciSifre.Text = "Şifre* :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(18, 84);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(48, 15);
            this.lblSoyadi.TabIndex = 1;
            this.lblSoyadi.Text = "Soyadı :";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(18, 38);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(31, 15);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Adı :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.Location = new System.Drawing.Point(37, 480);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(344, 41);
            this.btnGeriDon.TabIndex = 7;
            this.btnGeriDon.Text = "Ana Sayfaya Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ALBÜM DÜKKANI";
            // 
            // YeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.grpYeniKullanici);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniKullanici";
            this.Text = "YENİ KULLANICI KAYIT EKRANI";
            this.grpYeniKullanici.ResumeLayout(false);
            this.grpYeniKullanici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpYeniKullanici;
        private Button btnYeniKayitEkle;
        private Label lblSifreKontrol;
        private TextBox txtSifreKontrol;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private TextBox txtKullaniciSoyadi;
        private Label lblKullaniciSifre;
        private Label lblEmail;
        private Label lblSoyadi;
        private Button btnGeriDon;
        private TextBox txtAdi;
        private Label lblAdi;
        private Label label1;
        private Label label2;
    }
}