// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.malzemeEkstresi
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
using DevExpress.XtraLayout.Utils;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.MalzemeEksteresiTableAdapters;
using Makina_Ikmal.Model.MalzemeEkstresiKemalTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class malzemeEkstresi : XtraForm
  {
    private int malzemeID = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem YazdirButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem kapatButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private RibbonPageGroup ribbonPageGroup2;
    private BarEditItem kayitBulTxt;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private BarButtonItem yenileButton;
    private BarButtonItem excelButton;
    private bellDataSet bellDataSet;
    private BindingSource tBLMALZEMELERBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLMALZGRUPBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUPTableAdapter tBLMALZGRUPTableAdapter;
    private BindingSource tBLMALZMARKABindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZMARKATableAdapter tBLMALZMARKATableAdapter;
    private BindingSource tBLMALZDEPOBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZDEPOTableAdapter tBLMALZDEPOTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource1;
    private BindingSource tBLMALZEMELERBindingSource1;
    private BindingSource tBLKULLANICILARBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLKULLANICILARTableAdapter tBLKULLANICILARTableAdapter;
    private BindingSource tBLMALZGRUP2BindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUP2TableAdapter tBLMALZGRUP2TableAdapter;
    private BindingSource tBLMALZBOLUMBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBOLUMTableAdapter tBLMALZBOLUMTableAdapter;
    private BindingSource tBLMALZEMELERBindingSource2;
    private BindingSource tBLMALZBOLUMBindingSource1;
    private BindingSource tBLMALZDEPOBindingSource1;
    private SplitContainer splitContainer1;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem1;
    private SplitterItem splitterItem1;
    private SimpleSeparator simpleSeparator1;
    private Malzeemme malzeemme;
    private BindingSource tBLMALZEMELERBindingSource3;
    private Makina_Ikmal.Model.MalzeemmeTableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter1;
    private GridColumn colKAYITTIPIID;
    private GridColumn colMALZEMEADI1;
    private GridColumn colKULLANIMYERI;
    private GridColumn colBIRIMID;
    private GridColumn colGIRIS;
    private GridColumn colCIKIS;
    private GridColumn colKALAN;
    private GridColumn colGRUPID;
    private GridColumn colGRUPID2;
    private GridColumn colBOLUMID;
    private GridColumn colRAFNO;
    private GridColumn colGOZNO;
    private GridColumn colSERINOKONTROL;
    private GridColumn colTARIHKONTROL;
    private GridColumn colKMKONTROL;
    private BindingSource malzemeEkstresiGetirBindingSource;
    private MalzemeEksteresi malzemeEksteresi;
    private MalzemeEkstresiGetirTableAdapter malzemeEkstresiGetirTableAdapter;
    private GridColumn colID;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPageGroup Arama;
    private BindingSource malzemeEkstresiGetirBindingSource1;
    private BindingSource malzemeEkstresiKemalBindingSource;
    private MalzemeEkstresiKemal malzemeEkstresiKemal;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private BindingSource malzemeEkstresiGetirBindingSource3;
    private GridColumn colISLEMTIPI;
    private GridColumn colPLAKA;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private GridColumn colGIRISMIKTAR;
    private GridColumn colCIKISMIKTAR;
    private GridColumn colDEGISIMKMSI;
    private GridColumn colDEPOADI;
    private GridColumn colID1;
    private GridColumn colMalzemeID;
    private GridColumn colMALZURTTARIH;
    private GridColumn colKOD;
    private BindingSource malzemeEksteresiBindingSource;
    private BindingSource malzemeEkstresiGetirBindingSource2;
    private RepositoryItemSearchLookUpEdit MBirim;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit MGrup1;
    private GridView gridView3;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMALZGRUPBindingSource1;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZGRUPTableAdapter tBLMALZGRUPTableAdapter1;
    private RepositoryItemSearchLookUpEdit MGrup2;
    private GridView gridView4;
    private RepositoryItemSearchLookUpEdit MBolum;
    private GridView gridView5;

    public malzemeEkstresi() => this.InitializeComponent();

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.tBLMALZGRUPTableAdapter1.Fill(this.bellDataSet7.TBLMALZGRUP);
      this.dataTable1TableAdapter.Fill(this.malzemeEkstresiKemal.DataTable1);
      this.tBLMALZEMELERTableAdapter1.Fill(this.malzeemme.TBLMALZEMELER);
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet.TBLMALZBOLUM);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet.TBLMALZGRUP2);
      this.tBLKULLANICILARTableAdapter.Fill(this.bellDataSet.TBLKULLANICILAR);
      this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet.TBLMALZDEPO);
      this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet.TBLMALZMARKA);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet.TBLMALZGRUP);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet.TBLMALZEMELER);
    }

    private void malzemeListesi_Load(object sender, EventArgs e)
    {
      this.tBLMALZGRUPTableAdapter1.Fill(this.bellDataSet7.TBLMALZGRUP);
      this.dataTable1TableAdapter.Fill(this.malzemeEkstresiKemal.DataTable1);
      this.tBLMALZEMELERTableAdapter1.Fill(this.malzeemme.TBLMALZEMELER);
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet.TBLMALZBOLUM);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet.TBLMALZGRUP2);
      this.tBLKULLANICILARTableAdapter.Fill(this.bellDataSet.TBLKULLANICILAR);
      this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet.TBLMALZDEPO);
      this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet.TBLMALZMARKA);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet.TBLMALZGRUP);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet.TBLMALZEMELER);
    }

    private void gridControl2_Click(object sender, EventArgs e)
    {
    }

    private void gridView2_Click(object sender, EventArgs e)
    {
      this.malzemeID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      this.malzemeEkstresiGetirTableAdapter.Fill(this.malzemeEksteresi.MalzemeEkstresiGetir, this.malzemeID);
    }

    private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      this.malzemeID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      this.malzemeEkstresiGetirTableAdapter.Fill(this.malzemeEksteresi.MalzemeEkstresiGetir, this.malzemeID);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (malzemeEkstresi));
      SuperToolTip superToolTip = new SuperToolTip();
      ToolTipItem toolTipItem = new ToolTipItem();
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.kayitBulTxt = new BarEditItem();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.yenileButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl2 = new GridControl();
      this.tBLMALZEMELERBindingSource3 = new BindingSource(this.components);
      this.malzeemme = new Malzeemme();
      this.gridView2 = new GridView();
      this.colKAYITTIPIID = new GridColumn();
      this.colMALZEMEADI1 = new GridColumn();
      this.colKULLANIMYERI = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.MBirim = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.bellDataSet = new bellDataSet();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colGIRIS = new GridColumn();
      this.colCIKIS = new GridColumn();
      this.colKALAN = new GridColumn();
      this.colGRUPID = new GridColumn();
      this.MGrup1 = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZGRUPBindingSource1 = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView3 = new GridView();
      this.colGRUPID2 = new GridColumn();
      this.MGrup2 = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZGRUP2BindingSource = new BindingSource(this.components);
      this.gridView4 = new GridView();
      this.colBOLUMID = new GridColumn();
      this.MBolum = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZBOLUMBindingSource1 = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.colRAFNO = new GridColumn();
      this.colGOZNO = new GridColumn();
      this.colSERINOKONTROL = new GridColumn();
      this.colTARIHKONTROL = new GridColumn();
      this.colKMKONTROL = new GridColumn();
      this.colID = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.Arama = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.splitContainer1 = new SplitContainer();
      this.gridControl1 = new GridControl();
      this.malzemeEkstresiGetirBindingSource3 = new BindingSource(this.components);
      this.malzemeEksteresi = new MalzemeEksteresi();
      this.gridView1 = new GridView();
      this.colISLEMTIPI = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colGIRISMIKTAR = new GridColumn();
      this.colCIKISMIKTAR = new GridColumn();
      this.colDEGISIMKMSI = new GridColumn();
      this.colDEPOADI = new GridColumn();
      this.colID1 = new GridColumn();
      this.colMalzemeID = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colKOD = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.splitterItem1 = new SplitterItem();
      this.simpleSeparator1 = new SimpleSeparator();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.malzemeEkstresiKemalBindingSource = new BindingSource(this.components);
      this.malzemeEkstresiKemal = new MalzemeEkstresiKemal();
      this.malzemeEkstresiGetirBindingSource1 = new BindingSource(this.components);
      this.malzemeEkstresiGetirBindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERBindingSource2 = new BindingSource(this.components);
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBIRIMTableAdapter();
      this.tBLMALZGRUPBindingSource = new BindingSource(this.components);
      this.tBLMALZGRUPTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUPTableAdapter();
      this.tBLMALZMARKABindingSource = new BindingSource(this.components);
      this.tBLMALZMARKATableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZMARKATableAdapter();
      this.tBLMALZDEPOBindingSource = new BindingSource(this.components);
      this.tBLMALZDEPOTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZDEPOTableAdapter();
      this.tBLMALZBIRIMBindingSource1 = new BindingSource(this.components);
      this.tBLMALZEMELERBindingSource1 = new BindingSource(this.components);
      this.tBLKULLANICILARBindingSource = new BindingSource(this.components);
      this.tBLKULLANICILARTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLKULLANICILARTableAdapter();
      this.tBLMALZGRUP2TableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZGRUP2TableAdapter();
      this.tBLMALZBOLUMBindingSource = new BindingSource(this.components);
      this.tBLMALZBOLUMTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLMALZBOLUMTableAdapter();
      this.tBLMALZDEPOBindingSource1 = new BindingSource(this.components);
      this.tBLMALZEMELERTableAdapter1 = new Makina_Ikmal.Model.MalzeemmeTableAdapters.TBLMALZEMELERTableAdapter();
      this.malzemeEkstresiGetirTableAdapter = new MalzemeEkstresiGetirTableAdapter();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.malzemeEksteresiBindingSource = new BindingSource(this.components);
      this.malzemeEkstresiGetirBindingSource2 = new BindingSource(this.components);
      this.tBLMALZGRUPTableAdapter1 = new Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZGRUPTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource3).BeginInit();
      this.malzeemme.BeginInit();
      this.gridView2.BeginInit();
      this.MBirim.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.bellDataSet.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.MGrup1.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource1).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView3.BeginInit();
      this.MGrup2.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).BeginInit();
      this.gridView4.BeginInit();
      this.MBolum.BeginInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource1).BeginInit();
      this.gridView5.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource3).BeginInit();
      this.malzemeEksteresi.BeginInit();
      this.gridView1.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.splitterItem1.BeginInit();
      this.simpleSeparator1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.malzemeEkstresiKemalBindingSource).BeginInit();
      this.malzemeEkstresiKemal.BeginInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource1).BeginInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource2).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLKULLANICILARBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource1).BeginInit();
      ((ISupportInitialize) this.malzemeEksteresiBindingSource).BeginInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource2).BeginInit();
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
        (BarItem) this.YazdirButton,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.kapatButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.kayitBulTxt,
        (BarItem) this.yenileButton,
        (BarItem) this.excelButton,
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 15;
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
      this.ribbonControl1.Size = new Size(1385, 118);
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
      this.kayitBulTxt.Edit = (RepositoryItem) this.repositoryItemTextEdit1;
      this.kayitBulTxt.EditHeight = 30;
      this.kayitBulTxt.EditWidth = 140;
      this.kayitBulTxt.Hint = "Kayit Bul";
      this.kayitBulTxt.Id = 11;
      this.kayitBulTxt.Name = "kayitBulTxt";
      this.kayitBulTxt.SearchTags = "";
      toolTipItem.Text = "Kayit Bul...";
      superToolTip.Items.Add((BaseToolTipItem) toolTipItem);
      this.kayitBulTxt.SuperTip = superToolTip;
      this.repositoryItemTextEdit1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTextEdit1.NullText = "Kayit Bul...";
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
      this.excelButton.PaintStyle = BarItemPaintStyle.Caption;
      this.excelButton.RibbonStyle = RibbonItemStyles.Large;
      this.excelButton.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 35;
      this.barEditItem1.EditWidth = 130;
      this.barEditItem1.Hint = "Malzeme Eksteri";
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl2.DataSource = (object) this.tBLMALZEMELERBindingSource3;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.MBirim,
        (RepositoryItem) this.MGrup1,
        (RepositoryItem) this.MGrup2,
        (RepositoryItem) this.MBolum
      });
      this.gridControl2.Size = new Size(1361, 408);
      this.gridControl2.TabIndex = 6;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.Click += new EventHandler(this.gridControl2_Click);
      this.tBLMALZEMELERBindingSource3.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource3.DataSource = (object) this.malzeemme;
      this.malzeemme.DataSetName = "Malzeemme";
      this.malzeemme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[16]
      {
        this.colKAYITTIPIID,
        this.colMALZEMEADI1,
        this.colKULLANIMYERI,
        this.colBIRIMID,
        this.colGIRIS,
        this.colCIKIS,
        this.colKALAN,
        this.colGRUPID,
        this.colGRUPID2,
        this.colBOLUMID,
        this.colRAFNO,
        this.colGOZNO,
        this.colSERINOKONTROL,
        this.colTARIHKONTROL,
        this.colKMKONTROL,
        this.colID
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridView2.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
      this.gridView2.Click += new EventHandler(this.gridView2_Click);
      this.colKAYITTIPIID.FieldName = "KAYITTIPIID";
      this.colKAYITTIPIID.MinWidth = 25;
      this.colKAYITTIPIID.Name = "colKAYITTIPIID";
      this.colKAYITTIPIID.OptionsColumn.AllowEdit = false;
      this.colKAYITTIPIID.OptionsColumn.ReadOnly = true;
      this.colKAYITTIPIID.Width = 94;
      this.colMALZEMEADI1.Caption = "Malzeme Adı";
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.MinWidth = 25;
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 0;
      this.colMALZEMEADI1.Width = 94;
      this.colKULLANIMYERI.Caption = "Kullanım Yeri";
      this.colKULLANIMYERI.FieldName = "KULLANIMYERI";
      this.colKULLANIMYERI.MinWidth = 25;
      this.colKULLANIMYERI.Name = "colKULLANIMYERI";
      this.colKULLANIMYERI.OptionsColumn.AllowEdit = false;
      this.colKULLANIMYERI.OptionsColumn.ReadOnly = true;
      this.colKULLANIMYERI.Visible = true;
      this.colKULLANIMYERI.VisibleIndex = 1;
      this.colKULLANIMYERI.Width = 94;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.MBirim;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 25;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 2;
      this.colBIRIMID.Width = 94;
      this.MBirim.AutoHeight = false;
      this.MBirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MBirim.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.MBirim.DisplayMember = "BIRIMADI";
      this.MBirim.Name = "MBirim";
      this.MBirim.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.MBirim.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet;
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colGIRIS.Caption = "Giriş";
      this.colGIRIS.FieldName = "GIRIS";
      this.colGIRIS.MinWidth = 25;
      this.colGIRIS.Name = "colGIRIS";
      this.colGIRIS.OptionsColumn.AllowEdit = false;
      this.colGIRIS.OptionsColumn.ReadOnly = true;
      this.colGIRIS.Visible = true;
      this.colGIRIS.VisibleIndex = 3;
      this.colGIRIS.Width = 94;
      this.colCIKIS.Caption = "Çıkış";
      this.colCIKIS.FieldName = "CIKIS";
      this.colCIKIS.MinWidth = 25;
      this.colCIKIS.Name = "colCIKIS";
      this.colCIKIS.OptionsColumn.AllowEdit = false;
      this.colCIKIS.OptionsColumn.ReadOnly = true;
      this.colCIKIS.Visible = true;
      this.colCIKIS.VisibleIndex = 4;
      this.colCIKIS.Width = 94;
      this.colKALAN.Caption = "Kalan";
      this.colKALAN.FieldName = "KALAN";
      this.colKALAN.MinWidth = 25;
      this.colKALAN.Name = "colKALAN";
      this.colKALAN.OptionsColumn.AllowEdit = false;
      this.colKALAN.OptionsColumn.ReadOnly = true;
      this.colKALAN.Visible = true;
      this.colKALAN.VisibleIndex = 5;
      this.colKALAN.Width = 94;
      this.colGRUPID.Caption = "Grup 1";
      this.colGRUPID.ColumnEdit = (RepositoryItem) this.MGrup1;
      this.colGRUPID.FieldName = "GRUPID";
      this.colGRUPID.MinWidth = 25;
      this.colGRUPID.Name = "colGRUPID";
      this.colGRUPID.OptionsColumn.AllowEdit = false;
      this.colGRUPID.OptionsColumn.ReadOnly = true;
      this.colGRUPID.Visible = true;
      this.colGRUPID.VisibleIndex = 6;
      this.colGRUPID.Width = 94;
      this.MGrup1.AutoHeight = false;
      this.MGrup1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MGrup1.DataSource = (object) this.tBLMALZGRUPBindingSource1;
      this.MGrup1.DisplayMember = "MALZEMEGRUP";
      this.MGrup1.Name = "MGrup1";
      this.MGrup1.PopupView = (ColumnView) this.gridView3;
      this.MGrup1.ValueMember = "ID";
      this.tBLMALZGRUPBindingSource1.DataMember = "TBLMALZGRUP";
      this.tBLMALZGRUPBindingSource1.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.colGRUPID2.Caption = "Grup 2";
      this.colGRUPID2.ColumnEdit = (RepositoryItem) this.MGrup2;
      this.colGRUPID2.FieldName = "GRUPID2";
      this.colGRUPID2.MinWidth = 25;
      this.colGRUPID2.Name = "colGRUPID2";
      this.colGRUPID2.OptionsColumn.AllowEdit = false;
      this.colGRUPID2.OptionsColumn.ReadOnly = true;
      this.colGRUPID2.Visible = true;
      this.colGRUPID2.VisibleIndex = 7;
      this.colGRUPID2.Width = 94;
      this.MGrup2.AutoHeight = false;
      this.MGrup2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MGrup2.DataSource = (object) this.tBLMALZGRUP2BindingSource;
      this.MGrup2.DisplayMember = "MALZEMEGRUP2";
      this.MGrup2.Name = "MGrup2";
      this.MGrup2.PopupView = (ColumnView) this.gridView4;
      this.MGrup2.ValueMember = "ID";
      this.tBLMALZGRUP2BindingSource.DataMember = "TBLMALZGRUP2";
      this.tBLMALZGRUP2BindingSource.DataSource = (object) this.bellDataSet;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.colBOLUMID.Caption = "Bölüm";
      this.colBOLUMID.ColumnEdit = (RepositoryItem) this.MBolum;
      this.colBOLUMID.FieldName = "BOLUMID";
      this.colBOLUMID.MinWidth = 25;
      this.colBOLUMID.Name = "colBOLUMID";
      this.colBOLUMID.OptionsColumn.AllowEdit = false;
      this.colBOLUMID.OptionsColumn.ReadOnly = true;
      this.colBOLUMID.Visible = true;
      this.colBOLUMID.VisibleIndex = 8;
      this.colBOLUMID.Width = 94;
      this.MBolum.AutoHeight = false;
      this.MBolum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MBolum.DataSource = (object) this.tBLMALZBOLUMBindingSource1;
      this.MBolum.DisplayMember = "BOLUMADI";
      this.MBolum.Name = "MBolum";
      this.MBolum.PopupView = (ColumnView) this.gridView5;
      this.MBolum.ValueMember = "ID";
      this.tBLMALZBOLUMBindingSource1.DataMember = "TBLMALZBOLUM";
      this.tBLMALZBOLUMBindingSource1.DataSource = (object) this.bellDataSet;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colRAFNO.Caption = "Raf";
      this.colRAFNO.FieldName = "RAFNO";
      this.colRAFNO.MinWidth = 25;
      this.colRAFNO.Name = "colRAFNO";
      this.colRAFNO.OptionsColumn.AllowEdit = false;
      this.colRAFNO.OptionsColumn.ReadOnly = true;
      this.colRAFNO.Visible = true;
      this.colRAFNO.VisibleIndex = 9;
      this.colRAFNO.Width = 94;
      this.colGOZNO.Caption = "Göz";
      this.colGOZNO.FieldName = "GOZNO";
      this.colGOZNO.MinWidth = 25;
      this.colGOZNO.Name = "colGOZNO";
      this.colGOZNO.OptionsColumn.AllowEdit = false;
      this.colGOZNO.OptionsColumn.ReadOnly = true;
      this.colGOZNO.Visible = true;
      this.colGOZNO.VisibleIndex = 10;
      this.colGOZNO.Width = 94;
      this.colSERINOKONTROL.Caption = "Seri No Kontrol";
      this.colSERINOKONTROL.FieldName = "SERINOKONTROL";
      this.colSERINOKONTROL.MinWidth = 25;
      this.colSERINOKONTROL.Name = "colSERINOKONTROL";
      this.colSERINOKONTROL.OptionsColumn.AllowEdit = false;
      this.colSERINOKONTROL.OptionsColumn.ReadOnly = true;
      this.colSERINOKONTROL.Visible = true;
      this.colSERINOKONTROL.VisibleIndex = 11;
      this.colSERINOKONTROL.Width = 94;
      this.colTARIHKONTROL.Caption = "Tarih Kontrol";
      this.colTARIHKONTROL.FieldName = "TARIHKONTROL";
      this.colTARIHKONTROL.MinWidth = 25;
      this.colTARIHKONTROL.Name = "colTARIHKONTROL";
      this.colTARIHKONTROL.OptionsColumn.AllowEdit = false;
      this.colTARIHKONTROL.OptionsColumn.ReadOnly = true;
      this.colTARIHKONTROL.Visible = true;
      this.colTARIHKONTROL.VisibleIndex = 12;
      this.colTARIHKONTROL.Width = 94;
      this.colKMKONTROL.Caption = "KM Kontrol";
      this.colKMKONTROL.FieldName = "KMKONTROL";
      this.colKMKONTROL.MinWidth = 25;
      this.colKMKONTROL.Name = "colKMKONTROL";
      this.colKMKONTROL.OptionsColumn.AllowEdit = false;
      this.colKMKONTROL.OptionsColumn.ReadOnly = true;
      this.colKMKONTROL.Visible = true;
      this.colKMKONTROL.VisibleIndex = 13;
      this.colKMKONTROL.Width = 94;
      this.colID.Caption = "gridColumn1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 94;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup4,
        this.Arama,
        this.ribbonPageGroup2
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.Arama.ItemLinks.Add((BarItem) this.barEditItem1);
      this.Arama.Name = "Arama";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.layoutControl1.Controls.Add((Control) this.splitContainer1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(598, 211, 812, 500));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1385, 646);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.splitContainer1.Location = new Point(12, 12);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.gridControl2);
      this.splitContainer1.Panel2.Controls.Add((Control) this.gridControl1);
      this.splitContainer1.Size = new Size(1361, 609);
      this.splitContainer1.SplitterDistance = 408;
      this.splitContainer1.TabIndex = 3;
      this.gridControl1.DataSource = (object) this.malzemeEkstresiGetirBindingSource3;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1361, 197);
      this.gridControl1.TabIndex = 7;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.malzemeEkstresiGetirBindingSource3.DataMember = "MalzemeEkstresiGetir";
      this.malzemeEkstresiGetirBindingSource3.DataSource = (object) this.malzemeEksteresi;
      this.malzemeEksteresi.DataSetName = "MalzemeEksteresi";
      this.malzemeEksteresi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[12]
      {
        this.colISLEMTIPI,
        this.colPLAKA,
        this.colMALZEMEADI,
        this.colBIRIMADI,
        this.colGIRISMIKTAR,
        this.colCIKISMIKTAR,
        this.colDEGISIMKMSI,
        this.colDEPOADI,
        this.colID1,
        this.colMalzemeID,
        this.colMALZURTTARIH,
        this.colKOD
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ShowFooter = true;
      this.colISLEMTIPI.Caption = "İşlem Tipi";
      this.colISLEMTIPI.FieldName = "ISLEMTIPI";
      this.colISLEMTIPI.MinWidth = 25;
      this.colISLEMTIPI.Name = "colISLEMTIPI";
      this.colISLEMTIPI.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPI.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPI.Visible = true;
      this.colISLEMTIPI.VisibleIndex = 0;
      this.colISLEMTIPI.Width = 94;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 94;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 25;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 2;
      this.colMALZEMEADI.Width = 94;
      this.colBIRIMADI.Caption = "Birim Adı";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 25;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 3;
      this.colBIRIMADI.Width = 94;
      this.colGIRISMIKTAR.Caption = "Giriş Miktar";
      this.colGIRISMIKTAR.FieldName = "GIRISMIKTAR";
      this.colGIRISMIKTAR.MinWidth = 25;
      this.colGIRISMIKTAR.Name = "colGIRISMIKTAR";
      this.colGIRISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISMIKTAR.Visible = true;
      this.colGIRISMIKTAR.VisibleIndex = 4;
      this.colGIRISMIKTAR.Width = 94;
      this.colCIKISMIKTAR.Caption = "Çıkış Miktar";
      this.colCIKISMIKTAR.FieldName = "CIKISMIKTAR";
      this.colCIKISMIKTAR.MinWidth = 25;
      this.colCIKISMIKTAR.Name = "colCIKISMIKTAR";
      this.colCIKISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISMIKTAR.Visible = true;
      this.colCIKISMIKTAR.VisibleIndex = 5;
      this.colCIKISMIKTAR.Width = 94;
      this.colDEGISIMKMSI.Caption = "Değişim KM'si";
      this.colDEGISIMKMSI.FieldName = "DEGISIMKMSI";
      this.colDEGISIMKMSI.MinWidth = 25;
      this.colDEGISIMKMSI.Name = "colDEGISIMKMSI";
      this.colDEGISIMKMSI.OptionsColumn.AllowEdit = false;
      this.colDEGISIMKMSI.OptionsColumn.ReadOnly = true;
      this.colDEGISIMKMSI.Visible = true;
      this.colDEGISIMKMSI.VisibleIndex = 6;
      this.colDEGISIMKMSI.Width = 94;
      this.colDEPOADI.Caption = "Depo Adı";
      this.colDEPOADI.FieldName = "DEPOADI";
      this.colDEPOADI.MinWidth = 25;
      this.colDEPOADI.Name = "colDEPOADI";
      this.colDEPOADI.OptionsColumn.AllowEdit = false;
      this.colDEPOADI.OptionsColumn.ReadOnly = true;
      this.colDEPOADI.Visible = true;
      this.colDEPOADI.VisibleIndex = 7;
      this.colDEPOADI.Width = 94;
      this.colID1.FieldName = "ID";
      this.colID1.MinWidth = 25;
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Width = 94;
      this.colMalzemeID.FieldName = "Malzeme ID";
      this.colMalzemeID.MinWidth = 25;
      this.colMalzemeID.Name = "colMalzemeID";
      this.colMalzemeID.OptionsColumn.AllowEdit = false;
      this.colMalzemeID.OptionsColumn.ReadOnly = true;
      this.colMalzemeID.Width = 94;
      this.colMALZURTTARIH.Caption = "Üretim Tarihi";
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 25;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.OptionsColumn.AllowEdit = false;
      this.colMALZURTTARIH.OptionsColumn.ReadOnly = true;
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 8;
      this.colMALZURTTARIH.Width = 94;
      this.colKOD.Caption = "İş Emri Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 25;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 9;
      this.colKOD.Width = 94;
      this.Root.DefaultLayoutType = LayoutType.Horizontal;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[3]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.splitterItem1,
        (BaseLayoutItem) this.simpleSeparator1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1385, 646);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.splitContainer1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1365, 613);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.splitterItem1.AllowHotTrack = true;
      this.splitterItem1.Location = new Point(0, 614);
      this.splitterItem1.Name = "splitterItem1";
      this.splitterItem1.Size = new Size(1365, 12);
      this.simpleSeparator1.AllowHotTrack = false;
      this.simpleSeparator1.Location = new Point(0, 613);
      this.simpleSeparator1.Name = "simpleSeparator1";
      this.simpleSeparator1.Size = new Size(1365, 1);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.malzemeEkstresiKemalBindingSource;
      this.malzemeEkstresiKemalBindingSource.DataSource = (object) this.malzemeEkstresiKemal;
      this.malzemeEkstresiKemalBindingSource.Position = 0;
      this.malzemeEkstresiKemal.DataSetName = "MalzemeEkstresiKemal";
      this.malzemeEkstresiKemal.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.malzemeEkstresiGetirBindingSource1.DataMember = "MalzemeEkstresiGetir";
      this.malzemeEkstresiGetirBindingSource1.DataSource = (object) this.malzemeEksteresi;
      this.malzemeEkstresiGetirBindingSource.DataMember = "MalzemeEkstresiGetir";
      this.malzemeEkstresiGetirBindingSource.DataSource = (object) this.malzemeEksteresi;
      this.tBLMALZEMELERBindingSource2.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource2.DataSource = (object) this.bellDataSet;
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUPBindingSource.DataMember = "TBLMALZGRUP";
      this.tBLMALZGRUPBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZGRUPTableAdapter.ClearBeforeFill = true;
      this.tBLMALZMARKABindingSource.DataMember = "TBLMALZMARKA";
      this.tBLMALZMARKABindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZMARKATableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOBindingSource.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZDEPOTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMBindingSource1.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource1.DataSource = (object) this.bellDataSet;
      this.tBLMALZEMELERBindingSource1.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource1.DataSource = (object) this.bellDataSet;
      this.tBLKULLANICILARBindingSource.DataMember = "TBLKULLANICILAR";
      this.tBLKULLANICILARBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLKULLANICILARTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUP2TableAdapter.ClearBeforeFill = true;
      this.tBLMALZBOLUMBindingSource.DataMember = "TBLMALZBOLUM";
      this.tBLMALZBOLUMBindingSource.DataSource = (object) this.bellDataSet;
      this.tBLMALZBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOBindingSource1.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource1.DataSource = (object) this.bellDataSet;
      this.tBLMALZEMELERTableAdapter1.ClearBeforeFill = true;
      this.malzemeEkstresiGetirTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.malzemeEksteresiBindingSource.DataSource = (object) this.malzemeEksteresi;
      this.malzemeEksteresiBindingSource.Position = 0;
      this.malzemeEkstresiGetirBindingSource2.DataMember = "MalzemeEkstresiGetir";
      this.malzemeEkstresiGetirBindingSource2.DataSource = (object) this.malzemeEksteresiBindingSource;
      this.tBLMALZGRUPTableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1385, 764);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = nameof (malzemeEkstresi);
      this.Text = "Malzeme Ekstresi";
      this.Load += new EventHandler(this.malzemeListesi_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource3).EndInit();
      this.malzeemme.EndInit();
      this.gridView2.EndInit();
      this.MBirim.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.bellDataSet.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.MGrup1.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource1).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView3.EndInit();
      this.MGrup2.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).EndInit();
      this.gridView4.EndInit();
      this.MBolum.EndInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource1).EndInit();
      this.gridView5.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource3).EndInit();
      this.malzemeEksteresi.EndInit();
      this.gridView1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.splitterItem1.EndInit();
      this.simpleSeparator1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.malzemeEkstresiKemalBindingSource).EndInit();
      this.malzemeEkstresiKemal.EndInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource1).EndInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource2).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLKULLANICILARBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource1).EndInit();
      ((ISupportInitialize) this.malzemeEksteresiBindingSource).EndInit();
      ((ISupportInitialize) this.malzemeEkstresiGetirBindingSource2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
