// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Akaryakit.Hakedis.HakedisListe
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
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Makina_Ikmal.Akaryakit.Hakedis
{
  public class HakedisListe : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem düzenleButton;
    private BarButtonItem silButton;
    private BarButtonItem yenileButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem1;
    private BarButtonItem yeniButton;
    private BarButtonItem excelButton;
    private BarEditItem barEditItem2;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup3;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private BarEditItem barEditItem3;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private TabPane tabPane1;
    private TabNavigationPage tabNavigationPage1;
    private TabNavigationPage tabNavigationPage2;
    private GridControl gridControl1;
    private GridView gridView1;
    private GridColumn gridColumn1;
    private TabNavigationPage tabNavigationPage3;
    private TabNavigationPage tabNavigationPage4;
    private PrintDialog printDialog1;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private GridColumn gridColumn8;
    private GridColumn gridColumn9;
    private GridColumn gridColumn10;
    private GridColumn gridColumn11;
    private GridColumn gridColumn12;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private GridControl gridControl4;
    private GridView gridView4;
    private GridColumn gridColumn13;
    private GridColumn gridColumn14;
    private GridColumn gridColumn15;
    private GridColumn gridColumn20;
    private GridControl gridControl3;
    private GridView gridView3;
    private GridColumn gridColumn16;
    private GridColumn gridColumn19;
    private GridColumn gridColumn17;
    private GridColumn gridColumn18;
    private LabelControl labelControl2;
    private LabelControl labelControl1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;

    public HakedisListe() => this.InitializeComponent();

    private void HakedisListe_Load(object sender, EventArgs e)
    {
    }

    public void Yenile() => this.gridControl1.DataSource = (object) this.db.HAKEDISAKARYAKIT.ToList<HAKEDISAKARYAKIT>();

    private void yeniButton_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HakedisListe));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.düzenleButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.yenileButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.yeniButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tabPane1 = new TabPane();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.tabNavigationPage4 = new TabNavigationPage();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.printDialog1 = new PrintDialog();
      this.layoutControl1 = new LayoutControl();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.gridView2 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.gridColumn10 = new GridColumn();
      this.gridColumn11 = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridControl2 = new GridControl();
      this.gridView3 = new GridView();
      this.gridColumn16 = new GridColumn();
      this.gridColumn19 = new GridColumn();
      this.gridColumn17 = new GridColumn();
      this.gridColumn18 = new GridColumn();
      this.gridControl3 = new GridControl();
      this.gridView4 = new GridView();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.gridColumn15 = new GridColumn();
      this.gridColumn20 = new GridColumn();
      this.gridControl4 = new GridControl();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.labelControl1 = new LabelControl();
      this.layoutControlItem4 = new LayoutControlItem();
      this.labelControl2 = new LabelControl();
      this.layoutControlItem5 = new LayoutControlItem();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.tabNavigationPage1.SuspendLayout();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.gridView2.BeginInit();
      this.gridControl2.BeginInit();
      this.gridView3.BeginInit();
      this.gridControl3.BeginInit();
      this.gridView4.BeginInit();
      this.gridControl4.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
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
        (BarItem) this.düzenleButton,
        (BarItem) this.silButton,
        (BarItem) this.yenileButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1,
        (BarItem) this.yeniButton,
        (BarItem) this.excelButton,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 15;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(1327, 100);
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
      this.düzenleButton.Caption = "Düzenle";
      this.düzenleButton.Id = 2;
      this.düzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.Image");
      this.düzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.LargeImage");
      this.düzenleButton.LargeWidth = 100;
      this.düzenleButton.Name = "düzenleButton";
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
      this.yenileButton.Caption = "Yenile";
      this.yenileButton.Id = 5;
      this.yenileButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.Image");
      this.yenileButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.LargeImage");
      this.yenileButton.LargeWidth = 100;
      this.yenileButton.Name = "yenileButton";
      this.yenileButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.yeniButton.Caption = "Yeni";
      this.yeniButton.Id = 9;
      this.yeniButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.Image");
      this.yeniButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.LargeImage");
      this.yeniButton.LargeWidth = 100;
      this.yeniButton.Name = "yeniButton";
      this.yeniButton.ItemClick += new ItemClickEventHandler(this.yeniButton_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 11;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 13;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 14;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem3);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.düzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage4);
      this.tabPane1.Location = new Point(12, 12);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.Pages.AddRange(new NavigationPageBase[4]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3,
        (NavigationPageBase) this.tabNavigationPage4
      });
      this.tabPane1.RegularSize = new Size(1119, 465);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1119, 465);
      this.tabPane1.TabIndex = 4;
      this.tabNavigationPage1.Caption = "Yapılan İşler Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1119, 436);
      this.tabNavigationPage2.Caption = "Hakediş Özeti";
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1119, 436);
      this.tabNavigationPage3.Caption = "Liste";
      this.tabNavigationPage3.Controls.Add((Control) this.layoutControl2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1119, 436);
      this.tabNavigationPage4.Caption = "Teminat Takip Tablosu";
      this.tabNavigationPage4.Name = "tabNavigationPage4";
      this.tabNavigationPage4.Size = new Size(1119, 436);
      this.gridControl1.Dock = DockStyle.Left;
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(184, 489);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.AppearanceHeader.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn1.AppearanceHeader.Options.UseFont = true;
      this.gridColumn1.Caption = "Hak Edişler";
      this.gridColumn1.FieldName = "HAKEDISAD";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.printDialog1.UseEXDialog = true;
      this.layoutControl1.Controls.Add((Control) this.tabPane1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(184, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1143, 489);
      this.layoutControl1.TabIndex = 7;
      this.layoutControl1.Text = "layoutControl1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1143, 489);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.tabPane1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1123, 469);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.gridView2.Columns.AddRange(new GridColumn[11]
      {
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.gridColumn8,
        this.gridColumn9,
        this.gridColumn10,
        this.gridColumn11,
        this.gridColumn12
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.GroupSummary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridGroupSummaryItem(SummaryItemType.Sum, "", this.gridColumn7, "")
      });
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsMenu.ShowFooterItem = true;
      this.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "ID";
      this.gridColumn2.FieldName = "ID";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn3.Caption = "Sıra No";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 52;
      this.gridColumn4.Caption = "İşin Tanımı";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 1;
      this.gridColumn4.Width = 126;
      this.gridColumn5.Caption = "Birimi";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 2;
      this.gridColumn5.Width = 53;
      this.gridColumn6.Caption = "Teklif Birim Fiyat Tl";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 3;
      this.gridColumn6.Width = 136;
      this.gridColumn7.Caption = "Toplam İmalat İhzarat Miktarı";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 4;
      this.gridColumn7.Width = 136;
      this.gridColumn8.Caption = "Bir Önceki Hakediş İmalat İhzarat Miktarı( L t)\n";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 5;
      this.gridColumn8.Width = 136;
      this.gridColumn9.Caption = "Bu Hakediş İmalat İhzarat Miktarı(  Lt)";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 6;
      this.gridColumn9.Width = 136;
      this.gridColumn10.Caption = "Toplam İmalat İhzarat Tutarı  ";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "", "Toplam={0:0.##} TL")
      });
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 7;
      this.gridColumn10.Width = 136;
      this.gridColumn11.Caption = "Bir Önceki Hakediş Tutarı";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "", "Toplam={0:0.##} TL")
      });
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 8;
      this.gridColumn11.Width = 88;
      this.gridColumn12.Caption = "Bu Hakediş Tutarı";
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "", "Toplam={0:0.##} TL")
      });
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 9;
      this.gridColumn12.Width = 95;
      this.gridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1119, 432);
      this.gridControl2.TabIndex = 0;
      this.gridControl2.UseEmbeddedNavigator = true;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridView3.Columns.AddRange(new GridColumn[4]
      {
        this.gridColumn16,
        this.gridColumn19,
        this.gridColumn17,
        this.gridColumn18
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ShowFooter = true;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn16.Caption = "gridColumn16";
      this.gridColumn16.Name = "gridColumn16";
      this.gridColumn19.Caption = "S. N.";
      this.gridColumn19.Name = "gridColumn19";
      this.gridColumn19.Visible = true;
      this.gridColumn19.VisibleIndex = 0;
      this.gridColumn19.Width = 54;
      this.gridColumn17.Caption = "Tarihi";
      this.gridColumn17.Name = "gridColumn17";
      this.gridColumn17.Visible = true;
      this.gridColumn17.VisibleIndex = 1;
      this.gridColumn17.Width = 239;
      this.gridColumn18.Caption = "Miktarı(LT)";
      this.gridColumn18.Name = "gridColumn18";
      this.gridColumn18.Visible = true;
      this.gridColumn18.VisibleIndex = 2;
      this.gridColumn18.Width = 242;
      this.gridControl3.Location = new Point(549, 29);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.Size = new Size(558, 395);
      this.gridControl3.TabIndex = 0;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.gridView4.Columns.AddRange(new GridColumn[4]
      {
        this.gridColumn13,
        this.gridColumn14,
        this.gridColumn15,
        this.gridColumn20
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn13.Caption = "gridColumn13";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn14.Caption = "S. N.";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 0;
      this.gridColumn15.Caption = "Tarihi";
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 1;
      this.gridColumn20.Caption = "Miktarı(LT)";
      this.gridColumn20.Name = "gridColumn20";
      this.gridColumn20.Visible = true;
      this.gridColumn20.VisibleIndex = 2;
      this.gridControl4.Location = new Point(12, 29);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl4.Name = "gridControl4";
      this.gridControl4.Size = new Size(533, 395);
      this.gridControl4.TabIndex = 1;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.layoutControl2.Controls.Add((Control) this.labelControl2);
      this.layoutControl2.Controls.Add((Control) this.labelControl1);
      this.layoutControl2.Controls.Add((Control) this.gridControl3);
      this.layoutControl2.Controls.Add((Control) this.gridControl4);
      this.layoutControl2.Dock = DockStyle.Fill;
      this.layoutControl2.Location = new Point(0, 0);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 280, 650, 400));
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(1119, 436);
      this.layoutControl2.TabIndex = 2;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5
      });
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new Size(1119, 436);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.gridControl4;
      this.layoutControlItem2.Location = new Point(0, 17);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(537, 399);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.gridControl3;
      this.layoutControlItem3.Location = new Point(537, 17);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(562, 399);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(12, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(533, 13);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl2;
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "Motorin";
      this.layoutControlItem4.Control = (Control) this.labelControl1;
      this.layoutControlItem4.Location = new Point(0, 0);
      this.layoutControlItem4.MinSize = new Size(67, 17);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(537, 17);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(549, 12);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(558, 13);
      this.labelControl2.StyleController = (IStyleController) this.layoutControl2;
      this.labelControl2.TabIndex = 5;
      this.labelControl2.Text = "Benzin";
      this.layoutControlItem5.Control = (Control) this.labelControl2;
      this.layoutControlItem5.Location = new Point(537, 0);
      this.layoutControlItem5.MinSize = new Size(67, 17);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(562, 17);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1327, 589);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (HakedisListe);
      this.Text = nameof (HakedisListe);
      this.Load += new EventHandler(this.HakedisListe_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.tabNavigationPage1.ResumeLayout(false);
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.gridView2.EndInit();
      this.gridControl2.EndInit();
      this.gridView3.EndInit();
      this.gridControl3.EndInit();
      this.gridView4.EndInit();
      this.gridControl4.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
