// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Log.LogEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Net;

namespace Makina_Ikmal.Log
{
  public class LogEkle
  {
    public static void Logs(string islemturu)
    {
      string hostName = Dns.GetHostName();
      new bellEntities()
      {
        TBLLOG = {
          new TBLLOG()
          {
            TARIH = new DateTime?(DateTime.Now),
            SAAT = new TimeSpan?(DateTime.Now.TimeOfDay),
            KULLANICIADI = Convert.ToString(YetkiClass.kullanici_id),
            ISLEMTURU = islemturu,
            ISLEMINID = new int?(YetkiClass.secim_id),
            ISLEMSAYFASI = YetkiClass.menuAdi,
            KULLANICIID = new int?(YetkiClass.kullanici_id),
            IP = Dns.GetHostByName(hostName).AddressList[0].ToString()
          }
        }
      }.SaveChanges();
    }
  }
}
