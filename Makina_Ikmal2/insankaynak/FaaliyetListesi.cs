// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.FaaliyetListesi
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
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class FaaliyetListesi : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private YetkiClass yet = new YetkiClass();
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
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private BarButtonItem barButtonItem13;
    private BarEditItem aramaTxt;
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
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private BarButtonItem barButtonItem21;
    private BarButtonItem barButtonItem22;
    private BarButtonItem barButtonItem23;
    private BarButtonItem barButtonItem24;
    private BarButtonItem barButtonItem25;
    private BarButtonItem barButtonItem26;
    private GridControl gridControl3;
    private GridView gridView3;
    private RepositoryItemLookUpEdit persListesi;
    private bellDataSet7 bellDataSet7;
    private BindingSource fAALIYETBindingSource;
    private FAALIYETTableAdapter fAALIYETTableAdapter;
    private GridColumn colID;
    private GridColumn colTARIH;
    private GridColumn colYILI;
    private GridColumn colARACBAKIMATOLYE;
    private GridColumn colARACBAKIMARAZI;
    private GridColumn colARACBAKIMDIS;
    private GridColumn colYAGBAKIM;
    private GridColumn colZORUNLUTRFKSIGORTA;
    private GridColumn colMUAYENE;
    private GridColumn colBAIKRESMI;
    private GridColumn colBAIKHIZMET;
    private GridColumn colYAKITMOTORIN;
    private GridColumn colYAKITBENZIN;
    private GridColumn colRESMIKIRALIKMOTORIN;
    private GridColumn colRESMIKIRALIKBENZIN;
    private GridColumn colSUBEMUDURU;
    private GridColumn colAYI;

    public FaaliyetListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new FaliyatRaporu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.fAALIYETTableAdapter.Fill(this.bellDataSet7.FAALIYET);
      this.yet.MenuYetkilendirme("Personel Listesi");
      this.listele();
    }

    public void listele() => this.gridControl3.DataSource = (object) this.db.FAALIYET.ToList<FAALIYET>();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
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

    private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e) => this.yazdir(this.gridControl3);

    private void yazdir(GridControl grid)
    {
      if (!grid.IsPrintingAvailable)
      {
        int num = (int) MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
      }
      else
        grid.ShowPrintPreview();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
        new FaliyatRaporu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new FaliyatRaporu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new FaliyatRaporu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView3_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
    {
    }

    private void gridView3_DoubleClick_1(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
        new FaliyatRaporu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FaaliyetListesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
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
      this.aramaTxt = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barButtonItem17 = new BarButtonItem();
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barButtonItem21 = new BarButtonItem();
      this.barButtonItem22 = new BarButtonItem();
      this.barButtonItem23 = new BarButtonItem();
      this.barButtonItem24 = new BarButtonItem();
      this.barButtonItem25 = new BarButtonItem();
      this.barButtonItem26 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridControl3 = new GridControl();
      this.gridView3 = new GridView();
      this.persListesi = new RepositoryItemLookUpEdit();
      this.bellDataSet7 = new bellDataSet7();
      this.fAALIYETBindingSource = new BindingSource(this.components);
      this.fAALIYETTableAdapter = new FAALIYETTableAdapter();
      this.colID = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colYILI = new GridColumn();
      this.colARACBAKIMATOLYE = new GridColumn();
      this.colARACBAKIMARAZI = new GridColumn();
      this.colARACBAKIMDIS = new GridColumn();
      this.colYAGBAKIM = new GridColumn();
      this.colZORUNLUTRFKSIGORTA = new GridColumn();
      this.colMUAYENE = new GridColumn();
      this.colBAIKRESMI = new GridColumn();
      this.colBAIKHIZMET = new GridColumn();
      this.colYAKITMOTORIN = new GridColumn();
      this.colYAKITBENZIN = new GridColumn();
      this.colRESMIKIRALIKMOTORIN = new GridColumn();
      this.colRESMIKIRALIKBENZIN = new GridColumn();
      this.colSUBEMUDURU = new GridColumn();
      this.colAYI = new GridColumn();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl3.BeginInit();
      this.gridView3.BeginInit();
      this.persListesi.BeginInit();
      this.bellDataSet7.BeginInit();
      ((ISupportInitialize) this.fAALIYETBindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[35]
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
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.aramaTxt,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barButtonItem17,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barButtonItem21,
        (BarItem) this.barButtonItem22,
        (BarItem) this.barButtonItem23,
        (BarItem) this.barButtonItem24,
        (BarItem) this.barButtonItem25,
        (BarItem) this.barButtonItem26
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
      this.ribbonControl1.Size = new Size(1389, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.Check;
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
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
      this.barButtonItem13.Caption = "İş Emri Detay";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) Resources.alignfloatingobjectbottomright_16x16;
      this.barButtonItem13.ImageOptions.LargeImage = (Image) Resources.alignfloatingobjectbottomright_32x32;
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.aramaTxt.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.aramaTxt.EditHeight = 30;
      this.aramaTxt.EditWidth = 110;
      this.aramaTxt.Id = 14;
      this.aramaTxt.Name = "aramaTxt";
      this.aramaTxt.RibbonStyle = RibbonItemStyles.Large;
      this.repositoryItemSearchControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
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
      this.barButtonItem17.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem17.Caption = "Raporlar";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) Resources.printdialog_16x16;
      this.barButtonItem17.ImageOptions.LargeImage = (Image) Resources.printdialog_32x32;
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
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
      this.barButtonItem21.Caption = "Talep Oluştur";
      this.barButtonItem21.Id = 28;
      this.barButtonItem21.ImageOptions.Image = (Image) Resources.addheader_16x16;
      this.barButtonItem21.ImageOptions.LargeImage = (Image) Resources.addheader_32x32;
      this.barButtonItem21.LargeWidth = 100;
      this.barButtonItem21.Name = "barButtonItem21";
      this.barButtonItem21.ItemClick += new ItemClickEventHandler(this.barButtonItem21_ItemClick);
      this.barButtonItem22.Caption = "Filtre Rapor";
      this.barButtonItem22.Id = 29;
      this.barButtonItem22.ImageOptions.Image = (Image) Resources.differentoddevenpages_16x16;
      this.barButtonItem22.ImageOptions.LargeImage = (Image) Resources.differentoddevenpages_32x32;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barButtonItem22.ItemClick += new ItemClickEventHandler(this.barButtonItem22_ItemClick);
      this.barButtonItem23.Caption = "Atölye";
      this.barButtonItem23.Id = 30;
      this.barButtonItem23.Name = "barButtonItem23";
      this.barButtonItem23.ItemClick += new ItemClickEventHandler(this.barButtonItem23_ItemClick);
      this.barButtonItem24.Caption = "Yağ Emri";
      this.barButtonItem24.Id = 31;
      this.barButtonItem24.Name = "barButtonItem24";
      this.barButtonItem24.ItemClick += new ItemClickEventHandler(this.barButtonItem24_ItemClick);
      this.barButtonItem25.Caption = "Atölye Talep";
      this.barButtonItem25.Id = 32;
      this.barButtonItem25.Name = "barButtonItem25";
      this.barButtonItem25.ItemClick += new ItemClickEventHandler(this.barButtonItem25_ItemClick);
      this.barButtonItem26.Caption = "Biten İş Emri";
      this.barButtonItem26.Id = 33;
      this.barButtonItem26.Name = "barButtonItem26";
      this.barButtonItem26.ItemClick += new ItemClickEventHandler(this.barButtonItem26_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.aramaTxt);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridControl3.DataSource = (object) this.fAALIYETBindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 118);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.persListesi
      });
      this.gridControl3.Size = new Size(1389, 587);
      this.gridControl3.TabIndex = 7;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.gridView3.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView3.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView3.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.BackColor = Color.White;
      this.gridView3.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView3.Appearance.Row.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.Options.UseFont = true;
      this.gridView3.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView3.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView3.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView3.Columns.AddRange(new GridColumn[17]
      {
        this.colID,
        this.colTARIH,
        this.colYILI,
        this.colARACBAKIMATOLYE,
        this.colARACBAKIMARAZI,
        this.colARACBAKIMDIS,
        this.colYAGBAKIM,
        this.colZORUNLUTRFKSIGORTA,
        this.colMUAYENE,
        this.colBAIKRESMI,
        this.colBAIKHIZMET,
        this.colYAKITMOTORIN,
        this.colYAKITBENZIN,
        this.colRESMIKIRALIKMOTORIN,
        this.colRESMIKIRALIKBENZIN,
        this.colSUBEMUDURU,
        this.colAYI
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.RowCellStyle += new RowCellStyleEventHandler(this.gridView3_RowCellStyle_1);
      this.gridView3.DoubleClick += new EventHandler(this.gridView3_DoubleClick_1);
      this.persListesi.AutoHeight = false;
      this.persListesi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.persListesi.DisplayMember = "ADISOYADI";
      this.persListesi.Name = "persListesi";
      this.persListesi.NullText = "";
      this.persListesi.ValueMember = "ID";
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.fAALIYETBindingSource.DataMember = "FAALIYET";
      this.fAALIYETBindingSource.DataSource = (object) this.bellDataSet7;
      this.fAALIYETTableAdapter.ClearBeforeFill = true;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 94;
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 1;
      this.colTARIH.Width = 94;
      this.colYILI.FieldName = "YILI";
      this.colYILI.MinWidth = 25;
      this.colYILI.Name = "colYILI";
      this.colYILI.Visible = true;
      this.colYILI.VisibleIndex = 2;
      this.colYILI.Width = 94;
      this.colARACBAKIMATOLYE.FieldName = "ARACBAKIMATOLYE";
      this.colARACBAKIMATOLYE.MinWidth = 25;
      this.colARACBAKIMATOLYE.Name = "colARACBAKIMATOLYE";
      this.colARACBAKIMATOLYE.Visible = true;
      this.colARACBAKIMATOLYE.VisibleIndex = 3;
      this.colARACBAKIMATOLYE.Width = 94;
      this.colARACBAKIMARAZI.FieldName = "ARACBAKIMARAZI";
      this.colARACBAKIMARAZI.MinWidth = 25;
      this.colARACBAKIMARAZI.Name = "colARACBAKIMARAZI";
      this.colARACBAKIMARAZI.Visible = true;
      this.colARACBAKIMARAZI.VisibleIndex = 4;
      this.colARACBAKIMARAZI.Width = 94;
      this.colARACBAKIMDIS.FieldName = "ARACBAKIMDIS";
      this.colARACBAKIMDIS.MinWidth = 25;
      this.colARACBAKIMDIS.Name = "colARACBAKIMDIS";
      this.colARACBAKIMDIS.Visible = true;
      this.colARACBAKIMDIS.VisibleIndex = 5;
      this.colARACBAKIMDIS.Width = 94;
      this.colYAGBAKIM.FieldName = "YAGBAKIM";
      this.colYAGBAKIM.MinWidth = 25;
      this.colYAGBAKIM.Name = "colYAGBAKIM";
      this.colYAGBAKIM.Visible = true;
      this.colYAGBAKIM.VisibleIndex = 6;
      this.colYAGBAKIM.Width = 94;
      this.colZORUNLUTRFKSIGORTA.FieldName = "ZORUNLUTRFKSIGORTA";
      this.colZORUNLUTRFKSIGORTA.MinWidth = 25;
      this.colZORUNLUTRFKSIGORTA.Name = "colZORUNLUTRFKSIGORTA";
      this.colZORUNLUTRFKSIGORTA.Visible = true;
      this.colZORUNLUTRFKSIGORTA.VisibleIndex = 7;
      this.colZORUNLUTRFKSIGORTA.Width = 94;
      this.colMUAYENE.FieldName = "MUAYENE";
      this.colMUAYENE.MinWidth = 25;
      this.colMUAYENE.Name = "colMUAYENE";
      this.colMUAYENE.Visible = true;
      this.colMUAYENE.VisibleIndex = 8;
      this.colMUAYENE.Width = 94;
      this.colBAIKRESMI.FieldName = "BAIKRESMI";
      this.colBAIKRESMI.MinWidth = 25;
      this.colBAIKRESMI.Name = "colBAIKRESMI";
      this.colBAIKRESMI.Visible = true;
      this.colBAIKRESMI.VisibleIndex = 9;
      this.colBAIKRESMI.Width = 94;
      this.colBAIKHIZMET.FieldName = "BAIKHIZMET";
      this.colBAIKHIZMET.MinWidth = 25;
      this.colBAIKHIZMET.Name = "colBAIKHIZMET";
      this.colBAIKHIZMET.Visible = true;
      this.colBAIKHIZMET.VisibleIndex = 10;
      this.colBAIKHIZMET.Width = 94;
      this.colYAKITMOTORIN.FieldName = "YAKITMOTORIN";
      this.colYAKITMOTORIN.MinWidth = 25;
      this.colYAKITMOTORIN.Name = "colYAKITMOTORIN";
      this.colYAKITMOTORIN.Visible = true;
      this.colYAKITMOTORIN.VisibleIndex = 11;
      this.colYAKITMOTORIN.Width = 94;
      this.colYAKITBENZIN.FieldName = "YAKITBENZIN";
      this.colYAKITBENZIN.MinWidth = 25;
      this.colYAKITBENZIN.Name = "colYAKITBENZIN";
      this.colYAKITBENZIN.Visible = true;
      this.colYAKITBENZIN.VisibleIndex = 12;
      this.colYAKITBENZIN.Width = 94;
      this.colRESMIKIRALIKMOTORIN.FieldName = "RESMIKIRALIKMOTORIN";
      this.colRESMIKIRALIKMOTORIN.MinWidth = 25;
      this.colRESMIKIRALIKMOTORIN.Name = "colRESMIKIRALIKMOTORIN";
      this.colRESMIKIRALIKMOTORIN.Visible = true;
      this.colRESMIKIRALIKMOTORIN.VisibleIndex = 13;
      this.colRESMIKIRALIKMOTORIN.Width = 94;
      this.colRESMIKIRALIKBENZIN.FieldName = "RESMIKIRALIKBENZIN";
      this.colRESMIKIRALIKBENZIN.MinWidth = 25;
      this.colRESMIKIRALIKBENZIN.Name = "colRESMIKIRALIKBENZIN";
      this.colRESMIKIRALIKBENZIN.Visible = true;
      this.colRESMIKIRALIKBENZIN.VisibleIndex = 14;
      this.colRESMIKIRALIKBENZIN.Width = 94;
      this.colSUBEMUDURU.FieldName = "SUBEMUDURU";
      this.colSUBEMUDURU.MinWidth = 25;
      this.colSUBEMUDURU.Name = "colSUBEMUDURU";
      this.colSUBEMUDURU.Visible = true;
      this.colSUBEMUDURU.VisibleIndex = 15;
      this.colSUBEMUDURU.Width = 94;
      this.colAYI.FieldName = "AYI";
      this.colAYI.MinWidth = 25;
      this.colAYI.Name = "colAYI";
      this.colAYI.Visible = true;
      this.colAYI.VisibleIndex = 16;
      this.colAYI.Width = 94;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1389, 705);
      this.Controls.Add((Control) this.gridControl3);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (FaaliyetListesi);
      this.Text = "Atölye Bölümü";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl3.EndInit();
      this.gridView3.EndInit();
      this.persListesi.EndInit();
      this.bellDataSet7.EndInit();
      ((ISupportInitialize) this.fAALIYETBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
