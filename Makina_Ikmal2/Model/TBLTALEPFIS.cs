// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLTALEPFIS
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLTALEPFIS
  {
    public int ID { get; set; }

    public int? ISEMRIID { get; set; }

    public string KOD { get; set; }

    public DateTime? TARIH { get; set; }

    public DateTime? SAAT { get; set; }

    public int? FIRMAID { get; set; }

    public Decimal? FISTUTAR { get; set; }

    public int? TALEPDURUMID { get; set; }

    public string TALEPIPTALACIKLAMA { get; set; }

    public int? TALEPEDENUSTAID { get; set; }

    public int? ATOLYESEFID { get; set; }

    public int? DEPOYETKILIID { get; set; }

    public int? MUDURID { get; set; }

    public DateTime? MUDONAYZAMAN { get; set; }

    public int? TALEPKAYITID { get; set; }

    public string SAVEUSER { get; set; }

    public DateTime? SAVEDATE { get; set; }

    public string EDITUSER { get; set; }

    public DateTime? EDITDATE { get; set; }

    public string SAVEMAC { get; set; }

    public string EDITMAC { get; set; }

    public string SAVEIP { get; set; }

    public string EDITIP { get; set; }
  }
}
