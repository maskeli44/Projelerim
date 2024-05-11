// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AKemalBaskanlik.MalzemeAnaliz
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.BaskanlikMalzemeAnalizTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AKemalBaskanlik
{
  public class MalzemeAnaliz : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private BarButtonItem barButtonItem13;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private BarCheckItem barCheckItem6;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private BarHeaderItem barHeaderItem1;
    private BaskanlikMalzemeAnaliz baskanlikMalzemeAnaliz;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private PivotGridControl pivotGridControl1;
    private BindingSource dataTable1BindingSource1;
    private PivotGridField fieldMALZEMEADI1;
    private PivotGridField fieldBIRIMID1;
    private PivotGridField fieldGRUPID1;
    private PivotGridField fieldAY1;
    private PivotGridField fieldISLEMTIPIID1;
    private PivotGridField fieldMIKTAR1;
    private PivotGridField fieldTOPLAM1;
    private LayoutControlItem layoutControlItem1;
    private RepositoryItemSearchLookUpEdit Birim;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private RepositoryItemSearchControl repositoryItemSearchControl2;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;

    public MalzemeAnaliz() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      try
      {
        this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet6.TBLMALZBIRIM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
      this.listele();
    }

    public void listele()
    {
      try
      {
        this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet6.TBLMALZBIRIM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.baskanlikMalzemeAnaliz.DataTable1);
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl2_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView7_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.pivotGridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MalzemeAnaliz));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barHeaderItem1 = new BarHeaderItem();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.repositoryItemSearchControl2 = new RepositoryItemSearchControl();
      this.layoutControl1 = new LayoutControl();
      this.pivotGridControl1 = new PivotGridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.baskanlikMalzemeAnaliz = new BaskanlikMalzemeAnaliz();
      this.fieldMALZEMEADI1 = new PivotGridField();
      this.fieldBIRIMID1 = new PivotGridField();
      this.Birim = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.fieldGRUPID1 = new PivotGridField();
      this.fieldAY1 = new PivotGridField();
      this.fieldISLEMTIPIID1 = new PivotGridField();
      this.fieldMIKTAR1 = new PivotGridField();
      this.fieldTOPLAM1 = new PivotGridField();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.pivotGridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.baskanlikMalzemeAnaliz.BeginInit();
      this.Birim.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[28]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barHeaderItem1,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 34;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 329;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemSearchControl2
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1519, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
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
      this.barButtonItem8.Caption = "barButtonItem8";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "barButtonItem9";
      this.barButtonItem9.Id = 9;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Filtrele";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem2.CheckedChanged += new ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.CheckedChanged += new ItemClickEventHandler(this.barCheckItem3_CheckedChanged);
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem4.CheckedChanged += new ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem5.CheckedChanged += new ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
      this.barButtonItem14.Caption = "İş Emri İptal";
      this.barButtonItem14.Id = 20;
      this.barButtonItem14.Name = "barButtonItem14";
      this.barButtonItem15.Caption = "barButtonItem15";
      this.barButtonItem15.Id = 21;
      this.barButtonItem15.Name = "barButtonItem15";
      this.barButtonItem16.Caption = "barButtonItem16";
      this.barButtonItem16.Id = 22;
      this.barButtonItem16.Name = "barButtonItem16";
      this.barCheckItem6.Caption = "İş Emri İptal";
      this.barCheckItem6.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem6.Id = 23;
      this.barCheckItem6.Name = "barCheckItem6";
      this.barCheckItem6.CheckedChanged += new ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem18.ItemClick += new ItemClickEventHandler(this.barButtonItem18_ItemClick);
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barHeaderItem1.Appearance.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barHeaderItem1.Appearance.Options.UseFont = true;
      this.barHeaderItem1.Caption = "MAKİNA İKMAL ŞUBE MÜDÜRLÜĞÜ - ARAÇ BAKIM DURUM EKRANI";
      this.barHeaderItem1.Id = 29;
      this.barHeaderItem1.Name = "barHeaderItem1";
      this.barHeaderItem1.Width = 750;
      this.barButtonItem1.Caption = "Excel";
      this.barButtonItem1.Id = 32;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
      this.barButtonItem2.Caption = "Yazdır";
      this.barButtonItem2.Id = 33;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.repositoryItemSearchControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.repositoryItemSearchControl2.AutoHeight = false;
      this.repositoryItemSearchControl2.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl2.Name = "repositoryItemSearchControl2";
      this.layoutControl1.Controls.Add((Control) this.pivotGridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(4, 4, 4, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1519, 878);
      this.layoutControl1.TabIndex = 5;
      this.layoutControl1.Text = "layoutControl1";
      this.pivotGridControl1.DataSource = (object) this.dataTable1BindingSource1;
      this.pivotGridControl1.Fields.AddRange(new PivotGridField[7]
      {
        this.fieldMALZEMEADI1,
        this.fieldBIRIMID1,
        this.fieldGRUPID1,
        this.fieldAY1,
        this.fieldISLEMTIPIID1,
        this.fieldMIKTAR1,
        this.fieldTOPLAM1
      });
      this.pivotGridControl1.Location = new Point(16, 14);
      this.pivotGridControl1.Margin = new Padding(4, 4, 4, 4);
      this.pivotGridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.pivotGridControl1.Name = "pivotGridControl1";
      this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 133;
      this.pivotGridControl1.OptionsView.RowTreeOffset = 28;
      this.pivotGridControl1.OptionsView.RowTreeWidth = 133;
      this.pivotGridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.Birim
      });
      this.pivotGridControl1.Size = new Size(1487, 850);
      this.pivotGridControl1.TabIndex = 4;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.baskanlikMalzemeAnaliz;
      this.baskanlikMalzemeAnaliz.DataSetName = "BaskanlikMalzemeAnaliz";
      this.baskanlikMalzemeAnaliz.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.fieldMALZEMEADI1.Area = PivotArea.RowArea;
      this.fieldMALZEMEADI1.AreaIndex = 0;
      this.fieldMALZEMEADI1.Caption = "Malzeme Adı";
      this.fieldMALZEMEADI1.FieldName = "MALZEMEADI";
      this.fieldMALZEMEADI1.MinWidth = 27;
      this.fieldMALZEMEADI1.Name = "fieldMALZEMEADI1";
      this.fieldMALZEMEADI1.Width = 196;
      this.fieldBIRIMID1.Area = PivotArea.RowArea;
      this.fieldBIRIMID1.AreaIndex = 1;
      this.fieldBIRIMID1.Caption = "Birim";
      this.fieldBIRIMID1.FieldEdit = (RepositoryItem) this.Birim;
      this.fieldBIRIMID1.FieldName = "BIRIMID";
      this.fieldBIRIMID1.MinWidth = 27;
      this.fieldBIRIMID1.Name = "fieldBIRIMID1";
      this.fieldBIRIMID1.Width = 133;
      this.Birim.AutoHeight = false;
      this.Birim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Birim.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.Birim.DisplayMember = "BIRIMADI";
      this.Birim.Name = "Birim";
      this.Birim.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.Birim.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.fieldGRUPID1.Area = PivotArea.RowArea;
      this.fieldGRUPID1.AreaIndex = 2;
      this.fieldGRUPID1.Caption = "Grup";
      this.fieldGRUPID1.FieldName = "GRUPID";
      this.fieldGRUPID1.MinWidth = 27;
      this.fieldGRUPID1.Name = "fieldGRUPID1";
      this.fieldGRUPID1.Width = 133;
      this.fieldAY1.Area = PivotArea.ColumnArea;
      this.fieldAY1.AreaIndex = 0;
      this.fieldAY1.Caption = "Ay";
      this.fieldAY1.FieldName = "AY";
      this.fieldAY1.MinWidth = 27;
      this.fieldAY1.Name = "fieldAY1";
      this.fieldAY1.Width = 133;
      this.fieldISLEMTIPIID1.AreaIndex = 0;
      this.fieldISLEMTIPIID1.Caption = "İşlem Tipi";
      this.fieldISLEMTIPIID1.FieldName = "ISLEMTIPIID";
      this.fieldISLEMTIPIID1.MinWidth = 27;
      this.fieldISLEMTIPIID1.Name = "fieldISLEMTIPIID1";
      this.fieldISLEMTIPIID1.Width = 133;
      this.fieldMIKTAR1.Area = PivotArea.DataArea;
      this.fieldMIKTAR1.AreaIndex = 1;
      this.fieldMIKTAR1.Caption = "Miktar";
      this.fieldMIKTAR1.FieldName = "MIKTAR";
      this.fieldMIKTAR1.MinWidth = 27;
      this.fieldMIKTAR1.Name = "fieldMIKTAR1";
      this.fieldMIKTAR1.Width = 133;
      this.fieldTOPLAM1.Area = PivotArea.DataArea;
      this.fieldTOPLAM1.AreaIndex = 0;
      this.fieldTOPLAM1.Caption = "Toplam";
      this.fieldTOPLAM1.FieldName = "TOPLAM";
      this.fieldTOPLAM1.MinWidth = 27;
      this.fieldTOPLAM1.Name = "fieldTOPLAM1";
      this.fieldTOPLAM1.Width = 133;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1519, 878);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.pivotGridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1493, 854);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.baskanlikMalzemeAnaliz;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1519, 996);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (MalzemeAnaliz);
      this.Text = "Malzeme Analiz";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.pivotGridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.baskanlikMalzemeAnaliz.EndInit();
      this.Birim.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
