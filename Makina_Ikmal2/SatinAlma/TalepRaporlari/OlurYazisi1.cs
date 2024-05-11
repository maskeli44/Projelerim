// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepRaporlari.OlurYazisi1
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

namespace Makina_Ikmal.SatinAlma.TalepRaporlari
{
  public class OlurYazisi1 : XtraReport
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
    private DetailBand Detail;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel5;
    private XRLabel xrLabel1;
    private XRLabel xrLabel18;
    private XRLabel xrLabel19;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel15;
    private XRLabel xrLabel16;
    private XRLabel xrLabel17;
    private XRLabel xrLabel12;
    private XRLabel xrLabel26;
    private XRLabel xrLabel20;
    private Parameter talepID;

    public OlurYazisi1() => this.InitializeComponent();

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
      QueryParameter queryParameter1 = new QueryParameter();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Table table2 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table3 = new Table();
      QueryParameter queryParameter2 = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      SelectQuery selectQuery3 = new SelectQuery();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Table table4 = new Table();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Table table5 = new Table();
      QueryParameter queryParameter3 = new QueryParameter();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OlurYazisi1));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel2 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrLabel18 = new XRLabel();
      this.xrLabel19 = new XRLabel();
      this.Detail = new DetailBand();
      this.xrLabel20 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel26 = new XRLabel();
      this.talepID = new Parameter();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "BELGEKONU";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table1.Name = "TBLTALEP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "BELGESAYI";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTALEP";
      queryParameter1.Name = "talepID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      selectQuery1.Tables.Add(table1);
      columnExpression3.ColumnName = "DAIREBSKID";
      table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table2.Name = "TBLTALEP";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ADISOYADI";
      table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table3.Name = "TBLPERSONEL";
      columnExpression4.Table = table3;
      column4.Expression = (ExpressionBase) columnExpression4;
      selectQuery2.Columns.Add((ColumnBase) column3);
      selectQuery2.Columns.Add((ColumnBase) column4);
      selectQuery2.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "TBLTALEP_1";
      queryParameter2.Name = "talepID";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      relationColumnInfo1.NestedKeyColumn = "GOREVUNVANID";
      relationColumnInfo1.ParentKeyColumn = "DAIREBSKID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table3;
      join1.Parent = table2;
      selectQuery2.Relations.Add(join1);
      selectQuery2.Tables.Add(table2);
      selectQuery2.Tables.Add(table3);
      columnExpression5.ColumnName = "DAIREBSKID";
      table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table4.Name = "TBLTALEP";
      columnExpression5.Table = table4;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "ADISOYADI";
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression6.Table = table5;
      column6.Expression = (ExpressionBase) columnExpression6;
      selectQuery3.Columns.Add((ColumnBase) column5);
      selectQuery3.Columns.Add((ColumnBase) column6);
      selectQuery3.FilterString = "[TBLTALEP.ID] = ?talepID";
      selectQuery3.GroupFilterString = "";
      selectQuery3.Name = "DaireBaskani";
      queryParameter3.Name = "talepID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?talepID", typeof (int));
      selectQuery3.Parameters.Add(queryParameter3);
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "DAIREBSKID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table5;
      join2.Parent = table4;
      selectQuery3.Relations.Add(join2);
      selectQuery3.Tables.Add(table4);
      selectQuery3.Tables.Add(table5);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[3]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2,
        (SqlQuery) selectQuery3
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
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.ReportHeader.Name = "ReportHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(574.625f, 7.500051f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(117.4999f, 58.70837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(117.4999f, 35.70836f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(5f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[19]
      {
        (XRControl) this.xrLabel20,
        (XRControl) this.xrLabel26,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel17,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel18,
        (XRControl) this.xrLabel19
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 441.4168f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel2.LocationFloat = new PointFloat(10f, 0.0f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(40f, 23f);
      this.xrLabel2.Text = "Sayı :";
      this.xrLabel5.LocationFloat = new PointFloat(10f, 36.66664f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(52.5f, 23f);
      this.xrLabel5.Text = "Konu :";
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(250.8333f, 60.62495f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(243.3333f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "BAŞKANLIK MAKAMINA";
      this.xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLTALEP].[BELGESAYI]")
      });
      this.xrLabel18.LocationFloat = new PointFloat(50f, 0.0f);
      this.xrLabel18.Multiline = true;
      this.xrLabel18.Name = "xrLabel18";
      this.xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel18.SizeF = new SizeF(214.1667f, 23f);
      this.xrLabel18.Text = "xrLabel18";
      this.xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLTALEP].[BELGEKONU]")
      });
      this.xrLabel19.LocationFloat = new PointFloat(62.5f, 36.66665f);
      this.xrLabel19.Multiline = true;
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel19.SizeF = new SizeF(325.125f, 23f);
      this.xrLabel19.Text = "xrLabel19";
      this.Detail.HeightF = 0.0f;
      this.Detail.Name = "Detail";
      this.xrLabel20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DaireBaskani].[ADISOYADI]")
      });
      this.xrLabel20.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel20.LocationFloat = new PointFloat(536.2499f, 319.5833f);
      this.xrLabel20.Multiline = true;
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel20.SizeF = new SizeF(168.8752f, 23f);
      this.xrLabel20.StylePriority.UseFont = false;
      this.xrLabel20.StylePriority.UseTextAlignment = false;
      this.xrLabel20.Text = "xrLabel20";
      this.xrLabel20.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel6.Font = new Font("Arial", 12f);
      this.xrLabel6.LocationFloat = new PointFloat(29.62497f, 104.3749f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(209.1667f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "A. Talep Edilen İşin Cinsi";
      this.xrLabel7.Font = new Font("Arial", 12f);
      this.xrLabel7.LocationFloat = new PointFloat(29.62497f, 127.3749f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(209.1667f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.Text = "B. Yasal Dayanağı";
      this.xrLabel8.Font = new Font("Arial", 12f);
      this.xrLabel8.LocationFloat = new PointFloat(29.62497f, 150.3749f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(209.1667f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "C. Yönetmelik Maddeleri";
      this.xrLabel9.Font = new Font("Arial", 12f);
      this.xrLabel9.LocationFloat = new PointFloat(29.62497f, 173.3749f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(209.1667f, 23f);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.Text = "D. Meclis Kararı";
      this.xrLabel10.Font = new Font("Arial", 12f);
      this.xrLabel10.LocationFloat = new PointFloat(29.62497f, 196.3749f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(270f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.Text = "E. Bütçe Kodu ve Harcama Kalemi";
      this.xrLabel11.Font = new Font("Arial", 11f);
      this.xrLabel11.LocationFloat = new PointFloat(70.45831f, 244.2501f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(361.3334f, 23f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "Büyükşehir Belediyemize ait ekli listedeki araçlar için";
      this.xrLabel14.Font = new Font("Arial", 11f);
      this.xrLabel14.LocationFloat = new PointFloat(547.0833f, 244.2501f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(100f, 23f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.Text = "ihtiyac vardır.";
      this.xrLabel13.Font = new Font("Arial", 11f);
      this.xrLabel13.LocationFloat = new PointFloat(44.625f, 267.25f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(660.5001f, 23f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.Text = "Makamlarınızca uygun görülmesi halinde Mal Amını'nın 4734 sayılı Kamu İhale Kanununa göre";
      this.xrLabel15.Font = new Font("Arial", 11f);
      this.xrLabel15.LocationFloat = new PointFloat(29.62497f, 290.2501f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(482.1667f, 23.00002f);
      this.xrLabel15.StylePriority.UseFont = false;
      this.xrLabel15.Text = "yapılması hususunda ön izin verilmesi OLUR' olurlarınıza arz ederim.";
      this.xrLabel16.Font = new Font("Arial", 11f);
      this.xrLabel16.LocationFloat = new PointFloat(566.2916f, 342.5833f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(100f, 23f);
      this.xrLabel16.StylePriority.UseFont = false;
      this.xrLabel16.Text = "Daire Başkanı";
      this.xrLabel17.Font = new Font("Arial", 11f);
      this.xrLabel17.LocationFloat = new PointFloat(29.62497f, 368.3336f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(190.8333f, 23f);
      this.xrLabel17.StylePriority.UseFont = false;
      this.xrLabel17.Text = "Uygun görüşle arz ederim.";
      this.xrLabel12.Font = new Font("Arial", 11f);
      this.xrLabel12.LocationFloat = new PointFloat(431.7918f, 244.25f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(115.2916f, 23f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.Text = "Mal Alımına";
      this.xrLabel26.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel26.LocationFloat = new PointFloat(335.4583f, 418.4168f);
      this.xrLabel26.Multiline = true;
      this.xrLabel26.Name = "xrLabel26";
      this.xrLabel26.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel26.SizeF = new SizeF(60.50003f, 22.99994f);
      this.xrLabel26.StylePriority.UseFont = false;
      this.xrLabel26.Text = "OLUR";
      this.talepID.Description = "talepID";
      this.talepID.Name = "talepID";
      this.talepID.Type = typeof (int);
      this.talepID.ValueInfo = "0";
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
      this.DataMember = "TBLTALEP_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(57, 70, 100, 100);
      this.Parameters.AddRange(new Parameter[1]
      {
        this.talepID
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
      this.EndInit();
    }
  }
}
