// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.TalepTekArac1
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
  public class TalepTekArac1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel1;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel7;
    private XRTable xrTable2;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTable xrTable3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell5;
    private XRTable xrTable4;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable6;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell9;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel28;
    private XRLabel xrLabel15;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel19;
    private XRLabel xrLabel18;
    private XRSubreport xrSubreport1;
    private XRTable xrTable5;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell1;
    private Parameter talepID;

    public TalepTekArac1() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table3 = new Table();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table4 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table5 = new Table();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Table table6 = new Table();
      QueryParameter queryParameter1 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table7 = new Table();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Table table8 = new Table();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Table table9 = new Table();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Table table10 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join8 = new Join();
      RelationColumnInfo relationColumnInfo8 = new RelationColumnInfo();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Table table11 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join9 = new Join();
      RelationColumnInfo relationColumnInfo9 = new RelationColumnInfo();
      Table table12 = new Table();
      SelectQuery selectQuery4 = new SelectQuery();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Table table13 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      QueryParameter queryParameter4 = new QueryParameter();
      SelectQuery selectQuery5 = new SelectQuery();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table14 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      QueryParameter queryParameter5 = new QueryParameter();
      Join join10 = new Join();
      RelationColumnInfo relationColumnInfo10 = new RelationColumnInfo();
      Table table15 = new Table();
      Table table16 = new Table();
      Join join11 = new Join();
      RelationColumnInfo relationColumnInfo11 = new RelationColumnInfo();
      Table table17 = new Table();
      Join join12 = new Join();
      RelationColumnInfo relationColumnInfo12 = new RelationColumnInfo();
      SelectQuery selectQuery6 = new SelectQuery();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Table table18 = new Table();
      QueryParameter queryParameter6 = new QueryParameter();
      Join join13 = new Join();
      RelationColumnInfo relationColumnInfo13 = new RelationColumnInfo();
      Table table19 = new Table();
      SelectQuery selectQuery7 = new SelectQuery();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Table table20 = new Table();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Table table21 = new Table();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Table table22 = new Table();
      Column column25 = new Column();
      ColumnExpression columnExpression25 = new ColumnExpression();
      Column column26 = new Column();
      ColumnExpression columnExpression26 = new ColumnExpression();
      Table table23 = new Table();
      Column column27 = new Column();
      ColumnExpression columnExpression27 = new ColumnExpression();
      Column column28 = new Column();
      ColumnExpression columnExpression28 = new ColumnExpression();
      Column column29 = new Column();
      ColumnExpression columnExpression29 = new ColumnExpression();
      Column column30 = new Column();
      ColumnExpression columnExpression30 = new ColumnExpression();
      Column column31 = new Column();
      ColumnExpression columnExpression31 = new ColumnExpression();
      Column column32 = new Column();
      ColumnExpression columnExpression32 = new ColumnExpression();
      Column column33 = new Column();
      ColumnExpression columnExpression33 = new ColumnExpression();
      Table table24 = new Table();
      Column column34 = new Column();
      ColumnExpression columnExpression34 = new ColumnExpression();
      Column column35 = new Column();
      ColumnExpression columnExpression35 = new ColumnExpression();
      QueryParameter queryParameter7 = new QueryParameter();
      Join join14 = new Join();
      RelationColumnInfo relationColumnInfo14 = new RelationColumnInfo();
      Join join15 = new Join();
      RelationColumnInfo relationColumnInfo15 = new RelationColumnInfo();
      Join join16 = new Join();
      RelationColumnInfo relationColumnInfo16 = new RelationColumnInfo();
      Join join17 = new Join();
      RelationColumnInfo relationColumnInfo17 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression36 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepTekArac1));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel2 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel19 = new XRLabel();
      this.xrLabel18 = new XRLabel();
      this.xrLabel28 = new XRLabel();
      this.xrTable6 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel16 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrTable2 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrSubreport1 = new XRSubreport();
      this.talepID = new Parameter();
      this.xrTable5 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrLabel11 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrTable6.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable5.BeginInit();
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
      columnExpression5.ColumnName = "MIKTAR";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"243\" />";
      table2.Name = "TBLTALEPFISHRKT";
      columnExpression5.Table = table2;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "MALZEMEADI";
      table3.MetaSerializable = "<Meta X=\"510\" Y=\"130\" Width=\"125\" Height=\"683\" />";
      table3.Name = "TBLMALZEMELER";
      columnExpression6.Table = table3;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "BIRIMADI";
      table4.MetaSerializable = "<Meta X=\"650\" Y=\"130\" Width=\"125\" Height=\"263\" />";
      table4.Name = "TBLMALZBIRIM";
      columnExpression7.Table = table4;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "KOD";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "MALZACIKLAMA";
      columnExpression9.Table = table2;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "PLAKA";
      table5.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"1503\" />";
      table5.Name = "TBLARACLAR";
      columnExpression10.Table = table5;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "ARACACIKLAMA";
      columnExpression11.Table = table5;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"250\" Y=\"560\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression12.Table = table6;
      column12.Expression = (ExpressionBase) columnExpression12;
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
      selectQuery1.Columns.Add((ColumnBase) column11);
      selectQuery1.Columns.Add((ColumnBase) column12);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTALEP";
      queryParameter1.Name = "talepID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      relationColumnInfo1.NestedKeyColumn = "TALEPFISID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      table7.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"523\" />";
      table7.Name = "TBLTALEPFIS";
      join1.Parent = table7;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MALZEMEID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table2;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BIRIMID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "TALEPKAYITID";
      relationColumnInfo4.ParentKeyColumn = "ID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table7;
      join4.Parent = table1;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ISEMRIID";
      join5.KeyColumns.Add(relationColumnInfo5);
      table8.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"743\" />";
      table8.Name = "TBLISEMRI";
      join5.Nested = table8;
      join5.Parent = table7;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "ARACID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table5;
      join6.Parent = table8;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "MUDURID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table6;
      join7.Parent = table1;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Relations.Add(join4);
      selectQuery1.Relations.Add(join5);
      selectQuery1.Relations.Add(join6);
      selectQuery1.Relations.Add(join7);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table7);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table4);
      selectQuery1.Tables.Add(table8);
      selectQuery1.Tables.Add(table5);
      selectQuery1.Tables.Add(table6);
      columnExpression13.ColumnName = "ATOLYESEFID";
      table9.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table9.Name = "TBLTALEP";
      columnExpression13.Table = table9;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "ADISOYADI";
      table10.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table10.Name = "TBLPERSONEL";
      columnExpression14.Table = table10;
      column14.Expression = (ExpressionBase) columnExpression14;
      selectQuery2.Columns.Add((ColumnBase) column13);
      selectQuery2.Columns.Add((ColumnBase) column14);
      selectQuery2.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "AtolyeSefAdi";
      queryParameter2.Name = "talepID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "ATOLYESEFID";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table10;
      join8.Parent = table9;
      selectQuery2.Relations.Add(join8);
      selectQuery2.Tables.Add(table9);
      selectQuery2.Tables.Add(table10);
      columnExpression15.ColumnName = "ADISOYADI";
      table11.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table11.Name = "TBLPERSONEL";
      columnExpression15.Table = table11;
      column15.Expression = (ExpressionBase) columnExpression15;
      selectQuery3.Columns.Add((ColumnBase) column15);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "AmbarYetkili";
      queryParameter3.Name = "talepID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "DEPOYETKILIID";
      join9.KeyColumns.Add(relationColumnInfo9);
      join9.Nested = table11;
      table12.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table12.Name = "TBLTALEP";
      join9.Parent = table12;
      selectQuery3.Relations.Add(join9);
      selectQuery3.Tables.Add(table12);
      selectQuery3.Tables.Add(table11);
      columnExpression16.ColumnName = "SIRANO";
      table13.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
      table13.Name = "TBLTALEPTEKNIKSART";
      columnExpression16.Table = table13;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "ACIKLAMA";
      columnExpression17.Table = table13;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "TALEPID";
      columnExpression18.Table = table13;
      column18.Expression = (ExpressionBase) columnExpression18;
      selectQuery4.Columns.Add((ColumnBase) column16);
      selectQuery4.Columns.Add((ColumnBase) column17);
      selectQuery4.Columns.Add((ColumnBase) column18);
      selectQuery4.FilterString = "[TBLTALEPTEKNIKSART.TALEPID] = ?talepID";
      selectQuery4.GroupFilterString = "";
      selectQuery4.Name = "TeknikSartname";
      queryParameter4.Name = "talepID";
      queryParameter4.Type = typeof (Expression);
      queryParameter4.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery4.Parameters.Add(queryParameter4);
      selectQuery4.Tables.Add(table13);
      columnExpression19.ColumnName = "PLAKA";
      table14.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"1503\" />";
      table14.Name = "TBLARACLAR";
      columnExpression19.Table = table14;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "ARACACIKLAMA";
      columnExpression20.Table = table14;
      column20.Expression = (ExpressionBase) columnExpression20;
      selectQuery5.Columns.Add((ColumnBase) column19);
      selectQuery5.Columns.Add((ColumnBase) column20);
      selectQuery5.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery5.GroupFilterString = "";
      selectQuery5.Name = "Arac";
      queryParameter5.Name = "talepID";
      queryParameter5.Type = typeof (Expression);
      queryParameter5.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery5.Parameters.Add(queryParameter5);
      relationColumnInfo10.NestedKeyColumn = "TALEPKAYITID";
      relationColumnInfo10.ParentKeyColumn = "ID";
      join10.KeyColumns.Add(relationColumnInfo10);
      table15.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"523\" />";
      table15.Name = "TBLTALEPFIS";
      join10.Nested = table15;
      table16.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table16.Name = "TBLTALEP";
      join10.Parent = table16;
      relationColumnInfo11.NestedKeyColumn = "ID";
      relationColumnInfo11.ParentKeyColumn = "ISEMRIID";
      join11.KeyColumns.Add(relationColumnInfo11);
      table17.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"743\" />";
      table17.Name = "TBLISEMRI";
      join11.Nested = table17;
      join11.Parent = table15;
      relationColumnInfo12.NestedKeyColumn = "ID";
      relationColumnInfo12.ParentKeyColumn = "ARACID";
      join12.KeyColumns.Add(relationColumnInfo12);
      join12.Nested = table14;
      join12.Parent = table17;
      selectQuery5.Relations.Add(join10);
      selectQuery5.Relations.Add(join11);
      selectQuery5.Relations.Add(join12);
      selectQuery5.Tables.Add(table16);
      selectQuery5.Tables.Add(table15);
      selectQuery5.Tables.Add(table17);
      selectQuery5.Tables.Add(table14);
      columnExpression21.ColumnName = "ADISOYADI";
      table18.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table18.Name = "TBLPERSONEL";
      columnExpression21.Table = table18;
      column21.Expression = (ExpressionBase) columnExpression21;
      selectQuery6.Columns.Add((ColumnBase) column21);
      selectQuery6.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery6.GroupFilterString = "";
      selectQuery6.Name = "Mudur";
      queryParameter6.Name = "talepID";
      queryParameter6.Type = typeof (Expression);
      queryParameter6.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery6.Parameters.Add(queryParameter6);
      relationColumnInfo13.NestedKeyColumn = "ID";
      relationColumnInfo13.ParentKeyColumn = "MUDURID";
      join13.KeyColumns.Add(relationColumnInfo13);
      join13.Nested = table18;
      table19.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table19.Name = "TBLTALEP";
      join13.Parent = table19;
      selectQuery6.Relations.Add(join13);
      selectQuery6.Tables.Add(table19);
      selectQuery6.Tables.Add(table18);
      columnExpression22.ColumnName = "MALZEMEADI";
      table20.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table20.Name = "TBLMALZEMELER";
      columnExpression22.Table = table20;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "MALZACIKLAMA";
      table21.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table21.Name = "TBLTALEPHRKT";
      columnExpression23.Table = table21;
      column23.Expression = (ExpressionBase) columnExpression23;
      columnExpression24.ColumnName = "PLAKA";
      table22.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table22.Name = "TBLARACLAR";
      columnExpression24.Table = table22;
      column24.Expression = (ExpressionBase) columnExpression24;
      columnExpression25.ColumnName = "ARACACIKLAMA";
      columnExpression25.Table = table22;
      column25.Expression = (ExpressionBase) columnExpression25;
      columnExpression26.ColumnName = "KOD";
      table23.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table23.Name = "TBLTALEP";
      columnExpression26.Table = table23;
      column26.Expression = (ExpressionBase) columnExpression26;
      columnExpression27.ColumnName = "BELGESAYI";
      columnExpression27.Table = table23;
      column27.Expression = (ExpressionBase) columnExpression27;
      columnExpression28.ColumnName = "BELGEKONU";
      columnExpression28.Table = table23;
      column28.Expression = (ExpressionBase) columnExpression28;
      columnExpression29.ColumnName = "BELGETARIH";
      columnExpression29.Table = table23;
      column29.Expression = (ExpressionBase) columnExpression29;
      columnExpression30.ColumnName = "SAAT";
      columnExpression30.Table = table23;
      column30.Expression = (ExpressionBase) columnExpression30;
      columnExpression31.ColumnName = "TARIH";
      columnExpression31.Table = table23;
      column31.Expression = (ExpressionBase) columnExpression31;
      columnExpression32.ColumnName = "ISINADI";
      columnExpression32.Table = table23;
      column32.Expression = (ExpressionBase) columnExpression32;
      columnExpression33.ColumnName = "BIRIMADI";
      table24.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table24.Name = "TBLMALZBIRIM";
      columnExpression33.Table = table24;
      column33.Expression = (ExpressionBase) columnExpression33;
      columnExpression34.ColumnName = "MIKTAR";
      columnExpression34.Table = table21;
      column34.Expression = (ExpressionBase) columnExpression34;
      columnExpression35.ColumnName = "ID";
      columnExpression35.Table = table21;
      column35.Expression = (ExpressionBase) columnExpression35;
      selectQuery7.Columns.Add((ColumnBase) column22);
      selectQuery7.Columns.Add((ColumnBase) column23);
      selectQuery7.Columns.Add((ColumnBase) column24);
      selectQuery7.Columns.Add((ColumnBase) column25);
      selectQuery7.Columns.Add((ColumnBase) column26);
      selectQuery7.Columns.Add((ColumnBase) column27);
      selectQuery7.Columns.Add((ColumnBase) column28);
      selectQuery7.Columns.Add((ColumnBase) column29);
      selectQuery7.Columns.Add((ColumnBase) column30);
      selectQuery7.Columns.Add((ColumnBase) column31);
      selectQuery7.Columns.Add((ColumnBase) column32);
      selectQuery7.Columns.Add((ColumnBase) column33);
      selectQuery7.Columns.Add((ColumnBase) column34);
      selectQuery7.Columns.Add((ColumnBase) column35);
      selectQuery7.FilterString = "[TBLTALEPHRKT.TALEPID] = ?talepID";
      selectQuery7.GroupFilterString = "";
      selectQuery7.Name = "TBLTALEPHRKT";
      queryParameter7.Name = "talepID";
      queryParameter7.Type = typeof (Expression);
      queryParameter7.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery7.Parameters.Add(queryParameter7);
      relationColumnInfo14.NestedKeyColumn = "ID";
      relationColumnInfo14.ParentKeyColumn = "MALZEMEID";
      join14.KeyColumns.Add(relationColumnInfo14);
      join14.Nested = table20;
      join14.Parent = table21;
      relationColumnInfo15.NestedKeyColumn = "ID";
      relationColumnInfo15.ParentKeyColumn = "BIRIMID";
      join15.KeyColumns.Add(relationColumnInfo15);
      join15.Nested = table24;
      join15.Parent = table21;
      relationColumnInfo16.NestedKeyColumn = "ID";
      relationColumnInfo16.ParentKeyColumn = "ARACID";
      join16.KeyColumns.Add(relationColumnInfo16);
      join16.Nested = table22;
      join16.Parent = table21;
      join16.Type = JoinType.LeftOuter;
      relationColumnInfo17.NestedKeyColumn = "ID";
      relationColumnInfo17.ParentKeyColumn = "TALEPID";
      join17.KeyColumns.Add(relationColumnInfo17);
      join17.Nested = table23;
      join17.Parent = table21;
      selectQuery7.Relations.Add(join14);
      selectQuery7.Relations.Add(join15);
      selectQuery7.Relations.Add(join16);
      selectQuery7.Relations.Add(join17);
      columnExpression36.ColumnName = "ID";
      columnExpression36.Table = table21;
      sorting.Expression = (ExpressionBase) columnExpression36;
      selectQuery7.Sorting.Add(sorting);
      selectQuery7.Tables.Add(table21);
      selectQuery7.Tables.Add(table20);
      selectQuery7.Tables.Add(table22);
      selectQuery7.Tables.Add(table24);
      selectQuery7.Tables.Add(table23);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[7]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3,
        (SqlQuery) selectQuery4,
        (SqlQuery) selectQuery5,
        (SqlQuery) selectQuery6,
        (SqlQuery) selectQuery7
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Controls.AddRange(new XRControl[9]
      {
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel1
      });
      this.TopMargin.HeightF = 152f;
      this.TopMargin.Name = "TopMargin";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(20.83333f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(336.4583f, 10.00005f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(133.3333f, 61.20837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(133.3333f, 38.20836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(590.4584f, 10.00005f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(220.8333f, 84.20837f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(287.5f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "MAL - HİZMET TALEP LİSTESİ";
      this.BottomMargin.HeightF = 39.95755f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel19,
        (XRControl) this.xrLabel18,
        (XRControl) this.xrLabel28,
        (XRControl) this.xrTable6
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.xrLabel19.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrLabel19.LocationFloat = new PointFloat(526.5154f, 0.0f);
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.SizeF = new SizeF(104.9429f, 25f);
      this.xrLabel19.StylePriority.UseBorders = false;
      this.xrLabel18.Borders = BorderSide.Top | BorderSide.Bottom;
      this.xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]+' - '+[MALZACIKLAMA]")
      });
      this.xrLabel18.LocationFloat = new PointFloat(91.45851f, 0.0f);
      this.xrLabel18.Name = "xrLabel18";
      this.xrLabel18.SizeF = new SizeF(435.0569f, 25f);
      this.xrLabel18.StylePriority.UseBorders = false;
      this.xrLabel28.Borders = BorderSide.All;
      this.xrLabel28.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrLabel28.LocationFloat = new PointFloat(11.45836f, 0.0f);
      this.xrLabel28.Multiline = true;
      this.xrLabel28.Name = "xrLabel28";
      this.xrLabel28.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel28.SizeF = new SizeF(80.00013f, 25f);
      this.xrLabel28.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel28.Summary = xrSummary;
      this.xrLabel28.Text = "xrLabel28";
      this.xrTable6.LocationFloat = new PointFloat(631.4583f, 0.0f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable6.SizeF = new SizeF(104.9431f, 25f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 0.5;
      this.xrTableCell9.Borders = BorderSide.All;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrTableCell9.Font = new Font("Arial", 10f);
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.StylePriority.UsePadding = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "6";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 0.76975763028666211;
      this.GroupHeader1.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable4
      });
      this.GroupHeader1.HeightF = 29.96325f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.xrLabel16.LocationFloat = new PointFloat(153.1252f, 128.6299f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(432.0114f, 23f);
      this.xrLabel16.Text = "xrLabel16";
      this.xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrLabel15.LocationFloat = new PointFloat(11.45849f, 129f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(141.6667f, 23f);
      this.xrLabel15.Text = "xrLabel15";
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel7.LocationFloat = new PointFloat(585.1365f, 129f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(134.8636f, 23f);
      this.xrLabel7.Text = "xrLabel7";
      this.xrTable2.LocationFloat = new PointFloat(11.45849f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable2.SizeF = new SizeF(515.057f, 29.96325f);
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
      this.xrTableCell25.Weight = 0.31943058349642284;
      this.xrTableCell26.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell26.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "İmalatın Cinsi";
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 1.7371280088428838;
      this.xrTable3.LocationFloat = new PointFloat(526.5153f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable3.SizeF = new SizeF(104.943f, 29.96325f);
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
      this.xrTable4.LocationFloat = new PointFloat(631.4583f, 0.0f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable4.SizeF = new SizeF(104.9432f, 29.96325f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell4
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 0.5;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell4.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Miktar";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 0.76975763028666211;
      this.GroupFooter1.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.xrSubreport1,
        (XRControl) this.xrTable5,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel17,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel10
      });
      this.GroupFooter1.HeightF = 113.8338f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrSubreport1.LocationFloat = new PointFloat(11.45837f, 0.0f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("talepID", this.talepID));
      this.xrSubreport1.ReportSource = (XtraReport) new TeklifTeknikSartnameDuz();
      this.xrSubreport1.SizeF = new SizeF(728f, 23f);
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
      this.xrTable5.LocationFloat = new PointFloat(569.0001f, 56.16656f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable5.SizeF = new SizeF(108.3333f, 25f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 11.5;
      this.xrTableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Mudur].[ADISOYADI]")
      });
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "xrTableCell1";
      this.xrTableCell1.Weight = 2.0 / 15.0;
      this.xrLabel11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(68.54181f, 45.99988f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(182.5f, 23.00001f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "Ambarda mevcudu yoktur.";
      this.xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AmbarYetkili].[ADISOYADI]")
      });
      this.xrLabel12.LocationFloat = new PointFloat(68.54181f, 69.00002f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(182.4999f, 22.99998f);
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "xrLabel12";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[AtolyeSefAdi].[ADISOYADI]")
      });
      this.xrLabel17.LocationFloat = new PointFloat(299.1667f, 68.99983f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(149.9999f, 23.00003f);
      this.xrLabel17.StylePriority.UseTextAlignment = false;
      this.xrLabel17.Text = "xrLabel17";
      this.xrLabel17.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(68.54181f, 22.99999f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "Ambar Yetkilisi";
      this.xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel9.LocationFloat = new PointFloat(315f, 22.99999f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.Text = "Atölye Şefi";
      this.xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(569f, 22.99999f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.Text = "Şube Müdürü";
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
      this.DataMember = "TBLTALEPHRKT";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(60, 42, 152, 40);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
      });
      this.Version = "20.1";
      this.xrTable6.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.xrTable5.EndInit();
      this.EndInit();
    }
  }
}
