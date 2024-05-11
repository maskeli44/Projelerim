// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.AtolyeEkran_2
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class AtolyeEkran_2 : Form
  {
    private RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
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
    private GridControl gridControl2;
    private GridView gridView2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemProgressBar repositoryItemProgressBar1;
    private GridControl gridControl1;
    private GridView gridView1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    private Panel panel1;
    private Panel panel2;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private GridColumn colID;
    private GridColumn colBOLUMADI;
    private GridColumn colExpr2;
    private GridColumn colMIKTAR;
    private GridColumn colGIRISMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn colGIRISTUTAR;
    private GridColumn colDEGISIMKMSI;
    private GridColumn colSONRAKIDEGKM;
    private GridColumn colMALZURTTARIH;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private GridColumn colKOD;
    private GridColumn colTARIH;
    private GridColumn colExpr1;
    private GridColumn colISEMRIID;
    private GridColumn KOD;
    private isemirmalzeme isemirmalzeme;
    private BindingSource atolyeEkraniBindingSource;
    private AtolyeEkraniTableAdapter atolyeEkraniTableAdapter;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLMALZEMELERBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;

    public AtolyeEkran_2() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet6.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet6.TBLMALZEMELER);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void gridControl2_DoubleClick(object sender, EventArgs e)
    {
    }

    private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
    }

    private void gridView2_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
    {
      try
      {
        this.atolyeEkraniTableAdapter.Fill(this.isemirmalzeme.AtolyeEkrani, new int?(Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"))));
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet6.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet6.TBLMALZEMELER);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
    }

    private void gridView2_GotFocus(object sender, EventArgs e)
    {
      try
      {
        this.atolyeEkraniTableAdapter.Fill(this.isemirmalzeme.AtolyeEkrani, new int?(Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"))));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AtolyeEkran_2));
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
      this.gridControl2 = new GridControl();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView2 = new GridView();
      this.colID = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.repositoryItemProgressBar1 = new RepositoryItemProgressBar();
      this.gridControl1 = new GridControl();
      this.atolyeEkraniBindingSource = new BindingSource(this.components);
      this.isemirmalzeme = new isemirmalzeme();
      this.gridView1 = new GridView();
      this.KOD = new GridColumn();
      this.colExpr2 = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colGIRISMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colGIRISTUTAR = new GridColumn();
      this.colDEGISIMKMSI = new GridColumn();
      this.colSONRAKIDEGKM = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.repositoryItemLookUpEdit4 = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.colKOD = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colExpr1 = new GridColumn();
      this.colISEMRIID = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.tBLATOLYEBOLUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLATOLYEBOLUMTableAdapter();
      this.atolyeEkraniTableAdapter = new AtolyeEkraniTableAdapter();
      this.tBLMALZEMELERTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLMALZBIRIMTableAdapter();
      this.ribbonControl1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemProgressBar1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.atolyeEkraniBindingSource).BeginInit();
      this.isemirmalzeme.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit4.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
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
      this.ribbonControl1.Margin = new Padding(2, 2, 2, 2);
      this.ribbonControl1.MaxItemId = 8;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
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
      this.ribbonControl1.Size = new Size(862, 100);
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
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridControl2.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl2.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2, 2, 2, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemProgressBar1
      });
      this.gridControl2.Size = new Size(214, 473);
      this.gridControl2.TabIndex = 5;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colBOLUMADI
      });
      this.gridView2.DetailHeight = 284;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.GroupPanelText = "buraya ben yazarım";
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridView2.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged_1);
      this.gridView2.GotFocus += new EventHandler(this.gridView2_GotFocus);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 19;
      this.colID.Name = "colID";
      this.colID.Width = 70;
      this.colBOLUMADI.Caption = "Atölye Bölüm";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 19;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 0;
      this.colBOLUMADI.Width = 70;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
      this.gridControl1.DataSource = (object) this.atolyeEkraniBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl1.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2, 2, 2, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit3,
        (RepositoryItem) this.repositoryItemLookUpEdit4
      });
      this.gridControl1.Size = new Size(644, 474);
      this.gridControl1.TabIndex = 6;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.atolyeEkraniBindingSource.DataMember = "AtolyeEkrani";
      this.atolyeEkraniBindingSource.DataSource = (object) this.isemirmalzeme;
      this.isemirmalzeme.DataSetName = "isemirmalzeme";
      this.isemirmalzeme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[16]
      {
        this.KOD,
        this.colExpr2,
        this.colMIKTAR,
        this.colGIRISMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.colGIRISTUTAR,
        this.colDEGISIMKMSI,
        this.colSONRAKIDEGKM,
        this.colMALZURTTARIH,
        this.colMALZEMEADI,
        this.colBIRIMADI,
        this.colKOD,
        this.colTARIH,
        this.colExpr1,
        this.colISEMRIID
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "buraya ben yazarım";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ShowFooter = true;
      this.KOD.Caption = "İş Emir Kodu";
      this.KOD.FieldName = "KOD";
      this.KOD.MinWidth = 19;
      this.KOD.Name = "KOD";
      this.KOD.Visible = true;
      this.KOD.VisibleIndex = 0;
      this.KOD.Width = 85;
      this.colExpr2.FieldName = "Expr2";
      this.colExpr2.MinWidth = 19;
      this.colExpr2.Name = "colExpr2";
      this.colExpr2.Width = 70;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 19;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 4;
      this.colMIKTAR.Width = 66;
      this.colGIRISMIKTAR.FieldName = "GIRISMIKTAR";
      this.colGIRISMIKTAR.MinWidth = 19;
      this.colGIRISMIKTAR.Name = "colGIRISMIKTAR";
      this.colGIRISMIKTAR.Width = 70;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 19;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 5;
      this.colFIYAT.Width = 73;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 19;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TUTAR", "Toplam={0:0.##}")
      });
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 6;
      this.colTUTAR.Width = 107;
      this.colGIRISTUTAR.FieldName = "GIRISTUTAR";
      this.colGIRISTUTAR.MinWidth = 19;
      this.colGIRISTUTAR.Name = "colGIRISTUTAR";
      this.colGIRISTUTAR.Width = 70;
      this.colDEGISIMKMSI.FieldName = "DEGISIMKMSI";
      this.colDEGISIMKMSI.MinWidth = 19;
      this.colDEGISIMKMSI.Name = "colDEGISIMKMSI";
      this.colDEGISIMKMSI.Width = 70;
      this.colSONRAKIDEGKM.FieldName = "SONRAKIDEGKM";
      this.colSONRAKIDEGKM.MinWidth = 19;
      this.colSONRAKIDEGKM.Name = "colSONRAKIDEGKM";
      this.colSONRAKIDEGKM.Width = 70;
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 19;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.Width = 70;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 19;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 2;
      this.colMALZEMEADI.Width = 146;
      this.colBIRIMADI.Caption = "Birim";
      this.colBIRIMADI.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit4;
      this.colBIRIMADI.FieldName = "BIRIMID";
      this.colBIRIMADI.MinWidth = 19;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 3;
      this.colBIRIMADI.Width = 45;
      this.repositoryItemLookUpEdit4.AutoHeight = false;
      this.repositoryItemLookUpEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit4.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.repositoryItemLookUpEdit4.DisplayMember = "BIRIMADI";
      this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
      this.repositoryItemLookUpEdit4.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 19;
      this.colKOD.Name = "colKOD";
      this.colKOD.Width = 70;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 19;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 1;
      this.colTARIH.Width = 76;
      this.colExpr1.FieldName = "Expr1";
      this.colExpr1.MinWidth = 19;
      this.colExpr1.Name = "colExpr1";
      this.colExpr1.Width = 70;
      this.colISEMRIID.FieldName = "ISEMRIID";
      this.colISEMRIID.MinWidth = 19;
      this.colISEMRIID.Name = "colISEMRIID";
      this.colISEMRIID.Width = 70;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.repositoryItemLookUpEdit3.DisplayMember = "MALZEMEADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet6;
      this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.panel1.Controls.Add((Control) this.gridControl1);
      this.panel1.Location = new Point(218, 99);
      this.panel1.Margin = new Padding(2, 2, 2, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(644, 474);
      this.panel1.TabIndex = 9;
      this.panel2.Controls.Add((Control) this.gridControl2);
      this.panel2.Dock = DockStyle.Left;
      this.panel2.Location = new Point(0, 100);
      this.panel2.Margin = new Padding(2, 2, 2, 2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(214, 473);
      this.panel2.TabIndex = 7;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.atolyeEkraniTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(862, 573);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = nameof (AtolyeEkran_2);
      this.Text = "Atölye Ekranı";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView2.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemProgressBar1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.atolyeEkraniBindingSource).EndInit();
      this.isemirmalzeme.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit4.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
