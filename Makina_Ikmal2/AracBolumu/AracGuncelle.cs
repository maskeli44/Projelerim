// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.AracGuncelle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
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
using Makina_Ikmal.Properties;
using Makina_Ikmal.Sabitler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class AracGuncelle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private Resimleme res = new Resimleme();
    private YetkiClass yet = new YetkiClass();
    private int id = YetkiClass.secim_id;
    private bool resimDoluMuOn = false;
    private bool resimDoluMuarka = false;
    private string resimyolu;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem kayitButton;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private AraclarListesi araclarListesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private LayoutControl layoutControl1;
    private TextEdit plakaTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem difransiyel;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem26;
    private BindingSource dataTable1BindingSource1;
    private SearchLookUpEdit anaGrupLook;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem12;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem7;
    private BehaviorManager behaviorManager1;
    private LayoutControlItem BirimAdiCombo4558;
    private LayoutControlItem layoutControlItem20;
    private SearchLookUpEdit altGrupLook;
    private GridView gridView4;
    private TextEdit motorNoTxt;
    private GridColumn gridColumn5;
    private LookUpEdit modelYiliLook;
    private LayoutControlItem layoutControlItem17;
    private TextEdit saseNoTxt;
    private LayoutControlItem layoutControlItem24;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter tBLPERSONELISTIHDAMDURUMTableAdapter;
    private LookUpEdit markaLook;
    private LayoutControlItem layoutControlItem28;
    private BindingSource tBLPERSIZINDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSIZINDURUMTableAdapter tBLPERSIZINDURUMTableAdapter;
    private BindingSource tBLPERSONELDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter tBLPERSONELDURUMTableAdapter;
    private SimpleButton simpleButton5;
    private SimpleButton simpleButton3;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem30;
    private BarButtonItem barButtonItem8;
    private TextEdit tescilSiraNoTxt;
    private LookUpEdit aracTipiLook;
    private LookUpEdit aracDurumLook;
    private TextEdit aracAciklamaTxt;
    private TextEdit tahsisPlakaTxt;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem14;
    private LayoutControl layoutControl4;
    private SimpleButton simpleButton7;
    private SimpleButton simpleButton4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControlItem layoutControlItem51;
    private LayoutControlItem layoutControlItem52;
    private LayoutControl layoutControl3;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControlItem layoutControlItem43;
    private LayoutControlItem layoutControlItem50;
    private PictureEdit arkaGorunumPicture;
    private LookUpEdit tahsisEdilenLook;
    private LookUpEdit aracSoforuLook;
    private LookUpEdit mudurlukLook;
    private LookUpEdit birimAdiLook;
    private TextEdit anahtarAciklamaTxt;
    private TextEdit belgeSeriNoTxt;
    private TextEdit verildigiIlIlceTxt;
    private TextEdit beygirTxt;
    private MemoEdit ilgiliNotTxt;
    private CheckEdit aracTakipCheck;
    private TextEdit yeniDegerTxt;
    private TextEdit guncelDegerTxt;
    private LookUpEdit AracSahibiLook;
    private PictureEdit onGorunumPicture;
    private TextEdit silindirHacmiTxt;
    private TextEdit tipTxt;
    private TextEdit ticariAdiTxt;
    private TextEdit cinsTxt;
    private SimpleButton simpleButton6;
    private TextEdit renkTxt;
    private TextEdit motorGucuTxt;
    private LayoutControlItem layoutControlItem31;
    private LayoutControlItem layoutControlItem32;
    private LayoutControlItem layoutControlItem33;
    private LayoutControlItem layoutControlItem34;
    private LayoutControlItem layoutControlItem35;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem29;
    private LayoutControlItem layoutControlItem38;
    private LayoutControlItem layoutControlItem37;
    private LayoutControlItem layoutControlItem39;
    private LayoutControlItem layoutControlItem40;
    private LayoutControlItem layoutControlItem41;
    private LayoutControlItem layoutControlItem27;
    private LayoutControlItem layoutControlItem42;
    private LayoutControlItem layoutControlItem44;
    private LayoutControlItem layoutControlItem45;
    private LayoutControlItem layoutControlItem46;
    private LayoutControlItem layoutControlItem47;
    private LayoutControlItem layoutControlItem48;
    private LayoutControlItem layoutControlItem49;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem11;
    private ImageList ımageList1;
    private SimpleButton simpleButton8;
    private LayoutControlItem layoutControlItem53;
    private DateEdit yeniDegerDate;
    private LayoutControlItem layoutControlItem54;
    private DateEdit tahsisTarihDate;
    private DateEdit ilkTescilDate;
    private DateEdit tescilDate;
    private DateEdit muayeneDate;
    private DateEdit trafikSigortaDate;
    private DateEdit kaskoDate;
    private ComboBoxEdit paraCinsiCombo;
    private DateEdit gorevBitisDate;
    private LookUpEdit gorevDurumLook;
    private BindingSource tBLARACGRUBUBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACGRUBUTableAdapter tBLARACGRUBUTableAdapter;
    private BindingSource tBLARACGRUBU2BindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACGRUBU2TableAdapter tBLARACGRUBU2TableAdapter;
    private BindingSource tBLARACMARKABindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACMARKATableAdapter tBLARACMARKATableAdapter;
    private LookUpEdit yedekAnahtarLook;
    private BindingSource tBLVARYOKBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLVARYOKTableAdapter tBLVARYOKTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private bellDataSet6 bellDataSet6;
    private BindingSource tAHARACTIPIBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TAHARACTIPITableAdapter tAHARACTIPITableAdapter;
    private BindingSource tAHARACDURUMBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TAHARACDURUMTableAdapter tAHARACDURUMTableAdapter;
    private BindingSource tAHMODELYILIBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TAHMODELYILITableAdapter tAHMODELYILITableAdapter;
    private SimpleButton simpleButton11;
    private SimpleButton simpleButton10;
    private SimpleButton simpleButton9;
    private LayoutControlItem layoutControlItem55;
    private LayoutControlItem layoutControlItem56;
    private LayoutControlItem layoutControlItem57;
    private BindingSource tBLFIRMALARBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private GridColumn gridColumn1;
    private LayoutControlItem layoutControlItem58;
    private DateEdit EgzozDate;
    private SearchLookUpEdit aracIhaleGrupSluEdit;
    private GridView searchLookUpEdit1View;
    private LayoutControlItem layoutControlItem59;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private SimpleButton simpleButton12;
    private LayoutControlItem layoutControlItem36;

    public AracGuncelle() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.yenile();
      this.guncelleload();
    }

    public void yenile()
    {
      try
      {
        this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet6.TBLFIRMALAR);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tAHMODELYILITableAdapter.Fill(this.bellDataSet6.TAHMODELYILI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tAHARACDURUMTableAdapter.Fill(this.bellDataSet6.TAHARACDURUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tAHARACTIPITableAdapter.Fill(this.bellDataSet6.TAHARACTIPI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLVARYOKTableAdapter.Fill(this.bellDataSet5.TBLVARYOK);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACMARKATableAdapter.Fill(this.bellDataSet5.TBLARACMARKA);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBU2TableAdapter.Fill(this.bellDataSet5.TBLARACGRUBU2);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBUTableAdapter.Fill(this.bellDataSet5.TBLARACGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELDURUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSIZINDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSIZINDURUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELISTIHDAMDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELISTIHDAMDURUM);
      }
      catch (Exception ex)
      {
      }
      this.aracIhaleGrupSluEdit.Properties.DataSource = (object) this.db.TBLARACIHALEGRUP.Select(hd => new
      {
        ID = hd.ID,
        IHALEADI = hd.IHALEADI
      }).ToList();
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void degerleri()
    {
    }

    private void kayit()
    {
      TBLARACLAR entity = new TBLARACLAR();
      try
      {
        if (this.plakaTxt.Text != "")
          entity.PLAKA = this.plakaTxt.Text;
        if (this.aracTipiLook.Text != "")
          entity.ARACTIPIID = new int?(Convert.ToInt32(this.aracTipiLook.EditValue));
        if (this.aracDurumLook.Text != "")
          entity.ARACDURUMID = new int?(Convert.ToInt32(this.aracDurumLook.EditValue));
        if (this.anaGrupLook.Text != "")
          entity.ARACGRUBUID = new int?(Convert.ToInt32(this.anaGrupLook.EditValue));
        if (this.altGrupLook.Text != "")
          entity.ARACGRUBU2ID = new int?(Convert.ToInt32(this.altGrupLook.EditValue));
        if (this.aracIhaleGrupSluEdit.Text != "")
          entity.ARACIHALEGRUPID = new int?(Convert.ToInt32(this.aracIhaleGrupSluEdit.EditValue));
        if (this.aracAciklamaTxt.Text != "")
          entity.ARACACIKLAMA = this.aracAciklamaTxt.Text;
        if (this.tahsisPlakaTxt.Text != "")
          entity.TAHSPLAKA = this.tahsisPlakaTxt.Text;
        DateTime dateTime;
        if (this.tahsisTarihDate.Text != "")
        {
          TBLARACLAR tblaraclar = entity;
          dateTime = this.tahsisTarihDate.DateTime;
          string str = dateTime.ToString();
          tblaraclar.TAHSPLKTARIH = str;
        }
        if (this.ilkTescilDate.Text != "")
        {
          TBLARACLAR tblaraclar = entity;
          dateTime = this.ilkTescilDate.DateTime;
          string str = dateTime.ToString();
          tblaraclar.ILKTESCILTARIHI = str;
        }
        if (this.tescilSiraNoTxt.Text != "")
          entity.TESCILSIRANO = this.tescilSiraNoTxt.Text;
        if (this.tescilDate.Text != "")
        {
          TBLARACLAR tblaraclar = entity;
          dateTime = this.tescilDate.DateTime;
          string str = dateTime.ToString();
          tblaraclar.TESCILTARIHI = str;
        }
        if (this.markaLook.Text != "")
          entity.MARKAID = new int?(Convert.ToInt32(this.markaLook.EditValue));
        if (this.modelYiliLook.Text != "")
          entity.MODEL = this.modelYiliLook.Text.ToString();
        if (this.cinsTxt.Text != "")
          entity.CINSI = this.cinsTxt.Text;
        if (this.ticariAdiTxt.Text != "")
          entity.TICARIADI = this.ticariAdiTxt.Text;
        if (this.tipTxt.Text != "")
          entity.TIPI = this.tipTxt.Text;
        if (this.silindirHacmiTxt.Text != "")
          entity.SILINDIRHACMI = this.silindirHacmiTxt.Text;
        if (this.renkTxt.Text != "")
          entity.RENGI = this.renkTxt.Text;
        if (this.motorNoTxt.Text != "")
          entity.MOTORNO = this.motorNoTxt.Text;
        if (this.saseNoTxt.Text != "")
          entity.SASENO = this.saseNoTxt.Text;
        if (this.motorGucuTxt.Text != "")
          entity.MOTORGUCU = this.motorGucuTxt.Text;
        this.beygirTxt.Text = this.motorGucuTxt.Text;
        entity.BEYGIRGUCU = this.beygirTxt.Text;
        if (this.belgeSeriNoTxt.Text != "")
          entity.BELGESERINO = this.belgeSeriNoTxt.Text;
        if (this.verildigiIlIlceTxt.Text != "")
          entity.VERILDIGIILILCE = this.verildigiIlIlceTxt.Text;
        if (this.muayeneDate.Text != "")
          entity.MUAYENEGECSUR = new DateTime?(this.muayeneDate.DateTime);
        if (this.trafikSigortaDate.Text != "")
          entity.TRAFIKSGORTA2 = new DateTime?(this.trafikSigortaDate.DateTime);
        if (this.kaskoDate.Text != "")
        {
          TBLARACLAR tblaraclar = entity;
          dateTime = this.kaskoDate.DateTime;
          string str = dateTime.ToString();
          tblaraclar.KASKO = str;
        }
        if (this.yedekAnahtarLook.Text != "")
          entity.YEDEKANAHTAR = this.yedekAnahtarLook.Text;
        if (this.anahtarAciklamaTxt.Text != "")
          entity.YEDEKANHTRACKLM = this.anahtarAciklamaTxt.Text;
        if (this.EgzozDate.Text != "")
          entity.EGZOZKONTROL = new DateTime?(this.EgzozDate.DateTime);
        if (this.AracSahibiLook.Text != "")
          entity.ARACFIRMAID = new int?(Convert.ToInt32(this.AracSahibiLook.EditValue));
        if (this.guncelDegerTxt.Text != "")
          entity.GUNCELDEGERI = this.guncelDegerTxt.Text;
        if (this.yeniDegerTxt.Text != "")
          entity.YENIDEGERI = this.yeniDegerTxt.Text;
        if (this.paraCinsiCombo.Text != "")
          entity.PARABIRIMI = this.paraCinsiCombo.Text;
        if (this.aracTakipCheck.Text != "")
          entity.TAKIPVARYOKID = new int?(Convert.ToInt32(this.aracTakipCheck.Checked));
        if (this.ilgiliNotTxt.Text != "")
          entity.ILGILINOT = this.ilgiliNotTxt.Text;
        if (this.yeniDegerDate.Text != "")
          entity.YENIDEGERTARIH = new DateTime?(Convert.ToDateTime(this.yeniDegerDate.DateTime));
        this.db.TBLARACLAR.Add(entity);
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void guncelle()
    {
      TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == YetkiClass.secim_id));
      TBLARACRESIM entity = this.db.TBLARACRESIM.FirstOrDefault<TBLARACRESIM>((Expression<System.Func<TBLARACRESIM, bool>>) (x => x.ARACID == (int?) YetkiClass.secim_id));
      if (entity == null)
      {
        entity = new TBLARACRESIM();
        entity.ARACID = new int?(tblaraclar.ID);
        this.db.TBLARACRESIM.Add(entity);
        this.db.SaveChanges();
      }
      try
      {
        if (this.plakaTxt.Text != "")
          tblaraclar.PLAKA = this.plakaTxt.Text;
        if (this.aracTipiLook.Text != "")
          tblaraclar.ARACTIPIID = new int?(Convert.ToInt32(this.aracTipiLook.EditValue));
        if (this.aracDurumLook.Text != "")
          tblaraclar.ARACDURUMID = new int?(Convert.ToInt32(this.aracDurumLook.EditValue));
        if (this.anaGrupLook.Text != "")
          tblaraclar.ARACGRUBUID = new int?(Convert.ToInt32(this.anaGrupLook.EditValue));
        if (this.altGrupLook.Text != "")
          tblaraclar.ARACGRUBU2ID = new int?(Convert.ToInt32(this.altGrupLook.EditValue));
        if (this.aracIhaleGrupSluEdit.Text != "")
          tblaraclar.ARACIHALEGRUPID = new int?(Convert.ToInt32(this.aracIhaleGrupSluEdit.EditValue));
        if (this.aracAciklamaTxt.Text != "")
          tblaraclar.ARACACIKLAMA = this.aracAciklamaTxt.Text;
        if (this.tahsisPlakaTxt.Text != "")
          tblaraclar.TAHSPLAKA = this.tahsisPlakaTxt.Text;
        if (this.tahsisTarihDate.Text != "")
          tblaraclar.TAHSPLKTARIH = this.tahsisTarihDate.DateTime.ToString();
        if (this.ilkTescilDate.Text != "")
          tblaraclar.ILKTESCILTARIHI = this.ilkTescilDate.DateTime.ToString();
        if (this.tescilSiraNoTxt.Text != "")
          tblaraclar.TESCILSIRANO = this.tescilSiraNoTxt.Text;
        if (this.tescilDate.Text != "")
          tblaraclar.TESCILTARIHI = this.tescilDate.DateTime.ToString();
        if (this.markaLook.Text != "")
          tblaraclar.MARKAID = new int?(Convert.ToInt32(this.markaLook.EditValue));
        if (this.modelYiliLook.Text != "")
          tblaraclar.MODEL = this.modelYiliLook.Text.ToString();
        if (this.cinsTxt.Text != "")
          tblaraclar.CINSI = this.cinsTxt.Text;
        if (this.ticariAdiTxt.Text != "")
          tblaraclar.TICARIADI = this.ticariAdiTxt.Text;
        if (this.tipTxt.Text != "")
          tblaraclar.TIPI = this.tipTxt.Text;
        if (this.silindirHacmiTxt.Text != "")
          tblaraclar.SILINDIRHACMI = this.silindirHacmiTxt.Text;
        if (this.renkTxt.Text != "")
          tblaraclar.RENGI = this.renkTxt.Text;
        if (this.motorNoTxt.Text != "")
          tblaraclar.MOTORNO = this.motorNoTxt.Text;
        if (this.saseNoTxt.Text != "")
          tblaraclar.SASENO = this.saseNoTxt.Text;
        if (this.motorGucuTxt.Text != "")
          tblaraclar.MOTORGUCU = this.motorGucuTxt.Text;
        this.beygirTxt.Text = this.motorGucuTxt.Text;
        tblaraclar.BEYGIRGUCU = this.beygirTxt.Text;
        if (this.belgeSeriNoTxt.Text != "")
          tblaraclar.BELGESERINO = this.belgeSeriNoTxt.Text;
        if (this.verildigiIlIlceTxt.Text != "")
          tblaraclar.VERILDIGIILILCE = this.verildigiIlIlceTxt.Text;
        if (this.muayeneDate.Text != "")
          tblaraclar.MUAYENEGECSUR = new DateTime?(this.muayeneDate.DateTime);
        if (this.trafikSigortaDate.Text != "")
          tblaraclar.TRAFIKSGORTA2 = new DateTime?(this.trafikSigortaDate.DateTime);
        if (this.kaskoDate.Text != "")
          tblaraclar.KASKO = this.kaskoDate.DateTime.ToString();
        if (this.yedekAnahtarLook.Text != "")
          tblaraclar.YEDEKANAHTAR = this.yedekAnahtarLook.Text;
        if (this.anahtarAciklamaTxt.Text != "")
          tblaraclar.YEDEKANHTRACKLM = this.anahtarAciklamaTxt.Text;
        if (this.EgzozDate.Text != "")
          tblaraclar.EGZOZKONTROL = new DateTime?(this.EgzozDate.DateTime);
        if (this.AracSahibiLook.Text != "")
          tblaraclar.ARACFIRMAID = new int?(Convert.ToInt32(this.AracSahibiLook.EditValue));
        if (this.guncelDegerTxt.Text != "")
          tblaraclar.GUNCELDEGERI = this.guncelDegerTxt.Text;
        if (this.yeniDegerTxt.Text != "")
          tblaraclar.YENIDEGERI = this.yeniDegerTxt.Text;
        if (this.paraCinsiCombo.Text != "")
          tblaraclar.PARABIRIMI = this.paraCinsiCombo.Text;
        if (this.aracTakipCheck.Text != "")
          tblaraclar.TAKIPVARYOKID = !this.aracTakipCheck.Checked ? new int?(0) : new int?(1);
        if (this.ilgiliNotTxt.Text != "")
          tblaraclar.ILGILINOT = this.ilgiliNotTxt.Text;
        if (this.yeniDegerDate.Text != "")
          tblaraclar.YENIDEGERTARIH = new DateTime?(Convert.ToDateTime(this.yeniDegerDate.DateTime));
        if (this.resimDoluMuOn && entity != null)
          entity.ARACRESIMON = this.res.resimyukle(this.onGorunumPicture.Image);
        if (this.resimDoluMuarka && entity != null)
          entity.ARACRESIMARKA = this.res.resimyukle(this.arkaGorunumPicture.Image);
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Guncelleme başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void sil()
    {
    }

    private void listele()
    {
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.db.TBLARACLAR.Remove(this.db.TBLARACLAR.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
        ((AracListesi) Application.OpenForms["AracListesi"])?.Yenile();
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
      }
    }

    private void guncelleload()
    {
      TBLARACLAR sorgu = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == YetkiClass.secim_id));
      TBLARACRESIM tblaracresim = this.db.TBLARACRESIM.FirstOrDefault<TBLARACRESIM>((Expression<System.Func<TBLARACRESIM, bool>>) (x => x.ARACID == (int?) sorgu.ID));
      this.plakaTxt.EditValue = (object) sorgu.PLAKA;
      this.aracTipiLook.EditValue = (object) sorgu.ARACTIPIID;
      this.aracDurumLook.EditValue = (object) sorgu.ARACDURUMID;
      this.anaGrupLook.EditValue = (object) sorgu.ARACGRUBUID;
      this.altGrupLook.EditValue = (object) sorgu.ARACGRUBU2ID;
      this.aracIhaleGrupSluEdit.EditValue = (object) sorgu.ARACIHALEGRUPID;
      this.aracAciklamaTxt.EditValue = (object) sorgu.ARACACIKLAMA;
      this.tahsisPlakaTxt.EditValue = (object) sorgu.TAHSPLAKA;
      this.tahsisTarihDate.EditValue = (object) sorgu.TAHSPLKTARIH;
      this.ilkTescilDate.EditValue = (object) sorgu.ILKTESCILTARIHI;
      this.tescilSiraNoTxt.EditValue = (object) sorgu.TESCILSIRANO;
      this.tescilDate.EditValue = (object) sorgu.TESCILTARIHI;
      this.markaLook.EditValue = (object) sorgu.MARKAID;
      this.modelYiliLook.EditValue = (object) sorgu.MODEL;
      this.cinsTxt.EditValue = (object) sorgu.CINSI;
      this.ticariAdiTxt.EditValue = (object) sorgu.TICARIADI;
      this.tipTxt.EditValue = (object) sorgu.TICARIADI;
      this.silindirHacmiTxt.EditValue = (object) sorgu.SILINDIRHACMI;
      this.renkTxt.EditValue = (object) sorgu.RENGI;
      this.motorNoTxt.EditValue = (object) sorgu.MOTORNO;
      this.saseNoTxt.EditValue = (object) sorgu.SASENO;
      this.motorGucuTxt.EditValue = (object) sorgu.MOTORGUCU;
      this.beygirTxt.EditValue = (object) sorgu.BEYGIRGUCU;
      this.belgeSeriNoTxt.EditValue = (object) sorgu.BELGESERINO;
      this.verildigiIlIlceTxt.EditValue = (object) sorgu.VERILDIGIILILCE;
      this.muayeneDate.EditValue = (object) sorgu.MUAYENEGECSUR;
      this.trafikSigortaDate.EditValue = (object) sorgu.TRAFIKSGORTA2;
      this.kaskoDate.EditValue = (object) sorgu.KASKO;
      this.yedekAnahtarLook.EditValue = (object) sorgu.YEDEKANAHTAR;
      this.anahtarAciklamaTxt.EditValue = (object) sorgu.YEDEKANHTRACKLM;
      this.AracSahibiLook.EditValue = (object) sorgu.ARACFIRMAID;
      this.guncelDegerTxt.EditValue = (object) sorgu.GUNCELDEGERI;
      this.yeniDegerTxt.EditValue = (object) sorgu.YENIDEGERI;
      this.EgzozDate.EditValue = (object) sorgu.EGZOZKONTROL;
      this.yeniDegerDate.EditValue = (object) sorgu.YENIDEGERTARIH;
      this.paraCinsiCombo.EditValue = (object) sorgu.PARABIRIMI;
      int? takipvaryokid = sorgu.TAKIPVARYOKID;
      int num = 1;
      this.aracTakipCheck.Checked = takipvaryokid.GetValueOrDefault() == num & takipvaryokid.HasValue;
      this.ilgiliNotTxt.EditValue = (object) sorgu.ILGILINOT;
      if (tblaracresim != null && tblaracresim.ARACRESIMON != null)
        this.onGorunumPicture.Image = this.res.resimigetir(tblaracresim.ARACRESIMON);
      if (tblaracresim == null || tblaracresim.ARACRESIMARKA == null)
        return;
      this.arkaGorunumPicture.Image = this.res.resimigetir(tblaracresim.ARACRESIMARKA);
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void YetkiIzmaCombo_SelectedValueChanged(object sender, EventArgs e)
    {
    }

    private void personelistihdamcombo_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void simpleButton6_Click(object sender, EventArgs e)
    {
    }

    private void simpleButton7_Click(object sender, EventArgs e) => this.arkaGorunumPicture.Image = (Image) null;

    private void checkEdit1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void kayitButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.guncelle();
        LogEkle.Logs("Guncelleme Yapti");
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Guncelleme işlemi için yetkiniz yoktur.");
      }
      ((AracListesi) Application.OpenForms["AracListesi"])?.Yenile();
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      int num = (int) new AracKayitAnaGrup().ShowDialog();
    }

    private void simpleButton5_Click(object sender, EventArgs e)
    {
      int num = (int) new AracKayitAltGrup().ShowDialog();
    }

    private void simpleButton6_Click_1(object sender, EventArgs e)
    {
      int num = (int) new AracKayitMarka().ShowDialog();
    }

    private void simpleButton8_Click(object sender, EventArgs e)
    {
      int num = (int) new AracKayitAracSahibi().ShowDialog();
    }

    private void simpleButton1_Click_1(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
      int num = (int) openFileDialog.ShowDialog();
      this.resimyolu = openFileDialog.FileName;
      this.onGorunumPicture.Image = Image.FromFile(openFileDialog.FileName);
      this.resimDoluMuOn = true;
    }

    private void simpleButton4_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
      int num = (int) openFileDialog.ShowDialog();
      this.resimyolu = openFileDialog.FileName;
      this.arkaGorunumPicture.Image = Image.FromFile(openFileDialog.FileName);
      this.resimDoluMuarka = true;
    }

    private void simpleButton2_Click(object sender, EventArgs e) => this.onGorunumPicture.Image = (Image) null;

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.plakaTxt.EditValue = (object) null;
      this.aracTipiLook.EditValue = (object) null;
      this.aracDurumLook.EditValue = (object) null;
      this.anaGrupLook.EditValue = (object) null;
      this.altGrupLook.EditValue = (object) null;
      this.aracIhaleGrupSluEdit.EditValue = (object) null;
      this.aracAciklamaTxt.EditValue = (object) null;
      this.tahsisPlakaTxt.EditValue = (object) null;
      this.tahsisTarihDate.EditValue = (object) null;
      this.ilkTescilDate.EditValue = (object) null;
      this.tescilSiraNoTxt.EditValue = (object) null;
      this.tescilDate.EditValue = (object) null;
      this.markaLook.EditValue = (object) null;
      this.modelYiliLook.EditValue = (object) null;
      this.cinsTxt.EditValue = (object) null;
      this.ticariAdiTxt.EditValue = (object) null;
      this.tipTxt.EditValue = (object) null;
      this.silindirHacmiTxt.EditValue = (object) null;
      this.renkTxt.EditValue = (object) null;
      this.motorNoTxt.EditValue = (object) null;
      this.saseNoTxt.EditValue = (object) null;
      this.motorGucuTxt.EditValue = (object) null;
      this.beygirTxt.EditValue = (object) null;
      this.belgeSeriNoTxt.EditValue = (object) null;
      this.verildigiIlIlceTxt.EditValue = (object) null;
      this.muayeneDate.EditValue = (object) null;
      this.trafikSigortaDate.EditValue = (object) null;
      this.kaskoDate.EditValue = (object) null;
      this.yedekAnahtarLook.EditValue = (object) null;
      this.anahtarAciklamaTxt.EditValue = (object) null;
      this.AracSahibiLook.EditValue = (object) null;
      this.guncelDegerTxt.EditValue = (object) null;
      this.yeniDegerTxt.EditValue = (object) null;
      this.yeniDegerDate.EditValue = (object) null;
      this.paraCinsiCombo.EditValue = (object) null;
      this.aracTakipCheck.EditValue = (object) null;
      this.ilgiliNotTxt.EditValue = (object) null;
      this.onGorunumPicture.EditValue = (object) null;
      this.arkaGorunumPicture.EditValue = (object) null;
    }

    private void simpleButton11_Click(object sender, EventArgs e)
    {
      int num = (int) new ModelYili().ShowDialog();
    }

    private void simpleButton9_Click(object sender, EventArgs e)
    {
      int num = (int) new AracTipi().ShowDialog();
    }

    private void simpleButton12_Click(object sender, EventArgs e)
    {
      int num = (int) new AracKayitIhaleGrup().ShowDialog();
    }

    private void simpleButton10_Click(object sender, EventArgs e)
    {
      int num = (int) new AracDurum().ShowDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracGuncelle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.kayitButton = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.araclarListesi = new AraclarListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.simpleButton12 = new SimpleButton();
      this.aracIhaleGrupSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.simpleButton11 = new SimpleButton();
      this.simpleButton10 = new SimpleButton();
      this.simpleButton9 = new SimpleButton();
      this.yeniDegerDate = new DateEdit();
      this.simpleButton8 = new SimpleButton();
      this.layoutControl4 = new LayoutControl();
      this.simpleButton7 = new SimpleButton();
      this.simpleButton4 = new SimpleButton();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControlItem51 = new LayoutControlItem();
      this.layoutControlItem52 = new LayoutControlItem();
      this.layoutControl3 = new LayoutControl();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControlItem43 = new LayoutControlItem();
      this.layoutControlItem50 = new LayoutControlItem();
      this.arkaGorunumPicture = new PictureEdit();
      this.tahsisEdilenLook = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.aracSoforuLook = new LookUpEdit();
      this.mudurlukLook = new LookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.birimAdiLook = new LookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.anahtarAciklamaTxt = new TextEdit();
      this.belgeSeriNoTxt = new TextEdit();
      this.verildigiIlIlceTxt = new TextEdit();
      this.beygirTxt = new TextEdit();
      this.ilgiliNotTxt = new MemoEdit();
      this.aracTakipCheck = new CheckEdit();
      this.yeniDegerTxt = new TextEdit();
      this.guncelDegerTxt = new TextEdit();
      this.AracSahibiLook = new LookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.onGorunumPicture = new PictureEdit();
      this.silindirHacmiTxt = new TextEdit();
      this.tipTxt = new TextEdit();
      this.ticariAdiTxt = new TextEdit();
      this.cinsTxt = new TextEdit();
      this.simpleButton6 = new SimpleButton();
      this.tescilSiraNoTxt = new TextEdit();
      this.simpleButton5 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.markaLook = new LookUpEdit();
      this.tBLARACMARKABindingSource = new BindingSource(this.components);
      this.saseNoTxt = new TextEdit();
      this.plakaTxt = new TextEdit();
      this.anaGrupLook = new SearchLookUpEdit();
      this.tBLARACGRUBUBindingSource = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.altGrupLook = new SearchLookUpEdit();
      this.tBLARACGRUBU2BindingSource = new BindingSource(this.components);
      this.gridView4 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.motorNoTxt = new TextEdit();
      this.modelYiliLook = new LookUpEdit();
      this.tAHMODELYILIBindingSource = new BindingSource(this.components);
      this.aracTipiLook = new LookUpEdit();
      this.tAHARACTIPIBindingSource = new BindingSource(this.components);
      this.aracDurumLook = new LookUpEdit();
      this.tAHARACDURUMBindingSource = new BindingSource(this.components);
      this.aracAciklamaTxt = new TextEdit();
      this.tahsisPlakaTxt = new TextEdit();
      this.renkTxt = new TextEdit();
      this.motorGucuTxt = new TextEdit();
      this.tahsisTarihDate = new DateEdit();
      this.ilkTescilDate = new DateEdit();
      this.tescilDate = new DateEdit();
      this.muayeneDate = new DateEdit();
      this.trafikSigortaDate = new DateEdit();
      this.kaskoDate = new DateEdit();
      this.paraCinsiCombo = new ComboBoxEdit();
      this.gorevBitisDate = new DateEdit();
      this.gorevDurumLook = new LookUpEdit();
      this.yedekAnahtarLook = new LookUpEdit();
      this.tBLVARYOKBindingSource = new BindingSource(this.components);
      this.EgzozDate = new DateEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.difransiyel = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem28 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem30 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem31 = new LayoutControlItem();
      this.layoutControlItem32 = new LayoutControlItem();
      this.layoutControlItem33 = new LayoutControlItem();
      this.layoutControlItem34 = new LayoutControlItem();
      this.layoutControlItem35 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem29 = new LayoutControlItem();
      this.layoutControlItem38 = new LayoutControlItem();
      this.layoutControlItem37 = new LayoutControlItem();
      this.layoutControlItem24 = new LayoutControlItem();
      this.layoutControlItem39 = new LayoutControlItem();
      this.layoutControlItem40 = new LayoutControlItem();
      this.layoutControlItem41 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem42 = new LayoutControlItem();
      this.layoutControlItem44 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem53 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem49 = new LayoutControlItem();
      this.layoutControlItem48 = new LayoutControlItem();
      this.layoutControlItem47 = new LayoutControlItem();
      this.layoutControlItem46 = new LayoutControlItem();
      this.layoutControlItem45 = new LayoutControlItem();
      this.layoutControlItem54 = new LayoutControlItem();
      this.layoutControlItem55 = new LayoutControlItem();
      this.layoutControlItem56 = new LayoutControlItem();
      this.layoutControlItem57 = new LayoutControlItem();
      this.layoutControlItem58 = new LayoutControlItem();
      this.layoutControlItem59 = new LayoutControlItem();
      this.layoutControlItem36 = new LayoutControlItem();
      this.tBLPERSONELISTIHDAMDURUMBindingSource = new BindingSource(this.components);
      this.tBLPERSONELDURUMBindingSource = new BindingSource(this.components);
      this.tBLPERSIZINDURUMBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.BirimAdiCombo4558 = new LayoutControlItem();
      this.tBLPERSONELISTIHDAMDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter();
      this.tBLPERSIZINDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSIZINDURUMTableAdapter();
      this.tBLPERSONELDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter();
      this.ımageList1 = new ImageList(this.components);
      this.tBLARACGRUBUTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACGRUBUTableAdapter();
      this.tBLARACGRUBU2TableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACGRUBU2TableAdapter();
      this.tBLARACMARKATableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACMARKATableAdapter();
      this.tBLVARYOKTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLVARYOKTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDBIRIMLERTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDMUDURLUKTableAdapter();
      this.tAHARACTIPITableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TAHARACTIPITableAdapter();
      this.tAHARACDURUMTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TAHARACDURUMTableAdapter();
      this.tAHMODELYILITableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TAHMODELYILITableAdapter();
      this.tBLFIRMALARTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLFIRMALARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.araclarListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.aracIhaleGrupSluEdit.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.yeniDegerDate.Properties.CalendarTimeProperties.BeginInit();
      this.yeniDegerDate.Properties.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControl4.SuspendLayout();
      this.layoutControlGroup3.BeginInit();
      this.layoutControlItem51.BeginInit();
      this.layoutControlItem52.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControl3.SuspendLayout();
      this.layoutControlGroup2.BeginInit();
      this.layoutControlItem43.BeginInit();
      this.layoutControlItem50.BeginInit();
      this.arkaGorunumPicture.Properties.BeginInit();
      this.tahsisEdilenLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.aracSoforuLook.Properties.BeginInit();
      this.mudurlukLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.birimAdiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.anahtarAciklamaTxt.Properties.BeginInit();
      this.belgeSeriNoTxt.Properties.BeginInit();
      this.verildigiIlIlceTxt.Properties.BeginInit();
      this.beygirTxt.Properties.BeginInit();
      this.ilgiliNotTxt.Properties.BeginInit();
      this.aracTakipCheck.Properties.BeginInit();
      this.yeniDegerTxt.Properties.BeginInit();
      this.guncelDegerTxt.Properties.BeginInit();
      this.AracSahibiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.onGorunumPicture.Properties.BeginInit();
      this.silindirHacmiTxt.Properties.BeginInit();
      this.tipTxt.Properties.BeginInit();
      this.ticariAdiTxt.Properties.BeginInit();
      this.cinsTxt.Properties.BeginInit();
      this.tescilSiraNoTxt.Properties.BeginInit();
      this.markaLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACMARKABindingSource).BeginInit();
      this.saseNoTxt.Properties.BeginInit();
      this.plakaTxt.Properties.BeginInit();
      this.anaGrupLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).BeginInit();
      this.gridView1.BeginInit();
      this.altGrupLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).BeginInit();
      this.gridView4.BeginInit();
      this.motorNoTxt.Properties.BeginInit();
      this.modelYiliLook.Properties.BeginInit();
      ((ISupportInitialize) this.tAHMODELYILIBindingSource).BeginInit();
      this.aracTipiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tAHARACTIPIBindingSource).BeginInit();
      this.aracDurumLook.Properties.BeginInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource).BeginInit();
      this.aracAciklamaTxt.Properties.BeginInit();
      this.tahsisPlakaTxt.Properties.BeginInit();
      this.renkTxt.Properties.BeginInit();
      this.motorGucuTxt.Properties.BeginInit();
      this.tahsisTarihDate.Properties.CalendarTimeProperties.BeginInit();
      this.tahsisTarihDate.Properties.BeginInit();
      this.ilkTescilDate.Properties.CalendarTimeProperties.BeginInit();
      this.ilkTescilDate.Properties.BeginInit();
      this.tescilDate.Properties.CalendarTimeProperties.BeginInit();
      this.tescilDate.Properties.BeginInit();
      this.muayeneDate.Properties.CalendarTimeProperties.BeginInit();
      this.muayeneDate.Properties.BeginInit();
      this.trafikSigortaDate.Properties.CalendarTimeProperties.BeginInit();
      this.trafikSigortaDate.Properties.BeginInit();
      this.kaskoDate.Properties.CalendarTimeProperties.BeginInit();
      this.kaskoDate.Properties.BeginInit();
      this.paraCinsiCombo.Properties.BeginInit();
      this.gorevBitisDate.Properties.CalendarTimeProperties.BeginInit();
      this.gorevBitisDate.Properties.BeginInit();
      this.gorevDurumLook.Properties.BeginInit();
      this.yedekAnahtarLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLVARYOKBindingSource).BeginInit();
      this.EgzozDate.Properties.CalendarTimeProperties.BeginInit();
      this.EgzozDate.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.difransiyel.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem28.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem30.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem31.BeginInit();
      this.layoutControlItem32.BeginInit();
      this.layoutControlItem33.BeginInit();
      this.layoutControlItem34.BeginInit();
      this.layoutControlItem35.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem29.BeginInit();
      this.layoutControlItem38.BeginInit();
      this.layoutControlItem37.BeginInit();
      this.layoutControlItem24.BeginInit();
      this.layoutControlItem39.BeginInit();
      this.layoutControlItem40.BeginInit();
      this.layoutControlItem41.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem42.BeginInit();
      this.layoutControlItem44.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem53.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem49.BeginInit();
      this.layoutControlItem48.BeginInit();
      this.layoutControlItem47.BeginInit();
      this.layoutControlItem46.BeginInit();
      this.layoutControlItem45.BeginInit();
      this.layoutControlItem54.BeginInit();
      this.layoutControlItem55.BeginInit();
      this.layoutControlItem56.BeginInit();
      this.layoutControlItem57.BeginInit();
      this.layoutControlItem58.BeginInit();
      this.layoutControlItem59.BeginInit();
      this.layoutControlItem36.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSIZINDURUMBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.emptySpaceItem1.BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.BirimAdiCombo4558.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[10]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.kayitButton,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 9;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(1139, 100);
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
      this.kayitButton.Caption = "Kaydet";
      this.kayitButton.Id = 2;
      this.kayitButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kayitButton.ImageOptions.Image");
      this.kayitButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kayitButton.ImageOptions.LargeImage");
      this.kayitButton.LargeWidth = 100;
      this.kayitButton.Name = "kayitButton";
      this.kayitButton.ItemClick += new ItemClickEventHandler(this.kayitButton_ItemClick);
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
      this.barButtonItem8.Caption = "Yeni";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.kayitButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.araclarListesi.DataSetName = "AraclarListesi";
      this.araclarListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.araclarListesi;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.layoutControl1.Controls.Add((Control) this.simpleButton12);
      this.layoutControl1.Controls.Add((Control) this.aracIhaleGrupSluEdit);
      this.layoutControl1.Controls.Add((Control) this.simpleButton11);
      this.layoutControl1.Controls.Add((Control) this.simpleButton10);
      this.layoutControl1.Controls.Add((Control) this.simpleButton9);
      this.layoutControl1.Controls.Add((Control) this.yeniDegerDate);
      this.layoutControl1.Controls.Add((Control) this.simpleButton8);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.arkaGorunumPicture);
      this.layoutControl1.Controls.Add((Control) this.tahsisEdilenLook);
      this.layoutControl1.Controls.Add((Control) this.aracSoforuLook);
      this.layoutControl1.Controls.Add((Control) this.mudurlukLook);
      this.layoutControl1.Controls.Add((Control) this.birimAdiLook);
      this.layoutControl1.Controls.Add((Control) this.anahtarAciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.belgeSeriNoTxt);
      this.layoutControl1.Controls.Add((Control) this.verildigiIlIlceTxt);
      this.layoutControl1.Controls.Add((Control) this.beygirTxt);
      this.layoutControl1.Controls.Add((Control) this.ilgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.aracTakipCheck);
      this.layoutControl1.Controls.Add((Control) this.yeniDegerTxt);
      this.layoutControl1.Controls.Add((Control) this.guncelDegerTxt);
      this.layoutControl1.Controls.Add((Control) this.AracSahibiLook);
      this.layoutControl1.Controls.Add((Control) this.onGorunumPicture);
      this.layoutControl1.Controls.Add((Control) this.silindirHacmiTxt);
      this.layoutControl1.Controls.Add((Control) this.tipTxt);
      this.layoutControl1.Controls.Add((Control) this.ticariAdiTxt);
      this.layoutControl1.Controls.Add((Control) this.cinsTxt);
      this.layoutControl1.Controls.Add((Control) this.simpleButton6);
      this.layoutControl1.Controls.Add((Control) this.tescilSiraNoTxt);
      this.layoutControl1.Controls.Add((Control) this.simpleButton5);
      this.layoutControl1.Controls.Add((Control) this.simpleButton3);
      this.layoutControl1.Controls.Add((Control) this.markaLook);
      this.layoutControl1.Controls.Add((Control) this.saseNoTxt);
      this.layoutControl1.Controls.Add((Control) this.plakaTxt);
      this.layoutControl1.Controls.Add((Control) this.anaGrupLook);
      this.layoutControl1.Controls.Add((Control) this.altGrupLook);
      this.layoutControl1.Controls.Add((Control) this.motorNoTxt);
      this.layoutControl1.Controls.Add((Control) this.modelYiliLook);
      this.layoutControl1.Controls.Add((Control) this.aracTipiLook);
      this.layoutControl1.Controls.Add((Control) this.aracDurumLook);
      this.layoutControl1.Controls.Add((Control) this.aracAciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.tahsisPlakaTxt);
      this.layoutControl1.Controls.Add((Control) this.renkTxt);
      this.layoutControl1.Controls.Add((Control) this.motorGucuTxt);
      this.layoutControl1.Controls.Add((Control) this.tahsisTarihDate);
      this.layoutControl1.Controls.Add((Control) this.ilkTescilDate);
      this.layoutControl1.Controls.Add((Control) this.tescilDate);
      this.layoutControl1.Controls.Add((Control) this.muayeneDate);
      this.layoutControl1.Controls.Add((Control) this.trafikSigortaDate);
      this.layoutControl1.Controls.Add((Control) this.kaskoDate);
      this.layoutControl1.Controls.Add((Control) this.paraCinsiCombo);
      this.layoutControl1.Controls.Add((Control) this.gorevBitisDate);
      this.layoutControl1.Controls.Add((Control) this.gorevDurumLook);
      this.layoutControl1.Controls.Add((Control) this.yedekAnahtarLook);
      this.layoutControl1.Controls.Add((Control) this.EgzozDate);
      this.layoutControl1.Dock = DockStyle.Top;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(995, 216, 812, 500));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1139, 438);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.simpleButton12.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton12.ImageOptions.Image");
      this.simpleButton12.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton12.Location = new Point(326, 147);
      this.simpleButton12.Name = "simpleButton12";
      this.simpleButton12.PaintStyle = PaintStyles.Light;
      this.simpleButton12.Size = new Size(30, 22);
      this.simpleButton12.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton12.TabIndex = 99;
      this.simpleButton12.Click += new EventHandler(this.simpleButton12_Click);
      this.aracIhaleGrupSluEdit.Location = new Point(129, 147);
      this.aracIhaleGrupSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracIhaleGrupSluEdit.Name = "aracIhaleGrupSluEdit";
      this.aracIhaleGrupSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f);
      this.aracIhaleGrupSluEdit.Properties.Appearance.Options.UseFont = true;
      this.aracIhaleGrupSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracIhaleGrupSluEdit.Properties.DisplayMember = "IHALEADI";
      this.aracIhaleGrupSluEdit.Properties.NullText = "";
      this.aracIhaleGrupSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.aracIhaleGrupSluEdit.Properties.ValueMember = "ID";
      this.aracIhaleGrupSluEdit.Size = new Size(193, 24);
      this.aracIhaleGrupSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.aracIhaleGrupSluEdit.TabIndex = 98;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[2]
      {
        this.gridColumn2,
        this.gridColumn3
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "ID";
      this.gridColumn2.FieldName = "ID";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn3.Caption = "IHALEADI";
      this.gridColumn3.FieldName = "IHALEADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.simpleButton11.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton11.ImageOptions.Image");
      this.simpleButton11.Location = new Point(392, 369);
      this.simpleButton11.Name = "simpleButton11";
      this.simpleButton11.PaintStyle = PaintStyles.Light;
      this.simpleButton11.Size = new Size(22, 22);
      this.simpleButton11.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton11.TabIndex = 96;
      this.simpleButton11.Click += new EventHandler(this.simpleButton11_Click);
      this.simpleButton10.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton10.ImageOptions.Image");
      this.simpleButton10.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton10.Location = new Point(326, 68);
      this.simpleButton10.Name = "simpleButton10";
      this.simpleButton10.PaintStyle = PaintStyles.Light;
      this.simpleButton10.Size = new Size(30, 22);
      this.simpleButton10.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton10.TabIndex = 95;
      this.simpleButton10.Click += new EventHandler(this.simpleButton10_Click);
      this.simpleButton9.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton9.ImageOptions.Image");
      this.simpleButton9.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton9.Location = new Point(326, 40);
      this.simpleButton9.Name = "simpleButton9";
      this.simpleButton9.PaintStyle = PaintStyles.Light;
      this.simpleButton9.Size = new Size(30, 22);
      this.simpleButton9.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton9.TabIndex = 94;
      this.simpleButton9.Click += new EventHandler(this.simpleButton9_Click);
      this.yeniDegerDate.EditValue = (object) null;
      this.yeniDegerDate.Location = new Point(1046, 231);
      this.yeniDegerDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yeniDegerDate.Name = "yeniDegerDate";
      this.yeniDegerDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yeniDegerDate.Properties.Appearance.Options.UseFont = true;
      this.yeniDegerDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yeniDegerDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yeniDegerDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.yeniDegerDate.Size = new Size(64, 24);
      this.yeniDegerDate.StyleController = (IStyleController) this.layoutControl1;
      this.yeniDegerDate.TabIndex = 93;
      this.simpleButton8.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton8.ImageOptions.Image");
      this.simpleButton8.Location = new Point(1080, 175);
      this.simpleButton8.Name = "simpleButton8";
      this.simpleButton8.PaintStyle = PaintStyles.Light;
      this.simpleButton8.Size = new Size(30, 24);
      this.simpleButton8.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton8.TabIndex = 92;
      this.simpleButton8.Click += new EventHandler(this.simpleButton8_Click);
      this.layoutControl4.Controls.Add((Control) this.simpleButton7);
      this.layoutControl4.Controls.Add((Control) this.simpleButton4);
      this.layoutControl4.Location = new Point(882, 12);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(228, 159);
      this.layoutControl4.TabIndex = 91;
      this.layoutControl4.Text = "layoutControl4";
      this.simpleButton7.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton7.ImageOptions.Image");
      this.simpleButton7.Location = new Point(12, 84);
      this.simpleButton7.Name = "simpleButton7";
      this.simpleButton7.PaintStyle = PaintStyles.Light;
      this.simpleButton7.Size = new Size(204, 63);
      this.simpleButton7.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton7.TabIndex = 5;
      this.simpleButton7.Click += new EventHandler(this.simpleButton7_Click);
      this.simpleButton4.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton4.ImageOptions.Image");
      this.simpleButton4.Location = new Point(12, 12);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.PaintStyle = PaintStyles.Light;
      this.simpleButton4.Size = new Size(204, 68);
      this.simpleButton4.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton4.TabIndex = 4;
      this.simpleButton4.Click += new EventHandler(this.simpleButton4_Click);
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem51,
        (BaseLayoutItem) this.layoutControlItem52
      });
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(228, 159);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControlItem51.Control = (Control) this.simpleButton4;
      this.layoutControlItem51.Location = new Point(0, 0);
      this.layoutControlItem51.MinSize = new Size(78, 26);
      this.layoutControlItem51.Name = "layoutControlItem51";
      this.layoutControlItem51.Size = new Size(208, 72);
      this.layoutControlItem51.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem51.TextSize = new Size(0, 0);
      this.layoutControlItem51.TextVisible = false;
      this.layoutControlItem52.Control = (Control) this.simpleButton7;
      this.layoutControlItem52.Location = new Point(0, 72);
      this.layoutControlItem52.MinSize = new Size(78, 26);
      this.layoutControlItem52.Name = "layoutControlItem52";
      this.layoutControlItem52.Size = new Size(208, 67);
      this.layoutControlItem52.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem52.TextSize = new Size(0, 0);
      this.layoutControlItem52.TextVisible = false;
      this.layoutControl3.Controls.Add((Control) this.simpleButton2);
      this.layoutControl3.Controls.Add((Control) this.simpleButton1);
      this.layoutControl3.Location = new Point(501, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(223, 159);
      this.layoutControl3.TabIndex = 90;
      this.layoutControl3.Text = "layoutControl3";
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(12, 81);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(199, 66);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl3;
      this.simpleButton2.TabIndex = 5;
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(12, 12);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(199, 65);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl3;
      this.simpleButton1.TabIndex = 4;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click_1);
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem43,
        (BaseLayoutItem) this.layoutControlItem50
      });
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(223, 159);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControlItem43.Control = (Control) this.simpleButton1;
      this.layoutControlItem43.Location = new Point(0, 0);
      this.layoutControlItem43.MinSize = new Size(78, 26);
      this.layoutControlItem43.Name = "layoutControlItem43";
      this.layoutControlItem43.Size = new Size(203, 69);
      this.layoutControlItem43.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem43.TextSize = new Size(0, 0);
      this.layoutControlItem43.TextVisible = false;
      this.layoutControlItem50.Control = (Control) this.simpleButton2;
      this.layoutControlItem50.Location = new Point(0, 69);
      this.layoutControlItem50.MinSize = new Size(78, 26);
      this.layoutControlItem50.Name = "layoutControlItem50";
      this.layoutControlItem50.Size = new Size(203, 70);
      this.layoutControlItem50.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem50.TextSize = new Size(0, 0);
      this.layoutControlItem50.TextVisible = false;
      this.arkaGorunumPicture.Location = new Point(728, 12);
      this.arkaGorunumPicture.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.arkaGorunumPicture.Name = "arkaGorunumPicture";
      this.arkaGorunumPicture.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.arkaGorunumPicture.Properties.SizeMode = PictureSizeMode.Stretch;
      this.arkaGorunumPicture.Size = new Size(150, 143);
      this.arkaGorunumPicture.StyleController = (IStyleController) this.layoutControl1;
      this.arkaGorunumPicture.TabIndex = 89;
      this.tahsisEdilenLook.Enabled = false;
      this.tahsisEdilenLook.Location = new Point(885, 475);
      this.tahsisEdilenLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tahsisEdilenLook.Name = "tahsisEdilenLook";
      this.tahsisEdilenLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tahsisEdilenLook.Properties.Appearance.Options.UseFont = true;
      this.tahsisEdilenLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tahsisEdilenLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.tahsisEdilenLook.Properties.DisplayMember = "ADISOYADI";
      this.tahsisEdilenLook.Properties.NullText = "";
      this.tahsisEdilenLook.Properties.ValueMember = "ID";
      this.tahsisEdilenLook.Size = new Size(225, 24);
      this.tahsisEdilenLook.StyleController = (IStyleController) this.layoutControl1;
      this.tahsisEdilenLook.TabIndex = 88;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.aracSoforuLook.Enabled = false;
      this.aracSoforuLook.Location = new Point(885, 447);
      this.aracSoforuLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracSoforuLook.Name = "aracSoforuLook";
      this.aracSoforuLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracSoforuLook.Properties.Appearance.Options.UseFont = true;
      this.aracSoforuLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracSoforuLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.aracSoforuLook.Properties.DisplayMember = "ADISOYADI";
      this.aracSoforuLook.Properties.NullText = "";
      this.aracSoforuLook.Properties.ValueMember = "ID";
      this.aracSoforuLook.Size = new Size(225, 24);
      this.aracSoforuLook.StyleController = (IStyleController) this.layoutControl1;
      this.aracSoforuLook.TabIndex = 87;
      this.mudurlukLook.Enabled = false;
      this.mudurlukLook.Location = new Point(885, 419);
      this.mudurlukLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurlukLook.Name = "mudurlukLook";
      this.mudurlukLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mudurlukLook.Properties.Appearance.Options.UseFont = true;
      this.mudurlukLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurlukLook.Properties.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.mudurlukLook.Properties.DisplayMember = "BELDMUDURLUK";
      this.mudurlukLook.Properties.NullText = "";
      this.mudurlukLook.Properties.ValueMember = "ID";
      this.mudurlukLook.Size = new Size(225, 24);
      this.mudurlukLook.StyleController = (IStyleController) this.layoutControl1;
      this.mudurlukLook.TabIndex = 86;
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.birimAdiLook.Enabled = false;
      this.birimAdiLook.Location = new Point(885, 391);
      this.birimAdiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimAdiLook.Name = "birimAdiLook";
      this.birimAdiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimAdiLook.Properties.Appearance.Options.UseFont = true;
      this.birimAdiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimAdiLook.Properties.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.birimAdiLook.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimAdiLook.Properties.NullText = "";
      this.birimAdiLook.Properties.ValueMember = "ID";
      this.birimAdiLook.Size = new Size(225, 24);
      this.birimAdiLook.StyleController = (IStyleController) this.layoutControl1;
      this.birimAdiLook.TabIndex = 85;
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.anahtarAciklamaTxt.Location = new Point(535, 475);
      this.anahtarAciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.anahtarAciklamaTxt.Name = "anahtarAciklamaTxt";
      this.anahtarAciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.anahtarAciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.anahtarAciklamaTxt.Size = new Size(229, 24);
      this.anahtarAciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.anahtarAciklamaTxt.TabIndex = 81;
      this.belgeSeriNoTxt.Location = new Point(535, 315);
      this.belgeSeriNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.belgeSeriNoTxt.Name = "belgeSeriNoTxt";
      this.belgeSeriNoTxt.Size = new Size(229, 20);
      this.belgeSeriNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.belgeSeriNoTxt.TabIndex = 76;
      this.verildigiIlIlceTxt.Location = new Point(535, 339);
      this.verildigiIlIlceTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.verildigiIlIlceTxt.Name = "verildigiIlIlceTxt";
      this.verildigiIlIlceTxt.Size = new Size(229, 20);
      this.verildigiIlIlceTxt.StyleController = (IStyleController) this.layoutControl1;
      this.verildigiIlIlceTxt.TabIndex = 75;
      this.beygirTxt.Location = new Point(719, 287);
      this.beygirTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.beygirTxt.Name = "beygirTxt";
      this.beygirTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.beygirTxt.Properties.Appearance.Options.UseFont = true;
      this.beygirTxt.Properties.Mask.EditMask = "d";
      this.beygirTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.beygirTxt.Size = new Size(45, 24);
      this.beygirTxt.StyleController = (IStyleController) this.layoutControl1;
      this.beygirTxt.TabIndex = 74;
      this.ilgiliNotTxt.Location = new Point(885, 283);
      this.ilgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilgiliNotTxt.Name = "ilgiliNotTxt";
      this.ilgiliNotTxt.Size = new Size(225, 48);
      this.ilgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ilgiliNotTxt.TabIndex = 73;
      this.aracTakipCheck.Location = new Point(768, 259);
      this.aracTakipCheck.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracTakipCheck.Name = "aracTakipCheck";
      this.aracTakipCheck.Properties.Caption = "Araç Takipte Var/Yok";
      this.aracTakipCheck.Size = new Size(342, 20);
      this.aracTakipCheck.StyleController = (IStyleController) this.layoutControl1;
      this.aracTakipCheck.TabIndex = 72;
      this.aracTakipCheck.CheckedChanged += new EventHandler(this.checkEdit1_CheckedChanged);
      this.yeniDegerTxt.Location = new Point(845, 231);
      this.yeniDegerTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yeniDegerTxt.Name = "yeniDegerTxt";
      this.yeniDegerTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yeniDegerTxt.Properties.Appearance.Options.UseFont = true;
      this.yeniDegerTxt.Properties.Mask.EditMask = "c";
      this.yeniDegerTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.yeniDegerTxt.Size = new Size((int) sbyte.MaxValue, 24);
      this.yeniDegerTxt.StyleController = (IStyleController) this.layoutControl1;
      this.yeniDegerTxt.TabIndex = 70;
      this.guncelDegerTxt.Location = new Point(845, 203);
      this.guncelDegerTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.guncelDegerTxt.Name = "guncelDegerTxt";
      this.guncelDegerTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.guncelDegerTxt.Properties.Appearance.Options.UseFont = true;
      this.guncelDegerTxt.Properties.Mask.EditMask = "c";
      this.guncelDegerTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.guncelDegerTxt.Size = new Size(265, 24);
      this.guncelDegerTxt.StyleController = (IStyleController) this.layoutControl1;
      this.guncelDegerTxt.TabIndex = 69;
      this.AracSahibiLook.Location = new Point(844, 175);
      this.AracSahibiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AracSahibiLook.Name = "AracSahibiLook";
      this.AracSahibiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AracSahibiLook.Properties.Appearance.Options.UseFont = true;
      this.AracSahibiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AracSahibiLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("FIRMAADI", "FIRMAADI")
      });
      this.AracSahibiLook.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.AracSahibiLook.Properties.DisplayMember = "FIRMAADI";
      this.AracSahibiLook.Properties.NullText = "";
      this.AracSahibiLook.Properties.ValueMember = "ID";
      this.AracSahibiLook.Size = new Size(232, 24);
      this.AracSahibiLook.StyleController = (IStyleController) this.layoutControl1;
      this.AracSahibiLook.TabIndex = 68;
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.onGorunumPicture.Location = new Point(360, 12);
      this.onGorunumPicture.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.onGorunumPicture.Name = "onGorunumPicture";
      this.onGorunumPicture.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.onGorunumPicture.Properties.SizeMode = PictureSizeMode.Stretch;
      this.onGorunumPicture.Size = new Size(137, 143);
      this.onGorunumPicture.StyleController = (IStyleController) this.layoutControl1;
      this.onGorunumPicture.TabIndex = 65;
      this.silindirHacmiTxt.Location = new Point(129, 481);
      this.silindirHacmiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.silindirHacmiTxt.Name = "silindirHacmiTxt";
      this.silindirHacmiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.silindirHacmiTxt.Properties.Appearance.Options.UseFont = true;
      this.silindirHacmiTxt.Size = new Size(285, 24);
      this.silindirHacmiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.silindirHacmiTxt.TabIndex = 63;
      this.tipTxt.Location = new Point(129, 453);
      this.tipTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tipTxt.Name = "tipTxt";
      this.tipTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tipTxt.Properties.Appearance.Options.UseFont = true;
      this.tipTxt.Size = new Size(285, 24);
      this.tipTxt.StyleController = (IStyleController) this.layoutControl1;
      this.tipTxt.TabIndex = 62;
      this.ticariAdiTxt.Location = new Point(129, 425);
      this.ticariAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ticariAdiTxt.Name = "ticariAdiTxt";
      this.ticariAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ticariAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.ticariAdiTxt.Size = new Size(285, 24);
      this.ticariAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ticariAdiTxt.TabIndex = 61;
      this.cinsTxt.Location = new Point(129, 397);
      this.cinsTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cinsTxt.Name = "cinsTxt";
      this.cinsTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cinsTxt.Properties.Appearance.Options.UseFont = true;
      this.cinsTxt.Size = new Size(285, 24);
      this.cinsTxt.StyleController = (IStyleController) this.layoutControl1;
      this.cinsTxt.TabIndex = 60;
      this.simpleButton6.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton6.ImageOptions.Image");
      this.simpleButton6.Location = new Point(392, 343);
      this.simpleButton6.Name = "simpleButton6";
      this.simpleButton6.PaintStyle = PaintStyles.Light;
      this.simpleButton6.Size = new Size(22, 22);
      this.simpleButton6.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton6.TabIndex = 59;
      this.simpleButton6.Click += new EventHandler(this.simpleButton6_Click_1);
      this.tescilSiraNoTxt.Location = new Point(129, 287);
      this.tescilSiraNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tescilSiraNoTxt.Name = "tescilSiraNoTxt";
      this.tescilSiraNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tescilSiraNoTxt.Properties.Appearance.Options.UseFont = true;
      this.tescilSiraNoTxt.Size = new Size(285, 24);
      this.tescilSiraNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.tescilSiraNoTxt.TabIndex = 58;
      this.simpleButton5.ImageOptions.Image = (Image) Resources.add_16x163;
      this.simpleButton5.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton5.Location = new Point(326, 121);
      this.simpleButton5.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton5.Name = "simpleButton5";
      this.simpleButton5.PaintStyle = PaintStyles.Light;
      this.simpleButton5.Size = new Size(30, 22);
      this.simpleButton5.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton5.TabIndex = 49;
      this.simpleButton5.Click += new EventHandler(this.simpleButton5_Click);
      this.simpleButton3.ImageOptions.Image = (Image) Resources.add_16x162;
      this.simpleButton3.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton3.Location = new Point(326, 96);
      this.simpleButton3.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(30, 21);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 47;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.markaLook.Location = new Point(129, 343);
      this.markaLook.Margin = new Padding(3, 2, 3, 2);
      this.markaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.markaLook.Name = "markaLook";
      this.markaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.markaLook.Properties.Appearance.Options.UseFont = true;
      this.markaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.markaLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ARACMARKA", "Marka")
      });
      this.markaLook.Properties.DataSource = (object) this.tBLARACMARKABindingSource;
      this.markaLook.Properties.DisplayMember = "ARACMARKA";
      this.markaLook.Properties.NullText = "";
      this.markaLook.Properties.ValueMember = "ID";
      this.markaLook.Size = new Size(259, 24);
      this.markaLook.StyleController = (IStyleController) this.layoutControl1;
      this.markaLook.TabIndex = 46;
      this.tBLARACMARKABindingSource.DataMember = "TBLARACMARKA";
      this.tBLARACMARKABindingSource.DataSource = (object) this.bellDataSet5;
      this.saseNoTxt.Location = new Point(535, 259);
      this.saseNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saseNoTxt.Name = "saseNoTxt";
      this.saseNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saseNoTxt.Properties.Appearance.Options.UseFont = true;
      this.saseNoTxt.Size = new Size(229, 24);
      this.saseNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.saseNoTxt.TabIndex = 45;
      this.plakaTxt.Location = new Point(129, 12);
      this.plakaTxt.Margin = new Padding(3, 2, 3, 2);
      this.plakaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaTxt.Name = "plakaTxt";
      this.plakaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaTxt.Properties.Appearance.Options.UseFont = true;
      this.plakaTxt.Properties.Mask.BeepOnError = true;
      this.plakaTxt.Properties.Mask.EditMask = "n0";
      this.plakaTxt.Size = new Size(227, 24);
      this.plakaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.plakaTxt.TabIndex = 13;
      this.anaGrupLook.Location = new Point(129, 96);
      this.anaGrupLook.Margin = new Padding(3, 2, 3, 2);
      this.anaGrupLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.anaGrupLook.Name = "anaGrupLook";
      this.anaGrupLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.anaGrupLook.Properties.Appearance.Options.UseFont = true;
      this.anaGrupLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.anaGrupLook.Properties.DataSource = (object) this.tBLARACGRUBUBindingSource;
      this.anaGrupLook.Properties.DisplayMember = "GRUPADI";
      this.anaGrupLook.Properties.NullText = "";
      this.anaGrupLook.Properties.PopupView = (ColumnView) this.gridView1;
      this.anaGrupLook.Properties.ValueMember = "ID";
      this.anaGrupLook.Size = new Size(193, 24);
      this.anaGrupLook.StyleController = (IStyleController) this.layoutControl1;
      this.anaGrupLook.TabIndex = 5;
      this.tBLARACGRUBUBindingSource.DataMember = "TBLARACGRUBU";
      this.tBLARACGRUBUBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Grup Adı";
      this.gridColumn1.FieldName = "GRUPADI";
      this.gridColumn1.MinWidth = 17;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 64;
      this.altGrupLook.Location = new Point(129, 121);
      this.altGrupLook.Margin = new Padding(3, 2, 3, 2);
      this.altGrupLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.altGrupLook.Name = "altGrupLook";
      this.altGrupLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.altGrupLook.Properties.Appearance.Options.UseFont = true;
      this.altGrupLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.altGrupLook.Properties.DataSource = (object) this.tBLARACGRUBU2BindingSource;
      this.altGrupLook.Properties.DisplayMember = "GRUPADI";
      this.altGrupLook.Properties.NullText = "";
      this.altGrupLook.Properties.PopupView = (ColumnView) this.gridView4;
      this.altGrupLook.Properties.ValueMember = "ID";
      this.altGrupLook.Size = new Size(193, 24);
      this.altGrupLook.StyleController = (IStyleController) this.layoutControl1;
      this.altGrupLook.TabIndex = 20;
      this.tBLARACGRUBU2BindingSource.DataMember = "TBLARACGRUBU2";
      this.tBLARACGRUBU2BindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView4.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.gridView4.DetailHeight = 284;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Grup Adı";
      this.gridColumn5.FieldName = "GRUPADI";
      this.gridColumn5.MinWidth = 17;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.gridColumn5.Width = 64;
      this.motorNoTxt.EditValue = (object) "";
      this.motorNoTxt.Location = new Point(535, 231);
      this.motorNoTxt.Margin = new Padding(3, 2, 3, 2);
      this.motorNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motorNoTxt.Name = "motorNoTxt";
      this.motorNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motorNoTxt.Properties.Appearance.Options.UseFont = true;
      this.motorNoTxt.Properties.Mask.EditMask = "t";
      this.motorNoTxt.Size = new Size(189, 24);
      this.motorNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.motorNoTxt.TabIndex = 39;
      this.modelYiliLook.Location = new Point(129, 369);
      this.modelYiliLook.Margin = new Padding(3, 2, 3, 2);
      this.modelYiliLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.modelYiliLook.Name = "modelYiliLook";
      this.modelYiliLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.modelYiliLook.Properties.Appearance.Options.UseFont = true;
      this.modelYiliLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.modelYiliLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("YILI", "Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.modelYiliLook.Properties.DataSource = (object) this.tAHMODELYILIBindingSource;
      this.modelYiliLook.Properties.DisplayMember = "YILI";
      this.modelYiliLook.Properties.NullText = "";
      this.modelYiliLook.Properties.ValueMember = "ID";
      this.modelYiliLook.Size = new Size(259, 24);
      this.modelYiliLook.StyleController = (IStyleController) this.layoutControl1;
      this.modelYiliLook.TabIndex = 44;
      this.modelYiliLook.EditValueChanged += new EventHandler(this.personelistihdamcombo_EditValueChanged);
      this.tAHMODELYILIBindingSource.DataMember = "TAHMODELYILI";
      this.tAHMODELYILIBindingSource.DataSource = (object) this.bellDataSet6;
      this.aracTipiLook.Location = new Point(129, 40);
      this.aracTipiLook.Margin = new Padding(3, 2, 3, 2);
      this.aracTipiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracTipiLook.Name = "aracTipiLook";
      this.aracTipiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracTipiLook.Properties.Appearance.Options.UseFont = true;
      this.aracTipiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracTipiLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ARACTIPI", "AracTipi")
      });
      this.aracTipiLook.Properties.DataSource = (object) this.tAHARACTIPIBindingSource;
      this.aracTipiLook.Properties.DisplayMember = "ARACTIPI";
      this.aracTipiLook.Properties.NullText = "";
      this.aracTipiLook.Properties.ValueMember = "ID";
      this.aracTipiLook.Size = new Size(193, 24);
      this.aracTipiLook.StyleController = (IStyleController) this.layoutControl1;
      this.aracTipiLook.TabIndex = 28;
      this.tAHARACTIPIBindingSource.DataMember = "TAHARACTIPI";
      this.tAHARACTIPIBindingSource.DataSource = (object) this.bellDataSet6;
      this.aracDurumLook.Location = new Point(129, 68);
      this.aracDurumLook.Margin = new Padding(3, 2, 3, 2);
      this.aracDurumLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracDurumLook.Name = "aracDurumLook";
      this.aracDurumLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracDurumLook.Properties.Appearance.Options.UseFont = true;
      this.aracDurumLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracDurumLook.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ARACDURUM", "AracDurum")
      });
      this.aracDurumLook.Properties.DataSource = (object) this.tAHARACDURUMBindingSource;
      this.aracDurumLook.Properties.DisplayMember = "ARACDURUM";
      this.aracDurumLook.Properties.NullText = "";
      this.aracDurumLook.Properties.ValueMember = "ID";
      this.aracDurumLook.Size = new Size(193, 24);
      this.aracDurumLook.StyleController = (IStyleController) this.layoutControl1;
      this.aracDurumLook.TabIndex = 12;
      this.tAHARACDURUMBindingSource.DataMember = "TAHARACDURUM";
      this.tAHARACDURUMBindingSource.DataSource = (object) this.bellDataSet6;
      this.aracAciklamaTxt.Location = new Point(129, 175);
      this.aracAciklamaTxt.Margin = new Padding(3, 2, 3, 2);
      this.aracAciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracAciklamaTxt.Name = "aracAciklamaTxt";
      this.aracAciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracAciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.aracAciklamaTxt.Properties.DisplayFormat.FormatString = "d";
      this.aracAciklamaTxt.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.aracAciklamaTxt.Properties.EditFormat.FormatString = "d";
      this.aracAciklamaTxt.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.aracAciklamaTxt.Size = new Size(285, 24);
      this.aracAciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.aracAciklamaTxt.TabIndex = 33;
      this.tahsisPlakaTxt.Location = new Point(129, 203);
      this.tahsisPlakaTxt.Margin = new Padding(3, 2, 3, 2);
      this.tahsisPlakaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tahsisPlakaTxt.Name = "tahsisPlakaTxt";
      this.tahsisPlakaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tahsisPlakaTxt.Properties.Appearance.Options.UseFont = true;
      this.tahsisPlakaTxt.Size = new Size(285, 24);
      this.tahsisPlakaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.tahsisPlakaTxt.TabIndex = 6;
      this.renkTxt.Location = new Point(535, 203);
      this.renkTxt.Margin = new Padding(3, 2, 3, 2);
      this.renkTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.renkTxt.Name = "renkTxt";
      this.renkTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.renkTxt.Properties.Appearance.Options.UseFont = true;
      this.renkTxt.Size = new Size(189, 24);
      this.renkTxt.StyleController = (IStyleController) this.layoutControl1;
      this.renkTxt.TabIndex = 32;
      this.motorGucuTxt.Location = new Point(535, 287);
      this.motorGucuTxt.Margin = new Padding(3, 2, 3, 2);
      this.motorGucuTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motorGucuTxt.Name = "motorGucuTxt";
      this.motorGucuTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motorGucuTxt.Properties.Appearance.Options.UseFont = true;
      this.motorGucuTxt.Properties.Mask.EditMask = "d";
      this.motorGucuTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.motorGucuTxt.Size = new Size(63, 24);
      this.motorGucuTxt.StyleController = (IStyleController) this.layoutControl1;
      this.motorGucuTxt.TabIndex = 26;
      this.tahsisTarihDate.EditValue = (object) null;
      this.tahsisTarihDate.Location = new Point(129, 231);
      this.tahsisTarihDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tahsisTarihDate.Name = "tahsisTarihDate";
      this.tahsisTarihDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tahsisTarihDate.Properties.Appearance.Options.UseFont = true;
      this.tahsisTarihDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tahsisTarihDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tahsisTarihDate.Properties.DisplayFormat.FormatString = "";
      this.tahsisTarihDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.tahsisTarihDate.Properties.EditFormat.FormatString = "";
      this.tahsisTarihDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.tahsisTarihDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.tahsisTarihDate.Size = new Size(285, 24);
      this.tahsisTarihDate.StyleController = (IStyleController) this.layoutControl1;
      this.tahsisTarihDate.TabIndex = 56;
      this.ilkTescilDate.EditValue = (object) null;
      this.ilkTescilDate.Location = new Point(129, 259);
      this.ilkTescilDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilkTescilDate.Name = "ilkTescilDate";
      this.ilkTescilDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ilkTescilDate.Properties.Appearance.Options.UseFont = true;
      this.ilkTescilDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilkTescilDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilkTescilDate.Properties.DisplayFormat.FormatString = "";
      this.ilkTescilDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.ilkTescilDate.Properties.EditFormat.FormatString = "";
      this.ilkTescilDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.ilkTescilDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.ilkTescilDate.Size = new Size(285, 24);
      this.ilkTescilDate.StyleController = (IStyleController) this.layoutControl1;
      this.ilkTescilDate.TabIndex = 57;
      this.tescilDate.EditValue = (object) null;
      this.tescilDate.Location = new Point(129, 315);
      this.tescilDate.Margin = new Padding(3, 2, 3, 2);
      this.tescilDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tescilDate.Name = "tescilDate";
      this.tescilDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tescilDate.Properties.Appearance.Options.UseFont = true;
      this.tescilDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tescilDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tescilDate.Properties.DisplayFormat.FormatString = "";
      this.tescilDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.tescilDate.Properties.EditFormat.FormatString = "";
      this.tescilDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.tescilDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.tescilDate.Size = new Size(285, 24);
      this.tescilDate.StyleController = (IStyleController) this.layoutControl1;
      this.tescilDate.TabIndex = 29;
      this.muayeneDate.EditValue = (object) null;
      this.muayeneDate.Location = new Point(535, 363);
      this.muayeneDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.muayeneDate.Name = "muayeneDate";
      this.muayeneDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.muayeneDate.Properties.Appearance.Options.UseFont = true;
      this.muayeneDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.muayeneDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.muayeneDate.Properties.DisplayFormat.FormatString = "";
      this.muayeneDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.muayeneDate.Properties.EditFormat.FormatString = "";
      this.muayeneDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.muayeneDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.muayeneDate.Size = new Size(229, 24);
      this.muayeneDate.StyleController = (IStyleController) this.layoutControl1;
      this.muayeneDate.TabIndex = 77;
      this.trafikSigortaDate.EditValue = (object) null;
      this.trafikSigortaDate.Location = new Point(535, 391);
      this.trafikSigortaDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.trafikSigortaDate.Name = "trafikSigortaDate";
      this.trafikSigortaDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.trafikSigortaDate.Properties.Appearance.Options.UseFont = true;
      this.trafikSigortaDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.trafikSigortaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.trafikSigortaDate.Properties.DisplayFormat.FormatString = "";
      this.trafikSigortaDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.trafikSigortaDate.Properties.EditFormat.FormatString = "";
      this.trafikSigortaDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.trafikSigortaDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.trafikSigortaDate.Size = new Size(229, 24);
      this.trafikSigortaDate.StyleController = (IStyleController) this.layoutControl1;
      this.trafikSigortaDate.TabIndex = 78;
      this.kaskoDate.EditValue = (object) null;
      this.kaskoDate.Location = new Point(535, 419);
      this.kaskoDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kaskoDate.Name = "kaskoDate";
      this.kaskoDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kaskoDate.Properties.Appearance.Options.UseFont = true;
      this.kaskoDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kaskoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kaskoDate.Properties.DisplayFormat.FormatString = "";
      this.kaskoDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.kaskoDate.Properties.EditFormat.FormatString = "";
      this.kaskoDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.kaskoDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.kaskoDate.Size = new Size(229, 24);
      this.kaskoDate.StyleController = (IStyleController) this.layoutControl1;
      this.kaskoDate.TabIndex = 79;
      this.paraCinsiCombo.Location = new Point(976, 231);
      this.paraCinsiCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.paraCinsiCombo.Name = "paraCinsiCombo";
      this.paraCinsiCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.paraCinsiCombo.Properties.Appearance.Options.UseFont = true;
      this.paraCinsiCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.paraCinsiCombo.Properties.Items.AddRange(new object[3]
      {
        (object) "Lira",
        (object) "Dolar",
        (object) "Euro"
      });
      this.paraCinsiCombo.Properties.PopupSizeable = true;
      this.paraCinsiCombo.Size = new Size(66, 24);
      this.paraCinsiCombo.StyleController = (IStyleController) this.layoutControl1;
      this.paraCinsiCombo.TabIndex = 71;
      this.gorevBitisDate.EditValue = (object) null;
      this.gorevBitisDate.Enabled = false;
      this.gorevBitisDate.Location = new Point(885, 335);
      this.gorevBitisDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gorevBitisDate.Name = "gorevBitisDate";
      this.gorevBitisDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gorevBitisDate.Properties.Appearance.Options.UseFont = true;
      this.gorevBitisDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevBitisDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevBitisDate.Properties.DisplayFormat.FormatString = "";
      this.gorevBitisDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.gorevBitisDate.Properties.EditFormat.FormatString = "";
      this.gorevBitisDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.gorevBitisDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.gorevBitisDate.Size = new Size(225, 24);
      this.gorevBitisDate.StyleController = (IStyleController) this.layoutControl1;
      this.gorevBitisDate.TabIndex = 83;
      this.gorevDurumLook.Enabled = false;
      this.gorevDurumLook.Location = new Point(885, 363);
      this.gorevDurumLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gorevDurumLook.Name = "gorevDurumLook";
      this.gorevDurumLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gorevDurumLook.Properties.Appearance.Options.UseFont = true;
      this.gorevDurumLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevDurumLook.Properties.NullText = "";
      this.gorevDurumLook.Size = new Size(225, 24);
      this.gorevDurumLook.StyleController = (IStyleController) this.layoutControl1;
      this.gorevDurumLook.TabIndex = 84;
      this.yedekAnahtarLook.Location = new Point(535, 447);
      this.yedekAnahtarLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yedekAnahtarLook.Name = "yedekAnahtarLook";
      this.yedekAnahtarLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yedekAnahtarLook.Properties.Appearance.Options.UseFont = true;
      this.yedekAnahtarLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yedekAnahtarLook.Properties.DataSource = (object) this.tBLVARYOKBindingSource;
      this.yedekAnahtarLook.Properties.DisplayMember = "ADI";
      this.yedekAnahtarLook.Properties.NullText = "";
      this.yedekAnahtarLook.Properties.ValueMember = "ID";
      this.yedekAnahtarLook.Size = new Size(229, 24);
      this.yedekAnahtarLook.StyleController = (IStyleController) this.layoutControl1;
      this.yedekAnahtarLook.TabIndex = 80;
      this.tBLVARYOKBindingSource.DataMember = "TBLVARYOK";
      this.tBLVARYOKBindingSource.DataSource = (object) this.bellDataSet5;
      this.EgzozDate.EditValue = (object) null;
      this.EgzozDate.Location = new Point(535, 175);
      this.EgzozDate.Margin = new Padding(3, 2, 3, 2);
      this.EgzozDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.EgzozDate.Name = "EgzozDate";
      this.EgzozDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.EgzozDate.Properties.Appearance.Options.UseFont = true;
      this.EgzozDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.EgzozDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.EgzozDate.Properties.DisplayFormat.FormatString = "";
      this.EgzozDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.EgzozDate.Properties.EditFormat.FormatString = "";
      this.EgzozDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.EgzozDate.Size = new Size(188, 24);
      this.EgzozDate.StyleController = (IStyleController) this.layoutControl1;
      this.EgzozDate.TabIndex = 97;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[56]
      {
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.difransiyel,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem28,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem30,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem31,
        (BaseLayoutItem) this.layoutControlItem32,
        (BaseLayoutItem) this.layoutControlItem33,
        (BaseLayoutItem) this.layoutControlItem34,
        (BaseLayoutItem) this.layoutControlItem35,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem29,
        (BaseLayoutItem) this.layoutControlItem38,
        (BaseLayoutItem) this.layoutControlItem37,
        (BaseLayoutItem) this.layoutControlItem24,
        (BaseLayoutItem) this.layoutControlItem39,
        (BaseLayoutItem) this.layoutControlItem40,
        (BaseLayoutItem) this.layoutControlItem41,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem42,
        (BaseLayoutItem) this.layoutControlItem44,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem53,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem49,
        (BaseLayoutItem) this.layoutControlItem48,
        (BaseLayoutItem) this.layoutControlItem47,
        (BaseLayoutItem) this.layoutControlItem46,
        (BaseLayoutItem) this.layoutControlItem45,
        (BaseLayoutItem) this.layoutControlItem54,
        (BaseLayoutItem) this.layoutControlItem55,
        (BaseLayoutItem) this.layoutControlItem56,
        (BaseLayoutItem) this.layoutControlItem57,
        (BaseLayoutItem) this.layoutControlItem58,
        (BaseLayoutItem) this.layoutControlItem59,
        (BaseLayoutItem) this.layoutControlItem36
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1122, 517);
      this.Root.TextVisible = false;
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.tescilDate;
      this.layoutControlItem26.Location = new Point(0, 303);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem26.Size = new Size(406, 28);
      this.layoutControlItem26.Text = "Tescil Tarihi";
      this.layoutControlItem26.TextSize = new Size(114, 17);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.plakaTxt;
      this.layoutControlItem10.Location = new Point(0, 0);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(348, 28);
      this.layoutControlItem10.Text = "Plaka";
      this.layoutControlItem10.TextSize = new Size(114, 17);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.anaGrupLook;
      this.layoutControlItem2.Location = new Point(0, 84);
      this.layoutControlItem2.MinSize = new Size(155, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(314, 25);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Ana Grup";
      this.layoutControlItem2.TextSize = new Size(114, 17);
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.aracTipiLook;
      this.layoutControlItem25.Location = new Point(0, 28);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(314, 28);
      this.layoutControlItem25.Text = "Araç Tipi";
      this.layoutControlItem25.TextSize = new Size(114, 17);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.aracDurumLook;
      this.layoutControlItem9.Location = new Point(0, 56);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(314, 28);
      this.layoutControlItem9.Text = "Araç Durum";
      this.layoutControlItem9.TextSize = new Size(114, 17);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.tahsisPlakaTxt;
      this.layoutControlItem3.Location = new Point(0, 191);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem3.Size = new Size(406, 28);
      this.layoutControlItem3.Text = "Tahsisli Plaka";
      this.layoutControlItem3.TextSize = new Size(114, 17);
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.aracAciklamaTxt;
      this.layoutControlItem20.Location = new Point(0, 163);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(406, 28);
      this.layoutControlItem20.Text = "Araç Açıklama";
      this.layoutControlItem20.TextSize = new Size(114, 17);
      this.difransiyel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyel.AppearanceItemCaption.Options.UseFont = true;
      this.difransiyel.Control = (Control) this.altGrupLook;
      this.difransiyel.Location = new Point(0, 109);
      this.difransiyel.MinSize = new Size(155, 24);
      this.difransiyel.Name = "difransiyel";
      this.difransiyel.Size = new Size(314, 26);
      this.difransiyel.SizeConstraintsType = SizeConstraintsType.Custom;
      this.difransiyel.Text = "Alt Grup";
      this.difransiyel.TextSize = new Size(114, 17);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.renkTxt;
      this.layoutControlItem12.Location = new Point(406, 191);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(310, 28);
      this.layoutControlItem12.Text = "Rengi";
      this.layoutControlItem12.TextSize = new Size(114, 17);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.motorNoTxt;
      this.layoutControlItem7.Location = new Point(406, 219);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(310, 28);
      this.layoutControlItem7.Text = "Motor No";
      this.layoutControlItem7.TextSize = new Size(114, 17);
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.motorGucuTxt;
      this.layoutControlItem23.Location = new Point(406, 275);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem23.Size = new Size(184, 28);
      this.layoutControlItem23.Text = "Motor Gücü";
      this.layoutControlItem23.TextSize = new Size(114, 17);
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.modelYiliLook;
      this.layoutControlItem17.Location = new Point(0, 357);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem17.Size = new Size(380, 28);
      this.layoutControlItem17.Text = "Model Yılı";
      this.layoutControlItem17.TextSize = new Size(114, 17);
      this.layoutControlItem28.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem28.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem28.Control = (Control) this.markaLook;
      this.layoutControlItem28.Location = new Point(0, 331);
      this.layoutControlItem28.MinSize = new Size(155, 24);
      this.layoutControlItem28.Name = "layoutControlItem28";
      this.layoutControlItem28.Size = new Size(380, 26);
      this.layoutControlItem28.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem28.Text = "Marka";
      this.layoutControlItem28.TextSize = new Size(114, 17);
      this.layoutControlItem21.Control = (Control) this.simpleButton3;
      this.layoutControlItem21.Location = new Point(314, 84);
      this.layoutControlItem21.MinSize = new Size(22, 25);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(34, 25);
      this.layoutControlItem21.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem21.TextSize = new Size(0, 0);
      this.layoutControlItem21.TextVisible = false;
      this.layoutControlItem30.Control = (Control) this.simpleButton5;
      this.layoutControlItem30.Location = new Point(314, 109);
      this.layoutControlItem30.Name = "layoutControlItem30";
      this.layoutControlItem30.Size = new Size(34, 26);
      this.layoutControlItem30.TextSize = new Size(0, 0);
      this.layoutControlItem30.TextVisible = false;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.tahsisTarihDate;
      this.layoutControlItem5.Location = new Point(0, 219);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(406, 28);
      this.layoutControlItem5.Text = "Tahsis Tarihi";
      this.layoutControlItem5.TextSize = new Size(114, 18);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.ilkTescilDate;
      this.layoutControlItem8.Location = new Point(0, 247);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(406, 28);
      this.layoutControlItem8.Text = "İlk Tescil Tarihi";
      this.layoutControlItem8.TextSize = new Size(114, 18);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.tescilSiraNoTxt;
      this.layoutControlItem14.Location = new Point(0, 275);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(406, 28);
      this.layoutControlItem14.Text = "Tescil Sıra No";
      this.layoutControlItem14.TextSize = new Size(114, 18);
      this.layoutControlItem31.Control = (Control) this.simpleButton6;
      this.layoutControlItem31.Location = new Point(380, 331);
      this.layoutControlItem31.MinSize = new Size(26, 26);
      this.layoutControlItem31.Name = "layoutControlItem31";
      this.layoutControlItem31.Size = new Size(26, 26);
      this.layoutControlItem31.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem31.TextSize = new Size(0, 0);
      this.layoutControlItem31.TextVisible = false;
      this.layoutControlItem32.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem32.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem32.Control = (Control) this.cinsTxt;
      this.layoutControlItem32.Location = new Point(0, 385);
      this.layoutControlItem32.Name = "layoutControlItem32";
      this.layoutControlItem32.Size = new Size(406, 28);
      this.layoutControlItem32.Text = "Cinsi";
      this.layoutControlItem32.TextSize = new Size(114, 18);
      this.layoutControlItem33.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem33.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem33.Control = (Control) this.ticariAdiTxt;
      this.layoutControlItem33.Location = new Point(0, 413);
      this.layoutControlItem33.Name = "layoutControlItem33";
      this.layoutControlItem33.Size = new Size(406, 28);
      this.layoutControlItem33.Text = "Ticari Adı";
      this.layoutControlItem33.TextSize = new Size(114, 18);
      this.layoutControlItem34.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem34.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem34.Control = (Control) this.tipTxt;
      this.layoutControlItem34.Location = new Point(0, 441);
      this.layoutControlItem34.Name = "layoutControlItem34";
      this.layoutControlItem34.Size = new Size(406, 28);
      this.layoutControlItem34.Text = "Tipi";
      this.layoutControlItem34.TextSize = new Size(114, 18);
      this.layoutControlItem35.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem35.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem35.Control = (Control) this.silindirHacmiTxt;
      this.layoutControlItem35.Location = new Point(0, 469);
      this.layoutControlItem35.Name = "layoutControlItem35";
      this.layoutControlItem35.Size = new Size(406, 28);
      this.layoutControlItem35.Text = "Silindir Hacmi";
      this.layoutControlItem35.TextSize = new Size(114, 18);
      this.layoutControlItem4.Control = (Control) this.onGorunumPicture;
      this.layoutControlItem4.Location = new Point(348, 0);
      this.layoutControlItem4.MinSize = new Size(24, 24);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(141, 163);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Ön Görünüm";
      this.layoutControlItem4.TextLocation = Locations.Bottom;
      this.layoutControlItem4.TextSize = new Size(114, 13);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.Control = (Control) this.AracSahibiLook;
      this.layoutControlItem13.Location = new Point(715, 163);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(353, 28);
      this.layoutControlItem13.Text = "Araç Sahibi";
      this.layoutControlItem13.TextSize = new Size(114, 18);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.guncelDegerTxt;
      this.layoutControlItem15.Location = new Point(716, 191);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(386, 28);
      this.layoutControlItem15.Text = "Güncel Değeri";
      this.layoutControlItem15.TextSize = new Size(114, 18);
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.yeniDegerTxt;
      this.layoutControlItem16.Location = new Point(716, 219);
      this.layoutControlItem16.MinSize = new Size(171, 28);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(248, 28);
      this.layoutControlItem16.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem16.Text = "Yeni Değeri";
      this.layoutControlItem16.TextSize = new Size(114, 18);
      this.layoutControlItem18.Control = (Control) this.paraCinsiCombo;
      this.layoutControlItem18.Location = new Point(964, 219);
      this.layoutControlItem18.MinSize = new Size(50, 25);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(70, 28);
      this.layoutControlItem18.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem18.TextSize = new Size(0, 0);
      this.layoutControlItem18.TextVisible = false;
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.ilgiliNotTxt;
      this.layoutControlItem22.Location = new Point(756, 271);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(346, 52);
      this.layoutControlItem22.Text = "İlgili Not";
      this.layoutControlItem22.TextSize = new Size(114, 18);
      this.layoutControlItem29.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem29.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem29.Control = (Control) this.beygirTxt;
      this.layoutControlItem29.Location = new Point(590, 275);
      this.layoutControlItem29.MinSize = new Size(156, 24);
      this.layoutControlItem29.Name = "layoutControlItem29";
      this.layoutControlItem29.Size = new Size(166, 28);
      this.layoutControlItem29.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem29.Text = "Beygir";
      this.layoutControlItem29.TextLocation = Locations.Left;
      this.layoutControlItem29.TextSize = new Size(114, 18);
      this.layoutControlItem38.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem38.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem38.Control = (Control) this.belgeSeriNoTxt;
      this.layoutControlItem38.Location = new Point(406, 303);
      this.layoutControlItem38.Name = "layoutControlItem38";
      this.layoutControlItem38.Size = new Size(350, 24);
      this.layoutControlItem38.Text = "Belge Seri No";
      this.layoutControlItem38.TextSize = new Size(114, 18);
      this.layoutControlItem37.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem37.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem37.Control = (Control) this.verildigiIlIlceTxt;
      this.layoutControlItem37.Location = new Point(406, 327);
      this.layoutControlItem37.Name = "layoutControlItem37";
      this.layoutControlItem37.Size = new Size(350, 24);
      this.layoutControlItem37.Text = "Verildiği İl - İlçe";
      this.layoutControlItem37.TextSize = new Size(114, 18);
      this.layoutControlItem24.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem24.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem24.Control = (Control) this.saseNoTxt;
      this.layoutControlItem24.Location = new Point(406, 247);
      this.layoutControlItem24.Name = "layoutControlItem24";
      this.layoutControlItem24.Size = new Size(350, 28);
      this.layoutControlItem24.Text = "Sase No";
      this.layoutControlItem24.TextSize = new Size(114, 16);
      this.layoutControlItem39.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem39.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem39.Control = (Control) this.muayeneDate;
      this.layoutControlItem39.Location = new Point(406, 351);
      this.layoutControlItem39.Name = "layoutControlItem39";
      this.layoutControlItem39.Size = new Size(350, 28);
      this.layoutControlItem39.Text = "Muayene";
      this.layoutControlItem39.TextSize = new Size(114, 18);
      this.layoutControlItem40.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem40.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem40.Control = (Control) this.trafikSigortaDate;
      this.layoutControlItem40.Location = new Point(406, 379);
      this.layoutControlItem40.Name = "layoutControlItem40";
      this.layoutControlItem40.Size = new Size(350, 28);
      this.layoutControlItem40.Text = "Trafik Sigorta";
      this.layoutControlItem40.TextSize = new Size(114, 18);
      this.layoutControlItem41.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem41.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem41.Control = (Control) this.kaskoDate;
      this.layoutControlItem41.Location = new Point(406, 407);
      this.layoutControlItem41.Name = "layoutControlItem41";
      this.layoutControlItem41.Size = new Size(350, 28);
      this.layoutControlItem41.Text = "Kasko";
      this.layoutControlItem41.TextSize = new Size(114, 18);
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.anahtarAciklamaTxt;
      this.layoutControlItem27.Location = new Point(406, 463);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(350, 34);
      this.layoutControlItem27.Text = "Anahtar Açıklama";
      this.layoutControlItem27.TextSize = new Size(114, 18);
      this.layoutControlItem42.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem42.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem42.Control = (Control) this.yedekAnahtarLook;
      this.layoutControlItem42.Location = new Point(406, 435);
      this.layoutControlItem42.Name = "layoutControlItem42";
      this.layoutControlItem42.Size = new Size(350, 28);
      this.layoutControlItem42.Text = "Yedek Anahtar";
      this.layoutControlItem42.TextSize = new Size(114, 18);
      this.layoutControlItem44.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem44.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem44.Control = (Control) this.gorevBitisDate;
      this.layoutControlItem44.Location = new Point(756, 323);
      this.layoutControlItem44.Name = "layoutControlItem44";
      this.layoutControlItem44.Size = new Size(346, 28);
      this.layoutControlItem44.Text = "Görev Bitiş Tarihi";
      this.layoutControlItem44.TextSize = new Size(114, 18);
      this.layoutControlItem1.Control = (Control) this.arkaGorunumPicture;
      this.layoutControlItem1.Location = new Point(716, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(154, 163);
      this.layoutControlItem1.Text = "Arka Görünüm";
      this.layoutControlItem1.TextLocation = Locations.Bottom;
      this.layoutControlItem1.TextSize = new Size(114, 13);
      this.layoutControlItem6.Control = (Control) this.layoutControl3;
      this.layoutControlItem6.Location = new Point(489, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(227, 163);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.layoutControl4;
      this.layoutControlItem11.Location = new Point(870, 0);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(232, 163);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem53.Control = (Control) this.simpleButton8;
      this.layoutControlItem53.Location = new Point(1068, 163);
      this.layoutControlItem53.MinSize = new Size(26, 26);
      this.layoutControlItem53.Name = "layoutControlItem53";
      this.layoutControlItem53.Size = new Size(34, 28);
      this.layoutControlItem53.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem53.TextSize = new Size(0, 0);
      this.layoutControlItem53.TextVisible = false;
      this.layoutControlItem19.Control = (Control) this.aracTakipCheck;
      this.layoutControlItem19.Location = new Point(756, 247);
      this.layoutControlItem19.MinSize = new Size(76, 22);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(346, 24);
      this.layoutControlItem19.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem19.TextSize = new Size(0, 0);
      this.layoutControlItem19.TextVisible = false;
      this.layoutControlItem49.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem49.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem49.Control = (Control) this.tahsisEdilenLook;
      this.layoutControlItem49.Location = new Point(756, 463);
      this.layoutControlItem49.Name = "layoutControlItem49";
      this.layoutControlItem49.Size = new Size(346, 34);
      this.layoutControlItem49.Text = "Tahsis Edilen";
      this.layoutControlItem49.TextSize = new Size(114, 18);
      this.layoutControlItem48.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem48.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem48.Control = (Control) this.aracSoforuLook;
      this.layoutControlItem48.Location = new Point(756, 435);
      this.layoutControlItem48.Name = "layoutControlItem48";
      this.layoutControlItem48.Size = new Size(346, 28);
      this.layoutControlItem48.Text = "Araç Şoförü";
      this.layoutControlItem48.TextSize = new Size(114, 18);
      this.layoutControlItem47.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem47.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem47.Control = (Control) this.mudurlukLook;
      this.layoutControlItem47.Location = new Point(756, 407);
      this.layoutControlItem47.Name = "layoutControlItem47";
      this.layoutControlItem47.Size = new Size(346, 28);
      this.layoutControlItem47.Text = "Müdürlüğü";
      this.layoutControlItem47.TextSize = new Size(114, 18);
      this.layoutControlItem46.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem46.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem46.Control = (Control) this.birimAdiLook;
      this.layoutControlItem46.Location = new Point(756, 379);
      this.layoutControlItem46.Name = "layoutControlItem46";
      this.layoutControlItem46.Size = new Size(346, 28);
      this.layoutControlItem46.Text = "Birim Adı";
      this.layoutControlItem46.TextSize = new Size(114, 18);
      this.layoutControlItem45.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem45.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem45.Control = (Control) this.gorevDurumLook;
      this.layoutControlItem45.Location = new Point(756, 351);
      this.layoutControlItem45.Name = "layoutControlItem45";
      this.layoutControlItem45.Size = new Size(346, 28);
      this.layoutControlItem45.Text = "Görev Durum";
      this.layoutControlItem45.TextSize = new Size(114, 18);
      this.layoutControlItem54.Control = (Control) this.yeniDegerDate;
      this.layoutControlItem54.Location = new Point(1034, 219);
      this.layoutControlItem54.MinSize = new Size(54, 28);
      this.layoutControlItem54.Name = "layoutControlItem54";
      this.layoutControlItem54.Size = new Size(68, 28);
      this.layoutControlItem54.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem54.TextSize = new Size(0, 0);
      this.layoutControlItem54.TextVisible = false;
      this.layoutControlItem55.Control = (Control) this.simpleButton9;
      this.layoutControlItem55.Location = new Point(314, 28);
      this.layoutControlItem55.Name = "layoutControlItem55";
      this.layoutControlItem55.Size = new Size(34, 28);
      this.layoutControlItem55.TextSize = new Size(0, 0);
      this.layoutControlItem55.TextVisible = false;
      this.layoutControlItem56.Control = (Control) this.simpleButton10;
      this.layoutControlItem56.Location = new Point(314, 56);
      this.layoutControlItem56.Name = "layoutControlItem56";
      this.layoutControlItem56.Size = new Size(34, 28);
      this.layoutControlItem56.TextSize = new Size(0, 0);
      this.layoutControlItem56.TextVisible = false;
      this.layoutControlItem57.Control = (Control) this.simpleButton11;
      this.layoutControlItem57.Location = new Point(380, 357);
      this.layoutControlItem57.Name = "layoutControlItem57";
      this.layoutControlItem57.Size = new Size(26, 28);
      this.layoutControlItem57.TextSize = new Size(0, 0);
      this.layoutControlItem57.TextVisible = false;
      this.layoutControlItem58.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem58.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem58.Control = (Control) this.EgzozDate;
      this.layoutControlItem58.Location = new Point(406, 163);
      this.layoutControlItem58.Name = "layoutControlItem58";
      this.layoutControlItem58.Size = new Size(309, 28);
      this.layoutControlItem58.Text = "Egzoz Kontrol";
      this.layoutControlItem58.TextSize = new Size(114, 17);
      this.layoutControlItem59.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f);
      this.layoutControlItem59.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem59.Control = (Control) this.aracIhaleGrupSluEdit;
      this.layoutControlItem59.Location = new Point(0, 135);
      this.layoutControlItem59.Name = "layoutControlItem59";
      this.layoutControlItem59.Size = new Size(314, 28);
      this.layoutControlItem59.Text = "Araç İhale Grubu";
      this.layoutControlItem59.TextSize = new Size(114, 17);
      this.layoutControlItem36.Control = (Control) this.simpleButton12;
      this.layoutControlItem36.Location = new Point(314, 135);
      this.layoutControlItem36.Name = "layoutControlItem36";
      this.layoutControlItem36.Size = new Size(34, 28);
      this.layoutControlItem36.TextSize = new Size(0, 0);
      this.layoutControlItem36.TextVisible = false;
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLPERSONELDURUMBindingSource.DataMember = "TBLPERSONELDURUM";
      this.tBLPERSONELDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLPERSIZINDURUMBindingSource.DataMember = "TBLPERSIZINDURUM";
      this.tBLPERSIZINDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.araclarListesi;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.BirimAdiCombo4558.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.BirimAdiCombo4558.AppearanceItemCaption.Options.UseFont = true;
      this.BirimAdiCombo4558.Location = new Point(0, 240);
      this.BirimAdiCombo4558.Name = "layoutControlItem6";
      this.BirimAdiCombo4558.Size = new Size(378, 30);
      this.BirimAdiCombo4558.Text = "Çıkış Tarihi";
      this.BirimAdiCombo4558.TextAlignMode = TextAlignModeItem.CustomSize;
      this.BirimAdiCombo4558.TextSize = new Size(120, 16);
      this.BirimAdiCombo4558.TextToControlDistance = 2;
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSIZINDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELDURUMTableAdapter.ClearBeforeFill = true;
      this.ımageList1.ColorDepth = ColorDepth.Depth8Bit;
      this.ımageList1.ImageSize = new Size(16, 16);
      this.ımageList1.TransparentColor = Color.Transparent;
      this.tBLARACGRUBUTableAdapter.ClearBeforeFill = true;
      this.tBLARACGRUBU2TableAdapter.ClearBeforeFill = true;
      this.tBLARACMARKATableAdapter.ClearBeforeFill = true;
      this.tBLVARYOKTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.tAHARACTIPITableAdapter.ClearBeforeFill = true;
      this.tAHARACDURUMTableAdapter.ClearBeforeFill = true;
      this.tAHMODELYILITableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1139, 585);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (AracGuncelle);
      this.Text = "Arac Ekle Güncelle";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.araclarListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.aracIhaleGrupSluEdit.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.yeniDegerDate.Properties.CalendarTimeProperties.EndInit();
      this.yeniDegerDate.Properties.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControl4.ResumeLayout(false);
      this.layoutControlGroup3.EndInit();
      this.layoutControlItem51.EndInit();
      this.layoutControlItem52.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControl3.ResumeLayout(false);
      this.layoutControlGroup2.EndInit();
      this.layoutControlItem43.EndInit();
      this.layoutControlItem50.EndInit();
      this.arkaGorunumPicture.Properties.EndInit();
      this.tahsisEdilenLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.aracSoforuLook.Properties.EndInit();
      this.mudurlukLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.birimAdiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.anahtarAciklamaTxt.Properties.EndInit();
      this.belgeSeriNoTxt.Properties.EndInit();
      this.verildigiIlIlceTxt.Properties.EndInit();
      this.beygirTxt.Properties.EndInit();
      this.ilgiliNotTxt.Properties.EndInit();
      this.aracTakipCheck.Properties.EndInit();
      this.yeniDegerTxt.Properties.EndInit();
      this.guncelDegerTxt.Properties.EndInit();
      this.AracSahibiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.onGorunumPicture.Properties.EndInit();
      this.silindirHacmiTxt.Properties.EndInit();
      this.tipTxt.Properties.EndInit();
      this.ticariAdiTxt.Properties.EndInit();
      this.cinsTxt.Properties.EndInit();
      this.tescilSiraNoTxt.Properties.EndInit();
      this.markaLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACMARKABindingSource).EndInit();
      this.saseNoTxt.Properties.EndInit();
      this.plakaTxt.Properties.EndInit();
      this.anaGrupLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).EndInit();
      this.gridView1.EndInit();
      this.altGrupLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).EndInit();
      this.gridView4.EndInit();
      this.motorNoTxt.Properties.EndInit();
      this.modelYiliLook.Properties.EndInit();
      ((ISupportInitialize) this.tAHMODELYILIBindingSource).EndInit();
      this.aracTipiLook.Properties.EndInit();
      ((ISupportInitialize) this.tAHARACTIPIBindingSource).EndInit();
      this.aracDurumLook.Properties.EndInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource).EndInit();
      this.aracAciklamaTxt.Properties.EndInit();
      this.tahsisPlakaTxt.Properties.EndInit();
      this.renkTxt.Properties.EndInit();
      this.motorGucuTxt.Properties.EndInit();
      this.tahsisTarihDate.Properties.CalendarTimeProperties.EndInit();
      this.tahsisTarihDate.Properties.EndInit();
      this.ilkTescilDate.Properties.CalendarTimeProperties.EndInit();
      this.ilkTescilDate.Properties.EndInit();
      this.tescilDate.Properties.CalendarTimeProperties.EndInit();
      this.tescilDate.Properties.EndInit();
      this.muayeneDate.Properties.CalendarTimeProperties.EndInit();
      this.muayeneDate.Properties.EndInit();
      this.trafikSigortaDate.Properties.CalendarTimeProperties.EndInit();
      this.trafikSigortaDate.Properties.EndInit();
      this.kaskoDate.Properties.CalendarTimeProperties.EndInit();
      this.kaskoDate.Properties.EndInit();
      this.paraCinsiCombo.Properties.EndInit();
      this.gorevBitisDate.Properties.CalendarTimeProperties.EndInit();
      this.gorevBitisDate.Properties.EndInit();
      this.gorevDurumLook.Properties.EndInit();
      this.yedekAnahtarLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLVARYOKBindingSource).EndInit();
      this.EgzozDate.Properties.CalendarTimeProperties.EndInit();
      this.EgzozDate.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem20.EndInit();
      this.difransiyel.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem28.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem30.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem31.EndInit();
      this.layoutControlItem32.EndInit();
      this.layoutControlItem33.EndInit();
      this.layoutControlItem34.EndInit();
      this.layoutControlItem35.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem29.EndInit();
      this.layoutControlItem38.EndInit();
      this.layoutControlItem37.EndInit();
      this.layoutControlItem24.EndInit();
      this.layoutControlItem39.EndInit();
      this.layoutControlItem40.EndInit();
      this.layoutControlItem41.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem42.EndInit();
      this.layoutControlItem44.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem53.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem49.EndInit();
      this.layoutControlItem48.EndInit();
      this.layoutControlItem47.EndInit();
      this.layoutControlItem46.EndInit();
      this.layoutControlItem45.EndInit();
      this.layoutControlItem54.EndInit();
      this.layoutControlItem55.EndInit();
      this.layoutControlItem56.EndInit();
      this.layoutControlItem57.EndInit();
      this.layoutControlItem58.EndInit();
      this.layoutControlItem59.EndInit();
      this.layoutControlItem36.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSIZINDURUMBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.emptySpaceItem1.EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.BirimAdiCombo4558.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
