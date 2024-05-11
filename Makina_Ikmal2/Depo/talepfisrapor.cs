// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.talepfisrapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Depo
{
  public class talepfisrapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle GroupCaption1;
    private XRControlStyle GroupData1;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle GroupFooterBackground3;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private GroupHeaderBand GroupHeader2;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private GroupHeaderBand GroupHeader3;
    private XRTable table3;
    private XRTableRow tableRow3;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private GroupHeaderBand GroupHeader4;
    private XRTable table4;
    private XRTableRow tableRow4;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private GroupHeaderBand GroupHeader5;
    private XRTable table5;
    private XRTableRow tableRow5;
    private XRTableCell tableCell9;
    private XRTable table6;
    private XRTableRow tableRow6;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTable table7;
    private XRTableRow tableRow7;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
    private XRTable table8;
    private XRTableRow tableRow8;
    private XRTableCell tableCell15;
    private XRTableCell tableCell16;
    private GroupHeaderBand GroupHeader9;
    private XRTable table9;
    private XRTableRow tableRow9;
    private XRTableCell tableCell17;
    private XRTableCell tableCell18;
    private GroupHeaderBand GroupHeader10;
    private XRTable table10;
    private XRTableRow tableRow10;
    private XRTableCell tableCell19;
    private XRTableCell tableCell20;
    private GroupHeaderBand GroupHeader11;
    private XRTable table11;
    private XRTableRow tableRow11;
    private XRTableCell tableCell21;
    private XRTableCell tableCell22;
    private GroupHeaderBand GroupHeader12;
    private XRTable table12;
    private XRTableRow tableRow12;
    private XRTableCell tableCell23;
    private XRTableCell tableCell24;
    private XRTableCell tableCell25;
    private XRTableCell tableCell26;
    private XRTableCell tableCell27;
    private XRTableCell tableCell28;
    private XRTableCell tableCell29;
    private DetailBand Detail;
    private XRTable table13;
    private XRTableRow tableRow13;
    private XRTableCell tableCell30;
    private XRTableCell tableCell31;
    private XRTableCell tableCell32;
    private XRTableCell tableCell33;
    private XRTableCell tableCell34;
    private XRTableCell tableCell35;
    private XRTableCell tableCell36;
    private GroupFooterBand GroupFooter1;
    private XRLabel label2;
    private PageFooterBand PageFooter;
    private Parameter id;

    public talepfisrapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      CustomSqlQuery customSqlQuery = new CustomSqlQuery();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (talepfisrapor));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.GroupCaption1 = new XRControlStyle();
      this.GroupData1 = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.GroupFooterBackground3 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.GroupHeader1 = new GroupHeaderBand();
      this.GroupHeader2 = new GroupHeaderBand();
      this.GroupHeader3 = new GroupHeaderBand();
      this.GroupHeader4 = new GroupHeaderBand();
      this.GroupHeader5 = new GroupHeaderBand();
      this.GroupHeader9 = new GroupHeaderBand();
      this.GroupHeader10 = new GroupHeaderBand();
      this.GroupHeader11 = new GroupHeaderBand();
      this.GroupHeader12 = new GroupHeaderBand();
      this.Detail = new DetailBand();
      this.GroupFooter1 = new GroupFooterBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.label1 = new XRLabel();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.table3 = new XRTable();
      this.tableRow3 = new XRTableRow();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.table4 = new XRTable();
      this.tableRow4 = new XRTableRow();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.table5 = new XRTable();
      this.tableRow5 = new XRTableRow();
      this.tableCell9 = new XRTableCell();
      this.table6 = new XRTable();
      this.tableRow6 = new XRTableRow();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.table7 = new XRTable();
      this.tableRow7 = new XRTableRow();
      this.tableCell13 = new XRTableCell();
      this.tableCell14 = new XRTableCell();
      this.table8 = new XRTable();
      this.tableRow8 = new XRTableRow();
      this.tableCell15 = new XRTableCell();
      this.tableCell16 = new XRTableCell();
      this.table9 = new XRTable();
      this.tableRow9 = new XRTableRow();
      this.tableCell17 = new XRTableCell();
      this.tableCell18 = new XRTableCell();
      this.table10 = new XRTable();
      this.tableRow10 = new XRTableRow();
      this.tableCell19 = new XRTableCell();
      this.tableCell20 = new XRTableCell();
      this.table11 = new XRTable();
      this.tableRow11 = new XRTableRow();
      this.tableCell21 = new XRTableCell();
      this.tableCell22 = new XRTableCell();
      this.table12 = new XRTable();
      this.tableRow12 = new XRTableRow();
      this.tableCell23 = new XRTableCell();
      this.tableCell24 = new XRTableCell();
      this.tableCell25 = new XRTableCell();
      this.tableCell26 = new XRTableCell();
      this.tableCell27 = new XRTableCell();
      this.tableCell28 = new XRTableCell();
      this.tableCell29 = new XRTableCell();
      this.table13 = new XRTable();
      this.tableRow13 = new XRTableRow();
      this.tableCell30 = new XRTableCell();
      this.tableCell31 = new XRTableCell();
      this.tableCell32 = new XRTableCell();
      this.tableCell33 = new XRTableCell();
      this.tableCell34 = new XRTableCell();
      this.tableCell35 = new XRTableCell();
      this.tableCell36 = new XRTableCell();
      this.label2 = new XRLabel();
      this.PageFooter = new PageFooterBand();
      this.id = new Parameter();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.table3.BeginInit();
      this.table4.BeginInit();
      this.table5.BeginInit();
      this.table6.BeginInit();
      this.table7.BeginInit();
      this.table8.BeginInit();
      this.table9.BeginInit();
      this.table10.BeginInit();
      this.table11.BeginInit();
      this.table12.BeginInit();
      this.table13.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      customSqlQuery.Name = "Query";
      customSqlQuery.Sql = componentResourceManager.GetString("customSqlQuery1.Sql");
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) customSqlQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(64, 70, 80);
      this.Title.Name = "Title";
      this.GroupCaption1.BackColor = Color.FromArgb(93, 98, 110);
      this.GroupCaption1.BorderColor = Color.White;
      this.GroupCaption1.Borders = BorderSide.Bottom;
      this.GroupCaption1.BorderWidth = 2f;
      this.GroupCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupCaption1.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupCaption1.Name = "GroupCaption1";
      this.GroupCaption1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.GroupData1.BackColor = Color.FromArgb(93, 98, 110);
      this.GroupData1.BorderColor = Color.White;
      this.GroupData1.Borders = BorderSide.Bottom;
      this.GroupData1.BorderWidth = 2f;
      this.GroupData1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupData1.ForeColor = Color.White;
      this.GroupData1.Name = "GroupData1";
      this.GroupData1.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailCaption1.BackColor = Color.FromArgb(93, 98, 110);
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
      this.GroupFooterBackground3.BackColor = Color.FromArgb(109, 117, 129);
      this.GroupFooterBackground3.BorderColor = Color.White;
      this.GroupFooterBackground3.Borders = BorderSide.Bottom;
      this.GroupFooterBackground3.BorderWidth = 2f;
      this.GroupFooterBackground3.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.GroupFooterBackground3.ForeColor = Color.FromArgb(228, 228, 228);
      this.GroupFooterBackground3.Name = "GroupFooterBackground3";
      this.GroupFooterBackground3.Padding = new PaddingInfo(6, 2, 0, 0, 100f);
      this.GroupFooterBackground3.TextAlignment = TextAlignment.MiddleLeft;
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
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.pageInfo1,
        (XRControl) this.pageInfo2
      });
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
      this.ReportHeader.HeightF = 60f;
      this.ReportHeader.Name = "ReportHeader";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("TALEPFISID", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 27f;
      this.GroupHeader1.Level = 1;
      this.GroupHeader1.Name = "GroupHeader1";
      this.GroupHeader2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.GroupHeader2.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("mudur", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader2.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader2.HeightF = 27f;
      this.GroupHeader2.Level = 2;
      this.GroupHeader2.Name = "GroupHeader2";
      this.GroupHeader3.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table3
      });
      this.GroupHeader3.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("depoyet", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader3.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader3.HeightF = 27f;
      this.GroupHeader3.Level = 3;
      this.GroupHeader3.Name = "GroupHeader3";
      this.GroupHeader4.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table4
      });
      this.GroupHeader4.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("atolye", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader4.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader4.HeightF = 27f;
      this.GroupHeader4.Level = 4;
      this.GroupHeader4.Name = "GroupHeader4";
      this.GroupHeader5.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("talepedenusta", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader5.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader5.HeightF = 27f;
      this.GroupHeader5.Level = 5;
      this.GroupHeader5.Name = "GroupHeader5";
      this.GroupHeader9.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.table6,
        (XRControl) this.table7,
        (XRControl) this.table8,
        (XRControl) this.table9
      });
      this.GroupHeader9.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("TARIH", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader9.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader9.HeightF = 27.00002f;
      this.GroupHeader9.Level = 6;
      this.GroupHeader9.Name = "GroupHeader9";
      this.GroupHeader10.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table10
      });
      this.GroupHeader10.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("ARACACIKLAMA", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader10.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader10.HeightF = 27f;
      this.GroupHeader10.Level = 7;
      this.GroupHeader10.Name = "GroupHeader10";
      this.GroupHeader11.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table11
      });
      this.GroupHeader11.GroupFields.AddRange(new GroupField[1]
      {
        new GroupField("PLAKA", XRColumnSortOrder.Ascending)
      });
      this.GroupHeader11.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader11.HeightF = 27f;
      this.GroupHeader11.Level = 8;
      this.GroupHeader11.Name = "GroupHeader11";
      this.GroupHeader12.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table12
      });
      this.GroupHeader12.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader12.HeightF = 28f;
      this.GroupHeader12.Level = 9;
      this.GroupHeader12.Name = "GroupHeader12";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table13
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.GroupFooter1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label2
      });
      this.GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
      this.GroupFooter1.HeightF = 6f;
      this.GroupFooter1.Name = "GroupFooter1";
      this.pageInfo1.LocationFloat = new PointFloat(5f, 5f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(318f, 5f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.label1.LocationFloat = new PointFloat(5f, 5f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(617f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.Text = "Report Title";
      this.table1.LocationFloat = new PointFloat(0.0f, 2f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(627f, 25f);
      this.tableRow1.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell1,
        this.tableCell2
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "GroupCaption1";
      this.tableCell1.Text = "TALEPFISID";
      this.tableCell1.Weight = 0.11936544269275817;
      this.tableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TALEPFISID]")
      });
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "GroupData1";
      this.tableCell2.Weight = 0.88063450863486847;
      this.table2.LocationFloat = new PointFloat(0.0f, 2f);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(627f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell3,
        this.tableCell4
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 1.0;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "GroupCaption1";
      this.tableCell3.Text = "MUDUR";
      this.tableCell3.Weight = 0.0807723147256903;
      this.tableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[mudur]")
      });
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "GroupData1";
      this.tableCell4.Weight = 0.91922770961049638;
      this.table3.LocationFloat = new PointFloat(0.0f, 2f);
      this.table3.Name = "table3";
      this.table3.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow3
      });
      this.table3.SizeF = new SizeF(627f, 25f);
      this.tableRow3.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell5,
        this.tableCell6
      });
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 1.0;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "GroupCaption1";
      this.tableCell5.Text = "DEPOYET";
      this.tableCell5.Weight = 0.10009118282433713;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[depoyet]")
      });
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "GroupData1";
      this.tableCell6.Weight = 0.89990876850328949;
      this.table4.LocationFloat = new PointFloat(0.0f, 2f);
      this.table4.Name = "table4";
      this.table4.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow4
      });
      this.table4.SizeF = new SizeF(627f, 25f);
      this.tableRow4.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell7,
        this.tableCell8
      });
      this.tableRow4.Name = "tableRow4";
      this.tableRow4.Weight = 1.0;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "GroupCaption1";
      this.tableCell7.Text = "ATOLYE";
      this.tableCell7.Weight = 0.086875824266643614;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[atolye]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "GroupData1";
      this.tableCell8.Weight = 0.91312419398549638;
      this.table5.LocationFloat = new PointFloat(437.721f, 75f);
      this.table5.Name = "table5";
      this.table5.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow5
      });
      this.table5.SizeF = new SizeF(189.279f, 25f);
      this.tableRow5.Cells.AddRange(new XRTableCell[1]
      {
        this.tableCell9
      });
      this.tableRow5.Name = "tableRow5";
      this.tableRow5.Weight = 1.0;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[talepedenusta]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "GroupCaption1";
      this.tableCell9.Text = "TALEPEDENUSTA";
      this.tableCell9.Weight = 0.17318165853643341;
      this.table6.LocationFloat = new PointFloat(419.3398f, 2.00002f);
      this.table6.Name = "table6";
      this.table6.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow6
      });
      this.table6.SizeF = new SizeF(202.6602f, 25f);
      this.tableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell11,
        this.tableCell12
      });
      this.tableRow6.Name = "tableRow6";
      this.tableRow6.Weight = 1.0;
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "GroupCaption1";
      this.tableCell11.Text = "TBLISEMRI KOD";
      this.tableCell11.Weight = 0.11936544086471937;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TBLISEMRI_KOD]")
      });
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "GroupData1";
      this.tableCell12.Weight = 0.20385666067705038;
      this.table7.LocationFloat = new PointFloat(269.7517f, 2.00002f);
      this.table7.Name = "table7";
      this.table7.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow7
      });
      this.table7.SizeF = new SizeF(147.8334f, 25f);
      this.tableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell13,
        this.tableCell14
      });
      this.tableRow7.Name = "tableRow7";
      this.tableRow7.Weight = 1.0;
      this.tableCell13.Name = "tableCell13";
      this.tableCell13.StyleName = "GroupCaption1";
      this.tableCell13.Text = "KOD";
      this.tableCell13.Weight = 0.053368959320409068;
      this.tableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.tableCell14.Name = "tableCell14";
      this.tableCell14.StyleName = "GroupData1";
      this.tableCell14.Weight = 0.18240994518359777;
      this.table8.LocationFloat = new PointFloat(161.1667f, 2.00002f);
      this.table8.Name = "table8";
      this.table8.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow8
      });
      this.table8.SizeF = new SizeF(108.5849f, 25f);
      this.tableRow8.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell15,
        this.tableCell16
      });
      this.tableRow8.Name = "tableRow8";
      this.tableRow8.Weight = 1.0;
      this.tableCell15.Name = "tableCell15";
      this.tableCell15.StyleName = "GroupCaption1";
      this.tableCell15.Text = "SAAT";
      this.tableCell15.Weight = 0.062506382164962751;
      this.tableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SAAT]")
      });
      this.tableCell16.Name = "tableCell16";
      this.tableCell16.StyleName = "GroupData1";
      this.tableCell16.Weight = 0.1106752689959536;
      this.table9.LocationFloat = new PointFloat(0.0f, 2f);
      this.table9.Name = "table9";
      this.table9.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow9
      });
      this.table9.SizeF = new SizeF(161.1667f, 25f);
      this.tableRow9.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell17,
        this.tableCell18
      });
      this.tableRow9.Name = "tableRow9";
      this.tableRow9.Weight = 1.0;
      this.tableCell17.Name = "tableCell17";
      this.tableCell17.StyleName = "GroupCaption1";
      this.tableCell17.Text = "TARIH";
      this.tableCell17.Weight = 0.0685920532810631;
      this.tableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.tableCell18.Name = "tableCell18";
      this.tableCell18.StyleName = "GroupData1";
      this.tableCell18.Weight = 0.18845220823258757;
      this.table10.LocationFloat = new PointFloat(0.0f, 2f);
      this.table10.Name = "table10";
      this.table10.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow10
      });
      this.table10.SizeF = new SizeF(627f, 25f);
      this.tableRow10.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell19,
        this.tableCell20
      });
      this.tableRow10.Name = "tableRow10";
      this.tableRow10.Weight = 1.0;
      this.tableCell19.Name = "tableCell19";
      this.tableCell19.StyleName = "GroupCaption1";
      this.tableCell19.Text = "ARACACIKLAMA";
      this.tableCell19.Weight = 0.16300021328234027;
      this.tableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell20.Name = "tableCell20";
      this.tableCell20.StyleName = "GroupData1";
      this.tableCell20.Weight = 0.83699982322193978;
      this.table11.LocationFloat = new PointFloat(0.0f, 2f);
      this.table11.Name = "table11";
      this.table11.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow11
      });
      this.table11.SizeF = new SizeF(161.1667f, 25f);
      this.tableRow11.Cells.AddRange(new XRTableCell[2]
      {
        this.tableCell21,
        this.tableCell22
      });
      this.tableRow11.Name = "tableRow11";
      this.tableRow11.Weight = 1.0;
      this.tableCell21.Name = "tableCell21";
      this.tableCell21.StyleName = "GroupCaption1";
      this.tableCell21.Text = "PLAKA";
      this.tableCell21.Weight = 0.0757038962137566;
      this.tableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell22.Name = "tableCell22";
      this.tableCell22.StyleName = "GroupData1";
      this.tableCell22.Weight = 0.18134034809733246;
      this.table12.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table12.Name = "table12";
      this.table12.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow12
      });
      this.table12.SizeF = new SizeF(627f, 28f);
      this.tableRow12.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell23,
        this.tableCell24,
        this.tableCell25,
        this.tableCell26,
        this.tableCell27,
        this.tableCell28,
        this.tableCell29
      });
      this.tableRow12.Name = "tableRow12";
      this.tableRow12.Weight = 1.0;
      this.tableCell23.Borders = BorderSide.None;
      this.tableCell23.Name = "tableCell23";
      this.tableCell23.StyleName = "DetailCaption1";
      this.tableCell23.StylePriority.UseBorders = false;
      this.tableCell23.Text = "BIRIMADI";
      this.tableCell23.Weight = 0.13667314398611941;
      this.tableCell24.Name = "tableCell24";
      this.tableCell24.StyleName = "DetailCaption1";
      this.tableCell24.Text = "MALZEMEADI";
      this.tableCell24.Weight = 0.18654897832794431;
      this.tableCell25.Name = "tableCell25";
      this.tableCell25.StyleName = "DetailCaption1";
      this.tableCell25.Text = "MALZACIKLAMA";
      this.tableCell25.Weight = 0.22065328448963317;
      this.tableCell26.Name = "tableCell26";
      this.tableCell26.StyleName = "DetailCaption1";
      this.tableCell26.StylePriority.UseTextAlignment = false;
      this.tableCell26.Text = "MIKTAR";
      this.tableCell26.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell26.Weight = 0.12091316332657372;
      this.tableCell27.Name = "tableCell27";
      this.tableCell27.StyleName = "DetailCaption1";
      this.tableCell27.StylePriority.UseTextAlignment = false;
      this.tableCell27.Text = "FIYAT";
      this.tableCell27.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell27.Weight = 0.097296275210342523;
      this.tableCell28.Name = "tableCell28";
      this.tableCell28.StyleName = "DetailCaption1";
      this.tableCell28.StylePriority.UseTextAlignment = false;
      this.tableCell28.Text = "TUTAR";
      this.tableCell28.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell28.Weight = 0.10909895463423296;
      this.tableCell29.Name = "tableCell29";
      this.tableCell29.StyleName = "DetailCaption1";
      this.tableCell29.Text = "Kayıt Tip";
      this.tableCell29.Weight = 0.12881623044538726;
      this.table13.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table13.Name = "table13";
      this.table13.OddStyleName = "DetailData3_Odd";
      this.table13.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow13
      });
      this.table13.SizeF = new SizeF(627f, 25f);
      this.tableRow13.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell30,
        this.tableCell31,
        this.tableCell32,
        this.tableCell33,
        this.tableCell34,
        this.tableCell35,
        this.tableCell36
      });
      this.tableRow13.Name = "tableRow13";
      this.tableRow13.Weight = 11.5;
      this.tableCell30.Borders = BorderSide.None;
      this.tableCell30.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BIRIMADI]")
      });
      this.tableCell30.Name = "tableCell30";
      this.tableCell30.StyleName = "DetailData1";
      this.tableCell30.StylePriority.UseBorders = false;
      this.tableCell30.Weight = 0.13667314398611941;
      this.tableCell31.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZEMEADI]")
      });
      this.tableCell31.Name = "tableCell31";
      this.tableCell31.StyleName = "DetailData1";
      this.tableCell31.Weight = 0.18654897832794431;
      this.tableCell32.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MALZACIKLAMA]")
      });
      this.tableCell32.Name = "tableCell32";
      this.tableCell32.StyleName = "DetailData1";
      this.tableCell32.Weight = 0.22065328448963317;
      this.tableCell33.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[MIKTAR]")
      });
      this.tableCell33.Name = "tableCell33";
      this.tableCell33.StyleName = "DetailData1";
      this.tableCell33.StylePriority.UseTextAlignment = false;
      this.tableCell33.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell33.TextFormatString = "{0:C2}";
      this.tableCell33.Weight = 0.12091316332657372;
      this.tableCell34.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[FIYAT]")
      });
      this.tableCell34.Name = "tableCell34";
      this.tableCell34.StyleName = "DetailData1";
      this.tableCell34.StylePriority.UseTextAlignment = false;
      this.tableCell34.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell34.TextFormatString = "{0:C2}";
      this.tableCell34.Weight = 0.097296275210342523;
      this.tableCell35.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TUTAR]")
      });
      this.tableCell35.Name = "tableCell35";
      this.tableCell35.StyleName = "DetailData1";
      this.tableCell35.StylePriority.UseTextAlignment = false;
      this.tableCell35.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell35.TextFormatString = "{0:C2}";
      this.tableCell35.Weight = 0.10909895463423296;
      this.tableCell36.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KayıtTip]")
      });
      this.tableCell36.Name = "tableCell36";
      this.tableCell36.StyleName = "DetailData1";
      this.tableCell36.Weight = 0.12881620610920055;
      this.label2.Borders = BorderSide.None;
      this.label2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.label2.Name = "label2";
      this.label2.SizeF = new SizeF(627f, 2.08f);
      this.label2.StyleName = "GroupFooterBackground3";
      this.label2.StylePriority.UseBorders = false;
      this.PageFooter.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table5
      });
      this.PageFooter.Name = "PageFooter";
      this.id.Description = "Parameter1";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[15]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.GroupHeader3,
        (Band) this.GroupHeader4,
        (Band) this.GroupHeader5,
        (Band) this.GroupHeader9,
        (Band) this.GroupHeader10,
        (Band) this.GroupHeader11,
        (Band) this.GroupHeader12,
        (Band) this.Detail,
        (Band) this.GroupFooter1,
        (Band) this.PageFooter
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "Query";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[TALEPFISID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.PageHeight = 583;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A5;
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.StyleSheet.AddRange(new XRControlStyle[8]
      {
        this.Title,
        this.GroupCaption1,
        this.GroupData1,
        this.DetailCaption1,
        this.DetailData1,
        this.GroupFooterBackground3,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.table1.EndInit();
      this.table2.EndInit();
      this.table3.EndInit();
      this.table4.EndInit();
      this.table5.EndInit();
      this.table6.EndInit();
      this.table7.EndInit();
      this.table8.EndInit();
      this.table9.EndInit();
      this.table10.EndInit();
      this.table11.EndInit();
      this.table12.EndInit();
      this.table13.EndInit();
      this.EndInit();
    }
  }
}
