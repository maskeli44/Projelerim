// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.hizmetTanimlari
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
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.hizmettanımlarıTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class hizmetTanimlari : XtraForm
  {
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
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem5;
    private BarEditItem barEditItem3;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup t;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private LayoutControl layoutControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private hizmettanımları hizmettanımları;
    private BindingSource hizmetTanimBindingSource;
    private HizmetTanimTableAdapter hizmetTanimTableAdapter;
    private GridColumn colKOD;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private GridColumn colKALAN;
    private GridColumn colKayıtTip;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public hizmetTanimlari() => this.InitializeComponent();

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      HizmetKayitlari hizmetKayitlari = new HizmetKayitlari();
      hizmetKayitlari.gizle();
      int num = (int) hizmetKayitlari.ShowDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      HizmetKayitlari hizmetKayitlari = new HizmetKayitlari();
      hizmetKayitlari.gizle();
      int num = (int) hizmetKayitlari.ShowDialog();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      HizmetKayitlari hizmetKayitlari = new HizmetKayitlari();
      hizmetKayitlari.gizle();
      int num = (int) hizmetKayitlari.ShowDialog();
    }

    private void hizmetTanimlari_Load(object sender, EventArgs e) => this.hizmetTanimTableAdapter.Fill(this.hizmettanımları.HizmetTanim);

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (hizmetTanimlari));
      SuperToolTip superToolTip = new SuperToolTip();
      ToolTipItem toolTipItem = new ToolTipItem();
      GridLevelNode gridLevelNode = new GridLevelNode();
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
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.t = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.gridControl1 = new GridControl();
      this.hizmetTanimBindingSource = new BindingSource(this.components);
      this.hizmettanımları = new hizmettanımları();
      this.gridView1 = new GridView();
      this.colKOD = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colKALAN = new GridColumn();
      this.colKayıtTip = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.hizmetTanimTableAdapter = new HizmetTanimTableAdapter();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonControl1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.hizmetTanimBindingSource).BeginInit();
      this.hizmettanımları.BeginInit();
      this.gridView1.BeginInit();
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
      this.ribbonControl1.Items.AddRange(new BarItem[19]
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
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 24;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(1211, 100);
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
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 13;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.RibbonStyle = RibbonItemStyles.Large;
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
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
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
      this.barEditItem3.Caption = "Depo Seç";
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 21;
      this.barEditItem3.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem3.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemTextEdit1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTextEdit1.NullText = "Kayit Bul...";
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1211, 629);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.gridControl1.DataSource = (object) this.hizmetTanimBindingSource;
      gridLevelNode.RelationName = "Level1";
      this.gridControl1.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
      this.gridControl1.Location = new Point(11, 10);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1189, 609);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.hizmetTanimBindingSource.DataMember = "HizmetTanim";
      this.hizmetTanimBindingSource.DataSource = (object) this.hizmettanımları;
      this.hizmettanımları.DataSetName = "hizmettanımları";
      this.hizmettanımları.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colKOD,
        this.colMALZEMEADI,
        this.colBIRIMADI,
        this.colKALAN,
        this.colKayıtTip
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 21;
      this.colKOD.Name = "colKOD";
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 81;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 21;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 1;
      this.colMALZEMEADI.Width = 81;
      this.colBIRIMADI.Caption = "Birim";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 21;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 2;
      this.colBIRIMADI.Width = 81;
      this.colKALAN.Caption = "Miktar";
      this.colKALAN.FieldName = "KALAN";
      this.colKALAN.MinWidth = 21;
      this.colKALAN.Name = "colKALAN";
      this.colKALAN.Visible = true;
      this.colKALAN.VisibleIndex = 3;
      this.colKALAN.Width = 81;
      this.colKayıtTip.Caption = "Kayıt Tipi";
      this.colKayıtTip.FieldName = "KayıtTip";
      this.colKayıtTip.MinWidth = 21;
      this.colKayıtTip.Name = "colKayıtTip";
      this.colKayıtTip.Visible = true;
      this.colKayıtTip.VisibleIndex = 4;
      this.colKayıtTip.Width = 81;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1211, 629);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1193, 613);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.hizmetTanimTableAdapter.ClearBeforeFill = true;
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 23;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1211, 729);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (hizmetTanimlari);
      this.Text = nameof (hizmetTanimlari);
      this.Load += new EventHandler(this.hizmetTanimlari_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.hizmetTanimBindingSource).EndInit();
      this.hizmettanımları.EndInit();
      this.gridView1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
