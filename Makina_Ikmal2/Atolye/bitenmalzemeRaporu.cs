// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.bitenmalzemeRaporu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Atolye
{
  public class bitenmalzemeRaporu : XtraReport
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
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
    private XRTableCell tableCell15;
    private XRTableCell tableCell16;
    private XRTableCell tableCell17;
    private XRTableCell tableCell18;
    private XRTableCell tableCell19;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private XRLabel xrLabel1;
    private Parameter idemir1;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel2;

    public bitenmalzemeRaporu() => this.InitializeComponent();

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
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Table table5 = new Table();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (bitenmalzemeRaporu));
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
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.tableCell13 = new XRTableCell();
      this.tableCell14 = new XRTableCell();
      this.tableCell15 = new XRTableCell();
      this.tableCell16 = new XRTableCell();
      this.tableCell17 = new XRTableCell();
      this.tableCell18 = new XRTableCell();
      this.tableCell19 = new XRTableCell();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.idemir1 = new Parameter();
      this.ReportHeader = new ReportHeaderBand();
      this.xrLabel2 = new XRLabel();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "KOD";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"585\" />";
      table1.Name = "TBLDEPOFIS";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "TARIH";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "MALZEMEADI";
      table2.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table2.Name = "TBLMALZEMELER";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "BIRIMADI";
      table3.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLMALZBIRIM";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "MIKTAR";
      table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"505\" />";
      table4.Name = "TBLDEPOFISHRKT";
      columnExpression5.Table = table4;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "FIYAT";
      columnExpression6.Table = table4;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "TUTAR";
      columnExpression7.Table = table4;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "DEGISIMKMSI";
      columnExpression8.Table = table4;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "MALZSERINO";
      columnExpression9.Table = table4;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "ISLEMTIPIID";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "ISEMRIID";
      columnExpression11.Table = table1;
      column11.Expression = (ExpressionBase) columnExpression11;
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
      selectQuery.Columns.Add((ColumnBase) column11);
      selectQuery.FilterString = "[TBLDEPOFIS.ISLEMTIPIID] = '3'";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLDEPOFISHRKT_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "DEPOFISID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table1;
      join1.Parent = table4;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "ISEMRIID";
      join2.KeyColumns.Add(relationColumnInfo2);
      table5.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table5.Name = "TBLISEMRI";
      join2.Nested = table5;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "MALZEMEID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table2;
      join3.Parent = table4;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BIRIMID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table3;
      join4.Parent = table2;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table5);
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
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.DetailCaption1.BackColor = Color.FromArgb(69, 94, 178);
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
      this.TopMargin.HeightF = 4f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.BottomMargin.HeightF = 32f;
      this.BottomMargin.Name = "BottomMargin";
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([TUTAR])")
      });
      this.xrLabel1.LocationFloat = new PointFloat(516.5f, 5f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(100f, 23f);
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel1.Summary = xrSummary;
      this.xrLabel1.Text = "xrLabel1";
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
      this.table1.SizeF = new SizeF(764f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[9]
      {
        this.tableCell1,
        this.tableCell2,
        this.tableCell3,
        this.tableCell4,
        this.tableCell5,
        this.tableCell6,
        this.tableCell7,
        this.tableCell8,
        this.tableCell9
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "Kod";
      this.tableCell1.Weight = 0.094045480092366546;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "Tarih";
      this.tableCell2.Weight = 0.098598370949427278;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.Text = "Malzeme Adı";
      this.tableCell3.Weight = 0.23933222742259425;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "Birim";
      this.tableCell4.Weight = 0.08097899911341401;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.StylePriority.UseTextAlignment = false;
      this.tableCell5.Text = "Miktar";
      this.tableCell5.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell5.Weight = 0.11128906598769378;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.StylePriority.UseTextAlignment = false;
      this.tableCell6.Text = "Fiyat";
      this.tableCell6.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell6.Weight = 0.075120210647583022;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.StylePriority.UseTextAlignment = false;
      this.tableCell7.Text = "Tutar";
      this.tableCell7.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell7.Weight = 0.072855234146118164;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailCaption1";
      this.tableCell8.Text = "Değişim Km";
      this.tableCell8.Weight = 0.12170163790384926;
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailCaption1";
      this.tableCell9.Text = "Seri No";
      this.tableCell9.Weight = 0.10087051775046664;
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
      this.table2.SizeF = new SizeF(764f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[9]
      {
        this.tableCell11,
        this.tableCell12,
        this.tableCell13,
        this.tableCell14,
        this.tableCell15,
        this.tableCell16,
        this.tableCell17,
        this.tableCell18,
        this.tableCell19
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell11.Borders = BorderSide.None;
      this.tableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailData1";
      this.tableCell11.StylePriority.UseBorders = false;
      this.tableCell11.Weight = 0.094045468389659728;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailData1";
      this.tableCell12.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell12.Weight = 0.098598414381725508;
      this.tableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell13.Name = "tableCell13";
      this.tableCell13.StyleName = "DetailData1";
      this.tableCell13.Weight = 0.25832096111098818;
      this.tableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell14.Name = "tableCell14";
      this.tableCell14.StyleName = "DetailData1";
      this.tableCell14.Weight = 0.086404314306995272;
      this.tableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell15.Name = "tableCell15";
      this.tableCell15.StyleName = "DetailData1";
      this.tableCell15.StylePriority.UseTextAlignment = false;
      this.tableCell15.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell15.TextFormatString = "{0:C2}";
      this.tableCell15.Weight = 0.086874961908306417;
      this.tableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[FIYAT]")
      });
      this.tableCell16.Name = "tableCell16";
      this.tableCell16.StyleName = "DetailData1";
      this.tableCell16.StylePriority.UseTextAlignment = false;
      this.tableCell16.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell16.TextFormatString = "{0:C2}";
      this.tableCell16.Weight = 0.0751201259865887;
      this.tableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TUTAR]")
      });
      this.tableCell17.Name = "tableCell17";
      this.tableCell17.StyleName = "DetailData1";
      this.tableCell17.StylePriority.UseTextAlignment = false;
      this.tableCell17.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell17.TextFormatString = "{0:C2}";
      this.tableCell17.Weight = 0.0728553089835399;
      this.tableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DEGISIMKMSI]")
      });
      this.tableCell18.Name = "tableCell18";
      this.tableCell18.StyleName = "DetailData1";
      this.tableCell18.Weight = 0.12170162873275968;
      this.tableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZSERINO]")
      });
      this.tableCell19.Name = "tableCell19";
      this.tableCell19.StyleName = "DetailData1";
      this.tableCell19.Weight = 0.10087050954252637;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.idemir1.Description = "Parameter1";
      this.idemir1.Name = "idemir1";
      this.idemir1.Type = typeof (int);
      this.idemir1.ValueInfo = "0";
      this.idemir1.Visible = false;
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel2
      });
      this.ReportHeader.HeightF = 27.87501f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrLabel2.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(784.9999f, 25.08334f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "Kullanılan Malzemeler";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.GroupHeader1,
        (Band) this.Detail,
        (Band) this.ReportHeader
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLDEPOFISHRKT_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ISEMRIID] = ?idemir1";
      this.Font = new Font("Arial", 11f);
      this.Margins = new Margins(21, 39, 4, 32);
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5Rotated;
      this.Parameters.AddRange(new Parameter[1]
      {
        this.idemir1
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
