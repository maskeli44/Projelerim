// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.IdariSartnameResimli
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.SatinAlma.TeklifRaporlari
{
  public class IdariSartnameResimli : XtraReport
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
    private XRLabel xrLabel5;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;

    public IdariSartnameResimli() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IdariSartnameResimli));
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel9 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.TeklifId = new Parameter();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.ReportHeader = new ReportHeaderBand();
      this.xrLabel5 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 134.1667f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8
      });
      this.Detail.HeightF = 23.70809f;
      this.Detail.Name = "Detail";
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
      this.xrLabel5.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(100f, 104.5f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(476f, 29.66668f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = " MAL / HİZMET MUAYENE VE KABUL TUTANAĞI";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(100f, 35.70834f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(112.4999f, 58.70834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(569.625f, 7.500025f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
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
      this.Margins = new Margins(76, 69, 134, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.TeklifId
      });
      this.Version = "20.1";
      this.EndInit();
    }
  }
}
