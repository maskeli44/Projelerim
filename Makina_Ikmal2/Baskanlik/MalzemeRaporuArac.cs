// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Baskanlik.MalzemeRaporuArac
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;

namespace Makina_Ikmal.Baskanlik
{
  public class MalzemeRaporuArac : XtraReport
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
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
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
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
    private XRTableCell tableCell15;
    private XRTableCell tableCell16;
    private XRTableCell tableCell17;
    private XRTableCell tableCell18;
    private XRTableCell tableCell19;
    private XRTableCell tableCell20;
    private XRTableCell tableCell21;
    private XRTableCell tableCell22;
    private XRTableCell tableCell23;
    private XRTableCell tableCell24;

    public MalzemeRaporuArac() => this.InitializeComponent();

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
      Table table4 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table5 = new Table();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table6 = new Table();
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
      Sorting sorting = new Sorting();
      ColumnExpression columnExpression13 = new ColumnExpression();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MalzemeRaporuArac));
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
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.label1 = new XRLabel();
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
      this.tableCell10 = new XRTableCell();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell13 = new XRTableCell();
      this.tableCell14 = new XRTableCell();
      this.tableCell15 = new XRTableCell();
      this.tableCell16 = new XRTableCell();
      this.tableCell17 = new XRTableCell();
      this.tableCell18 = new XRTableCell();
      this.tableCell19 = new XRTableCell();
      this.tableCell20 = new XRTableCell();
      this.tableCell21 = new XRTableCell();
      this.tableCell22 = new XRTableCell();
      this.tableCell23 = new XRTableCell();
      this.tableCell24 = new XRTableCell();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "PLAKA";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table1.Name = "TBLARACLAR";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "KOD";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"585\" />";
      table2.Name = "TBLDEPOFIS";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "CIKISTARIH";
      table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table3.Name = "TBLISEMRI";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "MALZEMEADI";
      table4.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"685\" />";
      table4.Name = "TBLMALZEMELER";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "BIRIMADI";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table5.Name = "TBLMALZBIRIM";
      columnExpression5.Table = table5;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "MIKTAR";
      table6.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"505\" />";
      table6.Name = "TBLDEPOFISHRKT";
      columnExpression6.Table = table6;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "FIYAT";
      columnExpression7.Table = table6;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "TUTAR";
      columnExpression8.Table = table6;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "DEGISIMKMSI";
      columnExpression9.Table = table6;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "MALZSERINO";
      columnExpression10.Table = table6;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "ISLEMTIPIID";
      columnExpression11.Table = table2;
      column11.Expression = (ExpressionBase) columnExpression11;
      column12.Alias = "TBLISEMRI_KOD";
      columnExpression12.ColumnName = "KOD";
      columnExpression12.Table = table3;
      column12.Expression = (ExpressionBase) columnExpression12;
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
      selectQuery.Columns.Add((ColumnBase) column12);
      selectQuery.FilterString = "[TBLDEPOFIS.ISLEMTIPIID] = '3' And [TBLARACLAR.PLAKA] = '63b0457'";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLARACLAR_1";
      relationColumnInfo1.NestedKeyColumn = "ARACID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ISEMRIID";
      relationColumnInfo2.ParentKeyColumn = "ID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table3;
      relationColumnInfo3.NestedKeyColumn = "DEPOFISID";
      relationColumnInfo3.ParentKeyColumn = "ID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table6;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BIRIMID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table6;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "MALZEMEID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table4;
      join5.Parent = table6;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      columnExpression13.ColumnName = "CIKISTARIH";
      columnExpression13.Table = table3;
      sorting.Expression = (ExpressionBase) columnExpression13;
      selectQuery.Sorting.Add(sorting);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table4);
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
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
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
      this.pageInfo1.LocationFloat = new PointFloat(5f, 5f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(315f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(330f, 5f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(315f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.label1.LocationFloat = new PointFloat(5f, 5f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(640f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.Text = "Report Title";
      this.table1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(650f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[12]
      {
        this.tableCell1,
        this.tableCell2,
        this.tableCell3,
        this.tableCell4,
        this.tableCell5,
        this.tableCell6,
        this.tableCell7,
        this.tableCell8,
        this.tableCell9,
        this.tableCell10,
        this.tableCell11,
        this.tableCell12
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "PLAKA";
      this.tableCell1.Weight = 0.062616823636568508;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "KOD";
      this.tableCell2.Weight = 0.046241628206693211;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.Text = "CIKISTARIH";
      this.tableCell3.Weight = 0.09313631497896635;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "MALZEMEADI";
      this.tableCell4.Weight = 0.10578243549053486;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.Text = "BIRIMADI";
      this.tableCell5.Weight = 0.077500387338491586;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.Text = "MIKTAR";
      this.tableCell6.Weight = 0.068563707791841941;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.StylePriority.UseTextAlignment = false;
      this.tableCell7.Text = "FIYAT";
      this.tableCell7.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell7.Weight = 0.055171767014723559;
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailCaption1";
      this.tableCell8.StylePriority.UseTextAlignment = false;
      this.tableCell8.Text = "TUTAR";
      this.tableCell8.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell8.Weight = 0.061864471435546874;
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailCaption1";
      this.tableCell9.Text = "DEGISIMKMSI";
      this.tableCell9.Weight = 0.10654133723332332;
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailCaption1";
      this.tableCell10.Text = "MALZSERINO";
      this.tableCell10.Weight = 0.10504317063551682;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailCaption1";
      this.tableCell11.Text = "ISLEMTIPIID";
      this.tableCell11.Weight = 0.095373758169320907;
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailCaption1";
      this.tableCell12.Text = "TBLISEMRI KOD";
      this.tableCell12.Weight = 0.12216428316556491;
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(650f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[12]
      {
        this.tableCell13,
        this.tableCell14,
        this.tableCell15,
        this.tableCell16,
        this.tableCell17,
        this.tableCell18,
        this.tableCell19,
        this.tableCell20,
        this.tableCell21,
        this.tableCell22,
        this.tableCell23,
        this.tableCell24
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell13.Borders = BorderSide.None;
      this.tableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell13.Name = "tableCell13";
      this.tableCell13.StyleName = "DetailData1";
      this.tableCell13.StylePriority.UseBorders = false;
      this.tableCell13.Weight = 0.062616817767803479;
      this.tableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.tableCell14.Name = "tableCell14";
      this.tableCell14.StyleName = "DetailData1";
      this.tableCell14.Weight = 0.046241625272310696;
      this.tableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISTARIH]")
      });
      this.tableCell15.Name = "tableCell15";
      this.tableCell15.StyleName = "DetailData1";
      this.tableCell15.Weight = 0.093136309110201321;
      this.tableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell16.Name = "tableCell16";
      this.tableCell16.StyleName = "DetailData1";
      this.tableCell16.Weight = 0.10578242375300481;
      this.tableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell17.Name = "tableCell17";
      this.tableCell17.StyleName = "DetailData1";
      this.tableCell17.Weight = 0.077500381469726556;
      this.tableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell18.Name = "tableCell18";
      this.tableCell18.StyleName = "DetailData1";
      this.tableCell18.Weight = 0.068563701923076925;
      this.tableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[FIYAT]")
      });
      this.tableCell19.Name = "tableCell19";
      this.tableCell19.StyleName = "DetailData1";
      this.tableCell19.StylePriority.UseTextAlignment = false;
      this.tableCell19.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell19.TextFormatString = "{0:C2}";
      this.tableCell19.Weight = 0.055171761145958537;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TUTAR]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "DetailData1";
      this.tableCell20.StylePriority.UseTextAlignment = false;
      this.tableCell20.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell20.TextFormatString = "{0:C2}";
      this.tableCell20.Weight = 0.061864465566781851;
      this.tableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DEGISIMKMSI]")
      });
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "DetailData1";
      this.tableCell21.Weight = 0.10654132549579327;
      this.tableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZSERINO]")
      });
      this.tableCell22.Name = "tableCell22";
      this.tableCell22.StyleName = "DetailData1";
      this.tableCell22.Weight = 0.10504315889798678;
      this.tableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISLEMTIPIID]")
      });
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailData1";
      this.tableCell23.Weight = 0.095373752300555892;
      this.tableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLISEMRI_KOD]")
      });
      this.tableCell24.Name = "tableCell24";
      this.tableCell24.StyleName = "DetailData1";
      this.tableCell24.Weight = 0.122164306640625;
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
