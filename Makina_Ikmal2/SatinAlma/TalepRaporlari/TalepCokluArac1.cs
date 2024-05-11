// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.TalepCokluArac1
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
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

namespace Makina_Ikmal.SatinAlma.TalepRaporlari
{
  public class TalepCokluArac1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTable xrTable3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell5;
    private XRTable xrTable4;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell2;
    private XRLabel xrLabel7;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    private XRSubreport xrSubreport1;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel13;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private Parameter talepID;

    public TalepCokluArac1() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      SelectQuery selectQuery1 = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table1 = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Table table2 = new Table();
      QueryParameter queryParameter1 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Table table3 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table4 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table5 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Table table6 = new Table();
      SelectQuery selectQuery4 = new SelectQuery();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table7 = new Table();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table8 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table9 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table10 = new Table();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table11 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression15 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepCokluArac1));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel13 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrLabel28 = new XRLabel();
      this.xrLabel29 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable2 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrLabel7 = new XRLabel();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrLabel11 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrSubreport1 = new XRSubreport();
      this.talepID = new Parameter();
      this.xrLabel10 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ATOLYESEFID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table1.Name = "TBLTALEP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "AtolyeSefi";
      queryParameter1.Name = "talepID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ATOLYESEFID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table2);
      columnExpression3.ColumnName = "MUDURID";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table3.Name = "TBLTALEP";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ADISOYADI";
      table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      selectQuery2.Columns.Add((ColumnBase) column3);
      selectQuery2.Columns.Add((ColumnBase) column4);
      selectQuery2.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "SubeMuduru";
      queryParameter2.Name = "talepID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MUDURID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table4;
      join2.Parent = table3;
      selectQuery2.Relations.Add(join2);
      selectQuery2.Tables.Add(table3);
      selectQuery2.Tables.Add(table4);
      columnExpression5.ColumnName = "ADISOYADI";
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression5.Table = table5;
      column5.Expression = (ExpressionBase) columnExpression5;
      selectQuery3.Columns.Add((ColumnBase) column5);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "DepoSorumlusu";
      queryParameter3.Name = "talepID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "DEPOYETKILIID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table5;
      table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table6.Name = "TBLTALEP";
      join3.Parent = table6;
      selectQuery3.Relations.Add(join3);
      selectQuery3.Tables.Add(table6);
      selectQuery3.Tables.Add(table5);
      columnExpression6.ColumnName = "MALZEMEADI";
      table7.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table7.Name = "TBLMALZEMELER";
      columnExpression6.Table = table7;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "PLAKA";
      table8.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table8.Name = "TBLARACLAR";
      columnExpression7.Table = table8;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "ARACACIKLAMA";
      columnExpression8.Table = table8;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "KOD";
      table9.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table9.Name = "TBLTALEP";
      columnExpression9.Table = table9;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BIRIMADI";
      table10.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table10.Name = "TBLMALZBIRIM";
      columnExpression10.Table = table10;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "MIKTAR";
      table11.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table11.Name = "TBLTALEPHRKT";
      columnExpression11.Table = table11;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "TALEPID";
      columnExpression12.Table = table11;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ISINADI";
      columnExpression13.Table = table9;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "ID";
      columnExpression14.Table = table11;
      column14.Expression = (ExpressionBase) columnExpression14;
      selectQuery4.Columns.Add((ColumnBase) column6);
      selectQuery4.Columns.Add((ColumnBase) column7);
      selectQuery4.Columns.Add((ColumnBase) column8);
      selectQuery4.Columns.Add((ColumnBase) column9);
      selectQuery4.Columns.Add((ColumnBase) column10);
      selectQuery4.Columns.Add((ColumnBase) column11);
      selectQuery4.Columns.Add((ColumnBase) column12);
      selectQuery4.Columns.Add((ColumnBase) column13);
      selectQuery4.Columns.Add((ColumnBase) column14);
      selectQuery4.FilterString = "";
      selectQuery4.GroupFilterString = "";
      selectQuery4.Name = "AnaTalep";
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "MALZEMEID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table7;
      join4.Parent = table11;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ARACID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table8;
      join5.Parent = table11;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "TALEPID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table9;
      join6.Parent = table11;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "BIRIMID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table10;
      join7.Parent = table11;
      selectQuery4.Relations.Add(join4);
      selectQuery4.Relations.Add(join5);
      selectQuery4.Relations.Add(join6);
      selectQuery4.Relations.Add(join7);
      columnExpression15.ColumnName = "ID";
      columnExpression15.Table = table11;
      sorting.Expression = (ExpressionBase) columnExpression15;
      selectQuery4.Sorting.Add(sorting);
      selectQuery4.Tables.Add(table11);
      selectQuery4.Tables.Add(table7);
      selectQuery4.Tables.Add(table8);
      selectQuery4.Tables.Add(table9);
      selectQuery4.Tables.Add(table10);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[4]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3,
        (SqlQuery) selectQuery4
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel7,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 129.0834f;
      this.TopMargin.Name = "TopMargin";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(579.6251f, 10.00005f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(210f, 84.2084f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(287.5f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "MAL - HİZMET TALEP LİSTESİ";
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(325.625f, 10.00005f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(122.5f, 38.20836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(122.5f, 61.20837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(10f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel13,
        (XRControl) this.xrTable1,
        (XRControl) this.xrLabel28,
        (XRControl) this.xrLabel29
      });
      this.Detail.HeightF = 23.8431f;
      this.Detail.Name = "Detail";
      this.xrLabel13.Borders = BorderSide.All;
      this.xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrLabel13.Font = new Font("Arial", 9f);
      this.xrLabel13.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(45.00033f, 21.92156f);
      this.xrLabel13.StylePriority.UseBorders = false;
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel13.Summary = xrSummary;
      this.xrLabel13.Text = "xrLabel13";
      this.xrLabel13.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTable1.Font = new Font("Arial", 9f);
      this.xrTable1.LocationFloat = new PointFloat(709.5685f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(73.43158f, 21.92156f);
      this.xrTable1.StylePriority.UseFont = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 0.5;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrTableCell1.Font = new Font("Arial", 10f);
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Miktar";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 0.76975763028666211;
      this.xrLabel28.Borders = BorderSide.All;
      this.xrLabel28.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrLabel28.Font = new Font("Arial", 9f);
      this.xrLabel28.LocationFloat = new PointFloat(655.4584f, 0.0f);
      this.xrLabel28.Name = "xrLabel28";
      this.xrLabel28.SizeF = new SizeF(54.11011f, 21.92156f);
      this.xrLabel28.StylePriority.UseBorders = false;
      this.xrLabel28.StylePriority.UseFont = false;
      this.xrLabel28.StylePriority.UseTextAlignment = false;
      this.xrLabel28.Text = "satir";
      this.xrLabel28.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel29.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrLabel29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI] +' - '+ [ARACACIKLAMA]+' - ' + [PLAKA]")
      });
      this.xrLabel29.Font = new Font("Arial", 9f);
      this.xrLabel29.LocationFloat = new PointFloat(45.00033f, 0.0f);
      this.xrLabel29.Name = "xrLabel29";
      this.xrLabel29.SizeF = new SizeF(610.4581f, 21.92156f);
      this.xrLabel29.StylePriority.UseBorders = false;
      this.xrLabel29.StylePriority.UseFont = false;
      this.xrLabel29.StylePriority.UseTextAlignment = false;
      this.xrLabel29.Text = "satir";
      this.xrLabel29.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupHeader1.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable4
      });
      this.GroupHeader1.HeightF = 30.12991f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable2.LocationFloat = new PointFloat(6.357829E-05f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable2.SizeF = new SizeF(655.4584f, 29.96325f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell25,
        this.xrTableCell26
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 0.5;
      this.xrTableCell25.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell25.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "S.No";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 0.1796806174094801;
      this.xrTableCell26.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell26.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "İmalatın Cinsi";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 2.4374829827278264;
      this.xrTable3.LocationFloat = new PointFloat(655.4584f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable3.SizeF = new SizeF(54.11011f, 29.96325f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell5
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 0.5;
      this.xrTableCell5.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell5.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Birim";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.76975763028666211;
      this.xrTable4.LocationFloat = new PointFloat(709.5686f, 0.0f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable4.SizeF = new SizeF(73.43152f, 29.96325f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 0.5;
      this.xrTableCell2.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell2.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Miktar";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.76975763028666211;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel7.LocationFloat = new PointFloat(680.4016f, 100f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(102.5984f, 23f);
      this.xrLabel7.Text = "xrLabel7";
      this.GroupFooter1.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrSubreport1,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8
      });
      this.GroupFooter1.HeightF = 129.3087f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrLabel11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(79.16692f, 45.99994f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(164.7765f, 22.99999f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "Mevcudu depoda yoktur.";
      this.xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DepoSorumlusu].[ADISOYADI]")
      });
      this.xrLabel12.LocationFloat = new PointFloat(79.16692f, 69.00002f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(164.7765f, 23f);
      this.xrLabel12.Text = "xrLabel12";
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SubeMuduru].[ADISOYADI]")
      });
      this.xrLabel6.LocationFloat = new PointFloat(579.4586f, 45.99994f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(129.5416f, 23.00001f);
      this.xrLabel6.Text = "xrLabel6";
      this.xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AtolyeSefi].[ADISOYADI]")
      });
      this.xrLabel5.LocationFloat = new PointFloat(325.6251f, 46f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(145.1667f, 23.00001f);
      this.xrLabel5.Text = "xrLabel5";
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("talepID", this.talepID));
      this.xrSubreport1.ReportSource = (XtraReport) new TeklifTeknikSartnameDuz();
      this.xrSubreport1.SizeF = new SizeF(783.0001f, 23f);
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
      this.xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(579.6251f, 22.99999f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.Text = "Şube Müdürü";
      this.xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel9.LocationFloat = new PointFloat(325.6251f, 22.99999f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.Text = "Atölye Şefi";
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(79.16692f, 22.99999f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "Ambar Yetkilisi";
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1,
        (Band) this.GroupFooter1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "AnaTalep";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPID] = ?talepID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(30, 37, 129, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
      });
      this.TextAlignment = TextAlignment.MiddleLeft;
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.EndInit();
    }
  }
}
