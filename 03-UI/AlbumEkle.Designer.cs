namespace _03_UI
{
    partial class AlbumEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumEkle));
            this.lblAlbumAdi = new System.Windows.Forms.Label();
            this.txtAlbumAdi = new System.Windows.Forms.TextBox();
            this.lblAlbumSanatcisiGrubu = new System.Windows.Forms.Label();
            this.txtAlbumSanatci = new System.Windows.Forms.TextBox();
            this.lblAlbumCikisTarihi = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAlbumFiyati = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.lblIndirimOrani = new System.Windows.Forms.Label();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.lblSatisiDevamEdiyorMu = new System.Windows.Forms.Label();
            this.cmbSatisDevamEdiyorMu = new System.Windows.Forms.ComboBox();
            this.btnSatisiDurmusAlbum = new System.Windows.Forms.Button();
            this.btnSatisiDevamEdenAlbumler = new System.Windows.Forms.Button();
            this.btnEnSonEklenen = new System.Windows.Forms.Button();
            this.btnIndırimdekiler = new System.Windows.Forms.Button();
            this.lvTumAlbumler = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.adi = new System.Windows.Forms.ColumnHeader();
            this.sanatci = new System.Windows.Forms.ColumnHeader();
            this.tarihi = new System.Windows.Forms.ColumnHeader();
            this.fiyati = new System.Windows.Forms.ColumnHeader();
            this.indirimOrani = new System.Windows.Forms.ColumnHeader();
            this.satisiDevamEdiyorMu = new System.Windows.Forms.ColumnHeader();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAlbumGuncelle = new System.Windows.Forms.Button();
            this.btnAlbumSil = new System.Windows.Forms.Button();
            this.grpAlbumBilgiGiris = new System.Windows.Forms.GroupBox();
            this.lvListeliAlbumler = new System.Windows.Forms.ListView();
            this.albumAdi = new System.Windows.Forms.ColumnHeader();
            this.sanatcisi = new System.Windows.Forms.ColumnHeader();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.grpAlbumBilgiGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlbumAdi
            // 
            this.lblAlbumAdi.AutoSize = true;
            this.lblAlbumAdi.Location = new System.Drawing.Point(6, 45);
            this.lblAlbumAdi.Name = "lblAlbumAdi";
            this.lblAlbumAdi.Size = new System.Drawing.Size(73, 15);
            this.lblAlbumAdi.TabIndex = 0;
            this.lblAlbumAdi.Text = "Albüm Adı : ";
            // 
            // txtAlbumAdi
            // 
            this.txtAlbumAdi.Location = new System.Drawing.Point(174, 45);
            this.txtAlbumAdi.Name = "txtAlbumAdi";
            this.txtAlbumAdi.Size = new System.Drawing.Size(228, 23);
            this.txtAlbumAdi.TabIndex = 1;
            // 
            // lblAlbumSanatcisiGrubu
            // 
            this.lblAlbumSanatcisiGrubu.AutoSize = true;
            this.lblAlbumSanatcisiGrubu.Location = new System.Drawing.Point(5, 95);
            this.lblAlbumSanatcisiGrubu.Name = "lblAlbumSanatcisiGrubu";
            this.lblAlbumSanatcisiGrubu.Size = new System.Drawing.Size(164, 15);
            this.lblAlbumSanatcisiGrubu.TabIndex = 2;
            this.lblAlbumSanatcisiGrubu.Text = "Albüm Sanatçısı veya Grubu:";
            // 
            // txtAlbumSanatci
            // 
            this.txtAlbumSanatci.Location = new System.Drawing.Point(174, 95);
            this.txtAlbumSanatci.Name = "txtAlbumSanatci";
            this.txtAlbumSanatci.Size = new System.Drawing.Size(228, 23);
            this.txtAlbumSanatci.TabIndex = 3;
            // 
            // lblAlbumCikisTarihi
            // 
            this.lblAlbumCikisTarihi.AutoSize = true;
            this.lblAlbumCikisTarihi.Location = new System.Drawing.Point(10, 146);
            this.lblAlbumCikisTarihi.Name = "lblAlbumCikisTarihi";
            this.lblAlbumCikisTarihi.Size = new System.Drawing.Size(113, 15);
            this.lblAlbumCikisTarihi.TabIndex = 4;
            this.lblAlbumCikisTarihi.Text = "Albüm Çıkış Tarihi : ";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(173, 141);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(229, 23);
            this.dtpCikisTarihi.TabIndex = 5;
            // 
            // lblAlbumFiyati
            // 
            this.lblAlbumFiyati.AutoSize = true;
            this.lblAlbumFiyati.Location = new System.Drawing.Point(11, 190);
            this.lblAlbumFiyati.Name = "lblAlbumFiyati";
            this.lblAlbumFiyati.Size = new System.Drawing.Size(81, 15);
            this.lblAlbumFiyati.TabIndex = 6;
            this.lblAlbumFiyati.Text = "Albüm Fiyatı :";
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(174, 190);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(228, 23);
            this.txtFiyati.TabIndex = 7;
            // 
            // lblIndirimOrani
            // 
            this.lblIndirimOrani.AutoSize = true;
            this.lblIndirimOrani.Location = new System.Drawing.Point(12, 237);
            this.lblIndirimOrani.Name = "lblIndirimOrani";
            this.lblIndirimOrani.Size = new System.Drawing.Size(86, 15);
            this.lblIndirimOrani.TabIndex = 8;
            this.lblIndirimOrani.Text = "İndirim Oranı :";
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.Location = new System.Drawing.Point(173, 233);
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(229, 23);
            this.txtIndirimOrani.TabIndex = 9;
            // 
            // lblSatisiDevamEdiyorMu
            // 
            this.lblSatisiDevamEdiyorMu.AutoSize = true;
            this.lblSatisiDevamEdiyorMu.Location = new System.Drawing.Point(17, 283);
            this.lblSatisiDevamEdiyorMu.Name = "lblSatisiDevamEdiyorMu";
            this.lblSatisiDevamEdiyorMu.Size = new System.Drawing.Size(148, 15);
            this.lblSatisiDevamEdiyorMu.TabIndex = 10;
            this.lblSatisiDevamEdiyorMu.Text = "Satışı Devam Ediyor Mu? :";
            // 
            // cmbSatisDevamEdiyorMu
            // 
            this.cmbSatisDevamEdiyorMu.Items.AddRange(new object[] {
            "Durdu",
            "Devam Ediyor"});
            this.cmbSatisDevamEdiyorMu.Location = new System.Drawing.Point(173, 278);
            this.cmbSatisDevamEdiyorMu.Name = "cmbSatisDevamEdiyorMu";
            this.cmbSatisDevamEdiyorMu.Size = new System.Drawing.Size(229, 23);
            this.cmbSatisDevamEdiyorMu.TabIndex = 0;
            // 
            // btnSatisiDurmusAlbum
            // 
            this.btnSatisiDurmusAlbum.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSatisiDurmusAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSatisiDurmusAlbum.Location = new System.Drawing.Point(459, 123);
            this.btnSatisiDurmusAlbum.Name = "btnSatisiDurmusAlbum";
            this.btnSatisiDurmusAlbum.Size = new System.Drawing.Size(169, 23);
            this.btnSatisiDurmusAlbum.TabIndex = 11;
            this.btnSatisiDurmusAlbum.Text = "Satıışı Durmuş Albümler";
            this.btnSatisiDurmusAlbum.UseVisualStyleBackColor = false;
            this.btnSatisiDurmusAlbum.Click += new System.EventHandler(this.btnSatisiDurmusAlbum_Click);
            // 
            // btnSatisiDevamEdenAlbumler
            // 
            this.btnSatisiDevamEdenAlbumler.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSatisiDevamEdenAlbumler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSatisiDevamEdenAlbumler.Location = new System.Drawing.Point(460, 169);
            this.btnSatisiDevamEdenAlbumler.Name = "btnSatisiDevamEdenAlbumler";
            this.btnSatisiDevamEdenAlbumler.Size = new System.Drawing.Size(168, 23);
            this.btnSatisiDevamEdenAlbumler.TabIndex = 11;
            this.btnSatisiDevamEdenAlbumler.Text = "Satışı Devam Eden Albümler ";
            this.btnSatisiDevamEdenAlbumler.UseVisualStyleBackColor = false;
            this.btnSatisiDevamEdenAlbumler.Click += new System.EventHandler(this.btnSatisiDevamEdenAlbumler_Click);
            // 
            // btnEnSonEklenen
            // 
            this.btnEnSonEklenen.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEnSonEklenen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnSonEklenen.Location = new System.Drawing.Point(459, 269);
            this.btnEnSonEklenen.Name = "btnEnSonEklenen";
            this.btnEnSonEklenen.Size = new System.Drawing.Size(169, 23);
            this.btnEnSonEklenen.TabIndex = 11;
            this.btnEnSonEklenen.Text = "En son Eklenen 10 Albüm";
            this.btnEnSonEklenen.UseVisualStyleBackColor = false;
            this.btnEnSonEklenen.Click += new System.EventHandler(this.btnEnSonEklenen_Click);
            // 
            // btnIndırimdekiler
            // 
            this.btnIndırimdekiler.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnIndırimdekiler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIndırimdekiler.Location = new System.Drawing.Point(460, 221);
            this.btnIndırimdekiler.Name = "btnIndırimdekiler";
            this.btnIndırimdekiler.Size = new System.Drawing.Size(168, 23);
            this.btnIndırimdekiler.TabIndex = 11;
            this.btnIndırimdekiler.Text = "İndirimdeki Albümler";
            this.btnIndırimdekiler.UseVisualStyleBackColor = false;
            this.btnIndırimdekiler.Click += new System.EventHandler(this.btnIndırimdekiler_Click);
            // 
            // lvTumAlbumler
            // 
            this.lvTumAlbumler.BackColor = System.Drawing.Color.Tan;
            this.lvTumAlbumler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.adi,
            this.sanatci,
            this.tarihi,
            this.fiyati,
            this.indirimOrani,
            this.satisiDevamEdiyorMu});
            this.lvTumAlbumler.FullRowSelect = true;
            this.lvTumAlbumler.GridLines = true;
            this.lvTumAlbumler.Location = new System.Drawing.Point(23, 403);
            this.lvTumAlbumler.MultiSelect = false;
            this.lvTumAlbumler.Name = "lvTumAlbumler";
            this.lvTumAlbumler.Size = new System.Drawing.Size(1018, 269);
            this.lvTumAlbumler.TabIndex = 12;
            this.lvTumAlbumler.UseCompatibleStateImageBehavior = false;
            this.lvTumAlbumler.View = System.Windows.Forms.View.Details;
            this.lvTumAlbumler.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvTumAlbumler_ItemSelectionChanged);
            this.lvTumAlbumler.SelectedIndexChanged += new System.EventHandler(this.lvTumAlbumler_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // adi
            // 
            this.adi.Text = "Albüm Adı";
            this.adi.Width = 150;
            // 
            // sanatci
            // 
            this.sanatci.Text = "Albüm Sanatçısı veya Grubu";
            this.sanatci.Width = 150;
            // 
            // tarihi
            // 
            this.tarihi.Text = "Albüm Çıkış Tarihi";
            this.tarihi.Width = 150;
            // 
            // fiyati
            // 
            this.fiyati.Text = "Albüm Fiyatı";
            this.fiyati.Width = 150;
            // 
            // indirimOrani
            // 
            this.indirimOrani.Text = "İndirim Oranı";
            this.indirimOrani.Width = 150;
            // 
            // satisiDevamEdiyorMu
            // 
            this.satisiDevamEdiyorMu.Text = "Satışı Devam Ediyor Mu?";
            this.satisiDevamEdiyorMu.Width = 150;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEkle.Location = new System.Drawing.Point(17, 331);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Albüm Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAlbumGuncelle
            // 
            this.btnAlbumGuncelle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAlbumGuncelle.Location = new System.Drawing.Point(149, 331);
            this.btnAlbumGuncelle.Name = "btnAlbumGuncelle";
            this.btnAlbumGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnAlbumGuncelle.TabIndex = 15;
            this.btnAlbumGuncelle.Text = "Albüm Güncelle";
            this.btnAlbumGuncelle.UseVisualStyleBackColor = false;
            this.btnAlbumGuncelle.Click += new System.EventHandler(this.btnAlbumGuncelle_Click);
            // 
            // btnAlbumSil
            // 
            this.btnAlbumSil.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAlbumSil.Location = new System.Drawing.Point(281, 331);
            this.btnAlbumSil.Name = "btnAlbumSil";
            this.btnAlbumSil.Size = new System.Drawing.Size(121, 23);
            this.btnAlbumSil.TabIndex = 16;
            this.btnAlbumSil.Text = "Albüm Sil";
            this.btnAlbumSil.UseVisualStyleBackColor = false;
            this.btnAlbumSil.Click += new System.EventHandler(this.btnAlbumSil_Click);
            // 
            // grpAlbumBilgiGiris
            // 
            this.grpAlbumBilgiGiris.BackColor = System.Drawing.Color.Transparent;
            this.grpAlbumBilgiGiris.Controls.Add(this.lblAlbumAdi);
            this.grpAlbumBilgiGiris.Controls.Add(this.btnAlbumSil);
            this.grpAlbumBilgiGiris.Controls.Add(this.txtAlbumAdi);
            this.grpAlbumBilgiGiris.Controls.Add(this.btnAlbumGuncelle);
            this.grpAlbumBilgiGiris.Controls.Add(this.lblAlbumSanatcisiGrubu);
            this.grpAlbumBilgiGiris.Controls.Add(this.btnEkle);
            this.grpAlbumBilgiGiris.Controls.Add(this.txtAlbumSanatci);
            this.grpAlbumBilgiGiris.Controls.Add(this.lblAlbumCikisTarihi);
            this.grpAlbumBilgiGiris.Controls.Add(this.dtpCikisTarihi);
            this.grpAlbumBilgiGiris.Controls.Add(this.lblAlbumFiyati);
            this.grpAlbumBilgiGiris.Controls.Add(this.txtFiyati);
            this.grpAlbumBilgiGiris.Controls.Add(this.lblIndirimOrani);
            this.grpAlbumBilgiGiris.Controls.Add(this.txtIndirimOrani);
            this.grpAlbumBilgiGiris.Controls.Add(this.lblSatisiDevamEdiyorMu);
            this.grpAlbumBilgiGiris.Controls.Add(this.cmbSatisDevamEdiyorMu);
            this.grpAlbumBilgiGiris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAlbumBilgiGiris.Location = new System.Drawing.Point(23, 30);
            this.grpAlbumBilgiGiris.Name = "grpAlbumBilgiGiris";
            this.grpAlbumBilgiGiris.Size = new System.Drawing.Size(418, 367);
            this.grpAlbumBilgiGiris.TabIndex = 17;
            this.grpAlbumBilgiGiris.TabStop = false;
            this.grpAlbumBilgiGiris.Text = "Albüm Bilgi Giriş Ekranı ";
            // 
            // lvListeliAlbumler
            // 
            this.lvListeliAlbumler.BackColor = System.Drawing.Color.Tan;
            this.lvListeliAlbumler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.albumAdi,
            this.sanatcisi});
            this.lvListeliAlbumler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvListeliAlbumler.GridLines = true;
            this.lvListeliAlbumler.Location = new System.Drawing.Point(634, 40);
            this.lvListeliAlbumler.Name = "lvListeliAlbumler";
            this.lvListeliAlbumler.Size = new System.Drawing.Size(407, 339);
            this.lvListeliAlbumler.TabIndex = 18;
            this.lvListeliAlbumler.UseCompatibleStateImageBehavior = false;
            this.lvListeliAlbumler.View = System.Windows.Forms.View.Details;
            // 
            // albumAdi
            // 
            this.albumAdi.Text = "Albüm Adı";
            this.albumAdi.Width = 200;
            // 
            // sanatcisi
            // 
            this.sanatcisi.Text = "Sanatçısı / Grubu";
            this.sanatcisi.Width = 200;
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lblHosgeldin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHosgeldin.Location = new System.Drawing.Point(391, 10);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(94, 17);
            this.lblHosgeldin.TabIndex = 19;
            this.lblHosgeldin.Text = "HOŞGELDİNİZ";
            // 
            // AlbumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 683);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.lvListeliAlbumler);
            this.Controls.Add(this.grpAlbumBilgiGiris);
            this.Controls.Add(this.lvTumAlbumler);
            this.Controls.Add(this.btnIndırimdekiler);
            this.Controls.Add(this.btnEnSonEklenen);
            this.Controls.Add(this.btnSatisiDevamEdenAlbumler);
            this.Controls.Add(this.btnSatisiDurmusAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumEkle";
            this.Text = "ALBUMLER";
            this.Load += new System.EventHandler(this.AlbumEkle_Load);
            this.grpAlbumBilgiGiris.ResumeLayout(false);
            this.grpAlbumBilgiGiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAlbumAdi;
        private TextBox txtAlbumAdi;
        private Label lblAlbumSanatcisiGrubu;
        private TextBox txtAlbumSanatci;
        private Label lblAlbumCikisTarihi;
        private DateTimePicker dtpCikisTarihi;
        private Label lblAlbumFiyati;
        private TextBox txtFiyati;
        private Label lblIndirimOrani;
        private TextBox txtIndirimOrani;
        private Label lblSatisiDevamEdiyorMu;
        private ComboBox cmbSatisDevamEdiyorMu;
        private Button btnSatisiDurmusAlbum;
        private Button btnSatisiDevamEdenAlbumler;
        private Button btnEnSonEklenen;
        private Button btnIndırimdekiler;
        private ListView lvTumAlbumler;
        private Button btnEkle;
        private Button btnAlbumGuncelle;
        private Button btnAlbumSil;
        private GroupBox grpAlbumBilgiGiris;
        private ColumnHeader adi;
        private ColumnHeader sanatci;
        private ColumnHeader tarihi;
        private ColumnHeader fiyati;
        private ColumnHeader indirimOrani;
        private ColumnHeader satisiDevamEdiyorMu;
        private ListView lvListeliAlbumler;
        private ColumnHeader albumAdi;
        private ColumnHeader sanatcisi;
        private ColumnHeader Id;
        private Label lblHosgeldin;
    }
}