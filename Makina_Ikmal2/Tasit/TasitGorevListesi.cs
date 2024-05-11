// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Tasit.TasitGorevListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
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
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.TasitPersTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Tasit
{
  public class TasitGorevListesi : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem düzenleButton;
    private BarButtonItem silButton;
    private BarButtonItem yenileButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private BarEditItem barEditItem1;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem yeniButton;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLTASITGOREVBindingSource;
    private TBLTASITGOREVTableAdapter tBLTASITGOREVTableAdapter;
    private GridColumn colKOD;
    private GridColumn colPLAKAID;
    private GridColumn colSOFORID;
    private GridColumn colBIRIMID;
    private GridColumn colGOREVTURU;
    private GridColumn colGIDILECEKYER;
    private GridColumn colCIKISZAMANI;
    private GridColumn colDONUSZAMANI;
    private GridColumn colMESAIBITISSAATI;
    private GridColumn colGUNUNADI;
    private GridColumn colMESAIMIKTARI;
    private GridColumn colMUDURID;
    private GridColumn colBIRIMAMIRIID;
    private BindingSource tBLTASITPERSBindingSource;
    private TBLTASITPERSTableAdapter tBLTASITPERSTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLPERSUNVANBindingSource;
    private TBLPERSUNVANTableAdapter tBLPERSUNVANTableAdapter;
    private RepositoryItemLookUpEdit personel;
    private RepositoryItemLookUpEdit personelUnvan;
    private RepositoryItemLookUpEdit araclar;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private GridColumn mudurOnay;
    private BindingSource tasitPersBindingSource;
    private TasitPers tasitPers;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private BindingSource dataTable1BindingSource1;
    private GridColumn colUNVAN;
    private GridColumn colADISOYADI;
    private TasitPers tasitPers1;
    private DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn ID;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RepositoryItemTimeEdit repositoryItemTimeEdit1;

    public TasitGorevListesi()
    {
      this.InitializeComponent();
      this.gridView1.SelectRow(0);
    }

    private void TasitGörevListesi_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet2.TBLARACLAR);
      this.tBLPERSUNVANTableAdapter.Fill(this.bellDataSet2.TBLPERSUNVAN);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLTASITPERSTableAdapter.Fill(this.bellDataSet2.TBLTASITPERS);
      this.tBLTASITGOREVTableAdapter.Fill(this.bellDataSet2.TBLTASITGOREV);
    }

    private void yeniButton_ItemClick(object sender, ItemClickEventArgs e) => new TasitGorevEmri().Show();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.TasitGörevListesi_Load(sender, (EventArgs) e);
      this.gridView1.SelectRow(this.gridView1.RowCount);
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.ID));
      TasitGorevEmriDuzenle gorevEmriDuzenle = new TasitGorevEmriDuzenle();
      gorevEmriDuzenle.Show();
      gorevEmriDuzenle.guncelleLoad(int32);
    }

    private void gridView1_Click(object sender, EventArgs e)
    {
    }

    private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) => this.dataTable1TableAdapter1.Fill(this.tasitPers1.DataTable1, new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"))));

    private void silButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.db.TBLTASITGOREV.Remove(this.db.TBLTASITGOREV.Find(new object[1]
      {
        (object) YetkiClass.secim_id
      }));
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
      LogEkle.Logs("Silme Yapti");
      this.tBLTASITGOREVTableAdapter.Fill(this.bellDataSet2.TBLTASITGOREV);
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      Filtrele filtrele = new Filtrele();
      filtrele.Show();
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = "[CIKISZAMANI] >= #" + filtrele.ilkTarih.ToString() + "# AND [CIKISZAMANI] <= #" + filtrele.sonTarih.ToString() + "#";
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    public void tetikle()
    {
      Filtrele filtrele = new Filtrele();
      ColumnView gridView1 = (ColumnView) this.gridView1;
      this.gridView1.ActiveFilterString = ((CriteriaOperator) ((CriteriaOperator) new OperandProperty(this.colCIKISZAMANI.ToString()) >= (CriteriaOperator) filtrele.ilkTarih) & (CriteriaOperator) ((CriteriaOperator) new OperandProperty(this.colDONUSZAMANI.ToString()) <= (CriteriaOperator) filtrele.sonTarih)).ToString();
      this.gridView1.ActiveFilterEnabled = true;
    }

    private void düzenleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.ID));
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.ID));
      TasitGorevEmriDuzenle gorevEmriDuzenle = new TasitGorevEmriDuzenle();
      gorevEmriDuzenle.Show();
      gorevEmriDuzenle.guncelleLoad(int32);
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TasitGorevListesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.düzenleButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.yenileButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.yeniButton = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLTASITGOREVBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.gridView1 = new GridView();
      this.ID = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.colGOREVTURU = new GridColumn();
      this.colGIDILECEKYER = new GridColumn();
      this.colKOD = new GridColumn();
      this.colPLAKAID = new GridColumn();
      this.araclar = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.colCIKISZAMANI = new GridColumn();
      this.colDONUSZAMANI = new GridColumn();
      this.colGUNUNADI = new GridColumn();
      this.colMESAIBITISSAATI = new GridColumn();
      this.repositoryItemTimeEdit1 = new RepositoryItemTimeEdit();
      this.colMESAIMIKTARI = new GridColumn();
      this.colMUDURID = new GridColumn();
      this.personel = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colSOFORID = new GridColumn();
      this.colBIRIMAMIRIID = new GridColumn();
      this.mudurOnay = new GridColumn();
      this.personelUnvan = new RepositoryItemLookUpEdit();
      this.tBLPERSUNVANBindingSource = new BindingSource(this.components);
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.gridControl2 = new GridControl();
      this.tasitPers1 = new TasitPers();
      this.gridView2 = new GridView();
      this.colUNVAN = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.tasitPers = new TasitPers();
      this.tasitPersBindingSource = new BindingSource(this.components);
      this.tBLTASITPERSBindingSource = new BindingSource(this.components);
      this.tBLTASITGOREVTableAdapter = new TBLTASITGOREVTableAdapter();
      this.tBLTASITPERSTableAdapter = new TBLTASITPERSTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLPERSUNVANTableAdapter = new TBLPERSUNVANTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.dataTable1TableAdapter1 = new DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLTASITGOREVBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.gridView1.BeginInit();
      this.araclar.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.repositoryItemTimeEdit1.BeginInit();
      this.personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.personelUnvan.BeginInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.gridControl2.BeginInit();
      this.tasitPers1.BeginInit();
      this.gridView2.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.tasitPers.BeginInit();
      ((ISupportInitialize) this.tasitPersBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[13]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.düzenleButton,
        (BarItem) this.silButton,
        (BarItem) this.yenileButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1,
        (BarItem) this.yeniButton,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 13;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1256, 122);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.düzenleButton.Caption = "Düzenle";
      this.düzenleButton.Id = 2;
      this.düzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.Image");
      this.düzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.LargeImage");
      this.düzenleButton.LargeWidth = 100;
      this.düzenleButton.Name = "düzenleButton";
      this.düzenleButton.ItemClick += new ItemClickEventHandler(this.düzenleButton_ItemClick);
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
      this.silButton.ItemClick += new ItemClickEventHandler(this.silButton_ItemClick);
      this.yenileButton.Caption = "Yenile";
      this.yenileButton.Id = 5;
      this.yenileButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.Image");
      this.yenileButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.LargeImage");
      this.yenileButton.LargeWidth = 100;
      this.yenileButton.Name = "yenileButton";
      this.yenileButton.RibbonStyle = RibbonItemStyles.Large;
      this.yenileButton.ItemClick += new ItemClickEventHandler(this.yenileButton_ItemClick);
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemTextEdit1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemTextEdit1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTextEdit1.NullText = "Kayıt Bul...";
      this.yeniButton.Caption = "Yeni";
      this.yeniButton.Id = 9;
      this.yeniButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.Image");
      this.yeniButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.LargeImage");
      this.yeniButton.LargeWidth = 100;
      this.yeniButton.Name = "yeniButton";
      this.yeniButton.ItemClick += new ItemClickEventHandler(this.yeniButton_ItemClick);
      this.barButtonItem2.Caption = "Filtrele";
      this.barButtonItem2.Enabled = false;
      this.barButtonItem2.Id = 10;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Excel";
      this.barButtonItem3.Id = 11;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 30;
      this.barEditItem2.EditWidth = 130;
      this.barEditItem2.Id = 12;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLTASITGOREVBindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.gridControl1.Location = new Point(12, 12);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.personel,
        (RepositoryItem) this.personelUnvan,
        (RepositoryItem) this.araclar,
        (RepositoryItem) this.repositoryItemTimeEdit1
      });
      this.gridControl1.Size = new Size(1232, 436);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_Click);
      this.tBLTASITGOREVBindingSource.DataMember = "TBLTASITGOREV";
      this.tBLTASITGOREVBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 10.8f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[15]
      {
        this.ID,
        this.colBIRIMID,
        this.colGOREVTURU,
        this.colGIDILECEKYER,
        this.colKOD,
        this.colPLAKAID,
        this.colCIKISZAMANI,
        this.colDONUSZAMANI,
        this.colGUNUNADI,
        this.colMESAIBITISSAATI,
        this.colMESAIMIKTARI,
        this.colMUDURID,
        this.colSOFORID,
        this.colBIRIMAMIRIID,
        this.mudurOnay
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.ReadOnly = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD, ColumnSortOrder.Descending)
      });
      this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.ID.Caption = "ID";
      this.ID.FieldName = "ID";
      this.ID.MinWidth = 23;
      this.ID.Name = "ID";
      this.ID.OptionsColumn.AllowEdit = false;
      this.ID.Width = 87;
      this.colBIRIMID.Caption = "Görevi Veren";
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 23;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 3;
      this.colBIRIMID.Width = 87;
      this.colGOREVTURU.Caption = "Görev Türü";
      this.colGOREVTURU.FieldName = "GOREVTURU";
      this.colGOREVTURU.MinWidth = 23;
      this.colGOREVTURU.Name = "colGOREVTURU";
      this.colGOREVTURU.OptionsColumn.AllowEdit = false;
      this.colGOREVTURU.Visible = true;
      this.colGOREVTURU.VisibleIndex = 4;
      this.colGOREVTURU.Width = 87;
      this.colGIDILECEKYER.Caption = "Gidilecek Yer";
      this.colGIDILECEKYER.FieldName = "GIDILECEKYER";
      this.colGIDILECEKYER.MinWidth = 23;
      this.colGIDILECEKYER.Name = "colGIDILECEKYER";
      this.colGIDILECEKYER.OptionsColumn.AllowEdit = false;
      this.colGIDILECEKYER.Visible = true;
      this.colGIDILECEKYER.VisibleIndex = 5;
      this.colGIDILECEKYER.Width = 87;
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 23;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 87;
      this.colPLAKAID.Caption = "Araç Plaka";
      this.colPLAKAID.ColumnEdit = (RepositoryItem) this.araclar;
      this.colPLAKAID.FieldName = "PLAKAID";
      this.colPLAKAID.MinWidth = 23;
      this.colPLAKAID.Name = "colPLAKAID";
      this.colPLAKAID.OptionsColumn.AllowEdit = false;
      this.colPLAKAID.Visible = true;
      this.colPLAKAID.VisibleIndex = 1;
      this.colPLAKAID.Width = 87;
      this.araclar.AutoHeight = false;
      this.araclar.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.araclar.DataSource = (object) this.tBLARACLARBindingSource;
      this.araclar.DisplayMember = "PLAKA";
      this.araclar.Name = "araclar";
      this.araclar.NullText = "";
      this.araclar.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet2;
      this.colCIKISZAMANI.Caption = "Çıkış Zamanı";
      this.colCIKISZAMANI.FieldName = "CIKISZAMANI";
      this.colCIKISZAMANI.MinWidth = 23;
      this.colCIKISZAMANI.Name = "colCIKISZAMANI";
      this.colCIKISZAMANI.OptionsColumn.AllowEdit = false;
      this.colCIKISZAMANI.Visible = true;
      this.colCIKISZAMANI.VisibleIndex = 6;
      this.colCIKISZAMANI.Width = 87;
      this.colDONUSZAMANI.Caption = "Dönüş Zamanı";
      this.colDONUSZAMANI.FieldName = "DONUSZAMANI";
      this.colDONUSZAMANI.MinWidth = 23;
      this.colDONUSZAMANI.Name = "colDONUSZAMANI";
      this.colDONUSZAMANI.OptionsColumn.AllowEdit = false;
      this.colDONUSZAMANI.Visible = true;
      this.colDONUSZAMANI.VisibleIndex = 7;
      this.colDONUSZAMANI.Width = 87;
      this.colGUNUNADI.Caption = "Günün Adı";
      this.colGUNUNADI.FieldName = "GUNUNADI";
      this.colGUNUNADI.MinWidth = 23;
      this.colGUNUNADI.Name = "colGUNUNADI";
      this.colGUNUNADI.OptionsColumn.AllowEdit = false;
      this.colGUNUNADI.Visible = true;
      this.colGUNUNADI.VisibleIndex = 9;
      this.colGUNUNADI.Width = 87;
      this.colMESAIBITISSAATI.Caption = "Mesai Bitiş Saati";
      this.colMESAIBITISSAATI.ColumnEdit = (RepositoryItem) this.repositoryItemTimeEdit1;
      this.colMESAIBITISSAATI.FieldName = "MESAIBITISSAATI";
      this.colMESAIBITISSAATI.MinWidth = 23;
      this.colMESAIBITISSAATI.Name = "colMESAIBITISSAATI";
      this.colMESAIBITISSAATI.OptionsColumn.AllowEdit = false;
      this.colMESAIBITISSAATI.Visible = true;
      this.colMESAIBITISSAATI.VisibleIndex = 8;
      this.colMESAIBITISSAATI.Width = 87;
      this.repositoryItemTimeEdit1.AutoHeight = false;
      this.repositoryItemTimeEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
      this.colMESAIMIKTARI.Caption = "Mesaisi";
      this.colMESAIMIKTARI.FieldName = "MESAIMIKTARI";
      this.colMESAIMIKTARI.MinWidth = 23;
      this.colMESAIMIKTARI.Name = "colMESAIMIKTARI";
      this.colMESAIMIKTARI.OptionsColumn.AllowEdit = false;
      this.colMESAIMIKTARI.Visible = true;
      this.colMESAIMIKTARI.VisibleIndex = 10;
      this.colMESAIMIKTARI.Width = 87;
      this.colMUDURID.Caption = "Şube Müdürü";
      this.colMUDURID.ColumnEdit = (RepositoryItem) this.personel;
      this.colMUDURID.FieldName = "MUDURID";
      this.colMUDURID.MinWidth = 23;
      this.colMUDURID.Name = "colMUDURID";
      this.colMUDURID.OptionsColumn.AllowEdit = false;
      this.colMUDURID.Visible = true;
      this.colMUDURID.VisibleIndex = 11;
      this.colMUDURID.Width = 87;
      this.personel.AutoHeight = false;
      this.personel.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personel.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personel.DisplayMember = "ADISOYADI";
      this.personel.Name = "personel";
      this.personel.NullText = "";
      this.personel.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.colSOFORID.Caption = "Şöför";
      this.colSOFORID.ColumnEdit = (RepositoryItem) this.personel;
      this.colSOFORID.FieldName = "SOFORID";
      this.colSOFORID.MinWidth = 23;
      this.colSOFORID.Name = "colSOFORID";
      this.colSOFORID.OptionsColumn.AllowEdit = false;
      this.colSOFORID.Visible = true;
      this.colSOFORID.VisibleIndex = 2;
      this.colSOFORID.Width = 87;
      this.colBIRIMAMIRIID.Caption = "Birim Amiri";
      this.colBIRIMAMIRIID.ColumnEdit = (RepositoryItem) this.personel;
      this.colBIRIMAMIRIID.FieldName = "BIRIMAMIRIID";
      this.colBIRIMAMIRIID.MinWidth = 23;
      this.colBIRIMAMIRIID.Name = "colBIRIMAMIRIID";
      this.colBIRIMAMIRIID.OptionsColumn.AllowEdit = false;
      this.colBIRIMAMIRIID.Visible = true;
      this.colBIRIMAMIRIID.VisibleIndex = 12;
      this.colBIRIMAMIRIID.Width = 87;
      this.mudurOnay.Caption = "Müdür Onay";
      this.mudurOnay.FieldName = "MUDONAYZAMAN";
      this.mudurOnay.MinWidth = 23;
      this.mudurOnay.Name = "mudurOnay";
      this.mudurOnay.OptionsColumn.AllowEdit = false;
      this.mudurOnay.Visible = true;
      this.mudurOnay.VisibleIndex = 13;
      this.mudurOnay.Width = 87;
      this.personelUnvan.AutoHeight = false;
      this.personelUnvan.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personelUnvan.DataSource = (object) this.tBLPERSUNVANBindingSource;
      this.personelUnvan.DisplayMember = "UNVAN";
      this.personelUnvan.Name = "personelUnvan";
      this.personelUnvan.NullText = "";
      this.personelUnvan.ValueMember = "ID";
      this.tBLPERSUNVANBindingSource.DataMember = "TBLPERSUNVAN";
      this.tBLPERSUNVANBindingSource.DataSource = (object) this.bellDataSet2;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.düzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.gridControl2);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1256, 700);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.gridControl2.DataMember = "DataTable1";
      this.gridControl2.DataSource = (object) this.tasitPers1;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.gridControl2.Location = new Point(12, 452);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 4, 3, 4);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1232, 236);
      this.gridControl2.TabIndex = 5;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tasitPers1.DataSetName = "TasitPers";
      this.tasitPers1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.colUNVAN,
        this.colADISOYADI
      });
      this.gridView2.DetailHeight = 431;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.ReadOnly = true;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colUNVAN.FieldName = "UNVAN";
      this.colUNVAN.MinWidth = 23;
      this.colUNVAN.Name = "colUNVAN";
      this.colUNVAN.Visible = true;
      this.colUNVAN.VisibleIndex = 0;
      this.colUNVAN.Width = 87;
      this.colADISOYADI.Caption = "ADI SOYADI";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 23;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 1;
      this.colADISOYADI.Width = 87;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1256, 700);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1236, 440);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.gridControl2;
      this.layoutControlItem2.Location = new Point(0, 440);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1236, 240);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.tasitPers;
      this.tasitPers.DataSetName = "TasitPers";
      this.tasitPers.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tasitPersBindingSource.DataSource = (object) this.tasitPers;
      this.tasitPersBindingSource.Position = 0;
      this.tBLTASITPERSBindingSource.DataMember = "TBLTASITPERS";
      this.tBLTASITPERSBindingSource.DataSource = (object) this.bellDataSet2;
      this.tBLTASITGOREVTableAdapter.ClearBeforeFill = true;
      this.tBLTASITPERSTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLPERSUNVANTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.tasitPersBindingSource;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1256, 822);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (TasitGorevListesi);
      this.Text = "Taşıt Görev Listesi";
      this.Load += new EventHandler(this.TasitGörevListesi_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLTASITGOREVBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.gridView1.EndInit();
      this.araclar.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.repositoryItemTimeEdit1.EndInit();
      this.personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.personelUnvan.EndInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.tasitPers1.EndInit();
      this.gridView2.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.tasitPers.EndInit();
      ((ISupportInitialize) this.tasitPersBindingSource).EndInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
