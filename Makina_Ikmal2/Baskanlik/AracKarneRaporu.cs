// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Baskanlik.AracKarneRaporu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Baskanlik
{
  public class AracKarneRaporu : XtraReport
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
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;

    public AracKarneRaporu() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracKarneRaporu));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.GroupHeader1 = new GroupHeaderBand();
      this.Detail = new DetailBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.label1 = new XRLabel();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.tableCell8 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.tableCell11 = new XRTableCell();
      this.tableCell12 = new XRTableCell();
      this.tableCell13 = new XRTableCell();
      this.tableCell14 = new XRTableCell();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      customSqlQuery.Name = "TBLARACLAR_1";
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
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 28f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.Detail.HeightF = 25f;
      this.Detail.Name = "Detail";
      this.pageInfo1.LocationFloat = new PointFloat(5f, 5f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(474.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(489f, 5f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(474.5f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      this.label1.LocationFloat = new PointFloat(5f, 5f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(959f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.Text = "Report Title";
      this.table1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(1137f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell1,
        this.tableCell2,
        this.tableCell3,
        this.tableCell4,
        this.tableCell5,
        this.tableCell6,
        this.tableCell7
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "PLAKA";
      this.tableCell1.Weight = 0.27995253325689334;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "GIRISTARIH";
      this.tableCell2.Weight = 0.13433817380324964;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.Text = "CIKISTARIH";
      this.tableCell3.Weight = 0.13049278570248363;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "ADI";
      this.tableCell4.Weight = 0.144485955133419;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.Text = "BILDIRILENARIZA";
      this.tableCell5.Weight = 0.19655077626798431;
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption1";
      this.tableCell6.Text = "KOD";
      this.tableCell6.Weight = 0.10901988326613155;
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption1";
      this.tableCell7.StylePriority.UseTextAlignment = false;
      this.tableCell7.Text = "ARIZA NEDENI";
      this.tableCell7.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell7.Weight = 0.17853452404999923;
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(1137f, 25f);
      this.tableRow2.Cells.AddRange(new XRTableCell[7]
      {
        this.tableCell8,
        this.tableCell9,
        this.tableCell10,
        this.tableCell11,
        this.tableCell12,
        this.tableCell13,
        this.tableCell14
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.tableCell8.Borders = BorderSide.None;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.Weight = 0.27995259350913471;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GIRISTARIH]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData1";
      this.tableCell9.Weight = 0.1343381112081963;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CIKISTARIH]")
      });
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData1";
      this.tableCell10.Weight = 0.13049278613583587;
      this.tableCell11.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.tableCell11.Name = "tableCell11";
      this.tableCell11.StyleName = "DetailData1";
      this.tableCell11.Weight = 0.14448589092683745;
      this.tableCell12.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BILDIRILENARIZA]")
      });
      this.tableCell12.Name = "tableCell12";
      this.tableCell12.StyleName = "DetailData1";
      this.tableCell12.Weight = 0.19655083970265735;
      this.tableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KOD]")
      });
      this.tableCell13.Name = "tableCell13";
      this.tableCell13.StyleName = "DetailData1";
      this.tableCell13.Weight = 0.10901988278478536;
      this.tableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[Arıza Nedeni]")
      });
      this.tableCell14.Name = "tableCell14";
      this.tableCell14.StyleName = "DetailData1";
      this.tableCell14.StylePriority.UseTextAlignment = false;
      this.tableCell14.TextAlignment = TextAlignment.MiddleRight;
      this.tableCell14.Weight = 0.17853438276009417;
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
      this.DataMember = "TBLARACLAR_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.Font = new Font("Arial", 9.75f);
      this.Landscape = true;
      this.Margins = new Margins(13, 19, 100, 100);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4;
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.Title,
        this.DetailCaption1,
        this.DetailData1,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.table1.EndInit();
      this.table2.EndInit();
      this.EndInit();
    }
  }
}
