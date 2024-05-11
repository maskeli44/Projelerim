// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.CikisFisEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet6TableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class CikisFisEkle : XtraForm
  {
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private BarButtonItem barButtonItem13;
    private BarEditItem barEditItem1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private BarCheckItem barCheckItem6;
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private DataLayoutControl dataLayoutControl1;
    private TimeEdit timeEdit1;
    private SearchLookUpEdit searchLookUpEdit3;
    private GridView searchLookUpEdit3View;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup2;
    private SearchLookUpEdit searchLookUpEdit2;
    private GridView searchLookUpEdit2View;
    private DateEdit dateEdit1;
    private TextEdit textEdit1;
    private SearchLookUpEdit searchLookUpEdit1;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem3;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem6;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLDEPOFISBindingSource;
    private TBLDEPOFISTableAdapter tBLDEPOFISTableAdapter;
    private BarButtonItem barButtonItem22;
    private RibbonPageGroup ribbonPageGroup3;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colISEMRIID;
    private GridColumn colTARIH;
    private GridColumn colSAAT;
    private GridColumn colFISNO;
    private GridColumn colALANUSTAID;
    private GridColumn colFIRMAID;
    private GridColumn colISLEMTIPIID;
    private GridColumn colTOPTUTAR;
    private GridColumn colTOPKDVTUTAR;
    private GridColumn colFISTUTAR;
    private GridColumn colGCKOD;
    private GridColumn colTRANSFERID;
    private GridColumn colTRANSDEPOGCID;
    private GridColumn colIMZADEPOYETKILIID;
    private GridColumn colTALEPFISID;
    private GridColumn colGIRISICIKISYAPID;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private LayoutControl layoutControl4;
    private SimpleButton simpleButton4;
    private SimpleButton simpleButton3;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControlItem layoutControlItem12;
    private EmptySpaceItem emptySpaceItem2;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem11;

    public CikisFisEkle() => this.InitializeComponent();

    private void GirisFisEkle_Load(object sender, EventArgs e)
    {
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CikisFisEkle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barButtonItem17 = new BarButtonItem();
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barButtonItem22 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLDEPOFISBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colISEMRIID = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colSAAT = new GridColumn();
      this.colFISNO = new GridColumn();
      this.colALANUSTAID = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colTOPTUTAR = new GridColumn();
      this.colTOPKDVTUTAR = new GridColumn();
      this.colFISTUTAR = new GridColumn();
      this.colGCKOD = new GridColumn();
      this.colTRANSFERID = new GridColumn();
      this.colTRANSDEPOGCID = new GridColumn();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.colTALEPFISID = new GridColumn();
      this.colGIRISICIKISYAPID = new GridColumn();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.dataLayoutControl1 = new DataLayoutControl();
      this.timeEdit1 = new TimeEdit();
      this.searchLookUpEdit3 = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.searchLookUpEdit2 = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.dateEdit1 = new DateEdit();
      this.textEdit1 = new TextEdit();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem3 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLDEPOFISTableAdapter = new TBLDEPOFISTableAdapter();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.simpleButton1 = new SimpleButton();
      this.layoutControlItem12 = new LayoutControlItem();
      this.emptySpaceItem2 = new EmptySpaceItem();
      this.simpleButton2 = new SimpleButton();
      this.layoutControlItem13 = new LayoutControlItem();
      this.simpleButton3 = new SimpleButton();
      this.layoutControlItem14 = new LayoutControlItem();
      this.simpleButton4 = new SimpleButton();
      this.layoutControlItem15 = new LayoutControlItem();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.gridView1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.dataLayoutControl1.BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      this.timeEdit1.Properties.BeginInit();
      this.searchLookUpEdit3.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.searchLookUpEdit2.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControl4.SuspendLayout();
      this.layoutControlItem11.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.emptySpaceItem2.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[31]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barEditItem1,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barButtonItem17,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barButtonItem22,
        (BarItem) this.barEditItem2,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem5
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 35;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1259, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem2.Caption = "Sil";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
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
      this.barButtonItem8.Caption = "barButtonItem8";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "barButtonItem9";
      this.barButtonItem9.Id = 9;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Önizle";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditWidth = 100;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barButtonItem14.Caption = "İş Emri İptal";
      this.barButtonItem14.Id = 20;
      this.barButtonItem14.Name = "barButtonItem14";
      this.barButtonItem15.Caption = "barButtonItem15";
      this.barButtonItem15.Id = 21;
      this.barButtonItem15.Name = "barButtonItem15";
      this.barButtonItem16.Caption = "barButtonItem16";
      this.barButtonItem16.Id = 22;
      this.barButtonItem16.Name = "barButtonItem16";
      this.barCheckItem6.Caption = "İş Emri İptal";
      this.barCheckItem6.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem6.Id = 23;
      this.barCheckItem6.Name = "barCheckItem6";
      this.barButtonItem17.Caption = "Yazdır";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem22.Caption = "Talep Yükle";
      this.barButtonItem22.Id = 29;
      this.barButtonItem22.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.Image");
      this.barButtonItem22.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.LargeImage");
      this.barButtonItem22.LargeWidth = 100;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 120;
      this.barEditItem2.Hint = "Kayıt Bul..";
      this.barEditItem2.Id = 32;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLDEPOFISBindingSource;
      this.gridControl1.Location = new Point(94, 140);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1153, 288);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.tBLDEPOFISBindingSource.DataMember = "TBLDEPOFIS";
      this.tBLDEPOFISBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.colID,
        this.colKOD,
        this.colISEMRIID,
        this.colTARIH,
        this.colSAAT,
        this.colFISNO,
        this.colALANUSTAID,
        this.colFIRMAID,
        this.colISLEMTIPIID,
        this.colTOPTUTAR,
        this.colTOPKDVTUTAR,
        this.colFISTUTAR,
        this.colGCKOD,
        this.colTRANSFERID,
        this.colTRANSDEPOGCID,
        this.colIMZADEPOYETKILIID,
        this.colTALEPFISID,
        this.colGIRISICIKISYAPID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colGIRISICIKISYAPID, ColumnSortOrder.Descending)
      });
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colKOD.FieldName = "KOD";
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 41;
      this.colISEMRIID.FieldName = "ISEMRIID";
      this.colISEMRIID.Name = "colISEMRIID";
      this.colISEMRIID.OptionsColumn.AllowEdit = false;
      this.colISEMRIID.OptionsColumn.ReadOnly = true;
      this.colISEMRIID.Visible = true;
      this.colISEMRIID.VisibleIndex = 1;
      this.colISEMRIID.Width = 61;
      this.colTARIH.DisplayFormat.FormatString = "d";
      this.colTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 2;
      this.colTARIH.Width = 53;
      this.colSAAT.DisplayFormat.FormatString = "hh : mm";
      this.colSAAT.DisplayFormat.FormatType = FormatType.DateTime;
      this.colSAAT.FieldName = "SAAT";
      this.colSAAT.Name = "colSAAT";
      this.colSAAT.OptionsColumn.AllowEdit = false;
      this.colSAAT.OptionsColumn.ReadOnly = true;
      this.colSAAT.Visible = true;
      this.colSAAT.VisibleIndex = 3;
      this.colSAAT.Width = 47;
      this.colFISNO.FieldName = "FISNO";
      this.colFISNO.Name = "colFISNO";
      this.colFISNO.OptionsColumn.AllowEdit = false;
      this.colFISNO.OptionsColumn.ReadOnly = true;
      this.colFISNO.Visible = true;
      this.colFISNO.VisibleIndex = 4;
      this.colFISNO.Width = 48;
      this.colALANUSTAID.FieldName = "ALANUSTAID";
      this.colALANUSTAID.Name = "colALANUSTAID";
      this.colALANUSTAID.OptionsColumn.AllowEdit = false;
      this.colALANUSTAID.OptionsColumn.ReadOnly = true;
      this.colALANUSTAID.Visible = true;
      this.colALANUSTAID.VisibleIndex = 5;
      this.colALANUSTAID.Width = 40;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 6;
      this.colFIRMAID.Width = 45;
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 7;
      this.colISLEMTIPIID.Width = 40;
      this.colTOPTUTAR.FieldName = "TOPTUTAR";
      this.colTOPTUTAR.Name = "colTOPTUTAR";
      this.colTOPTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPTUTAR.Visible = true;
      this.colTOPTUTAR.VisibleIndex = 8;
      this.colTOPTUTAR.Width = 40;
      this.colTOPKDVTUTAR.FieldName = "TOPKDVTUTAR";
      this.colTOPKDVTUTAR.Name = "colTOPKDVTUTAR";
      this.colTOPKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPKDVTUTAR.Visible = true;
      this.colTOPKDVTUTAR.VisibleIndex = 9;
      this.colTOPKDVTUTAR.Width = 46;
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 10;
      this.colFISTUTAR.Width = 47;
      this.colGCKOD.FieldName = "GCKOD";
      this.colGCKOD.Name = "colGCKOD";
      this.colGCKOD.OptionsColumn.AllowEdit = false;
      this.colGCKOD.OptionsColumn.ReadOnly = true;
      this.colGCKOD.Visible = true;
      this.colGCKOD.VisibleIndex = 11;
      this.colGCKOD.Width = 44;
      this.colTRANSFERID.FieldName = "TRANSFERID";
      this.colTRANSFERID.Name = "colTRANSFERID";
      this.colTRANSFERID.OptionsColumn.AllowEdit = false;
      this.colTRANSFERID.OptionsColumn.ReadOnly = true;
      this.colTRANSFERID.Visible = true;
      this.colTRANSFERID.VisibleIndex = 12;
      this.colTRANSFERID.Width = 43;
      this.colTRANSDEPOGCID.FieldName = "TRANSDEPOGCID";
      this.colTRANSDEPOGCID.Name = "colTRANSDEPOGCID";
      this.colTRANSDEPOGCID.OptionsColumn.AllowEdit = false;
      this.colTRANSDEPOGCID.OptionsColumn.ReadOnly = true;
      this.colTRANSDEPOGCID.Visible = true;
      this.colTRANSDEPOGCID.VisibleIndex = 13;
      this.colTRANSDEPOGCID.Width = 22;
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colIMZADEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 14;
      this.colIMZADEPOYETKILIID.Width = 27;
      this.colTALEPFISID.FieldName = "TALEPFISID";
      this.colTALEPFISID.Name = "colTALEPFISID";
      this.colTALEPFISID.OptionsColumn.AllowEdit = false;
      this.colTALEPFISID.OptionsColumn.ReadOnly = true;
      this.colTALEPFISID.Visible = true;
      this.colTALEPFISID.VisibleIndex = 15;
      this.colTALEPFISID.Width = 20;
      this.colGIRISICIKISYAPID.FieldName = "GIRISICIKISYAPID";
      this.colGIRISICIKISYAPID.Name = "colGIRISICIKISYAPID";
      this.colGIRISICIKISYAPID.OptionsColumn.AllowEdit = false;
      this.colGIRISICIKISYAPID.OptionsColumn.ReadOnly = true;
      this.colGIRISICIKISYAPID.Visible = true;
      this.colGIRISICIKISYAPID.VisibleIndex = 16;
      this.colGIRISICIKISYAPID.Width = 21;
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem5.Caption = "Giriş Fişi Ekle";
      this.barButtonItem5.Id = 34;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup5,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.dataLayoutControl1);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1259, 440);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.dataLayoutControl1.Controls.Add((Control) this.timeEdit1);
      this.dataLayoutControl1.Controls.Add((Control) this.searchLookUpEdit3);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl3);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.searchLookUpEdit2);
      this.dataLayoutControl1.Controls.Add((Control) this.dateEdit1);
      this.dataLayoutControl1.Controls.Add((Control) this.textEdit1);
      this.dataLayoutControl1.Controls.Add((Control) this.searchLookUpEdit1);
      this.dataLayoutControl1.Location = new Point(12, 12);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.layoutControlGroup1;
      this.dataLayoutControl1.Size = new Size(1235, 124);
      this.dataLayoutControl1.TabIndex = 5;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      this.timeEdit1.EditValue = (object) new DateTime(2021, 12, 25, 0, 0, 0, 0);
      this.timeEdit1.Location = new Point(162, 60);
      this.timeEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.timeEdit1.Name = "timeEdit1";
      this.timeEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.timeEdit1.Size = new Size(99, 20);
      this.timeEdit1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.timeEdit1.TabIndex = 12;
      this.searchLookUpEdit3.Location = new Point(330, 60);
      this.searchLookUpEdit3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit3.Name = "searchLookUpEdit3";
      this.searchLookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit3.Properties.NullText = "";
      this.searchLookUpEdit3.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.searchLookUpEdit3.Size = new Size(299, 20);
      this.searchLookUpEdit3.StyleController = (IStyleController) this.dataLayoutControl1;
      this.searchLookUpEdit3.TabIndex = 11;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.layoutControl3.Location = new Point(633, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup3;
      this.layoutControl3.Size = new Size(590, 100);
      this.layoutControl3.TabIndex = 10;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(590, 100);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl2.Location = new Point(265, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup2;
      this.layoutControl2.Size = new Size(364, 20);
      this.layoutControl2.TabIndex = 9;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(364, 20);
      this.layoutControlGroup2.TextVisible = false;
      this.searchLookUpEdit2.Location = new Point(330, 36);
      this.searchLookUpEdit2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit2.Name = "searchLookUpEdit2";
      this.searchLookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit2.Properties.NullText = "";
      this.searchLookUpEdit2.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.searchLookUpEdit2.Size = new Size(299, 20);
      this.searchLookUpEdit2.StyleController = (IStyleController) this.dataLayoutControl1;
      this.searchLookUpEdit2.TabIndex = 8;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(77, 60);
      this.dateEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Size = new Size(81, 20);
      this.dateEdit1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.dateEdit1.TabIndex = 6;
      this.textEdit1.Location = new Point(77, 36);
      this.textEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Size = new Size(184, 20);
      this.textEdit1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.textEdit1.TabIndex = 5;
      this.searchLookUpEdit1.Location = new Point(77, 12);
      this.searchLookUpEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.NullText = "";
      this.searchLookUpEdit1.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.searchLookUpEdit1.Size = new Size(184, 20);
      this.searchLookUpEdit1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.searchLookUpEdit1.TabIndex = 4;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[9]
      {
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem6
      });
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(1235, 124);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.searchLookUpEdit1;
      this.layoutControlItem3.Location = new Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(253, 24);
      this.layoutControlItem3.Text = "İş Emri";
      this.layoutControlItem3.TextSize = new Size(62, 13);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 72);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(621, 32);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem4.Control = (Control) this.textEdit1;
      this.layoutControlItem4.Location = new Point(0, 24);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(253, 24);
      this.layoutControlItem4.Text = "Fiş Kodu";
      this.layoutControlItem4.TextSize = new Size(62, 13);
      this.layoutControlItem5.Control = (Control) this.dateEdit1;
      this.layoutControlItem5.Location = new Point(0, 48);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(150, 24);
      this.layoutControlItem5.Text = "Tarih/Saat";
      this.layoutControlItem5.TextSize = new Size(62, 13);
      this.layoutControlItem7.Control = (Control) this.searchLookUpEdit2;
      this.layoutControlItem7.Location = new Point(253, 24);
      this.layoutControlItem7.MinSize = new Size(116, 24);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(368, 24);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Alan Usta";
      this.layoutControlItem7.TextSize = new Size(62, 13);
      this.layoutControlItem8.Control = (Control) this.layoutControl2;
      this.layoutControlItem8.Location = new Point(253, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(368, 24);
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.layoutControl3;
      this.layoutControlItem9.Location = new Point(621, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(594, 104);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.searchLookUpEdit3;
      this.layoutControlItem10.Location = new Point(253, 48);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(368, 24);
      this.layoutControlItem10.Text = "Depo Yetkilisi";
      this.layoutControlItem10.TextSize = new Size(62, 13);
      this.layoutControlItem6.Control = (Control) this.timeEdit1;
      this.layoutControlItem6.Location = new Point(150, 48);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(103, 24);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[3]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem11
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1259, 440);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(82, 128);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1157, 292);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.dataLayoutControl1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1239, 128);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLDEPOFISTableAdapter.ClearBeforeFill = true;
      this.layoutControl4.Controls.Add((Control) this.simpleButton4);
      this.layoutControl4.Controls.Add((Control) this.simpleButton3);
      this.layoutControl4.Controls.Add((Control) this.simpleButton2);
      this.layoutControl4.Controls.Add((Control) this.simpleButton1);
      this.layoutControl4.Location = new Point(12, 140);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup4;
      this.layoutControl4.Size = new Size(78, 288);
      this.layoutControl4.TabIndex = 6;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlItem11.Control = (Control) this.layoutControl4;
      this.layoutControlItem11.Location = new Point(0, 128);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(82, 292);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Items.AddRange(new BaseLayoutItem[5]
      {
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.emptySpaceItem2,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15
      });
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(78, 288);
      this.layoutControlGroup4.TextVisible = false;
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(12, 12);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(54, 36);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton1.TabIndex = 4;
      this.layoutControlItem12.Control = (Control) this.simpleButton1;
      this.layoutControlItem12.Location = new Point(0, 0);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(58, 40);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new Point(0, 160);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new Size(58, 108);
      this.emptySpaceItem2.TextSize = new Size(0, 0);
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(12, 52);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(54, 36);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton2.TabIndex = 5;
      this.layoutControlItem13.Control = (Control) this.simpleButton2;
      this.layoutControlItem13.Location = new Point(0, 40);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(58, 40);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.Location = new Point(12, 92);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(54, 36);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton3.TabIndex = 6;
      this.layoutControlItem14.Control = (Control) this.simpleButton3;
      this.layoutControlItem14.Location = new Point(0, 80);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(58, 40);
      this.layoutControlItem14.TextSize = new Size(0, 0);
      this.layoutControlItem14.TextVisible = false;
      this.simpleButton4.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton4.ImageOptions.Image");
      this.simpleButton4.Location = new Point(12, 132);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.PaintStyle = PaintStyles.Light;
      this.simpleButton4.Size = new Size(54, 36);
      this.simpleButton4.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton4.TabIndex = 7;
      this.layoutControlItem15.Control = (Control) this.simpleButton4;
      this.layoutControlItem15.Location = new Point(0, 120);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(58, 40);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1259, 540);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (CikisFisEkle);
      this.Text = nameof (CikisFisEkle);
      this.Load += new EventHandler(this.GirisFisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.gridView1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.dataLayoutControl1.EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      this.timeEdit1.Properties.EndInit();
      this.searchLookUpEdit3.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup2.EndInit();
      this.searchLookUpEdit2.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.textEdit1.Properties.EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem3.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem6.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControl4.ResumeLayout(false);
      this.layoutControlItem11.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControlItem12.EndInit();
      this.emptySpaceItem2.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
