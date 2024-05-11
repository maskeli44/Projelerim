// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.BaskanliginaGore
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

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class BaskanliginaGore : XtraReport
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
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private GroupHeaderBand GroupHeader2;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell3;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private DetailBand Detail;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell1;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private GroupFooterBand GroupFooter1;
    private XRLabel label2;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private Parameter id;

    public BaskanliginaGore() => this.InitializeComponent();

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
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table6 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      QueryParameter queryParameter = new QueryParameter();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BaskanliginaGore));
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
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.GroupHeader2 = new GroupHeaderBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.tableCell11 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.label2 = new XRLabel();
      this.id = new Parameter();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.table3.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1523\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "MODEL";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "RENGI";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "BELDBIRIMADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table2.Name = "TBLBELDBIRIMLER";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "ARACMARKA";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table3.Name = "TBLARACMARKA";
      columnExpression5.Table = table3;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ADISOYADI";
      table4.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression6.Table = table4;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "UNVAN";
      table5.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table5.Name = "TBLPERSUNVAN";
      columnExpression7.Table = table5;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "BELDMUDURLUK";
      table6.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"283\" />";
      table6.Name = "TBLBELDMUDURLUK";
      columnExpression8.Table = table6;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "CEPTELEFON";
      columnExpression9.Table = table4;
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
      selectQuery.FilterString = "[TBLARACLAR.ARACTIPIID] = 2 And [TBLARACLAR.ARACDURUMID] = 1 And [TBLARACLAR.ARACIHALEGRUPID] = ?id";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLARACLAR";
      queryParameter.Name = "id";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?id", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "BELDBIRIMID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MARKAID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BELDMUDURLUKID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table6;
      join3.Parent = table1;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "ARACKULPERSID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table4;
      join4.Parent = table1;
      join4.Type = JoinType.LeftOuter;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "UNVANID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table5;
      join5.Parent = table4;
      join5.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table6);
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
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(6f, 6f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(438f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(456f, 6f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(438f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Sayfa {0} of {1}";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("BELDBIRIMADI", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 27f;
      this.GroupHeader1.Level = 1;
      this.GroupHeader1.Name = "GroupHeader1";
      this.table1.LocationFloat = new PointFloat(0.0f, 2f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(900f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell1,
        this.tableCell2
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.BorderColor = Color.Black;
      this.tableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "")
      });
      this.tableCell1.ForeColor = Color.Black;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.StylePriority.UseBorderColor = false;
      this.tableCell1.StylePriority.UseForeColor = false;
      this.tableCell1.Weight = 0.055045869931539829;
      this.tableCell2.BorderColor = Color.Black;
      this.tableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "GroupData1";
      this.tableCell2.StylePriority.UseBorderColor = false;
      this.tableCell2.Weight = 0.94495412159135517;
      this.GroupHeader2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.GroupHeader2.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader2.HeightF = 28f;
      this.GroupHeader2.Name = "GroupHeader2";
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(900f, 28f);
      this.tableRow2.Cells.AddRange(new XRTableCell[9]
      {
        this.xrTableCell4,
        this.xrTableCell3,
        this.tableCell3,
        this.tableCell6,
        this.tableCell5,
        this.tableCell4,
        this.tableCell7,
        this.xrTableCell5,
        this.xrTableCell6
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.xrTableCell4.BorderColor = Color.Black;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StyleName = "DetailCaption1";
      this.xrTableCell4.StylePriority.UseBorderColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.Text = " ";
      this.xrTableCell4.Weight = 0.1089498452787046;
      this.xrTableCell3.BorderColor = Color.Black;
      this.xrTableCell3.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StyleName = "DetailCaption1";
      this.xrTableCell3.StylePriority.UseBorderColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "BİRİMİ";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 0.2051636529851843;
      this.tableCell3.BorderColor = Color.Black;
      this.tableCell3.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.StylePriority.UseBorderColor = false;
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.StylePriority.UseTextAlignment = false;
      this.tableCell3.Text = "PLAKA";
      this.tableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell3.Weight = 0.15705674913194445;
      this.tableCell6.BorderColor = Color.Black;
      this.tableCell6.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.StylePriority.UseBorderColor = false;
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.StylePriority.UseTextAlignment = false;
      this.tableCell6.Text = "RENGİ";
      this.tableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell6.Weight = 0.1477362569173177;
      this.tableCell5.BorderColor = Color.Black;
      this.tableCell5.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.StylePriority.UseBorderColor = false;
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.StylePriority.UseTextAlignment = false;
      this.tableCell5.Text = "MARKA";
      this.tableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell5.Weight = 0.19998360527886286;
      this.tableCell4.BorderColor = Color.Black;
      this.tableCell4.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.StylePriority.UseBorderColor = false;
      this.tableCell4.StylePriority.UseBorders = false;
      this.tableCell4.StylePriority.UseTextAlignment = false;
      this.tableCell4.Text = "MODEL";
      this.tableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell4.Weight = 0.16265235053168403;
      this.tableCell7.BorderColor = Color.Black;
      this.tableCell7.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.StylePriority.UseBorderColor = false;
      this.tableCell7.StylePriority.UseBorders = false;
      this.tableCell7.StylePriority.UseTextAlignment = false;
      this.tableCell7.Text = "KULLANAN PERSONEL";
      this.tableCell7.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell7.Weight = 0.33257100423177083;
      this.xrTableCell5.BorderColor = Color.Black;
      this.xrTableCell5.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StyleName = "DetailCaption1";
      this.xrTableCell5.StylePriority.UseBorderColor = false;
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "ÜNVANI";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.33257100423177083;
      this.xrTableCell6.BorderColor = Color.Black;
      this.xrTableCell6.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StyleName = "DetailCaption1";
      this.xrTableCell6.StylePriority.UseBorderColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "TELEFON";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.33257100423177083;
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
      this.table3.SizeF = new SizeF(900f, 25f);
      this.tableRow3.Cells.AddRange(new XRTableCell[9]
      {
        this.xrTableCell2,
        this.xrTableCell1,
        this.tableCell8,
        this.tableCell11,
        this.tableCell10,
        this.tableCell9,
        this.tableCell12,
        this.xrTableCell7,
        this.xrTableCell8
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
      this.xrTableCell2.Weight = 0.1089498452787046;
      this.xrTableCell1.BorderColor = Color.Black;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDMUDURLUK]")
      });
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailData1";
      this.xrTableCell1.StylePriority.UseBorderColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Weight = 0.2051636529851843;
      this.tableCell8.BorderColor = Color.Black;
      this.tableCell8.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.StylePriority.UseBorderColor = false;
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.StylePriority.UseTextAlignment = false;
      this.tableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell8.Weight = 0.15705674913194445;
      this.tableCell11.BorderColor = Color.Black;
      this.tableCell11.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[RENGI]")
      });
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailData1";
      this.tableCell11.StylePriority.UseBorderColor = false;
      this.tableCell11.StylePriority.UseBorders = false;
      this.tableCell11.StylePriority.UseTextAlignment = false;
      this.tableCell11.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell11.Weight = 0.1477362569173177;
      this.tableCell10.BorderColor = Color.Black;
      this.tableCell10.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACMARKA]")
      });
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData1";
      this.tableCell10.StylePriority.UseBorderColor = false;
      this.tableCell10.StylePriority.UseBorders = false;
      this.tableCell10.StylePriority.UseTextAlignment = false;
      this.tableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell10.Weight = 0.19998360527886286;
      this.tableCell9.BorderColor = Color.Black;
      this.tableCell9.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MODEL]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData1";
      this.tableCell9.StylePriority.UseBorderColor = false;
      this.tableCell9.StylePriority.UseBorders = false;
      this.tableCell9.StylePriority.UseTextAlignment = false;
      this.tableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell9.Weight = 0.16265235053168403;
      this.tableCell12.BorderColor = Color.Black;
      this.tableCell12.Borders = BorderSide.Left | BorderSide.Bottom;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailData1";
      this.tableCell12.StylePriority.UseBorderColor = false;
      this.tableCell12.StylePriority.UseBorders = false;
      this.tableCell12.StylePriority.UseTextAlignment = false;
      this.tableCell12.TextAlignment = TextAlignment.MiddleCenter;
      this.tableCell12.Weight = 0.33257100423177083;
      this.xrTableCell7.BorderColor = Color.Black;
      this.xrTableCell7.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StyleName = "DetailData1";
      this.xrTableCell7.StylePriority.UseBorderColor = false;
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "xrTableCell7";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 0.33257100423177083;
      this.xrTableCell8.BorderColor = Color.Black;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CEPTELEFON]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StyleName = "DetailData1";
      this.xrTableCell8.StylePriority.UseBorderColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 0.33257100423177083;
      this.GroupFooter1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label2
      });
      this.GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter1.HeightF = 6f;
      this.GroupFooter1.Level = 1;
      this.GroupFooter1.Name = "GroupFooter1";
      this.label2.Borders = BorderSide.None;
      this.label2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.label2.Name = "label2";
      this.label2.SizeF = new SizeF(900f, 2.08f);
      this.label2.StyleName = "GroupFooterBackground3";
      this.label2.StylePriority.UseBorders = false;
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[6]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.Detail,
        (Band) this.GroupFooter1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLARACLAR";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.PageHeight = 850;
      this.PageWidth = 1100;
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
      this.table2.EndInit();
      this.table3.EndInit();
      this.EndInit();
    }
  }
}
