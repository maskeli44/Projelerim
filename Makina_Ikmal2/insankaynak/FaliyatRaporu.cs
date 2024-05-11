// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.FaliyatRaporu
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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class FaliyatRaporu : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int son_id;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
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
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup1;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private LayoutControlItem layoutControlItem14;
    private BarButtonItem barButtonItem21;
    private BarButtonItem barButtonItem22;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem23;
    private TextEdit AyiTxt;
    private TextEdit YiliTxt;
    private TextEdit bakimAraziLook;
    private TextEdit BakimDisServisLook;
    private TextEdit YagbakimLook;
    private TextEdit SigortaLook;
    private TextEdit MuayeneLook;
    private TextEdit baik_resmiLook;
    private TextEdit baik_HizmetLook;
    private TextEdit YakitAlimiMotorinLook;
    private TextEdit YakitAlimiBenzinLook;
    private TextEdit bakimAtolyelook;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private SearchLookUpEdit SubeMudurllook;
    private GridView searchLookUpEdit1View;
    private TextEdit rkayik_motrinLook;
    private TextEdit rkayik_benzinLook1;
    private LayoutControlItem layoutControlItem15;

    public FaliyatRaporu() => this.InitializeComponent();

    private void YetkiliImzaAyarlamasi_Load(object sender, EventArgs e)
    {
      this.SubeMudurllook.EditValue = (object) sorumlu.subemuduru;
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet6.TBLPERSONEL);
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.GuncelLoad();
    }

    private void GuncelLoad()
    {
      FAALIYET faaliyet = this.db.FAALIYET.FirstOrDefault<FAALIYET>((Expression<System.Func<FAALIYET, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.MuayeneLook.EditValue = (object) faaliyet.MUAYENE;
      this.baik_resmiLook.EditValue = (object) faaliyet.BAIKRESMI;
      this.baik_HizmetLook.Text = faaliyet.BAIKHIZMET.ToString();
      this.bakimAtolyelook.EditValue = (object) faaliyet.ARACBAKIMATOLYE;
      this.bakimAraziLook.EditValue = (object) faaliyet.ARACBAKIMARAZI;
      this.BakimDisServisLook.EditValue = (object) faaliyet.ARACBAKIMDIS;
      this.SigortaLook.EditValue = (object) faaliyet.ZORUNLUTRFKSIGORTA;
      this.YagbakimLook.EditValue = (object) faaliyet.YAGBAKIM;
      this.baik_resmiLook.Text = faaliyet.BAIKRESMI.ToString();
      this.YakitAlimiMotorinLook.Text = faaliyet.YAKITMOTORIN.ToString();
      this.YakitAlimiBenzinLook.Text = faaliyet.YAKITBENZIN.ToString();
      this.rkayik_motrinLook.Text = faaliyet.RESMIKIRALIKMOTORIN.ToString();
      this.rkayik_benzinLook1.Text = faaliyet.RESMIKIRALIKBENZIN.ToString();
      this.YiliTxt.Text = faaliyet.YILI;
      this.AyiTxt.Text = faaliyet.AYI;
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.secim == "guncelle" && YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        LogEkle.Logs("Guncelleme Yapti");
        this.guncelle();
      }
      else if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
      {
        LogEkle.Logs("Ekleme Yapti");
        this.kaydet();
      }
      ((ToplantiListesi) Application.OpenForms["ToplantiListesi"])?.listele();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void kaydet()
    {
      FAALIYET entity = new FAALIYET();
      try
      {
        if (this.bakimAtolyelook.Text != "")
          entity.ARACBAKIMATOLYE = new int?(Convert.ToInt32(this.bakimAtolyelook.Text));
        if (this.bakimAraziLook.Text != "")
          entity.ARACBAKIMARAZI = new int?(Convert.ToInt32(this.bakimAraziLook.Text));
        if (this.BakimDisServisLook.Text != "")
          entity.ARACBAKIMDIS = new int?(Convert.ToInt32(this.BakimDisServisLook.Text));
        if (this.YagbakimLook.Text != "")
          entity.YAGBAKIM = new int?(Convert.ToInt32(this.YagbakimLook.Text));
        if (this.SigortaLook.Text != "")
          entity.ZORUNLUTRFKSIGORTA = new int?(Convert.ToInt32(this.SigortaLook.Text));
        if (this.MuayeneLook.Text != "")
          entity.MUAYENE = new int?(Convert.ToInt32(this.MuayeneLook.Text));
        if (this.baik_resmiLook.Text != "")
          entity.BAIKRESMI = new int?(Convert.ToInt32(this.baik_resmiLook.Text));
        if (this.baik_HizmetLook.Text != "")
          entity.BAIKHIZMET = new int?(Convert.ToInt32(this.baik_HizmetLook.Text));
        if (this.YakitAlimiMotorinLook.Text != "")
          entity.YAKITMOTORIN = new Decimal?(Convert.ToDecimal(this.YakitAlimiMotorinLook.Text));
        if (this.YakitAlimiBenzinLook.Text != "")
          entity.YAKITBENZIN = new Decimal?(Convert.ToDecimal(this.YakitAlimiBenzinLook.Text));
        if (this.rkayik_motrinLook.Text != "")
          entity.RESMIKIRALIKMOTORIN = new Decimal?(Convert.ToDecimal(this.rkayik_motrinLook.Text));
        if (this.rkayik_benzinLook1.Text != "")
          entity.RESMIKIRALIKBENZIN = new Decimal?(Convert.ToDecimal(this.rkayik_benzinLook1.Text));
        if (this.YiliTxt.Text != "")
          entity.YILI = this.YiliTxt.Text;
        if (this.AyiTxt.Text != "")
          entity.AYI = this.AyiTxt.Text;
        if (this.SubeMudurllook.Text != "")
          entity.SUBEMUDURU = new int?(Convert.ToInt32(this.SubeMudurllook.EditValue));
        this.db.FAALIYET.Add(entity);
        this.db.SaveChanges();
        YetkiClass.secim_id = int.Parse(this.db.FAALIYET.OrderByDescending<FAALIYET, int>((Expression<System.Func<FAALIYET, int>>) (p => p.ID)).Select<FAALIYET, int>((Expression<System.Func<FAALIYET, int>>) (r => r.ID)).First<int>().ToString());
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
        YetkiClass.secim = "guncelle";
        this.GuncelLoad();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void guncelle()
    {
      FAALIYET faaliyet = this.db.FAALIYET.FirstOrDefault<FAALIYET>((Expression<System.Func<FAALIYET, bool>>) (x => x.ID == YetkiClass.secim_id));
      try
      {
        if (this.bakimAtolyelook.Text != "")
          faaliyet.ARACBAKIMATOLYE = new int?(Convert.ToInt32(this.bakimAtolyelook.Text));
        if (this.bakimAraziLook.Text != "")
          faaliyet.ARACBAKIMARAZI = new int?(Convert.ToInt32(this.bakimAraziLook.Text));
        if (this.BakimDisServisLook.Text != "")
          faaliyet.ARACBAKIMDIS = new int?(Convert.ToInt32(this.BakimDisServisLook.Text));
        if (this.YagbakimLook.Text != "")
          faaliyet.YAGBAKIM = new int?(Convert.ToInt32(this.YagbakimLook.Text));
        if (this.SigortaLook.Text != "")
          faaliyet.ZORUNLUTRFKSIGORTA = new int?(Convert.ToInt32(this.SigortaLook.Text));
        if (this.MuayeneLook.Text != "")
          faaliyet.MUAYENE = new int?(Convert.ToInt32(this.MuayeneLook.Text));
        if (this.baik_resmiLook.Text != "")
          faaliyet.BAIKRESMI = new int?(Convert.ToInt32(this.baik_resmiLook.Text));
        if (this.baik_HizmetLook.Text != "")
          faaliyet.BAIKHIZMET = new int?(Convert.ToInt32(this.baik_HizmetLook.Text));
        if (this.YakitAlimiMotorinLook.Text != "")
          faaliyet.YAKITMOTORIN = new Decimal?(Convert.ToDecimal(this.YakitAlimiMotorinLook.Text));
        if (this.YakitAlimiBenzinLook.Text != "")
          faaliyet.YAKITBENZIN = new Decimal?(Convert.ToDecimal(this.YakitAlimiBenzinLook.Text));
        if (this.rkayik_motrinLook.Text != "")
          faaliyet.RESMIKIRALIKMOTORIN = new Decimal?(Convert.ToDecimal(this.rkayik_motrinLook.Text));
        if (this.rkayik_benzinLook1.Text != "")
          faaliyet.RESMIKIRALIKBENZIN = new Decimal?(Convert.ToDecimal(this.rkayik_benzinLook1.Text));
        if (this.YiliTxt.Text != "")
          faaliyet.YILI = this.YiliTxt.Text;
        if (this.AyiTxt.Text != "")
          faaliyet.AYI = this.AyiTxt.Text;
        if (this.SubeMudurllook.Text != "")
          faaliyet.SUBEMUDURU = new int?(Convert.ToInt32(this.SubeMudurllook.EditValue));
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
        YetkiClass.secim = nameof (guncelle);
        this.GuncelLoad();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void sil()
    {
      try
      {
        this.db.FAALIYET.Remove(this.db.FAALIYET.FirstOrDefault<FAALIYET>((Expression<System.Func<FAALIYET, bool>>) (x => x.ID == YetkiClass.secim_id)));
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
    {
      FaaliyetRaporYazdir faaliyetRaporYazdir = new FaaliyetRaporYazdir();
      faaliyetRaporYazdir.Parameters["id"].Value = (object) YetkiClass.secim_id;
      faaliyetRaporYazdir.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) faaliyetRaporYazdir).Print();
    }

    private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
    {
      FaaliyetRaporYazdir faaliyetRaporYazdir = new FaaliyetRaporYazdir();
      faaliyetRaporYazdir.Parameters["id"].Value = (object) YetkiClass.secim_id;
      faaliyetRaporYazdir.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) faaliyetRaporYazdir).ShowPreviewDialog();
    }

    private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (XtraMessageBox.Show("Silmek istediğinizden eminmisiniz", "UYARI", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.sil();
      int num = (int) XtraMessageBox.Show("Silme işlemi başarlı bir şekilde gerçekleşti.");
      this.Close();
      ((ToplantiListesi) Application.OpenForms["ToplantiListesi"])?.listele();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FaliyatRaporu));
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
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem21 = new BarButtonItem();
      this.barButtonItem22 = new BarButtonItem();
      this.barButtonItem23 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.SubeMudurllook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.searchLookUpEdit1View = new GridView();
      this.AyiTxt = new TextEdit();
      this.YiliTxt = new TextEdit();
      this.bakimAraziLook = new TextEdit();
      this.BakimDisServisLook = new TextEdit();
      this.YagbakimLook = new TextEdit();
      this.SigortaLook = new TextEdit();
      this.MuayeneLook = new TextEdit();
      this.baik_resmiLook = new TextEdit();
      this.baik_HizmetLook = new TextEdit();
      this.YakitAlimiMotorinLook = new TextEdit();
      this.YakitAlimiBenzinLook = new TextEdit();
      this.bakimAtolyelook = new TextEdit();
      this.rkayik_motrinLook = new TextEdit();
      this.rkayik_benzinLook1 = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.SubeMudurllook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.AyiTxt.Properties.BeginInit();
      this.YiliTxt.Properties.BeginInit();
      this.bakimAraziLook.Properties.BeginInit();
      this.BakimDisServisLook.Properties.BeginInit();
      this.YagbakimLook.Properties.BeginInit();
      this.SigortaLook.Properties.BeginInit();
      this.MuayeneLook.Properties.BeginInit();
      this.baik_resmiLook.Properties.BeginInit();
      this.baik_HizmetLook.Properties.BeginInit();
      this.YakitAlimiMotorinLook.Properties.BeginInit();
      this.YakitAlimiBenzinLook.Properties.BeginInit();
      this.bakimAtolyelook.Properties.BeginInit();
      this.rkayik_motrinLook.Properties.BeginInit();
      this.rkayik_benzinLook1.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[32]
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
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem21,
        (BarItem) this.barButtonItem22,
        (BarItem) this.barButtonItem23
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 33;
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
      this.ribbonControl1.Size = new Size(897, 100);
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
      this.barButtonItem13.Caption = "Filtrele";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barEditItem1.AccessibleDescription = "Kayıt Bul...";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
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
      this.barButtonItem17.Caption = "Excel";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem1.Caption = "Karne Yazdır";
      this.barButtonItem1.Id = 28;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem2.Caption = "Kaydet";
      this.barButtonItem2.Id = 29;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem21.Caption = "Sil";
      this.barButtonItem21.Id = 30;
      this.barButtonItem21.ImageOptions.Image = (Image) Resources.clearvalidationcircles_32x32;
      this.barButtonItem21.ImageOptions.LargeImage = (Image) Resources.clearvalidationcircles_32x32;
      this.barButtonItem21.LargeWidth = 100;
      this.barButtonItem21.Name = "barButtonItem21";
      this.barButtonItem21.ItemClick += new ItemClickEventHandler(this.barButtonItem21_ItemClick);
      this.barButtonItem22.Caption = "Yazdır";
      this.barButtonItem22.Id = 31;
      this.barButtonItem22.ImageOptions.Image = (Image) Resources.printer_16x16;
      this.barButtonItem22.ImageOptions.LargeImage = (Image) Resources.printer_32x32;
      this.barButtonItem22.LargeWidth = 100;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barButtonItem22.ItemClick += new ItemClickEventHandler(this.barButtonItem22_ItemClick);
      this.barButtonItem23.Caption = "Önizleme";
      this.barButtonItem23.Id = 32;
      this.barButtonItem23.ImageOptions.Image = (Image) Resources.preview_16x163;
      this.barButtonItem23.ImageOptions.LargeImage = (Image) Resources.preview_32x323;
      this.barButtonItem23.LargeWidth = 100;
      this.barButtonItem23.Name = "barButtonItem23";
      this.barButtonItem23.ItemClick += new ItemClickEventHandler(this.barButtonItem23_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup4,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem21);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem22);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem23);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "ribbonPageGroup2";
      this.layoutControl1.Controls.Add((Control) this.SubeMudurllook);
      this.layoutControl1.Controls.Add((Control) this.AyiTxt);
      this.layoutControl1.Controls.Add((Control) this.YiliTxt);
      this.layoutControl1.Controls.Add((Control) this.bakimAraziLook);
      this.layoutControl1.Controls.Add((Control) this.BakimDisServisLook);
      this.layoutControl1.Controls.Add((Control) this.YagbakimLook);
      this.layoutControl1.Controls.Add((Control) this.SigortaLook);
      this.layoutControl1.Controls.Add((Control) this.MuayeneLook);
      this.layoutControl1.Controls.Add((Control) this.baik_resmiLook);
      this.layoutControl1.Controls.Add((Control) this.baik_HizmetLook);
      this.layoutControl1.Controls.Add((Control) this.YakitAlimiMotorinLook);
      this.layoutControl1.Controls.Add((Control) this.YakitAlimiBenzinLook);
      this.layoutControl1.Controls.Add((Control) this.bakimAtolyelook);
      this.layoutControl1.Controls.Add((Control) this.rkayik_motrinLook);
      this.layoutControl1.Controls.Add((Control) this.rkayik_benzinLook1);
      this.layoutControl1.Location = new Point(0, 115);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(880, 434);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.SubeMudurllook.EditValue = (object) "";
      this.SubeMudurllook.Location = new Point(438, 402);
      this.SubeMudurllook.Margin = new Padding(3, 2, 3, 2);
      this.SubeMudurllook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SubeMudurllook.Name = "SubeMudurllook";
      this.SubeMudurllook.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SubeMudurllook.Properties.Appearance.Options.UseFont = true;
      this.SubeMudurllook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.SubeMudurllook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.SubeMudurllook.Properties.DisplayMember = "ADISOYADI";
      this.SubeMudurllook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.SubeMudurllook.Properties.ValueMember = "ID";
      this.SubeMudurllook.Size = new Size(414, 24);
      this.SubeMudurllook.StyleController = (IStyleController) this.layoutControl1;
      this.SubeMudurllook.TabIndex = 17;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.DetailHeight = 284;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.AyiTxt.Location = new Point(438, 374);
      this.AyiTxt.Margin = new Padding(3, 2, 3, 2);
      this.AyiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AyiTxt.Name = "AyiTxt";
      this.AyiTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AyiTxt.Properties.Appearance.Options.UseFont = true;
      this.AyiTxt.Size = new Size(414, 24);
      this.AyiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.AyiTxt.TabIndex = 16;
      this.YiliTxt.Location = new Point(438, 346);
      this.YiliTxt.Margin = new Padding(3, 2, 3, 2);
      this.YiliTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.YiliTxt.Name = "YiliTxt";
      this.YiliTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YiliTxt.Properties.Appearance.Options.UseFont = true;
      this.YiliTxt.Size = new Size(414, 24);
      this.YiliTxt.StyleController = (IStyleController) this.layoutControl1;
      this.YiliTxt.TabIndex = 15;
      this.bakimAraziLook.EditValue = (object) "";
      this.bakimAraziLook.Location = new Point(438, 38);
      this.bakimAraziLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimAraziLook.Name = "bakimAraziLook";
      this.bakimAraziLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimAraziLook.Properties.Appearance.Options.UseFont = true;
      this.bakimAraziLook.Properties.NullText = "[EditValue is null]";
      this.bakimAraziLook.Size = new Size(414, 24);
      this.bakimAraziLook.StyleController = (IStyleController) this.layoutControl1;
      this.bakimAraziLook.TabIndex = 5;
      this.BakimDisServisLook.EditValue = (object) "";
      this.BakimDisServisLook.Location = new Point(438, 66);
      this.BakimDisServisLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.BakimDisServisLook.Name = "BakimDisServisLook";
      this.BakimDisServisLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.BakimDisServisLook.Properties.Appearance.Options.UseFont = true;
      this.BakimDisServisLook.Properties.NullText = "[EditValue is null]";
      this.BakimDisServisLook.Size = new Size(414, 24);
      this.BakimDisServisLook.StyleController = (IStyleController) this.layoutControl1;
      this.BakimDisServisLook.TabIndex = 6;
      this.YagbakimLook.EditValue = (object) "";
      this.YagbakimLook.Location = new Point(438, 94);
      this.YagbakimLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.YagbakimLook.Name = "YagbakimLook";
      this.YagbakimLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YagbakimLook.Properties.Appearance.Options.UseFont = true;
      this.YagbakimLook.Properties.NullText = "[EditValue is null]";
      this.YagbakimLook.Size = new Size(414, 24);
      this.YagbakimLook.StyleController = (IStyleController) this.layoutControl1;
      this.YagbakimLook.TabIndex = 7;
      this.SigortaLook.EditValue = (object) "";
      this.SigortaLook.Location = new Point(438, 122);
      this.SigortaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SigortaLook.Name = "SigortaLook";
      this.SigortaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SigortaLook.Properties.Appearance.Options.UseFont = true;
      this.SigortaLook.Properties.NullText = "[EditValue is null]";
      this.SigortaLook.Size = new Size(414, 24);
      this.SigortaLook.StyleController = (IStyleController) this.layoutControl1;
      this.SigortaLook.TabIndex = 8;
      this.MuayeneLook.EditValue = (object) "";
      this.MuayeneLook.Location = new Point(438, 150);
      this.MuayeneLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.MuayeneLook.Name = "MuayeneLook";
      this.MuayeneLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.MuayeneLook.Properties.Appearance.Options.UseFont = true;
      this.MuayeneLook.Properties.NullText = "[EditValue is null]";
      this.MuayeneLook.Size = new Size(414, 24);
      this.MuayeneLook.StyleController = (IStyleController) this.layoutControl1;
      this.MuayeneLook.TabIndex = 9;
      this.baik_resmiLook.EditValue = (object) "";
      this.baik_resmiLook.Location = new Point(438, 178);
      this.baik_resmiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.baik_resmiLook.Name = "baik_resmiLook";
      this.baik_resmiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.baik_resmiLook.Properties.Appearance.Options.UseFont = true;
      this.baik_resmiLook.Properties.NullText = "[EditValue is null]";
      this.baik_resmiLook.Size = new Size(414, 24);
      this.baik_resmiLook.StyleController = (IStyleController) this.layoutControl1;
      this.baik_resmiLook.TabIndex = 10;
      this.baik_HizmetLook.EditValue = (object) "";
      this.baik_HizmetLook.Location = new Point(438, 206);
      this.baik_HizmetLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.baik_HizmetLook.Name = "baik_HizmetLook";
      this.baik_HizmetLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.baik_HizmetLook.Properties.Appearance.Options.UseFont = true;
      this.baik_HizmetLook.Properties.NullText = "[EditValue is null]";
      this.baik_HizmetLook.Size = new Size(414, 24);
      this.baik_HizmetLook.StyleController = (IStyleController) this.layoutControl1;
      this.baik_HizmetLook.TabIndex = 11;
      this.YakitAlimiMotorinLook.EditValue = (object) "";
      this.YakitAlimiMotorinLook.Location = new Point(438, 234);
      this.YakitAlimiMotorinLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.YakitAlimiMotorinLook.Name = "YakitAlimiMotorinLook";
      this.YakitAlimiMotorinLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YakitAlimiMotorinLook.Properties.Appearance.Options.UseFont = true;
      this.YakitAlimiMotorinLook.Properties.Mask.EditMask = "n";
      this.YakitAlimiMotorinLook.Properties.Mask.MaskType = MaskType.Numeric;
      this.YakitAlimiMotorinLook.Properties.NullText = "[EditValue is null]";
      this.YakitAlimiMotorinLook.Size = new Size(414, 24);
      this.YakitAlimiMotorinLook.StyleController = (IStyleController) this.layoutControl1;
      this.YakitAlimiMotorinLook.TabIndex = 12;
      this.YakitAlimiBenzinLook.EditValue = (object) "";
      this.YakitAlimiBenzinLook.Location = new Point(438, 262);
      this.YakitAlimiBenzinLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.YakitAlimiBenzinLook.Name = "YakitAlimiBenzinLook";
      this.YakitAlimiBenzinLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YakitAlimiBenzinLook.Properties.Appearance.Options.UseFont = true;
      this.YakitAlimiBenzinLook.Properties.Mask.EditMask = "n";
      this.YakitAlimiBenzinLook.Properties.Mask.MaskType = MaskType.Numeric;
      this.YakitAlimiBenzinLook.Properties.NullText = "[EditValue is null]";
      this.YakitAlimiBenzinLook.Size = new Size(414, 24);
      this.YakitAlimiBenzinLook.StyleController = (IStyleController) this.layoutControl1;
      this.YakitAlimiBenzinLook.TabIndex = 13;
      this.bakimAtolyelook.EditValue = (object) "";
      this.bakimAtolyelook.Location = new Point(438, 10);
      this.bakimAtolyelook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimAtolyelook.Name = "bakimAtolyelook";
      this.bakimAtolyelook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimAtolyelook.Properties.Appearance.Options.UseFont = true;
      this.bakimAtolyelook.Properties.NullText = "[EditValue is null]";
      this.bakimAtolyelook.Size = new Size(414, 24);
      this.bakimAtolyelook.StyleController = (IStyleController) this.layoutControl1;
      this.bakimAtolyelook.TabIndex = 4;
      this.rkayik_motrinLook.EditValue = (object) "";
      this.rkayik_motrinLook.Location = new Point(438, 290);
      this.rkayik_motrinLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.rkayik_motrinLook.Name = "rkayik_motrinLook";
      this.rkayik_motrinLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.rkayik_motrinLook.Properties.Appearance.Options.UseFont = true;
      this.rkayik_motrinLook.Properties.Mask.EditMask = "n";
      this.rkayik_motrinLook.Properties.Mask.MaskType = MaskType.Numeric;
      this.rkayik_motrinLook.Properties.NullText = "[EditValue is null]";
      this.rkayik_motrinLook.Size = new Size(414, 24);
      this.rkayik_motrinLook.StyleController = (IStyleController) this.layoutControl1;
      this.rkayik_motrinLook.TabIndex = 14;
      this.rkayik_benzinLook1.EditValue = (object) "";
      this.rkayik_benzinLook1.Location = new Point(438, 318);
      this.rkayik_benzinLook1.Name = "rkayik_benzinLook1";
      this.rkayik_benzinLook1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.rkayik_benzinLook1.Properties.Appearance.Options.UseFont = true;
      this.rkayik_benzinLook1.Properties.Mask.EditMask = "n";
      this.rkayik_benzinLook1.Properties.Mask.MaskType = MaskType.Numeric;
      this.rkayik_benzinLook1.Properties.NullText = "[EditValue is null]";
      this.rkayik_benzinLook1.Size = new Size(414, 24);
      this.rkayik_benzinLook1.StyleController = (IStyleController) this.layoutControl1;
      this.rkayik_benzinLook1.TabIndex = 14;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[15]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem15
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(863, 436);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.bakimAtolyelook;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(845, 28);
      this.layoutControlItem1.Text = "Araç Bakımı Yapılması (Atölyede)";
      this.layoutControlItem1.TextSize = new Size(424, 18);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.bakimAraziLook;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(845, 28);
      this.layoutControlItem2.Text = "Araç Bakımı Yapılması (Arazide)";
      this.layoutControlItem2.TextSize = new Size(424, 18);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.BakimDisServisLook;
      this.layoutControlItem3.Location = new Point(0, 56);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(845, 28);
      this.layoutControlItem3.Text = "Araç Bakımı Yapılması (Dış Servis)";
      this.layoutControlItem3.TextSize = new Size(424, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.YagbakimLook;
      this.layoutControlItem4.Location = new Point(0, 84);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(845, 28);
      this.layoutControlItem4.Text = "Yağ ve Filtre Bakım Onarım ve Değişim";
      this.layoutControlItem4.TextSize = new Size(424, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.SigortaLook;
      this.layoutControlItem5.Location = new Point(0, 112);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(845, 28);
      this.layoutControlItem5.Text = "Zorunlu Trafik ve Mali Sigorta Yapılması";
      this.layoutControlItem5.TextSize = new Size(424, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.MuayeneLook;
      this.layoutControlItem6.Location = new Point(0, 140);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(845, 28);
      this.layoutControlItem6.Text = "Muayene İşlemleri Yapılması";
      this.layoutControlItem6.TextSize = new Size(424, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.baik_resmiLook;
      this.layoutControlItem7.Location = new Point(0, 168);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(845, 28);
      this.layoutControlItem7.Text = "Birimlerin Araç İhtiyaçlarının Karşılanması (Resmi Araç)";
      this.layoutControlItem7.TextSize = new Size(424, 18);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.baik_HizmetLook;
      this.layoutControlItem8.Location = new Point(0, 196);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(845, 28);
      this.layoutControlItem8.Text = "Birimlerin Araç İhtiyaçlarının Karşılanması(Hizmet Alımı)";
      this.layoutControlItem8.TextSize = new Size(424, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.YakitAlimiMotorinLook;
      this.layoutControlItem9.Location = new Point(0, 224);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(845, 28);
      this.layoutControlItem9.Text = "Yakıt Alımı(Motorin)";
      this.layoutControlItem9.TextSize = new Size(424, 18);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.YakitAlimiBenzinLook;
      this.layoutControlItem10.Location = new Point(0, 252);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(845, 28);
      this.layoutControlItem10.Text = "Yakıt Alımı(Benzin)";
      this.layoutControlItem10.TextSize = new Size(424, 18);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.rkayik_motrinLook;
      this.layoutControlItem11.Location = new Point(0, 280);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(845, 28);
      this.layoutControlItem11.Text = "Resmi ve Kiralık Araçların Yakıt İhtiyacının Karşılanması (Motorin)";
      this.layoutControlItem11.TextSize = new Size(424, 18);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.rkayik_benzinLook1;
      this.layoutControlItem14.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem14.CustomizationFormText = "Oto Lastik Ustabaşı";
      this.layoutControlItem14.Location = new Point(0, 308);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem14.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem14.OptionsPrint.AppearanceItemText.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItemText.Options.UseFont = true;
      this.layoutControlItem14.Size = new Size(845, 28);
      this.layoutControlItem14.Text = "Resmi ve Kiralık Araçların Yakıt İhtiyacının Karşılanması (Benzin)";
      this.layoutControlItem14.TextSize = new Size(424, 17);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.YiliTxt;
      this.layoutControlItem12.Location = new Point(0, 336);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(845, 28);
      this.layoutControlItem12.Text = "Yılı";
      this.layoutControlItem12.TextSize = new Size(424, 17);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.Control = (Control) this.AyiTxt;
      this.layoutControlItem13.Location = new Point(0, 364);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(845, 28);
      this.layoutControlItem13.Text = "Ayı";
      this.layoutControlItem13.TextSize = new Size(424, 17);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.SubeMudurllook;
      this.layoutControlItem15.Location = new Point(0, 392);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.OptionsPrint.AppearanceItemText.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItemText.Options.UseFont = true;
      this.layoutControlItem15.Size = new Size(845, 28);
      this.layoutControlItem15.Text = "Şube Müdürü";
      this.layoutControlItem15.TextSize = new Size(424, 17);
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(897, 551);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (FaliyatRaporu);
      this.Text = "Yetkili imza Ayarlamasi";
      this.Load += new EventHandler(this.YetkiliImzaAyarlamasi_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.SubeMudurllook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.AyiTxt.Properties.EndInit();
      this.YiliTxt.Properties.EndInit();
      this.bakimAraziLook.Properties.EndInit();
      this.BakimDisServisLook.Properties.EndInit();
      this.YagbakimLook.Properties.EndInit();
      this.SigortaLook.Properties.EndInit();
      this.MuayeneLook.Properties.EndInit();
      this.baik_resmiLook.Properties.EndInit();
      this.baik_HizmetLook.Properties.EndInit();
      this.YakitAlimiMotorinLook.Properties.EndInit();
      this.YakitAlimiBenzinLook.Properties.EndInit();
      this.bakimAtolyelook.Properties.EndInit();
      this.rkayik_motrinLook.Properties.EndInit();
      this.rkayik_benzinLook1.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem15.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
