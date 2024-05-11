// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.Raporlar.AnaGrubaGore
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Otomasyon.Raporlar
{
  public class AnaGrubaGore : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel3;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell9;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell8;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell5;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell10;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell11;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell7;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell6;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell18;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell19;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell20;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell21;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell12;
    private Parameter id;
    private Parameter tarih1;
    private Parameter tarih2;
    private XRLabel xrLabel1;

    public AnaGrubaGore() => this.InitializeComponent();

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
      Table table3 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table4 = new Table();
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
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table5 = new Table();
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
      Table table6 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Table table7 = new Table();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table8 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AnaGrubaGore));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable11 = new XRTable();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTable12 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTable13 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell20 = new XRTableCell();
      this.xrLabel1 = new XRLabel();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable15 = new XRTable();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell21 = new XRTableCell();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTable9 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable10 = new XRTable();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.id = new Parameter();
      this.tarih1 = new Parameter();
      this.tarih2 = new Parameter();
      this.xrTable11.BeginInit();
      this.xrTable12.BeginInit();
      this.xrTable13.BeginInit();
      this.xrTable14.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable15.BeginInit();
      this.xrTable8.BeginInit();
      this.xrTable9.BeginInit();
      this.xrTable10.BeginInit();
      this.xrTable7.BeginInit();
      this.xrTable6.BeginInit();
      this.xrTable5.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "UNVAN";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLPERSUNVAN";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "TARIHSAAT";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"205\" />";
      table4.Name = "TBLARACMESTKP";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "MESAIICI";
      columnExpression5.Table = table4;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "MESAIDISI";
      columnExpression6.Table = table4;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "TOPLAMKM";
      columnExpression7.Table = table4;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "CALISMASURESI";
      columnExpression8.Table = table4;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "TAHSPLKTARIH";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BELDBIRIMID";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.Columns.Add((ColumnBase) column5);
      selectQuery1.Columns.Add((ColumnBase) column6);
      selectQuery1.Columns.Add((ColumnBase) column7);
      selectQuery1.Columns.Add((ColumnBase) column8);
      selectQuery1.Columns.Add((ColumnBase) column9);
      selectQuery1.Columns.Add((ColumnBase) column10);
      selectQuery1.FilterString = "";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLARACLAR_1";
      queryParameter.Name = "id";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?id", typeof (int));
      selectQuery1.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "TAHSISEDILENID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "UNVANID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table2;
      relationColumnInfo3.NestedKeyColumn = "PLAKA";
      relationColumnInfo3.ParentKeyColumn = "PLAKA";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table4);
      columnExpression11.ColumnName = "PLAKA";
      table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"205\" />";
      table5.Name = "TBLARACMESTKP";
      columnExpression11.Table = table5;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "TARIHSAAT";
      columnExpression12.Table = table5;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "MESAIICI";
      columnExpression13.Table = table5;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "MESAIDISI";
      columnExpression14.Table = table5;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "TOPLAMKM";
      columnExpression15.Table = table5;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "BELDBIRIMID";
      table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table6.Name = "TBLARACLAR";
      columnExpression16.Table = table6;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "ADISOYADI";
      table7.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table7.Name = "TBLPERSONEL";
      columnExpression17.Table = table7;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "CEPTELEFON";
      columnExpression18.Table = table7;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "BELDBIRIMADI";
      table8.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table8.Name = "TBLBELDBIRIMLER";
      columnExpression19.Table = table8;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "CALISMASURESI";
      columnExpression20.Table = table5;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "TAKIPVARYOKID";
      columnExpression21.Table = table6;
      column21.Expression = (ExpressionBase) columnExpression21;
      selectQuery2.Columns.Add((ColumnBase) column11);
      selectQuery2.Columns.Add((ColumnBase) column12);
      selectQuery2.Columns.Add((ColumnBase) column13);
      selectQuery2.Columns.Add((ColumnBase) column14);
      selectQuery2.Columns.Add((ColumnBase) column15);
      selectQuery2.Columns.Add((ColumnBase) column16);
      selectQuery2.Columns.Add((ColumnBase) column17);
      selectQuery2.Columns.Add((ColumnBase) column18);
      selectQuery2.Columns.Add((ColumnBase) column19);
      selectQuery2.Columns.Add((ColumnBase) column20);
      selectQuery2.Columns.Add((ColumnBase) column21);
      selectQuery2.FilterString = "[TBLARACLAR.TAKIPVARYOKID] = 1";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "TBLARACMESTKP";
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "ARACKULPERSID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table7;
      join4.Parent = table6;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "BELDBIRIMID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table8;
      join5.Parent = table6;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "PLAKA";
      relationColumnInfo6.ParentKeyColumn = "PLAKA";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table6;
      join6.Parent = table5;
      join6.Type = JoinType.LeftOuter;
      selectQuery2.Relations.Add(join4);
      selectQuery2.Relations.Add(join5);
      selectQuery2.Relations.Add(join6);
      selectQuery2.Tables.Add(table5);
      selectQuery2.Tables.Add(table6);
      selectQuery2.Tables.Add(table8);
      selectQuery2.Tables.Add(table7);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[2]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 0.0f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable11,
        (XRControl) this.xrTable12,
        (XRControl) this.xrTable13,
        (XRControl) this.xrTable14
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.xrTable11.Borders = BorderSide.All;
      this.xrTable11.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow11
      });
      this.xrTable11.SizeF = new SizeF(416.6667f, 25f);
      this.xrTable11.StylePriority.UseBorders = false;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell15,
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell15.Summary = xrSummary;
      this.xrTableCell15.Text = "S.NO";
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 0.49166667938232417;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP].[PLAKA]")
      });
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "Plaka";
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell16.Weight = 0.95833324432373057;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP].[ADISOYADI]")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Tahsis Edilen";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell17.Weight = 2.7166666412353511;
      this.xrTable12.Borders = BorderSide.All;
      this.xrTable12.LocationFloat = new PointFloat(416.6667f, 0.0f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable12.SizeF = new SizeF(245.8333f, 25f);
      this.xrTable12.StylePriority.UseBorders = false;
      this.xrTableRow12.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell13,
        this.xrTableCell14,
        this.xrTableCell18
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CEPTELEFON]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "Ünvanı";
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 0.9666661621288406;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP].[MESAIICI]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "Mesai İçi";
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell14.Weight = 0.76666773069346128;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP].[MESAIDISI]")
      });
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.Text = "Mesai Dışı";
      this.xrTableCell18.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell18.Weight = 0.72500012118710977;
      this.xrTable13.Borders = BorderSide.All;
      this.xrTable13.LocationFloat = new PointFloat(662.5f, 0.0f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable13.SizeF = new SizeF(80.83325f, 25f);
      this.xrTable13.StylePriority.UseBorders = false;
      this.xrTableRow13.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell19
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLAMKM]")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseTextAlignment = false;
      this.xrTableCell19.Text = "Toplam KM";
      this.xrTableCell19.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell19.Weight = 1.0;
      this.xrTable14.Borders = BorderSide.All;
      this.xrTable14.LocationFloat = new PointFloat(743.3333f, 0.0f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable14.SizeF = new SizeF(71.66669f, 25f);
      this.xrTable14.StylePriority.UseBorders = false;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell20
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell20.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell20.TextFormatString = "{0:HH:mm}";
      this.xrTableCell20.Weight = 1.0;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "Substring([CALISMASURESI], 9,6 ) ")
      });
      this.xrLabel1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(71.66669f, 23f);
      this.PageHeader.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrTable1
      });
      this.PageHeader.HeightF = 79.16666f;
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(578.1249f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 75.83334f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 75.83334f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(99.99998f, 10f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(464.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "[TARIHSAAT!d.MM.yyyy] -GÜNLÜK MESAFE RAPORU";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrTable1.LocationFloat = new PointFloat(100f, 50.83333f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(478.1249f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.Tomato;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP].[BELDBIRIMADI]")
      });
      this.xrTableCell1.Font = new Font("Arial", 14f);
      this.xrTableCell1.ForeColor = Color.GhostWhite;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseForeColor = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "1.Kamyon";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 1.0;
      this.GroupHeader1.Controls.AddRange(new XRControl[10]
      {
        (XRControl) this.xrTable15,
        (XRControl) this.xrTable8,
        (XRControl) this.xrTable9,
        (XRControl) this.xrTable10,
        (XRControl) this.xrTable7,
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable2
      });
      this.GroupHeader1.HeightF = 65f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable15.Borders = BorderSide.All;
      this.xrTable15.LocationFloat = new PointFloat(662.5f, 46.66667f);
      this.xrTable15.Name = "xrTable15";
      this.xrTable15.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable15.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow15
      });
      this.xrTable15.SizeF = new SizeF(80.83331f, 18.33332f);
      this.xrTable15.StylePriority.UseBorders = false;
      this.xrTableRow15.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell21
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TAHSPLKTARIH]")
      });
      this.xrTableCell21.Font = new Font("Arial", 8f);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.StylePriority.UseTextAlignment = false;
      this.xrTableCell21.Text = "Toplam KM";
      this.xrTableCell21.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell21.Weight = 1.0;
      this.xrTable8.Borders = BorderSide.All;
      this.xrTable8.LocationFloat = new PointFloat(662.5f, 28.33333f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(80.83331f, 18.33333f);
      this.xrTable8.StylePriority.UseBorders = false;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell10
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "06:00-18:00\r\n")
      });
      this.xrTableCell10.Font = new Font("Arial", 8f);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "Toplam KM";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell10.Weight = 1.0;
      this.xrTable9.Borders = BorderSide.All;
      this.xrTable9.LocationFloat = new PointFloat(513.3333f, 28.33333f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable9.SizeF = new SizeF(76.66675f, 36.66666f);
      this.xrTable9.StylePriority.UseBorders = false;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell11
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIHSAAT]")
      });
      this.xrTableCell11.Font = new Font("Arial", 8f);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "Mesai İçi";
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell11.Weight = 1.0;
      this.xrTable10.Borders = BorderSide.All;
      this.xrTable10.LocationFloat = new PointFloat(590f, 28.33333f);
      this.xrTable10.Name = "xrTable10";
      this.xrTable10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable10.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow10
      });
      this.xrTable10.SizeF = new SizeF(72.5f, 36.66666f);
      this.xrTable10.StylePriority.UseBorders = false;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell12
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIHSAAT]")
      });
      this.xrTableCell12.Font = new Font("Arial", 8f);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "Mesai Dışı";
      this.xrTableCell12.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell12.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell12.Weight = 1.0;
      this.xrTable7.Borders = BorderSide.All;
      this.xrTable7.LocationFloat = new PointFloat(590f, 0.0f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(72.5f, 28.33333f);
      this.xrTable7.StylePriority.UseBorders = false;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell7
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Mesai Dışı";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 1.0;
      this.xrTable6.Borders = BorderSide.All;
      this.xrTable6.LocationFloat = new PointFloat(513.3333f, 0.0f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(76.66675f, 28.33333f);
      this.xrTable6.StylePriority.UseBorders = false;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Mesai İçi";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 1.0;
      this.xrTable5.Borders = BorderSide.All;
      this.xrTable5.LocationFloat = new PointFloat(743.3333f, 0.0f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(71.66669f, 65f);
      this.xrTable5.StylePriority.UseBorders = false;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "Çalışma Saati";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 1.0;
      this.xrTable4.Borders = BorderSide.All;
      this.xrTable4.LocationFloat = new PointFloat(662.5f, 0.0f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(80.83331f, 28.33333f);
      this.xrTable4.StylePriority.UseBorders = false;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell8
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Toplam KM";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 1.0;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.LocationFloat = new PointFloat(416.6667f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(96.6666f, 65f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell5
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Telefon";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.73333343505859383;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(416.6667f, 65f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell2,
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "S.NO";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.49166667938232417;
      this.xrTableCell3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Plaka";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 0.95833324432373057;
      this.xrTableCell4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Tahsis Edilen";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 2.7166666412353511;
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.tarih1.Description = "Parameter1";
      this.tarih1.Name = "tarih1";
      this.tarih1.Type = typeof (DateTime);
      this.tarih1.ValueInfo = "2022-01-12";
      this.tarih2.Description = "Parameter1";
      this.tarih2.Name = "tarih2";
      this.tarih2.Type = typeof (DateTime);
      this.tarih2.ValueInfo = "2022-01-12";
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
      this.DataMember = "TBLARACMESTKP";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[BELDBIRIMID] = ?id And [TARIHSAAT] >= ?tarih1 And [TARIHSAAT] <= ?tarih2";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(20, 15, 100, 0);
      this.Parameters.AddRange(new Parameter[3]
      {
        this.id,
        this.tarih1,
        this.tarih2
      });
      this.Version = "20.1";
      this.xrTable11.EndInit();
      this.xrTable12.EndInit();
      this.xrTable13.EndInit();
      this.xrTable14.EndInit();
      this.xrTable1.EndInit();
      this.xrTable15.EndInit();
      this.xrTable8.EndInit();
      this.xrTable9.EndInit();
      this.xrTable10.EndInit();
      this.xrTable7.EndInit();
      this.xrTable6.EndInit();
      this.xrTable5.EndInit();
      this.xrTable4.EndInit();
      this.xrTable3.EndInit();
      this.xrTable2.EndInit();
      this.EndInit();
    }
  }
}
