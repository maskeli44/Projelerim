// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.GirisFisEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class GirisFisEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId kul = new KullaniciSonId();
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
    private TimeEdit saat;
    private SearchLookUpEdit depoYetkilisiLook;
    private GridView searchLookUpEdit3View;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup2;
    private SearchLookUpEdit firmaAdiLook;
    private GridView searchLookUpEdit2View;
    private DateEdit tarih;
    private TextEdit fisKoduTxt;
    private SearchLookUpEdit isEmriLook;
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
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem2;
    private BarButtonItem barButtonItem22;
    private RibbonPageGroup ribbonPageGroup3;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn gridColumn1;
    private BindingSource girisFisEkle1BindingSource;
    private GirisFisEkle girisFisEkle1;
    private BindingSource tBLMALZEMELERBindingSource;
    private BindingSource tBLDEPOFISBindingSource;
    private TBLDEPOFISTableAdapter tBLDEPOFISTableAdapter;
    private BindingSource tBLMALZDEPOBindingSource;
    private TBLMALZDEPOTableAdapter tBLMALZDEPOTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLMALZKDVBindingSource;
    private TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private BindingSource tBLMALZEMELERBindingSource1;
    private BindingSource dataTable1BindingSource;
    private BindingSource dataTable1BindingSource1;
    private BindingSource talepeklemeAnaBindingSource1;

    public GirisFisEkle() => this.InitializeComponent();

    private void GirisFisEkle_Load(object sender, EventArgs e)
    {
    }

    public void talepFistenGelenVeri()
    {
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GirisFisEkle));
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
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.talepeklemeAnaBindingSource1 = new BindingSource(this.components);
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERBindingSource1 = new BindingSource(this.components);
      this.girisFisEkle1BindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.tBLMALZDEPOBindingSource = new BindingSource(this.components);
      this.layoutControl1 = new LayoutControl();
      this.dataLayoutControl1 = new DataLayoutControl();
      this.saat = new TimeEdit();
      this.depoYetkilisiLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.firmaAdiLook = new SearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit2View = new GridView();
      this.tarih = new DateEdit();
      this.fisKoduTxt = new TextEdit();
      this.isEmriLook = new SearchLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
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
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLDEPOFISBindingSource = new BindingSource(this.components);
      this.tBLDEPOFISTableAdapter = new TBLDEPOFISTableAdapter();
      this.tBLMALZDEPOTableAdapter = new TBLMALZDEPOTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZKDVTableAdapter = new TBLMALZKDVTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      ((ISupportInitialize) this.talepeklemeAnaBindingSource1).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).BeginInit();
      ((ISupportInitialize) this.girisFisEkle1BindingSource).BeginInit();
      ((ISupportInitialize) this.girisFisEkle1).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.dataLayoutControl1.BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      this.saat.Properties.BeginInit();
      this.depoYetkilisiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.firmaAdiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.tarih.Properties.CalendarTimeProperties.BeginInit();
      this.tarih.Properties.BeginInit();
      this.fisKoduTxt.Properties.BeginInit();
      this.isEmriLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
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
      this.layoutControlItem2.BeginInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).BeginInit();
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
      this.ribbonControl1.OptionsMenuMinWidth = 288;
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
      this.ribbonControl1.Size = new Size(1469, 118);
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
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.talepeklemeAnaBindingSource1;
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem5.Caption = "Talep Yükle";
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
      this.tBLMALZEMELERBindingSource1.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource1.DataSource = (object) this.girisFisEkle1BindingSource;
      this.girisFisEkle1BindingSource.DataSource = (object) this.girisFisEkle1;
      this.girisFisEkle1BindingSource.Position = 0;
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.girisFisEkle1BindingSource;
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet6;
      this.tBLMALZDEPOBindingSource.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource.DataSource = (object) this.bellDataSet6;
      this.layoutControl1.Controls.Add((Control) this.dataLayoutControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1469, 547);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.dataLayoutControl1.Controls.Add((Control) this.saat);
      this.dataLayoutControl1.Controls.Add((Control) this.depoYetkilisiLook);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl3);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.firmaAdiLook);
      this.dataLayoutControl1.Controls.Add((Control) this.tarih);
      this.dataLayoutControl1.Controls.Add((Control) this.fisKoduTxt);
      this.dataLayoutControl1.Controls.Add((Control) this.isEmriLook);
      this.dataLayoutControl1.Location = new Point(14, 14);
      this.dataLayoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.layoutControlGroup1;
      this.dataLayoutControl1.Size = new Size(1441, 519);
      this.dataLayoutControl1.TabIndex = 5;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      this.saat.EditValue = (object) new DateTime(2021, 12, 25, 0, 0, 0, 0);
      this.saat.Location = new Point(195, 82);
      this.saat.Margin = new Padding(3, 4, 3, 4);
      this.saat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saat.Name = "saat";
      this.saat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saat.Properties.Appearance.Options.UseFont = true;
      this.saat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saat.Size = new Size(110, 30);
      this.saat.StyleController = (IStyleController) this.dataLayoutControl1;
      this.saat.TabIndex = 12;
      this.depoYetkilisiLook.Location = new Point(424, 82);
      this.depoYetkilisiLook.Margin = new Padding(3, 4, 3, 4);
      this.depoYetkilisiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.depoYetkilisiLook.Name = "depoYetkilisiLook";
      this.depoYetkilisiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.depoYetkilisiLook.Properties.Appearance.Options.UseFont = true;
      this.depoYetkilisiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depoYetkilisiLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.depoYetkilisiLook.Properties.DisplayMember = "ADISOYADI";
      this.depoYetkilisiLook.Properties.NullText = "";
      this.depoYetkilisiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.depoYetkilisiLook.Properties.ValueMember = "ID";
      this.depoYetkilisiLook.Size = new Size(310, 30);
      this.depoYetkilisiLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.depoYetkilisiLook.TabIndex = 11;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet6;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit3View.DetailHeight = 431;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "AdıSoyadı";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.layoutControl3.Location = new Point(738, 14);
      this.layoutControl3.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup3;
      this.layoutControl3.Size = new Size(689, 491);
      this.layoutControl3.TabIndex = 10;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(689, 491);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl2.Location = new Point(309, 14);
      this.layoutControl2.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup2;
      this.layoutControl2.Size = new Size(425, 30);
      this.layoutControl2.TabIndex = 9;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(425, 30);
      this.layoutControlGroup2.TextVisible = false;
      this.firmaAdiLook.Enabled = false;
      this.firmaAdiLook.Location = new Point(424, 48);
      this.firmaAdiLook.Margin = new Padding(3, 4, 3, 4);
      this.firmaAdiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firmaAdiLook.Name = "firmaAdiLook";
      this.firmaAdiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.firmaAdiLook.Properties.Appearance.Options.UseFont = true;
      this.firmaAdiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmaAdiLook.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firmaAdiLook.Properties.DisplayMember = "FIRMAADI";
      this.firmaAdiLook.Properties.NullText = "";
      this.firmaAdiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.firmaAdiLook.Properties.ValueMember = "ID";
      this.firmaAdiLook.Size = new Size(310, 30);
      this.firmaAdiLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.firmaAdiLook.TabIndex = 8;
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet6;
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.tarih.EditValue = (object) null;
      this.tarih.Location = new Point(129, 82);
      this.tarih.Margin = new Padding(3, 4, 3, 4);
      this.tarih.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarih.Name = "tarih";
      this.tarih.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarih.Properties.Appearance.Options.UseFont = true;
      this.tarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Size = new Size(62, 30);
      this.tarih.StyleController = (IStyleController) this.dataLayoutControl1;
      this.tarih.TabIndex = 6;
      this.fisKoduTxt.Enabled = false;
      this.fisKoduTxt.Location = new Point(129, 48);
      this.fisKoduTxt.Margin = new Padding(3, 4, 3, 4);
      this.fisKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisKoduTxt.Name = "fisKoduTxt";
      this.fisKoduTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.fisKoduTxt.Properties.Appearance.Options.UseFont = true;
      this.fisKoduTxt.Size = new Size(176, 30);
      this.fisKoduTxt.StyleController = (IStyleController) this.dataLayoutControl1;
      this.fisKoduTxt.TabIndex = 5;
      this.fisKoduTxt.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.isEmriLook.Enabled = false;
      this.isEmriLook.Location = new Point(129, 14);
      this.isEmriLook.Margin = new Padding(3, 4, 3, 4);
      this.isEmriLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isEmriLook.Name = "isEmriLook";
      this.isEmriLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isEmriLook.Properties.Appearance.Options.UseFont = true;
      this.isEmriLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isEmriLook.Properties.DataSource = (object) this.tBLISEMRIBindingSource;
      this.isEmriLook.Properties.DisplayMember = "KOD";
      this.isEmriLook.Properties.NullText = "";
      this.isEmriLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.isEmriLook.Properties.ValueMember = "ID";
      this.isEmriLook.Size = new Size(176, 30);
      this.isEmriLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.isEmriLook.TabIndex = 4;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet6;
      this.searchLookUpEdit1View.DetailHeight = 431;
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
      this.layoutControlGroup1.Size = new Size(1441, 519);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.isEmriLook;
      this.layoutControlItem3.Location = new Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(295, 34);
      this.layoutControlItem3.Text = "İş Emri";
      this.layoutControlItem3.TextSize = new Size(112, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 102);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(724, 393);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.fisKoduTxt;
      this.layoutControlItem4.Location = new Point(0, 34);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(295, 34);
      this.layoutControlItem4.Text = "Fiş Kodu";
      this.layoutControlItem4.TextSize = new Size(112, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.tarih;
      this.layoutControlItem5.Location = new Point(0, 68);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(181, 34);
      this.layoutControlItem5.Text = "Tarih/Saat";
      this.layoutControlItem5.TextSize = new Size(112, 24);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.firmaAdiLook;
      this.layoutControlItem7.Location = new Point(295, 34);
      this.layoutControlItem7.MinSize = new Size(135, 30);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(429, 34);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Firma Adı";
      this.layoutControlItem7.TextSize = new Size(112, 24);
      this.layoutControlItem8.Control = (Control) this.layoutControl2;
      this.layoutControlItem8.Location = new Point(295, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(429, 34);
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.layoutControl3;
      this.layoutControlItem9.Location = new Point(724, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(693, 495);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.depoYetkilisiLook;
      this.layoutControlItem10.Location = new Point(295, 68);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(429, 34);
      this.layoutControlItem10.Text = "Depo Yetkilisi";
      this.layoutControlItem10.TextSize = new Size(112, 24);
      this.layoutControlItem6.Control = (Control) this.saat;
      this.layoutControlItem6.Location = new Point(181, 68);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(114, 34);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1469, 547);
      this.Root.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.dataLayoutControl1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1445, 523);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLDEPOFISBindingSource.DataMember = "TBLDEPOFIS";
      this.tBLDEPOFISBindingSource.DataSource = (object) this.bellDataSet6;
      this.tBLDEPOFISTableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1469, 665);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (GirisFisEkle);
      this.Text = nameof (GirisFisEkle);
      this.Load += new EventHandler(this.GirisFisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).EndInit();
      ((ISupportInitialize) this.girisFisEkle1BindingSource).EndInit();
      ((ISupportInitialize) this.girisFisEkle1).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.dataLayoutControl1.EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      this.saat.Properties.EndInit();
      this.depoYetkilisiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup2.EndInit();
      this.firmaAdiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.tarih.Properties.CalendarTimeProperties.EndInit();
      this.tarih.Properties.EndInit();
      this.fisKoduTxt.Properties.EndInit();
      this.isEmriLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
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
      this.layoutControlItem2.EndInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
