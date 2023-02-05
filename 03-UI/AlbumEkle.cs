using _01_Entity.Concrete;
using _02_DAL.Context;
using Microsoft.VisualBasic.ApplicationServices;


namespace _03_UI
{
    public partial class AlbumEkle : Form
    {
        ProjectContext context;
        Metotlar metotlar = new Metotlar();
        int secilenId;
        Yonetici yonetici;

        public AlbumEkle(Yonetici yonetici)
        {
            InitializeComponent();
            this.yonetici = yonetici;
        }

        private void AlbumEkle_Load(object sender, EventArgs e)
        {
            context = new ProjectContext();
            ListViewDoldur();
            lblHosgeldin.Text = ("HOŞGELDİN" + " " + yonetici.YoneticiAdi + " " + yonetici.YoneticiSoyadi + "!!").ToUpper();
        }

        private void ListViewDoldur()
        {
            context = new ProjectContext();

            lvTumAlbumler.Clear();
            lvTumAlbumler.View = View.Details;
            lvTumAlbumler.GridLines = true;

            lvTumAlbumler.Columns.Add("ID", 50);
            lvTumAlbumler.Columns.Add("ALBUM ADI", 150);
            lvTumAlbumler.Columns.Add("SANATCI VEYA GRUP", 150);
            lvTumAlbumler.Columns.Add("CIKIS TARIHI", 125);
            lvTumAlbumler.Columns.Add("FIYATI", 100);
            lvTumAlbumler.Columns.Add("INDIRIM ORANI", 125);
            lvTumAlbumler.Columns.Add("SATISI DEVAM EDIYOR MU", 200);

            foreach (AlbumBilgi album in context.AlbumBilgileri)
            {
                ListViewItem satir = new ListViewItem(album.Id.ToString());
                satir.SubItems.Add(album.AlbumAdi.ToString());
                satir.SubItems.Add(album.SanatciveyaGrup.ToString());
                satir.SubItems.Add(album.CikisTarihi.ToString());
                satir.SubItems.Add(album.Fiyat.ToString());
                satir.SubItems.Add(album.IndirimOrani.ToString());

                if (album.SatisiVarMi)
                    satir.SubItems.Add("Devam Ediyor");

                else
                    satir.SubItems.Add("Durdu");

                lvTumAlbumler.Items.Add(satir);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            context = new ProjectContext();


            if (!metotlar.BosAlanVarMi(grpAlbumBilgiGiris))
            {
                bool satisDurumu = (cmbSatisDevamEdiyorMu.SelectedItem.ToString() == "Durdu") ? false : true;
                bool fiyatDonusturme = decimal.TryParse(txtFiyati.Text.ToString(), out decimal fiyat);
                bool indirimDonusturme = float.TryParse(txtIndirimOrani.Text.ToString(), out float indirim);

                if (fiyatDonusturme && indirimDonusturme)
                {
                    if (!AlbumExists())
                    {
                        context.AlbumBilgileri.Add(new AlbumBilgi()
                        {
                            AlbumAdi = txtAlbumAdi.Text,
                            SanatciveyaGrup = txtAlbumSanatci.Text,
                            CikisTarihi = dtpCikisTarihi.Value,
                            Fiyat = fiyat,
                            IndirimOrani = indirim,
                            SatisiVarMi = satisDurumu
                        });
                        context.SaveChanges();
                        metotlar.Temizle(grpAlbumBilgiGiris);
                        MessageBox.Show("Kayıt Başarıyla Eklenmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt zaten mevcuttur.");
                    }
                }
                else
                {
                    MessageBox.Show("Fiyat ya da indirim bilgisi hatalı girilmiştir");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }

            ListViewDoldur();
        }
        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            var album = context.AlbumBilgileri.FirstOrDefault(x => x.Id == secilenId);

            if (!metotlar.BosAlanVarMi(grpAlbumBilgiGiris))
            {
                bool satisDurumu = (cmbSatisDevamEdiyorMu.SelectedItem.ToString() == "Durdu") ? false : true;
                bool fiyatDonusturme = decimal.TryParse(txtFiyati.Text.ToString(), out decimal fiyat);
                bool indirimDonusturme = float.TryParse(txtIndirimOrani.Text.ToString(), out float indirim);
                if (fiyatDonusturme && indirimDonusturme)
                {
                    if (album != null)
                    {
                        if (!AlbumExists(album.Id))
                        {
                            album.AlbumAdi = txtAlbumAdi.Text;
                            album.SanatciveyaGrup = txtAlbumSanatci.Text;
                            album.CikisTarihi = dtpCikisTarihi.Value;
                            album.Fiyat = fiyat;
                            album.IndirimOrani = indirim;
                            album.SatisiVarMi = satisDurumu;

                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt zaten mevcuttur.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fiyat ya da indirim bilgisi hatalı girilmiştir");
                }
            }

            metotlar.Temizle(grpAlbumBilgiGiris);
            ListViewDoldur();
            album = null;
        }

        private bool AlbumExists(int? albumId = null)
        {
            if (albumId != null)
                return context.AlbumBilgileri.Any(l => l.AlbumAdi == txtAlbumAdi.Text && l.SanatciveyaGrup == txtAlbumSanatci.Text && l.Id != (int)albumId);
            else
                return context.AlbumBilgileri.Any(l => l.AlbumAdi == txtAlbumAdi.Text && l.SanatciveyaGrup == txtAlbumSanatci.Text);
        }

        private void btnAlbumSil_Click(object sender, EventArgs e)
        {
            var album = context.AlbumBilgileri.Where(x => x.Id == secilenId).FirstOrDefault();

            if (album != null)
            {
                context.AlbumBilgileri.Remove(album);
                context.SaveChanges();
            }

            metotlar.Temizle(grpAlbumBilgiGiris);
            metotlar.Temizle(lvTumAlbumler);
            metotlar.Temizle(lvListeliAlbumler);
            ListViewDoldur();
            secilenId = -1;
            album = null;
        }

        private void lvTumAlbumler_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void lvTumAlbumler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            context = new ProjectContext();
            secilenId = Convert.ToInt32(lvTumAlbumler.SelectedItems[0].SubItems[0].Text);
            //var album = context.AlbumBilgileri.Where(x => x.Id == int.Parse(lvTumAlbumler.SelectedItems[0].SubItems[0].Text)).ToList().FirstOrDefault();
            var album = context.AlbumBilgileri.Find(secilenId);

            if (album != null)
            {
                txtAlbumAdi.Text = album.AlbumAdi;
                txtAlbumSanatci.Text = album.SanatciveyaGrup;
                dtpCikisTarihi.Value = album.CikisTarihi;
                txtFiyati.Text = album.Fiyat.ToString();
                txtIndirimOrani.Text = album.IndirimOrani.ToString();
                cmbSatisDevamEdiyorMu.SelectedIndex = album.SatisiVarMi ? 1 : 0;
            }

            metotlar.Temizle(lvTumAlbumler);
            album = null;
            ListViewDoldur();
        }

        private void btnSatisiDurmusAlbum_Click(object sender, EventArgs e)
        {
            lvListeliAlbumler.Clear();
            var table = context.AlbumBilgileri.Where(x => x.SatisiVarMi == false).ToList();

            context = new ProjectContext();

            lvListeliAlbumler.Clear();
            lvListeliAlbumler.View = View.Details;
            lvListeliAlbumler.GridLines = true;

            lvListeliAlbumler.Columns.Add("ID", 50);
            lvListeliAlbumler.Columns.Add("ALBUM ADI", 150);
            lvListeliAlbumler.Columns.Add("SANATCI VEYA GRUP", 150);

            foreach (AlbumBilgi album in table)
            {
                ListViewItem satir = new ListViewItem(album.Id.ToString());
                satir.SubItems.Add(album.AlbumAdi.ToString());
                satir.SubItems.Add(album.SanatciveyaGrup.ToString());

                lvListeliAlbumler.Items.Add(satir);
            }
        }

        private void btnSatisiDevamEdenAlbumler_Click(object sender, EventArgs e)
        {
            lvListeliAlbumler.Clear();
            var table = context.AlbumBilgileri.Where(x => x.SatisiVarMi == true).ToList();

            context = new ProjectContext();

            lvListeliAlbumler.Clear();
            lvListeliAlbumler.View = View.Details;
            lvListeliAlbumler.GridLines = true;

            lvListeliAlbumler.Columns.Add("ID", 50);
            lvListeliAlbumler.Columns.Add("ALBUM ADI", 150);
            lvListeliAlbumler.Columns.Add("SANATCI VEYA GRUP", 150);

            foreach (AlbumBilgi album in table)
            {
                ListViewItem satir = new ListViewItem(album.Id.ToString());
                satir.SubItems.Add(album.AlbumAdi.ToString());
                satir.SubItems.Add(album.SanatciveyaGrup.ToString());

                lvListeliAlbumler.Items.Add(satir);
            }
        }

        private void btnIndırimdekiler_Click(object sender, EventArgs e)
        {
            lvListeliAlbumler.Clear();
            var table = context.AlbumBilgileri.Where(x => x.IndirimOrani > 0).ToList();

            context = new ProjectContext();

            lvListeliAlbumler.Clear();
            lvListeliAlbumler.View = View.Details;
            lvListeliAlbumler.GridLines = true;

            lvListeliAlbumler.Columns.Add("ID", 50);
            lvListeliAlbumler.Columns.Add("ALBUM ADI", 150);
            lvListeliAlbumler.Columns.Add("SANATCI VEYA GRUP", 150);

            foreach (AlbumBilgi album in table)
            {
                ListViewItem satir = new ListViewItem(album.Id.ToString());
                satir.SubItems.Add(album.AlbumAdi.ToString());
                satir.SubItems.Add(album.SanatciveyaGrup.ToString());

                lvListeliAlbumler.Items.Add(satir);
            }
        }

        private void btnEnSonEklenen_Click(object sender, EventArgs e)
        {
            lvListeliAlbumler.Clear();
            var table = context.AlbumBilgileri.OrderByDescending(x => x.Id).Take(10).ToList();

            context = new ProjectContext();

            lvListeliAlbumler.Clear();
            lvListeliAlbumler.View = View.Details;
            lvListeliAlbumler.GridLines = true;

            lvListeliAlbumler.Columns.Add("ID", 50);
            lvListeliAlbumler.Columns.Add("ALBUM ADI", 150);
            lvListeliAlbumler.Columns.Add("SANATCI VEYA GRUP", 150);

            foreach (AlbumBilgi album in table)
            {
                ListViewItem satir = new ListViewItem(album.Id.ToString());
                satir.SubItems.Add(album.AlbumAdi.ToString());
                satir.SubItems.Add(album.SanatciveyaGrup.ToString());

                lvListeliAlbumler.Items.Add(satir);
            }
        }


    }
}

