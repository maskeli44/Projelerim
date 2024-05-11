// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.TrafikCezaKaydiEkle
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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class TrafikCezaKaydiEkle : XtraForm
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
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private MemoEdit ilgiliNotTxt;
    private TextEdit cezaTutariTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem13;
    private DateEdit kayitTarihiDate;
    private TextEdit fisNoTxt;
    private DateEdit cezaDate;
    private TimeEdit cezaTime;
    private TextEdit cezaAciklamaTxt;
    private LayoutControlItem layoutControlItem2;
    private ComboBoxEdit odemeDurumuCombo;
    private LayoutControlItem layoutControlItem3;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private SearchLookUpEdit plakaLook;
    private GridView searchLookUpEdit1View;
    private GridColumn gridColumn1;

    public TrafikCezaKaydiEkle() => this.InitializeComponent();

    private void AracZimmetKaydi_Load(object sender, EventArgs e)
    {
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
      this.kayitTarihiDate.EditValue = (object) DateTime.Now;
    }

    private void kayit()
    {
      TBLARACTRFCEZA entity = new TBLARACTRFCEZA();
      try
      {
        if (this.kayitTarihiDate.Text != "")
          entity.KAYITTARIHI = new DateTime?(Convert.ToDateTime(this.kayitTarihiDate.EditValue));
        if (this.plakaLook.Text != "")
          entity.ARACID = new int?(Convert.ToInt32(this.plakaLook.EditValue));
        if (this.fisNoTxt.Text != "")
          entity.FISNO = this.fisNoTxt.Text;
        if (this.cezaDate.Text != "")
          entity.CEZATARIHI = new DateTime?(Convert.ToDateTime(this.cezaDate.EditValue));
        if (this.cezaTime.Text != "")
          entity.CEZASAATI = new DateTime?(Convert.ToDateTime(this.cezaTime.EditValue));
        if (this.cezaAciklamaTxt.Text != "")
          entity.CEZAACIKLAMA = this.cezaAciklamaTxt.Text;
        if (this.cezaTutariTxt.Text != "")
          entity.CEZATUTARI = new Decimal?(Convert.ToDecimal(this.cezaTutariTxt.EditValue));
        if (this.odemeDurumuCombo.Text != "")
          entity.ODEMEDURUM = this.odemeDurumuCombo.Text;
        if (this.ilgiliNotTxt.Text != "")
          entity.ILGILINOT = this.ilgiliNotTxt.Text;
        if (this.db.TBLARACTRFCEZA.Where<TBLARACTRFCEZA>((Expression<System.Func<TBLARACTRFCEZA, bool>>) (hd => hd.FISNO == this.fisNoTxt.Text)).Count<TBLARACTRFCEZA>() > 0)
        {
          int num1 = (int) MessageBox.Show("Aynı fiş numarası tekrardan kayıt edilemez");
        }
        else
        {
          this.db.TBLARACTRFCEZA.Add(entity);
          this.db.SaveChanges();
          int num2 = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.kayit();
      LogEkle.Logs("Ekleme Yapti");
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.kayitTarihiDate.EditValue = (object) null;
      this.plakaLook.EditValue = (object) null;
      this.fisNoTxt.EditValue = (object) null;
      this.cezaDate.EditValue = (object) null;
      this.cezaTime.EditValue = (object) null;
      this.cezaTutariTxt.EditValue = (object) null;
      this.odemeDurumuCombo.EditValue = (object) null;
      this.ilgiliNotTxt.EditValue = (object) null;
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLARACTRFCEZA.Remove(this.db.TBLARACTRFCEZA.FirstOrDefault<TBLARACTRFCEZA>((Expression<System.Func<TBLARACTRFCEZA, bool>>) (x => x.ID == YetkiClass.secim_id)));
      this.db.SaveChanges();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TrafikCezaKaydiEkle));
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
      this.cezaTime = new TimeEdit();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.ilgiliNotTxt = new MemoEdit();
      this.cezaTutariTxt = new TextEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.kayitTarihiDate = new DateEdit();
      this.fisNoTxt = new TextEdit();
      this.cezaDate = new DateEdit();
      this.cezaAciklamaTxt = new TextEdit();
      this.odemeDurumuCombo = new ComboBoxEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.plakaLook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.cezaTime.Properties.BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.ilgiliNotTxt.Properties.BeginInit();
      this.cezaTutariTxt.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.kayitTarihiDate.Properties.CalendarTimeProperties.BeginInit();
      this.kayitTarihiDate.Properties.BeginInit();
      this.fisNoTxt.Properties.BeginInit();
      this.cezaDate.Properties.CalendarTimeProperties.BeginInit();
      this.cezaDate.Properties.BeginInit();
      this.cezaAciklamaTxt.Properties.BeginInit();
      this.odemeDurumuCombo.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.plakaLook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
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
      this.ribbonControl1.Size = new Size(939, 100);
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
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
      this.layoutControl1.Controls.Add((Control) this.cezaTime);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.ilgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.cezaTutariTxt);
      this.layoutControl1.Controls.Add((Control) this.kayitTarihiDate);
      this.layoutControl1.Controls.Add((Control) this.fisNoTxt);
      this.layoutControl1.Controls.Add((Control) this.cezaDate);
      this.layoutControl1.Controls.Add((Control) this.cezaAciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.odemeDurumuCombo);
      this.layoutControl1.Controls.Add((Control) this.plakaLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(939, 439);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.cezaTime.EditValue = (object) new DateTime(2021, 12, 24, 0, 0, 0, 0);
      this.cezaTime.Location = new Point(534, 99);
      this.cezaTime.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cezaTime.Name = "cezaTime";
      this.cezaTime.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cezaTime.Properties.Appearance.Options.UseFont = true;
      this.cezaTime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cezaTime.Properties.Mask.EditMask = "t";
      this.cezaTime.Size = new Size(178, 24);
      this.cezaTime.StyleController = (IStyleController) this.layoutControl1;
      this.cezaTime.TabIndex = 17;
      this.layoutControl5.Location = new Point(183, 309);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(529, 118);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(529, 118);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl3.Location = new Point(12, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(167, 415);
      this.layoutControl3.TabIndex = 14;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(167, 415);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(716, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(211, 415);
      this.layoutControl2.TabIndex = 13;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(211, 415);
      this.layoutControlGroup1.TextVisible = false;
      this.ilgiliNotTxt.Location = new Point(296, 208);
      this.ilgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilgiliNotTxt.Name = "ilgiliNotTxt";
      this.ilgiliNotTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ilgiliNotTxt.Properties.Appearance.Options.UseFont = true;
      this.ilgiliNotTxt.Size = new Size(416, 97);
      this.ilgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ilgiliNotTxt.TabIndex = 12;
      this.cezaTutariTxt.Location = new Point(296, 152);
      this.cezaTutariTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cezaTutariTxt.Name = "cezaTutariTxt";
      this.cezaTutariTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cezaTutariTxt.Properties.Appearance.Options.UseFont = true;
      this.cezaTutariTxt.Properties.Mask.EditMask = "n";
      this.cezaTutariTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.cezaTutariTxt.Size = new Size(416, 24);
      this.cezaTutariTxt.StyleController = (IStyleController) this.layoutControl1;
      this.cezaTutariTxt.TabIndex = 11;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.kayitTarihiDate.EditValue = (object) null;
      this.kayitTarihiDate.Location = new Point(296, 12);
      this.kayitTarihiDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kayitTarihiDate.Name = "kayitTarihiDate";
      this.kayitTarihiDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kayitTarihiDate.Properties.Appearance.Options.UseFont = true;
      this.kayitTarihiDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kayitTarihiDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kayitTarihiDate.Properties.DisplayFormat.FormatString = "";
      this.kayitTarihiDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.kayitTarihiDate.Properties.EditFormat.FormatString = "";
      this.kayitTarihiDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.kayitTarihiDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.kayitTarihiDate.Size = new Size(416, 24);
      this.kayitTarihiDate.StyleController = (IStyleController) this.layoutControl1;
      this.kayitTarihiDate.TabIndex = 4;
      this.fisNoTxt.Location = new Point(296, 71);
      this.fisNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisNoTxt.Name = "fisNoTxt";
      this.fisNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.fisNoTxt.Properties.Appearance.Options.UseFont = true;
      this.fisNoTxt.Size = new Size(416, 24);
      this.fisNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.fisNoTxt.TabIndex = 8;
      this.cezaDate.EditValue = (object) null;
      this.cezaDate.Location = new Point(296, 99);
      this.cezaDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cezaDate.Name = "cezaDate";
      this.cezaDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cezaDate.Properties.Appearance.Options.UseFont = true;
      this.cezaDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cezaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cezaDate.Properties.DisplayFormat.FormatString = "";
      this.cezaDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.cezaDate.Properties.EditFormat.FormatString = "";
      this.cezaDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.cezaDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.cezaDate.Size = new Size(234, 24);
      this.cezaDate.StyleController = (IStyleController) this.layoutControl1;
      this.cezaDate.TabIndex = 9;
      this.cezaAciklamaTxt.Location = new Point(296, (int) sbyte.MaxValue);
      this.cezaAciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cezaAciklamaTxt.Name = "cezaAciklamaTxt";
      this.cezaAciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cezaAciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.cezaAciklamaTxt.Size = new Size(416, 24);
      this.cezaAciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.cezaAciklamaTxt.TabIndex = 10;
      this.odemeDurumuCombo.Location = new Point(296, 180);
      this.odemeDurumuCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.odemeDurumuCombo.Name = "odemeDurumuCombo";
      this.odemeDurumuCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.odemeDurumuCombo.Properties.Appearance.Options.UseFont = true;
      this.odemeDurumuCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.odemeDurumuCombo.Properties.Items.AddRange(new object[4]
      {
        (object) "Beklemede",
        (object) "Tahsil Edildi",
        (object) "Ödendi",
        (object) "İptal"
      });
      this.odemeDurumuCombo.Properties.PopupSizeable = true;
      this.odemeDurumuCombo.Size = new Size(416, 24);
      this.odemeDurumuCombo.StyleController = (IStyleController) this.layoutControl1;
      this.odemeDurumuCombo.TabIndex = 18;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[12]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(939, 439);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.kayitTarihiDate;
      this.layoutControlItem1.Location = new Point(171, 0);
      this.layoutControlItem1.MinSize = new Size(50, 25);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(533, 28);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Kayıt Tarihi";
      this.layoutControlItem1.TextSize = new Size(110, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.plakaLook;
      this.layoutControlItem4.Location = new Point(171, 28);
      this.layoutControlItem4.MinSize = new Size(50, 25);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(533, 31);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Plaka";
      this.layoutControlItem4.TextSize = new Size(110, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.fisNoTxt;
      this.layoutControlItem5.Location = new Point(171, 59);
      this.layoutControlItem5.MinSize = new Size(50, 25);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(533, 28);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Fiş No";
      this.layoutControlItem5.TextSize = new Size(110, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.cezaDate;
      this.layoutControlItem6.Location = new Point(171, 87);
      this.layoutControlItem6.MinSize = new Size(50, 25);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(351, 28);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.Text = "Ceza Tarih/Saat";
      this.layoutControlItem6.TextSize = new Size(110, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.cezaAciklamaTxt;
      this.layoutControlItem7.Location = new Point(171, 115);
      this.layoutControlItem7.MinSize = new Size(50, 25);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(533, 25);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Ceza Açıklaması";
      this.layoutControlItem7.TextSize = new Size(110, 18);
      this.layoutControlItem10.Control = (Control) this.layoutControl2;
      this.layoutControlItem10.Location = new Point(704, 0);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(215, 419);
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.layoutControl3;
      this.layoutControlItem11.Location = new Point(0, 0);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(171, 419);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.cezaTutariTxt;
      this.layoutControlItem8.Location = new Point(171, 140);
      this.layoutControlItem8.MinSize = new Size(154, 28);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(533, 28);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "Ceza Tutarı";
      this.layoutControlItem8.TextSize = new Size(110, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.ilgiliNotTxt;
      this.layoutControlItem9.Location = new Point(171, 196);
      this.layoutControlItem9.MinSize = new Size(114, 24);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(533, 101);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.Text = "İlgili Not";
      this.layoutControlItem9.TextSize = new Size(110, 18);
      this.layoutControlItem13.Control = (Control) this.layoutControl5;
      this.layoutControlItem13.Location = new Point(171, 297);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(533, 122);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.cezaTime;
      this.layoutControlItem2.Location = new Point(522, 87);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(182, 28);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.odemeDurumuCombo;
      this.layoutControlItem3.Location = new Point(171, 168);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(533, 28);
      this.layoutControlItem3.Text = "Ödeme Durumu";
      this.layoutControlItem3.TextSize = new Size(110, 18);
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.plakaLook.Location = new Point(296, 40);
      this.plakaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaLook.Name = "plakaLook";
      this.plakaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaLook.Properties.Appearance.Options.UseFont = true;
      this.plakaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plakaLook.Properties.DataSource = (object) this.tBLARACLARBindingSource;
      this.plakaLook.Properties.DisplayMember = "PLAKA";
      this.plakaLook.Properties.NullText = "";
      this.plakaLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.plakaLook.Properties.ValueMember = "ID";
      this.plakaLook.Size = new Size(416, 24);
      this.plakaLook.StyleController = (IStyleController) this.layoutControl1;
      this.plakaLook.TabIndex = 7;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Plaka";
      this.gridColumn1.FieldName = "PLAKA";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(939, 539);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (TrafikCezaKaydiEkle);
      this.Text = "AracTrafikCezaEkleme";
      this.Load += new EventHandler(this.AracZimmetKaydi_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.cezaTime.Properties.EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.ilgiliNotTxt.Properties.EndInit();
      this.cezaTutariTxt.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.kayitTarihiDate.Properties.CalendarTimeProperties.EndInit();
      this.kayitTarihiDate.Properties.EndInit();
      this.fisNoTxt.Properties.EndInit();
      this.cezaDate.Properties.CalendarTimeProperties.EndInit();
      this.cezaDate.Properties.EndInit();
      this.cezaAciklamaTxt.Properties.EndInit();
      this.odemeDurumuCombo.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.plakaLook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
