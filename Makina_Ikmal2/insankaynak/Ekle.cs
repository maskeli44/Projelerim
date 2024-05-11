// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.Ekle
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class Ekle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private Resimleme rs = new Resimleme();
    private YetkiClass yet = new YetkiClass();
    private int id = YetkiClass.secim_id;
    private bool resimsec = false;
    private string resimyolu;
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
    private RibbonPageGroup ribbonPageGroup4;
    private AraclarListesi araclarListesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private LayoutControl layoutControl1;
    private TextEdit GorevYeriTxt;
    private TextEdit TcTxt;
    private TextEdit Telefon1Txt;
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
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem26;
    private LayoutControlItem layoutControlItem27;
    private BindingSource dataTable1BindingSource1;
    private SearchLookUpEdit egitimDurumCombo;
    private GridView gridView1;
    private MemoEdit ParafTxt;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem12;
    private EmptySpaceItem emptySpaceItem1;
    private GridColumn gridColumn2;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem14;
    private ComboBoxEdit YetkiIzmaCombo;
    private BehaviorManager behaviorManager1;
    private TextEdit kodTxt;
    private TextEdit SicilTxt;
    private TextEdit AdiTxt;
    private TextEdit SoyadTxt;
    private SearchLookUpEdit UnvanCombo;
    private GridView searchLookUpEdit1View;
    private LayoutControlItem BirimAdiCombo4558;
    private SearchLookUpEdit GorevUnvanCombo;
    private GridView gridView2;
    private LayoutControlItem layoutControlItem20;
    private SearchLookUpEdit BirimAdiCombo;
    private GridView gridView3;
    private SearchLookUpEdit MudurlukCombo;
    private GridView gridView4;
    private TextEdit Telefon2Txt;
    private DateEdit GirisTarihiDate;
    private SearchLookUpEdit EhliyetBilgisiCombo;
    private GridView gridView5;
    private DateEdit EhliyetTarihiDate;
    private TextEdit CocukSayisiTxt;
    private PictureEdit ResimPic;
    private LayoutControlItem layoutControlItem6;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private MemoEdit ikametAdresiTxt;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem15;
    private GridColumn gridColumn1;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private ComboBoxEdit KanGrubuCombo;
    private DateEdit DogumTarihiDate;
    private LookUpEdit personelistihdamcombo;
    private LayoutControlItem layoutControlItem17;
    private TextEdit siranoTxt;
    private LayoutControlItem layoutControlItem24;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter tBLPERSONELISTIHDAMDURUMTableAdapter;
    private LookUpEdit KayitDurumuCombo;
    private LayoutControlItem layoutControlItem28;
    private BindingSource tBLPERSIZINDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSIZINDURUMTableAdapter tBLPERSIZINDURUMTableAdapter;
    private BindingSource tBLPERSONELDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter tBLPERSONELDURUMTableAdapter;
    private SimpleButton simpleButton9;
    private SimpleButton simpleButton8;
    private SimpleButton simpleButton7;
    private SimpleButton simpleButton6;
    private SimpleButton simpleButton5;
    private SimpleButton simpleButton4;
    private SimpleButton simpleButton3;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem29;
    private LayoutControlItem layoutControlItem30;
    private LayoutControlItem layoutControlItem31;
    private LayoutControlItem layoutControlItem32;
    private LayoutControlItem layoutControlItem33;
    private LayoutControlItem layoutControlItem34;
    private SimpleButton simpleButton10;
    private LayoutControlItem layoutControlItem35;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSEHLIYETBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSEHLIYETTableAdapter tBLPERSEHLIYETTableAdapter;
    private LookUpEdit zimmetAraciLook;
    private LayoutControlItem layoutControlItem36;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;

    public Ekle() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLPERSEHLIYETTableAdapter.Fill(this.bellDataSet7.TBLPERSEHLIYET);
      this.tBLPERSONELDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELDURUM);
      this.tBLPERSIZINDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSIZINDURUM);
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELISTIHDAMDURUM);
      this.kodTxt.Text = this.son.PersonelP();
      this.yet.yetkiislemleri("PERSONEL");
      this.UnvanCombo.Properties.DataSource = (object) this.db.TBLPERSUNVAN.ToList<TBLPERSUNVAN>();
      this.UnvanCombo.Properties.ValueMember = "ID";
      this.UnvanCombo.Properties.DisplayMember = "UNVAN";
      this.egitimDurumCombo.Properties.DataSource = (object) this.db.TBLPERSEGITIMDRM.ToList<TBLPERSEGITIMDRM>();
      this.egitimDurumCombo.Properties.ValueMember = "ID";
      this.egitimDurumCombo.Properties.DisplayMember = "EGITIMDURUM";
      this.BirimAdiCombo.Properties.DataSource = (object) this.db.TBLBELDBIRIMLER.ToList<TBLBELDBIRIMLER>();
      this.BirimAdiCombo.Properties.ValueMember = "ID";
      this.BirimAdiCombo.Properties.DisplayMember = "BELDBIRIMADI";
      this.GorevUnvanCombo.Properties.DataSource = (object) this.db.TBLPERSKURUMGOREV.ToList<TBLPERSKURUMGOREV>();
      this.GorevUnvanCombo.Properties.ValueMember = "ID";
      this.GorevUnvanCombo.Properties.DisplayMember = "KURUMGOREV";
      this.MudurlukCombo.Properties.DataSource = (object) this.db.TBLBELDMUDURLUK.ToList<TBLBELDMUDURLUK>();
      this.MudurlukCombo.Properties.ValueMember = "ID";
      this.MudurlukCombo.Properties.DisplayMember = "BELDMUDURLUK";
      if (YetkiClass.secim == "kayıt")
      {
        this.EhliyetBilgisiCombo.EditValue = (object) null;
        this.CocukSayisiTxt.EditValue = (object) 0;
      }
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelleload();
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
      this.degerleri();
      switch (YetkiClass.secim)
      {
        case "kayit":
          this.barButtonItem2.Caption = "Kayıt";
          break;
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void degerleri()
    {
    }

    private void kayit()
    {
      TBLPERSONEL entity = new TBLPERSONEL();
      try
      {
        entity.ADI = this.AdiTxt.Text;
        entity.SOYADI = this.SoyadTxt.Text;
        entity.ADISOYADI = this.AdiTxt.Text + " " + this.SoyadTxt.Text;
        entity.TCKIMLIKNO = this.TcTxt.Text;
        if (this.SicilTxt.Text != "")
          entity.SICILNO = this.SicilTxt.Text;
        entity.KOD = this.kodTxt.Text;
        if (this.UnvanCombo.Text != "")
          entity.UNVANID = new int?(Convert.ToInt32(this.UnvanCombo.EditValue));
        if (this.GorevUnvanCombo.Text != "")
          entity.GOREVUNVANID = new int?(Convert.ToInt32(this.GorevUnvanCombo.EditValue));
        if (this.egitimDurumCombo.Text != "")
          entity.EGITIMID = new int?(Convert.ToInt32(this.egitimDurumCombo.EditValue));
        if (this.personelistihdamcombo.Text != "")
          entity.PERSISTIHDAMIID = new int?(Convert.ToInt32(this.personelistihdamcombo.EditValue));
        if (this.EhliyetBilgisiCombo.Text != "")
        {
          int int32 = Convert.ToInt32(this.EhliyetBilgisiCombo.EditValue);
          entity.EHLIYETID = new int?(int32);
        }
        try
        {
          entity.EHLVERTARIH = Convert.ToDateTime(this.EhliyetTarihiDate.DateTime).ToString();
        }
        catch
        {
        }
        if (this.BirimAdiCombo.Text != "")
          entity.BELDBIRIMIID = new int?(Convert.ToInt32(this.BirimAdiCombo.EditValue));
        if (this.MudurlukCombo.Text != "")
          entity.BELDMUDURLUKID = new int?(Convert.ToInt32(this.MudurlukCombo.EditValue));
        if (this.GorevYeriTxt.Text != "")
          entity.GOREVYERI = this.GorevYeriTxt.Text;
        if (this.KanGrubuCombo.Text != "")
          entity.KANGRUPID = new int?(Convert.ToInt32(this.KanGrubuCombo.SelectedIndex));
        if (this.YetkiIzmaCombo.Text == "Var")
        {
          this.ParafTxt.Enabled = false;
        }
        else
        {
          this.ParafTxt.Enabled = true;
          entity.PARAFTANIM = this.ParafTxt.Text;
        }
        if (this.YetkiIzmaCombo.Text != "")
          entity.YETKILIIMZAID = new int?(Convert.ToInt32(this.YetkiIzmaCombo.SelectedIndex));
        entity.IKMADRES = this.ikametAdresiTxt.Text;
        if (this.resimsec)
          entity.RESIMPER = this.rs.resimyukle(this.ResimPic.Image);
        if (this.Telefon1Txt.Text != "")
          entity.CEPTELEFON = this.Telefon1Txt.Text;
        if (this.Telefon2Txt.Text != "")
          entity.CEPTELEFON2 = this.Telefon2Txt.Text;
        if (this.CocukSayisiTxt.Text != "")
          entity.COCUKTOPLAM = new int?(Convert.ToInt32(this.CocukSayisiTxt.Text));
        entity.SIRANO = this.siranoTxt.Text;
        if (this.GirisTarihiDate.Text != "")
          entity.ISEGIRISTARIHI = new DateTime?(Convert.ToDateTime(this.GirisTarihiDate.DateTime));
        if (this.DogumTarihiDate.Text != "")
          entity.DOGUMTARIHI = new DateTime?(Convert.ToDateTime(this.DogumTarihiDate.DateTime));
        if (this.KayitDurumuCombo.Text != "")
          entity.PERSDURUMID = new int?(Convert.ToInt32(this.KayitDurumuCombo.EditValue));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " Hata var");
      }
      this.db.TBLPERSONEL.Add(entity);
      this.db.SaveChanges();
      int num1 = (int) XtraMessageBox.Show("Kayıt işlemi başarlı bir şekilde gerçekleşti.");
    }

    private void guncelle()
    {
      TBLPERSONEL tblpersonel = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == YetkiClass.secim_id));
      try
      {
        tblpersonel.ADI = this.AdiTxt.Text;
        tblpersonel.SOYADI = this.SoyadTxt.Text;
        tblpersonel.ADISOYADI = this.AdiTxt.Text + " " + this.SoyadTxt.Text;
        tblpersonel.TCKIMLIKNO = this.TcTxt.Text;
        if (this.SicilTxt.Text != "")
          tblpersonel.SICILNO = this.SicilTxt.Text;
        tblpersonel.KOD = this.kodTxt.Text;
        if (this.UnvanCombo.Text != "")
          tblpersonel.UNVANID = new int?(Convert.ToInt32(this.UnvanCombo.EditValue));
        if (this.GorevUnvanCombo.Text != "")
          tblpersonel.GOREVUNVANID = new int?(Convert.ToInt32(this.GorevUnvanCombo.EditValue));
        if (this.egitimDurumCombo.Text != "")
          tblpersonel.EGITIMID = new int?(Convert.ToInt32(this.egitimDurumCombo.EditValue));
        if (this.personelistihdamcombo.Text != "")
          tblpersonel.PERSISTIHDAMIID = new int?(Convert.ToInt32(this.personelistihdamcombo.EditValue));
        if (this.EhliyetBilgisiCombo.Text != "")
        {
          int int32 = Convert.ToInt32(this.EhliyetBilgisiCombo.EditValue);
          tblpersonel.EHLIYETID = new int?(int32);
        }
        try
        {
          tblpersonel.EHLVERTARIH = Convert.ToDateTime(this.EhliyetTarihiDate.DateTime).ToString();
        }
        catch
        {
        }
        if (this.BirimAdiCombo.Text != "")
          tblpersonel.BELDBIRIMIID = new int?(Convert.ToInt32(this.BirimAdiCombo.EditValue));
        if (this.MudurlukCombo.Text != "")
          tblpersonel.BELDMUDURLUKID = new int?(Convert.ToInt32(this.MudurlukCombo.EditValue));
        if (this.GorevYeriTxt.Text != "")
          tblpersonel.GOREVYERI = this.GorevYeriTxt.Text;
        if (this.KanGrubuCombo.Text != "")
          tblpersonel.KANGRUPID = new int?(Convert.ToInt32(this.KanGrubuCombo.SelectedIndex));
        if (this.YetkiIzmaCombo.Text == "Var")
        {
          this.ParafTxt.Enabled = false;
        }
        else
        {
          this.ParafTxt.Enabled = true;
          tblpersonel.PARAFTANIM = this.ParafTxt.Text;
        }
        if (this.YetkiIzmaCombo.Text != "")
          tblpersonel.YETKILIIMZAID = new int?(Convert.ToInt32(this.YetkiIzmaCombo.SelectedIndex));
        tblpersonel.IKMADRES = this.ikametAdresiTxt.Text;
        tblpersonel.RESIMPER = !this.resimsec ? (byte[]) null : this.rs.resimyukle(this.ResimPic.Image);
        if (this.Telefon1Txt.Text != "")
          tblpersonel.CEPTELEFON = this.Telefon1Txt.Text;
        if (this.Telefon2Txt.Text != "")
          tblpersonel.CEPTELEFON2 = this.Telefon2Txt.Text;
        if (this.CocukSayisiTxt.Text != "")
          tblpersonel.COCUKTOPLAM = new int?(Convert.ToInt32(this.CocukSayisiTxt.Text));
        tblpersonel.SIRANO = this.siranoTxt.Text;
        if (this.GirisTarihiDate.Text != "" && this.GirisTarihiDate.Text != "1.01.0001 00:00:00")
          tblpersonel.ISEGIRISTARIHI = new DateTime?(Convert.ToDateTime(this.GirisTarihiDate.DateTime));
        if (this.DogumTarihiDate.Text != "" && this.DogumTarihiDate.Text != "1.01.0001 00:00:00")
          tblpersonel.DOGUMTARIHI = new DateTime?(Convert.ToDateTime(this.DogumTarihiDate.DateTime));
        if (this.KayitDurumuCombo.Text != "")
          tblpersonel.PERSDURUMID = new int?(Convert.ToInt32(this.KayitDurumuCombo.EditValue));
        if (XtraMessageBox.Show(tblpersonel.ADISOYADI + " adlı personelin bilgileri güncellenecektir", "UYARI", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Güncelleme işlemi başarlı bir şekilde gerçekleşti.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " Hata var");
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
        LogEkle.Logs("Ekleme Yapti");
        this.kayit();
      }
      else
      {
        if (!(YetkiClass.secim == "guncelle") || YetkiClass.GuncelleYetki != 1 || !(YetkiClass.menuyetki == "Hayır"))
          return;
        LogEkle.Logs("Guncelleme Yapti");
        this.guncelle();
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki != 1 || !(YetkiClass.menuyetki == "Hayır"))
        return;
      TBLPERSONEL entity = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (XtraMessageBox.Show(entity.ADISOYADI + " adlı personelin silmek istediğinizden eminmisiniz", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        LogEkle.Logs("Silme Yapti");
        this.db.TBLPERSONEL.Remove(entity);
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Silme işlemi başarlı bir şekilde gerçekleşti.");
      }
    }

    private void guncelleload()
    {
      try
      {
        this.barButtonItem2.Caption = "Güncelle";
        int id = YetkiClass.secim_id;
        DbSet<TBLPERSONEL> tblpersonel1 = this.db.TBLPERSONEL;
        Expression<System.Func<TBLPERSONEL, bool>> predicate = (Expression<System.Func<TBLPERSONEL, bool>>) (hd => hd.ID == id);
        foreach (TBLPERSONEL tblpersonel2 in (IEnumerable<TBLPERSONEL>) tblpersonel1.Where<TBLPERSONEL>(predicate))
        {
          this.AdiTxt.Text = tblpersonel2.ADI;
          this.SoyadTxt.Text = tblpersonel2.SOYADI;
          this.TcTxt.Text = tblpersonel2.TCKIMLIKNO;
          try
          {
            this.ResimPic.Image = this.rs.resimigetir(tblpersonel2.RESIMPER);
          }
          catch (Exception ex)
          {
          }
          this.SicilTxt.Text = tblpersonel2.SICILNO;
          this.kodTxt.Text = tblpersonel2.KOD;
          try
          {
            this.UnvanCombo.EditValue = (object) int.Parse(tblpersonel2.UNVANID.ToString());
          }
          catch (Exception ex)
          {
            this.UnvanCombo.Text = "";
          }
          try
          {
            this.BirimAdiCombo.EditValue = (object) Convert.ToInt32((object) tblpersonel2.BELDBIRIMIID);
          }
          catch (Exception ex)
          {
            this.GorevUnvanCombo.Text = "";
          }
          try
          {
            this.egitimDurumCombo.EditValue = (object) Convert.ToInt32((object) tblpersonel2.EGITIMID);
          }
          catch (Exception ex)
          {
            this.egitimDurumCombo.Text = "";
          }
          try
          {
            this.MudurlukCombo.EditValue = (object) Convert.ToInt32((object) tblpersonel2.BELDMUDURLUKID);
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.GorevUnvanCombo.EditValue = (object) Convert.ToInt32((object) tblpersonel2.GOREVUNVANID);
          }
          catch (Exception ex)
          {
            this.GorevUnvanCombo.Text = "";
          }
          try
          {
            this.EhliyetBilgisiCombo.EditValue = (object) Convert.ToInt32((object) tblpersonel2.EGITIMID);
          }
          catch (Exception ex)
          {
            this.EhliyetBilgisiCombo.Text = "";
          }
          this.GorevYeriTxt.Text = tblpersonel2.GOREVYERI;
          try
          {
            this.KanGrubuCombo.SelectedIndex = Convert.ToInt32((object) tblpersonel2.KANGRUPID);
          }
          catch (Exception ex)
          {
          }
          this.YetkiIzmaCombo.SelectedIndex = Convert.ToInt32((object) tblpersonel2.YETKILIIMZAID);
          this.ikametAdresiTxt.Text = tblpersonel2.IKMADRES;
          this.Telefon1Txt.Text = tblpersonel2.CEPTELEFON;
          this.Telefon2Txt.Text = tblpersonel2.CEPTELEFON2;
          this.personelistihdamcombo.EditValue = (object) tblpersonel2.PERSISTIHDAMIID.ToString();
          this.KayitDurumuCombo.EditValue = (object) tblpersonel2.PERSDURUMID;
          this.CocukSayisiTxt.Text = tblpersonel2.COCUKTOPLAM.ToString();
          this.zimmetAraciLook.EditValue = (object) tblpersonel2.ARACID;
          try
          {
            int arac_id = Convert.ToInt32((object) tblpersonel2.ARACID);
            this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.EhliyetTarihiDate.EditValue = (object) Convert.ToDateTime(tblpersonel2.EHLVERTARIH);
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.GirisTarihiDate.EditValue = (object) Convert.ToDateTime((object) tblpersonel2.ISEGIRISTARIHI);
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.DogumTarihiDate.EditValue = (object) Convert.ToDateTime((object) tblpersonel2.DOGUMTARIHI);
          }
          catch (Exception ex)
          {
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " Hata var");
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
        int num = (int) openFileDialog.ShowDialog();
        this.resimyolu = openFileDialog.FileName;
        this.ResimPic.Image = Image.FromFile(openFileDialog.FileName);
        this.resimsec = true;
      }
      catch (Exception ex)
      {
      }
    }

    private void YetkiIzmaCombo_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.YetkiIzmaCombo.Text == "Var")
        this.ParafTxt.Enabled = false;
      else
        this.ParafTxt.Enabled = true;
    }

    private void personelistihdamcombo_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      int num = (int) new EgitimDurumu().ShowDialog();
    }

    private void simpleButton5_Click(object sender, EventArgs e)
    {
      int num = (int) new Mudurluk().ShowDialog();
    }

    private void simpleButton9_Click(object sender, EventArgs e)
    {
      int num = (int) new GorevUnvan().ShowDialog();
    }

    private void simpleButton10_Click(object sender, EventArgs e)
    {
      int num = (int) new Unvan().ShowDialog();
    }

    private void simpleButton8_Click(object sender, EventArgs e)
    {
      int num = (int) new BirimAdi().ShowDialog();
    }

    private void simpleButton6_Click(object sender, EventArgs e)
    {
      int num = (int) new PersonelDurum().ShowDialog();
    }

    private void simpleButton7_Click(object sender, EventArgs e)
    {
      int num = (int) new Istihdam().ShowDialog();
    }

    private void simpleButton4_Click(object sender, EventArgs e)
    {
      int num = (int) new Ehliyet().ShowDialog();
    }

    private void layoutControlItem31_Click(object sender, EventArgs e)
    {
      int num = (int) new PersonelDurum().ShowDialog();
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      this.ResimPic.Image = (Image) null;
      this.resimsec = false;
    }

    private void TcTxt_TextChanged(object sender, EventArgs e)
    {
      if (!(YetkiClass.secim == "kayit"))
        return;
      if (this.db.TBLPERSONEL.Where<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (hd => hd.TCKIMLIKNO == this.TcTxt.Text)).Count<TBLPERSONEL>() > 0)
      {
        int num = (int) MessageBox.Show("Aynı kayıt tekrar kayıt edilemez.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Ekle));
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
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.araclarListesi = new AraclarListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.zimmetAraciLook = new LookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.simpleButton10 = new SimpleButton();
      this.simpleButton9 = new SimpleButton();
      this.simpleButton8 = new SimpleButton();
      this.simpleButton7 = new SimpleButton();
      this.simpleButton6 = new SimpleButton();
      this.simpleButton5 = new SimpleButton();
      this.simpleButton4 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.KayitDurumuCombo = new LookUpEdit();
      this.tBLPERSONELDURUMBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.siranoTxt = new TextEdit();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.ResimPic = new PictureEdit();
      this.GorevYeriTxt = new TextEdit();
      this.TcTxt = new TextEdit();
      this.Telefon1Txt = new TextEdit();
      this.egitimDurumCombo = new SearchLookUpEdit();
      this.gridView1 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.ParafTxt = new MemoEdit();
      this.YetkiIzmaCombo = new ComboBoxEdit();
      this.kodTxt = new TextEdit();
      this.SicilTxt = new TextEdit();
      this.AdiTxt = new TextEdit();
      this.SoyadTxt = new TextEdit();
      this.UnvanCombo = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.GorevUnvanCombo = new SearchLookUpEdit();
      this.gridView2 = new GridView();
      this.gridColumn4 = new GridColumn();
      this.BirimAdiCombo = new SearchLookUpEdit();
      this.gridView3 = new GridView();
      this.gridColumn3 = new GridColumn();
      this.MudurlukCombo = new SearchLookUpEdit();
      this.gridView4 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.Telefon2Txt = new TextEdit();
      this.GirisTarihiDate = new DateEdit();
      this.EhliyetBilgisiCombo = new SearchLookUpEdit();
      this.tBLPERSEHLIYETBindingSource = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.gridColumn6 = new GridColumn();
      this.EhliyetTarihiDate = new DateEdit();
      this.CocukSayisiTxt = new TextEdit();
      this.ikametAdresiTxt = new MemoEdit();
      this.KanGrubuCombo = new ComboBoxEdit();
      this.DogumTarihiDate = new DateEdit();
      this.personelistihdamcombo = new LookUpEdit();
      this.tBLPERSONELISTIHDAMDURUMBindingSource = new BindingSource(this.components);
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.difransiyel = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem24 = new LayoutControlItem();
      this.layoutControlItem28 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem29 = new LayoutControlItem();
      this.layoutControlItem30 = new LayoutControlItem();
      this.layoutControlItem31 = new LayoutControlItem();
      this.layoutControlItem32 = new LayoutControlItem();
      this.layoutControlItem33 = new LayoutControlItem();
      this.layoutControlItem34 = new LayoutControlItem();
      this.layoutControlItem35 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem36 = new LayoutControlItem();
      this.tBLPERSIZINDURUMBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.BirimAdiCombo4558 = new LayoutControlItem();
      this.tBLPERSONELISTIHDAMDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter();
      this.tBLPERSIZINDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSIZINDURUMTableAdapter();
      this.tBLPERSONELDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter();
      this.tBLPERSEHLIYETTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSEHLIYETTableAdapter();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.araclarListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.zimmetAraciLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.KayitDurumuCombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.siranoTxt.Properties.BeginInit();
      this.ResimPic.Properties.BeginInit();
      this.GorevYeriTxt.Properties.BeginInit();
      this.TcTxt.Properties.BeginInit();
      this.Telefon1Txt.Properties.BeginInit();
      this.egitimDurumCombo.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.ParafTxt.Properties.BeginInit();
      this.YetkiIzmaCombo.Properties.BeginInit();
      this.kodTxt.Properties.BeginInit();
      this.SicilTxt.Properties.BeginInit();
      this.AdiTxt.Properties.BeginInit();
      this.SoyadTxt.Properties.BeginInit();
      this.UnvanCombo.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.GorevUnvanCombo.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.BirimAdiCombo.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.MudurlukCombo.Properties.BeginInit();
      this.gridView4.BeginInit();
      this.Telefon2Txt.Properties.BeginInit();
      this.GirisTarihiDate.Properties.CalendarTimeProperties.BeginInit();
      this.GirisTarihiDate.Properties.BeginInit();
      this.EhliyetBilgisiCombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSEHLIYETBindingSource).BeginInit();
      this.gridView5.BeginInit();
      this.EhliyetTarihiDate.Properties.CalendarTimeProperties.BeginInit();
      this.EhliyetTarihiDate.Properties.BeginInit();
      this.CocukSayisiTxt.Properties.BeginInit();
      this.ikametAdresiTxt.Properties.BeginInit();
      this.KanGrubuCombo.Properties.BeginInit();
      this.DogumTarihiDate.Properties.CalendarTimeProperties.BeginInit();
      this.DogumTarihiDate.Properties.BeginInit();
      this.personelistihdamcombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.difransiyel.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem24.BeginInit();
      this.layoutControlItem28.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem29.BeginInit();
      this.layoutControlItem30.BeginInit();
      this.layoutControlItem31.BeginInit();
      this.layoutControlItem32.BeginInit();
      this.layoutControlItem33.BeginInit();
      this.layoutControlItem34.BeginInit();
      this.layoutControlItem35.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem36.BeginInit();
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
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
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
      this.ribbonControl1.Size = new Size(1130, 118);
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
      this.barButtonItem2.Caption = "Kayıt";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Enabled = false;
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
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
      this.layoutControl1.Controls.Add((Control) this.zimmetAraciLook);
      this.layoutControl1.Controls.Add((Control) this.simpleButton10);
      this.layoutControl1.Controls.Add((Control) this.simpleButton9);
      this.layoutControl1.Controls.Add((Control) this.simpleButton8);
      this.layoutControl1.Controls.Add((Control) this.simpleButton7);
      this.layoutControl1.Controls.Add((Control) this.simpleButton6);
      this.layoutControl1.Controls.Add((Control) this.simpleButton5);
      this.layoutControl1.Controls.Add((Control) this.simpleButton4);
      this.layoutControl1.Controls.Add((Control) this.simpleButton3);
      this.layoutControl1.Controls.Add((Control) this.KayitDurumuCombo);
      this.layoutControl1.Controls.Add((Control) this.siranoTxt);
      this.layoutControl1.Controls.Add((Control) this.simpleButton2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.ResimPic);
      this.layoutControl1.Controls.Add((Control) this.GorevYeriTxt);
      this.layoutControl1.Controls.Add((Control) this.TcTxt);
      this.layoutControl1.Controls.Add((Control) this.Telefon1Txt);
      this.layoutControl1.Controls.Add((Control) this.egitimDurumCombo);
      this.layoutControl1.Controls.Add((Control) this.ParafTxt);
      this.layoutControl1.Controls.Add((Control) this.YetkiIzmaCombo);
      this.layoutControl1.Controls.Add((Control) this.kodTxt);
      this.layoutControl1.Controls.Add((Control) this.SicilTxt);
      this.layoutControl1.Controls.Add((Control) this.AdiTxt);
      this.layoutControl1.Controls.Add((Control) this.SoyadTxt);
      this.layoutControl1.Controls.Add((Control) this.UnvanCombo);
      this.layoutControl1.Controls.Add((Control) this.GorevUnvanCombo);
      this.layoutControl1.Controls.Add((Control) this.BirimAdiCombo);
      this.layoutControl1.Controls.Add((Control) this.MudurlukCombo);
      this.layoutControl1.Controls.Add((Control) this.Telefon2Txt);
      this.layoutControl1.Controls.Add((Control) this.GirisTarihiDate);
      this.layoutControl1.Controls.Add((Control) this.EhliyetBilgisiCombo);
      this.layoutControl1.Controls.Add((Control) this.EhliyetTarihiDate);
      this.layoutControl1.Controls.Add((Control) this.CocukSayisiTxt);
      this.layoutControl1.Controls.Add((Control) this.ikametAdresiTxt);
      this.layoutControl1.Controls.Add((Control) this.KanGrubuCombo);
      this.layoutControl1.Controls.Add((Control) this.DogumTarihiDate);
      this.layoutControl1.Controls.Add((Control) this.personelistihdamcombo);
      this.layoutControl1.Dock = DockStyle.Top;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(995, 216, 812, 500));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1130, 539);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.zimmetAraciLook.Enabled = false;
      this.zimmetAraciLook.Location = new Point(137, 499);
      this.zimmetAraciLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.zimmetAraciLook.Name = "zimmetAraciLook";
      this.zimmetAraciLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.zimmetAraciLook.Properties.Appearance.Options.UseFont = true;
      this.zimmetAraciLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.zimmetAraciLook.Properties.DataSource = (object) this.tBLARACLARBindingSource;
      this.zimmetAraciLook.Properties.DisplayMember = "PLAKA";
      this.zimmetAraciLook.Properties.NullText = "";
      this.zimmetAraciLook.Properties.ValueMember = "ID";
      this.zimmetAraciLook.Size = new Size(981, 28);
      this.zimmetAraciLook.StyleController = (IStyleController) this.layoutControl1;
      this.zimmetAraciLook.TabIndex = 56;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.simpleButton10.ImageOptions.Image = (Image) Resources.add_16x169;
      this.simpleButton10.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton10.Location = new Point(349, 240);
      this.simpleButton10.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton10.Name = "simpleButton10";
      this.simpleButton10.PaintStyle = PaintStyles.Light;
      this.simpleButton10.Size = new Size(26, 27);
      this.simpleButton10.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton10.TabIndex = 54;
      this.simpleButton10.Click += new EventHandler(this.simpleButton10_Click);
      this.simpleButton9.ImageOptions.Image = (Image) Resources.add_16x164;
      this.simpleButton9.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton9.Location = new Point(349, 209);
      this.simpleButton9.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton9.Name = "simpleButton9";
      this.simpleButton9.PaintStyle = PaintStyles.Light;
      this.simpleButton9.Size = new Size(26, 27);
      this.simpleButton9.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton9.TabIndex = 53;
      this.simpleButton9.Click += new EventHandler(this.simpleButton9_Click);
      this.simpleButton8.ImageOptions.Image = (Image) Resources.add_16x165;
      this.simpleButton8.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton8.Location = new Point(349, 301);
      this.simpleButton8.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton8.Name = "simpleButton8";
      this.simpleButton8.PaintStyle = PaintStyles.Light;
      this.simpleButton8.Size = new Size(26, 27);
      this.simpleButton8.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton8.TabIndex = 52;
      this.simpleButton8.Click += new EventHandler(this.simpleButton8_Click);
      this.simpleButton7.ImageOptions.Image = (Image) Resources.add_16x167;
      this.simpleButton7.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton7.Location = new Point(349, 363);
      this.simpleButton7.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton7.Name = "simpleButton7";
      this.simpleButton7.PaintStyle = PaintStyles.Light;
      this.simpleButton7.Size = new Size(26, 27);
      this.simpleButton7.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton7.TabIndex = 51;
      this.simpleButton7.Click += new EventHandler(this.simpleButton7_Click);
      this.simpleButton6.ImageOptions.Image = (Image) Resources.add_16x166;
      this.simpleButton6.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton6.Location = new Point(349, 332);
      this.simpleButton6.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton6.Name = "simpleButton6";
      this.simpleButton6.PaintStyle = PaintStyles.Light;
      this.simpleButton6.Size = new Size(26, 27);
      this.simpleButton6.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton6.TabIndex = 50;
      this.simpleButton6.Click += new EventHandler(this.simpleButton6_Click);
      this.simpleButton5.ImageOptions.Image = (Image) Resources.add_16x163;
      this.simpleButton5.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton5.Location = new Point(349, 178);
      this.simpleButton5.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton5.Name = "simpleButton5";
      this.simpleButton5.PaintStyle = PaintStyles.Light;
      this.simpleButton5.Size = new Size(26, 27);
      this.simpleButton5.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton5.TabIndex = 49;
      this.simpleButton5.Click += new EventHandler(this.simpleButton5_Click);
      this.simpleButton4.ImageOptions.Image = (Image) Resources.add_16x168;
      this.simpleButton4.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton4.Location = new Point(649, 132);
      this.simpleButton4.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.PaintStyle = PaintStyles.Light;
      this.simpleButton4.Size = new Size(93, 27);
      this.simpleButton4.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton4.TabIndex = 48;
      this.simpleButton4.Click += new EventHandler(this.simpleButton4_Click);
      this.simpleButton3.ImageOptions.Image = (Image) Resources.add_16x162;
      this.simpleButton3.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton3.Location = new Point(353, 132);
      this.simpleButton3.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(22, 42);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 47;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.KayitDurumuCombo.Location = new Point(137, 332);
      this.KayitDurumuCombo.Margin = new Padding(3, 2, 3, 2);
      this.KayitDurumuCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KayitDurumuCombo.Name = "KayitDurumuCombo";
      this.KayitDurumuCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KayitDurumuCombo.Properties.Appearance.Options.UseFont = true;
      this.KayitDurumuCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.KayitDurumuCombo.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("DURUM", "Durum")
      });
      this.KayitDurumuCombo.Properties.DataSource = (object) this.tBLPERSONELDURUMBindingSource;
      this.KayitDurumuCombo.Properties.DisplayMember = "DURUM";
      this.KayitDurumuCombo.Properties.NullText = "";
      this.KayitDurumuCombo.Properties.ValueMember = "ID";
      this.KayitDurumuCombo.Size = new Size(208, 26);
      this.KayitDurumuCombo.StyleController = (IStyleController) this.layoutControl1;
      this.KayitDurumuCombo.TabIndex = 46;
      this.tBLPERSONELDURUMBindingSource.DataMember = "TBLPERSONELDURUM";
      this.tBLPERSONELDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.siranoTxt.Location = new Point(504, 283);
      this.siranoTxt.Margin = new Padding(3, 4, 3, 4);
      this.siranoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.siranoTxt.Name = "siranoTxt";
      this.siranoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.siranoTxt.Properties.Appearance.Options.UseFont = true;
      this.siranoTxt.Size = new Size(238, 26);
      this.siranoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.siranoTxt.TabIndex = 45;
      this.simpleButton2.Location = new Point(916, 363);
      this.simpleButton2.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(202, 27);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton2.TabIndex = 43;
      this.simpleButton2.Text = "Resim Sil";
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton1.Location = new Point(746, 363);
      this.simpleButton1.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(166, 27);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 42;
      this.simpleButton1.Text = "Resim Ekle";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.ResimPic.Location = new Point(755, 12);
      this.ResimPic.Margin = new Padding(3, 2, 3, 2);
      this.ResimPic.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ResimPic.Name = "ResimPic";
      this.ResimPic.Properties.PictureAlignment = ContentAlignment.BottomCenter;
      this.ResimPic.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.ResimPic.Properties.SizeMode = PictureSizeMode.Stretch;
      this.ResimPic.Size = new Size(363, 347);
      this.ResimPic.StyleController = (IStyleController) this.layoutControl1;
      this.ResimPic.TabIndex = 41;
      this.GorevYeriTxt.Location = new Point(137, 271);
      this.GorevYeriTxt.Margin = new Padding(3, 2, 3, 2);
      this.GorevYeriTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GorevYeriTxt.Name = "GorevYeriTxt";
      this.GorevYeriTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GorevYeriTxt.Properties.Appearance.Options.UseFont = true;
      this.GorevYeriTxt.Size = new Size(238, 26);
      this.GorevYeriTxt.StyleController = (IStyleController) this.layoutControl1;
      this.GorevYeriTxt.TabIndex = 8;
      this.TcTxt.Location = new Point(137, 42);
      this.TcTxt.Margin = new Padding(3, 2, 3, 2);
      this.TcTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.TcTxt.Name = "TcTxt";
      this.TcTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TcTxt.Properties.Appearance.Options.UseFont = true;
      this.TcTxt.Properties.Mask.BeepOnError = true;
      this.TcTxt.Size = new Size(238, 26);
      this.TcTxt.StyleController = (IStyleController) this.layoutControl1;
      this.TcTxt.TabIndex = 13;
      this.TcTxt.TextChanged += new EventHandler(this.TcTxt_TextChanged);
      this.Telefon1Txt.Location = new Point(504, 42);
      this.Telefon1Txt.Margin = new Padding(3, 2, 3, 2);
      this.Telefon1Txt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.Telefon1Txt.Name = "Telefon1Txt";
      this.Telefon1Txt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Telefon1Txt.Properties.Appearance.Options.UseFont = true;
      this.Telefon1Txt.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
      this.Telefon1Txt.Properties.Mask.MaskType = MaskType.Regular;
      this.Telefon1Txt.Size = new Size(238, 26);
      this.Telefon1Txt.StyleController = (IStyleController) this.layoutControl1;
      this.Telefon1Txt.TabIndex = 21;
      this.egitimDurumCombo.Location = new Point(137, 132);
      this.egitimDurumCombo.Margin = new Padding(3, 2, 3, 2);
      this.egitimDurumCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.egitimDurumCombo.Name = "egitimDurumCombo";
      this.egitimDurumCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.egitimDurumCombo.Properties.Appearance.Options.UseFont = true;
      this.egitimDurumCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.egitimDurumCombo.Properties.DisplayMember = "ID";
      this.egitimDurumCombo.Properties.NullText = "";
      this.egitimDurumCombo.Properties.PopupView = (ColumnView) this.gridView1;
      this.egitimDurumCombo.Properties.ValueMember = "EGITIMDURUM";
      this.egitimDurumCombo.Size = new Size(212, 26);
      this.egitimDurumCombo.StyleController = (IStyleController) this.layoutControl1;
      this.egitimDurumCombo.TabIndex = 5;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "EGITIMDURUM";
      this.gridColumn2.FieldName = "EGITIMDURUM";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.ParafTxt.Location = new Point(504, 343);
      this.ParafTxt.Margin = new Padding(3, 2, 3, 2);
      this.ParafTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ParafTxt.Name = "ParafTxt";
      this.ParafTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ParafTxt.Properties.Appearance.Options.UseFont = true;
      this.ParafTxt.Properties.ScrollBars = ScrollBars.None;
      this.ParafTxt.Size = new Size(238, 47);
      this.ParafTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ParafTxt.TabIndex = 30;
      this.YetkiIzmaCombo.Location = new Point(504, 313);
      this.YetkiIzmaCombo.Margin = new Padding(3, 2, 3, 2);
      this.YetkiIzmaCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.YetkiIzmaCombo.Name = "YetkiIzmaCombo";
      this.YetkiIzmaCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.YetkiIzmaCombo.Properties.Appearance.Options.UseFont = true;
      this.YetkiIzmaCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.YetkiIzmaCombo.Properties.Items.AddRange(new object[2]
      {
        (object) "Var",
        (object) "Yok"
      });
      this.YetkiIzmaCombo.Size = new Size(238, 26);
      this.YetkiIzmaCombo.StyleController = (IStyleController) this.layoutControl1;
      this.YetkiIzmaCombo.TabIndex = 26;
      this.YetkiIzmaCombo.SelectedValueChanged += new EventHandler(this.YetkiIzmaCombo_SelectedValueChanged);
      this.kodTxt.Location = new Point(137, 12);
      this.kodTxt.Margin = new Padding(3, 2, 3, 2);
      this.kodTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kodTxt.Name = "kodTxt";
      this.kodTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kodTxt.Properties.Appearance.Options.UseFont = true;
      this.kodTxt.Size = new Size(238, 26);
      this.kodTxt.StyleController = (IStyleController) this.layoutControl1;
      this.kodTxt.TabIndex = 4;
      this.kodTxt.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.SicilTxt.Location = new Point(494, 12);
      this.SicilTxt.Margin = new Padding(3, 2, 3, 2);
      this.SicilTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SicilTxt.Name = "SicilTxt";
      this.SicilTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SicilTxt.Properties.Appearance.Options.UseFont = true;
      this.SicilTxt.Size = new Size(248, 26);
      this.SicilTxt.StyleController = (IStyleController) this.layoutControl1;
      this.SicilTxt.TabIndex = 11;
      this.AdiTxt.Location = new Point(137, 72);
      this.AdiTxt.Margin = new Padding(3, 2, 3, 2);
      this.AdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AdiTxt.Name = "AdiTxt";
      this.AdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AdiTxt.Properties.Appearance.Options.UseFont = true;
      this.AdiTxt.Size = new Size(238, 26);
      this.AdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.AdiTxt.TabIndex = 28;
      this.SoyadTxt.Location = new Point(137, 102);
      this.SoyadTxt.Margin = new Padding(3, 2, 3, 2);
      this.SoyadTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.SoyadTxt.Name = "SoyadTxt";
      this.SoyadTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.SoyadTxt.Properties.Appearance.Options.UseFont = true;
      this.SoyadTxt.Size = new Size(238, 26);
      this.SoyadTxt.StyleController = (IStyleController) this.layoutControl1;
      this.SoyadTxt.TabIndex = 12;
      this.UnvanCombo.Location = new Point(137, 240);
      this.UnvanCombo.Margin = new Padding(3, 2, 3, 2);
      this.UnvanCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.UnvanCombo.Name = "UnvanCombo";
      this.UnvanCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.UnvanCombo.Properties.Appearance.Options.UseFont = true;
      this.UnvanCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.UnvanCombo.Properties.DisplayMember = "ID";
      this.UnvanCombo.Properties.NullText = "";
      this.UnvanCombo.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.UnvanCombo.Size = new Size(208, 26);
      this.UnvanCombo.StyleController = (IStyleController) this.layoutControl1;
      this.UnvanCombo.TabIndex = 6;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Ünvan";
      this.gridColumn1.FieldName = "UNVAN";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.GorevUnvanCombo.Location = new Point(137, 209);
      this.GorevUnvanCombo.Margin = new Padding(3, 2, 3, 2);
      this.GorevUnvanCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GorevUnvanCombo.Name = "GorevUnvanCombo";
      this.GorevUnvanCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GorevUnvanCombo.Properties.Appearance.Options.UseFont = true;
      this.GorevUnvanCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.GorevUnvanCombo.Properties.DisplayFormat.FormatString = "d";
      this.GorevUnvanCombo.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.GorevUnvanCombo.Properties.DisplayMember = "ID";
      this.GorevUnvanCombo.Properties.EditFormat.FormatString = "d";
      this.GorevUnvanCombo.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.GorevUnvanCombo.Properties.NullText = "";
      this.GorevUnvanCombo.Properties.PopupView = (ColumnView) this.gridView2;
      this.GorevUnvanCombo.Size = new Size(208, 26);
      this.GorevUnvanCombo.StyleController = (IStyleController) this.layoutControl1;
      this.GorevUnvanCombo.TabIndex = 33;
      this.gridView2.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Görev ";
      this.gridColumn4.FieldName = "KURUMGOREV";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.BirimAdiCombo.Location = new Point(137, 301);
      this.BirimAdiCombo.Margin = new Padding(3, 2, 3, 2);
      this.BirimAdiCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.BirimAdiCombo.Name = "BirimAdiCombo";
      this.BirimAdiCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.BirimAdiCombo.Properties.Appearance.Options.UseFont = true;
      this.BirimAdiCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BirimAdiCombo.Properties.NullText = "";
      this.BirimAdiCombo.Properties.PopupView = (ColumnView) this.gridView3;
      this.BirimAdiCombo.Size = new Size(208, 26);
      this.BirimAdiCombo.StyleController = (IStyleController) this.layoutControl1;
      this.BirimAdiCombo.TabIndex = 29;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Birim";
      this.gridColumn3.FieldName = "BELDBIRIMADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.MudurlukCombo.Location = new Point(137, 178);
      this.MudurlukCombo.Margin = new Padding(3, 2, 3, 2);
      this.MudurlukCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.MudurlukCombo.Name = "MudurlukCombo";
      this.MudurlukCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.MudurlukCombo.Properties.Appearance.Options.UseFont = true;
      this.MudurlukCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MudurlukCombo.Properties.DisplayMember = "ID";
      this.MudurlukCombo.Properties.NullText = "";
      this.MudurlukCombo.Properties.PopupView = (ColumnView) this.gridView4;
      this.MudurlukCombo.Size = new Size(208, 26);
      this.MudurlukCombo.StyleController = (IStyleController) this.layoutControl1;
      this.MudurlukCombo.TabIndex = 20;
      this.gridView4.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Müdürlük";
      this.gridColumn5.FieldName = "BELDMUDURLUK";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.Telefon2Txt.Location = new Point(504, 72);
      this.Telefon2Txt.Margin = new Padding(3, 2, 3, 2);
      this.Telefon2Txt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.Telefon2Txt.Name = "Telefon2Txt";
      this.Telefon2Txt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Telefon2Txt.Properties.Appearance.Options.UseFont = true;
      this.Telefon2Txt.Properties.Mask.EditMask = "0(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
      this.Telefon2Txt.Properties.Mask.MaskType = MaskType.Regular;
      this.Telefon2Txt.Size = new Size(238, 26);
      this.Telefon2Txt.StyleController = (IStyleController) this.layoutControl1;
      this.Telefon2Txt.TabIndex = 14;
      this.GirisTarihiDate.EditValue = (object) null;
      this.GirisTarihiDate.Location = new Point(504, 102);
      this.GirisTarihiDate.Margin = new Padding(3, 2, 3, 2);
      this.GirisTarihiDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.GirisTarihiDate.Name = "GirisTarihiDate";
      this.GirisTarihiDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.GirisTarihiDate.Properties.Appearance.Options.UseFont = true;
      this.GirisTarihiDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.GirisTarihiDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.GirisTarihiDate.Properties.DisplayFormat.FormatString = "";
      this.GirisTarihiDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.GirisTarihiDate.Properties.EditFormat.FormatString = "";
      this.GirisTarihiDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.GirisTarihiDate.Size = new Size(238, 26);
      this.GirisTarihiDate.StyleController = (IStyleController) this.layoutControl1;
      this.GirisTarihiDate.TabIndex = 31;
      this.EhliyetBilgisiCombo.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.EhliyetBilgisiCombo.Location = new Point(504, 132);
      this.EhliyetBilgisiCombo.Margin = new Padding(3, 2, 3, 2);
      this.EhliyetBilgisiCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.EhliyetBilgisiCombo.Name = "EhliyetBilgisiCombo";
      this.EhliyetBilgisiCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.EhliyetBilgisiCombo.Properties.Appearance.Options.UseFont = true;
      this.EhliyetBilgisiCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.EhliyetBilgisiCombo.Properties.DataSource = (object) this.tBLPERSEHLIYETBindingSource;
      this.EhliyetBilgisiCombo.Properties.DisplayMember = "EHLIYET";
      this.EhliyetBilgisiCombo.Properties.NullText = "";
      this.EhliyetBilgisiCombo.Properties.PopupView = (ColumnView) this.gridView5;
      this.EhliyetBilgisiCombo.Properties.ValueMember = "ID";
      this.EhliyetBilgisiCombo.Size = new Size(141, 26);
      this.EhliyetBilgisiCombo.StyleController = (IStyleController) this.layoutControl1;
      this.EhliyetBilgisiCombo.TabIndex = 38;
      this.tBLPERSEHLIYETBindingSource.DataMember = "TBLPERSEHLIYET";
      this.tBLPERSEHLIYETBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView5.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn6
      });
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.gridColumn6.Caption = "gridColumn6";
      this.gridColumn6.FieldName = "EHLIYET";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.EhliyetTarihiDate.EditValue = (object) null;
      this.EhliyetTarihiDate.Location = new Point(504, 163);
      this.EhliyetTarihiDate.Margin = new Padding(3, 2, 3, 2);
      this.EhliyetTarihiDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.EhliyetTarihiDate.Name = "EhliyetTarihiDate";
      this.EhliyetTarihiDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.EhliyetTarihiDate.Properties.Appearance.Options.UseFont = true;
      this.EhliyetTarihiDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.EhliyetTarihiDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.EhliyetTarihiDate.Properties.DisplayFormat.FormatString = "";
      this.EhliyetTarihiDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.EhliyetTarihiDate.Properties.EditFormat.FormatString = "";
      this.EhliyetTarihiDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.EhliyetTarihiDate.Size = new Size(238, 26);
      this.EhliyetTarihiDate.StyleController = (IStyleController) this.layoutControl1;
      this.EhliyetTarihiDate.TabIndex = 19;
      this.CocukSayisiTxt.EditValue = (object) "";
      this.CocukSayisiTxt.Location = new Point(504, 253);
      this.CocukSayisiTxt.Margin = new Padding(3, 2, 3, 2);
      this.CocukSayisiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.CocukSayisiTxt.Name = "CocukSayisiTxt";
      this.CocukSayisiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.CocukSayisiTxt.Properties.Appearance.Options.UseFont = true;
      this.CocukSayisiTxt.Properties.Mask.EditMask = "n0";
      this.CocukSayisiTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.CocukSayisiTxt.Size = new Size(238, 26);
      this.CocukSayisiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.CocukSayisiTxt.TabIndex = 39;
      this.ikametAdresiTxt.Location = new Point(137, 394);
      this.ikametAdresiTxt.Margin = new Padding(3, 2, 3, 2);
      this.ikametAdresiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ikametAdresiTxt.Name = "ikametAdresiTxt";
      this.ikametAdresiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ikametAdresiTxt.Properties.Appearance.Options.UseFont = true;
      this.ikametAdresiTxt.Properties.ScrollBars = ScrollBars.None;
      this.ikametAdresiTxt.Size = new Size(981, 101);
      this.ikametAdresiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ikametAdresiTxt.TabIndex = 22;
      this.KanGrubuCombo.Location = new Point(504, 223);
      this.KanGrubuCombo.Margin = new Padding(3, 2, 3, 2);
      this.KanGrubuCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KanGrubuCombo.Name = "KanGrubuCombo";
      this.KanGrubuCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KanGrubuCombo.Properties.Appearance.Options.UseFont = true;
      this.KanGrubuCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.KanGrubuCombo.Properties.Items.AddRange(new object[8]
      {
        (object) "A Rh+",
        (object) "A Rh-",
        (object) "B Rh+",
        (object) "B Rh-",
        (object) "AB Rh+",
        (object) "AB Rh-",
        (object) "0 Rh+",
        (object) "0 Rh-"
      });
      this.KanGrubuCombo.Properties.PopupSizeable = true;
      this.KanGrubuCombo.Size = new Size(238, 26);
      this.KanGrubuCombo.StyleController = (IStyleController) this.layoutControl1;
      this.KanGrubuCombo.TabIndex = 32;
      this.DogumTarihiDate.EditValue = (object) null;
      this.DogumTarihiDate.Location = new Point(504, 193);
      this.DogumTarihiDate.Margin = new Padding(3, 2, 3, 2);
      this.DogumTarihiDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.DogumTarihiDate.Name = "DogumTarihiDate";
      this.DogumTarihiDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.DogumTarihiDate.Properties.Appearance.Options.UseFont = true;
      this.DogumTarihiDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.DogumTarihiDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.DogumTarihiDate.Properties.DisplayFormat.FormatString = "";
      this.DogumTarihiDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.DogumTarihiDate.Properties.EditFormat.FormatString = "";
      this.DogumTarihiDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.DogumTarihiDate.Size = new Size(238, 26);
      this.DogumTarihiDate.StyleController = (IStyleController) this.layoutControl1;
      this.DogumTarihiDate.TabIndex = 40;
      this.personelistihdamcombo.Location = new Point(137, 363);
      this.personelistihdamcombo.Margin = new Padding(3, 2, 3, 2);
      this.personelistihdamcombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.personelistihdamcombo.Name = "personelistihdamcombo";
      this.personelistihdamcombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.personelistihdamcombo.Properties.Appearance.Options.UseFont = true;
      this.personelistihdamcombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personelistihdamcombo.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADI", "Adı")
      });
      this.personelistihdamcombo.Properties.DataSource = (object) this.tBLPERSONELISTIHDAMDURUMBindingSource;
      this.personelistihdamcombo.Properties.DisplayMember = "ADI";
      this.personelistihdamcombo.Properties.NullText = "";
      this.personelistihdamcombo.Properties.ValueMember = "ID";
      this.personelistihdamcombo.Size = new Size(208, 26);
      this.personelistihdamcombo.StyleController = (IStyleController) this.layoutControl1;
      this.personelistihdamcombo.TabIndex = 44;
      this.personelistihdamcombo.EditValueChanged += new EventHandler(this.personelistihdamcombo_EditValueChanged);
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[37]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.difransiyel,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem24,
        (BaseLayoutItem) this.layoutControlItem28,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem29,
        (BaseLayoutItem) this.layoutControlItem30,
        (BaseLayoutItem) this.layoutControlItem31,
        (BaseLayoutItem) this.layoutControlItem32,
        (BaseLayoutItem) this.layoutControlItem33,
        (BaseLayoutItem) this.layoutControlItem34,
        (BaseLayoutItem) this.layoutControlItem35,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem36
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1130, 539);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.kodTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem1.Size = new Size(367, 30);
      this.layoutControlItem1.Text = "Kod";
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(122, 21);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.GorevYeriTxt;
      this.layoutControlItem5.Location = new Point(0, 259);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(367, 30);
      this.layoutControlItem5.Text = "Görev Yeri";
      this.layoutControlItem5.TextSize = new Size(122, 20);
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.BirimAdiCombo;
      this.layoutControlItem26.Location = new Point(0, 289);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem26.Size = new Size(337, 31);
      this.layoutControlItem26.Text = "Birim Adı";
      this.layoutControlItem26.TextSize = new Size(122, 20);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.TcTxt;
      this.layoutControlItem10.Location = new Point(0, 30);
      this.layoutControlItem10.MinSize = new Size(181, 30);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(367, 30);
      this.layoutControlItem10.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem10.Text = "T.C";
      this.layoutControlItem10.TextSize = new Size(122, 20);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.egitimDurumCombo;
      this.layoutControlItem2.Location = new Point(0, 120);
      this.layoutControlItem2.MinSize = new Size(181, 30);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(341, 46);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Eğitim Durumu";
      this.layoutControlItem2.TextSize = new Size(122, 20);
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.AdiTxt;
      this.layoutControlItem25.Location = new Point(0, 60);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(367, 30);
      this.layoutControlItem25.Text = "Adı ";
      this.layoutControlItem25.TextSize = new Size(122, 20);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.SoyadTxt;
      this.layoutControlItem9.Location = new Point(0, 90);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(367, 30);
      this.layoutControlItem9.Text = "Soyad";
      this.layoutControlItem9.TextSize = new Size(122, 20);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.UnvanCombo;
      this.layoutControlItem3.Location = new Point(0, 228);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem3.Size = new Size(337, 31);
      this.layoutControlItem3.Text = "Unvanı";
      this.layoutControlItem3.TextSize = new Size(122, 20);
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.GorevUnvanCombo;
      this.layoutControlItem20.Location = new Point(0, 197);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(337, 31);
      this.layoutControlItem20.Text = "Görev Ünvanı";
      this.layoutControlItem20.TextSize = new Size(122, 20);
      this.difransiyel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyel.AppearanceItemCaption.Options.UseFont = true;
      this.difransiyel.Control = (Control) this.MudurlukCombo;
      this.difransiyel.Location = new Point(0, 166);
      this.difransiyel.MinSize = new Size(181, 30);
      this.difransiyel.Name = "difransiyel";
      this.difransiyel.Size = new Size(337, 31);
      this.difransiyel.SizeConstraintsType = SizeConstraintsType.Custom;
      this.difransiyel.Text = "Müdürlüğü";
      this.difransiyel.TextSize = new Size(122, 20);
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.EhliyetBilgisiCombo;
      this.layoutControlItem22.Location = new Point(367, 120);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(270, 31);
      this.layoutControlItem22.Text = "Ehliyet Bilgisi";
      this.layoutControlItem22.TextSize = new Size(122, 20);
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.EhliyetTarihiDate;
      this.layoutControlItem16.Location = new Point(367, 151);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem16.Size = new Size(367, 30);
      this.layoutControlItem16.Text = "Ehliyet Tarihi";
      this.layoutControlItem16.TextSize = new Size(122, 20);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.DogumTarihiDate;
      this.layoutControlItem14.Location = new Point(367, 181);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(367, 30);
      this.layoutControlItem14.Text = "Doğum Tarihi";
      this.layoutControlItem14.TextSize = new Size(122, 20);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.KanGrubuCombo;
      this.layoutControlItem12.Location = new Point(367, 211);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(367, 30);
      this.layoutControlItem12.Text = "Kan Grubu";
      this.layoutControlItem12.TextSize = new Size(122, 20);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.CocukSayisiTxt;
      this.layoutControlItem7.Location = new Point(367, 241);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(367, 30);
      this.layoutControlItem7.Text = "Çocuk Sayısı";
      this.layoutControlItem7.TextSize = new Size(122, 20);
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.YetkiIzmaCombo;
      this.layoutControlItem23.Location = new Point(367, 301);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem23.Size = new Size(367, 30);
      this.layoutControlItem23.Text = "İmza Yetkisi";
      this.layoutControlItem23.TextSize = new Size(122, 20);
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.ikametAdresiTxt;
      this.layoutControlItem19.Location = new Point(0, 382);
      this.layoutControlItem19.MinSize = new Size(50, 25);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem19.Size = new Size(1110, 105);
      this.layoutControlItem19.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem19.Text = "İkamet Adresi";
      this.layoutControlItem19.TextSize = new Size(122, 22);
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.ParafTxt;
      this.layoutControlItem27.Location = new Point(367, 331);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(367, 51);
      this.layoutControlItem27.Text = "Paraf Tanımı";
      this.layoutControlItem27.TextSize = new Size(122, 20);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.GirisTarihiDate;
      this.layoutControlItem4.Location = new Point(367, 90);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(367, 30);
      this.layoutControlItem4.Text = "İşe Giriş Tarihi";
      this.layoutControlItem4.TextSize = new Size(122, 20);
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.Telefon1Txt;
      this.layoutControlItem18.Location = new Point(367, 30);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(367, 30);
      this.layoutControlItem18.Text = "İrtibat No1";
      this.layoutControlItem18.TextSize = new Size(122, 20);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.Telefon2Txt;
      this.layoutControlItem11.Location = new Point(367, 60);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(367, 30);
      this.layoutControlItem11.Text = "İrtibat No2";
      this.layoutControlItem11.TextSize = new Size(122, 20);
      this.layoutControlItem6.Control = (Control) this.ResimPic;
      this.layoutControlItem6.ImageOptions.Alignment = ContentAlignment.MiddleCenter;
      this.layoutControlItem6.Location = new Point(734, 0);
      this.layoutControlItem6.MinSize = new Size(33, 23);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(376, 351);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.Text = " ";
      this.layoutControlItem6.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem6.TextSize = new Size(4, 16);
      this.layoutControlItem6.TextToControlDistance = 5;
      this.layoutControlItem13.Control = (Control) this.simpleButton1;
      this.layoutControlItem13.Location = new Point(734, 351);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(170, 31);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.simpleButton2;
      this.layoutControlItem15.Location = new Point(904, 351);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(206, 31);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.personelistihdamcombo;
      this.layoutControlItem17.Location = new Point(0, 351);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem17.Size = new Size(337, 31);
      this.layoutControlItem17.Text = "İstihdam";
      this.layoutControlItem17.TextSize = new Size(122, 21);
      this.layoutControlItem24.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem24.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem24.Control = (Control) this.siranoTxt;
      this.layoutControlItem24.Location = new Point(367, 271);
      this.layoutControlItem24.Name = "layoutControlItem24";
      this.layoutControlItem24.Size = new Size(367, 30);
      this.layoutControlItem24.Text = "Sıra No";
      this.layoutControlItem24.TextSize = new Size(122, 20);
      this.layoutControlItem28.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem28.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem28.Control = (Control) this.KayitDurumuCombo;
      this.layoutControlItem28.Location = new Point(0, 320);
      this.layoutControlItem28.MinSize = new Size(181, 30);
      this.layoutControlItem28.Name = "layoutControlItem28";
      this.layoutControlItem28.Size = new Size(337, 31);
      this.layoutControlItem28.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem28.Text = "Durum ";
      this.layoutControlItem28.TextSize = new Size(122, 21);
      this.layoutControlItem21.Control = (Control) this.simpleButton3;
      this.layoutControlItem21.Location = new Point(341, 120);
      this.layoutControlItem21.MinSize = new Size(26, 31);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(26, 46);
      this.layoutControlItem21.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem21.TextSize = new Size(0, 0);
      this.layoutControlItem21.TextVisible = false;
      this.layoutControlItem29.Control = (Control) this.simpleButton4;
      this.layoutControlItem29.Location = new Point(637, 120);
      this.layoutControlItem29.MinSize = new Size(26, 31);
      this.layoutControlItem29.Name = "layoutControlItem29";
      this.layoutControlItem29.Size = new Size(97, 31);
      this.layoutControlItem29.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem29.TextSize = new Size(0, 0);
      this.layoutControlItem29.TextVisible = false;
      this.layoutControlItem30.Control = (Control) this.simpleButton5;
      this.layoutControlItem30.Location = new Point(337, 166);
      this.layoutControlItem30.Name = "layoutControlItem30";
      this.layoutControlItem30.Size = new Size(30, 31);
      this.layoutControlItem30.TextSize = new Size(0, 0);
      this.layoutControlItem30.TextVisible = false;
      this.layoutControlItem31.Control = (Control) this.simpleButton6;
      this.layoutControlItem31.Location = new Point(337, 320);
      this.layoutControlItem31.Name = "layoutControlItem31";
      this.layoutControlItem31.Size = new Size(30, 31);
      this.layoutControlItem31.TextSize = new Size(0, 0);
      this.layoutControlItem31.TextVisible = false;
      this.layoutControlItem31.Click += new EventHandler(this.layoutControlItem31_Click);
      this.layoutControlItem32.Control = (Control) this.simpleButton7;
      this.layoutControlItem32.Location = new Point(337, 351);
      this.layoutControlItem32.Name = "layoutControlItem32";
      this.layoutControlItem32.Size = new Size(30, 31);
      this.layoutControlItem32.TextSize = new Size(0, 0);
      this.layoutControlItem32.TextVisible = false;
      this.layoutControlItem33.Control = (Control) this.simpleButton8;
      this.layoutControlItem33.Location = new Point(337, 289);
      this.layoutControlItem33.Name = "layoutControlItem33";
      this.layoutControlItem33.Size = new Size(30, 31);
      this.layoutControlItem33.TextSize = new Size(0, 0);
      this.layoutControlItem33.TextVisible = false;
      this.layoutControlItem34.Control = (Control) this.simpleButton9;
      this.layoutControlItem34.Location = new Point(337, 197);
      this.layoutControlItem34.Name = "layoutControlItem34";
      this.layoutControlItem34.Size = new Size(30, 31);
      this.layoutControlItem34.TextSize = new Size(0, 0);
      this.layoutControlItem34.TextVisible = false;
      this.layoutControlItem35.Control = (Control) this.simpleButton10;
      this.layoutControlItem35.ImageOptions.Alignment = ContentAlignment.MiddleCenter;
      this.layoutControlItem35.Location = new Point(337, 228);
      this.layoutControlItem35.MinSize = new Size(26, 31);
      this.layoutControlItem35.Name = "layoutControlItem35";
      this.layoutControlItem35.Size = new Size(30, 31);
      this.layoutControlItem35.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem35.TextSize = new Size(0, 0);
      this.layoutControlItem35.TextVisible = false;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.SicilTxt;
      this.layoutControlItem8.Location = new Point(367, 0);
      this.layoutControlItem8.MinSize = new Size(168, 30);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(367, 30);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "Sicil No";
      this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem8.TextSize = new Size(113, 20);
      this.layoutControlItem8.TextToControlDistance = 2;
      this.layoutControlItem36.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem36.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem36.Control = (Control) this.zimmetAraciLook;
      this.layoutControlItem36.Location = new Point(0, 487);
      this.layoutControlItem36.Name = "layoutControlItem36";
      this.layoutControlItem36.Size = new Size(1110, 32);
      this.layoutControlItem36.Text = "Zimmetli Aracı :";
      this.layoutControlItem36.TextSize = new Size(122, 22);
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
      this.tBLPERSEHLIYETTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1130, 661);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (Ekle);
      this.Text = "Personel Ekle Güncelle";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.araclarListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.zimmetAraciLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.KayitDurumuCombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.siranoTxt.Properties.EndInit();
      this.ResimPic.Properties.EndInit();
      this.GorevYeriTxt.Properties.EndInit();
      this.TcTxt.Properties.EndInit();
      this.Telefon1Txt.Properties.EndInit();
      this.egitimDurumCombo.Properties.EndInit();
      this.gridView1.EndInit();
      this.ParafTxt.Properties.EndInit();
      this.YetkiIzmaCombo.Properties.EndInit();
      this.kodTxt.Properties.EndInit();
      this.SicilTxt.Properties.EndInit();
      this.AdiTxt.Properties.EndInit();
      this.SoyadTxt.Properties.EndInit();
      this.UnvanCombo.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.GorevUnvanCombo.Properties.EndInit();
      this.gridView2.EndInit();
      this.BirimAdiCombo.Properties.EndInit();
      this.gridView3.EndInit();
      this.MudurlukCombo.Properties.EndInit();
      this.gridView4.EndInit();
      this.Telefon2Txt.Properties.EndInit();
      this.GirisTarihiDate.Properties.CalendarTimeProperties.EndInit();
      this.GirisTarihiDate.Properties.EndInit();
      this.EhliyetBilgisiCombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSEHLIYETBindingSource).EndInit();
      this.gridView5.EndInit();
      this.EhliyetTarihiDate.Properties.CalendarTimeProperties.EndInit();
      this.EhliyetTarihiDate.Properties.EndInit();
      this.CocukSayisiTxt.Properties.EndInit();
      this.ikametAdresiTxt.Properties.EndInit();
      this.KanGrubuCombo.Properties.EndInit();
      this.DogumTarihiDate.Properties.CalendarTimeProperties.EndInit();
      this.DogumTarihiDate.Properties.EndInit();
      this.personelistihdamcombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem20.EndInit();
      this.difransiyel.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem24.EndInit();
      this.layoutControlItem28.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem29.EndInit();
      this.layoutControlItem30.EndInit();
      this.layoutControlItem31.EndInit();
      this.layoutControlItem32.EndInit();
      this.layoutControlItem33.EndInit();
      this.layoutControlItem34.EndInit();
      this.layoutControlItem35.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem36.EndInit();
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
