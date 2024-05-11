// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLMALZEMELER
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLMALZEMELER
  {
    public int ID { get; set; }

    public string KOD { get; set; }

    public string UFKOD { get; set; }

    public string OEMKOD { get; set; }

    public string MALZEMEADI { get; set; }

    public string DIGERADI { get; set; }

    public string KULLANIMYERI { get; set; }

    public int? BIRIMID { get; set; }

    public int? GRUPID { get; set; }

    public int? GRUPID2 { get; set; }

    public int? KDVID { get; set; }

    public int? BOLUMID { get; set; }

    public string RAFNO { get; set; }

    public string GOZNO { get; set; }

    public string BARKOD { get; set; }

    public string TARIHKONTROL { get; set; }

    public string SERINOKONTROL { get; set; }

    public string KMKONTROL { get; set; }

    public string MALZEMEFOTO { get; set; }

    public int? KAYITTIPIID { get; set; }

    public string SAVEUSER { get; set; }

    public string SAVEDATE { get; set; }

    public string EDITUSER { get; set; }

    public DateTime? EDITDATE { get; set; }

    public string SAVEMAC { get; set; }

    public string EDITMAC { get; set; }

    public string SAVEIP { get; set; }

    public string EDITIP { get; set; }

    public Decimal? GIRIS { get; set; }

    public Decimal? CIKIS { get; set; }

    public Decimal? KALAN { get; set; }
  }
}
