// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.FaaliyetRaporYazdir
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

namespace Makina_Ikmal.insankaynak
{
  public class FaaliyetRaporYazdir : XtraReport
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
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private ReportHeaderBand ReportHeader;
    private DetailBand Detail;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRLabel xrLabel3;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private Parameter id;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;

    public FaaliyetRaporYazdir() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Join join = new Join();
      RelationColumnInfo relationColumnInfo = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FaaliyetRaporYazdir));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.ReportHeader = new ReportHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.Detail = new DetailBand();
      this.xrLabel5 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell40 = new XRTableCell();
      this.xrTableCell41 = new XRTableCell();
      this.xrTableCell42 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell27 = new XRTableCell();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell43 = new XRTableCell();
      this.xrTableCell44 = new XRTableCell();
      this.xrTableCell45 = new XRTableCell();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableCell30 = new XRTableCell();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell37 = new XRTableCell();
      this.xrTableCell38 = new XRTableCell();
      this.xrTableCell39 = new XRTableCell();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell31 = new XRTableCell();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableCell33 = new XRTableCell();
      this.id = new Parameter();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TARIH";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"405\" />";
      table1.Name = "FAALIYET";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "YILI";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACBAKIMATOLYE";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ARACBAKIMARAZI";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "ARACBAKIMDIS";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "YAGBAKIM";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ZORUNLUTRFKSIGORTA";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "MUAYENE";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BAIKRESMI";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BAIKHIZMET";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "YAKITMOTORIN";
      columnExpression11.Table = table1;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "YAKITBENZIN";
      columnExpression12.Table = table1;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "RESMIKIRALIKMOTORIN";
      columnExpression13.Table = table1;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "RESMIKIRALIKBENZIN";
      columnExpression14.Table = table1;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "AYI";
      columnExpression15.Table = table1;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression16.Table = table2;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "ID";
      columnExpression17.Table = table1;
      column17.Expression = (ExpressionBase) columnExpression17;
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
      selectQuery.Name = "FAALIYET_1";
      relationColumnInfo.NestedKeyColumn = "ID";
      relationColumnInfo.ParentKeyColumn = "SUBEMUDURU";
      join.KeyColumns.Add(relationColumnInfo);
      join.Nested = table2;
      join.Parent = table1;
      selectQuery.Relations.Add(join);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
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
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1
      });
      this.BottomMargin.HeightF = 35f;
      this.BottomMargin.Name = "BottomMargin";
      this.xrLabel3.LocationFloat = new PointFloat(797f, 0.0f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(264.9998f, 23f);
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Yayın Tarihi : 12.01.2016";
      this.xrLabel3.TextAlignment = TextAlignment.TopRight;
      this.xrLabel2.LocationFloat = new PointFloat(313.3334f, 0.0f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(203.3333f, 23f);
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "Revizyon No :2";
      this.xrLabel2.TextAlignment = TextAlignment.TopRight;
      this.xrLabel1.LocationFloat = new PointFloat(0.0f, 2.00002f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(203.3333f, 23f);
      this.xrLabel1.Text = "Form No : FR-151";
      this.ReportHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel8
      });
      this.ReportHeader.HeightF = 100.8333f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(907.8334f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(154.1666f, 100f);
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel6.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel6.LocationFloat = new PointFloat(100f, 0.0f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(807.8334f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "T.C.";
      this.xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel7.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel7.LocationFloat = new PointFloat(100f, 23.00001f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(807.8334f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel8.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(100f, 56.16666f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(807.8334f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "Makine İkmal Şube Müdürlüğü [AYI] Ayı Faaliyet Raporu";
      this.xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
      this.Detail.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 474.1666f;
      this.Detail.Name = "Detail";
      this.xrLabel5.Font = new Font("Arial", 11f);
      this.xrLabel5.LocationFloat = new PointFloat(815.3334f, 444.8333f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(246.6664f, 23f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "Makine İkmal Şube Müdürü";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrLabel4.Font = new Font("Arial", 11f);
      this.xrLabel4.LocationFloat = new PointFloat(815.3334f, 421.8333f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(246.6664f, 22.99997f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[14]
      {
        this.xrTableRow1,
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow5,
        this.xrTableRow6,
        this.xrTableRow7,
        this.xrTableRow8,
        this.xrTableRow14,
        this.xrTableRow9,
        this.xrTableRow15,
        this.xrTableRow10,
        this.xrTableRow13,
        this.xrTableRow11
      });
      this.xrTable1.SizeF = new SizeF(1062f, 392.7777f);
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell1,
        this.xrTableCell2
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.BorderWidth = 2f;
      this.xrTableCell1.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseBorderWidth = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.Text = "Daire Başkanlığı : Destek Hizmetleri Dairesi Başkanlığı  -  Makine İkmal Şube Müdürlüğü";
      this.xrTableCell1.Weight = 1.9999997701123795;
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.BorderWidth = 2f;
      this.xrTableCell2.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseBorderWidth = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.Text = "[AYI]/[YILI]";
      this.xrTableCell2.Weight = 1.0000002298876205;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell4,
        this.xrTableCell5,
        this.xrTableCell6
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.All;
      this.xrTableCell4.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "FAALİYETİN KONUSU";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 1.3413369091586422;
      this.xrTableCell5.Borders = BorderSide.All;
      this.xrTableCell5.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "MİKTARI";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.65866309084135766;
      this.xrTableCell6.Borders = BorderSide.All;
      this.xrTableCell6.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "FAALİYET BÖLGESİ";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 1.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell9
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.All;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.Text = "Araç Bakım Yapılması (Atölyede)";
      this.xrTableCell7.Weight = 1.3413369091586422;
      this.xrTableCell8.Borders = BorderSide.All;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "[ARACBAKIMATOLYE]  Adet";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell8.Weight = 0.65866309084135766;
      this.xrTableCell9.Borders = BorderSide.All;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.Text = "Makine İkmal Şube Müdürlüğünde";
      this.xrTableCell9.Weight = 1.0;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell10,
        this.xrTableCell11,
        this.xrTableCell12
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.Borders = BorderSide.All;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.Text = "Araç Bakım Yapılması (Arazide)";
      this.xrTableCell10.Weight = 1.3413369091586422;
      this.xrTableCell11.Borders = BorderSide.All;
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "[ARACBAKIMARAZI] Adet";
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell11.Weight = 0.65866309084135766;
      this.xrTableCell12.Borders = BorderSide.All;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.Text = "Makine İkmal Şube Müdürlüğünce Arazide";
      this.xrTableCell12.Weight = 1.0;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell13,
        this.xrTableCell14,
        this.xrTableCell15
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell13.Borders = BorderSide.All;
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.Text = "Araç Bakım Yapılması (Dış Servis)";
      this.xrTableCell13.Weight = 1.3413369091586422;
      this.xrTableCell14.Borders = BorderSide.All;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "[ARACBAKIMDIS] Adet";
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell14.Weight = 0.65866309084135766;
      this.xrTableCell15.Borders = BorderSide.All;
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.Text = "Dış Servis";
      this.xrTableCell15.Weight = 1.0;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell16,
        this.xrTableCell17,
        this.xrTableCell18
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell16.Borders = BorderSide.All;
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.Text = "Yağ ve Filtre Bakım Onarım ve Değişimi";
      this.xrTableCell16.Weight = 1.3413369091586422;
      this.xrTableCell17.Borders = BorderSide.All;
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "[YAGBAKIM] Adet";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell17.Weight = 0.65866309084135766;
      this.xrTableCell18.Borders = BorderSide.All;
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.Text = "Makine İkmal Şube Müdürlüğünde ve Arazide";
      this.xrTableCell18.Weight = 1.0;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell19,
        this.xrTableCell20,
        this.xrTableCell21
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell19.Borders = BorderSide.All;
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBorders = false;
      this.xrTableCell19.Text = "Zorunlu Trafik ve Mali Sigorta Yapılması";
      this.xrTableCell19.Weight = 1.3413369091586422;
      this.xrTableCell20.Borders = BorderSide.All;
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseBorders = false;
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.Text = "[ZORUNLUTRFKSIGORTA] Adet";
      this.xrTableCell20.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell20.Weight = 0.65866309084135766;
      this.xrTableCell21.Borders = BorderSide.All;
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.Text = "Hizmet Alımı";
      this.xrTableCell21.Weight = 1.0;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell22,
        this.xrTableCell23,
        this.xrTableCell24
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell22.Borders = BorderSide.All;
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.Text = "Muayene İşlemleri Yapılması";
      this.xrTableCell22.Weight = 1.3413369091586422;
      this.xrTableCell23.Borders = BorderSide.All;
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseTextAlignment = false;
      this.xrTableCell23.Text = "[MUAYENE] Adet";
      this.xrTableCell23.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell23.Weight = 0.65866309084135766;
      this.xrTableCell24.Borders = BorderSide.All;
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.Text = "Muayene İstasyonu";
      this.xrTableCell24.Weight = 1.0;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell40,
        this.xrTableCell41,
        this.xrTableCell42
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell40.Borders = BorderSide.All;
      this.xrTableCell40.Multiline = true;
      this.xrTableCell40.Name = "xrTableCell40";
      this.xrTableCell40.StylePriority.UseBorders = false;
      this.xrTableCell40.Text = "Birimlerin Araç İhtiyaçlarının Karşılanması";
      this.xrTableCell40.Weight = 1.3413369091586422;
      this.xrTableCell41.Borders = BorderSide.All;
      this.xrTableCell41.Multiline = true;
      this.xrTableCell41.Name = "xrTableCell41";
      this.xrTableCell41.StylePriority.UseBorders = false;
      this.xrTableCell41.StylePriority.UseTextAlignment = false;
      this.xrTableCell41.Text = "[BAIKRESMI] Adet";
      this.xrTableCell41.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell41.Weight = 0.65866309084135766;
      this.xrTableCell42.Borders = BorderSide.All;
      this.xrTableCell42.Multiline = true;
      this.xrTableCell42.Name = "xrTableCell42";
      this.xrTableCell42.StylePriority.UseBorders = false;
      this.xrTableCell42.Text = "Resmi Araç";
      this.xrTableCell42.Weight = 1.0;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell25,
        this.xrTableCell26,
        this.xrTableCell27
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell25.Borders = BorderSide.All;
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.Text = "Birimlerin Araç İhtiyaçlarının Karşılanması";
      this.xrTableCell25.Weight = 1.3413369091586422;
      this.xrTableCell26.Borders = BorderSide.All;
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "[BAIKHIZMET] Adet";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell26.Weight = 0.65866309084135766;
      this.xrTableCell27.Borders = BorderSide.All;
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.StylePriority.UseBorders = false;
      this.xrTableCell27.Text = "Hizmet alımı";
      this.xrTableCell27.Weight = 1.0;
      this.xrTableRow15.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell43,
        this.xrTableCell44,
        this.xrTableCell45
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell43.Borders = BorderSide.All;
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.StylePriority.UseBorders = false;
      this.xrTableCell43.Text = "Yakıt Alımı (Motorin)";
      this.xrTableCell43.Weight = 1.3413369091586422;
      this.xrTableCell44.Borders = BorderSide.All;
      this.xrTableCell44.Multiline = true;
      this.xrTableCell44.Name = "xrTableCell44";
      this.xrTableCell44.StylePriority.UseBorders = false;
      this.xrTableCell44.StylePriority.UseTextAlignment = false;
      this.xrTableCell44.Text = "[YAKITMOTORIN!n] Litre";
      this.xrTableCell44.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell44.Weight = 0.65866309084135766;
      this.xrTableCell45.Borders = BorderSide.All;
      this.xrTableCell45.Multiline = true;
      this.xrTableCell45.Name = "xrTableCell45";
      this.xrTableCell45.StylePriority.UseBorders = false;
      this.xrTableCell45.Text = "Mal Alımı";
      this.xrTableCell45.Weight = 1.0;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell28,
        this.xrTableCell29,
        this.xrTableCell30
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell28.Borders = BorderSide.All;
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseBorders = false;
      this.xrTableCell28.Text = "Yakıt Alımı (Benzin)";
      this.xrTableCell28.Weight = 1.3413369091586422;
      this.xrTableCell29.Borders = BorderSide.All;
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.StylePriority.UseBorders = false;
      this.xrTableCell29.StylePriority.UseTextAlignment = false;
      this.xrTableCell29.Text = "[YAKITBENZIN!n] Litre";
      this.xrTableCell29.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell29.Weight = 0.65866309084135766;
      this.xrTableCell30.Borders = BorderSide.All;
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.StylePriority.UseBorders = false;
      this.xrTableCell30.Text = "Mal Alımı";
      this.xrTableCell30.Weight = 1.0;
      this.xrTableRow13.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell37,
        this.xrTableCell38,
        this.xrTableCell39
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell37.Borders = BorderSide.All;
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.StylePriority.UseBorders = false;
      this.xrTableCell37.Text = "Resmi ve Kiralık Araçların Yakıt İhtiyacının Karşılanması (Motorin)";
      this.xrTableCell37.Weight = 1.3413369091586422;
      this.xrTableCell38.Borders = BorderSide.All;
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.StylePriority.UseBorders = false;
      this.xrTableCell38.StylePriority.UseTextAlignment = false;
      this.xrTableCell38.Text = "[RESMIKIRALIKMOTORIN!n] Litre";
      this.xrTableCell38.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell38.Weight = 0.65866309084135766;
      this.xrTableCell39.Borders = BorderSide.All;
      this.xrTableCell39.Multiline = true;
      this.xrTableCell39.Name = "xrTableCell39";
      this.xrTableCell39.StylePriority.UseBorders = false;
      this.xrTableCell39.Text = "Makine İkmal Şube Müdürlüğünde";
      this.xrTableCell39.Weight = 1.0;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell31,
        this.xrTableCell32,
        this.xrTableCell33
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell31.Borders = BorderSide.All;
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.StylePriority.UseBorders = false;
      this.xrTableCell31.Text = "Resmi ve Kiralık Araçların Yakıt İhtiyacının Karşılanması (Benzin)";
      this.xrTableCell31.Weight = 1.3413369091586422;
      this.xrTableCell32.Borders = BorderSide.All;
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.StylePriority.UseBorders = false;
      this.xrTableCell32.StylePriority.UseTextAlignment = false;
      this.xrTableCell32.Text = "[RESMIKIRALIKBENZIN!n] Litre";
      this.xrTableCell32.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell32.Weight = 0.65866309084135766;
      this.xrTableCell33.Borders = BorderSide.All;
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      this.xrTableCell33.StylePriority.UseBorders = false;
      this.xrTableCell33.Text = "Makine İkmal Şube Müdürlüğünde";
      this.xrTableCell33.Weight = 1.0;
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "FAALIYET_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(53, 54, 100, 35);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4Rotated;
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
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
