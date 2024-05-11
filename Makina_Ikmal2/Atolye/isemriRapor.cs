// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.isemriRapor
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

namespace Makina_Ikmal.Atolye
{
  public class isemriRapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell43;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRTable xrTable3;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell50;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell51;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell52;
    private XRTable xrTable5;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell31;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell35;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell60;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell61;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell62;
    private XRTable xrTable2;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell30;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell24;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private Parameter plaka;
    private Parameter aracBilgisi;
    private Parameter isEmirkod;
    private Parameter bariza;
    private Parameter bakimyeri;
    private Parameter km;
    private Parameter ctarih;
    private Parameter gsaat;
    private Parameter csaat;
    private Parameter sofor;
    private Parameter atolyesef;
    private Parameter gtarih;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;

    public isemriRapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.TopMargin = new TopMarginBand();
      this.xrLabel14 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.xrTable4 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell44 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell42 = new XRTableCell();
      this.xrTableCell53 = new XRTableCell();
      this.xrTableCell54 = new XRTableCell();
      this.xrTableCell43 = new XRTableCell();
      this.xrLabel10 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrTable3 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell39 = new XRTableCell();
      this.xrTableCell40 = new XRTableCell();
      this.xrTableCell41 = new XRTableCell();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell45 = new XRTableCell();
      this.xrTableCell46 = new XRTableCell();
      this.xrTableCell47 = new XRTableCell();
      this.xrTableRow16 = new XRTableRow();
      this.xrTableCell48 = new XRTableCell();
      this.xrTableCell49 = new XRTableCell();
      this.xrTableRow17 = new XRTableRow();
      this.xrTableCell50 = new XRTableCell();
      this.xrTableRow18 = new XRTableRow();
      this.xrTableCell51 = new XRTableCell();
      this.xrTableRow19 = new XRTableRow();
      this.xrTableCell52 = new XRTableCell();
      this.xrTable5 = new XRTable();
      this.xrTableRow20 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableRow21 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableCell31 = new XRTableCell();
      this.xrTableRow22 = new XRTableRow();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableRow23 = new XRTableRow();
      this.xrTableCell60 = new XRTableCell();
      this.xrTableRow24 = new XRTableRow();
      this.xrTableCell61 = new XRTableCell();
      this.xrTableRow25 = new XRTableRow();
      this.xrTableCell62 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableCell37 = new XRTableCell();
      this.xrTableCell38 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell33 = new XRTableCell();
      this.xrTableCell34 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell30 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell27 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell24 = new XRTableCell();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.Detail = new DetailBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell55 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell56 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.plaka = new Parameter();
      this.aracBilgisi = new Parameter();
      this.isEmirkod = new Parameter();
      this.bariza = new Parameter();
      this.bakimyeri = new Parameter();
      this.km = new Parameter();
      this.ctarih = new Parameter();
      this.gsaat = new Parameter();
      this.csaat = new Parameter();
      this.sofor = new Parameter();
      this.atolyesef = new Parameter();
      this.gtarih = new Parameter();
      this.xrLabel16 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrTable4.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable5.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[6]
      {
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 118.3333f;
      this.TopMargin.Name = "TopMargin";
      this.xrLabel14.Font = new Font("Arial", 8f);
      this.xrLabel14.LocationFloat = new PointFloat(135.8333f, 56.50004f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Destek Hizmetleri Daire Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel14.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel13.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel13.LocationFloat = new PointFloat(137.5f, 36.66667f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "ŞANLIURFA BÜYÜKŞEHİR BAŞKANLIĞI";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel12.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel12.LocationFloat = new PointFloat(122.1666f, 92.83336f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(356.1666f, 25.49998f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "İŞ EMRİ FORMU (ARAÇ BAKIM)";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(135.8333f, 18.66669f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "T.C. ";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(504.1541f, 18.33334f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(145.8459f, 90f);
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 10f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 90f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.Controls.AddRange(new XRControl[14]
      {
        (XRControl) this.xrTable4,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1
      });
      this.BottomMargin.HeightF = 827.4998f;
      this.BottomMargin.Name = "BottomMargin";
      this.xrTable4.LocationFloat = new PointFloat(9.999847f, 618.1249f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable4.SizeF = new SizeF(630f, 25f);
      this.xrTableRow12.Cells.AddRange(new XRTableCell[6]
      {
        this.xrTableCell44,
        this.xrTableCell6,
        this.xrTableCell42,
        this.xrTableCell53,
        this.xrTableCell54,
        this.xrTableCell43
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell44.Borders = BorderSide.All;
      this.xrTableCell44.BorderWidth = 2f;
      this.xrTableCell44.Multiline = true;
      this.xrTableCell44.Name = "xrTableCell44";
      this.xrTableCell44.StylePriority.UseBorders = false;
      this.xrTableCell44.StylePriority.UseBorderWidth = false;
      this.xrTableCell44.Weight = 0.31458331823348995;
      this.xrTableCell6.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "ŞOFÖR / OPERATÖR";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell6.Weight = 1.8104168665409088;
      this.xrTableCell42.Borders = BorderSide.All;
      this.xrTableCell42.BorderWidth = 2f;
      this.xrTableCell42.Multiline = true;
      this.xrTableCell42.Name = "xrTableCell42";
      this.xrTableCell42.StylePriority.UseBorders = false;
      this.xrTableCell42.StylePriority.UseBorderWidth = false;
      this.xrTableCell42.Weight = 0.30156225562095629;
      this.xrTableCell53.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell53.Multiline = true;
      this.xrTableCell53.Name = "xrTableCell53";
      this.xrTableCell53.StylePriority.UseFont = false;
      this.xrTableCell53.StylePriority.UseTextAlignment = false;
      this.xrTableCell53.Text = "ARAÇ YIPLANMIŞ";
      this.xrTableCell53.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell53.Weight = 1.4796875953674318;
      this.xrTableCell54.Borders = BorderSide.All;
      this.xrTableCell54.BorderWidth = 2f;
      this.xrTableCell54.Multiline = true;
      this.xrTableCell54.Name = "xrTableCell54";
      this.xrTableCell54.StylePriority.UseBorders = false;
      this.xrTableCell54.StylePriority.UseBorderWidth = false;
      this.xrTableCell54.Weight = 0.30000000000000004;
      this.xrTableCell43.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.StylePriority.UseFont = false;
      this.xrTableCell43.StylePriority.UseTextAlignment = false;
      this.xrTableCell43.Text = "İŞ GÜÇLÜĞÜ";
      this.xrTableCell43.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell43.Weight = 1.7;
      this.xrLabel10.LocationFloat = new PointFloat(359.9999f, 731.8334f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(280.0001f, 34f);
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "Aracı yukarıdaki bakımları yapılmış olarak TESLİM ettim.";
      this.xrLabel10.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel9.LocationFloat = new PointFloat(9.999949f, 731.8334f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(304.1667f, 34f);
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "Aracı yukarıdaki bakımları yapılmış olarak TESLİM Aaldım.";
      this.xrLabel9.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel5.LocationFloat = new PointFloat(430f, 658.6667f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(168.3334f, 39.16656f);
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "ARACI TESLİM ALAN Atölye Şefi";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel6.LocationFloat = new PointFloat(73.33331f, 658.6667f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(146.6667f, 39.16656f);
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "ARACI TESLİM EDEN Şoför & Opertor";
      this.xrLabel6.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?sofor")
      });
      this.xrLabel7.LocationFloat = new PointFloat(73.33331f, 697.8334f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(146.6667f, 33.99999f);
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "xrLabel4";
      this.xrLabel7.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?atolyesef")
      });
      this.xrLabel8.LocationFloat = new PointFloat(430f, 697.8334f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(168.3334f, 33.99999f);
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "xrLabel3";
      this.xrLabel8.TextAlignment = TextAlignment.TopCenter;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.BorderWidth = 2f;
      this.xrTable3.LocationFloat = new PointFloat(10.00001f, 446.875f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[6]
      {
        this.xrTableRow14,
        this.xrTableRow15,
        this.xrTableRow16,
        this.xrTableRow17,
        this.xrTableRow18,
        this.xrTableRow19
      });
      this.xrTable3.SizeF = new SizeF(630f, 160.4167f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTable3.StylePriority.UseBorderWidth = false;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell39,
        this.xrTableCell40,
        this.xrTableCell41
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell39.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell39.Multiline = true;
      this.xrTableCell39.Name = "xrTableCell39";
      this.xrTableCell39.StylePriority.UseFont = false;
      this.xrTableCell39.StylePriority.UseTextAlignment = false;
      this.xrTableCell39.Text = "Atölye Adı";
      this.xrTableCell39.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell39.Weight = 1.0;
      this.xrTableCell40.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell40.Multiline = true;
      this.xrTableCell40.Name = "xrTableCell40";
      this.xrTableCell40.StylePriority.UseFont = false;
      this.xrTableCell40.StylePriority.UseTextAlignment = false;
      this.xrTableCell40.Text = "Bakım Yapan Usta";
      this.xrTableCell40.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell40.Weight = 1.0;
      this.xrTableCell41.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell41.Multiline = true;
      this.xrTableCell41.Name = "xrTableCell41";
      this.xrTableCell41.StylePriority.UseFont = false;
      this.xrTableCell41.StylePriority.UseTextAlignment = false;
      this.xrTableCell41.Text = "Bakım Grubu";
      this.xrTableCell41.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell41.Weight = 1.0;
      this.xrTableRow15.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell45,
        this.xrTableCell46,
        this.xrTableCell47
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell45.Multiline = true;
      this.xrTableCell45.Name = "xrTableCell45";
      this.xrTableCell45.Weight = 1.0;
      this.xrTableCell46.Multiline = true;
      this.xrTableCell46.Name = "xrTableCell46";
      this.xrTableCell46.Weight = 1.0;
      this.xrTableCell47.Multiline = true;
      this.xrTableCell47.Name = "xrTableCell47";
      this.xrTableCell47.Weight = 1.0;
      this.xrTableRow16.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell48,
        this.xrTableCell49
      });
      this.xrTableRow16.Name = "xrTableRow16";
      this.xrTableRow16.Weight = 1.0;
      this.xrTableCell48.Multiline = true;
      this.xrTableCell48.Name = "xrTableCell48";
      this.xrTableCell48.Text = "Yapılan Bakım";
      this.xrTableCell48.Weight = 0.5;
      this.xrTableCell49.Multiline = true;
      this.xrTableCell49.Name = "xrTableCell49";
      this.xrTableCell49.Weight = 2.5;
      this.xrTableRow17.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell50
      });
      this.xrTableRow17.Name = "xrTableRow17";
      this.xrTableRow17.Weight = 1.0;
      this.xrTableCell50.Multiline = true;
      this.xrTableCell50.Name = "xrTableCell50";
      this.xrTableCell50.Weight = 3.0;
      this.xrTableRow18.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell51
      });
      this.xrTableRow18.Name = "xrTableRow18";
      this.xrTableRow18.Weight = 1.0;
      this.xrTableCell51.Multiline = true;
      this.xrTableCell51.Name = "xrTableCell51";
      this.xrTableCell51.Weight = 3.0;
      this.xrTableRow19.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell52
      });
      this.xrTableRow19.Name = "xrTableRow19";
      this.xrTableRow19.Weight = 1.0;
      this.xrTableCell52.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel17
      });
      this.xrTableCell52.Multiline = true;
      this.xrTableCell52.Name = "xrTableCell52";
      this.xrTableCell52.Weight = 3.0;
      this.xrTable5.Borders = BorderSide.All;
      this.xrTable5.BorderWidth = 2f;
      this.xrTable5.LocationFloat = new PointFloat(9.999847f, 269.375f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[6]
      {
        this.xrTableRow20,
        this.xrTableRow21,
        this.xrTableRow22,
        this.xrTableRow23,
        this.xrTableRow24,
        this.xrTableRow25
      });
      this.xrTable5.SizeF = new SizeF(630f, 165f);
      this.xrTable5.StylePriority.UseBorders = false;
      this.xrTable5.StylePriority.UseBorderWidth = false;
      this.xrTableRow20.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell13,
        this.xrTableCell25,
        this.xrTableCell26
      });
      this.xrTableRow20.Name = "xrTableRow20";
      this.xrTableRow20.Weight = 1.0;
      this.xrTableCell13.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseFont = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "Atölye Adı";
      this.xrTableCell13.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell13.Weight = 1.0;
      this.xrTableCell25.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "Bakım Yapan Usta";
      this.xrTableCell25.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell25.Weight = 1.0;
      this.xrTableCell26.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "Bakım Grubu";
      this.xrTableCell26.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell26.Weight = 1.0;
      this.xrTableRow21.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell28,
        this.xrTableCell29,
        this.xrTableCell31
      });
      this.xrTableRow21.Name = "xrTableRow21";
      this.xrTableRow21.Weight = 1.0;
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.Weight = 1.0;
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.Weight = 1.0;
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.Weight = 1.0;
      this.xrTableRow22.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell32,
        this.xrTableCell35
      });
      this.xrTableRow22.Name = "xrTableRow22";
      this.xrTableRow22.Weight = 1.0;
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.Text = "Yapılan Bakım";
      this.xrTableCell32.Weight = 0.5;
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.Weight = 2.5;
      this.xrTableRow23.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell60
      });
      this.xrTableRow23.Name = "xrTableRow23";
      this.xrTableRow23.Weight = 1.0;
      this.xrTableCell60.Multiline = true;
      this.xrTableCell60.Name = "xrTableCell60";
      this.xrTableCell60.Weight = 3.0;
      this.xrTableRow24.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell61
      });
      this.xrTableRow24.Name = "xrTableRow24";
      this.xrTableRow24.Weight = 1.0;
      this.xrTableCell61.Multiline = true;
      this.xrTableCell61.Name = "xrTableCell61";
      this.xrTableCell61.Weight = 3.0;
      this.xrTableRow25.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell62
      });
      this.xrTableRow25.Name = "xrTableRow25";
      this.xrTableRow25.Weight = 1.0;
      this.xrTableCell62.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel16
      });
      this.xrTableCell62.Multiline = true;
      this.xrTableCell62.Name = "xrTableCell62";
      this.xrTableCell62.Weight = 3.0;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.BorderWidth = 2f;
      this.xrTable2.LocationFloat = new PointFloat(9.999974f, 82.29166f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[7]
      {
        this.xrTableRow5,
        this.xrTableRow11,
        this.xrTableRow6,
        this.xrTableRow10,
        this.xrTableRow9,
        this.xrTableRow8,
        this.xrTableRow7
      });
      this.xrTable2.SizeF = new SizeF(630f, 176.25f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseBorderWidth = false;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell3
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell3.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Yapılan Bakımlar";
      this.xrTableCell3.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell3.Weight = 3.0;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell36,
        this.xrTableCell37,
        this.xrTableCell38
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell36.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      this.xrTableCell36.StylePriority.UseFont = false;
      this.xrTableCell36.StylePriority.UseTextAlignment = false;
      this.xrTableCell36.Text = "Atölye Adı";
      this.xrTableCell36.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell36.Weight = 1.0;
      this.xrTableCell37.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.StylePriority.UseFont = false;
      this.xrTableCell37.StylePriority.UseTextAlignment = false;
      this.xrTableCell37.Text = "Bakım Yapan Usta";
      this.xrTableCell37.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell37.Weight = 1.0;
      this.xrTableCell38.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.StylePriority.UseFont = false;
      this.xrTableCell38.StylePriority.UseTextAlignment = false;
      this.xrTableCell38.Text = "Bakım Grubu";
      this.xrTableCell38.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell38.Weight = 1.0;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell16,
        this.xrTableCell20,
        this.xrTableCell21
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.Weight = 1.0;
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Weight = 1.0;
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.Weight = 1.0;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell33,
        this.xrTableCell34
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      this.xrTableCell33.Text = "Yapılan Bakım";
      this.xrTableCell33.Weight = 0.5;
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      this.xrTableCell34.Weight = 2.5;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell30
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.Weight = 3.0;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell27
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.Weight = 3.0;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell24
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell24.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel15
      });
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.Weight = 3.0;
      this.xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?sofor")
      });
      this.xrLabel4.LocationFloat = new PointFloat(10f, 37.66668f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(146.6667f, 33.99999f);
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "xrLabel4";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?atolyesef")
      });
      this.xrLabel3.LocationFloat = new PointFloat(471.6666f, 37.66668f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(168.3334f, 33.99999f);
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "xrLabel3";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.LocationFloat = new PointFloat(471.6666f, 1.000061f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(168.3334f, 36.66661f);
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "ARACI TESLİM ALAN Atölye Şefi";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel1.LocationFloat = new PointFloat(10f, 1.000061f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(146.6667f, 36.66661f);
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "ARACI TESLİM EDEN Şoför & Opertor";
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 160.8336f;
      this.Detail.Name = "Detail";
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.BorderWidth = 2f;
      this.xrTable1.LocationFloat = new PointFloat(10f, 9.166667f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[4]
      {
        this.xrTableRow1,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow2
      });
      this.xrTable1.SizeF = new SizeF(630f, 100f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseBorderWidth = false;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell1,
        this.xrTableCell2,
        this.xrTableCell17
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "Arac Bilgisi";
      this.xrTableCell1.Weight = 1.0;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?plaka")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 2.0;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?aracBilgisi")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.Text = "xrTableCell17";
      this.xrTableCell17.Weight = 3.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell14,
        this.xrTableCell18,
        this.xrTableCell55,
        this.xrTableCell22,
        this.xrTableCell9
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.Text = "İş Emri Kodu";
      this.xrTableCell7.Weight = 1.0;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isEmirkod")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Text = "xrTableCell8";
      this.xrTableCell8.Weight = 1.0;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.Text = "Giriş Tarihi";
      this.xrTableCell14.Weight = 0.72222231910342261;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?gtarih")
      });
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.Text = "xrTableCell18";
      this.xrTableCell18.Weight = 0.77777768089657739;
      this.xrTableCell55.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?gsaat")
      });
      this.xrTableCell55.Multiline = true;
      this.xrTableCell55.Name = "xrTableCell55";
      this.xrTableCell55.Text = "xrTableCell55";
      this.xrTableCell55.Weight = 0.77301548549107135;
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.RowSpan = 2;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.Text = "Bakım Yeri";
      this.xrTableCell22.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell22.Weight = 0.72698451450892865;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?bakimyeri")
      });
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.RowSpan = 2;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "xrTableCell9";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 1.0;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell10,
        this.xrTableCell11,
        this.xrTableCell15,
        this.xrTableCell19,
        this.xrTableCell56,
        this.xrTableCell23,
        this.xrTableCell12
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.Text = "Kilometre";
      this.xrTableCell10.Weight = 1.0;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?km")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.Text = "xrTableCell11";
      this.xrTableCell11.Weight = 1.0;
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.Text = "Çıkış Tarihi";
      this.xrTableCell15.Weight = 0.72222231910342261;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?ctarih")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.Text = "xrTableCell19";
      this.xrTableCell19.Weight = 0.77777768089657739;
      this.xrTableCell56.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?csaat")
      });
      this.xrTableCell56.Multiline = true;
      this.xrTableCell56.Name = "xrTableCell56";
      this.xrTableCell56.Text = "xrTableCell56";
      this.xrTableCell56.Weight = 0.77301606677827384;
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.Text = "xrTableCell23";
      this.xrTableCell23.Weight = 0.72698393322172616;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.Text = "xrTableCell12";
      this.xrTableCell12.Weight = 1.0;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell4,
        this.xrTableCell5
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Text = "Bildirilen Arıza";
      this.xrTableCell4.Weight = 1.0;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?bariza")
      });
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "xrTableCell5";
      this.xrTableCell5.Weight = 5.0;
      this.plaka.Description = "Parameter1";
      this.plaka.Name = "plaka";
      this.plaka.Type = typeof (int);
      this.plaka.ValueInfo = "0";
      this.aracBilgisi.Description = "Parameter2";
      this.aracBilgisi.Name = "aracBilgisi";
      this.aracBilgisi.Type = typeof (int);
      this.aracBilgisi.ValueInfo = "0";
      this.isEmirkod.Description = "Parameter3";
      this.isEmirkod.Name = "isEmirkod";
      this.isEmirkod.Type = typeof (int);
      this.isEmirkod.ValueInfo = "0";
      this.bariza.Description = "Parameter4";
      this.bariza.Name = "bariza";
      this.bakimyeri.Description = "Parameter5";
      this.bakimyeri.Name = "bakimyeri";
      this.bakimyeri.Type = typeof (int);
      this.bakimyeri.ValueInfo = "0";
      this.km.Description = "Parameter6";
      this.km.Name = "km";
      this.km.Type = typeof (int);
      this.km.ValueInfo = "0";
      this.ctarih.Description = "Parameter7";
      this.ctarih.Name = "ctarih";
      this.ctarih.Type = typeof (int);
      this.ctarih.ValueInfo = "0";
      this.gsaat.Description = "Parameter1";
      this.gsaat.Name = "gsaat";
      this.gsaat.Type = typeof (int);
      this.gsaat.ValueInfo = "0";
      this.csaat.Description = "Parameter2";
      this.csaat.Name = "csaat";
      this.csaat.Type = typeof (int);
      this.csaat.ValueInfo = "0";
      this.sofor.Description = "Parameter1";
      this.sofor.Name = "sofor";
      this.sofor.Type = typeof (int);
      this.sofor.ValueInfo = "0";
      this.atolyesef.Description = "Parameter2";
      this.atolyesef.Name = "atolyesef";
      this.atolyesef.Type = typeof (int);
      this.atolyesef.ValueInfo = "0";
      this.gtarih.Description = "Parameter1";
      this.gtarih.Name = "gtarih";
      this.gtarih.Type = typeof (int);
      this.gtarih.ValueInfo = "0";
      this.xrLabel16.Borders = BorderSide.None;
      this.xrLabel16.LocationFloat = new PointFloat(405.2082f, 1.525879E-05f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(100f, 23f);
      this.xrLabel16.StylePriority.UseBorders = false;
      this.xrLabel16.StylePriority.UseTextAlignment = false;
      this.xrLabel16.Text = "İmza:";
      this.xrLabel16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel17.Borders = BorderSide.None;
      this.xrLabel17.LocationFloat = new PointFloat(405.2082f, 1.525879E-05f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(100f, 23f);
      this.xrLabel17.StylePriority.UseBorders = false;
      this.xrLabel17.StylePriority.UseTextAlignment = false;
      this.xrLabel17.Text = "İmza:";
      this.xrLabel17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel15.Borders = BorderSide.None;
      this.xrLabel15.LocationFloat = new PointFloat(405.2082f, 1.525879E-05f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(100f, 23f);
      this.xrLabel15.StylePriority.UseBorders = false;
      this.xrLabel15.StylePriority.UseTextAlignment = false;
      this.xrLabel15.Text = "İmza:";
      this.xrLabel15.TextAlignment = TextAlignment.MiddleCenter;
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(92, 90, 118, 827);
      this.Parameters.AddRange(new Parameter[12]
      {
        this.plaka,
        this.aracBilgisi,
        this.isEmirkod,
        this.bariza,
        this.bakimyeri,
        this.km,
        this.ctarih,
        this.gsaat,
        this.csaat,
        this.sofor,
        this.atolyesef,
        this.gtarih
      });
      this.Version = "20.1";
      this.xrTable4.EndInit();
      this.xrTable3.EndInit();
      this.xrTable5.EndInit();
      this.xrTable2.EndInit();
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
