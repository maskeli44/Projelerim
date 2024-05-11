// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.AracParkIcmalSayim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class AracParkIcmalSayim : XtraReport
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
    private XRLabel xrLabel1;
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRLabel xrLabel2;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private Parameter aracDurumID;
    private Parameter aracTipID;

    public AracParkIcmalSayim() => this.InitializeComponent();

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
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table3 = new Table();
      Group group1 = new Group();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Group group2 = new Group();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Group group3 = new Group();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Group group4 = new Group();
      ColumnExpression columnExpression9 = new ColumnExpression();
      QueryParameter queryParameter1 = new QueryParameter();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression10 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracParkIcmalSayim));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.xrLabel1 = new XRLabel();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.ReportHeader = new ReportHeaderBand();
      this.label1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrLabel2 = new XRLabel();
      this.aracDurumID = new Parameter();
      this.aracTipID = new Parameter();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ARACDURUMID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"150\" Height=\"1543\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ARACTIPIID";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "GRUPADI";
      table2.MetaSerializable = "<Meta X=\"220\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table2.Name = "TBLARACGRUBU2";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      column4.Alias = "Adet";
      columnExpression4.Aggregate = AggregationType.Count;
      columnExpression4.ColumnName = "GRUPADI";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "BELDBIRIMADI";
      table3.MetaSerializable = "<Meta X=\"390\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table3.Name = "TBLBELDBIRIMLER";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.FilterString = "";
      selectQuery.GroupFilterString = "[ARACDURUMID] = ?aracDurumID And [ARACTIPIID] = ?aracTipID";
      columnExpression6.ColumnName = "ARACDURUMID";
      columnExpression6.Table = table1;
      group1.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ARACTIPIID";
      columnExpression7.Table = table1;
      group2.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "GRUPADI";
      columnExpression8.Table = table2;
      group3.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BELDBIRIMADI";
      columnExpression9.Table = table3;
      group4.Expression = (ExpressionBase) columnExpression9;
      selectQuery.Groups.Add(group1);
      selectQuery.Groups.Add(group2);
      selectQuery.Groups.Add(group3);
      selectQuery.Groups.Add(group4);
      selectQuery.Name = "TBLARACLAR_1";
      queryParameter1.Name = "aracDurumID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?aracDurumID", typeof (int));
      queryParameter2.Name = "aracTipID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?aracTipID", typeof (int));
      selectQuery.Parameters.Add(queryParameter1);
      selectQuery.Parameters.Add(queryParameter2);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "BELDBIRIMID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table1;
      join1.Type = JoinType.LeftOuter;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "ARACGRUBU2ID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table1;
      join2.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      columnExpression10.ColumnName = "BELDBIRIMADI";
      columnExpression10.Table = table3;
      sorting.Expression = (ExpressionBase) columnExpression10;
      selectQuery.Sorting.Add(sorting);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
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
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.Name = "BottomMargin";
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([Adet])")
      });
      this.xrLabel1.LocationFloat = new PointFloat(527.0001f, 29f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(100f, 23f);
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel1.Summary = xrSummary;
      this.xrLabel1.Text = "xrLabel1";
      this.pageInfo1.LocationFloat = new PointFloat(6f, 6f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(301.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(319f, 6f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(301.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
      this.ReportHeader.HeightF = 60f;
      this.ReportHeader.Name = "ReportHeader";
      this.label1.LocationFloat = new PointFloat(6f, 6f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(615f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.Text = "Araç Listesi";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 28f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.table1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(627f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[3]
      {
        this.tableCell1,
        this.tableCell2,
        this.xrTableCell1
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "CINSI";
      this.tableCell1.Weight = 0.53027114989844992;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.StylePriority.UseTextAlignment = false;
      this.tableCell2.Text = "Adet";
      this.tableCell2.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell2.Weight = 0.33299169240865462;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(627f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.tableCell3,
        this.tableCell4,
        this.xrTableCell2
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell3.Borders = BorderSide.None;
      this.tableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GRUPADI]")
      });
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailData1";
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.Weight = 0.53027114989844992;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Adet]")
      });
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailData1";
      this.tableCell4.StylePriority.UseTextAlignment = false;
      this.tableCell4.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell4.Weight = 0.33299169240865462;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailCaption1";
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Birimi";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell1.Weight = 0.60646600779444548;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell2.Weight = 0.60646600779444548;
      this.xrLabel2.LocationFloat = new PointFloat(368.276f, 29f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel2.SizeF = new SizeF(130.6824f, 23f);
      this.xrLabel2.Text = "Toplam Araç Sayısı :";
      this.aracDurumID.Description = "aracDurumID";
      this.aracDurumID.Name = "aracDurumID";
      this.aracDurumID.Type = typeof (int);
      this.aracDurumID.ValueInfo = "0";
      this.aracTipID.Description = "aracTipID";
      this.aracTipID.Name = "aracTipID";
      this.aracTipID.Type = typeof (int);
      this.aracTipID.ValueInfo = "0";
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLARACLAR_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
      this.Parameters.AddRange(new Parameter[2]
      {
        this.aracDurumID,
        this.aracTipID
      });
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.Title,
        this.DetailCaption1,
        this.DetailData1,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.table1.EndInit();
      this.table2.EndInit();
      this.EndInit();
    }
  }
}
