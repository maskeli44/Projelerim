// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Mudurlukk.TasitGorevEmriDuzenle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Mudurlukk
{
  public class TasitGorevEmriDuzenle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int sonid = 0;
    private int idControl = 0;
    private int mesaiSuresi = 0;
    private KullaniciSonId son = new KullaniciSonId();
    private string yeniTasitKod;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarEditItem barEditItem1;
    private BarEditItem barEditItem2;
    private BarButtonItem barButtonItem2;
    private BarEditItem barEditItem3;
    private BarEditItem barEditItem4;
    private BarEditItem barEditItem5;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem fazlaMesaiButton;
    private RibbonPageGroup ribbonPageGroup5;
    private BarEditItem barEditItem6;
    private RepositoryItemButtonEdit repositoryItemButtonEdit1;
    protected BarEditItem barEditItem7;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private BarEditItem barEditItem8;
    private RepositoryItemRadioGroup repositoryItemRadioGroup2;
    private RadioGroup radioGroup1;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl2;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private SimpleButton kayitSilButton;
    private SimpleButton kayitEkleButton;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private SearchLookUpEdit subeMuduruSluEdit;
    private GridView searchLookUpEdit5View;
    private TextEdit gidilecekYerTxt;
    private TextEdit gorevTuruTxt;
    private TextEdit aitKurulusTxt;
    private SearchLookUpEdit soforunAdiSluEdit;
    private GridView searchLookUpEdit2View;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControl layoutControl5;
    private LabelControl labelControl1;
    private TextEdit gunTxt;
    private TextEdit cikisKmTxt;
    private DateEdit cikisTarihDateEdit;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem17;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem16;
    private TextEdit donusKmEdit;
    private LabelControl labelControl11;
    private DateEdit donusTarihDateEdit;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layout55;
    private LayoutControlItem layoutControlItem22;
    private TimeEdit mesaiBitisTimeEdit;
    private LayoutControlItem layoutControlItem23;
    private ComboBoxEdit gorevVerenCombo;
    private LayoutControlItem layoutControlItem7;
    private LayoutControl layoutControl8;
    private LayoutControlGroup layoutControlGroup7;
    private LayoutControlItem layoutControlItem26;
    private TextEdit kodTxt;
    private LayoutControlItem layoutControlItem1;
    private BindingSource tBLARACLARBindingSource;
    private BindingSource tBLPERSONELBindingSource;
    private SearchLookUpEdit birimSorumlusuSluEdit;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem8;
    private BindingSource tBLTASITPERSBindingSource;
    private BindingSource tBLPERSUNVANBindingSource;
    private BindingSource tBLPERSKURUMGOREVBindingSource;
    private BindingSource tBLPERSONELBindingSource1;
    private BindingSource tBLPERSUNVANBindingSource1;
    private BindingSource tBLTASITPERSBindingSource1;
    private BindingSource birimListesiBindingSource;
    private birimListesi birimListesi;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.Model.birimListesiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLARACLARBindingSource1;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private BindingSource tBLPERSONELBindingSource2;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource subeMuduruBindingSource;
    private subeMuduru subeMuduru;
    private BindingSource dataTable1BindingSource1;
    private Makina_Ikmal.Model.subeMuduruTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn adiSoyadiBirim;
    private GridColumn adiSoyadi;
    private BindingSource aracPlakaBindingSource;
    private aracPlaka aracPlaka;
    private BindingSource tBLARACLARBindingSource2;
    private Makina_Ikmal.Model.aracPlakaTableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter1;
    private GridColumn gridColumn1;
    private BindingSource soforAdiBindingSource;
    private soforAdi soforAdi;
    private BindingSource tBLPERSONELBindingSource3;
    private Makina_Ikmal.Model.soforAdiTableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter1;
    private BindingSource dataTable1BindingSource2;
    private BindingSource birimListesiBindingSource1;
    private BindingSource tBLPERSONELBindingSource4;
    private GridControl personelTasitGritControl;
    private GridView gridView2;
    private LayoutControlItem layoutControlItem27;
    private BehaviorManager behaviorManager1;
    private RepositoryItemRadioGroup repositoryItemRadioGroup3;
    private RepositoryItemRadioGroup repositoryItemRadioGroup4;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private BindingSource tBLPERSUNVANBindingSource2;
    private TBLPERSUNVANTableAdapter tBLPERSUNVANTableAdapter;
    private SearchLookUpEdit aracPlakaSluEdit;
    private GridView searchLookUpEdit1View;
    private LayoutControlItem layoutControlItem2;
    private GridColumn gridColumn4;
    private BindingSource tBLPERSONELBindingSource5;
    private CheckEdit muduronay;
    private GridColumn gridColumn5;
    private EmptySpaceItem emptySpaceItem2;
    private LayoutControlItem layoutControlItem9;

    public TasitGorevEmriDuzenle() => this.InitializeComponent();

    private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Duzenle()
    {
      try
      {
        if (this.BoslukControl())
        {
          TBLTASITGOREV tbltasitgorev = this.db.TBLTASITGOREV.FirstOrDefault<TBLTASITGOREV>((Expression<System.Func<TBLTASITGOREV, bool>>) (x => x.ID == this.idControl));
          int num1 = Convert.ToInt32((this.donusTarihDateEdit.DateTime - this.cikisTarihDateEdit.DateTime).TotalHours) - 8;
          this.mesaiSuresi = num1;
          tbltasitgorev.PLAKAID = new int?(Convert.ToInt32(this.aracPlakaSluEdit.EditValue));
          tbltasitgorev.SOFORID = new int?(Convert.ToInt32(this.soforunAdiSluEdit.EditValue));
          tbltasitgorev.KURUM = this.aitKurulusTxt.Text;
          tbltasitgorev.GOREVTURU = this.gorevTuruTxt.Text;
          tbltasitgorev.GIDILECEKYER = this.gidilecekYerTxt.Text;
          tbltasitgorev.MESAIBITISSAATI = new DateTime?(Convert.ToDateTime(this.mesaiBitisTimeEdit.EditValue));
          tbltasitgorev.BIRIMAMIRIID = new int?(Convert.ToInt32(this.birimSorumlusuSluEdit.EditValue));
          if (this.donusTarihDateEdit.Text != "")
            tbltasitgorev.DONUSZAMANI = new DateTime?(Convert.ToDateTime(this.donusTarihDateEdit.EditValue));
          if (this.donusKmEdit.Text != "")
            tbltasitgorev.DONUSKM = this.donusKmEdit.Text;
          tbltasitgorev.DONUSZAMANI = new DateTime?(Convert.ToDateTime(this.donusTarihDateEdit.EditValue));
          tbltasitgorev.DONUSKM = this.donusKmEdit.Text;
          tbltasitgorev.MUDONAYZAMAN = !this.muduronay.Checked ? "1" : "2";
          tbltasitgorev.GUNUNADI = this.cikisTarihDateEdit.DateTime.ToString("dddd");
          tbltasitgorev.MUDURID = new int?(Convert.ToInt32(this.subeMuduruSluEdit.EditValue));
          tbltasitgorev.GOREVGRUPID = new int?(Convert.ToInt32(1));
          tbltasitgorev.MESAIMIKTARI = num1.ToString();
          this.db.SaveChanges();
          for (int rowHandle = 0; rowHandle < this.gridView2.DataRowCount; ++rowHandle)
          {
            if (Convert.ToInt32(this.gridView2.GetRowCellValue(rowHandle, "ID")) == 0)
            {
              this.db.TBLTASITPERS.Add(new TBLTASITPERS()
              {
                TASITID = new int?(Convert.ToInt32(tbltasitgorev.ID)),
                PERSONELID = new int?(Convert.ToInt32(this.gridView2.GetRowCellValue(rowHandle, "ADISOYADI"))),
                UNVANID = new int?(Convert.ToInt32(this.gridView2.GetRowCellValue(rowHandle, "UNVANI")))
              });
              this.db.SaveChanges();
            }
          }
          int num2 = (int) XtraMessageBox.Show("Kayıt Tamam");
        }
        else
        {
          int num = (int) XtraMessageBox.Show("Eksik girdi veya hatalı giriş yaptınız.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.Duzenle();
      LogEkle.Logs("Guncelleme Yapti");
      ((TalepOnay) Application.OpenForms["TalepOnay"])?.res();
      ((Basinsan) Application.OpenForms["Basinsan"])?.acil();
      this.Close();
    }

    private bool BoslukControl() => this.idControl != 0;

    private void YazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void TasitGorevEmri_Load(object sender, EventArgs e)
    {
      this.yeniTasitKod = this.son.TasitgorevSonKod();
      this.kodTxt.Text = this.son.TasitgorevSonKod();
      this.kodTxt.Enabled = false;
      this.YeniDosyaButton.Enabled = false;
      this.cikisTarihDateEdit.DateTime = DateTime.Now;
      this.gunTxt.Text = this.cikisTarihDateEdit.DateTime.ToString("dddd");
      this.SilButton.Enabled = false;
      this.aitKurulusTxt.Text = "Şanlıurfa Büyükşehir Belediyesi";
      this.tBLPERSUNVANTableAdapter.Fill(this.bellDataSet2.TBLPERSUNVAN);
      this.tBLPERSONELTableAdapter1.Fill(this.soforAdi.TBLPERSONEL);
      this.tBLARACLARTableAdapter1.Fill(this.aracPlaka.TBLARACLAR);
      this.dataTable1TableAdapter1.Fill(this.subeMuduru.DataTable1);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet2.TBLARACLAR);
      this.dataTable1TableAdapter.Fill(this.birimListesi.DataTable1);
      tasitGorevEmriAktarma.list.Clear();
    }

    private void kayitEkleButton_Click(object sender, EventArgs e)
    {
    }

    public void tetikle() => this.personelTasitGritControl.DataSource = (object) tasitGorevEmriAktarma.list.ToList<Personeller>();

    private void kayitSilButton_Click(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID")) == 0)
      {
        int id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ADISOYADI"));
        Personeller personeller = tasitGorevEmriAktarma.list.FirstOrDefault<Personeller>((System.Func<Personeller, bool>) (x => x.ADISOYADI == id));
        tasitGorevEmriAktarma.list.Remove(personeller);
        this.personelTasitGritControl.DataSource = (object) tasitGorevEmriAktarma.list.ToList<Personeller>();
      }
      else
      {
        int id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
        this.db.TBLTASITPERS.Remove(this.db.TBLTASITPERS.FirstOrDefault<TBLTASITPERS>((Expression<System.Func<TBLTASITPERS, bool>>) (x => x.ID == id)));
        this.db.SaveChanges();
        this.perListele(this.idControl);
      }
    }

    private void fazlaMesaiButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        if (this.BoslukControl())
        {
          this.sonid = this.idControl;
          int subeMudurID = Convert.ToInt32(this.subeMuduruSluEdit.EditValue);
          int birimSorumlusuID = Convert.ToInt32(this.birimSorumlusuSluEdit.EditValue);
          string str1 = (string) null;
          string str2 = (string) null;
          IQueryable<\u003C\u003Ef__AnonymousType40<TBLPERSONEL, TBLPERSUNVAN>> source1 = this.db.TBLPERSONEL.Join((IEnumerable<TBLPERSUNVAN>) this.db.TBLPERSUNVAN, (Expression<System.Func<TBLPERSONEL, int?>>) (hd => hd.UNVANID), (Expression<System.Func<TBLPERSUNVAN, int?>>) (ht => (int?) ht.ID), (hd, ht) => new
          {
            hd = hd,
            ht = ht
          }).Where(data => data.hd.ID == subeMudurID);
          Expression<System.Func<\u003C\u003Ef__AnonymousType40<TBLPERSONEL, TBLPERSUNVAN>, \u003C\u003Ef__AnonymousType49<string, string>>> selector1 = data => new
          {
            UNVAN = data.ht.UNVAN,
            ADISOYADI = data.hd.ADISOYADI
          };
          foreach (var data in source1.Select(selector1))
            str1 = data.UNVAN;
          IQueryable<\u003C\u003Ef__AnonymousType40<TBLPERSONEL, TBLPERSUNVAN>> source2 = this.db.TBLPERSONEL.Join((IEnumerable<TBLPERSUNVAN>) this.db.TBLPERSUNVAN, (Expression<System.Func<TBLPERSONEL, int?>>) (hd => hd.UNVANID), (Expression<System.Func<TBLPERSUNVAN, int?>>) (ht => (int?) ht.ID), (hd, ht) => new
          {
            hd = hd,
            ht = ht
          }).Where(data => data.hd.ID == birimSorumlusuID);
          Expression<System.Func<\u003C\u003Ef__AnonymousType40<TBLPERSONEL, TBLPERSUNVAN>, \u003C\u003Ef__AnonymousType49<string, string>>> selector2 = data => new
          {
            UNVAN = data.ht.UNVAN,
            ADISOYADI = data.hd.ADISOYADI
          };
          foreach (var data in source2.Select(selector2))
            str2 = data.UNVAN;
        }
        else
        {
          int num = (int) XtraMessageBox.Show("Aradığınız kayıt bulunamadı veya bos belge");
        }
      }
      catch
      {
        int num = (int) XtraMessageBox.Show("Bir hata oluştu veya eksik sütun doldurdunuz. ");
      }
    }

    public void guncelleLoad(int guncelleID)
    {
      this.idControl = guncelleID;
      IQueryable<TBLTASITGOREV> source = this.db.TBLTASITGOREV.Where<TBLTASITGOREV>((Expression<System.Func<TBLTASITGOREV, bool>>) (hd => hd.ID == guncelleID));
      Expression<System.Func<TBLTASITGOREV, \u003C\u003Ef__AnonymousType50<string, int?, int?, string, string, string, DateTime?, int?, DateTime?, string, DateTime?, string, int?, string, int?, string>>> selector = hd => new
      {
        KOD = hd.KOD,
        PLAKAID = hd.PLAKAID,
        SOFORID = hd.SOFORID,
        KURUM = hd.KURUM,
        GOREVTURU = hd.GOREVTURU,
        GIDILECEKYER = hd.GIDILECEKYER,
        MESAIBITISSAATI = hd.MESAIBITISSAATI,
        BIRIMAMIRIID = hd.BIRIMAMIRIID,
        CIKISZAMANI = hd.CIKISZAMANI,
        CIKISKM = hd.CIKISKM,
        DONUSZAMANI = hd.DONUSZAMANI,
        DONUSKM = hd.DONUSKM,
        MUDURID = hd.MUDURID,
        GUNUNADI = hd.GUNUNADI,
        BIRIMID = hd.BIRIMID,
        MESAIMIKTARI = hd.MESAIMIKTARI
      };
      foreach (var data in source.Select(selector))
      {
        this.kodTxt.Text = data.KOD;
        this.aracPlakaSluEdit.EditValue = (object) data.PLAKAID;
        this.soforunAdiSluEdit.EditValue = (object) data.SOFORID;
        this.aitKurulusTxt.Text = data.KURUM;
        this.gorevTuruTxt.Text = data.GOREVTURU;
        this.gidilecekYerTxt.Text = data.GIDILECEKYER;
        this.mesaiBitisTimeEdit.EditValue = (object) data.MESAIBITISSAATI;
        this.birimSorumlusuSluEdit.EditValue = (object) data.BIRIMAMIRIID;
        this.cikisTarihDateEdit.EditValue = (object) data.CIKISZAMANI;
        this.cikisKmTxt.Text = data.CIKISKM;
        this.donusTarihDateEdit.EditValue = (object) data.DONUSZAMANI;
        this.donusKmEdit.Text = data.DONUSKM;
        this.cikisTarihDateEdit.DateTime.ToString("dddd");
        this.subeMuduruSluEdit.EditValue = (object) data.MUDURID;
        this.gorevVerenCombo.EditValue = (object) data.BIRIMID;
        this.mesaiSuresi = Convert.ToInt32(data.MESAIMIKTARI);
      }
      this.perListele(guncelleID);
    }

    private void perListele(int id)
    {
      tasitGorevEmriAktarma.list.Clear();
      IQueryable<TBLTASITPERS> source = this.db.TBLTASITPERS.Where<TBLTASITPERS>((Expression<System.Func<TBLTASITPERS, bool>>) (hd => hd.TASITID == (int?) id));
      Expression<System.Func<TBLTASITPERS, \u003C\u003Ef__AnonymousType51<int, int?, int?>>> selector = hd => new
      {
        ID = hd.ID,
        PERSONELID = hd.PERSONELID,
        UNVANID = hd.UNVANID
      };
      foreach (var data in source.Select(selector))
        tasitGorevEmriAktarma.list.Add(new Personeller()
        {
          ID = data.ID,
          ADISOYADI = Convert.ToInt32((object) data.PERSONELID),
          UNVANI = Convert.ToInt32((object) data.UNVANID)
        });
      this.personelTasitGritControl.DataSource = (object) tasitGorevEmriAktarma.list.ToList<Personeller>();
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TasitGorevEmriDuzenle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barEditItem2 = new BarEditItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.barEditItem4 = new BarEditItem();
      this.barEditItem5 = new BarEditItem();
      this.fazlaMesaiButton = new BarButtonItem();
      this.barEditItem6 = new BarEditItem();
      this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
      this.barEditItem7 = new BarEditItem();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.barEditItem8 = new BarEditItem();
      this.repositoryItemRadioGroup2 = new RepositoryItemRadioGroup();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.repositoryItemRadioGroup3 = new RepositoryItemRadioGroup();
      this.repositoryItemRadioGroup4 = new RepositoryItemRadioGroup();
      this.radioGroup1 = new RadioGroup();
      this.layoutControl1 = new LayoutControl();
      this.muduronay = new CheckEdit();
      this.aracPlakaSluEdit = new SearchLookUpEdit();
      this.tBLARACLARBindingSource1 = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn4 = new GridColumn();
      this.personelTasitGritControl = new GridControl();
      this.gridView2 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource4 = new BindingSource(this.components);
      this.gridColumn3 = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.tBLPERSUNVANBindingSource2 = new BindingSource(this.components);
      this.birimSorumlusuSluEdit = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource5 = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.adiSoyadiBirim = new GridColumn();
      this.kodTxt = new TextEdit();
      this.layoutControl8 = new LayoutControl();
      this.layoutControlGroup7 = new LayoutControlGroup();
      this.gorevVerenCombo = new ComboBoxEdit();
      this.mesaiBitisTimeEdit = new TimeEdit();
      this.layoutControl5 = new LayoutControl();
      this.labelControl1 = new LabelControl();
      this.gunTxt = new TextEdit();
      this.cikisKmTxt = new TextEdit();
      this.cikisTarihDateEdit = new DateEdit();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControl4 = new LayoutControl();
      this.donusKmEdit = new TextEdit();
      this.labelControl11 = new LabelControl();
      this.donusTarihDateEdit = new DateEdit();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layout55 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControl2 = new LayoutControl();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.kayitSilButton = new SimpleButton();
      this.kayitEkleButton = new SimpleButton();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.subeMuduruSluEdit = new SearchLookUpEdit();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.subeMuduruBindingSource = new BindingSource(this.components);
      this.subeMuduru = new subeMuduru();
      this.searchLookUpEdit5View = new GridView();
      this.adiSoyadi = new GridColumn();
      this.gidilecekYerTxt = new TextEdit();
      this.gorevTuruTxt = new TextEdit();
      this.aitKurulusTxt = new TextEdit();
      this.soforunAdiSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLPERSONELBindingSource1 = new BindingSource(this.components);
      this.dataTable1BindingSource2 = new BindingSource(this.components);
      this.birimListesiBindingSource = new BindingSource(this.components);
      this.birimListesi = new birimListesi();
      this.tBLARACLARBindingSource2 = new BindingSource(this.components);
      this.aracPlakaBindingSource = new BindingSource(this.components);
      this.aracPlaka = new aracPlaka();
      this.tBLPERSONELBindingSource3 = new BindingSource(this.components);
      this.soforAdiBindingSource = new BindingSource(this.components);
      this.soforAdi = new soforAdi();
      this.tBLPERSONELBindingSource2 = new BindingSource(this.components);
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.tBLTASITPERSBindingSource1 = new BindingSource(this.components);
      this.tBLPERSUNVANBindingSource = new BindingSource(this.components);
      this.tBLTASITPERSBindingSource = new BindingSource(this.components);
      this.tBLPERSKURUMGOREVBindingSource = new BindingSource(this.components);
      this.tBLPERSUNVANBindingSource1 = new BindingSource(this.components);
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.birimListesiTableAdapters.DataTable1TableAdapter();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLPERSONELTableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.subeMuduruTableAdapters.DataTable1TableAdapter();
      this.tBLARACLARTableAdapter1 = new Makina_Ikmal.Model.aracPlakaTableAdapters.TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter1 = new Makina_Ikmal.Model.soforAdiTableAdapters.TBLPERSONELTableAdapter();
      this.birimListesiBindingSource1 = new BindingSource(this.components);
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.tBLPERSUNVANTableAdapter = new TBLPERSUNVANTableAdapter();
      this.emptySpaceItem2 = new EmptySpaceItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.ribbonControl1.BeginInit();
      this.repositoryItemButtonEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.repositoryItemRadioGroup3.BeginInit();
      this.repositoryItemRadioGroup4.BeginInit();
      this.radioGroup1.Properties.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.muduronay.Properties.BeginInit();
      this.aracPlakaSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).BeginInit();
      this.bellDataSet2.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.personelTasitGritControl.BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource4).BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource2).BeginInit();
      this.birimSorumlusuSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource5).BeginInit();
      this.gridView1.BeginInit();
      this.kodTxt.Properties.BeginInit();
      this.layoutControl8.BeginInit();
      this.layoutControlGroup7.BeginInit();
      this.gorevVerenCombo.Properties.BeginInit();
      this.mesaiBitisTimeEdit.Properties.BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControl5.SuspendLayout();
      this.gunTxt.Properties.BeginInit();
      this.cikisKmTxt.Properties.BeginInit();
      this.cikisTarihDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.cikisTarihDateEdit.Properties.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControl4.SuspendLayout();
      this.donusKmEdit.Properties.BeginInit();
      this.donusTarihDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.donusTarihDateEdit.Properties.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layout55.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.subeMuduruSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      ((ISupportInitialize) this.subeMuduruBindingSource).BeginInit();
      this.subeMuduru.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.gidilecekYerTxt.Properties.BeginInit();
      this.gorevTuruTxt.Properties.BeginInit();
      this.aitKurulusTxt.Properties.BeginInit();
      this.soforunAdiSluEdit.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem2.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      ((ISupportInitialize) this.birimListesiBindingSource).BeginInit();
      this.birimListesi.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource2).BeginInit();
      ((ISupportInitialize) this.aracPlakaBindingSource).BeginInit();
      this.aracPlaka.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource3).BeginInit();
      ((ISupportInitialize) this.soforAdiBindingSource).BeginInit();
      this.soforAdi.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource2).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource1).BeginInit();
      ((ISupportInitialize) this.birimListesiBindingSource1).BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.emptySpaceItem2.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[22]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.barEditItem2,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem4,
        (BarItem) this.barEditItem5,
        (BarItem) this.fazlaMesaiButton,
        (BarItem) this.barEditItem6,
        (BarItem) this.barEditItem7,
        (BarItem) this.barEditItem8
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 27;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.repositoryItemRadioGroup1,
        (RepositoryItem) this.repositoryItemRadioGroup2,
        (RepositoryItem) this.repositoryItemRadioGroup3,
        (RepositoryItem) this.repositoryItemRadioGroup4
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1184, 122);
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
      this.KaydetButton.ItemClick += new ItemClickEventHandler(this.KaydetButton_ItemClick);
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
      this.YazdirButton.ItemClick += new ItemClickEventHandler(this.YazdirButton_ItemClick);
      this.KayitBulButton.Caption = "Kayıt Bul";
      this.KayitBulButton.Id = 5;
      this.KayitBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.Image");
      this.KayitBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.LargeImage");
      this.KayitBulButton.LargeWidth = 100;
      this.KayitBulButton.Name = "KayitBulButton";
      this.KayitBulButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
      this.FisEkleButton.Caption = "Fiş Ekle";
      this.FisEkleButton.Id = 9;
      this.FisEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.Image");
      this.FisEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.LargeImage");
      this.FisEkleButton.Name = "FisEkleButton";
      this.FisEkleButton.RibbonStyle = RibbonItemStyles.Large;
      this.FisiCikarButton.Caption = "Fişi Çıkar";
      this.FisiCikarButton.Id = 10;
      this.FisiCikarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.Image");
      this.FisiCikarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.LargeImage");
      this.FisiCikarButton.Name = "FisiCikarButton";
      this.FisiCikarButton.RibbonStyle = RibbonItemStyles.Large;
      this.barEditItem1.Caption = "barEditItem1";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.Id = 13;
      this.barEditItem2.Name = "barEditItem2";
      this.barButtonItem2.Caption = "barButtonItem2";
      this.barButtonItem2.Id = 14;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.RibbonStyle = RibbonItemStyles.Large | RibbonItemStyles.SmallWithoutText;
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.Id = 18;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem4.Edit = (RepositoryItem) null;
      this.barEditItem4.Id = 19;
      this.barEditItem4.Name = "barEditItem4";
      this.barEditItem5.Edit = (RepositoryItem) null;
      this.barEditItem5.Id = 20;
      this.barEditItem5.Name = "barEditItem5";
      this.fazlaMesaiButton.Caption = "Fazla Mesai";
      this.fazlaMesaiButton.Id = 21;
      this.fazlaMesaiButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("fazlaMesaiButton.ImageOptions.Image");
      this.fazlaMesaiButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("fazlaMesaiButton.ImageOptions.LargeImage");
      this.fazlaMesaiButton.LargeWidth = 100;
      this.fazlaMesaiButton.Name = "fazlaMesaiButton";
      this.fazlaMesaiButton.RibbonStyle = RibbonItemStyles.Large;
      this.fazlaMesaiButton.ItemClick += new ItemClickEventHandler(this.fazlaMesaiButton_ItemClick);
      this.barEditItem6.Caption = "barEditItem6";
      this.barEditItem6.Edit = (RepositoryItem) this.repositoryItemButtonEdit1;
      this.barEditItem6.Id = 22;
      this.barEditItem6.Name = "barEditItem6";
      this.repositoryItemButtonEdit1.AutoHeight = false;
      this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
      this.barEditItem7.Edit = (RepositoryItem) this.repositoryItemRadioGroup1;
      this.barEditItem7.EditHeight = 80;
      this.barEditItem7.EditWidth = 70;
      this.barEditItem7.Id = 23;
      this.barEditItem7.Name = "barEditItem7";
      this.barEditItem7.RibbonStyle = RibbonItemStyles.Large;
      this.repositoryItemRadioGroup1.Appearance.BackColor = Color.FromArgb(224, 224, 224);
      this.repositoryItemRadioGroup1.Appearance.Options.UseBackColor = true;
      this.repositoryItemRadioGroup1.Columns = 1;
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.barEditItem8.Caption = "barEditItem8";
      this.barEditItem8.Edit = (RepositoryItem) this.repositoryItemRadioGroup2;
      this.barEditItem8.Id = 24;
      this.barEditItem8.Name = "barEditItem8";
      this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup5,
        this.ribbonPageGroup4,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup5.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.YazdirButton);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.fazlaMesaiButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup3.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.repositoryItemRadioGroup3.Name = "repositoryItemRadioGroup3";
      this.repositoryItemRadioGroup4.Name = "repositoryItemRadioGroup4";
      this.radioGroup1.Location = new Point(639, 0);
      this.radioGroup1.Margin = new Padding(3, 4, 3, 4);
      this.radioGroup1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.radioGroup1.Name = "radioGroup1";
      this.radioGroup1.Properties.Appearance.BackColor = Color.FromArgb(224, 224, 224);
      this.radioGroup1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
      this.radioGroup1.Properties.Appearance.Options.UseFont = true;
      this.radioGroup1.Properties.Items.AddRange(new RadioGroupItem[2]
      {
        new RadioGroupItem((object) null, "A4", true, (object) null, "a4"),
        new RadioGroupItem((object) null, "A5", true, (object) null, "a5")
      });
      this.radioGroup1.Size = new Size(117, 123);
      this.radioGroup1.TabIndex = 2;
      this.radioGroup1.SelectedIndexChanged += new EventHandler(this.radioGroup1_SelectedIndexChanged);
      this.layoutControl1.Controls.Add((Control) this.muduronay);
      this.layoutControl1.Controls.Add((Control) this.aracPlakaSluEdit);
      this.layoutControl1.Controls.Add((Control) this.personelTasitGritControl);
      this.layoutControl1.Controls.Add((Control) this.birimSorumlusuSluEdit);
      this.layoutControl1.Controls.Add((Control) this.kodTxt);
      this.layoutControl1.Controls.Add((Control) this.layoutControl8);
      this.layoutControl1.Controls.Add((Control) this.gorevVerenCombo);
      this.layoutControl1.Controls.Add((Control) this.mesaiBitisTimeEdit);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.subeMuduruSluEdit);
      this.layoutControl1.Controls.Add((Control) this.gidilecekYerTxt);
      this.layoutControl1.Controls.Add((Control) this.gorevTuruTxt);
      this.layoutControl1.Controls.Add((Control) this.aitKurulusTxt);
      this.layoutControl1.Controls.Add((Control) this.soforunAdiSluEdit);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1184, 679);
      this.layoutControl1.TabIndex = 3;
      this.layoutControl1.Text = "layoutControl1";
      this.muduronay.Location = new Point(533, 12);
      this.muduronay.Margin = new Padding(3, 4, 3, 4);
      this.muduronay.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.muduronay.Name = "muduronay";
      this.muduronay.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.muduronay.Properties.Appearance.ForeColor = Color.Black;
      this.muduronay.Properties.Appearance.Options.UseFont = true;
      this.muduronay.Properties.Appearance.Options.UseForeColor = true;
      this.muduronay.Properties.Caption = "Müdür Onay";
      this.muduronay.Size = new Size(273, 28);
      this.muduronay.StyleController = (IStyleController) this.layoutControl1;
      this.muduronay.TabIndex = 28;
      this.aracPlakaSluEdit.EditValue = (object) "";
      this.aracPlakaSluEdit.Location = new Point(176, 46);
      this.aracPlakaSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.aracPlakaSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracPlakaSluEdit.Name = "aracPlakaSluEdit";
      this.aracPlakaSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracPlakaSluEdit.Properties.Appearance.Options.UseFont = true;
      this.aracPlakaSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracPlakaSluEdit.Properties.DataSource = (object) this.tBLARACLARBindingSource1;
      this.aracPlakaSluEdit.Properties.DisplayMember = "PLAKA";
      this.aracPlakaSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.aracPlakaSluEdit.Properties.ValueMember = "ID";
      this.aracPlakaSluEdit.Size = new Size(353, 30);
      this.aracPlakaSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.aracPlakaSluEdit.TabIndex = 26;
      this.tBLARACLARBindingSource1.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource1.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "PLAKA";
      this.gridColumn4.FieldName = "PLAKA";
      this.gridColumn4.MinWidth = 23;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.gridColumn4.Width = 87;
      this.personelTasitGritControl.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.personelTasitGritControl.Location = new Point(98, 284);
      this.personelTasitGritControl.MainView = (BaseView) this.gridView2;
      this.personelTasitGritControl.Margin = new Padding(3, 4, 3, 4);
      this.personelTasitGritControl.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.personelTasitGritControl.Name = "personelTasitGritControl";
      this.personelTasitGritControl.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2
      });
      this.personelTasitGritControl.Size = new Size(1074, 349);
      this.personelTasitGritControl.TabIndex = 25;
      this.personelTasitGritControl.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridView2.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn5,
        this.gridColumn2,
        this.gridColumn3
      });
      this.gridView2.DetailHeight = 431;
      this.gridView2.GridControl = this.personelTasitGritControl;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "ID";
      this.gridColumn5.FieldName = "ID";
      this.gridColumn5.MinWidth = 25;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Width = 87;
      this.gridColumn2.Caption = "ADI SOYADI";
      this.gridColumn2.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn2.FieldName = "ADISOYADI";
      this.gridColumn2.MinWidth = 23;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn2.Width = 87;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELBindingSource4;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELBindingSource4.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource4.DataSource = (object) this.bellDataSet2;
      this.gridColumn3.Caption = "ÜNVANI";
      this.gridColumn3.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.gridColumn3.FieldName = "UNVANI";
      this.gridColumn3.MinWidth = 23;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.gridColumn3.Width = 87;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLPERSUNVANBindingSource2;
      this.repositoryItemLookUpEdit2.DisplayMember = "UNVAN";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.tBLPERSUNVANBindingSource2.DataMember = "TBLPERSUNVAN";
      this.tBLPERSUNVANBindingSource2.DataSource = (object) this.bellDataSet2;
      this.birimSorumlusuSluEdit.EditValue = (object) "";
      this.birimSorumlusuSluEdit.Location = new Point(176, 250);
      this.birimSorumlusuSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.birimSorumlusuSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimSorumlusuSluEdit.Name = "birimSorumlusuSluEdit";
      this.birimSorumlusuSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimSorumlusuSluEdit.Properties.Appearance.Options.UseFont = true;
      this.birimSorumlusuSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimSorumlusuSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource5;
      this.birimSorumlusuSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.birimSorumlusuSluEdit.Properties.PopupView = (ColumnView) this.gridView1;
      this.birimSorumlusuSluEdit.Properties.ValueMember = "ID";
      this.birimSorumlusuSluEdit.Size = new Size(399, 30);
      this.birimSorumlusuSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.birimSorumlusuSluEdit.TabIndex = 24;
      this.tBLPERSONELBindingSource5.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource5.DataSource = (object) this.bellDataSet2;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.adiSoyadiBirim
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.adiSoyadiBirim.Caption = "ADI SOYADI";
      this.adiSoyadiBirim.FieldName = "ADISOYADI";
      this.adiSoyadiBirim.MinWidth = 23;
      this.adiSoyadiBirim.Name = "adiSoyadiBirim";
      this.adiSoyadiBirim.Visible = true;
      this.adiSoyadiBirim.VisibleIndex = 0;
      this.adiSoyadiBirim.Width = 87;
      this.kodTxt.Location = new Point(176, 12);
      this.kodTxt.Margin = new Padding(3, 4, 3, 4);
      this.kodTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kodTxt.Name = "kodTxt";
      this.kodTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kodTxt.Properties.Appearance.Options.UseFont = true;
      this.kodTxt.Size = new Size(353, 30);
      this.kodTxt.StyleController = (IStyleController) this.layoutControl1;
      this.kodTxt.TabIndex = 22;
      this.layoutControl8.Location = new Point(579, 216);
      this.layoutControl8.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl8.Name = "layoutControl8";
      this.layoutControl8.Root = this.layoutControlGroup7;
      this.layoutControl8.Size = new Size(227, 64);
      this.layoutControl8.TabIndex = 21;
      this.layoutControl8.Text = "layoutControl8";
      this.layoutControlGroup7.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup7.GroupBordersVisible = false;
      this.layoutControlGroup7.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.emptySpaceItem2
      });
      this.layoutControlGroup7.Name = "layoutControlGroup7";
      this.layoutControlGroup7.Size = new Size(227, 64);
      this.layoutControlGroup7.TextVisible = false;
      this.gorevVerenCombo.Location = new Point(176, 216);
      this.gorevVerenCombo.Margin = new Padding(3, 4, 3, 4);
      this.gorevVerenCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gorevVerenCombo.Name = "gorevVerenCombo";
      this.gorevVerenCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gorevVerenCombo.Properties.Appearance.Options.UseFont = true;
      this.gorevVerenCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevVerenCombo.Properties.Items.AddRange(new object[4]
      {
        (object) "Atölye",
        (object) "Akaryakıt",
        (object) "Araç Bölümü",
        (object) "Müdüriyet"
      });
      this.gorevVerenCombo.Size = new Size(228, 30);
      this.gorevVerenCombo.StyleController = (IStyleController) this.layoutControl1;
      this.gorevVerenCombo.TabIndex = 18;
      this.mesaiBitisTimeEdit.EditValue = (object) new DateTime(2021, 12, 6, 0, 0, 0, 0);
      this.mesaiBitisTimeEdit.Location = new Point(501, 216);
      this.mesaiBitisTimeEdit.Margin = new Padding(3, 4, 3, 4);
      this.mesaiBitisTimeEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mesaiBitisTimeEdit.Name = "mesaiBitisTimeEdit";
      this.mesaiBitisTimeEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mesaiBitisTimeEdit.Properties.Appearance.Options.UseFont = true;
      this.mesaiBitisTimeEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mesaiBitisTimeEdit.Properties.Mask.EditMask = "t";
      this.mesaiBitisTimeEdit.Size = new Size(74, 30);
      this.mesaiBitisTimeEdit.StyleController = (IStyleController) this.layoutControl1;
      this.mesaiBitisTimeEdit.TabIndex = 17;
      this.layoutControl5.Controls.Add((Control) this.labelControl1);
      this.layoutControl5.Controls.Add((Control) this.gunTxt);
      this.layoutControl5.Controls.Add((Control) this.cikisKmTxt);
      this.layoutControl5.Controls.Add((Control) this.cikisTarihDateEdit);
      this.layoutControl5.Location = new Point(810, 12);
      this.layoutControl5.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 0, 650, 400));
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(362, 148);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.ForeColor = Color.Black;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.Location = new Point(12, 12);
      this.labelControl1.Margin = new Padding(3, 4, 3, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(104, 24);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl5;
      this.labelControl1.TabIndex = 7;
      this.labelControl1.Text = "Çıkış Bilgileri";
      this.gunTxt.Location = new Point(105, 96);
      this.gunTxt.Margin = new Padding(3, 4, 3, 4);
      this.gunTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gunTxt.Name = "gunTxt";
      this.gunTxt.Size = new Size(245, 22);
      this.gunTxt.StyleController = (IStyleController) this.layoutControl5;
      this.gunTxt.TabIndex = 6;
      this.cikisKmTxt.Location = new Point(105, 68);
      this.cikisKmTxt.Margin = new Padding(3, 4, 3, 4);
      this.cikisKmTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikisKmTxt.Name = "cikisKmTxt";
      this.cikisKmTxt.Properties.Mask.EditMask = "d";
      this.cikisKmTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.cikisKmTxt.Size = new Size(245, 22);
      this.cikisKmTxt.StyleController = (IStyleController) this.layoutControl5;
      this.cikisKmTxt.TabIndex = 5;
      this.cikisTarihDateEdit.EditValue = (object) null;
      this.cikisTarihDateEdit.Location = new Point(105, 40);
      this.cikisTarihDateEdit.Margin = new Padding(3, 4, 3, 4);
      this.cikisTarihDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikisTarihDateEdit.Name = "cikisTarihDateEdit";
      this.cikisTarihDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisTarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisTarihDateEdit.Properties.Mask.EditMask = "G";
      this.cikisTarihDateEdit.Size = new Size(245, 22);
      this.cikisTarihDateEdit.StyleController = (IStyleController) this.layoutControl5;
      this.cikisTarihDateEdit.TabIndex = 4;
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem17
      });
      this.layoutControlGroup4.Name = "Root";
      this.layoutControlGroup4.Size = new Size(362, 148);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem18.Control = (Control) this.cikisKmTxt;
      this.layoutControlItem18.Location = new Point(0, 56);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem18.Size = new Size(342, 28);
      this.layoutControlItem18.Text = "Çıkış Km";
      this.layoutControlItem18.TextSize = new Size(90, 24);
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.labelControl1;
      this.layoutControlItem20.Location = new Point(0, 0);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem20.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem20.Size = new Size(342, 28);
      this.layoutControlItem20.TextSize = new Size(0, 0);
      this.layoutControlItem20.TextVisible = false;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem19.Control = (Control) this.gunTxt;
      this.layoutControlItem19.Location = new Point(0, 84);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(342, 44);
      this.layoutControlItem19.Text = "Gün Adı";
      this.layoutControlItem19.TextSize = new Size(90, 24);
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem17.Control = (Control) this.cikisTarihDateEdit;
      this.layoutControlItem17.Location = new Point(0, 28);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem17.Size = new Size(342, 28);
      this.layoutControlItem17.Text = "Tarih/ Saat";
      this.layoutControlItem17.TextSize = new Size(90, 24);
      this.layoutControl4.Controls.Add((Control) this.donusKmEdit);
      this.layoutControl4.Controls.Add((Control) this.labelControl11);
      this.layoutControl4.Controls.Add((Control) this.donusTarihDateEdit);
      this.layoutControl4.Location = new Point(810, 164);
      this.layoutControl4.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(362, 116);
      this.layoutControl4.TabIndex = 15;
      this.layoutControl4.Text = "layoutControl4";
      this.donusKmEdit.Location = new Point(105, 68);
      this.donusKmEdit.Margin = new Padding(3, 4, 3, 4);
      this.donusKmEdit.Name = "donusKmEdit";
      this.donusKmEdit.Properties.Mask.EditMask = "d";
      this.donusKmEdit.Properties.Mask.MaskType = MaskType.Numeric;
      this.donusKmEdit.Size = new Size(245, 22);
      this.donusKmEdit.StyleController = (IStyleController) this.layoutControl4;
      this.donusKmEdit.TabIndex = 5;
      this.labelControl11.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl11.Appearance.ForeColor = Color.Black;
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Appearance.Options.UseForeColor = true;
      this.labelControl11.Location = new Point(12, 12);
      this.labelControl11.Margin = new Padding(3, 4, 3, 4);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(120, 24);
      this.labelControl11.StyleController = (IStyleController) this.layoutControl4;
      this.labelControl11.TabIndex = 7;
      this.labelControl11.Text = "Dönüş Bilgileri";
      this.donusTarihDateEdit.EditValue = (object) null;
      this.donusTarihDateEdit.Location = new Point(105, 40);
      this.donusTarihDateEdit.Margin = new Padding(3, 4, 3, 4);
      this.donusTarihDateEdit.Name = "donusTarihDateEdit";
      this.donusTarihDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.donusTarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.donusTarihDateEdit.Properties.Mask.EditMask = "G";
      this.donusTarihDateEdit.Size = new Size(245, 22);
      this.donusTarihDateEdit.StyleController = (IStyleController) this.layoutControl4;
      this.donusTarihDateEdit.TabIndex = 4;
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Items.AddRange(new BaseLayoutItem[3]
      {
        (BaseLayoutItem) this.layout55,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem21
      });
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(362, 116);
      this.layoutControlGroup3.TextVisible = false;
      this.layout55.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layout55.AppearanceItemCaption.ForeColor = Color.Black;
      this.layout55.AppearanceItemCaption.Options.UseFont = true;
      this.layout55.AppearanceItemCaption.Options.UseForeColor = true;
      this.layout55.Control = (Control) this.donusTarihDateEdit;
      this.layout55.ControlAlignment = ContentAlignment.TopLeft;
      this.layout55.CustomizationFormText = "Tarih/ Saat";
      this.layout55.Location = new Point(0, 28);
      this.layout55.Name = "layout55";
      this.layout55.OptionsTableLayoutItem.RowIndex = 1;
      this.layout55.Size = new Size(342, 28);
      this.layout55.Text = "Tarih/ Saat";
      this.layout55.TextSize = new Size(90, 24);
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem22.Control = (Control) this.labelControl11;
      this.layoutControlItem22.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem22.CustomizationFormText = "layoutControlItem20";
      this.layoutControlItem22.Location = new Point(0, 0);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem22.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem22.Size = new Size(342, 28);
      this.layoutControlItem22.Text = "layoutControlItem20";
      this.layoutControlItem22.TextSize = new Size(0, 0);
      this.layoutControlItem22.TextVisible = false;
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem21.Control = (Control) this.donusKmEdit;
      this.layoutControlItem21.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem21.CustomizationFormText = "Çıkış KM";
      this.layoutControlItem21.Location = new Point(0, 56);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem21.Size = new Size(342, 40);
      this.layoutControlItem21.Text = "Dönüş Km";
      this.layoutControlItem21.TextSize = new Size(90, 24);
      this.layoutControl2.Controls.Add((Control) this.layoutControl3);
      this.layoutControl2.Controls.Add((Control) this.kayitSilButton);
      this.layoutControl2.Controls.Add((Control) this.kayitEkleButton);
      this.layoutControl2.Location = new Point(12, 284);
      this.layoutControl2.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(82, 349);
      this.layoutControl2.TabIndex = 14;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControl3.Location = new Point(12, 92);
      this.layoutControl3.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(58, 245);
      this.layoutControl3.TabIndex = 6;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(58, 245);
      this.layoutControlGroup2.TextVisible = false;
      this.kayitSilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kayitSilButton.ImageOptions.Image");
      this.kayitSilButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.kayitSilButton.Location = new Point(12, 52);
      this.kayitSilButton.Margin = new Padding(3, 4, 3, 4);
      this.kayitSilButton.Name = "kayitSilButton";
      this.kayitSilButton.PaintStyle = PaintStyles.Light;
      this.kayitSilButton.Size = new Size(58, 36);
      this.kayitSilButton.StyleController = (IStyleController) this.layoutControl2;
      this.kayitSilButton.TabIndex = 5;
      this.kayitSilButton.ToolTip = "Kayıt Sil";
      this.kayitSilButton.Click += new EventHandler(this.kayitSilButton_Click);
      this.kayitEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kayitEkleButton.ImageOptions.Image");
      this.kayitEkleButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.kayitEkleButton.Location = new Point(12, 12);
      this.kayitEkleButton.Margin = new Padding(3, 4, 3, 4);
      this.kayitEkleButton.Name = "kayitEkleButton";
      this.kayitEkleButton.PaintStyle = PaintStyles.Light;
      this.kayitEkleButton.Size = new Size(58, 36);
      this.kayitEkleButton.StyleController = (IStyleController) this.layoutControl2;
      this.kayitEkleButton.TabIndex = 4;
      this.kayitEkleButton.Tag = (object) "";
      this.kayitEkleButton.ToolTip = "Kayıt Ekle";
      this.kayitEkleButton.Click += new EventHandler(this.kayitEkleButton_Click);
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[3]
      {
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14
      });
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(82, 349);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.kayitEkleButton;
      this.layoutControlItem12.Location = new Point(0, 0);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(62, 40);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.layoutControlItem13.Control = (Control) this.kayitSilButton;
      this.layoutControlItem13.Location = new Point(0, 40);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(62, 40);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem14.Control = (Control) this.layoutControl3;
      this.layoutControlItem14.Location = new Point(0, 80);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(62, 249);
      this.layoutControlItem14.TextSize = new Size(0, 0);
      this.layoutControlItem14.TextVisible = false;
      this.subeMuduruSluEdit.EditValue = (object) "";
      this.subeMuduruSluEdit.Location = new Point(176, 637);
      this.subeMuduruSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.subeMuduruSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.subeMuduruSluEdit.Name = "subeMuduruSluEdit";
      this.subeMuduruSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.subeMuduruSluEdit.Properties.Appearance.Options.UseFont = true;
      this.subeMuduruSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.subeMuduruSluEdit.Properties.DataSource = (object) this.dataTable1BindingSource1;
      this.subeMuduruSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.subeMuduruSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.subeMuduruSluEdit.Properties.ValueMember = "ID";
      this.subeMuduruSluEdit.Size = new Size(996, 30);
      this.subeMuduruSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.subeMuduruSluEdit.TabIndex = 13;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.subeMuduruBindingSource;
      this.subeMuduruBindingSource.DataSource = (object) this.subeMuduru;
      this.subeMuduruBindingSource.Position = 0;
      this.subeMuduru.DataSetName = "subeMuduru";
      this.subeMuduru.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit5View.Columns.AddRange(new GridColumn[1]
      {
        this.adiSoyadi
      });
      this.searchLookUpEdit5View.DetailHeight = 431;
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.adiSoyadi.Caption = "ADI SOYADI";
      this.adiSoyadi.FieldName = "ADISOYADI";
      this.adiSoyadi.MinWidth = 23;
      this.adiSoyadi.Name = "adiSoyadi";
      this.adiSoyadi.Visible = true;
      this.adiSoyadi.VisibleIndex = 0;
      this.adiSoyadi.Width = 87;
      this.gidilecekYerTxt.Location = new Point(176, 182);
      this.gidilecekYerTxt.Margin = new Padding(3, 4, 3, 4);
      this.gidilecekYerTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gidilecekYerTxt.Name = "gidilecekYerTxt";
      this.gidilecekYerTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gidilecekYerTxt.Properties.Appearance.Options.UseFont = true;
      this.gidilecekYerTxt.Size = new Size(630, 30);
      this.gidilecekYerTxt.StyleController = (IStyleController) this.layoutControl1;
      this.gidilecekYerTxt.TabIndex = 9;
      this.gorevTuruTxt.Location = new Point(176, 148);
      this.gorevTuruTxt.Margin = new Padding(3, 4, 3, 4);
      this.gorevTuruTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gorevTuruTxt.Name = "gorevTuruTxt";
      this.gorevTuruTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gorevTuruTxt.Properties.Appearance.Options.UseFont = true;
      this.gorevTuruTxt.Size = new Size(630, 30);
      this.gorevTuruTxt.StyleController = (IStyleController) this.layoutControl1;
      this.gorevTuruTxt.TabIndex = 8;
      this.aitKurulusTxt.Location = new Point(176, 114);
      this.aitKurulusTxt.Margin = new Padding(3, 4, 3, 4);
      this.aitKurulusTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aitKurulusTxt.Name = "aitKurulusTxt";
      this.aitKurulusTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aitKurulusTxt.Properties.Appearance.Options.UseFont = true;
      this.aitKurulusTxt.Size = new Size(630, 30);
      this.aitKurulusTxt.StyleController = (IStyleController) this.layoutControl1;
      this.aitKurulusTxt.TabIndex = 7;
      this.soforunAdiSluEdit.EditValue = (object) "";
      this.soforunAdiSluEdit.Location = new Point(176, 80);
      this.soforunAdiSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.soforunAdiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.soforunAdiSluEdit.Name = "soforunAdiSluEdit";
      this.soforunAdiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.soforunAdiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.soforunAdiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.soforunAdiSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource4;
      this.soforunAdiSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.soforunAdiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.soforunAdiSluEdit.Properties.ValueMember = "ID";
      this.soforunAdiSluEdit.Size = new Size(630, 30);
      this.soforunAdiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.soforunAdiSluEdit.TabIndex = 6;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "ADI SOYADI";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[16]
      {
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem9
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1184, 679);
      this.Root.TextVisible = false;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem3.Control = (Control) this.soforunAdiSluEdit;
      this.layoutControlItem3.Location = new Point(0, 68);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(798, 34);
      this.layoutControlItem3.Text = "Şöförün Adı Soyadı";
      this.layoutControlItem3.TextLocation = Locations.Left;
      this.layoutControlItem3.TextSize = new Size(161, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem5.Control = (Control) this.gorevTuruTxt;
      this.layoutControlItem5.Location = new Point(0, 136);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(798, 34);
      this.layoutControlItem5.Text = "Görevin Türü";
      this.layoutControlItem5.TextLocation = Locations.Left;
      this.layoutControlItem5.TextSize = new Size(161, 24);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem6.Control = (Control) this.gidilecekYerTxt;
      this.layoutControlItem6.Location = new Point(0, 170);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(798, 34);
      this.layoutControlItem6.Text = "Gidilecek Yer";
      this.layoutControlItem6.TextLocation = Locations.Left;
      this.layoutControlItem6.TextSize = new Size(161, 24);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem10.Control = (Control) this.subeMuduruSluEdit;
      this.layoutControlItem10.Location = new Point(0, 625);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(1164, 34);
      this.layoutControlItem10.Text = "Şube Müdürü";
      this.layoutControlItem10.TextSize = new Size(161, 24);
      this.layoutControlItem11.Control = (Control) this.layoutControl2;
      this.layoutControlItem11.Location = new Point(0, 272);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(86, 353);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.layoutControl4;
      this.layoutControlItem15.Location = new Point(798, 152);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(366, 120);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.layoutControlItem16.Control = (Control) this.layoutControl5;
      this.layoutControlItem16.Location = new Point(798, 0);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(366, 152);
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem4.Control = (Control) this.aitKurulusTxt;
      this.layoutControlItem4.Location = new Point(0, 102);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(798, 34);
      this.layoutControlItem4.Text = "Ait Olduğu Kuruluş";
      this.layoutControlItem4.TextLocation = Locations.Left;
      this.layoutControlItem4.TextSize = new Size(161, 24);
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.mesaiBitisTimeEdit;
      this.layoutControlItem23.Location = new Point(396, 204);
      this.layoutControlItem23.MinSize = new Size(153, 34);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(171, 34);
      this.layoutControlItem23.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem23.Text = "Mesai Bitiş";
      this.layoutControlItem23.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem23.TextSize = new Size(88, 24);
      this.layoutControlItem23.TextToControlDistance = 5;
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem7.Control = (Control) this.gorevVerenCombo;
      this.layoutControlItem7.Location = new Point(0, 204);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(396, 34);
      this.layoutControlItem7.Text = "Görev Veren Yer";
      this.layoutControlItem7.TextLocation = Locations.Left;
      this.layoutControlItem7.TextSize = new Size(161, 24);
      this.layoutControlItem26.Control = (Control) this.layoutControl8;
      this.layoutControlItem26.Location = new Point(567, 204);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.Size = new Size(231, 68);
      this.layoutControlItem26.TextSize = new Size(0, 0);
      this.layoutControlItem26.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem1.Control = (Control) this.kodTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(521, 34);
      this.layoutControlItem1.Text = "Kod";
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(161, 24);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem8.Control = (Control) this.birimSorumlusuSluEdit;
      this.layoutControlItem8.Location = new Point(0, 238);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(567, 34);
      this.layoutControlItem8.Text = "Birim Sorumlusu";
      this.layoutControlItem8.TextSize = new Size(161, 24);
      this.layoutControlItem27.Control = (Control) this.personelTasitGritControl;
      this.layoutControlItem27.Location = new Point(86, 272);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(1078, 353);
      this.layoutControlItem27.TextSize = new Size(0, 0);
      this.layoutControlItem27.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem2.Control = (Control) this.aracPlakaSluEdit;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(521, 34);
      this.layoutControlItem2.Text = "Araç Plaka";
      this.layoutControlItem2.TextSize = new Size(161, 24);
      this.tBLPERSONELBindingSource1.DataMember = "TBLPERSONEL";
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.birimListesiBindingSource;
      this.birimListesiBindingSource.DataSource = (object) this.birimListesi;
      this.birimListesiBindingSource.Position = 0;
      this.birimListesi.DataSetName = "birimListesi";
      this.birimListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLARACLARBindingSource2.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource2.DataSource = (object) this.aracPlakaBindingSource;
      this.aracPlakaBindingSource.DataSource = (object) this.aracPlaka;
      this.aracPlakaBindingSource.Position = 0;
      this.aracPlaka.DataSetName = "aracPlaka";
      this.aracPlaka.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLPERSONELBindingSource3.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource3.DataSource = (object) this.soforAdiBindingSource;
      this.soforAdiBindingSource.DataSource = (object) this.soforAdi;
      this.soforAdiBindingSource.Position = 0;
      this.soforAdi.DataSetName = "soforAdi";
      this.soforAdi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLPERSONELBindingSource2.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource2.DataSource = (object) this.bellDataSet2;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.birimListesiBindingSource;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLTASITPERSBindingSource1.DataMember = "TBLTASITPERS";
      this.tBLPERSUNVANBindingSource.DataMember = "TBLPERSUNVAN";
      this.tBLTASITPERSBindingSource.DataMember = "TBLTASITPERS";
      this.tBLPERSKURUMGOREVBindingSource.DataMember = "TBLPERSKURUMGOREV";
      this.tBLPERSUNVANBindingSource1.DataMember = "TBLPERSUNVAN";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter1.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter1.ClearBeforeFill = true;
      this.birimListesiBindingSource1.DataSource = (object) this.birimListesi;
      this.birimListesiBindingSource1.Position = 0;
      this.tBLPERSUNVANTableAdapter.ClearBeforeFill = true;
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new Point(0, 0);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new Size(207, 44);
      this.emptySpaceItem2.TextSize = new Size(0, 0);
      this.layoutControlItem9.Control = (Control) this.muduronay;
      this.layoutControlItem9.Location = new Point(521, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(277, 68);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.Appearance.BackColor = Color.FromArgb(224, 224, 224);
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1184, 801);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.radioGroup1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (TasitGorevEmriDuzenle);
      this.Text = "Taşıt Görev Emri";
      this.Load += new EventHandler(this.TasitGorevEmri_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemButtonEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.repositoryItemRadioGroup3.EndInit();
      this.repositoryItemRadioGroup4.EndInit();
      this.radioGroup1.Properties.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.muduronay.Properties.EndInit();
      this.aracPlakaSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).EndInit();
      this.bellDataSet2.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.personelTasitGritControl.EndInit();
      this.gridView2.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource4).EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource2).EndInit();
      this.birimSorumlusuSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource5).EndInit();
      this.gridView1.EndInit();
      this.kodTxt.Properties.EndInit();
      this.layoutControl8.EndInit();
      this.layoutControlGroup7.EndInit();
      this.gorevVerenCombo.Properties.EndInit();
      this.mesaiBitisTimeEdit.Properties.EndInit();
      this.layoutControl5.EndInit();
      this.layoutControl5.ResumeLayout(false);
      this.gunTxt.Properties.EndInit();
      this.cikisKmTxt.Properties.EndInit();
      this.cikisTarihDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.cikisTarihDateEdit.Properties.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControl4.ResumeLayout(false);
      this.donusKmEdit.Properties.EndInit();
      this.donusTarihDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.donusTarihDateEdit.Properties.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layout55.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.subeMuduruSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      ((ISupportInitialize) this.subeMuduruBindingSource).EndInit();
      this.subeMuduru.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.gidilecekYerTxt.Properties.EndInit();
      this.gorevTuruTxt.Properties.EndInit();
      this.aitKurulusTxt.Properties.EndInit();
      this.soforunAdiSluEdit.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.Root.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem2.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      ((ISupportInitialize) this.birimListesiBindingSource).EndInit();
      this.birimListesi.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource2).EndInit();
      ((ISupportInitialize) this.aracPlakaBindingSource).EndInit();
      this.aracPlaka.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource3).EndInit();
      ((ISupportInitialize) this.soforAdiBindingSource).EndInit();
      this.soforAdi.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource2).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).EndInit();
      ((ISupportInitialize) this.tBLTASITPERSBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource1).EndInit();
      ((ISupportInitialize) this.birimListesiBindingSource1).EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.emptySpaceItem2.EndInit();
      this.layoutControlItem9.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
