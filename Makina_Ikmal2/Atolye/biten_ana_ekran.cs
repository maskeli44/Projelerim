// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.biten_ana_ekran
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Atolye
{
  public class biten_ana_ekran : XtraReport
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
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private GroupHeaderBand GroupHeader1;
    private DetailBand Detail;
    private Parameter idemir;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private XRSubreport xrSubreport2;
    private XRSubreport xrSubreport1;
    private Parameter idemir1;
    private Parameter idemir2;
    private PageFooterBand PageFooter;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell12;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel11;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel12;
    private XRPictureBox xrPictureBox2;

    public biten_ana_ekran() => this.InitializeComponent();

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
      Table table2 = new Table();
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
      Table table3 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table4 = new Table();
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
      Table table5 = new Table();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table6 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (biten_ana_ekran));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel11 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell55 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell56 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.Detail = new DetailBand();
      this.idemir = new Parameter();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.idemir1 = new Parameter();
      this.idemir2 = new Parameter();
      this.PageFooter = new PageFooterBand();
      this.xrSubreport2 = new XRSubreport();
      this.xrSubreport1 = new XRSubreport();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "KOD";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table1.Name = "TBLISEMRI";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "GIRISTARIH";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "PLAKA";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table2.Name = "TBLARACLAR";
      columnExpression3.Table = table2;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "ARACACIKLAMA";
      columnExpression4.Table = table2;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "CIKISTARIH";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "GIRISSAAT";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "CIKISSAAT";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "BAKIMSAATI";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "ADI";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table3.Name = "TBLBAKIMYERI";
      columnExpression9.Table = table3;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "BILDIRILENARIZA";
      columnExpression10.Table = table1;
      column10.Expression = (ExpressionBase) columnExpression10;
      selectQuery1.Columns.Add((ColumnBase) column1);
      selectQuery1.Columns.Add((ColumnBase) column2);
      selectQuery1.Columns.Add((ColumnBase) column3);
      selectQuery1.Columns.Add((ColumnBase) column4);
      selectQuery1.Columns.Add((ColumnBase) column5);
      selectQuery1.Columns.Add((ColumnBase) column6);
      selectQuery1.Columns.Add((ColumnBase) column7);
      selectQuery1.Columns.Add((ColumnBase) column8);
      selectQuery1.Columns.Add((ColumnBase) column9);
      selectQuery1.Columns.Add((ColumnBase) column10);
      selectQuery1.Name = "TBLISEMRI_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "BAKIMYERIID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      columnExpression11.ColumnName = "ID";
      table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"725\" />";
      table4.Name = "TBLISEMRI";
      columnExpression11.Table = table4;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "KOD";
      columnExpression12.Table = table4;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "GIRISTARIH";
      columnExpression13.Table = table4;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "GIRISSAAT";
      columnExpression14.Table = table4;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "CIKISTARIH";
      columnExpression15.Table = table4;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "CIKISSAAT";
      columnExpression16.Table = table4;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "PLAKA";
      table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"1485\" />";
      table5.Name = "TBLARACLAR";
      columnExpression17.Table = table5;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "ARACACIKLAMA";
      columnExpression18.Table = table5;
      column18.Expression = (ExpressionBase) columnExpression18;
      columnExpression19.ColumnName = "ADI";
      table6.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table6.Name = "TBLBAKIMYERI";
      columnExpression19.Table = table6;
      column19.Expression = (ExpressionBase) columnExpression19;
      columnExpression20.ColumnName = "BILDIRILENARIZA";
      columnExpression20.Table = table4;
      column20.Expression = (ExpressionBase) columnExpression20;
      selectQuery2.Columns.Add((ColumnBase) column11);
      selectQuery2.Columns.Add((ColumnBase) column12);
      selectQuery2.Columns.Add((ColumnBase) column13);
      selectQuery2.Columns.Add((ColumnBase) column14);
      selectQuery2.Columns.Add((ColumnBase) column15);
      selectQuery2.Columns.Add((ColumnBase) column16);
      selectQuery2.Columns.Add((ColumnBase) column17);
      selectQuery2.Columns.Add((ColumnBase) column18);
      selectQuery2.Columns.Add((ColumnBase) column19);
      selectQuery2.Columns.Add((ColumnBase) column20);
      selectQuery2.Name = "TBLISEMRI_2";
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "ARACID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table5;
      join3.Parent = table4;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "BAKIMYERIID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table6;
      join4.Parent = table4;
      selectQuery2.Relations.Add(join3);
      selectQuery2.Relations.Add(join4);
      selectQuery2.Tables.Add(table4);
      selectQuery2.Tables.Add(table5);
      selectQuery2.Tables.Add(table6);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[2]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.DetailCaption1.BackColor = Color.FromArgb(69, 94, 178);
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
      this.DetailData3_Odd.BackColor = Color.FromArgb(243, 245, 248);
      this.DetailData3_Odd.BorderColor = Color.Transparent;
      this.DetailData3_Odd.Borders = BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1f;
      this.DetailData3_Odd.Font = new Font("Arial", 8.25f);
      this.DetailData3_Odd.ForeColor = Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData3_Odd.TextAlignment = TextAlignment.MiddleLeft;
      this.PageInfo.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.PageInfo.ForeColor = Color.FromArgb(64, 70, 80);
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.TopMargin.Controls.AddRange(new XRControl[6]
      {
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrPictureBox2
      });
      this.TopMargin.HeightF = 108f;
      this.TopMargin.Name = "TopMargin";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(4.999995f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 90f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel11.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(208.1881f, 8.666691f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "T.C. ";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel13.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel13.LocationFloat = new PointFloat(209.8548f, 26.66667f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "ŞANLIURFA BÜYÜKŞEHİR BAŞKANLIĞI";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel14.Font = new Font("Arial", 8f);
      this.xrLabel14.LocationFloat = new PointFloat(208.1881f, 46.50004f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(342.5f, 17.99998f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Destek Hizmetleri Daire Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel14.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel12.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel12.LocationFloat = new PointFloat(196.1882f, 64.50002f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(356.1666f, 25.49998f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "İŞ EMRİ FORMU (ARAÇ BAKIM)";
      this.xrLabel12.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(617.1541f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(145.8459f, 90f);
      this.BottomMargin.HeightF = 2f;
      this.BottomMargin.Name = "BottomMargin";
      this.pageInfo1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(371.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(391.5f, 0.0f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(371.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 115.625f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrTable1.Borders = BorderSide.All;
      this.xrTable1.BorderWidth = 2f;
      this.xrTable1.LocationFloat = new PointFloat(7.947286E-06f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[3]
      {
        this.xrTableRow1,
        this.xrTableRow3,
        this.xrTableRow4
      });
      this.xrTable1.SizeF = new SizeF(763.0001f, 115.3333f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseBorderWidth = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell1,
        this.xrTableCell2,
        this.xrTableCell17
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Arac Bilgisi";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell1.Weight = 1.0;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 2.0;
      this.xrTableCell17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.Text = "xrTableCell17";
      this.xrTableCell17.Weight = 3.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell7,
        this.xrTableCell8,
        this.xrTableCell14,
        this.xrTableCell18,
        this.xrTableCell55,
        this.xrTableCell22,
        this.xrTableCell9
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "İş Emri Kodu";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell7.Weight = 1.0;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Text = "xrTableCell8";
      this.xrTableCell8.Weight = 1.0;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.Text = "Giriş Tarihi";
      this.xrTableCell14.Weight = 0.72222231910342261;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GIRISTARIH]")
      });
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.Text = "xrTableCell18";
      this.xrTableCell18.TextFormatString = "{0:d MMMM yyyy dddd}";
      this.xrTableCell18.Weight = 0.77777768089657739;
      this.xrTableCell55.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GIRISSAAT]")
      });
      this.xrTableCell55.Multiline = true;
      this.xrTableCell55.Name = "xrTableCell55";
      this.xrTableCell55.Text = "xrTableCell55";
      this.xrTableCell55.TextFormatString = "{0:HH:mm}";
      this.xrTableCell55.Weight = 0.77301548549107135;
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.RowSpan = 2;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.Text = "Bakım Yeri";
      this.xrTableCell22.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell22.Weight = 0.72698451450892865;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.RowSpan = 2;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "xrTableCell9";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 1.0;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[7]
      {
        this.xrTableCell10,
        this.xrTableCell11,
        this.xrTableCell15,
        this.xrTableCell19,
        this.xrTableCell56,
        this.xrTableCell23,
        this.xrTableCell12
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "Kilometre";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell10.Weight = 1.0;
      this.xrTableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?km")
      });
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.Text = "xrTableCell11";
      this.xrTableCell11.Weight = 1.0;
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.Text = "Çıkış Tarihi";
      this.xrTableCell15.Weight = 0.72222231910342261;
      this.xrTableCell19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISTARIH]")
      });
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.Text = "xrTableCell19";
      this.xrTableCell19.Weight = 0.77777768089657739;
      this.xrTableCell56.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISSAAT]")
      });
      this.xrTableCell56.Multiline = true;
      this.xrTableCell56.Name = "xrTableCell56";
      this.xrTableCell56.Text = "xrTableCell56";
      this.xrTableCell56.Weight = 0.77301606677827384;
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.Text = "xrTableCell23";
      this.xrTableCell23.Weight = 0.72698393322172616;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.Text = "xrTableCell12";
      this.xrTableCell12.Weight = 1.0;
      this.Detail.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrSubreport2,
        (XRControl) this.xrSubreport1
      });
      this.Detail.HeightF = 80.20827f;
      this.Detail.Name = "Detail";
      this.idemir.Description = "Parameter1";
      this.idemir.Name = "idemir";
      this.idemir.Type = typeof (int);
      this.idemir.ValueInfo = "0";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.idemir1.Description = "Parameter1";
      this.idemir1.Name = "idemir1";
      this.idemir1.Type = typeof (int);
      this.idemir1.ValueInfo = "0";
      this.idemir2.Description = "Parameter1";
      this.idemir2.Name = "idemir2";
      this.idemir2.Type = typeof (int);
      this.idemir2.ValueInfo = "0";
      this.PageFooter.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo2,
        (XRControl) this.pageInfo1
      });
      this.PageFooter.HeightF = 26.9584f;
      this.PageFooter.Name = "PageFooter";
      this.xrSubreport2.LocationFloat = new PointFloat(0.0f, 51.12502f);
      this.xrSubreport2.Name = "xrSubreport2";
      this.xrSubreport2.ParameterBindings.Add(new ParameterBinding("idemir1", (object) null, "TBLISEMRI_2.ID"));
      this.xrSubreport2.ReportSource = (XtraReport) new bitenmalzemeRaporu();
      this.xrSubreport2.SizeF = new SizeF(763f, 27.79165f);
      this.xrSubreport1.LocationFloat = new PointFloat(0.0f, 25f);
      this.xrSubreport1.Name = "xrSubreport1";
      this.xrSubreport1.ParameterBindings.Add(new ParameterBinding("idemri2", (object) null, "TBLISEMRI_2.ID"));
      this.xrSubreport1.ReportSource = (XtraReport) new usta_isemri_biten();
      this.xrSubreport1.SizeF = new SizeF(763.0001f, 26.12502f);
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.GroupHeader1,
        (Band) this.Detail,
        (Band) this.PageFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLISEMRI_2";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?idemir";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(15, 6, 108, 2);
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5Rotated;
      this.Parameters.AddRange(new Parameter[3]
      {
        this.idemir,
        this.idemir1,
        this.idemir2
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
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
