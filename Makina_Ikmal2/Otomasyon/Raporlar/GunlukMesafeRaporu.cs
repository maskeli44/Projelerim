// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.Raporlar.GunlukMesafeRaporu
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

namespace Makina_Ikmal.Otomasyon.Raporlar
{
  public class GunlukMesafeRaporu : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell10;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell11;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRPictureBox xrPictureBox2;
    private GroupHeaderBand GroupHeader1;
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
    private Parameter id;
    private XRLabel xrLabel1;

    public GunlukMesafeRaporu() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Table table3 = new Table();
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
      Table table4 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table5 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GunlukMesafeRaporu));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable6 = new XRTable();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTable7 = new XRTable();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell11 = new XRTableCell();
      this.xrTable8 = new XRTable();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTable9 = new XRTable();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.PageHeader = new PageHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrLabel1 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrPictureBox2 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
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
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.id = new Parameter();
      this.xrTable6.BeginInit();
      this.xrTable7.BeginInit();
      this.xrTable8.BeginInit();
      this.xrTable9.BeginInit();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable5.BeginInit();
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
      columnExpression3.ColumnName = "MESAIICI";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"205\" />";
      table3.Name = "TBLARACMESTKP";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "MESAIDISI";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "TOPLAMKM";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "CALISMASURESI";
      columnExpression6.Table = table3;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "TARIHSAAT";
      columnExpression7.Table = table3;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "UNVAN";
      table4.MetaSerializable = "<Meta X=\"380\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table4.Name = "TBLPERSUNVAN";
      columnExpression8.Table = table4;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BELDBIRIMADI";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table5.Name = "TBLBELDBIRIMLER";
      columnExpression9.Table = table5;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BELDBIRIMID";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
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
      selectQuery.FilterString = "[TBLARACMESTKP.ID] = ?id";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "rapor";
      queryParameter.Name = "id";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?id", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "TAHSISEDILENID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "PLAKA";
      relationColumnInfo2.ParentKeyColumn = "PLAKA";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "UNVANID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BELDBIRIMID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable6,
        (XRControl) this.xrTable7,
        (XRControl) this.xrTable8,
        (XRControl) this.xrTable9
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.xrTable6.Borders = BorderSide.All;
      this.xrTable6.LocationFloat = new PointFloat(624.1667f, 0.0f);
      this.xrTable6.Name = "xrTable6";
      this.xrTable6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable6.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow6
      });
      this.xrTable6.SizeF = new SizeF(125.8333f, 25f);
      this.xrTable6.StylePriority.UseBorders = false;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell10
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CALISMASURESI]")
      });
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "Çalışma Saati";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell10.Weight = 1.0;
      this.xrTable7.Borders = BorderSide.All;
      this.xrTable7.LocationFloat = new PointFloat(524.1667f, 0.0f);
      this.xrTable7.Name = "xrTable7";
      this.xrTable7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable7.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow7
      });
      this.xrTable7.SizeF = new SizeF(100f, 25f);
      this.xrTable7.StylePriority.UseBorders = false;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell11
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLAMKM]")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "Toplam KM";
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell11.Weight = 1.0;
      this.xrTable8.Borders = BorderSide.All;
      this.xrTable8.LocationFloat = new PointFloat(265f, 0.0f);
      this.xrTable8.Name = "xrTable8";
      this.xrTable8.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable8.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow8
      });
      this.xrTable8.SizeF = new SizeF(259.1667f, 25f);
      this.xrTable8.StylePriority.UseBorders = false;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell12,
        this.xrTableCell13,
        this.xrTableCell14
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "Ünvanı";
      this.xrTableCell12.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell12.Weight = 0.73333343505859383;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MESAIICI]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "Mesai İçi";
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 0.95;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MESAIDISI]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "Mesai Dışı";
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell14.Weight = 0.90833404541015628;
      this.xrTable9.Borders = BorderSide.All;
      this.xrTable9.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable9.Name = "xrTable9";
      this.xrTable9.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable9.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow9
      });
      this.xrTable9.SizeF = new SizeF(265f, 25f);
      this.xrTable9.StylePriority.UseBorders = false;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell15,
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
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
      this.xrTableCell15.Weight = 0.7;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "Plaka";
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell16.Weight = 0.925;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Tahsis Edilen";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell17.Weight = 1.025;
      this.PageHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrTable1,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrPictureBox2
      });
      this.PageHeader.HeightF = 75.83334f;
      this.PageHeader.Name = "PageHeader";
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
      this.xrTableCell1.Font = new Font("Arial", 14f);
      this.xrTableCell1.ForeColor = Color.GhostWhite;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseForeColor = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "1.1 HUKUK MÜŞAVİRİ";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 1.0;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIHSAAT]")
      });
      this.xrLabel1.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(100f, 10f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(155f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat((float) byte.MaxValue, 10f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(309.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "GÜNLÜK MESAFE RAPORU";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 75.83334f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(578.1249f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 75.83334f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable2,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable5
      });
      this.GroupHeader1.HeightF = 37.5f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(265f, 37.5f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseFont = false;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell2,
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "S.NO";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.7;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Plaka";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 0.925;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Tahsis Edilen";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 1.025;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable3.LocationFloat = new PointFloat(265f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(259.1667f, 37.5f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTable3.StylePriority.UseFont = false;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell7
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Ünvanı";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.73333343505859383;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Mesai İçi\r\n 06:00-18:00";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.95;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Mesai Dışı";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 0.90833404541015628;
      this.xrTable4.Borders = BorderSide.All;
      this.xrTable4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable4.LocationFloat = new PointFloat(524.1667f, 0.0f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(100f, 37.5f);
      this.xrTable4.StylePriority.UseBorders = false;
      this.xrTable4.StylePriority.UseFont = false;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell8
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Toplam KM";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 1.0;
      this.xrTable5.Borders = BorderSide.All;
      this.xrTable5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable5.LocationFloat = new PointFloat(624.1667f, 0.0f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(125.8333f, 37.5f);
      this.xrTable5.StylePriority.UseBorders = false;
      this.xrTable5.StylePriority.UseFont = false;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "Çalışma Saati";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 1.0;
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
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
      this.DataMember = "rapor";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[BELDBIRIMID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(54, 36, 100, 100);
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.Version = "20.1";
      this.xrTable6.EndInit();
      this.xrTable7.EndInit();
      this.xrTable8.EndInit();
      this.xrTable9.EndInit();
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.xrTable5.EndInit();
      this.EndInit();
    }
  }
}
