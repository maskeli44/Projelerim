// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Classlar.KullaniciSonId
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Makina_Ikmal.Classlar
{
  internal class KullaniciSonId
  {
    private bellEntities db = new bellEntities();

    public string giriskod()
    {
      try
      {
        string str = this.db.TBLDEPOFIS.Where<TBLDEPOFIS>((Expression<Func<TBLDEPOFIS, bool>>) (x => x.KOD.Contains("G"))).OrderByDescending<TBLDEPOFIS, int>((Expression<Func<TBLDEPOFIS, int>>) (p => p.ID)).Select<TBLDEPOFIS, string>((Expression<Func<TBLDEPOFIS, string>>) (r => r.KOD)).First<string>().ToString();
        return "G" + (Convert.ToInt32(str.Substring(1, str.Length - 1)) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "G000001";
      }
    }

    public string cikiskod()
    {
      try
      {
        string str = this.db.TBLDEPOFIS.Where<TBLDEPOFIS>((Expression<Func<TBLDEPOFIS, bool>>) (x => x.KOD.Contains("C"))).OrderByDescending<TBLDEPOFIS, int>((Expression<Func<TBLDEPOFIS, int>>) (p => p.ID)).Select<TBLDEPOFIS, string>((Expression<Func<TBLDEPOFIS, string>>) (r => r.KOD)).First<string>().ToString();
        return "C" + (Convert.ToInt32(str.Substring(1, str.Length - 1)) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "C000001";
      }
    }

    public string sayimkod()
    {
      try
      {
        string str = this.db.TBLDEPOFIS.Where<TBLDEPOFIS>((Expression<Func<TBLDEPOFIS, bool>>) (x => x.KOD.Contains("S"))).OrderByDescending<TBLDEPOFIS, int>((Expression<Func<TBLDEPOFIS, int>>) (p => p.ID)).Select<TBLDEPOFIS, string>((Expression<Func<TBLDEPOFIS, string>>) (r => r.KOD)).First<string>().ToString();
        return "S" + (Convert.ToInt32(str.Substring(1, str.Length - 1)) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "S000001";
      }
    }

    public string talepfiskodu()
    {
      try
      {
        return "TF" + (int.Parse(this.db.TBLTALEPFIS.OrderByDescending<TBLTALEPFIS, int>((Expression<Func<TBLTALEPFIS, int>>) (p => p.ID)).Select<TBLTALEPFIS, int>((Expression<Func<TBLTALEPFIS, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "TF000001";
      }
    }

    public string isemirkod()
    {
      try
      {
        return "IE" + (int.Parse(this.db.TBLISEMRI.OrderByDescending<TBLISEMRI, int>((Expression<Func<TBLISEMRI, int>>) (p => p.ID)).Select<TBLISEMRI, int>((Expression<Func<TBLISEMRI, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "IE0000001";
      }
    }

    public int isemir()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLISEMRI.OrderByDescending<TBLISEMRI, int>((Expression<Func<TBLISEMRI, int>>) (p => p.ID)).Select<TBLISEMRI, int>((Expression<Func<TBLISEMRI, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public string talepKod()
    {
      try
      {
        return "TA" + (int.Parse(this.db.TBLTALEP.OrderByDescending<TBLTALEP, int>((Expression<Func<TBLTALEP, int>>) (p => p.ID)).Select<TBLTALEP, int>((Expression<Func<TBLTALEP, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "TA0000001";
      }
    }

    public string AkaryakitSonKod()
    {
      try
      {
        return "AYK" + (int.Parse(this.db.TBLYAKITKONTFORM.OrderByDescending<TBLYAKITKONTFORM, int>((Expression<Func<TBLYAKITKONTFORM, int>>) (p => p.ID)).Select<TBLYAKITKONTFORM, int>((Expression<Func<TBLYAKITKONTFORM, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "AYK0000001";
      }
    }

    public string teklifKod()
    {
      try
      {
        return "TE" + (int.Parse(this.db.TBLTEKLIF.OrderByDescending<TBLTEKLIF, int>((Expression<Func<TBLTEKLIF, int>>) (p => p.ID)).Select<TBLTEKLIF, int>((Expression<Func<TBLTEKLIF, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "TE0000001";
      }
    }

    public int SonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLKULLANICILAR.OrderByDescending<TBLKULLANICILAR, int?>((Expression<Func<TBLKULLANICILAR, int?>>) (p => p.ID)).Select<TBLKULLANICILAR, int?>((Expression<Func<TBLKULLANICILAR, int?>>) (r => r.ID)).First<int?>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int SonTalepId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLTALEP.OrderByDescending<TBLTALEP, int>((Expression<Func<TBLTALEP, int>>) (p => p.ID)).Select<TBLTALEP, int>((Expression<Func<TBLTALEP, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public string TasitgorevSonKod()
    {
      try
      {
        return "TG" + (int.Parse(this.db.TBLTASITGOREV.OrderByDescending<TBLTASITGOREV, int>((Expression<Func<TBLTASITGOREV, int>>) (p => p.ID)).Select<TBLTASITGOREV, int>((Expression<Func<TBLTASITGOREV, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(6, '0');
      }
      catch (Exception ex)
      {
        return "TG0000001";
      }
    }

    public int aracgrup1SonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACGRUBU.OrderByDescending<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (p => p.ID)).Select<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int aracgrup2SonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACGRUBU2.OrderByDescending<TBLARACGRUBU2, int>((Expression<Func<TBLARACGRUBU2, int>>) (p => p.ID)).Select<TBLARACGRUBU2, int>((Expression<Func<TBLARACGRUBU2, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int arachgsSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACGRUBU.OrderByDescending<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (p => p.ID)).Select<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int araclarSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACLAR.OrderByDescending<TBLARACLAR, int>((Expression<Func<TBLARACLAR, int>>) (p => p.ID)).Select<TBLARACLAR, int>((Expression<Func<TBLARACLAR, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int aracmarkaSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACMARKA.OrderByDescending<TBLARACMARKA, int>((Expression<Func<TBLARACMARKA, int>>) (p => p.ID)).Select<TBLARACMARKA, int>((Expression<Func<TBLARACMARKA, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int aracmestpkSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACMESTKP.OrderByDescending<TBLARACMESTKP, int>((Expression<Func<TBLARACMESTKP, int>>) (p => p.ID)).Select<TBLARACMESTKP, int>((Expression<Func<TBLARACMESTKP, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int aractrkcezaSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACTRFCEZA.OrderByDescending<TBLARACTRFCEZA, int>((Expression<Func<TBLARACTRFCEZA, int>>) (p => p.ID)).Select<TBLARACTRFCEZA, int>((Expression<Func<TBLARACTRFCEZA, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int araczimmetSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACZIMMET.OrderByDescending<TBLARACZIMMET, int>((Expression<Func<TBLARACZIMMET, int>>) (p => p.ID)).Select<TBLARACZIMMET, int>((Expression<Func<TBLARACZIMMET, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelegitimdurumuSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLPERSEGITIMDRM.OrderByDescending<TBLPERSEGITIMDRM, int>((Expression<Func<TBLPERSEGITIMDRM, int>>) (p => p.ID)).Select<TBLPERSEGITIMDRM, int>((Expression<Func<TBLPERSEGITIMDRM, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelehliyerSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLPERSEHLIYET.OrderByDescending<TBLPERSEHLIYET, int>((Expression<Func<TBLPERSEHLIYET, int>>) (p => p.ID)).Select<TBLPERSEHLIYET, int>((Expression<Func<TBLPERSEHLIYET, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelizindurumuSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLPERSIZINDURUM.OrderByDescending<TBLPERSIZINDURUM, int>((Expression<Func<TBLPERSIZINDURUM, int>>) (p => p.ID)).Select<TBLPERSIZINDURUM, int>((Expression<Func<TBLPERSIZINDURUM, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelkurumgorevSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLPERSKURUMGOREV.OrderByDescending<TBLPERSKURUMGOREV, int>((Expression<Func<TBLPERSKURUMGOREV, int>>) (p => p.ID)).Select<TBLPERSKURUMGOREV, int>((Expression<Func<TBLPERSKURUMGOREV, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelSonId()
    {
      try
      {
        return Convert.ToInt32(int.Parse(this.db.TBLPERSONEL.OrderByDescending<TBLPERSONEL, int>((Expression<Func<TBLPERSONEL, int>>) (p => p.ID)).Select<TBLPERSONEL, int>((Expression<Func<TBLPERSONEL, int>>) (p => p.ID)).Max<int>().ToString()) + 1);
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public int personelunvanSonId()
    {
      try
      {
        return Convert.ToInt32((int.Parse(this.db.TBLARACGRUBU.OrderByDescending<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (p => p.ID)).Select<TBLARACGRUBU, int>((Expression<Func<TBLARACGRUBU, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString());
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public string PersonelP()
    {
      try
      {
        return "P" + (int.Parse(this.db.TBLPERSONEL.OrderByDescending<TBLPERSONEL, int>((Expression<Func<TBLPERSONEL, int>>) (p => p.ID)).Select<TBLPERSONEL, int>((Expression<Func<TBLPERSONEL, int>>) (r => r.ID)).First<int>().ToString()) + 1).ToString().PadLeft(5, '0');
      }
      catch (Exception ex)
      {
        return "P0000001";
      }
    }

    public int KullanicSonId()
    {
      try
      {
        return int.Parse(this.db.TBLKULLANICILAR.OrderByDescending<TBLKULLANICILAR, int?>((Expression<Func<TBLKULLANICILAR, int?>>) (p => p.ID)).Select<TBLKULLANICILAR, int?>((Expression<Func<TBLKULLANICILAR, int?>>) (r => r.ID)).First<int?>().ToString()) + 1;
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public string sayitoyazi(int tutar)
    {
      string str1 = tutar.ToString("F2").Replace('.', ',');
      string str2 = str1.Substring(0, str1.IndexOf(','));
      string str3 = str1.Substring(str1.IndexOf(',') + 1, 2);
      string str4 = "";
      string[] strArray1 = new string[10]
      {
        "",
        "BİR",
        "İKİ",
        "Üç",
        "DÖRT",
        "BEŞ",
        "ALTI",
        "YEDİ",
        "SEKİZ",
        "DOKUZ"
      };
      string[] strArray2 = new string[10]
      {
        "",
        "ON",
        "YİRMİ",
        "OTUZ",
        "KIRK",
        "ELLİ",
        "ALTMIŞ",
        "YETMİŞ",
        "SEKSEN",
        "DOKSAN"
      };
      string[] strArray3 = new string[6]
      {
        "KATRİLYON",
        "TRİLYON",
        "MİLYAR",
        "MİLYON",
        "BİN",
        ""
      };
      int num = 6;
      string str5 = str2.PadLeft(num * 3, '0');
      for (int startIndex = 0; startIndex < num * 3; startIndex += 3)
      {
        string str6 = "";
        if (str5.Substring(startIndex, 1) != "0")
          str6 = str6 + strArray1[Convert.ToInt32(str5.Substring(startIndex, 1))] + "YÜZ";
        if (str6 == "BİRYÜZ")
          str6 = "YÜZ";
        string str7 = str6 + strArray2[Convert.ToInt32(str5.Substring(startIndex + 1, 1))] + strArray1[Convert.ToInt32(str5.Substring(startIndex + 2, 1))];
        if (str7 != "")
          str7 += strArray3[startIndex / 3];
        if (str7 == "BİRBİN")
          str7 = "BİN";
        str4 += str7;
      }
      if (str4 != "")
        str4 += "  ";
      int length = str4.Length;
      if (str3.Substring(0, 1) != "0")
        str4 += strArray2[Convert.ToInt32(str3.Substring(0, 1))];
      if (str3.Substring(1, 1) != "0")
        str4 += strArray1[Convert.ToInt32(str3.Substring(1, 1))];
      return "(" + (str4.Length <= length ? str4 ?? "" : str4 ?? "") + ") Gün";
    }

    public string paratoyazi(Decimal tutar)
    {
      string str1 = tutar.ToString("F2").Replace('.', ',');
      string str2 = str1.Substring(0, str1.IndexOf(','));
      string str3 = str1.Substring(str1.IndexOf(',') + 1, 2);
      string str4 = "";
      string[] strArray1 = new string[10]
      {
        "",
        "Bir",
        "İki",
        "Üç",
        "Dört",
        "Beş",
        "Altı",
        "Yedi",
        "Sekiz",
        "Dokuz"
      };
      string[] strArray2 = new string[10]
      {
        "",
        "On",
        "Yirmi",
        "Otuz",
        "Kırk",
        "Elli",
        "Altmış",
        "Yetmiş",
        "Seksen",
        "Doksan"
      };
      string[] strArray3 = new string[6]
      {
        "Katirilyon",
        "Trilyon",
        "Milyar",
        "Milyon",
        "Bin",
        ""
      };
      int num = 6;
      string str5 = str2.PadLeft(num * 3, '0');
      for (int startIndex = 0; startIndex < num * 3; startIndex += 3)
      {
        string str6 = "";
        if (str5.Substring(startIndex, 1) != "0")
          str6 = str6 + strArray1[Convert.ToInt32(str5.Substring(startIndex, 1))] + "Yüz";
        if (str6 == "Biryüz")
          str6 = "Yüz";
        string str7 = str6 + strArray2[Convert.ToInt32(str5.Substring(startIndex + 1, 1))] + strArray1[Convert.ToInt32(str5.Substring(startIndex + 2, 1))];
        if (str7 != "")
          str7 += strArray3[startIndex / 3];
        if (str7 == "BirBin")
          str7 = "Bin";
        str4 += str7;
      }
      if (str4 != "")
        str4 += " TL ";
      int length = str4.Length;
      if (str3.Substring(0, 1) != "0")
        str4 += strArray2[Convert.ToInt32(str3.Substring(0, 1))];
      if (str3.Substring(1, 1) != "0")
        str4 += strArray1[Convert.ToInt32(str3.Substring(1, 1))];
      return str4.Length <= length ? str4 ?? "" : str4 + " Kr";
    }
  }
}
