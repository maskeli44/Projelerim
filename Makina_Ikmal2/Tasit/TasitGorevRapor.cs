// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Tasit.TasitGorevRapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model.tasitgorevegidenlerTableAdapters;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Tasit
{
  public class TasitGorevRapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRPictureBox xrPictureBox1;
    private XRPictureBox xrPictureBox2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private GroupHeaderBand tablo1;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private GroupHeaderBand tablo2;
    private XRTableCell xrTableCell24;
    private XRTable xrTable3;
    private XRTableRow xrTableRow9;
    private XRTableCell siraNoColumn;
    private XRTableCell adColumn;
    private XRTableCell unvanColumn;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private Parameter sonId;
    private XRLabel xrLabel1;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private SqlDataSource sqlDataSource1;

    public TasitGorevRapor() => this.InitializeComponent();

    private void TasitGorevRapor_Load(object sender, EventArgs e)
    {
    }

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
      SelectQuery selectQuery = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table1 = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table2 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Table table3 = new Table();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Table table4 = new Table();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Table table5 = new Table();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Table table6 = new Table();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Table table7 = new Table();
      Column column25 = new Column();
      ColumnExpression columnExpression25 = new ColumnExpression();
      Table table8 = new Table();
      Column column26 = new Column();
      ColumnExpression columnExpression26 = new ColumnExpression();
      Table table9 = new Table();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Table table10 = new Table();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      Join join8 = new Join();
      RelationColumnInfo relationColumnInfo8 = new RelationColumnInfo();
      Join join9 = new Join();
      RelationColumnInfo relationColumnInfo9 = new RelationColumnInfo();
      Table table11 = new Table();
      Join join10 = new Join();
      RelationColumnInfo relationColumnInfo10 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TasitGorevRapor));
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.xrLabel13 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.Detail = new DetailBand();
      this.xrTable3 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.siraNoColumn = new XRTableCell();
      this.adColumn = new XRTableCell();
      this.unvanColumn = new XRTableCell();
      this.ReportHeader = new ReportHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTable2 = new XRTable();
      this.tablo1 = new GroupHeaderBand();
      this.tablo2 = new GroupHeaderBand();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.sonId = new Parameter();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.xrTable3.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.BeginInit();
      this.TopMargin.HeightF = 41f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[10]
      {
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel1
      });
      this.BottomMargin.HeightF = 174f;
      this.BottomMargin.Name = "BottomMargin";
      this.xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[mudurunvan]")
      });
      this.xrLabel13.LocationFloat = new PointFloat(540.5f, 132.2917f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(100f, 23f);
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "xrLabel13";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[birimamiriunvan]")
      });
      this.xrLabel12.LocationFloat = new PointFloat(121.75f, 132.2917f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(100f, 23f);
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "xrLabel12";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[birimamiri]")
      });
      this.xrLabel11.LocationFloat = new PointFloat(32.06723f, 109.2917f);
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(282.4167f, 23.00001f);
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "xrLabel11";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[muduradsoyad]")
      });
      this.xrLabel10.LocationFloat = new PointFloat(418.6693f, 109.2917f);
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(326.9518f, 23.00001f);
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "xrLabel10";
      this.xrLabel10.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel9.LocationFloat = new PointFloat(540.5f, 86.29169f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(100f, 23f);
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "ONAY";
      this.xrLabel9.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel8.LocationFloat = new PointFloat(121.75f, 86.29169f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(113.5417f, 23f);
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "Aracı Sevk Eden";
      this.xrLabel8.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold | FontStyle.Underline);
      this.xrLabel7.LocationFloat = new PointFloat(0.0f, 65.37501f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(745.6212f, 20.91669f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.Text = "Sürücüler ve görevliler araç içinde sigara içmeyecektir.";
      this.xrLabel6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrLabel6.LocationFloat = new PointFloat(0.3788074f, 41.83337f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(745.6212f, 20.91669f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "Not: Araç sürücüleri ile araçta bulunan görevliler resmi sıfatın gerektirdiği saygınlığı gösterecektir.";
      this.xrLabel5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrLabel5.LocationFloat = new PointFloat(0.3788074f, 20.91669f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(745.6212f, 20.91669f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.Text = "2. Taşıt Görev Emri yetkililerin istemesi halinde gösterilecektir.";
      this.xrLabel1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(0.3788074f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(745.6212f, 20.91669f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "1. Taşıt Görev Emri her görevlendirmede iki nüsha doldurlacak bir nüshası kurumda kalacak, ikinci nüshası araçta bulundurulacaktır.";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable3
      });
      this.Detail.HeightF = 16.4951f;
      this.Detail.Name = "Detail";
      this.Detail.SortFields.AddRange(new GroupField[1]
      {
        new GroupField("", XRColumnSortOrder.Ascending)
      });
      this.xrTable3.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTable3.LocationFloat = new PointFloat(0.3787994f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable3.SizeF = new SizeF(418.6693f, 16.42157f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.siraNoColumn,
        this.adColumn,
        this.unvanColumn
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.siraNoColumn.ExpressionBindings.AddRange(new ExpressionBinding[2]
      {
        new ExpressionBinding("BeforePrint", "Text", ""),
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.siraNoColumn.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.siraNoColumn.Multiline = true;
      this.siraNoColumn.Name = "siraNoColumn";
      this.siraNoColumn.StylePriority.UseFont = false;
      xrSummary.Running = SummaryRunning.Report;
      this.siraNoColumn.Summary = xrSummary;
      this.siraNoColumn.Weight = 0.37073486502472197;
      this.adColumn.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[tasitpersad]")
      });
      this.adColumn.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adColumn.Multiline = true;
      this.adColumn.Name = "adColumn";
      this.adColumn.StylePriority.UseFont = false;
      this.adColumn.Text = "\r\n";
      this.adColumn.Weight = 1.958475641221864;
      this.unvanColumn.Borders = BorderSide.All;
      this.unvanColumn.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[tasitpersunvan]")
      });
      this.unvanColumn.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.unvanColumn.Multiline = true;
      this.unvanColumn.Name = "unvanColumn";
      this.unvanColumn.Padding = new PaddingInfo(1, 0, 0, 0, 100f);
      this.unvanColumn.StylePriority.UseBorders = false;
      this.unvanColumn.StylePriority.UseFont = false;
      this.unvanColumn.StylePriority.UsePadding = false;
      this.unvanColumn.Text = "\r\n";
      this.unvanColumn.Weight = 0.77538404743059031;
      this.ReportHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2
      });
      this.ReportHeader.HeightF = 102.375f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(578.1249f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(133.3333f, 61.20836f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(133.3333f, 38.20836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(336.4583f, 10.00004f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[6]
      {
        this.xrTableRow1,
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow5,
        this.xrTableRow6
      });
      this.xrTable1.SizeF = new SizeF(746f, 100.4583f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.TopCenter;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.LightBlue;
      this.xrTableCell1.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "TAŞIT GÖREV EMRİ";
      this.xrTableCell1.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell1.Weight = 1.0;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell2,
        this.xrTableCell5,
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.BackColor = Color.Transparent;
      this.xrTableCell2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBackColor = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Aracın Plakası";
      this.xrTableCell2.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell2.Weight = 0.20524088541666666;
      this.xrTableCell5.BackColor = Color.Transparent;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrTableCell5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBackColor = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell5.Weight = 0.355978011636828;
      this.xrTableCell3.BackColor = Color.Transparent;
      this.xrTableCell3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBackColor = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Kod";
      this.xrTableCell3.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell3.Weight = 0.12332901636795889;
      this.xrTableCell4.BackColor = Color.Transparent;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrTableCell4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBackColor = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell4.Weight = 0.31545208657854645;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell6,
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell9
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell6.BackColor = Color.Transparent;
      this.xrTableCell6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBackColor = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Şöförün Adı Soyadı";
      this.xrTableCell6.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell6.Weight = 0.20524088541666666;
      this.xrTableCell7.BackColor = Color.Transparent;
      this.xrTableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[sofor]")
      });
      this.xrTableCell7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBackColor = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell7.Weight = 0.355978011636828;
      this.xrTableCell8.BackColor = Color.Transparent;
      this.xrTableCell8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBackColor = false;
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Çıkış Zamanı";
      this.xrTableCell8.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell8.Weight = 0.12332901636795889;
      this.xrTableCell9.BackColor = Color.Transparent;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISZAMANI]")
      });
      this.xrTableCell9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBackColor = false;
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell9.Weight = 0.31545208657854645;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell10,
        this.xrTableCell11,
        this.xrTableCell12,
        this.xrTableCell13
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.BackColor = Color.Transparent;
      this.xrTableCell10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBackColor = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "Görevin Türü";
      this.xrTableCell10.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell10.Weight = 0.20524088541666666;
      this.xrTableCell11.BackColor = Color.Transparent;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GOREVTURU]")
      });
      this.xrTableCell11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBackColor = false;
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell11.Weight = 0.355978011636828;
      this.xrTableCell12.BackColor = Color.Transparent;
      this.xrTableCell12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBackColor = false;
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "Çıkış Km";
      this.xrTableCell12.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell12.Weight = 0.12332901636795889;
      this.xrTableCell13.BackColor = Color.Transparent;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISKM]")
      });
      this.xrTableCell13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBackColor = false;
      this.xrTableCell13.StylePriority.UseFont = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell13.Weight = 0.31545208657854645;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell14,
        this.xrTableCell15,
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell14.BackColor = Color.Transparent;
      this.xrTableCell14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBackColor = false;
      this.xrTableCell14.StylePriority.UseFont = false;
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "Gidilecek Yer";
      this.xrTableCell14.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell14.Weight = 0.20524088541666666;
      this.xrTableCell15.BackColor = Color.Transparent;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GIDILECEKYER]")
      });
      this.xrTableCell15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBackColor = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell15.Weight = 0.355978011636828;
      this.xrTableCell16.BackColor = Color.Transparent;
      this.xrTableCell16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBackColor = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "Dönüş Tarih";
      this.xrTableCell16.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell16.Weight = 0.12332901636795889;
      this.xrTableCell17.BackColor = Color.Transparent;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DONUSZAMANI]")
      });
      this.xrTableCell17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBackColor = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell17.Weight = 0.31545208657854645;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell18,
        this.xrTableCell19,
        this.xrTableCell20,
        this.xrTableCell21
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell18.BackColor = Color.Transparent;
      this.xrTableCell18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBackColor = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.Text = "Ait Olduğu Kuruluş";
      this.xrTableCell18.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell18.Weight = 0.20524088541666666;
      this.xrTableCell19.BackColor = Color.Transparent;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KURUM]")
      });
      this.xrTableCell19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBackColor = false;
      this.xrTableCell19.StylePriority.UseFont = false;
      this.xrTableCell19.StylePriority.UseTextAlignment = false;
      this.xrTableCell19.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell19.Weight = 0.355978011636828;
      this.xrTableCell20.BackColor = Color.Transparent;
      this.xrTableCell20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseBackColor = false;
      this.xrTableCell20.StylePriority.UseFont = false;
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.Text = "Dönüş Km";
      this.xrTableCell20.TextAlignment = TextAlignment.BottomRight;
      this.xrTableCell20.Weight = 0.12332901636795889;
      this.xrTableCell21.BackColor = Color.Transparent;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DONUSKM]")
      });
      this.xrTableCell21.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBackColor = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.StylePriority.UseTextAlignment = false;
      this.xrTableCell21.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell21.Weight = 0.31545208657854645;
      this.xrTableCell26.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell26.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "Ünvanı";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 0.76975763028666211;
      this.xrTableCell25.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell25.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "Adı Soyadı";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 1.9372459748368309;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell24,
        this.xrTableCell25,
        this.xrTableCell26
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 0.5;
      this.xrTableCell24.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell24.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.StylePriority.UseFont = false;
      this.xrTableCell24.StylePriority.UseTextAlignment = false;
      this.xrTableCell24.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell24.Weight = 0.36671620132865662;
      this.xrTableCell23.Borders = BorderSide.All;
      this.xrTableCell23.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.StylePriority.UseTextAlignment = false;
      this.xrTableCell23.Text = "GÖREVLİ PERSONELİN";
      this.xrTableCell23.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell23.Weight = 2.7070035911330805;
      this.xrTableCell22.Borders = BorderSide.All;
      this.xrTableCell22.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.RowSpan = 2;
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.StylePriority.UseFont = false;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.Text = "Sıra \r\nNo";
      this.xrTableCell22.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell22.Weight = 0.36671621531906934;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell22,
        this.xrTableCell23
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 0.5;
      this.xrTable2.LocationFloat = new PointFloat(0.3787994f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[2]
      {
        this.xrTableRow7,
        this.xrTableRow8
      });
      this.xrTable2.SizeF = new SizeF(419.0481f, 37.00984f);
      this.tablo1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.tablo1.HeightF = 104.3332f;
      this.tablo1.Level = 1;
      this.tablo1.Name = "tablo1";
      this.tablo2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.tablo2.HeightF = 37.21825f;
      this.tablo2.Name = "tablo2";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.sonId.AllowNull = true;
      this.sonId.Description = "sonID";
      this.sonId.Name = "sonId";
      this.sonId.Type = typeof (int);
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table1.MetaSerializable = "<Meta X=\"-110\" Y=\"40\" Width=\"140\" Height=\"683\" />";
      table1.Name = "TBLTASITGOREV";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "KOD";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "KURUM";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "GOREVTURU";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "GIDILECEKYER";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "CIKISZAMANI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "CIKISTARIH";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "CIKISSAAT";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "CIKISKM";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "DONUSZAMANI";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "DONUSTARIH";
      columnExpression11.Table = table1;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "DONUSSAAT";
      columnExpression12.Table = table1;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "DONUSKM";
      columnExpression13.Table = table1;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "MESAIBITISSAATI";
      columnExpression14.Table = table1;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "GUNUNADI";
      columnExpression15.Table = table1;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "MESAIMIKTARI";
      columnExpression16.Table = table1;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "MUDONAYZAMAN";
      columnExpression17.Table = table1;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "GOREVGRUPID";
      columnExpression18.Table = table1;
      column18.Expression = (ExpressionBase) columnExpression18;
      column19.Alias = "sofor";
      columnExpression19.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"200\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression19.Table = table2;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "PLAKA";
      table3.MetaSerializable = "<Meta X=\"45\" Y=\"30\" Width=\"125\" Height=\"1563\" />";
      table3.Name = "TBLARACLAR";
      columnExpression20.Table = table3;
      column20.Expression = (ExpressionBase) columnExpression20;
      column21.Alias = "muduradsoyad";
      columnExpression21.ColumnName = "ADISOYADI";
      table4.Alias = "TBLPERSONEL_1";
      table4.MetaSerializable = "<Meta X=\"510\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression21.Table = table4;
      column21.Expression = (ExpressionBase) columnExpression21;
      column22.Alias = "mudurunvan";
      columnExpression22.ColumnName = "UNVAN";
      table5.Alias = "TBLPERSUNVAN_1";
      table5.MetaSerializable = "<Meta X=\"1285\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table5.Name = "TBLPERSUNVAN";
      columnExpression22.Table = table5;
      column22.Expression = (ExpressionBase) columnExpression22;
      column23.Alias = "birimamiri";
      columnExpression23.ColumnName = "ADISOYADI";
      table6.Alias = "TBLPERSONEL_2";
      table6.MetaSerializable = "<Meta X=\"665\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression23.Table = table6;
      column23.Expression = (ExpressionBase) columnExpression23;
      column24.Alias = "birimamiriunvan";
      columnExpression24.ColumnName = "UNVAN";
      table7.Alias = "TBLPERSUNVAN_2";
      table7.MetaSerializable = "<Meta X=\"1440\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table7.Name = "TBLPERSUNVAN";
      columnExpression24.Table = table7;
      column24.Expression = (ExpressionBase) columnExpression24;
      column25.Alias = "tasitpersad";
      columnExpression25.ColumnName = "ADISOYADI";
      table8.Alias = "TBLPERSONEL_3";
      table8.MetaSerializable = "<Meta X=\"1130\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table8.Name = "TBLPERSONEL";
      columnExpression25.Table = table8;
      column25.Expression = (ExpressionBase) columnExpression25;
      column26.Alias = "tasitpersunvan";
      columnExpression26.ColumnName = "UNVAN";
      table9.MetaSerializable = "<Meta X=\"975\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table9.Name = "TBLPERSUNVAN";
      columnExpression26.Table = table9;
      column26.Expression = (ExpressionBase) columnExpression26;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.Columns.Add((ColumnBase) column8);
      selectQuery.Columns.Add((ColumnBase) column9);
      selectQuery.Columns.Add((ColumnBase) column10);
      selectQuery.Columns.Add((ColumnBase) column11);
      selectQuery.Columns.Add((ColumnBase) column12);
      selectQuery.Columns.Add((ColumnBase) column13);
      selectQuery.Columns.Add((ColumnBase) column14);
      selectQuery.Columns.Add((ColumnBase) column15);
      selectQuery.Columns.Add((ColumnBase) column16);
      selectQuery.Columns.Add((ColumnBase) column17);
      selectQuery.Columns.Add((ColumnBase) column18);
      selectQuery.Columns.Add((ColumnBase) column19);
      selectQuery.Columns.Add((ColumnBase) column20);
      selectQuery.Columns.Add((ColumnBase) column21);
      selectQuery.Columns.Add((ColumnBase) column22);
      selectQuery.Columns.Add((ColumnBase) column23);
      selectQuery.Columns.Add((ColumnBase) column24);
      selectQuery.Columns.Add((ColumnBase) column25);
      selectQuery.Columns.Add((ColumnBase) column26);
      selectQuery.Name = "TBLTASITGOREV";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "PLAKAID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BIRIMAMIRIID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table6;
      join2.Parent = table1;
      join2.Type = JoinType.LeftOuter;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MUDURID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      join3.Type = JoinType.LeftOuter;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "UNVANID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table9;
      table10.MetaSerializable = "<Meta X=\"820\" Y=\"30\" Width=\"125\" Height=\"143\" />";
      table10.Name = "TBLTASITPERS";
      join4.Parent = table10;
      join4.Type = JoinType.LeftOuter;
      relationColumnInfo5.NestedKeyColumn = "TASITID";
      relationColumnInfo5.ParentKeyColumn = "ID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table10;
      join5.Parent = table1;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "PERSONELID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table8;
      join6.Parent = table10;
      join6.Type = JoinType.LeftOuter;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "UNVANID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table7;
      join7.Parent = table6;
      join7.Type = JoinType.LeftOuter;
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "UNVANID";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table5;
      join8.Parent = table4;
      join8.Type = JoinType.LeftOuter;
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "BIRIMID";
      join9.KeyColumns.Add(relationColumnInfo9);
      table11.MetaSerializable = "<Meta X=\"355\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table11.Name = "TBLBELDBIRIMLER";
      join9.Nested = table11;
      join9.Parent = table1;
      join9.Type = JoinType.LeftOuter;
      relationColumnInfo10.NestedKeyColumn = "ID";
      relationColumnInfo10.ParentKeyColumn = "SOFORID";
      join10.KeyColumns.Add(relationColumnInfo10);
      join10.Nested = table2;
      join10.Parent = table1;
      join10.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Relations.Add(join6);
      selectQuery.Relations.Add(join7);
      selectQuery.Relations.Add(join8);
      selectQuery.Relations.Add(join9);
      selectQuery.Relations.Add(join10);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table11);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table10);
      selectQuery.Tables.Add(table9);
      selectQuery.Tables.Add(table8);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table7);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Bands.AddRange(new Band[6]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.ReportHeader,
        (Band) this.tablo1,
        (Band) this.tablo2
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataAdapter = (object) this.dataTable1TableAdapter;
      this.DataMember = "TBLTASITGOREV";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?sonId";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(47, 34, 41, 174);
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5Rotated;
      this.Parameters.AddRange(new Parameter[1]
      {
        this.sonId
      });
      this.Version = "20.1";
      this.xrTable3.EndInit();
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.EndInit();
    }
  }
}
