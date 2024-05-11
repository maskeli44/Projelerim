// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.IdariSartname
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

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class IdariSartname : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel7;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private Parameter TeklifId;
    private SqlDataSource sqlDataSource1;
    private ReportHeaderBand ReportHeader;

    public IdariSartname() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      XRSummary xrSummary = new XRSummary();
      SelectQuery selectQuery = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      QueryParameter queryParameter = new QueryParameter();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IdariSartname));
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel7 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.TeklifId = new Parameter();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.ReportHeader = new ReportHeaderBand();
      this.BeginInit();
      this.TopMargin.HeightF = 100f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8
      });
      this.Detail.HeightF = 23.70809f;
      this.Detail.Name = "Detail";
      this.xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Underline);
      this.xrLabel7.LocationFloat = new PointFloat(223.708f, 0.0f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(202.5f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "İDARİ ŞARTNAME";
      this.xrLabel7.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrLabel9.LocationFloat = new PointFloat(31.45844f, 0.0f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(60f, 23f);
      xrSummary.Running = SummaryRunning.Report;
      this.xrLabel9.Summary = xrSummary;
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ACIKLAMA]")
      });
      this.xrLabel8.LocationFloat = new PointFloat(91.45845f, 0.0f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(440f, 23f);
      this.xrLabel8.Text = "xrLabel8";
      this.TeklifId.Description = "TeklifId";
      this.TeklifId.Name = "TeklifId";
      this.TeklifId.Type = typeof (int);
      this.TeklifId.ValueInfo = "0";
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
      table.Name = "TBLTEKLIFIDARISART";
      columnExpression1.Table = table;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "TEKLIFID";
      columnExpression2.Table = table;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "SIRANO";
      columnExpression3.Table = table;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ACIKLAMA";
      columnExpression4.Table = table;
      column4.Expression = (ExpressionBase) columnExpression4;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.FilterString = "[TBLTEKLIFIDARISART.TEKLIFID] = ?TeklifId";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLTEKLIFIDARISART";
      queryParameter.Name = "TeklifId";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?TeklifId", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      selectQuery.Tables.Add(table);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel7
      });
      this.ReportHeader.HeightF = 23f;
      this.ReportHeader.Name = "ReportHeader";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.ReportHeader
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIFIDARISART";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.TeklifId
      });
      this.Version = "20.1";
      this.EndInit();
    }
  }
}
