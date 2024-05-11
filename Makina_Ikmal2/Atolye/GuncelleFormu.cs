// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.GuncelleFormu
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.AraclarListesiTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class GuncelleFormu : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private int id = YetkiClass.secim_id;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private AraclarListesi araclarListesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private LayoutControl layoutControl1;
    private TextEdit isemirkodu;
    private TextEdit aracigetiren;
    private TextEdit difransiyelyag;
    private TextEdit bakimKMsaat;
    private TextEdit no;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem difransiyel;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem26;
    private LayoutControlItem layoutControlItem27;
    private SearchLookUpEdit plakaCombo;
    private BindingSource dataTable1BindingSource1;
    private GridView searchLookUpEdit1View;
    private MemoEdit textEdit3;
    private SearchLookUpEdit birimCombo;
    private GridView gridView1;
    private SearchLookUpEdit textEdit8;
    private GridView gridView2;
    private SearchLookUpEdit textEdit9;
    private GridView gridView3;
    private MemoEdit bildirilenariza;
    private TextEdit motoryag;
    private TextEdit sanzimanyag;
    private MemoEdit bakimozeti;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem12;
    private SimpleLabelItem simpleLabelItem1;
    private EmptySpaceItem emptySpaceItem1;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private DateEdit dateEdit1;
    private LayoutControlItem layoutControlItem20;
    private DateEdit dateEdit2;
    private LayoutControlItem layoutControlItem6;
    private TimeSpanEdit timeSpanEdit1;
    private LayoutControlItem layoutControlItem22;
    private TimeSpanEdit timeSpanEdit2;
    private LayoutControlItem layoutControlItem7;
    private TextEdit genelbakim;
    private LayoutControlItem layoutControlItem14;
    private ComboBoxEdit bakimturu;
    private SearchLookUpEdit atolyesefi;
    private GridView gridView5;
    private ComboBoxEdit arizanedeni;
    private GridColumn gridColumn5;
    private LookUpEdit bakimyeri;
    private LookUpEdit isemirturu;

    public GuncelleFormu() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.dataTable1TableAdapter.Fill(this.araclarListesi.DataTable1);
      this.textEdit9.Properties.ValueMember = "ID";
      this.textEdit9.Properties.DisplayMember = "ADISOYADI";
      this.textEdit9.Properties.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.birimCombo.Properties.ValueMember = "ID";
      this.birimCombo.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimCombo.Properties.DataSource = (object) this.db.TBLBELDBIRIMLER.ToList<TBLBELDBIRIMLER>();
      this.textEdit8.Properties.ValueMember = "ID";
      this.textEdit8.Properties.DisplayMember = "BELDMUDURLUK";
      this.textEdit8.Properties.DataSource = (object) this.db.TBLBELDMUDURLUK.ToList<TBLBELDMUDURLUK>();
      this.atolyesefi.Properties.ValueMember = "ID";
      this.atolyesefi.Properties.DisplayMember = "ADISOYADI";
      this.atolyesefi.Properties.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
      this.degerleri();
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void degerleri()
    {
      try
      {
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACZIMMET tblaraczimmet = this.db.TBLARACZIMMET.OrderBy<TBLARACZIMMET, int>((Expression<System.Func<TBLARACZIMMET, int>>) (x => x.ID)).First<TBLARACZIMMET>((Expression<System.Func<TBLARACZIMMET, bool>>) (x => x.ARACID == (int?) arac_id));
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.OrderBy<TBLARACLAR, int>((Expression<System.Func<TBLARACLAR, int>>) (x => x.ID)).First<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        int int32_1 = Convert.ToInt32((object) tblaraczimmet.ZIMMETALANID);
        int int32_2 = Convert.ToInt32((object) tblaraczimmet.BELDBIRIMID);
        int int32_3 = Convert.ToInt32((object) tblaraczimmet.BELDMUDURLUKID);
        this.textEdit9.EditValue = (object) int32_1;
        this.birimCombo.EditValue = (object) int32_2;
        this.textEdit8.EditValue = (object) int32_3;
        this.textEdit3.Text = tblaraclar.ARACACIKLAMA;
      }
      catch (Exception ex)
      {
      }
    }

    private void kayit()
    {
      try
      {
        TBLISEMRI entity = new TBLISEMRI();
        entity.ID = this.son.isemir();
        entity.KOD = this.son.isemirkod().ToString();
        entity.ARACID = new int?(Convert.ToInt32(this.plakaCombo.EditValue));
        entity.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.EditValue));
        entity.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.timeSpanEdit1.EditValue));
        try
        {
          entity.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.timeSpanEdit2.EditValue));
        }
        catch (Exception ex)
        {
        }
        entity.ARIZANEDENIID = new int?(this.arizanedeni.SelectedIndex);
        entity.BILDIRILENARIZA = this.bildirilenariza.Text;
        entity.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isemirturu.EditValue));
        entity.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimyeri.EditValue));
        entity.ARACIGETIREN = this.aracigetiren.Text;
        entity.BAKIMKMSI = this.bakimKMsaat.Text;
        entity.ISEMRISIRANO = new int?(Convert.ToInt32(this.no.Text));
        entity.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyesefi.EditValue));
        entity.BAKIMTURUID = this.bakimturu.SelectedIndex.ToString();
        TBLISEMRI tblisemri = entity;
        int num1 = this.bakimturu.SelectedIndex;
        string str = num1.ToString();
        tblisemri.BAKIMDERECESIID = str;
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        tblaraclar.GENELBAKIMKM = this.genelbakim.Text;
        num1 = tblaraclar.ID;
        int num2 = (int) XtraMessageBox.Show(num1.ToString() + " " + tblaraclar.PLAKA);
        tblaraclar.MOTORYAGKM = this.motoryag.Text;
        tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        this.db.TBLISEMRI.Add(entity);
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void guncelle()
    {
      try
      {
        TBLISEMRI tblisemri1 = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == this.id));
        tblisemri1.ID = this.son.isemir();
        tblisemri1.KOD = this.son.isemirkod().ToString();
        tblisemri1.ARACID = new int?(Convert.ToInt32(this.plakaCombo.EditValue));
        tblisemri1.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.EditValue));
        tblisemri1.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.timeSpanEdit1.EditValue));
        try
        {
          tblisemri1.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          tblisemri1.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.timeSpanEdit2.EditValue));
        }
        catch (Exception ex)
        {
        }
        tblisemri1.ARIZANEDENIID = new int?(this.arizanedeni.SelectedIndex);
        tblisemri1.BILDIRILENARIZA = this.bildirilenariza.Text;
        tblisemri1.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isemirturu.EditValue));
        tblisemri1.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimyeri.EditValue));
        tblisemri1.ARACIGETIREN = this.aracigetiren.Text;
        tblisemri1.BAKIMKMSI = this.bakimKMsaat.Text;
        tblisemri1.ISEMRISIRANO = new int?(Convert.ToInt32(this.no.Text));
        tblisemri1.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyesefi.EditValue));
        TBLISEMRI tblisemri2 = tblisemri1;
        int selectedIndex = this.bakimturu.SelectedIndex;
        string str1 = selectedIndex.ToString();
        tblisemri2.BAKIMTURUID = str1;
        TBLISEMRI tblisemri3 = tblisemri1;
        selectedIndex = this.bakimturu.SelectedIndex;
        string str2 = selectedIndex.ToString();
        tblisemri3.BAKIMDERECESIID = str2;
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        tblaraclar.GENELBAKIMKM = this.genelbakim.Text;
        int num = (int) XtraMessageBox.Show(tblaraclar.ID.ToString() + " " + tblaraclar.PLAKA);
        tblaraclar.MOTORYAGKM = this.motoryag.Text;
        tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void sil()
    {
    }

    private void listele()
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
      {
        this.kayit();
        LogEkle.Logs("Ekleme Yapti");
      }
      else
      {
        if (!(YetkiClass.secim == "guncelle") || YetkiClass.GuncelleYetki != 1 || !(YetkiClass.menuyetki == "Hayır"))
          return;
        this.guncelle();
        LogEkle.Logs("Guncelle Yapti");
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void guncelleload()
    {
      TBLISEMRI tblisemri = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == this.id));
      this.isemirkodu.Text = tblisemri.KOD;
      this.plakaCombo.EditValue = (object) tblisemri.ARACID;
      this.dateEdit1.EditValue = (object) tblisemri.GIRISTARIH;
      this.timeSpanEdit1.EditValue = (object) Convert.ToDateTime((object) tblisemri.GIRISSAAT);
      this.dateEdit2.EditValue = (object) tblisemri.CIKISTARIH;
      this.timeSpanEdit2.EditValue = (object) tblisemri.CIKISSAAT;
      this.aracigetiren.Text = tblisemri.ARACIGETIREN;
      this.arizanedeni.SelectedIndex = Convert.ToInt32((object) tblisemri.ARIZANEDENIID);
      this.bildirilenariza.Text = tblisemri.BILDIRILENARIZA;
      this.isemirturu.EditValue = (object) Convert.ToInt32((object) tblisemri.ISEMRIDURUMID);
      this.bakimyeri.EditValue = (object) tblisemri.BAKIMYERIID.ToString();
      this.aracigetiren.Text = tblisemri.ARACIGETIREN;
      this.bakimKMsaat.Text = tblisemri.BAKIMKMSI;
      this.no.Text = tblisemri.ISEMRISIRANO.ToString();
      this.atolyesefi.EditValue = (object) tblisemri.IMZAATOLYESEFID;
      this.bakimturu.SelectedIndex = Convert.ToInt32(tblisemri.BAKIMTURUID);
      this.bakimturu.SelectedIndex = Convert.ToInt32(tblisemri.BAKIMDERECESIID);
      int arac_id = Convert.ToInt32((object) tblisemri.ARACID);
      TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
      this.genelbakim.Text = tblaraclar.GENELBAKIMKM;
      this.motoryag.Text = tblaraclar.MOTORYAGKM;
      this.difransiyelyag.Text = tblaraclar.DIFERANSIYELYAGKM;
      this.sanzimanyag.Text = tblaraclar.SANZIMANYAGKM;
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GuncelleFormu));
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
      this.araclarListesi = new AraclarListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.genelbakim = new TextEdit();
      this.timeSpanEdit2 = new TimeSpanEdit();
      this.timeSpanEdit1 = new TimeSpanEdit();
      this.dateEdit2 = new DateEdit();
      this.dateEdit1 = new DateEdit();
      this.isemirkodu = new TextEdit();
      this.aracigetiren = new TextEdit();
      this.difransiyelyag = new TextEdit();
      this.bakimKMsaat = new TextEdit();
      this.no = new TextEdit();
      this.plakaCombo = new SearchLookUpEdit();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.textEdit3 = new MemoEdit();
      this.birimCombo = new SearchLookUpEdit();
      this.gridView1 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.textEdit8 = new SearchLookUpEdit();
      this.gridView2 = new GridView();
      this.gridColumn3 = new GridColumn();
      this.textEdit9 = new SearchLookUpEdit();
      this.gridView3 = new GridView();
      this.gridColumn4 = new GridColumn();
      this.bildirilenariza = new MemoEdit();
      this.motoryag = new TextEdit();
      this.sanzimanyag = new TextEdit();
      this.bakimozeti = new MemoEdit();
      this.bakimturu = new ComboBoxEdit();
      this.atolyesefi = new SearchLookUpEdit();
      this.gridView5 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.arizanedeni = new ComboBoxEdit();
      this.bakimyeri = new LookUpEdit();
      this.isemirturu = new LookUpEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.difransiyel = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.simpleLabelItem1 = new SimpleLabelItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.ribbonControl1.BeginInit();
      this.araclarListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.genelbakim.Properties.BeginInit();
      this.timeSpanEdit2.Properties.BeginInit();
      this.timeSpanEdit1.Properties.BeginInit();
      this.dateEdit2.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit2.Properties.BeginInit();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.isemirkodu.Properties.BeginInit();
      this.aracigetiren.Properties.BeginInit();
      this.difransiyelyag.Properties.BeginInit();
      this.bakimKMsaat.Properties.BeginInit();
      this.no.Properties.BeginInit();
      this.plakaCombo.Properties.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.textEdit3.Properties.BeginInit();
      this.birimCombo.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.textEdit8.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.textEdit9.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.bildirilenariza.Properties.BeginInit();
      this.motoryag.Properties.BeginInit();
      this.sanzimanyag.Properties.BeginInit();
      this.bakimozeti.Properties.BeginInit();
      this.bakimturu.Properties.BeginInit();
      this.atolyesefi.Properties.BeginInit();
      this.gridView5.BeginInit();
      this.arizanedeni.Properties.BeginInit();
      this.bakimyeri.Properties.BeginInit();
      this.isemirturu.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.difransiyel.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.simpleLabelItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.emptySpaceItem1.BeginInit();
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
      this.ribbonControl1.Size = new Size(1130, 122);
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
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
      this.araclarListesi.DataSetName = "AraclarListesi";
      this.araclarListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.araclarListesi;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.layoutControl1.Controls.Add((Control) this.genelbakim);
      this.layoutControl1.Controls.Add((Control) this.timeSpanEdit2);
      this.layoutControl1.Controls.Add((Control) this.timeSpanEdit1);
      this.layoutControl1.Controls.Add((Control) this.dateEdit2);
      this.layoutControl1.Controls.Add((Control) this.dateEdit1);
      this.layoutControl1.Controls.Add((Control) this.isemirkodu);
      this.layoutControl1.Controls.Add((Control) this.aracigetiren);
      this.layoutControl1.Controls.Add((Control) this.difransiyelyag);
      this.layoutControl1.Controls.Add((Control) this.bakimKMsaat);
      this.layoutControl1.Controls.Add((Control) this.no);
      this.layoutControl1.Controls.Add((Control) this.plakaCombo);
      this.layoutControl1.Controls.Add((Control) this.textEdit3);
      this.layoutControl1.Controls.Add((Control) this.birimCombo);
      this.layoutControl1.Controls.Add((Control) this.textEdit8);
      this.layoutControl1.Controls.Add((Control) this.textEdit9);
      this.layoutControl1.Controls.Add((Control) this.bildirilenariza);
      this.layoutControl1.Controls.Add((Control) this.motoryag);
      this.layoutControl1.Controls.Add((Control) this.sanzimanyag);
      this.layoutControl1.Controls.Add((Control) this.bakimozeti);
      this.layoutControl1.Controls.Add((Control) this.bakimturu);
      this.layoutControl1.Controls.Add((Control) this.atolyesefi);
      this.layoutControl1.Controls.Add((Control) this.arizanedeni);
      this.layoutControl1.Controls.Add((Control) this.bakimyeri);
      this.layoutControl1.Controls.Add((Control) this.isemirturu);
      this.layoutControl1.Dock = DockStyle.Top;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1130, 316);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.genelbakim.Location = new Point(974, 133);
      this.genelbakim.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelbakim.Name = "genelbakim";
      this.genelbakim.Properties.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelbakim.Properties.Appearance.Options.UseFont = true;
      this.genelbakim.Properties.Mask.EditMask = "n0";
      this.genelbakim.Properties.Mask.MaskType = MaskType.Numeric;
      this.genelbakim.Size = new Size(144, 28);
      this.genelbakim.StyleController = (IStyleController) this.layoutControl1;
      this.genelbakim.TabIndex = 40;
      this.timeSpanEdit2.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.timeSpanEdit2.Location = new Point(495, 165);
      this.timeSpanEdit2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.timeSpanEdit2.Name = "timeSpanEdit2";
      this.timeSpanEdit2.Properties.AllowEditDays = false;
      this.timeSpanEdit2.Properties.AllowEditSeconds = false;
      this.timeSpanEdit2.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.timeSpanEdit2.Properties.Appearance.Options.UseFont = true;
      this.timeSpanEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.timeSpanEdit2.Properties.Mask.EditMask = "t";
      this.timeSpanEdit2.Size = new Size(358, 26);
      this.timeSpanEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.timeSpanEdit2.TabIndex = 39;
      this.timeSpanEdit1.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.timeSpanEdit1.Location = new Point(495, 133);
      this.timeSpanEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.timeSpanEdit1.Name = "timeSpanEdit1";
      this.timeSpanEdit1.Properties.AllowEditDays = false;
      this.timeSpanEdit1.Properties.AllowEditSeconds = false;
      this.timeSpanEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.timeSpanEdit1.Properties.Appearance.Options.UseFont = true;
      this.timeSpanEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.timeSpanEdit1.Properties.Mask.EditMask = "t";
      this.timeSpanEdit1.Size = new Size(358, 26);
      this.timeSpanEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.timeSpanEdit1.TabIndex = 38;
      this.dateEdit2.EditValue = (object) null;
      this.dateEdit2.Location = new Point(134, 163);
      this.dateEdit2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.dateEdit2.Name = "dateEdit2";
      this.dateEdit2.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateEdit2.Properties.Appearance.Options.UseFont = true;
      this.dateEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Size = new Size(252, 26);
      this.dateEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit2.TabIndex = 34;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(134, 133);
      this.dateEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateEdit1.Properties.Appearance.Options.UseFont = true;
      this.dateEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.Mask.EditMask = "D";
      this.dateEdit1.Size = new Size(252, 26);
      this.dateEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit1.TabIndex = 33;
      this.isemirkodu.Location = new Point(134, 103);
      this.isemirkodu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemirkodu.Name = "isemirkodu";
      this.isemirkodu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemirkodu.Properties.Appearance.Options.UseFont = true;
      this.isemirkodu.Size = new Size(252, 26);
      this.isemirkodu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirkodu.TabIndex = 8;
      this.aracigetiren.Location = new Point(134, 42);
      this.aracigetiren.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracigetiren.Name = "aracigetiren";
      this.aracigetiren.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracigetiren.Properties.Appearance.Options.UseFont = true;
      this.aracigetiren.Size = new Size(247, 26);
      this.aracigetiren.StyleController = (IStyleController) this.layoutControl1;
      this.aracigetiren.TabIndex = 13;
      this.difransiyelyag.Location = new Point(974, 195);
      this.difransiyelyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.difransiyelyag.Name = "difransiyelyag";
      this.difransiyelyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyelyag.Properties.Appearance.Options.UseFont = true;
      this.difransiyelyag.Properties.Mask.EditMask = "n0";
      this.difransiyelyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.difransiyelyag.Size = new Size(144, 26);
      this.difransiyelyag.StyleController = (IStyleController) this.layoutControl1;
      this.difransiyelyag.TabIndex = 20;
      this.bakimKMsaat.Location = new Point(134, 193);
      this.bakimKMsaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimKMsaat.Name = "bakimKMsaat";
      this.bakimKMsaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimKMsaat.Properties.Appearance.Options.UseFont = true;
      this.bakimKMsaat.Properties.Mask.EditMask = "n0";
      this.bakimKMsaat.Properties.Mask.MaskType = MaskType.Numeric;
      this.bakimKMsaat.Size = new Size(252, 26);
      this.bakimKMsaat.StyleController = (IStyleController) this.layoutControl1;
      this.bakimKMsaat.TabIndex = 21;
      this.no.Location = new Point(495, 103);
      this.no.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.no.Name = "no";
      this.no.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.no.Properties.Appearance.Options.UseFont = true;
      this.no.Size = new Size(358, 26);
      this.no.StyleController = (IStyleController) this.layoutControl1;
      this.no.TabIndex = 29;
      this.plakaCombo.Location = new Point(135, 12);
      this.plakaCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaCombo.Name = "plakaCombo";
      this.plakaCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaCombo.Properties.Appearance.Options.UseFont = true;
      this.plakaCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plakaCombo.Properties.DataSource = (object) this.dataTable1BindingSource1;
      this.plakaCombo.Properties.DisplayMember = "PLAKA";
      this.plakaCombo.Properties.NullText = "";
      this.plakaCombo.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.plakaCombo.Properties.ValueMember = "ID";
      this.plakaCombo.Size = new Size(246, 26);
      this.plakaCombo.StyleController = (IStyleController) this.layoutControl1;
      this.plakaCombo.TabIndex = 4;
      this.plakaCombo.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.araclarListesi;
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
      this.textEdit3.Location = new Point(134, 72);
      this.textEdit3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit3.Name = "textEdit3";
      this.textEdit3.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit3.Properties.Appearance.Options.UseFont = true;
      this.textEdit3.Properties.ScrollBars = ScrollBars.None;
      this.textEdit3.Size = new Size(984, 27);
      this.textEdit3.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit3.TabIndex = 6;
      this.birimCombo.Location = new Point(855, 12);
      this.birimCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimCombo.Name = "birimCombo";
      this.birimCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimCombo.Properties.Appearance.Options.UseFont = true;
      this.birimCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimCombo.Properties.NullText = "";
      this.birimCombo.Properties.PopupView = (ColumnView) this.gridView1;
      this.birimCombo.Size = new Size(263, 26);
      this.birimCombo.StyleController = (IStyleController) this.layoutControl1;
      this.birimCombo.TabIndex = 5;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Adı";
      this.gridColumn2.FieldName = "BELDBIRIMADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.textEdit8.Location = new Point(487, 12);
      this.textEdit8.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit8.Name = "textEdit8";
      this.textEdit8.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit8.Properties.Appearance.Options.UseFont = true;
      this.textEdit8.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.textEdit8.Properties.NullText = "";
      this.textEdit8.Properties.PopupView = (ColumnView) this.gridView2;
      this.textEdit8.Size = new Size(262, 26);
      this.textEdit8.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit8.TabIndex = 11;
      this.gridView2.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Adı";
      this.gridColumn3.FieldName = "BELDMUDURLUK";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.textEdit9.Location = new Point(487, 42);
      this.textEdit9.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit9.Name = "textEdit9";
      this.textEdit9.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit9.Properties.Appearance.Options.UseFont = true;
      this.textEdit9.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.textEdit9.Properties.NullText = "";
      this.textEdit9.Properties.PopupView = (ColumnView) this.gridView3;
      this.textEdit9.Size = new Size(262, 26);
      this.textEdit9.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit9.TabIndex = 12;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Ad Soyad";
      this.gridColumn4.FieldName = "ADISOYADI";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.bildirilenariza.Location = new Point(134, 253);
      this.bildirilenariza.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bildirilenariza.Name = "bildirilenariza";
      this.bildirilenariza.Properties.ScrollBars = ScrollBars.None;
      this.bildirilenariza.Size = new Size(252, 51);
      this.bildirilenariza.StyleController = (IStyleController) this.layoutControl1;
      this.bildirilenariza.TabIndex = 19;
      this.motoryag.Location = new Point(974, 165);
      this.motoryag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motoryag.Name = "motoryag";
      this.motoryag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motoryag.Properties.Appearance.Options.UseFont = true;
      this.motoryag.Properties.Mask.EditMask = "n0";
      this.motoryag.Properties.Mask.MaskType = MaskType.Numeric;
      this.motoryag.Size = new Size(144, 26);
      this.motoryag.StyleController = (IStyleController) this.layoutControl1;
      this.motoryag.TabIndex = 31;
      this.sanzimanyag.Location = new Point(974, 225);
      this.sanzimanyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sanzimanyag.Name = "sanzimanyag";
      this.sanzimanyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sanzimanyag.Properties.Appearance.Options.UseFont = true;
      this.sanzimanyag.Properties.Mask.EditMask = "n0";
      this.sanzimanyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.sanzimanyag.Size = new Size(144, 26);
      this.sanzimanyag.StyleController = (IStyleController) this.layoutControl1;
      this.sanzimanyag.TabIndex = 32;
      this.bakimozeti.Location = new Point(495, (int) byte.MaxValue);
      this.bakimozeti.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimozeti.Name = "bakimozeti";
      this.bakimozeti.Properties.ScrollBars = ScrollBars.None;
      this.bakimozeti.Size = new Size(623, 49);
      this.bakimozeti.StyleController = (IStyleController) this.layoutControl1;
      this.bakimozeti.TabIndex = 30;
      this.bakimturu.Location = new Point(495, 225);
      this.bakimturu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimturu.Name = "bakimturu";
      this.bakimturu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimturu.Properties.Appearance.Options.UseFont = true;
      this.bakimturu.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimturu.Properties.Items.AddRange(new object[5]
      {
        (object) "Genel Arıza",
        (object) "Muayene Bakım",
        (object) "Yağ Eksiltme",
        (object) "Yağ Bakımı",
        (object) "Atölye İhtiyaç"
      });
      this.bakimturu.Size = new Size(138, 26);
      this.bakimturu.StyleController = (IStyleController) this.layoutControl1;
      this.bakimturu.TabIndex = 26;
      this.atolyesefi.Location = new Point(855, 42);
      this.atolyesefi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyesefi.Name = "atolyesefi";
      this.atolyesefi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyesefi.Properties.Appearance.Options.UseFont = true;
      this.atolyesefi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyesefi.Properties.NullText = "";
      this.atolyesefi.Properties.PopupView = (ColumnView) this.gridView5;
      this.atolyesefi.Size = new Size(263, 26);
      this.atolyesefi.StyleController = (IStyleController) this.layoutControl1;
      this.atolyesefi.TabIndex = 28;
      this.gridView5.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Adı Soyadı";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.arizanedeni.Location = new Point(741, 225);
      this.arizanedeni.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.arizanedeni.Name = "arizanedeni";
      this.arizanedeni.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizanedeni.Properties.Items.AddRange(new object[3]
      {
        (object) "Kullanıcı Hatası",
        (object) "Araç Yıpranmış",
        (object) "İş Güçlüğü"
      });
      this.arizanedeni.Size = new Size(112, 22);
      this.arizanedeni.StyleController = (IStyleController) this.layoutControl1;
      this.arizanedeni.TabIndex = 24;
      this.bakimyeri.Location = new Point(495, 195);
      this.bakimyeri.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimyeri.Name = "bakimyeri";
      this.bakimyeri.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimyeri.Properties.Appearance.Options.UseFont = true;
      this.bakimyeri.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimyeri.Properties.NullText = "";
      this.bakimyeri.Size = new Size(358, 26);
      this.bakimyeri.StyleController = (IStyleController) this.layoutControl1;
      this.bakimyeri.TabIndex = 14;
      this.isemirturu.Location = new Point(134, 223);
      this.isemirturu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemirturu.Name = "isemirturu";
      this.isemirturu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemirturu.Properties.Appearance.Options.UseFont = true;
      this.isemirturu.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isemirturu.Properties.NullText = "";
      this.isemirturu.Properties.PopupSizeable = false;
      this.isemirturu.Size = new Size(252, 26);
      this.isemirturu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirturu.TabIndex = 22;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[25]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.difransiyel,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.simpleLabelItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem21
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1130, 316);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.plakaCombo;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem1.Size = new Size(373, 30);
      this.layoutControlItem1.Text = "Araç Plaka";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(118, 21);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.isemirturu;
      this.layoutControlItem19.Location = new Point(0, 211);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem19.Size = new Size(378, 30);
      this.layoutControlItem19.Text = "İş Emir Durum";
      this.layoutControlItem19.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem19.TextSize = new Size(120, 16);
      this.layoutControlItem19.TextToControlDistance = 2;
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.textEdit9;
      this.layoutControlItem9.Location = new Point(373, 30);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(368, 30);
      this.layoutControlItem9.Text = "Araç Şoförü";
      this.layoutControlItem9.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem9.TextSize = new Size(100, 20);
      this.layoutControlItem9.TextToControlDistance = 2;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.isemirkodu;
      this.layoutControlItem5.Location = new Point(0, 91);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(378, 30);
      this.layoutControlItem5.Text = "İş Emir Kodu";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem5.TextSize = new Size(120, 16);
      this.layoutControlItem5.TextToControlDistance = 2;
      this.difransiyel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyel.AppearanceItemCaption.Options.UseFont = true;
      this.difransiyel.Control = (Control) this.difransiyelyag;
      this.difransiyel.Location = new Point(845, 183);
      this.difransiyel.Name = "difransiyel";
      this.difransiyel.Size = new Size(265, 30);
      this.difransiyel.Text = "Difrensiyel Yağ";
      this.difransiyel.TextAlignMode = TextAlignModeItem.CustomSize;
      this.difransiyel.TextSize = new Size(115, 16);
      this.difransiyel.TextToControlDistance = 2;
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.bakimKMsaat;
      this.layoutControlItem18.Location = new Point(0, 181);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(378, 30);
      this.layoutControlItem18.Text = "Bakım KM/Saat";
      this.layoutControlItem18.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem18.TextSize = new Size(120, 16);
      this.layoutControlItem18.TextToControlDistance = 2;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.textEdit3;
      this.layoutControlItem3.Location = new Point(0, 60);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem3.Size = new Size(1110, 31);
      this.layoutControlItem3.Text = "Araç Açıklama";
      this.layoutControlItem3.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem3.TextSize = new Size(120, 16);
      this.layoutControlItem3.TextToControlDistance = 2;
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.no;
      this.layoutControlItem26.Location = new Point(378, 91);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem26.Size = new Size(467, 30);
      this.layoutControlItem26.Text = "No";
      this.layoutControlItem26.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem26.TextSize = new Size(100, 16);
      this.layoutControlItem26.TextToControlDistance = 5;
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.bakimyeri;
      this.layoutControlItem11.Location = new Point(378, 183);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(467, 30);
      this.layoutControlItem11.Text = "Bakım  Yeri";
      this.layoutControlItem11.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem11.TextSize = new Size(100, 16);
      this.layoutControlItem11.TextToControlDistance = 5;
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.bildirilenariza;
      this.layoutControlItem16.Location = new Point(0, 241);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem16.Size = new Size(378, 55);
      this.layoutControlItem16.Text = "Bildirilen Arıza";
      this.layoutControlItem16.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem16.TextSize = new Size(120, 16);
      this.layoutControlItem16.TextToControlDistance = 2;
      this.simpleLabelItem1.AllowHotTrack = false;
      this.simpleLabelItem1.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
      this.simpleLabelItem1.Location = new Point(845, 91);
      this.simpleLabelItem1.Name = "simpleLabelItem1";
      this.simpleLabelItem1.Size = new Size(265, 30);
      this.simpleLabelItem1.Text = "Sonraki Bakım Km Bilgisi";
      this.simpleLabelItem1.TextSize = new Size(252, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.motoryag;
      this.layoutControlItem4.Location = new Point(845, 153);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(265, 30);
      this.layoutControlItem4.Text = "Motor Yağ";
      this.layoutControlItem4.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem4.TextSize = new Size(115, 16);
      this.layoutControlItem4.TextToControlDistance = 2;
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.sanzimanyag;
      this.layoutControlItem12.Location = new Point(845, 213);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(265, 30);
      this.layoutControlItem12.Text = "Şanzıman Yağ";
      this.layoutControlItem12.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem12.TextSize = new Size(115, 16);
      this.layoutControlItem12.TextToControlDistance = 2;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.dateEdit1;
      this.layoutControlItem20.Location = new Point(0, 121);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(378, 30);
      this.layoutControlItem20.Text = "Giriş Tarihi";
      this.layoutControlItem20.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem20.TextSize = new Size(120, 16);
      this.layoutControlItem20.TextToControlDistance = 2;
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.dateEdit2;
      this.layoutControlItem6.Location = new Point(0, 151);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(378, 30);
      this.layoutControlItem6.Text = "Çıkış Tarihi";
      this.layoutControlItem6.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem6.TextSize = new Size(120, 16);
      this.layoutControlItem6.TextToControlDistance = 2;
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.timeSpanEdit1;
      this.layoutControlItem22.Location = new Point(378, 121);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(467, 32);
      this.layoutControlItem22.Text = "Giriş Saati";
      this.layoutControlItem22.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem22.TextSize = new Size(100, 16);
      this.layoutControlItem22.TextToControlDistance = 5;
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.timeSpanEdit2;
      this.layoutControlItem7.Location = new Point(378, 153);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(467, 30);
      this.layoutControlItem7.Text = "Çıkış Saati";
      this.layoutControlItem7.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem7.TextSize = new Size(100, 16);
      this.layoutControlItem7.TextToControlDistance = 5;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.genelbakim;
      this.layoutControlItem14.Location = new Point(845, 121);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(265, 32);
      this.layoutControlItem14.Text = "Genek Bakım";
      this.layoutControlItem14.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem14.TextSize = new Size(115, 16);
      this.layoutControlItem14.TextToControlDistance = 2;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.textEdit8;
      this.layoutControlItem8.Location = new Point(373, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(368, 30);
      this.layoutControlItem8.Text = "Müdürlük";
      this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem8.TextSize = new Size(100, 20);
      this.layoutControlItem8.TextToControlDistance = 2;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.aracigetiren;
      this.layoutControlItem10.Location = new Point(0, 30);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(373, 30);
      this.layoutControlItem10.Text = "Araçı Getiren";
      this.layoutControlItem10.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem10.TextSize = new Size(120, 16);
      this.layoutControlItem10.TextToControlDistance = 2;
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.bakimozeti;
      this.layoutControlItem27.Location = new Point(378, 243);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(732, 53);
      this.layoutControlItem27.Text = "Bakım Özeti";
      this.layoutControlItem27.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem27.TextSize = new Size(100, 16);
      this.layoutControlItem27.TextToControlDistance = 5;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.birimCombo;
      this.layoutControlItem2.Location = new Point(741, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(369, 30);
      this.layoutControlItem2.Text = "Birim";
      this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem2.TextSize = new Size(100, 16);
      this.layoutControlItem2.TextToControlDistance = 2;
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.atolyesefi;
      this.layoutControlItem25.Location = new Point(741, 30);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(369, 30);
      this.layoutControlItem25.Text = "Atölye Şefi";
      this.layoutControlItem25.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem25.TextSize = new Size(100, 16);
      this.layoutControlItem25.TextToControlDistance = 2;
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.bakimturu;
      this.layoutControlItem23.Location = new Point(378, 213);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem23.Size = new Size(247, 30);
      this.layoutControlItem23.Text = "Bakım Türü";
      this.layoutControlItem23.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem23.TextSize = new Size(100, 16);
      this.layoutControlItem23.TextToControlDistance = 5;
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.Control = (Control) this.arizanedeni;
      this.layoutControlItem21.Location = new Point(625, 213);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(220, 30);
      this.layoutControlItem21.Text = "Arıza nedeni";
      this.layoutControlItem21.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem21.TextSize = new Size(102, 16);
      this.layoutControlItem21.TextToControlDistance = 2;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1130, 693);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (GuncelleFormu);
      this.Text = "Guncelle";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.araclarListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.genelbakim.Properties.EndInit();
      this.timeSpanEdit2.Properties.EndInit();
      this.timeSpanEdit1.Properties.EndInit();
      this.dateEdit2.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit2.Properties.EndInit();
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.isemirkodu.Properties.EndInit();
      this.aracigetiren.Properties.EndInit();
      this.difransiyelyag.Properties.EndInit();
      this.bakimKMsaat.Properties.EndInit();
      this.no.Properties.EndInit();
      this.plakaCombo.Properties.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.textEdit3.Properties.EndInit();
      this.birimCombo.Properties.EndInit();
      this.gridView1.EndInit();
      this.textEdit8.Properties.EndInit();
      this.gridView2.EndInit();
      this.textEdit9.Properties.EndInit();
      this.gridView3.EndInit();
      this.bildirilenariza.Properties.EndInit();
      this.motoryag.Properties.EndInit();
      this.sanzimanyag.Properties.EndInit();
      this.bakimozeti.Properties.EndInit();
      this.bakimturu.Properties.EndInit();
      this.atolyesefi.Properties.EndInit();
      this.gridView5.EndInit();
      this.arizanedeni.Properties.EndInit();
      this.bakimyeri.Properties.EndInit();
      this.isemirturu.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem5.EndInit();
      this.difransiyel.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem16.EndInit();
      this.simpleLabelItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem21.EndInit();
      this.emptySpaceItem1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
