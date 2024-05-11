// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Classlar.YetkiClass
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Makina_Ikmal.Classlar
{
  internal class YetkiClass
  {
    private bellEntities db = new bellEntities();

    public static string menuAdi { get; set; }

    public static string menuyetki { get; set; }

    public static int EkleYetki { get; set; }

    public static int SilYetki { get; set; }

    public static int GuncelleYetki { get; set; }

    public static int ListelemeYetki { get; set; }

    public static int kullanici_id { get; set; }

    public static string kullanici_ad { get; set; }

    public static string secim { get; set; }

    public static int personelid { get; set; }

    public static int secim_id { get; set; }

    public static int secim_id2 { get; set; }

    public static string secim_kodu { get; set; }

    public static string yeni_kart_mal { get; set; }

    public void yetkiislemleri(string idxx)
    {
      DbSet<TBLFORMKULLANICI> tblformkullanici1 = this.db.TBLFORMKULLANICI;
      Expression<Func<TBLFORMKULLANICI, bool>> predicate = (Expression<Func<TBLFORMKULLANICI, bool>>) (p => p.KULLANICIID == (int?) YetkiClass.kullanici_id && p.KOMUTADI == idxx);
      foreach (TBLFORMKULLANICI tblformkullanici2 in (IEnumerable<TBLFORMKULLANICI>) tblformkullanici1.Where<TBLFORMKULLANICI>(predicate))
      {
        YetkiClass.menuAdi = tblformkullanici2.KOMUTADI;
        YetkiClass.menuyetki = tblformkullanici2.SALTOKUNUR;
        YetkiClass.EkleYetki = Convert.ToInt32((object) tblformkullanici2.KAYIT);
        YetkiClass.SilYetki = Convert.ToInt32((object) tblformkullanici2.SİL);
        YetkiClass.GuncelleYetki = Convert.ToInt32((object) tblformkullanici2.GUNCELLEME);
        YetkiClass.ListelemeYetki = Convert.ToInt32((object) tblformkullanici2.LISTELEME);
      }
    }

    public string MenuyeGirs { get; set; }

    public bool MenuYetkilendirme(string baslik)
    {
      bool flag = false;
      DbSet<TBLFORMKULLANICI> tblformkullanici1 = this.db.TBLFORMKULLANICI;
      Expression<Func<TBLFORMKULLANICI, bool>> predicate = (Expression<Func<TBLFORMKULLANICI, bool>>) (p => p.KULLANICIID == (int?) YetkiClass.kullanici_id && p.KOMUTADI == baslik);
      foreach (TBLFORMKULLANICI tblformkullanici2 in (IEnumerable<TBLFORMKULLANICI>) tblformkullanici1.Where<TBLFORMKULLANICI>(predicate))
      {
        if (tblformkullanici2.SALTOKUNUR == "Hayır")
        {
          flag = true;
          YetkiClass.EkleYetki = Convert.ToInt32((object) tblformkullanici2.KAYIT);
          YetkiClass.SilYetki = Convert.ToInt32((object) tblformkullanici2.SİL);
          YetkiClass.GuncelleYetki = Convert.ToInt32((object) tblformkullanici2.GUNCELLEME);
          YetkiClass.ListelemeYetki = Convert.ToInt32((object) tblformkullanici2.LISTELEME);
          YetkiClass.menuAdi = tblformkullanici2.KOMUTADI;
          YetkiClass.menuyetki = tblformkullanici2.SALTOKUNUR;
        }
        else
          flag = false;
      }
      return flag;
    }
  }
}
