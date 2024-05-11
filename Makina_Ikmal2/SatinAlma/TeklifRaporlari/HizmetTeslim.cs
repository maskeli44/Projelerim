// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.HizmetTeslim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
  public class HizmetTeslim : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel5;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel1;
    private Parameter teklifID;
    private SqlDataSource sqlDataSource1;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel2;

    public HizmetTeslim() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HizmetTeslim));
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
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table2 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Join join = new Join();
      RelationColumnInfo relationColumnInfo = new RelationColumnInfo();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel5 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.teklifID = new Parameter();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.xrLabel2 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 185f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1
      });
      this.Detail.HeightF = 130.4167f;
      this.Detail.Name = "Detail";
      this.xrLabel5.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(100f, 155.3333f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(476f, 29.66668f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "ÜRÜN - HİZMET TESLİM FORMU";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(100f, 73.20833f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(112.4999f, 96.20834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(569.625f, 45.00003f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 37.5f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", componentResourceManager.GetString("xrLabel1.ExpressionBindings"))
      });
      this.xrLabel1.LocationFloat = new PointFloat(10.00001f, 10.00001f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(682.9999f, 80.20834f);
      this.xrLabel1.Text = "Müdürlüğümüzce";
      this.teklifID.Description = "teklifID";
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table1.MetaSerializable = "<Meta X=\"-100\" Y=\"20\" Width=\"125\" Height=\"923\" />";
      table1.Name = "TBLTEKLIF";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "KOD";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "TARIH";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "SAAT";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "TEKLIFKONUSU";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "KAZANANFIRMAID";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "FATURATARIHI";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "FATURANO";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "FATURATUTAR";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "KDVTUTAR";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "TOPLAMTUTAR";
      columnExpression11.Table = table1;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "FATTUTARYAZIYLA";
      columnExpression12.Table = table1;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "SAKARARTARIHI";
      columnExpression13.Table = table1;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "SAKARARNO";
      columnExpression14.Table = table1;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "IMZABIRIMAMIRIID";
      columnExpression15.Table = table1;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "IMZAMUDURID";
      columnExpression16.Table = table1;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "DAIREBSKID";
      columnExpression17.Table = table1;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "OLURILGISI";
      columnExpression18.Table = table1;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "BELGEKONU";
      table2.MetaSerializable = "<Meta X=\"55\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table2.Name = "TBLTALEP";
      columnExpression19.Table = table2;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "BELGESAYI";
      columnExpression20.Table = table2;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "BELGETARIH";
      columnExpression21.Table = table2;
      column21.Expression = (ExpressionBase) columnExpression21;
      column22.Alias = "TBLTALEP_TARIH";
      columnExpression22.ColumnName = "TARIH";
      columnExpression22.Table = table2;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "IHALEUSULU";
      columnExpression23.Table = table2;
      column23.Expression = (ExpressionBase) columnExpression23;
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
      selectQuery.Columns.Add((ColumnBase) column13);
      selectQuery.Columns.Add((ColumnBase) column14);
      selectQuery.Columns.Add((ColumnBase) column15);
      selectQuery.Columns.Add((ColumnBase) column16);
      selectQuery.Columns.Add((ColumnBase) column17);
      selectQuery.Columns.Add((ColumnBase) column18);
      selectQuery.Columns.Add((ColumnBase) column19);
      selectQuery.Columns.Add((ColumnBase) column20);
      selectQuery.Columns.Add((ColumnBase) column21);
      selectQuery.Columns.Add((ColumnBase) column22);
      selectQuery.Columns.Add((ColumnBase) column23);
      selectQuery.Name = "TBLTEKLIF";
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
      this.xrLabel2.LocationFloat = new PointFloat(10.00001f, 97.41666f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel2.SizeF = new SizeF(142.7083f, 23f);
      this.xrLabel2.Text = "Komisyon Başkanı";
      this.xrLabel6.LocationFloat = new PointFloat(242.6667f, 97.41666f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel6.SizeF = new SizeF(179.1667f, 23f);
      this.xrLabel6.Text = "Teslim Alan Şube Personeli";
      this.xrLabel7.LocationFloat = new PointFloat(569.6249f, 97.41666f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel7.SizeF = new SizeF(118.7499f, 23f);
      this.xrLabel7.Text = "Ambar Memuru";
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIF";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?teklifID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(74, 73, 185, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.teklifID
      });
      this.Version = "20.1";
      this.EndInit();
    }
  }
}
