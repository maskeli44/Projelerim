// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AKemalBaskanlik.IsEmriTvEkran
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AKemalBaskanlik
{
  public class IsEmriTvEkran : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage1;
    private GridControl gridControl2;
    private GridView gridView2;
    private SimpleButton simpleButton1;
    private TabPane tabPane1;
    private GridControl gridControl1;
    private GridView gridView1;
    private BarButtonItem barButtonItem13;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private BarCheckItem barCheckItem6;
    private GridControl gridControl3;
    private GridView gridView3;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem2;
    private RepositoryItemSearchLookUpEdit AnaGrup;
    private GridView gridView5;
    private RepositoryItemSearchLookUpEdit AltGrup;
    private GridView gridView7;
    private RepositoryItemSearchLookUpEdit IsEmriDurum;
    private GridView gridView8;
    private BarHeaderItem barHeaderItem1;
    private RibbonPageGroup ribbonPageGroup1;
    private BaskanlikIsEmriTvEkran baskanlikIsEmriTvEkran;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.Model.BaskanlikIsEmriTvEkranTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colIsEmriID;
    private GridColumn colGIRISTARIH;
    private GridColumn colMODEL;
    private GridColumn colAnaGrup;
    private GridColumn colAltGrup;
    private GridColumn colBILDIRILENARIZA;
    private GridColumn colISEMRIDURUMID;
    private GridColumn colKOD;
    private GridColumn colPLAKA;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLARACGRUBUBindingSource;
    private TBLARACGRUBUTableAdapter tBLARACGRUBUTableAdapter;
    private BindingSource tBLARACGRUBU2BindingSource;
    private TBLARACGRUBU2TableAdapter tBLARACGRUBU2TableAdapter;
    private BindingSource tBLISEMIRDURUMBindingSource;
    private TBLISEMIRDURUMTableAdapter tBLISEMIRDURUMTableAdapter;
    private BindingSource baskanlikIsEmriTvEkranCikisYapanBindingSource;
    private BaskanlikIsEmriTvEkranCikisYapan baskanlikIsEmriTvEkranCikisYapan;
    private BindingSource dataTable1BindingSource1;
    private Makina_Ikmal.Model.BaskanlikIsEmriTvEkranCikisYapanTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn colCIKISTARIH;
    private GridColumn colPLAKA1;
    private GridColumn colAnaGrup1;
    private GridColumn colAltGrup1;
    private GridColumn colYAPILANBAKIM;
    private GridColumn colARIZANEDENIID;
    private GridColumn colISEMRIDURUMID1;
    private GridColumn colKOD1;
    private GridColumn colIsEmriId1;
    private GridColumn colAracID;
    private RepositoryItemSearchLookUpEdit AltGrp;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit AnaGrp;
    private GridView repositoryItemSearchLookUpEdit2View;
    private RepositoryItemSearchLookUpEdit ArizaNeden;
    private GridView gridView4;
    private RepositoryItemSearchLookUpEdit İsEmriDurum;
    private GridView gridView6;
    private BindingSource tAHARIZANEDENIBindingSource;
    private TAHARIZANEDENITableAdapter tAHARIZANEDENITableAdapter;

    public IsEmriTvEkran() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      try
      {
        this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet6.TAHARIZANEDENI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter1.Fill(this.baskanlikIsEmriTvEkranCikisYapan.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet6.TBLISEMIRDURUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBU2TableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU2);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBUTableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikIsEmriTvEkran.DataTable1);
      }
      catch (Exception ex)
      {
      }
      this.listele();
    }

    public void listele()
    {
      try
      {
        this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet6.TAHARIZANEDENI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter1.Fill(this.baskanlikIsEmriTvEkranCikisYapan.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet6.TBLISEMIRDURUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBU2TableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU2);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBUTableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikIsEmriTvEkran.DataTable1);
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl2_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView7_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IsEmriTvEkran));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barHeaderItem1 = new BarHeaderItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.baskanlikIsEmriTvEkran = new BaskanlikIsEmriTvEkran();
      this.gridView1 = new GridView();
      this.colIsEmriID = new GridColumn();
      this.colGIRISTARIH = new GridColumn();
      this.colMODEL = new GridColumn();
      this.colAnaGrup = new GridColumn();
      this.AnaGrup = new RepositoryItemSearchLookUpEdit();
      this.tBLARACGRUBUBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.gridView5 = new GridView();
      this.colAltGrup = new GridColumn();
      this.AltGrup = new RepositoryItemSearchLookUpEdit();
      this.tBLARACGRUBU2BindingSource = new BindingSource(this.components);
      this.gridView7 = new GridView();
      this.colBILDIRILENARIZA = new GridColumn();
      this.colISEMRIDURUMID = new GridColumn();
      this.IsEmriDurum = new RepositoryItemSearchLookUpEdit();
      this.tBLISEMIRDURUMBindingSource = new BindingSource(this.components);
      this.gridView8 = new GridView();
      this.colKOD = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.baskanlikIsEmriTvEkranCikisYapanBindingSource = new BindingSource(this.components);
      this.baskanlikIsEmriTvEkranCikisYapan = new BaskanlikIsEmriTvEkranCikisYapan();
      this.gridView3 = new GridView();
      this.colCIKISTARIH = new GridColumn();
      this.colPLAKA1 = new GridColumn();
      this.colAnaGrup1 = new GridColumn();
      this.AnaGrp = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit2View = new GridView();
      this.colAltGrup1 = new GridColumn();
      this.AltGrp = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colYAPILANBAKIM = new GridColumn();
      this.colARIZANEDENIID = new GridColumn();
      this.ArizaNeden = new RepositoryItemSearchLookUpEdit();
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.gridView4 = new GridView();
      this.colISEMRIDURUMID1 = new GridColumn();
      this.İsEmriDurum = new RepositoryItemSearchLookUpEdit();
      this.gridView6 = new GridView();
      this.colKOD1 = new GridColumn();
      this.colIsEmriId1 = new GridColumn();
      this.colAracID = new GridColumn();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.simpleButton1 = new SimpleButton();
      this.tabPane1 = new TabPane();
      this.layoutControl1 = new LayoutControl();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.BaskanlikIsEmriTvEkranTableAdapters.DataTable1TableAdapter();
      this.tBLARACGRUBUTableAdapter = new TBLARACGRUBUTableAdapter();
      this.tBLARACGRUBU2TableAdapter = new TBLARACGRUBU2TableAdapter();
      this.tBLISEMIRDURUMTableAdapter = new TBLISEMIRDURUMTableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.BaskanlikIsEmriTvEkranCikisYapanTableAdapters.DataTable1TableAdapter();
      this.tAHARIZANEDENITableAdapter = new TAHARIZANEDENITableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.baskanlikIsEmriTvEkran.BeginInit();
      this.gridView1.BeginInit();
      this.AnaGrup.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.gridView5.BeginInit();
      this.AltGrup.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).BeginInit();
      this.gridView7.BeginInit();
      this.IsEmriDurum.BeginInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).BeginInit();
      this.gridView8.BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      ((ISupportInitialize) this.baskanlikIsEmriTvEkranCikisYapanBindingSource).BeginInit();
      this.baskanlikIsEmriTvEkranCikisYapan.BeginInit();
      this.gridView3.BeginInit();
      this.AnaGrp.BeginInit();
      this.repositoryItemSearchLookUpEdit2View.BeginInit();
      this.AltGrp.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.ArizaNeden.BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
      this.gridView4.BeginInit();
      this.İsEmriDurum.BeginInit();
      this.gridView6.BeginInit();
      this.tabNavigationPage1.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView2.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.Root.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[26]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barHeaderItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 30;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 329;
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
      this.ribbonControl1.Size = new Size(1519, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
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
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Filtrele";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem2.CheckedChanged += new ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.CheckedChanged += new ItemClickEventHandler(this.barCheckItem3_CheckedChanged);
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem4.CheckedChanged += new ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem5.CheckedChanged += new ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
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
      this.barCheckItem6.CheckedChanged += new ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem18.ItemClick += new ItemClickEventHandler(this.barButtonItem18_ItemClick);
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barHeaderItem1.Appearance.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barHeaderItem1.Appearance.Options.UseFont = true;
      this.barHeaderItem1.Caption = "MAKİNA İKMAL ŞUBE MÜDÜRLÜĞÜ - ARAÇ BAKIM DURUM EKRANI";
      this.barHeaderItem1.Id = 29;
      this.barHeaderItem1.Name = "barHeaderItem1";
      this.barHeaderItem1.Width = 750;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup1
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barHeaderItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.repositoryItemSearchControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.AnaGrup,
        (RepositoryItem) this.AltGrup,
        (RepositoryItem) this.IsEmriDurum
      });
      this.gridControl1.Size = new Size(1495, 808);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.baskanlikIsEmriTvEkran;
      this.baskanlikIsEmriTvEkran.DataSetName = "BaskanlikIsEmriTvEkran";
      this.baskanlikIsEmriTvEkran.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[9]
      {
        this.colIsEmriID,
        this.colGIRISTARIH,
        this.colMODEL,
        this.colAnaGrup,
        this.colAltGrup,
        this.colBILDIRILENARIZA,
        this.colISEMRIDURUMID,
        this.colKOD,
        this.colPLAKA
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colIsEmriID.FieldName = "IsEmriID";
      this.colIsEmriID.MinWidth = 27;
      this.colIsEmriID.Name = "colIsEmriID";
      this.colIsEmriID.OptionsColumn.AllowEdit = false;
      this.colIsEmriID.OptionsColumn.ReadOnly = true;
      this.colIsEmriID.Width = 100;
      this.colGIRISTARIH.Caption = "Giriş Tarihi";
      this.colGIRISTARIH.FieldName = "GIRISTARIH";
      this.colGIRISTARIH.MinWidth = 27;
      this.colGIRISTARIH.Name = "colGIRISTARIH";
      this.colGIRISTARIH.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH.Visible = true;
      this.colGIRISTARIH.VisibleIndex = 0;
      this.colGIRISTARIH.Width = 151;
      this.colMODEL.Caption = "Model";
      this.colMODEL.FieldName = "MODEL";
      this.colMODEL.MinWidth = 27;
      this.colMODEL.Name = "colMODEL";
      this.colMODEL.OptionsColumn.AllowEdit = false;
      this.colMODEL.OptionsColumn.ReadOnly = true;
      this.colMODEL.Visible = true;
      this.colMODEL.VisibleIndex = 2;
      this.colMODEL.Width = 100;
      this.colAnaGrup.ColumnEdit = (RepositoryItem) this.AnaGrup;
      this.colAnaGrup.FieldName = "Ana Grup";
      this.colAnaGrup.MinWidth = 27;
      this.colAnaGrup.Name = "colAnaGrup";
      this.colAnaGrup.OptionsColumn.AllowEdit = false;
      this.colAnaGrup.OptionsColumn.ReadOnly = true;
      this.colAnaGrup.Visible = true;
      this.colAnaGrup.VisibleIndex = 3;
      this.colAnaGrup.Width = 121;
      this.AnaGrup.AutoHeight = false;
      this.AnaGrup.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AnaGrup.DataSource = (object) this.tBLARACGRUBUBindingSource;
      this.AnaGrup.DisplayMember = "GRUPADI";
      this.AnaGrup.Name = "AnaGrup";
      this.AnaGrup.NullText = "";
      this.AnaGrup.PopupView = (ColumnView) this.gridView5;
      this.AnaGrup.ValueMember = "ID";
      this.tBLARACGRUBUBindingSource.DataMember = "TBLARACGRUBU";
      this.tBLARACGRUBUBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView5.DetailHeight = 431;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colAltGrup.ColumnEdit = (RepositoryItem) this.AltGrup;
      this.colAltGrup.FieldName = "Alt Grup";
      this.colAltGrup.MinWidth = 27;
      this.colAltGrup.Name = "colAltGrup";
      this.colAltGrup.OptionsColumn.AllowEdit = false;
      this.colAltGrup.OptionsColumn.ReadOnly = true;
      this.colAltGrup.Visible = true;
      this.colAltGrup.VisibleIndex = 4;
      this.colAltGrup.Width = 100;
      this.AltGrup.AutoHeight = false;
      this.AltGrup.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AltGrup.DataSource = (object) this.tBLARACGRUBU2BindingSource;
      this.AltGrup.DisplayMember = "GRUPADI";
      this.AltGrup.Name = "AltGrup";
      this.AltGrup.NullText = "";
      this.AltGrup.PopupView = (ColumnView) this.gridView7;
      this.AltGrup.ValueMember = "ID";
      this.tBLARACGRUBU2BindingSource.DataMember = "TBLARACGRUBU2";
      this.tBLARACGRUBU2BindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView7.DetailHeight = 431;
      this.gridView7.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView7.OptionsView.ShowGroupPanel = false;
      this.colBILDIRILENARIZA.Caption = "Bildirilen Arıza";
      this.colBILDIRILENARIZA.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA.MinWidth = 27;
      this.colBILDIRILENARIZA.Name = "colBILDIRILENARIZA";
      this.colBILDIRILENARIZA.OptionsColumn.AllowEdit = false;
      this.colBILDIRILENARIZA.OptionsColumn.ReadOnly = true;
      this.colBILDIRILENARIZA.Visible = true;
      this.colBILDIRILENARIZA.VisibleIndex = 5;
      this.colBILDIRILENARIZA.Width = 205;
      this.colISEMRIDURUMID.Caption = "İş Emri Durumu";
      this.colISEMRIDURUMID.ColumnEdit = (RepositoryItem) this.IsEmriDurum;
      this.colISEMRIDURUMID.FieldName = "ISEMRIDURUMID";
      this.colISEMRIDURUMID.MinWidth = 27;
      this.colISEMRIDURUMID.Name = "colISEMRIDURUMID";
      this.colISEMRIDURUMID.OptionsColumn.AllowEdit = false;
      this.colISEMRIDURUMID.OptionsColumn.ReadOnly = true;
      this.colISEMRIDURUMID.Visible = true;
      this.colISEMRIDURUMID.VisibleIndex = 6;
      this.colISEMRIDURUMID.Width = 196;
      this.IsEmriDurum.AutoHeight = false;
      this.IsEmriDurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IsEmriDurum.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.IsEmriDurum.DisplayMember = "ADI";
      this.IsEmriDurum.Name = "IsEmriDurum";
      this.IsEmriDurum.NullText = "";
      this.IsEmriDurum.PopupView = (ColumnView) this.gridView8;
      this.IsEmriDurum.ValueMember = "ID";
      this.tBLISEMIRDURUMBindingSource.DataMember = "TBLISEMIRDURUM";
      this.tBLISEMIRDURUMBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView8.DetailHeight = 431;
      this.gridView8.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView8.Name = "gridView8";
      this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView8.OptionsView.ShowGroupPanel = false;
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 27;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 7;
      this.colKOD.Width = 100;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 27;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 100;
      this.tabNavigationPage2.Caption = "Çıkış Yapan Araçlar(Son 7 Gün)";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1487, 802);
      this.gridControl3.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.AltGrp,
        (RepositoryItem) this.AnaGrp,
        (RepositoryItem) this.ArizaNeden,
        (RepositoryItem) this.İsEmriDurum
      });
      this.gridControl3.Size = new Size(1487, 802);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.baskanlikIsEmriTvEkranCikisYapanBindingSource;
      this.baskanlikIsEmriTvEkranCikisYapanBindingSource.DataSource = (object) this.baskanlikIsEmriTvEkranCikisYapan;
      this.baskanlikIsEmriTvEkranCikisYapanBindingSource.Position = 0;
      this.baskanlikIsEmriTvEkranCikisYapan.DataSetName = "BaskanlikIsEmriTvEkranCikisYapan";
      this.baskanlikIsEmriTvEkranCikisYapan.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView3.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView3.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView3.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.BackColor = Color.White;
      this.gridView3.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView3.Appearance.Row.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.Options.UseFont = true;
      this.gridView3.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView3.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView3.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView3.Columns.AddRange(new GridColumn[10]
      {
        this.colCIKISTARIH,
        this.colPLAKA1,
        this.colAnaGrup1,
        this.colAltGrup1,
        this.colYAPILANBAKIM,
        this.colARIZANEDENIID,
        this.colISEMRIDURUMID1,
        this.colKOD1,
        this.colIsEmriId1,
        this.colAracID
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsPrint.AutoWidth = false;
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colCIKISTARIH, ColumnSortOrder.Ascending)
      });
      this.colCIKISTARIH.Caption = "Çıkış Tarihi";
      this.colCIKISTARIH.FieldName = "CIKISTARIH";
      this.colCIKISTARIH.MinWidth = 27;
      this.colCIKISTARIH.Name = "colCIKISTARIH";
      this.colCIKISTARIH.OptionsColumn.AllowEdit = false;
      this.colCIKISTARIH.OptionsColumn.ReadOnly = true;
      this.colCIKISTARIH.Visible = true;
      this.colCIKISTARIH.VisibleIndex = 0;
      this.colCIKISTARIH.Width = 148;
      this.colPLAKA1.FieldName = "PLAKA";
      this.colPLAKA1.MinWidth = 27;
      this.colPLAKA1.Name = "colPLAKA1";
      this.colPLAKA1.OptionsColumn.AllowEdit = false;
      this.colPLAKA1.OptionsColumn.ReadOnly = true;
      this.colPLAKA1.Visible = true;
      this.colPLAKA1.VisibleIndex = 1;
      this.colPLAKA1.Width = 100;
      this.colAnaGrup1.ColumnEdit = (RepositoryItem) this.AnaGrp;
      this.colAnaGrup1.FieldName = "Ana Grup";
      this.colAnaGrup1.MinWidth = 27;
      this.colAnaGrup1.Name = "colAnaGrup1";
      this.colAnaGrup1.OptionsColumn.AllowEdit = false;
      this.colAnaGrup1.OptionsColumn.ReadOnly = true;
      this.colAnaGrup1.Visible = true;
      this.colAnaGrup1.VisibleIndex = 2;
      this.colAnaGrup1.Width = 121;
      this.AnaGrp.AutoHeight = false;
      this.AnaGrp.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AnaGrp.DataSource = (object) this.tBLARACGRUBUBindingSource;
      this.AnaGrp.DisplayMember = "GRUPADI";
      this.AnaGrp.Name = "AnaGrp";
      this.AnaGrp.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit2View;
      this.AnaGrp.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit2View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
      this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.colAltGrup1.ColumnEdit = (RepositoryItem) this.AltGrp;
      this.colAltGrup1.FieldName = "Alt Grup";
      this.colAltGrup1.MinWidth = 27;
      this.colAltGrup1.Name = "colAltGrup1";
      this.colAltGrup1.OptionsColumn.AllowEdit = false;
      this.colAltGrup1.OptionsColumn.ReadOnly = true;
      this.colAltGrup1.Visible = true;
      this.colAltGrup1.VisibleIndex = 3;
      this.colAltGrup1.Width = 111;
      this.AltGrp.AutoHeight = false;
      this.AltGrp.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AltGrp.DataSource = (object) this.tBLARACGRUBU2BindingSource;
      this.AltGrp.DisplayMember = "GRUPADI";
      this.AltGrp.Name = "AltGrp";
      this.AltGrp.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.AltGrp.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colYAPILANBAKIM.Caption = "Yapılan Bakım";
      this.colYAPILANBAKIM.FieldName = "YAPILANBAKIM";
      this.colYAPILANBAKIM.MinWidth = 27;
      this.colYAPILANBAKIM.Name = "colYAPILANBAKIM";
      this.colYAPILANBAKIM.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIM.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIM.Visible = true;
      this.colYAPILANBAKIM.VisibleIndex = 4;
      this.colYAPILANBAKIM.Width = 181;
      this.colARIZANEDENIID.Caption = "Arıza Nedeni";
      this.colARIZANEDENIID.ColumnEdit = (RepositoryItem) this.ArizaNeden;
      this.colARIZANEDENIID.FieldName = "ARIZANEDENIID";
      this.colARIZANEDENIID.MinWidth = 27;
      this.colARIZANEDENIID.Name = "colARIZANEDENIID";
      this.colARIZANEDENIID.OptionsColumn.AllowEdit = false;
      this.colARIZANEDENIID.OptionsColumn.ReadOnly = true;
      this.colARIZANEDENIID.Visible = true;
      this.colARIZANEDENIID.VisibleIndex = 5;
      this.colARIZANEDENIID.Width = 192;
      this.ArizaNeden.AutoHeight = false;
      this.ArizaNeden.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ArizaNeden.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.ArizaNeden.DisplayMember = "ARIZANEDENI";
      this.ArizaNeden.Name = "ArizaNeden";
      this.ArizaNeden.PopupView = (ColumnView) this.gridView4;
      this.ArizaNeden.ValueMember = "ID";
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView4.DetailHeight = 431;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.colISEMRIDURUMID1.Caption = "İş Emri Durumu";
      this.colISEMRIDURUMID1.ColumnEdit = (RepositoryItem) this.İsEmriDurum;
      this.colISEMRIDURUMID1.FieldName = "ISEMRIDURUMID";
      this.colISEMRIDURUMID1.MinWidth = 27;
      this.colISEMRIDURUMID1.Name = "colISEMRIDURUMID1";
      this.colISEMRIDURUMID1.OptionsColumn.AllowEdit = false;
      this.colISEMRIDURUMID1.OptionsColumn.ReadOnly = true;
      this.colISEMRIDURUMID1.Visible = true;
      this.colISEMRIDURUMID1.VisibleIndex = 6;
      this.colISEMRIDURUMID1.Width = 196;
      this.İsEmriDurum.AutoHeight = false;
      this.İsEmriDurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.İsEmriDurum.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.İsEmriDurum.DisplayMember = "ADI";
      this.İsEmriDurum.Name = "İsEmriDurum";
      this.İsEmriDurum.PopupView = (ColumnView) this.gridView6;
      this.İsEmriDurum.ValueMember = "ID";
      this.gridView6.DetailHeight = 431;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.MinWidth = 27;
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.OptionsColumn.AllowEdit = false;
      this.colKOD1.OptionsColumn.ReadOnly = true;
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 7;
      this.colKOD1.Width = 100;
      this.colIsEmriId1.FieldName = "IsEmriId";
      this.colIsEmriId1.MinWidth = 27;
      this.colIsEmriId1.Name = "colIsEmriId1";
      this.colIsEmriId1.OptionsColumn.AllowEdit = false;
      this.colIsEmriId1.OptionsColumn.ReadOnly = true;
      this.colIsEmriId1.Width = 100;
      this.colAracID.FieldName = "AracID";
      this.colAracID.MinWidth = 27;
      this.colAracID.Name = "colAracID";
      this.colAracID.OptionsColumn.AllowEdit = false;
      this.colAracID.OptionsColumn.ReadOnly = true;
      this.colAracID.Width = 100;
      this.tabNavigationPage1.AccessibleDescription = "";
      this.tabNavigationPage1.Caption = "Bakımda Olan Araçlar";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1495, 808);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1495, 808);
      this.gridControl2.TabIndex = 4;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick_1);
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 2);
      this.simpleButton1.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(25, 25);
      this.simpleButton1.TabIndex = 3;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(12, 12);
      this.tabPane1.Margin = new Padding(3, 2, 3, 2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[2]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2
      });
      this.tabPane1.RegularSize = new Size(1487, 850);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1495, 854);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Giriş Fiş Hareketleri";
      this.layoutControl1.Controls.Add((Control) this.tabPane1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1519, 878);
      this.layoutControl1.TabIndex = 5;
      this.layoutControl1.Text = "layoutControl1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1519, 878);
      this.Root.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.tabPane1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1499, 858);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLARACGRUBUTableAdapter.ClearBeforeFill = true;
      this.tBLARACGRUBU2TableAdapter.ClearBeforeFill = true;
      this.tBLISEMIRDURUMTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.tAHARIZANEDENITableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1519, 996);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (IsEmriTvEkran);
      this.Text = "İş Emri TV Ekran";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.baskanlikIsEmriTvEkran.EndInit();
      this.gridView1.EndInit();
      this.AnaGrup.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.gridView5.EndInit();
      this.AltGrup.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).EndInit();
      this.gridView7.EndInit();
      this.IsEmriDurum.EndInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).EndInit();
      this.gridView8.EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      ((ISupportInitialize) this.baskanlikIsEmriTvEkranCikisYapanBindingSource).EndInit();
      this.baskanlikIsEmriTvEkranCikisYapan.EndInit();
      this.gridView3.EndInit();
      this.AnaGrp.EndInit();
      this.repositoryItemSearchLookUpEdit2View.EndInit();
      this.AltGrp.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.ArizaNeden.EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
      this.gridView4.EndInit();
      this.İsEmriDurum.EndInit();
      this.gridView6.EndInit();
      this.tabNavigationPage1.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView2.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
