// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.UstaEkran
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
using Makina_Ikmal.bellDataSet1TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class UstaEkran : Form
  {
    private RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
    private bellEntities db = new bellEntities();
    private int detay = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private GridView gridView1;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colBOLUMADI;
    private GridColumn colPLAKA;
    private GridColumn colBILDIRILENARIZA;
    private GridColumn colARACIGETIREN;
    private GridColumn colISEMRIDURUMID;
    private GridColumn colGIRISTARIH;
    private GridColumn colGIRISSAAT;
    private GridColumn colCIKISTARIH;
    private GridColumn colCIKISSAAT;
    private GridColumn colBAKIMSAATI;
    private GridColumn colYAPILANBAKIMOZETI;
    private GridControl gridControl1;
    private TabPane tabPane1;
    private TabNavigationPage tabNavigationPage1;
    private GridControl gridControl2;
    private GridView gridView2;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage3;
    private SimpleButton simpleButton1;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private GridColumn colKOD1;
    private GridColumn colARACID;
    private GridColumn colGIRISTARIH1;
    private GridColumn colBILDIRILENARIZA1;
    private GridColumn gridColumn1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemProgressBar repositoryItemProgressBar1;

    public UstaEkran() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new EkleFormu().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet1.TBLARACLAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet1.TBLISEMRI);
      this.ritem.Minimum = 0;
      this.ritem.Maximum = 100;
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) XtraMessageBox.Show("id:" + this.gridView1.GetFocusedRowCellValue("ID")?.ToString());
      new EkleFormu().Show();
    }

    private void gridControl2_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_kodu = this.gridView2.GetFocusedRowCellValue("KOD").ToString();
      new EkleFormu().Show();
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      string kodu = this.gridView2.GetFocusedRowCellValue("KOD").ToString();
      TBLISEMRI tblisemri = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == kodu));
      if (Convert.ToInt32(tblisemri.ISBITIMORANI) > 100)
        return;
      int num = Convert.ToInt32(tblisemri.ISBITIMORANI) + 10;
      tblisemri.ISBITIMORANI = num.ToString();
      this.db.SaveChanges();
      this.gridView1.FocusedRowHandle = this.gridView1.GetRowHandle(this.detay);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet1.TBLISEMRI);
      this.gridView1.FocusedRowHandle = this.gridView1.GetRowHandle(this.detay);
    }

    private void gridControl2_Click(object sender, EventArgs e) => this.detay = this.gridView2.FocusedRowHandle;

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      string kodu = this.gridView2.GetFocusedRowCellValue("KOD").ToString();
      TBLISEMRI tblisemri = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == kodu));
      if (Convert.ToInt32(tblisemri.ISBITIMORANI) > 100)
        return;
      int num = Convert.ToInt32(tblisemri.ISBITIMORANI) - 10;
      tblisemri.ISBITIMORANI = num.ToString();
      this.db.SaveChanges();
      this.gridView1.FocusedRowHandle = this.gridView1.GetRowHandle(this.detay);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet1.TBLISEMRI);
      this.gridView1.FocusedRowHandle = this.gridView1.GetRowHandle(this.detay);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UstaEkran));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colBILDIRILENARIZA = new GridColumn();
      this.colARACIGETIREN = new GridColumn();
      this.colISEMRIDURUMID = new GridColumn();
      this.colGIRISTARIH = new GridColumn();
      this.colGIRISSAAT = new GridColumn();
      this.colCIKISTARIH = new GridColumn();
      this.colCIKISSAAT = new GridColumn();
      this.colBAKIMSAATI = new GridColumn();
      this.colYAPILANBAKIMOZETI = new GridColumn();
      this.gridControl1 = new GridControl();
      this.tabPane1 = new TabPane();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.simpleButton1 = new SimpleButton();
      this.gridControl2 = new GridControl();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.gridView2 = new GridView();
      this.colKOD1 = new GridColumn();
      this.colARACID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.colGIRISTARIH1 = new GridColumn();
      this.colBILDIRILENARIZA1 = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.repositoryItemProgressBar1 = new RepositoryItemProgressBar();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.gridView1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.tabNavigationPage1.SuspendLayout();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.repositoryItemProgressBar1.BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[9]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 8;
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
      this.ribbonControl1.Size = new Size(1149, 118);
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
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Düzenle";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.Caption = "Arttır";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem5.Caption = "Azalt";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.colID,
        this.colKOD,
        this.colBOLUMADI,
        this.colPLAKA,
        this.colBILDIRILENARIZA,
        this.colARACIGETIREN,
        this.colISEMRIDURUMID,
        this.colGIRISTARIH,
        this.colGIRISSAAT,
        this.colCIKISTARIH,
        this.colCIKISSAAT,
        this.colBAKIMSAATI,
        this.colYAPILANBAKIMOZETI
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 94;
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 25;
      this.colKOD.Name = "colKOD";
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 1;
      this.colKOD.Width = 94;
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 25;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 2;
      this.colBOLUMADI.Width = 94;
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 3;
      this.colPLAKA.Width = 94;
      this.colBILDIRILENARIZA.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA.MinWidth = 25;
      this.colBILDIRILENARIZA.Name = "colBILDIRILENARIZA";
      this.colBILDIRILENARIZA.Visible = true;
      this.colBILDIRILENARIZA.VisibleIndex = 4;
      this.colBILDIRILENARIZA.Width = 94;
      this.colARACIGETIREN.FieldName = "ARACIGETIREN";
      this.colARACIGETIREN.MinWidth = 25;
      this.colARACIGETIREN.Name = "colARACIGETIREN";
      this.colARACIGETIREN.Visible = true;
      this.colARACIGETIREN.VisibleIndex = 5;
      this.colARACIGETIREN.Width = 94;
      this.colISEMRIDURUMID.FieldName = "ISEMRIDURUMID";
      this.colISEMRIDURUMID.MinWidth = 25;
      this.colISEMRIDURUMID.Name = "colISEMRIDURUMID";
      this.colISEMRIDURUMID.Visible = true;
      this.colISEMRIDURUMID.VisibleIndex = 6;
      this.colISEMRIDURUMID.Width = 94;
      this.colGIRISTARIH.FieldName = "GIRISTARIH";
      this.colGIRISTARIH.MinWidth = 25;
      this.colGIRISTARIH.Name = "colGIRISTARIH";
      this.colGIRISTARIH.Visible = true;
      this.colGIRISTARIH.VisibleIndex = 7;
      this.colGIRISTARIH.Width = 94;
      this.colGIRISSAAT.FieldName = "GIRISSAAT";
      this.colGIRISSAAT.MinWidth = 25;
      this.colGIRISSAAT.Name = "colGIRISSAAT";
      this.colGIRISSAAT.Visible = true;
      this.colGIRISSAAT.VisibleIndex = 8;
      this.colGIRISSAAT.Width = 94;
      this.colCIKISTARIH.FieldName = "CIKISTARIH";
      this.colCIKISTARIH.MinWidth = 25;
      this.colCIKISTARIH.Name = "colCIKISTARIH";
      this.colCIKISTARIH.Visible = true;
      this.colCIKISTARIH.VisibleIndex = 9;
      this.colCIKISTARIH.Width = 94;
      this.colCIKISSAAT.FieldName = "CIKISSAAT";
      this.colCIKISSAAT.MinWidth = 25;
      this.colCIKISSAAT.Name = "colCIKISSAAT";
      this.colCIKISSAAT.Visible = true;
      this.colCIKISSAAT.VisibleIndex = 10;
      this.colCIKISSAAT.Width = 94;
      this.colBAKIMSAATI.FieldName = "BAKIMSAATI";
      this.colBAKIMSAATI.MinWidth = 25;
      this.colBAKIMSAATI.Name = "colBAKIMSAATI";
      this.colBAKIMSAATI.Visible = true;
      this.colBAKIMSAATI.VisibleIndex = 11;
      this.colBAKIMSAATI.Width = 94;
      this.colYAPILANBAKIMOZETI.FieldName = "YAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.MinWidth = 25;
      this.colYAPILANBAKIMOZETI.Name = "colYAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.Visible = true;
      this.colYAPILANBAKIMOZETI.VisibleIndex = 12;
      this.colYAPILANBAKIMOZETI.Width = 94;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1149, 541);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 118);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[3]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3
      });
      this.tabPane1.RegularSize = new Size(1149, 587);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1149, 587);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "İş Emir Listesi";
      this.tabNavigationPage1.Caption = "İş Emir Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1149, 541);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 3);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(25, 24);
      this.simpleButton1.TabIndex = 3;
      this.gridControl2.DataSource = (object) this.tBLISEMRIBindingSource;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemProgressBar1
      });
      this.gridControl2.Size = new Size(1149, 541);
      this.gridControl2.TabIndex = 2;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.Click += new EventHandler(this.gridControl2_Click);
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick);
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[5]
      {
        this.colKOD1,
        this.colARACID,
        this.colGIRISTARIH1,
        this.colBILDIRILENARIZA1,
        this.gridColumn1
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.GroupPanelText = "buraya ben yazarım";
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ShowFooter = true;
      this.colKOD1.Caption = "İş Emri Kod";
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.MinWidth = 25;
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.OptionsColumn.AllowEdit = false;
      this.colKOD1.OptionsColumn.ReadOnly = true;
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 0;
      this.colKOD1.Width = 94;
      this.colARACID.Caption = "Plaka";
      this.colARACID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 25;
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 1;
      this.colARACID.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLARACLARBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet1;
      this.colGIRISTARIH1.Caption = "Giriş Tarihi";
      this.colGIRISTARIH1.FieldName = "GIRISTARIH";
      this.colGIRISTARIH1.MinWidth = 25;
      this.colGIRISTARIH1.Name = "colGIRISTARIH1";
      this.colGIRISTARIH1.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH1.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH1.Visible = true;
      this.colGIRISTARIH1.VisibleIndex = 2;
      this.colGIRISTARIH1.Width = 94;
      this.colBILDIRILENARIZA1.Caption = "Bildirilen Arıza";
      this.colBILDIRILENARIZA1.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA1.MinWidth = 25;
      this.colBILDIRILENARIZA1.Name = "colBILDIRILENARIZA1";
      this.colBILDIRILENARIZA1.OptionsColumn.AllowEdit = false;
      this.colBILDIRILENARIZA1.OptionsColumn.ReadOnly = true;
      this.colBILDIRILENARIZA1.Visible = true;
      this.colBILDIRILENARIZA1.VisibleIndex = 3;
      this.colBILDIRILENARIZA1.Width = 94;
      this.gridColumn1.Caption = "İş Bitim Oranı";
      this.gridColumn1.ColumnEdit = (RepositoryItem) this.repositoryItemProgressBar1;
      this.gridColumn1.FieldName = "ISBITIMORANI";
      this.gridColumn1.MinWidth = 25;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 4;
      this.gridColumn1.Width = 94;
      this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
      this.tabNavigationPage2.Caption = "Yağ Emir Listesi";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1149, 541);
      this.tabNavigationPage3.Caption = "Atölye Talepleri";
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1149, 547);
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1149, 705);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (UstaEkran);
      this.Text = "Form6";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.gridView1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.tabNavigationPage1.ResumeLayout(false);
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      this.gridView2.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.repositoryItemProgressBar1.EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
