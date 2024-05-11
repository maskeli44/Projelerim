// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.A4_Rapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Depo
{
  public class A4_Rapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private GroupHeaderBand GroupHeader1;
    private DetailBand Detail;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRTable table6;
    private XRTableRow tableRow6;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTable table5;
    private XRTableRow tableRow5;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTable table4;
    private XRTableRow tableRow4;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRLabel xrLabel1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTable table8;
    private XRTableRow tableRow8;
    private XRTableCell xrTableCell2;
    private XRTableCell tableCell20;
    private XRTableCell tableCell21;
    private XRTableCell tableCell23;
    private XRTableCell tableCell24;
    private XRTableCell xrTableCell1;
    private XRTableCell tableCell25;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel14;
    private Parameter id;
    private PageFooterBand PageFooter;

    public A4_Rapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      CustomSqlQuery customSqlQuery = new CustomSqlQuery();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (A4_Rapor));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.table4 = new XRTable();
      this.tableRow4 = new XRTableRow();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.xrLabel1 = new XRLabel();
      this.table5 = new XRTable();
      this.tableRow5 = new XRTableRow();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.table6 = new XRTable();
      this.tableRow6 = new XRTableRow();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table8 = new XRTable();
      this.tableRow8 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.tableCell20 = new XRTableCell();
      this.tableCell21 = new XRTableCell();
      this.tableCell23 = new XRTableCell();
      this.tableCell24 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell25 = new XRTableCell();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.id = new Parameter();
      this.PageFooter = new PageFooterBand();
      this.table4.BeginInit();
      this.table3.BeginInit();
      this.table1.BeginInit();
      this.table5.BeginInit();
      this.table6.BeginInit();
      this.table2.BeginInit();
      this.xrTable1.BeginInit();
      this.table8.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      customSqlQuery.Name = "Query";
      customSqlQuery.Sql = componentResourceManager.GetString("customSqlQuery1.Sql");
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) customSqlQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(75, 75, 75);
      this.Title.Name = "Title";
      this.DetailCaption1.BackColor = Color.FromArgb(75, 75, 75);
      this.DetailCaption1.BorderColor = Color.White;
      this.DetailCaption1.Borders = BorderSide.Left;
      this.DetailCaption1.BorderWidth = 2f;
      this.DetailCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.DetailCaption1.ForeColor = Color.White;
      this.DetailCaption1.Name = "DetailCaption1";
      this.DetailCaption1.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailData1.BorderColor = Color.Transparent;
      this.DetailData1.Borders = BorderSide.Left;
      this.DetailData1.BorderWidth = 2f;
      this.DetailData1.Font = new Font("Arial", 8.25f);
      this.DetailData1.ForeColor = Color.Black;
      this.DetailData1.Name = "DetailData1";
      this.DetailData1.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailData3_Odd.BackColor = Color.FromArgb(231, 231, 231);
      this.DetailData3_Odd.BorderColor = Color.Transparent;
      this.DetailData3_Odd.Borders = BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1f;
      this.DetailData3_Odd.Font = new Font("Arial", 8.25f);
      this.DetailData3_Odd.ForeColor = Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData3_Odd.TextAlignment = TextAlignment.MiddleLeft;
      this.PageInfo.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.PageInfo.ForeColor = Color.FromArgb(75, 75, 75);
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel6
      });
      this.TopMargin.HeightF = 99f;
      this.TopMargin.Name = "TopMargin";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(10f, 29f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(78.03445f, 62.33334f);
      this.xrPictureBox2.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(730.132f, 29f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(74.66675f, 62.33334f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel4.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(110f, 29f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(594.7987f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "T.C.";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel5.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(110f, 52f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(594.7987f, 23f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ BAŞKANLIĞI";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel6.LocationFloat = new PointFloat(111.1249f, 76f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(593.6738f, 23f);
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "Destek Hizmetleri Daire Başkanlığı Makine İkmal Şube Müdürlüğü ";
      this.xrLabel6.TextAlignment = TextAlignment.TopCenter;
      this.BottomMargin.HeightF = 9f;
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.table4,
        (XRControl) this.table3,
        (XRControl) this.table1,
        (XRControl) this.xrLabel1,
        (XRControl) this.table5,
        (XRControl) this.table6,
        (XRControl) this.table2
      });
      this.ReportHeader.HeightF = 78.33338f;
      this.ReportHeader.Name = "ReportHeader";
      this.table4.LocationFloat = new PointFloat(331.9893f, 51.99998f);
      this.table4.Name = "table4";
      this.table4.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow4
      });
      this.table4.SizeF = new SizeF(274.1774f, 25f);
      this.table4.StylePriority.UseTextAlignment = false;
      this.table4.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell7,
        this.tableCell8
      });
      this.tableRow4.Name = "tableRow4";
      this.tableRow4.Weight = 1.0;
      this.tableCell7.BackColor = Color.White;
      this.tableCell7.Borders = BorderSide.All;
      this.tableCell7.BorderWidth = 1f;
      this.tableCell7.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell7.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StylePriority.UseBackColor = false;
      this.tableCell7.StylePriority.UseBorders = false;
      this.tableCell7.StylePriority.UseBorderWidth = false;
      this.tableCell7.StylePriority.UseFont = false;
      this.tableCell7.StylePriority.UseForeColor = false;
      this.tableCell7.Text = " TARIH";
      this.tableCell7.Weight = 0.09438173939241494;
      this.tableCell8.BackColor = Color.White;
      this.tableCell8.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell8.Borders = BorderSide.All;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.tableCell8.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell8.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StylePriority.UseBackColor = false;
      this.tableCell8.StylePriority.UseBorderColor = false;
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.StylePriority.UseFont = false;
      this.tableCell8.StylePriority.UseForeColor = false;
      this.tableCell8.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell8.Weight = 0.34290272564379659;
      this.table3.LocationFloat = new PointFloat(606.1667f, 51.99995f);
      this.table3.Name = "table3";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(198.8333f, 25f);
      this.table3.StylePriority.UseTextAlignment = false;
      this.table3.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow3.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell5,
        this.tableCell6
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 1.0;
      this.tableCell5.BackColor = Color.White;
      this.tableCell5.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell5.Borders = BorderSide.All;
      this.tableCell5.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell5.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StylePriority.UseBackColor = false;
      this.tableCell5.StylePriority.UseBorderColor = false;
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.StylePriority.UseFont = false;
      this.tableCell5.StylePriority.UseForeColor = false;
      this.tableCell5.Text = " SAAT";
      this.tableCell5.Weight = 0.16171814621763719;
      this.tableCell6.BackColor = Color.White;
      this.tableCell6.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell6.Borders = BorderSide.All;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAAT]")
      });
      this.tableCell6.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell6.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StylePriority.UseBackColor = false;
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseFont = false;
      this.tableCell6.StylePriority.UseForeColor = false;
      this.tableCell6.TextFormatString = "{0:HH:mm}";
      this.tableCell6.Weight = 0.43008028324010728;
      this.table1.LocationFloat = new PointFloat(0.0f, 52f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(123.0355f, 25f);
      this.table1.StylePriority.UseTextAlignment = false;
      this.table1.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell1
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.3000000850132551;
      this.tableCell1.BackColor = Color.White;
      this.tableCell1.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell1.Borders = BorderSide.All;
      this.tableCell1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell1.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StylePriority.UseBackColor = false;
      this.tableCell1.StylePriority.UseBorderColor = false;
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.StylePriority.UseFont = false;
      this.tableCell1.StylePriority.UseForeColor = false;
      this.tableCell1.Text = " KOD";
      this.tableCell1.Weight = 0.3693915676589889;
      this.xrLabel1.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrLabel1.Borders = BorderSide.All;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(123.0355f, 51.99995f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(208.9538f, 24.99995f);
      this.xrLabel1.StylePriority.UseBorderColor = false;
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "xrLabel1";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleLeft;
      this.table5.LocationFloat = new PointFloat(0.0f, 27f);
      this.table5.Name = "table5";
      this.table5.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow5
      });
      this.table5.SizeF = new SizeF(804.7988f, 25f);
      this.table5.StylePriority.UseTextAlignment = false;
      this.table5.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell9,
        this.tableCell10
      });
      this.tableRow5.Name = "tableRow5";
      this.tableRow5.Weight = 1.0;
      this.tableCell9.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell9.Borders = BorderSide.All;
      this.tableCell9.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StylePriority.UseBorderColor = false;
      this.tableCell9.StylePriority.UseBorders = false;
      this.tableCell9.StylePriority.UseFont = false;
      this.tableCell9.Text = "ARACACIKLAMA";
      this.tableCell9.Weight = 0.26998566737660362;
      this.tableCell10.BackColor = Color.White;
      this.tableCell10.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell10.Borders = BorderSide.All;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell10.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StylePriority.UseBackColor = false;
      this.tableCell10.StylePriority.UseBorderColor = false;
      this.tableCell10.StylePriority.UseBorders = false;
      this.tableCell10.StylePriority.UseForeColor = false;
      this.tableCell10.Weight = 1.0135851765404822;
      this.table6.LocationFloat = new PointFloat(0.0f, 2f);
      this.table6.Name = "table6";
      this.table6.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow6
      });
      this.table6.SizeF = new SizeF(391.1667f, 25f);
      this.table6.StylePriority.UseTextAlignment = false;
      this.table6.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell11,
        this.tableCell12
      });
      this.tableRow6.Name = "tableRow6";
      this.tableRow6.Weight = 1.0;
      this.tableCell11.BackColor = Color.White;
      this.tableCell11.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell11.Borders = BorderSide.All;
      this.tableCell11.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell11.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StylePriority.UseBackColor = false;
      this.tableCell11.StylePriority.UseBorderColor = false;
      this.tableCell11.StylePriority.UseBorders = false;
      this.tableCell11.StylePriority.UseFont = false;
      this.tableCell11.StylePriority.UseForeColor = false;
      this.tableCell11.Text = "PLAKA";
      this.tableCell11.Weight = 0.14040584172673376;
      this.tableCell12.BackColor = Color.White;
      this.tableCell12.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell12.Borders = BorderSide.All;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "   [PLAKA]  + [BOLUMADI]")
      });
      this.tableCell12.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell12.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StylePriority.UseBackColor = false;
      this.tableCell12.StylePriority.UseBorderColor = false;
      this.tableCell12.StylePriority.UseBorders = false;
      this.tableCell12.StylePriority.UseFont = false;
      this.tableCell12.StylePriority.UseForeColor = false;
      this.tableCell12.Text = "[KOD]";
      this.tableCell12.Weight = 0.48346454326168364;
      this.table2.LocationFloat = new PointFloat(391.1667f, 1.999995f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(413.6321f, 25f);
      this.table2.StylePriority.UseTextAlignment = false;
      this.table2.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell3,
        this.tableCell4
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.tableCell3.BackColor = Color.White;
      this.tableCell3.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell3.Borders = BorderSide.All;
      this.tableCell3.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell3.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StylePriority.UseBackColor = false;
      this.tableCell3.StylePriority.UseBorderColor = false;
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.StylePriority.UseFont = false;
      this.tableCell3.StylePriority.UseForeColor = false;
      this.tableCell3.Text = "TBLISEMRI KOD";
      this.tableCell3.Weight = 0.23313568933992757;
      this.tableCell4.BackColor = Color.White;
      this.tableCell4.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell4.Borders = BorderSide.All;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "    [TBLISEMRI_KOD]")
      });
      this.tableCell4.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell4.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StylePriority.UseBackColor = false;
      this.tableCell4.StylePriority.UseBorderColor = false;
      this.tableCell4.StylePriority.UseBorders = false;
      this.tableCell4.StylePriority.UseFont = false;
      this.tableCell4.StylePriority.UseForeColor = false;
      this.tableCell4.Weight = 0.43052357022499993;
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 25f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(804.7988f, 25f);
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell3,
        this.xrTableCell4,
        this.xrTableCell6,
        this.xrTableCell8,
        this.xrTableCell12,
        this.xrTableCell9,
        this.xrTableCell10
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell3.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell3.Borders = BorderSide.All;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorderColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.Text = "S.No";
      this.xrTableCell3.Weight = 0.49100397941658952;
      this.xrTableCell4.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell4.Borders = BorderSide.All;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorderColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.Text = "Malzeme Adı";
      this.xrTableCell4.Weight = 4.2573994863374454;
      this.xrTableCell6.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell6.Borders = BorderSide.All;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorderColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.Text = "Açıklama";
      this.xrTableCell6.Weight = 2.5722254562911475;
      this.xrTableCell8.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell8.Borders = BorderSide.All;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorderColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.Text = "Birim";
      this.xrTableCell8.Weight = 0.64047549770225043;
      this.xrTableCell12.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell12.Borders = BorderSide.All;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorderColor = false;
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.Text = "Miktar";
      this.xrTableCell12.Weight = 0.667952843681841;
      this.xrTableCell9.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell9.Borders = BorderSide.All;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorderColor = false;
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.Text = "Fiyat";
      this.xrTableCell9.Weight = 0.7269417903834805;
      this.xrTableCell10.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell10.Borders = BorderSide.All;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorderColor = false;
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.Text = "Tutar";
      this.xrTableCell10.Weight = 0.74185291065490455;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table8
      });
      this.Detail.HeightF = 15f;
      this.Detail.Name = "Detail";
      this.table8.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table8.Name = "table8";
      this.table8.OddStyleName = "DetailData3_Odd";
      this.table8.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow8
      });
      this.table8.SizeF = new SizeF(804.7988f, 15f);
      this.table8.StylePriority.UseTextAlignment = false;
      this.table8.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow8.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell2,
        this.tableCell20,
        this.tableCell21,
        this.tableCell23,
        this.tableCell24,
        this.xrTableCell1,
        this.tableCell25
      });
      this.tableRow8.Name = "tableRow8";
      this.tableRow8.Weight = 11.5;
      this.xrTableCell2.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.BorderWidth = 1f;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.StylePriority.UseBorderColor = false;
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseBorderWidth = false;
      xrSummary.Running = SummaryRunning.Group;
      this.xrTableCell2.Summary = xrSummary;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 0.064746990935825033;
      this.tableCell20.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell20.Borders = BorderSide.All;
      this.tableCell20.BorderWidth = 1f;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "DetailData1";
      this.tableCell20.StylePriority.UseBorderColor = false;
      this.tableCell20.StylePriority.UseBorders = false;
      this.tableCell20.StylePriority.UseBorderWidth = false;
      this.tableCell20.Weight = 0.56140853262310275;
      this.tableCell21.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell21.Borders = BorderSide.All;
      this.tableCell21.BorderWidth = 1f;
      this.tableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZACIKLAMA]")
      });
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "DetailData1";
      this.tableCell21.StylePriority.UseBorderColor = false;
      this.tableCell21.StylePriority.UseBorders = false;
      this.tableCell21.StylePriority.UseBorderWidth = false;
      this.tableCell21.Weight = 0.33919041562518665;
      this.tableCell23.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell23.Borders = BorderSide.All;
      this.tableCell23.BorderWidth = 1f;
      this.tableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailData1";
      this.tableCell23.StylePriority.UseBorderColor = false;
      this.tableCell23.StylePriority.UseBorders = false;
      this.tableCell23.StylePriority.UseBorderWidth = false;
      this.tableCell23.Weight = 0.084457289877590935;
      this.tableCell24.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell24.Borders = BorderSide.All;
      this.tableCell24.BorderWidth = 1f;
      this.tableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell24.Name = "tableCell24";
      this.tableCell24.StyleName = "DetailData1";
      this.tableCell24.StylePriority.UseBorderColor = false;
      this.tableCell24.StylePriority.UseBorders = false;
      this.tableCell24.StylePriority.UseBorderWidth = false;
      this.tableCell24.TextFormatString = "{0:#.00}";
      this.tableCell24.Weight = 0.08808051220546953;
      this.xrTableCell1.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.BorderWidth = 1f;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailData1";
      this.xrTableCell1.StylePriority.UseBorderColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseBorderWidth = false;
      this.xrTableCell1.Weight = 0.095859381332280613;
      this.tableCell25.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell25.Borders = BorderSide.All;
      this.tableCell25.BorderWidth = 1f;
      this.tableCell25.Name = "tableCell25";
      this.tableCell25.StyleName = "DetailData1";
      this.tableCell25.StylePriority.UseBorderColor = false;
      this.tableCell25.StylePriority.UseBorders = false;
      this.tableCell25.StylePriority.UseBorderWidth = false;
      this.tableCell25.Weight = 0.097825580980742372;
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[mudur]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(607.3952f, 62.8334f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(177.6048f, 23f);
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(622.8334f, 39.83332f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(145f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Şube Müdür";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[atolye]")
      });
      this.xrLabel9.LocationFloat = new PointFloat(391.6633f, 64.49997f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(179.6898f, 23f);
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "xrLabel2";
      this.xrLabel9.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(409.8788f, 41.50009f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(145f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "Atölye Şefi";
      this.xrLabel8.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[talepedenusta]")
      });
      this.xrLabel11.LocationFloat = new PointFloat(211.3858f, 64.49997f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(173.8987f, 22.99994f);
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "xrLabel2";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(228.4476f, 41.50009f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(145f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "Talep Eden Usta";
      this.xrLabel10.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[depoyet]")
      });
      this.xrLabel13.LocationFloat = new PointFloat(22.21911f, 64.49997f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(173.8987f, 22.99994f);
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "xrLabel2";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel12.LocationFloat = new PointFloat(22.21911f, 41.50009f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(184.9734f, 22.99991f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "Ambarda Mevcudu Yoktur";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel14.LocationFloat = new PointFloat(40.94765f, 11.50009f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(145f, 23f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Ambar Yetkilisi";
      this.xrLabel14.TextAlignment = TextAlignment.TopCenter;
      this.id.Description = "Parameter1";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.PageFooter.Controls.AddRange(new XRControl[9]
      {
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel3
      });
      this.PageFooter.Name = "PageFooter";
      this.Bands.AddRange(new Band[6]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.Detail,
        (Band) this.PageFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "Query";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPFISID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(23, 22, 99, 9);
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.Title,
        this.DetailCaption1,
        this.DetailData1,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.table4.EndInit();
      this.table3.EndInit();
      this.table1.EndInit();
      this.table5.EndInit();
      this.table6.EndInit();
      this.table2.EndInit();
      this.xrTable1.EndInit();
      this.table8.EndInit();
      this.EndInit();
    }
  }
}
