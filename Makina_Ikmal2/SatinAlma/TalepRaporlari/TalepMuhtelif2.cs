// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.TalepMuhtelif2
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
  public class TalepMuhtelif2 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel29;
    private XRLabel xrLabel11;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel30;
    private XRTable xrTable2;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel9;
    private XRLabel xrLabel14;
    private XRLabel xrLabel10;
    private XRLabel xrLabel13;
    private XRSubreport xrSubreport1;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel12;
    private Parameter id;

    public TalepMuhtelif2() => this.InitializeComponent();

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
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table3 = new Table();
      QueryParameter queryParameter1 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table4 = new Table();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table5 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Table table6 = new Table();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table7 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Table table8 = new Table();
      SelectQuery selectQuery4 = new SelectQuery();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table9 = new Table();
      QueryParameter queryParameter4 = new QueryParameter();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Table table10 = new Table();
      SelectQuery selectQuery5 = new SelectQuery();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table11 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table12 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table13 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Table table14 = new Table();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Table table15 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      Join join8 = new Join();
      RelationColumnInfo relationColumnInfo8 = new RelationColumnInfo();
      Join join9 = new Join();
      RelationColumnInfo relationColumnInfo9 = new RelationColumnInfo();
      Join join10 = new Join();
      RelationColumnInfo relationColumnInfo10 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression25 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepMuhtelif2));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel29 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel30 = new XRLabel();
      this.xrTable2 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrLabel9 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrSubreport1 = new XRSubreport();
      this.id = new Parameter();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrTable2.BeginInit();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "KOD";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table1.Name = "TBLTALEP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "MALZACIKLAMA";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"245\" />";
      table2.Name = "TBLTALEPFISHRKT";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "MIKTAR";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "BIRIMADI";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLMALZBIRIM";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?id";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTALEP_1";
      queryParameter1.Name = "id";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?id", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      relationColumnInfo1.NestedKeyColumn = "TALEPKAYITID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"525\" />";
      table4.Name = "TBLTALEPFIS";
      join1.Nested = table4;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "TALEPFISID";
      relationColumnInfo2.ParentKeyColumn = "ID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table4;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BIRIMID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table3;
      join3.Parent = table2;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table4);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      columnExpression5.ColumnName = "ADISOYADI";
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression5.Table = table5;
      column5.Expression = (ExpressionBase) columnExpression5;
      selectQuery2.Columns.Add((ColumnBase) column5);
      selectQuery2.FilterString = "[TBLTALEP.ID] = ?id";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "DepoYetkili";
      queryParameter2.Name = "id";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?id", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "DEPOYETKILIID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table6.Name = "TBLTALEP";
      join4.Parent = table6;
      selectQuery2.Relations.Add(join4);
      selectQuery2.Tables.Add(table6);
      selectQuery2.Tables.Add(table5);
      columnExpression6.ColumnName = "ADISOYADI";
      table7.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table7.Name = "TBLPERSONEL";
      columnExpression6.Table = table7;
      column6.Expression = (ExpressionBase) columnExpression6;
      selectQuery3.Columns.Add((ColumnBase) column6);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?id";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "AtolyeSef";
      queryParameter3.Name = "id";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?id", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ATOLYESEFID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table7;
      table8.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table8.Name = "TBLTALEP";
      join5.Parent = table8;
      selectQuery3.Relations.Add(join5);
      selectQuery3.Tables.Add(table8);
      selectQuery3.Tables.Add(table7);
      columnExpression7.ColumnName = "ADISOYADI";
      table9.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table9.Name = "TBLPERSONEL";
      columnExpression7.Table = table9;
      column7.Expression = (ExpressionBase) columnExpression7;
      selectQuery4.Columns.Add((ColumnBase) column7);
      selectQuery4.FilterString = "[TBLTALEP.ID] = ?id";
      selectQuery4.GroupFilterString = "";
      selectQuery4.Name = "Mudur";
      queryParameter4.Name = "id";
      queryParameter4.Type = typeof (Expression);
      queryParameter4.Value = (object) new Expression("?id", typeof (int));
      selectQuery4.Parameters.Add(queryParameter4);
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "MUDURID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table9;
      table10.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table10.Name = "TBLTALEP";
      join6.Parent = table10;
      selectQuery4.Relations.Add(join6);
      selectQuery4.Tables.Add(table10);
      selectQuery4.Tables.Add(table9);
      columnExpression8.ColumnName = "MALZACIKLAMA";
      table11.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table11.Name = "TBLTALEPHRKT";
      columnExpression8.Table = table11;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "MALZEMEADI";
      table12.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table12.Name = "TBLMALZEMELER";
      columnExpression9.Table = table12;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "MIKTAR";
      columnExpression10.Table = table11;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "BIRIMADI";
      table13.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table13.Name = "TBLMALZBIRIM";
      columnExpression11.Table = table13;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "FIYAT";
      columnExpression12.Table = table11;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "TUTAR";
      columnExpression13.Table = table11;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "PLAKA";
      table14.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table14.Name = "TBLARACLAR";
      columnExpression14.Table = table14;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "ARACACIKLAMA";
      columnExpression15.Table = table14;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "KOD";
      table15.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table15.Name = "TBLTALEP";
      columnExpression16.Table = table15;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "BELGESAYI";
      columnExpression17.Table = table15;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "BELGEKONU";
      columnExpression18.Table = table15;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "BELGETARIH";
      columnExpression19.Table = table15;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "ISINADI";
      columnExpression20.Table = table15;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "TARIH";
      columnExpression21.Table = table15;
      column21.Expression = (ExpressionBase) columnExpression21;
      columnExpression22.ColumnName = "SAAT";
      columnExpression22.Table = table15;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "TALEPID";
      columnExpression23.Table = table11;
      column23.Expression = (ExpressionBase) columnExpression23;
      columnExpression24.ColumnName = "ID";
      columnExpression24.Table = table11;
      column24.Expression = (ExpressionBase) columnExpression24;
      selectQuery5.Columns.Add((ColumnBase) column8);
      selectQuery5.Columns.Add((ColumnBase) column9);
      selectQuery5.Columns.Add((ColumnBase) column10);
      selectQuery5.Columns.Add((ColumnBase) column11);
      selectQuery5.Columns.Add((ColumnBase) column12);
      selectQuery5.Columns.Add((ColumnBase) column13);
      selectQuery5.Columns.Add((ColumnBase) column14);
      selectQuery5.Columns.Add((ColumnBase) column15);
      selectQuery5.Columns.Add((ColumnBase) column16);
      selectQuery5.Columns.Add((ColumnBase) column17);
      selectQuery5.Columns.Add((ColumnBase) column18);
      selectQuery5.Columns.Add((ColumnBase) column19);
      selectQuery5.Columns.Add((ColumnBase) column20);
      selectQuery5.Columns.Add((ColumnBase) column21);
      selectQuery5.Columns.Add((ColumnBase) column22);
      selectQuery5.Columns.Add((ColumnBase) column23);
      selectQuery5.Columns.Add((ColumnBase) column24);
      selectQuery5.Name = "TBLTALEPHRKT";
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "MALZEMEID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table12;
      join7.Parent = table11;
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "BIRIMID";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table13;
      join8.Parent = table11;
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "TALEPID";
      join9.KeyColumns.Add(relationColumnInfo9);
      join9.Nested = table15;
      join9.Parent = table11;
      relationColumnInfo10.NestedKeyColumn = "ID";
      relationColumnInfo10.ParentKeyColumn = "ARACID";
      join10.KeyColumns.Add(relationColumnInfo10);
      join10.Nested = table14;
      join10.Parent = table11;
      join10.Type = JoinType.LeftOuter;
      selectQuery5.Relations.Add(join7);
      selectQuery5.Relations.Add(join8);
      selectQuery5.Relations.Add(join9);
      selectQuery5.Relations.Add(join10);
      columnExpression25.ColumnName = "ID";
      columnExpression25.Table = table11;
      sorting.Expression = (ExpressionBase) columnExpression25;
      selectQuery5.Sorting.Add(sorting);
      selectQuery5.Tables.Add(table11);
      selectQuery5.Tables.Add(table12);
      selectQuery5.Tables.Add(table13);
      selectQuery5.Tables.Add(table14);
      selectQuery5.Tables.Add(table15);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[5]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3,
        (SqlQuery) selectQuery4,
        (SqlQuery) selectQuery5
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.HeightF = 44.16667f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 8.791554f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel29,
        (XRControl) this.xrLabel11
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.xrLabel6.Borders = BorderSide.All;
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrLabel6.LocationFloat = new PointFloat(703.9135f, 0.0f);
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.SizeF = new SizeF(70.08661f, 25f);
      this.xrLabel6.StylePriority.UseBorders = false;
      this.xrLabel6.Text = "satir";
      this.xrLabel5.Borders = BorderSide.All;
      this.xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrLabel5.LocationFloat = new PointFloat(642.5836f, 0.0f);
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.SizeF = new SizeF(61.32983f, 25f);
      this.xrLabel5.StylePriority.UseBorders = false;
      this.xrLabel5.Text = "satir";
      this.xrLabel29.Borders = BorderSide.All;
      this.xrLabel29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]+' - '+[MALZACIKLAMA]")
      });
      this.xrLabel29.LocationFloat = new PointFloat(46.29178f, 0.0f);
      this.xrLabel29.Name = "xrLabel29";
      this.xrLabel29.SizeF = new SizeF(596.2918f, 25f);
      this.xrLabel29.StylePriority.UseBorders = false;
      this.xrLabel29.StylePriority.UseTextAlignment = false;
      this.xrLabel29.Text = "satir";
      this.xrLabel29.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.Borders = BorderSide.All;
      this.xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrLabel11.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(46.29178f, 25f);
      this.xrLabel11.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel11.Summary = xrSummary;
      this.xrLabel11.Text = "xrLabel11";
      this.PageHeader.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel30,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox2
      });
      this.PageHeader.HeightF = 154.7084f;
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(146.6666f, 37.37503f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(349.7916f, 9.166718f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(146.6666f, 60.37503f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(234.1666f, 83.37504f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(287.5f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "MAL - HİZMET TALEP LİSTESİ";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(673.9159f, 10.00005f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(100.0841f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.HeightF = 30.29152f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel30.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel30.LocationFloat = new PointFloat(674.0002f, 131.7084f);
      this.xrLabel30.Multiline = true;
      this.xrLabel30.Name = "xrLabel30";
      this.xrLabel30.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel30.SizeF = new SizeF(100f, 23f);
      this.xrLabel30.Text = "xrLabel7";
      this.xrTable2.LocationFloat = new PointFloat(642.5837f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable2.SizeF = new SizeF(131.4165f, 29.96325f);
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
      this.xrTableCell25.Text = "Birim";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 0.59372333699079927;
      this.xrTableCell26.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell26.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "Miktar";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 0.67849667263477076;
      this.xrTable1.LocationFloat = new PointFloat(3.178914E-05f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(642.5837f, 29.96325f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell1,
        this.xrTableCell2
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 0.5;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell1.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "S.No";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 0.18483732269453873;
      this.xrTableCell2.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell2.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "İmalatın Cinsi";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 2.3809193005634617;
      this.GroupFooter1.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrSubreport1,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel12
      });
      this.GroupFooter1.HeightF = 129.0001f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel9.LocationFloat = new PointFloat(50.83333f, 60f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.Text = "Ambar Yetkilisi";
      this.xrLabel14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel14.LocationFloat = new PointFloat(40.83325f, 83.00002f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(182.4999f, 23.00001f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.Text = "Ambarda mevcudu yoktur.\r\n";
      this.xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(297.2916f, 60f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.Text = "Atölye Şefi";
      this.xrLabel13.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel13.LocationFloat = new PointFloat(551.2915f, 60f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.Text = "Şube Müdürü";
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("talepID", this.id));
      this.xrSubreport1.ReportSource = (XtraReport) new TeklifTeknikSartnameDuz();
      this.xrSubreport1.SizeF = new SizeF(774.0001f, 23f);
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AtolyeSef].[ADISOYADI]")
      });
      this.xrLabel7.LocationFloat = new PointFloat(297.2916f, 82.99998f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(108.3333f, 23.00001f);
      this.xrLabel7.Text = "xrLabel7";
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Mudur].[ADISOYADI]")
      });
      this.xrLabel8.LocationFloat = new PointFloat(551.2915f, 83.00003f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(108.3333f, 23.00001f);
      this.xrLabel8.Text = "xrLabel8";
      this.xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DepoYetkili].[ADISOYADI]")
      });
      this.xrLabel12.LocationFloat = new PointFloat(50.83333f, 106.0001f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel12.Text = "xrLabel12";
      this.Bands.AddRange(new Band[6]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.PageHeader,
        (Band) this.GroupHeader1,
        (Band) this.GroupFooter1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTALEPHRKT";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(38, 38, 44, 9);
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.Version = "20.1";
      this.xrTable2.EndInit();
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
