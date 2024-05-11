// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.KamyonIsMakinesiKiralik
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
using DevExpress.XtraReports.UI.CrossTab;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class KamyonIsMakinesiKiralik : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle crossTabGeneralStyle;
    private XRControlStyle crossTabDataStyle;
    private XRControlStyle crossTabHeaderStyle;
    private XRControlStyle crossTabTotalStyle;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private DetailBand Detail;
    private XRCrossTab crossTab1;
    private XRCrossTabCell xrCrossTabCell1;
    private XRCrossTabCell xrCrossTabCell2;
    private XRCrossTabCell xrCrossTabCell3;
    private XRCrossTabCell xrCrossTabCell4;
    private XRCrossTabCell xrCrossTabCell5;
    private XRCrossTabCell xrCrossTabCell6;
    private XRCrossTabCell xrCrossTabCell7;
    private XRCrossTabCell xrCrossTabCell8;
    private XRCrossTabCell xrCrossTabCell9;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRControlStyle TitleStyle;
    private Parameter id;

    public KamyonIsMakinesiKiralik() => this.InitializeComponent();

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
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KamyonIsMakinesiKiralik));
      CrossTabColumnDefinition columnDefinition1 = new CrossTabColumnDefinition(100f);
      CrossTabColumnDefinition columnDefinition2 = new CrossTabColumnDefinition(100f);
      CrossTabColumnField crossTabColumnField = new CrossTabColumnField();
      CrossTabDataField crossTabDataField = new CrossTabDataField();
      CrossTabRowField crossTabRowField = new CrossTabRowField();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.crossTabGeneralStyle = new XRControlStyle();
      this.crossTabDataStyle = new XRControlStyle();
      this.crossTabHeaderStyle = new XRControlStyle();
      this.crossTabTotalStyle = new XRControlStyle();
      this.ReportHeader = new ReportHeaderBand();
      this.label1 = new XRLabel();
      this.Detail = new DetailBand();
      this.crossTab1 = new XRCrossTab();
      this.xrCrossTabCell1 = new XRCrossTabCell();
      this.xrCrossTabCell2 = new XRCrossTabCell();
      this.xrCrossTabCell3 = new XRCrossTabCell();
      this.xrCrossTabCell4 = new XRCrossTabCell();
      this.xrCrossTabCell5 = new XRCrossTabCell();
      this.xrCrossTabCell6 = new XRCrossTabCell();
      this.xrCrossTabCell7 = new XRCrossTabCell();
      this.xrCrossTabCell8 = new XRCrossTabCell();
      this.xrCrossTabCell9 = new XRCrossTabCell();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.TitleStyle = new XRControlStyle();
      this.id = new Parameter();
      this.crossTab1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "BELDBIRIMADI";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table1.Name = "TBLBELDBIRIMLER";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "GRUPADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table2.Name = "TBLARACGRUBU2";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACIHALEGRUPID";
      table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1563\" />";
      table3.Name = "TBLARACLAR";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "IHALEADI";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table4.Name = "TBLARACIHALEGRUP";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.FilterString = "[TBLARACLAR.ARACTIPIID] = 2 And [TBLARACLAR.ARACDURUMID] = 1 And [TBLARACLAR.ARACIHALEGRUPID] = ?id";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLARACLAR";
      queryParameter.Name = "id";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?id", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACGRUBU2ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table3;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BELDBIRIMID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table1;
      join2.Parent = table3;
      join2.Type = JoinType.LeftOuter;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "ARACIHALEGRUPID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table3;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table4);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.crossTabGeneralStyle.BorderColor = Color.FromArgb(230, 232, 234);
      this.crossTabGeneralStyle.Borders = BorderSide.All;
      this.crossTabGeneralStyle.BorderWidth = 1f;
      this.crossTabGeneralStyle.Font = new Font("Arial", 9.75f);
      this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
      this.crossTabGeneralStyle.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.crossTabDataStyle.Name = "crossTabDataStyle";
      this.crossTabDataStyle.TextAlignment = TextAlignment.MiddleRight;
      this.crossTabHeaderStyle.BackColor = Color.FromArgb(250, 251, 252);
      this.crossTabHeaderStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
      this.crossTabHeaderStyle.TextAlignment = TextAlignment.MiddleLeft;
      this.crossTabTotalStyle.BackColor = Color.FromArgb(250, 250, 250);
      this.crossTabTotalStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.crossTabTotalStyle.Name = "crossTabTotalStyle";
      this.crossTabTotalStyle.TextAlignment = TextAlignment.MiddleRight;
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
      this.ReportHeader.HeightF = 39.37499f;
      this.ReportHeader.Name = "ReportHeader";
      this.label1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACLAR].[IHALEADI]+' KİRALIK ARAÇ LİSTESİ'")
      });
      this.label1.LocationFloat = new PointFloat(6.00001f, 5.999994f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(996.0001f, 30.01301f);
      this.label1.StyleName = "TitleStyle";
      this.label1.StylePriority.UseTextAlignment = false;
      this.label1.TextAlignment = TextAlignment.TopCenter;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.crossTab1
      });
      this.Detail.HeightF = 79.79177f;
      this.Detail.Name = "Detail";
      this.crossTab1.Cells.AddRange(new XRControl[9]
      {
        (XRControl) this.xrCrossTabCell1,
        (XRControl) this.xrCrossTabCell2,
        (XRControl) this.xrCrossTabCell3,
        (XRControl) this.xrCrossTabCell4,
        (XRControl) this.xrCrossTabCell5,
        (XRControl) this.xrCrossTabCell6,
        (XRControl) this.xrCrossTabCell7,
        (XRControl) this.xrCrossTabCell8,
        (XRControl) this.xrCrossTabCell9
      });
      columnDefinition1.AutoWidthMode = AutoSizeMode.ShrinkAndGrow;
      columnDefinition2.AutoWidthMode = AutoSizeMode.ShrinkAndGrow;
      this.crossTab1.ColumnDefinitions.AddRange(new CrossTabColumnDefinition[3]
      {
        columnDefinition1,
        columnDefinition2,
        new CrossTabColumnDefinition(112.5f)
      });
      crossTabColumnField.FieldName = "GRUPADI";
      this.crossTab1.ColumnFields.AddRange(new CrossTabColumnField[1]
      {
        crossTabColumnField
      });
      this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
      crossTabDataField.FieldName = "GRUPADI";
      crossTabDataField.SummaryType = SummaryType.Count;
      this.crossTab1.DataFields.AddRange(new CrossTabDataField[1]
      {
        crossTabDataField
      });
      this.crossTab1.DataMember = "TBLARACLAR";
      this.crossTab1.DataSource = (object) this.sqlDataSource1;
      this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
      this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
      this.crossTab1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.crossTab1.Name = "crossTab1";
      this.crossTab1.RowDefinitions.AddRange(new CrossTabRowDefinition[3]
      {
        new CrossTabRowDefinition(25f),
        new CrossTabRowDefinition(25f),
        new CrossTabRowDefinition(25f)
      });
      crossTabRowField.FieldName = "BELDBIRIMADI";
      this.crossTab1.RowFields.AddRange(new CrossTabRowField[1]
      {
        crossTabRowField
      });
      this.crossTab1.SizeF = new SizeF(312.5f, 75f);
      this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
      this.xrCrossTabCell1.ColumnIndex = 0;
      this.xrCrossTabCell1.Name = "xrCrossTabCell1";
      this.xrCrossTabCell1.RowIndex = 0;
      this.xrCrossTabCell1.Text = "BELEDİYE BİRİMLER";
      this.xrCrossTabCell2.ColumnIndex = 1;
      this.xrCrossTabCell2.Name = "xrCrossTabCell2";
      this.xrCrossTabCell2.RowIndex = 1;
      this.xrCrossTabCell3.ColumnIndex = 1;
      this.xrCrossTabCell3.Name = "xrCrossTabCell3";
      this.xrCrossTabCell3.RowIndex = 0;
      this.xrCrossTabCell4.ColumnIndex = 2;
      this.xrCrossTabCell4.Name = "xrCrossTabCell4";
      this.xrCrossTabCell4.RowIndex = 0;
      this.xrCrossTabCell4.Text = "Genel Toplam";
      this.xrCrossTabCell5.ColumnIndex = 2;
      this.xrCrossTabCell5.Name = "xrCrossTabCell5";
      this.xrCrossTabCell5.RowIndex = 1;
      this.xrCrossTabCell6.ColumnIndex = 0;
      this.xrCrossTabCell6.Name = "xrCrossTabCell6";
      this.xrCrossTabCell6.RowIndex = 1;
      this.xrCrossTabCell7.ColumnIndex = 0;
      this.xrCrossTabCell7.Name = "xrCrossTabCell7";
      this.xrCrossTabCell7.RowIndex = 2;
      this.xrCrossTabCell7.Text = "Genel Toplam";
      this.xrCrossTabCell8.ColumnIndex = 1;
      this.xrCrossTabCell8.Name = "xrCrossTabCell8";
      this.xrCrossTabCell8.RowIndex = 2;
      this.xrCrossTabCell9.ColumnIndex = 2;
      this.xrCrossTabCell9.Name = "xrCrossTabCell9";
      this.xrCrossTabCell9.RowIndex = 2;
      this.TopMargin.HeightF = 15f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 38f;
      this.BottomMargin.Name = "BottomMargin";
      this.TitleStyle.Font = new Font("Arial", 18f);
      this.TitleStyle.Name = "TitleStyle";
      this.TitleStyle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.ReportHeader,
        (Band) this.Detail,
        (Band) this.TopMargin,
        (Band) this.BottomMargin
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.HorizontalContentSplitting = HorizontalContentSplitting.Smart;
      this.Margins = new Margins(58, 32, 15, 38);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4Rotated;
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.TitleStyle,
        this.crossTabGeneralStyle,
        this.crossTabHeaderStyle,
        this.crossTabDataStyle,
        this.crossTabTotalStyle
      });
      this.Version = "20.1";
      this.VerticalContentSplitting = VerticalContentSplitting.Smart;
      this.crossTab1.EndInit();
      this.EndInit();
    }
  }
}
