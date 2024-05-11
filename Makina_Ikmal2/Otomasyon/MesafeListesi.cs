// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.MesafeListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Excel;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet1TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Otomasyon
{
  public class MesafeListesi : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem1;
    private BarButtonItem yukleBtn;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarEditItem barEditItem2;
    private BarEditItem barEditItem3;
    private BarEditItem barEditItem1;
    private BarButtonItem kaydetBtn;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLARACMESTKPBindingSource;
    private TBLARACMESTKPTableAdapter tBLARACMESTKPTableAdapter;
    private XtraOpenFileDialog xtraOpenFileDialog1;
    private GridColumn colTARIHSAAT;
    private GridColumn colPLAKA;
    private GridColumn colMESAIICI;
    private GridColumn colMESAIDISI;
    private GridColumn colCALISMASURESI;
    private RepositoryItemDateEdit repositoryItemDateEdit1;
    private RepositoryItemTimeEdit repositoryItemTimeEdit1;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private BehaviorManager behaviorManager1;

    public MesafeListesi() => this.InitializeComponent();

    private void kaydetBtn_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
        {
          TBLARACMESTKP entity = new TBLARACMESTKP();
          entity.MESAIDISI = this.gridView1.GetRowCellValue(rowHandle, this.colMESAIDISI).ToString();
          entity.MESAIICI = this.gridView1.GetRowCellValue(rowHandle, this.colMESAIICI).ToString();
          entity.PLAKA = this.gridView1.GetRowCellValue(rowHandle, this.colPLAKA).ToString();
          entity.TARIHSAAT = new DateTime?(Convert.ToDateTime(this.gridView1.GetRowCellValue(rowHandle, this.colTARIHSAAT)));
          Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colMESAIDISI)) + Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colMESAIICI));
          entity.TOPLAMKM = Convert.ToString(num);
          entity.CALISMASURESI = this.gridView1.GetRowCellValue(rowHandle, this.colCALISMASURESI).ToString();
          this.db.TBLARACMESTKP.Add(entity);
          this.db.SaveChanges();
        }
        int num1 = (int) XtraMessageBox.Show("Bilgiler Başarı İle Kaydedildi");
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void yukleBtn_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.xtraOpenFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
      this.xtraOpenFileDialog1.Title = "Import Excel";
      this.xtraOpenFileDialog1.Multiselect = false;
      int num = (int) this.xtraOpenFileDialog1.ShowDialog();
    }

    private void MesafeListesi_Load(object sender, EventArgs e)
    {
      this.tBLARACMESTKPTableAdapter.Fill(this.bellDataSet1.TBLARACMESTKP);
      this.gridControl1.DataSource = (object) null;
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void xtraOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      string fileName = this.xtraOpenFileDialog1.FileName;
      ExcelDataSource excelDataSource = new ExcelDataSource();
      excelDataSource.FileName = fileName;
      ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings();
      worksheetSettings.WorksheetName = "Mesai Dışı ve Mesai İçi Çalışma";
      ExcelSourceOptions excelSourceOptions = new ExcelSourceOptions();
      excelSourceOptions.ImportSettings = (ExcelSettingsBase) worksheetSettings;
      excelSourceOptions.SkipHiddenRows = false;
      excelSourceOptions.SkipHiddenColumns = false;
      excelSourceOptions.UseFirstRowAsHeader = true;
      excelDataSource.SourceOptions = (ExcelSourceOptionsBase) excelSourceOptions;
      excelDataSource.Fill();
      this.gridControl1.DataSource = (object) excelDataSource;
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MesafeListesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem1 = new BarButtonItem();
      this.yukleBtn = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem3 = new BarEditItem();
      this.barEditItem1 = new BarEditItem();
      this.kaydetBtn = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.tBLARACMESTKPBindingSource = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.gridView1 = new GridView();
      this.colTARIHSAAT = new GridColumn();
      this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
      this.colPLAKA = new GridColumn();
      this.colMESAIICI = new GridColumn();
      this.colMESAIDISI = new GridColumn();
      this.colCALISMASURESI = new GridColumn();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.repositoryItemTimeEdit1 = new RepositoryItemTimeEdit();
      this.tBLARACMESTKPTableAdapter = new TBLARACMESTKPTableAdapter();
      this.xtraOpenFileDialog1 = new XtraOpenFileDialog(this.components);
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.ribbonControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLARACMESTKPBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemDateEdit1.BeginInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemTimeEdit1.BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[15]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem1,
        (BarItem) this.yukleBtn,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem1,
        (BarItem) this.kaydetBtn
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 21;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 288;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1129, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem6.Caption = "Kapat";
      this.barButtonItem6.Id = 6;
      this.barButtonItem6.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.Image");
      this.barButtonItem6.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.LargeImage");
      this.barButtonItem6.Name = "barButtonItem6";
      this.barButtonItem7.Caption = "Kapat";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.LargeWidth = 100;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barButtonItem7.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem7.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
      this.barButtonItem1.Caption = "Şablon";
      this.barButtonItem1.Id = 9;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.yukleBtn.Caption = "Yükle";
      this.yukleBtn.Id = 10;
      this.yukleBtn.ImageOptions.Image = (Image) componentResourceManager.GetObject("yukleBtn.ImageOptions.Image");
      this.yukleBtn.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yukleBtn.ImageOptions.LargeImage");
      this.yukleBtn.LargeWidth = 100;
      this.yukleBtn.Name = "yukleBtn";
      this.yukleBtn.ItemClick += new ItemClickEventHandler(this.yukleBtn_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 11;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 12;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "Excel";
      this.barButtonItem9.Id = 13;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 15;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 17;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 18;
      this.barEditItem1.Name = "barEditItem1";
      this.kaydetBtn.Caption = "Kaydet";
      this.kaydetBtn.Id = 19;
      this.kaydetBtn.ImageOptions.Image = (Image) componentResourceManager.GetObject("kaydetBtn.ImageOptions.Image");
      this.kaydetBtn.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kaydetBtn.ImageOptions.LargeImage");
      this.kaydetBtn.LargeWidth = 100;
      this.kaydetBtn.Name = "kaydetBtn";
      this.kaydetBtn.ItemClick += new ItemClickEventHandler(this.kaydetBtn_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yukleBtn);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.kaydetBtn);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridControl1.DataSource = (object) this.tBLARACMESTKPBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 118);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemDateEdit1,
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTimeEdit1
      });
      this.gridControl1.Size = new Size(1129, 535);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLARACMESTKPBindingSource.DataMember = "TBLARACMESTKP";
      this.tBLARACMESTKPBindingSource.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colTARIHSAAT,
        this.colPLAKA,
        this.colMESAIICI,
        this.colMESAIDISI,
        this.colCALISMASURESI
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colTARIHSAAT.ColumnEdit = (RepositoryItem) this.repositoryItemDateEdit1;
      this.colTARIHSAAT.FieldName = "Tarih";
      this.colTARIHSAAT.MinWidth = 25;
      this.colTARIHSAAT.Name = "colTARIHSAAT";
      this.colTARIHSAAT.Visible = true;
      this.colTARIHSAAT.VisibleIndex = 0;
      this.colTARIHSAAT.Width = 94;
      this.repositoryItemDateEdit1.AutoHeight = false;
      this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
      this.colPLAKA.FieldName = "Plaka";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 94;
      this.colMESAIICI.FieldName = "Mesai İçi Mesafe(km)";
      this.colMESAIICI.MinWidth = 25;
      this.colMESAIICI.Name = "colMESAIICI";
      this.colMESAIICI.Visible = true;
      this.colMESAIICI.VisibleIndex = 2;
      this.colMESAIICI.Width = 94;
      this.colMESAIDISI.FieldName = "Mesai Dışı Mesafe(km)";
      this.colMESAIDISI.MinWidth = 25;
      this.colMESAIDISI.Name = "colMESAIDISI";
      this.colMESAIDISI.Visible = true;
      this.colMESAIDISI.VisibleIndex = 3;
      this.colMESAIDISI.Width = 94;
      this.colCALISMASURESI.FieldName = "Toplam Çalışma Süresi";
      this.colCALISMASURESI.MinWidth = 25;
      this.colCALISMASURESI.Name = "colCALISMASURESI";
      this.colCALISMASURESI.Visible = true;
      this.colCALISMASURESI.VisibleIndex = 4;
      this.colCALISMASURESI.Width = 94;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTimeEdit1.AutoHeight = false;
      this.repositoryItemTimeEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
      this.tBLARACMESTKPTableAdapter.ClearBeforeFill = true;
      this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
      this.xtraOpenFileDialog1.FileOk += new CancelEventHandler(this.xtraOpenFileDialog1_FileOk);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1129, 653);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (MesafeListesi);
      this.Text = nameof (MesafeListesi);
      this.Load += new EventHandler(this.MesafeListesi_Load);
      this.ribbonControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLARACMESTKPBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemTimeEdit1.EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
