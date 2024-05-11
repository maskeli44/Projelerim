// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.kdvTanim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSetTableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class kdvTanim : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarButtonItem kayitBulButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private ComboBoxEdit comboBoxEdit1;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private TextEdit comboBoxEdit2;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControl layoutControl6;
    private LayoutControlGroup layoutControlGroup5;
    private LayoutControlItem layoutControlItem8;
    private LayoutControl layoutControl7;
    private LayoutControlGroup layoutControlGroup6;
    private LayoutControlItem layoutControlItem9;
    private bellDataSet bellDataSet;
    private BindingSource tBLMALZKDVBindingSource;
    private TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private GridColumn colKDVGRUP;
    private GridColumn colKDVORAN;

    public kdvTanim() => this.InitializeComponent();

    private void kdvTanim_Load(object sender, EventArgs e) => this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet.TBLMALZKDV);

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (kdvTanim));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.kayitBulButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.layoutControl7 = new LayoutControl();
      this.layoutControlGroup6 = new LayoutControlGroup();
      this.layoutControl6 = new LayoutControl();
      this.layoutControlGroup5 = new LayoutControlGroup();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.comboBoxEdit1 = new ComboBoxEdit();
      this.gridControl1 = new GridControl();
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.bellDataSet = new bellDataSet();
      this.gridView1 = new GridView();
      this.colKDVGRUP = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.comboBoxEdit2 = new TextEdit();
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
      this.tBLMALZKDVTableAdapter = new TBLMALZKDVTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl7.BeginInit();
      this.layoutControlGroup6.BeginInit();
      this.layoutControl6.BeginInit();
      this.layoutControlGroup5.BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.comboBoxEdit1.Properties.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.bellDataSet.BeginInit();
      this.gridView1.BeginInit();
      this.comboBoxEdit2.Properties.BeginInit();
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
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[10]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.kayitBulButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 12;
      this.ribbonControl1.Name = "ribbonControl1";
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
      this.ribbonControl1.Size = new Size(717, 118);
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
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.kayitBulButton.Caption = "Kayıt Bul";
      this.kayitBulButton.Id = 11;
      this.kayitBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kayitBulButton.ImageOptions.Image");
      this.kayitBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kayitBulButton.ImageOptions.LargeImage");
      this.kayitBulButton.LargeWidth = 100;
      this.kayitBulButton.Name = "kayitBulButton";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.layoutControl7);
      this.layoutControl1.Controls.Add((Control) this.layoutControl6);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.comboBoxEdit1);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Controls.Add((Control) this.comboBoxEdit2);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(717, 581);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl7.Location = new Point(12, 12);
      this.layoutControl7.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl7.Name = "layoutControl7";
      this.layoutControl7.Root = this.layoutControlGroup6;
      this.layoutControl7.Size = new Size(693, 37);
      this.layoutControl7.TabIndex = 12;
      this.layoutControl7.Text = "layoutControl7";
      this.layoutControlGroup6.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup6.GroupBordersVisible = false;
      this.layoutControlGroup6.Name = "layoutControlGroup6";
      this.layoutControlGroup6.Size = new Size(693, 37);
      this.layoutControlGroup6.TextVisible = false;
      this.layoutControl6.Location = new Point(12, 131);
      this.layoutControl6.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl6.Name = "layoutControl6";
      this.layoutControl6.Root = this.layoutControlGroup5;
      this.layoutControl6.Size = new Size(693, 28);
      this.layoutControl6.TabIndex = 11;
      this.layoutControl6.Text = "layoutControl6";
      this.layoutControlGroup5.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup5.GroupBordersVisible = false;
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new Size(693, 28);
      this.layoutControlGroup5.TextVisible = false;
      this.layoutControl5.Location = new Point(489, 90);
      this.layoutControl5.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(216, 37);
      this.layoutControl5.TabIndex = 10;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(216, 37);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl4.Location = new Point(12, 90);
      this.layoutControl4.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(205, 37);
      this.layoutControl4.TabIndex = 9;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(205, 37);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(489, 53);
      this.layoutControl3.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(216, 33);
      this.layoutControl3.TabIndex = 7;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "Root";
      this.layoutControlGroup2.Size = new Size(216, 33);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(12, 53);
      this.layoutControl2.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(205, 33);
      this.layoutControl2.TabIndex = 6;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(205, 33);
      this.layoutControlGroup1.TextVisible = false;
      this.comboBoxEdit1.Location = new Point(303, 53);
      this.comboBoxEdit1.Margin = new Padding(3, 4, 3, 4);
      this.comboBoxEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.comboBoxEdit1.Name = "comboBoxEdit1";
      this.comboBoxEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
      this.comboBoxEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.comboBoxEdit1.Properties.Items.AddRange(new object[4]
      {
        (object) "1. Grup",
        (object) "2. Grup",
        (object) "3. Grup",
        (object) "4. Grup"
      });
      this.comboBoxEdit1.Size = new Size(182, 30);
      this.comboBoxEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.comboBoxEdit1.TabIndex = 5;
      this.gridControl1.DataSource = (object) this.tBLMALZKDVBindingSource;
      this.gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(12, 163);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(693, 406);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet;
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.ColumnPanelRowHeight = 37;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colKDVGRUP,
        this.colKDVORAN
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colKDVGRUP.AppearanceCell.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colKDVGRUP.AppearanceCell.Options.UseFont = true;
      this.colKDVGRUP.AppearanceHeader.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colKDVGRUP.AppearanceHeader.Options.UseFont = true;
      this.colKDVGRUP.Caption = "Kdv Grup";
      this.colKDVGRUP.FieldName = "KDVGRUP";
      this.colKDVGRUP.MinWidth = 23;
      this.colKDVGRUP.Name = "colKDVGRUP";
      this.colKDVGRUP.Visible = true;
      this.colKDVGRUP.VisibleIndex = 0;
      this.colKDVGRUP.Width = 510;
      this.colKDVORAN.AppearanceCell.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colKDVORAN.AppearanceCell.Options.UseFont = true;
      this.colKDVORAN.AppearanceHeader.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colKDVORAN.AppearanceHeader.Options.UseFont = true;
      this.colKDVORAN.Caption = "Kdv Oranı";
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.MinWidth = 23;
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 1;
      this.colKDVORAN.Width = 150;
      this.comboBoxEdit2.Location = new Point(303, 90);
      this.comboBoxEdit2.Margin = new Padding(3, 4, 3, 4);
      this.comboBoxEdit2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.comboBoxEdit2.Name = "comboBoxEdit2";
      this.comboBoxEdit2.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
      this.comboBoxEdit2.Properties.Mask.EditMask = "p";
      this.comboBoxEdit2.Properties.Mask.MaskType = MaskType.Numeric;
      this.comboBoxEdit2.Size = new Size(182, 30);
      this.comboBoxEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.comboBoxEdit2.TabIndex = 8;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[9]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(717, 581);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 151);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(697, 410);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.comboBoxEdit1;
      this.layoutControlItem2.Location = new Point(209, 41);
      this.layoutControlItem2.MaxSize = new Size(268, 37);
      this.layoutControlItem2.MinSize = new Size(268, 37);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(268, 37);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Kdv Grup";
      this.layoutControlItem2.TextSize = new Size(79, 24);
      this.layoutControlItem3.Control = (Control) this.layoutControl2;
      this.layoutControlItem3.Location = new Point(0, 41);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(209, 37);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.Control = (Control) this.layoutControl3;
      this.layoutControlItem4.Location = new Point(477, 41);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(220, 37);
      this.layoutControlItem4.TextSize = new Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.comboBoxEdit2;
      this.layoutControlItem5.Location = new Point(209, 78);
      this.layoutControlItem5.MaxSize = new Size(268, 41);
      this.layoutControlItem5.MinSize = new Size(268, 41);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(268, 41);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Kdv Oran";
      this.layoutControlItem5.TextSize = new Size(79, 24);
      this.layoutControlItem6.Control = (Control) this.layoutControl4;
      this.layoutControlItem6.Location = new Point(0, 78);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(209, 41);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem7.Control = (Control) this.layoutControl5;
      this.layoutControlItem7.Location = new Point(477, 78);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(220, 41);
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.layoutControlItem8.Control = (Control) this.layoutControl6;
      this.layoutControlItem8.Location = new Point(0, 119);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(697, 32);
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.layoutControl7;
      this.layoutControlItem9.Location = new Point(0, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(697, 41);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(717, 699);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (kdvTanim);
      this.Text = nameof (kdvTanim);
      this.Load += new EventHandler(this.kdvTanim_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl7.EndInit();
      this.layoutControlGroup6.EndInit();
      this.layoutControl6.EndInit();
      this.layoutControlGroup5.EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.comboBoxEdit1.Properties.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.bellDataSet.EndInit();
      this.gridView1.EndInit();
      this.comboBoxEdit2.Properties.EndInit();
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
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
