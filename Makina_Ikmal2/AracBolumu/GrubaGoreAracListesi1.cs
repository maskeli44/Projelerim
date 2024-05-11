// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.GrubaGoreAracListesi1
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

namespace Makina_Ikmal.AracBolumu
{
  public class GrubaGoreAracListesi1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private GroupHeaderBand GroupHeader1;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell8;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell15;
    private Parameter kod;

    public GrubaGoreAracListesi1() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table3 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table4 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table5 = new Table();
      Table table6 = new Table();
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
      Table table7 = new Table();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GrubaGoreAracListesi1));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.kod = new Parameter();
      this.xrTable5.BeginInit();
      this.xrTable6.BeginInit();
      this.xrTable7.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ARACACIKLAMA";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "BIRIMADI";
      table2.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table2.Name = "TBLMALZBIRIM";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "TARIH";
      table3.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"425\" />";
      table3.Name = "TBLARACZIMMET";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "SAAT";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ZIMMETALANID";
      columnExpression6.Table = table3;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ADISOYADI";
      table4.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression7.Table = table4;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "CEPTELEFON";
      columnExpression8.Table = table4;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "GOREVDURUM";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.Columns.Add((ColumnBase) column8);
      selectQuery.Columns.Add((ColumnBase) column9);
      selectQuery.FilterString = "[TBLTALEP.KOD] = ?kod";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLTEKLIF_1";
      queryParameter.Name = "kod";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?kod", typeof (string));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"745\" />";
      table5.Name = "TBLTEKLIFHRKT";
      join1.Nested = table5;
      table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table6.Name = "TBLTEKLIF";
      join1.Parent = table6;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "ARACID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table1;
      join2.Parent = table5;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BIRIMID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table2;
      join3.Parent = table5;
      relationColumnInfo4.NestedKeyColumn = "ARACID";
      relationColumnInfo4.ParentKeyColumn = "ARACID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table3;
      join4.Parent = table5;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ZIMMETALANID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table4;
      join5.Parent = table3;
      relationColumnInfo6.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo6.ParentKeyColumn = "ID";
      join6.KeyColumns.Add(relationColumnInfo6);
      table7.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table7.Name = "TBLTALEP";
      join6.Nested = table7;
      join6.Parent = table6;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Relations.Add(join6);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table7);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable7
      });
      this.Detail.HeightF = 35f;
      this.Detail.Name = "Detail";
      this.xrTable5.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(365.8333f, 35f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell9,
        this.xrTableCell10,
        this.xrTableCell11
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell9.BackColor = Color.White;
      this.xrTableCell9.Borders = BorderSide.All;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBackColor = false;
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell9.Summary = xrSummary;
      this.xrTableCell9.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell9.Weight = 0.5083338928222656;
      this.xrTableCell10.BackColor = Color.White;
      this.xrTableCell10.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBackColor = false;
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "xrTableCell10";
      this.xrTableCell10.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell10.Weight = 0.7416664123535156;
      this.xrTableCell11.BackColor = Color.White;
      this.xrTableCell11.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBackColor = false;
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "xrTableCell11";
      this.xrTableCell11.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell11.Weight = 2.4083328247070313;
      this.xrTable6.LocationFloat = new PointFloat(365.8333f, 0.0f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(260.1248f, 35f);
      this.xrTableRow6.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell12,
        this.xrTableCell13,
        this.xrTableCell14
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell12.BackColor = Color.White;
      this.xrTableCell12.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBackColor = false;
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "xrTableCell9";
      this.xrTableCell12.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell12.Weight = 0.623463134765625;
      this.xrTableCell13.BackColor = Color.White;
      this.xrTableCell13.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBackColor = false;
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "xrTableCell10";
      this.xrTableCell13.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell13.Weight = 1.044451904296875;
      this.xrTableCell14.BackColor = Color.White;
      this.xrTableCell14.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CEPTELEFON]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBackColor = false;
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "xrTableCell11";
      this.xrTableCell14.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell14.Weight = 0.93333312988281247;
      this.xrTable7.LocationFloat = new PointFloat(625.9581f, 0.0f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(76.04187f, 35f);
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell15
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell15.BackColor = Color.White;
      this.xrTableCell15.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GOREVDURUM]")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBackColor = false;
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.Text = "xrTableCell15";
      this.xrTableCell15.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell15.Weight = 1.0;
      this.PageHeader.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(572.4583f, 7.500051f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(115.3332f, 35.70836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 48.83334f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ\r\n ARAÇ LİSTESİ";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(2.833313f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable1,
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable4
      });
      this.GroupHeader1.HeightF = 60f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable1.LocationFloat = new PointFloat(2.543131E-05f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(702f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.Gold;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Weight = 1.0;
      this.xrTable2.LocationFloat = new PointFloat(2.543131E-05f, 25f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(365.8333f, 35f);
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell2,
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.BackColor = Color.PowderBlue;
      this.xrTableCell2.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBackColor = false;
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "SIRA NO";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.50833343505859374;
      this.xrTableCell3.BackColor = Color.PowderBlue;
      this.xrTableCell3.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBackColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "PLAKA";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 0.7416664123535156;
      this.xrTableCell4.BackColor = Color.PowderBlue;
      this.xrTableCell4.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBackColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Araç Açıklama";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 2.408333257846734;
      this.xrTable3.LocationFloat = new PointFloat(365.8333f, 25f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(260.1248f, 35f);
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell7
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell5.BackColor = Color.PowderBlue;
      this.xrTableCell5.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBackColor = false;
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Birim";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.68137355695654067;
      this.xrTableCell6.BackColor = Color.PowderBlue;
      this.xrTableCell6.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBackColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Şoför";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 1.1414659260043503;
      this.xrTableCell7.BackColor = Color.PowderBlue;
      this.xrTableCell7.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBackColor = false;
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Telefon";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 1.0200257995023279;
      this.xrTable4.LocationFloat = new PointFloat(625.9581f, 25f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(76.04187f, 35f);
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell8
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell8.BackColor = Color.PowderBlue;
      this.xrTableCell8.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBackColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Araç Durum";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 1.0;
      this.kod.Name = "kod";
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
      this.DataMember = "TBLTEKLIF_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(60, 63, 100, 100);
      this.Parameters.AddRange(new Parameter[1]{ this.kod });
      this.Version = "20.1";
      this.xrTable5.EndInit();
      this.xrTable6.EndInit();
      this.xrTable7.EndInit();
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.EndInit();
    }
  }
}
