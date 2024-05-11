// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.ToplantiEkle
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
using DevExpress.XtraGrid.Columns;
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
  public class ToplantiEkle : XtraForm
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
    private SearchLookUpEdit OtolastikLook;
    private GridView searchLookUpEdit11View;
    private SearchLookUpEdit KamyonTamirLook;
    private GridView searchLookUpEdit10View;
    private SearchLookUpEdit otoelektrikLook;
    private GridView searchLookUpEdit9View;
    private SearchLookUpEdit KaynakAtolyesiSrmlsLook;
    private GridView searchLookUpEdit8View;
    private SearchLookUpEdit AkarYakitsrmlsLook;
    private GridView searchLookUpEdit7View;
    private SearchLookUpEdit ikmalBirimSorumlusuLook;
    private GridView searchLookUpEdit6View;
    private SearchLookUpEdit isMakinasiUstabasiLook;
    private GridView searchLookUpEdit5View;
    private SearchLookUpEdit AmbarsorumlusuLook;
    private GridView searchLookUpEdit4View;
    private SearchLookUpEdit atolyesefiLook;
    private GridView searchLookUpEdit3View;
    private SearchLookUpEdit yaziisleriLook;
    private GridView searchLookUpEdit2View;
    private SearchLookUpEdit yoneticilook;
    private GridView searchLookUpEdit1View;
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
    private GridColumn AdSoyad;
    private GridColumn gridColumn9;
    private GridColumn gridColumn8;
    private GridColumn gridColumn7;
    private GridColumn gridColumn6;
    private GridColumn gridColumn5;
    private GridColumn gridColumn4;
    private GridColumn gridColumn3;
    private GridColumn gridColumn2;
    private GridColumn gridColumn1;
    private GridColumn G;
    private SearchLookUpEdit AMbaraydiyatLook1;
    private GridView searchLookUpEdit11View1;
    private GridColumn gridColumn91;
    private LayoutControlItem layoutControlItem14;
    private LayoutControl layoutControl2;
    private DateEdit SonrakiTopTarihi;
    private TextEdit KararAciklmasiTxt;
    private TextEdit GundemMaddelerTxt;
    private TextEdit TpltiSuresiTxt;
    private TextEdit RaporNoTxt;
    private TextEdit daireBasKoduTxt;
    private TextEdit ToplantiKonusuTxt;
    private DateEdit ToplantiTarihi;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem12;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem17;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem20;
    private BarButtonItem barButtonItem21;
    private BarButtonItem barButtonItem22;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem23;

    public ToplantiEkle() => this.InitializeComponent();

    private void YetkiliImzaAyarlamasi_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet6.TBLPERSONEL);
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.GuncelLoad();
    }

    private void GuncelLoad()
    {
      TBLPERTOPLANTI tblpertoplanti = this.db.TBLPERTOPLANTI.FirstOrDefault<TBLPERTOPLANTI>((Expression<System.Func<TBLPERTOPLANTI, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.ikmalBirimSorumlusuLook.EditValue = (object) tblpertoplanti.IKMALBIRIMSRMLS;
      this.AkarYakitsrmlsLook.EditValue = (object) tblpertoplanti.AKARYKTSRMLS;
      this.yoneticilook.EditValue = (object) tblpertoplanti.TOPLANTIYONETICISI;
      this.yaziisleriLook.EditValue = (object) tblpertoplanti.YAZIISLERISRMLS;
      this.atolyesefiLook.EditValue = (object) tblpertoplanti.ATOLYESRMLS;
      this.isMakinasiUstabasiLook.EditValue = (object) tblpertoplanti.ISMAKINASISRMLS;
      this.AmbarsorumlusuLook.EditValue = (object) tblpertoplanti.AMBARSRMLS;
      this.KaynakAtolyesiSrmlsLook.EditValue = (object) tblpertoplanti.KAYNAKISTANYONSEF;
      this.KamyonTamirLook.EditValue = (object) tblpertoplanti.KAMYONTAMIRUSTABAS;
      this.AMbaraydiyatLook1.EditValue = (object) tblpertoplanti.AMBARAYNIYATSRMLS;
      this.ToplantiTarihi.EditValue = (object) tblpertoplanti.TOPLANTITARIHI;
      this.ToplantiKonusuTxt.Text = tblpertoplanti.TOPLANTIKONUSU;
      this.daireBasKoduTxt.Text = tblpertoplanti.DAIREBASK_KODU;
      this.RaporNoTxt.Text = tblpertoplanti.RAPORNO;
      this.TpltiSuresiTxt.Text = tblpertoplanti.TOPLANTISURESI;
      this.GundemMaddelerTxt.Text = tblpertoplanti.GUNDEMMADDELERI;
      this.KararAciklmasiTxt.Text = tblpertoplanti.KARARACIKLAMASI;
      this.SonrakiTopTarihi.EditValue = (object) tblpertoplanti.SONRAKITOPLANTITARIHI;
      this.otoelektrikLook.EditValue = (object) tblpertoplanti.ELEKTRIKSRMLS;
      this.OtolastikLook.EditValue = (object) tblpertoplanti.OTOLASTIKUSTABASI;
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
      TBLPERTOPLANTI entity = new TBLPERTOPLANTI();
      try
      {
        if (this.yoneticilook.Text != "")
          entity.TOPLANTIYONETICISI = new int?(Convert.ToInt32(this.yoneticilook.EditValue));
        if (this.yaziisleriLook.Text != "")
          entity.YAZIISLERISRMLS = new int?(Convert.ToInt32(this.yaziisleriLook.EditValue));
        if (this.atolyesefiLook.Text != "")
          entity.ATOLYESRMLS = new int?(Convert.ToInt32(this.atolyesefiLook.EditValue));
        if (this.AmbarsorumlusuLook.Text != "")
          entity.AMBARSRMLS = new int?(Convert.ToInt32(this.AmbarsorumlusuLook.EditValue));
        if (this.isMakinasiUstabasiLook.Text != "")
          entity.ISMAKINASISRMLS = new int?(Convert.ToInt32(this.isMakinasiUstabasiLook.EditValue));
        if (this.ikmalBirimSorumlusuLook.Text != "")
          entity.IKMALBIRIMSRMLS = new int?(Convert.ToInt32(this.ikmalBirimSorumlusuLook.EditValue));
        if (this.AkarYakitsrmlsLook.Text != "")
          entity.AKARYKTSRMLS = new int?(Convert.ToInt32(this.AkarYakitsrmlsLook.EditValue));
        if (this.KaynakAtolyesiSrmlsLook.Text != "")
          entity.KAYNAKISTANYONSEF = new int?(Convert.ToInt32(this.KaynakAtolyesiSrmlsLook.EditValue));
        if (this.otoelektrikLook.Text != "")
          entity.ELEKTRIKSRMLS = new int?(Convert.ToInt32(this.otoelektrikLook.EditValue));
        if (this.KamyonTamirLook.Text != "")
          entity.KAMYONTAMIRUSTABAS = new int?(Convert.ToInt32(this.KamyonTamirLook.EditValue));
        if (this.OtolastikLook.Text != "")
          entity.OTOLASTIKUSTABASI = new int?(Convert.ToInt32(this.OtolastikLook.EditValue));
        if (this.AMbaraydiyatLook1.Text != "")
          entity.AMBARAYNIYATSRMLS = new int?(Convert.ToInt32(this.AMbaraydiyatLook1.EditValue));
        if (this.ToplantiTarihi.Text != "")
          entity.TOPLANTITARIHI = new DateTime?(Convert.ToDateTime(this.ToplantiTarihi.EditValue));
        if (this.ToplantiKonusuTxt.Text != "")
          entity.TOPLANTIKONUSU = this.ToplantiKonusuTxt.Text;
        if (this.daireBasKoduTxt.Text != "")
          entity.DAIREBASK_KODU = this.daireBasKoduTxt.Text;
        if (this.RaporNoTxt.Text != "")
          entity.RAPORNO = this.RaporNoTxt.Text;
        if (this.TpltiSuresiTxt.Text != "")
          entity.TOPLANTISURESI = this.TpltiSuresiTxt.Text;
        if (this.GundemMaddelerTxt.Text != "")
          entity.GUNDEMMADDELERI = this.GundemMaddelerTxt.Text;
        if (this.KararAciklmasiTxt.Text != "")
          entity.KARARACIKLAMASI = this.KararAciklmasiTxt.Text;
        if (this.SonrakiTopTarihi.Text != "")
          entity.SONRAKITOPLANTITARIHI = new DateTime?(Convert.ToDateTime(this.SonrakiTopTarihi.EditValue));
        this.db.TBLPERTOPLANTI.Add(entity);
        this.db.SaveChanges();
        YetkiClass.secim_id = int.Parse(this.db.TBLPERTOPLANTI.OrderByDescending<TBLPERTOPLANTI, int>((Expression<System.Func<TBLPERTOPLANTI, int>>) (p => p.ID)).Select<TBLPERTOPLANTI, int>((Expression<System.Func<TBLPERTOPLANTI, int>>) (r => r.ID)).First<int>().ToString());
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
      TBLPERTOPLANTI tblpertoplanti = this.db.TBLPERTOPLANTI.FirstOrDefault<TBLPERTOPLANTI>((Expression<System.Func<TBLPERTOPLANTI, bool>>) (x => x.ID == YetkiClass.secim_id));
      try
      {
        if (this.yoneticilook.Text != "")
          tblpertoplanti.TOPLANTIYONETICISI = new int?(Convert.ToInt32(this.yoneticilook.EditValue));
        if (this.yaziisleriLook.Text != "")
          tblpertoplanti.YAZIISLERISRMLS = new int?(Convert.ToInt32(this.yaziisleriLook.EditValue));
        if (this.atolyesefiLook.Text != "")
          tblpertoplanti.ATOLYESRMLS = new int?(Convert.ToInt32(this.atolyesefiLook.EditValue));
        if (this.AmbarsorumlusuLook.Text != "")
          tblpertoplanti.AMBARSRMLS = new int?(Convert.ToInt32(this.AmbarsorumlusuLook.EditValue));
        if (this.isMakinasiUstabasiLook.Text != "")
          tblpertoplanti.ISMAKINASISRMLS = new int?(Convert.ToInt32(this.isMakinasiUstabasiLook.EditValue));
        if (this.ikmalBirimSorumlusuLook.Text != "")
          tblpertoplanti.IKMALBIRIMSRMLS = new int?(Convert.ToInt32(this.ikmalBirimSorumlusuLook.EditValue));
        if (this.AkarYakitsrmlsLook.Text != "")
          tblpertoplanti.AKARYKTSRMLS = new int?(Convert.ToInt32(this.AkarYakitsrmlsLook.EditValue));
        if (this.KaynakAtolyesiSrmlsLook.Text != "")
          tblpertoplanti.KAYNAKISTANYONSEF = new int?(Convert.ToInt32(this.KaynakAtolyesiSrmlsLook.EditValue));
        if (this.otoelektrikLook.Text != "")
          tblpertoplanti.ELEKTRIKSRMLS = new int?(Convert.ToInt32(this.otoelektrikLook.EditValue));
        if (this.KamyonTamirLook.Text != "")
          tblpertoplanti.KAMYONTAMIRUSTABAS = new int?(Convert.ToInt32(this.KamyonTamirLook.EditValue));
        if (this.OtolastikLook.Text != "")
          tblpertoplanti.OTOLASTIKUSTABASI = new int?(Convert.ToInt32(this.OtolastikLook.EditValue));
        if (this.AMbaraydiyatLook1.Text != "")
          tblpertoplanti.AMBARAYNIYATSRMLS = new int?(Convert.ToInt32(this.AMbaraydiyatLook1.EditValue));
        if (this.ToplantiTarihi.Text != "")
          tblpertoplanti.TOPLANTITARIHI = new DateTime?(Convert.ToDateTime(this.ToplantiTarihi.EditValue));
        if (this.ToplantiKonusuTxt.Text != "")
          tblpertoplanti.TOPLANTIKONUSU = this.ToplantiKonusuTxt.Text;
        if (this.daireBasKoduTxt.Text != "")
          tblpertoplanti.DAIREBASK_KODU = this.daireBasKoduTxt.Text;
        if (this.RaporNoTxt.Text != "")
          tblpertoplanti.RAPORNO = this.RaporNoTxt.Text;
        if (this.TpltiSuresiTxt.Text != "")
          tblpertoplanti.TOPLANTISURESI = this.TpltiSuresiTxt.Text;
        if (this.GundemMaddelerTxt.Text != "")
          tblpertoplanti.GUNDEMMADDELERI = this.GundemMaddelerTxt.Text;
        if (this.KararAciklmasiTxt.Text != "")
          tblpertoplanti.KARARACIKLAMASI = this.KararAciklmasiTxt.Text;
        if (this.SonrakiTopTarihi.Text != "")
          tblpertoplanti.SONRAKITOPLANTITARIHI = new DateTime?(Convert.ToDateTime(this.SonrakiTopTarihi.EditValue));
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
        this.db.TBLPERTOPLANTI.Remove(this.db.TBLPERTOPLANTI.FirstOrDefault<TBLPERTOPLANTI>((Expression<System.Func<TBLPERTOPLANTI, bool>>) (x => x.ID == YetkiClass.secim_id)));
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
    {
      ToplantiRapor toplantiRapor = new ToplantiRapor();
      toplantiRapor.Parameters["id"].Value = (object) YetkiClass.secim_id;
      toplantiRapor.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) toplantiRapor).Print();
    }

    private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
    {
      ToplantiRapor toplantiRapor = new ToplantiRapor();
      toplantiRapor.Parameters["id"].Value = (object) YetkiClass.secim_id;
      toplantiRapor.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) toplantiRapor).ShowPreviewDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ToplantiEkle));
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
      this.OtolastikLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.searchLookUpEdit11View = new GridView();
      this.gridColumn9 = new GridColumn();
      this.KamyonTamirLook = new SearchLookUpEdit();
      this.searchLookUpEdit10View = new GridView();
      this.gridColumn8 = new GridColumn();
      this.otoelektrikLook = new SearchLookUpEdit();
      this.searchLookUpEdit9View = new GridView();
      this.gridColumn7 = new GridColumn();
      this.KaynakAtolyesiSrmlsLook = new SearchLookUpEdit();
      this.searchLookUpEdit8View = new GridView();
      this.gridColumn6 = new GridColumn();
      this.AkarYakitsrmlsLook = new SearchLookUpEdit();
      this.searchLookUpEdit7View = new GridView();
      this.gridColumn5 = new GridColumn();
      this.ikmalBirimSorumlusuLook = new SearchLookUpEdit();
      this.searchLookUpEdit6View = new GridView();
      this.gridColumn4 = new GridColumn();
      this.isMakinasiUstabasiLook = new SearchLookUpEdit();
      this.searchLookUpEdit5View = new GridView();
      this.gridColumn3 = new GridColumn();
      this.AmbarsorumlusuLook = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.atolyesefiLook = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.yaziisleriLook = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.G = new GridColumn();
      this.yoneticilook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.AdSoyad = new GridColumn();
      this.AMbaraydiyatLook1 = new SearchLookUpEdit();
      this.searchLookUpEdit11View1 = new GridView();
      this.gridColumn91 = new GridColumn();
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
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.layoutControl2 = new LayoutControl();
      this.SonrakiTopTarihi = new DateEdit();
      this.KararAciklmasiTxt = new TextEdit();
      this.GundemMaddelerTxt = new TextEdit();
      this.TpltiSuresiTxt = new TextEdit();
      this.RaporNoTxt = new TextEdit();
      this.daireBasKoduTxt = new TextEdit();
      this.ToplantiKonusuTxt = new TextEdit();
      this.ToplantiTarihi = new DateEdit();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem12 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.OtolastikLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.searchLookUpEdit11View.BeginInit();
      this.KamyonTamirLook.Properties.BeginInit();
      this.searchLookUpEdit10View.BeginInit();
      this.otoelektrikLook.Properties.BeginInit();
      this.searchLookUpEdit9View.BeginInit();
      this.KaynakAtolyesiSrmlsLook.Properties.BeginInit();
      this.searchLookUpEdit8View.BeginInit();
      this.AkarYakitsrmlsLook.Properties.BeginInit();
      this.searchLookUpEdit7View.BeginInit();
      this.ikmalBirimSorumlusuLook.Properties.BeginInit();
      this.searchLookUpEdit6View.BeginInit();
      this.isMakinasiUstabasiLook.Properties.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.AmbarsorumlusuLook.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.atolyesefiLook.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.yaziisleriLook.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.yoneticilook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.AMbaraydiyatLook1.Properties.BeginInit();
      this.searchLookUpEdit11View1.BeginInit();
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
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.SonrakiTopTarihi.Properties.CalendarTimeProperties.BeginInit();
      this.SonrakiTopTarihi.Properties.BeginInit();
      this.KararAciklmasiTxt.Properties.BeginInit();
      this.GundemMaddelerTxt.Properties.BeginInit();
      this.TpltiSuresiTxt.Properties.BeginInit();
      this.RaporNoTxt.Properties.BeginInit();
      this.daireBasKoduTxt.Properties.BeginInit();
      this.ToplantiKonusuTxt.Properties.BeginInit();
      this.ToplantiTarihi.Properties.CalendarTimeProperties.BeginInit();
      this.ToplantiTarihi.Properties.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem20.BeginInit();
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
      this.ribbonControl1.OptionsMenuMinWidth = 288;
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
      this.ribbonControl1.Size = new Size(1229, 122);
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
      this.barButtonItem22.ImageOptions.Image = (Image) Resources.printer_32x32;
      this.barButtonItem22.ImageOptions.LargeImage = (Image) Resources.printer_32x32;
      this.barButtonItem22.LargeWidth = 100;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barButtonItem22.ItemClick += new ItemClickEventHandler(this.barButtonItem22_ItemClick);
      this.barButtonItem23.Caption = "Önizleme";
      this.barButtonItem23.Id = 32;
      this.barButtonItem23.ImageOptions.Image = (Image) Resources.preview_16x164;
      this.barButtonItem23.ImageOptions.LargeImage = (Image) Resources.preview_32x324;
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
      this.layoutControl1.Controls.Add((Control) this.OtolastikLook);
      this.layoutControl1.Controls.Add((Control) this.KamyonTamirLook);
      this.layoutControl1.Controls.Add((Control) this.otoelektrikLook);
      this.layoutControl1.Controls.Add((Control) this.KaynakAtolyesiSrmlsLook);
      this.layoutControl1.Controls.Add((Control) this.AkarYakitsrmlsLook);
      this.layoutControl1.Controls.Add((Control) this.ikmalBirimSorumlusuLook);
      this.layoutControl1.Controls.Add((Control) this.isMakinasiUstabasiLook);
      this.layoutControl1.Controls.Add((Control) this.AmbarsorumlusuLook);
      this.layoutControl1.Controls.Add((Control) this.atolyesefiLook);
      this.layoutControl1.Controls.Add((Control) this.yaziisleriLook);
      this.layoutControl1.Controls.Add((Control) this.yoneticilook);
      this.layoutControl1.Controls.Add((Control) this.AMbaraydiyatLook1);
      this.layoutControl1.Location = new Point(0, 141);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(583, 428);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.OtolastikLook.EditValue = (object) "";
      this.OtolastikLook.Location = new Point(229, 352);
      this.OtolastikLook.Margin = new Padding(3, 4, 3, 4);
      this.OtolastikLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.OtolastikLook.Name = "OtolastikLook";
      this.OtolastikLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.OtolastikLook.Properties.Appearance.Options.UseFont = true;
      this.OtolastikLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.OtolastikLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.OtolastikLook.Properties.DisplayMember = "ADISOYADI";
      this.OtolastikLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit11View;
      this.OtolastikLook.Properties.ValueMember = "ID";
      this.OtolastikLook.Size = new Size(342, 30);
      this.OtolastikLook.StyleController = (IStyleController) this.layoutControl1;
      this.OtolastikLook.TabIndex = 14;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit11View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn9
      });
      this.searchLookUpEdit11View.DetailHeight = 431;
      this.searchLookUpEdit11View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit11View.Name = "searchLookUpEdit11View";
      this.searchLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit11View.OptionsView.ShowGroupPanel = false;
      this.gridColumn9.Caption = "Ad Soyad";
      this.gridColumn9.FieldName = "ADISOYADI";
      this.gridColumn9.MinWidth = 23;
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 0;
      this.gridColumn9.Width = 87;
      this.KamyonTamirLook.EditValue = (object) "";
      this.KamyonTamirLook.Location = new Point(229, 318);
      this.KamyonTamirLook.Margin = new Padding(3, 4, 3, 4);
      this.KamyonTamirLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KamyonTamirLook.Name = "KamyonTamirLook";
      this.KamyonTamirLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KamyonTamirLook.Properties.Appearance.Options.UseFont = true;
      this.KamyonTamirLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.KamyonTamirLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.KamyonTamirLook.Properties.DisplayMember = "ADISOYADI";
      this.KamyonTamirLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit10View;
      this.KamyonTamirLook.Properties.ValueMember = "ID";
      this.KamyonTamirLook.Size = new Size(342, 30);
      this.KamyonTamirLook.StyleController = (IStyleController) this.layoutControl1;
      this.KamyonTamirLook.TabIndex = 13;
      this.searchLookUpEdit10View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn8
      });
      this.searchLookUpEdit10View.DetailHeight = 431;
      this.searchLookUpEdit10View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit10View.Name = "searchLookUpEdit10View";
      this.searchLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit10View.OptionsView.ShowGroupPanel = false;
      this.gridColumn8.Caption = "Ad Soyad";
      this.gridColumn8.FieldName = "ADISOYADI";
      this.gridColumn8.MinWidth = 23;
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 0;
      this.gridColumn8.Width = 87;
      this.otoelektrikLook.EditValue = (object) "";
      this.otoelektrikLook.Location = new Point(229, 284);
      this.otoelektrikLook.Margin = new Padding(3, 4, 3, 4);
      this.otoelektrikLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.otoelektrikLook.Name = "otoelektrikLook";
      this.otoelektrikLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.otoelektrikLook.Properties.Appearance.Options.UseFont = true;
      this.otoelektrikLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.otoelektrikLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.otoelektrikLook.Properties.DisplayMember = "ADISOYADI";
      this.otoelektrikLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit9View;
      this.otoelektrikLook.Properties.ValueMember = "ID";
      this.otoelektrikLook.Size = new Size(342, 30);
      this.otoelektrikLook.StyleController = (IStyleController) this.layoutControl1;
      this.otoelektrikLook.TabIndex = 12;
      this.searchLookUpEdit9View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn7
      });
      this.searchLookUpEdit9View.DetailHeight = 431;
      this.searchLookUpEdit9View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit9View.Name = "searchLookUpEdit9View";
      this.searchLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit9View.OptionsView.ShowGroupPanel = false;
      this.gridColumn7.Caption = "Ad Soyad";
      this.gridColumn7.FieldName = "ADISOYADI";
      this.gridColumn7.MinWidth = 23;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 0;
      this.gridColumn7.Width = 87;
      this.KaynakAtolyesiSrmlsLook.EditValue = (object) "";
      this.KaynakAtolyesiSrmlsLook.Location = new Point(229, 250);
      this.KaynakAtolyesiSrmlsLook.Margin = new Padding(3, 4, 3, 4);
      this.KaynakAtolyesiSrmlsLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KaynakAtolyesiSrmlsLook.Name = "KaynakAtolyesiSrmlsLook";
      this.KaynakAtolyesiSrmlsLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KaynakAtolyesiSrmlsLook.Properties.Appearance.Options.UseFont = true;
      this.KaynakAtolyesiSrmlsLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.KaynakAtolyesiSrmlsLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.KaynakAtolyesiSrmlsLook.Properties.DisplayMember = "ADISOYADI";
      this.KaynakAtolyesiSrmlsLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit8View;
      this.KaynakAtolyesiSrmlsLook.Properties.ValueMember = "ID";
      this.KaynakAtolyesiSrmlsLook.Size = new Size(342, 30);
      this.KaynakAtolyesiSrmlsLook.StyleController = (IStyleController) this.layoutControl1;
      this.KaynakAtolyesiSrmlsLook.TabIndex = 11;
      this.searchLookUpEdit8View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn6
      });
      this.searchLookUpEdit8View.DetailHeight = 431;
      this.searchLookUpEdit8View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit8View.Name = "searchLookUpEdit8View";
      this.searchLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit8View.OptionsView.ShowGroupPanel = false;
      this.gridColumn6.Caption = "Ad Soyad";
      this.gridColumn6.FieldName = "ADISOYADI";
      this.gridColumn6.MinWidth = 23;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.gridColumn6.Width = 87;
      this.AkarYakitsrmlsLook.EditValue = (object) "";
      this.AkarYakitsrmlsLook.Location = new Point(229, 216);
      this.AkarYakitsrmlsLook.Margin = new Padding(3, 4, 3, 4);
      this.AkarYakitsrmlsLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AkarYakitsrmlsLook.Name = "AkarYakitsrmlsLook";
      this.AkarYakitsrmlsLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AkarYakitsrmlsLook.Properties.Appearance.Options.UseFont = true;
      this.AkarYakitsrmlsLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AkarYakitsrmlsLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AkarYakitsrmlsLook.Properties.DisplayMember = "ADISOYADI";
      this.AkarYakitsrmlsLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit7View;
      this.AkarYakitsrmlsLook.Properties.ValueMember = "ID";
      this.AkarYakitsrmlsLook.Size = new Size(342, 30);
      this.AkarYakitsrmlsLook.StyleController = (IStyleController) this.layoutControl1;
      this.AkarYakitsrmlsLook.TabIndex = 10;
      this.searchLookUpEdit7View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.searchLookUpEdit7View.DetailHeight = 431;
      this.searchLookUpEdit7View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit7View.Name = "searchLookUpEdit7View";
      this.searchLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit7View.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Ad Soyad";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.MinWidth = 23;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.gridColumn5.Width = 87;
      this.ikmalBirimSorumlusuLook.EditValue = (object) "";
      this.ikmalBirimSorumlusuLook.Location = new Point(229, 182);
      this.ikmalBirimSorumlusuLook.Margin = new Padding(3, 4, 3, 4);
      this.ikmalBirimSorumlusuLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ikmalBirimSorumlusuLook.Name = "ikmalBirimSorumlusuLook";
      this.ikmalBirimSorumlusuLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ikmalBirimSorumlusuLook.Properties.Appearance.Options.UseFont = true;
      this.ikmalBirimSorumlusuLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ikmalBirimSorumlusuLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.ikmalBirimSorumlusuLook.Properties.DisplayMember = "ADISOYADI";
      this.ikmalBirimSorumlusuLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit6View;
      this.ikmalBirimSorumlusuLook.Properties.ValueMember = "ID";
      this.ikmalBirimSorumlusuLook.Size = new Size(342, 30);
      this.ikmalBirimSorumlusuLook.StyleController = (IStyleController) this.layoutControl1;
      this.ikmalBirimSorumlusuLook.TabIndex = 9;
      this.searchLookUpEdit6View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.searchLookUpEdit6View.DetailHeight = 431;
      this.searchLookUpEdit6View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit6View.Name = "searchLookUpEdit6View";
      this.searchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Ad Soyad";
      this.gridColumn4.FieldName = "ADISOYADI";
      this.gridColumn4.MinWidth = 23;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.gridColumn4.Width = 87;
      this.isMakinasiUstabasiLook.EditValue = (object) "";
      this.isMakinasiUstabasiLook.Location = new Point(229, 148);
      this.isMakinasiUstabasiLook.Margin = new Padding(3, 4, 3, 4);
      this.isMakinasiUstabasiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isMakinasiUstabasiLook.Name = "isMakinasiUstabasiLook";
      this.isMakinasiUstabasiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isMakinasiUstabasiLook.Properties.Appearance.Options.UseFont = true;
      this.isMakinasiUstabasiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isMakinasiUstabasiLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.isMakinasiUstabasiLook.Properties.DisplayMember = "ADISOYADI";
      this.isMakinasiUstabasiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.isMakinasiUstabasiLook.Properties.ValueMember = "ID";
      this.isMakinasiUstabasiLook.Size = new Size(342, 30);
      this.isMakinasiUstabasiLook.StyleController = (IStyleController) this.layoutControl1;
      this.isMakinasiUstabasiLook.TabIndex = 8;
      this.searchLookUpEdit5View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.searchLookUpEdit5View.DetailHeight = 431;
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Ad Soyad";
      this.gridColumn3.FieldName = "ADISOYADI";
      this.gridColumn3.MinWidth = 23;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 87;
      this.AmbarsorumlusuLook.EditValue = (object) "";
      this.AmbarsorumlusuLook.Location = new Point(229, 114);
      this.AmbarsorumlusuLook.Margin = new Padding(3, 4, 3, 4);
      this.AmbarsorumlusuLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AmbarsorumlusuLook.Name = "AmbarsorumlusuLook";
      this.AmbarsorumlusuLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AmbarsorumlusuLook.Properties.Appearance.Options.UseFont = true;
      this.AmbarsorumlusuLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AmbarsorumlusuLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AmbarsorumlusuLook.Properties.DisplayMember = "ADISOYADI";
      this.AmbarsorumlusuLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.AmbarsorumlusuLook.Properties.ValueMember = "ID";
      this.AmbarsorumlusuLook.Size = new Size(342, 30);
      this.AmbarsorumlusuLook.StyleController = (IStyleController) this.layoutControl1;
      this.AmbarsorumlusuLook.TabIndex = 7;
      this.searchLookUpEdit4View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.searchLookUpEdit4View.DetailHeight = 431;
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Ad Soyad";
      this.gridColumn2.FieldName = "ADISOYADI";
      this.gridColumn2.MinWidth = 23;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn2.Width = 87;
      this.atolyesefiLook.EditValue = (object) "";
      this.atolyesefiLook.Location = new Point(229, 80);
      this.atolyesefiLook.Margin = new Padding(3, 4, 3, 4);
      this.atolyesefiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyesefiLook.Name = "atolyesefiLook";
      this.atolyesefiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyesefiLook.Properties.Appearance.Options.UseFont = true;
      this.atolyesefiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyesefiLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.atolyesefiLook.Properties.DisplayMember = "ADISOYADI";
      this.atolyesefiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.atolyesefiLook.Properties.ValueMember = "ID";
      this.atolyesefiLook.Size = new Size(342, 30);
      this.atolyesefiLook.StyleController = (IStyleController) this.layoutControl1;
      this.atolyesefiLook.TabIndex = 6;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit3View.DetailHeight = 431;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Ad Soyad";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.yaziisleriLook.EditValue = (object) "";
      this.yaziisleriLook.Location = new Point(229, 46);
      this.yaziisleriLook.Margin = new Padding(3, 4, 3, 4);
      this.yaziisleriLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yaziisleriLook.Name = "yaziisleriLook";
      this.yaziisleriLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yaziisleriLook.Properties.Appearance.Options.UseFont = true;
      this.yaziisleriLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yaziisleriLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.yaziisleriLook.Properties.DisplayMember = "ADISOYADI";
      this.yaziisleriLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.yaziisleriLook.Properties.ValueMember = "ID";
      this.yaziisleriLook.Size = new Size(342, 30);
      this.yaziisleriLook.StyleController = (IStyleController) this.layoutControl1;
      this.yaziisleriLook.TabIndex = 5;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.G
      });
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.G.Caption = "Ad Soyad";
      this.G.FieldName = "ADISOYADI";
      this.G.MinWidth = 23;
      this.G.Name = "G";
      this.G.Visible = true;
      this.G.VisibleIndex = 0;
      this.G.Width = 87;
      this.yoneticilook.EditValue = (object) "";
      this.yoneticilook.Location = new Point(229, 12);
      this.yoneticilook.Margin = new Padding(3, 4, 3, 4);
      this.yoneticilook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yoneticilook.Name = "yoneticilook";
      this.yoneticilook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yoneticilook.Properties.Appearance.Options.UseFont = true;
      this.yoneticilook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yoneticilook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.yoneticilook.Properties.DisplayMember = "ADISOYADI";
      this.yoneticilook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.yoneticilook.Properties.ValueMember = "ID";
      this.yoneticilook.Size = new Size(342, 30);
      this.yoneticilook.StyleController = (IStyleController) this.layoutControl1;
      this.yoneticilook.TabIndex = 4;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.AdSoyad
      });
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.AdSoyad.Caption = "Ad Soyad";
      this.AdSoyad.FieldName = "ADISOYADI";
      this.AdSoyad.MinWidth = 23;
      this.AdSoyad.Name = "AdSoyad";
      this.AdSoyad.Visible = true;
      this.AdSoyad.VisibleIndex = 0;
      this.AdSoyad.Width = 87;
      this.AMbaraydiyatLook1.EditValue = (object) "";
      this.AMbaraydiyatLook1.Location = new Point(229, 386);
      this.AMbaraydiyatLook1.Margin = new Padding(3, 4, 3, 4);
      this.AMbaraydiyatLook1.Name = "AMbaraydiyatLook1";
      this.AMbaraydiyatLook1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AMbaraydiyatLook1.Properties.Appearance.Options.UseFont = true;
      this.AMbaraydiyatLook1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AMbaraydiyatLook1.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AMbaraydiyatLook1.Properties.DisplayMember = "ADISOYADI";
      this.AMbaraydiyatLook1.Properties.PopupView = (ColumnView) this.searchLookUpEdit11View1;
      this.AMbaraydiyatLook1.Properties.ValueMember = "ID";
      this.AMbaraydiyatLook1.Size = new Size(342, 30);
      this.AMbaraydiyatLook1.StyleController = (IStyleController) this.layoutControl1;
      this.AMbaraydiyatLook1.TabIndex = 14;
      this.searchLookUpEdit11View1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn91
      });
      this.searchLookUpEdit11View1.DetailHeight = 431;
      this.searchLookUpEdit11View1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit11View1.Name = "searchLookUpEdit11View1";
      this.searchLookUpEdit11View1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit11View1.OptionsView.ShowGroupPanel = false;
      this.gridColumn91.Caption = "Ad Soyad";
      this.gridColumn91.FieldName = "ADISOYADI";
      this.gridColumn91.MinWidth = 23;
      this.gridColumn91.Name = "gridColumn91";
      this.gridColumn91.Visible = true;
      this.gridColumn91.VisibleIndex = 0;
      this.gridColumn91.Width = 87;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[12]
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
        (BaseLayoutItem) this.layoutControlItem14
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(583, 428);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.yoneticilook;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(563, 34);
      this.layoutControlItem1.Text = "Toplantı Yöneticisi";
      this.layoutControlItem1.TextSize = new Size(214, 24);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.yaziisleriLook;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(563, 34);
      this.layoutControlItem2.Text = "Yazı İşleri Sorumlusu";
      this.layoutControlItem2.TextSize = new Size(214, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.atolyesefiLook;
      this.layoutControlItem3.Location = new Point(0, 68);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(563, 34);
      this.layoutControlItem3.Text = "Atölye Sorumlusu";
      this.layoutControlItem3.TextSize = new Size(214, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.AmbarsorumlusuLook;
      this.layoutControlItem4.Location = new Point(0, 102);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(563, 34);
      this.layoutControlItem4.Text = "Ambar Sorumlusu";
      this.layoutControlItem4.TextSize = new Size(214, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.isMakinasiUstabasiLook;
      this.layoutControlItem5.Location = new Point(0, 136);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(563, 34);
      this.layoutControlItem5.Text = "İş Makinesi Ustabaşı";
      this.layoutControlItem5.TextSize = new Size(214, 24);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.ikmalBirimSorumlusuLook;
      this.layoutControlItem6.Location = new Point(0, 170);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(563, 34);
      this.layoutControlItem6.Text = "İkmal Birim Sorumlusu";
      this.layoutControlItem6.TextSize = new Size(214, 24);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.AkarYakitsrmlsLook;
      this.layoutControlItem7.Location = new Point(0, 204);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(563, 34);
      this.layoutControlItem7.Text = "Akaryakıt İstasyon Şefi";
      this.layoutControlItem7.TextSize = new Size(214, 24);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.KaynakAtolyesiSrmlsLook;
      this.layoutControlItem8.Location = new Point(0, 238);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(563, 34);
      this.layoutControlItem8.Text = "Kaynak Atölye Sorumlusu";
      this.layoutControlItem8.TextSize = new Size(214, 24);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.otoelektrikLook;
      this.layoutControlItem9.Location = new Point(0, 272);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(563, 34);
      this.layoutControlItem9.Text = "Oto Elektrik Ustabaşı";
      this.layoutControlItem9.TextSize = new Size(214, 24);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.KamyonTamirLook;
      this.layoutControlItem10.Location = new Point(0, 306);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(563, 34);
      this.layoutControlItem10.Text = "Kamyon Tamir Ustabaşı";
      this.layoutControlItem10.TextSize = new Size(214, 24);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.OtolastikLook;
      this.layoutControlItem11.Location = new Point(0, 340);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(563, 34);
      this.layoutControlItem11.Text = "Oto Lastik Ustabaşı";
      this.layoutControlItem11.TextSize = new Size(214, 24);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.AMbaraydiyatLook1;
      this.layoutControlItem14.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem14.CustomizationFormText = "Oto Lastik Ustabaşı";
      this.layoutControlItem14.Location = new Point(0, 374);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem14.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem14.OptionsPrint.AppearanceItemText.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.OptionsPrint.AppearanceItemText.Options.UseFont = true;
      this.layoutControlItem14.Size = new Size(563, 34);
      this.layoutControlItem14.Text = "Ambar Ayniyat Sorumlusu";
      this.layoutControlItem14.TextSize = new Size(214, 22);
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.layoutControl2.Controls.Add((Control) this.SonrakiTopTarihi);
      this.layoutControl2.Controls.Add((Control) this.KararAciklmasiTxt);
      this.layoutControl2.Controls.Add((Control) this.GundemMaddelerTxt);
      this.layoutControl2.Controls.Add((Control) this.TpltiSuresiTxt);
      this.layoutControl2.Controls.Add((Control) this.RaporNoTxt);
      this.layoutControl2.Controls.Add((Control) this.daireBasKoduTxt);
      this.layoutControl2.Controls.Add((Control) this.ToplantiKonusuTxt);
      this.layoutControl2.Controls.Add((Control) this.ToplantiTarihi);
      this.layoutControl2.Location = new Point(595, 141);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(617, 379);
      this.layoutControl2.TabIndex = 4;
      this.layoutControl2.Text = "layoutControl2";
      this.SonrakiTopTarihi.EditValue = (object) null;
      this.SonrakiTopTarihi.Location = new Point(217, 236);
      this.SonrakiTopTarihi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SonrakiTopTarihi.Name = "SonrakiTopTarihi";
      this.SonrakiTopTarihi.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SonrakiTopTarihi.Properties.Appearance.Options.UseFont = true;
      this.SonrakiTopTarihi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.SonrakiTopTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.SonrakiTopTarihi.Size = new Size(388, 28);
      this.SonrakiTopTarihi.StyleController = (IStyleController) this.layoutControl2;
      this.SonrakiTopTarihi.TabIndex = 11;
      this.KararAciklmasiTxt.Location = new Point(217, 204);
      this.KararAciklmasiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KararAciklmasiTxt.Name = "KararAciklmasiTxt";
      this.KararAciklmasiTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KararAciklmasiTxt.Properties.Appearance.Options.UseFont = true;
      this.KararAciklmasiTxt.Size = new Size(388, 28);
      this.KararAciklmasiTxt.StyleController = (IStyleController) this.layoutControl2;
      this.KararAciklmasiTxt.TabIndex = 10;
      this.GundemMaddelerTxt.Location = new Point(217, 172);
      this.GundemMaddelerTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GundemMaddelerTxt.Name = "GundemMaddelerTxt";
      this.GundemMaddelerTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GundemMaddelerTxt.Properties.Appearance.Options.UseFont = true;
      this.GundemMaddelerTxt.Size = new Size(388, 28);
      this.GundemMaddelerTxt.StyleController = (IStyleController) this.layoutControl2;
      this.GundemMaddelerTxt.TabIndex = 9;
      this.TpltiSuresiTxt.Location = new Point(217, 140);
      this.TpltiSuresiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.TpltiSuresiTxt.Name = "TpltiSuresiTxt";
      this.TpltiSuresiTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TpltiSuresiTxt.Properties.Appearance.Options.UseFont = true;
      this.TpltiSuresiTxt.Size = new Size(388, 28);
      this.TpltiSuresiTxt.StyleController = (IStyleController) this.layoutControl2;
      this.TpltiSuresiTxt.TabIndex = 8;
      this.RaporNoTxt.Location = new Point(217, 108);
      this.RaporNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.RaporNoTxt.Name = "RaporNoTxt";
      this.RaporNoTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.RaporNoTxt.Properties.Appearance.Options.UseFont = true;
      this.RaporNoTxt.Size = new Size(388, 28);
      this.RaporNoTxt.StyleController = (IStyleController) this.layoutControl2;
      this.RaporNoTxt.TabIndex = 7;
      this.daireBasKoduTxt.Location = new Point(217, 76);
      this.daireBasKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.daireBasKoduTxt.Name = "daireBasKoduTxt";
      this.daireBasKoduTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.daireBasKoduTxt.Properties.Appearance.Options.UseFont = true;
      this.daireBasKoduTxt.Size = new Size(388, 28);
      this.daireBasKoduTxt.StyleController = (IStyleController) this.layoutControl2;
      this.daireBasKoduTxt.TabIndex = 6;
      this.ToplantiKonusuTxt.Location = new Point(217, 44);
      this.ToplantiKonusuTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ToplantiKonusuTxt.Name = "ToplantiKonusuTxt";
      this.ToplantiKonusuTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ToplantiKonusuTxt.Properties.Appearance.Options.UseFont = true;
      this.ToplantiKonusuTxt.Size = new Size(388, 28);
      this.ToplantiKonusuTxt.StyleController = (IStyleController) this.layoutControl2;
      this.ToplantiKonusuTxt.TabIndex = 5;
      this.ToplantiTarihi.EditValue = (object) null;
      this.ToplantiTarihi.Location = new Point(217, 12);
      this.ToplantiTarihi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ToplantiTarihi.Name = "ToplantiTarihi";
      this.ToplantiTarihi.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ToplantiTarihi.Properties.Appearance.Options.UseFont = true;
      this.ToplantiTarihi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ToplantiTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ToplantiTarihi.Size = new Size(388, 28);
      this.ToplantiTarihi.StyleController = (IStyleController) this.layoutControl2;
      this.ToplantiTarihi.TabIndex = 4;
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[9]
      {
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem20
      });
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(617, 379);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.ToplantiTarihi;
      this.layoutControlItem12.Location = new Point(0, 0);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem12.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem12.Size = new Size(597, 32);
      this.layoutControlItem12.Text = "Toplantı Tarihi";
      this.layoutControlItem12.TextSize = new Size(202, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 256);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(597, 103);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.Control = (Control) this.ToplantiKonusuTxt;
      this.layoutControlItem13.Location = new Point(0, 32);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem13.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem13.Size = new Size(597, 32);
      this.layoutControlItem13.Text = "Toplantı Konusu";
      this.layoutControlItem13.TextSize = new Size(202, 24);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.daireBasKoduTxt;
      this.layoutControlItem15.Location = new Point(0, 64);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem15.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem15.Size = new Size(597, 32);
      this.layoutControlItem15.Text = "Daire Bşk/Şb Md Kodu";
      this.layoutControlItem15.TextSize = new Size(202, 24);
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.RaporNoTxt;
      this.layoutControlItem16.Location = new Point(0, 96);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem16.Size = new Size(597, 32);
      this.layoutControlItem16.Text = "Rapor No";
      this.layoutControlItem16.TextSize = new Size(202, 24);
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.TpltiSuresiTxt;
      this.layoutControlItem17.Location = new Point(0, 128);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem17.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem17.Size = new Size(597, 32);
      this.layoutControlItem17.Text = "Süre";
      this.layoutControlItem17.TextSize = new Size(202, 24);
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.GundemMaddelerTxt;
      this.layoutControlItem18.Location = new Point(0, 160);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem18.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem18.Size = new Size(597, 32);
      this.layoutControlItem18.Text = "Gündem Maddeleri";
      this.layoutControlItem18.TextSize = new Size(202, 24);
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.KararAciklmasiTxt;
      this.layoutControlItem19.Location = new Point(0, 192);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem19.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem19.Size = new Size(597, 32);
      this.layoutControlItem19.Text = "Kararın Açıklanması";
      this.layoutControlItem19.TextSize = new Size(202, 24);
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.SonrakiTopTarihi;
      this.layoutControlItem20.Location = new Point(0, 224);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(597, 32);
      this.layoutControlItem20.Text = "Sonraki Toplanti Tarihi";
      this.layoutControlItem20.TextSize = new Size(202, 24);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1229, 573);
      this.Controls.Add((Control) this.layoutControl2);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (ToplantiEkle);
      this.Text = "Yetkili imza Ayarlamasi";
      this.Load += new EventHandler(this.YetkiliImzaAyarlamasi_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.OtolastikLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.searchLookUpEdit11View.EndInit();
      this.KamyonTamirLook.Properties.EndInit();
      this.searchLookUpEdit10View.EndInit();
      this.otoelektrikLook.Properties.EndInit();
      this.searchLookUpEdit9View.EndInit();
      this.KaynakAtolyesiSrmlsLook.Properties.EndInit();
      this.searchLookUpEdit8View.EndInit();
      this.AkarYakitsrmlsLook.Properties.EndInit();
      this.searchLookUpEdit7View.EndInit();
      this.ikmalBirimSorumlusuLook.Properties.EndInit();
      this.searchLookUpEdit6View.EndInit();
      this.isMakinasiUstabasiLook.Properties.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.AmbarsorumlusuLook.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.atolyesefiLook.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.yaziisleriLook.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.yoneticilook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.AMbaraydiyatLook1.Properties.EndInit();
      this.searchLookUpEdit11View1.EndInit();
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
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.SonrakiTopTarihi.Properties.CalendarTimeProperties.EndInit();
      this.SonrakiTopTarihi.Properties.EndInit();
      this.KararAciklmasiTxt.Properties.EndInit();
      this.GundemMaddelerTxt.Properties.EndInit();
      this.TpltiSuresiTxt.Properties.EndInit();
      this.RaporNoTxt.Properties.EndInit();
      this.daireBasKoduTxt.Properties.EndInit();
      this.ToplantiKonusuTxt.Properties.EndInit();
      this.ToplantiTarihi.Properties.CalendarTimeProperties.EndInit();
      this.ToplantiTarihi.Properties.EndInit();
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem12.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem20.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
