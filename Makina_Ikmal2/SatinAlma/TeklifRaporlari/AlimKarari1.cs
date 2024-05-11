// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.AlimKarari1
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.Xpo.DB;
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
  public class AlimKarari1 : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel30;
    private XRLabel xrLabel29;
    private XRLabel xrLabel28;
    private XRLabel xrLabel27;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;
    private XRLabel xrLabel23;
    private XRLabel xrLabel22;
    private XRLabel xrLabel21;
    private XRLabel xrLabel20;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel26;
    private XRLabel xrLabel19;
    private Parameter teklifID;
    private XRLabel xrLabel14;
    private Parameter yaziyla;

    public AlimKarari1() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      SelectQuery selectQuery1 = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table1 = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table2 = new Table();
      QueryParameter queryParameter1 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table3 = new Table();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table4 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Table table5 = new Table();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table6 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Table table7 = new Table();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AlimKarari1));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel14 = new XRLabel();
      this.xrLabel30 = new XRLabel();
      this.xrLabel29 = new XRLabel();
      this.xrLabel28 = new XRLabel();
      this.xrLabel27 = new XRLabel();
      this.xrLabel25 = new XRLabel();
      this.xrLabel24 = new XRLabel();
      this.xrLabel23 = new XRLabel();
      this.xrLabel22 = new XRLabel();
      this.xrLabel21 = new XRLabel();
      this.xrLabel20 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrLabel26 = new XRLabel();
      this.xrLabel19 = new XRLabel();
      this.teklifID = new Parameter();
      this.yaziyla = new Parameter();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "KOD";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table1.Name = "TBLTEKLIF";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "TEKLIFKONUSU";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "TARIH";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "FATURANO";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "FATURATUTAR";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "OLURILGISI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "SAKARARNO";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "SAKARARTARIHI";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "FIRMAADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"483\" />";
      table2.Name = "TBLFIRMALAR";
      columnExpression9.Table = table2;
      column9.Expression = (ExpressionBase) columnExpression9;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.Columns.Add((ColumnBase) column5);
      selectQuery1.Columns.Add((ColumnBase) column6);
      selectQuery1.Columns.Add((ColumnBase) column7);
      selectQuery1.Columns.Add((ColumnBase) column8);
      selectQuery1.Columns.Add((ColumnBase) column9);
      selectQuery1.FilterString = "[TBLTEKLIF.ID] = ?teklifID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTEKLIF_1";
      queryParameter1.Name = "teklifID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?teklifID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      relationColumnInfo1.NestedKeyColumn = "TEKLIFID";
      relationColumnInfo1.ParentKeyColumn = "ID";
      join1.KeyColumns.Add(relationColumnInfo1);
      table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"743\" />";
      table3.Name = "TBLTEKLIFHRKT";
      join1.Nested = table3;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "KAZANANFIRMAID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table1;
      join2.Type = JoinType.LeftOuter;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table2);
      columnExpression10.ColumnName = "ADISOYADI";
      table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression10.Table = table4;
      column10.Expression = (ExpressionBase) columnExpression10;
      selectQuery2.Columns.Add((ColumnBase) column10);
      selectQuery2.FilterString = "[TBLTEKLIF.ID] = ?teklifID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "SubeMuduru";
      queryParameter2.Name = "teklifID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?teklifID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "IMZAMUDURID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table5.Name = "TBLTEKLIF";
      join3.Parent = table5;
      selectQuery2.Relations.Add(join3);
      selectQuery2.Tables.Add(table5);
      selectQuery2.Tables.Add(table4);
      columnExpression11.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression11.Table = table6;
      column11.Expression = (ExpressionBase) columnExpression11;
      selectQuery3.Columns.Add((ColumnBase) column11);
      selectQuery3.FilterString = "[TBLTEKLIF.ID] = ?teklifID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "DaireBaskani";
      queryParameter3.Name = "teklifID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?teklifID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "DAIREBSKID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table6;
      table7.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table7.Name = "TBLTEKLIF";
      join4.Parent = table7;
      selectQuery3.Relations.Add(join4);
      selectQuery3.Tables.Add(table7);
      selectQuery3.Tables.Add(table6);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[3]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.HeightF = 14.28571f;
      this.Detail.Name = "Detail";
      this.PageHeader.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.PageHeader.HeightF = 116.7526f;
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(585.6248f, 7.500025f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(128.4998f, 58.70834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(115.9999f, 35.70834f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(15.99986f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[18]
      {
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel30,
        (XRControl) this.xrLabel29,
        (XRControl) this.xrLabel28,
        (XRControl) this.xrLabel27,
        (XRControl) this.xrLabel25,
        (XRControl) this.xrLabel24,
        (XRControl) this.xrLabel23,
        (XRControl) this.xrLabel22,
        (XRControl) this.xrLabel21,
        (XRControl) this.xrLabel20,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel26,
        (XRControl) this.xrLabel19
      });
      this.GroupHeader1.HeightF = 592.2917f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAKARARTARIHI]")
      });
      this.xrLabel14.LocationFloat = new PointFloat(628.7497f, 10.00001f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(100f, 23f);
      this.xrLabel14.Text = "xrLabel14";
      this.xrLabel14.TextFormatString = "{0:d}";
      this.xrLabel30.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[OLURILGISI]")
      });
      this.xrLabel30.Font = new Font("Arial", 10f);
      this.xrLabel30.LocationFloat = new PointFloat(82.83318f, 121.2917f);
      this.xrLabel30.Multiline = true;
      this.xrLabel30.Name = "xrLabel30";
      this.xrLabel30.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel30.SizeF = new SizeF(600.8333f, 22.99999f);
      this.xrLabel30.StylePriority.UseFont = false;
      this.xrLabel30.Text = "xrLabel30";
      this.xrLabel29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TEKLIFKONUSU]")
      });
      this.xrLabel29.LocationFloat = new PointFloat(101.8333f, 22.99999f);
      this.xrLabel29.Multiline = true;
      this.xrLabel29.Name = "xrLabel29";
      this.xrLabel29.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel29.SizeF = new SizeF(122.5f, 23f);
      this.xrLabel29.Text = "xrLabel29";
      this.xrLabel28.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAKARARNO]")
      });
      this.xrLabel28.LocationFloat = new PointFloat(115.9999f, 0.0f);
      this.xrLabel28.Multiline = true;
      this.xrLabel28.Name = "xrLabel28";
      this.xrLabel28.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel28.SizeF = new SizeF(108.3333f, 23f);
      this.xrLabel28.Text = "xrLabel28";
      this.xrLabel27.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "Daire Başkanı")
      });
      this.xrLabel27.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel27.LocationFloat = new PointFloat(311.6248f, 569.2917f);
      this.xrLabel27.Multiline = true;
      this.xrLabel27.Name = "xrLabel27";
      this.xrLabel27.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel27.SizeF = new SizeF(100f, 23f);
      this.xrLabel27.StylePriority.UseFont = false;
      this.xrLabel27.StylePriority.UseTextAlignment = false;
      this.xrLabel27.Text = "Daire Başkanı";
      this.xrLabel27.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel25.LocationFloat = new PointFloat(311.6248f, 498.4583f);
      this.xrLabel25.Multiline = true;
      this.xrLabel25.Name = "xrLabel25";
      this.xrLabel25.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel25.SizeF = new SizeF(100f, 23f);
      this.xrLabel25.StylePriority.UseTextAlignment = false;
      this.xrLabel25.Text = "../../2022";
      this.xrLabel25.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel24.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel24.LocationFloat = new PointFloat(311.6248f, 475.4583f);
      this.xrLabel24.Multiline = true;
      this.xrLabel24.Name = "xrLabel24";
      this.xrLabel24.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel24.SizeF = new SizeF(100f, 23f);
      this.xrLabel24.StylePriority.UseFont = false;
      this.xrLabel24.StylePriority.UseTextAlignment = false;
      this.xrLabel24.Text = "OLUR";
      this.xrLabel24.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel23.LocationFloat = new PointFloat(15.99988f, 416.4583f);
      this.xrLabel23.Multiline = true;
      this.xrLabel23.Name = "xrLabel23";
      this.xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel23.SizeF = new SizeF(172.5f, 23.00003f);
      this.xrLabel23.Text = "2.Piyasa Araştırma Raporu";
      this.xrLabel22.LocationFloat = new PointFloat(15.99988f, 393.4583f);
      this.xrLabel22.Multiline = true;
      this.xrLabel22.Name = "xrLabel22";
      this.xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel22.SizeF = new SizeF(125.8333f, 23f);
      this.xrLabel22.Text = "1.Komisyon Raporu";
      this.xrLabel21.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel21.LocationFloat = new PointFloat(15.99988f, 370.4583f);
      this.xrLabel21.Multiline = true;
      this.xrLabel21.Name = "xrLabel21";
      this.xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel21.SizeF = new SizeF(66.8333f, 23f);
      this.xrLabel21.StylePriority.UseFont = false;
      this.xrLabel21.StylePriority.UseTextAlignment = false;
      this.xrLabel21.Text = "Ekiler:";
      this.xrLabel21.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel20.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel20.LocationFloat = new PointFloat(532.9584f, 352.8749f);
      this.xrLabel20.Multiline = true;
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel20.SizeF = new SizeF(100f, 23f);
      this.xrLabel20.StylePriority.UseFont = false;
      this.xrLabel20.StylePriority.UseTextAlignment = false;
      this.xrLabel20.Text = "Şube Müdürü";
      this.xrLabel20.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel7.AutoWidth = true;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", componentResourceManager.GetString("xrLabel7.ExpressionBindings"))
      });
      this.xrLabel7.Font = new Font("Arial", 10f);
      this.xrLabel7.LocationFloat = new PointFloat(3.178914E-05f, 155.25f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 4, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(715.1664f, 153.7915f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UsePadding = false;
      this.xrLabel7.Text = componentResourceManager.GetString("xrLabel7.Text");
      this.xrLabel6.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel6.LocationFloat = new PointFloat(43.66652f, 121.2917f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(39.16667f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "İlgi : ";
      this.xrLabel5.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(251.1665f, 79.62499f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(244.1667f, 29.66667f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "BAŞKANLIK MAKAMINA";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(31.16651f, 23f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(70.6667f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.Text = "Konu : ";
      this.xrLabel1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(31.16651f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(84.83337f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "Karar No :";
      this.xrLabel26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SubeMuduru].[ADISOYADI]")
      });
      this.xrLabel26.LocationFloat = new PointFloat(521.3927f, 329.8749f);
      this.xrLabel26.Multiline = true;
      this.xrLabel26.Name = "xrLabel26";
      this.xrLabel26.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel26.SizeF = new SizeF(137.1485f, 23f);
      this.xrLabel26.StylePriority.UseTextAlignment = false;
      this.xrLabel26.Text = "xrLabel26";
      this.xrLabel26.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DaireBaskani].[ADISOYADI]")
      });
      this.xrLabel19.LocationFloat = new PointFloat(267.3333f, 546.2917f);
      this.xrLabel19.Multiline = true;
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel19.SizeF = new SizeF(181.4049f, 23f);
      this.xrLabel19.StylePriority.UseTextAlignment = false;
      this.xrLabel19.Text = "xrLabel19";
      this.xrLabel19.TextAlignment = TextAlignment.TopCenter;
      this.teklifID.Description = "teklifID";
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.yaziyla.Description = "yaziyla";
      this.yaziyla.Name = "yaziyla";
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.PageHeader,
        (Band) this.GroupHeader1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIF_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(87, 18, 100, 100);
      this.Parameters.AddRange(new Parameter[2]
      {
        this.teklifID,
        this.yaziyla
      });
      this.Version = "20.1";
      this.EndInit();
    }
  }
}
