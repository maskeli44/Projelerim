// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.YagEmri
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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.AraclarListesiTableAdapters;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class YagEmri : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private int id = YetkiClass.secim_id;
    private string kod = YetkiClass.secim_kodu;
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
    private DateEdit dateEdit1;
    private LayoutControlItem layoutControlItem20;
    private DateEdit dateEdit2;
    private LayoutControlItem layoutControlItem6;
    private TextEdit genelbakim;
    private LayoutControlItem layoutControlItem14;
    private ComboBoxEdit bakimturu;
    private BehaviorManager behaviorManager1;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private SimpleButton simpleButton2;
    private PanelControl panelControl2;
    private PanelControl panelControl4;
    public GridControl gridControl2;
    private GridView gridView6;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private PanelControl panelControl3;
    private SimpleButton simpleButton1;
    private SimpleButton simpleButton3;
    private LookUpEdit bakimyeri;
    private LookUpEdit isemirturu;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLISEMIRDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMIRDURUMTableAdapter tBLISEMIRDURUMTableAdapter;
    private BindingSource tBLBAKIMYERIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBAKIMYERITableAdapter tBLBAKIMYERITableAdapter;
    private TimeEdit cikissaat;
    private TimeEdit girissaat;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem17;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private LookUpEdit atolyesefi;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private TextEdit atikyagTxt;
    private LayoutControlItem layoutControlItem7;
    private BarButtonItem barButtonItem8;
    private TextEdit HidrolikYagTxt;
    private LayoutControlItem layoutControlItem13;
    private LookUpEdit arizanedeni;
    private BindingSource tAHARIZANEDENIBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TAHARIZANEDENITableAdapter tAHARIZANEDENITableAdapter;

    public YagEmri() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet7.TAHARIZANEDENI);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet5.TBLBAKIMYERI);
      this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet5.TBLISEMIRDURUM);
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet1.TBLBAKIMGRUBU);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet1.TBLATOLYEUSTALAR);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet1.TBLATOLYEBOLUM);
      DegerAktarma.list.Clear();
      this.textEdit9.Properties.ValueMember = "ID";
      this.textEdit9.Properties.DisplayMember = "ADISOYADI";
      this.textEdit9.Properties.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.plakaCombo.Properties.ValueMember = "ID";
      this.plakaCombo.Properties.DisplayMember = "PLAKA";
      this.plakaCombo.Properties.DataSource = (object) this.db.TBLARACLAR.ToList<TBLARACLAR>();
      this.birimCombo.Properties.ValueMember = "ID";
      this.birimCombo.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimCombo.Properties.DataSource = (object) this.db.TBLBELDBIRIMLER.ToList<TBLBELDBIRIMLER>();
      this.textEdit8.Properties.ValueMember = "ID";
      this.textEdit8.Properties.DisplayMember = "BELDMUDURLUK";
      this.textEdit8.Properties.DataSource = (object) this.db.TBLBELDMUDURLUK.ToList<TBLBELDMUDURLUK>();
      this.bakimyeri.EditValue = (object) "4";
      this.isemirturu.EditValue = (object) 1;
      this.girissaat.EditValue = (object) DateTime.Now;
      this.dateEdit1.EditValue = (object) DateTime.Now;
      this.atolyesefi.EditValue = (object) sorumlu.yagsorumlusu;
      this.bakimturu.EditValue = (object) "Genel Arıza";
      DegerAktarma.list.Clear();
      switch (YetkiClass.secim)
      {
        case "kayıt":
          this.isemirkodu.Text = this.son.isemirkod().ToString();
          break;
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
        entity.KOD = this.son.isemirkod().ToString();
        entity.ARACID = new int?(Convert.ToInt32(this.plakaCombo.EditValue));
        entity.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.EditValue));
        entity.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.girissaat.EditValue));
        if (this.dateEdit2.Text != "")
          entity.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        if (this.cikissaat.Text != "00:00:00")
          entity.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.cikissaat.EditValue));
        if (this.arizanedeni.Text != "")
          entity.ARIZANEDENIID = new int?(Convert.ToInt32(this.arizanedeni.EditValue));
        if (this.bildirilenariza.Text != "")
          entity.BILDIRILENARIZA = this.bildirilenariza.Text;
        if (this.isemirturu.Text != "")
          entity.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isemirturu.EditValue));
        if (this.bakimyeri.Text != "")
          entity.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimyeri.EditValue));
        if (this.aracigetiren.Text != "")
          entity.ARACIGETIREN = this.aracigetiren.Text;
        if (this.bakimKMsaat.Text != "")
          entity.BAKIMKMSI = this.bakimKMsaat.Text;
        entity.ISEMRISIRANO = new int?(Convert.ToInt32(999));
        if (this.atolyesefi.Text != "")
          entity.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyesefi.EditValue));
        int num1;
        if (this.bakimturu.Text != "")
        {
          TBLISEMRI tblisemri = entity;
          num1 = this.bakimturu.SelectedIndex;
          string str = num1.ToString();
          tblisemri.BAKIMTURUID = str;
        }
        if (this.atikyagTxt.Text != "")
          entity.ATIKYAG = new Decimal?(Convert.ToDecimal(this.atikyagTxt.Text));
        if (this.bakimturu.Text != "")
        {
          TBLISEMRI tblisemri = entity;
          num1 = this.bakimturu.SelectedIndex;
          string str = num1.ToString();
          tblisemri.BAKIMDERECESIID = str;
        }
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        if (this.genelbakim.Text != "")
          tblaraclar.GENELBAKIMKM = this.genelbakim.Text;
        if (this.motoryag.Text != "")
          tblaraclar.MOTORYAGKM = this.motoryag.Text;
        if (this.difransiyelyag.Text != "")
          tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        if (this.sanzimanyag.Text != "")
          tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        if (this.HidrolikYagTxt.Text != "")
          tblaraclar.HIDROLIKYAGKM = this.HidrolikYagTxt.Text;
        for (int rowHandle = 0; rowHandle < this.gridView6.DataRowCount; ++rowHandle)
        {
          this.db.TBLISEMRIBAKIMLAR.Add(new TBLISEMRIBAKIMLAR()
          {
            ISEMRIID = new int?(this.son.isemir()),
            ATOLYEID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ATOLYEID"))),
            BAKIMYAPUSTAID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMYAPUSTAID"))),
            BAKIMGRUBUID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMGRUBUID"))),
            YAPILANBAKIM = this.gridView6.GetRowCellValue(rowHandle, "YAPILANBAKIM").ToString()
          });
          this.db.SaveChanges();
        }
        this.db.TBLISEMRI.Add(entity);
        this.db.SaveChanges();
        num1 = this.db.TBLISEMRI.OrderByDescending<TBLISEMRI, int>((Expression<System.Func<TBLISEMRI, int>>) (p => p.ID)).Select<TBLISEMRI, int>((Expression<System.Func<TBLISEMRI, int>>) (r => r.ID)).First<int>();
        YetkiClass.secim_id = int.Parse(num1.ToString());
        int num2 = (int) XtraMessageBox.Show("Kayıt Tamam");
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
        TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == this.kod));
        ise.ARACID = new int?(Convert.ToInt32(this.plakaCombo.EditValue));
        ise.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.EditValue));
        ise.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.girissaat.EditValue));
        if (this.dateEdit2.Text != "")
          ise.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        if (this.cikissaat.Text != "00:00:00")
          ise.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.cikissaat.EditValue));
        if (this.arizanedeni.Text != "")
          ise.ARIZANEDENIID = new int?(Convert.ToInt32(this.arizanedeni.EditValue));
        if (this.bildirilenariza.Text != "")
          ise.BILDIRILENARIZA = this.bildirilenariza.Text;
        if (this.isemirturu.Text != "")
          ise.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isemirturu.EditValue));
        if (this.bakimyeri.Text != "")
          ise.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimyeri.EditValue));
        if (this.aracigetiren.Text != "")
          ise.ARACIGETIREN = this.aracigetiren.Text;
        if (this.bakimKMsaat.Text != "")
          ise.BAKIMKMSI = this.bakimKMsaat.Text;
        ise.ISEMRISIRANO = new int?(Convert.ToInt32(999));
        if (this.atolyesefi.Text != "")
          ise.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyesefi.EditValue));
        int selectedIndex;
        if (this.bakimturu.Text != "")
        {
          TBLISEMRI tblisemri = ise;
          selectedIndex = this.bakimturu.SelectedIndex;
          string str = selectedIndex.ToString();
          tblisemri.BAKIMTURUID = str;
        }
        if (this.atikyagTxt.Text != "")
          ise.ATIKYAG = new Decimal?(Convert.ToDecimal(this.atikyagTxt.Text));
        if (this.bakimturu.Text != "")
        {
          TBLISEMRI tblisemri = ise;
          selectedIndex = this.bakimturu.SelectedIndex;
          string str = selectedIndex.ToString();
          tblisemri.BAKIMDERECESIID = str;
        }
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        if (this.genelbakim.Text != "")
          tblaraclar.GENELBAKIMKM = this.genelbakim.Text;
        if (this.motoryag.Text != "")
          tblaraclar.MOTORYAGKM = this.motoryag.Text;
        if (this.difransiyelyag.Text != "")
          tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        if (this.sanzimanyag.Text != "")
          tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        if (this.HidrolikYagTxt.Text != "")
          tblaraclar.HIDROLIKYAGKM = this.HidrolikYagTxt.Text;
        IQueryable<TBLISEMRIBAKIMLAR> source = this.db.TBLISEMRIBAKIMLAR.Where<TBLISEMRIBAKIMLAR>((Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (hd => hd.ISEMRIID == (int?) ise.ID));
        for (int rowHandle = 0; rowHandle < this.gridView6.DataRowCount; ++rowHandle)
        {
          if (source.Count<TBLISEMRIBAKIMLAR>() > 0)
          {
            foreach (TBLISEMRIBAKIMLAR tblisemribakimlar1 in (IEnumerable<TBLISEMRIBAKIMLAR>) source)
            {
              if (Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ID")) != 0)
              {
                TBLISEMRIBAKIMLAR tblisemribakimlar2 = this.db.TBLISEMRIBAKIMLAR.FirstOrDefault<TBLISEMRIBAKIMLAR>((Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (x => x.ISEMRIID == (int?) ise.ID));
                tblisemribakimlar2.ISEMRIID = new int?(ise.ID);
                tblisemribakimlar2.ATOLYEID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ATOLYEID")));
                tblisemribakimlar2.BAKIMYAPUSTAID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMYAPUSTAID")));
                tblisemribakimlar2.BAKIMGRUBUID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMGRUBUID")));
                tblisemribakimlar2.YAPILANBAKIM = this.gridView6.GetRowCellValue(rowHandle, "YAPILANBAKIM").ToString();
              }
              else
                this.db.TBLISEMRIBAKIMLAR.Add(new TBLISEMRIBAKIMLAR()
                {
                  ISEMRIID = new int?(ise.ID),
                  ATOLYEID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ATOLYEID"))),
                  BAKIMYAPUSTAID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMYAPUSTAID"))),
                  BAKIMGRUBUID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMGRUBUID"))),
                  YAPILANBAKIM = this.gridView6.GetRowCellValue(rowHandle, "YAPILANBAKIM").ToString()
                });
            }
          }
          else
            this.db.TBLISEMRIBAKIMLAR.Add(new TBLISEMRIBAKIMLAR()
            {
              ISEMRIID = new int?(ise.ID),
              ATOLYEID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ATOLYEID"))),
              BAKIMYAPUSTAID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMYAPUSTAID"))),
              BAKIMGRUBUID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMGRUBUID"))),
              YAPILANBAKIM = this.gridView6.GetRowCellValue(rowHandle, "YAPILANBAKIM").ToString()
            });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt Tamam");
        }
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void sil()
    {
      TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == this.kod));
      IQueryable<TBLISEMRIBAKIMLAR> source = this.db.TBLISEMRIBAKIMLAR.Where<TBLISEMRIBAKIMLAR>((Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (deg => deg.ISEMRIID == (int?) ise.ID));
      try
      {
        if (source.Any<TBLISEMRIBAKIMLAR>())
        {
          foreach (TBLISEMRIBAKIMLAR tblisemribakimlar in (IEnumerable<TBLISEMRIBAKIMLAR>) source)
          {
            TBLISEMRIBAKIMLAR item = tblisemribakimlar;
            TBLISEMRIBAKIMLAR entity = this.db.TBLISEMRIBAKIMLAR.FirstOrDefault<TBLISEMRIBAKIMLAR>((Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (x => x.ID == item.ID));
            int num = (int) XtraMessageBox.Show(entity.ID.ToString());
            this.db.TBLISEMRIBAKIMLAR.Remove(entity);
          }
          this.db.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
      this.db.TBLISEMRI.Remove(ise);
      this.db.SaveChanges();
      ((ilksayfa) Application.OpenForms["ilksayfa"])?.listele();
      this.Close();
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
        ((ilksayfa) Application.OpenForms["ilksayfa"])?.listele();
      }
      else if (YetkiClass.secim == "guncelle" && YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.guncelle();
        LogEkle.Logs("Guncelleme Yapti");
      }
      else
      {
        int num = (int) XtraMessageBox.Show("İşlemi yapma yetkiniz yok.Lütfen yönetici ile irtibata geçiniz");
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.sil();
        LogEkle.Logs("Silme Yapti");
        this.sil();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("İşlemi yapma yetkiniz yok.Lütfen yönetici ile irtibata geçiniz");
      }
    }

    private void guncelleload()
    {
      TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == this.kod));
      try
      {
        this.isemirkodu.Text = ise.KOD;
        this.plakaCombo.EditValue = (object) ise.ARACID;
        this.dateEdit1.EditValue = (object) ise.GIRISTARIH;
        this.girissaat.EditValue = (object) Convert.ToDateTime((object) ise.GIRISSAAT);
        this.dateEdit2.EditValue = (object) ise.CIKISTARIH;
        this.cikissaat.EditValue = (object) ise.CIKISSAAT;
        this.aracigetiren.Text = ise.ARACIGETIREN;
        this.arizanedeni.EditValue = (object) Convert.ToInt32((object) ise.ARIZANEDENIID);
        this.bildirilenariza.Text = ise.BILDIRILENARIZA;
        this.isemirturu.EditValue = (object) Convert.ToInt32((object) ise.ISEMRIDURUMID);
        this.bakimyeri.EditValue = (object) ise.BAKIMYERIID.ToString();
        this.aracigetiren.Text = ise.ARACIGETIREN;
        this.bakimKMsaat.Text = ise.BAKIMKMSI;
        this.atolyesefi.EditValue = (object) ise.IMZAATOLYESEFID;
        this.bakimturu.SelectedIndex = Convert.ToInt32(ise.BAKIMTURUID);
        this.bakimturu.SelectedIndex = Convert.ToInt32(ise.BAKIMDERECESIID);
        this.atikyagTxt.Text = ise.ATIKYAG.ToString();
        int arac_id = Convert.ToInt32((object) ise.ARACID);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        this.genelbakim.Text = tblaraclar.GENELBAKIMKM;
        this.motoryag.Text = tblaraclar.MOTORYAGKM;
        this.difransiyelyag.Text = tblaraclar.DIFERANSIYELYAGKM;
        this.sanzimanyag.Text = tblaraclar.SANZIMANYAGKM;
        this.HidrolikYagTxt.Text = tblaraclar.HIDROLIKYAGKM;
      }
      catch (Exception ex)
      {
      }
      try
      {
        DegerAktarma.list.Clear();
        DbSet<TBLISEMRIBAKIMLAR> tblisemribakimlar1 = this.db.TBLISEMRIBAKIMLAR;
        Expression<System.Func<TBLISEMRIBAKIMLAR, bool>> predicate = (Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (hd => hd.ISEMRIID == (int?) ise.ID);
        foreach (TBLISEMRIBAKIMLAR tblisemribakimlar2 in (IEnumerable<TBLISEMRIBAKIMLAR>) tblisemribakimlar1.Where<TBLISEMRIBAKIMLAR>(predicate))
        {
          BindingList<Makina_Ikmal.Classlar.ElemanlarDurum> list = DegerAktarma.list;
          Makina_Ikmal.Classlar.ElemanlarDurum elemanlarDurum = new Makina_Ikmal.Classlar.ElemanlarDurum();
          elemanlarDurum.ID = tblisemribakimlar2.ID;
          int? nullable = tblisemribakimlar2.ATOLYEID;
          elemanlarDurum.ATOLYEID = nullable.ToString();
          nullable = tblisemribakimlar2.BAKIMYAPUSTAID;
          elemanlarDurum.BAKIMYAPUSTAID = nullable.ToString();
          nullable = tblisemribakimlar2.BAKIMGRUBUID;
          elemanlarDurum.BAKIMGRUBUID = nullable.ToString();
          elemanlarDurum.YAPILANBAKIM = tblisemribakimlar2.YAPILANBAKIM;
          list.Add(elemanlarDurum);
        }
        this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new Ustalar().ShowDialog();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new YagBakim3()).ShowPreviewDialog();

    public void tetikle()
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
    }

    private void gridView6_ValidateRow(object sender, ValidateRowEventArgs e)
    {
      if (this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, this.gridView1.FocusedColumn) != null)
        return;
      if (this.gridView1.IsValidRowHandle(e.RowHandle))
        this.gridView1.DeleteRow(e.RowHandle);
      e.Valid = true;
    }

    private void simpleButton1_Click_1(object sender, EventArgs e)
    {
      int num = (int) new Ustalar().ShowDialog();
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      YagBakim2 yagBakim2 = new YagBakim2();
      yagBakim2.Parameters["bariza"].Value = (object) this.gridView6.GetRowCellDisplayText(0, "BAKIMYAPUSTAID");
      yagBakim2.Parameters["bariza"].Visible = false;
      yagBakim2.Parameters["sofor"].Value = (object) this.aracigetiren.Text;
      yagBakim2.Parameters["sofor"].Visible = false;
      yagBakim2.Parameters["atolyesef"].Value = (object) this.atolyesefi.Text;
      yagBakim2.Parameters["atolyesef"].Visible = false;
      yagBakim2.Parameters["id"].Value = (object) YetkiClass.secim_id;
      yagBakim2.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) yagBakim2).ShowPreviewDialog();
    }

    private void simpleButton1_Click_2(object sender, EventArgs e)
    {
      int num = (int) new Ustalar2().ShowDialog();
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.gridView6.GetFocusedRowCellValue("ID")) == 0 || this.gridView6.GetFocusedRowCellValue("ID") == null)
      {
        this.gridView1.DeleteSelectedRows();
        string id2 = Convert.ToString(this.gridView6.GetFocusedRowCellValue("BAKIMYAPUSTAID"));
        Makina_Ikmal.Classlar.ElemanlarDurum elemanlarDurum = DegerAktarma.list.FirstOrDefault<Makina_Ikmal.Classlar.ElemanlarDurum>((System.Func<Makina_Ikmal.Classlar.ElemanlarDurum, bool>) (x => x.BAKIMYAPUSTAID == id2));
        DegerAktarma.list.Remove(elemanlarDurum);
        this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
      }
      else
      {
        int id = Convert.ToInt32(this.gridView6.GetFocusedRowCellValue("ID"));
        this.db.TBLISEMRIBAKIMLAR.Remove(this.db.TBLISEMRIBAKIMLAR.FirstOrDefault<TBLISEMRIBAKIMLAR>((Expression<System.Func<TBLISEMRIBAKIMLAR, bool>>) (x => x.ID == id)));
        this.db.SaveChanges();
        this.guncelleload();
      }
    }

    private void plakaCombo_EditValueChanged(object sender, EventArgs e)
    {
      try
      {
        int tmp = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR arac = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == tmp));
        int? aractipiid = arac.ARACTIPIID;
        int num1 = 2;
        if (!(aractipiid.GetValueOrDefault() == num1 & aractipiid.HasValue))
        {
          this.textEdit8.EditValue = (object) arac.BELDMUDURLUKID;
          this.birimCombo.EditValue = (object) arac.BELDBIRIMID;
          this.textEdit9.EditValue = (object) arac.ARACKULPERSID;
          this.aracigetiren.Text = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => (int?) x.ID == arac.ARACKULPERSID)).ADISOYADI;
          this.textEdit3.Text = arac.ARACACIKLAMA;
        }
        else
        {
          this.plakaCombo.EditValue = (object) null;
          int num2 = (int) XtraMessageBox.Show("Bu aracın iş emri alma yetkisi yoktur!");
        }
      }
      catch (Exception ex)
      {
      }
    }

    private void searchLookUpEdit1View_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
    }

    private void isemirturu_EditValueChanged(object sender, EventArgs e)
    {
      if (!(this.isemirturu.Text == "Teslim Edildi"))
        return;
      this.dateEdit2.EditValue = (object) DateTime.Now;
      this.cikissaat.EditValue = (object) DateTime.Now;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (YagEmri));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.araclarListesi = new AraclarListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.HidrolikYagTxt = new TextEdit();
      this.atikyagTxt = new TextEdit();
      this.cikissaat = new TimeEdit();
      this.girissaat = new TimeEdit();
      this.genelbakim = new TextEdit();
      this.dateEdit2 = new DateEdit();
      this.dateEdit1 = new DateEdit();
      this.isemirkodu = new TextEdit();
      this.aracigetiren = new TextEdit();
      this.difransiyelyag = new TextEdit();
      this.bakimKMsaat = new TextEdit();
      this.plakaCombo = new SearchLookUpEdit();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.textEdit3 = new MemoEdit();
      this.birimCombo = new SearchLookUpEdit();
      this.gridView1 = new GridView();
      this.textEdit8 = new SearchLookUpEdit();
      this.gridView2 = new GridView();
      this.textEdit9 = new SearchLookUpEdit();
      this.gridView3 = new GridView();
      this.bildirilenariza = new MemoEdit();
      this.motoryag = new TextEdit();
      this.sanzimanyag = new TextEdit();
      this.bakimozeti = new MemoEdit();
      this.bakimturu = new ComboBoxEdit();
      this.bakimyeri = new LookUpEdit();
      this.tBLBAKIMYERIBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.isemirturu = new LookUpEdit();
      this.tBLISEMIRDURUMBindingSource = new BindingSource(this.components);
      this.atolyesefi = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.arizanedeni = new LookUpEdit();
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.difransiyel = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.simpleLabelItem1 = new SimpleLabelItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.simpleButton2 = new SimpleButton();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.tBLATOLYEBOLUMTableAdapter = new Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEBOLUMTableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEUSTALARTableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new Makina_Ikmal.bellDataSet1TableAdapters.TBLBAKIMGRUBUTableAdapter();
      this.panelControl2 = new PanelControl();
      this.panelControl4 = new PanelControl();
      this.gridControl2 = new GridControl();
      this.gridView6 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.gridColumn4 = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.gridColumn5 = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.gridColumn6 = new GridColumn();
      this.panelControl3 = new PanelControl();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.tBLISEMIRDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMIRDURUMTableAdapter();
      this.tBLBAKIMYERITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBAKIMYERITableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter();
      this.tAHARIZANEDENITableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TAHARIZANEDENITableAdapter();
      this.ribbonControl1.BeginInit();
      this.araclarListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.HidrolikYagTxt.Properties.BeginInit();
      this.atikyagTxt.Properties.BeginInit();
      this.cikissaat.Properties.BeginInit();
      this.girissaat.Properties.BeginInit();
      this.genelbakim.Properties.BeginInit();
      this.dateEdit2.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit2.Properties.BeginInit();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.isemirkodu.Properties.BeginInit();
      this.aracigetiren.Properties.BeginInit();
      this.difransiyelyag.Properties.BeginInit();
      this.bakimKMsaat.Properties.BeginInit();
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
      this.bakimyeri.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.isemirturu.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).BeginInit();
      this.atolyesefi.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.arizanedeni.Properties.BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.difransiyel.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.simpleLabelItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.emptySpaceItem1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.panelControl4.BeginInit();
      this.panelControl4.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView6.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.panelControl3.BeginInit();
      this.panelControl3.SuspendLayout();
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
        (BarItem) this.barButtonItem2,
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
      this.ribbonControl1.Size = new Size(1270, 122);
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
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem5.Caption = "Bos Forum";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) Resources.printarea_16x16;
      this.barButtonItem5.ImageOptions.LargeImage = (Image) Resources.printarea_32x32;
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
      this.layoutControl1.Controls.Add((Control) this.HidrolikYagTxt);
      this.layoutControl1.Controls.Add((Control) this.atikyagTxt);
      this.layoutControl1.Controls.Add((Control) this.cikissaat);
      this.layoutControl1.Controls.Add((Control) this.girissaat);
      this.layoutControl1.Controls.Add((Control) this.genelbakim);
      this.layoutControl1.Controls.Add((Control) this.dateEdit2);
      this.layoutControl1.Controls.Add((Control) this.dateEdit1);
      this.layoutControl1.Controls.Add((Control) this.isemirkodu);
      this.layoutControl1.Controls.Add((Control) this.aracigetiren);
      this.layoutControl1.Controls.Add((Control) this.difransiyelyag);
      this.layoutControl1.Controls.Add((Control) this.bakimKMsaat);
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
      this.layoutControl1.Controls.Add((Control) this.bakimyeri);
      this.layoutControl1.Controls.Add((Control) this.isemirturu);
      this.layoutControl1.Controls.Add((Control) this.atolyesefi);
      this.layoutControl1.Controls.Add((Control) this.arizanedeni);
      this.layoutControl1.Dock = DockStyle.Top;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1108, 138, 812, 500));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1270, 325);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.HidrolikYagTxt.Location = new Point(1098, 285);
      this.HidrolikYagTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.HidrolikYagTxt.Name = "HidrolikYagTxt";
      this.HidrolikYagTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.HidrolikYagTxt.Properties.Appearance.Options.UseFont = true;
      this.HidrolikYagTxt.Size = new Size(160, 28);
      this.HidrolikYagTxt.StyleController = (IStyleController) this.layoutControl1;
      this.HidrolikYagTxt.TabIndex = 45;
      this.atikyagTxt.Location = new Point(802, 253);
      this.atikyagTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atikyagTxt.Name = "atikyagTxt";
      this.atikyagTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atikyagTxt.Properties.Appearance.Options.UseFont = true;
      this.atikyagTxt.Size = new Size(177, 28);
      this.atikyagTxt.StyleController = (IStyleController) this.layoutControl1;
      this.atikyagTxt.TabIndex = 44;
      this.cikissaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.cikissaat.Location = new Point(532, 189);
      this.cikissaat.Margin = new Padding(3, 2, 3, 2);
      this.cikissaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikissaat.Name = "cikissaat";
      this.cikissaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cikissaat.Properties.Appearance.Options.UseFont = true;
      this.cikissaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikissaat.Size = new Size(447, 28);
      this.cikissaat.StyleController = (IStyleController) this.layoutControl1;
      this.cikissaat.TabIndex = 43;
      this.girissaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.girissaat.Location = new Point(532, 157);
      this.girissaat.Margin = new Padding(3, 2, 3, 2);
      this.girissaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.girissaat.Name = "girissaat";
      this.girissaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girissaat.Properties.Appearance.Options.UseFont = true;
      this.girissaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girissaat.Size = new Size(447, 28);
      this.girissaat.StyleController = (IStyleController) this.layoutControl1;
      this.girissaat.TabIndex = 42;
      this.genelbakim.Location = new Point(1100, 155);
      this.genelbakim.Margin = new Padding(3, 2, 3, 2);
      this.genelbakim.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelbakim.Name = "genelbakim";
      this.genelbakim.Properties.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelbakim.Properties.Appearance.Options.UseFont = true;
      this.genelbakim.Properties.Mask.EditMask = "n0";
      this.genelbakim.Properties.Mask.MaskType = MaskType.Numeric;
      this.genelbakim.Size = new Size(158, 28);
      this.genelbakim.StyleController = (IStyleController) this.layoutControl1;
      this.genelbakim.TabIndex = 40;
      this.dateEdit2.EditValue = (object) null;
      this.dateEdit2.Location = new Point(134, 189);
      this.dateEdit2.Margin = new Padding(3, 2, 3, 2);
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
      this.dateEdit2.Size = new Size(289, 26);
      this.dateEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit2.TabIndex = 34;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(134, 157);
      this.dateEdit1.Margin = new Padding(3, 2, 3, 2);
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
      this.dateEdit1.Size = new Size(289, 26);
      this.dateEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit1.TabIndex = 33;
      this.isemirkodu.Location = new Point(134, (int) sbyte.MaxValue);
      this.isemirkodu.Margin = new Padding(3, 2, 3, 2);
      this.isemirkodu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemirkodu.Name = "isemirkodu";
      this.isemirkodu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemirkodu.Properties.Appearance.Options.UseFont = true;
      this.isemirkodu.Size = new Size(289, 26);
      this.isemirkodu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirkodu.TabIndex = 8;
      this.aracigetiren.Location = new Point(134, 42);
      this.aracigetiren.Margin = new Padding(3, 2, 3, 2);
      this.aracigetiren.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracigetiren.Name = "aracigetiren";
      this.aracigetiren.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracigetiren.Properties.Appearance.Options.UseFont = true;
      this.aracigetiren.Size = new Size(289, 26);
      this.aracigetiren.StyleController = (IStyleController) this.layoutControl1;
      this.aracigetiren.TabIndex = 13;
      this.difransiyelyag.Location = new Point(1100, 223);
      this.difransiyelyag.Margin = new Padding(3, 2, 3, 2);
      this.difransiyelyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.difransiyelyag.Name = "difransiyelyag";
      this.difransiyelyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyelyag.Properties.Appearance.Options.UseFont = true;
      this.difransiyelyag.Properties.Mask.EditMask = "n0";
      this.difransiyelyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.difransiyelyag.Size = new Size(158, 26);
      this.difransiyelyag.StyleController = (IStyleController) this.layoutControl1;
      this.difransiyelyag.TabIndex = 20;
      this.bakimKMsaat.Location = new Point(134, 223);
      this.bakimKMsaat.Margin = new Padding(3, 2, 3, 2);
      this.bakimKMsaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimKMsaat.Name = "bakimKMsaat";
      this.bakimKMsaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimKMsaat.Properties.Appearance.Options.UseFont = true;
      this.bakimKMsaat.Properties.Mask.EditMask = "n0";
      this.bakimKMsaat.Properties.Mask.MaskType = MaskType.Numeric;
      this.bakimKMsaat.Size = new Size(289, 26);
      this.bakimKMsaat.StyleController = (IStyleController) this.layoutControl1;
      this.bakimKMsaat.TabIndex = 21;
      this.plakaCombo.Location = new Point(135, 12);
      this.plakaCombo.Margin = new Padding(3, 2, 3, 2);
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
      this.plakaCombo.Size = new Size(288, 26);
      this.plakaCombo.StyleController = (IStyleController) this.layoutControl1;
      this.plakaCombo.TabIndex = 4;
      this.plakaCombo.EditValueChanged += new EventHandler(this.plakaCombo_EditValueChanged);
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
      this.searchLookUpEdit1View.CellValueChanged += new CellValueChangedEventHandler(this.searchLookUpEdit1View_CellValueChanged);
      this.gridColumn1.Caption = "Plaka";
      this.gridColumn1.FieldName = "PLAKA";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.textEdit3.Location = new Point(134, 72);
      this.textEdit3.Margin = new Padding(3, 2, 3, 2);
      this.textEdit3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit3.Name = "textEdit3";
      this.textEdit3.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit3.Properties.Appearance.Options.UseFont = true;
      this.textEdit3.Properties.ScrollBars = ScrollBars.None;
      this.textEdit3.Size = new Size(1124, 51);
      this.textEdit3.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit3.TabIndex = 6;
      this.birimCombo.Enabled = false;
      this.birimCombo.Location = new Point(944, 12);
      this.birimCombo.Margin = new Padding(3, 2, 3, 2);
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
      this.birimCombo.Size = new Size(314, 26);
      this.birimCombo.StyleController = (IStyleController) this.layoutControl1;
      this.birimCombo.TabIndex = 5;
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.textEdit8.Location = new Point(529, 12);
      this.textEdit8.Margin = new Padding(3, 2, 3, 2);
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
      this.textEdit8.Size = new Size(309, 26);
      this.textEdit8.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit8.TabIndex = 11;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.textEdit9.Enabled = false;
      this.textEdit9.Location = new Point(529, 42);
      this.textEdit9.Margin = new Padding(3, 2, 3, 2);
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
      this.textEdit9.Size = new Size(309, 26);
      this.textEdit9.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit9.TabIndex = 12;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.bildirilenariza.Location = new Point(134, 285);
      this.bildirilenariza.Margin = new Padding(3, 2, 3, 2);
      this.bildirilenariza.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bildirilenariza.Name = "bildirilenariza";
      this.bildirilenariza.Properties.ScrollBars = ScrollBars.None;
      this.bildirilenariza.Size = new Size(289, 28);
      this.bildirilenariza.StyleController = (IStyleController) this.layoutControl1;
      this.bildirilenariza.TabIndex = 19;
      this.motoryag.Location = new Point(1100, 189);
      this.motoryag.Margin = new Padding(3, 2, 3, 2);
      this.motoryag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motoryag.Name = "motoryag";
      this.motoryag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motoryag.Properties.Appearance.Options.UseFont = true;
      this.motoryag.Properties.Mask.EditMask = "n0";
      this.motoryag.Properties.Mask.MaskType = MaskType.Numeric;
      this.motoryag.Size = new Size(158, 26);
      this.motoryag.StyleController = (IStyleController) this.layoutControl1;
      this.motoryag.TabIndex = 31;
      this.sanzimanyag.Location = new Point(1100, 253);
      this.sanzimanyag.Margin = new Padding(3, 2, 3, 2);
      this.sanzimanyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sanzimanyag.Name = "sanzimanyag";
      this.sanzimanyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sanzimanyag.Properties.Appearance.Options.UseFont = true;
      this.sanzimanyag.Properties.Mask.EditMask = "n0";
      this.sanzimanyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.sanzimanyag.Size = new Size(158, 26);
      this.sanzimanyag.StyleController = (IStyleController) this.layoutControl1;
      this.sanzimanyag.TabIndex = 32;
      this.bakimozeti.Location = new Point(532, 285);
      this.bakimozeti.Margin = new Padding(3, 2, 3, 2);
      this.bakimozeti.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimozeti.Name = "bakimozeti";
      this.bakimozeti.Properties.ScrollBars = ScrollBars.None;
      this.bakimozeti.Size = new Size(447, 28);
      this.bakimozeti.StyleController = (IStyleController) this.layoutControl1;
      this.bakimozeti.TabIndex = 30;
      this.bakimturu.Location = new Point(532, 223);
      this.bakimturu.Margin = new Padding(3, 2, 3, 2);
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
      this.bakimturu.Size = new Size(447, 26);
      this.bakimturu.StyleController = (IStyleController) this.layoutControl1;
      this.bakimturu.TabIndex = 26;
      this.bakimyeri.Location = new Point(532, (int) sbyte.MaxValue);
      this.bakimyeri.Margin = new Padding(3, 2, 3, 2);
      this.bakimyeri.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimyeri.Name = "bakimyeri";
      this.bakimyeri.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimyeri.Properties.Appearance.Options.UseFont = true;
      this.bakimyeri.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimyeri.Properties.DataSource = (object) this.tBLBAKIMYERIBindingSource;
      this.bakimyeri.Properties.DisplayMember = "ADI";
      this.bakimyeri.Properties.NullText = "";
      this.bakimyeri.Properties.ValueMember = "ID";
      this.bakimyeri.Size = new Size(447, 26);
      this.bakimyeri.StyleController = (IStyleController) this.layoutControl1;
      this.bakimyeri.TabIndex = 14;
      this.tBLBAKIMYERIBindingSource.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.isemirturu.Location = new Point(134, 253);
      this.isemirturu.Margin = new Padding(3, 2, 3, 2);
      this.isemirturu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemirturu.Name = "isemirturu";
      this.isemirturu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemirturu.Properties.Appearance.Options.UseFont = true;
      this.isemirturu.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isemirturu.Properties.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.isemirturu.Properties.DisplayMember = "ADI";
      this.isemirturu.Properties.NullText = "";
      this.isemirturu.Properties.PopupSizeable = false;
      this.isemirturu.Properties.ValueMember = "ID";
      this.isemirturu.Size = new Size(289, 26);
      this.isemirturu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirturu.TabIndex = 22;
      this.isemirturu.EditValueChanged += new EventHandler(this.isemirturu_EditValueChanged);
      this.tBLISEMIRDURUMBindingSource.DataMember = "TBLISEMIRDURUM";
      this.tBLISEMIRDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.atolyesefi.Location = new Point(944, 42);
      this.atolyesefi.Margin = new Padding(3, 2, 3, 2);
      this.atolyesefi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyesefi.Name = "atolyesefi";
      this.atolyesefi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyesefi.Properties.Appearance.Options.UseFont = true;
      this.atolyesefi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyesefi.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADISOYADI", "Adı Soyadı", 23, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.atolyesefi.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.atolyesefi.Properties.DisplayMember = "ADISOYADI";
      this.atolyesefi.Properties.NullText = "";
      this.atolyesefi.Properties.ValueMember = "ID";
      this.atolyesefi.Size = new Size(314, 26);
      this.atolyesefi.StyleController = (IStyleController) this.layoutControl1;
      this.atolyesefi.TabIndex = 28;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.arizanedeni.Location = new Point(530, 253);
      this.arizanedeni.Margin = new Padding(3, 2, 3, 2);
      this.arizanedeni.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.arizanedeni.Name = "arizanedeni";
      this.arizanedeni.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.arizanedeni.Properties.Appearance.Options.UseFont = true;
      this.arizanedeni.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizanedeni.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ARIZANEDENI", "Arız Nedeni")
      });
      this.arizanedeni.Properties.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.arizanedeni.Properties.DisplayMember = "ARIZANEDENI";
      this.arizanedeni.Properties.NullText = "";
      this.arizanedeni.Properties.PopupSizeable = false;
      this.arizanedeni.Properties.ValueMember = "ID";
      this.arizanedeni.Size = new Size(175, 28);
      this.arizanedeni.StyleController = (IStyleController) this.layoutControl1;
      this.arizanedeni.TabIndex = 24;
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.bellDataSet7;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[26]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.difransiyel,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.simpleLabelItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem13
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1270, 325);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.plakaCombo;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem1.Size = new Size(415, 30);
      this.layoutControlItem1.Text = "Araç Plaka";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(118, 21);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.isemirturu;
      this.layoutControlItem19.Location = new Point(0, 241);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem19.Size = new Size(415, 32);
      this.layoutControlItem19.Text = "İş Emir Durum";
      this.layoutControlItem19.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem19.TextSize = new Size(120, 16);
      this.layoutControlItem19.TextToControlDistance = 2;
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.textEdit9;
      this.layoutControlItem9.Location = new Point(415, 30);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(415, 30);
      this.layoutControlItem9.Text = "Araç Şoförü";
      this.layoutControlItem9.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem9.TextSize = new Size(100, 20);
      this.layoutControlItem9.TextToControlDistance = 2;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.isemirkodu;
      this.layoutControlItem5.Location = new Point(0, 115);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(415, 30);
      this.layoutControlItem5.Text = "İş Emir Kodu";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem5.TextSize = new Size(120, 16);
      this.layoutControlItem5.TextToControlDistance = 2;
      this.difransiyel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyel.AppearanceItemCaption.Options.UseFont = true;
      this.difransiyel.Control = (Control) this.difransiyelyag;
      this.difransiyel.Location = new Point(971, 211);
      this.difransiyel.Name = "difransiyel";
      this.difransiyel.Size = new Size(279, 30);
      this.difransiyel.Text = "Difrensiyel Yağ";
      this.difransiyel.TextAlignMode = TextAlignModeItem.CustomSize;
      this.difransiyel.TextSize = new Size(115, 16);
      this.difransiyel.TextToControlDistance = 2;
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.bakimKMsaat;
      this.layoutControlItem18.Location = new Point(0, 211);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(415, 30);
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
      this.layoutControlItem3.Size = new Size(1250, 55);
      this.layoutControlItem3.Text = "Araç Açıklama";
      this.layoutControlItem3.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem3.TextSize = new Size(120, 16);
      this.layoutControlItem3.TextToControlDistance = 2;
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.bildirilenariza;
      this.layoutControlItem16.Location = new Point(0, 273);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem16.Size = new Size(415, 32);
      this.layoutControlItem16.Text = "Bildirilen Arıza";
      this.layoutControlItem16.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem16.TextSize = new Size(120, 16);
      this.layoutControlItem16.TextToControlDistance = 2;
      this.simpleLabelItem1.AllowHotTrack = false;
      this.simpleLabelItem1.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
      this.simpleLabelItem1.Location = new Point(971, 115);
      this.simpleLabelItem1.Name = "simpleLabelItem1";
      this.simpleLabelItem1.Size = new Size(279, 28);
      this.simpleLabelItem1.Text = "Sonraki Bakım Km Bilgisi";
      this.simpleLabelItem1.TextSize = new Size(252, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.motoryag;
      this.layoutControlItem4.Location = new Point(971, 177);
      this.layoutControlItem4.MinSize = new Size(181, 34);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(279, 34);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Motor Yağ";
      this.layoutControlItem4.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem4.TextSize = new Size(115, 16);
      this.layoutControlItem4.TextToControlDistance = 2;
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.sanzimanyag;
      this.layoutControlItem12.Location = new Point(971, 241);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(279, 32);
      this.layoutControlItem12.Text = "Şanzıman Yağ";
      this.layoutControlItem12.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem12.TextSize = new Size(115, 16);
      this.layoutControlItem12.TextToControlDistance = 2;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.dateEdit1;
      this.layoutControlItem20.Location = new Point(0, 145);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(415, 32);
      this.layoutControlItem20.Text = "Giriş Tarihi";
      this.layoutControlItem20.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem20.TextSize = new Size(120, 16);
      this.layoutControlItem20.TextToControlDistance = 2;
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.dateEdit2;
      this.layoutControlItem6.Location = new Point(0, 177);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(415, 34);
      this.layoutControlItem6.Text = "Çıkış Tarihi";
      this.layoutControlItem6.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem6.TextSize = new Size(120, 16);
      this.layoutControlItem6.TextToControlDistance = 2;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.genelbakim;
      this.layoutControlItem14.Location = new Point(971, 143);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(279, 34);
      this.layoutControlItem14.Text = "Genek Bakım";
      this.layoutControlItem14.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem14.TextSize = new Size(115, 16);
      this.layoutControlItem14.TextToControlDistance = 2;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.textEdit8;
      this.layoutControlItem8.Location = new Point(415, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(415, 30);
      this.layoutControlItem8.Text = "Müdürlük";
      this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem8.TextSize = new Size(100, 20);
      this.layoutControlItem8.TextToControlDistance = 2;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.aracigetiren;
      this.layoutControlItem10.Location = new Point(0, 30);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(415, 30);
      this.layoutControlItem10.Text = "Araçı Getiren";
      this.layoutControlItem10.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem10.TextSize = new Size(120, 16);
      this.layoutControlItem10.TextToControlDistance = 2;
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.bakimozeti;
      this.layoutControlItem27.Location = new Point(415, 273);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(556, 32);
      this.layoutControlItem27.Text = "Bakım Özeti";
      this.layoutControlItem27.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem27.TextSize = new Size(100, 16);
      this.layoutControlItem27.TextToControlDistance = 5;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.birimCombo;
      this.layoutControlItem2.Location = new Point(830, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(420, 30);
      this.layoutControlItem2.Text = "Birim";
      this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem2.TextSize = new Size(100, 16);
      this.layoutControlItem2.TextToControlDistance = 2;
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.atolyesefi;
      this.layoutControlItem25.Location = new Point(830, 30);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(420, 30);
      this.layoutControlItem25.Text = "Atölye Şefi";
      this.layoutControlItem25.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem25.TextSize = new Size(100, 16);
      this.layoutControlItem25.TextToControlDistance = 2;
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.Control = (Control) this.arizanedeni;
      this.layoutControlItem21.Location = new Point(415, 241);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem21.Size = new Size(282, 32);
      this.layoutControlItem21.Text = "Arıza nedeni";
      this.layoutControlItem21.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem21.TextSize = new Size(101, 16);
      this.layoutControlItem21.TextToControlDistance = 2;
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.girissaat;
      this.layoutControlItem15.Location = new Point(415, 145);
      this.layoutControlItem15.MinSize = new Size(321, 32);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(556, 32);
      this.layoutControlItem15.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem15.Text = "Giriş Saati";
      this.layoutControlItem15.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem15.TextLocation = Locations.Left;
      this.layoutControlItem15.TextSize = new Size(100, 20);
      this.layoutControlItem15.TextToControlDistance = 5;
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.cikissaat;
      this.layoutControlItem17.Location = new Point(415, 177);
      this.layoutControlItem17.MinSize = new Size(169, 34);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.Size = new Size(556, 34);
      this.layoutControlItem17.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem17.Text = "Çıkış Saati";
      this.layoutControlItem17.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem17.TextSize = new Size(100, 20);
      this.layoutControlItem17.TextToControlDistance = 5;
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.bakimyeri;
      this.layoutControlItem11.Location = new Point(415, 115);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(556, 30);
      this.layoutControlItem11.Text = "Bakım  Yeri";
      this.layoutControlItem11.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem11.TextSize = new Size(100, 16);
      this.layoutControlItem11.TextToControlDistance = 5;
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.bakimturu;
      this.layoutControlItem23.Location = new Point(415, 211);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem23.Size = new Size(556, 30);
      this.layoutControlItem23.Text = "Bakım Türü";
      this.layoutControlItem23.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem23.TextSize = new Size(100, 16);
      this.layoutControlItem23.TextToControlDistance = 5;
      this.layoutControlItem7.Control = (Control) this.atikyagTxt;
      this.layoutControlItem7.Location = new Point(697, 241);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem7.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem7.Size = new Size(274, 32);
      this.layoutControlItem7.Text = "Atık Yağ";
      this.layoutControlItem7.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem7.TextSize = new Size(90, 25);
      this.layoutControlItem7.TextToControlDistance = 3;
      this.layoutControlItem13.Control = (Control) this.HidrolikYagTxt;
      this.layoutControlItem13.Location = new Point(971, 273);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem13.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem13.Size = new Size(279, 32);
      this.layoutControlItem13.Text = "Hidrolik Yağ";
      this.layoutControlItem13.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem13.TextSize = new Size(70, 20);
      this.layoutControlItem13.TextToControlDistance = 45;
      this.simpleButton2.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.Font = new Font("Tahoma", 16.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton2.Appearance.Options.UseBackColor = true;
      this.simpleButton2.Appearance.Options.UseBorderColor = true;
      this.simpleButton2.Appearance.Options.UseFont = true;
      this.simpleButton2.Appearance.Options.UseTextOptions = true;
      this.simpleButton2.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.simpleButton2.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(-17, 181);
      this.simpleButton2.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(66, 62);
      this.simpleButton2.TabIndex = 49;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet1;
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet1;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.panelControl2.Controls.Add((Control) this.panelControl4);
      this.panelControl2.Controls.Add((Control) this.panelControl3);
      this.panelControl2.Controls.Add((Control) this.simpleButton2);
      this.panelControl2.Dock = DockStyle.Bottom;
      this.panelControl2.Location = new Point(0, 449);
      this.panelControl2.Margin = new Padding(3, 2, 3, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(1270, 351);
      this.panelControl2.TabIndex = 6;
      this.panelControl4.Controls.Add((Control) this.gridControl2);
      this.panelControl4.Dock = DockStyle.Top;
      this.panelControl4.Location = new Point(63, 2);
      this.panelControl4.Margin = new Padding(3, 2, 3, 2);
      this.panelControl4.Name = "panelControl4";
      this.panelControl4.Size = new Size(1205, 256);
      this.panelControl4.TabIndex = 1;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Location = new Point(2, 2);
      this.gridControl2.MainView = (BaseView) this.gridView6;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit3
      });
      this.gridControl2.Size = new Size(1201, 252);
      this.gridControl2.TabIndex = 5;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView6
      });
      this.gridView6.Appearance.GroupPanel.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView6.Appearance.GroupPanel.Options.UseFont = true;
      this.gridView6.Columns.AddRange(new GridColumn[5]
      {
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6
      });
      this.gridView6.GridControl = this.gridControl2;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsView.AllowHtmlDrawGroups = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.FieldName = "ID";
      this.gridColumn2.MinWidth = 23;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Width = 87;
      this.gridColumn3.Caption = "Atölye";
      this.gridColumn3.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn3.FieldName = "ATOLYEID";
      this.gridColumn3.MinWidth = 23;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 87;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.gridColumn4.Caption = "Usta";
      this.gridColumn4.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.gridColumn4.FieldName = "BAKIMYAPUSTAID";
      this.gridColumn4.MinWidth = 23;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 1;
      this.gridColumn4.Width = 87;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.repositoryItemLookUpEdit2.DisplayMember = "USTAADISOYADI";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.NullText = "";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.gridColumn5.Caption = "Bakım Grubu";
      this.gridColumn5.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.gridColumn5.FieldName = "BAKIMGRUBUID";
      this.gridColumn5.MinWidth = 23;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 2;
      this.gridColumn5.Width = 87;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.repositoryItemLookUpEdit3.DisplayMember = "GRUPADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.gridColumn6.Caption = "Yapılan Bakım";
      this.gridColumn6.FieldName = "YAPILANBAKIM";
      this.gridColumn6.MinWidth = 23;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 3;
      this.gridColumn6.Width = 87;
      this.panelControl3.Controls.Add((Control) this.simpleButton3);
      this.panelControl3.Controls.Add((Control) this.simpleButton1);
      this.panelControl3.Dock = DockStyle.Left;
      this.panelControl3.Location = new Point(2, 2);
      this.panelControl3.Margin = new Padding(3, 2, 3, 2);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new Size(61, 347);
      this.panelControl3.TabIndex = 0;
      this.simpleButton3.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton3.Appearance.Options.UseBackColor = true;
      this.simpleButton3.Appearance.Options.UseBorderColor = true;
      this.simpleButton3.Appearance.Options.UseFont = true;
      this.simpleButton3.AppearanceDisabled.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.AppearanceDisabled.Options.UseBorderColor = true;
      this.simpleButton3.AppearanceHovered.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton3.Location = new Point(-2, 96);
      this.simpleButton3.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(61, 85);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 50;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.simpleButton1.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton1.Appearance.Options.UseBackColor = true;
      this.simpleButton1.Appearance.Options.UseBorderColor = true;
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.AppearanceDisabled.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.AppearanceDisabled.Options.UseBorderColor = true;
      this.simpleButton1.AppearanceHovered.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(0, 5);
      this.simpleButton1.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(61, 85);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 49;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click_2);
      this.tBLISEMIRDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMYERITableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tAHARIZANEDENITableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1270, 800);
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (YagEmri);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Atölye Yağ Bölümü";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.araclarListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.HidrolikYagTxt.Properties.EndInit();
      this.atikyagTxt.Properties.EndInit();
      this.cikissaat.Properties.EndInit();
      this.girissaat.Properties.EndInit();
      this.genelbakim.Properties.EndInit();
      this.dateEdit2.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit2.Properties.EndInit();
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.isemirkodu.Properties.EndInit();
      this.aracigetiren.Properties.EndInit();
      this.difransiyelyag.Properties.EndInit();
      this.bakimKMsaat.Properties.EndInit();
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
      this.bakimyeri.Properties.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.isemirturu.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).EndInit();
      this.atolyesefi.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.arizanedeni.Properties.EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem5.EndInit();
      this.difransiyel.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem16.EndInit();
      this.simpleLabelItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem13.EndInit();
      this.emptySpaceItem1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl4.EndInit();
      this.panelControl4.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView6.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.panelControl3.EndInit();
      this.panelControl3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class Elemanlar
    {
      public string maladi { get; set; }

      public string aciklama { get; set; }

      public string birim { get; set; }

      public Decimal miktar { get; set; }

      public Decimal fiyat { get; set; }

      public Decimal tutar { get; set; }
    }

    public class ElemanlarDurum
    {
      public string Atolyeadı { get; set; }

      public string Usta { get; set; }

      public string bakimGrubu { get; set; }

      public string Yapilanbakim { get; set; }
    }
  }
}
