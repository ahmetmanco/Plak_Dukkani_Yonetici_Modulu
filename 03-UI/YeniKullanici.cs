using _01_Entity.Concrete;
using _02_DAL.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class YeniKullanici : Form
    {
        ProjectContext context = new ProjectContext();
        Metotlar metotlar = new Metotlar();

        public YeniKullanici()
        {
            InitializeComponent();
        }

        private void btnYeniKayitEkle_Click(object sender, EventArgs e)
        {
            if (metotlar.EmailKontrol(txtEmail.Text))
            {
                if (!metotlar.BosAlanVarMi(grpYeniKullanici))
                {
                    if (metotlar.SifreKontrol(txtSifre.Text))
                    {
                        if (!KullaniciExists())
                        {
                            context.Yoneticiler.Add(new Yonetici()
                            {
                                YoneticiAdi = txtAdi.Text,
                                YoneticiSoyadi = txtKullaniciSoyadi.Text,
                                EMail = txtEmail.Text,
                                Sifre = metotlar.SHA256Crypt(txtSifre.Text)
                            });

                            MessageBox.Show("Kayıt Başarıyla Eklenmiştir");
                            context.SaveChanges();

                            YoneticiGirisBolumu giris = new YoneticiGirisBolumu();
                            giris.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı veritabanında mevcut.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir şifre giriniz");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir email giriniz.");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            YoneticiGirisBolumu giris = new YoneticiGirisBolumu();
            giris.Show();
            this.Close();
        }

        public bool KullaniciExists()
        {
            return context.Yoneticiler.Any(l => l.EMail == txtEmail.Text);
        }
    }
}
