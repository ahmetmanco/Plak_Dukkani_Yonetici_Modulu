using _01_Entity.Concrete;
using _02_DAL.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class YoneticiGirisBolumu : Form
    {
        ProjectContext projectContext;
        Metotlar metotlar = new Metotlar();

        public YoneticiGirisBolumu()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            YeniKullanici yeniKullanici = new YeniKullanici();
            yeniKullanici.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email =txtEmail.Text.Trim();
            string password = metotlar.SHA256Crypt(txtKullaniciSifre.Text.Trim());
            try
            {
                Yonetici yonetici = metotlar.CheckLogin(email, password);
                if (yonetici != null)
                {
                    AlbumEkle albumEkle = new AlbumEkle(yonetici);
                    albumEkle.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login attempt. Username or password incorrect!!!\r\nIf you are not a member, register.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void YoneticiGirisBolumu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreGoster.CheckState == CheckState.Checked)
            {
                txtKullaniciSifre.UseSystemPasswordChar = false;
                chbSifreGoster.Text = "Parolayı Gizle";
            }
            else if (chbSifreGoster.CheckState == CheckState.Unchecked)
            {
                txtKullaniciSifre.UseSystemPasswordChar = true;
                chbSifreGoster.Text = "Parolayı Göster";
            }
        }
    }
}
