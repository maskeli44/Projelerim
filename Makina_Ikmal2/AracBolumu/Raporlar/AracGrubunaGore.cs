// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.AracGrubunaGore
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class AracGrubunaGore : XtraReport
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
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private GroupHeaderBand GroupHeader2;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private DetailBand Detail;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRLabel label2;
    private GroupFooterBand GroupFooter1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private GroupHeaderBand GroupHeader3;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private GroupFooterBand GroupFooter2;
    private XRLabel xrLabel1;

    public AracGrubunaGore() => this.InitializeComponent();

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
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table2 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table3 = new Table();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table4 = new Table();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table5 = new Table();
      Group group1 = new Group();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Group group2 = new Group();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Group group3 = new Group();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Group group4 = new Group();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Group group5 = new Group();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Group group6 = new Group();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Group group7 = new Group();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression15 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracGrubunaGore));
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
      this.BottomMargin = new BottomMarginBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.ReportHeader = new ReportHeaderBand();
      this.label1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.GroupHeader2 = new GroupHeaderBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.label2 = new XRLabel();
      this.GroupFooter1 = new GroupFooterBand();
      this.GroupHeader3 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.GroupFooter2 = new GroupFooterBand();
      this.xrLabel1 = new XRLabel();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.table3.BeginInit();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1543\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "MODEL";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACACIKLAMA";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "BELDBIRIMADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table2.Name = "TBLBELDBIRIMLER";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "GRUPADI";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table3.Name = "TBLARACGRUBU";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ARACMARKA";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table4.Name = "TBLARACMARKA";
      columnExpression6.Table = table4;
      column6.Expression = (ExpressionBase) columnExpression6;
      column7.Alias = "GRUPADI2";
      columnExpression7.ColumnName = "GRUPADI";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table5.Name = "TBLARACGRUBU2";
      columnExpression7.Table = table5;
      column7.Expression = (ExpressionBase) columnExpression7;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.FilterString = "[TBLARACLAR.ARACTIPIID] = 1 And [TBLARACLAR.ARACDURUMID] = 1";
      selectQuery.GroupFilterString = "";
      columnExpression8.ColumnName = "PLAKA";
      columnExpression8.Table = table1;
      group1.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "MODEL";
      columnExpression9.Table = table1;
      group2.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "ARACACIKLAMA";
      columnExpression10.Table = table1;
      group3.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "BELDBIRIMADI";
      columnExpression11.Table = table2;
      group4.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "GRUPADI";
      columnExpression12.Table = table3;
      group5.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ARACMARKA";
      columnExpression13.Table = table4;
      group6.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "GRUPADI";
      columnExpression14.Table = table5;
      group7.Expression = (ExpressionBase) columnExpression14;
      selectQuery.Groups.Add(group1);
      selectQuery.Groups.Add(group2);
      selectQuery.Groups.Add(group3);
      selectQuery.Groups.Add(group4);
      selectQuery.Groups.Add(group5);
      selectQuery.Groups.Add(group6);
      selectQuery.Groups.Add(group7);
      selectQuery.Name = "TBLARACLAR";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACGRUBUID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BELDBIRIMID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MARKAID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "ARACGRUBU2ID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      columnExpression15.ColumnName = "GRUPADI";
      columnExpression15.Table = table3;
      sorting.Expression = (ExpressionBase) columnExpression15;
      selectQuery.Sorting.Add(sorting);
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
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.GroupCaption1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.GroupCaption1.BorderColor = Color.White;
      this.GroupCaption1.Borders = BorderSide.Bottom;
      this.GroupCaption1.BorderWidth = 2f;
      this.GroupCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupCaption1.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupCaption1.Name = "GroupCaption1";
      this.GroupCaption1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupData1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.GroupData1.BorderColor = Color.White;
      this.GroupData1.Borders = BorderSide.Bottom;
      this.GroupData1.BorderWidth = 2f;
      this.GroupData1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupData1.ForeColor = Color.FromArgb(64, 70, 80);
      this.GroupData1.Name = "GroupData1";
      this.GroupData1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailCaption1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.DetailCaption1.BorderColor = Color.White;
      this.DetailCaption1.Borders = BorderSide.Left;
      this.DetailCaption1.BorderWidth = 2f;
      this.DetailCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.DetailCaption1.ForeColor = Color.FromArgb(64, 70, 80);
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
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.HeightF = 67f;
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(6f, 6f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(313f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(331f, 6f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(313f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Sayfa {0} of {1}";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
      this.ReportHeader.HeightF = 33.95834f;
      this.ReportHeader.Name = "ReportHeader";
      this.label1.LocationFloat = new PointFloat(6f, 6f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(638f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.StylePriority.UseTextAlignment = false;
      this.label1.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ";
      this.label1.TextAlignment = TextAlignment.TopCenter;
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("ARACGRUBUID", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 25f;
      this.GroupHeader1.Level = 1;
      this.GroupHeader1.Name = "GroupHeader1";
      this.table1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(650f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell1,
        this.tableCell2
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.BorderColor = Color.Black;
      this.tableCell1.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.StylePriority.UseBorderColor = false;
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "Araç Cinsi";
      this.tableCell1.Weight = 0.14549186119666466;
      this.tableCell2.BorderColor = Color.Black;
      this.tableCell2.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GRUPADI]")
      });
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "GroupData1";
      this.tableCell2.StylePriority.UseBorderColor = false;
      this.tableCell2.StylePriority.UseBorders = false;
      this.tableCell2.StylePriority.UseTextAlignment = false;
      this.tableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell2.Weight = 0.85450815054086537;
      this.GroupHeader2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.GroupHeader2.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("GRUPADI", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader2.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader2.HeightF = 28f;
      this.GroupHeader2.Level = 2;
      this.GroupHeader2.Name = "GroupHeader2";
      this.GroupHeader2.RepeatEveryPage = true;
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(650f, 28f);
      this.tableRow2.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell1,
        this.tableCell3,
        this.tableCell4,
        this.tableCell5,
        this.tableCell6
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.xrTableCell1.BorderColor = Color.Black;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailCaption1";
      this.xrTableCell1.StylePriority.UseBorderColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Text = "S. No";
      this.xrTableCell1.Weight = 0.0836139226935586;
      this.tableCell3.BorderColor = Color.Black;
      this.tableCell3.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.StylePriority.UseBorderColor = false;
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.Text = "Plaka";
      this.tableCell3.Weight = 0.31842906483648947;
      this.tableCell4.BorderColor = Color.Black;
      this.tableCell4.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.StylePriority.UseBorderColor = false;
      this.tableCell4.StylePriority.UseBorders = false;
      this.tableCell4.Text = "Model";
      this.tableCell4.Weight = 0.20818345289963941;
      this.tableCell5.BorderColor = Color.Black;
      this.tableCell5.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.StylePriority.UseBorderColor = false;
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.StylePriority.UseTextAlignment = false;
      this.tableCell5.Text = "Marka";
      this.tableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell5.Weight = 0.25596480149489181;
      this.tableCell6.BorderColor = Color.Black;
      this.tableCell6.Borders = BorderSide.All;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseTextAlignment = false;
      this.tableCell6.Text = "BELDBIRIMID";
      this.tableCell6.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell6.Weight = 0.33483022836538462;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table3
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.table3.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table3.Name = "table3";
      this.table3.OddStyleName = "DetailData3_Odd";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(650f, 25f);
      this.tableRow3.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell2,
        this.tableCell7,
        this.tableCell8,
        this.tableCell9,
        this.tableCell10
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 11.5;
      this.xrTableCell2.BorderColor = Color.Black;
      this.xrTableCell2.Borders = BorderSide.Left | BorderSide.Bottom;
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
      this.xrTableCell2.Weight = 0.083613915645045819;
      this.tableCell7.BorderColor = Color.Black;
      this.tableCell7.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailData1";
      this.tableCell7.StylePriority.UseBorderColor = false;
      this.tableCell7.StylePriority.UseBorders = false;
      this.tableCell7.Weight = 0.31842907188500225;
      this.tableCell8.BorderColor = Color.Black;
      this.tableCell8.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MODEL]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.StylePriority.UseBorderColor = false;
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.Weight = 0.20818345289963941;
      this.tableCell9.BorderColor = Color.Black;
      this.tableCell9.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData1";
      this.tableCell9.StylePriority.UseBorderColor = false;
      this.tableCell9.StylePriority.UseBorders = false;
      this.tableCell9.StylePriority.UseTextAlignment = false;
      this.tableCell9.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell9.Weight = 0.25596480149489181;
      this.tableCell10.BorderColor = Color.Black;
      this.tableCell10.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData1";
      this.tableCell10.StylePriority.UseBorderColor = false;
      this.tableCell10.StylePriority.UseBorders = false;
      this.tableCell10.StylePriority.UseTextAlignment = false;
      this.tableCell10.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell10.Weight = 0.33483022836538462;
      this.label2.Borders = BorderSide.None;
      this.label2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.label2.Name = "label2";
      this.label2.SizeF = new SizeF(650f, 2.08f);
      this.label2.StyleName = "GroupFooterBackground3";
      this.label2.StylePriority.UseBorders = false;
      this.GroupFooter1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label2
      });
      this.GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter1.HeightF = 3.916677f;
      this.GroupFooter1.Level = 1;
      this.GroupFooter1.Name = "GroupFooter1";
      this.GroupFooter1.PageBreak = PageBreak.AfterBand;
      this.GroupHeader3.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.GroupHeader3.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("GRUPADI2", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader3.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader3.HeightF = 25.54165f;
      this.GroupHeader3.Name = "GroupHeader3";
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(650f, 25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell3.BorderColor = Color.Black;
      this.xrTableCell3.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StyleName = "GroupCaption1";
      this.xrTableCell3.StylePriority.UseBorderColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.Text = "Araç Cinsi";
      this.xrTableCell3.Weight = 0.14549186119666466;
      this.xrTableCell4.BorderColor = Color.Black;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GRUPADI2]")
      });
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StyleName = "GroupData1";
      this.xrTableCell4.StylePriority.UseBorderColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 0.85450815054086537;
      this.GroupFooter2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.GroupFooter2.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter2.HeightF = 4.166667f;
      this.GroupFooter2.Name = "GroupFooter2";
      this.xrLabel1.Borders = BorderSide.None;
      this.xrLabel1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.SizeF = new SizeF(650f, 2.08f);
      this.xrLabel1.StyleName = "GroupFooterBackground3";
      this.xrLabel1.StylePriority.UseBorders = false;
      this.Bands.AddRange(new Band[9]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.Detail,
        (Band) this.GroupFooter1,
        (Band) this.GroupHeader3,
        (Band) this.GroupFooter2
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLARACLAR";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(100, 100, 100, 67);
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
      this.table2.EndInit();
      this.table3.EndInit();
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
