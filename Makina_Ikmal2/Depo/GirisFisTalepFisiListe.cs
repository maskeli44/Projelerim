// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.GirisFisTalepFisiListe
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
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
using Makina_Ikmal.Model.girisTalepEkleListesixsdTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class GirisFisTalepFisiListe : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private BarButtonItem barButtonItem13;
    private BarEditItem barEditItem1;
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
    private BarButtonItem barButtonItem22;
    private BarEditItem barEditItem2;
    private BarButtonItem barButtonItem1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private BarEditItem barEditItem3;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private girisTalepEkleListesixsd girisTalepEkleListesixsd;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colKOD;
    private GridColumn colTARIH;
    private GridColumn colFIRMAID;
    private GridColumn colTALEPDURUMID;
    private GridColumn colFISTUTAR;
    private GridColumn colTALEPIPTALACIKLAMA;
    private GridColumn colTALEPEDENUSTAID;
    private GridColumn colATOLYESEFID;
    private GridColumn colDEPOYETKILIID;
    private GridColumn colMUDURID;
    private GridColumn colMUDONAYZAMAN;
    private GridColumn colTALEPKAYITID;
    private GridColumn colExpr1;
    private GridColumn colPLAKA;
    private GridColumn colARACACIKLAMA;
    private GridColumn colDurum;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private RepositoryItemSearchLookUpEdit firma;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private RepositoryItemSearchLookUpEdit TalepEdenUsta;
    private GridView gridView2;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private RepositoryItemSearchLookUpEdit personel;
    private GridView gridView3;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemSearchLookUpEdit plaka;
    private GridView gridView4;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;

    public GirisFisTalepFisiListe() => this.InitializeComponent();

    private void GirisFisTalepFisiListe_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.dataTable1TableAdapter.Fill(this.girisTalepEkleListesixsd.DataTable1);
      try
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void yenile()
    {
      try
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id2 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ISEMRIID"));
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (tbltalepfis.SAVEUSER == "1" || tbltalepfis.SAVEUSER == null)
      {
        YetkiClass.secim = "fis";
        ((GirisFisEkle) Application.OpenForms["GirisFisEkle"])?.talepFistenGelenVeri();
        this.Close();
      }
      else
      {
        if (!(tbltalepfis.SAVEUSER == "2"))
          return;
        int num = (int) XtraMessageBox.Show("Bu fiş Daha Önce Eklenmiştir");
      }
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e) => this.yenile();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id2 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ISEMRIID"));
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (tbltalepfis.SAVEUSER == "1" || tbltalepfis.SAVEUSER == null)
      {
        YetkiClass.secim = "fis";
        ((GirisFisEkle) Application.OpenForms["GirisFisEkle"])?.talepFistenGelenVeri();
        this.Close();
      }
      else
      {
        if (!(tbltalepfis.SAVEUSER == "2"))
          return;
        int num = (int) XtraMessageBox.Show("Bu fiş Daha Önce Eklenmiştir");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GirisFisTalepFisiListe));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
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
      this.barButtonItem22 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.barButtonItem1 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.girisTalepEkleListesixsd = new girisTalepEkleListesixsd();
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.colKOD = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.firma = new RepositoryItemSearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colTALEPDURUMID = new GridColumn();
      this.colFISTUTAR = new GridColumn();
      this.colTALEPIPTALACIKLAMA = new GridColumn();
      this.colTALEPEDENUSTAID = new GridColumn();
      this.TalepEdenUsta = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.colATOLYESEFID = new GridColumn();
      this.colDEPOYETKILIID = new GridColumn();
      this.personel = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.colMUDURID = new GridColumn();
      this.colMUDONAYZAMAN = new GridColumn();
      this.colTALEPKAYITID = new GridColumn();
      this.colExpr1 = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.plaka = new RepositoryItemSearchLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.gridView4 = new GridView();
      this.colARACACIKLAMA = new GridColumn();
      this.colDurum = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.girisTalepEkleListesixsd.BeginInit();
      this.gridView1.BeginInit();
      this.firma.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.TalepEdenUsta.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.plaka.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.gridView4.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[31]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barEditItem1,
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
        (BarItem) this.barButtonItem22,
        (BarItem) this.barEditItem2,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 36;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 288;
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
      this.ribbonControl1.Size = new Size(1202, 122);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem2.Caption = "Sil";
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
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
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
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Fişi Ekle";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditWidth = 100;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
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
      this.barButtonItem17.Caption = "Yenile";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem22.Caption = "Talep Yükle";
      this.barButtonItem22.Id = 29;
      this.barButtonItem22.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.Image");
      this.barButtonItem22.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.LargeImage");
      this.barButtonItem22.LargeWidth = 100;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 120;
      this.barEditItem2.Hint = "Kayıt Bul..";
      this.barEditItem2.Id = 32;
      this.barEditItem2.Name = "barEditItem2";
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 30;
      this.barEditItem3.EditWidth = 120;
      this.barEditItem3.Hint = "Kayıt Bul...";
      this.barEditItem3.Id = 35;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.firma,
        (RepositoryItem) this.TalepEdenUsta,
        (RepositoryItem) this.personel,
        (RepositoryItem) this.plaka
      });
      this.gridControl1.Size = new Size(1202, 528);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.girisTalepEkleListesixsd;
      this.girisTalepEkleListesixsd.DataSetName = "girisTalepEkleListesixsd";
      this.girisTalepEkleListesixsd.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.gridColumn1,
        this.colKOD,
        this.colTARIH,
        this.colFIRMAID,
        this.colTALEPDURUMID,
        this.colFISTUTAR,
        this.colTALEPIPTALACIKLAMA,
        this.colTALEPEDENUSTAID,
        this.colATOLYESEFID,
        this.colDEPOYETKILIID,
        this.colMUDURID,
        this.colMUDONAYZAMAN,
        this.colTALEPKAYITID,
        this.colExpr1,
        this.colPLAKA,
        this.colARACACIKLAMA,
        this.colDurum,
        this.gridColumn2
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD, ColumnSortOrder.Descending)
      });
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.gridColumn1.Caption = "ID";
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.MinWidth = 24;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Width = 94;
      this.colKOD.Caption = "Talep Fiş Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 24;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 87;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 24;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 2;
      this.colTARIH.Width = 87;
      this.colFIRMAID.Caption = "Firma";
      this.colFIRMAID.ColumnEdit = (RepositoryItem) this.firma;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 24;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 3;
      this.colFIRMAID.Width = 87;
      this.firma.AutoHeight = false;
      this.firma.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma.DisplayMember = "FIRMAADI";
      this.firma.Name = "firma";
      this.firma.NullText = "";
      this.firma.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.firma.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colTALEPDURUMID.Caption = "Talep Durum";
      this.colTALEPDURUMID.FieldName = "TALEPDURUMID";
      this.colTALEPDURUMID.MinWidth = 24;
      this.colTALEPDURUMID.Name = "colTALEPDURUMID";
      this.colTALEPDURUMID.OptionsColumn.AllowEdit = false;
      this.colTALEPDURUMID.OptionsColumn.ReadOnly = true;
      this.colTALEPDURUMID.Visible = true;
      this.colTALEPDURUMID.VisibleIndex = 4;
      this.colTALEPDURUMID.Width = 97;
      this.colFISTUTAR.Caption = "Fiş Tutar";
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.MinWidth = 24;
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 5;
      this.colFISTUTAR.Width = 87;
      this.colTALEPIPTALACIKLAMA.Caption = "Talep İptal Açıklama";
      this.colTALEPIPTALACIKLAMA.FieldName = "TALEPIPTALACIKLAMA";
      this.colTALEPIPTALACIKLAMA.MinWidth = 24;
      this.colTALEPIPTALACIKLAMA.Name = "colTALEPIPTALACIKLAMA";
      this.colTALEPIPTALACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colTALEPIPTALACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colTALEPIPTALACIKLAMA.Visible = true;
      this.colTALEPIPTALACIKLAMA.VisibleIndex = 6;
      this.colTALEPIPTALACIKLAMA.Width = 138;
      this.colTALEPEDENUSTAID.Caption = "Talep Eden Usta";
      this.colTALEPEDENUSTAID.ColumnEdit = (RepositoryItem) this.TalepEdenUsta;
      this.colTALEPEDENUSTAID.FieldName = "TALEPEDENUSTAID";
      this.colTALEPEDENUSTAID.MinWidth = 24;
      this.colTALEPEDENUSTAID.Name = "colTALEPEDENUSTAID";
      this.colTALEPEDENUSTAID.OptionsColumn.AllowEdit = false;
      this.colTALEPEDENUSTAID.OptionsColumn.ReadOnly = true;
      this.colTALEPEDENUSTAID.Visible = true;
      this.colTALEPEDENUSTAID.VisibleIndex = 7;
      this.colTALEPEDENUSTAID.Width = 118;
      this.TalepEdenUsta.AutoHeight = false;
      this.TalepEdenUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.TalepEdenUsta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.TalepEdenUsta.DisplayMember = "USTAADISOYADI";
      this.TalepEdenUsta.Name = "TalepEdenUsta";
      this.TalepEdenUsta.NullText = "";
      this.TalepEdenUsta.PopupView = (ColumnView) this.gridView2;
      this.TalepEdenUsta.ValueMember = "ID";
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView2.DetailHeight = 431;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colATOLYESEFID.Caption = "Atolye Şefi";
      this.colATOLYESEFID.FieldName = "ATOLYESEFID";
      this.colATOLYESEFID.MinWidth = 24;
      this.colATOLYESEFID.Name = "colATOLYESEFID";
      this.colATOLYESEFID.OptionsColumn.AllowEdit = false;
      this.colATOLYESEFID.OptionsColumn.ReadOnly = true;
      this.colATOLYESEFID.Visible = true;
      this.colATOLYESEFID.VisibleIndex = 8;
      this.colATOLYESEFID.Width = 87;
      this.colDEPOYETKILIID.Caption = "Depo Yetkilisi";
      this.colDEPOYETKILIID.ColumnEdit = (RepositoryItem) this.personel;
      this.colDEPOYETKILIID.FieldName = "DEPOYETKILIID";
      this.colDEPOYETKILIID.MinWidth = 24;
      this.colDEPOYETKILIID.Name = "colDEPOYETKILIID";
      this.colDEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colDEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colDEPOYETKILIID.Visible = true;
      this.colDEPOYETKILIID.VisibleIndex = 9;
      this.colDEPOYETKILIID.Width = 99;
      this.personel.AutoHeight = false;
      this.personel.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personel.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personel.DisplayMember = "ADISOYADI";
      this.personel.Name = "personel";
      this.personel.NullText = "";
      this.personel.PopupView = (ColumnView) this.gridView3;
      this.personel.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView3.DetailHeight = 431;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.colMUDURID.Caption = "Müdür";
      this.colMUDURID.ColumnEdit = (RepositoryItem) this.personel;
      this.colMUDURID.FieldName = "MUDURID";
      this.colMUDURID.MinWidth = 24;
      this.colMUDURID.Name = "colMUDURID";
      this.colMUDURID.OptionsColumn.AllowEdit = false;
      this.colMUDURID.OptionsColumn.ReadOnly = true;
      this.colMUDURID.Visible = true;
      this.colMUDURID.VisibleIndex = 10;
      this.colMUDURID.Width = 87;
      this.colMUDONAYZAMAN.Caption = "Müdür Onay Zamanı";
      this.colMUDONAYZAMAN.FieldName = "MUDONAYZAMAN";
      this.colMUDONAYZAMAN.MinWidth = 24;
      this.colMUDONAYZAMAN.Name = "colMUDONAYZAMAN";
      this.colMUDONAYZAMAN.OptionsColumn.AllowEdit = false;
      this.colMUDONAYZAMAN.OptionsColumn.ReadOnly = true;
      this.colMUDONAYZAMAN.Visible = true;
      this.colMUDONAYZAMAN.VisibleIndex = 11;
      this.colMUDONAYZAMAN.Width = 139;
      this.colTALEPKAYITID.FieldName = "TALEPKAYITID";
      this.colTALEPKAYITID.MinWidth = 24;
      this.colTALEPKAYITID.Name = "colTALEPKAYITID";
      this.colTALEPKAYITID.OptionsColumn.AllowEdit = false;
      this.colTALEPKAYITID.OptionsColumn.ReadOnly = true;
      this.colTALEPKAYITID.Width = 87;
      this.colExpr1.Caption = "İş Emri Adı";
      this.colExpr1.FieldName = "Expr1";
      this.colExpr1.MinWidth = 24;
      this.colExpr1.Name = "colExpr1";
      this.colExpr1.OptionsColumn.AllowEdit = false;
      this.colExpr1.OptionsColumn.ReadOnly = true;
      this.colExpr1.Visible = true;
      this.colExpr1.VisibleIndex = 1;
      this.colExpr1.Width = 87;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.ColumnEdit = (RepositoryItem) this.plaka;
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 24;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 12;
      this.colPLAKA.Width = 87;
      this.plaka.AutoHeight = false;
      this.plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plaka.DataSource = (object) this.tBLARACLARBindingSource;
      this.plaka.DisplayMember = "PLAKA";
      this.plaka.Name = "plaka";
      this.plaka.NullText = "";
      this.plaka.PopupView = (ColumnView) this.gridView4;
      this.plaka.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView4.DetailHeight = 431;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.colARACACIKLAMA.Caption = "Araç Açıklama";
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.MinWidth = 24;
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 13;
      this.colARACACIKLAMA.Width = 104;
      this.colDurum.Caption = "Durum";
      this.colDurum.FieldName = "Durum";
      this.colDurum.MinWidth = 24;
      this.colDurum.Name = "colDurum";
      this.colDurum.OptionsColumn.AllowEdit = false;
      this.colDurum.OptionsColumn.ReadOnly = true;
      this.colDurum.Visible = true;
      this.colDurum.VisibleIndex = 14;
      this.colDurum.Width = 87;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.FieldName = "ISEMRIID";
      this.gridColumn2.MinWidth = 24;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Width = 94;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup5,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barEditItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1202, 650);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (GirisFisTalepFisiListe);
      this.Text = nameof (GirisFisTalepFisiListe);
      this.Load += new EventHandler(this.GirisFisTalepFisiListe_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.girisTalepEkleListesixsd.EndInit();
      this.gridView1.EndInit();
      this.firma.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.TalepEdenUsta.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.gridView2.EndInit();
      this.personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView3.EndInit();
      this.plaka.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.gridView4.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
