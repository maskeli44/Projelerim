// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLDEPOFISHRKT
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLDEPOFISHRKT
  {
    public int ID { get; set; }

    public int? DEPOFISID { get; set; }

    public int? MALZEMEID { get; set; }

    public string MALZACIKLAMA { get; set; }

    public int? BIRIMID { get; set; }

    public Decimal? MIKTAR { get; set; }

    public Decimal? GIRISMIKTAR { get; set; }

    public Decimal? CIKISMIKTAR { get; set; }

    public Decimal? FIYAT { get; set; }

    public Decimal? TUTAR { get; set; }

    public Decimal? GIRISTUTAR { get; set; }

    public Decimal? CIKISTUTAR { get; set; }

    public Decimal? KDVORAN { get; set; }

    public Decimal? KDVTUTAR { get; set; }

    public Decimal? SATIRTUTAR { get; set; }

    public string GCKOD { get; set; }

    public int? DEPOID { get; set; }

    public int? MALZMARKAID { get; set; }

    public string MALZSERINO { get; set; }

    public string MALZURTTARIH { get; set; }

    public string DEGISIMKMSI { get; set; }

    public string SONRAKIDEGKM { get; set; }
  }
}
