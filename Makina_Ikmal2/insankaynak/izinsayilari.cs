// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.izinsayilari
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;

namespace Makina_Ikmal.insankaynak
{
  public class izinsayilari : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;

    public izinsayilari() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.BeginInit();
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Name = "Detail";
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.Font = new Font("Arial", 9.75f);
      this.Version = "20.1";
      this.EndInit();
    }
  }
}
