// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.PersoneIzinDuzenleme
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

namespace Makina_Ikmal.insankaynak
{
  public class PersoneIzinDuzenleme : XtraForm
  {
    private bellEntities db = new bellEntities();
    private BindingList<PersoneIzinDuzenleme.ElemanlarDurum> list = new BindingList<PersoneIzinDuzenleme.ElemanlarDurum>();
    private KullaniciSonId kul = new KullaniciSonId();
    private YetkiClass yet = new YetkiClass();
    private int sonid = 0;
    private IContainer components = (IContainer) null;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem2;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem YazdirButton;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private RepositoryItemRadioGroup repositoryItemRadioGroup2;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarEditItem barEditItem1;
    private BarButtonItem barButtonItem2;
    private RibbonControl ribbonControl1;
    private LayoutControl layoutControl1;
    private DateEdit onayDateEdit;
    private MemoEdit izinAdresMemoEdit;
    private TextEdit izinGunSayisiTextEdit;
    private DateEdit bitisTarihDateEdit;
    private DateEdit baslangicTarihDateEdit;
    private SearchLookUpEdit personelAdiSluEdit;
    private GridView searchLookUpEdit1View;
    private TextEdit izinSuresiTextEdit;
    private TextEdit izinYillariTextEdit;
    private ComboBoxEdit izinTuruComboEdit;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private SearchLookUpEdit genelSekreterYardSluEdit;
    private GridView searchLookUpEdit4View;
    private SearchLookUpEdit insanKayDBskSluEdit;
    private GridView searchLookUpEdit3View;
    private SearchLookUpEdit daireBaskanSluEdit;
    private GridView searchLookUpEdit2View;
    private ComboBoxEdit izinDurumComboEdit;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem15;
    private BarEditItem barEditItem5;
    private RepositoryItemRadioGroup repositoryItemRadioGroup5;
    private BarEditItem barEditItem3;
    private RepositoryItemRadioGroup repositoryItemRadioGroup3;
    private BarEditItem barEditItem4;
    private RepositoryItemRadioGroup repositoryItemRadioGroup4;
    private DateEdit gorevBasDateEdit;
    private LayoutControlItem layoutControlItem8;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem16;
    private SearchLookUpEdit SubeMudurSluEdit;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem9;
    private SimpleButton simpleButton1;
    private LayoutControl layoutControl6;
    private LayoutControlGroup layoutControlGroup5;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem23;
    private GridColumn ADI;
    private belediyeDataSet belediyeDataSet;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.belediyeDataSetTableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource resimliYazBindingSource;
    private ResimliYaz resimliYaz;
    private GridColumn ADISOYADI;
    private BarEditItem barEditItem6;
    private RepositoryItemRadioGroup repositoryItemRadioGroup6;
    private BarButtonGroup barButtonGroup1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RadioButton radioButton1;
    private RadioGroup radioGroup1;
    private RadioButton radioButton2;
    private SearchLookUpEdit muduryerineCombo;
    private GridView gridView3;
    private LayoutControlItem asdasda;
    private GridColumn gridColumn7;
    private GridColumn gridColumn6;
    private GridColumn gridColumn5;
    private GridColumn gridColumn4;

    public PersoneIzinDuzenleme() => this.InitializeComponent();

    private void Temizle()
    {
    }

    private void PersoneIzin_Load(object sender, EventArgs e)
    {
      this.yet.yetkiislemleri("Personel İzin Listesi");
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.gunvelleload();
      this.radioButton1.Checked = true;
    }

