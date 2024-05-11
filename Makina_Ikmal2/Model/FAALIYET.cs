// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.FAALIYET
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class FAALIYET
  {
    public int ID { get; set; }

    public DateTime? TARIH { get; set; }

    public string YILI { get; set; }

    public int? ARACBAKIMATOLYE { get; set; }

    public int? ARACBAKIMARAZI { get; set; }

    public int? ARACBAKIMDIS { get; set; }

    public int? YAGBAKIM { get; set; }

    public int? ZORUNLUTRFKSIGORTA { get; set; }

    public int? MUAYENE { get; set; }

    public int? BAIKRESMI { get; set; }

    public int? BAIKHIZMET { get; set; }

    public Decimal? YAKITMOTORIN { get; set; }

    public Decimal? YAKITBENZIN { get; set; }

    public Decimal? RESMIKIRALIKMOTORIN { get; set; }

    public Decimal? RESMIKIRALIKBENZIN { get; set; }

    public int? SUBEMUDURU { get; set; }

    public string AYI { get; set; }
  }
}
