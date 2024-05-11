using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LokantaProjes3
{ 
    internal class Urun
        {
            public string UrunAdi { get; set; }
            public DateTime UretimTarihi { get; set; }
            public DateTime SonKullanmaTarihi { get; set; }
            public float KaloriGram { get; set; }
            public float StokAdet { get; set; }
            public float Fiyat { get; set; }

            public Urun(string urunAdi, DateTime uretimTarihi, DateTime sonKullanmaTarihi, float kaloriGram, float stokAdet, float fiyat)
            {
                UrunAdi = urunAdi;
                UretimTarihi = uretimTarihi;
                SonKullanmaTarihi = sonKullanmaTarihi;
                KaloriGram = kaloriGram;
                StokAdet = stokAdet;
                Fiyat = fiyat;
            }

            public override string ToString()
            {
                return $"{UrunAdi} - Üretim: {UretimTarihi.ToShortDateString()}, SKT: {SonKullanmaTarihi.ToShortDateString()}, Kalori: {KaloriGram} cal, Stok: {StokAdet}, Fiyat: {Fiyat:C}";
            }
        }



        class program
        {
            static List<Urun> urunler = new List<Urun>();
            static string dosyaYolu = "Depo.txt";

            static void Main(string[] args)
            {
                try
                {
                    urunler = DosyadanUrunleriOku();

                    while (true)
                    {
                        Console.WriteLine("1- Kayıt Ekle");
                        Console.WriteLine("2- Kayıt Sil");
                        Console.WriteLine("3- Kayıt Güncelle");
                        Console.WriteLine("4- Rapor Al");
                        Console.WriteLine("5- Çıkış");
                        Console.Write("İşlem seçin: ");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        switch (secim)
                        {
                            case 1:
                                KayitEkle();
                                break;
                            case 2:
                                KayitSil();
                                break;
                            case 3:
                                KayitGuncelle();
                                break;
                            case 4:
                                RaporAl();
                                break;
                            case 5:
                                DosyayaUrunleriKaydet();
                                return;
                            default:
                                Console.WriteLine("Geçersiz seçim.");
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
            }
            static List<Urun> DosyadanUrunleriOku()
            {
                List<Urun> urunListesi = new List<Urun>();
                try
                {
                    if (File.Exists(dosyaYolu))
                    {
                        string[] satirlar = File.ReadAllLines(dosyaYolu);
                        foreach (string satir in satirlar)
                        {
                            string[] veriler = satir.Split('-');
                            string urunAdi = veriler[0].Trim();
                            DateTime uretimTarihi = DateTime.Parse(veriler[1].Substring(veriler[1].IndexOf("Üretim:") + 9).Trim());
                            DateTime sonKullanmaTarihi = DateTime.Parse(veriler[2].Substring(veriler[2].IndexOf("SKT:") + 4).Trim());
                            float kaloriGram = Convert.ToSingle(veriler[3].Substring(veriler[3].IndexOf("Kalori:") + 7).Trim().Split()[0]);
                            float stokAdet = Convert.ToSingle(veriler[4].Substring(veriler[4].IndexOf("Stok:") + 5).Trim());
                            float fiyat = Convert.ToSingle(veriler[5].Substring(veriler[5].IndexOf("Fiyat:") + 6).Trim().Replace("", "TL").Trim());

                            Urun urun = new Urun(urunAdi, uretimTarihi, sonKullanmaTarihi, kaloriGram, stokAdet, fiyat);
                            urunListesi.Add(urun);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dosya okuma hatası: " + ex.Message);
                }

                return urunListesi;
            }

            static void DosyayaUrunleriKaydet()
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(dosyaYolu, append: false))
                    {
                        foreach (Urun urun in urunler)
                        {
                            writer.WriteLine(urun.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dosya yazma hatası: " + ex.Message);
                }
            }

            static void KayitEkle()
            {
                Console.Write("Ürün adını girin: ");
                string urunAdi = Console.ReadLine();

                Console.Write("Üretim tarihini girin (örn. 2023-08-08): ");
                DateTime uretimTarihi = DateTime.Parse(Console.ReadLine());

                Console.Write("Son kullanma tarihini girin (örn. 2023-08-15): ");
                DateTime sonKullanmaTarihi = DateTime.Parse(Console.ReadLine());

                Console.Write("Kalori miktarını girin: ");
                float kaloriGram = Convert.ToSingle(Console.ReadLine());

                Console.Write("Stok adetini girin: ");
                float stokAdet = Convert.ToSingle(Console.ReadLine());

                Console.Write("Fiyatını girin: ");
                float fiyat = Convert.ToSingle(Console.ReadLine());

                Urun urun = new Urun(urunAdi, uretimTarihi, sonKullanmaTarihi, kaloriGram, stokAdet, fiyat);
                urunler.Add(urun);
                Console.WriteLine("Ürün eklendi.");
            }

            static void KayitSil()
            {
                Console.Write("Silmek istediğiniz ürünün adını girin: ");
                string urunAdi = Console.ReadLine();

                Urun silinecekUrun = urunler.Find(u => u.UrunAdi.Equals(urunAdi, StringComparison.OrdinalIgnoreCase));
                if (silinecekUrun != null)
                {
                    urunler.Remove(silinecekUrun);
                    Console.WriteLine("Ürün silindi.");
                }
                else
                {
                    Console.WriteLine("Ürün bulunamadı.");
                }
            }

            static void KayitGuncelle()
            {
                Console.Write("Güncellemek istediğiniz ürünün adını girin: ");
                string urunAdi = Console.ReadLine();

                Urun guncellenecekUrun = urunler.Find(u => u.UrunAdi.Equals(urunAdi, StringComparison.OrdinalIgnoreCase));
                if (guncellenecekUrun != null)
                {
                    Console.Write("Yeni ürün adını girin: ");
                    guncellenecekUrun.UrunAdi = Console.ReadLine();

                    Console.Write("Yeni üretim tarihini girin (örn. 2023-08-08): ");
                    guncellenecekUrun.UretimTarihi = DateTime.Parse(Console.ReadLine());

                    Console.Write("Yeni son kullanma tarihini girin (örn. 2023-08-15): ");
                    guncellenecekUrun.SonKullanmaTarihi = DateTime.Parse(Console.ReadLine());

                    Console.Write("Yeni kalori miktarını girin: ");
                    guncellenecekUrun.KaloriGram = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Yeni stok adetini girin: ");
                    guncellenecekUrun.StokAdet = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Yeni fiyatını girin: ");
                    guncellenecekUrun.Fiyat = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ürün güncellendi.");
                }
                else
                {
                    Console.WriteLine("Ürün bulunamadı.");
                }
            }

            static void RaporAl()
            {
                Console.WriteLine("Ürün Raporu:");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Ürün Adı - Üretim Tarihi - Son Kullanma Tarihi - Kalori - Stok Adet - Fiyat");
                Console.WriteLine("---------------------------------------------------");

                foreach (Urun urun in urunler)
                {
                    Console.WriteLine($"{urun.UrunAdi} - {urun.UretimTarihi.ToShortDateString()} - {urun.SonKullanmaTarihi.ToShortDateString()} - {urun.KaloriGram} cal - {urun.StokAdet} - {urun.Fiyat:C}");
                }
            }
        }
    }

