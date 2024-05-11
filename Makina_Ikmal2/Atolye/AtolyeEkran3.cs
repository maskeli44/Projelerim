// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.AtolyeEkran3
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
using Makina_Ikmal.bellDataSet1TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.ustabasTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class AtolyeEkran3 : Form
  {
    private RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private GridControl gridControl2;
    private GridView gridView2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemProgressBar repositoryItemProgressBar1;
    private GridControl gridControl1;
    private GridView gridView1;
    private BindingSource dataTable1BindingSource;
    private BindingSource ustabasBindingSource;
    private ustabas ustabas;
    private GridColumn colID1;
    private GridColumn colARACID;
    private GridColumn colGIRISTARIH;
    private GridColumn colCIKISTARIH;
    private GridColumn colBAKIMGRUBUID;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource1;
    private GridColumn colID;
    private GridColumn colUSTAADISOYADI;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private Panel panel1;
    private Panel panel2;

    public AtolyeEkran3() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new EkleFormu().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet1.TBLBAKIMGRUBU);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet1.TBLISEMRI);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet1.TBLARACLAR);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet1.TBLATOLYEUSTALAR);
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

    private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      try
      {
        this.dataTable1TableAdapter.Fill(this.ustabas.DataTable1, Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID")));
      }
      catch (Exception ex)
      {
      }
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AtolyeEkran3));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridControl2 = new GridControl();
      this.tBLATOLYEUSTALARBindingSource1 = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.gridView2 = new GridView();
      this.colID = new GridColumn();
      this.colUSTAADISOYADI = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.repositoryItemProgressBar1 = new RepositoryItemProgressBar();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.ustabasBindingSource = new BindingSource(this.components);
      this.ustabas = new ustabas();
      this.gridView1 = new GridView();
      this.colID1 = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.colARACID = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.colGIRISTARIH = new GridColumn();
      this.colCIKISTARIH = new GridColumn();
      this.colBAKIMGRUBUID = new GridColumn();
      this.repositoryItemLookUpEdit4 = new RepositoryItemLookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.ribbonControl1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource1).BeginInit();
      this.bellDataSet1.BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemProgressBar1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.ustabasBindingSource).BeginInit();
      this.ustabas.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.repositoryItemLookUpEdit4.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
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
      this.ribbonControl1.Size = new Size(1149, 122);
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
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.Caption = "Yenile";
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
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
      this.gridControl2.DataSource = (object) this.tBLATOLYEUSTALARBindingSource1;
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
      this.gridControl2.Size = new Size(285, 583);
      this.gridControl2.TabIndex = 5;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLATOLYEUSTALARBindingSource1.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource1.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colUSTAADISOYADI
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.GroupPanelText = "buraya ben yazarım";
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridView2.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Width = 94;
      this.colUSTAADISOYADI.FieldName = "USTAADISOYADI";
      this.colUSTAADISOYADI.MinWidth = 25;
      this.colUSTAADISOYADI.Name = "colUSTAADISOYADI";
      this.colUSTAADISOYADI.Visible = true;
      this.colUSTAADISOYADI.VisibleIndex = 0;
      this.colUSTAADISOYADI.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit3,
        (RepositoryItem) this.repositoryItemLookUpEdit4
      });
      this.gridControl1.Size = new Size(858, 583);
      this.gridControl1.TabIndex = 6;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.ustabasBindingSource;
      this.ustabasBindingSource.DataSource = (object) this.ustabas;
      this.ustabasBindingSource.Position = 0;
      this.ustabas.DataSetName = "ustabas";
      this.ustabas.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colID1,
        this.colARACID,
        this.colGIRISTARIH,
        this.colCIKISTARIH,
        this.colBAKIMGRUBUID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "buraya ben yazarım";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ShowFooter = true;
      this.colID1.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.colID1.FieldName = "ID";
      this.colID1.MinWidth = 25;
      this.colID1.Name = "colID1";
      this.colID1.Visible = true;
      this.colID1.VisibleIndex = 0;
      this.colID1.Width = 94;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DataSource = (object) this.tBLISEMRIBindingSource;
      this.repositoryItemLookUpEdit3.DisplayMember = "KOD";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet1;
      this.colARACID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 25;
      this.colARACID.Name = "colARACID";
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 1;
      this.colARACID.Width = 94;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLARACLARBindingSource;
      this.repositoryItemLookUpEdit2.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet1;
      this.colGIRISTARIH.FieldName = "GIRISTARIH";
      this.colGIRISTARIH.MinWidth = 25;
      this.colGIRISTARIH.Name = "colGIRISTARIH";
      this.colGIRISTARIH.Visible = true;
      this.colGIRISTARIH.VisibleIndex = 2;
      this.colGIRISTARIH.Width = 94;
      this.colCIKISTARIH.FieldName = "CIKISTARIH";
      this.colCIKISTARIH.MinWidth = 25;
      this.colCIKISTARIH.Name = "colCIKISTARIH";
      this.colCIKISTARIH.Visible = true;
      this.colCIKISTARIH.VisibleIndex = 3;
      this.colCIKISTARIH.Width = 94;
      this.colBAKIMGRUBUID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit4;
      this.colBAKIMGRUBUID.FieldName = "BAKIMGRUBUID";
      this.colBAKIMGRUBUID.MinWidth = 25;
      this.colBAKIMGRUBUID.Name = "colBAKIMGRUBUID";
      this.colBAKIMGRUBUID.Visible = true;
      this.colBAKIMGRUBUID.VisibleIndex = 4;
      this.colBAKIMGRUBUID.Width = 94;
      this.repositoryItemLookUpEdit4.AutoHeight = false;
      this.repositoryItemLookUpEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit4.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.repositoryItemLookUpEdit4.DisplayMember = "GRUPADI";
      this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
      this.repositoryItemLookUpEdit4.ValueMember = "ID";
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet1;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet1;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.panel1.Controls.Add((Control) this.gridControl1);
      this.panel1.Location = new Point(291, 122);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(858, 583);
      this.panel1.TabIndex = 9;
      this.panel2.Controls.Add((Control) this.gridControl2);
      this.panel2.Dock = DockStyle.Left;
      this.panel2.Location = new Point(0, 122);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(285, 583);
      this.panel2.TabIndex = 7;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1149, 705);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "AtolyeEkran";
      this.Text = "Atölye Ekranı";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource1).EndInit();
      this.bellDataSet1.EndInit();
      this.gridView2.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemProgressBar1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.ustabasBindingSource).EndInit();
      this.ustabas.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.repositoryItemLookUpEdit4.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
