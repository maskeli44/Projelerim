// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.OdenekIzınBelgesi1
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

namespace Makina_Ikmal.SatinAlma.TalepRaporlari
{
  public class OdenekIzınBelgesi1 : XtraReport
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
    private XRLabel xrLabel1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell3;
    private XRTable xrTable3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTable xrTable2;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell6;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell8;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell9;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTable xrTable9;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTable xrTable10;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTable xrTable11;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell24;
    private XRTable xrTable12;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell25;
    private XRTable xrTable13;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell26;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell28;
    private XRTable xrTable14;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell27;
    private XRTable xrTable15;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTable xrTable16;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTable xrTable17;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell2;
    private XRTable xrTable18;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell43;
    private Parameter talepID;

    public OdenekIzınBelgesi1() => this.InitializeComponent();

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
      QueryParameter queryParameter1 = new QueryParameter();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table2 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table3 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table4 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table5 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      SelectQuery selectQuery4 = new SelectQuery();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table6 = new Table();
      QueryParameter queryParameter4 = new QueryParameter();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Table table7 = new Table();
      SelectQuery selectQuery5 = new SelectQuery();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Table table8 = new Table();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Table table9 = new Table();
      QueryParameter queryParameter5 = new QueryParameter();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OdenekIzınBelgesi1));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTable9 = new XRTable();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTable10 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTable11 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell24 = new XRTableCell();
      this.xrTable12 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTable13 = new XRTable();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableRow17 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow16 = new XRTableRow();
      this.xrTableCell27 = new XRTableCell();
      this.xrTable18 = new XRTable();
      this.xrTableRow21 = new XRTableRow();
      this.xrTableCell43 = new XRTableCell();
      this.xrTable15 = new XRTable();
      this.xrTableRow18 = new XRTableRow();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableCell30 = new XRTableCell();
      this.xrTableCell31 = new XRTableCell();
      this.xrTable16 = new XRTable();
      this.xrTableRow19 = new XRTableRow();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableCell33 = new XRTableCell();
      this.xrTableCell34 = new XRTableCell();
      this.xrTable17 = new XRTable();
      this.xrTableRow20 = new XRTableRow();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableCell37 = new XRTableCell();
      this.talepID = new Parameter();
      this.xrTable1.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable2.BeginInit();
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
      this.xrTable18.BeginInit();
      this.xrTable15.BeginInit();
      this.xrTable16.BeginInit();
      this.xrTable17.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TARIH";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table1.Name = "TBLTALEP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "BELGETARIH";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ISINTURUMIKTARI";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ISINADI";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "BUTCETERTIBI";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "BELGESAYI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.Columns.Add((ColumnBase) column5);
      selectQuery1.Columns.Add((ColumnBase) column6);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTALEP_1";
      queryParameter1.Name = "talepID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      selectQuery1.Tables.Add(table1);
      columnExpression7.ColumnName = "ISTENENMIKTAR";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"243\" />";
      table2.Name = "TBLTALEPFISHRKT";
      columnExpression7.Table = table2;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "KOD";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"523\" />";
      table3.Name = "TBLTALEPFIS";
      columnExpression8.Table = table3;
      column8.Expression = (ExpressionBase) columnExpression8;
      selectQuery2.Columns.Add((ColumnBase) column7);
      selectQuery2.Columns.Add((ColumnBase) column8);
      selectQuery2.FilterString = "[TBLTALEPFIS.TALEPKAYITID] = ?talepID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "TBLTALEPFIS";
      queryParameter2.Name = "talepID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo1.NestedKeyColumn = "TALEPFISID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table3;
      selectQuery2.Relations.Add(join1);
      selectQuery2.Tables.Add(table3);
      selectQuery2.Tables.Add(table2);
      columnExpression9.ColumnName = "DAIREBSKID";
      table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table4.Name = "TBLTALEP";
      columnExpression9.Table = table4;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "ADISOYADI";
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression10.Table = table5;
      column10.Expression = (ExpressionBase) columnExpression10;
      selectQuery3.Columns.Add((ColumnBase) column9);
      selectQuery3.Columns.Add((ColumnBase) column10);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "DaireBaskani";
      queryParameter3.Name = "talepID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "DAIREBSKID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table5;
      join2.Parent = table4;
      selectQuery3.Relations.Add(join2);
      selectQuery3.Tables.Add(table4);
      selectQuery3.Tables.Add(table5);
      columnExpression11.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression11.Table = table6;
      column11.Expression = (ExpressionBase) columnExpression11;
      selectQuery4.Columns.Add((ColumnBase) column11);
      selectQuery4.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery4.GroupFilterString = "";
      selectQuery4.Name = "SubeMuduru";
      queryParameter4.Name = "talepID";
      queryParameter4.Type = typeof (Expression);
      queryParameter4.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery4.Parameters.Add(queryParameter4);
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MUDURID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table6;
      table7.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table7.Name = "TBLTALEP";
      join3.Parent = table7;
      selectQuery4.Relations.Add(join3);
      selectQuery4.Tables.Add(table7);
      selectQuery4.Tables.Add(table6);
      columnExpression12.ColumnName = "SORUMLUID";
      table8.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table8.Name = "TBLTALEP";
      columnExpression12.Table = table8;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ADISOYADI";
      table9.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table9.Name = "TBLPERSONEL";
      columnExpression13.Table = table9;
      column13.Expression = (ExpressionBase) columnExpression13;
      selectQuery5.Columns.Add((ColumnBase) column12);
      selectQuery5.Columns.Add((ColumnBase) column13);
      selectQuery5.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery5.GroupFilterString = "";
      selectQuery5.Name = "Sorumlu";
      queryParameter5.Name = "talepID";
      queryParameter5.Type = typeof (Expression);
      queryParameter5.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery5.Parameters.Add(queryParameter5);
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "GENELSEKRETERID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table9;
      join4.Parent = table8;
      selectQuery5.Relations.Add(join4);
      selectQuery5.Tables.Add(table8);
      selectQuery5.Tables.Add(table9);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[5]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3,
        (SqlQuery) selectQuery4,
        (SqlQuery) selectQuery5
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Name = "Detail";
      this.PageHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel1
      });
      this.PageHeader.HeightF = 104.7084f;
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(574.625f, 7.500051f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(117.4999f, 58.70837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(117.4999f, 35.70836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(5f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(240f, 81.70837f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(227.0412f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "ÖDENEK İZİN BELGESİ";
      this.GroupHeader1.Controls.AddRange(new XRControl[17]
      {
        (XRControl) this.xrTable1,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable2,
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
        (XRControl) this.xrTable15,
        (XRControl) this.xrTable16,
        (XRControl) this.xrTable17
      });
      this.GroupHeader1.HeightF = 671.6668f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable1.LocationFloat = new PointFloat(28.49998f, 45.00001f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(529.6249f, 29.16667f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell1,
        this.xrTableCell2,
        this.xrTableCell3
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.White;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Sayı:";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell1.Weight = 0.33298398078529118;
      this.xrTableCell2.BackColor = Color.White;
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELGESAYI]")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBackColor = false;
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.90916267110918358;
      this.xrTableCell3.BackColor = Color.White;
      this.xrTableCell3.Borders = BorderSide.All;
      this.xrTableCell3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBackColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Tarih:";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell3.Weight = 1.2534683066802239;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.LocationFloat = new PointFloat(28.49989f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable3.SizeF = new SizeF(672.6847f, 45f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTable3.StylePriority.UseTextAlignment = false;
      this.xrTable3.TextAlignment = TextAlignment.TopCenter;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell4.BackColor = Color.White;
      this.xrTableCell4.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBackColor = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "MALİ HİZMETLER DAİRE BAŞKANLIĞINA";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 1.0;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.LocationFloat = new PointFloat(558.1251f, 45.00001f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable2.SizeF = new SizeF(143.0597f, 29.16667f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseTextAlignment = false;
      this.xrTable2.TextAlignment = TextAlignment.TopCenter;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell6.BackColor = Color.White;
      this.xrTableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.xrTableCell6.Font = new Font("Arial", 10f);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBackColor = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.355978011636828;
      this.xrTable4.LocationFloat = new PointFloat(28.49998f, 74.16665f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(672.6847f, 25f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell5,
        this.xrTableCell8
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell5.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.Text = "Bütçe Yılı";
      this.xrTableCell5.Weight = 2.8583334350585941;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.Text = "xrTableCell8";
      this.xrTableCell8.Weight = 3.868513488769532;
      this.xrTable5.LocationFloat = new PointFloat(28.49998f, 99.16671f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(672.6847f, 25f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell7,
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.Text = "İşin Adı";
      this.xrTableCell7.Weight = 2.8583334350585941;
      this.xrTableCell9.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISINADI]")
      });
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.Text = "xrTableCell8";
      this.xrTableCell9.Weight = 3.868513488769532;
      this.xrTable6.LocationFloat = new PointFloat(28.50005f, 124.1668f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(672.6847f, 25f);
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell10,
        this.xrTableCell11
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell10.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.Text = "İşin Miktarı";
      this.xrTableCell10.Weight = 2.8583334350585941;
      this.xrTableCell11.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISINTURUMIKTARI]")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.Text = "xrTableCell8";
      this.xrTableCell11.Weight = 3.868513488769532;
      this.xrTable7.LocationFloat = new PointFloat(28.49998f, 149.1668f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(672.6847f, 25f);
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell12,
        this.xrTableCell13
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell12.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.Text = "Harcamanın Yapılacağı Bütçe Terfibi";
      this.xrTableCell12.Weight = 2.8583334350585941;
      this.xrTableCell13.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BUTCETERTIBI]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.Text = "xrTableCell8";
      this.xrTableCell13.Weight = 3.868513488769532;
      this.xrTable8.LocationFloat = new PointFloat(28.49998f, 174.1668f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(672.6847f, 25f);
      this.xrTableRow8.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell14,
        this.xrTableCell15
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell14.Borders = BorderSide.All;
      this.xrTableCell14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseFont = false;
      this.xrTableCell14.Text = "Bu İş İçin İstenen Ödenek";
      this.xrTableCell14.Weight = 2.8583334350585941;
      this.xrTableCell15.Borders = BorderSide.All;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLTALEPFIS].[ISTENENMIKTAR]")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.Text = "xrTableCell8";
      this.xrTableCell15.Weight = 3.868513488769532;
      this.xrTable9.LocationFloat = new PointFloat(28.50008f, 199.1668f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[3]
      {
        this.xrTableRow10,
        this.xrTableRow9,
        this.xrTableRow11
      });
      this.xrTable9.SizeF = new SizeF(672.6847f, 206.2501f);
      this.xrTableRow10.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell17
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell17.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell17.Font = new Font("Arial", 11f);
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "\r\n      Yukarıda Terribi ve kullanılabilir  ödenek tutarı belirtilen ödeneğin serbest bırakılması hususunu     OLUR'larınızı arz ederim.";
      this.xrTableCell17.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell17.Weight = 1.0;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell16,
        this.xrTableCell18
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell16.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SubeMuduru].[ADISOYADI]")
      });
      this.xrTableCell16.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "\r\n\r\nŞube Müdür";
      this.xrTableCell16.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell16.Weight = 0.5;
      this.xrTableCell18.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DaireBaskani].[ADISOYADI]")
      });
      this.xrTableCell18.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell18.Weight = 0.5;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell19,
        this.xrTableCell20
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell19.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell19.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBorders = false;
      this.xrTableCell19.StylePriority.UseFont = false;
      this.xrTableCell19.StylePriority.UseTextAlignment = false;
      this.xrTableCell19.Text = "Şube Müdürü";
      this.xrTableCell19.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell19.Weight = 0.5;
      this.xrTableCell20.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell20.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseBorders = false;
      this.xrTableCell20.StylePriority.UseFont = false;
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.Text = "Daire Başkanı\r\n(İhale Yetkilisi)";
      this.xrTableCell20.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell20.Weight = 0.5;
      this.xrTable10.LocationFloat = new PointFloat(28.50008f, 405.4169f);
      this.xrTable10.Name = "xrTable10";
      this.xrTable10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable10.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable10.SizeF = new SizeF(672.6847f, 27.08322f);
      this.xrTableRow12.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell21,
        this.xrTableCell22,
        this.xrTableCell23
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell21.Borders = BorderSide.Left;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELGESAYI]")
      });
      this.xrTableCell21.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.Text = "xrTableCell21";
      this.xrTableCell21.Weight = 1.6832972344670134;
      this.xrTableCell22.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseFont = false;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.Text = "Tarih:";
      this.xrTableCell22.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell22.Weight = 0.81561795701394246;
      this.xrTableCell23.Borders = BorderSide.Right;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.xrTableCell23.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.Text = "xrTableCell23";
      this.xrTableCell23.Weight = 0.41945709108600582;
      this.xrTable11.LocationFloat = new PointFloat(28.49998f, 432.5001f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable11.SizeF = new SizeF(672.6846f, 43.33334f);
      this.xrTableRow13.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell24
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell24.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell24.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.StylePriority.UseFont = false;
      this.xrTableCell24.StylePriority.UseTextAlignment = false;
      this.xrTableCell24.Text = "\r\nBASKANLIK MAKAMINA\r\n";
      this.xrTableCell24.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell24.Weight = 1.0;
      this.xrTable12.LocationFloat = new PointFloat(28.49989f, 475.8333f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable12.SizeF = new SizeF(672.6848f, 54.16666f);
      this.xrTableRow14.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell25
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell25.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell25.Font = new Font("Arial", 11f);
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.Text = "      Yukarıda Terribi ve kullanılabilir ödenek tutarı belirtilen ödeneğin serbest bırakılması hususunu OLUR' larınızı arz ederim.";
      this.xrTableCell25.Weight = 1.0;
      this.xrTable13.LocationFloat = new PointFloat(28.49989f, 529.9999f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[2]
      {
        this.xrTableRow15,
        this.xrTableRow17
      });
      this.xrTable13.SizeF = new SizeF(336.3423f, 52.5f);
      this.xrTableRow15.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell26
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell26.Borders = BorderSide.Left;
      this.xrTableCell26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SubeMuduru].[ADISOYADI]")
      });
      this.xrTableCell26.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.Text = "Muhbin Bar";
      this.xrTableCell26.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell26.Weight = 1.5000005444022655;
      this.xrTableRow17.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell28
      });
      this.xrTableRow17.Name = "xrTableRow17";
      this.xrTableRow17.Weight = 1.2500019618460185;
      this.xrTableCell28.Borders = BorderSide.Left;
      this.xrTableCell28.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseBorders = false;
      this.xrTableCell28.StylePriority.UseFont = false;
      this.xrTableCell28.StylePriority.UseTextAlignment = false;
      this.xrTableCell28.Text = "Şube Müdür V";
      this.xrTableCell28.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell28.Weight = 1.5000005444022655;
      this.xrTable14.LocationFloat = new PointFloat(364.8423f, 529.9999f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow16
      });
      this.xrTable14.SizeF = new SizeF(336.3425f, 52.5f);
      this.xrTableRow16.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell27
      });
      this.xrTableRow16.Name = "xrTableRow16";
      this.xrTableRow16.Weight = 1.0;
      this.xrTableCell27.Borders = BorderSide.Right;
      this.xrTableCell27.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable18
      });
      this.xrTableCell27.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.StylePriority.UseBorders = false;
      this.xrTableCell27.StylePriority.UseFont = false;
      this.xrTableCell27.StylePriority.UseTextAlignment = false;
      this.xrTableCell27.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell27.Weight = 1.0;
      this.xrTable18.LocationFloat = new PointFloat(76.48148f, 23.33331f);
      this.xrTable18.Name = "xrTable18";
      this.xrTable18.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable18.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow21
      });
      this.xrTable18.SizeF = new SizeF(182.6667f, 25f);
      this.xrTableRow21.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell43
      });
      this.xrTableRow21.Name = "xrTableRow21";
      this.xrTableRow21.Weight = 11.5;
      this.xrTableCell43.Borders = BorderSide.None;
      this.xrTableCell43.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DaireBaskani].[ADISOYADI]")
      });
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.StylePriority.UseBorders = false;
      this.xrTableCell43.Text = "xrTableCell43";
      this.xrTableCell43.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell43.Weight = 100.0 / 121.0;
      this.xrTable15.LocationFloat = new PointFloat(28.50008f, 582.5f);
      this.xrTable15.Name = "xrTable15";
      this.xrTable15.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable15.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow18
      });
      this.xrTable15.SizeF = new SizeF(672.6846f, 25f);
      this.xrTableRow18.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell29,
        this.xrTableCell30,
        this.xrTableCell31
      });
      this.xrTableRow18.Name = "xrTableRow18";
      this.xrTableRow18.Weight = 1.0;
      this.xrTableCell29.Borders = BorderSide.Left;
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.StylePriority.UseBorders = false;
      this.xrTableCell29.Weight = 1.0;
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.Weight = 0.914241160976529;
      this.xrTableCell31.Borders = BorderSide.Right;
      this.xrTableCell31.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.StylePriority.UseBorders = false;
      this.xrTableCell31.StylePriority.UseFont = false;
      this.xrTableCell31.Text = "Mali Hizmetler Daire Bsk.";
      this.xrTableCell31.Weight = 1.0955984100476686;
      this.xrTable16.LocationFloat = new PointFloat(28.50008f, 607.5f);
      this.xrTable16.Name = "xrTable16";
      this.xrTable16.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable16.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow19
      });
      this.xrTable16.SizeF = new SizeF(672.6846f, 27.5f);
      this.xrTableRow19.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell32,
        this.xrTableCell33,
        this.xrTableCell34
      });
      this.xrTableRow19.Name = "xrTableRow19";
      this.xrTableRow19.Weight = 1.0;
      this.xrTableCell32.Borders = BorderSide.Left;
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.StylePriority.UseBorders = false;
      this.xrTableCell32.Weight = 1.0;
      this.xrTableCell33.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      this.xrTableCell33.StylePriority.UseFont = false;
      this.xrTableCell33.StylePriority.UseTextAlignment = false;
      this.xrTableCell33.Text = "OLUR";
      this.xrTableCell33.TextAlignment = TextAlignment.BottomCenter;
      this.xrTableCell33.Weight = 1.0;
      this.xrTableCell34.Borders = BorderSide.Right;
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      this.xrTableCell34.StylePriority.UseBorders = false;
      this.xrTableCell34.Weight = 1.0;
      this.xrTable17.LocationFloat = new PointFloat(28.50033f, 635.0001f);
      this.xrTable17.Name = "xrTable17";
      this.xrTable17.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable17.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow20
      });
      this.xrTable17.SizeF = new SizeF(672.6844f, 36.66669f);
      this.xrTableRow20.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell35,
        this.xrTableCell36,
        this.xrTableCell37
      });
      this.xrTableRow20.Name = "xrTableRow20";
      this.xrTableRow20.Weight = 1.0;
      this.xrTableCell35.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.StylePriority.UseBorders = false;
      this.xrTableCell35.Weight = 1.0;
      this.xrTableCell36.Borders = BorderSide.Bottom;
      this.xrTableCell36.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      this.xrTableCell36.StylePriority.UseBorders = false;
      this.xrTableCell36.StylePriority.UseFont = false;
      this.xrTableCell36.StylePriority.UseTextAlignment = false;
      this.xrTableCell36.Text = "../../20..";
      this.xrTableCell36.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell36.Weight = 1.0;
      this.xrTableCell37.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.StylePriority.UseBorders = false;
      this.xrTableCell37.Weight = 0.98675922331833588;
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
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
      this.DataMember = "TBLTALEP_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(64, 65, 100, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable3.EndInit();
      this.xrTable2.EndInit();
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
      this.xrTable18.EndInit();
      this.xrTable15.EndInit();
      this.xrTable16.EndInit();
      this.xrTable17.EndInit();
      this.EndInit();
    }
  }
}
