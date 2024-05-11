// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.malzemeHareketleri
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
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.MalzemeHareketleriKemalTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class malzemeHareketleri : XtraForm
  {
    private string secme = "";
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
    private BarEditItem barEditItem1;
    private BarButtonItem barButtonItem4;
    private BarEditItem barEditItem3;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup t;
    private RibbonPageGroup ribbonPageGroup2;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private LayoutControl layoutControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private BarCheckItem sayim;
    private BarCheckItem Giris;
    private BarCheckItem Cikis;
    private BarCheckItem barCheckItem3;
    private RibbonPageGroup ribbonPageGroup1;
    private BindingSource malzemeHareketleriKemalBindingSource;
    private MalzemeHareketleriKemal malzemeHareketleriKemal;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colMalzemeMarka;
    private GridColumn colBelediyeBirim;
    private GridColumn colFişKod;
    private GridColumn colTARIH;
    private GridColumn colISLEMTIPIID;
    private GridColumn colİşlemYeri;
    private GridColumn colMalzemeAdı;
    private GridColumn colGIRISMIKTAR;
    private GridColumn colCIKISMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colGIRISTUTAR;
    private GridColumn colCIKISTUTAR;
    private GridColumn colKDVORAN;
    private GridColumn colKDVTUTAR;
    private GridColumn colSATIRTUTAR;
    private GridColumn colMALZSERINO;
    private GridColumn colMALZURTTARIH;
    private GridColumn colDEGISIMKMSI;
    private GridColumn colSONRAKIDEGKM;
    private GridColumn colDepoAdı;
    private GridColumn colALANUSTAID;
    private GridColumn colFIRMAID;
    private RepositoryItemSearchLookUpEdit BelBirim;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private RepositoryItemSearchLookUpEdit IslemTipi;
    private GridView gridView2;
    private BindingSource tBLISLEMTIPIBindingSource;
    private TBLISLEMTIPITableAdapter tBLISLEMTIPITableAdapter;
    private RepositoryItemSearchLookUpEdit IslemYeri;
    private GridView gridView3;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemSearchLookUpEdit Depo;
    private GridView gridView4;
    private BindingSource tBLMALZDEPOBindingSource;
    private TBLMALZDEPOTableAdapter tBLMALZDEPOTableAdapter;
    private RepositoryItemSearchLookUpEdit AlanUsta;
    private GridView gridView5;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private RepositoryItemSearchLookUpEdit Firma;
    private GridView gridView6;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private RepositoryItemSearchLookUpEdit MalzMarka;
    private GridView gridView7;
    private BindingSource tBLMALZMARKABindingSource;
    private TBLMALZMARKATableAdapter tBLMALZMARKATableAdapter;
    private RepositoryItemSearchLookUpEdit MalzAdi;
    private GridView gridView8;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public malzemeHareketleri() => this.InitializeComponent();

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void malzemeHareketleri_Load(object sender, EventArgs e)
    {
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet7.TBLMALZEMELER);
      this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet7.TBLMALZMARKA);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet7.TBLMALZDEPO);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLISLEMTIPITableAdapter.Fill(this.bellDataSet7.TBLISLEMTIPI);
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet7.TBLBELDBIRIMLER);
      this.dataTable1TableAdapter.Fill(this.malzemeHareketleriKemal.DataTable1);
    }

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet7.TBLMALZEMELER);
      this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet7.TBLMALZMARKA);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet7.TBLMALZDEPO);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLISLEMTIPITableAdapter.Fill(this.bellDataSet7.TBLISLEMTIPI);
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet7.TBLBELDBIRIMLER);
      this.dataTable1TableAdapter.Fill(this.malzemeHareketleriKemal.DataTable1);
    }

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void filtre()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private string secmeislemi()
    {
      this.secme = "";
      string str = "";
      if (this.sayim.Checked)
        this.secme += "[ISLEMTIPIID] = 1 OR";
      if (this.Giris.Checked)
        this.secme += "  [ISLEMTIPIID] = 2 OR";
      if (this.Cikis.Checked)
        this.secme += "[ISLEMTIPIID] = 3 OR";
      if (this.barCheckItem3.Checked)
        this.secme += "[ISLEMTIPIID] = 4 OR";
      try
      {
        str = this.secme.Substring(0, this.secme.Length - 2);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private void sayim_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void Giris_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void Cikis_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (malzemeHareketleri));
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
      this.yenileButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.sayim = new BarCheckItem();
      this.Giris = new BarCheckItem();
      this.Cikis = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.t = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.layoutControl1 = new LayoutControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.malzemeHareketleriKemalBindingSource = new BindingSource(this.components);
      this.malzemeHareketleriKemal = new MalzemeHareketleriKemal();
      this.gridView1 = new GridView();
      this.colMalzemeMarka = new GridColumn();
      this.MalzMarka = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZMARKABindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView7 = new GridView();
      this.colBelediyeBirim = new GridColumn();
      this.BelBirim = new RepositoryItemSearchLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colFişKod = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.IslemTipi = new RepositoryItemSearchLookUpEdit();
      this.tBLISLEMTIPIBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.colİşlemYeri = new GridColumn();
      this.IslemYeri = new RepositoryItemSearchLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.colMalzemeAdı = new GridColumn();
      this.MalzAdi = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.gridView8 = new GridView();
      this.colGIRISMIKTAR = new GridColumn();
      this.colCIKISMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colGIRISTUTAR = new GridColumn();
      this.colCIKISTUTAR = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.colKDVTUTAR = new GridColumn();
      this.colSATIRTUTAR = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colDEGISIMKMSI = new GridColumn();
      this.colSONRAKIDEGKM = new GridColumn();
      this.colDepoAdı = new GridColumn();
      this.Depo = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZDEPOBindingSource = new BindingSource(this.components);
      this.gridView4 = new GridView();
      this.colALANUSTAID = new GridColumn();
      this.AlanUsta = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.colFIRMAID = new GridColumn();
      this.Firma = new RepositoryItemSearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.gridView6 = new GridView();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLISLEMTIPITableAdapter = new TBLISLEMTIPITableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLMALZDEPOTableAdapter = new TBLMALZDEPOTableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.tBLMALZMARKATableAdapter = new TBLMALZMARKATableAdapter();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonControl1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.malzemeHareketleriKemalBindingSource).BeginInit();
      this.malzemeHareketleriKemal.BeginInit();
      this.gridView1.BeginInit();
      this.MalzMarka.BeginInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView7.BeginInit();
      this.BelBirim.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.IslemTipi.BeginInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.IslemYeri.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.MalzAdi.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.gridView8.BeginInit();
      this.Depo.BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).BeginInit();
      this.gridView4.BeginInit();
      this.AlanUsta.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.gridView5.BeginInit();
      this.Firma.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.gridView6.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[20]
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
        (BarItem) this.barEditItem1,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barEditItem3,
        (BarItem) this.sayim,
        (BarItem) this.Giris,
        (BarItem) this.Cikis,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 31;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemRadioGroup1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1869, 122);
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
      toolTipItem.Text = "Kayit Bul...";
      superToolTip.Items.Add((BaseToolTipItem) toolTipItem);
      this.kayitBulTxt.SuperTip = superToolTip;
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
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.barButtonItem4.Caption = "barButtonItem4";
      this.barButtonItem4.Id = 17;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barEditItem3.Caption = "Depo Seç";
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.EditWidth = 100;
      this.barEditItem3.Id = 21;
      this.barEditItem3.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem3.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.sayim.Caption = "Sayım Fişleri";
      this.sayim.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.sayim.Id = 26;
      this.sayim.Name = "sayim";
      this.sayim.CheckedChanged += new ItemClickEventHandler(this.sayim_CheckedChanged);
      this.Giris.Caption = "Giriş Fişleri";
      this.Giris.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.Giris.Id = 27;
      this.Giris.Name = "Giris";
      this.Giris.CheckedChanged += new ItemClickEventHandler(this.Giris_CheckedChanged);
      this.Cikis.Caption = "Çıkış Fişleri";
      this.Cikis.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.Cikis.Id = 28;
      this.Cikis.Name = "Cikis";
      this.Cikis.CheckedChanged += new ItemClickEventHandler(this.Cikis_CheckedChanged);
      this.barCheckItem3.Caption = "Tümü";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 29;
      this.barCheckItem3.Name = "barCheckItem3";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup4,
        this.t,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.t.ItemLinks.Add((BarItem) this.kayitBulTxt, true);
      this.t.ItemLinks.Add((BarItem) this.barEditItem1);
      this.t.ItemLinks.Add((BarItem) this.barEditItem2);
      this.t.Name = "t";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.sayim);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.Giris);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.Cikis);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.repositoryItemRadioGroup1.Columns = 2;
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1869, 838);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.gridControl1.Location = new Point(12, 12);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[8]
      {
        (RepositoryItem) this.BelBirim,
        (RepositoryItem) this.IslemTipi,
        (RepositoryItem) this.IslemYeri,
        (RepositoryItem) this.Depo,
        (RepositoryItem) this.AlanUsta,
        (RepositoryItem) this.Firma,
        (RepositoryItem) this.MalzMarka,
        (RepositoryItem) this.MalzAdi
      });
      this.gridControl1.Size = new Size(1845, 814);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.malzemeHareketleriKemalBindingSource;
      this.malzemeHareketleriKemalBindingSource.DataSource = (object) this.malzemeHareketleriKemal;
      this.malzemeHareketleriKemalBindingSource.Position = 0;
      this.malzemeHareketleriKemal.DataSetName = "MalzemeHareketleriKemal";
      this.malzemeHareketleriKemal.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[22]
      {
        this.colMalzemeMarka,
        this.colBelediyeBirim,
        this.colFişKod,
        this.colTARIH,
        this.colISLEMTIPIID,
        this.colİşlemYeri,
        this.colMalzemeAdı,
        this.colGIRISMIKTAR,
        this.colCIKISMIKTAR,
        this.colFIYAT,
        this.colGIRISTUTAR,
        this.colCIKISTUTAR,
        this.colKDVORAN,
        this.colKDVTUTAR,
        this.colSATIRTUTAR,
        this.colMALZSERINO,
        this.colMALZURTTARIH,
        this.colDEGISIMKMSI,
        this.colSONRAKIDEGKM,
        this.colDepoAdı,
        this.colALANUSTAID,
        this.colFIRMAID
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.colMalzemeMarka.Caption = "Malzeme Markası";
      this.colMalzemeMarka.ColumnEdit = (RepositoryItem) this.MalzMarka;
      this.colMalzemeMarka.FieldName = "Malzeme Marka";
      this.colMalzemeMarka.MinWidth = 25;
      this.colMalzemeMarka.Name = "colMalzemeMarka";
      this.colMalzemeMarka.OptionsColumn.AllowEdit = false;
      this.colMalzemeMarka.OptionsColumn.ReadOnly = true;
      this.colMalzemeMarka.Visible = true;
      this.colMalzemeMarka.VisibleIndex = 0;
      this.colMalzemeMarka.Width = 118;
      this.MalzMarka.AutoHeight = false;
      this.MalzMarka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MalzMarka.DataSource = (object) this.tBLMALZMARKABindingSource;
      this.MalzMarka.DisplayMember = "MALZMARKA";
      this.MalzMarka.Name = "MalzMarka";
      this.MalzMarka.NullText = "";
      this.MalzMarka.PopupView = (ColumnView) this.gridView7;
      this.MalzMarka.ValueMember = "ID";
      this.tBLMALZMARKABindingSource.DataMember = "TBLMALZMARKA";
      this.tBLMALZMARKABindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView7.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView7.OptionsView.ShowGroupPanel = false;
      this.colBelediyeBirim.Caption = "Belediye Birim";
      this.colBelediyeBirim.ColumnEdit = (RepositoryItem) this.BelBirim;
      this.colBelediyeBirim.FieldName = "Belediye Birim";
      this.colBelediyeBirim.MinWidth = 25;
      this.colBelediyeBirim.Name = "colBelediyeBirim";
      this.colBelediyeBirim.OptionsColumn.AllowEdit = false;
      this.colBelediyeBirim.OptionsColumn.ReadOnly = true;
      this.colBelediyeBirim.Visible = true;
      this.colBelediyeBirim.VisibleIndex = 1;
      this.colBelediyeBirim.Width = 94;
      this.BelBirim.AutoHeight = false;
      this.BelBirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BelBirim.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.BelBirim.DisplayMember = "BELDBIRIMADI";
      this.BelBirim.Name = "BelBirim";
      this.BelBirim.NullText = "";
      this.BelBirim.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.BelBirim.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet7;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colFişKod.FieldName = "Fiş Kod";
      this.colFişKod.MinWidth = 25;
      this.colFişKod.Name = "colFişKod";
      this.colFişKod.OptionsColumn.AllowEdit = false;
      this.colFişKod.OptionsColumn.ReadOnly = true;
      this.colFişKod.Visible = true;
      this.colFişKod.VisibleIndex = 2;
      this.colFişKod.Width = 94;
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 3;
      this.colTARIH.Width = 94;
      this.colISLEMTIPIID.Caption = "İşlem Tipi";
      this.colISLEMTIPIID.ColumnEdit = (RepositoryItem) this.IslemTipi;
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 25;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 4;
      this.colISLEMTIPIID.Width = 94;
      this.IslemTipi.AutoHeight = false;
      this.IslemTipi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IslemTipi.DataSource = (object) this.tBLISLEMTIPIBindingSource;
      this.IslemTipi.DisplayMember = "ISLEMTIPI";
      this.IslemTipi.Name = "IslemTipi";
      this.IslemTipi.NullText = "";
      this.IslemTipi.PopupView = (ColumnView) this.gridView2;
      this.IslemTipi.ValueMember = "ID";
      this.tBLISLEMTIPIBindingSource.DataMember = "TBLISLEMTIPI";
      this.tBLISLEMTIPIBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colİşlemYeri.ColumnEdit = (RepositoryItem) this.IslemYeri;
      this.colİşlemYeri.FieldName = "İşlem Yeri";
      this.colİşlemYeri.MinWidth = 25;
      this.colİşlemYeri.Name = "colİşlemYeri";
      this.colİşlemYeri.OptionsColumn.AllowEdit = false;
      this.colİşlemYeri.OptionsColumn.ReadOnly = true;
      this.colİşlemYeri.Visible = true;
      this.colİşlemYeri.VisibleIndex = 5;
      this.colİşlemYeri.Width = 94;
      this.IslemYeri.AutoHeight = false;
      this.IslemYeri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IslemYeri.DataSource = (object) this.tBLARACLARBindingSource;
      this.IslemYeri.DisplayMember = "PLAKA";
      this.IslemYeri.Name = "IslemYeri";
      this.IslemYeri.NullText = "";
      this.IslemYeri.PopupView = (ColumnView) this.gridView3;
      this.IslemYeri.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.colMalzemeAdı.ColumnEdit = (RepositoryItem) this.MalzAdi;
      this.colMalzemeAdı.FieldName = "Malzeme Adı";
      this.colMalzemeAdı.MinWidth = 25;
      this.colMalzemeAdı.Name = "colMalzemeAdı";
      this.colMalzemeAdı.OptionsColumn.AllowEdit = false;
      this.colMalzemeAdı.OptionsColumn.ReadOnly = true;
      this.colMalzemeAdı.Visible = true;
      this.colMalzemeAdı.VisibleIndex = 6;
      this.colMalzemeAdı.Width = 94;
      this.MalzAdi.AutoHeight = false;
      this.MalzAdi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MalzAdi.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.MalzAdi.DisplayMember = "MALZEMEADI";
      this.MalzAdi.Name = "MalzAdi";
      this.MalzAdi.NullText = "";
      this.MalzAdi.PopupView = (ColumnView) this.gridView8;
      this.MalzAdi.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView8.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView8.Name = "gridView8";
      this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView8.OptionsView.ShowGroupPanel = false;
      this.colGIRISMIKTAR.Caption = "Giriş Miktar";
      this.colGIRISMIKTAR.FieldName = "GIRISMIKTAR";
      this.colGIRISMIKTAR.MinWidth = 25;
      this.colGIRISMIKTAR.Name = "colGIRISMIKTAR";
      this.colGIRISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISMIKTAR.Visible = true;
      this.colGIRISMIKTAR.VisibleIndex = 7;
      this.colGIRISMIKTAR.Width = 94;
      this.colCIKISMIKTAR.Caption = "Çıkış Miktar";
      this.colCIKISMIKTAR.FieldName = "CIKISMIKTAR";
      this.colCIKISMIKTAR.MinWidth = 25;
      this.colCIKISMIKTAR.Name = "colCIKISMIKTAR";
      this.colCIKISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISMIKTAR.Visible = true;
      this.colCIKISMIKTAR.VisibleIndex = 8;
      this.colCIKISMIKTAR.Width = 94;
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 25;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 9;
      this.colFIYAT.Width = 94;
      this.colGIRISTUTAR.Caption = "Giriş Tutar";
      this.colGIRISTUTAR.FieldName = "GIRISTUTAR";
      this.colGIRISTUTAR.MinWidth = 25;
      this.colGIRISTUTAR.Name = "colGIRISTUTAR";
      this.colGIRISTUTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISTUTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISTUTAR.Visible = true;
      this.colGIRISTUTAR.VisibleIndex = 10;
      this.colGIRISTUTAR.Width = 94;
      this.colCIKISTUTAR.Caption = "Çıkış Tutar";
      this.colCIKISTUTAR.FieldName = "CIKISTUTAR";
      this.colCIKISTUTAR.MinWidth = 25;
      this.colCIKISTUTAR.Name = "colCIKISTUTAR";
      this.colCIKISTUTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISTUTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISTUTAR.Visible = true;
      this.colCIKISTUTAR.VisibleIndex = 11;
      this.colCIKISTUTAR.Width = 94;
      this.colKDVORAN.Caption = "KDV Oran";
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.MinWidth = 25;
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.OptionsColumn.AllowEdit = false;
      this.colKDVORAN.OptionsColumn.ReadOnly = true;
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 12;
      this.colKDVORAN.Width = 94;
      this.colKDVTUTAR.Caption = "KDV Tutar";
      this.colKDVTUTAR.FieldName = "KDVTUTAR";
      this.colKDVTUTAR.MinWidth = 25;
      this.colKDVTUTAR.Name = "colKDVTUTAR";
      this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colKDVTUTAR.Visible = true;
      this.colKDVTUTAR.VisibleIndex = 13;
      this.colKDVTUTAR.Width = 94;
      this.colSATIRTUTAR.Caption = "Satır Tutar";
      this.colSATIRTUTAR.FieldName = "SATIRTUTAR";
      this.colSATIRTUTAR.MinWidth = 25;
      this.colSATIRTUTAR.Name = "colSATIRTUTAR";
      this.colSATIRTUTAR.OptionsColumn.AllowEdit = false;
      this.colSATIRTUTAR.OptionsColumn.ReadOnly = true;
      this.colSATIRTUTAR.Visible = true;
      this.colSATIRTUTAR.VisibleIndex = 14;
      this.colSATIRTUTAR.Width = 94;
      this.colMALZSERINO.Caption = "Malzeme Seri No";
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.MinWidth = 25;
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 15;
      this.colMALZSERINO.Width = 94;
      this.colMALZURTTARIH.Caption = "Malzeme Üretim Tarihi";
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 25;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.OptionsColumn.AllowEdit = false;
      this.colMALZURTTARIH.OptionsColumn.ReadOnly = true;
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 16;
      this.colMALZURTTARIH.Width = 119;
      this.colDEGISIMKMSI.Caption = "Değişim KM'si";
      this.colDEGISIMKMSI.FieldName = "DEGISIMKMSI";
      this.colDEGISIMKMSI.MinWidth = 25;
      this.colDEGISIMKMSI.Name = "colDEGISIMKMSI";
      this.colDEGISIMKMSI.OptionsColumn.AllowEdit = false;
      this.colDEGISIMKMSI.OptionsColumn.ReadOnly = true;
      this.colDEGISIMKMSI.Visible = true;
      this.colDEGISIMKMSI.VisibleIndex = 17;
      this.colDEGISIMKMSI.Width = 94;
      this.colSONRAKIDEGKM.Caption = "Sonraki Değişim KM'si";
      this.colSONRAKIDEGKM.FieldName = "SONRAKIDEGKM";
      this.colSONRAKIDEGKM.MinWidth = 25;
      this.colSONRAKIDEGKM.Name = "colSONRAKIDEGKM";
      this.colSONRAKIDEGKM.OptionsColumn.AllowEdit = false;
      this.colSONRAKIDEGKM.OptionsColumn.ReadOnly = true;
      this.colSONRAKIDEGKM.Visible = true;
      this.colSONRAKIDEGKM.VisibleIndex = 18;
      this.colSONRAKIDEGKM.Width = 120;
      this.colDepoAdı.ColumnEdit = (RepositoryItem) this.Depo;
      this.colDepoAdı.FieldName = "Depo Adı";
      this.colDepoAdı.MinWidth = 25;
      this.colDepoAdı.Name = "colDepoAdı";
      this.colDepoAdı.OptionsColumn.AllowEdit = false;
      this.colDepoAdı.OptionsColumn.ReadOnly = true;
      this.colDepoAdı.Visible = true;
      this.colDepoAdı.VisibleIndex = 19;
      this.colDepoAdı.Width = 94;
      this.Depo.AutoHeight = false;
      this.Depo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Depo.DataSource = (object) this.tBLMALZDEPOBindingSource;
      this.Depo.DisplayMember = "DEPOADI";
      this.Depo.Name = "Depo";
      this.Depo.NullText = "";
      this.Depo.PopupView = (ColumnView) this.gridView4;
      this.Depo.ValueMember = "ID";
      this.tBLMALZDEPOBindingSource.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.colALANUSTAID.Caption = "Alan Usta Adı";
      this.colALANUSTAID.ColumnEdit = (RepositoryItem) this.AlanUsta;
      this.colALANUSTAID.FieldName = "ALANUSTAID";
      this.colALANUSTAID.MinWidth = 25;
      this.colALANUSTAID.Name = "colALANUSTAID";
      this.colALANUSTAID.OptionsColumn.AllowEdit = false;
      this.colALANUSTAID.OptionsColumn.ReadOnly = true;
      this.colALANUSTAID.Visible = true;
      this.colALANUSTAID.VisibleIndex = 20;
      this.colALANUSTAID.Width = 94;
      this.AlanUsta.AutoHeight = false;
      this.AlanUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AlanUsta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.AlanUsta.DisplayMember = "USTAADISOYADI";
      this.AlanUsta.Name = "AlanUsta";
      this.AlanUsta.NullText = "";
      this.AlanUsta.PopupView = (ColumnView) this.gridView5;
      this.AlanUsta.ValueMember = "USTAADISOYADI";
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colFIRMAID.Caption = "Firma";
      this.colFIRMAID.ColumnEdit = (RepositoryItem) this.Firma;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 25;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 21;
      this.colFIRMAID.Width = 94;
      this.Firma.AutoHeight = false;
      this.Firma.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Firma.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.Firma.DisplayMember = "FIRMAADI";
      this.Firma.Name = "Firma";
      this.Firma.NullText = "";
      this.Firma.PopupView = (ColumnView) this.gridView6;
      this.Firma.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1869, 838);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1849, 818);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLISLEMTIPITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLMALZMARKATableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 35;
      this.barEditItem2.EditWidth = 135;
      this.barEditItem2.Id = 30;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1869, 960);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (malzemeHareketleri);
      this.Text = nameof (malzemeHareketleri);
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.malzemeHareketleri_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.malzemeHareketleriKemalBindingSource).EndInit();
      this.malzemeHareketleriKemal.EndInit();
      this.gridView1.EndInit();
      this.MalzMarka.EndInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView7.EndInit();
      this.BelBirim.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.IslemTipi.EndInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).EndInit();
      this.gridView2.EndInit();
      this.IslemYeri.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.gridView3.EndInit();
      this.MalzAdi.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.gridView8.EndInit();
      this.Depo.EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).EndInit();
      this.gridView4.EndInit();
      this.AlanUsta.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.gridView5.EndInit();
      this.Firma.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.gridView6.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
