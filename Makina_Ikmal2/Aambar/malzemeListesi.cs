// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.malzemeListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.MalzeemmeTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class malzemeListesi : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem YazdirButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem kapatButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarEditItem kayitBulTxt;
    private BarButtonItem yenileButton;
    private BarButtonItem excelButton;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup t;
    private RibbonPageGroup ribbonPageGroup2;
    private BarEditItem barEditItem2;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem4;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem3;
    private RepositoryItemComboBox repositoryItemComboBox1;
    private RibbonPageGroup ribbonPageGroup3;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private bellDataSet bellDataSet;
    private BindingSource tBLTALEPTEKNIKSARTBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLTALEPTEKNIKSARTTableAdapter tBLTALEPTEKNIKSARTTableAdapter;
    private BindingSource tBLMALZEMELERBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private GridControl gridControl1;
    private BindingSource tBLMALZEMELERBindingSource1;
    private GridView gridView1;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colUFKOD;
    private GridColumn colOEMKOD;
    private GridColumn colMALZEMEADI;
    private GridColumn colDIGERADI;
    private GridColumn colKULLANIMYERI;
    private GridColumn colBIRIMID;
    private GridColumn colGRUPID;
    private GridColumn colGRUPID2;
    private GridColumn colKDVID;
    private GridColumn colBOLUMID;
    private GridColumn colRAFNO;
    private GridColumn colGOZNO;
    private GridColumn colTARIHKONTROL;
    private GridColumn colSERINOKONTROL;
    private GridColumn colKMKONTROL;
    private GridColumn colMALZEMEFOTO;
    private GridColumn colKAYITTIPIID;
    private GridColumn colGIRIS;
    private GridColumn colCIKIS;
    private GridColumn colKALAN;
    private RepositoryItemLookUpEdit grup1;
    private LayoutControlItem layoutControlItem1;
    private BindingSource tBLMALZGRUPBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUPTableAdapter tBLMALZGRUPTableAdapter;
    private RepositoryItemLookUpEdit grup2;
    private BindingSource tBLMALZGRUP2BindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUP2TableAdapter tBLMALZGRUP2TableAdapter;
    private RepositoryItemLookUpEdit birimID;
    private BindingSource tBLMALZBIRIMBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BarSubItem barSubItem1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private Malzeemme malzeemme;
    private BindingSource tBLMALZEMELERBindingSource2;
    private Makina_Ikmal.Model.MalzeemmeTableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter1;
    private BindingSource tBLFILITREBindingSource;
    private TBLFILITRETableAdapter tBLFILITRETableAdapter;
    private BindingSource tBLYAGBindingSource;
    private TBLYAGTableAdapter tBLYAGTableAdapter;
    private RepositoryItemSearchLookUpEdit kdvid;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMALZKDVBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private RepositoryItemSearchLookUpEdit bolum;
    private GridView gridView2;
    private BindingSource tBLMALZBOLUMBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZBOLUMTableAdapter tBLMALZBOLUMTableAdapter;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public malzemeListesi() => this.InitializeComponent();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new malzemeEkle().ShowDialog();
    }

    private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void malzemeListesi_Load(object sender, EventArgs e)
    {
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet7.TBLMALZBOLUM);
      this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet7.TBLMALZKDV);
      this.tBLYAGTableAdapter.Fill(this.malzeemme.TBLYAG);
      this.tBLFILITRETableAdapter.Fill(this.malzeemme.TBLFILITRE);
      switch (YetkiClass.secim)
      {
        case "Ambar":
          this.gridControl1.DataSource = (object) null;
          this.tBLMALZEMELERTableAdapter1.Fill(this.malzeemme.TBLMALZEMELER);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLMALZEMELER;
          break;
        case "Filtre":
          this.tBLFILITRETableAdapter.Fill(this.malzeemme.TBLFILITRE);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLFILITRE;
          break;
        case "Yağ":
          this.tBLYAGTableAdapter.Fill(this.malzeemme.TBLYAG);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLYAG;
          break;
      }
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet.TBLMALZBIRIM);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet.TBLMALZGRUP2);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet.TBLMALZGRUP);
      this.tBLTALEPTEKNIKSARTTableAdapter.Fill(this.bellDataSet.TBLTALEPTEKNIKSART);
    }

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new malzemeGuncelle().ShowDialog();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new malzemeEkle().ShowDialog();
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new malzemeGuncelle().Show();
    }

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
    }

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    public void Listele()
    {
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet7.TBLMALZBOLUM);
      this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet7.TBLMALZKDV);
      this.tBLYAGTableAdapter.Fill(this.malzeemme.TBLYAG);
      this.tBLFILITRETableAdapter.Fill(this.malzeemme.TBLFILITRE);
      switch (YetkiClass.secim)
      {
        case "Ambar":
          this.gridControl1.DataSource = (object) null;
          this.tBLMALZEMELERTableAdapter1.Fill(this.malzeemme.TBLMALZEMELER);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLMALZEMELER;
          break;
        case "Filtre":
          this.tBLFILITRETableAdapter.Fill(this.malzeemme.TBLFILITRE);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLFILITRE;
          break;
        case "Yağ":
          this.tBLYAGTableAdapter.Fill(this.malzeemme.TBLYAG);
          this.gridControl1.DataSource = (object) this.malzeemme.TBLYAG;
          break;
      }
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet.TBLMALZBIRIM);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet.TBLMALZGRUP2);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet.TBLMALZGRUP);
      this.tBLTALEPTEKNIKSARTTableAdapter.Fill(this.bellDataSet.TBLTALEPTEKNIKSART);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (malzemeListesi));
      SuperToolTip superToolTip1 = new SuperToolTip();
      ToolTipItem toolTipItem1 = new ToolTipItem();
      SuperToolTip superToolTip2 = new SuperToolTip();
      ToolTipItem toolTipItem2 = new ToolTipItem();
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.kayitBulTxt = new BarEditItem();
      this.yenileButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemComboBox1 = new RepositoryItemComboBox();
      this.barSubItem1 = new BarSubItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colUFKOD = new GridColumn();
      this.colOEMKOD = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colDIGERADI = new GridColumn();
      this.colKULLANIMYERI = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.birimID = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.bellDataSet = new bellDataSet();
      this.colGRUPID = new GridColumn();
      this.grup1 = new RepositoryItemLookUpEdit();
      this.tBLMALZGRUPBindingSource = new BindingSource(this.components);
      this.colGRUPID2 = new GridColumn();
      this.grup2 = new RepositoryItemLookUpEdit();
      this.tBLMALZGRUP2BindingSource = new BindingSource(this.components);
      this.colKDVID = new GridColumn();
      this.kdvid = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colBOLUMID = new GridColumn();
      this.bolum = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZBOLUMBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.colRAFNO = new GridColumn();
      this.colGOZNO = new GridColumn();
      this.colTARIHKONTROL = new GridColumn();
      this.colSERINOKONTROL = new GridColumn();
      this.colKMKONTROL = new GridColumn();
      this.colMALZEMEFOTO = new GridColumn();
      this.colKAYITTIPIID = new GridColumn();
      this.colGIRIS = new GridColumn();
      this.colCIKIS = new GridColumn();
      this.colKALAN = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.t = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.barEditItem2 = new BarEditItem();
      this.layoutControl1 = new LayoutControl();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.tBLMALZEMELERBindingSource2 = new BindingSource(this.components);
      this.malzeemme = new Malzeemme();
      this.tBLMALZEMELERBindingSource1 = new BindingSource(this.components);
      this.tBLTALEPTEKNIKSARTBindingSource = new BindingSource(this.components);
      this.tBLTALEPTEKNIKSARTTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLTALEPTEKNIKSARTTableAdapter();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZEMELERTableAdapter();
      this.tBLMALZGRUPTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUPTableAdapter();
      this.tBLMALZGRUP2TableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUP2TableAdapter();
      this.tBLMALZBIRIMTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBIRIMTableAdapter();
      this.tBLMALZEMELERTableAdapter1 = new Makina_Ikmal.Model.MalzeemmeTableAdapters.TBLMALZEMELERTableAdapter();
      this.tBLFILITREBindingSource = new BindingSource(this.components);
      this.tBLFILITRETableAdapter = new TBLFILITRETableAdapter();
      this.tBLYAGBindingSource = new BindingSource(this.components);
      this.tBLYAGTableAdapter = new TBLYAGTableAdapter();
      this.tBLMALZKDVTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZKDVTableAdapter();
      this.tBLMALZBOLUMTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZBOLUMTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemComboBox1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.birimID.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.bellDataSet.BeginInit();
      this.grup1.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).BeginInit();
      this.grup2.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).BeginInit();
      this.kdvid.BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.bolum.BeginInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource2).BeginInit();
      this.malzeemme.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLFILITREBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLYAGBindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[23]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.YazdirButton,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.kapatButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.kayitBulTxt,
        (BarItem) this.yenileButton,
        (BarItem) this.excelButton,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem3,
        (BarItem) this.barSubItem1,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 27;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1406, 122);
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
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
      this.KayitBulButton.Caption = "Kayıt Bul";
      this.KayitBulButton.Id = 5;
      this.KayitBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.Image");
      this.KayitBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.LargeImage");
      this.KayitBulButton.LargeWidth = 100;
      this.KayitBulButton.Name = "KayitBulButton";
      this.KayitBulButton.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem6.Caption = "Kapat";
      this.barButtonItem6.Id = 6;
      this.barButtonItem6.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.Image");
      this.barButtonItem6.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.LargeImage");
      this.barButtonItem6.Name = "barButtonItem6";
      this.kapatButton.Caption = "Kapat";
      this.kapatButton.Id = 7;
      this.kapatButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.Image");
      this.kapatButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.LargeImage");
      this.kapatButton.LargeWidth = 100;
      this.kapatButton.Name = "kapatButton";
      this.kapatButton.RibbonStyle = RibbonItemStyles.Large;
      this.kapatButton.ItemClick += new ItemClickEventHandler(this.kapatButton_ItemClick);
      this.FisEkleButton.Caption = "Fiş Ekle";
      this.FisEkleButton.Id = 9;
      this.FisEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.Image");
      this.FisEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.LargeImage");
      this.FisEkleButton.Name = "FisEkleButton";
      this.FisEkleButton.RibbonStyle = RibbonItemStyles.Large;
      this.FisiCikarButton.Caption = "Fişi Çıkar";
      this.FisiCikarButton.Id = 10;
      this.FisiCikarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.Image");
      this.FisiCikarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.LargeImage");
      this.FisiCikarButton.Name = "FisiCikarButton";
      this.FisiCikarButton.RibbonStyle = RibbonItemStyles.Large;
      this.kayitBulTxt.Edit = (RepositoryItem) null;
      this.kayitBulTxt.EditHeight = 30;
      this.kayitBulTxt.EditWidth = 140;
      this.kayitBulTxt.Hint = "Kayit Bul";
      this.kayitBulTxt.Id = 11;
      this.kayitBulTxt.Name = "kayitBulTxt";
      this.kayitBulTxt.SearchTags = "";
      toolTipItem1.Text = "Kayit Bul...";
      superToolTip1.Items.Add((BaseToolTipItem) toolTipItem1);
      this.kayitBulTxt.SuperTip = superToolTip1;
      this.yenileButton.Caption = "Yenile";
      this.yenileButton.Id = 12;
      this.yenileButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.Image");
      this.yenileButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.LargeImage");
      this.yenileButton.LargeWidth = 100;
      this.yenileButton.Name = "yenileButton";
      this.yenileButton.RibbonStyle = RibbonItemStyles.Large;
      this.yenileButton.ItemClick += new ItemClickEventHandler(this.yenileButton_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 13;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.RibbonStyle = RibbonItemStyles.Large;
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
      this.barButtonItem2.Caption = "Yeni Kayıt";
      this.barButtonItem2.Id = 15;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem4.Caption = "barButtonItem4";
      this.barButtonItem4.Id = 17;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem3.Caption = "Düzenle";
      this.barButtonItem3.Id = 18;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem5.Caption = "Sil";
      this.barButtonItem5.Id = 19;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
      this.barButtonItem7.Caption = "Yazdır";
      this.barButtonItem7.Id = 20;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.Name = "barButtonItem7";
      this.barEditItem3.Caption = "Depo Seç";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemComboBox1;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 21;
      this.barEditItem3.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem3.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem3.ItemClick += new ItemClickEventHandler(this.barEditItem3_ItemClick);
      this.repositoryItemComboBox1.AutoHeight = false;
      this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
      this.barSubItem1.Caption = "barSubItem1";
      this.barSubItem1.Id = 22;
      this.barSubItem1.Name = "barSubItem1";
      this.barCheckItem1.Caption = "barCheckItem1";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 23;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "Ambar";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 24;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "barCheckItem3";
      this.barCheckItem3.Id = 25;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 26;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.gridControl1.Location = new Point(14, 14);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.grup1,
        (RepositoryItem) this.grup2,
        (RepositoryItem) this.birimID,
        (RepositoryItem) this.kdvid,
        (RepositoryItem) this.bolum
      });
      this.gridControl1.Size = new Size(1378, 752);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.gridView1.Columns.AddRange(new GridColumn[22]
      {
        this.colID,
        this.colKOD,
        this.colUFKOD,
        this.colOEMKOD,
        this.colMALZEMEADI,
        this.colDIGERADI,
        this.colKULLANIMYERI,
        this.colBIRIMID,
        this.colGRUPID,
        this.colGRUPID2,
        this.colKDVID,
        this.colBOLUMID,
        this.colRAFNO,
        this.colGOZNO,
        this.colTARIHKONTROL,
        this.colSERINOKONTROL,
        this.colKMKONTROL,
        this.colMALZEMEFOTO,
        this.colKAYITTIPIID,
        this.colGIRIS,
        this.colCIKIS,
        this.colKALAN
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 23;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 87;
      this.colKOD.Caption = "Malzeme Kodu";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 23;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 1;
      this.colKOD.Width = 87;
      this.colUFKOD.Caption = "Uf Kod";
      this.colUFKOD.FieldName = "UFKOD";
      this.colUFKOD.MinWidth = 23;
      this.colUFKOD.Name = "colUFKOD";
      this.colUFKOD.OptionsColumn.AllowEdit = false;
      this.colUFKOD.OptionsColumn.ReadOnly = true;
      this.colUFKOD.Visible = true;
      this.colUFKOD.VisibleIndex = 2;
      this.colUFKOD.Width = 87;
      this.colOEMKOD.Caption = "Oem Kod";
      this.colOEMKOD.FieldName = "OEMKOD";
      this.colOEMKOD.MinWidth = 23;
      this.colOEMKOD.Name = "colOEMKOD";
      this.colOEMKOD.OptionsColumn.AllowEdit = false;
      this.colOEMKOD.OptionsColumn.ReadOnly = true;
      this.colOEMKOD.Visible = true;
      this.colOEMKOD.VisibleIndex = 3;
      this.colOEMKOD.Width = 87;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 23;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 4;
      this.colMALZEMEADI.Width = 87;
      this.colDIGERADI.Caption = "Diğer Adı";
      this.colDIGERADI.FieldName = "DIGERADI";
      this.colDIGERADI.MinWidth = 23;
      this.colDIGERADI.Name = "colDIGERADI";
      this.colDIGERADI.OptionsColumn.AllowEdit = false;
      this.colDIGERADI.OptionsColumn.ReadOnly = true;
      this.colDIGERADI.Visible = true;
      this.colDIGERADI.VisibleIndex = 5;
      this.colDIGERADI.Width = 87;
      this.colKULLANIMYERI.Caption = "Kullanım Yeri";
      this.colKULLANIMYERI.FieldName = "KULLANIMYERI";
      this.colKULLANIMYERI.MinWidth = 23;
      this.colKULLANIMYERI.Name = "colKULLANIMYERI";
      this.colKULLANIMYERI.OptionsColumn.AllowEdit = false;
      this.colKULLANIMYERI.OptionsColumn.ReadOnly = true;
      this.colKULLANIMYERI.Visible = true;
      this.colKULLANIMYERI.VisibleIndex = 6;
      this.colKULLANIMYERI.Width = 87;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.birimID;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 23;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 7;
      this.colBIRIMID.Width = 87;
      this.birimID.AutoHeight = false;
      this.birimID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimID.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.birimID.DisplayMember = "BIRIMADI";
      this.birimID.Name = "birimID";
      this.birimID.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet;
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colGRUPID.Caption = "Grup 1";
      this.colGRUPID.ColumnEdit = (RepositoryItem) this.grup1;
      this.colGRUPID.FieldName = "GRUPID";
      this.colGRUPID.MinWidth = 23;
      this.colGRUPID.Name = "colGRUPID";
      this.colGRUPID.OptionsColumn.AllowEdit = false;
      this.colGRUPID.OptionsColumn.ReadOnly = true;
      this.colGRUPID.Visible = true;
      this.colGRUPID.VisibleIndex = 8;
      this.colGRUPID.Width = 87;
      this.grup1.AutoHeight = false;
      this.grup1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grup1.DataSource = (object) this.tBLMALZGRUPBindingSource;
      this.grup1.DisplayMember = "MALZEMEGRUP";
      this.grup1.Name = "grup1";
      this.grup1.ValueMember = "ID";
      this.tBLMALZGRUPBindingSource.DataMember = "TBLMALZGRUP";
      this.tBLMALZGRUPBindingSource.DataSource = (object) this.bellDataSet;
      this.colGRUPID2.Caption = "Grup 2";
      this.colGRUPID2.ColumnEdit = (RepositoryItem) this.grup2;
      this.colGRUPID2.FieldName = "GRUPID2";
      this.colGRUPID2.MinWidth = 23;
      this.colGRUPID2.Name = "colGRUPID2";
      this.colGRUPID2.OptionsColumn.AllowEdit = false;
      this.colGRUPID2.OptionsColumn.ReadOnly = true;
      this.colGRUPID2.Visible = true;
      this.colGRUPID2.VisibleIndex = 9;
      this.colGRUPID2.Width = 87;
      this.grup2.AutoHeight = false;
      this.grup2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grup2.DataSource = (object) this.tBLMALZGRUP2BindingSource;
      this.grup2.DisplayMember = "MALZEMEGRUP2";
      this.grup2.Name = "grup2";
      this.grup2.ValueMember = "ID";
      this.tBLMALZGRUP2BindingSource.DataMember = "TBLMALZGRUP2";
      this.tBLMALZGRUP2BindingSource.DataSource = (object) this.bellDataSet;
      this.colKDVID.Caption = "Kdv";
      this.colKDVID.ColumnEdit = (RepositoryItem) this.kdvid;
      this.colKDVID.FieldName = "KDVID";
      this.colKDVID.MinWidth = 23;
      this.colKDVID.Name = "colKDVID";
      this.colKDVID.OptionsColumn.AllowEdit = false;
      this.colKDVID.OptionsColumn.ReadOnly = true;
      this.colKDVID.Visible = true;
      this.colKDVID.VisibleIndex = 10;
      this.colKDVID.Width = 87;
      this.kdvid.AutoHeight = false;
      this.kdvid.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kdvid.DataSource = (object) this.tBLMALZKDVBindingSource;
      this.kdvid.DisplayMember = "KDVGRUP";
      this.kdvid.Name = "kdvid";
      this.kdvid.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.kdvid.ValueMember = "ID";
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colBOLUMID.Caption = "Bölüm";
      this.colBOLUMID.ColumnEdit = (RepositoryItem) this.bolum;
      this.colBOLUMID.FieldName = "BOLUMID";
      this.colBOLUMID.MinWidth = 23;
      this.colBOLUMID.Name = "colBOLUMID";
      this.colBOLUMID.OptionsColumn.AllowEdit = false;
      this.colBOLUMID.OptionsColumn.ReadOnly = true;
      this.colBOLUMID.Visible = true;
      this.colBOLUMID.VisibleIndex = 11;
      this.colBOLUMID.Width = 87;
      this.bolum.AutoHeight = false;
      this.bolum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bolum.DataSource = (object) this.tBLMALZBOLUMBindingSource;
      this.bolum.DisplayMember = "BOLUMADI";
      this.bolum.Name = "bolum";
      this.bolum.PopupView = (ColumnView) this.gridView2;
      this.bolum.ValueMember = "ID";
      this.tBLMALZBOLUMBindingSource.DataMember = "TBLMALZBOLUM";
      this.tBLMALZBOLUMBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colRAFNO.Caption = "Raf No";
      this.colRAFNO.FieldName = "RAFNO";
      this.colRAFNO.MinWidth = 23;
      this.colRAFNO.Name = "colRAFNO";
      this.colRAFNO.OptionsColumn.AllowEdit = false;
      this.colRAFNO.OptionsColumn.ReadOnly = true;
      this.colRAFNO.Visible = true;
      this.colRAFNO.VisibleIndex = 12;
      this.colRAFNO.Width = 87;
      this.colGOZNO.Caption = "Göz No";
      this.colGOZNO.FieldName = "GOZNO";
      this.colGOZNO.MinWidth = 23;
      this.colGOZNO.Name = "colGOZNO";
      this.colGOZNO.OptionsColumn.AllowEdit = false;
      this.colGOZNO.OptionsColumn.ReadOnly = true;
      this.colGOZNO.Visible = true;
      this.colGOZNO.VisibleIndex = 13;
      this.colGOZNO.Width = 87;
      this.colTARIHKONTROL.Caption = "Tarih Kontrol";
      this.colTARIHKONTROL.FieldName = "TARIHKONTROL";
      this.colTARIHKONTROL.MinWidth = 23;
      this.colTARIHKONTROL.Name = "colTARIHKONTROL";
      this.colTARIHKONTROL.OptionsColumn.AllowEdit = false;
      this.colTARIHKONTROL.OptionsColumn.ReadOnly = true;
      this.colTARIHKONTROL.Visible = true;
      this.colTARIHKONTROL.VisibleIndex = 14;
      this.colTARIHKONTROL.Width = 87;
      this.colSERINOKONTROL.Caption = "Seri No Kontrol";
      this.colSERINOKONTROL.FieldName = "SERINOKONTROL";
      this.colSERINOKONTROL.MinWidth = 23;
      this.colSERINOKONTROL.Name = "colSERINOKONTROL";
      this.colSERINOKONTROL.OptionsColumn.AllowEdit = false;
      this.colSERINOKONTROL.OptionsColumn.ReadOnly = true;
      this.colSERINOKONTROL.Visible = true;
      this.colSERINOKONTROL.VisibleIndex = 15;
      this.colSERINOKONTROL.Width = 87;
      this.colKMKONTROL.Caption = "Km Kontrol";
      this.colKMKONTROL.FieldName = "KMKONTROL";
      this.colKMKONTROL.MinWidth = 23;
      this.colKMKONTROL.Name = "colKMKONTROL";
      this.colKMKONTROL.OptionsColumn.AllowEdit = false;
      this.colKMKONTROL.OptionsColumn.ReadOnly = true;
      this.colKMKONTROL.Visible = true;
      this.colKMKONTROL.VisibleIndex = 16;
      this.colKMKONTROL.Width = 87;
      this.colMALZEMEFOTO.Caption = "Malzeme Foto";
      this.colMALZEMEFOTO.FieldName = "MALZEMEFOTO";
      this.colMALZEMEFOTO.MinWidth = 23;
      this.colMALZEMEFOTO.Name = "colMALZEMEFOTO";
      this.colMALZEMEFOTO.OptionsColumn.AllowEdit = false;
      this.colMALZEMEFOTO.OptionsColumn.ReadOnly = true;
      this.colMALZEMEFOTO.Visible = true;
      this.colMALZEMEFOTO.VisibleIndex = 17;
      this.colMALZEMEFOTO.Width = 87;
      this.colKAYITTIPIID.Caption = "Kayit Tipi";
      this.colKAYITTIPIID.FieldName = "KAYITTIPIID";
      this.colKAYITTIPIID.MinWidth = 23;
      this.colKAYITTIPIID.Name = "colKAYITTIPIID";
      this.colKAYITTIPIID.OptionsColumn.AllowEdit = false;
      this.colKAYITTIPIID.OptionsColumn.ReadOnly = true;
      this.colKAYITTIPIID.Visible = true;
      this.colKAYITTIPIID.VisibleIndex = 18;
      this.colKAYITTIPIID.Width = 87;
      this.colGIRIS.Caption = "Giriş";
      this.colGIRIS.FieldName = "GIRIS";
      this.colGIRIS.MinWidth = 23;
      this.colGIRIS.Name = "colGIRIS";
      this.colGIRIS.OptionsColumn.AllowEdit = false;
      this.colGIRIS.OptionsColumn.ReadOnly = true;
      this.colGIRIS.Visible = true;
      this.colGIRIS.VisibleIndex = 19;
      this.colGIRIS.Width = 87;
      this.colCIKIS.Caption = "Çıkış";
      this.colCIKIS.FieldName = "CIKIS";
      this.colCIKIS.MinWidth = 23;
      this.colCIKIS.Name = "colCIKIS";
      this.colCIKIS.OptionsColumn.AllowEdit = false;
      this.colCIKIS.OptionsColumn.ReadOnly = true;
      this.colCIKIS.Visible = true;
      this.colCIKIS.VisibleIndex = 20;
      this.colCIKIS.Width = 87;
      this.colKALAN.Caption = "Kalan";
      this.colKALAN.FieldName = "KALAN";
      this.colKALAN.MinWidth = 23;
      this.colKALAN.Name = "colKALAN";
      this.colKALAN.OptionsColumn.AllowEdit = false;
      this.colKALAN.OptionsColumn.ReadOnly = true;
      this.colKALAN.Visible = true;
      this.colKALAN.VisibleIndex = 21;
      this.colKALAN.Width = 87;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup4,
        this.t,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.t.ItemLinks.Add((BarItem) this.kayitBulTxt, true);
      this.t.ItemLinks.Add((BarItem) this.barEditItem1);
      this.t.Name = "t";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.repositoryItemTextEdit1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTextEdit1.NullText = "Kayıt Bul...";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemTextEdit1;
      this.barEditItem2.EditHeight = 30;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Hint = "Kayit Bul";
      this.barEditItem2.Id = 11;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem2.SearchTags = "";
      toolTipItem2.Text = "Kayit Bul...";
      superToolTip2.Items.Add((BaseToolTipItem) toolTipItem2);
      this.barEditItem2.SuperTip = superToolTip2;
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1406, 780);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1406, 780);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1382, 756);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.tBLMALZEMELERBindingSource2.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource2.DataSource = (object) this.malzeemme;
      this.malzeemme.DataSetName = "Malzeemme";
      this.malzeemme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLMALZEMELERBindingSource1.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource1.DataSource = (object) this.bellDataSet;
      this.tBLTALEPTEKNIKSARTBindingSource.DataMember = "TBLTALEPTEKNIKSART";
      this.tBLTALEPTEKNIKSARTBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLTALEPTEKNIKSARTTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUPTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUP2TableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter1.ClearBeforeFill = true;
      this.tBLFILITREBindingSource.DataMember = "TBLFILITRE";
      this.tBLFILITREBindingSource.DataSource = (object) this.malzeemme;
      this.tBLFILITRETableAdapter.ClearBeforeFill = true;
      this.tBLYAGBindingSource.DataMember = "TBLYAG";
      this.tBLYAGBindingSource.DataSource = (object) this.malzeemme;
      this.tBLYAGTableAdapter.ClearBeforeFill = true;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBOLUMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1406, 902);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (malzemeListesi);
      this.Text = nameof (malzemeListesi);
      this.Load += new EventHandler(this.malzemeListesi_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemComboBox1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.birimID.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.bellDataSet.EndInit();
      this.grup1.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).EndInit();
      this.grup2.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).EndInit();
      this.kdvid.EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.bolum.EndInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).EndInit();
      this.gridView2.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource2).EndInit();
      this.malzeemme.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      ((ISupportInitialize) this.tBLFILITREBindingSource).EndInit();
      ((ISupportInitialize) this.tBLYAGBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
