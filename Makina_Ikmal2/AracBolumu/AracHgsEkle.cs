// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.AracHgsEkle
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
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class AracHgsEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem8;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private MemoEdit IlgılıNotText;
    private DateEdit IptalDate;
    private DateEdit GuncelDate;
    private DateEdit HgsDate;
    private TextEdit GuncelAracText;
    private TextEdit HgsEtiketText;
    private SearchLookUpEdit PlakaLook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup Root;
    private LayoutControlItem AracPlaka;
    private LayoutControlItem HgsEtiket;
    private LayoutControlItem GuncelArac;
    private LayoutControlItem hgs;
    private LayoutControlItem Guncel;
    private LayoutControlItem Iptal;
    private LayoutControlItem IlgiliNot;
    private GridColumn colPLAKA;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;

    public AracHgsEkle() => this.InitializeComponent();

    private void kayit()
    {
      TAHARACHGS entity = new TAHARACHGS();
      try
      {
        if (this.PlakaLook.Text != "")
          entity.ARACID = new int?(Convert.ToInt32(this.PlakaLook.EditValue));
        if (this.HgsDate.Text != "")
          entity.HGSTARIH = new DateTime?(Convert.ToDateTime(this.HgsDate.EditValue));
        if (this.HgsEtiketText.Text != "")
          entity.HGSETIKETNO = this.HgsEtiketText.Text;
        if (this.GuncelAracText.Text != "")
          entity.GUNCELARAC = this.GuncelAracText.Text;
        if (this.GuncelDate.Text != "")
          entity.GUNCELTARIH = new DateTime?(Convert.ToDateTime(this.GuncelDate.EditValue));
        if (this.IptalDate.Text != "")
          entity.IPTALTARIH = new DateTime?(Convert.ToDateTime(this.IptalDate.EditValue));
        if (this.IlgılıNotText.Text != "")
          entity.ILGILINOT = this.IlgılıNotText.Text;
        this.db.TAHARACHGS.Add(entity);
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.kayit();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.PlakaLook.EditValue = (object) null;
      this.HgsDate.EditValue = (object) null;
      this.HgsEtiketText.EditValue = (object) null;
      this.GuncelAracText.EditValue = (object) null;
      this.GuncelDate.EditValue = (object) null;
      this.IptalDate.EditValue = (object) null;
      this.IlgılıNotText.EditValue = (object) null;
    }

    private void AracHgsEkle_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracHgsEkle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.IlgılıNotText = new MemoEdit();
      this.IptalDate = new DateEdit();
      this.GuncelDate = new DateEdit();
      this.HgsDate = new DateEdit();
      this.GuncelAracText = new TextEdit();
      this.HgsEtiketText = new TextEdit();
      this.PlakaLook = new SearchLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.searchLookUpEdit1View = new GridView();
      this.colPLAKA = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.AracPlaka = new LayoutControlItem();
      this.HgsEtiket = new LayoutControlItem();
      this.GuncelArac = new LayoutControlItem();
      this.hgs = new LayoutControlItem();
      this.Guncel = new LayoutControlItem();
      this.Iptal = new LayoutControlItem();
      this.IlgiliNot = new LayoutControlItem();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.IlgılıNotText.Properties.BeginInit();
      this.IptalDate.Properties.CalendarTimeProperties.BeginInit();
      this.IptalDate.Properties.BeginInit();
      this.GuncelDate.Properties.CalendarTimeProperties.BeginInit();
      this.GuncelDate.Properties.BeginInit();
      this.HgsDate.Properties.CalendarTimeProperties.BeginInit();
      this.HgsDate.Properties.BeginInit();
      this.GuncelAracText.Properties.BeginInit();
      this.HgsEtiketText.Properties.BeginInit();
      this.PlakaLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.Root.BeginInit();
      this.AracPlaka.BeginInit();
      this.HgsEtiket.BeginInit();
      this.GuncelArac.BeginInit();
      this.hgs.BeginInit();
      this.Guncel.BeginInit();
      this.Iptal.BeginInit();
      this.IlgiliNot.BeginInit();
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
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 9;
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
      this.ribbonControl1.Size = new Size(666, 96);
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
      this.barButtonItem2.Caption = "Kaydet";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Enabled = false;
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.Caption = "Önizle";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.Caption = "Yazdır";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
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
      this.barButtonItem8.Caption = "Yeni";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.IlgılıNotText);
      this.layoutControl1.Controls.Add((Control) this.IptalDate);
      this.layoutControl1.Controls.Add((Control) this.GuncelDate);
      this.layoutControl1.Controls.Add((Control) this.HgsDate);
      this.layoutControl1.Controls.Add((Control) this.GuncelAracText);
      this.layoutControl1.Controls.Add((Control) this.HgsEtiketText);
      this.layoutControl1.Controls.Add((Control) this.PlakaLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(666, 290);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.IlgılıNotText.Location = new Point(134, 180);
      this.IlgılıNotText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.IlgılıNotText.Name = "IlgılıNotText";
      this.IlgılıNotText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.IlgılıNotText.Properties.Appearance.Options.UseFont = true;
      this.IlgılıNotText.Size = new Size(520, 98);
      this.IlgılıNotText.StyleController = (IStyleController) this.layoutControl1;
      this.IlgılıNotText.TabIndex = 11;
      this.IptalDate.EditValue = (object) null;
      this.IptalDate.Location = new Point(134, 152);
      this.IptalDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.IptalDate.Name = "IptalDate";
      this.IptalDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.IptalDate.Properties.Appearance.Options.UseFont = true;
      this.IptalDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IptalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IptalDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.IptalDate.Size = new Size(520, 24);
      this.IptalDate.StyleController = (IStyleController) this.layoutControl1;
      this.IptalDate.TabIndex = 10;
      this.GuncelDate.EditValue = (object) null;
      this.GuncelDate.Location = new Point(134, 124);
      this.GuncelDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GuncelDate.Name = "GuncelDate";
      this.GuncelDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GuncelDate.Properties.Appearance.Options.UseFont = true;
      this.GuncelDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.GuncelDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.GuncelDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.GuncelDate.Size = new Size(520, 24);
      this.GuncelDate.StyleController = (IStyleController) this.layoutControl1;
      this.GuncelDate.TabIndex = 9;
      this.HgsDate.EditValue = (object) null;
      this.HgsDate.Location = new Point(134, 40);
      this.HgsDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.HgsDate.Name = "HgsDate";
      this.HgsDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.HgsDate.Properties.Appearance.Options.UseFont = true;
      this.HgsDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.HgsDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.HgsDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.HgsDate.Size = new Size(520, 24);
      this.HgsDate.StyleController = (IStyleController) this.layoutControl1;
      this.HgsDate.TabIndex = 8;
      this.GuncelAracText.Location = new Point(134, 96);
      this.GuncelAracText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GuncelAracText.Name = "GuncelAracText";
      this.GuncelAracText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GuncelAracText.Properties.Appearance.Options.UseFont = true;
      this.GuncelAracText.Size = new Size(520, 24);
      this.GuncelAracText.StyleController = (IStyleController) this.layoutControl1;
      this.GuncelAracText.TabIndex = 7;
      this.HgsEtiketText.Location = new Point(134, 68);
      this.HgsEtiketText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.HgsEtiketText.Name = "HgsEtiketText";
      this.HgsEtiketText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.HgsEtiketText.Properties.Appearance.Options.UseFont = true;
      this.HgsEtiketText.Size = new Size(520, 24);
      this.HgsEtiketText.StyleController = (IStyleController) this.layoutControl1;
      this.HgsEtiketText.TabIndex = 6;
      this.PlakaLook.EditValue = (object) "";
      this.PlakaLook.Location = new Point(134, 12);
      this.PlakaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.PlakaLook.Name = "PlakaLook";
      this.PlakaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.PlakaLook.Properties.Appearance.Options.UseFont = true;
      this.PlakaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.PlakaLook.Properties.DataSource = (object) this.tBLARACLARBindingSource;
      this.PlakaLook.Properties.DisplayMember = "PLAKA";
      this.PlakaLook.Properties.NullText = "";
      this.PlakaLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.PlakaLook.Properties.ValueMember = "ID";
      this.PlakaLook.Size = new Size(520, 24);
      this.PlakaLook.StyleController = (IStyleController) this.layoutControl1;
      this.PlakaLook.TabIndex = 4;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.colPLAKA
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 0;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[7]
      {
        (BaseLayoutItem) this.AracPlaka,
        (BaseLayoutItem) this.HgsEtiket,
        (BaseLayoutItem) this.GuncelArac,
        (BaseLayoutItem) this.hgs,
        (BaseLayoutItem) this.Guncel,
        (BaseLayoutItem) this.Iptal,
        (BaseLayoutItem) this.IlgiliNot
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(666, 290);
      this.Root.TextVisible = false;
      this.AracPlaka.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AracPlaka.AppearanceItemCaption.Options.UseFont = true;
      this.AracPlaka.Control = (Control) this.PlakaLook;
      this.AracPlaka.Location = new Point(0, 0);
      this.AracPlaka.Name = "AracPlaka";
      this.AracPlaka.Size = new Size(646, 28);
      this.AracPlaka.Text = "Araç Plaka";
      this.AracPlaka.TextSize = new Size(119, 18);
      this.HgsEtiket.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.HgsEtiket.AppearanceItemCaption.Options.UseFont = true;
      this.HgsEtiket.Control = (Control) this.HgsEtiketText;
      this.HgsEtiket.Location = new Point(0, 56);
      this.HgsEtiket.Name = "HgsEtiket";
      this.HgsEtiket.Size = new Size(646, 28);
      this.HgsEtiket.Text = "HGS Etiket No";
      this.HgsEtiket.TextSize = new Size(119, 18);
      this.GuncelArac.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GuncelArac.AppearanceItemCaption.Options.UseFont = true;
      this.GuncelArac.Control = (Control) this.GuncelAracText;
      this.GuncelArac.Location = new Point(0, 84);
      this.GuncelArac.Name = "GuncelArac";
      this.GuncelArac.Size = new Size(646, 28);
      this.GuncelArac.Text = "Güncellenen Araç";
      this.GuncelArac.TextSize = new Size(119, 18);
      this.hgs.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.hgs.AppearanceItemCaption.Options.UseFont = true;
      this.hgs.Control = (Control) this.HgsDate;
      this.hgs.Location = new Point(0, 28);
      this.hgs.Name = "hgs";
      this.hgs.Size = new Size(646, 28);
      this.hgs.Text = "HGS Tarih";
      this.hgs.TextSize = new Size(119, 18);
      this.Guncel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Guncel.AppearanceItemCaption.Options.UseFont = true;
      this.Guncel.Control = (Control) this.GuncelDate;
      this.Guncel.Location = new Point(0, 112);
      this.Guncel.Name = "Guncel";
      this.Guncel.Size = new Size(646, 28);
      this.Guncel.Text = "Güncellenen Tarih";
      this.Guncel.TextSize = new Size(119, 18);
      this.Iptal.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Iptal.AppearanceItemCaption.Options.UseFont = true;
      this.Iptal.Control = (Control) this.IptalDate;
      this.Iptal.Location = new Point(0, 140);
      this.Iptal.Name = "Iptal";
      this.Iptal.Size = new Size(646, 28);
      this.Iptal.Text = "İptal Tarihi";
      this.Iptal.TextSize = new Size(119, 18);
      this.IlgiliNot.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.IlgiliNot.AppearanceItemCaption.Options.UseFont = true;
      this.IlgiliNot.Control = (Control) this.IlgılıNotText;
      this.IlgiliNot.Location = new Point(0, 168);
      this.IlgiliNot.Name = "IlgiliNot";
      this.IlgiliNot.Size = new Size(646, 102);
      this.IlgiliNot.Text = "İlgili Not";
      this.IlgiliNot.TextSize = new Size(119, 18);
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(666, 386);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (AracHgsEkle);
      this.Text = nameof (AracHgsEkle);
      this.Load += new EventHandler(this.AracHgsEkle_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.IlgılıNotText.Properties.EndInit();
      this.IptalDate.Properties.CalendarTimeProperties.EndInit();
      this.IptalDate.Properties.EndInit();
      this.GuncelDate.Properties.CalendarTimeProperties.EndInit();
      this.GuncelDate.Properties.EndInit();
      this.HgsDate.Properties.CalendarTimeProperties.EndInit();
      this.HgsDate.Properties.EndInit();
      this.GuncelAracText.Properties.EndInit();
      this.HgsEtiketText.Properties.EndInit();
      this.PlakaLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.Root.EndInit();
      this.AracPlaka.EndInit();
      this.HgsEtiket.EndInit();
      this.GuncelArac.EndInit();
      this.hgs.EndInit();
      this.Guncel.EndInit();
      this.Iptal.EndInit();
      this.IlgiliNot.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
