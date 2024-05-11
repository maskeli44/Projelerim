// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.Raporlar.ResmiAracTeslim
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.AracBolumu.Raporlar
{
  public class ResmiAracTeslim : XtraReport
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
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRLabel xrLabel1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel15;
    private XRLabel xrLabel16;
    private XRLabel xrLabel18;
    private XRLabel xrLabel19;
    private XRLabel xrLabel20;
    private XRLabel xrLabel21;
    private XRLabel xrLabel22;
    private XRLabel xrLabel23;
    private Parameter aracID;
    private XRLabel xrLabel2;
    private XRLabel xrLabel17;
    private Parameter tarih;
    private Parameter saat;

    public ResmiAracTeslim() => this.InitializeComponent();

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
      Table table2 = new Table();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Table table3 = new Table();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Table table4 = new Table();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Table table5 = new Table();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table6 = new Table();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table7 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Table table8 = new Table();
      QueryParameter queryParameter1 = new QueryParameter();
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
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      SelectQuery selectQuery2 = new SelectQuery();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Table table9 = new Table();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      QueryParameter queryParameter2 = new QueryParameter();
      QueryParameter queryParameter3 = new QueryParameter();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ResmiAracTeslim));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrLabel2 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrLabel1 = new XRLabel();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrLabel5 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrLabel18 = new XRLabel();
      this.xrLabel19 = new XRLabel();
      this.xrLabel20 = new XRLabel();
      this.xrLabel21 = new XRLabel();
      this.xrLabel22 = new XRLabel();
      this.xrLabel23 = new XRLabel();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel4 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.aracID = new Parameter();
      this.tarih = new Parameter();
      this.saat = new Parameter();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"425\" />";
      table1.Name = "TBLARACZIMMET";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "PLAKA";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"1545\" />";
      table2.Name = "TBLARACLAR";
      columnExpression2.Table = table2;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "ARACMARKA";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table3.Name = "TBLARACMARKA";
      columnExpression3.Table = table3;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "BELDMUDURLUK";
      table4.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"285\" />";
      table4.Name = "TBLBELDMUDURLUK";
      columnExpression4.Table = table4;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "TARIH";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "SAAT";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "TCKIMLIKNO";
      table5.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression7.Table = table5;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "ADISOYADI";
      columnExpression8.Table = table5;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "CEPTELEFON";
      columnExpression9.Table = table5;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "ARACTIPI";
      table6.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"105\" />";
      table6.Name = "TAHARACTIPI";
      columnExpression10.Table = table6;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "BELDBIRIMADI";
      table7.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"265\" />";
      table7.Name = "TBLBELDBIRIMLER";
      columnExpression11.Table = table7;
      column11.Expression = (ExpressionBase) columnExpression11;
      column12.Alias = "TBLBELDMUDURLUK_1_BELDMUDURLUK";
      columnExpression12.ColumnName = "BELDMUDURLUK";
      table8.Alias = "TBLBELDMUDURLUK_1";
      table8.MetaSerializable = "<Meta X=\"1270\" Y=\"30\" Width=\"125\" Height=\"285\" />";
      table8.Name = "TBLBELDMUDURLUK";
      columnExpression12.Table = table8;
      column12.Expression = (ExpressionBase) columnExpression12;
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
      selectQuery1.Columns.Add((ColumnBase) column11);
      selectQuery1.Columns.Add((ColumnBase) column12);
      selectQuery1.FilterString = "[TBLARACZIMMET.ID] = ?aracID";
      selectQuery1.GroupFilterString = "";
      selectQuery1.Name = "TBLTEKLIF_1";
      queryParameter1.Name = "aracID";
      queryParameter1.Type = typeof (Expression);
      queryParameter1.Value = (object) new Expression("?aracID", typeof (int));
      selectQuery1.Parameters.Add(queryParameter1);
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "ARACID";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      join1.Type = JoinType.LeftOuter;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "MARKAID";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table2;
      join2.Type = JoinType.LeftOuter;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "BELDMUDURLUKID";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table2;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "ZIMMETALANID";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      join4.Type = JoinType.LeftOuter;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ARACTIPIID";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table6;
      join5.Parent = table2;
      join5.Type = JoinType.LeftOuter;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "BELDBIRIMID";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table7;
      join6.Parent = table1;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "BELDMUDURLUKID";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table8;
      join7.Parent = table1;
      selectQuery1.Relations.Add(join1);
      selectQuery1.Relations.Add(join2);
      selectQuery1.Relations.Add(join3);
      selectQuery1.Relations.Add(join4);
      selectQuery1.Relations.Add(join5);
      selectQuery1.Relations.Add(join6);
      selectQuery1.Relations.Add(join7);
      selectQuery1.Tables.Add(table1);
      selectQuery1.Tables.Add(table2);
      selectQuery1.Tables.Add(table3);
      selectQuery1.Tables.Add(table4);
      selectQuery1.Tables.Add(table5);
      selectQuery1.Tables.Add(table6);
      selectQuery1.Tables.Add(table7);
      selectQuery1.Tables.Add(table8);
      columnExpression13.ColumnName = "TARIH";
      table9.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"423\" />";
      table9.Name = "TBLARACZIMMET";
      columnExpression13.Table = table9;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "SAAT";
      columnExpression14.Table = table9;
      column14.Expression = (ExpressionBase) columnExpression14;
      selectQuery2.Columns.Add((ColumnBase) column13);
      selectQuery2.Columns.Add((ColumnBase) column14);
      selectQuery2.FilterString = "[TBLARACZIMMET.ARACID] = ?aracID";
      selectQuery2.GroupFilterString = "";
      selectQuery2.Name = "Tarih";
      queryParameter2.Name = "kod";
      queryParameter2.Type = typeof (Expression);
      queryParameter2.Value = (object) new Expression("?kod", typeof (string));
      queryParameter3.Name = "aracID";
      queryParameter3.Type = typeof (Expression);
      queryParameter3.Value = (object) new Expression("?aracID", typeof (int));
      selectQuery2.Parameters.Add(queryParameter2);
      selectQuery2.Parameters.Add(queryParameter3);
      selectQuery2.Tables.Add(table9);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[2]
      {
        (SqlQuery) selectQuery1,
        (SqlQuery) selectQuery2
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[22]
      {
        (XRControl) this.xrLabel2,
        (XRControl) this.xrTable1,
        (XRControl) this.xrTable2,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel17,
        (XRControl) this.xrLabel18,
        (XRControl) this.xrLabel19,
        (XRControl) this.xrLabel20,
        (XRControl) this.xrLabel21,
        (XRControl) this.xrLabel22,
        (XRControl) this.xrLabel23
      });
      this.Detail.HeightF = 576.6666f;
      this.Detail.Name = "Detail";
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACTIPI]")
      });
      this.xrLabel2.LocationFloat = new PointFloat(350.5f, 322.3333f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(100f, 23f);
      this.xrLabel2.Text = "xrLabel2";
      this.xrTable1.LocationFloat = new PointFloat(26.50004f, 31.95829f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(677.6666f, 62.5f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Text = "xrTableCell1";
      this.xrTableCell1.Weight = 1.0;
      this.xrLabel1.Borders = BorderSide.None;
      this.xrLabel1.Font = new Font("Arial", 14f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(153.4999f, 9.999998f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(358.1249f, 23f);
      this.xrLabel1.StylePriority.UseBorders = false;
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = " ARAÇ TESLİM TUTANAĞI";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTable2.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTable2.LocationFloat = new PointFloat(25.83338f, 94.4583f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(677.6666f, 211.875f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Font = new Font("Arial", 14f);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.Text = componentResourceManager.GetString("xrTableCell2.Text");
      this.xrTableCell2.Weight = 1.0;
      this.xrLabel5.LocationFloat = new PointFloat(50.04171f, 322.3333f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(133.3333f, 23.00002f);
      this.xrLabel5.Text = "Plakası                 :";
      this.xrLabel6.LocationFloat = new PointFloat(50.04171f, 345.3333f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(133.3333f, 22.99997f);
      this.xrLabel6.Text = "Araç Markası       :";
      this.xrLabel7.LocationFloat = new PointFloat(50.04165f, 368.3333f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(119.1667f, 23.00003f);
      this.xrLabel7.Text = "Daire Başkanlığı  :";
      this.xrLabel8.LocationFloat = new PointFloat(50.04165f, 391.3334f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(133.3333f, 23.00003f);
      this.xrLabel8.Text = "Müdürlüğü             :";
      this.xrLabel9.LocationFloat = new PointFloat(50.04171f, 414.3333f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(133.3333f, 23.00003f);
      this.xrLabel9.Text = "T.C Kimlik No       :";
      this.xrLabel10.LocationFloat = new PointFloat(50.04165f, 437.3335f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(133.3333f, 23.00003f);
      this.xrLabel10.Text = "Adı Soyadı            :";
      this.xrLabel11.LocationFloat = new PointFloat(50.04171f, 460.3334f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(133.3333f, 23.00009f);
      this.xrLabel11.Text = "Telefon                  :";
      this.xrLabel12.LocationFloat = new PointFloat(50.04165f, 483.3335f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(133.3333f, 23.00006f);
      this.xrLabel12.Text = "Tarih                      :";
      this.xrLabel13.LocationFloat = new PointFloat(50.04171f, 506.3336f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(133.3333f, 23.00006f);
      this.xrLabel13.Text = "Saat                      :";
      this.xrLabel14.LocationFloat = new PointFloat(50.04171f, 529.3336f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(66.66666f, 23.00009f);
      this.xrLabel14.Text = "İmza";
      this.xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.xrLabel15.LocationFloat = new PointFloat(183.3749f, 322.3333f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(100f, 23f);
      this.xrLabel15.Text = "xrLabel15";
      this.xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACMARKA]")
      });
      this.xrLabel16.LocationFloat = new PointFloat(183.3749f, 345.3333f);
      this.xrLabel16.Multiline = true;
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(100f, 23f);
      this.xrLabel16.Text = "xrLabel16";
      this.xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BELDBIRIMADI]")
      });
      this.xrLabel17.LocationFloat = new PointFloat(183.3749f, 368.3333f);
      this.xrLabel17.Multiline = true;
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel17.Text = "xrLabel17";
      this.xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLBELDMUDURLUK_1_BELDMUDURLUK]")
      });
      this.xrLabel18.LocationFloat = new PointFloat(183.3749f, 391.3334f);
      this.xrLabel18.Multiline = true;
      this.xrLabel18.Name = "xrLabel18";
      this.xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel18.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel18.Text = "xrLabel18";
      this.xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TCKIMLIKNO]")
      });
      this.xrLabel19.LocationFloat = new PointFloat(183.3749f, 414.3335f);
      this.xrLabel19.Multiline = true;
      this.xrLabel19.Name = "xrLabel19";
      this.xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel19.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel19.Text = "xrLabel19";
      this.xrLabel20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrLabel20.LocationFloat = new PointFloat(183.3749f, 437.3335f);
      this.xrLabel20.Multiline = true;
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel20.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel20.Text = "xrLabel20";
      this.xrLabel21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CEPTELEFON]")
      });
      this.xrLabel21.LocationFloat = new PointFloat(183.3749f, 460.3334f);
      this.xrLabel21.Multiline = true;
      this.xrLabel21.Name = "xrLabel21";
      this.xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel21.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel21.Text = "xrLabel21";
      this.xrLabel22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.xrLabel22.LocationFloat = new PointFloat(183.3749f, 483.3336f);
      this.xrLabel22.Multiline = true;
      this.xrLabel22.Name = "xrLabel22";
      this.xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel22.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel22.Text = "xrLabel22";
      this.xrLabel22.TextFormatString = "{0:d.MM.yyyy}";
      this.xrLabel23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAAT]")
      });
      this.xrLabel23.LocationFloat = new PointFloat(183.3749f, 506.3336f);
      this.xrLabel23.Multiline = true;
      this.xrLabel23.Name = "xrLabel23";
      this.xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel23.SizeF = new SizeF(463.5417f, 23f);
      this.xrLabel23.Text = "xrLabel23";
      this.xrLabel23.TextFormatString = "{0:HH:mm:ss}";
      this.PageHeader.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrPictureBox1
      });
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(595.4584f, 7.500025f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(129.5417f, 89.99995f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(138.3333f, 58.70834f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(125.8334f, 35.70834f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(25.83338f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.aracID.Name = "aracID";
      this.aracID.Type = typeof (int);
      this.aracID.ValueInfo = "0";
      this.tarih.Description = "Parameter1";
      this.tarih.Name = "tarih";
      this.tarih.Type = typeof (DateTime);
      this.tarih.ValueInfo = "2022-01-18";
      this.saat.Description = "Parameter1";
      this.saat.Name = "saat";
      this.saat.Type = typeof (DateTime);
      this.saat.ValueInfo = "2022-01-18";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.PageHeader
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLTEKLIF_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?aracID";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(62, 47, 100, 100);
      this.Parameters.AddRange(new Parameter[3]
      {
        this.aracID,
        this.tarih,
        this.saat
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.EndInit();
    }
  }
}
