// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.TeklifTeknikSartnameDuz
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class TeklifTeknikSartnameDuz : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private Parameter talepID;
    private XRLabel xrLabel1;

    public TeklifTeknikSartnameDuz() => this.InitializeComponent();

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
      QueryParameter queryParameter = new QueryParameter();
      Join join = new Join();
      RelationColumnInfo relationColumnInfo = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TeklifTeknikSartnameDuz));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.talepID = new Parameter();
      this.xrLabel1 = new XRLabel();
      this.xrTable2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TALEPID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
      table1.Name = "TBLTALEPTEKNIKSART";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "SIRANO";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ACIKLAMA";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ISINADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table2.Name = "TBLTALEP";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "KOD";
      columnExpression5.Table = table2;
      column5.Expression = (ExpressionBase) columnExpression5;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.FilterString = "";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "Teknik";
      queryParameter.Name = "talepID";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo.NestedKeyColumn = "ID";
      relationColumnInfo.ParentKeyColumn = "TALEPID";
      join.KeyColumns.Add(relationColumnInfo);
      join.Nested = table2;
      join.Parent = table1;
      selectQuery.Relations.Add(join);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.Detail.HeightF = 27.49999f;
      this.Detail.Name = "Detail";
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 1.666673f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(709.3335f, 25f);
      this.xrTable2.StylePriority.UseTextAlignment = false;
      this.xrTable2.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell3,
        this.xrTableCell4,
        this.xrTableCell5
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell3.Summary = xrSummary;
      this.xrTableCell3.Text = "xrTableCell1";
      this.xrTableCell3.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell3.Weight = 0.81212078621610961;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "-";
      this.xrTableCell4.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell4.Weight = 0.2189974462514365;
      this.xrTableCell5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ACIKLAMA]")
      });
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "xrTableCell2";
      this.xrTableCell5.Weight = 6.8984642870637032;
      this.GroupHeader1.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5
      });
      this.GroupHeader1.HeightF = 58.12503f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel6.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrLabel6.LocationFloat = new PointFloat(267.0834f, 0.0f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(173.1249f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "TEKNİK ŞARTNAME ";
      this.xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ISINADI]")
      });
      this.xrLabel5.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(344.1667f, 35.12503f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(241.0416f, 23f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(244.1667f, 35.12503f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(100f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "xrLabel1";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "Teknik";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPID] = ?talepID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(72, 48, 100, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
      });
      this.Version = "20.1";
      this.xrTable2.EndInit();
      this.EndInit();
    }
  }
}
