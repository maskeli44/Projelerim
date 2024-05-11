// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.AracIcmalPivot
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class AracIcmalPivot : XtraReport
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
    private XRPivotGrid xrPivotGrid1;
    private XRPivotGridField fieldGRUPADI1;
    private XRPivotGridField fieldBELDBIRIMADI1;
    private XRPivotGridField fieldAdet1;
    private DetailBand Detail;

    public AracIcmalPivot() => this.InitializeComponent();

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
      Group group1 = new Group();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Group group2 = new Group();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Group group3 = new Group();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Group group4 = new Group();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracIcmalPivot));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.Detail = new DetailBand();
      this.xrPivotGrid1 = new XRPivotGrid();
      this.fieldGRUPADI1 = new XRPivotGridField();
      this.fieldBELDBIRIMADI1 = new XRPivotGridField();
      this.fieldAdet1 = new XRPivotGridField();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "GRUPADI";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table1.Name = "TBLARACGRUBU2";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "BELDBIRIMADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table2.Name = "TBLBELDBIRIMLER";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      column3.Alias = "Adet";
      columnExpression3.Aggregate = AggregationType.Count;
      columnExpression3.ColumnName = "ARACGRUBU2ID";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1505\" />";
      table3.Name = "TBLARACLAR";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.FilterString = "";
      selectQuery.GroupFilterString = "[ARACDURUMID] = 1 And [ARACTIPIID] = 1";
      columnExpression4.ColumnName = "BELDBIRIMADI";
      columnExpression4.Table = table2;
      group1.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "GRUPADI";
      columnExpression5.Table = table1;
      group2.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ARACDURUMID";
      columnExpression6.Table = table3;
      group3.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ARACTIPIID";
      columnExpression7.Table = table3;
      group4.Expression = (ExpressionBase) columnExpression7;
      selectQuery.Groups.Add(group1);
      selectQuery.Groups.Add(group2);
      selectQuery.Groups.Add(group3);
      selectQuery.Groups.Add(group4);
      selectQuery.Name = "TBLARACLAR_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACGRUBU2ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table1;
      join1.Parent = table3;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BELDBIRIMID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table3;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Tables.Add(table3);
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
      this.TopMargin.HeightF = 3f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 5f;
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrPivotGrid1
      });
      this.ReportHeader.HeightF = 60f;
      this.ReportHeader.Name = "ReportHeader";
      this.Detail.HeightF = 60f;
      this.Detail.Name = "Detail";
      this.xrPivotGrid1.Appearance.Cell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldHeader.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValue.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.Lines.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.TotalCell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.DataMember = "TBLARACLAR_1";
      this.xrPivotGrid1.DataSource = (object) this.sqlDataSource1;
      this.xrPivotGrid1.Fields.AddRange(new XRPivotGridField[3]
      {
        this.fieldGRUPADI1,
        this.fieldBELDBIRIMADI1,
        this.fieldAdet1
      });
      this.xrPivotGrid1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPivotGrid1.Name = "xrPivotGrid1";
      this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False;
      this.xrPivotGrid1.SizeF = new SizeF(1136f, 38.33333f);
      this.fieldGRUPADI1.Area = PivotArea.RowArea;
      this.fieldGRUPADI1.AreaIndex = 0;
      this.fieldGRUPADI1.Caption = "Cinsi";
      this.fieldGRUPADI1.FieldName = "GRUPADI";
      this.fieldGRUPADI1.GrandTotalText = "Toplam";
      this.fieldGRUPADI1.Name = "fieldGRUPADI1";
      this.fieldBELDBIRIMADI1.Area = PivotArea.ColumnArea;
      this.fieldBELDBIRIMADI1.AreaIndex = 0;
      this.fieldBELDBIRIMADI1.Caption = "Birimler";
      this.fieldBELDBIRIMADI1.FieldName = "BELDBIRIMADI";
      this.fieldBELDBIRIMADI1.Name = "fieldBELDBIRIMADI1";
      this.fieldBELDBIRIMADI1.Width = 56;
      this.fieldAdet1.Area = PivotArea.DataArea;
      this.fieldAdet1.AreaIndex = 0;
      this.fieldAdet1.Caption = "Adet";
      this.fieldAdet1.FieldName = "Adet";
      this.fieldAdet1.GrandTotalText = "Toplam";
      this.fieldAdet1.Name = "fieldAdet1";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLARACLAR_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.Margins = new Margins(17, 16, 3, 5);
      this.PageHeight = 827;
      this.PageWidth = 1169;
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
      this.EndInit();
    }
  }
}
