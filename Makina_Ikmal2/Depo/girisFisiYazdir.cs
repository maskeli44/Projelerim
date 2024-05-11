// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.girisFisiYazdir
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
  public class girisFisiYazdir : XtraReport
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
    private ReportHeaderBand ReportHeader;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private GroupHeaderBand GroupHeader4;
    private XRTable table4;
    private XRTableRow tableRow4;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private GroupHeaderBand GroupHeader5;
    private XRTable table5;
    private XRTableRow tableRow5;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private GroupHeaderBand GroupHeader6;
    private XRTable table6;
    private XRTableRow tableRow6;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private DetailBand Detail;
    private XRTable table8;
    private XRTableRow tableRow8;
    private XRTableCell tableCell20;
    private XRTableCell tableCell21;
    private XRTableCell tableCell22;
    private XRTableCell tableCell23;
    private XRTableCell tableCell24;
    private XRTableCell tableCell25;
    private XRTableCell tableCell26;
    private XRLabel xrLabel1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell1;
    private GroupHeaderBand GroupHeader8;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell5;
    private XRLabel xrLabel2;
    private GroupFooterBand GroupFooter2;
    private XRLabel xrLabel3;
    private Parameter id;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel7;

    public girisFisiYazdir() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table3 = new Table();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table4 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table5 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table6 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table7 = new Table();
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
      Table table8 = new Table();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (girisFisiYazdir));
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
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.ReportHeader = new ReportHeaderBand();
      this.xrLabel7 = new XRLabel();
      this.GroupHeader4 = new GroupHeaderBand();
      this.xrLabel1 = new XRLabel();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.table4 = new XRTable();
      this.tableRow4 = new XRTableRow();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.GroupHeader5 = new GroupHeaderBand();
      this.table5 = new XRTable();
      this.tableRow5 = new XRTableRow();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.GroupHeader6 = new GroupHeaderBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.table6 = new XRTable();
      this.tableRow6 = new XRTableRow();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table8 = new XRTable();
      this.tableRow8 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.tableCell20 = new XRTableCell();
      this.tableCell21 = new XRTableCell();
      this.tableCell22 = new XRTableCell();
      this.tableCell23 = new XRTableCell();
      this.tableCell24 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell25 = new XRTableCell();
      this.tableCell26 = new XRTableCell();
      this.GroupHeader8 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrLabel2 = new XRLabel();
      this.GroupFooter2 = new GroupFooterBand();
      this.xrLabel3 = new XRLabel();
      this.id = new Parameter();
      this.table1.BeginInit();
      this.table3.BeginInit();
      this.table4.BeginInit();
      this.table5.BeginInit();
      this.table2.BeginInit();
      this.table6.BeginInit();
      this.table8.BeginInit();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ARACACIKLAMA";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "KOD";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"585\" />";
      table2.Name = "TBLDEPOFIS";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "TARIH";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "SAAT";
      columnExpression5.Table = table2;
      column5.Expression = (ExpressionBase) columnExpression5;
      column6.Alias = "TBLISEMRI_KOD";
      columnExpression6.ColumnName = "KOD";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table3.Name = "TBLISEMRI";
      columnExpression6.Table = table3;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "MALZEMEADI";
      table4.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table4.Name = "TBLMALZEMELER";
      columnExpression7.Table = table4;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "MALZACIKLAMA";
      table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"505\" />";
      table5.Name = "TBLDEPOFISHRKT";
      columnExpression8.Table = table5;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BOLUMADI";
      table6.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table6.Name = "TBLMALZBOLUM";
      columnExpression9.Table = table6;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BIRIMADI";
      table7.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table7.Name = "TBLMALZBIRIM";
      columnExpression10.Table = table7;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "MALZURTTARIH";
      columnExpression11.Table = table5;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "DEGISIMKMSI";
      columnExpression12.Table = table5;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "MALZSERINO";
      columnExpression13.Table = table5;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "MIKTAR";
      columnExpression14.Table = table5;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "ADISOYADI";
      table8.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table8.Name = "TBLPERSONEL";
      columnExpression15.Table = table8;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "ISLEMTIPIID";
      columnExpression16.Table = table2;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "ID";
      columnExpression17.Table = table2;
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
      selectQuery.FilterString = "[TBLDEPOFIS.ISLEMTIPIID] = '2'";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLDEPOFISHRKT_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "DEPOFISID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table5;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "ISEMRIID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table2;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "ARACID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table1;
      join3.Parent = table3;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "MALZEMEID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table4;
      join4.Parent = table5;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "BOLUMID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table6;
      join5.Parent = table4;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "BIRIMID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table7;
      join6.Parent = table4;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "IMZADEPOYETKILIID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table8;
      join7.Parent = table2;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Relations.Add(join6);
      selectQuery.Relations.Add(join7);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table7);
      selectQuery.Tables.Add(table8);
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
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.GroupCaption1.BackColor = Color.FromArgb(46, 148, 130);
      this.GroupCaption1.BorderColor = Color.White;
      this.GroupCaption1.Borders = BorderSide.Bottom;
      this.GroupCaption1.BorderWidth = 2f;
      this.GroupCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupCaption1.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupCaption1.Name = "GroupCaption1";
      this.GroupCaption1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupData1.BackColor = Color.FromArgb(46, 148, 130);
      this.GroupData1.BorderColor = Color.White;
      this.GroupData1.Borders = BorderSide.Bottom;
      this.GroupData1.BorderWidth = 2f;
      this.GroupData1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupData1.ForeColor = Color.White;
      this.GroupData1.Name = "GroupData1";
      this.GroupData1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailCaption1.BackColor = Color.FromArgb(46, 148, 130);
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
      this.GroupFooterBackground3.BackColor = Color.FromArgb(109, 117, 129);
      this.GroupFooterBackground3.BorderColor = Color.White;
      this.GroupFooterBackground3.Borders = BorderSide.Bottom;
      this.GroupFooterBackground3.BorderWidth = 2f;
      this.GroupFooterBackground3.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupFooterBackground3.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupFooterBackground3.Name = "GroupFooterBackground3";
      this.GroupFooterBackground3.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupFooterBackground3.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailData3_Odd.BackColor = Color.FromArgb(243, 245, 248);
      this.DetailData3_Odd.BorderColor = Color.Transparent;
      this.DetailData3_Odd.Borders = BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1f;
      this.DetailData3_Odd.Font = new Font("Arial", 8.25f);
      this.DetailData3_Odd.ForeColor = Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData3_Odd.TextAlignment = TextAlignment.MiddleLeft;
      this.PageInfo.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.PageInfo.ForeColor = Color.FromArgb(64, 70, 80);
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 91.33334f;
      this.TopMargin.Name = "TopMargin";
      this.xrLabel6.LocationFloat = new PointFloat(103.326f, 57f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(593.6738f, 23f);
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "Destek Hizmetleri Daire Başkanlığı Makine İkmal Şube Müdürlüğü ";
      this.xrLabel6.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel5.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(102.2011f, 33f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(594.7987f, 23f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ BAŞKANLIĞI";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(102.2011f, 10f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(594.7987f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "T.C.";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(2.201112f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(85.83334f, 91.33334f);
      this.xrPictureBox2.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(709.8331f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(87.16675f, 91.33334f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(5f, 5f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(318f, 5f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Sayfa {0} / {1}";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel7
      });
      this.ReportHeader.HeightF = 23.66666f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrLabel7.BackColor = Color.DarkGray;
      this.xrLabel7.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel7.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(796.9998f, 23f);
      this.xrLabel7.StylePriority.UseBackColor = false;
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "Giriş Fişi";
      this.xrLabel7.TextAlignment = TextAlignment.TopCenter;
      this.GroupHeader4.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel1,
        (XRControl) this.table1,
        (XRControl) this.table3,
        (XRControl) this.table4
      });
      this.GroupHeader4.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("TARIH", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader4.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader4.HeightF = 28.33333f;
      this.GroupHeader4.Level = 1;
      this.GroupHeader4.Name = "GroupHeader4";
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel1.LocationFloat = new PointFloat(123.0355f, 1.999969f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(208.9538f, 24.99995f);
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "xrLabel1";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleLeft;
      this.table1.LocationFloat = new PointFloat(0.0f, 2.00002f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(123.0355f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell1
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.3000000850132551;
      this.tableCell1.BackColor = Color.White;
      this.tableCell1.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.StylePriority.UseBackColor = false;
      this.tableCell1.StylePriority.UseForeColor = false;
      this.tableCell1.Text = "KOD";
      this.tableCell1.Weight = 0.3693915676589889;
      this.table3.LocationFloat = new PointFloat(606.1667f, 1.999969f);
      this.table3.Name = "table3";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(190.8333f, 25f);
      this.tableRow3.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell5,
        this.tableCell6
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 1.0;
      this.tableCell5.BackColor = Color.White;
      this.tableCell5.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "GroupCaption1";
      this.tableCell5.StylePriority.UseBackColor = false;
      this.tableCell5.StylePriority.UseForeColor = false;
      this.tableCell5.Text = "SAAT";
      this.tableCell5.Weight = 0.16171814621763719;
      this.tableCell6.BackColor = Color.White;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAAT]")
      });
      this.tableCell6.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "GroupData1";
      this.tableCell6.StylePriority.UseBackColor = false;
      this.tableCell6.StylePriority.UseForeColor = false;
      this.tableCell6.TextFormatString = "{0:HH:mm}";
      this.tableCell6.Weight = 0.40626935809161413;
      this.table4.LocationFloat = new PointFloat(331.9893f, 2f);
      this.table4.Name = "table4";
      this.table4.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow4
      });
      this.table4.SizeF = new SizeF(274.1774f, 25f);
      this.tableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell7,
        this.tableCell8
      });
      this.tableRow4.Name = "tableRow4";
      this.tableRow4.Weight = 1.0;
      this.tableCell7.BackColor = Color.White;
      this.tableCell7.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "GroupCaption1";
      this.tableCell7.StylePriority.UseBackColor = false;
      this.tableCell7.StylePriority.UseForeColor = false;
      this.tableCell7.Text = "TARIH";
      this.tableCell7.Weight = 0.0685920532810631;
      this.tableCell8.BackColor = Color.White;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.tableCell8.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "GroupData1";
      this.tableCell8.StylePriority.UseBackColor = false;
      this.tableCell8.StylePriority.UseForeColor = false;
      this.tableCell8.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell8.Weight = 0.36869241175514844;
      this.GroupHeader5.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table5
      });
      this.GroupHeader5.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("ARACACIKLAMA", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader5.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader5.HeightF = 27f;
      this.GroupHeader5.Level = 2;
      this.GroupHeader5.Name = "GroupHeader5";
      this.table5.LocationFloat = new PointFloat(0.0f, 2f);
      this.table5.Name = "table5";
      this.table5.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow5
      });
      this.table5.SizeF = new SizeF(796.9999f, 25f);
      this.tableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell9,
        this.tableCell10
      });
      this.tableRow5.Name = "tableRow5";
      this.tableRow5.Weight = 1.0;
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "GroupCaption1";
      this.tableCell9.Text = "ARACACIKLAMA";
      this.tableCell9.Weight = 0.16300021328234027;
      this.tableCell10.BackColor = Color.White;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell10.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "GroupData1";
      this.tableCell10.StylePriority.UseBackColor = false;
      this.tableCell10.StylePriority.UseForeColor = false;
      this.tableCell10.Weight = 1.1081321121702159;
      this.GroupHeader6.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.table2,
        (XRControl) this.table6
      });
      this.GroupHeader6.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("PLAKA", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader6.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader6.HeightF = 27f;
      this.GroupHeader6.Level = 3;
      this.GroupHeader6.Name = "GroupHeader6";
      this.table2.LocationFloat = new PointFloat(391.1667f, 1.999995f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(388.8333f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell3,
        this.tableCell4
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.tableCell3.BackColor = Color.White;
      this.tableCell3.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "GroupCaption1";
      this.tableCell3.StylePriority.UseBackColor = false;
      this.tableCell3.StylePriority.UseForeColor = false;
      this.tableCell3.Text = "TBLISEMRI KOD";
      this.tableCell3.Weight = 0.23313568933992757;
      this.tableCell4.BackColor = Color.White;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLISEMRI_KOD]")
      });
      this.tableCell4.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "GroupData1";
      this.tableCell4.StylePriority.UseBackColor = false;
      this.tableCell4.StylePriority.UseForeColor = false;
      this.tableCell4.Weight = 0.39073475258334045;
      this.table6.LocationFloat = new PointFloat(0.0f, 2f);
      this.table6.Name = "table6";
      this.table6.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow6
      });
      this.table6.SizeF = new SizeF(391.1667f, 25f);
      this.tableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell11,
        this.tableCell12
      });
      this.tableRow6.Name = "tableRow6";
      this.tableRow6.Weight = 1.0;
      this.tableCell11.BackColor = Color.White;
      this.tableCell11.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "GroupCaption1";
      this.tableCell11.StylePriority.UseBackColor = false;
      this.tableCell11.StylePriority.UseForeColor = false;
      this.tableCell11.Text = "PLAKA";
      this.tableCell11.Weight = 0.0757038962137566;
      this.tableCell12.BackColor = Color.White;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell12.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "GroupData1";
      this.tableCell12.StylePriority.UseBackColor = false;
      this.tableCell12.StylePriority.UseForeColor = false;
      this.tableCell12.Weight = 0.54816648877466079;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table8
      });
      this.Detail.HeightF = 26.16669f;
      this.Detail.Name = "Detail";
      this.table8.LocationFloat = new PointFloat(5f, 0.0f);
      this.table8.Name = "table8";
      this.table8.OddStyleName = "DetailData3_Odd";
      this.table8.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow8
      });
      this.table8.SizeF = new SizeF(792f, 25f);
      this.tableRow8.Cells.AddRange(new XRTableCell[9]
      {
        this.xrTableCell2,
        this.tableCell20,
        this.tableCell21,
        this.tableCell22,
        this.tableCell23,
        this.tableCell24,
        this.xrTableCell1,
        this.tableCell25,
        this.tableCell26
      });
      this.tableRow8.Name = "tableRow8";
      this.tableRow8.Weight = 11.5;
      this.xrTableCell2.Borders = BorderSide.None;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Group;
      this.xrTableCell2.Summary = xrSummary;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 0.078534784559942741;
      this.tableCell20.Borders = BorderSide.None;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "DetailData1";
      this.tableCell20.StylePriority.UseBorders = false;
      this.tableCell20.Weight = 0.21096498804272873;
      this.tableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZACIKLAMA]")
      });
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "DetailData1";
      this.tableCell21.Weight = 0.1712126055022366;
      this.tableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BOLUMADI]")
      });
      this.tableCell22.Name = "tableCell22";
      this.tableCell22.StyleName = "DetailData1";
      this.tableCell22.Weight = 0.12132195042270982;
      this.tableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailData1";
      this.tableCell23.Weight = 0.10604947225518964;
      this.tableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZURTTARIH]")
      });
      this.tableCell24.Name = "tableCell24";
      this.tableCell24.StyleName = "DetailData1";
      this.tableCell24.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell24.Weight = 0.16713937275717702;
      this.xrTableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailData1";
      this.xrTableCell1.Text = "xrTableCell1";
      this.xrTableCell1.Weight = 0.14578834789221368;
      this.tableCell25.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DEGISIMKMSI]")
      });
      this.tableCell25.Name = "tableCell25";
      this.tableCell25.StyleName = "DetailData1";
      this.tableCell25.Weight = 0.14578834789221368;
      this.tableCell26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZSERINO]")
      });
      this.tableCell26.Name = "tableCell26";
      this.tableCell26.StyleName = "DetailData1";
      this.tableCell26.Weight = 0.16359281159664074;
      this.GroupHeader8.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.GroupHeader8.HeightF = 25.66663f;
      this.GroupHeader8.Name = "GroupHeader8";
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(797f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[9]
      {
        this.xrTableCell3,
        this.xrTableCell4,
        this.xrTableCell6,
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell12,
        this.xrTableCell9,
        this.xrTableCell10,
        this.xrTableCell5
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Text = "S.No";
      this.xrTableCell3.Weight = 0.65829798986801091;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Text = "Malzeme Adı";
      this.xrTableCell4.Weight = 1.5998370698285074;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.Text = "Açıklama";
      this.xrTableCell6.Weight = 1.2983776269623148;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.Text = "Bölüm";
      this.xrTableCell7.Weight = 0.92003681369527812;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Text = "Birim";
      this.xrTableCell8.Weight = 0.80421781839062012;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.Text = "Tarih";
      this.xrTableCell12.Weight = 1.267489857379364;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.Text = "Miktar";
      this.xrTableCell9.Weight = 1.1055749775923669;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.Text = "Seri No";
      this.xrTableCell10.Weight = 1.1055749775923669;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "Değişim Km";
      this.xrTableCell5.Weight = 1.2405932915853843;
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(521.8961f, 89.66672f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(208.8333f, 23f);
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.GroupFooter2.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2
      });
      this.GroupFooter2.HeightF = 252.1666f;
      this.GroupFooter2.Level = 1;
      this.GroupFooter2.Name = "GroupFooter2";
      this.xrLabel3.LocationFloat = new PointFloat(553.1247f, 66.66672f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(145f, 23f);
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Depo Yetkilisi";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[9]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader4,
        (Band) this.GroupHeader5,
        (Band) this.GroupHeader6,
        (Band) this.Detail,
        (Band) this.GroupHeader8,
        (Band) this.GroupFooter2
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLDEPOFISHRKT_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.Margins = new Margins(18, 12, 91, 100);
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5;
      this.Parameters.AddRange(new Parameter[1]{ this.id });
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
      this.table1.EndInit();
      this.table3.EndInit();
      this.table4.EndInit();
      this.table5.EndInit();
      this.table2.EndInit();
      this.table6.EndInit();
      this.table8.EndInit();
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
