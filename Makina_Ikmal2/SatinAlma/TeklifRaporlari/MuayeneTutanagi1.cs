// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.MuayeneTutanagi1
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

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class MuayeneTutanagi1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel5;
    private GroupHeaderBand GroupHeader1;
    private Parameter teklifID;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell20;
    private XRLabel xrLabel29;
    private XRLabel xrLabel2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel1;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell13;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell25;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell3;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell2;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRLabel xrLabel18;

    public MuayeneTutanagi1() => this.InitializeComponent();

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
      Table table2 = new Table();
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
      Table table3 = new Table();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Table table4 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Table table5 = new Table();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Table table6 = new Table();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Table table7 = new Table();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Table table8 = new Table();
      QueryParameter queryParameter = new QueryParameter();
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
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression24 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MuayeneTutanagi1));
      XRSummary xrSummary1 = new XRSummary();
      XRSummary xrSummary2 = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel8 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrTable13 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell20 = new XRTableCell();
      this.xrLabel29 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.PageHeader = new PageHeaderBand();
      this.xrLabel5 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTable9 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTable10 = new XRTable();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTable11 = new XRTable();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.teklifID = new Parameter();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrLabel17 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrTable12 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTable15 = new XRTable();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrLabel18 = new XRLabel();
      this.xrLabel19 = new XRLabel();
      this.xrLabel20 = new XRLabel();
      this.xrTable13.BeginInit();
      this.xrTable8.BeginInit();
      this.xrTable9.BeginInit();
      this.xrTable10.BeginInit();
      this.xrTable11.BeginInit();
      this.xrTable7.BeginInit();
      this.xrTable6.BeginInit();
      this.xrTable5.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable12.BeginInit();
      this.xrTable14.BeginInit();
      this.xrTable15.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "KOD";
      table1.MetaSerializable = "<Meta X=\"-130\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table1.Name = "TBLTEKLIF";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "FATURATARIHI";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "FATURANO";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "FATURATUTAR";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "KDVTUTAR";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "TOPLAMTUTAR";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "FATTUTARYAZIYLA";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "MIKTAR";
      table2.MetaSerializable = "<Meta X=\"20\" Y=\"30\" Width=\"125\" Height=\"743\" />";
      table2.Name = "TBLTEKLIFHRKT";
      columnExpression8.Table = table2;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BIRIMFIYAT";
      columnExpression9.Table = table2;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "MALZACIKLAMA";
      columnExpression10.Table = table2;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "TUTAR";
      columnExpression11.Table = table2;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "BIRIMID";
      columnExpression12.Table = table2;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "BIRIMADI";
      table3.MetaSerializable = "<Meta X=\"175\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table3.Name = "TBLMALZBIRIM";
      columnExpression13.Table = table3;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "SAKARARNO";
      columnExpression14.Table = table1;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "SAKARARTARIHI";
      columnExpression15.Table = table1;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "MALZEMEADI";
      table4.MetaSerializable = "<Meta X=\"330\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table4.Name = "TBLMALZEMELER";
      columnExpression16.Table = table4;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "FIRMAADI";
      table5.MetaSerializable = "<Meta X=\"485\" Y=\"30\" Width=\"125\" Height=\"483\" />";
      table5.Name = "TBLFIRMALAR";
      columnExpression17.Table = table5;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "ID";
      columnExpression18.Table = table2;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "F1TUTAR";
      columnExpression19.Table = table2;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "F1BIRIMFIYAT";
      columnExpression20.Table = table2;
      column20.Expression = (ExpressionBase) columnExpression20;
      column21.Alias = "KomUye1";
      columnExpression21.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"640\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression21.Table = table6;
      column21.Expression = (ExpressionBase) columnExpression21;
      column22.Alias = "KomUye2";
      columnExpression22.ColumnName = "ADISOYADI";
      table7.Alias = "TBLPERSONEL_1";
      table7.MetaSerializable = "<Meta X=\"795\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table7.Name = "TBLPERSONEL";
      columnExpression22.Table = table7;
      column22.Expression = (ExpressionBase) columnExpression22;
      column23.Alias = "KomBas";
      columnExpression23.ColumnName = "ADISOYADI";
      table8.Alias = "TBLPERSONEL_2";
      table8.MetaSerializable = "<Meta X=\"950\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table8.Name = "TBLPERSONEL";
      columnExpression23.Table = table8;
      column23.Expression = (ExpressionBase) columnExpression23;
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
      selectQuery.FilterString = "[TBLTEKLIF.ID] = ?teklifID";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "AnaTablo";
      queryParameter.Name = "teklifID";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?teklifID", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "BIRIMID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table2;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "KAZANANFIRMAID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table5;
      join2.Parent = table1;
      join2.Type = JoinType.LeftOuter;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MALZEMEID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table2;
      join3.Type = JoinType.LeftOuter;
      relationColumnInfo4.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo4.ParentKeyColumn = "ID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table2;
      join4.Parent = table1;
      join4.Type = JoinType.LeftOuter;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "KOMBSKID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table8;
      join5.Parent = table1;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "KOMUYE2ID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table7;
      join6.Parent = table1;
      join6.Type = JoinType.LeftOuter;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "KOMUYE1ID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table6;
      join7.Parent = table1;
      join7.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Relations.Add(join6);
      selectQuery.Relations.Add(join7);
      columnExpression24.ColumnName = "ID";
      columnExpression24.Table = table2;
      sorting.Expression = (ExpressionBase) columnExpression24;
      selectQuery.Sorting.Add(sorting);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table7);
      selectQuery.Tables.Add(table8);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 52f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrTable13,
        (XRControl) this.xrLabel29,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel1
      });
      this.Detail.HeightF = 36.25005f;
      this.Detail.Name = "Detail";
      this.xrLabel8.Borders = BorderSide.All;
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F1TUTAR]")
      });
      this.xrLabel8.LocationFloat = new PointFloat(596.4584f, 0.0f);
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.SizeF = new SizeF(146.5416f, 35.83334f);
      this.xrLabel8.StylePriority.UseBorders = false;
      this.xrLabel8.Text = "satir";
      this.xrLabel7.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F1BIRIMFIYAT]")
      });
      this.xrLabel7.LocationFloat = new PointFloat(505.5351f, 0.0f);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.SizeF = new SizeF(90.00339f, 35.83334f);
      this.xrLabel7.StylePriority.UseBorders = false;
      this.xrLabel7.Text = "satir";
      this.xrTable13.LocationFloat = new PointFloat(25.91348f, 0.0f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable13.SizeF = new SizeF(67.16952f, 35.83334f);
      this.xrTableRow13.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell20
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell20.Borders = BorderSide.All;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
      this.xrTableCell20.StylePriority.UseBorders = false;
      this.xrTableCell20.StylePriority.UsePadding = false;
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      xrSummary1.Running = SummaryRunning.Report;
      this.xrTableCell20.Summary = xrSummary1;
      this.xrTableCell20.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell20.Weight = 0.35625392637379827;
      this.xrLabel29.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrLabel29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[MALZACIKLAMA]")
      });
      this.xrLabel29.LocationFloat = new PointFloat(279.5414f, 0.0f);
      this.xrLabel29.Name = "xrLabel29";
      this.xrLabel29.SizeF = new SizeF(100.5812f, 35.83334f);
      this.xrLabel29.StylePriority.UseBorders = false;
      this.xrLabel29.StylePriority.UseTextAlignment = false;
      this.xrLabel29.Text = "satir";
      this.xrLabel29.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[BIRIMADI]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(380.1226f, 0.0f);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.SizeF = new SizeF(59.12427f, 35.83334f);
      this.xrLabel2.StylePriority.UseBorders = false;
      this.xrLabel2.Text = "satir";
      this.xrLabel6.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[MIKTAR]")
      });
      this.xrLabel6.LocationFloat = new PointFloat(439.2468f, 0.0f);
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.SizeF = new SizeF(66.2883f, 35.83334f);
      this.xrLabel6.StylePriority.UseBorders = false;
      this.xrLabel6.Text = "satir";
      this.xrLabel1.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.xrLabel1.LocationFloat = new PointFloat(93.08298f, 0.0f);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.SizeF = new SizeF(186.4584f, 35.83334f);
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "satir";
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
      this.PageHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel5,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.PageHeader.HeightF = 135.8333f;
      this.PageHeader.Name = "PageHeader";
      this.xrLabel5.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(125.8334f, 104.5f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(476f, 29.66668f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = " MAL / HİZMET MUAYENE VE KABUL TUTANAĞI";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(595.4584f, 7.500025f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(138.3333f, 58.70834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(125.8334f, 35.70834f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(25.83338f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[11]
      {
        (XRControl) this.xrTable8,
        (XRControl) this.xrTable9,
        (XRControl) this.xrTable10,
        (XRControl) this.xrTable11,
        (XRControl) this.xrTable7,
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.HeightF = 158.1251f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable8.LocationFloat = new PointFloat(595.5385f, 128.1618f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(146.5416f, 29.96327f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell13
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 0.5;
      this.xrTableCell13.Borders = BorderSide.All;
      this.xrTableCell13.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.StylePriority.UseFont = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "Tutar";
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 0.87897573803783724;
      this.xrTable9.LocationFloat = new PointFloat(380.1226f, 128.1618f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable9.SizeF = new SizeF(125.4126f, 29.96325f);
      this.xrTableRow9.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell14,
        this.xrTableCell15
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 0.5;
      this.xrTableCell14.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell14.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseFont = false;
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "Birim";
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell14.Weight = 0.56620522021994346;
      this.xrTableCell15.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell15.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.Text = "Miktar";
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 0.63481188457650439;
      this.xrTable10.LocationFloat = new PointFloat(25.91348f, 128.1618f);
      this.xrTable10.Name = "xrTable10";
      this.xrTable10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable10.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow10
      });
      this.xrTable10.SizeF = new SizeF(354.209f, 29.96325f);
      this.xrTableRow10.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 0.5;
      this.xrTableCell16.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell16.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "S.No";
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell16.Weight = 0.26619229512822529;
      this.xrTableCell17.Borders = BorderSide.All;
      this.xrTableCell17.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Tanımı";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell17.Weight = 1.1375355228229886;
      this.xrTable11.LocationFloat = new PointFloat(505.5351f, 128.1618f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow11
      });
      this.xrTable11.SizeF = new SizeF(90.00345f, 29.96326f);
      this.xrTableRow11.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell25
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 0.5;
      this.xrTableCell25.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell25.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "Fiyat";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 0.97288754919872289;
      this.xrTable7.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable7.LocationFloat = new PointFloat(439.2469f, 107.3285f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(302.8333f, 19.99997f);
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell11,
        this.xrTableCell12
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell11.Borders = BorderSide.None;
      this.xrTableCell11.CanGrow = false;
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "Fatura Tutarı:";
      this.xrTableCell11.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell11.Weight = 1.7582816944187649;
      this.xrTableCell12.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell12.CanGrow = false;
      this.xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[FATURATUTAR]")
      });
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.Text = "xrTableCell3";
      this.xrTableCell12.Weight = 1.6485926684796397;
      this.xrTable6.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable6.LocationFloat = new PointFloat(439.1667f, 85.6618f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell9,
        this.xrTableCell10
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell9.Borders = BorderSide.Bottom;
      this.xrTableCell9.CanGrow = false;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "Fatura Tarihi:";
      this.xrTableCell9.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell9.Weight = 1.7582816944187649;
      this.xrTableCell10.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell10.CanGrow = false;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[FATURATARIHI]")
      });
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.Text = "xrTableCell3";
      this.xrTableCell10.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell10.Weight = 1.6485926684796397;
      this.xrTable5.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable5.LocationFloat = new PointFloat(439.2469f, 63.99515f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell7,
        this.xrTableCell8
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.Bottom;
      this.xrTableCell7.CanGrow = false;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Fatura / İrsaliye No:";
      this.xrTableCell7.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell7.Weight = 1.7582816944187649;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell8.CanGrow = false;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AnaTablo].[FATURANO]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.Text = "xrTableCell3";
      this.xrTableCell8.Weight = 1.6485926684796397;
      this.xrTable4.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable4.LocationFloat = new PointFloat(439.1667f, 42.32846f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell5,
        this.xrTableCell6
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell5.Borders = BorderSide.Bottom;
      this.xrTableCell5.CanGrow = false;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Satın Alma Karar No:";
      this.xrTableCell5.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell5.Weight = 1.7582816944187649;
      this.xrTableCell6.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell6.CanGrow = false;
      this.xrTableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAKARARNO]")
      });
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.Text = "xrTableCell3";
      this.xrTableCell6.Weight = 1.6485926684796397;
      this.xrTable3.LocationFloat = new PointFloat(25.83338f, 76.49516f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(413.3333f, 51.66664f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell4
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[FIRMAADI]")
      });
      this.xrTableCell4.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 1.0;
      this.xrTable2.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable2.LocationFloat = new PointFloat(439.2469f, 20.6618f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell1,
        this.xrTableCell3
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell1.CanGrow = false;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Satin Alma Karar Tarihi:";
      this.xrTableCell1.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell1.Weight = 1.7582816944187649;
      this.xrTableCell3.Borders = BorderSide.All;
      this.xrTableCell3.CanGrow = false;
      this.xrTableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAKARARTARIHI]")
      });
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.Text = "xrTableCell3";
      this.xrTableCell3.Weight = 1.6485926684796397;
      this.xrTable1.LocationFloat = new PointFloat(25.83338f, 21.49516f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(413.3333f, 55f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.Font = new Font("Arial", 14f, FontStyle.Bold | FontStyle.Underline);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Fatura Sahibi";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 1.0;
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.GroupFooter1.Controls.AddRange(new XRControl[15]
      {
        (XRControl) this.xrLabel20,
        (XRControl) this.xrLabel19,
        (XRControl) this.xrLabel18,
        (XRControl) this.xrLabel17,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrTable12,
        (XRControl) this.xrTable14,
        (XRControl) this.xrTable15
      });
      this.GroupFooter1.HeightF = 308.3327f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrLabel17.LocationFloat = new PointFloat(621.3685f, 243.6667f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(120.6312f, 23.00003f);
      this.xrLabel17.Text = "Komisyon Başkanı";
      this.xrLabel16.LocationFloat = new PointFloat(458.8685f, 243.6667f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(46.66666f, 23.00003f);
      this.xrLabel16.Text = "Üye";
      this.xrLabel15.LocationFloat = new PointFloat(248.8333f, 243.6667f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(46.66666f, 23.00003f);
      this.xrLabel15.Text = "Üye";
      this.xrLabel14.LocationFloat = new PointFloat(44.66667f, 243.6667f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(65.83334f, 23f);
      this.xrLabel14.Text = "Ünvanı:";
      this.xrLabel13.LocationFloat = new PointFloat(44.66667f, 220.6667f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(95.83333f, 23.00003f);
      this.xrLabel13.Text = "Adı Soyadı:";
      this.xrLabel12.LocationFloat = new PointFloat(44.66667f, 197.6667f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(65.83334f, 23f);
      this.xrLabel12.Text = "İmzası:";
      this.xrLabel11.Font = new Font("Arial", 12f);
      this.xrLabel11.LocationFloat = new PointFloat(275.3334f, 161f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(241.6667f, 23f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "Muayene ve Kabul Komisyonu";
      this.xrLabel10.LocationFloat = new PointFloat(25.83338f, 119.1667f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(349.5001f, 23f);
      this.xrLabel10.Text = "muayene ve kabulünde bir sakınca olmadığı görülmüştür.";
      this.xrLabel9.LocationFloat = new PointFloat(25.83338f, 96.1667f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(716.1663f, 23f);
      this.xrLabel9.Text = "Yukarıda cins, özellik ve miktarı belirtilen malın / hizmetin tarafımızdan muayene edilerek sözleşmeye uygun olduğu, ";
      this.xrTable12.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable12.LocationFloat = new PointFloat(440.1667f, 0.0f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable12.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow12.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell18,
        this.xrTableCell19
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell18.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell18.CanGrow = false;
      this.xrTableCell18.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.Text = "Tutar:";
      this.xrTableCell18.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell18.Weight = 1.7582816944187649;
      this.xrTableCell19.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell19.CanGrow = false;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sum([F1TUTAR])")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBorders = false;
      xrSummary2.Running = SummaryRunning.Page;
      this.xrTableCell19.Summary = xrSummary2;
      this.xrTableCell19.Weight = 1.6485926684796397;
      this.xrTable14.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable14.LocationFloat = new PointFloat(439.1663f, 21.66665f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable14.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow14.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell21,
        this.xrTableCell22
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell21.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell21.CanGrow = false;
      this.xrTableCell21.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.StylePriority.UseTextAlignment = false;
      this.xrTableCell21.Text = "KDV:";
      this.xrTableCell21.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell21.Weight = 1.7582816944187649;
      this.xrTableCell22.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell22.CanGrow = false;
      this.xrTableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KDVTUTAR]")
      });
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.Weight = 1.6485926684796397;
      this.xrTable15.AnchorVertical = VerticalAnchorStyles.Bottom;
      this.xrTable15.LocationFloat = new PointFloat(439.1663f, 43.33331f);
      this.xrTable15.Name = "xrTable15";
      this.xrTable15.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable15.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow15
      });
      this.xrTable15.SizeF = new SizeF(302.8333f, 21.66667f);
      this.xrTableRow15.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell23,
        this.xrTableCell24
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell23.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell23.CanGrow = false;
      this.xrTableCell23.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.StylePriority.UseTextAlignment = false;
      this.xrTableCell23.Text = "Toplam Tutar:";
      this.xrTableCell23.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell23.Weight = 1.7582816944187649;
      this.xrTableCell24.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell24.CanGrow = false;
      this.xrTableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLAMTUTAR]")
      });
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.Weight = 1.6485926684796397;
      this.xrLabel18.LocationFloat = new PointFloat(570.6252f, 266.6668f);
      this.xrLabel18.Multiline = true;
      this.xrLabel18.Name = "xrLabel18";
      this.xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel18.SizeF = new SizeF(182.3748f, 23f);
      this.xrLabel18.StylePriority.UseTextAlignment = false;
      this.xrLabel18.Text = "[KomBas]";
      this.xrLabel18.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KomUye1]")
      });
      this.xrLabel19.LocationFloat = new PointFloat(188.0417f, 266.6668f);
      this.xrLabel19.Multiline = true;
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel19.SizeF = new SizeF(175f, 23f);
      this.xrLabel19.StylePriority.UseTextAlignment = false;
      this.xrLabel19.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KomUye2]")
      });
      this.xrLabel20.LocationFloat = new PointFloat(363.0417f, 266.6668f);
      this.xrLabel20.Multiline = true;
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel20.SizeF = new SizeF(207.5834f, 23f);
      this.xrLabel20.StylePriority.UseTextAlignment = false;
      this.xrLabel20.TextAlignment = TextAlignment.TopCenter;
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
      this.DataMember = "AnaTablo";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(38, 59, 100, 52);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.teklifID
      });
      this.Version = "20.1";
      this.xrTable13.EndInit();
      this.xrTable8.EndInit();
      this.xrTable9.EndInit();
      this.xrTable10.EndInit();
      this.xrTable11.EndInit();
      this.xrTable7.EndInit();
      this.xrTable6.EndInit();
      this.xrTable5.EndInit();
      this.xrTable4.EndInit();
      this.xrTable3.EndInit();
      this.xrTable2.EndInit();
      this.xrTable1.EndInit();
      this.xrTable12.EndInit();
      this.xrTable14.EndInit();
      this.xrTable15.EndInit();
      this.EndInit();
    }
  }
}
