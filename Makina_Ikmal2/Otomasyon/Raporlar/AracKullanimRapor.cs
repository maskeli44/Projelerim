// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.Raporlar.AracKullanimRapor
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

namespace Makina_Ikmal.Otomasyon.Raporlar
{
  public class AracKullanimRapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRPictureBox xrPictureBox2;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell9;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell8;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell20;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell19;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell18;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private Parameter id;

    public AracKullanimRapor() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Table table3 = new Table();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Table table4 = new Table();
      QueryParameter queryParameter = new QueryParameter();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Table table5 = new Table();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracKullanimRapor));
      XRSummary xrSummary = new XRSummary();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrPictureBox2 = new XRPictureBox();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable5 = new XRTable();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell9 = new XRTableCell();
      this.xrTable4 = new XRTable();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell4 = new XRTableCell();
      this.xrTable14 = new XRTable();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell20 = new XRTableCell();
      this.xrTable13 = new XRTable();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTable12 = new XRTable();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTable11 = new XRTable();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.id = new Parameter();
      this.xrTable5.BeginInit();
      this.xrTable4.BeginInit();
      this.xrTable3.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable14.BeginInit();
      this.xrTable13.BeginInit();
      this.xrTable12.BeginInit();
      this.xrTable11.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TARIHSAAT";
      table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"205\" />";
      table1.Name = "TBLARACMESTKP";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      column2.Alias = "TBLARACMESTKP_PLAKA";
      columnExpression2.ColumnName = "PLAKA";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "MESAIICI";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "MESAIDISI";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "TOPLAMKM";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "CALISMASURESI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression7.Table = table2;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "UNVAN";
      table3.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLPERSUNVAN";
      columnExpression8.Table = table3;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "BELDBIRIMADI";
      table4.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table4.Name = "TBLBELDBIRIMLER";
      columnExpression9.Table = table4;
      column9.Expression = (ExpressionBase) columnExpression9;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.Columns.Add((ColumnBase) column8);
      selectQuery.Columns.Add((ColumnBase) column9);
      selectQuery.FilterString = "[TBLARACLAR.ID] = ?id";
      selectQuery.GroupFilterString = "";
      selectQuery.Name = "TBLARACLAR_1";
      queryParameter.Name = "id";
      queryParameter.Type = typeof (Expression);
      queryParameter.Value = (object) new Expression("?id", typeof (int));
      selectQuery.Parameters.Add(queryParameter);
      relationColumnInfo1.NestedKeyColumn = "PLAKA";
      relationColumnInfo1.ParentKeyColumn = "PLAKA";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table1;
      table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table5.Name = "TBLARACLAR";
      join1.Parent = table5;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "TAHSISEDILENID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table2;
      join2.Parent = table5;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "UNVANID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table3;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BELDBIRIMID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table4;
      join4.Parent = table5;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable14,
        (XRControl) this.xrTable13,
        (XRControl) this.xrTable12,
        (XRControl) this.xrTable11
      });
      this.BottomMargin.HeightF = 25f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrTable5,
        (XRControl) this.xrTable4,
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable2
      });
      this.Detail.HeightF = 37.5f;
      this.Detail.Name = "Detail";
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(103f, 44.16667f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(478.1248f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ARAÇ KULLANIM RAPORU";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(3.000005f, 10f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 75.83334f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(581.1249f, 10f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 75.83334f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.GroupHeader1.Controls.AddRange(new XRControl[3]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrPictureBox2
      });
      this.GroupHeader1.HeightF = 85.83334f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable5.Borders = BorderSide.All;
      this.xrTable5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable5.LocationFloat = new PointFloat(623.1667f, 0.0f);
      this.xrTable5.Name = "xrTable5";
      this.xrTable5.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable5.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow5
      });
      this.xrTable5.SizeF = new SizeF(124.8332f, 37.5f);
      this.xrTable5.StylePriority.UseBorders = false;
      this.xrTable5.StylePriority.UseFont = false;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell9
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "Toplam KM";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 1.0;
      this.xrTable4.Borders = BorderSide.All;
      this.xrTable4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable4.LocationFloat = new PointFloat(524.1667f, 0.0f);
      this.xrTable4.Name = "xrTable4";
      this.xrTable4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable4.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow4
      });
      this.xrTable4.SizeF = new SizeF(98.99994f, 37.5f);
      this.xrTable4.StylePriority.UseBorders = false;
      this.xrTable4.StylePriority.UseFont = false;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell8
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Mesai Dışı";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 1.0;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable3.LocationFloat = new PointFloat(237.6668f, 0.0f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow3
      });
      this.xrTable3.SizeF = new SizeF(286.5f, 37.5f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTable3.StylePriority.UseFont = false;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell7
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Tahsis Edilen";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 1.0177640703311401;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Ünvan";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.95;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Mesai İçi";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 0.90833404541015628;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTable2.LocationFloat = new PointFloat(2.000173f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(235.6666f, 37.5f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseFont = false;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell2,
        this.xrTableCell3,
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "S.NO";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.44068819900008666;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Birim Adı";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 1.1843118009999134;
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Plaka";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 0.74059341964569536;
      this.xrTable14.Borders = BorderSide.All;
      this.xrTable14.LocationFloat = new PointFloat(624.1667f, 0.0f);
      this.xrTable14.Name = "xrTable14";
      this.xrTable14.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable14.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow14
      });
      this.xrTable14.SizeF = new SizeF(123.8331f, 25f);
      this.xrTable14.StylePriority.UseBorders = false;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell20
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLAMKM]")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.Text = "Çalışma Saati";
      this.xrTableCell20.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell20.Weight = 1.0;
      this.xrTable13.Borders = BorderSide.All;
      this.xrTable13.LocationFloat = new PointFloat(524.1667f, 0.0f);
      this.xrTable13.Name = "xrTable13";
      this.xrTable13.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable13.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow13
      });
      this.xrTable13.SizeF = new SizeF(100f, 25f);
      this.xrTable13.StylePriority.UseBorders = false;
      this.xrTableRow13.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell19
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MESAIDISI]")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseTextAlignment = false;
      this.xrTableCell19.Text = "Toplam KM";
      this.xrTableCell19.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell19.Weight = 1.0;
      this.xrTable12.Borders = BorderSide.All;
      this.xrTable12.LocationFloat = new PointFloat(237.6668f, 0.0f);
      this.xrTable12.Name = "xrTable12";
      this.xrTable12.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable12.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow12
      });
      this.xrTable12.SizeF = new SizeF(286.4999f, 25f);
      this.xrTable12.StylePriority.UseBorders = false;
      this.xrTableRow12.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell13,
        this.xrTableCell14,
        this.xrTableCell18
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = "Ünvanı";
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 1.0087919170157686;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[UNVAN]")
      });
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.Text = "Mesai İçi";
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell14.Weight = 0.96662420494260781;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MESAIICI]")
      });
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.Text = "Mesai Dışı";
      this.xrTableCell18.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell18.Weight = 0.91186631671959673;
      this.xrTable11.Borders = BorderSide.All;
      this.xrTable11.LocationFloat = new PointFloat(2.000173f, 0.0f);
      this.xrTable11.Name = "xrTable11";
      this.xrTable11.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable11.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow11
      });
      this.xrTable11.SizeF = new SizeF(235.6666f, 25f);
      this.xrTable11.StylePriority.UseBorders = false;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell15,
        this.xrTableCell16,
        this.xrTableCell17
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell15.Summary = xrSummary;
      this.xrTableCell15.Text = "S.NO";
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 0.4423639688037902;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "Plaka";
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell16.Weight = 1.1826364149779811;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLARACMESTKP_PLAKA]")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Tahsis Edilen";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell17.Weight = 0.74958827721379917;
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
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
      this.DataMember = "TBLARACLAR_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(62, 39, 100, 25);
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.Version = "20.1";
      this.xrTable5.EndInit();
      this.xrTable4.EndInit();
      this.xrTable3.EndInit();
      this.xrTable2.EndInit();
      this.xrTable14.EndInit();
      this.xrTable13.EndInit();
      this.xrTable12.EndInit();
      this.xrTable11.EndInit();
      this.EndInit();
    }
  }
}