    private void Kayit()
    {
      try
      {
        TBLPERSONELIZIN tblpersonelizin = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<System.Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
        tblpersonelizin.IZINTURU = this.izinTuruComboEdit.Text;
        tblpersonelizin.IZINYILLARI = this.izinYillariTextEdit.Text;
        tblpersonelizin.IZINGUNSAY = this.izinGunSayisiTextEdit.Text;
        tblpersonelizin.PERSID = new int?(Convert.ToInt32(this.personelAdiSluEdit.EditValue));
        tblpersonelizin.IZINSURESI = this.izinSuresiTextEdit.Text;
        tblpersonelizin.BASLANGICTARIHI = new DateTime?(this.baslangicTarihDateEdit.DateTime);
        tblpersonelizin.BITISTARIHI = new DateTime?(this.bitisTarihDateEdit.DateTime);
        tblpersonelizin.GOREVEBASTARIH = new DateTime?(this.gorevBasDateEdit.DateTime);
        tblpersonelizin.IZINDEBULADRES = this.izinAdresMemoEdit.Text;
        tblpersonelizin.IZINTURU = this.izinTuruComboEdit.Text.ToString();
        tblpersonelizin.SBMUDURID = new int?(Convert.ToInt32(this.SubeMudurSluEdit.EditValue));
        if (this.daireBaskanSluEdit.Text != "")
          tblpersonelizin.DAIREBSKID = new int?(Convert.ToInt32(this.daireBaskanSluEdit.EditValue));
        if (this.insanKayDBskSluEdit.Text != "")
          tblpersonelizin.INSANDAIREBSKID = new int?(Convert.ToInt32(this.insanKayDBskSluEdit.EditValue));
        if (this.daireBaskanSluEdit.Text != "")
          tblpersonelizin.DAIREBSKID = new int?(Convert.ToInt32(this.daireBaskanSluEdit.EditValue));
        if (this.genelSekreterYardSluEdit.Text != "")
          tblpersonelizin.GENELSEKYRDID = new int?(Convert.ToInt32(this.genelSekreterYardSluEdit.EditValue));
        if (this.muduryerineCombo.Text != "")
          tblpersonelizin.MUDURYERINE = new int?(Convert.ToInt32(this.muduryerineCombo.EditValue));
        tblpersonelizin.IZINDURUM = this.izinDurumComboEdit.Text;
        tblpersonelizin.ONAYTARIH = new DateTime?(this.onayDateEdit.DateTime);
        if (this.izinTuruComboEdit.Text != null && this.izinYillariTextEdit.Text != "" && this.izinSuresiTextEdit.Text != "" && this.baslangicTarihDateEdit.Text != "")
        {
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayit İşlemi Başarlı bir şekilde gerçekleşti");
          this.Temizle();
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Boş Alan Bırakmayınız");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void izinleriEkleButton_Click(object sender, EventArgs e)
    {
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "guncelle")
      {
        if (this.radioButton2.Checked)
        {
          if (this.SubeMudurSluEdit.Text != "")
          {
            if (this.daireBaskanSluEdit.Text != "")
            {
              if (this.insanKayDBskSluEdit.Text != "")
              {
                if (this.muduryerineCombo.Text != "")
                {
                  this.Kayit();
                }
                else
                {
                  int num1 = (int) XtraMessageBox.Show("Müdürün Yerine boş bırakılamaz");
                }
              }
              else
              {
                int num2 = (int) XtraMessageBox.Show("İnsan Kayn. boş bırakılamaz");
              }
            }
            else
            {
              int num3 = (int) XtraMessageBox.Show("Daire Başkanı seçilmelidir.");
            }
          }
          else
          {
            int num4 = (int) XtraMessageBox.Show("Şube Müdürü seçilmelidir.");
          }
        }
        else if (this.radioButton1.Checked)
          this.Kayit();
        int num5 = (int) XtraMessageBox.Show("Kayıt işlemi başarlı bir şekilde gerçekleşti.");
      }
      LogEkle.Logs("Guncelleme Yapti");
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e) => this.Temizle();

    private void izinTuruComboEdit_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void gunvelleload()
    {
      TBLPERSONELIZIN tblpersonelizin = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<System.Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.personelAdiSluEdit.EditValue = (object) tblpersonelizin.PERSID;
      this.izinTuruComboEdit.Text = tblpersonelizin.IZINTURU;
      this.izinYillariTextEdit.Text = tblpersonelizin.IZINYILLARI;
      this.izinSuresiTextEdit.Text = tblpersonelizin.IZINSURESI;
      this.baslangicTarihDateEdit.EditValue = (object) tblpersonelizin.BASLANGICTARIHI;
      this.bitisTarihDateEdit.EditValue = (object) tblpersonelizin.BITISTARIHI;
      this.izinGunSayisiTextEdit.Text = tblpersonelizin.IZINGUNSAY;
      this.gorevBasDateEdit.EditValue = (object) tblpersonelizin.GOREVEBASTARIH;
      this.izinAdresMemoEdit.Text = tblpersonelizin.IZINDEBULADRES;
      this.SubeMudurSluEdit.EditValue = (object) tblpersonelizin.SBMUDURID;
      this.daireBaskanSluEdit.EditValue = (object) tblpersonelizin.DAIREBSKID;
      this.insanKayDBskSluEdit.EditValue = (object) tblpersonelizin.INSANDAIREBSKID;
      this.genelSekreterYardSluEdit.EditValue = (object) tblpersonelizin.GENELSEKYRDID;
      this.muduryerineCombo.EditValue = (object) tblpersonelizin.MUDURYERINE;
      this.onayDateEdit.EditValue = (object) Convert.ToDateTime((object) tblpersonelizin.ONAYTARIH);
      this.izinDurumComboEdit.Text = tblpersonelizin.IZINDURUM;
    }

    private void sil()
    {
      try
      {
        TBLPERSONELIZIN fir = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<System.Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
        IQueryable<TBLPERSIZINDURUM> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hf => hf.PERSONELIZINID == (int?) YetkiClass.secim_id));
        Expression<System.Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hf => hf.PERSONELID == fir.PERSID);
        foreach (TBLPERSIZINDURUM tblpersizindurum in (IEnumerable<TBLPERSIZINDURUM>) source.Where<TBLPERSIZINDURUM>(predicate))
        {
          TBLPERSIZINDURUM item = tblpersizindurum;
          this.db.TBLPERSIZINDURUM.Remove(this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == item.ID)));
        }
        this.db.TBLPERSONELIZIN.Remove(fir);
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show("Bir hata meydana geldi.Lütfen daha sonra deneyin");
      }
    }

    private void searchLookUpEdit1View_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      int num1 = 0;
      int deger = Convert.ToInt32(this.personelAdiSluEdit.EditValue);
      IQueryable<IGrouping<int?, TBLPERSIZINDURUM>> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) deger)).GroupBy<TBLPERSIZINDURUM, int?>((Expression<System.Func<TBLPERSIZINDURUM, int?>>) (hd => hd.IZINYILI));
      Expression<System.Func<IGrouping<int?, TBLPERSIZINDURUM>, \u003C\u003Ef__AnonymousType47<int?, int?, int?, int?>>> selector = g => new
      {
        PersonId = g.Key,
        izin = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (a => a.IZINHAKKI)),
        kul = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (b => b.KULLANILANIZIN)),
        izinyili = g.Key
      };
      foreach (var data in source.Select(selector))
      {
        int num2 = Convert.ToInt32((object) data.izin) - Convert.ToInt32((object) data.kul);
        if (num2 > 0)
          this.list.Add(new PersoneIzinDuzenleme.ElemanlarDurum()
          {
            yil = Convert.ToInt32((object) data.izinyili),
            izinhakki = Convert.ToInt32((object) data.izin),
            kullan = Convert.ToInt32((object) data.kul),
            kalan = num2,
            istek = ""
          });
        num1 = 0;
      }
    }

    private void personelAdiSluEdit_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void izinTuruComboEdit_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void gridView2_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
    }

    private void YazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.radioButton2.Checked)
      {
        mudurizin2 mudurizin2 = new mudurizin2();
        mudurizin2.Parameters["id"].Value = (object) YetkiClass.secim_id;
        mudurizin2.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) mudurizin2).ShowPreviewDialog();
      }
      else
      {
        if (!this.radioButton1.Checked)
          return;
        persizin persizin = new persizin();
        persizin.Parameters["id"].Value = (object) YetkiClass.secim_id;
        persizin.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) persizin).ShowPreviewDialog();
      }
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.sil();
        int num = (int) XtraMessageBox.Show("Kayit İşlemi Başarlı bir şekilde gerçekleşti");
        this.Close();
        ((izinlistesi) Application.OpenForms["izinlistesi"])?.tetikle();
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz yok .Lütfen yöneticinizle irtibata geçiniz.");
      }
      LogEkle.Logs("Silme Yapti");
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private string IzinGunSayisi(DateTime a, DateTime b)
    {
      string str = "";
      return this.baslangicTarihDateEdit.Text != "" && this.bitisTarihDateEdit.Text != "" ? new KullaniciSonId().sayitoyazi((b - a).Days + 1) : str;
    }

    private void bitisTarihDateEdit_EditValueChanged(object sender, EventArgs e) => this.izinGunSayisiTextEdit.Text = this.IzinGunSayisi(this.baslangicTarihDateEdit.DateTime, this.bitisTarihDateEdit.DateTime);

    private void baslangicTarihDateEdit_EditValueChanged(object sender, EventArgs e) => this.izinGunSayisiTextEdit.Text = this.IzinGunSayisi(this.baslangicTarihDateEdit.DateTime, this.bitisTarihDateEdit.DateTime);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PersoneIzinDuzenleme));
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.YeniDosyaButton = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.YazdirButton = new BarButtonItem();
      this.barButtonGroup1 = new BarButtonGroup();
      this.barEditItem6 = new BarEditItem();
      this.repositoryItemRadioGroup6 = new RepositoryItemRadioGroup();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem5 = new BarEditItem();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.repositoryItemRadioGroup2 = new RepositoryItemRadioGroup();
      this.barButtonItem1 = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barButtonItem2 = new BarButtonItem();
      this.ribbonControl1 = new RibbonControl();
      this.barEditItem3 = new BarEditItem();
      this.barEditItem4 = new BarEditItem();
      this.repositoryItemRadioGroup3 = new RepositoryItemRadioGroup();
      this.repositoryItemRadioGroup4 = new RepositoryItemRadioGroup();
      this.repositoryItemRadioGroup5 = new RepositoryItemRadioGroup();
      this.layoutControl1 = new LayoutControl();
      this.muduryerineCombo = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.gridView3 = new GridView();
      this.gridColumn7 = new GridColumn();
      this.layoutControl6 = new LayoutControl();
      this.layoutControlGroup5 = new LayoutControlGroup();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.gorevBasDateEdit = new DateEdit();
      this.genelSekreterYardSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.gridColumn6 = new GridColumn();
      this.insanKayDBskSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn5 = new GridColumn();
      this.daireBaskanSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn4 = new GridColumn();
      this.izinDurumComboEdit = new ComboBoxEdit();
      this.onayDateEdit = new DateEdit();
      this.izinAdresMemoEdit = new MemoEdit();
      this.izinGunSayisiTextEdit = new TextEdit();
      this.bitisTarihDateEdit = new DateEdit();
      this.baslangicTarihDateEdit = new DateEdit();
      this.personelAdiSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.ADI = new GridColumn();
      this.izinSuresiTextEdit = new TextEdit();
      this.izinYillariTextEdit = new TextEdit();
      this.izinTuruComboEdit = new ComboBoxEdit();
      this.SubeMudurSluEdit = new SearchLookUpEdit();
      this.gridView1 = new GridView();
      this.ADISOYADI = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.asdasda = new LayoutControlItem();
      this.resimliYazBindingSource = new BindingSource(this.components);
      this.resimliYaz = new ResimliYaz();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.simpleButton1 = new SimpleButton();
      this.belediyeDataSet = new belediyeDataSet();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new Makina_Ikmal.belediyeDataSetTableAdapters.TBLISEMRITableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.radioButton1 = new RadioButton();
      this.radioGroup1 = new RadioGroup();
      this.radioButton2 = new RadioButton();
      this.repositoryItemRadioGroup6.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemRadioGroup3.BeginInit();
      this.repositoryItemRadioGroup4.BeginInit();
      this.repositoryItemRadioGroup5.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.muduryerineCombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.gridView3.BeginInit();
      this.layoutControl6.BeginInit();
      this.layoutControlGroup5.BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.gorevBasDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.gorevBasDateEdit.Properties.BeginInit();
      this.genelSekreterYardSluEdit.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.insanKayDBskSluEdit.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.daireBaskanSluEdit.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.izinDurumComboEdit.Properties.BeginInit();
      this.onayDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.onayDateEdit.Properties.BeginInit();
      this.izinAdresMemoEdit.Properties.BeginInit();
      this.izinGunSayisiTextEdit.Properties.BeginInit();
      this.bitisTarihDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.bitisTarihDateEdit.Properties.BeginInit();
      this.baslangicTarihDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.baslangicTarihDateEdit.Properties.BeginInit();
      this.personelAdiSluEdit.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.izinSuresiTextEdit.Properties.BeginInit();
      this.izinYillariTextEdit.Properties.BeginInit();
      this.izinTuruComboEdit.Properties.BeginInit();
      this.SubeMudurSluEdit.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.asdasda.BeginInit();
      ((ISupportInitialize) this.resimliYazBindingSource).BeginInit();
      this.resimliYaz.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.belediyeDataSet.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.radioGroup1.Properties.BeginInit();
      this.SuspendLayout();
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
      this.KaydetButton.Caption = "Düzenle";
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
      this.SilButton.ItemClick += new ItemClickEventHandler(this.SilButton_ItemClick);
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.barButtonItem7.Caption = "Kapat";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.LargeWidth = 100;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barButtonItem7.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem7.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.YazdirButton, true);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
      this.YazdirButton.ItemClick += new ItemClickEventHandler(this.YazdirButton_ItemClick);
      this.barButtonGroup1.Caption = "barButtonGroup1";
      this.barButtonGroup1.Id = 22;
      this.barButtonGroup1.Name = "barButtonGroup1";
      this.barEditItem6.Edit = (RepositoryItem) this.repositoryItemRadioGroup6;
      this.barEditItem6.Id = 21;
      this.barEditItem6.Name = "barEditItem6";
      this.repositoryItemRadioGroup6.Name = "repositoryItemRadioGroup6";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.Id = 13;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem5.Edit = (RepositoryItem) null;
      this.barEditItem5.Id = 20;
      this.barEditItem5.Name = "barEditItem5";
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.repositoryItemRadioGroup2.Columns = 2;
      this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemRadioGroup1;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barButtonItem2.Caption = "barButtonItem2";
      this.barButtonItem2.Id = 14;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.RibbonStyle = RibbonItemStyles.Large | RibbonItemStyles.SmallWithoutText;
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[20]
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
        (BarItem) this.barEditItem6,
        (BarItem) this.barButtonGroup1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 23;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[6]
      {
        (RepositoryItem) this.repositoryItemRadioGroup1,
        (RepositoryItem) this.repositoryItemRadioGroup2,
        (RepositoryItem) this.repositoryItemRadioGroup3,
        (RepositoryItem) this.repositoryItemRadioGroup4,
        (RepositoryItem) this.repositoryItemRadioGroup5,
        (RepositoryItem) this.repositoryItemRadioGroup6
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(807, 96);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.Id = 18;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem4.Edit = (RepositoryItem) null;
      this.barEditItem4.Id = 19;
      this.barEditItem4.Name = "barEditItem4";
      this.repositoryItemRadioGroup3.Name = "repositoryItemRadioGroup3";
      this.repositoryItemRadioGroup4.Name = "repositoryItemRadioGroup4";
      this.repositoryItemRadioGroup5.Name = "repositoryItemRadioGroup5";
      this.layoutControl1.Controls.Add((Control) this.muduryerineCombo);
      this.layoutControl1.Controls.Add((Control) this.layoutControl6);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.gorevBasDateEdit);
      this.layoutControl1.Controls.Add((Control) this.genelSekreterYardSluEdit);
      this.layoutControl1.Controls.Add((Control) this.insanKayDBskSluEdit);
      this.layoutControl1.Controls.Add((Control) this.daireBaskanSluEdit);
      this.layoutControl1.Controls.Add((Control) this.izinDurumComboEdit);
      this.layoutControl1.Controls.Add((Control) this.onayDateEdit);
      this.layoutControl1.Controls.Add((Control) this.izinAdresMemoEdit);
      this.layoutControl1.Controls.Add((Control) this.izinGunSayisiTextEdit);
      this.layoutControl1.Controls.Add((Control) this.bitisTarihDateEdit);
      this.layoutControl1.Controls.Add((Control) this.baslangicTarihDateEdit);
      this.layoutControl1.Controls.Add((Control) this.personelAdiSluEdit);
      this.layoutControl1.Controls.Add((Control) this.izinSuresiTextEdit);
      this.layoutControl1.Controls.Add((Control) this.izinYillariTextEdit);
      this.layoutControl1.Controls.Add((Control) this.izinTuruComboEdit);
      this.layoutControl1.Controls.Add((Control) this.SubeMudurSluEdit);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(807, 635);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.muduryerineCombo.EditValue = (object) "";
      this.muduryerineCombo.Location = new Point(148, 599);
      this.muduryerineCombo.Margin = new Padding(3, 2, 3, 2);
      this.muduryerineCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.muduryerineCombo.Name = "muduryerineCombo";
      this.muduryerineCombo.Properties.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.muduryerineCombo.Properties.Appearance.Options.UseFont = true;
      this.muduryerineCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.muduryerineCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.muduryerineCombo.Properties.DisplayMember = "ADISOYADI";
      this.muduryerineCombo.Properties.NullText = "";
      this.muduryerineCombo.Properties.PopupView = (ColumnView) this.gridView3;
      this.muduryerineCombo.Properties.ValueMember = "ID";
      this.muduryerineCombo.Size = new Size(647, 24);
      this.muduryerineCombo.StyleController = (IStyleController) this.layoutControl1;
      this.muduryerineCombo.TabIndex = 33;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn7
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn7.Caption = "Ad Soyad";
      this.gridColumn7.FieldName = "ADISOYADI";
      this.gridColumn7.MinWidth = 17;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 0;
      this.gridColumn7.Width = 64;
      this.layoutControl6.Location = new Point(257, 208);
      this.layoutControl6.Name = "layoutControl6";
      this.layoutControl6.Root = this.layoutControlGroup5;
      this.layoutControl6.Size = new Size(538, 24);
      this.layoutControl6.TabIndex = 28;
      this.layoutControl6.Text = "layoutControl6";
      this.layoutControlGroup5.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup5.GroupBordersVisible = false;
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new Size(538, 24);
      this.layoutControlGroup5.TextVisible = false;
      this.layoutControl5.Location = new Point(257, 180);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(538, 24);
      this.layoutControl5.TabIndex = 27;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(538, 24);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl4.Location = new Point(257, 152);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(538, 24);
      this.layoutControl4.TabIndex = 26;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(538, 24);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(257, 124);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(538, 24);
      this.layoutControl3.TabIndex = 25;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(538, 24);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(265, 40);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(530, 24);
      this.layoutControl2.TabIndex = 24;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(530, 24);
      this.layoutControlGroup1.TextVisible = false;
      this.gorevBasDateEdit.EditValue = (object) null;
      this.gorevBasDateEdit.Location = new Point(148, 208);
      this.gorevBasDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gorevBasDateEdit.Name = "gorevBasDateEdit";
      this.gorevBasDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gorevBasDateEdit.Properties.Appearance.Options.UseFont = true;
      this.gorevBasDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevBasDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevBasDateEdit.Size = new Size(105, 24);
      this.gorevBasDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.gorevBasDateEdit.TabIndex = 23;
      this.genelSekreterYardSluEdit.EditValue = (object) "";
      this.genelSekreterYardSluEdit.Location = new Point(148, 571);
      this.genelSekreterYardSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelSekreterYardSluEdit.Name = "genelSekreterYardSluEdit";
      this.genelSekreterYardSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelSekreterYardSluEdit.Properties.Appearance.Options.UseFont = true;
      this.genelSekreterYardSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.genelSekreterYardSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.genelSekreterYardSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.genelSekreterYardSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.genelSekreterYardSluEdit.Properties.ValueMember = "ID";
      this.genelSekreterYardSluEdit.Size = new Size(647, 24);
      this.genelSekreterYardSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.genelSekreterYardSluEdit.TabIndex = 19;
      this.searchLookUpEdit4View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn6
      });
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.gridColumn6.Caption = "Ad Soyad";
      this.gridColumn6.FieldName = "ADISOYADI";
      this.gridColumn6.MinWidth = 17;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.gridColumn6.Width = 64;
      this.insanKayDBskSluEdit.EditValue = (object) "";
      this.insanKayDBskSluEdit.Location = new Point(148, 543);
      this.insanKayDBskSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.insanKayDBskSluEdit.Name = "insanKayDBskSluEdit";
      this.insanKayDBskSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.insanKayDBskSluEdit.Properties.Appearance.Options.UseFont = true;
      this.insanKayDBskSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.insanKayDBskSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.insanKayDBskSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.insanKayDBskSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.insanKayDBskSluEdit.Properties.ValueMember = "ID";
      this.insanKayDBskSluEdit.Size = new Size(647, 24);
      this.insanKayDBskSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.insanKayDBskSluEdit.TabIndex = 18;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Ad Soyad";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.MinWidth = 17;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.gridColumn5.Width = 64;
      this.daireBaskanSluEdit.EditValue = (object) "";
      this.daireBaskanSluEdit.Location = new Point(148, 515);
      this.daireBaskanSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.daireBaskanSluEdit.Name = "daireBaskanSluEdit";
      this.daireBaskanSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.daireBaskanSluEdit.Properties.Appearance.Options.UseFont = true;
      this.daireBaskanSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.daireBaskanSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.daireBaskanSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.daireBaskanSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.daireBaskanSluEdit.Properties.ValueMember = "ID";
      this.daireBaskanSluEdit.Size = new Size(647, 24);
      this.daireBaskanSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.daireBaskanSluEdit.TabIndex = 17;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Ad Soyad";
      this.gridColumn4.FieldName = "ADISOYADI";
      this.gridColumn4.MinWidth = 17;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.gridColumn4.Width = 64;
      this.izinDurumComboEdit.Location = new Point(389, 459);
      this.izinDurumComboEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinDurumComboEdit.Name = "izinDurumComboEdit";
      this.izinDurumComboEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinDurumComboEdit.Properties.Appearance.Options.UseFont = true;
      this.izinDurumComboEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.izinDurumComboEdit.Properties.Items.AddRange(new object[2]
      {
        (object) "İzinde",
        (object) "Geldi"
      });
      this.izinDurumComboEdit.Size = new Size(406, 24);
      this.izinDurumComboEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinDurumComboEdit.TabIndex = 16;
      this.onayDateEdit.EditValue = (object) null;
      this.onayDateEdit.Location = new Point(148, 459);
      this.onayDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.onayDateEdit.Name = "onayDateEdit";
      this.onayDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.onayDateEdit.Properties.Appearance.Options.UseFont = true;
      this.onayDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.onayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.onayDateEdit.Size = new Size(101, 24);
      this.onayDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.onayDateEdit.TabIndex = 15;
      this.izinAdresMemoEdit.Location = new Point(148, 236);
      this.izinAdresMemoEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinAdresMemoEdit.Name = "izinAdresMemoEdit";
      this.izinAdresMemoEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinAdresMemoEdit.Properties.Appearance.Options.UseFont = true;
      this.izinAdresMemoEdit.Size = new Size(647, 219);
      this.izinAdresMemoEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinAdresMemoEdit.TabIndex = 14;
      this.izinGunSayisiTextEdit.EditValue = (object) "";
      this.izinGunSayisiTextEdit.Location = new Point(148, 180);
      this.izinGunSayisiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinGunSayisiTextEdit.Name = "izinGunSayisiTextEdit";
      this.izinGunSayisiTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinGunSayisiTextEdit.Properties.Appearance.Options.UseFont = true;
      this.izinGunSayisiTextEdit.Size = new Size(105, 24);
      this.izinGunSayisiTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinGunSayisiTextEdit.TabIndex = 11;
      this.bitisTarihDateEdit.EditValue = (object) null;
      this.bitisTarihDateEdit.Location = new Point(148, 152);
      this.bitisTarihDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bitisTarihDateEdit.Name = "bitisTarihDateEdit";
      this.bitisTarihDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bitisTarihDateEdit.Properties.Appearance.Options.UseFont = true;
      this.bitisTarihDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bitisTarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bitisTarihDateEdit.Size = new Size(105, 24);
      this.bitisTarihDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.bitisTarihDateEdit.TabIndex = 10;
      this.bitisTarihDateEdit.EditValueChanged += new EventHandler(this.bitisTarihDateEdit_EditValueChanged);
      this.baslangicTarihDateEdit.EditValue = (object) null;
      this.baslangicTarihDateEdit.Location = new Point(148, 124);
      this.baslangicTarihDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.baslangicTarihDateEdit.Name = "baslangicTarihDateEdit";
      this.baslangicTarihDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.baslangicTarihDateEdit.Properties.Appearance.Options.UseFont = true;
      this.baslangicTarihDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.baslangicTarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.baslangicTarihDateEdit.Size = new Size(105, 24);
      this.baslangicTarihDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.baslangicTarihDateEdit.TabIndex = 9;
      this.baslangicTarihDateEdit.EditValueChanged += new EventHandler(this.baslangicTarihDateEdit_EditValueChanged);
      this.personelAdiSluEdit.EditValue = (object) " ";
      this.personelAdiSluEdit.Location = new Point(148, 12);
      this.personelAdiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.personelAdiSluEdit.Name = "personelAdiSluEdit";
      this.personelAdiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.personelAdiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.personelAdiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personelAdiSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personelAdiSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.personelAdiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.personelAdiSluEdit.Properties.ValueMember = "ID";
      this.personelAdiSluEdit.Size = new Size(647, 24);
      this.personelAdiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.personelAdiSluEdit.TabIndex = 8;
      this.personelAdiSluEdit.EditValueChanged += new EventHandler(this.personelAdiSluEdit_EditValueChanged);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.ADI
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit1View.CellValueChanged += new CellValueChangedEventHandler(this.searchLookUpEdit1View_CellValueChanged);
      this.ADI.Caption = "Ad Soyad";
      this.ADI.FieldName = "ADISOYADI";
      this.ADI.Name = "ADI";
      this.ADI.Visible = true;
      this.ADI.VisibleIndex = 0;
      this.izinSuresiTextEdit.Location = new Point(148, 96);
      this.izinSuresiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinSuresiTextEdit.Name = "izinSuresiTextEdit";
      this.izinSuresiTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinSuresiTextEdit.Properties.Appearance.Options.UseFont = true;
      this.izinSuresiTextEdit.Size = new Size(647, 24);
      this.izinSuresiTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinSuresiTextEdit.TabIndex = 7;
      this.izinYillariTextEdit.Location = new Point(148, 68);
      this.izinYillariTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinYillariTextEdit.Name = "izinYillariTextEdit";
      this.izinYillariTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinYillariTextEdit.Properties.Appearance.Options.UseFont = true;
      this.izinYillariTextEdit.Size = new Size(647, 24);
      this.izinYillariTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinYillariTextEdit.TabIndex = 6;
      this.izinTuruComboEdit.Enabled = false;
      this.izinTuruComboEdit.Location = new Point(148, 40);
      this.izinTuruComboEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinTuruComboEdit.Name = "izinTuruComboEdit";
      this.izinTuruComboEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinTuruComboEdit.Properties.Appearance.Options.UseFont = true;
      this.izinTuruComboEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.izinTuruComboEdit.Properties.Items.AddRange(new object[4]
      {
        (object) "Yıllık",
        (object) "Doğum İzni",
        (object) "Mazeret",
        (object) "Diğer"
      });
      this.izinTuruComboEdit.Size = new Size(113, 24);
      this.izinTuruComboEdit.StyleController = (IStyleController) this.layoutControl1;
      this.izinTuruComboEdit.TabIndex = 5;
      this.izinTuruComboEdit.SelectedIndexChanged += new EventHandler(this.izinTuruComboEdit_SelectedIndexChanged);
      this.izinTuruComboEdit.EditValueChanged += new EventHandler(this.izinTuruComboEdit_EditValueChanged);
      this.SubeMudurSluEdit.Location = new Point(148, 487);
      this.SubeMudurSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SubeMudurSluEdit.Name = "SubeMudurSluEdit";
      this.SubeMudurSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SubeMudurSluEdit.Properties.Appearance.Options.UseFont = true;
      this.SubeMudurSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.SubeMudurSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.SubeMudurSluEdit.Properties.DisplayFormat.FormatString = "d";
      this.SubeMudurSluEdit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.SubeMudurSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.SubeMudurSluEdit.Properties.EditFormat.FormatString = "d";
      this.SubeMudurSluEdit.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.SubeMudurSluEdit.Properties.NullText = "";
      this.SubeMudurSluEdit.Properties.PopupView = (ColumnView) this.gridView1;
      this.SubeMudurSluEdit.Properties.ValueMember = "ID";
      this.SubeMudurSluEdit.Size = new Size(647, 24);
      this.SubeMudurSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.SubeMudurSluEdit.TabIndex = 13;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.ADISOYADI
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.ADISOYADI.Caption = "Ad Soyad";
      this.ADISOYADI.FieldName = "ADISOYADI";
      this.ADISOYADI.Name = "ADISOYADI";
      this.ADISOYADI.Visible = true;
      this.ADISOYADI.VisibleIndex = 0;
      this.Root.AppearanceGroup.ForeColor = Color.Black;
      this.Root.AppearanceGroup.Options.UseForeColor = true;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[21]
      {
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.asdasda
      });
      this.Root.Name = "Root";
      this.Root.OptionsPrint.AppearanceGroupCaption.ForeColor = Color.Blue;
      this.Root.OptionsPrint.AppearanceGroupCaption.Options.UseForeColor = true;
      this.Root.Size = new Size(807, 635);
      this.Root.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem2.Control = (Control) this.izinTuruComboEdit;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(253, 28);
      this.layoutControlItem2.Text = "İzin Türü";
      this.layoutControlItem2.TextSize = new Size(133, 18);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem3.Control = (Control) this.izinYillariTextEdit;
      this.layoutControlItem3.Location = new Point(0, 56);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(787, 28);
      this.layoutControlItem3.Text = "İzin Yılları";
      this.layoutControlItem3.TextSize = new Size(133, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem4.Control = (Control) this.izinSuresiTextEdit;
      this.layoutControlItem4.Location = new Point(0, 84);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(787, 28);
      this.layoutControlItem4.Text = "İzin Süresi";
      this.layoutControlItem4.TextSize = new Size(133, 18);
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem1.Control = (Control) this.personelAdiSluEdit;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(787, 28);
      this.layoutControlItem1.Text = "Personel Ad";
      this.layoutControlItem1.TextSize = new Size(133, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem5.Control = (Control) this.baslangicTarihDateEdit;
      this.layoutControlItem5.Location = new Point(0, 112);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(245, 28);
      this.layoutControlItem5.Text = "Başlangıç Tarihi";
      this.layoutControlItem5.TextSize = new Size(133, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem6.Control = (Control) this.bitisTarihDateEdit;
      this.layoutControlItem6.Location = new Point(0, 140);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(245, 28);
      this.layoutControlItem6.Text = "Bitiş Tarihi";
      this.layoutControlItem6.TextSize = new Size(133, 18);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem12.Control = (Control) this.izinDurumComboEdit;
      this.layoutControlItem12.Location = new Point(241, 447);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(546, 28);
      this.layoutControlItem12.Text = "İzin Durum";
      this.layoutControlItem12.TextSize = new Size(133, 18);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem13.Control = (Control) this.daireBaskanSluEdit;
      this.layoutControlItem13.Location = new Point(0, 503);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(787, 28);
      this.layoutControlItem13.Text = "Daire Başkanı";
      this.layoutControlItem13.TextSize = new Size(133, 18);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem14.Control = (Control) this.insanKayDBskSluEdit;
      this.layoutControlItem14.Location = new Point(0, 531);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(787, 28);
      this.layoutControlItem14.Text = "İnsan Kay. D.Bşk";
      this.layoutControlItem14.TextSize = new Size(133, 18);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem15.Control = (Control) this.genelSekreterYardSluEdit;
      this.layoutControlItem15.Location = new Point(0, 559);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(787, 28);
      this.layoutControlItem15.Text = "Genel Sekreter Yard";
      this.layoutControlItem15.TextSize = new Size(133, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem7.Control = (Control) this.izinGunSayisiTextEdit;
      this.layoutControlItem7.Location = new Point(0, 168);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(245, 28);
      this.layoutControlItem7.Text = "İzin Gün Sayısı";
      this.layoutControlItem7.TextSize = new Size(133, 18);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem8.Control = (Control) this.gorevBasDateEdit;
      this.layoutControlItem8.Location = new Point(0, 196);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(245, 28);
      this.layoutControlItem8.Text = "Göreve Baş. Tarihi";
      this.layoutControlItem8.TextSize = new Size(133, 18);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem10.Control = (Control) this.izinAdresMemoEdit;
      this.layoutControlItem10.Location = new Point(0, 224);
      this.layoutControlItem10.MinSize = new Size(162, 24);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(787, 223);
      this.layoutControlItem10.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem10.Text = "İzindeki Adres";
      this.layoutControlItem10.TextLocation = Locations.Left;
      this.layoutControlItem10.TextSize = new Size(133, 18);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem11.Control = (Control) this.onayDateEdit;
      this.layoutControlItem11.Location = new Point(0, 447);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(241, 28);
      this.layoutControlItem11.Text = "Onay Tarihi";
      this.layoutControlItem11.TextSize = new Size(133, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem9.Control = (Control) this.SubeMudurSluEdit;
      this.layoutControlItem9.Location = new Point(0, 475);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(787, 28);
      this.layoutControlItem9.Text = "Şube Müdürü";
      this.layoutControlItem9.TextSize = new Size(133, 18);
      this.layoutControlItem19.Control = (Control) this.layoutControl2;
      this.layoutControlItem19.Location = new Point(253, 28);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(534, 28);
      this.layoutControlItem19.TextSize = new Size(0, 0);
      this.layoutControlItem19.TextVisible = false;
      this.layoutControlItem20.Control = (Control) this.layoutControl3;
      this.layoutControlItem20.Location = new Point(245, 112);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.Size = new Size(542, 28);
      this.layoutControlItem20.TextSize = new Size(0, 0);
      this.layoutControlItem20.TextVisible = false;
      this.layoutControlItem21.Control = (Control) this.layoutControl4;
      this.layoutControlItem21.Location = new Point(245, 140);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(542, 28);
      this.layoutControlItem21.TextSize = new Size(0, 0);
      this.layoutControlItem21.TextVisible = false;
      this.layoutControlItem22.Control = (Control) this.layoutControl5;
      this.layoutControlItem22.Location = new Point(245, 168);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(542, 28);
      this.layoutControlItem22.TextSize = new Size(0, 0);
      this.layoutControlItem22.TextVisible = false;
      this.layoutControlItem23.Control = (Control) this.layoutControl6;
      this.layoutControlItem23.Location = new Point(245, 196);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(542, 28);
      this.layoutControlItem23.TextSize = new Size(0, 0);
      this.layoutControlItem23.TextVisible = false;
      this.asdasda.AppearanceItemCaption.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.asdasda.AppearanceItemCaption.ForeColor = Color.Black;
      this.asdasda.AppearanceItemCaption.Options.UseFont = true;
      this.asdasda.AppearanceItemCaption.Options.UseForeColor = true;
      this.asdasda.Control = (Control) this.muduryerineCombo;
      this.asdasda.Location = new Point(0, 587);
      this.asdasda.Name = "asdasda";
      this.asdasda.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.asdasda.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.asdasda.Size = new Size(787, 28);
      this.asdasda.Text = "Müdürün Yerine";
      this.asdasda.TextSize = new Size(133, 17);
      this.resimliYazBindingSource.DataSource = (object) this.resimliYaz;
      this.resimliYazBindingSource.Position = 0;
      this.resimliYaz.DataSetName = "ResimliYaz";
      this.resimliYaz.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 382);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(978, 102);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem16.Control = (Control) this.simpleButton1;
      this.layoutControlItem16.Location = new Point(627, 0);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(175, 596);
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.simpleButton1.Location = new Point(0, 0);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(75, 23);
      this.simpleButton1.TabIndex = 0;
      this.belediyeDataSet.DataSetName = "belediyeDataSet";
      this.belediyeDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.belediyeDataSet;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.radioButton1.AutoSize = true;
      this.radioButton1.ForeColor = Color.Black;
      this.radioButton1.Location = new Point(609, 41);
      this.radioButton1.Margin = new Padding(3, 2, 3, 2);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(86, 17);
      this.radioButton1.TabIndex = 3;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Personel İzin";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioGroup1.Location = new Point(609, 10);
      this.radioGroup1.Margin = new Padding(3, 2, 3, 2);
      this.radioGroup1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.radioGroup1.Name = "radioGroup1";
      this.radioGroup1.Size = new Size(91, 58);
      this.radioGroup1.TabIndex = 4;
      this.radioButton2.AutoSize = true;
      this.radioButton2.ForeColor = Color.Black;
      this.radioButton2.Location = new Point(609, 20);
      this.radioButton2.Margin = new Padding(3, 2, 3, 2);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(75, 17);
      this.radioButton2.TabIndex = 3;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Müdür İzin";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.Appearance.BackColor = Color.FromArgb(224, 224, 224);
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(807, 731);
      this.Controls.Add((Control) this.radioButton2);
      this.Controls.Add((Control) this.radioButton1);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Controls.Add((Control) this.radioGroup1);
      this.Name = nameof (PersoneIzinDuzenleme);
      this.Text = "Personel İzin Düzenleme";
      this.Load += new EventHandler(this.PersoneIzin_Load);
      this.repositoryItemRadioGroup6.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemRadioGroup3.EndInit();
      this.repositoryItemRadioGroup4.EndInit();
      this.repositoryItemRadioGroup5.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.muduryerineCombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.gridView3.EndInit();
      this.layoutControl6.EndInit();
      this.layoutControlGroup5.EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.gorevBasDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.gorevBasDateEdit.Properties.EndInit();
      this.genelSekreterYardSluEdit.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.insanKayDBskSluEdit.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.daireBaskanSluEdit.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.izinDurumComboEdit.Properties.EndInit();
      this.onayDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.onayDateEdit.Properties.EndInit();
      this.izinAdresMemoEdit.Properties.EndInit();
      this.izinGunSayisiTextEdit.Properties.EndInit();
      this.bitisTarihDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.bitisTarihDateEdit.Properties.EndInit();
      this.baslangicTarihDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.baslangicTarihDateEdit.Properties.EndInit();
      this.personelAdiSluEdit.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.izinSuresiTextEdit.Properties.EndInit();
      this.izinYillariTextEdit.Properties.EndInit();
      this.izinTuruComboEdit.Properties.EndInit();
      this.SubeMudurSluEdit.Properties.EndInit();
      this.gridView1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem23.EndInit();
      this.asdasda.EndInit();
      ((ISupportInitialize) this.resimliYazBindingSource).EndInit();
      this.resimliYaz.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem16.EndInit();
      this.belediyeDataSet.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.radioGroup1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class ElemanlarDurum
    {
      public int yil { get; set; }

      public int izinhakki { get; set; }

      public int kullan { get; set; }

      public int kalan { get; set; }

      public string istek { get; set; }
    }
  }
}
