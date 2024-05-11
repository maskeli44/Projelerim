// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.PersonelResimliYazdirma
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.insankaynak
{
  public class PersonelResimliYazdirma : XtraReport
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
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private DetailBand Detail;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell8;
    private XRPictureBox pictureBox1;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private GroupFooterBand GroupFooter1;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell2;
    private XRSubreport xrSubreport1;
    private ReportFooterBand ReportFooter;
    private XRSubreport xrSubreport2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel1;

    public PersonelResimliYazdirma() => this.InitializeComponent();

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
      Table table4 = new Table();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table5 = new Table();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PersonelResimliYazdirma));
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
      this.tableCell3 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.tableCell8 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.pictureBox1 = new XRPictureBox();
      this.xrTableCell2 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrSubreport1 = new XRSubreport();
      this.ReportFooter = new ReportFooterBand();
      this.xrSubreport2 = new XRSubreport();
      this.xrLabel1 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.table3.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "RESIMPER";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table1.Name = "TBLPERSONEL";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "GOREVYERI";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "EGITIMDURUM";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table2.Name = "TBLPERSEGITIMDRM";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "UNVAN";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLPERSUNVAN";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "KURUMGOREV";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table4.Name = "TBLPERSKURUMGOREV";
      columnExpression5.Table = table4;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ADI";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table5.Name = "TBLPERSONELISTIHDAMDURUM";
      columnExpression6.Table = table5;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ADISOYADI";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "PERSDURUMID";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.Columns.Add((ColumnBase) column8);
      selectQuery.FilterString = "[TBLPERSONEL.PERSDURUMID] = 1";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLPERSONEL_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "EGITIMID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      join1.Type = JoinType.LeftOuter;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "UNVANID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "GOREVUNVANID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      join3.Type = JoinType.LeftOuter;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "PERSISTIHDAMIID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      join4.Type = JoinType.LeftOuter;
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
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.GroupCaption1.BackColor = Color.FromArgb(153, 212, 246);
      this.GroupCaption1.BorderColor = Color.White;
      this.GroupCaption1.Borders = BorderSide.Bottom;
      this.GroupCaption1.BorderWidth = 2f;
      this.GroupCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupCaption1.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupCaption1.Name = "GroupCaption1";
      this.GroupCaption1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupData1.BackColor = Color.FromArgb(153, 212, 246);
      this.GroupData1.BorderColor = Color.White;
      this.GroupData1.Borders = BorderSide.Bottom;
      this.GroupData1.BorderWidth = 2f;
      this.GroupData1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupData1.ForeColor = Color.FromArgb(64, 70, 80);
      this.GroupData1.Name = "GroupData1";
      this.GroupData1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailCaption1.BackColor = Color.FromArgb(153, 212, 246);
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
      this.TopMargin.Controls.AddRange(new XRControl[6]
      {
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel1
      });
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.HeightF = 165.6667f;
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(0.0f, 142.6667f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(415.5f, 142.6667f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("KURUMGOREV", XRColumnSortOrder.Ascending)
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
      this.table1.SizeF = new SizeF(728.9999f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell1,
        this.tableCell2
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.Text = "KURUMGOREV";
      this.tableCell1.Weight = 0.14677772339451256;
      this.tableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KURUMGOREV]")
      });
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "GroupData1";
      this.tableCell2.Weight = 1.0159015485076988;
      this.GroupHeader2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.GroupHeader2.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader2.HeightF = 28f;
      this.GroupHeader2.Level = 2;
      this.GroupHeader2.Name = "GroupHeader2";
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(729f, 28f);
      this.tableRow2.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell4,
        this.tableCell3,
        this.xrTableCell1,
        this.tableCell4,
        this.tableCell5,
        this.tableCell6,
        this.tableCell7
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.None;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StyleName = "DetailCaption1";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.Text = "S.No";
      this.xrTableCell4.Weight = 0.18046406697427511;
      this.tableCell3.Borders = BorderSide.None;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.Text = "RESIMPER";
      this.tableCell3.Weight = 0.3048621039785524;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailCaption1";
      this.xrTableCell1.Text = "Adı Soyadı";
      this.xrTableCell1.Weight = 0.311395336347949;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "GOREVYERI";
      this.tableCell4.Weight = 0.26970278299266004;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.Text = "EGITIMDURUM";
      this.tableCell5.Weight = 0.25476879667672819;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.Text = "UNVAN";
      this.tableCell6.Weight = 0.24970140193268567;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.Text = "ADI";
      this.tableCell7.Weight = 0.25555209095370912;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table3
      });
      this.Detail.HeightF = 82.5f;
      this.Detail.Name = "Detail";
      this.table3.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table3.Name = "table3";
      this.table3.OddStyleName = "DetailData3_Odd";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(729f, 82.5f);
      this.table3.StylePriority.UseTextAlignment = false;
      this.table3.TextAlignment = TextAlignment.MiddleLeft;
      this.tableRow3.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell8,
        this.xrTableCell3,
        this.xrTableCell2,
        this.tableCell9,
        this.tableCell10,
        this.tableCell11,
        this.tableCell12
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 11.5;
      this.tableCell8.Borders = BorderSide.None;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Group;
      this.tableCell8.Summary = xrSummary;
      this.tableCell8.Weight = 0.17027623870688555;
      this.xrTableCell3.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.pictureBox1
      });
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StyleName = "DetailData1";
      this.xrTableCell3.Text = "xrTableCell3";
      this.xrTableCell3.Weight = 0.28765150773886305;
      this.pictureBox1.AnchorHorizontal = HorizontalAnchorStyles.Both;
      this.pictureBox1.AnchorVertical = VerticalAnchorStyles.Both;
      this.pictureBox1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "ImageSource", "[RESIMPER]")
      });
      this.pictureBox1.LocationFloat = new PointFloat(0.3104782f, 0.0f);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.SizeF = new SizeF(111.4087f, 82.5f);
      this.pictureBox1.Sizing = ImageSizeMode.ZoomImage;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 0.29381610778907763;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GOREVYERI]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData1";
      this.tableCell9.Weight = 0.25447715805026361;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[EGITIMDURUM]")
      });
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData1";
      this.tableCell10.Weight = 0.24038619903504949;
      this.tableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailData1";
      this.tableCell11.Weight = 0.2356047407921551;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailData1";
      this.tableCell12.Weight = 0.24112540225539991;
      this.GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter1.HeightF = 6f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 63.49996f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ReportSource = (XtraReport) new AltRaporistihdam();
      this.xrSubreport1.SizeF = new SizeF(728.9998f, 94.6667f);
      this.ReportFooter.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrSubreport2,
        (XRControl) this.xrSubreport1
      });
      this.ReportFooter.HeightF = 286.8333f;
      this.ReportFooter.Name = "ReportFooter";
      this.xrSubreport2.LocationFloat = new PointFloat(0.0f, 188.1667f);
      this.xrSubreport2.Name = "xrSubreport2";
      this.xrSubreport2.ReportSource = (XtraReport) new altRaporGorevyeri();
      this.xrSubreport2.SizeF = new SizeF(728.9998f, 98.66669f);
      this.xrLabel1.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(100f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(527f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "T.C.";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(627f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel2.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(100f, 23.00001f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(526.9999f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel3.Font = new Font("Arial", 11f);
      this.xrLabel3.LocationFloat = new PointFloat(100f, 46.00001f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(526.9999f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel4.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(100.0001f, 69.00001f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(526.9999f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "MAKİNA İKMAL ŞUBE MÜDÜRLÜĞÜ PERSONEL LİSTESİ";
      this.xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
      this.Bands.AddRange(new Band[7]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.Detail,
        (Band) this.GroupFooter1,
        (Band) this.ReportFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLPERSONEL_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(57, 41, 100, 166);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
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
