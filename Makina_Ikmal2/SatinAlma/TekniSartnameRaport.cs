// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TekniSartnameRaport
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.SatinAlma
{
  public class TekniSartnameRaport : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private GroupHeaderBand GroupHeader1;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel2;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private GroupHeaderBand GroupHeader2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private Parameter isinadi;
    private Parameter maddeler;

    public TekniSartnameRaport() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      XRSummary xrSummary = new XRSummary();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.GroupHeader2 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.isinadi = new Parameter();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.maddeler = new Parameter();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.BeginInit();
      this.TopMargin.HeightF = 33.33333f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.Detail.Name = "Detail";
      this.GroupHeader1.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrPictureBox2
      });
      this.GroupHeader1.HeightF = 127.0833f;
      this.GroupHeader1.Level = 1;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 10.00001f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(133.3333f, 48.20836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(133.3333f, 71.20835f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(336.4583f, 20.00004f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(578.1249f, 10.00001f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(261.4584f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(165.625f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "TENİK ŞARTNAME";
      this.GroupHeader2.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrTable1,
        (XRControl) this.xrLabel1
      });
      this.GroupHeader2.HeightF = 68.75f;
      this.GroupHeader2.Name = "GroupHeader2";
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 43.75f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(308.3333f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell1,
        this.xrTableCell2
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "İİŞİN ADI\t";
      this.xrTableCell1.Weight = 1.0;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isinadi")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.Weight = 2.0833334350585937;
      this.isinadi.AllowNull = true;
      this.isinadi.Description = "isinadi";
      this.isinadi.Name = "isinadi";
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(746f, 25f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell3.Summary = xrSummary;
      this.xrTableCell3.Weight = 0.36458312988281261;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?maddeler")
      });
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Weight = 7.0954168701171865;
      this.maddeler.AllowNull = true;
      this.maddeler.Description = "maddeler";
      this.maddeler.Name = "maddeler";
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2
      });
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(64, 31, 33, 100);
      this.Parameters.AddRange(new Parameter[2]
      {
        this.isinadi,
        this.maddeler
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.EndInit();
    }
  }
}
