// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.AracKayitFirmaEkle
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
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Sabitler
{
  public class AracKayitFirmaEkle : RibbonForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbon;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonStatusBar ribbonStatusBar;
    private BarButtonItem yeniEgitimEkleButton;
    private BarButtonItem yeniEgitimKaydetButton;
    private BarButtonItem egitimBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem kapatButton;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLFIRMASEKTORBindingSource;
    private TBLFIRMASEKTORTableAdapter tBLFIRMASEKTORTableAdapter;
    private LayoutControl layoutControl1;
    private SimpleButton simpleButton1;
    private MemoEdit IlgiliNotTxt;
    private TextEdit VergiNoTxt;
    private TextEdit VergiDairesiTxt;
    private TextEdit AdresTxt;
    private TextEdit CepTelefonTxt;
    private TextEdit TelefonTxt;
    private TextEdit YetkiliTxt;
    private TextEdit FaaliyetAlaniTxt;
    private TextEdit FirmaAdiTxt;
    private SearchLookUpEdit sektorLook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem15;
    private GridColumn gridColumn1;

    public AracKayitFirmaEkle() => this.InitializeComponent();

    private void EgitimDurumu_Load(object sender, EventArgs e) => this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet5.TBLFIRMASEKTOR);

    private void yenile() => this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet5.TBLFIRMASEKTOR);

    private void yeniEgitimKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLFIRMALAR.Add(new TBLFIRMALAR()
      {
        SEKTORID = new int?(Convert.ToInt32(this.sektorLook.EditValue)),
        FIRMAADI = this.FirmaAdiTxt.Text,
        FALIYETALANI = this.FaaliyetAlaniTxt.Text,
        YETKILISI = this.YetkiliTxt.Text,
        TELEFON = this.TelefonTxt.Text,
        CEPTELEFON = this.CepTelefonTxt.Text,
        FIRMAADRES = this.AdresTxt.Text,
        VERGIDAIRE = this.VergiDairesiTxt.Text,
        VERGINO = this.VergiNoTxt.Text,
        ILGILINOT = this.IlgiliNotTxt.Text
      });
      this.db.SaveChanges();
      this.listele();
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void labelControl1_Click(object sender, EventArgs e)
    {
    }

    private void listele()
    {
    }

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void yeniEgitimEkleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.sektorLook.EditValue = (object) null;
      this.FirmaAdiTxt.Text = (string) null;
      this.FaaliyetAlaniTxt.Text = (string) null;
      this.YetkiliTxt.Text = (string) null;
      this.TelefonTxt.Text = (string) null;
      this.CepTelefonTxt.Text = (string) null;
      this.AdresTxt.Text = (string) null;
      this.VergiDairesiTxt.Text = (string) null;
      this.VergiNoTxt.Text = (string) null;
      this.IlgiliNotTxt.Text = (string) null;
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new AracKayitFirmaEkle().ShowDialog();
      this.yenile();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracKayitFirmaEkle));
      this.ribbon = new RibbonControl();
      this.yeniEgitimEkleButton = new BarButtonItem();
      this.yeniEgitimKaydetButton = new BarButtonItem();
      this.egitimBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonStatusBar = new RibbonStatusBar();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.tBLFIRMASEKTORBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.tBLFIRMASEKTORTableAdapter = new TBLFIRMASEKTORTableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.simpleButton1 = new SimpleButton();
      this.IlgiliNotTxt = new MemoEdit();
      this.VergiNoTxt = new TextEdit();
      this.VergiDairesiTxt = new TextEdit();
      this.AdresTxt = new TextEdit();
      this.CepTelefonTxt = new TextEdit();
      this.TelefonTxt = new TextEdit();
      this.YetkiliTxt = new TextEdit();
      this.FaaliyetAlaniTxt = new TextEdit();
      this.FirmaAdiTxt = new TextEdit();
      this.sektorLook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
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
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.gridColumn1 = new GridColumn();
      this.ribbon.BeginInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.IlgiliNotTxt.Properties.BeginInit();
      this.VergiNoTxt.Properties.BeginInit();
      this.VergiDairesiTxt.Properties.BeginInit();
      this.AdresTxt.Properties.BeginInit();
      this.CepTelefonTxt.Properties.BeginInit();
      this.TelefonTxt.Properties.BeginInit();
      this.YetkiliTxt.Properties.BeginInit();
      this.FaaliyetAlaniTxt.Properties.BeginInit();
      this.FirmaAdiTxt.Properties.BeginInit();
      this.sektorLook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
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
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.SuspendLayout();
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new BarItem[7]
      {
        (BarItem) this.ribbon.ExpandCollapseItem,
        (BarItem) this.ribbon.SearchEditItem,
        (BarItem) this.yeniEgitimEkleButton,
        (BarItem) this.yeniEgitimKaydetButton,
        (BarItem) this.egitimBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.kapatButton
      });
      this.ribbon.Location = new Point(0, 0);
      this.ribbon.Margin = new Padding(3, 4, 3, 4);
      this.ribbon.MaxItemId = 9;
      this.ribbon.Name = "ribbon";
      this.ribbon.OptionsMenuMinWidth = 385;
      this.ribbon.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbon.Size = new Size(766, 193);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      this.yeniEgitimEkleButton.Caption = "Temizle";
      this.yeniEgitimEkleButton.Id = 1;
      this.yeniEgitimEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniEgitimEkleButton.ImageOptions.Image");
      this.yeniEgitimEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniEgitimEkleButton.ImageOptions.LargeImage");
      this.yeniEgitimEkleButton.LargeWidth = 100;
      this.yeniEgitimEkleButton.Name = "yeniEgitimEkleButton";
      this.yeniEgitimEkleButton.ItemClick += new ItemClickEventHandler(this.yeniEgitimEkleButton_ItemClick);
      this.yeniEgitimKaydetButton.Caption = "Kaydet";
      this.yeniEgitimKaydetButton.Id = 2;
      this.yeniEgitimKaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniEgitimKaydetButton.ImageOptions.Image");
      this.yeniEgitimKaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniEgitimKaydetButton.ImageOptions.LargeImage");
      this.yeniEgitimKaydetButton.LargeWidth = 100;
      this.yeniEgitimKaydetButton.Name = "yeniEgitimKaydetButton";
      this.yeniEgitimKaydetButton.ItemClick += new ItemClickEventHandler(this.yeniEgitimKaydetButton_ItemClick);
      this.egitimBulButton.Caption = "Kayit Bul";
      this.egitimBulButton.Id = 4;
      this.egitimBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("egitimBulButton.ImageOptions.Image");
      this.egitimBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("egitimBulButton.ImageOptions.LargeImage");
      this.egitimBulButton.LargeWidth = 100;
      this.egitimBulButton.Name = "egitimBulButton";
      this.barButtonItem6.Caption = "Kapat";
      this.barButtonItem6.Id = 6;
      this.barButtonItem6.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.Image");
      this.barButtonItem6.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.LargeImage");
      this.barButtonItem6.LargeWidth = 100;
      this.barButtonItem6.Name = "barButtonItem6";
      this.kapatButton.Alignment = BarItemLinkAlignment.Right;
      this.kapatButton.AllowDrawArrow = false;
      this.kapatButton.Caption = "Kapat";
      this.kapatButton.Id = 7;
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
      this.ribbonPage1.Text = "Araç Firma";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimEkleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimKaydetButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonStatusBar.Location = new Point(0, 619);
      this.ribbonStatusBar.Margin = new Padding(3, 4, 3, 4);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new Size(766, 28);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.Name = "barButtonItem5";
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.Text = "ribbonPageGroup5";
      this.tBLFIRMASEKTORBindingSource.DataMember = "TBLFIRMASEKTOR";
      this.tBLFIRMASEKTORBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLFIRMASEKTORTableAdapter.ClearBeforeFill = true;
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.IlgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.VergiNoTxt);
      this.layoutControl1.Controls.Add((Control) this.VergiDairesiTxt);
      this.layoutControl1.Controls.Add((Control) this.AdresTxt);
      this.layoutControl1.Controls.Add((Control) this.CepTelefonTxt);
      this.layoutControl1.Controls.Add((Control) this.TelefonTxt);
      this.layoutControl1.Controls.Add((Control) this.YetkiliTxt);
      this.layoutControl1.Controls.Add((Control) this.FaaliyetAlaniTxt);
      this.layoutControl1.Controls.Add((Control) this.FirmaAdiTxt);
      this.layoutControl1.Controls.Add((Control) this.sektorLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 193);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(766, 426);
      this.layoutControl1.TabIndex = 9;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl5.Location = new Point(385, 268);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(369, 28);
      this.layoutControl5.TabIndex = 18;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(369, 28);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl4.Location = new Point(385, 236);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(369, 28);
      this.layoutControl4.TabIndex = 17;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(369, 28);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(385, 172);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(369, 28);
      this.layoutControl3.TabIndex = 16;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(369, 28);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(385, 140);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(369, 28);
      this.layoutControl2.TabIndex = 15;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(369, 28);
      this.layoutControlGroup1.TextVisible = false;
      this.simpleButton1.ImageOptions.Image = (Image) Resources.add_16x1610;
      this.simpleButton1.Location = new Point(726, 12);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(28, 27);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 14;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.IlgiliNotTxt.Location = new Point(123, 300);
      this.IlgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.IlgiliNotTxt.Name = "IlgiliNotTxt";
      this.IlgiliNotTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.IlgiliNotTxt.Properties.Appearance.Options.UseFont = true;
      this.IlgiliNotTxt.Size = new Size(631, 64);
      this.IlgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.IlgiliNotTxt.TabIndex = 13;
      this.VergiNoTxt.Location = new Point(123, 268);
      this.VergiNoTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.VergiNoTxt.Name = "VergiNoTxt";
      this.VergiNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.VergiNoTxt.Properties.Appearance.Options.UseFont = true;
      this.VergiNoTxt.Size = new Size(258, 28);
      this.VergiNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.VergiNoTxt.TabIndex = 12;
      this.VergiDairesiTxt.Location = new Point(123, 236);
      this.VergiDairesiTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.VergiDairesiTxt.Name = "VergiDairesiTxt";
      this.VergiDairesiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.VergiDairesiTxt.Properties.Appearance.Options.UseFont = true;
      this.VergiDairesiTxt.Size = new Size(258, 28);
      this.VergiDairesiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.VergiDairesiTxt.TabIndex = 11;
      this.AdresTxt.Location = new Point(123, 204);
      this.AdresTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.AdresTxt.Name = "AdresTxt";
      this.AdresTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AdresTxt.Properties.Appearance.Options.UseFont = true;
      this.AdresTxt.Size = new Size(631, 28);
      this.AdresTxt.StyleController = (IStyleController) this.layoutControl1;
      this.AdresTxt.TabIndex = 10;
      this.CepTelefonTxt.Location = new Point(123, 172);
      this.CepTelefonTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.CepTelefonTxt.Name = "CepTelefonTxt";
      this.CepTelefonTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.CepTelefonTxt.Properties.Appearance.Options.UseFont = true;
      this.CepTelefonTxt.Size = new Size(258, 28);
      this.CepTelefonTxt.StyleController = (IStyleController) this.layoutControl1;
      this.CepTelefonTxt.TabIndex = 9;
      this.TelefonTxt.Location = new Point(123, 140);
      this.TelefonTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.TelefonTxt.Name = "TelefonTxt";
      this.TelefonTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TelefonTxt.Properties.Appearance.Options.UseFont = true;
      this.TelefonTxt.Size = new Size(258, 28);
      this.TelefonTxt.StyleController = (IStyleController) this.layoutControl1;
      this.TelefonTxt.TabIndex = 8;
      this.YetkiliTxt.Location = new Point(123, 108);
      this.YetkiliTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.YetkiliTxt.Name = "YetkiliTxt";
      this.YetkiliTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YetkiliTxt.Properties.Appearance.Options.UseFont = true;
      this.YetkiliTxt.Size = new Size(631, 28);
      this.YetkiliTxt.StyleController = (IStyleController) this.layoutControl1;
      this.YetkiliTxt.TabIndex = 7;
      this.FaaliyetAlaniTxt.Location = new Point(123, 76);
      this.FaaliyetAlaniTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.FaaliyetAlaniTxt.Name = "FaaliyetAlaniTxt";
      this.FaaliyetAlaniTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.FaaliyetAlaniTxt.Properties.Appearance.Options.UseFont = true;
      this.FaaliyetAlaniTxt.Size = new Size(631, 28);
      this.FaaliyetAlaniTxt.StyleController = (IStyleController) this.layoutControl1;
      this.FaaliyetAlaniTxt.TabIndex = 6;
      this.FirmaAdiTxt.Location = new Point(123, 44);
      this.FirmaAdiTxt.MenuManager = (IDXMenuManager) this.ribbon;
      this.FirmaAdiTxt.Name = "FirmaAdiTxt";
      this.FirmaAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.FirmaAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.FirmaAdiTxt.Size = new Size(631, 28);
      this.FirmaAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.FirmaAdiTxt.TabIndex = 5;
      this.sektorLook.EditValue = (object) "";
      this.sektorLook.Location = new Point(123, 12);
      this.sektorLook.MenuManager = (IDXMenuManager) this.ribbon;
      this.sektorLook.Name = "sektorLook";
      this.sektorLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.sektorLook.Properties.Appearance.Options.UseFont = true;
      this.sektorLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sektorLook.Properties.DataSource = (object) this.tBLFIRMASEKTORBindingSource;
      this.sektorLook.Properties.DisplayMember = "SEKTORADI";
      this.sektorLook.Properties.NullText = "";
      this.sektorLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.sektorLook.Properties.ValueMember = "ID";
      this.sektorLook.Size = new Size(599, 28);
      this.sektorLook.StyleController = (IStyleController) this.layoutControl1;
      this.sektorLook.TabIndex = 4;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[16]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(766, 426);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.sektorLook;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(714, 32);
      this.layoutControlItem1.Text = "Sektör Adı";
      this.layoutControlItem1.TextSize = new Size(108, 22);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 356);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(746, 50);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.FirmaAdiTxt;
      this.layoutControlItem2.Location = new Point(0, 32);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(746, 32);
      this.layoutControlItem2.Text = "Firma Adı";
      this.layoutControlItem2.TextSize = new Size(108, 22);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.FaaliyetAlaniTxt;
      this.layoutControlItem3.Location = new Point(0, 64);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(746, 32);
      this.layoutControlItem3.Text = "Faaliyet Alanı";
      this.layoutControlItem3.TextSize = new Size(108, 22);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.YetkiliTxt;
      this.layoutControlItem4.Location = new Point(0, 96);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(746, 32);
      this.layoutControlItem4.Text = "Yetkilisi";
      this.layoutControlItem4.TextSize = new Size(108, 22);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.TelefonTxt;
      this.layoutControlItem5.Location = new Point(0, 128);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(373, 32);
      this.layoutControlItem5.Text = "Telefon";
      this.layoutControlItem5.TextSize = new Size(108, 22);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.CepTelefonTxt;
      this.layoutControlItem6.Location = new Point(0, 160);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(373, 32);
      this.layoutControlItem6.Text = "Cep Telefon";
      this.layoutControlItem6.TextSize = new Size(108, 22);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.AdresTxt;
      this.layoutControlItem7.Location = new Point(0, 192);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(746, 32);
      this.layoutControlItem7.Text = "Adres";
      this.layoutControlItem7.TextSize = new Size(108, 22);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.VergiDairesiTxt;
      this.layoutControlItem8.Location = new Point(0, 224);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(373, 32);
      this.layoutControlItem8.Text = "Vergi Dairesi";
      this.layoutControlItem8.TextSize = new Size(108, 22);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.VergiNoTxt;
      this.layoutControlItem9.Location = new Point(0, 256);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(373, 32);
      this.layoutControlItem9.Text = "Vergi No";
      this.layoutControlItem9.TextSize = new Size(108, 22);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.IlgiliNotTxt;
      this.layoutControlItem10.Location = new Point(0, 288);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(746, 68);
      this.layoutControlItem10.Text = "İlgili Not";
      this.layoutControlItem10.TextSize = new Size(108, 22);
      this.layoutControlItem11.Control = (Control) this.simpleButton1;
      this.layoutControlItem11.Location = new Point(714, 0);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(32, 32);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.layoutControl2;
      this.layoutControlItem12.Location = new Point(373, 128);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(373, 32);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.layoutControlItem13.Control = (Control) this.layoutControl3;
      this.layoutControlItem13.Location = new Point(373, 160);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(373, 32);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem14.Control = (Control) this.layoutControl4;
      this.layoutControlItem14.Location = new Point(373, 224);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(373, 32);
      this.layoutControlItem14.TextSize = new Size(0, 0);
      this.layoutControlItem14.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.layoutControl5;
      this.layoutControlItem15.Location = new Point(373, 256);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(373, 32);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.gridColumn1.Caption = "Sektör Adı";
      this.gridColumn1.FieldName = "SEKTORADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(766, 647);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonStatusBar);
      this.Controls.Add((Control) this.ribbon);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (AracKayitFirmaEkle);
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Araç Firma Girişi";
      this.Load += new EventHandler(this.EgitimDurumu_Load);
      this.ribbon.EndInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.IlgiliNotTxt.Properties.EndInit();
      this.VergiNoTxt.Properties.EndInit();
      this.VergiDairesiTxt.Properties.EndInit();
      this.AdresTxt.Properties.EndInit();
      this.CepTelefonTxt.Properties.EndInit();
      this.TelefonTxt.Properties.EndInit();
      this.YetkiliTxt.Properties.EndInit();
      this.FaaliyetAlaniTxt.Properties.EndInit();
      this.FirmaAdiTxt.Properties.EndInit();
      this.sektorLook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
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
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
