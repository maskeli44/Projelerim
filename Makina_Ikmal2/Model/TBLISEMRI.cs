// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLISEMRI
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLISEMRI
  {
    public int ID { get; set; }

    public string KOD { get; set; }

    public int? ATOLYEID { get; set; }

    public int? ARACID { get; set; }

    public DateTime? GIRISTARIH { get; set; }

    public DateTime? GIRISSAAT { get; set; }

    public DateTime? CIKISTARIH { get; set; }

    public DateTime? CIKISSAAT { get; set; }

    public int? ARIZANEDENIID { get; set; }

    public string BILDIRILENARIZA { get; set; }

    public int? ISEMRIDURUMID { get; set; }

    public int? BAKIMYERIID { get; set; }

    public string BAKIMYERACKLM { get; set; }

    public string ARACIGETIREN { get; set; }

    public string BAKIMKMSI { get; set; }

    public string SONRAKIBKMKM { get; set; }

    public string SONRAKIBKMTRH { get; set; }

    public string BAKIMSAATI { get; set; }

    public string SONRAKIBKMSAAT { get; set; }

    public int? ISEMRISIRANO { get; set; }

    public string YAPILANBAKIMOZETI { get; set; }

    public int? IMZAATOLYESEFID { get; set; }

    public string ISBITIMORANI { get; set; }

    public string SAVEUSER { get; set; }

    public DateTime? SAVEDATE { get; set; }

    public string EDITUSER { get; set; }

    public DateTime? EDITDATE { get; set; }

    public string SAVEMAC { get; set; }

    public string EDITMAC { get; set; }

    public string SAVEIP { get; set; }

    public string EDITIP { get; set; }

    public string BAKIMTURUID { get; set; }

    public string BAKIMDERECESIID { get; set; }

    public Decimal? ATIKYAG { get; set; }
  }
}
