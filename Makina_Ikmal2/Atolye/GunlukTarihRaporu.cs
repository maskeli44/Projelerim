// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.GunlukTarihRaporu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.ikitarihTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Atolye
{
  public class GunlukTarihRaporu : XtraReport
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
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private ikitarih ikitarih1;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private Parameter kucuk;
    private Parameter buyuk;
    private bellDataSet7 bellDataSet71;
    private Parameter IsemirDurum;

    public GunlukTarihRaporu() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GunlukTarihRaporu));
      XRSummary xrSummary = new XRSummary();
      DynamicListLookUpSettings listLookUpSettings = new DynamicListLookUpSettings();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.pageInfo1 = new XRPageInfo();
      this.pageInfo2 = new XRPageInfo();
      this.ReportHeader = new ReportHeaderBand();
      this.label1 = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.table1 = new XRTable();
      this.tableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.tableCell1 = new XRTableCell();
      this.tableCell2 = new XRTableCell();
      this.tableCell3 = new XRTableCell();
      this.tableCell4 = new XRTableCell();
      this.tableCell5 = new XRTableCell();
      this.Detail = new DetailBand();
      this.table2 = new XRTable();
      this.tableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.tableCell6 = new XRTableCell();
      this.tableCell7 = new XRTableCell();
      this.tableCell8 = new XRTableCell();
      this.tableCell9 = new XRTableCell();
      this.tableCell10 = new XRTableCell();
      this.ikitarih1 = new ikitarih();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.kucuk = new Parameter();
      this.buyuk = new Parameter();
      this.bellDataSet71 = new bellDataSet7();
      this.IsemirDurum = new Parameter();
      this.table1.BeginInit();
      this.table2.BeginInit();
      this.ikitarih1.BeginInit();
      this.bellDataSet71.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      customSqlQuery.Name = "TBLISEMRI_1";
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
      this.DetailCaption1.BackColor = Color.FromArgb(46, 148, 130);
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
      this.pageInfo1.LocationFloat = new PointFloat(5f, 5f);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new SizeF(303.5f, 23f);
      this.pageInfo1.StyleName = "PageInfo";
      this.pageInfo2.LocationFloat = new PointFloat(318f, 5f);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new SizeF(465f, 23f);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Sayfa Sayısı {0} of {1}";
      this.ReportHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.label1
      });
      this.ReportHeader.HeightF = 60f;
      this.ReportHeader.Name = "ReportHeader";
      this.label1.Font = new Font("Arial", 14.25f, FontStyle.Bold);
      this.label1.LocationFloat = new PointFloat(5f, 5f);
      this.label1.Name = "label1";
      this.label1.SizeF = new SizeF(778f, 24.19433f);
      this.label1.StyleName = "Title";
      this.label1.StylePriority.UseFont = false;
      this.label1.StylePriority.UseTextAlignment = false;
      this.label1.Text = "ATÖLYEDE BAKIMI DEVAM EDEN ARAÇLAR";
      this.label1.TextAlignment = TextAlignment.TopCenter;
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table1
      });
      this.GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 28f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.table1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow1
      });
      this.table1.SizeF = new SizeF(783f, 28f);
      this.tableRow1.Cells.AddRange(new XRTableCell[6]
      {
        this.xrTableCell1,
        this.tableCell1,
        this.tableCell2,
        this.tableCell3,
        this.tableCell4,
        this.tableCell5
      });
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.None;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StyleName = "DetailCaption1";
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.Text = "SIRA NO";
      this.xrTableCell1.Weight = 0.10634773157288435;
      this.tableCell1.Borders = BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "PLAKA";
      this.tableCell1.Weight = 0.1687458459322243;
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailCaption1";
      this.tableCell2.Text = "ARACACIKLAMA";
      this.tableCell2.Weight = 0.29183744889940283;
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailCaption1";
      this.tableCell3.Text = "GIRISTARIH";
      this.tableCell3.Weight = 0.19252572371385973;
      this.tableCell4.Name = "tableCell4";
      this.tableCell4.StyleName = "DetailCaption1";
      this.tableCell4.Text = "BILDIRILENARIZA";
      this.tableCell4.Weight = 0.31054334651928434;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption1";
      this.tableCell5.Text = "ADI";
      this.tableCell5.Weight = 0.32593364458652058;
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.table2
      });
      this.Detail.HeightF = 54.83335f;
      this.Detail.Name = "Detail";
      this.table2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new XRTableRow[1]
      {
        this.tableRow2
      });
      this.table2.SizeF = new SizeF(783f, 54.83335f);
      this.tableRow2.Cells.AddRange(new XRTableCell[6]
      {
        this.xrTableCell2,
        this.tableCell6,
        this.tableCell7,
        this.tableCell8,
        this.tableCell9,
        this.tableCell10
      });
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5;
      this.xrTableCell2.Borders = BorderSide.None;
      this.xrTableCell2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")
      });
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StyleName = "DetailData1";
      this.xrTableCell2.StylePriority.UseBorders = false;
      xrSummary.Running = SummaryRunning.Report;
      this.xrTableCell2.Summary = xrSummary;
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 0.10561764402241425;
      this.tableCell6.Borders = BorderSide.None;
      this.tableCell6.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[PLAKA]")
      });
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailData1";
      this.tableCell6.StylePriority.UseBorders = false;
      this.tableCell6.Weight = 0.16947593348269441;
      this.tableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ARACACIKLAMA]")
      });
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailData1";
      this.tableCell7.Weight = 0.28794565579343712;
      this.tableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GIRISTARIH]")
      });
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData1";
      this.tableCell8.TextFormatString = "{0:d.MM.yyyy}";
      this.tableCell8.Weight = 0.19120379161675338;
      this.tableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[BILDIRILENARIZA]")
      });
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData1";
      this.tableCell9.Weight = 0.30841144235298823;
      this.tableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADI]")
      });
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData1";
      this.tableCell10.Weight = 0.32369605189071626;
      this.ikitarih1.DataSetName = "ikitarih";
      this.ikitarih1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.kucuk.Description = "Parameter1";
      this.kucuk.Name = "kucuk";
      this.kucuk.Type = typeof (DateTime);
      this.buyuk.Description = "Parameter2";
      this.buyuk.Name = "buyuk";
      this.buyuk.Type = typeof (DateTime);
      this.bellDataSet71.DataSetName = "bellDataSet7";
      this.bellDataSet71.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.IsemirDurum.Description = "İş Emri Durum";
      this.IsemirDurum.Name = "IsemirDurum";
      listLookUpSettings.DataMember = "TBLISEMIRDURUM";
      listLookUpSettings.DataSource = (object) this.bellDataSet71;
      listLookUpSettings.DisplayMember = "ID";
      listLookUpSettings.SortMember = "ADI";
      listLookUpSettings.SortOrder = ColumnSortOrder.Ascending;
      listLookUpSettings.ValueMember = "ADI";
      this.IsemirDurum.ValueSourceSettings = (ValueSourceSettings) listLookUpSettings;
      this.Bands.AddRange(new Band[5]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.GroupHeader1,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[3]
      {
        (IComponent) this.sqlDataSource1,
        (IComponent) this.ikitarih1,
        (IComponent) this.bellDataSet71
      });
      this.DataAdapter = (object) this.dataTable1TableAdapter;
      this.DataMember = "TBLISEMRI_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[GIRISTARIH] <= ?buyuk And [GIRISTARIH] >= ?kucuk";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(22, 22, 100, 100);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
      this.Parameters.AddRange(new Parameter[3]
      {
        this.kucuk,
        this.buyuk,
        this.IsemirDurum
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
      this.table1.EndInit();
      this.table2.EndInit();
      this.ikitarih1.EndInit();
      this.bellDataSet71.EndInit();
      this.EndInit();
    }
  }
}
