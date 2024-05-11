// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.TeklifRaporlari
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
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

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class TeklifRaporlari : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRLabel xrLabel18;
    private XRLabel xrLabel16;
    private XRLabel xrLabel2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell3;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell4;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell5;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell6;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell7;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell8;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell9;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell10;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell11;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell12;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell13;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell14;
    private XRLabel xrLabel5;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell15;
    private XRLabel xrLabel6;
    private Parameter teklifID;
    private GroupHeaderBand GroupHeader1;
    private XRSubreport xrSubreport1;

    public TeklifRaporlari() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table3 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table4 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table5 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression13 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Makina_Ikmal.SatinAlma.TeklifRaporlari.TeklifRaporlari));
      XRSummary xrSummary1 = new XRSummary();
      XRSummary xrSummary2 = new XRSummary();
      XRSummary xrSummary3 = new XRSummary();
      XRSummary xrSummary4 = new XRSummary();
      XRSummary xrSummary5 = new XRSummary();
      XRSummary xrSummary6 = new XRSummary();
      XRSummary xrSummary7 = new XRSummary();
      XRSummary xrSummary8 = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.xrLabel18 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel20 = new XRLabel();
      this.xrLabel19 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.Detail = new DetailBand();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel6 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTable9 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTable10 = new XRTable();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTable11 = new XRTable();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable12 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTable13 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell14 = new XRTableCell();
      this.xrLabel5 = new XRLabel();
      this.xrTable15 = new XRTable();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.teklifID = new Parameter();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrSubreport1 = new XRSubreport();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable5.BeginInit();
      this.xrTable6.BeginInit();
      this.xrTable7.BeginInit();
      this.xrTable8.BeginInit();
      this.xrTable9.BeginInit();
      this.xrTable10.BeginInit();
      this.xrTable11.BeginInit();
      this.xrTable12.BeginInit();
      this.xrTable13.BeginInit();
      this.xrTable14.BeginInit();
      this.xrTable15.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "MIKTAR";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"745\" />";
      table1.Name = "TBLTEKLIFHRKT";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "MARKA";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "BIRIMFIYAT";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "TUTAR";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "MALZACIKLAMA";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "BIRIMID";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "BIRIMADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table2.Name = "TBLMALZBIRIM";
      columnExpression7.Table = table2;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "TOPLAMTUTAR";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table3.Name = "TBLTEKLIF";
      columnExpression8.Table = table3;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "SIRANO";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"145\" />";
      table4.Name = "TBLTEKLIFIDARISART";
      columnExpression9.Table = table4;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "ACIKLAMA";
      columnExpression10.Table = table4;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "MALZEMEADI";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table5.Name = "TBLMALZEMELER";
      columnExpression11.Table = table5;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "ID";
      columnExpression12.Table = table1;
      column12.Expression = (ExpressionBase) columnExpression12;
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
      selectQuery.FilterString = "[TBLTEKLIF.ID] = ?teklifID";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLTEKLIF";
      queryParameter.Name = "teklifID";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?teklifID", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table1;
      join1.Parent = table3;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BIRIMID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo3.ParentKeyColumn = "ID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table3;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "MALZEMEID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      columnExpression13.ColumnName = "ID";
      columnExpression13.Table = table1;
      sorting.Expression = (ExpressionBase) columnExpression13;
      selectQuery.Sorting.Add(sorting);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel18,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel20,
        (XRControl) this.xrLabel19,
        (XRControl) this.xrLabel16
      });
      this.BottomMargin.Name = "BottomMargin";
      this.xrLabel18.Borders = BorderSide.None;
      this.xrLabel18.LocationFloat = new PointFloat(11.66674f, 33.08334f);
      this.xrLabel18.Multiline = true;
      this.xrLabel18.Name = "xrLabel18";
      this.xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel18.SizeF = new SizeF(307.5f, 23f);
      this.xrLabel18.StylePriority.UseBorders = false;
      this.xrLabel18.Text = "belirttiğim fiyatla vermeyi / yapmayı taahüt ederim.";
      this.xrLabel2.LocationFloat = new PointFloat(319.1667f, 33.08334f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(100f, 23f);
      this.xrLabel2.Text = "..../...../.........";
      this.xrLabel20.Borders = BorderSide.None;
      this.xrLabel20.Font = new Font("Arial", 8f, FontStyle.Bold);
      this.xrLabel20.LocationFloat = new PointFloat(601.6665f, 33.08334f);
      this.xrLabel20.Multiline = true;
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel20.SizeF = new SizeF(88.33337f, 23f);
      this.xrLabel20.StylePriority.UseBorders = false;
      this.xrLabel20.StylePriority.UseFont = false;
      this.xrLabel20.StylePriority.UseTextAlignment = false;
      this.xrLabel20.Text = "(İMZA / KAŞE)";
      this.xrLabel20.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel19.Borders = BorderSide.None;
      this.xrLabel19.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel19.LocationFloat = new PointFloat(588.3333f, 10.08339f);
      this.xrLabel19.Multiline = true;
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel19.SizeF = new SizeF(114.1667f, 23f);
      this.xrLabel19.StylePriority.UseBorders = false;
      this.xrLabel19.StylePriority.UseFont = false;
      this.xrLabel19.StylePriority.UseTextAlignment = false;
      this.xrLabel19.Text = "TEKLİF VEREN";
      this.xrLabel19.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel16.Borders = BorderSide.None;
      this.xrLabel16.LocationFloat = new PointFloat(11.66674f, 9.999974f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(485.3745f, 23.08344f);
      this.xrLabel16.StylePriority.UseBorders = false;
      this.xrLabel16.Text = "Yukarıda cins, miktar, özellik ve şartları yazılı işi teknikşartnameye uygun olarak ";
      this.Detail.HeightF = 23.33463f;
      this.Detail.Name = "Detail";
      this.PageHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.PageHeader.HeightF = 110.5417f;
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(581.2917f, 10f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(266.6667f, 84.20832f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(184.5412f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "TEKLİF MEKTUBU";
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(124.1666f, 61.20832f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(124.1666f, 38.20831f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(11.66674f, 2.499949f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?kod")
      });
      this.xrLabel6.LocationFloat = new PointFloat(592.5001f, 10f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(100f, 23f);
      this.xrLabel6.Text = "xrLabel6";
      this.xrTable1.LocationFloat = new PointFloat(52.50008f, 39.16667f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(46.66666f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.Text = "S.No";
      this.xrTableCell1.Weight = 1.0;
      this.xrTable2.LocationFloat = new PointFloat(99.16674f, 39.16667f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(271.6667f, 25f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "İmalat Cinsi";
      this.xrTableCell2.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell2.Weight = 1.0;
      this.xrTable3.LocationFloat = new PointFloat(370.8335f, 39.16667f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(51.66666f, 25f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell3
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell3.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Birim";
      this.xrTableCell3.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell3.Weight = 1.0;
      this.xrTable4.LocationFloat = new PointFloat(422.5001f, 39.16667f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(55f, 25f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell4
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Miktar";
      this.xrTableCell4.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell4.Weight = 1.0;
      this.xrTable5.LocationFloat = new PointFloat(477.5001f, 39.16667f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(61.66669f, 25f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell5
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell5.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Marka";
      this.xrTableCell5.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell5.Weight = 1.0;
      this.xrTable6.LocationFloat = new PointFloat(539.1667f, 39.16667f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(100f, 25f);
      this.xrTableRow6.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell6.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Birim Fiyat";
      this.xrTableCell6.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell6.Weight = 1.0;
      this.xrTable7.LocationFloat = new PointFloat(639.1667f, 39.16667f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(71.66656f, 25f);
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell7
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Tutar";
      this.xrTableCell7.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell7.Weight = 1.0;
      this.xrTable8.LocationFloat = new PointFloat(52.50008f, 64.16666f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(46.66666f, 25f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell8
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      xrSummary1.Running = SummaryRunning.Report;
      this.xrTableCell8.Summary = xrSummary1;
      this.xrTableCell8.Weight = 1.0;
      this.xrTable9.LocationFloat = new PointFloat(99.16674f, 64.16666f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable9.SizeF = new SizeF(271.6667f, 25f);
      this.xrTableRow9.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell9
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell9.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      xrSummary2.Running = SummaryRunning.Report;
      this.xrTableCell9.Summary = xrSummary2;
      this.xrTableCell9.Weight = 1.0;
      this.xrTable10.LocationFloat = new PointFloat(370.8335f, 64.16666f);
      this.xrTable10.Name = "xrTable10";
      this.xrTable10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable10.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow10
      });
      this.xrTable10.SizeF = new SizeF(51.66666f, 25f);
      this.xrTableRow10.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell10
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell10.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      xrSummary3.Running = SummaryRunning.Report;
      this.xrTableCell10.Summary = xrSummary3;
      this.xrTableCell10.Weight = 1.0;
      this.xrTable11.LocationFloat = new PointFloat(422.5001f, 64.16666f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow11
      });
      this.xrTable11.SizeF = new SizeF(54.99997f, 25f);
      this.xrTableRow11.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell11
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell11.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      xrSummary4.Running = SummaryRunning.Report;
      this.xrTableCell11.Summary = xrSummary4;
      this.xrTableCell11.Weight = 1.0;
      this.xrTable12.LocationFloat = new PointFloat(477.8745f, 64.16666f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable12.SizeF = new SizeF(61.29224f, 25f);
      this.xrTableRow12.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell12
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell12.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MARKA]")
      });
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      xrSummary5.Running = SummaryRunning.Report;
      this.xrTableCell12.Summary = xrSummary5;
      this.xrTableCell12.Weight = 1.0;
      this.xrTable13.LocationFloat = new PointFloat(539.1667f, 64.16666f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable13.SizeF = new SizeF(99.99997f, 25f);
      this.xrTableRow13.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell13
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell13.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMFIYAT]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      xrSummary6.Running = SummaryRunning.Report;
      this.xrTableCell13.Summary = xrSummary6;
      this.xrTableCell13.Weight = 1.0;
      this.xrTable14.LocationFloat = new PointFloat(639.1667f, 64.16666f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable14.SizeF = new SizeF(71.66656f, 25f);
      this.xrTableRow14.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell14
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell14.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TUTAR]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      xrSummary7.Running = SummaryRunning.Report;
      this.xrTableCell14.Summary = xrSummary7;
      this.xrTableCell14.Weight = 1.0;
      this.xrLabel5.Borders = BorderSide.All;
      this.xrLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(52.50008f, 89.16666f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(586.6667f, 23f);
      this.xrLabel5.StylePriority.UseBorders = false;
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "Toplam Tutar";
      this.xrLabel5.TextAlignment = TextAlignment.TopRight;
      this.xrTable15.LocationFloat = new PointFloat(639.1667f, 89.16666f);
      this.xrTable15.Name = "xrTable15";
      this.xrTable15.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable15.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow15
      });
      this.xrTable15.SizeF = new SizeF(71.66656f, 23.00001f);
      this.xrTableRow15.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell15
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell15.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLAMTUTAR]")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      xrSummary8.Running = SummaryRunning.Report;
      this.xrTableCell15.Summary = xrSummary8;
      this.xrTableCell15.Weight = 1.0;
      this.teklifID.Description = "teklifID";
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.GroupHeader1.Controls.AddRange(new XRControl[18]
      {
        (XRControl) this.xrSubreport1,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrTable1,
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable7,
        (XRControl) this.xrTable8,
        (XRControl) this.xrTable9,
        (XRControl) this.xrTable10,
        (XRControl) this.xrTable11,
        (XRControl) this.xrTable12,
        (XRControl) this.xrTable13,
        (XRControl) this.xrTable14,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrTable15
      });
      this.GroupHeader1.HeightF = 157.9998f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrSubreport1.LocationFloat = new PointFloat(52.49996f, 124.9997f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("TeklifId", this.teklifID));
      this.xrSubreport1.ReportSource = (XtraReport) new IdariSartname();
      this.xrSubreport1.SizeF = new SizeF(658.3333f, 23f);
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.PageHeader,
        (Band) this.GroupHeader1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIF";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(47, 64, 100, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.teklifID
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.xrTable5.EndInit();
      this.xrTable6.EndInit();
      this.xrTable7.EndInit();
      this.xrTable8.EndInit();
      this.xrTable9.EndInit();
      this.xrTable10.EndInit();
      this.xrTable11.EndInit();
      this.xrTable12.EndInit();
      this.xrTable13.EndInit();
      this.xrTable14.EndInit();
      this.xrTable15.EndInit();
      this.EndInit();
    }
  }
}
