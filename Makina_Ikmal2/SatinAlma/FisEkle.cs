// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.FisEkle
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
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class FisEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    public int secim = 0;
    public int talepID = 0;
    private int degerVar = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarEditItem barEditItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLTALEPFISBindingSource;
    private TBLTALEPFISTableAdapter tBLTALEPFISTableAdapter;
    private GridColumn colID;
    private GridColumn colISEMRIID;
    private GridColumn colKOD;
    private GridColumn colTARIH;
    private GridColumn colSAAT;
    private GridColumn colFIRMAID;
    private GridColumn colFISTUTAR;
    private GridColumn colTALEPDURUMID;
    private GridColumn colTALEPIPTALACIKLAMA;
    private GridColumn colTALEPEDENUSTAID;
    private GridColumn colATOLYESEFID;
    private GridColumn colDEPOYETKILIID;
    private GridColumn colMUDURID;
    private GridColumn colMUDONAYZAMAN;
    private GridColumn colTALEPKAYITID;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private BindingSource tBLTALEPBindingSource;
    private TBLTALEPTableAdapter tBLTALEPTableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private RepositoryItemLookUpEdit firmaAd;

    public FisEkle() => this.InitializeComponent();

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.FisEkle_Load(sender, (EventArgs) e);

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.TalepiDoldur();

    private void TalepiDoldur()
    {
      int talepFisID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == talepFisID));
      int num1;
      if (tbltalepfis.TALEPKAYITID.HasValue)
      {
        int? talepkayitid = tbltalepfis.TALEPKAYITID;
        int num2 = 0;
        num1 = talepkayitid.GetValueOrDefault() == num2 & talepkayitid.HasValue ? 1 : 0;
      }
      else
        num1 = 1;
      if (num1 != 0)
      {
        tbltalepfis.TALEPKAYITID = new int?(YetkiClass.secim_id);
        tbltalepfis.TALEPDURUMID = new int?(3);
        this.db.SaveChanges();
        this.degerVar = 0;
        IQueryable<\u003C\u003Ef__AnonymousType59<\u003C\u003Ef__AnonymousType58<\u003C\u003Ef__AnonymousType28<\u003C\u003Ef__AnonymousType27<TBLTALEPFIS, TBLTALEPFISHRKT>, TBLMALZEMELER>, TBLISEMRI>, TBLMALZBIRIM>> source = this.db.TBLTALEPFIS.Join((IEnumerable<TBLTALEPFISHRKT>) this.db.TBLTALEPFISHRKT, (Expression<System.Func<TBLTALEPFIS, int?>>) (hd => (int?) hd.ID), (Expression<System.Func<TBLTALEPFISHRKT, int?>>) (hy => hy.TALEPFISID), (hd, hy) => new
        {
          hd = hd,
          hy = hy
        }).Join((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.hy.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (ht => (int?) ht.ID), (data, ht) => new
        {
          \u003C\u003Eh__TransparentIdentifier0 = data,
          ht = ht
        }).Join((IEnumerable<TBLISEMRI>) this.db.TBLISEMRI, data => data.\u003C\u003Eh__TransparentIdentifier0.hd.ISEMRIID, (Expression<System.Func<TBLISEMRI, int?>>) (hp => (int?) hp.ID), (data, hp) => new
        {
          \u003C\u003Eh__TransparentIdentifier1 = data,
          hp = hp
        }).Join((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, data => data.\u003C\u003Eh__TransparentIdentifier1.ht.BIRIMID, (Expression<System.Func<TBLMALZBIRIM, int?>>) (birim => (int?) birim.ID), (data, birim) => new
        {
          \u003C\u003Eh__TransparentIdentifier2 = data,
          birim = birim
        }).Where(data => data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ID == talepFisID);
        Expression<System.Func<\u003C\u003Ef__AnonymousType59<\u003C\u003Ef__AnonymousType58<\u003C\u003Ef__AnonymousType28<\u003C\u003Ef__AnonymousType27<TBLTALEPFIS, TBLTALEPFISHRKT>, TBLMALZEMELER>, TBLISEMRI>, TBLMALZBIRIM>, \u003C\u003Ef__AnonymousType60<int?, string, string, string, Decimal?, Decimal?, Decimal?, int?, int?, int?, int?, int?>>> selector = data => new
        {
          ISEMRIID = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ISEMRIID,
          KOD = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.KOD,
          MALZEMEADI = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.ht.MALZEMEADI,
          MALZACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.MALZACIKLAMA,
          MIKTAR = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.MIKTAR,
          FIYAT = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.FIYAT,
          TUTAR = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.TUTAR,
          TALEPFISID = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.TALEPFISID,
          TALEPKAYITID = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TALEPKAYITID,
          ARACID = data.\u003C\u003Eh__TransparentIdentifier2.hp.ARACID,
          MALZEMEID = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.MALZEMEID,
          BIRIMID = data.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.BIRIMID
        };
        foreach (var data in source.Select(selector))
        {
          try
          {
            this.db.TBLTALEPHRKT.Add(new TBLTALEPHRKT()
            {
              TALEPID = new int?(YetkiClass.secim_id),
              ARACID = new int?(Convert.ToInt32((object) data.ARACID)),
              MALZACIKLAMA = Convert.ToString(data.MALZACIKLAMA),
              MALZEMEID = new int?(Convert.ToInt32((object) data.MALZEMEID)),
              MIKTAR = new Decimal?(Convert.ToDecimal((object) data.MIKTAR)),
              TALEPFISID = new int?(Convert.ToInt32((object) data.TALEPFISID)),
              TUTAR = new Decimal?(Convert.ToDecimal((object) data.TUTAR)),
              BIRIMID = new int?(Convert.ToInt32((object) data.BIRIMID)),
              FIYAT = new Decimal?(Convert.ToDecimal((object) data.FIYAT))
            });
          }
          catch (Exception ex)
          {
            int num3 = (int) XtraMessageBox.Show(ex.ToString());
          }
        }
        this.db.SaveChanges();
        ((TalepEkle) Application.OpenForms["TalepEkle"])?.Listele();
      }
      else
      {
        int num4 = (int) XtraMessageBox.Show("Talebe Kaydedilen Fiş Eklenemez");
      }
      if (this.degerVar == 1)
        return;
      if (this.secim == 1)
      {
        TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
        if (openForm != null)
        {
          openForm.liste();
          openForm.liste2(talepFisID);
        }
        this.Close();
      }
      if (this.secim == 2)
      {
        TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
        if (openForm != null)
        {
          openForm.liste();
          openForm.liste2(talepFisID);
        }
        this.Close();
      }
    }

    private void FisEkle_Load(object sender, EventArgs e)
    {
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet5.TBLFIRMALAR);
      this.tBLTALEPTableAdapter.Fill(this.bellDataSet5.TBLTALEP);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLTALEPFISTableAdapter.Fill(this.bellDataSet5.TBLTALEPFIS);
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem2_ItemClick(object sender, EventArgs e)
    {
    }

    private void gridView1_DoubleClick(object sender, EventArgs e) => this.TalepiDoldur();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FisEkle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLTALEPFISBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colISEMRIID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colSAAT = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.firmaAd = new RepositoryItemLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.colFISTUTAR = new GridColumn();
      this.colTALEPDURUMID = new GridColumn();
      this.colTALEPIPTALACIKLAMA = new GridColumn();
      this.colTALEPEDENUSTAID = new GridColumn();
      this.colATOLYESEFID = new GridColumn();
      this.colDEPOYETKILIID = new GridColumn();
      this.colMUDURID = new GridColumn();
      this.colMUDONAYZAMAN = new GridColumn();
      this.colTALEPKAYITID = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.tBLTALEPBindingSource = new BindingSource(this.components);
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.tBLTALEPFISTableAdapter = new TBLTALEPFISTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLTALEPTableAdapter = new TBLTALEPTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.firmaAd.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[13]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 16;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1016, 122);
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
      this.SilButton.Caption = "Sil";
      this.SilButton.Id = 3;
      this.SilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.Image");
      this.SilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.LargeImage");
      this.SilButton.LargeWidth = 100;
      this.SilButton.Name = "SilButton";
      this.SilButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.LargeWidth = 100;
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barButtonItem2.Caption = "Fişi Ekle";
      this.barButtonItem2.Id = 12;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Hint = "Kayit Bul..";
      this.barEditItem2.Id = 15;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLTALEPFISBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.firmaAd
      });
      this.gridControl1.Size = new Size(1016, 497);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.tBLTALEPFISBindingSource.DataMember = "TBLTALEPFIS";
      this.tBLTALEPFISBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[15]
      {
        this.colID,
        this.colISEMRIID,
        this.colKOD,
        this.colTARIH,
        this.colSAAT,
        this.colFIRMAID,
        this.colFISTUTAR,
        this.colTALEPDURUMID,
        this.colTALEPIPTALACIKLAMA,
        this.colTALEPEDENUSTAID,
        this.colATOLYESEFID,
        this.colDEPOYETKILIID,
        this.colMUDURID,
        this.colMUDONAYZAMAN,
        this.colTALEPKAYITID
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD, ColumnSortOrder.Descending)
      });
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 23;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 87;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.colISEMRIID.Caption = "İş Emri Kod";
      this.colISEMRIID.FieldName = "ISEMRIID";
      this.colISEMRIID.MinWidth = 23;
      this.colISEMRIID.Name = "colISEMRIID";
      this.colISEMRIID.OptionsColumn.AllowEdit = false;
      this.colISEMRIID.OptionsColumn.ReadOnly = true;
      this.colISEMRIID.Visible = true;
      this.colISEMRIID.VisibleIndex = 5;
      this.colISEMRIID.Width = 110;
      this.colKOD.Caption = "Talep Fişi Kodu";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 23;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 2;
      this.colKOD.Width = 122;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 23;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Width = 51;
      this.colSAAT.Caption = "Saat";
      this.colSAAT.FieldName = "SAAT";
      this.colSAAT.MinWidth = 23;
      this.colSAAT.Name = "colSAAT";
      this.colSAAT.OptionsColumn.AllowEdit = false;
      this.colSAAT.OptionsColumn.ReadOnly = true;
      this.colSAAT.Visible = true;
      this.colSAAT.VisibleIndex = 4;
      this.colSAAT.Width = 82;
      this.colFIRMAID.Caption = "Firma Adı";
      this.colFIRMAID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 23;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 7;
      this.colFIRMAID.Width = 115;
      this.firmaAd.AutoHeight = false;
      this.firmaAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmaAd.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firmaAd.DisplayMember = "FIRMAADI";
      this.firmaAd.Name = "firmaAd";
      this.firmaAd.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet5;
      this.colFISTUTAR.Caption = "Fiş Tutarı";
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.MinWidth = 23;
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 8;
      this.colFISTUTAR.Width = 122;
      this.colTALEPDURUMID.Caption = "Talep Durumu";
      this.colTALEPDURUMID.FieldName = "TALEPDURUMID";
      this.colTALEPDURUMID.MinWidth = 23;
      this.colTALEPDURUMID.Name = "colTALEPDURUMID";
      this.colTALEPDURUMID.OptionsColumn.AllowEdit = false;
      this.colTALEPDURUMID.OptionsColumn.ReadOnly = true;
      this.colTALEPDURUMID.Visible = true;
      this.colTALEPDURUMID.VisibleIndex = 6;
      this.colTALEPDURUMID.Width = 118;
      this.colTALEPIPTALACIKLAMA.FieldName = "TALEPIPTALACIKLAMA";
      this.colTALEPIPTALACIKLAMA.MinWidth = 23;
      this.colTALEPIPTALACIKLAMA.Name = "colTALEPIPTALACIKLAMA";
      this.colTALEPIPTALACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colTALEPIPTALACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colTALEPIPTALACIKLAMA.Width = 51;
      this.colTALEPEDENUSTAID.Caption = "Talep Eden Usta";
      this.colTALEPEDENUSTAID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colTALEPEDENUSTAID.FieldName = "TALEPEDENUSTAID";
      this.colTALEPEDENUSTAID.MinWidth = 23;
      this.colTALEPEDENUSTAID.Name = "colTALEPEDENUSTAID";
      this.colTALEPEDENUSTAID.OptionsColumn.AllowEdit = false;
      this.colTALEPEDENUSTAID.OptionsColumn.ReadOnly = true;
      this.colTALEPEDENUSTAID.Visible = true;
      this.colTALEPEDENUSTAID.VisibleIndex = 9;
      this.colTALEPEDENUSTAID.Width = 152;
      this.colATOLYESEFID.Caption = "Atölye Şefi";
      this.colATOLYESEFID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colATOLYESEFID.FieldName = "ATOLYESEFID";
      this.colATOLYESEFID.MinWidth = 23;
      this.colATOLYESEFID.Name = "colATOLYESEFID";
      this.colATOLYESEFID.OptionsColumn.AllowEdit = false;
      this.colATOLYESEFID.OptionsColumn.ReadOnly = true;
      this.colATOLYESEFID.Visible = true;
      this.colATOLYESEFID.VisibleIndex = 10;
      this.colATOLYESEFID.Width = 147;
      this.colDEPOYETKILIID.Caption = "Depo Yetkilisi";
      this.colDEPOYETKILIID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colDEPOYETKILIID.FieldName = "DEPOYETKILIID";
      this.colDEPOYETKILIID.MinWidth = 23;
      this.colDEPOYETKILIID.Name = "colDEPOYETKILIID";
      this.colDEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colDEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colDEPOYETKILIID.Visible = true;
      this.colDEPOYETKILIID.VisibleIndex = 11;
      this.colDEPOYETKILIID.Width = (int) sbyte.MaxValue;
      this.colMUDURID.Caption = "Şube Müdürü";
      this.colMUDURID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colMUDURID.FieldName = "MUDURID";
      this.colMUDURID.MinWidth = 23;
      this.colMUDURID.Name = "colMUDURID";
      this.colMUDURID.OptionsColumn.AllowEdit = false;
      this.colMUDURID.OptionsColumn.ReadOnly = true;
      this.colMUDURID.Visible = true;
      this.colMUDURID.VisibleIndex = 0;
      this.colMUDURID.Width = 107;
      this.colMUDONAYZAMAN.Caption = "Onay Zamanı";
      this.colMUDONAYZAMAN.FieldName = "MUDONAYZAMAN";
      this.colMUDONAYZAMAN.MinWidth = 23;
      this.colMUDONAYZAMAN.Name = "colMUDONAYZAMAN";
      this.colMUDONAYZAMAN.OptionsColumn.AllowEdit = false;
      this.colMUDONAYZAMAN.OptionsColumn.ReadOnly = true;
      this.colMUDONAYZAMAN.Visible = true;
      this.colMUDONAYZAMAN.VisibleIndex = 1;
      this.colMUDONAYZAMAN.Width = 110;
      this.colTALEPKAYITID.Caption = "Talep Kodu";
      this.colTALEPKAYITID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.colTALEPKAYITID.FieldName = "TALEPKAYITID";
      this.colTALEPKAYITID.MinWidth = 23;
      this.colTALEPKAYITID.Name = "colTALEPKAYITID";
      this.colTALEPKAYITID.OptionsColumn.AllowEdit = false;
      this.colTALEPKAYITID.OptionsColumn.ReadOnly = true;
      this.colTALEPKAYITID.Visible = true;
      this.colTALEPKAYITID.VisibleIndex = 3;
      this.colTALEPKAYITID.Width = 125;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLTALEPBindingSource;
      this.repositoryItemLookUpEdit2.DisplayMember = "KOD";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.tBLTALEPBindingSource.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource.DataSource = (object) this.bellDataSet5;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.tBLTALEPFISTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1016, 619);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (FisEkle);
      this.Text = nameof (FisEkle);
      this.Load += new EventHandler(this.FisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.firmaAd.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
