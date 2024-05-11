// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TBLISEMRIBAKIMLAR
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;

namespace Makina_Ikmal.Model
{
  public class TBLISEMRIBAKIMLAR
  {
    public int ID { get; set; }

    public int? ISEMRIID { get; set; }

    public int? ATOLYEID { get; set; }

    public int? BAKIMYAPUSTAID { get; set; }

    public int? BAKIMGRUBUID { get; set; }

    public string YAPILANBAKIM { get; set; }

    public string SAVEUSER { get; set; }

    public DateTime? SAVEDATE { get; set; }

    public string EDITUSER { get; set; }

    public string EDITDATE { get; set; }

    public string SAVEMAC { get; set; }

    public string EDITMAC { get; set; }

    public string SAVEIP { get; set; }

    public string EDITIP { get; set; }
  }
}
