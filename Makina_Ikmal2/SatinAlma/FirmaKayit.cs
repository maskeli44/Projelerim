// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.FirmaKayit
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSetTableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class FirmaKayit : XtraForm
  {
    public int secim = 0;
    private int gecerliID = 0;
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private SimpleButton ekleButton;
    private SearchLookUpEdit sektorAdi;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private bellDataSet bellDataSet;
    private BindingSource tBLFIRMASEKTORBindingSource;
    private TBLFIRMASEKTORTableAdapter tBLFIRMASEKTORTableAdapter;
    private TextEdit firmaAdi;
    private LayoutControlItem layoutControlItem3;
    private BarButtonItem kapatButton;
    private MemoEdit ilgiliNotTxt;
    private TextEdit vergiNoTxt;
    private TextEdit vergiDairesiTxt;
    private TextEdit adresTxt;
    private TextEdit cepTelefonTxt;
    private TextEdit telefonTxt;
    private TextEdit yetkiliTxt;
    private TextEdit faaliyetAlaniTxt;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private GridColumn sektorID;

    public FirmaKayit() => this.InitializeComponent();

    private void FirmaKayit_Load(object sender, EventArgs e) => this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet.TBLFIRMASEKTOR);

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
        this.Kaydet();
      if (this.secim != 2)
        return;
      this.Duzenle();
    }

    private void Kaydet()
    {
      if (this.BoslukKontrol())
      {
        try
        {
          this.db.TBLFIRMALAR.Add(new TBLFIRMALAR()
          {
            SEKTORID = new int?(Convert.ToInt32(this.sektorAdi.EditValue)),
            FIRMAADI = this.firmaAdi.Text,
            FALIYETALANI = this.faaliyetAlaniTxt.Text,
            YETKILISI = this.yetkiliTxt.Text,
            TELEFON = this.telefonTxt.Text,
            CEPTELEFON = this.cepTelefonTxt.Text,
            FIRMAADRES = this.adresTxt.Text,
            VERGIDAIRE = this.vergiDairesiTxt.Text,
            VERGINO = this.vergiNoTxt.Text,
            ILGILINOT = this.ilgiliNotTxt.Text
          });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
          ((FirmaListesi) Application.OpenForms["FirmaListesi"])?.Yenile();
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show("Veriler Kaydedilemedi Veri Tabanı Hatası Var");
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Bos alan var!");
      }
    }

    private bool BoslukKontrol() => this.firmaAdi.Text != "" && this.sektorAdi.EditValue != null && this.yetkiliTxt.Text != "" && this.telefonTxt.Text != "" && this.cepTelefonTxt.Text != "" && this.adresTxt.Text != "" && this.vergiDairesiTxt.Text != "" && this.vergiNoTxt.Text != "";

    private void Duzenle()
    {
      if (this.BoslukKontrol() && this.gecerliID != 0)
      {
        try
        {
          TBLFIRMALAR tblfirmalar = this.db.TBLFIRMALAR.FirstOrDefault<TBLFIRMALAR>((Expression<System.Func<TBLFIRMALAR, bool>>) (x => x.ID == this.gecerliID));
          tblfirmalar.SEKTORID = new int?(Convert.ToInt32(this.sektorAdi.EditValue));
          tblfirmalar.FIRMAADI = this.firmaAdi.Text;
          tblfirmalar.FALIYETALANI = this.faaliyetAlaniTxt.Text;
          tblfirmalar.YETKILISI = this.yetkiliTxt.Text;
          tblfirmalar.TELEFON = this.telefonTxt.Text;
          tblfirmalar.CEPTELEFON = this.cepTelefonTxt.Text;
          tblfirmalar.FIRMAADRES = this.adresTxt.Text;
          tblfirmalar.VERGIDAIRE = this.vergiDairesiTxt.Text;
          tblfirmalar.VERGINO = this.vergiNoTxt.Text;
          tblfirmalar.ILGILINOT = this.ilgiliNotTxt.Text;
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Güncelleme başarı ile tamamlanmıştır.");
          ((FirmaListesi) Application.OpenForms["FirmaListesi"])?.Yenile();
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show("Veriler Kaydedilemedi Veri Tabanı Hatası Var");
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Bos alan var!");
      }
    }

    public void Getir(int guncelID)
    {
      if (guncelID == 0)
        return;
      try
      {
        this.SilButton.Enabled = false;
        this.YeniDosyaButton.Enabled = false;
        this.gecerliID = guncelID;
        TBLFIRMALAR tblfirmalar = this.db.TBLFIRMALAR.FirstOrDefault<TBLFIRMALAR>((Expression<System.Func<TBLFIRMALAR, bool>>) (x => x.ID == guncelID));
        this.sektorAdi.EditValue = (object) tblfirmalar.SEKTORID;
        this.firmaAdi.Text = tblfirmalar.FIRMAADI;
        this.faaliyetAlaniTxt.Text = tblfirmalar.FALIYETALANI;
        this.yetkiliTxt.Text = tblfirmalar.YETKILISI;
        this.telefonTxt.Text = tblfirmalar.TELEFON;
        this.cepTelefonTxt.Text = tblfirmalar.CEPTELEFON;
        this.adresTxt.Text = tblfirmalar.FIRMAADRES;
        this.vergiDairesiTxt.Text = tblfirmalar.VERGIDAIRE;
        this.vergiNoTxt.Text = tblfirmalar.VERGINO;
        this.ilgiliNotTxt.Text = tblfirmalar.ILGILINOT;
      }
      catch
      {
      }
    }

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.gecerliID == 0)
        return;
      this.db.TBLFIRMALAR.Remove(this.db.TBLFIRMALAR.FirstOrDefault<TBLFIRMALAR>((Expression<System.Func<TBLFIRMALAR, bool>>) (x => x.ID == this.gecerliID)));
      this.db.SaveChanges();
      this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet.TBLFIRMASEKTOR);
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.sektorAdi.EditValue = (object) null;
      this.firmaAdi.Text = "";
      this.faaliyetAlaniTxt.Text = "";
      this.yetkiliTxt.Text = "";
      this.telefonTxt.Text = "";
      this.cepTelefonTxt.Text = "";
      this.adresTxt.Text = "";
      this.vergiDairesiTxt.Text = "";
      this.vergiNoTxt.Text = "";
      this.ilgiliNotTxt.Text = "";
    }

    private void ekleButton_Click(object sender, EventArgs e)
    {
      int num = (int) new SektorKayit() { secim = 1 }.ShowDialog();
    }

    public void liste()
    {
      this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet.TBLFIRMASEKTOR);
      this.sektorAdi.EditValue = (object) SektorAktarma.list[0].ID;
      SektorAktarma.list.Clear();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FirmaKayit));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.ilgiliNotTxt = new MemoEdit();
      this.vergiNoTxt = new TextEdit();
      this.vergiDairesiTxt = new TextEdit();
      this.adresTxt = new TextEdit();
      this.cepTelefonTxt = new TextEdit();
      this.telefonTxt = new TextEdit();
      this.yetkiliTxt = new TextEdit();
      this.faaliyetAlaniTxt = new TextEdit();
      this.firmaAdi = new TextEdit();
      this.ekleButton = new SimpleButton();
      this.sektorAdi = new SearchLookUpEdit();
      this.tBLFIRMASEKTORBindingSource = new BindingSource(this.components);
      this.bellDataSet = new bellDataSet();
      this.searchLookUpEdit1View = new GridView();
      this.sektorID = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.tBLFIRMASEKTORTableAdapter = new TBLFIRMASEKTORTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.ilgiliNotTxt.Properties.BeginInit();
      this.vergiNoTxt.Properties.BeginInit();
      this.vergiDairesiTxt.Properties.BeginInit();
      this.adresTxt.Properties.BeginInit();
      this.cepTelefonTxt.Properties.BeginInit();
      this.telefonTxt.Properties.BeginInit();
      this.yetkiliTxt.Properties.BeginInit();
      this.faaliyetAlaniTxt.Properties.BeginInit();
      this.firmaAdi.Properties.BeginInit();
      this.sektorAdi.Properties.BeginInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).BeginInit();
      this.bellDataSet.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
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
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.kapatButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 12;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(763, 96);
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
      this.KaydetButton.Caption = "Kaydet";
      this.KaydetButton.Id = 2;
      this.KaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.Image");
      this.KaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.LargeImage");
      this.KaydetButton.LargeWidth = 100;
      this.KaydetButton.Name = "KaydetButton";
      this.KaydetButton.ItemClick += new ItemClickEventHandler(this.KaydetButton_ItemClick);
      this.SilButton.Caption = "Sil";
      this.SilButton.Id = 3;
      this.SilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.Image");
      this.SilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.LargeImage");
      this.SilButton.LargeWidth = 100;
      this.SilButton.Name = "SilButton";
      this.SilButton.RibbonStyle = RibbonItemStyles.Large;
      this.SilButton.ItemClick += new ItemClickEventHandler(this.SilButton_ItemClick);
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
      this.barButtonItem7.Caption = "Kapat";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.LargeWidth = 100;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barButtonItem7.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.LargeWidth = 100;
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
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
      this.kapatButton.Caption = "Kapat";
      this.kapatButton.Id = 11;
      this.kapatButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.Image");
      this.kapatButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.LargeImage");
      this.kapatButton.LargeWidth = 100;
      this.kapatButton.Name = "kapatButton";
      this.kapatButton.ItemClick += new ItemClickEventHandler(this.kapatButton_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.ilgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.vergiNoTxt);
      this.layoutControl1.Controls.Add((Control) this.vergiDairesiTxt);
      this.layoutControl1.Controls.Add((Control) this.adresTxt);
      this.layoutControl1.Controls.Add((Control) this.cepTelefonTxt);
      this.layoutControl1.Controls.Add((Control) this.telefonTxt);
      this.layoutControl1.Controls.Add((Control) this.yetkiliTxt);
      this.layoutControl1.Controls.Add((Control) this.faaliyetAlaniTxt);
      this.layoutControl1.Controls.Add((Control) this.firmaAdi);
      this.layoutControl1.Controls.Add((Control) this.ekleButton);
      this.layoutControl1.Controls.Add((Control) this.sektorAdi);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1016, 329, 650, 400));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(763, 386);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.ilgiliNotTxt.Location = new Point(100, 276);
      this.ilgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilgiliNotTxt.Name = "ilgiliNotTxt";
      this.ilgiliNotTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ilgiliNotTxt.Properties.Appearance.Options.UseFont = true;
      this.ilgiliNotTxt.Size = new Size(651, 98);
      this.ilgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ilgiliNotTxt.TabIndex = 14;
      this.vergiNoTxt.Location = new Point(100, 248);
      this.vergiNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.vergiNoTxt.Name = "vergiNoTxt";
      this.vergiNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.vergiNoTxt.Properties.Appearance.Options.UseFont = true;
      this.vergiNoTxt.Size = new Size(651, 24);
      this.vergiNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.vergiNoTxt.TabIndex = 13;
      this.vergiDairesiTxt.Location = new Point(100, 220);
      this.vergiDairesiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.vergiDairesiTxt.Name = "vergiDairesiTxt";
      this.vergiDairesiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.vergiDairesiTxt.Properties.Appearance.Options.UseFont = true;
      this.vergiDairesiTxt.Size = new Size(651, 24);
      this.vergiDairesiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.vergiDairesiTxt.TabIndex = 12;
      this.adresTxt.Location = new Point(100, 192);
      this.adresTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.adresTxt.Name = "adresTxt";
      this.adresTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adresTxt.Properties.Appearance.Options.UseFont = true;
      this.adresTxt.Size = new Size(651, 24);
      this.adresTxt.StyleController = (IStyleController) this.layoutControl1;
      this.adresTxt.TabIndex = 11;
      this.cepTelefonTxt.Location = new Point(100, 164);
      this.cepTelefonTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cepTelefonTxt.Name = "cepTelefonTxt";
      this.cepTelefonTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cepTelefonTxt.Properties.Appearance.Options.UseFont = true;
      this.cepTelefonTxt.Size = new Size(651, 24);
      this.cepTelefonTxt.StyleController = (IStyleController) this.layoutControl1;
      this.cepTelefonTxt.TabIndex = 10;
      this.telefonTxt.Location = new Point(100, 136);
      this.telefonTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.telefonTxt.Name = "telefonTxt";
      this.telefonTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.telefonTxt.Properties.Appearance.Options.UseFont = true;
      this.telefonTxt.Size = new Size(651, 24);
      this.telefonTxt.StyleController = (IStyleController) this.layoutControl1;
      this.telefonTxt.TabIndex = 9;
      this.yetkiliTxt.Location = new Point(100, 108);
      this.yetkiliTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yetkiliTxt.Name = "yetkiliTxt";
      this.yetkiliTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yetkiliTxt.Properties.Appearance.Options.UseFont = true;
      this.yetkiliTxt.Size = new Size(651, 24);
      this.yetkiliTxt.StyleController = (IStyleController) this.layoutControl1;
      this.yetkiliTxt.TabIndex = 8;
      this.faaliyetAlaniTxt.Location = new Point(100, 80);
      this.faaliyetAlaniTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.faaliyetAlaniTxt.Name = "faaliyetAlaniTxt";
      this.faaliyetAlaniTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.faaliyetAlaniTxt.Properties.Appearance.Options.UseFont = true;
      this.faaliyetAlaniTxt.Size = new Size(651, 24);
      this.faaliyetAlaniTxt.StyleController = (IStyleController) this.layoutControl1;
      this.faaliyetAlaniTxt.TabIndex = 7;
      this.firmaAdi.Location = new Point(100, 52);
      this.firmaAdi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firmaAdi.Name = "firmaAdi";
      this.firmaAdi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.firmaAdi.Properties.Appearance.Options.UseFont = true;
      this.firmaAdi.Size = new Size(651, 24);
      this.firmaAdi.StyleController = (IStyleController) this.layoutControl1;
      this.firmaAdi.TabIndex = 6;
      this.ekleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("ekleButton.ImageOptions.Image");
      this.ekleButton.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.ekleButton.Location = new Point(713, 12);
      this.ekleButton.Name = "ekleButton";
      this.ekleButton.PaintStyle = PaintStyles.Light;
      this.ekleButton.Size = new Size(38, 36);
      this.ekleButton.StyleController = (IStyleController) this.layoutControl1;
      this.ekleButton.TabIndex = 5;
      this.ekleButton.Click += new EventHandler(this.ekleButton_Click);
      this.sektorAdi.EditValue = (object) "";
      this.sektorAdi.Location = new Point(100, 12);
      this.sektorAdi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sektorAdi.Name = "sektorAdi";
      this.sektorAdi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sektorAdi.Properties.Appearance.Options.UseFont = true;
      this.sektorAdi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sektorAdi.Properties.DataSource = (object) this.tBLFIRMASEKTORBindingSource;
      this.sektorAdi.Properties.DisplayMember = "SEKTORADI";
      this.sektorAdi.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.sektorAdi.Properties.ValueMember = "ID";
      this.sektorAdi.Size = new Size(609, 24);
      this.sektorAdi.StyleController = (IStyleController) this.layoutControl1;
      this.sektorAdi.TabIndex = 4;
      this.tBLFIRMASEKTORBindingSource.DataMember = "TBLFIRMASEKTOR";
      this.tBLFIRMASEKTORBindingSource.DataSource = (object) this.bellDataSet;
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.sektorID
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.sektorID.Caption = "Sektör Adı";
      this.sektorID.FieldName = "SEKTORADI";
      this.sektorID.Name = "sektorID";
      this.sektorID.Visible = true;
      this.sektorID.VisibleIndex = 0;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[11]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(763, 386);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.sektorAdi;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(701, 40);
      this.layoutControlItem1.Text = "Sektör Adı";
      this.layoutControlItem1.TextSize = new Size(85, 18);
      this.layoutControlItem2.Control = (Control) this.ekleButton;
      this.layoutControlItem2.Location = new Point(701, 0);
      this.layoutControlItem2.MinSize = new Size(42, 40);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(42, 40);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.firmaAdi;
      this.layoutControlItem3.Location = new Point(0, 40);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(743, 28);
      this.layoutControlItem3.Text = "Firma Adi";
      this.layoutControlItem3.TextSize = new Size(85, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.faaliyetAlaniTxt;
      this.layoutControlItem4.Location = new Point(0, 68);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(743, 28);
      this.layoutControlItem4.Text = "Faaliyet Alanı";
      this.layoutControlItem4.TextSize = new Size(85, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.yetkiliTxt;
      this.layoutControlItem5.Location = new Point(0, 96);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(743, 28);
      this.layoutControlItem5.Text = "Yetkilisi";
      this.layoutControlItem5.TextSize = new Size(85, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.telefonTxt;
      this.layoutControlItem6.Location = new Point(0, 124);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(743, 28);
      this.layoutControlItem6.Text = "Telefon";
      this.layoutControlItem6.TextSize = new Size(85, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.cepTelefonTxt;
      this.layoutControlItem7.Location = new Point(0, 152);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(743, 28);
      this.layoutControlItem7.Text = "Cep Telefon";
      this.layoutControlItem7.TextSize = new Size(85, 18);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.adresTxt;
      this.layoutControlItem8.Location = new Point(0, 180);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(743, 28);
      this.layoutControlItem8.Text = "Adres";
      this.layoutControlItem8.TextSize = new Size(85, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.vergiDairesiTxt;
      this.layoutControlItem9.Location = new Point(0, 208);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(743, 28);
      this.layoutControlItem9.Text = "Vergi Dairesi";
      this.layoutControlItem9.TextSize = new Size(85, 18);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.vergiNoTxt;
      this.layoutControlItem10.Location = new Point(0, 236);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(743, 28);
      this.layoutControlItem10.Text = "Vergi No";
      this.layoutControlItem10.TextSize = new Size(85, 18);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.ilgiliNotTxt;
      this.layoutControlItem11.Location = new Point(0, 264);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(743, 102);
      this.layoutControlItem11.Text = "İlgili Not";
      this.layoutControlItem11.TextSize = new Size(85, 18);
      this.tBLFIRMASEKTORTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(763, 482);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (FirmaKayit);
      this.Text = nameof (FirmaKayit);
      this.Load += new EventHandler(this.FirmaKayit_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.ilgiliNotTxt.Properties.EndInit();
      this.vergiNoTxt.Properties.EndInit();
      this.vergiDairesiTxt.Properties.EndInit();
      this.adresTxt.Properties.EndInit();
      this.cepTelefonTxt.Properties.EndInit();
      this.telefonTxt.Properties.EndInit();
      this.yetkiliTxt.Properties.EndInit();
      this.faaliyetAlaniTxt.Properties.EndInit();
      this.firmaAdi.Properties.EndInit();
      this.sektorAdi.Properties.EndInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).EndInit();
      this.bellDataSet.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
