using _01_Entity.Concrete;
using _02_DAL.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_UI
{
    public class Metotlar
    {
        ProjectContext context;


        public bool SifreKontrol(string sifre)
        {
            Regex buyukHarfKontrolu = new Regex(@".*[A-Z].*[A-Z].*");
            Regex kucukharfKontrolu = new Regex(@".*[a-z].*[a-z].*[a-z].*");
            Regex sembolKontrolu = new Regex(@".*[!:+*]+.*[!:+*]+.*");
            bool sonuc;

            if (sifre.Length >= 8)
            {
                if (buyukHarfKontrolu.IsMatch(sifre))
                {
                    if (kucukharfKontrolu.IsMatch(sifre))
                    {
                        if (sembolKontrolu.IsMatch(sifre))
                        {
                            sonuc = true;
                        }

                        else
                        {
                            sonuc = false;
                            MessageBox.Show("Şifre içinde ! (ünlem), : (iki nokta üst üste), + (artı), * (yıldız) karakterlerinden en az 2 tanesi olmalıdır.\n(Aynı karakterden birden fazla olabilir)");
                        }
                    }

                    else
                    {
                        sonuc = false;
                        MessageBox.Show("Şifre içinde en az 3 küçük harf olmalıdır.");
                    }
                }

                else
                {
                    MessageBox.Show("En az 2 büyük harf içermelidir.");
                    sonuc = false;
                }
            }

            else
            {
                MessageBox.Show("Şifre en az 8 karakterli olmalıdır.");
                sonuc = false;
            }

            return sonuc;
        }

        public bool EmailKontrol(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.Match(email).Success;
        }

        public bool BosAlanVarMi(GroupBox grp)
        {
            bool flag = false;
            foreach (var item in grp.Controls)
            {
                if (item is TextBox)
                    flag = ((TextBox)item).Text.Trim() == "";
                else if (item is MaskedTextBox)
                    flag = ((MaskedTextBox)item).Text.Trim() == "";
                else if (item is ComboBox)
                    flag = ((ComboBox)item).SelectedIndex == -1;
                else if (item is DateTimePicker)
                    flag = ((DateTimePicker)item).Value == DateTime.Now;
               
            }
            return flag;
        }

        public void Temizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }

                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }

                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }

                else if (item is ListView)
                {
                    ((ListView)item).Clear();
                }

            }
        }

        public void Temizle(ListView lv)
        {
            lv.Clear();
        }
        public Yonetici CheckLogin(string email, string password)
        {
            context = new ProjectContext();
            var yonetici = context.Yoneticiler.Where(a => a.EMail == email && a.Sifre == password).ToList();
            return yonetici.FirstOrDefault();
        }
        public string SHA256Crypt(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

       
    }
}






