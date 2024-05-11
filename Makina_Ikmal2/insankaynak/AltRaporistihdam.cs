// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.AltRaporistihdam
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.insankaynak
{
  public class AltRaporistihdam : XtraReport
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
    private ReportHeaderBand ReportHeader;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell2;
    private XRTableCell tableCell3;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel1;

    public AltRaporistihdam() => this.InitializeComponent();

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
      Group group = new Group();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Join join = new Join();
      RelationColumnInfo relationColumnInfo = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AltRaporistihdam));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.GroupHeader1 = new GroupHeaderBand();
      this.Detail = new DetailBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell2 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.ReportFooter = new ReportFooterBand();
      this.xrLabel1 = new XRLabel();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      column1.Alias = "Count_ADISOYADI";
      columnExpression1.Aggregate = AggregationType.Count;
      columnExpression1.ColumnName = "ADISOYADI";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table1.Name = "TBLPERSONEL";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "ADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table2.Name = "TBLPERSONELISTIHDAMDURUM";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      column3.Alias = "Count_PERSDURUMID";
      columnExpression3.Aggregate = AggregationType.Count;
      columnExpression3.ColumnName = "PERSDURUMID";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.FilterString = "[TBLPERSONEL.PERSDURUMID] = 1";
      selectQuery.GroupFilterString = "";
      columnExpression4.ColumnName = "ADI";
      columnExpression4.Table = table2;
      group.Expression = (ExpressionBase) columnExpression4;
      selectQuery.Groups.Add(group);
      selectQuery.Name = "TBLPERSONEL_1";
      relationColumnInfo.NestedKeyColumn = "ID";
      relationColumnInfo.ParentKeyColumn = "PERSISTIHDAMIID";
      join.KeyColumns.Add(relationColumnInfo);
      join.Nested = table2;
      join.Parent = table1;
      join.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
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
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.DetailCaption1.BackColor = Color.FromArgb(23, 104, 196);
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
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.HeightF = 60f;
      this.ReportHeader.Name = "ReportHeader";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 28f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.table1.LocationFloat = new PointFloat(6.103516E-05f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(626.9999f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell2,
        this.tableCell3
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "İstihdam";
      this.tableCell2.Weight = 0.5214737524773726;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.StylePriority.UseTextAlignment = false;
      this.tableCell3.Text = "Sayı";
      this.tableCell3.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell3.Weight = 0.47852618690502891;
      this.table2.LocationFloat = new PointFloat(3.051758E-05f, 0.0f);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(626.9999f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell5,
        this.tableCell6
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell5.BorderColor = Color.Gray;
      this.tableCell5.Borders = BorderSide.All;
      this.tableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailData1";
      this.tableCell5.StylePriority.UseBorderColor = false;
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.Weight = 0.521473801149749;
      this.tableCell6.BorderColor = Color.Gray;
      this.tableCell6.Borders = BorderSide.All;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Count_PERSDURUMID]")
      });
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailData1";
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseTextAlignment = false;
      this.tableCell6.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell6.Weight = 0.47852618690502891;
      this.ReportFooter.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.ReportFooter.HeightF = 26.50004f;
      this.ReportFooter.Name = "ReportFooter";
      this.xrLabel1.Borders = BorderSide.None;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sum([Count_PERSDURUMID])")
      });
      this.xrLabel1.LocationFloat = new PointFloat(602.8334f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(40f, 23f);
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Group;
      this.xrLabel1.Summary = xrSummary;
      this.xrLabel1.Text = "xrLabel1";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleJustify;
      this.Bands.AddRange(new Band[6]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.Detail,
        (Band) this.ReportFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLPERSONEL_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
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
