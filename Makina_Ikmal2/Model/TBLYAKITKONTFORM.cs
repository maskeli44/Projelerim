// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLYAKITKONTFORM
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLYAKITKONTFORM
  {
    public int ID { get; set; }

    public string KOD { get; set; }

    public string PLAKA { get; set; }

    public DateTime? EBYSTARIH { get; set; }

    public string EBYSSAYI { get; set; }

    public DateTime? GIRISZAMAN { get; set; }

    public DateTime? CIKISZAMAN { get; set; }

    public int? BIRIMID { get; set; }

    public int? MUDURLUKID { get; set; }

    public string SOFOROPERATOR { get; set; }

    public int? ISTASYONPERSID { get; set; }

    public int? ILGILIBIRIMPERSID { get; set; }

    public int? OTOMASYONPERSID { get; set; }
  }
}
