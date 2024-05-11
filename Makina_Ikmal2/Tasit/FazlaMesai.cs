// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Tasit.FazlaMesai
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

namespace Makina_Ikmal.Tasit
{
  public class FazlaMesai : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRTable xrTable2;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTable xrTable3;
    private XRTableRow xrTableRow9;
    private XRTableCell adColumn;
    private XRTableCell unvanColumn;
    private ReportHeaderBand ReportHeader;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell10;
    private XRLine xrLine1;
    private Parameter iseBaslama;
    private Parameter isiBitirme;
    private Parameter isSuresi;
    private Parameter yapilacakIs;
    private Parameter tasitSonId;
    private SqlDataSource sqlDataSource1;
    private XRLabel xrLabel1;
    private GroupHeaderBand GroupHeader2;
    private XRLabel xrLabel5;
    private Parameter simdikiTarih;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private Parameter yetkili;
    private Parameter yetkiliUnvan;
    private Parameter subeMudur;
    private Parameter subeMudurUnvan;
    private ReportFooterBand ReportFooter;

    public FazlaMesai() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      SelectQuery selectQuery = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table1 = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Table table2 = new Table();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Table table3 = new Table();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table4 = new Table();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FazlaMesai));
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable3 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.adColumn = new XRTableCell();
      this.unvanColumn = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.ReportHeader = new ReportHeaderBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLine1 = new XRLine();
      this.xrTable4 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.iseBaslama = new Parameter();
      this.isiBitirme = new Parameter();
      this.isSuresi = new Parameter();
      this.yapilacakIs = new Parameter();
      this.tasitSonId = new Parameter();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.GroupHeader2 = new GroupHeaderBand();
      this.xrLabel1 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.simdikiTarih = new Parameter();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.yetkili = new Parameter();
      this.yetkiliUnvan = new Parameter();
      this.subeMudur = new Parameter();
      this.subeMudurUnvan = new Parameter();
      this.ReportFooter = new ReportFooterBand();
      this.xrTable3.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.TopMargin.HeightF = 51.04167f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 109.0783f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable3
      });
      this.Detail.HeightF = 26.42157f;
      this.Detail.Name = "Detail";
      this.xrTable3.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTable3.LocationFloat = new PointFloat(9.536743E-05f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable3.SizeF = new SizeF(747.9999f, 26.42157f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.adColumn,
        this.unvanColumn,
        this.xrTableCell11
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.adColumn.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.adColumn.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.adColumn.Multiline = true;
      this.adColumn.Name = "adColumn";
      this.adColumn.StylePriority.UseBorders = false;
      this.adColumn.Weight = 1.7327664942355767;
      this.unvanColumn.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.unvanColumn.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.unvanColumn.Multiline = true;
      this.unvanColumn.Name = "unvanColumn";
      this.unvanColumn.StylePriority.UseBorders = false;
      this.unvanColumn.Text = "\r\n";
      this.unvanColumn.Weight = 1.0010931944168777;
      this.xrTableCell11.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.Weight = 0.77538404743059031;
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 42.70833f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable2.SizeF = new SizeF(747.9999f, 29.96324f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell25,
        this.xrTableCell26,
        this.xrTableCell10
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 0.5;
      this.xrTableCell25.Borders = BorderSide.All;
      this.xrTableCell25.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "Adı Soyadı";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 1.7136260704632118;
      this.xrTableCell26.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell26.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "Ünvanı";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 0.99337753466028111;
      this.xrTableCell10.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell10.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "İmza";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell10.Weight = 0.76975763028666211;
      this.ReportHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2
      });
      this.ReportHeader.Name = "ReportHeader";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(319.7157f, 10.00004f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(115.6249f, 38.20836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(119.7915f, 61.20834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(578.1249f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrLabel1,
        (XRControl) this.xrTable2
      });
      this.GroupHeader1.HeightF = 72.70838f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLine1.LocationFloat = new PointFloat(0.0f, 124.5833f);
      this.xrLine1.Name = "xrLine1";
      this.xrLine1.SizeF = new SizeF(743.4167f, 2.083328f);
      this.xrTable4.LocationFloat = new PointFloat(6.357829E-05f, 24.58334f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[4]
      {
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow5
      });
      this.xrTable4.SizeF = new SizeF(368.6742f, 100f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell2,
        this.xrTableCell3
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "İşe Başlama : ";
      this.xrTableCell2.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell2.Weight = 0.59893065669688383;
      this.xrTableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?iseBaslama")
      });
      this.xrTableCell3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.Weight = 0.879709067925215;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell4,
        this.xrTableCell5
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell4.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "İşi Bitirme : ";
      this.xrTableCell4.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell4.Weight = 0.59893065669688383;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isiBitirme")
      });
      this.xrTableCell5.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.Weight = 0.879709067925215;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell6,
        this.xrTableCell7
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell6.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "İşin Süresi (Saat) : ";
      this.xrTableCell6.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell6.Weight = 0.59893065669688383;
      this.xrTableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isSuresi")
      });
      this.xrTableCell7.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.Weight = 0.879709067925215;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell8,
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell8.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Yapılcak İş : ";
      this.xrTableCell8.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell8.Weight = 0.59893065669688383;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?yapilacakIs")
      });
      this.xrTableCell9.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.Weight = 0.879709067925215;
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(747.9999f, 24.58333f);
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
      this.xrTableCell1.Text = "FAZLA ÇALIŞMA (MESAİ) GÖREV ÇAĞRISI";
      this.xrTableCell1.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell1.Weight = 1.0;
      this.iseBaslama.AllowNull = true;
      this.iseBaslama.Description = "Parameter1";
      this.iseBaslama.Name = "iseBaslama";
      this.isiBitirme.AllowNull = true;
      this.isiBitirme.Description = "Parameter1";
      this.isiBitirme.Name = "isiBitirme";
      this.isSuresi.Description = "isSuresi";
      this.isSuresi.Name = "isSuresi";
      this.yapilacakIs.AllowNull = true;
      this.yapilacakIs.Description = "Parameter1";
      this.yapilacakIs.Name = "yapilacakIs";
      this.tasitSonId.AllowNull = true;
      this.tasitSonId.Description = "tasitSonID";
      this.tasitSonId.Name = "tasitSonId";
      this.tasitSonId.Type = typeof (int);
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table1.Name = "TBLTASITGOREV";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "UNVAN";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table2.Name = "TBLPERSUNVAN";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ADISOYADI";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table3.Name = "TBLPERSONEL";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Name = "TBLTASITGOREV_1";
      relationColumnInfo1.NestedKeyColumn = "TASITID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"143\" />";
      table4.Name = "TBLTASITPERS";
      join1.Nested = table4;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "UNVANID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table4;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "PERSONELID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table3;
      join3.Parent = table4;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.GroupHeader2.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrLine1,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable1
      });
      this.GroupHeader2.HeightF = 126.6667f;
      this.GroupHeader2.Level = 1;
      this.GroupHeader2.Name = "GroupHeader2";
      this.xrLabel1.LocationFloat = new PointFloat(9.536743E-05f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(747.9998f, 42.70833f);
      this.xrLabel1.Text = "Makine İkmal Şube Müdürlüğümüzün ilgili bölümlerinde iş yoğunluğu veya diğer çeşitli nedenlerden dolayı ihtiyaç duyulan fazla çalışmaya(mesai) kalmayı kabul ediyorum.";
      this.xrLabel5.LocationFloat = new PointFloat(43.67401f, 24.58331f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(676.0417f, 23f);
      this.xrLabel5.Text = "Yukarıda adı soyadı yazılı personelin fazla çalışma (mesai) yaptığı görülmüştür.";
      this.simdikiTarih.AllowNull = true;
      this.simdikiTarih.Description = "simdikiTarih";
      this.simdikiTarih.Name = "simdikiTarih";
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?simdikiTarih")
      });
      this.xrLabel6.LocationFloat = new PointFloat(546.4167f, 47.58332f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(100f, 23f);
      this.xrLabel6.Text = "xrLabel6";
      this.xrLabel7.LocationFloat = new PointFloat(87.04166f, 64.24999f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(202.0833f, 22.99999f);
      this.xrLabel7.Text = "Görevlendiren / Birim Sorumlusu";
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?yetkili")
      });
      this.xrLabel8.LocationFloat = new PointFloat(115.6249f, 87.25001f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(100f, 23f);
      this.xrLabel8.Text = "xrLabel8";
      this.xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?subeMudur")
      });
      this.xrLabel9.LocationFloat = new PointFloat(546.4167f, 87.25001f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(100f, 23f);
      this.xrLabel9.Text = "xrLabel9";
      this.xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?subeMudurUnvan")
      });
      this.xrLabel10.LocationFloat = new PointFloat(546.4167f, 110.25f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(100f, 23f);
      this.xrLabel10.Text = "xrLabel10";
      this.xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?yetkiliUnvan")
      });
      this.xrLabel11.LocationFloat = new PointFloat(115.6249f, 110.25f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(100f, 23f);
      this.xrLabel11.Text = "xrLabel11";
      this.yetkili.AllowNull = true;
      this.yetkili.Description = "yetkili";
      this.yetkili.Name = "yetkili";
      this.yetkiliUnvan.AllowNull = true;
      this.yetkiliUnvan.Description = "yetkiliUnvan";
      this.yetkiliUnvan.Name = "yetkiliUnvan";
      this.subeMudur.AllowNull = true;
      this.subeMudur.Description = "subeMudur";
      this.subeMudur.Name = "subeMudur";
      this.subeMudurUnvan.AllowNull = true;
      this.subeMudurUnvan.Description = "subeMudurUnvan";
      this.subeMudurUnvan.Name = "subeMudurUnvan";
      this.ReportFooter.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel5
      });
      this.ReportFooter.HeightF = 154.5734f;
      this.ReportFooter.Name = "ReportFooter";
      this.Bands.AddRange(new Band[7]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.ReportFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTASITGOREV_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?tasitSonId";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(64, 38, 51, 109);
      this.Parameters.AddRange(new Parameter[10]
      {
        this.iseBaslama,
        this.isiBitirme,
        this.isSuresi,
        this.yapilacakIs,
        this.tasitSonId,
        this.simdikiTarih,
        this.yetkili,
        this.yetkiliUnvan,
        this.subeMudur,
        this.subeMudurUnvan
      });
      this.Version = "20.1";
      this.xrTable3.EndInit();
      this.xrTable2.EndInit();
      this.xrTable4.EndInit();
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
