// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLFORMKULLANICI
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

namespace Makina_Ikmal.Model
{
  public class TBLFORMKULLANICI
  {
    public int ID { get; set; }

    public int? KULLANICIID { get; set; }

    public string KOMUTADI { get; set; }

    public string SALTOKUNUR { get; set; }

    public bool? KAYIT { get; set; }

    public bool? SİL { get; set; }

    public bool? GUNCELLEME { get; set; }

    public bool? LISTELEME { get; set; }

    public int? KOMUTID { get; set; }
  }
}
