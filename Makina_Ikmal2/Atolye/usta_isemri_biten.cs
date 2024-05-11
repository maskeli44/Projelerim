// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.usta_isemri_biten
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Atolye
{
  public class usta_isemri_biten : XtraReport
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
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private Parameter idemri2;
    private XRLabel xrLabel1;

    public usta_isemri_biten() => this.InitializeComponent();

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
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (usta_isemri_biten));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.xrLabel1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.idemri2 = new Parameter();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "BOLUMADI";
      table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table1.Name = "TBLATOLYEBOLUM";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "USTAADISOYADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"285\" />";
      table2.Name = "TBLATOLYEUSTALAR";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "GRUPADI";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLBAKIMGRUBU";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "YAPILANBAKIM";
      table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"345\" />";
      table4.Name = "TBLISEMRIBAKIMLAR";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "ISEMRIID";
      columnExpression5.Table = table4;
      column5.Expression = (ExpressionBase) columnExpression5;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Name = "TBLISEMRIBAKIMLAR_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ATOLYEID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table4;
      join1.Type = JoinType.LeftOuter;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "ATOLYEID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table1;
      join2.Parent = table4;
      join2.Type = JoinType.LeftOuter;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BAKIMGRUBUID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table3;
      join3.Parent = table4;
      join3.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table1);
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
      this.TopMargin.HeightF = 8.95834f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 1.458327f;
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.ReportHeader.HeightF = 25f;
      this.ReportHeader.Name = "ReportHeader";
      this.xrLabel1.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(1.589457E-05f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(767.9999f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "Yapılan Bakımlar";
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
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
      this.table1.SizeF = new SizeF(768f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[4]
      {
        this.tableCell1,
        this.tableCell2,
        this.tableCell3,
        this.tableCell4
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "BOLUMADI";
      this.tableCell1.Weight = 0.2144240140914917;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "USTAADISOYADI";
      this.tableCell2.Weight = 0.30807503064473468;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.Text = "GRUPADI";
      this.tableCell3.Weight = 0.18925104538599649;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "YAPILANBAKIM";
      this.tableCell4.Weight = 0.28824987014134723;
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
      this.table2.SizeF = new SizeF(768f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[4]
      {
        this.tableCell5,
        this.tableCell6,
        this.tableCell7,
        this.tableCell8
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell5.Borders = BorderSide.None;
      this.tableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BOLUMADI]")
      });
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailData1";
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.Weight = 0.2144240140914917;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[USTAADISOYADI]")
      });
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailData1";
      this.tableCell6.Weight = 0.30807505051294964;
      this.tableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GRUPADI]")
      });
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailData1";
      this.tableCell7.Weight = 0.18925104538599649;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[YAPILANBAKIM]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.Weight = 0.28824989000956219;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.idemri2.Description = "Parameter1";
      this.idemri2.Name = "idemri2";
      this.idemri2.Type = typeof (int);
      this.idemri2.ValueInfo = "0";
      this.idemri2.Visible = false;
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
      this.DataMember = "TBLISEMRIBAKIMLAR_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ISEMRIID] = ?idemri2";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(27, 32, 9, 1);
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5Rotated;
      this.Parameters.AddRange(new Parameter[1]
      {
        this.idemri2
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
