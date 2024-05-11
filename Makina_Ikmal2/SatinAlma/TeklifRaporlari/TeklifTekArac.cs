// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.TeklifTekArac
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
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class TeklifTekArac : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle GroupCaption1;
    private XRControlStyle GroupData1;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle GroupFooterBackground3;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell2;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell4;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell6;
    private GroupHeaderBand GroupHeader4;
    private XRTable table4;
    private XRTableRow tableRow4;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
    private DetailBand Detail;
    private XRTable table5;
    private XRTableRow tableRow5;
    private XRTableCell tableCell16;
    private XRTableCell tableCell17;
    private XRTableCell tableCell19;
    private XRTableCell tableCell20;
    private XRTableCell tableCell21;
    private XRTableCell tableCell22;
    private XRTableCell tableCell23;
    private GroupFooterBand GroupFooter1;
    private XRLabel label2;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private Parameter teklifID;
    private XRSubreport xrSubreport1;
    private XRSubreport xrSubreport2;
    private Parameter talepID;

    public TeklifTekArac() => this.InitializeComponent();

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
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table3 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table4 = new Table();
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
      Table table5 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression14 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TeklifTekArac));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.GroupCaption1 = new XRControlStyle();
      this.GroupData1 = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.GroupFooterBackground3 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.tableCell6 = new XRTableCell();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell2 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell4 = new XRTableCell();
      this.xrLabel1 = new XRLabel();
      this.GroupHeader4 = new GroupHeaderBand();
      this.table4 = new XRTable();
      this.tableRow4 = new XRTableRow();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.tableCell11 = new XRTableCell();
      this.tableCell14 = new XRTableCell();
      this.tableCell13 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table5 = new XRTable();
      this.tableRow5 = new XRTableRow();
      this.tableCell16 = new XRTableCell();
      this.tableCell17 = new XRTableCell();
      this.tableCell19 = new XRTableCell();
      this.tableCell21 = new XRTableCell();
      this.tableCell20 = new XRTableCell();
      this.tableCell23 = new XRTableCell();
      this.tableCell22 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrSubreport2 = new XRSubreport();
      this.talepID = new Parameter();
      this.xrSubreport1 = new XRSubreport();
      this.teklifID = new Parameter();
      this.xrLabel2 = new XRLabel();
      this.label2 = new XRLabel();
      this.table3.BeginInit();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.table4.BeginInit();
      this.table5.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TEKLIFID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"745\" />";
      table1.Name = "TBLTEKLIFHRKT";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "PLAKA";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table2.Name = "TBLARACLAR";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACACIKLAMA";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "MALZEMEADI";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table3.Name = "TBLMALZEMELER";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "MALZACIKLAMA";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "BIRIMADI";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table4.Name = "TBLMALZBIRIM";
      columnExpression6.Table = table4;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "MARKA";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "MIKTAR";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "TUTAR";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BIRIMFIYAT";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "TALEPID";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table5.Name = "TBLTEKLIF";
      columnExpression11.Table = table5;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "KOD";
      columnExpression12.Table = table5;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ID";
      columnExpression13.Table = table1;
      column13.Expression = (ExpressionBase) columnExpression13;
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
      selectQuery.Name = "TBLTEKLIFHRKT_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      join1.Type = JoinType.LeftOuter;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MALZEMEID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BIRIMID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "TEKLIFID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      columnExpression14.ColumnName = "ID";
      columnExpression14.Table = table1;
      sorting.Expression = (ExpressionBase) columnExpression14;
      selectQuery.Sorting.Add(sorting);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
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
      this.GroupCaption1.BackColor = Color.FromArgb(75, 75, 75);
      this.GroupCaption1.BorderColor = Color.White;
      this.GroupCaption1.Borders = BorderSide.Bottom;
      this.GroupCaption1.BorderWidth = 2f;
      this.GroupCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupCaption1.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupCaption1.Name = "GroupCaption1";
      this.GroupCaption1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupData1.BackColor = Color.FromArgb(75, 75, 75);
      this.GroupData1.BorderColor = Color.White;
      this.GroupData1.Borders = BorderSide.Bottom;
      this.GroupData1.BorderWidth = 2f;
      this.GroupData1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupData1.ForeColor = Color.White;
      this.GroupData1.Name = "GroupData1";
      this.GroupData1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupData1.TextAlignment = TextAlignment.MiddleLeft;
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
      this.GroupFooterBackground3.BackColor = Color.FromArgb(131, 131, 131);
      this.GroupFooterBackground3.BorderColor = Color.White;
      this.GroupFooterBackground3.Borders = BorderSide.Bottom;
      this.GroupFooterBackground3.BorderWidth = 2f;
      this.GroupFooterBackground3.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupFooterBackground3.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupFooterBackground3.Name = "GroupFooterBackground3";
      this.GroupFooterBackground3.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupFooterBackground3.TextAlignment = TextAlignment.MiddleLeft;
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
      this.TopMargin.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.table3,
        (XRControl) this.table1,
        (XRControl) this.table2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 164.375f;
      this.TopMargin.Name = "TopMargin";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(565.2202f, 7.500051f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(105.7798f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(112.4999f, 35.70836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(452.7202f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(152.8386f, 58.70837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(368.4582f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(5f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(107.4999f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.HeightF = 14f;
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(4.999987f, 0.0f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(303.5f, 13.00004f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(320.0834f, 0.0f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(303.5f, 13.00004f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.table3.LocationFloat = new PointFloat(0.0f, 137.0833f);
      this.table3.Name = "table3";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(112.4999f, 25f);
      this.tableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell6
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 1.0;
      this.tableCell6.BackColor = Color.White;
      this.tableCell6.BorderColor = Color.Black;
      this.tableCell6.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell6.ForeColor = Color.Black;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "GroupData1";
      this.tableCell6.StylePriority.UseBackColor = false;
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseForeColor = false;
      this.tableCell6.Weight = 0.92429606119791663;
      this.table1.LocationFloat = new PointFloat(592.5861f, 137.0833f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(108.4138f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell2
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell2.BackColor = Color.White;
      this.tableCell2.BorderColor = Color.Black;
      this.tableCell2.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.tableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.tableCell2.Font = new Font("Arial", 8f, FontStyle.Bold);
      this.tableCell2.ForeColor = Color.Black;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "GroupData1";
      this.tableCell2.StylePriority.UseBackColor = false;
      this.tableCell2.StylePriority.UseBorderColor = false;
      this.tableCell2.StylePriority.UseBorders = false;
      this.tableCell2.StylePriority.UseFont = false;
      this.tableCell2.StylePriority.UseForeColor = false;
      this.tableCell2.Weight = 0.94663103459554421;
      this.table2.LocationFloat = new PointFloat(112.4999f, 137.0833f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(229.8745f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell4
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.tableCell4.BackColor = Color.White;
      this.tableCell4.BorderColor = Color.Black;
      this.tableCell4.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell4.Font = new Font("Arial", 8f, FontStyle.Bold);
      this.tableCell4.ForeColor = Color.Black;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "GroupData1";
      this.tableCell4.StylePriority.UseBackColor = false;
      this.tableCell4.StylePriority.UseBorderColor = false;
      this.tableCell4.StylePriority.UseBorders = false;
      this.tableCell4.StylePriority.UseFont = false;
      this.tableCell4.StylePriority.UseForeColor = false;
      this.tableCell4.Weight = 0.36662594703501888;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(234.1667f, 111.25f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(229.8744f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "TEKLİF MEKTUBU";
      this.GroupHeader4.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table4
      });
      this.GroupHeader4.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader4.HeightF = 28f;
      this.GroupHeader4.Level = 1;
      this.GroupHeader4.Name = "GroupHeader4";
      this.table4.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table4.Name = "table4";
      this.table4.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow4
      });
      this.table4.SizeF = new SizeF(700.9999f, 28f);
      this.tableRow4.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell7,
        this.tableCell8,
        this.tableCell10,
        this.tableCell12,
        this.tableCell11,
        this.tableCell14,
        this.tableCell13
      });
      this.tableRow4.Name = "tableRow4";
      this.tableRow4.Weight = 1.0;
      this.tableCell7.BackColor = Color.White;
      this.tableCell7.BorderColor = Color.Black;
      this.tableCell7.Borders = BorderSide.All;
      this.tableCell7.ForeColor = Color.Black;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.StylePriority.UseBackColor = false;
      this.tableCell7.StylePriority.UseBorderColor = false;
      this.tableCell7.StylePriority.UseBorders = false;
      this.tableCell7.StylePriority.UseForeColor = false;
      this.tableCell7.StylePriority.UseTextAlignment = false;
      this.tableCell7.Text = "S.No";
      this.tableCell7.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell7.Weight = 0.053403017201500723;
      this.tableCell8.BackColor = Color.White;
      this.tableCell8.BorderColor = Color.Black;
      this.tableCell8.Borders = BorderSide.All;
      this.tableCell8.ForeColor = Color.Black;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailCaption1";
      this.tableCell8.StylePriority.UseBackColor = false;
      this.tableCell8.StylePriority.UseBorderColor = false;
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.StylePriority.UseForeColor = false;
      this.tableCell8.Text = "İmalatın Cinsi";
      this.tableCell8.Weight = 0.23596098425479189;
      this.tableCell10.BackColor = Color.White;
      this.tableCell10.BorderColor = Color.Black;
      this.tableCell10.Borders = BorderSide.All;
      this.tableCell10.ForeColor = Color.Black;
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailCaption1";
      this.tableCell10.StylePriority.UseBackColor = false;
      this.tableCell10.StylePriority.UseBorderColor = false;
      this.tableCell10.StylePriority.UseBorders = false;
      this.tableCell10.StylePriority.UseForeColor = false;
      this.tableCell10.Text = "Birim Adı";
      this.tableCell10.Weight = 0.085349448208070833;
      this.tableCell12.BackColor = Color.White;
      this.tableCell12.BorderColor = Color.Black;
      this.tableCell12.Borders = BorderSide.All;
      this.tableCell12.ForeColor = Color.Black;
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailCaption1";
      this.tableCell12.StylePriority.UseBackColor = false;
      this.tableCell12.StylePriority.UseBorderColor = false;
      this.tableCell12.StylePriority.UseBorders = false;
      this.tableCell12.StylePriority.UseForeColor = false;
      this.tableCell12.StylePriority.UseTextAlignment = false;
      this.tableCell12.Text = "Miktar";
      this.tableCell12.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell12.Weight = 0.083013761862079663;
      this.tableCell11.BackColor = Color.White;
      this.tableCell11.BorderColor = Color.Black;
      this.tableCell11.Borders = BorderSide.All;
      this.tableCell11.ForeColor = Color.Black;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailCaption1";
      this.tableCell11.StylePriority.UseBackColor = false;
      this.tableCell11.StylePriority.UseBorderColor = false;
      this.tableCell11.StylePriority.UseBorders = false;
      this.tableCell11.StylePriority.UseForeColor = false;
      this.tableCell11.StylePriority.UseTextAlignment = false;
      this.tableCell11.Text = "Marka";
      this.tableCell11.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell11.Weight = 0.069671428742664479;
      this.tableCell14.BackColor = Color.White;
      this.tableCell14.BorderColor = Color.Black;
      this.tableCell14.Borders = BorderSide.All;
      this.tableCell14.ForeColor = Color.Black;
      this.tableCell14.Multiline = true;
      this.tableCell14.Name = "tableCell14";
      this.tableCell14.StyleName = "DetailCaption1";
      this.tableCell14.StylePriority.UseBackColor = false;
      this.tableCell14.StylePriority.UseBorderColor = false;
      this.tableCell14.StylePriority.UseBorders = false;
      this.tableCell14.StylePriority.UseForeColor = false;
      this.tableCell14.StylePriority.UseTextAlignment = false;
      this.tableCell14.Text = "Birim Fiyat\r\n";
      this.tableCell14.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell14.Weight = 0.0934049289860976;
      this.tableCell13.BackColor = Color.White;
      this.tableCell13.BorderColor = Color.Black;
      this.tableCell13.Borders = BorderSide.All;
      this.tableCell13.ForeColor = Color.Black;
      this.tableCell13.Name = "tableCell13";
      this.tableCell13.StyleName = "DetailCaption1";
      this.tableCell13.StylePriority.UseBackColor = false;
      this.tableCell13.StylePriority.UseBorderColor = false;
      this.tableCell13.StylePriority.UseBorders = false;
      this.tableCell13.StylePriority.UseForeColor = false;
      this.tableCell13.StylePriority.UseTextAlignment = false;
      this.tableCell13.Text = "Tutar";
      this.tableCell13.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell13.Weight = 0.11357590860314806;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table5
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.table5.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table5.Name = "table5";
      this.table5.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow5
      });
      this.table5.SizeF = new SizeF(700.9999f, 25f);
      this.tableRow5.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell16,
        this.tableCell17,
        this.tableCell19,
        this.tableCell21,
        this.tableCell20,
        this.tableCell23,
        this.tableCell22
      });
      this.tableRow5.Name = "tableRow5";
      this.tableRow5.Weight = 11.5;
      this.tableCell16.BorderColor = Color.Black;
      this.tableCell16.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell16.ExpressionBindings.AddRange(new ExpressionBinding[2]
      {
        new ExpressionBinding("BeforePrint", "Text", ""),
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.tableCell16.Name = "tableCell16";
      this.tableCell16.StyleName = "DetailData1";
      this.tableCell16.StylePriority.UseBackColor = false;
      this.tableCell16.StylePriority.UseBorderColor = false;
      this.tableCell16.StylePriority.UseBorders = false;
      this.tableCell16.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.tableCell16.Summary = xrSummary;
      this.tableCell16.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell16.Weight = 0.053403021811651449;
      this.tableCell17.BorderColor = Color.Black;
      this.tableCell17.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]+[MALZACIKLAMA]")
      });
      this.tableCell17.Name = "tableCell17";
      this.tableCell17.StyleName = "DetailData1";
      this.tableCell17.StylePriority.UseBorderColor = false;
      this.tableCell17.StylePriority.UseBorders = false;
      this.tableCell17.Weight = 0.2359610048694005;
      this.tableCell19.BorderColor = Color.Black;
      this.tableCell19.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell19.Name = "tableCell19";
      this.tableCell19.StyleName = "DetailData1";
      this.tableCell19.StylePriority.UseBorderColor = false;
      this.tableCell19.StylePriority.UseBorders = false;
      this.tableCell19.Weight = 0.0853495350992793;
      this.tableCell21.BorderColor = Color.Black;
      this.tableCell21.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "DetailData1";
      this.tableCell21.StylePriority.UseBorderColor = false;
      this.tableCell21.StylePriority.UseBorders = false;
      this.tableCell21.StylePriority.UseTextAlignment = false;
      this.tableCell21.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell21.Weight = 0.083013684630550547;
      this.tableCell20.BorderColor = Color.Black;
      this.tableCell20.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MARKA]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "DetailData1";
      this.tableCell20.StylePriority.UseBorderColor = false;
      this.tableCell20.StylePriority.UseBorders = false;
      this.tableCell20.StylePriority.UseTextAlignment = false;
      this.tableCell20.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell20.TextFormatString = "{0:C2}";
      this.tableCell20.Weight = 0.06967136570476537;
      this.tableCell23.BorderColor = Color.Black;
      this.tableCell23.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailData1";
      this.tableCell23.StylePriority.UseBorderColor = false;
      this.tableCell23.StylePriority.UseBorders = false;
      this.tableCell23.StylePriority.UseTextAlignment = false;
      this.tableCell23.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell23.TextFormatString = "{0:C2}";
      this.tableCell23.Weight = 0.093404961469839454;
      this.tableCell22.BorderColor = Color.Black;
      this.tableCell22.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell22.Name = "tableCell22";
      this.tableCell22.StyleName = "DetailData1";
      this.tableCell22.StylePriority.UseBorderColor = false;
      this.tableCell22.StylePriority.UseBorders = false;
      this.tableCell22.StylePriority.UseTextAlignment = false;
      this.tableCell22.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell22.TextFormatString = "{0:C2}";
      this.tableCell22.Weight = 0.11357589210477329;
      this.GroupFooter1.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrSubreport2,
        (XRControl) this.xrSubreport1,
        (XRControl) this.xrLabel2,
        (XRControl) this.label2
      });
      this.GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter1.HeightF = 92.66618f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrSubreport2.LocationFloat = new PointFloat(0.0f, 65.41634f);
      this.xrSubreport2.Name = "xrSubreport2";
      this.xrSubreport2.ParameterBindings.Add(new ParameterBinding("talepID", this.talepID));
      this.xrSubreport2.ReportSource = (XtraReport) new TeklifTeknikSartnameDuz();
      this.xrSubreport2.SizeF = new SizeF(541.6105f, 23f);
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 42.41635f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("TeklifId", this.teklifID));
      this.xrSubreport1.ReportSource = (XtraReport) new IdariSartname();
      this.xrSubreport1.SizeF = new SizeF(541.6107f, 23f);
      this.teklifID.Description = "teklifID";
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.xrLabel2.BorderColor = Color.Black;
      this.xrLabel2.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrLabel2.LocationFloat = new PointFloat(592.5864f, 0.0f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(108.4136f, 31.33336f);
      this.xrLabel2.StylePriority.UseBorderColor = false;
      this.xrLabel2.StylePriority.UseBorders = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.label2.BackColor = Color.White;
      this.label2.BorderColor = Color.Black;
      this.label2.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.label2.ForeColor = Color.Black;
      this.label2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.label2.Name = "label2";
      this.label2.SizeF = new SizeF(592.5864f, 31.33336f);
      this.label2.StyleName = "GroupFooterBackground3";
      this.label2.StylePriority.UseBackColor = false;
      this.label2.StylePriority.UseBorderColor = false;
      this.label2.StylePriority.UseBorders = false;
      this.label2.StylePriority.UseForeColor = false;
      this.label2.StylePriority.UseTextAlignment = false;
      this.label2.Text = "Toplam Tutar   ";
      this.label2.TextAlignment = TextAlignment.MiddleRight;
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.GroupHeader4,
        (Band) this.Detail,
        (Band) this.GroupFooter1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIFHRKT_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TEKLIFID] = ?teklifID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(47, 0, 164, 14);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
      this.Parameters.AddRange(new Parameter[2]
      {
        this.teklifID,
        this.talepID
      });
      this.StyleSheet.AddRange(new XRControlStyle[8]
      {
        this.Title,
        this.GroupCaption1,
        this.GroupData1,
        this.DetailCaption1,
        this.DetailData1,
        this.GroupFooterBackground3,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.table3.EndInit();
      this.table1.EndInit();
      this.table2.EndInit();
      this.table4.EndInit();
      this.table5.EndInit();
      this.EndInit();
    }
  }
}
