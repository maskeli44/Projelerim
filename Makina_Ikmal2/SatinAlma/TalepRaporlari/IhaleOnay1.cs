// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.IhaleOnay1
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.SatinAlma.TalepRaporlari
{
  public class IhaleOnay1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRLabel xrLabel1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell7;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell6;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell10;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell12;
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
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTable xrTable16;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTable xrTable17;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTable xrTable18;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTable xrTable19;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTable xrTable20;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTable xrTable21;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTable xrTable22;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell40;
    private XRTable xrTable23;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell41;
    private XRTable xrTable24;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell42;
    private XRTable xrTable25;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell43;
    private XRTable xrTable26;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell44;
    private XRTable xrTable27;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell45;
    private XRTable xrTable28;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell46;
    private XRTable xrTable29;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell47;
    private XRSubreport xrSubreport1;
    private Parameter talepID;

    public IhaleOnay1() => this.InitializeComponent();

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
      QueryParameter queryParameter1 = new QueryParameter();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table2 = new Table();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table3 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Table table4 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Table table5 = new Table();
      SelectQuery selectQuery4 = new SelectQuery();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Table table6 = new Table();
      QueryParameter queryParameter4 = new QueryParameter();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Table table7 = new Table();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IhaleOnay1));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrSubreport1 = new XRSubreport();
      this.talepID = new Parameter();
      this.PageHeader = new PageHeaderBand();
      this.xrLabel1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
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
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTable12 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTable13 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
      this.xrTable15 = new XRTable();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell27 = new XRTableCell();
      this.xrTable16 = new XRTable();
      this.xrTableRow16 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell29 = new XRTableCell();
      this.xrTable17 = new XRTable();
      this.xrTableRow17 = new XRTableRow();
      this.xrTableCell30 = new XRTableCell();
      this.xrTableCell31 = new XRTableCell();
      this.xrTable18 = new XRTable();
      this.xrTableRow18 = new XRTableRow();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableCell33 = new XRTableCell();
      this.xrTable19 = new XRTable();
      this.xrTableRow19 = new XRTableRow();
      this.xrTableCell34 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTable20 = new XRTable();
      this.xrTableRow20 = new XRTableRow();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableCell37 = new XRTableCell();
      this.xrTable21 = new XRTable();
      this.xrTableRow21 = new XRTableRow();
      this.xrTableCell38 = new XRTableCell();
      this.xrTableCell39 = new XRTableCell();
      this.xrTable22 = new XRTable();
      this.xrTableRow22 = new XRTableRow();
      this.xrTableCell40 = new XRTableCell();
      this.xrTable23 = new XRTable();
      this.xrTableRow23 = new XRTableRow();
      this.xrTableCell41 = new XRTableCell();
      this.xrTable24 = new XRTable();
      this.xrTableRow24 = new XRTableRow();
      this.xrTableCell42 = new XRTableCell();
      this.xrTable25 = new XRTable();
      this.xrTableRow25 = new XRTableRow();
      this.xrTableCell43 = new XRTableCell();
      this.xrTable26 = new XRTable();
      this.xrTableRow26 = new XRTableRow();
      this.xrTableCell44 = new XRTableCell();
      this.xrTable27 = new XRTable();
      this.xrTableRow27 = new XRTableRow();
      this.xrTableCell45 = new XRTableCell();
      this.xrTable28 = new XRTable();
      this.xrTableRow28 = new XRTableRow();
      this.xrTableCell46 = new XRTableCell();
      this.xrTable29 = new XRTable();
      this.xrTableRow29 = new XRTableRow();
      this.xrTableCell47 = new XRTableCell();
      this.xrTable5.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable4.BeginInit();
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
      this.xrTable16.BeginInit();
      this.xrTable17.BeginInit();
      this.xrTable18.BeginInit();
      this.xrTable19.BeginInit();
      this.xrTable20.BeginInit();
      this.xrTable21.BeginInit();
      this.xrTable22.BeginInit();
      this.xrTable23.BeginInit();
      this.xrTable24.BeginInit();
      this.xrTable25.BeginInit();
      this.xrTable26.BeginInit();
      this.xrTable27.BeginInit();
      this.xrTable28.BeginInit();
      this.xrTable29.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "BELGESAYI";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table1.Name = "TBLTALEP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "BELGEKONU";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "BELGETARIH";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ISINADI";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "ISINYAPYERI";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "BUTCETERTIBI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "YAKLASIKMALIYET";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "KULLODENEKTUTAR";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "IHALEUSULU";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.Columns.Add((ColumnBase) column5);
      selectQuery1.Columns.Add((ColumnBase) column6);
      selectQuery1.Columns.Add((ColumnBase) column7);
      selectQuery1.Columns.Add((ColumnBase) column8);
      selectQuery1.Columns.Add((ColumnBase) column9);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "GenelTablo";
      queryParameter1.Name = "talepID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      selectQuery1.Tables.Add(table1);
      columnExpression10.ColumnName = "BILGINOTU";
      table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table2.Name = "TBLTALEP";
      columnExpression10.Table = table2;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "OLURILGISI";
      table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table3.Name = "TBLTEKLIF";
      columnExpression11.Table = table3;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "TEKLIFKONUSU";
      columnExpression12.Table = table3;
      column12.Expression = (ExpressionBase) columnExpression12;
      selectQuery2.Columns.Add((ColumnBase) column10);
      selectQuery2.Columns.Add((ColumnBase) column11);
      selectQuery2.Columns.Add((ColumnBase) column12);
      selectQuery2.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "TeklifTablo";
      queryParameter2.Name = "talepID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "TEKLIFID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table2;
      selectQuery2.Relations.Add(join1);
      selectQuery2.Tables.Add(table2);
      selectQuery2.Tables.Add(table3);
      columnExpression13.ColumnName = "ADISOYADI";
      table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression13.Table = table4;
      column13.Expression = (ExpressionBase) columnExpression13;
      selectQuery3.Columns.Add((ColumnBase) column13);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "Mudur";
      queryParameter3.Name = "talepID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MUDURID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table4;
      table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table5.Name = "TBLTALEP";
      join2.Parent = table5;
      selectQuery3.Relations.Add(join2);
      selectQuery3.Tables.Add(table5);
      selectQuery3.Tables.Add(table4);
      columnExpression14.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression14.Table = table6;
      column14.Expression = (ExpressionBase) columnExpression14;
      selectQuery4.Columns.Add((ColumnBase) column14);
      selectQuery4.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery4.GroupFilterString = "";
      selectQuery4.Name = "DaireBaskani";
      queryParameter4.Name = "talepID";
      queryParameter4.Type = typeof (Expression);
      queryParameter4.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery4.Parameters.Add(queryParameter4);
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "DAIREBSKID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table6;
      table7.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table7.Name = "TBLTALEP";
      join3.Parent = table7;
      selectQuery4.Relations.Add(join3);
      selectQuery4.Tables.Add(table7);
      selectQuery4.Tables.Add(table6);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[4]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3,
        (SqlQuery) selectQuery4
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.HeightF = 16f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 98f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrSubreport1
      });
      this.Detail.HeightF = 25.00005f;
      this.Detail.Name = "Detail";
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 0.3334045f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("talepID", this.talepID));
      this.xrSubreport1.ReportSource = (XtraReport) new TeklifTeknikSartnameDuz();
      this.xrSubreport1.SizeF = new SizeF(650f, 23f);
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
      this.PageHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.PageHeader.HeightF = 40.83333f;
      this.PageHeader.Name = "PageHeader";
      this.xrLabel1.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(259.1666f, 7.833328f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(201.6667f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "İHALE ONAY BELGESİ";
      this.GroupHeader1.Controls.AddRange(new XRControl[29]
      {
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable1,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable7,
        (XRControl) this.xrTable8,
        (XRControl) this.xrTable9,
        (XRControl) this.xrTable10,
        (XRControl) this.xrTable11,
        (XRControl) this.xrTable12,
        (XRControl) this.xrTable13,
        (XRControl) this.xrTable14,
        (XRControl) this.xrTable15,
        (XRControl) this.xrTable16,
        (XRControl) this.xrTable17,
        (XRControl) this.xrTable18,
        (XRControl) this.xrTable19,
        (XRControl) this.xrTable20,
        (XRControl) this.xrTable21,
        (XRControl) this.xrTable22,
        (XRControl) this.xrTable23,
        (XRControl) this.xrTable24,
        (XRControl) this.xrTable25,
        (XRControl) this.xrTable26,
        (XRControl) this.xrTable27,
        (XRControl) this.xrTable28,
        (XRControl) this.xrTable29
      });
      this.GroupHeader1.HeightF = 710f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable5.LocationFloat = new PointFloat(10f, 68.33334f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(630f, 25f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell7
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell7.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "BAŞKANLIK MAKAMINA";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 1.0;
      this.xrTable2.LocationFloat = new PointFloat(144.1667f, 1.666667f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(495.8333f, 41.66667f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.Font = new Font("Arial", 11f);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI\r\nDestek Hizmetleri Dairesi Başkanlığı - Makine İkmal Şube Müdürlüğü";
      this.xrTableCell2.Weight = 1.0;
      this.xrTable3.LocationFloat = new PointFloat(10f, 43.33333f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(630f, 25f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell3,
        this.xrTableCell4,
        this.xrTableCell5
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell3.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell3.Font = new Font("Arial", 12f);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.Text = "BELGE TARİH VE SAYISI";
      this.xrTableCell3.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELGETARIH]")
      });
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.Weight = 0.56746026901971724;
      this.xrTableCell5.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELGESAYI]")
      });
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.Weight = 1.4325397309802828;
      this.xrTable1.LocationFloat = new PointFloat(10f, 1.666667f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(134.1667f, 41.66667f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell1.Font = new Font("Arial", 12f);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "İDARENİN ADI";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell1.Weight = 0.44230769424245;
      this.xrTable4.LocationFloat = new PointFloat(10f, 93.33338f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(630f, 25f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell6.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell6.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "İHALE İLE İLGİLİ BİLGİLER";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 1.0;
      this.xrTable6.LocationFloat = new PointFloat(10f, 143.3334f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(630f, 25f);
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell8,
        this.xrTableCell10
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell8.Font = new Font("Arial", 11f);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.Text = "İşin Türü ve Miktarı (Fiziki) Kapsamı";
      this.xrTableCell8.Weight = 3.2916665649414063;
      this.xrTableCell10.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISINADI]")
      });
      this.xrTableCell10.Font = new Font("Arial", 11f);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.Weight = 3.0083334350585935;
      this.xrTable7.LocationFloat = new PointFloat(10f, 118.3334f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(630f, 25f);
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell9,
        this.xrTableCell11
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell9.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell9.Font = new Font("Arial", 11f);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.Text = "İşin Adı";
      this.xrTableCell9.Weight = 3.2916665649414063;
      this.xrTableCell11.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell11.Font = new Font("Arial", 11f);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.Text = "Mal Alımı";
      this.xrTableCell11.Weight = 3.0083334350585935;
      this.xrTable8.LocationFloat = new PointFloat(10f, 168.3334f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(630f, 25f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell12,
        this.xrTableCell13
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell12.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell12.Font = new Font("Arial", 11f);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.Text = "Yapı Tekniği";
      this.xrTableCell12.Weight = 3.2916665649414063;
      this.xrTableCell13.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?yapiTeknigi")
      });
      this.xrTableCell13.Font = new Font("Arial", 11f);
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.StylePriority.UseFont = false;
      this.xrTableCell13.Weight = 3.0083334350585935;
      this.xrTable9.LocationFloat = new PointFloat(10f, 193.3334f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable9.SizeF = new SizeF(630f, 25f);
      this.xrTableRow9.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell14,
        this.xrTableCell15
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell14.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell14.Font = new Font("Arial", 11f);
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseFont = false;
      this.xrTableCell14.Text = "İşin Yapılacağı Yer";
      this.xrTableCell14.Weight = 3.2916665649414063;
      this.xrTableCell15.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISINYAPYERI]")
      });
      this.xrTableCell15.Font = new Font("Arial", 11f);
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.Weight = 3.0083334350585935;
      this.xrTable10.LocationFloat = new PointFloat(10f, 218.3333f);
      this.xrTable10.Name = "xrTable10";
      this.xrTable10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable10.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow10
      });
      this.xrTable10.SizeF = new SizeF(630f, 25f);
      this.xrTableRow10.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell16.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell16.Font = new Font("Arial", 11f);
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.Text = "Yaklaşık Maliyet";
      this.xrTableCell16.Weight = 3.2916665649414063;
      this.xrTableCell17.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[YAKLASIKMALIYET]")
      });
      this.xrTableCell17.Font = new Font("Arial", 11f);
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.Weight = 3.0083334350585935;
      this.xrTable11.LocationFloat = new PointFloat(10f, 243.3333f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow11
      });
      this.xrTable11.SizeF = new SizeF(630f, 25f);
      this.xrTableRow11.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell18,
        this.xrTableCell19
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell18.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell18.Font = new Font("Arial", 11f);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.Text = "Kullanılabilir Ödenek Tutarı";
      this.xrTableCell18.Weight = 3.2916665649414063;
      this.xrTableCell19.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KULLODENEKTUTAR]")
      });
      this.xrTableCell19.Font = new Font("Arial", 11f);
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBorders = false;
      this.xrTableCell19.StylePriority.UseFont = false;
      this.xrTableCell19.Weight = 3.0083334350585935;
      this.xrTable12.LocationFloat = new PointFloat(10f, 268.3333f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable12.SizeF = new SizeF(630f, 25f);
      this.xrTableRow12.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell20,
        this.xrTableCell21
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell20.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell20.Font = new Font("Arial", 11f);
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseBorders = false;
      this.xrTableCell20.StylePriority.UseFont = false;
      this.xrTableCell20.Text = "Yatırım Proje Numarası";
      this.xrTableCell20.Weight = 3.2916665649414063;
      this.xrTableCell21.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?yatirimProjeNo")
      });
      this.xrTableCell21.Font = new Font("Arial", 11f);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.Weight = 3.0083334350585935;
      this.xrTable13.LocationFloat = new PointFloat(10f, 293.3333f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable13.SizeF = new SizeF(630f, 25f);
      this.xrTableRow13.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell22,
        this.xrTableCell23
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell22.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell22.Font = new Font("Arial", 11f);
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.StylePriority.UseFont = false;
      this.xrTableCell22.Text = "Bütçe Tertibi (varsa)";
      this.xrTableCell22.Weight = 3.2916665649414063;
      this.xrTableCell23.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BUTCETERTIBI]")
      });
      this.xrTableCell23.Font = new Font("Arial", 11f);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.Weight = 3.0083334350585935;
      this.xrTable14.LocationFloat = new PointFloat(10f, 318.3333f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable14.SizeF = new SizeF(630f, 25f);
      this.xrTableRow14.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell24,
        this.xrTableCell25
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell24.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell24.Font = new Font("Arial", 11f);
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.StylePriority.UseFont = false;
      this.xrTableCell24.Text = "Avans Verilecekse Şartları";
      this.xrTableCell24.Weight = 3.2916665649414063;
      this.xrTableCell25.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell25.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?avans")
      });
      this.xrTableCell25.Font = new Font("Arial", 11f);
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.Weight = 3.0083334350585935;
      this.xrTable15.LocationFloat = new PointFloat(10f, 343.3333f);
      this.xrTable15.Name = "xrTable15";
      this.xrTable15.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable15.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow15
      });
      this.xrTable15.SizeF = new SizeF(630f, 25f);
      this.xrTableRow15.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell26,
        this.xrTableCell27
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell26.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell26.Font = new Font("Arial", 11f);
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.Text = "İhale Usulü (2)";
      this.xrTableCell26.Weight = 3.2916665649414063;
      this.xrTableCell27.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell27.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IHALEUSULU]")
      });
      this.xrTableCell27.Font = new Font("Arial", 11f);
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.StylePriority.UseBorders = false;
      this.xrTableCell27.StylePriority.UseFont = false;
      this.xrTableCell27.Weight = 3.0083334350585935;
      this.xrTable16.LocationFloat = new PointFloat(10f, 368.3333f);
      this.xrTable16.Name = "xrTable16";
      this.xrTable16.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable16.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow16
      });
      this.xrTable16.SizeF = new SizeF(630f, 25f);
      this.xrTableRow16.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell28,
        this.xrTableCell29
      });
      this.xrTableRow16.Name = "xrTableRow16";
      this.xrTableRow16.Weight = 1.0;
      this.xrTableCell28.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell28.Font = new Font("Arial", 11f);
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseBorders = false;
      this.xrTableCell28.StylePriority.UseFont = false;
      this.xrTableCell28.Text = "İlanın Şekli ve Adedi";
      this.xrTableCell28.Weight = 3.2916665649414063;
      this.xrTableCell29.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?ilanSekil")
      });
      this.xrTableCell29.Font = new Font("Arial", 11f);
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.StylePriority.UseBorders = false;
      this.xrTableCell29.StylePriority.UseFont = false;
      this.xrTableCell29.Weight = 3.0083334350585935;
      this.xrTable17.LocationFloat = new PointFloat(10f, 393.3333f);
      this.xrTable17.Name = "xrTable17";
      this.xrTable17.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable17.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow17
      });
      this.xrTable17.SizeF = new SizeF(630f, 25f);
      this.xrTableRow17.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell30,
        this.xrTableCell31
      });
      this.xrTableRow17.Name = "xrTableRow17";
      this.xrTableRow17.Weight = 1.0;
      this.xrTableCell30.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell30.Font = new Font("Arial", 11f);
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.StylePriority.UseBorders = false;
      this.xrTableCell30.StylePriority.UseFont = false;
      this.xrTableCell30.Text = "Döküman Satış Bedeli (3)";
      this.xrTableCell30.Weight = 3.2916665649414063;
      this.xrTableCell31.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell31.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?satisBedeli")
      });
      this.xrTableCell31.Font = new Font("Arial", 11f);
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.StylePriority.UseBorders = false;
      this.xrTableCell31.StylePriority.UseFont = false;
      this.xrTableCell31.Weight = 3.0083334350585935;
      this.xrTable18.LocationFloat = new PointFloat(10f, 418.3333f);
      this.xrTable18.Name = "xrTable18";
      this.xrTable18.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable18.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow18
      });
      this.xrTable18.SizeF = new SizeF(630f, 47.5f);
      this.xrTableRow18.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell32,
        this.xrTableCell33
      });
      this.xrTableRow18.Name = "xrTableRow18";
      this.xrTableRow18.Weight = 1.0;
      this.xrTableCell32.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell32.Font = new Font("Arial", 11f);
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.StylePriority.UseBorders = false;
      this.xrTableCell32.StylePriority.UseFont = false;
      this.xrTableCell32.Text = "Fiyat Farkı ve Ödenecekse Dayanağı \r\nBakanlar Kurulu Kararı";
      this.xrTableCell32.Weight = 3.2916665649414063;
      this.xrTableCell33.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell33.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?fiyatFarki")
      });
      this.xrTableCell33.Font = new Font("Arial", 11f);
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      this.xrTableCell33.StylePriority.UseBorders = false;
      this.xrTableCell33.StylePriority.UseFont = false;
      this.xrTableCell33.Weight = 3.0083334350585935;
      this.xrTable19.LocationFloat = new PointFloat(10f, 465.8333f);
      this.xrTable19.Name = "xrTable19";
      this.xrTable19.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable19.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow19
      });
      this.xrTable19.SizeF = new SizeF(630f, 25f);
      this.xrTableRow19.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell34,
        this.xrTableCell35
      });
      this.xrTableRow19.Name = "xrTableRow19";
      this.xrTableRow19.Weight = 1.0;
      this.xrTableCell34.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell34.Font = new Font("Arial", 11f);
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      this.xrTableCell34.StylePriority.UseBorders = false;
      this.xrTableCell34.StylePriority.UseFont = false;
      this.xrTableCell34.Text = "Teklif ve Sözleşme Türü";
      this.xrTableCell34.Weight = 3.2916665649414063;
      this.xrTableCell35.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell35.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TeklifTablo].[TEKLIFKONUSU]")
      });
      this.xrTableCell35.Font = new Font("Arial", 11f);
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.StylePriority.UseBorders = false;
      this.xrTableCell35.StylePriority.UseFont = false;
      this.xrTableCell35.Weight = 3.0083334350585935;
      this.xrTable20.LocationFloat = new PointFloat(10f, 490.8333f);
      this.xrTable20.Name = "xrTable20";
      this.xrTable20.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable20.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow20
      });
      this.xrTable20.SizeF = new SizeF(630f, 47.5f);
      this.xrTableRow20.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell36,
        this.xrTableCell37
      });
      this.xrTableRow20.Name = "xrTableRow20";
      this.xrTableRow20.Weight = 1.0;
      this.xrTableCell36.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell36.Font = new Font("Arial", 11f);
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      this.xrTableCell36.StylePriority.UseBorders = false;
      this.xrTableCell36.StylePriority.UseFont = false;
      this.xrTableCell36.Text = "İhale Usulü ve İhale İlanının Yılın Hangi Çeyreğinde Yayımlanacağı (1)";
      this.xrTableCell36.Weight = 3.2916665649414063;
      this.xrTableCell37.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell37.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IHALEUSULU]")
      });
      this.xrTableCell37.Font = new Font("Arial", 11f);
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.StylePriority.UseBorders = false;
      this.xrTableCell37.StylePriority.UseFont = false;
      this.xrTableCell37.Weight = 3.0083334350585935;
      this.xrTable21.LocationFloat = new PointFloat(10f, 538.3333f);
      this.xrTable21.Name = "xrTable21";
      this.xrTable21.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable21.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow21
      });
      this.xrTable21.SizeF = new SizeF(630f, 25f);
      this.xrTableRow21.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell38,
        this.xrTableCell39
      });
      this.xrTableRow21.Name = "xrTableRow21";
      this.xrTableRow21.Weight = 1.0;
      this.xrTableCell38.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell38.Font = new Font("Arial", 11f);
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.StylePriority.UseBorders = false;
      this.xrTableCell38.StylePriority.UseFont = false;
      this.xrTableCell38.Text = "İHALE İLE İLGİLİ DİĞER AÇIKLAMALAR (5)";
      this.xrTableCell38.Weight = 3.2916665649414063;
      this.xrTableCell39.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell39.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TeklifTablo].[BILGINOTU]")
      });
      this.xrTableCell39.Font = new Font("Arial", 11f);
      this.xrTableCell39.Multiline = true;
      this.xrTableCell39.Name = "xrTableCell39";
      this.xrTableCell39.StylePriority.UseBorders = false;
      this.xrTableCell39.StylePriority.UseFont = false;
      this.xrTableCell39.Weight = 3.0083334350585935;
      this.xrTable22.LocationFloat = new PointFloat(10f, 563.3333f);
      this.xrTable22.Name = "xrTable22";
      this.xrTable22.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable22.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow22
      });
      this.xrTable22.SizeF = new SizeF(630f, 25f);
      this.xrTableRow22.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell40
      });
      this.xrTableRow22.Name = "xrTableRow22";
      this.xrTableRow22.Weight = 1.0;
      this.xrTableCell40.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell40.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell40.Multiline = true;
      this.xrTableCell40.Name = "xrTableCell40";
      this.xrTableCell40.StylePriority.UseBorders = false;
      this.xrTableCell40.StylePriority.UseFont = false;
      this.xrTableCell40.StylePriority.UseTextAlignment = false;
      this.xrTableCell40.Text = "ONAY";
      this.xrTableCell40.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell40.Weight = 3.2916665649414063;
      this.xrTable23.LocationFloat = new PointFloat(10f, 588.3333f);
      this.xrTable23.Name = "xrTable23";
      this.xrTable23.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable23.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow23
      });
      this.xrTable23.SizeF = new SizeF(329.1667f, 76.66663f);
      this.xrTableRow23.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell41
      });
      this.xrTableRow23.Name = "xrTableRow23";
      this.xrTableRow23.Weight = 1.0;
      this.xrTableCell41.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell41.Font = new Font("Arial", 11f);
      this.xrTableCell41.Multiline = true;
      this.xrTableCell41.Name = "xrTableCell41";
      this.xrTableCell41.StylePriority.UseBorders = false;
      this.xrTableCell41.StylePriority.UseFont = false;
      this.xrTableCell41.StylePriority.UseTextAlignment = false;
      this.xrTableCell41.Text = "       Yukarıda belirtilen işin yaptırılması için ihaleye çıkılması hususunda onaylarınızı arzm ederim.";
      this.xrTableCell41.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell41.Weight = 3.2916665649414063;
      this.xrTable24.LocationFloat = new PointFloat(339.1667f, 635.8333f);
      this.xrTable24.Name = "xrTable24";
      this.xrTable24.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable24.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow24
      });
      this.xrTable24.SizeF = new SizeF(300.8333f, 29.16663f);
      this.xrTableRow24.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell42
      });
      this.xrTableRow24.Name = "xrTableRow24";
      this.xrTableRow24.Weight = 1.0;
      this.xrTableCell42.Borders = BorderSide.Right;
      this.xrTableCell42.Font = new Font("Arial", 11f);
      this.xrTableCell42.Multiline = true;
      this.xrTableCell42.Name = "xrTableCell42";
      this.xrTableCell42.StylePriority.UseBorders = false;
      this.xrTableCell42.StylePriority.UseFont = false;
      this.xrTableCell42.StylePriority.UseTextAlignment = false;
      this.xrTableCell42.Text = "Uygundur";
      this.xrTableCell42.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell42.Weight = 3.2916665649414063;
      this.xrTable25.LocationFloat = new PointFloat(339.1667f, 588.3333f);
      this.xrTable25.Name = "xrTable25";
      this.xrTable25.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable25.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow25
      });
      this.xrTable25.SizeF = new SizeF(300.8333f, 47.5f);
      this.xrTableRow25.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell43
      });
      this.xrTableRow25.Name = "xrTableRow25";
      this.xrTableRow25.Weight = 1.0;
      this.xrTableCell43.Borders = BorderSide.Right;
      this.xrTableCell43.Font = new Font("Arial", 11f);
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.StylePriority.UseBorders = false;
      this.xrTableCell43.StylePriority.UseFont = false;
      this.xrTableCell43.Weight = 3.2916665649414063;
      this.xrTable26.LocationFloat = new PointFloat(10f, 665f);
      this.xrTable26.Name = "xrTable26";
      this.xrTable26.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable26.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow26
      });
      this.xrTable26.SizeF = new SizeF(329.1667f, 22.5f);
      this.xrTableRow26.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell44
      });
      this.xrTableRow26.Name = "xrTableRow26";
      this.xrTableRow26.Weight = 1.0;
      this.xrTableCell44.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell44.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Mudur].[ADISOYADI]")
      });
      this.xrTableCell44.Font = new Font("Arial", 11f);
      this.xrTableCell44.Multiline = true;
      this.xrTableCell44.Name = "xrTableCell44";
      this.xrTableCell44.StylePriority.UseBorders = false;
      this.xrTableCell44.StylePriority.UseFont = false;
      this.xrTableCell44.StylePriority.UseTextAlignment = false;
      this.xrTableCell44.Text = "Eşref Ökten";
      this.xrTableCell44.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell44.Weight = 3.2916665649414063;
      this.xrTable27.LocationFloat = new PointFloat(10f, 687.5f);
      this.xrTable27.Name = "xrTable27";
      this.xrTable27.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable27.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow27
      });
      this.xrTable27.SizeF = new SizeF(329.1667f, 22.5f);
      this.xrTableRow27.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell45
      });
      this.xrTableRow27.Name = "xrTableRow27";
      this.xrTableRow27.Weight = 1.0;
      this.xrTableCell45.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell45.Font = new Font("Arial", 11f);
      this.xrTableCell45.Multiline = true;
      this.xrTableCell45.Name = "xrTableCell45";
      this.xrTableCell45.StylePriority.UseBorders = false;
      this.xrTableCell45.StylePriority.UseFont = false;
      this.xrTableCell45.StylePriority.UseTextAlignment = false;
      this.xrTableCell45.Text = "Şube Müdürü";
      this.xrTableCell45.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell45.Weight = 3.2916665649414063;
      this.xrTable28.LocationFloat = new PointFloat(339.1667f, 665f);
      this.xrTable28.Name = "xrTable28";
      this.xrTable28.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable28.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow28
      });
      this.xrTable28.SizeF = new SizeF(300.8333f, 22.5f);
      this.xrTableRow28.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell46
      });
      this.xrTableRow28.Name = "xrTableRow28";
      this.xrTableRow28.Weight = 1.0;
      this.xrTableCell46.Borders = BorderSide.Right;
      this.xrTableCell46.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DaireBaskani].[ADISOYADI]")
      });
      this.xrTableCell46.Font = new Font("Arial", 11f);
      this.xrTableCell46.Multiline = true;
      this.xrTableCell46.Name = "xrTableCell46";
      this.xrTableCell46.StylePriority.UseBorders = false;
      this.xrTableCell46.StylePriority.UseFont = false;
      this.xrTableCell46.StylePriority.UseTextAlignment = false;
      this.xrTableCell46.Text = "Mehmet Hicri Çubuk";
      this.xrTableCell46.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell46.Weight = 3.2916665649414063;
      this.xrTable29.LocationFloat = new PointFloat(339.1667f, 687.5f);
      this.xrTable29.Name = "xrTable29";
      this.xrTable29.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable29.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow29
      });
      this.xrTable29.SizeF = new SizeF(300.8333f, 22.5f);
      this.xrTableRow29.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell47
      });
      this.xrTableRow29.Name = "xrTableRow29";
      this.xrTableRow29.Weight = 1.0;
      this.xrTableCell47.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell47.Font = new Font("Arial", 11f);
      this.xrTableCell47.Multiline = true;
      this.xrTableCell47.Name = "xrTableCell47";
      this.xrTableCell47.StylePriority.UseBorders = false;
      this.xrTableCell47.StylePriority.UseFont = false;
      this.xrTableCell47.StylePriority.UseTextAlignment = false;
      this.xrTableCell47.Text = "Daire Başkanı";
      this.xrTableCell47.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell47.Weight = 3.2916665649414063;
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
      this.DataMember = "GenelTablo";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(70, 10, 16, 98);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
      });
      this.Version = "20.1";
      this.xrTable5.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable1.EndInit();
      this.xrTable4.EndInit();
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
      this.xrTable16.EndInit();
      this.xrTable17.EndInit();
      this.xrTable18.EndInit();
      this.xrTable19.EndInit();
      this.xrTable20.EndInit();
      this.xrTable21.EndInit();
      this.xrTable22.EndInit();
      this.xrTable23.EndInit();
      this.xrTable24.EndInit();
      this.xrTable25.EndInit();
      this.xrTable26.EndInit();
      this.xrTable27.EndInit();
      this.xrTable28.EndInit();
      this.xrTable29.EndInit();
      this.EndInit();
    }
  }
}
