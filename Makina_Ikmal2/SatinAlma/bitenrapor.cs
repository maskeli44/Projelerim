// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.bitenrapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class bitenrapor : XtraReport
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
    private isemirmalzeme isemirmalzeme1;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private BindingSource bindingSource1;
    private Parameter isemir_id;
    private ReportHeaderBand ReportHeader;
    private ReportFooterBand ReportFooter;
    private XRTable xrTable2;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;

    public bitenrapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      XRSummary xrSummary = new XRSummary();
      this.TopMargin = new TopMarginBand();
      this.xrLabel14 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable2 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
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
      this.isemirmalzeme1 = new isemirmalzeme();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.bindingSource1 = new BindingSource(this.components);
      this.isemir_id = new Parameter();
      this.ReportHeader = new ReportHeaderBand();
      this.xrLabel1 = new XRLabel();
      this.ReportFooter = new ReportFooterBand();
      this.xrLabel2 = new XRLabel();
      this.xrTable2.BeginInit();
      this.xrTable1.BeginInit();
      this.isemirmalzeme1.BeginInit();
      ((ISupportInitialize) this.bindingSource1).BeginInit();
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
      this.xrPictureBox2.LocationFloat = new PointFloat(504.1541f, 10f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(145.8459f, 90f);
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 10f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 90f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.HeightF = 0.0f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.Detail.HeightF = 25f;
      this.Detail.MultiColumn.ColumnWidth = 5f;
      this.Detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
      this.Detail.Name = "Detail";
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.BorderWidth = 2f;
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable2.SizeF = new SizeF(650f, 25f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseBorderWidth = false;
      this.xrTable2.StylePriority.UseTextAlignment = false;
      this.xrTable2.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[8]
      {
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell13,
        this.xrTableCell16,
        this.xrTableCell20,
        this.xrTableCell21,
        this.xrTableCell24,
        this.xrTableCell25
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "xrTableCell5";
      this.xrTableCell5.Weight = 0.71282070453350355;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.Text = "İş Emri Kodu";
      this.xrTableCell6.Weight = 0.93717913114107576;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isEmirkod")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.Text = "xrTableCell8";
      this.xrTableCell13.Weight = 0.8384617849496695;
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.Text = "Giriş Tarihi";
      this.xrTableCell16.Weight = 0.82991454463302;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Text = "xrTableCell18";
      this.xrTableCell20.Weight = 1.1816238347427312;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZURTTARIH]")
      });
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.Text = "xrTableCell55";
      this.xrTableCell21.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell21.Weight = 0.77301548549107135;
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.RowSpan = 2;
      this.xrTableCell24.StylePriority.UseTextAlignment = false;
      this.xrTableCell24.Text = "Bakım Yeri";
      this.xrTableCell24.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell24.Weight = 0.72698451450892865;
      this.xrTableCell25.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TUTAR]")
      });
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.RowSpan = 2;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "xrTableCell9";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 1.0;
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.BorderWidth = 2f;
      this.xrTable1.LocationFloat = new PointFloat(10f, 25f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[3]
      {
        this.xrTableRow1,
        this.xrTableRow3,
        this.xrTableRow4
      });
      this.xrTable1.SizeF = new SizeF(630f, 75f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseBorderWidth = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleCenter;
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
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Arac Bilgisi";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleLeft;
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
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "İş Emri Kodu";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleLeft;
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
      this.xrTableCell18.TextFormatString = "{0:d MMMM yyyy dddd}";
      this.xrTableCell18.Weight = 0.77777768089657739;
      this.xrTableCell55.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?gsaat")
      });
      this.xrTableCell55.Multiline = true;
      this.xrTableCell55.Name = "xrTableCell55";
      this.xrTableCell55.Text = "xrTableCell55";
      this.xrTableCell55.TextFormatString = "{0:HH:mm}";
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
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "Kilometre";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleLeft;
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
      this.bariza.Type = typeof (int);
      this.bariza.ValueInfo = "0";
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
      this.isemirmalzeme1.DataSetName = "isemirmalzeme";
      this.isemirmalzeme1.EnforceConstraints = false;
      this.isemirmalzeme1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.isemir_id.Description = "Parameter1";
      this.isemir_id.Name = "isemir_id";
      this.isemir_id.Type = typeof (int);
      this.isemir_id.ValueInfo = "0";
      this.ReportHeader.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrLabel1,
        (XRControl) this.xrTable1
      });
      this.ReportHeader.HeightF = 185.0001f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrLabel1.Borders = BorderSide.All;
      this.xrLabel1.BorderWidth = 2f;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(0.0f, 149.5001f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(650f, 35.5f);
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseBorderWidth = false;
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "Forum";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.ReportFooter.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel2
      });
      this.ReportFooter.Name = "ReportFooter";
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([TUTAR])")
      });
      this.xrLabel2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrLabel2.LocationFloat = new PointFloat(557.1428f, 0.0f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(92.85718f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel2.Summary = xrSummary;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel2.TextFormatString = "{0:c0}";
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.ReportHeader,
        (Band) this.ReportFooter
      });
      this.ComponentStorage.AddRange(new IComponent[2]
      {
        (IComponent) this.isemirmalzeme1,
        (IComponent) this.bindingSource1
      });
      this.DataAdapter = (object) this.dataTable1TableAdapter;
      this.DataMember = "DataTable1";
      this.DataSource = (object) this.isemirmalzeme1;
      this.FilterString = "[ISEMRIID] = ?isemir_id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(100, 100, 118, 0);
      this.Parameters.AddRange(new Parameter[13]
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
        this.gtarih,
        this.isemir_id
      });
      this.Version = "20.1";
      this.xrTable2.EndInit();
      this.xrTable1.EndInit();
      this.isemirmalzeme1.EndInit();
      ((ISupportInitialize) this.bindingSource1).EndInit();
      this.EndInit();
    }
  }
}
