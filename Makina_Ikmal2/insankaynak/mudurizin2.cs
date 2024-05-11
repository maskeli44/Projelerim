// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.mudurizin2
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
using Makina_Ikmal.ModelYeni;
using Makina_Ikmal.ModelYeni.izinRaporTableAdapters;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.insankaynak
{
  public class mudurizin2 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private Parameter id;
    private izinRapor izinRapor1;
    private SqlDataSource sqlDataSource2;
    private XRPageInfo pageInfo1;
    private XRLabel xrLabel11;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel14;
    private XRLabel xrLabel8;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel7;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel15;
    private XRLabel xrLabel16;
    private XRLabel xrLabel17;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell39;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell25;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell40;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell45;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell51;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell60;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell46;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell48;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell69;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell44;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell66;

    public mudurizin2() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table3 = new Table();
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
      Table table4 = new Table();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Table table5 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Table table6 = new Table();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Table table7 = new Table();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table8 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (mudurizin2));
      SelectQuery selectQuery2 = new SelectQuery();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Table table9 = new Table();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Table table10 = new Table();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Column column25 = new Column();
      ColumnExpression columnExpression25 = new ColumnExpression();
      Column column26 = new Column();
      ColumnExpression columnExpression26 = new ColumnExpression();
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
      Table table11 = new Table();
      Column column33 = new Column();
      ColumnExpression columnExpression33 = new ColumnExpression();
      Table table12 = new Table();
      Column column34 = new Column();
      ColumnExpression columnExpression34 = new ColumnExpression();
      Table table13 = new Table();
      Column column35 = new Column();
      ColumnExpression columnExpression35 = new ColumnExpression();
      Table table14 = new Table();
      Column column36 = new Column();
      ColumnExpression columnExpression36 = new ColumnExpression();
      Table table15 = new Table();
      Column column37 = new Column();
      ColumnExpression columnExpression37 = new ColumnExpression();
      Table table16 = new Table();
      Column column38 = new Column();
      ColumnExpression columnExpression38 = new ColumnExpression();
      Table table17 = new Table();
      Column column39 = new Column();
      ColumnExpression columnExpression39 = new ColumnExpression();
      Column column40 = new Column();
      ColumnExpression columnExpression40 = new ColumnExpression();
      Column column41 = new Column();
      ColumnExpression columnExpression41 = new ColumnExpression();
      Table table18 = new Table();
      Column column42 = new Column();
      ColumnExpression columnExpression42 = new ColumnExpression();
      Column column43 = new Column();
      ColumnExpression columnExpression43 = new ColumnExpression();
      Table table19 = new Table();
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
      Join join17 = new Join();
      RelationColumnInfo relationColumnInfo17 = new RelationColumnInfo();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.pageInfo1 = new XRPageInfo();
      this.xrLabel11 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableRow33 = new XRTableRow();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableCell39 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell34 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell31 = new XRTableCell();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell37 = new XRTableCell();
      this.xrTableCell38 = new XRTableCell();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableRow16 = new XRTableRow();
      this.xrTableCell42 = new XRTableCell();
      this.xrTableCell43 = new XRTableCell();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell27 = new XRTableCell();
      this.xrTableCell40 = new XRTableCell();
      this.xrTableRow17 = new XRTableRow();
      this.xrTableCell45 = new XRTableCell();
      this.xrTableRow19 = new XRTableRow();
      this.xrTableCell51 = new XRTableCell();
      this.xrTableRow30 = new XRTableRow();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableRow29 = new XRTableRow();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableRow22 = new XRTableRow();
      this.xrTableCell60 = new XRTableCell();
      this.xrTableRow20 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableRow28 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow31 = new XRTableRow();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableRow23 = new XRTableRow();
      this.xrTableCell46 = new XRTableCell();
      this.xrTableRow24 = new XRTableRow();
      this.xrTableCell48 = new XRTableCell();
      this.xrTableRow27 = new XRTableRow();
      this.xrTableCell69 = new XRTableCell();
      this.xrTableRow21 = new XRTableRow();
      this.xrTableCell44 = new XRTableCell();
      this.xrTableRow26 = new XRTableRow();
      this.xrTableCell66 = new XRTableCell();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.id = new Parameter();
      this.izinRapor1 = new izinRapor();
      this.sqlDataSource2 = new SqlDataSource(this.components);
      this.xrTable1.BeginInit();
      this.izinRapor1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ADISOYADI";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table1.Name = "TBLPERSONEL";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "TCKIMLIKNO";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "SICILNO";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"103\" />";
      table2.Name = "TBLPERSONELISTIHDAMDURUM";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "IZINTURU";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"603\" />";
      table3.Name = "TBLPERSONELIZIN";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "IZINYILLARI";
      columnExpression6.Table = table3;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "IZINSURESI";
      columnExpression7.Table = table3;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "BASLANGICTARIHI";
      columnExpression8.Table = table3;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BITISTARIHI";
      columnExpression9.Table = table3;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "IZINGUNSAY";
      columnExpression10.Table = table3;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "GOREVEBASTARIH";
      columnExpression11.Table = table3;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "IZINDEBULADRES";
      columnExpression12.Table = table3;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ONAYTARIH";
      columnExpression13.Table = table3;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "IZINDURUM";
      columnExpression14.Table = table3;
      column14.Expression = (ExpressionBase) columnExpression14;
      column15.Alias = "subeadi";
      columnExpression15.ColumnName = "ADISOYADI";
      table4.Alias = "TBLPERSONEL_1";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression15.Table = table4;
      column15.Expression = (ExpressionBase) columnExpression15;
      column16.Alias = "dairebaskan";
      columnExpression16.ColumnName = "ADISOYADI";
      table5.Alias = "TBLPERSONEL_2";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression16.Table = table5;
      column16.Expression = (ExpressionBase) columnExpression16;
      column17.Alias = "insankaynaklari";
      columnExpression17.ColumnName = "ADISOYADI";
      table6.Alias = "TBLPERSONEL_3";
      table6.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression17.Table = table6;
      column17.Expression = (ExpressionBase) columnExpression17;
      column18.Alias = "genelsek";
      columnExpression18.ColumnName = "ADISOYADI";
      table7.Alias = "TBLPERSONEL_4";
      table7.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table7.Name = "TBLPERSONEL";
      columnExpression18.Table = table7;
      column18.Expression = (ExpressionBase) columnExpression18;
      column19.Alias = "muduryerine";
      columnExpression19.ColumnName = "ADISOYADI";
      table8.Alias = "TBLPERSONEL_5";
      table8.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"903\" />";
      table8.Name = "TBLPERSONEL";
      columnExpression19.Table = table8;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "ID";
      columnExpression20.Table = table3;
      column20.Expression = (ExpressionBase) columnExpression20;
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
      selectQuery1.Columns.Add((ColumnBase) column18);
      selectQuery1.Columns.Add((ColumnBase) column19);
      selectQuery1.Columns.Add((ColumnBase) column20);
      selectQuery1.Name = "TBLPERSONELIZIN_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "PERSID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table1;
      join1.Parent = table3;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "PERSISTIHDAMIID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MUDURYERINE";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table8;
      join3.Parent = table3;
      join3.Type = JoinType.LeftOuter;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "GENELSEKYRDID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table7;
      join4.Parent = table3;
      join4.Type = JoinType.LeftOuter;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "INSANDAIREBSKID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table6;
      join5.Parent = table3;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "DAIREBSKID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table5;
      join6.Parent = table3;
      join6.Type = JoinType.LeftOuter;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "SBMUDURID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table4;
      join7.Parent = table3;
      join7.Type = JoinType.LeftOuter;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Relations.Add(join4);
      selectQuery1.Relations.Add(join5);
      selectQuery1.Relations.Add(join6);
      selectQuery1.Relations.Add(join7);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table4);
      selectQuery1.Tables.Add(table5);
      selectQuery1.Tables.Add(table6);
      selectQuery1.Tables.Add(table7);
      selectQuery1.Tables.Add(table8);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery1
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(75, 75, 75);
      this.Title.Name = "Title";
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
      this.TopMargin.Controls.AddRange(new XRControl[6]
      {
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 113f;
      this.TopMargin.Name = "TopMargin";
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(100f, 86.99999f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(431f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = " Personel İzin Formu";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 10f);
      this.xrLabel3.LocationFloat = new PointFloat(100f, 63.99999f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(440f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(110.0417f, 41f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(420.9583f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel1.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(100f, 10f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(431f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "T.C.";
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(539.9999f, 10f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 10f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.HeightF = 30.23321f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[15]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel17,
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 926.7979f;
      this.Detail.Name = "Detail";
      this.pageInfo1.LocationFloat = new PointFloat(2.380447f, 899.4645f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(301.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.xrLabel11.Borders = BorderSide.None;
      this.xrLabel11.LocationFloat = new PointFloat(539.9999f, 889.4645f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(100f, 23f);
      this.xrLabel11.StylePriority.UseBorders = false;
      this.xrLabel11.Text = "ONAY";
      this.xrLabel5.Borders = BorderSide.None;
      this.xrLabel5.LocationFloat = new PointFloat(443.1656f, 592.7524f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(176.8333f, 23f);
      this.xrLabel5.StylePriority.UseBorders = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "..................................";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel6.Borders = BorderSide.None;
      this.xrLabel6.LocationFloat = new PointFloat(443.1656f, 614.4874f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(176.8333f, 23f);
      this.xrLabel6.StylePriority.UseBorders = false;
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "Şef";
      this.xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel14.Borders = BorderSide.None;
      this.xrLabel14.LocationFloat = new PointFloat(158.0471f, 759.1086f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(145.8333f, 23f);
      this.xrLabel14.StylePriority.UseBorders = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "...../...../20...";
      this.xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel8.Borders = BorderSide.None;
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[OLUR]")
      });
      this.xrLabel8.LocationFloat = new PointFloat(158.0471f, 736.1086f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(145.8333f, 23f);
      this.xrLabel8.StylePriority.UseBorders = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "xrLabel7";
      this.xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel10.Borders = BorderSide.None;
      this.xrLabel10.LocationFloat = new PointFloat(428.3322f, 743.7797f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(191.6667f, 23f);
      this.xrLabel10.StylePriority.UseBorders = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "Daire Başkanı";
      this.xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel9.Borders = BorderSide.None;
      this.xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[dairebaskan]")
      });
      this.xrLabel9.LocationFloat = new PointFloat(428.3322f, 723.3748f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(191.6667f, 23f);
      this.xrLabel9.StylePriority.UseBorders = false;
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "xrLabel7";
      this.xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel7.Borders = BorderSide.None;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IZINSURESI]+' ' +[IZINTURU] +' izne ayrılması ve anılan tarihlerde yerine '+ [muduryerine]+' ' +'ın Vekaleten görevlendirilmesini' +'  \n\n'+'\n\t\n\t'+'Olurlarınıza arz ederim'")
      });
      this.xrLabel7.LocationFloat = new PointFloat(10f, 705.4373f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(619.9989f, 40.93738f);
      this.xrLabel7.StylePriority.UseBorders = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "[IZINSURESI]  [IZINTURU] izne ayrılması ve anılan tarihlerde yerine ";
      this.xrLabel7.TextAlignment = TextAlignment.TopLeft;
      this.xrLabel12.Borders = BorderSide.None;
      this.xrLabel12.LocationFloat = new PointFloat(11.70166f, 682.171f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(138.5417f, 21.70251f);
      this.xrLabel12.StylePriority.UseBorders = false;
      this.xrLabel12.Text = "Adı geçen personelin";
      this.xrLabel13.Borders = BorderSide.None;
      this.xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BASLANGICTARIHI]")
      });
      this.xrLabel13.LocationFloat = new PointFloat(150.2434f, 682.7498f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(86.45834f, 21.70251f);
      this.xrLabel13.StylePriority.UseBorders = false;
      this.xrLabel13.Text = "xrLabel13";
      this.xrLabel13.TextFormatString = "{0:d.MM.yyyy}";
      this.xrLabel15.Borders = BorderSide.None;
      this.xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BITISTARIHI]")
      });
      this.xrLabel15.LocationFloat = new PointFloat(273.3684f, 682.171f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(74.47046f, 21.70251f);
      this.xrLabel15.StylePriority.UseBorders = false;
      this.xrLabel15.Text = "xrLabel13";
      this.xrLabel15.TextFormatString = "{0:d.MM.yyyy}";
      this.xrLabel16.Borders = BorderSide.None;
      this.xrLabel16.LocationFloat = new PointFloat(361.1721f, 682.7498f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(274.8278f, 759f / 32f);
      this.xrLabel16.StylePriority.UseBorders = false;
      this.xrLabel16.Text = "tarihleri arasında [IZINYILLARI]";
      this.xrLabel17.Borders = BorderSide.None;
      this.xrLabel17.LocationFloat = new PointFloat(236.7017f, 682.7498f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(36.66667f, 23f);
      this.xrLabel17.StylePriority.UseBorders = false;
      this.xrLabel17.StylePriority.UseTextAlignment = false;
      this.xrLabel17.Text = "-";
      this.xrLabel17.TextAlignment = TextAlignment.TopCenter;
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.LocationFloat = new PointFloat(6.00001f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[30]
      {
        this.xrTableRow1,
        this.xrTableRow3,
        this.xrTableRow5,
        this.xrTableRow4,
        this.xrTableRow6,
        this.xrTableRow7,
        this.xrTableRow8,
        this.xrTableRow33,
        this.xrTableRow9,
        this.xrTableRow12,
        this.xrTableRow11,
        this.xrTableRow10,
        this.xrTableRow13,
        this.xrTableRow14,
        this.xrTableRow2,
        this.xrTableRow16,
        this.xrTableRow15,
        this.xrTableRow17,
        this.xrTableRow19,
        this.xrTableRow30,
        this.xrTableRow29,
        this.xrTableRow22,
        this.xrTableRow20,
        this.xrTableRow28,
        this.xrTableRow31,
        this.xrTableRow23,
        this.xrTableRow24,
        this.xrTableRow27,
        this.xrTableRow21,
        this.xrTableRow26
      });
      this.xrTable1.SizeF = new SizeF(634f, 920.1356f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "İZİN İSTEMİNDE BULUNAN PERSONEL";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 3.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell7,
        this.xrTableCell8
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.Text = "T.C. Kimlik No";
      this.xrTableCell7.Weight = 1.5041746908658797;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TCKIMLIKNO]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Text = "xrTableCell8";
      this.xrTableCell8.Weight = 1.4958253091341203;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell13,
        this.xrTableCell14
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.Text = "Sicil No";
      this.xrTableCell13.Weight = 1.5041755980194977;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SICILNO]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.Text = "xrTableCell14";
      this.xrTableCell14.Weight = 1.4958244019805023;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell10,
        this.xrTableCell11
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.Text = "Adı Soyadı";
      this.xrTableCell10.Weight = 1.5041742770224431;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.Text = "xrTableCell11";
      this.xrTableCell11.Weight = 1.4958257229775569;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.Text = "Ünvanı";
      this.xrTableCell16.Weight = 1.5041740676793005;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.Text = "xrTableCell17";
      this.xrTableCell17.Weight = 1.4958259323206995;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell19,
        this.xrTableCell20
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.Text = "Dairesi";
      this.xrTableCell19.Weight = 1.5041737187740629;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Text = "xrTableCell20";
      this.xrTableCell20.Weight = 1.4958262812259371;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell22,
        this.xrTableCell23
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.Text = "Şubesi";
      this.xrTableCell22.Weight = 1.5041752491142601;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDMUDURLUK]")
      });
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.Text = "xrTableCell23";
      this.xrTableCell23.Weight = 1.4958247508857399;
      this.xrTableRow33.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell36,
        this.xrTableCell39
      });
      this.xrTableRow33.Name = "xrTableRow33";
      this.xrTableRow33.Weight = 1.0;
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      this.xrTableCell36.Text = "İsdihdamı";
      this.xrTableCell36.Weight = 1.5041752491142601;
      this.xrTableCell39.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.xrTableCell39.Multiline = true;
      this.xrTableCell39.Name = "xrTableCell39";
      this.xrTableCell39.Text = "xrTableCell39";
      this.xrTableCell39.Weight = 1.4958247508857399;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell25
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell25.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.Text = "KULLANILACAK İZİN";
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.Weight = 3.0;
      this.xrTableRow12.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell34,
        this.xrTableCell35
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      this.xrTableCell34.Text = "İzin Türü";
      this.xrTableCell34.Weight = 1.5041752491142601;
      this.xrTableCell35.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IZINTURU]")
      });
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.Text = "xrTableCell35";
      this.xrTableCell35.Weight = 1.4958247508857399;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell31,
        this.xrTableCell32
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.Text = "İzin Yılı ";
      this.xrTableCell31.Weight = 1.5041751095521649;
      this.xrTableCell32.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IZINYILLARI]")
      });
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.Text = "xrTableCell32";
      this.xrTableCell32.Weight = 1.4958248904478351;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell28,
        this.xrTableCell29
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.Text = "Süresi";
      this.xrTableCell28.Weight = 1.5041730161207387;
      this.xrTableCell29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IZINSURESI]")
      });
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.Text = "xrTableCell29";
      this.xrTableCell29.Weight = 1.4958269838792613;
      this.xrTableRow13.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell37,
        this.xrTableCell38
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.Text = "Başlangıç Tarihi";
      this.xrTableCell37.Weight = 1.5041730161207387;
      this.xrTableCell38.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BASLANGICTARIHI]")
      });
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.Text = "xrTableCell38";
      this.xrTableCell38.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell38.Weight = 1.4958269838792613;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell2,
        this.xrTableCell3
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.Text = "Bitiş Tarihi";
      this.xrTableCell2.Weight = 1.5041723183102633;
      this.xrTableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BITISTARIHI]")
      });
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Text = "xrTableCell3";
      this.xrTableCell3.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell3.Weight = 1.4958276816897367;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell4,
        this.xrTableCell5
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Text = "Göreve Başlayacağı Tarih";
      this.xrTableCell4.Weight = 1.5041717600618829;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GOREVEBASTARIH]")
      });
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "xrTableCell5";
      this.xrTableCell5.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell5.Weight = 1.4958282399381171;
      this.xrTableRow16.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell42,
        this.xrTableCell43
      });
      this.xrTableRow16.Name = "xrTableRow16";
      this.xrTableRow16.Weight = 1.0;
      this.xrTableCell42.Multiline = true;
      this.xrTableCell42.Name = "xrTableCell42";
      this.xrTableCell42.Text = "İzinde Bulunacağı Açık Adres";
      this.xrTableCell42.Weight = 1.5041712018135027;
      this.xrTableCell43.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[IZINDEBULADRES]")
      });
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.Text = "xrTableCell43";
      this.xrTableCell43.Weight = 1.4958287981864973;
      this.xrTableRow15.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell27,
        this.xrTableCell40
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.Text = "İmzası";
      this.xrTableCell27.Weight = 1.5041710767799537;
      this.xrTableCell40.Multiline = true;
      this.xrTableCell40.Name = "xrTableCell40";
      this.xrTableCell40.Weight = 1.4958289232200463;
      this.xrTableRow17.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell45
      });
      this.xrTableRow17.Name = "xrTableRow17";
      this.xrTableRow17.Weight = 1.0;
      this.xrTableCell45.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell45.Multiline = true;
      this.xrTableCell45.Name = "xrTableCell45";
      this.xrTableCell45.StylePriority.UseFont = false;
      this.xrTableCell45.StylePriority.UseTextAlignment = false;
      this.xrTableCell45.Text = "İZİN TETKİKİ";
      this.xrTableCell45.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell45.Weight = 3.0;
      this.xrTableRow19.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell51
      });
      this.xrTableRow19.Name = "xrTableRow19";
      this.xrTableRow19.Weight = 1.0;
      this.xrTableCell51.Multiline = true;
      this.xrTableCell51.Name = "xrTableCell51";
      this.xrTableCell51.RowSpan = 3;
      this.xrTableCell51.StylePriority.UseTextAlignment = false;
      this.xrTableCell51.Text = "\r\nAdı geçen personelin dosyasının tetkikinde ................................................. yılına / yıllarına ait ................ gün yıllık izni bulunduğu tespit edilmiştir. \r\n";
      this.xrTableCell51.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell51.Weight = 3.0;
      this.xrTableRow30.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell24
      });
      this.xrTableRow30.Name = "xrTableRow30";
      this.xrTableRow30.Weight = 1.0;
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.Text = "xrTableCell24";
      this.xrTableCell24.Weight = 3.0;
      this.xrTableRow29.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell18
      });
      this.xrTableRow29.Name = "xrTableRow29";
      this.xrTableRow29.Weight = 1.0;
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.Text = "xrTableCell18";
      this.xrTableCell18.Weight = 3.0;
      this.xrTableRow22.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell60
      });
      this.xrTableRow22.Name = "xrTableRow22";
      this.xrTableRow22.Weight = 1.0;
      this.xrTableCell60.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell60.Multiline = true;
      this.xrTableCell60.Name = "xrTableCell60";
      this.xrTableCell60.StylePriority.UseFont = false;
      this.xrTableCell60.StylePriority.UseTextAlignment = false;
      this.xrTableCell60.Text = "TEKLİF VE ONAY\r\n";
      this.xrTableCell60.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell60.Weight = 3.0;
      this.xrTableRow20.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow20.Name = "xrTableRow20";
      this.xrTableRow20.Weight = 1.0;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.RowSpan = 5;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell6.Weight = 3.0;
      this.xrTableRow28.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell12
      });
      this.xrTableRow28.Name = "xrTableRow28";
      this.xrTableRow28.Weight = 1.0;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.Text = "xrTableCell12";
      this.xrTableCell12.Weight = 3.0;
      this.xrTableRow31.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell21
      });
      this.xrTableRow31.Name = "xrTableRow31";
      this.xrTableRow31.Weight = 1.0;
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.Text = "xrTableCell21";
      this.xrTableCell21.Weight = 3.0;
      this.xrTableRow23.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell46
      });
      this.xrTableRow23.Name = "xrTableRow23";
      this.xrTableRow23.Weight = 1.0;
      this.xrTableCell46.Multiline = true;
      this.xrTableCell46.Name = "xrTableCell46";
      this.xrTableCell46.Text = "xrTableCell46";
      this.xrTableCell46.Weight = 3.0;
      this.xrTableRow24.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell48
      });
      this.xrTableRow24.Name = "xrTableRow24";
      this.xrTableRow24.Weight = 1.0;
      this.xrTableCell48.Multiline = true;
      this.xrTableCell48.Name = "xrTableCell48";
      this.xrTableCell48.Weight = 3.0;
      this.xrTableRow27.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell69
      });
      this.xrTableRow27.Name = "xrTableRow27";
      this.xrTableRow27.Weight = 1.0;
      this.xrTableCell69.Multiline = true;
      this.xrTableCell69.Name = "xrTableCell69";
      this.xrTableCell69.RowSpan = 3;
      this.xrTableCell69.StylePriority.UseTextAlignment = false;
      this.xrTableCell69.Text = "\r\nİNSAN KAYNAKLARI VE EĞİTİM DAİRESİ BAŞKANLIĞINA Adı geçen personel ......../......./20...... tarihinde izinden dönmüş ve ........./......./20....... tarihinde görevine başlamıştır. \r\n";
      this.xrTableCell69.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell69.Weight = 3.0;
      this.xrTableRow21.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell44
      });
      this.xrTableRow21.Name = "xrTableRow21";
      this.xrTableRow21.Weight = 1.0;
      this.xrTableCell44.Multiline = true;
      this.xrTableCell44.Name = "xrTableCell44";
      this.xrTableCell44.Text = "xrTableCell44";
      this.xrTableCell44.Weight = 3.0;
      this.xrTableRow26.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell66
      });
      this.xrTableRow26.Name = "xrTableRow26";
      this.xrTableRow26.Weight = 1.0;
      this.xrTableCell66.Multiline = true;
      this.xrTableCell66.Name = "xrTableCell66";
      this.xrTableCell66.Text = "xrTableCell66";
      this.xrTableCell66.Weight = 3.0;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.id.Description = "Parameter1";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.izinRapor1.DataSetName = "izinRapor";
      this.izinRapor1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.sqlDataSource2.ConnectionName = "bellConnectionString";
      this.sqlDataSource2.Name = "sqlDataSource2";
      columnExpression21.ColumnName = "ADISOYADI";
      table9.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table9.Name = "TBLPERSONEL";
      columnExpression21.Table = table9;
      column21.Expression = (ExpressionBase) columnExpression21;
      columnExpression22.ColumnName = "IZINTURU";
      table10.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"605\" />";
      table10.Name = "TBLPERSONELIZIN";
      columnExpression22.Table = table10;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "IZINYILLARI";
      columnExpression23.Table = table10;
      column23.Expression = (ExpressionBase) columnExpression23;
      columnExpression24.ColumnName = "IZINSURESI";
      columnExpression24.Table = table10;
      column24.Expression = (ExpressionBase) columnExpression24;
      columnExpression25.ColumnName = "BASLANGICTARIHI";
      columnExpression25.Table = table10;
      column25.Expression = (ExpressionBase) columnExpression25;
      columnExpression26.ColumnName = "BITISTARIHI";
      columnExpression26.Table = table10;
      column26.Expression = (ExpressionBase) columnExpression26;
      columnExpression27.ColumnName = "IZINGUNSAY";
      columnExpression27.Table = table10;
      column27.Expression = (ExpressionBase) columnExpression27;
      columnExpression28.ColumnName = "GOREVEBASTARIH";
      columnExpression28.Table = table10;
      column28.Expression = (ExpressionBase) columnExpression28;
      columnExpression29.ColumnName = "IZINDEBULADRES";
      columnExpression29.Table = table10;
      column29.Expression = (ExpressionBase) columnExpression29;
      columnExpression30.ColumnName = "ONAYTARIH";
      columnExpression30.Table = table10;
      column30.Expression = (ExpressionBase) columnExpression30;
      columnExpression31.ColumnName = "IZINDURUM";
      columnExpression31.Table = table10;
      column31.Expression = (ExpressionBase) columnExpression31;
      columnExpression32.ColumnName = "UNVAN";
      table11.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table11.Name = "TBLPERSUNVAN";
      columnExpression32.Table = table11;
      column32.Expression = (ExpressionBase) columnExpression32;
      column33.Alias = "subemudur";
      columnExpression33.ColumnName = "ADISOYADI";
      table12.Alias = "TBLPERSONEL_1";
      table12.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table12.Name = "TBLPERSONEL";
      columnExpression33.Table = table12;
      column33.Expression = (ExpressionBase) columnExpression33;
      column34.Alias = "dairebaskan";
      columnExpression34.ColumnName = "ADISOYADI";
      table13.Alias = "TBLPERSONEL_2";
      table13.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table13.Name = "TBLPERSONEL";
      columnExpression34.Table = table13;
      column34.Expression = (ExpressionBase) columnExpression34;
      column35.Alias = "insankaynaklari";
      columnExpression35.ColumnName = "ADISOYADI";
      table14.Alias = "TBLPERSONEL_3";
      table14.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table14.Name = "TBLPERSONEL";
      columnExpression35.Table = table14;
      column35.Expression = (ExpressionBase) columnExpression35;
      column36.Alias = "genelsek";
      columnExpression36.ColumnName = "ADISOYADI";
      table15.Alias = "TBLPERSONEL_4";
      table15.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table15.Name = "TBLPERSONEL";
      columnExpression36.Table = table15;
      column36.Expression = (ExpressionBase) columnExpression36;
      column37.Alias = "muduryerine";
      columnExpression37.ColumnName = "ADISOYADI";
      table16.Alias = "TBLPERSONEL_5";
      table16.MetaSerializable = "<Meta X=\"1270\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table16.Name = "TBLPERSONEL";
      columnExpression37.Table = table16;
      column37.Expression = (ExpressionBase) columnExpression37;
      columnExpression38.ColumnName = "ADI";
      table17.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table17.Name = "TBLPERSONELISTIHDAMDURUM";
      columnExpression38.Table = table17;
      column38.Expression = (ExpressionBase) columnExpression38;
      columnExpression39.ColumnName = "SICILNO";
      columnExpression39.Table = table9;
      column39.Expression = (ExpressionBase) columnExpression39;
      columnExpression40.ColumnName = "TCKIMLIKNO";
      columnExpression40.Table = table9;
      column40.Expression = (ExpressionBase) columnExpression40;
      columnExpression41.ColumnName = "BELDMUDURLUK";
      table18.MetaSerializable = "<Meta X=\"1425\" Y=\"30\" Width=\"125\" Height=\"285\" />";
      table18.Name = "TBLBELDMUDURLUK";
      columnExpression41.Table = table18;
      column41.Expression = (ExpressionBase) columnExpression41;
      columnExpression42.ColumnName = "ID";
      columnExpression42.Table = table10;
      column42.Expression = (ExpressionBase) columnExpression42;
      columnExpression43.ColumnName = "BELDBIRIMADI";
      table19.MetaSerializable = "<Meta X=\"1580\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table19.Name = "TBLBELDBIRIMLER";
      columnExpression43.Table = table19;
      column43.Expression = (ExpressionBase) columnExpression43;
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
      selectQuery2.Columns.Add((ColumnBase) column34);
      selectQuery2.Columns.Add((ColumnBase) column35);
      selectQuery2.Columns.Add((ColumnBase) column36);
      selectQuery2.Columns.Add((ColumnBase) column37);
      selectQuery2.Columns.Add((ColumnBase) column38);
      selectQuery2.Columns.Add((ColumnBase) column39);
      selectQuery2.Columns.Add((ColumnBase) column40);
      selectQuery2.Columns.Add((ColumnBase) column41);
      selectQuery2.Columns.Add((ColumnBase) column42);
      selectQuery2.Columns.Add((ColumnBase) column43);
      selectQuery2.FilterString = "";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "TBLPERSONELIZIN_1";
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "PERSID";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table9;
      join8.Parent = table10;
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "PERSISTIHDAMIID";
      join9.KeyColumns.Add(relationColumnInfo9);
      join9.Nested = table17;
      join9.Parent = table9;
      join9.Type = JoinType.LeftOuter;
      relationColumnInfo10.NestedKeyColumn = "ID";
      relationColumnInfo10.ParentKeyColumn = "UNVANID";
      join10.KeyColumns.Add(relationColumnInfo10);
      join10.Nested = table11;
      join10.Parent = table9;
      join10.Type = JoinType.LeftOuter;
      relationColumnInfo11.NestedKeyColumn = "ID";
      relationColumnInfo11.ParentKeyColumn = "SBMUDURID";
      join11.KeyColumns.Add(relationColumnInfo11);
      join11.Nested = table12;
      join11.Parent = table10;
      join11.Type = JoinType.LeftOuter;
      relationColumnInfo12.NestedKeyColumn = "ID";
      relationColumnInfo12.ParentKeyColumn = "DAIREBSKID";
      join12.KeyColumns.Add(relationColumnInfo12);
      join12.Nested = table13;
      join12.Parent = table10;
      join12.Type = JoinType.LeftOuter;
      relationColumnInfo13.NestedKeyColumn = "ID";
      relationColumnInfo13.ParentKeyColumn = "INSANDAIREBSKID";
      join13.KeyColumns.Add(relationColumnInfo13);
      join13.Nested = table14;
      join13.Parent = table10;
      join13.Type = JoinType.LeftOuter;
      relationColumnInfo14.NestedKeyColumn = "ID";
      relationColumnInfo14.ParentKeyColumn = "GENELSEKYRDID";
      join14.KeyColumns.Add(relationColumnInfo14);
      join14.Nested = table15;
      join14.Parent = table10;
      join14.Type = JoinType.LeftOuter;
      relationColumnInfo15.NestedKeyColumn = "ID";
      relationColumnInfo15.ParentKeyColumn = "MUDURYERINE";
      join15.KeyColumns.Add(relationColumnInfo15);
      join15.Nested = table16;
      join15.Parent = table10;
      join15.Type = JoinType.LeftOuter;
      relationColumnInfo16.NestedKeyColumn = "ID";
      relationColumnInfo16.ParentKeyColumn = "BELDMUDURLUKID";
      join16.KeyColumns.Add(relationColumnInfo16);
      join16.Nested = table18;
      join16.Parent = table9;
      join16.Type = JoinType.LeftOuter;
      relationColumnInfo17.NestedKeyColumn = "ID";
      relationColumnInfo17.ParentKeyColumn = "BELDBIRIMIID";
      join17.KeyColumns.Add(relationColumnInfo17);
      join17.Nested = table19;
      join17.Parent = table9;
      join17.Type = JoinType.LeftOuter;
      selectQuery2.Relations.Add(join8);
      selectQuery2.Relations.Add(join9);
      selectQuery2.Relations.Add(join10);
      selectQuery2.Relations.Add(join11);
      selectQuery2.Relations.Add(join12);
      selectQuery2.Relations.Add(join13);
      selectQuery2.Relations.Add(join14);
      selectQuery2.Relations.Add(join15);
      selectQuery2.Relations.Add(join16);
      selectQuery2.Relations.Add(join17);
      selectQuery2.Tables.Add(table10);
      selectQuery2.Tables.Add(table9);
      selectQuery2.Tables.Add(table17);
      selectQuery2.Tables.Add(table11);
      selectQuery2.Tables.Add(table12);
      selectQuery2.Tables.Add(table13);
      selectQuery2.Tables.Add(table14);
      selectQuery2.Tables.Add(table15);
      selectQuery2.Tables.Add(table16);
      selectQuery2.Tables.Add(table18);
      selectQuery2.Tables.Add(table19);
      this.sqlDataSource2.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery2
      });
      this.sqlDataSource2.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource2.ResultSchemaSerializable");
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[3]
      {
        (IComponent) this.sqlDataSource1,
        (IComponent) this.izinRapor1,
        (IComponent) this.sqlDataSource2
      });
      this.DataMember = "TBLPERSONELIZIN_1";
      this.DataSource = (object) this.sqlDataSource2;
      this.FilterString = "[ID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(81, 100, 113, 30);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.Title,
        this.DetailCaption1,
        this.DetailData1,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.izinRapor1.EndInit();
      this.EndInit();
    }
  }
}
