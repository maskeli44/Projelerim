// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLTALEP
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLTALEP
  {
    public int ID { get; set; }

    public string KOD { get; set; }

    public DateTime? TARIH { get; set; }

    public DateTime? SAAT { get; set; }

    public string BELGESAYI { get; set; }

    public string BELGEKONU { get; set; }

    public DateTime? BELGETARIH { get; set; }

    public string ISINADI { get; set; }

    public string ISINTURUMIKTARI { get; set; }

    public string ISINYAPYERI { get; set; }

    public string BUTCETERTIBI { get; set; }

    public string IHALEUSULU { get; set; }

    public string YAKLASIKMALIYET { get; set; }

    public string KULLODENEKTUTAR { get; set; }

    public int? ATOLYESEFID { get; set; }

    public int? DEPOYETKILIID { get; set; }

    public int? SORUMLUID { get; set; }

    public int? MUDURID { get; set; }

    public int? DAIREBSKID { get; set; }

    public int? GENELSEKYRDID { get; set; }

    public int? GENELSEKRETERID { get; set; }

    public string SAVEUSER { get; set; }

    public DateTime? SAVEDATE { get; set; }

    public string EDITUSER { get; set; }

    public DateTime? EDITDATE { get; set; }

    public string SAVEMAC { get; set; }

    public string EDITMAC { get; set; }

    public string SAVEIP { get; set; }

    public string EDITIP { get; set; }

    public string BILGINOTU { get; set; }

    public int? TEKLIFID { get; set; }
  }
}
