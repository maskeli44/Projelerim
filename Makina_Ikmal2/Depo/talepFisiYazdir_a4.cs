// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.talepFisiYazdir_a4
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
  public class talepFisiYazdir_a4 : XtraReport
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
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private Parameter id;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel7;
    private XRLabel xrLabel14;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private PageFooterBand PageFooter;

    public talepFisiYazdir_a4() => this.InitializeComponent();

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
      CustomSqlQuery customSqlQuery1 = new CustomSqlQuery();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (talepFisiYazdir_a4));
      SelectQuery selectQuery2 = new SelectQuery();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Table table9 = new Table();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Table table10 = new Table();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Table table11 = new Table();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Table table12 = new Table();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Column column25 = new Column();
      ColumnExpression columnExpression25 = new ColumnExpression();
      Column column26 = new Column();
      ColumnExpression columnExpression26 = new ColumnExpression();
      Table table13 = new Table();
      Column column27 = new Column();
      ColumnExpression columnExpression27 = new ColumnExpression();
      Column column28 = new Column();
      ColumnExpression columnExpression28 = new ColumnExpression();
      Column column29 = new Column();
      ColumnExpression columnExpression29 = new ColumnExpression();
      Table table14 = new Table();
      Column column30 = new Column();
      ColumnExpression columnExpression30 = new ColumnExpression();
      Table table15 = new Table();
      Column column31 = new Column();
      ColumnExpression columnExpression31 = new ColumnExpression();
      Table table16 = new Table();
      Column column32 = new Column();
      ColumnExpression columnExpression32 = new ColumnExpression();
      Table table17 = new Table();
      Column column33 = new Column();
      ColumnExpression columnExpression33 = new ColumnExpression();
      Table table18 = new Table();
      Join join8 = new Join();
      RelationColumnInfo relationColumnInfo8 = new RelationColumnInfo();
      Join join9 = new Join();
      RelationColumnInfo relationColumnInfo9 = new RelationColumnInfo();
      Join join10 = new Join();
      RelationColumnInfo relationColumnInfo10 = new RelationColumnInfo();
      Join join11 = new Join();
      RelationColumnInfo relationColumnInfo11 = new RelationColumnInfo();
      Join join12 = new Join();
      RelationColumnInfo relationColumnInfo12 = new RelationColumnInfo();
      Join join13 = new Join();
      RelationColumnInfo relationColumnInfo13 = new RelationColumnInfo();
      Join join14 = new Join();
      RelationColumnInfo relationColumnInfo14 = new RelationColumnInfo();
      Join join15 = new Join();
      RelationColumnInfo relationColumnInfo15 = new RelationColumnInfo();
      Join join16 = new Join();
      RelationColumnInfo relationColumnInfo16 = new RelationColumnInfo();
      CustomSqlQuery customSqlQuery2 = new CustomSqlQuery();
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
      this.xrLabel2 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.id = new Parameter();
      this.PageFooter = new PageFooterBand();
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
      selectQuery1.Columns.Add((ColumnBase) column13);
      selectQuery1.Columns.Add((ColumnBase) column14);
      selectQuery1.Columns.Add((ColumnBase) column15);
      selectQuery1.Columns.Add((ColumnBase) column16);
      selectQuery1.Columns.Add((ColumnBase) column17);
      selectQuery1.FilterString = "[TBLDEPOFIS.ISLEMTIPIID] = '2'";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLDEPOFISHRKT_1";
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
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Relations.Add(join4);
      selectQuery1.Relations.Add(join5);
      selectQuery1.Relations.Add(join6);
      selectQuery1.Relations.Add(join7);
      selectQuery1.Tables.Add(table5);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table4);
      selectQuery1.Tables.Add(table6);
      selectQuery1.Tables.Add(table7);
      selectQuery1.Tables.Add(table8);
      customSqlQuery1.Name = "Query";
      customSqlQuery1.Sql = componentResourceManager.GetString("customSqlQuery1.Sql");
      columnExpression18.ColumnName = "PLAKA";
      table9.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table9.Name = "TBLARACLAR";
      columnExpression18.Table = table9;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "ARACACIKLAMA";
      columnExpression19.Table = table9;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "BIRIMADI";
      table10.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table10.Name = "TBLMALZBIRIM";
      columnExpression20.Table = table10;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "MALZEMEADI";
      table11.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table11.Name = "TBLMALZEMELER";
      columnExpression21.Table = table11;
      column21.Expression = (ExpressionBase) columnExpression21;
      columnExpression22.ColumnName = "MALZACIKLAMA";
      table12.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"245\" />";
      table12.Name = "TBLTALEPFISHRKT";
      columnExpression22.Table = table12;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "MIKTAR";
      columnExpression23.Table = table12;
      column23.Expression = (ExpressionBase) columnExpression23;
      columnExpression24.ColumnName = "FIYAT";
      columnExpression24.Table = table12;
      column24.Expression = (ExpressionBase) columnExpression24;
      columnExpression25.ColumnName = "TUTAR";
      columnExpression25.Table = table12;
      column25.Expression = (ExpressionBase) columnExpression25;
      columnExpression26.ColumnName = "TARIH";
      table13.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"525\" />";
      table13.Name = "TBLTALEPFIS";
      columnExpression26.Table = table13;
      column26.Expression = (ExpressionBase) columnExpression26;
      columnExpression27.ColumnName = "SAAT";
      columnExpression27.Table = table13;
      column27.Expression = (ExpressionBase) columnExpression27;
      columnExpression28.ColumnName = "KOD";
      columnExpression28.Table = table13;
      column28.Expression = (ExpressionBase) columnExpression28;
      column29.Alias = "TBLISEMRI_KOD";
      columnExpression29.ColumnName = "KOD";
      table14.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table14.Name = "TBLISEMRI";
      columnExpression29.Table = table14;
      column29.Expression = (ExpressionBase) columnExpression29;
      column30.Alias = "talepedenusta";
      columnExpression30.ColumnName = "ADISOYADI";
      table15.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table15.Name = "TBLPERSONEL";
      columnExpression30.Table = table15;
      column30.Expression = (ExpressionBase) columnExpression30;
      column31.Alias = "atolye";
      columnExpression31.ColumnName = "ADISOYADI";
      table16.Alias = "TBLPERSONEL_1";
      table16.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table16.Name = "TBLPERSONEL";
      columnExpression31.Table = table16;
      column31.Expression = (ExpressionBase) columnExpression31;
      column32.Alias = "depoyet";
      columnExpression32.ColumnName = "ADISOYADI";
      table17.Alias = "TBLPERSONEL_2";
      table17.MetaSerializable = "<Meta X=\"1270\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table17.Name = "TBLPERSONEL";
      columnExpression32.Table = table17;
      column32.Expression = (ExpressionBase) columnExpression32;
      column33.Alias = "mudur";
      columnExpression33.ColumnName = "ADISOYADI";
      table18.Alias = "TBLPERSONEL_3";
      table18.MetaSerializable = "<Meta X=\"1425\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table18.Name = "TBLPERSONEL";
      columnExpression33.Table = table18;
      column33.Expression = (ExpressionBase) columnExpression33;
      selectQuery2.Columns.Add((ColumnBase) column18);
      selectQuery2.Columns.Add((ColumnBase) column19);
      selectQuery2.Columns.Add((ColumnBase) column20);
      selectQuery2.Columns.Add((ColumnBase) column21);
      selectQuery2.Columns.Add((ColumnBase) column22);
      selectQuery2.Columns.Add((ColumnBase) column23);
      selectQuery2.Columns.Add((ColumnBase) column24);
      selectQuery2.Columns.Add((ColumnBase) column25);
      selectQuery2.Columns.Add((ColumnBase) column26);
      selectQuery2.Columns.Add((ColumnBase) column27);
      selectQuery2.Columns.Add((ColumnBase) column28);
      selectQuery2.Columns.Add((ColumnBase) column29);
      selectQuery2.Columns.Add((ColumnBase) column30);
      selectQuery2.Columns.Add((ColumnBase) column31);
      selectQuery2.Columns.Add((ColumnBase) column32);
      selectQuery2.Columns.Add((ColumnBase) column33);
      selectQuery2.Name = "TBLTALEPFISHRKT";
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "TALEPFISID";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table13;
      join8.Parent = table12;
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "ISEMRIID";
      join9.KeyColumns.Add(relationColumnInfo9);
      join9.Nested = table14;
      join9.Parent = table13;
      relationColumnInfo10.NestedKeyColumn = "ID";
      relationColumnInfo10.ParentKeyColumn = "ARACID";
      join10.KeyColumns.Add(relationColumnInfo10);
      join10.Nested = table9;
      join10.Parent = table14;
      relationColumnInfo11.NestedKeyColumn = "ID";
      relationColumnInfo11.ParentKeyColumn = "MALZEMEID";
      join11.KeyColumns.Add(relationColumnInfo11);
      join11.Nested = table11;
      join11.Parent = table12;
      relationColumnInfo12.NestedKeyColumn = "ID";
      relationColumnInfo12.ParentKeyColumn = "BIRIMID";
      join12.KeyColumns.Add(relationColumnInfo12);
      join12.Nested = table10;
      join12.Parent = table11;
      relationColumnInfo13.NestedKeyColumn = "ID";
      relationColumnInfo13.ParentKeyColumn = "TALEPEDENUSTAID";
      join13.KeyColumns.Add(relationColumnInfo13);
      join13.Nested = table15;
      join13.Parent = table13;
      relationColumnInfo14.NestedKeyColumn = "ID";
      relationColumnInfo14.ParentKeyColumn = "ATOLYESEFID";
      join14.KeyColumns.Add(relationColumnInfo14);
      join14.Nested = table16;
      join14.Parent = table13;
      relationColumnInfo15.NestedKeyColumn = "ID";
      relationColumnInfo15.ParentKeyColumn = "DEPOYETKILIID";
      join15.KeyColumns.Add(relationColumnInfo15);
      join15.Nested = table17;
      join15.Parent = table13;
      relationColumnInfo16.NestedKeyColumn = "ID";
      relationColumnInfo16.ParentKeyColumn = "MUDURID";
      join16.KeyColumns.Add(relationColumnInfo16);
      join16.Nested = table18;
      join16.Parent = table13;
      selectQuery2.Relations.Add(join8);
      selectQuery2.Relations.Add(join9);
      selectQuery2.Relations.Add(join10);
      selectQuery2.Relations.Add(join11);
      selectQuery2.Relations.Add(join12);
      selectQuery2.Relations.Add(join13);
      selectQuery2.Relations.Add(join14);
      selectQuery2.Relations.Add(join15);
      selectQuery2.Relations.Add(join16);
      selectQuery2.Tables.Add(table12);
      selectQuery2.Tables.Add(table13);
      selectQuery2.Tables.Add(table14);
      selectQuery2.Tables.Add(table9);
      selectQuery2.Tables.Add(table11);
      selectQuery2.Tables.Add(table10);
      selectQuery2.Tables.Add(table15);
      selectQuery2.Tables.Add(table16);
      selectQuery2.Tables.Add(table17);
      selectQuery2.Tables.Add(table18);
      customSqlQuery2.Name = "Query_1";
      customSqlQuery2.Sql = componentResourceManager.GetString("customSqlQuery2.Sql");
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[4]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) customSqlQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) customSqlQuery2
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
      this.BottomMargin.HeightF = 12f;
      this.BottomMargin.Name = "BottomMargin";
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
      this.xrLabel7.Text = "Talep Fişi";
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
      this.xrLabel1.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrLabel1.Borders = BorderSide.All;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(123.0355f, 1.999969f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(208.9538f, 24.99995f);
      this.xrLabel1.StylePriority.UseBorderColor = false;
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseFont = false;
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
      this.tableCell1.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell1.Borders = BorderSide.All;
      this.tableCell1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell1.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.StylePriority.UseBackColor = false;
      this.tableCell1.StylePriority.UseBorderColor = false;
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.StylePriority.UseFont = false;
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
      this.tableCell5.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell5.Borders = BorderSide.All;
      this.tableCell5.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell5.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "GroupCaption1";
      this.tableCell5.StylePriority.UseBackColor = false;
      this.tableCell5.StylePriority.UseBorderColor = false;
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.StylePriority.UseFont = false;
      this.tableCell5.StylePriority.UseForeColor = false;
      this.tableCell5.Text = "SAAT";
      this.tableCell5.Weight = 0.16171814621763719;
      this.tableCell6.BackColor = Color.White;
      this.tableCell6.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell6.Borders = BorderSide.All;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAAT]")
      });
      this.tableCell6.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell6.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "GroupData1";
      this.tableCell6.StylePriority.UseBackColor = false;
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseFont = false;
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
      this.tableCell7.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell7.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "GroupCaption1";
      this.tableCell7.StylePriority.UseBackColor = false;
      this.tableCell7.StylePriority.UseFont = false;
      this.tableCell7.StylePriority.UseForeColor = false;
      this.tableCell7.Text = "TARIH";
      this.tableCell7.Weight = 0.09438173939241494;
      this.tableCell8.BackColor = Color.White;
      this.tableCell8.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell8.Borders = BorderSide.All;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.tableCell8.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell8.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "GroupData1";
      this.tableCell8.StylePriority.UseBackColor = false;
      this.tableCell8.StylePriority.UseBorderColor = false;
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.StylePriority.UseFont = false;
      this.tableCell8.StylePriority.UseForeColor = false;
      this.tableCell8.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell8.Weight = 0.34290272564379659;
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
      this.tableCell9.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell9.Borders = BorderSide.All;
      this.tableCell9.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "GroupCaption1";
      this.tableCell9.StylePriority.UseBorderColor = false;
      this.tableCell9.StylePriority.UseBorders = false;
      this.tableCell9.StylePriority.UseFont = false;
      this.tableCell9.Text = "ARACACIKLAMA";
      this.tableCell9.Weight = 0.26998566737660362;
      this.tableCell10.BackColor = Color.White;
      this.tableCell10.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell10.Borders = BorderSide.All;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell10.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "GroupData1";
      this.tableCell10.StylePriority.UseBackColor = false;
      this.tableCell10.StylePriority.UseBorderColor = false;
      this.tableCell10.StylePriority.UseBorders = false;
      this.tableCell10.StylePriority.UseForeColor = false;
      this.tableCell10.Weight = 1.0011466580759527;
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
      this.table2.SizeF = new SizeF(405.833f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell3,
        this.tableCell4
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.tableCell3.BackColor = Color.White;
      this.tableCell3.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell3.Borders = BorderSide.All;
      this.tableCell3.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell3.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "GroupCaption1";
      this.tableCell3.StylePriority.UseBackColor = false;
      this.tableCell3.StylePriority.UseBorderColor = false;
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.StylePriority.UseFont = false;
      this.tableCell3.StylePriority.UseForeColor = false;
      this.tableCell3.Text = "TBLISEMRI KOD";
      this.tableCell3.Weight = 0.23313568933992757;
      this.tableCell4.BackColor = Color.White;
      this.tableCell4.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell4.Borders = BorderSide.All;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLISEMRI_KOD]")
      });
      this.tableCell4.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell4.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "GroupData1";
      this.tableCell4.StylePriority.UseBackColor = false;
      this.tableCell4.StylePriority.UseBorderColor = false;
      this.tableCell4.StylePriority.UseBorders = false;
      this.tableCell4.StylePriority.UseFont = false;
      this.tableCell4.StylePriority.UseForeColor = false;
      this.tableCell4.Weight = 0.41801021167669672;
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
      this.tableCell11.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell11.Borders = BorderSide.All;
      this.tableCell11.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell11.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "GroupCaption1";
      this.tableCell11.StylePriority.UseBackColor = false;
      this.tableCell11.StylePriority.UseBorderColor = false;
      this.tableCell11.StylePriority.UseBorders = false;
      this.tableCell11.StylePriority.UseFont = false;
      this.tableCell11.StylePriority.UseForeColor = false;
      this.tableCell11.Text = "PLAKA";
      this.tableCell11.Weight = 0.14040584172673376;
      this.tableCell12.BackColor = Color.White;
      this.tableCell12.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell12.Borders = BorderSide.All;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "  [PLAKA]- [[BOLUMADI]]")
      });
      this.tableCell12.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tableCell12.ForeColor = SystemColors.ActiveCaptionText;
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "GroupData1";
      this.tableCell12.StylePriority.UseBackColor = false;
      this.tableCell12.StylePriority.UseBorderColor = false;
      this.tableCell12.StylePriority.UseBorders = false;
      this.tableCell12.StylePriority.UseFont = false;
      this.tableCell12.StylePriority.UseForeColor = false;
      this.tableCell12.Weight = 0.48346454326168364;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table8
      });
      this.Detail.HeightF = 27.33337f;
      this.Detail.Name = "Detail";
      this.table8.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table8.Name = "table8";
      this.table8.OddStyleName = "DetailData3_Odd";
      this.table8.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow8
      });
      this.table8.SizeF = new SizeF(796.9998f, 25f);
      this.tableRow8.Cells.AddRange(new XRTableCell[8]
      {
        this.xrTableCell2,
        this.tableCell20,
        this.tableCell21,
        this.tableCell22,
        this.tableCell23,
        this.tableCell24,
        this.xrTableCell1,
        this.tableCell25
      });
      this.tableRow8.Name = "tableRow8";
      this.tableRow8.Weight = 11.5;
      this.xrTableCell2.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.StylePriority.UseBorderColor = false;
      this.xrTableCell2.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Group;
      this.xrTableCell2.Summary = xrSummary;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 0.0868074653480313;
      this.tableCell20.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell20.Borders = BorderSide.All;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "DetailData1";
      this.tableCell20.StylePriority.UseBorderColor = false;
      this.tableCell20.StylePriority.UseBorders = false;
      this.tableCell20.Weight = 0.26359186601332829;
      this.tableCell21.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell21.Borders = BorderSide.All;
      this.tableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZACIKLAMA]")
      });
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "DetailData1";
      this.tableCell21.StylePriority.UseBorderColor = false;
      this.tableCell21.StylePriority.UseBorders = false;
      this.tableCell21.Weight = 0.3791751976026449;
      this.tableCell22.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell22.Borders = BorderSide.All;
      this.tableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KayıtTip]")
      });
      this.tableCell22.Name = "tableCell22";
      this.tableCell22.StyleName = "DetailData1";
      this.tableCell22.StylePriority.UseBorderColor = false;
      this.tableCell22.StylePriority.UseBorders = false;
      this.tableCell22.Weight = 0.13924598272995603;
      this.tableCell23.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell23.Borders = BorderSide.All;
      this.tableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailData1";
      this.tableCell23.StylePriority.UseBorderColor = false;
      this.tableCell23.StylePriority.UseBorders = false;
      this.tableCell23.Weight = 0.10856126899886792;
      this.tableCell24.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell24.Borders = BorderSide.All;
      this.tableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell24.Name = "tableCell24";
      this.tableCell24.StyleName = "DetailData1";
      this.tableCell24.StylePriority.UseBorderColor = false;
      this.tableCell24.StylePriority.UseBorders = false;
      this.tableCell24.TextFormatString = "{0:#.00}";
      this.tableCell24.Weight = 0.0874160317199088;
      this.xrTableCell1.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailData1";
      this.xrTableCell1.StylePriority.UseBorderColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Weight = 0.10964694746816067;
      this.tableCell25.BorderColor = Color.FromArgb(64, 64, 64);
      this.tableCell25.Borders = BorderSide.All;
      this.tableCell25.Name = "tableCell25";
      this.tableCell25.StyleName = "DetailData1";
      this.tableCell25.StylePriority.UseBorderColor = false;
      this.tableCell25.StylePriority.UseBorders = false;
      this.tableCell25.Weight = 0.14422025478579967;
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
      this.xrTable1.SizeF = new SizeF(796.9998f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[8]
      {
        this.xrTableCell3,
        this.xrTableCell4,
        this.xrTableCell6,
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell12,
        this.xrTableCell9,
        this.xrTableCell10
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell3.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell3.Borders = BorderSide.All;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorderColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.Text = "S.No";
      this.xrTableCell3.Weight = 0.65829798986801091;
      this.xrTableCell4.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell4.Borders = BorderSide.All;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorderColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.Text = "Malzeme Adı";
      this.xrTableCell4.Weight = 1.9989292924695832;
      this.xrTableCell6.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell6.Borders = BorderSide.All;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorderColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.Text = "Açıklama";
      this.xrTableCell6.Weight = 2.8754467324953552;
      this.xrTableCell7.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell7.Borders = BorderSide.All;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorderColor = false;
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.Text = "Kayıt Tipi";
      this.xrTableCell7.Weight = 1.0559629594809459;
      this.xrTableCell8.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell8.Borders = BorderSide.All;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorderColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.Text = "Birim";
      this.xrTableCell8.Weight = 0.82326622586133613;
      this.xrTableCell12.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell12.Borders = BorderSide.All;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorderColor = false;
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.Text = "Miktar";
      this.xrTableCell12.Weight = 0.66291227384936846;
      this.xrTableCell9.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell9.Borders = BorderSide.All;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorderColor = false;
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.Text = "Fiyat";
      this.xrTableCell9.Weight = 0.83149876999413763;
      this.xrTableCell10.BorderColor = Color.FromArgb(64, 64, 64);
      this.xrTableCell10.Borders = BorderSide.All;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorderColor = false;
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.Text = "Tutar";
      this.xrTableCell10.Weight = 1.0936842254747394;
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[mudur]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(590.7286f, 67.00002f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(177.6048f, 23f);
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel14.LocationFloat = new PointFloat(24.28099f, 15.66671f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(145f, 23f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Ambar Yetkilisi";
      this.xrLabel14.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel12.LocationFloat = new PointFloat(5.552451f, 45.66671f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(184.9734f, 22.99991f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "Ambarda Mevcudu Yoktur";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[depoyet]")
      });
      this.xrLabel13.LocationFloat = new PointFloat(5.552451f, 68.66659f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(173.8987f, 22.99994f);
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "xrLabel2";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(211.781f, 45.66671f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(145f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "Talep Eden Usta";
      this.xrLabel10.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[talepedenusta]")
      });
      this.xrLabel11.LocationFloat = new PointFloat(194.7191f, 68.66659f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(173.8987f, 22.99994f);
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "xrLabel2";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(393.2122f, 45.66671f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(145f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "Atölye Şefi";
      this.xrLabel8.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[atolye]")
      });
      this.xrLabel9.LocationFloat = new PointFloat(374.9966f, 68.66659f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(179.6898f, 23f);
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "xrLabel2";
      this.xrLabel9.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(606.1667f, 43.99994f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(145f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Şube Müdür";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.PageFooter.Controls.AddRange(new XRControl[9]
      {
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2
      });
      this.PageFooter.HeightF = 101.8333f;
      this.PageFooter.Name = "PageFooter";
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
        (Band) this.PageFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "Query_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPFISID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.Margins = new Margins(18, 71, 91, 12);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4;
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
