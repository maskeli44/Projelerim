// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLLOG
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLLOG
  {
    public int ID { get; set; }

    public string ISLEMSAYFASI { get; set; }

    public string ISLEMTURU { get; set; }

    public int? ISLEMINID { get; set; }

    public DateTime? TARIH { get; set; }

    public TimeSpan? SAAT { get; set; }

    public string KULLANICIADI { get; set; }

    public int? KULLANICIID { get; set; }

    public string IP { get; set; }

    public string MAC { get; set; }
  }
}
