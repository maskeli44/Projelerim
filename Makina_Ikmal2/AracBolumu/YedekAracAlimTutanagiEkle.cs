// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.YedekAracAlimTutanagiEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.tasitgorevegidenlerTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class YedekAracAlimTutanagiEkle : XtraForm
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
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LookUpEdit plakaLook;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private MemoEdit ilgiliNotTxt;
    private TextEdit firmaYetkilisiTxt;
    private LookUpEdit teslimAlanLook;
    private TimeEdit saatDate;
    private DateEdit tarihDate;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem13;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private BindingSource tBLARACZIMMETBindingSource;
    private TBLARACZIMMETTableAdapter tBLARACZIMMETTableAdapter;
    private LookUpEdit teslimEdenLook;
    private TextEdit degisimSebebiTxt;
    private TextEdit yedekAracTxt;
    private TextEdit yedekAracMarkaTxt;
    private LayoutControlItem layoutControlItem14;
    private BindingSource dataTable1BindingSource;
    private AraclarListesi araclarListesi1;
    private DataTable1TableAdapter dataTable1TableAdapter1;

    public YedekAracAlimTutanagiEkle() => this.InitializeComponent();

    private void AracZimmetKaydi_Load(object sender, EventArgs e)
    {
      try
      {
        this.tBLARACZIMMETTableAdapter.Fill(this.bellDataSet5.TBLARACZIMMET);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
    }

    private void kayit()
    {
      TBLARACYEDEKALIM entity = new TBLARACYEDEKALIM();
      try
      {
        if (this.plakaLook.Text != "")
          entity.GIDENARACID = new int?(Convert.ToInt32(this.plakaLook.EditValue));
        if (this.plakaLook.Text != "")
          entity.TARIH = new DateTime?(Convert.ToDateTime(this.tarihDate.EditValue));
        if (this.plakaLook.Text != "")
          entity.SAAT = new DateTime?(Convert.ToDateTime(this.saatDate.EditValue));
        if (this.plakaLook.Text != "")
          entity.DEGISIMSEBEBI = this.degisimSebebiTxt.Text;
        if (this.plakaLook.Text != "")
          entity.YEDEKARAC = this.yedekAracTxt.Text;
        if (this.plakaLook.Text != "")
          entity.YEDEKARACMARKA = this.yedekAracMarkaTxt.Text;
        if (this.plakaLook.Text != "")
          entity.TESLIMALANID = new int?(Convert.ToInt32(this.teslimAlanLook.EditValue));
        if (this.plakaLook.Text != "")
          entity.FIRMAYETKILISI = this.firmaYetkilisiTxt.Text;
        if (this.plakaLook.Text != "")
          entity.TESLIMEDENID = new int?(Convert.ToInt32(this.teslimEdenLook.EditValue));
        if (this.plakaLook.Text != "")
          entity.ILGILINOT = this.ilgiliNotTxt.Text;
        this.db.TBLARACYEDEKALIM.Add(entity);
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
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
      this.plakaLook.EditValue = (object) null;
      this.tarihDate.EditValue = (object) null;
      this.saatDate.EditValue = (object) null;
      this.degisimSebebiTxt.EditValue = (object) null;
      this.yedekAracTxt.EditValue = (object) null;
      this.yedekAracMarkaTxt.EditValue = (object) null;
      this.teslimAlanLook.EditValue = (object) null;
      this.firmaYetkilisiTxt.EditValue = (object) null;
      this.teslimEdenLook.EditValue = (object) null;
      this.ilgiliNotTxt.EditValue = (object) null;
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (YedekAracAlimTutanagiEkle));
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
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.plakaLook = new LookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.layoutControl1 = new LayoutControl();
      this.teslimEdenLook = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.ilgiliNotTxt = new MemoEdit();
      this.firmaYetkilisiTxt = new TextEdit();
      this.teslimAlanLook = new LookUpEdit();
      this.saatDate = new TimeEdit();
      this.tarihDate = new DateEdit();
      this.degisimSebebiTxt = new TextEdit();
      this.yedekAracTxt = new TextEdit();
      this.yedekAracMarkaTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.tBLARACZIMMETBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.araclarListesi1 = new AraclarListesi();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.tBLARACZIMMETTableAdapter = new TBLARACZIMMETTableAdapter();
      this.dataTable1TableAdapter1 = new DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.plakaLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.teslimEdenLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.ilgiliNotTxt.Properties.BeginInit();
      this.firmaYetkilisiTxt.Properties.BeginInit();
      this.teslimAlanLook.Properties.BeginInit();
      this.saatDate.Properties.BeginInit();
      this.tarihDate.Properties.CalendarTimeProperties.BeginInit();
      this.tarihDate.Properties.BeginInit();
      this.degisimSebebiTxt.Properties.BeginInit();
      this.yedekAracTxt.Properties.BeginInit();
      this.yedekAracMarkaTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      ((ISupportInitialize) this.tBLARACZIMMETBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.araclarListesi1.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
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
      this.ribbonControl1.Size = new Size(939, 96);
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.plakaLook.Location = new Point(307, 12);
      this.plakaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaLook.Name = "plakaLook";
      this.plakaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaLook.Properties.Appearance.Options.UseFont = true;
      this.plakaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plakaLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("PLAKA", "PLAKA")
      });
      this.plakaLook.Properties.DataSource = (object) this.tBLARACLARBindingSource;
      this.plakaLook.Properties.DisplayMember = "PLAKA";
      this.plakaLook.Properties.NullText = "";
      this.plakaLook.Properties.ValueMember = "ID";
      this.plakaLook.Size = new Size(405, 24);
      this.plakaLook.StyleController = (IStyleController) this.layoutControl1;
      this.plakaLook.TabIndex = 4;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.layoutControl1.Controls.Add((Control) this.teslimEdenLook);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.ilgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.firmaYetkilisiTxt);
      this.layoutControl1.Controls.Add((Control) this.teslimAlanLook);
      this.layoutControl1.Controls.Add((Control) this.saatDate);
      this.layoutControl1.Controls.Add((Control) this.tarihDate);
      this.layoutControl1.Controls.Add((Control) this.plakaLook);
      this.layoutControl1.Controls.Add((Control) this.degisimSebebiTxt);
      this.layoutControl1.Controls.Add((Control) this.yedekAracTxt);
      this.layoutControl1.Controls.Add((Control) this.yedekAracMarkaTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(939, 443);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.teslimEdenLook.Location = new Point(307, 201);
      this.teslimEdenLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimEdenLook.Name = "teslimEdenLook";
      this.teslimEdenLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimEdenLook.Properties.Appearance.Options.UseFont = true;
      this.teslimEdenLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.teslimEdenLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADISOYADI", "ADISOYADI")
      });
      this.teslimEdenLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.teslimEdenLook.Properties.DisplayMember = "ADISOYADI";
      this.teslimEdenLook.Properties.NullText = "";
      this.teslimEdenLook.Properties.ValueMember = "ID";
      this.teslimEdenLook.Size = new Size(405, 24);
      this.teslimEdenLook.StyleController = (IStyleController) this.layoutControl1;
      this.teslimEdenLook.TabIndex = 17;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.layoutControl5.Location = new Point(183, 312);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(529, 119);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(529, 119);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl4.Location = new Point(487, 40);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(225, 25);
      this.layoutControl4.TabIndex = 15;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(225, 25);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(12, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(167, 419);
      this.layoutControl3.TabIndex = 14;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(167, 419);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(716, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(211, 419);
      this.layoutControl2.TabIndex = 13;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(211, 419);
      this.layoutControlGroup1.TextVisible = false;
      this.ilgiliNotTxt.Location = new Point(307, 229);
      this.ilgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilgiliNotTxt.Name = "ilgiliNotTxt";
      this.ilgiliNotTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ilgiliNotTxt.Properties.Appearance.Options.UseFont = true;
      this.ilgiliNotTxt.Size = new Size(405, 79);
      this.ilgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ilgiliNotTxt.TabIndex = 12;
      this.firmaYetkilisiTxt.Location = new Point(307, 173);
      this.firmaYetkilisiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firmaYetkilisiTxt.Name = "firmaYetkilisiTxt";
      this.firmaYetkilisiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.firmaYetkilisiTxt.Properties.Appearance.Options.UseFont = true;
      this.firmaYetkilisiTxt.Size = new Size(405, 24);
      this.firmaYetkilisiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.firmaYetkilisiTxt.TabIndex = 11;
      this.teslimAlanLook.Location = new Point(307, 145);
      this.teslimAlanLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimAlanLook.Name = "teslimAlanLook";
      this.teslimAlanLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimAlanLook.Properties.Appearance.Options.UseFont = true;
      this.teslimAlanLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.teslimAlanLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADISOYADI", "ADISOYADI")
      });
      this.teslimAlanLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.teslimAlanLook.Properties.DisplayMember = "ADISOYADI";
      this.teslimAlanLook.Properties.NullText = "";
      this.teslimAlanLook.Properties.ValueMember = "ID";
      this.teslimAlanLook.Size = new Size(405, 24);
      this.teslimAlanLook.StyleController = (IStyleController) this.layoutControl1;
      this.teslimAlanLook.TabIndex = 10;
      this.saatDate.EditValue = (object) new DateTime(2021, 12, 24, 0, 0, 0, 0);
      this.saatDate.Location = new Point(402, 40);
      this.saatDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saatDate.Name = "saatDate";
      this.saatDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saatDate.Properties.Appearance.Options.UseFont = true;
      this.saatDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saatDate.Properties.Mask.EditMask = "t";
      this.saatDate.Size = new Size(81, 24);
      this.saatDate.StyleController = (IStyleController) this.layoutControl1;
      this.saatDate.TabIndex = 6;
      this.tarihDate.EditValue = (object) null;
      this.tarihDate.Location = new Point(307, 40);
      this.tarihDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihDate.Name = "tarihDate";
      this.tarihDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarihDate.Properties.Appearance.Options.UseFont = true;
      this.tarihDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.tarihDate.Size = new Size(91, 24);
      this.tarihDate.StyleController = (IStyleController) this.layoutControl1;
      this.tarihDate.TabIndex = 5;
      this.degisimSebebiTxt.Location = new Point(307, 69);
      this.degisimSebebiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.degisimSebebiTxt.Name = "degisimSebebiTxt";
      this.degisimSebebiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.degisimSebebiTxt.Properties.Appearance.Options.UseFont = true;
      this.degisimSebebiTxt.Size = new Size(405, 24);
      this.degisimSebebiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.degisimSebebiTxt.TabIndex = 7;
      this.yedekAracTxt.Location = new Point(307, 94);
      this.yedekAracTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yedekAracTxt.Name = "yedekAracTxt";
      this.yedekAracTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yedekAracTxt.Properties.Appearance.Options.UseFont = true;
      this.yedekAracTxt.Size = new Size(405, 24);
      this.yedekAracTxt.StyleController = (IStyleController) this.layoutControl1;
      this.yedekAracTxt.TabIndex = 8;
      this.yedekAracMarkaTxt.Location = new Point(307, 120);
      this.yedekAracMarkaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yedekAracMarkaTxt.Name = "yedekAracMarkaTxt";
      this.yedekAracMarkaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yedekAracMarkaTxt.Properties.Appearance.Options.UseFont = true;
      this.yedekAracMarkaTxt.Size = new Size(405, 24);
      this.yedekAracMarkaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.yedekAracMarkaTxt.TabIndex = 9;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[14]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(939, 443);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.plakaLook;
      this.layoutControlItem1.Location = new Point(171, 0);
      this.layoutControlItem1.MinSize = new Size(154, 28);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(533, 28);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Giden Araç";
      this.layoutControlItem1.TextSize = new Size(121, 18);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.tarihDate;
      this.layoutControlItem2.Location = new Point(171, 28);
      this.layoutControlItem2.MinSize = new Size(154, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(219, 29);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Tarih/Saat";
      this.layoutControlItem2.TextSize = new Size(121, 18);
      this.layoutControlItem3.Control = (Control) this.saatDate;
      this.layoutControlItem3.Location = new Point(390, 28);
      this.layoutControlItem3.MinSize = new Size(54, 28);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(85, 29);
      this.layoutControlItem3.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.degisimSebebiTxt;
      this.layoutControlItem4.Location = new Point(171, 57);
      this.layoutControlItem4.MinSize = new Size(50, 25);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(533, 25);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Değişim Sebebi";
      this.layoutControlItem4.TextSize = new Size(121, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.yedekAracTxt;
      this.layoutControlItem5.Location = new Point(171, 82);
      this.layoutControlItem5.MinSize = new Size(50, 25);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(533, 26);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Yedek Araç";
      this.layoutControlItem5.TextSize = new Size(121, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.yedekAracMarkaTxt;
      this.layoutControlItem6.Location = new Point(171, 108);
      this.layoutControlItem6.MinSize = new Size(50, 25);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(533, 25);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.Text = "Yedek Araç Marka";
      this.layoutControlItem6.TextSize = new Size(121, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.teslimAlanLook;
      this.layoutControlItem7.Location = new Point(171, 133);
      this.layoutControlItem7.MinSize = new Size(154, 28);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(533, 28);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Teslim Alan";
      this.layoutControlItem7.TextSize = new Size(121, 18);
      this.layoutControlItem10.Control = (Control) this.layoutControl2;
      this.layoutControlItem10.Location = new Point(704, 0);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(215, 423);
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.layoutControl3;
      this.layoutControlItem11.Location = new Point(0, 0);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(171, 423);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.layoutControl4;
      this.layoutControlItem12.Location = new Point(475, 28);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(229, 29);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.firmaYetkilisiTxt;
      this.layoutControlItem8.Location = new Point(171, 161);
      this.layoutControlItem8.MinSize = new Size(154, 28);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(533, 28);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "Firma Yetkilisi";
      this.layoutControlItem8.TextSize = new Size(121, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.ilgiliNotTxt;
      this.layoutControlItem9.Location = new Point(171, 217);
      this.layoutControlItem9.MinSize = new Size(114, 24);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(533, 83);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.Text = "İlgili Not";
      this.layoutControlItem9.TextSize = new Size(121, 18);
      this.layoutControlItem13.Control = (Control) this.layoutControl5;
      this.layoutControlItem13.Location = new Point(171, 300);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(533, 123);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.teslimEdenLook;
      this.layoutControlItem14.Location = new Point(171, 189);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(533, 28);
      this.layoutControlItem14.Text = "Teslim Eden";
      this.layoutControlItem14.TextSize = new Size(121, 18);
      this.tBLARACZIMMETBindingSource.DataMember = "TBLARACZIMMET";
      this.tBLARACZIMMETBindingSource.DataSource = (object) this.bellDataSet5;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.araclarListesi1;
      this.dataTable1BindingSource.Sort = "";
      this.araclarListesi1.DataSetName = "AraclarListesi";
      this.araclarListesi1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.tBLARACZIMMETTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(939, 539);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (YedekAracAlimTutanagiEkle);
      this.Text = "Yedek Araç Alım Tutanağı";
      this.Load += new EventHandler(this.AracZimmetKaydi_Load);
      this.ribbonControl1.EndInit();
      this.plakaLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.teslimEdenLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.ilgiliNotTxt.Properties.EndInit();
      this.firmaYetkilisiTxt.Properties.EndInit();
      this.teslimAlanLook.Properties.EndInit();
      this.saatDate.Properties.EndInit();
      this.tarihDate.Properties.CalendarTimeProperties.EndInit();
      this.tarihDate.Properties.EndInit();
      this.degisimSebebiTxt.Properties.EndInit();
      this.yedekAracTxt.Properties.EndInit();
      this.yedekAracMarkaTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      ((ISupportInitialize) this.tBLARACZIMMETBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.araclarListesi1.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
