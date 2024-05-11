// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.CikisFisGirisFisiEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.DepoModel;
using Makina_Ikmal.DepoModel.CikisFisicinGirisfislistesiTableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class CikisFisGirisFisiEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
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
    private BarButtonItem barButtonItem22;
    private BarEditItem barEditItem2;
    private BarButtonItem barButtonItem1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private BarEditItem barEditItem3;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private RepositoryItemSearchLookUpEdit IslemYeri;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit IslemTipi;
    private GridView gridView2;
    private RepositoryItemSearchLookUpEdit DepoYetkili;
    private GridView gridView3;
    private RepositoryItemSearchLookUpEdit FirmaAdi;
    private GridView gridView4;
    private CikisFisicinGirisfislistesi cikisFisicinGirisfislistesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colİşEmriKodu;
    private GridColumn colARACID;
    private GridColumn colID;
    private GridColumn colDepoFişKodu;
    private GridColumn colTARIH;
    private GridColumn colFIRMAID;
    private GridColumn colFISTUTAR;
    private GridColumn colTOPKDVTUTAR;
    private GridColumn colTalepFişKodu;
    private GridColumn colIMZADEPOYETKILIID;
    private GridColumn colISLEMTIPIID;
    private GridColumn colISLEMTIPI;
    private GridColumn gridColumn1;

    public CikisFisGirisFisiEkle() => this.InitializeComponent();

    private void GirisFisTalepFisiListe_Load(object sender, EventArgs e) => this.dataTable1TableAdapter.Fill(this.cikisFisicinGirisfislistesi.DataTable1);

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("Expr1"));
      YetkiClass.secim_id2 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TalepfisId"));
      YetkiClass.secim = "fis";
      TBLDEPOFIS tbldepofis = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (tbldepofis.SAVEUSER == "1" || tbldepofis.SAVEUSER == null)
      {
        this.Close();
        ((CikisFisEkle) Application.OpenForms["CikisFisEkle"])?.talepFistenGelenVeri();
      }
      else
      {
        if (!(tbldepofis.SAVEUSER == "2"))
          return;
        int num = (int) XtraMessageBox.Show("Bu Fiş Daha Önce eklenmiştir.");
      }
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void gridView1_RowClick(object sender, RowClickEventArgs e)
    {
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("Expr1"));
      YetkiClass.secim_id2 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TalepfisId"));
      YetkiClass.secim = "fis";
      TBLDEPOFIS tbldepofis = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (tbldepofis.SAVEUSER == "1" || tbldepofis.SAVEUSER == null)
      {
        this.Close();
        ((CikisFisEkle) Application.OpenForms["CikisFisEkle"])?.talepFistenGelenVeri();
      }
      else
      {
        if (!(tbldepofis.SAVEUSER == "2"))
          return;
        int num = (int) XtraMessageBox.Show("Bu Fiş Daha Önce eklenmiştir.");
      }
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CikisFisGirisFisiEkle));
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
      this.barButtonItem1 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.cikisFisicinGirisfislistesi = new CikisFisicinGirisfislistesi();
      this.gridView1 = new GridView();
      this.colİşEmriKodu = new GridColumn();
      this.colARACID = new GridColumn();
      this.colID = new GridColumn();
      this.colDepoFişKodu = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.colFISTUTAR = new GridColumn();
      this.colTOPKDVTUTAR = new GridColumn();
      this.colTalepFişKodu = new GridColumn();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colISLEMTIPI = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.IslemYeri = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.IslemTipi = new RepositoryItemSearchLookUpEdit();
      this.gridView2 = new GridView();
      this.DepoYetkili = new RepositoryItemSearchLookUpEdit();
      this.gridView3 = new GridView();
      this.FirmaAdi = new RepositoryItemSearchLookUpEdit();
      this.gridView4 = new GridView();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.cikisFisicinGirisfislistesi.BeginInit();
      this.gridView1.BeginInit();
      this.IslemYeri.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.IslemTipi.BeginInit();
      this.gridView2.BeginInit();
      this.DepoYetkili.BeginInit();
      this.gridView3.BeginInit();
      this.FirmaAdi.BeginInit();
      this.gridView4.BeginInit();
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
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 36;
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
      this.ribbonControl1.Size = new Size(1202, 122);
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
      this.barButtonItem13.Caption = "Fişi Ekle";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
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
      this.barButtonItem17.Caption = "Yenile";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
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
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 120;
      this.barEditItem2.Hint = "Kayıt Bul..";
      this.barEditItem2.Id = 32;
      this.barEditItem2.Name = "barEditItem2";
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 30;
      this.barEditItem3.EditWidth = 120;
      this.barEditItem3.Hint = "Kayıt Bul...";
      this.barEditItem3.Id = 35;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.IslemYeri,
        (RepositoryItem) this.IslemTipi,
        (RepositoryItem) this.DepoYetkili,
        (RepositoryItem) this.FirmaAdi
      });
      this.gridControl1.Size = new Size(1202, 528);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.cikisFisicinGirisfislistesi;
      this.cikisFisicinGirisfislistesi.DataSetName = "CikisFisicinGirisfislistesi";
      this.cikisFisicinGirisfislistesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.colİşEmriKodu,
        this.colARACID,
        this.colID,
        this.colDepoFişKodu,
        this.colTARIH,
        this.colFIRMAID,
        this.colFISTUTAR,
        this.colTOPKDVTUTAR,
        this.colTalepFişKodu,
        this.colIMZADEPOYETKILIID,
        this.colISLEMTIPIID,
        this.colISLEMTIPI,
        this.gridColumn1
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colID, ColumnSortOrder.Descending)
      });
      this.gridView1.RowClick += new RowClickEventHandler(this.gridView1_RowClick);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colİşEmriKodu.FieldName = "İş Emri Kodu";
      this.colİşEmriKodu.MinWidth = 25;
      this.colİşEmriKodu.Name = "colİşEmriKodu";
      this.colİşEmriKodu.OptionsColumn.AllowEdit = false;
      this.colİşEmriKodu.OptionsColumn.ReadOnly = true;
      this.colİşEmriKodu.Visible = true;
      this.colİşEmriKodu.VisibleIndex = 0;
      this.colİşEmriKodu.Width = 87;
      this.colARACID.Caption = "Plaka";
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 25;
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 1;
      this.colARACID.Width = 87;
      this.colID.FieldName = "Expr1";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 87;
      this.colDepoFişKodu.FieldName = "Depo Fiş Kodu";
      this.colDepoFişKodu.MinWidth = 25;
      this.colDepoFişKodu.Name = "colDepoFişKodu";
      this.colDepoFişKodu.OptionsColumn.AllowEdit = false;
      this.colDepoFişKodu.OptionsColumn.ReadOnly = true;
      this.colDepoFişKodu.Visible = true;
      this.colDepoFişKodu.VisibleIndex = 2;
      this.colDepoFişKodu.Width = 87;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 3;
      this.colTARIH.Width = 87;
      this.colFIRMAID.Caption = "Firma";
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 25;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 4;
      this.colFIRMAID.Width = 87;
      this.colFISTUTAR.Caption = "Fis Tutarı";
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.MinWidth = 25;
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 5;
      this.colFISTUTAR.Width = 87;
      this.colTOPKDVTUTAR.Caption = "Toplam Kdv Tutarı";
      this.colTOPKDVTUTAR.FieldName = "TOPKDVTUTAR";
      this.colTOPKDVTUTAR.MinWidth = 25;
      this.colTOPKDVTUTAR.Name = "colTOPKDVTUTAR";
      this.colTOPKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPKDVTUTAR.Visible = true;
      this.colTOPKDVTUTAR.VisibleIndex = 6;
      this.colTOPKDVTUTAR.Width = 87;
      this.colTalepFişKodu.FieldName = "Talep Fiş Kodu";
      this.colTalepFişKodu.MinWidth = 25;
      this.colTalepFişKodu.Name = "colTalepFişKodu";
      this.colTalepFişKodu.OptionsColumn.AllowEdit = false;
      this.colTalepFişKodu.OptionsColumn.ReadOnly = true;
      this.colTalepFişKodu.Visible = true;
      this.colTalepFişKodu.VisibleIndex = 7;
      this.colTalepFişKodu.Width = 87;
      this.colIMZADEPOYETKILIID.Caption = "İmza Depo Yetkilisi";
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.MinWidth = 25;
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colIMZADEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 8;
      this.colIMZADEPOYETKILIID.Width = 87;
      this.colISLEMTIPIID.Caption = "İşlem Tipi No";
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 25;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 9;
      this.colISLEMTIPIID.Width = 87;
      this.colISLEMTIPI.Caption = "İşlem Tipi";
      this.colISLEMTIPI.FieldName = "ISLEMTIPI";
      this.colISLEMTIPI.MinWidth = 25;
      this.colISLEMTIPI.Name = "colISLEMTIPI";
      this.colISLEMTIPI.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPI.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPI.Visible = true;
      this.colISLEMTIPI.VisibleIndex = 10;
      this.colISLEMTIPI.Width = 87;
      this.gridColumn1.Caption = "Talep Fiş Id";
      this.gridColumn1.FieldName = "TalepfisId";
      this.gridColumn1.MinWidth = 25;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Width = 94;
      this.IslemYeri.AutoHeight = false;
      this.IslemYeri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IslemYeri.DisplayMember = "PLAKA";
      this.IslemYeri.Name = "IslemYeri";
      this.IslemYeri.NullText = "";
      this.IslemYeri.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.IslemYeri.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.IslemTipi.AutoHeight = false;
      this.IslemTipi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IslemTipi.DisplayMember = "ISLEMTIPI";
      this.IslemTipi.Name = "IslemTipi";
      this.IslemTipi.NullText = "";
      this.IslemTipi.PopupView = (ColumnView) this.gridView2;
      this.IslemTipi.ValueMember = "ID";
      this.gridView2.DetailHeight = 431;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.DepoYetkili.AutoHeight = false;
      this.DepoYetkili.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.DepoYetkili.DisplayMember = "ADISOYADI";
      this.DepoYetkili.Name = "DepoYetkili";
      this.DepoYetkili.NullText = "";
      this.DepoYetkili.PopupView = (ColumnView) this.gridView3;
      this.DepoYetkili.ValueMember = "ID";
      this.gridView3.DetailHeight = 431;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.FirmaAdi.AutoHeight = false;
      this.FirmaAdi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.FirmaAdi.DisplayMember = "FIRMAADI";
      this.FirmaAdi.Name = "FirmaAdi";
      this.FirmaAdi.NullText = "";
      this.FirmaAdi.PopupView = (ColumnView) this.gridView4;
      this.FirmaAdi.ValueMember = "ID";
      this.gridView4.DetailHeight = 431;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup5,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barEditItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1202, 650);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (CikisFisGirisFisiEkle);
      this.Text = "Çıkışa Ekleme Ekle";
      this.Load += new EventHandler(this.GirisFisTalepFisiListe_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.cikisFisicinGirisfislistesi.EndInit();
      this.gridView1.EndInit();
      this.IslemYeri.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.IslemTipi.EndInit();
      this.gridView2.EndInit();
      this.DepoYetkili.EndInit();
      this.gridView3.EndInit();
      this.FirmaAdi.EndInit();
      this.gridView4.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
