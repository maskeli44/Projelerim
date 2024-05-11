// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLTALEPFISHRKT
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLTALEPFISHRKT
  {
    public int ID { get; set; }

    public int? TALEPFISID { get; set; }

    public int? MALZEMEID { get; set; }

    public string MALZACIKLAMA { get; set; }

    public int? BIRIMID { get; set; }

    public Decimal? ISTENENMIKTAR { get; set; }

    public Decimal? MIKTAR { get; set; }

    public Decimal? FIYAT { get; set; }

    public Decimal? TUTAR { get; set; }
  }
}
