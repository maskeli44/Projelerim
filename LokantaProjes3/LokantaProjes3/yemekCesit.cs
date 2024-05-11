using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LokantaProjes3
{
   
        internal class yemekcesit
        {

            private string malzemeDosyaAdi = "malzeme.txt";
            private string yemekCesitDosyaAdi = "yemekcesit.txt";


            public void Run()
            {
                while (true)
                {
                    Console.WriteLine("1. Yemek Ekle");
                    Console.WriteLine("2. Yemek Sil");
                    Console.WriteLine("3. Rapor Al");
                    Console.WriteLine("4. Çıkış");
                    Console.Write("Seçiminizi yapın: ");

                    if (int.TryParse(Console.ReadLine(), out int secim))
                    {
                        switch (secim)
                        {
                            case 1:
                                YemekEkle();
                                break;
                            case 2:
                                YemekSil();
                                break;
                            case 3:
                                RaporAl();
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Geçersiz seçim.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
                    }
                }
            }


            private void YemekSil()
            {
                if (!File.Exists(yemekCesitDosyaAdi))
                {
                    Console.WriteLine("Yemek çeşidi dosyası bulunamadı.");
                    return;
                }

                Console.WriteLine("Silinecek yemeği seçin:");
                List<string> yemekler = new List<string>(File.ReadAllLines(yemekCesitDosyaAdi));

                for (int i = 0; i < yemekler.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {yemekler[i]}");
                }

                Console.Write("Seçiminizi yapın: ");
                if (int.TryParse(Console.ReadLine(), out int secim))
                {
                    secim--;

                    if (secim >= 0 && secim < yemekler.Count)
                    {
                        string[] yemekParts = yemekler[secim].Split(new[] { "- " }, StringSplitOptions.None);
                        if (yemekParts.Length >= 2 && int.TryParse(yemekParts[0], out int yemekId))
                        {
                            string silinecekYemek = yemekParts[1];
                            yemekler.RemoveAt(secim);

                            File.WriteAllLines(yemekCesitDosyaAdi, yemekler);

                            List<string> malzemeler = new List<string>(File.ReadAllLines(malzemeDosyaAdi));
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

                            File.WriteAllLines(malzemeDosyaAdi, yeniMalzemeler);

                            Console.WriteLine($"{silinecekYemek} yemeği ve bağlı malzemeleri silindi.");
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
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
                }
            }

            private void YemekEkle()
            {
                Console.Write("Yeni yemek adını girin: ");
                string yeniYemek = Console.ReadLine();

                if (!File.Exists(yemekCesitDosyaAdi))
                {
                    File.Create(yemekCesitDosyaAdi).Close();
                }

                List<string> yemekler = new List<string>(File.ReadAllLines(yemekCesitDosyaAdi));

                int yeniYemekId;
                if (yemekler.Count > 0)
                {
                    string[] sonYemekParts = yemekler[yemekler.Count - 1].Split(new[] { "- " }, StringSplitOptions.None);
                    int sonYemekId = int.Parse(sonYemekParts[0]);
                    yeniYemekId = sonYemekId + 1;
                }
                else
                {
                    yeniYemekId = 1;
                }

                yemekler.Add($"{yeniYemekId}- {yeniYemek}");
                File.WriteAllLines(yemekCesitDosyaAdi, yemekler);

                Console.Write("Malzemeleri girin (virgülle ayırarak): ");
                string malzemeGirdi = Console.ReadLine();
                string malzemeSatiri = $"{yeniYemekId}- {malzemeGirdi}";
                File.AppendAllText(malzemeDosyaAdi, malzemeSatiri + Environment.NewLine);

                Console.WriteLine($"{yeniYemek} yemeği ve malzemeleri eklendi.");
            }


            private void RaporAl()
            {
                if (!File.Exists(yemekCesitDosyaAdi))
                {
                    Console.WriteLine("Yemek çeşidi dosyası bulunamadı.");
                    return;
                }

                Console.WriteLine("Yemek çeşitleri:");
                string[] yemekler = File.ReadAllLines(yemekCesitDosyaAdi);

                foreach (string yemek in yemekler)
                {
                    Console.WriteLine(yemek);
                }
            }

            private int YemekIdBelirle(string yemekAdi)
            {
                string[] yemekler = File.ReadAllLines(yemekCesitDosyaAdi);
                return Array.IndexOf(yemekler, yemekAdi);
            }
        }
    }



