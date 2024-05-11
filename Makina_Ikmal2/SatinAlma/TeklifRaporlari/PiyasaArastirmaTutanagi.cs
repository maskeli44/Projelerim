// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifRaporlari.PiyasaArastirmaTutanagi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
  public class PiyasaArastirmaTutanagi : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRPictureBox xrPictureBox1;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel5;
    private XRLabel xrLabel1;
    private SqlDataSource sqlDataSource1;
    private Parameter teklifID;
    private XRLabel xrLabel6;
    private XRLabel xrLabel2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell4;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell14;
    private XRTable xrTable3;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private GroupFooterBand GroupFooter1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;

    public PiyasaArastirmaTutanagi() => this.InitializeComponent();

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
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Column column22 = new Column();
      ColumnExpression columnExpression22 = new ColumnExpression();
      Column column23 = new Column();
      ColumnExpression columnExpression23 = new ColumnExpression();
      Column column24 = new Column();
      ColumnExpression columnExpression24 = new ColumnExpression();
      Column column25 = new Column();
      ColumnExpression columnExpression25 = new ColumnExpression();
      Column column26 = new Column();
      ColumnExpression columnExpression26 = new ColumnExpression();
      Column column27 = new Column();
      ColumnExpression columnExpression27 = new ColumnExpression();
      Column column28 = new Column();
      ColumnExpression columnExpression28 = new ColumnExpression();
      Column column29 = new Column();
      ColumnExpression columnExpression29 = new ColumnExpression();
      Column column30 = new Column();
      ColumnExpression columnExpression30 = new ColumnExpression();
      Column column31 = new Column();
      ColumnExpression columnExpression31 = new ColumnExpression();
      Column column32 = new Column();
      ColumnExpression columnExpression32 = new ColumnExpression();
      Column column33 = new Column();
      ColumnExpression columnExpression33 = new ColumnExpression();
      Column column34 = new Column();
      ColumnExpression columnExpression34 = new ColumnExpression();
      Column column35 = new Column();
      ColumnExpression columnExpression35 = new ColumnExpression();
      Table table2 = new Table();
      Column column36 = new Column();
      ColumnExpression columnExpression36 = new ColumnExpression();
      Table table3 = new Table();
      Column column37 = new Column();
      ColumnExpression columnExpression37 = new ColumnExpression();
      Table table4 = new Table();
      Column column38 = new Column();
      ColumnExpression columnExpression38 = new ColumnExpression();
      Table table5 = new Table();
      Column column39 = new Column();
      ColumnExpression columnExpression39 = new ColumnExpression();
      Table table6 = new Table();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PiyasaArastirmaTutanagi));
      XRSummary xrSummary1 = new XRSummary();
      XRSummary xrSummary2 = new XRSummary();
      XRSummary xrSummary3 = new XRSummary();
      XRSummary xrSummary4 = new XRSummary();
      XRSummary xrSummary5 = new XRSummary();
      XRSummary xrSummary6 = new XRSummary();
      XRSummary xrSummary7 = new XRSummary();
      XRSummary xrSummary8 = new XRSummary();
      XRSummary xrSummary9 = new XRSummary();
      this.TopMargin = new TopMarginBand();
      this.xrLabel1 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.teklifID = new Parameter();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrLabel2 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell27 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell31 = new XRTableCell();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableCell33 = new XRTableCell();
      this.xrTableCell34 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableCell37 = new XRTableCell();
      this.xrTableCell38 = new XRTableCell();
      this.GroupFooter1 = new GroupFooterBand();
      this.xrTable4 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableCell30 = new XRTableCell();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable4.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel5
      });
      this.TopMargin.HeightF = 177f;
      this.TopMargin.Name = "TopMargin";
      this.xrLabel1.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(323.2084f, 39.79165f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "T.C.";
      this.xrLabel1.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 26.0416f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(959.4583f, 39.79166f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(323.2084f, 103.0416f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(319.0418f, 62.79167f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel5.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(292f, 146.7916f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(476f, 29.66668f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "AYRINTILI PİYASA FİYAT ARAŞTIRMA TUTANAĞI";
      this.xrLabel5.TextAlignment = TextAlignment.TopCenter;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table1.MetaSerializable = "<Meta X=\"-110\" Y=\"20\" Width=\"125\" Height=\"743\" />";
      table1.Name = "TBLTEKLIFHRKT";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "TEKLIFID";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACID";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "MALZEMEID";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "MALZACIKLAMA";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "BIRIMID";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "MIKTAR";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "MARKA";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BIRIMFIYAT";
      columnExpression9.Table = table1;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "TUTAR";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "FIRMA1ID";
      columnExpression11.Table = table1;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "F1BIRIMFIYAT";
      columnExpression12.Table = table1;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "F1TUTAR";
      columnExpression13.Table = table1;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "FIRMA2ID";
      columnExpression14.Table = table1;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "F2BIRIMFIYAT";
      columnExpression15.Table = table1;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "F2TUTAR";
      columnExpression16.Table = table1;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "FIRMA3ID";
      columnExpression17.Table = table1;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "F3BIRIMFIYAT";
      columnExpression18.Table = table1;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "F3TUTAR";
      columnExpression19.Table = table1;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "FIRMA4ID";
      columnExpression20.Table = table1;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "F4BIRIMFIYAT";
      columnExpression21.Table = table1;
      column21.Expression = (ExpressionBase) columnExpression21;
      columnExpression22.ColumnName = "F4TUTAR";
      columnExpression22.Table = table1;
      column22.Expression = (ExpressionBase) columnExpression22;
      columnExpression23.ColumnName = "FIRMA5ID";
      columnExpression23.Table = table1;
      column23.Expression = (ExpressionBase) columnExpression23;
      columnExpression24.ColumnName = "F5BIRIMFIYAT";
      columnExpression24.Table = table1;
      column24.Expression = (ExpressionBase) columnExpression24;
      columnExpression25.ColumnName = "F5TUTAR";
      columnExpression25.Table = table1;
      column25.Expression = (ExpressionBase) columnExpression25;
      columnExpression26.ColumnName = "FIRMA6ID";
      columnExpression26.Table = table1;
      column26.Expression = (ExpressionBase) columnExpression26;
      columnExpression27.ColumnName = "F6BIRIMFIYAT";
      columnExpression27.Table = table1;
      column27.Expression = (ExpressionBase) columnExpression27;
      columnExpression28.ColumnName = "F6TUTAR";
      columnExpression28.Table = table1;
      column28.Expression = (ExpressionBase) columnExpression28;
      columnExpression29.ColumnName = "FIRMA7ID";
      columnExpression29.Table = table1;
      column29.Expression = (ExpressionBase) columnExpression29;
      columnExpression30.ColumnName = "F7BIRIMFIYAT";
      columnExpression30.Table = table1;
      column30.Expression = (ExpressionBase) columnExpression30;
      columnExpression31.ColumnName = "F7TUTAR";
      columnExpression31.Table = table1;
      column31.Expression = (ExpressionBase) columnExpression31;
      columnExpression32.ColumnName = "FIRMA8ID";
      columnExpression32.Table = table1;
      column32.Expression = (ExpressionBase) columnExpression32;
      columnExpression33.ColumnName = "F8BIRIMFIYAT";
      columnExpression33.Table = table1;
      column33.Expression = (ExpressionBase) columnExpression33;
      columnExpression34.ColumnName = "F8TUTAR";
      columnExpression34.Table = table1;
      column34.Expression = (ExpressionBase) columnExpression34;
      columnExpression35.ColumnName = "KOD";
      table2.MetaSerializable = "<Meta X=\"80\" Y=\"20\" Width=\"125\" Height=\"923\" />";
      table2.Name = "TBLTEKLIF";
      columnExpression35.Table = table2;
      column35.Expression = (ExpressionBase) columnExpression35;
      columnExpression36.ColumnName = "MALZEMEADI";
      table3.MetaSerializable = "<Meta X=\"235\" Y=\"30\" Width=\"125\" Height=\"683\" />";
      table3.Name = "TBLMALZEMELER";
      columnExpression36.Table = table3;
      column36.Expression = (ExpressionBase) columnExpression36;
      column37.Alias = "TBLTALEP_KOD";
      columnExpression37.ColumnName = "KOD";
      table4.MetaSerializable = "<Meta X=\"410\" Y=\"60\" Width=\"125\" Height=\"683\" />";
      table4.Name = "TBLTALEP";
      columnExpression37.Table = table4;
      column37.Expression = (ExpressionBase) columnExpression37;
      columnExpression38.ColumnName = "BIRIMADI";
      table5.MetaSerializable = "<Meta X=\"565\" Y=\"30\" Width=\"125\" Height=\"263\" />";
      table5.Name = "TBLMALZBIRIM";
      columnExpression38.Table = table5;
      column38.Expression = (ExpressionBase) columnExpression38;
      columnExpression39.ColumnName = "ADISOYADI";
      table6.MetaSerializable = "<Meta X=\"720\" Y=\"30\" Width=\"125\" Height=\"923\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression39.Table = table6;
      column39.Expression = (ExpressionBase) columnExpression39;
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
      selectQuery.Columns.Add((ColumnBase) column24);
      selectQuery.Columns.Add((ColumnBase) column25);
      selectQuery.Columns.Add((ColumnBase) column26);
      selectQuery.Columns.Add((ColumnBase) column27);
      selectQuery.Columns.Add((ColumnBase) column28);
      selectQuery.Columns.Add((ColumnBase) column29);
      selectQuery.Columns.Add((ColumnBase) column30);
      selectQuery.Columns.Add((ColumnBase) column31);
      selectQuery.Columns.Add((ColumnBase) column32);
      selectQuery.Columns.Add((ColumnBase) column33);
      selectQuery.Columns.Add((ColumnBase) column34);
      selectQuery.Columns.Add((ColumnBase) column35);
      selectQuery.Columns.Add((ColumnBase) column36);
      selectQuery.Columns.Add((ColumnBase) column37);
      selectQuery.Columns.Add((ColumnBase) column38);
      selectQuery.Columns.Add((ColumnBase) column39);
      selectQuery.Name = "TBLTEKLIFHRKT";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "TEKLIFID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MALZEMEID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "TALEPID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BIRIMID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "MUDURID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table6;
      join5.Parent = table4;
      join5.Type = JoinType.LeftOuter;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table6);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.teklifID.Description = "teklifID";
      this.teklifID.Name = "teklifID";
      this.teklifID.Type = typeof (int);
      this.teklifID.ValueInfo = "0";
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[2]
      {
        this.xrTableRow1,
        this.xrTableRow2
      });
      this.xrTable1.SizeF = new SizeF(1089f, 50f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell1,
        this.xrTableCell2
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Mal/Hizmet/ Yapım İşi";
      this.xrTableCell1.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell1.Weight = 1.0383143092200917;
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Kişi / Firmalar ve Fiyat Teklifleri";
      this.xrTableCell2.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell2.Weight = 2.0766280441271605;
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLTALEP_KOD]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(0.0f, 153.4583f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel2.SizeF = new SizeF(100f, 23f);
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrLabel6.LocationFloat = new PointFloat(989f, 153.4583f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel6.SizeF = new SizeF(100f, 23f);
      this.xrLabel6.Text = "xrLabel6";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.HeightF = 50f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTableRow2.Cells.AddRange(new XRTableCell[12]
      {
        this.xrTableCell3,
        this.xrTableCell7,
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell4,
        this.xrTableCell10,
        this.xrTableCell9,
        this.xrTableCell12,
        this.xrTableCell8,
        this.xrTableCell13,
        this.xrTableCell11,
        this.xrTableCell14
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "S.No";
      this.xrTableCell3.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell3.Weight = 0.11305671998824195;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Weight = 0.25957861458000092;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Birim";
      this.xrTableCell5.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell5.Weight = 0.1881287360661574;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Miktar";
      this.xrTableCell6.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell6.Weight = 0.13705969429598241;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Malın Hizmetin Adı / Özelliği";
      this.xrTableCell7.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell7.Weight = 0.60006917018379446;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Weight = 0.25957853819989574;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.Weight = 0.25957853819989568;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.Weight = 0.2595786254914445;
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.Weight = 0.25957871278299333;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.Weight = 0.2595783636167982;
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.Weight = 0.25957853819989568;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.Weight = 0.25957810174215179;
      this.xrTable2.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable2.SizeF = new SizeF(1089f, 25f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[12]
      {
        this.xrTableCell15,
        this.xrTableCell16,
        this.xrTableCell18,
        this.xrTableCell21,
        this.xrTableCell20,
        this.xrTableCell22,
        this.xrTableCell19,
        this.xrTableCell24,
        this.xrTableCell23,
        this.xrTableCell25,
        this.xrTableCell26,
        this.xrTableCell27
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      xrSummary1.Running = SummaryRunning.Report;
      this.xrTableCell15.Summary = xrSummary1;
      this.xrTableCell15.Weight = 0.395252150812865;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.Weight = 2.0978728493713756;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.Weight = 0.65770782480354129;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F3TUTAR]")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.Weight = 363.0 / 400.0;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F1TUTAR]")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Weight = 0.90750030517578106;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.Weight = 0.47916778564453133;
      this.xrTableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F2TUTAR]")
      });
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.Weight = 0.90750030517578129;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F5TUTAR]")
      });
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.Weight = 363.0 / 400.0;
      this.xrTableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F4TUTAR]")
      });
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.Weight = 0.90749938964843768;
      this.xrTableCell25.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F6TUTAR]")
      });
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.Weight = 363.0 / 400.0;
      this.xrTableCell26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F7TUTAR]")
      });
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.Weight = 0.90750061035157548;
      this.xrTableCell27.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell27.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[F8TUTAR]")
      });
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.StylePriority.UseBorders = false;
      this.xrTableCell27.Weight = 0.90749893188475483;
      this.xrTable3.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTable3.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable3.SizeF = new SizeF(1089f, 25f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[9]
      {
        this.xrTableCell28,
        this.xrTableCell31,
        this.xrTableCell32,
        this.xrTableCell33,
        this.xrTableCell34,
        this.xrTableCell35,
        this.xrTableCell36,
        this.xrTableCell37,
        this.xrTableCell38
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseTextAlignment = false;
      this.xrTableCell28.Text = "Toplam: ";
      this.xrTableCell28.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell28.Weight = 3.6300005620639437;
      this.xrTableCell31.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F1TUTAR])")
      });
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      xrSummary2.Running = SummaryRunning.Group;
      this.xrTableCell31.Summary = xrSummary2;
      this.xrTableCell31.Weight = 0.90750030517578106;
      this.xrTableCell32.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F2TUTAR])")
      });
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      xrSummary3.Running = SummaryRunning.Group;
      this.xrTableCell32.Summary = xrSummary3;
      this.xrTableCell32.Weight = 363.0 / 400.0;
      this.xrTableCell33.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F3TUTAR])")
      });
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      xrSummary4.Running = SummaryRunning.Group;
      this.xrTableCell33.Summary = xrSummary4;
      this.xrTableCell33.Weight = 363.0 / 400.0;
      this.xrTableCell34.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F4TUTAR])")
      });
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      xrSummary5.Running = SummaryRunning.Group;
      this.xrTableCell34.Summary = xrSummary5;
      this.xrTableCell34.Weight = 0.90749847412109053;
      this.xrTableCell35.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F5TUTAR])")
      });
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      xrSummary6.Running = SummaryRunning.Group;
      this.xrTableCell35.Summary = xrSummary6;
      this.xrTableCell35.Weight = 0.90750122070312789;
      this.xrTableCell36.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F6TUTAR])")
      });
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      xrSummary7.Running = SummaryRunning.Group;
      this.xrTableCell36.Summary = xrSummary7;
      this.xrTableCell36.Weight = 363.0 / 400.0;
      this.xrTableCell37.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F7TUTAR])")
      });
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      xrSummary8.Running = SummaryRunning.Group;
      this.xrTableCell37.Summary = xrSummary8;
      this.xrTableCell37.Weight = 0.9075006103515757;
      this.xrTableCell38.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell38.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumSum([F8TUTAR])")
      });
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.StylePriority.UseBorders = false;
      xrSummary9.Running = SummaryRunning.Group;
      this.xrTableCell38.Summary = xrSummary9;
      this.xrTableCell38.Weight = 0.90749886816631853;
      this.GroupFooter1.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable3
      });
      this.GroupFooter1.HeightF = 294.8929f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.xrTable4.LocationFloat = new PointFloat(0.0f, 49.48816f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[2]
      {
        this.xrTableRow5,
        this.xrTableRow6
      });
      this.xrTable4.SizeF = new SizeF(1089f, 81.02373f);
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell17
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.Text = componentResourceManager.GetString("xrTableCell17.Text");
      this.xrTableCell17.Weight = 1.0;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell29,
        this.xrTableCell30
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.Weight = 0.75000005604697551;
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.Weight = 0.24999994395302455;
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1,
        (Band) this.GroupFooter1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIFHRKT";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TEKLIFID] = ?teklifID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(39, 41, 177, 100);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4Rotated;
      this.Parameters.AddRange(new Parameter[1]
      {
        this.teklifID
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.xrTable4.EndInit();
      this.EndInit();
    }
  }
}
