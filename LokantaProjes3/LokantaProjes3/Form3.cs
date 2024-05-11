using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LokantaProjes3
{
    public partial class Form3 : Form
    {
        private YemekCesit yemekNesnesi;
        public Form3()
        {
            InitializeComponent();
            yemekNesnesi = new YemekCesit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            yemekNesnesi.MalzemeDosyaAdi = "malzeme.txt";
            yemekNesnesi.YemekCesitDosyaAdi = "yemekcesit.txt";

            RaporuGoster();
        }
   

        
        private void RaporuGoster()
            {
                List<string> yemekler = yemekNesnesi.RaporAl();
                listBoxYemekler.Items.Clear();

                foreach (string yemek in yemekler)
                {
                    // Yemek bilgisini ve bağlı malzemeleri ayrıştır
                    string[] yemekBilgisi = yemek.Split(new[] { "- " }, StringSplitOptions.None);
                    if (yemekBilgisi.Length >= 2)
                    {
                        string yemekAdi = yemekBilgisi[1]; // Yemek adı
                        string malzemeler = ""; // Malzemeleri tutacağımız değişken
                        int yemekId = int.Parse(yemekBilgisi[0]);

                        // Malzemeleri bul ve formatla
                        List<string> malzemeSatirlari = yemekNesnesi.MalzemeleriGetir(yemekId);
                        if (malzemeSatirlari.Count > 0)
                        {
                            malzemeler = "Malzemeler: " + string.Join(", ", malzemeSatirlari);
                        }
                        else
                        {
                            malzemeler = "Malzemeler: Yok";
                        }

                        // Yemeği ve malzemeleri ListBox'a ekle
                        listBoxYemekler.Items.Add(yemekAdi + " - " + malzemeler);
                    }
                }
            }

        private void buttonYemekEkle_Click_1(object sender, EventArgs e)
        {
            string yeniYemek = textBoxYeniYemek.Text.Trim();
            string malzemeler = textBoxMalzemeler.Text.Trim();

            if (!string.IsNullOrEmpty(yeniYemek))
            {
                // Yemeği ekle ve formda göster
                yemekNesnesi.YemekEkle(yeniYemek, malzemeler);
                MessageBox.Show($"{yeniYemek} yemeği ve malzemeleri eklendi.");
                textBoxYeniYemek.Clear();
                textBoxMalzemeler.Clear();

                // Yemek çeşitlerini güncelle
                RaporuGoster();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yemek adı girin.");
            }

        }

        private void buttonYemekSil_Click_1(object sender, EventArgs e)
        {
            int secilenIndex = listBoxYemekler.SelectedIndex;
            if (secilenIndex >= 0)
            {
                yemekNesnesi.YemekSil(secilenIndex);
                MessageBox.Show("Yemek silindi.");
                RaporuGoster();
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
            }

        }

        private void buttonRaporAl_Click_1(object sender, EventArgs e)
        {
            List<string> rapor = yemekNesnesi.RaporAl();

            // Yeni formu oluştur ve raporu göster
            RaporForm raporForm = new RaporForm(rapor);
            raporForm.ShowDialog();
        }
    }

    internal class YemekCesit
        {
            public string MalzemeDosyaAdi { get; set; }
            public string YemekCesitDosyaAdi { get; set; }

            public void YemekEkle(string yeniYemek, string malzemeler)
            {
                if (string.IsNullOrEmpty(yeniYemek))
                {
                    Console.WriteLine("Geçerli bir yemek adı girilmelidir.");
                    return;
                }

                // Yeni yemek eklemek için gerekli işlemler
                List<string> yemekler = File.Exists(YemekCesitDosyaAdi) ? File.ReadAllLines(YemekCesitDosyaAdi).ToList() : new List<string>();
                int yeniYemekId = yemekler.Count + 1; // Yeni yemek ID'sini belirle
                yemekler.Add($"{yeniYemekId}- {yeniYemek}");
                File.WriteAllLines(YemekCesitDosyaAdi, yemekler);

                // Malzemeleri dosyaya ekleyin
                if (!string.IsNullOrEmpty(malzemeler))
                {
                    File.AppendAllText(MalzemeDosyaAdi, $"{yeniYemekId}- {malzemeler}" + Environment.NewLine);
                }
            }
            public List<string> MalzemeleriGetir(int yemekId)
            {
                List<string> malzemeler = new List<string>();

                if (File.Exists(MalzemeDosyaAdi))
                {
                    List<string> malzemeSatirlari = File.ReadAllLines(MalzemeDosyaAdi).ToList();

                    foreach (string malzeme in malzemeSatirlari)
                    {
                        string[] malzemeParts = malzeme.Split(new[] { "- " }, StringSplitOptions.None);

                        if (malzemeParts.Length >= 2 && int.TryParse(malzemeParts[0], out int malzemeYemekId))
                        {
                            if (malzemeYemekId == yemekId)
                            {
                                malzemeler.Add(malzemeParts[1]);
                            }
                        }
                    }
                }

                return malzemeler;
            }


            public void YemekSil(int secilenIndex)
            {
                if (secilenIndex < 0)
                {
                    Console.WriteLine("Geçerli bir yemek seçmelisiniz.");
                    return;
                }

                // Seçilen yemeği silme işlemleri
                List<string> yemekler = File.Exists(YemekCesitDosyaAdi) ? File.ReadAllLines(YemekCesitDosyaAdi).ToList() : new List<string>();
                if (secilenIndex < yemekler.Count)
                {
                    string secilenYemek = yemekler[secilenIndex];
                    string[] yemekParts = secilenYemek.Split(new[] { "- " }, StringSplitOptions.None);
                    if (yemekParts.Length >= 2 && int.TryParse(yemekParts[0], out int yemekId))
                    {
                        // Yemeği yemek listesinden ve malzeme listesinden sil
                        yemekler.RemoveAt(secilenIndex);
                        File.WriteAllLines(YemekCesitDosyaAdi, yemekler);

                        if (File.Exists(MalzemeDosyaAdi))
                        {
                            List<string> malzemeler = File.ReadAllLines(MalzemeDosyaAdi).ToList();
                            List<string> yeniMalzemeler = new List<string>();

                            foreach (string malzeme in malzemeler)
                            {
                                string[] malzemeParts = malzeme.Split(new[] { "- " }, StringSplitOptions.None);

                                if (malzemeParts.Length >= 2 && int.TryParse(malzemeParts[0], out int malzemeYemekId))
                                {
                                    if (malzemeYemekId != yemekId)
                                    {
                                        yeniMalzemeler.Add(malzeme);
                                    }
                                }
                            }

                            File.WriteAllLines(MalzemeDosyaAdi, yeniMalzemeler);
                        }

                        // Formda da yemeği sil
                        Form3 form = (Form3)Application.OpenForms["Form3"];
                        form.listBoxYemekler.Items.RemoveAt(secilenIndex);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }
            }

            public List<string> RaporAl()
            {
                if (!File.Exists(YemekCesitDosyaAdi))
                {
                    Console.WriteLine("Yemek çeşidi dosyası bulunamadı.");
                    return new List<string>();
                }

                List<string> yemekler = new List<string>(File.ReadAllLines(YemekCesitDosyaAdi));
                return yemekler;

            }
        }
    }
