// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.EkleFormu
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
  public class EkleFormu : XtraForm
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
    private MemoEdit aracAciklamaTxt;
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
    private SearchLookUpEdit atolyesefi;
    private GridView gridView5;
    private BehaviorManager behaviorManager1;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private SimpleButton simpleButton2;
    private PanelControl panelControl1;
    private GridControl gridControl1;
    private GridView gridView4;
    private PanelControl panelControl2;
    private PanelControl panelControl4;
    public GridControl gridControl2;
    private GridView gridView6;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit usta;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private PanelControl panelControl3;
    private SimpleButton simpleButton1;
    private SimpleButton simpleButton3;
    private SearchControl searchControl1;
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
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private GridColumn gridColumn8;
    private LookUpEdit arizanedeni;
    private BindingSource tAHARIZANEDENIBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TAHARIZANEDENITableAdapter tAHARIZANEDENITableAdapter;

    public EkleFormu() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet7.TAHARIZANEDENI);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.isemirturu.EditValue = (object) 1;
      this.girissaat.EditValue = (object) DateTime.Now;
      this.dateEdit1.EditValue = (object) DateTime.Now;
      this.arizanedeni.EditValue = (object) "Genel Arıza";
      this.no.EditValue = (object) 999;
      this.dateEdit2.EditValue = (object) null;
      this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet5.TBLBAKIMYERI);
      this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet5.TBLISEMIRDURUM);
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet1.TBLBAKIMGRUBU);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet1.TBLATOLYEUSTALAR);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet1.TBLATOLYEBOLUM);
      this.atolyesefi.EditValue = (object) sorumlu.atolyesefi;
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
      this.atolyesefi.Properties.ValueMember = "ID";
      this.atolyesefi.Properties.DisplayMember = "ADISOYADI";
      this.atolyesefi.Properties.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.atolyesefi.EditValue = (object) sorumlu.atolyesefi;
      switch (YetkiClass.secim)
      {
        case "kayıt":
          this.isemirkodu.Text = this.son.isemirkod();
          break;
        case "guncelle":
          this.sonload();
          break;
      }
    }

    private void sonload()
    {
      this.guncelleload();
      try
      {
        TBLISEMRI ara = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.KOD == YetkiClass.secim_kodu));
        this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ISEMRIID == (int?) ara.ID));
        IQueryable<TBLTALEPFIS> queryable = this.db.TBLTALEPFIS.Where<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (hdx => hdx.ISEMRIID == (int?) ara.ID));
        BindingList<EkleFormu.Elemanlar> source1 = new BindingList<EkleFormu.Elemanlar>();
        foreach (TBLTALEPFIS tbltalepfis in (IEnumerable<TBLTALEPFIS>) queryable)
        {
          TBLTALEPFIS item = tbltalepfis;
          IQueryable<\u003C\u003Ef__AnonymousType23<\u003C\u003Ef__AnonymousType22<TBLTALEPFISHRKT, TBLMALZBIRIM>, TBLMALZEMELER>> source2 = this.db.TBLTALEPFISHRKT.Join((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, (Expression<System.Func<TBLTALEPFISHRKT, int?>>) (hd => hd.BIRIMID), (Expression<System.Func<TBLMALZBIRIM, int?>>) (y => (int?) y.ID), (hd, y) => new
          {
            hd = hd,
            y = y
          }).Join((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.hd.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (t => (int?) t.ID), (data, t) => new
          {
            \u003C\u003Eh__TransparentIdentifier0 = data,
            t = t
          }).Where(data => data.\u003C\u003Eh__TransparentIdentifier0.hd.TALEPFISID == (int?) item.ID);
          Expression<System.Func<\u003C\u003Ef__AnonymousType23<\u003C\u003Ef__AnonymousType22<TBLTALEPFISHRKT, TBLMALZBIRIM>, TBLMALZEMELER>, \u003C\u003Ef__AnonymousType24<string, string, string, Decimal?, Decimal?, Decimal?>>> selector = data => new
          {
            MALZEMEADI = data.t.MALZEMEADI,
            MALZACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier0.hd.MALZACIKLAMA,
            BIRIMADI = data.\u003C\u003Eh__TransparentIdentifier0.y.BIRIMADI,
            MIKTAR = data.\u003C\u003Eh__TransparentIdentifier0.hd.MIKTAR,
            FIYAT = data.\u003C\u003Eh__TransparentIdentifier0.hd.FIYAT,
            TUTAR = data.\u003C\u003Eh__TransparentIdentifier0.hd.TUTAR
          };
          foreach (var data in source2.Select(selector))
            source1.Add(new EkleFormu.Elemanlar()
            {
              maladi = data.MALZEMEADI,
              birim = data.BIRIMADI,
              miktar = Convert.ToDecimal((object) data.MIKTAR),
              fiyat = Convert.ToDecimal((object) data.FIYAT),
              tutar = Convert.ToDecimal((object) data.TUTAR)
            });
          this.gridControl1.DataSource = (object) source1.ToList<EkleFormu.Elemanlar>();
        }
      }
      catch (Exception ex)
      {
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
        this.aracAciklamaTxt.Text = tblaraclar.ARACACIKLAMA;
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
        string shortTimeString = Convert.ToDateTime(this.girissaat.Text).ToShortTimeString();
        entity.GIRISSAAT = new DateTime?(Convert.ToDateTime(shortTimeString));
        if (this.dateEdit2.Text != "")
          entity.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        if (this.cikissaat.Text != "00:00:00")
          entity.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.cikissaat.EditValue));
        entity.ARIZANEDENIID = new int?(Convert.ToInt32(this.arizanedeni.EditValue));
        entity.BILDIRILENARIZA = this.bildirilenariza.Text;
        entity.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isemirturu.EditValue));
        entity.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimyeri.EditValue));
        entity.ARACIGETIREN = this.aracigetiren.Text;
        entity.BAKIMKMSI = this.bakimKMsaat.Text;
        entity.ISEMRISIRANO = new int?(Convert.ToInt32(this.no.Text));
        entity.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyesefi.EditValue));
        entity.BAKIMTURUID = this.bakimturu.SelectedIndex.ToString();
        entity.BAKIMDERECESIID = this.bakimturu.SelectedIndex.ToString();
        int arac_id = Convert.ToInt32(this.plakaCombo.EditValue);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        tblaraclar.GENELBAKIMKM = this.genelbakim.Text;
        tblaraclar.MOTORYAGKM = this.motoryag.Text;
        entity.YAPILANBAKIMOZETI = this.bakimozeti.Text;
        tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        this.db.TBLISEMRI.Add(entity);
        this.db.SaveChanges();
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
        int num = (int) XtraMessageBox.Show("Kayıt Tamam");
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = int.Parse(this.db.TBLISEMRI.OrderByDescending<TBLISEMRI, int>((Expression<System.Func<TBLISEMRI, int>>) (p => p.ID)).Select<TBLISEMRI, int>((Expression<System.Func<TBLISEMRI, int>>) (r => r.ID)).First<int>().ToString());
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
        TBLISEMRI tblisemri1 = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == YetkiClass.secim_id));
        tblisemri1.ARACID = new int?(Convert.ToInt32(this.plakaCombo.EditValue));
        tblisemri1.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.EditValue));
        tblisemri1.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.girissaat.EditValue));
        if (this.dateEdit2.Text != "")
          tblisemri1.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.dateEdit2.EditValue));
        if (this.cikissaat.Text != "" && this.cikissaat.Text != "00:00:00")
        {
          try
          {
            tblisemri1.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.cikissaat.EditValue));
          }
          catch (Exception ex)
          {
          }
        }
        tblisemri1.ARIZANEDENIID = new int?(Convert.ToInt32(this.arizanedeni.EditValue));
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
        tblaraclar.MOTORYAGKM = this.motoryag.Text;
        tblaraclar.DIFERANSIYELYAGKM = this.difransiyelyag.Text;
        tblaraclar.SANZIMANYAGKM = this.sanzimanyag.Text;
        tblisemri1.YAPILANBAKIMOZETI = this.bakimozeti.Text;
        for (int rowHandle = 0; rowHandle < this.gridView6.DataRowCount; ++rowHandle)
        {
          if (Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ID")) == 0)
            this.db.TBLISEMRIBAKIMLAR.Add(new TBLISEMRIBAKIMLAR()
            {
              ISEMRIID = new int?(tblisemri1.ID),
              ATOLYEID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "ATOLYEID"))),
              BAKIMYAPUSTAID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMYAPUSTAID"))),
              BAKIMGRUBUID = new int?(Convert.ToInt32(this.gridView6.GetRowCellValue(rowHandle, "BAKIMGRUBUID"))),
              YAPILANBAKIM = this.gridView6.GetRowCellValue(rowHandle, "YAPILANBAKIM").ToString()
            });
          this.db.SaveChanges();
        }
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Guncelle başarlı bie şekilde gerçekleşti");
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
      this.listele();
      this.Close();
    }

    private void listele() => ((ilksayfa) Application.OpenForms["ilksayfa"])?.listele();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.secim == "guncelle" && YetkiClass.EkleYetki == 1)
      {
        this.guncelle();
        LogEkle.Logs("Guncelleme Yapti");
        this.listele();
        this.sonload();
      }
      else if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
      {
        this.kayit();
        LogEkle.Logs("Ekleme Yapti");
        this.listele();
        this.sonload();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Kayıt sırasında beklenmeyen bir hata geldi.");
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki != 1 || !(YetkiClass.menuyetki == "Hayır") || !(YetkiClass.secim == "guncelle") || XtraMessageBox.Show(" Silmek istediğinizden eminmisiniz", "UYARI", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.sil();
      LogEkle.Logs("Silme Yapti");
      this.Close();
    }

    private void guncelleload()
    {
      DegerAktarma.list.Clear();
      TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == YetkiClass.secim_id));
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
      try
      {
        this.isemirkodu.Text = ise.KOD;
        this.plakaCombo.EditValue = (object) ise.ARACID;
        this.dateEdit1.EditValue = (object) ise.GIRISTARIH;
        this.girissaat.EditValue = (object) Convert.ToDateTime((object) ise.GIRISSAAT);
        this.dateEdit2.EditValue = (object) ise.CIKISTARIH;
        this.cikissaat.EditValue = (object) ise.CIKISSAAT;
        this.aracigetiren.Text = ise.ARACIGETIREN;
        this.bakimozeti.Text = ise.YAPILANBAKIMOZETI;
        this.arizanedeni.EditValue = (object) Convert.ToInt32((object) ise.ARIZANEDENIID);
        this.bildirilenariza.Text = ise.BILDIRILENARIZA;
        this.isemirturu.EditValue = (object) Convert.ToInt32((object) ise.ISEMRIDURUMID);
        this.bakimyeri.EditValue = (object) ise.BAKIMYERIID.ToString();
        this.aracigetiren.Text = ise.ARACIGETIREN;
        this.bakimKMsaat.Text = ise.BAKIMKMSI;
        this.no.Text = ise.ISEMRISIRANO.ToString();
        this.atolyesefi.EditValue = (object) ise.IMZAATOLYESEFID;
        this.bakimturu.SelectedIndex = Convert.ToInt32(ise.BAKIMTURUID);
        this.bakimturu.SelectedIndex = Convert.ToInt32(ise.BAKIMDERECESIID);
        int arac_id = Convert.ToInt32((object) ise.ARACID);
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == arac_id));
        this.genelbakim.Text = tblaraclar.GENELBAKIMKM;
        this.motoryag.Text = tblaraclar.MOTORYAGKM;
        this.difransiyelyag.Text = tblaraclar.DIFERANSIYELYAGKM;
        this.aracAciklamaTxt.Text = tblaraclar.ARACACIKLAMA;
        this.sanzimanyag.Text = tblaraclar.SANZIMANYAGKM;
        this.textEdit8.EditValue = (object) tblaraclar.BELDMUDURLUKID;
        this.textEdit9.EditValue = (object) tblaraclar.ARACKULPERSID;
        this.birimCombo.EditValue = (object) tblaraclar.BELDBIRIMID;
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

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
    }

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
      isemriRapor isemriRapor = new isemriRapor();
      isemriRapor.Parameters["plaka"].Value = (object) this.plakaCombo.Text;
      isemriRapor.Parameters["aracBilgisi"].Value = (object) this.aracAciklamaTxt.Text;
      isemriRapor.Parameters["isEmirkod"].Value = (object) this.isemirkodu.Text;
      isemriRapor.Parameters["bariza"].Value = (object) this.bildirilenariza.Text;
      isemriRapor.Parameters["ctarih"].Value = (object) this.dateEdit2.Text;
      isemriRapor.Parameters["gtarih"].Value = (object) this.dateEdit1.Text;
      isemriRapor.Parameters["csaat"].Value = this.cikissaat.EditValue;
      isemriRapor.Parameters["gsaat"].Value = this.girissaat.EditValue;
      isemriRapor.Parameters["sofor"].Value = (object) this.aracigetiren.Text;
      isemriRapor.Parameters["atolyesef"].Value = (object) this.atolyesefi.Text;
      isemriRapor.Parameters["bakimyeri"].Value = (object) this.bakimyeri.Text;
      isemriRapor.Parameters["km"].Value = (object) this.bakimKMsaat.Text;
      isemriRapor.Parameters["km"].Visible = false;
      isemriRapor.Parameters["bakimyeri"].Visible = false;
      isemriRapor.Parameters["gsaat"].Visible = false;
      isemriRapor.Parameters["csaat"].Visible = false;
      isemriRapor.Parameters["atolyesef"].Visible = false;
      isemriRapor.Parameters["sofor"].Visible = false;
      isemriRapor.Parameters["gtarih"].Visible = false;
      isemriRapor.Parameters["ctarih"].Visible = false;
      isemriRapor.Parameters["bariza"].Visible = false;
      isemriRapor.Parameters["isEmirkod"].Visible = false;
      isemriRapor.Parameters["aracBilgisi"].Visible = false;
      isemriRapor.Parameters["plaka"].Visible = false;
      new ReportPrintTool((IReport) isemriRapor).ShowPreviewDialog();
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
      if (!(YetkiClass.secim == "kayıt"))
        return;
      int tmp = Convert.ToInt32(this.plakaCombo.EditValue);
      if (this.db.TBLISEMRI.Where<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (hd => hd.ARACID == (int?) tmp)).Where<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (hd => hd.ISEMRIDURUMID != (int?) 4)).Where<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (hd => hd.BAKIMYERIID == (int?) 1 || hd.BAKIMYERIID == (int?) 2 || hd.BAKIMYERIID == (int?) 3 || hd.BAKIMYERIID == (int?) 0)).Any<TBLISEMRI>())
      {
        this.plakaCombo.EditValue = (object) null;
        int num = (int) XtraMessageBox.Show("Bu araca ait bir iş emri açık bulunmaktadır");
      }
      else
      {
        try
        {
          TBLARACLAR arac = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == tmp));
          int? aractipiid = arac.ARACTIPIID;
          int num1 = 2;
          if (!(aractipiid.GetValueOrDefault() == num1 & aractipiid.HasValue))
          {
            this.textEdit8.EditValue = (object) arac.BELDMUDURLUKID;
            this.birimCombo.EditValue = (object) arac.BELDBIRIMID;
            this.textEdit9.EditValue = (object) arac.ARACKULPERSID;
            this.aracigetiren.Text = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => (int?) x.ID == arac.ARACKULPERSID)).ADISOYADI;
            this.aracAciklamaTxt.Text = arac.ARACACIKLAMA;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EkleFormu));
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
      this.cikissaat = new TimeEdit();
      this.girissaat = new TimeEdit();
      this.genelbakim = new TextEdit();
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
      this.aracAciklamaTxt = new MemoEdit();
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
      this.atolyesefi = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView5 = new GridView();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.bakimyeri = new LookUpEdit();
      this.tBLBAKIMYERIBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.isemirturu = new LookUpEdit();
      this.tBLISEMIRDURUMBindingSource = new BindingSource(this.components);
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
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
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
      this.panelControl1 = new PanelControl();
      this.gridControl1 = new GridControl();
      this.gridView4 = new GridView();
      this.panelControl2 = new PanelControl();
      this.panelControl4 = new PanelControl();
      this.gridControl2 = new GridControl();
      this.gridView6 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.gridColumn3 = new GridColumn();
      this.usta = new RepositoryItemLookUpEdit();
      this.gridColumn4 = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.panelControl3 = new PanelControl();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.searchControl1 = new SearchControl();
      this.tBLISEMIRDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMIRDURUMTableAdapter();
      this.tBLBAKIMYERITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBAKIMYERITableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter();
      this.arizanedeni = new LookUpEdit();
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.tAHARIZANEDENITableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TAHARIZANEDENITableAdapter();
      this.ribbonControl1.BeginInit();
      this.araclarListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
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
      this.no.Properties.BeginInit();
      this.plakaCombo.Properties.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.aracAciklamaTxt.Properties.BeginInit();
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
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView5.BeginInit();
      this.bakimyeri.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.isemirturu.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).BeginInit();
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
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.emptySpaceItem1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.gridControl1.BeginInit();
      this.gridView4.BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.panelControl4.BeginInit();
      this.panelControl4.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView6.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.usta.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.panelControl3.BeginInit();
      this.panelControl3.SuspendLayout();
      this.searchControl1.Properties.BeginInit();
      this.arizanedeni.Properties.BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
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
      this.ribbonControl1.Size = new Size(1389, 122);
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
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
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
      this.layoutControl1.Controls.Add((Control) this.cikissaat);
      this.layoutControl1.Controls.Add((Control) this.girissaat);
      this.layoutControl1.Controls.Add((Control) this.genelbakim);
      this.layoutControl1.Controls.Add((Control) this.dateEdit2);
      this.layoutControl1.Controls.Add((Control) this.dateEdit1);
      this.layoutControl1.Controls.Add((Control) this.isemirkodu);
      this.layoutControl1.Controls.Add((Control) this.aracigetiren);
      this.layoutControl1.Controls.Add((Control) this.difransiyelyag);
      this.layoutControl1.Controls.Add((Control) this.bakimKMsaat);
      this.layoutControl1.Controls.Add((Control) this.no);
      this.layoutControl1.Controls.Add((Control) this.plakaCombo);
      this.layoutControl1.Controls.Add((Control) this.aracAciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.birimCombo);
      this.layoutControl1.Controls.Add((Control) this.textEdit8);
      this.layoutControl1.Controls.Add((Control) this.textEdit9);
      this.layoutControl1.Controls.Add((Control) this.bildirilenariza);
      this.layoutControl1.Controls.Add((Control) this.motoryag);
      this.layoutControl1.Controls.Add((Control) this.sanzimanyag);
      this.layoutControl1.Controls.Add((Control) this.bakimozeti);
      this.layoutControl1.Controls.Add((Control) this.bakimturu);
      this.layoutControl1.Controls.Add((Control) this.atolyesefi);
      this.layoutControl1.Controls.Add((Control) this.bakimyeri);
      this.layoutControl1.Controls.Add((Control) this.isemirturu);
      this.layoutControl1.Controls.Add((Control) this.arizanedeni);
      this.layoutControl1.Dock = DockStyle.Top;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1108, 138, 812, 500));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1389, 377);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.cikissaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.cikissaat.Location = new Point(456, 170);
      this.cikissaat.Margin = new Padding(3, 2, 3, 2);
      this.cikissaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikissaat.Name = "cikissaat";
      this.cikissaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cikissaat.Properties.Appearance.Options.UseFont = true;
      this.cikissaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikissaat.Size = new Size(578, 28);
      this.cikissaat.StyleController = (IStyleController) this.layoutControl1;
      this.cikissaat.TabIndex = 43;
      this.girissaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.girissaat.Location = new Point(456, 138);
      this.girissaat.Margin = new Padding(3, 2, 3, 2);
      this.girissaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.girissaat.Name = "girissaat";
      this.girissaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girissaat.Properties.Appearance.Options.UseFont = true;
      this.girissaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girissaat.Size = new Size(578, 28);
      this.girissaat.StyleController = (IStyleController) this.layoutControl1;
      this.girissaat.TabIndex = 42;
      this.genelbakim.Location = new Point(1155, 136);
      this.genelbakim.Margin = new Padding(3, 2, 3, 2);
      this.genelbakim.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelbakim.Name = "genelbakim";
      this.genelbakim.Properties.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelbakim.Properties.Appearance.Options.UseFont = true;
      this.genelbakim.Properties.Mask.EditMask = "n0";
      this.genelbakim.Properties.Mask.MaskType = MaskType.Numeric;
      this.genelbakim.Size = new Size(222, 28);
      this.genelbakim.StyleController = (IStyleController) this.layoutControl1;
      this.genelbakim.TabIndex = 40;
      this.dateEdit2.EditValue = (object) null;
      this.dateEdit2.Location = new Point(134, 170);
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
      this.dateEdit2.Size = new Size(213, 26);
      this.dateEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit2.TabIndex = 34;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(134, 138);
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
      this.dateEdit1.Size = new Size(213, 26);
      this.dateEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit1.TabIndex = 33;
      this.isemirkodu.Enabled = false;
      this.isemirkodu.Location = new Point(134, 108);
      this.isemirkodu.Margin = new Padding(3, 2, 3, 2);
      this.isemirkodu.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemirkodu.Name = "isemirkodu";
      this.isemirkodu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemirkodu.Properties.Appearance.Options.UseFont = true;
      this.isemirkodu.Size = new Size(213, 26);
      this.isemirkodu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirkodu.TabIndex = 8;
      this.aracigetiren.Location = new Point(134, 42);
      this.aracigetiren.Margin = new Padding(3, 2, 3, 2);
      this.aracigetiren.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracigetiren.Name = "aracigetiren";
      this.aracigetiren.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracigetiren.Properties.Appearance.Options.UseFont = true;
      this.aracigetiren.Size = new Size(327, 26);
      this.aracigetiren.StyleController = (IStyleController) this.layoutControl1;
      this.aracigetiren.TabIndex = 13;
      this.difransiyelyag.Location = new Point(1155, 202);
      this.difransiyelyag.Margin = new Padding(3, 2, 3, 2);
      this.difransiyelyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.difransiyelyag.Name = "difransiyelyag";
      this.difransiyelyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyelyag.Properties.Appearance.Options.UseFont = true;
      this.difransiyelyag.Properties.Mask.EditMask = "n0";
      this.difransiyelyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.difransiyelyag.Size = new Size(222, 26);
      this.difransiyelyag.StyleController = (IStyleController) this.layoutControl1;
      this.difransiyelyag.TabIndex = 20;
      this.bakimKMsaat.Location = new Point(134, 202);
      this.bakimKMsaat.Margin = new Padding(3, 2, 3, 2);
      this.bakimKMsaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimKMsaat.Name = "bakimKMsaat";
      this.bakimKMsaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimKMsaat.Properties.Appearance.Options.UseFont = true;
      this.bakimKMsaat.Properties.Mask.EditMask = "n0";
      this.bakimKMsaat.Properties.Mask.MaskType = MaskType.Numeric;
      this.bakimKMsaat.Size = new Size(213, 26);
      this.bakimKMsaat.StyleController = (IStyleController) this.layoutControl1;
      this.bakimKMsaat.TabIndex = 21;
      this.no.Enabled = false;
      this.no.Location = new Point(456, 108);
      this.no.Margin = new Padding(3, 2, 3, 2);
      this.no.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.no.Name = "no";
      this.no.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.no.Properties.Appearance.Options.UseFont = true;
      this.no.Properties.Mask.EditMask = "n0";
      this.no.Properties.Mask.MaskType = MaskType.Numeric;
      this.no.Size = new Size(578, 26);
      this.no.StyleController = (IStyleController) this.layoutControl1;
      this.no.TabIndex = 29;
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
      this.plakaCombo.Size = new Size(326, 26);
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
      this.aracAciklamaTxt.Location = new Point(134, 72);
      this.aracAciklamaTxt.Margin = new Padding(3, 2, 3, 2);
      this.aracAciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aracAciklamaTxt.Name = "aracAciklamaTxt";
      this.aracAciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracAciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.aracAciklamaTxt.Properties.ScrollBars = ScrollBars.None;
      this.aracAciklamaTxt.Size = new Size(1243, 32);
      this.aracAciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.aracAciklamaTxt.TabIndex = 6;
      this.birimCombo.Enabled = false;
      this.birimCombo.Location = new Point(1022, 12);
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
      this.birimCombo.Size = new Size(355, 26);
      this.birimCombo.StyleController = (IStyleController) this.layoutControl1;
      this.birimCombo.TabIndex = 5;
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.textEdit8.Enabled = false;
      this.textEdit8.Location = new Point(567, 12);
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
      this.textEdit8.Size = new Size(349, 26);
      this.textEdit8.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit8.TabIndex = 11;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.textEdit9.Enabled = false;
      this.textEdit9.Location = new Point(567, 42);
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
      this.textEdit9.Size = new Size(349, 26);
      this.textEdit9.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit9.TabIndex = 12;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.bildirilenariza.Location = new Point(134, 262);
      this.bildirilenariza.Margin = new Padding(3, 2, 3, 2);
      this.bildirilenariza.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bildirilenariza.Name = "bildirilenariza";
      this.bildirilenariza.Properties.ScrollBars = ScrollBars.None;
      this.bildirilenariza.Size = new Size(213, 103);
      this.bildirilenariza.StyleController = (IStyleController) this.layoutControl1;
      this.bildirilenariza.TabIndex = 19;
      this.motoryag.Location = new Point(1155, 170);
      this.motoryag.Margin = new Padding(3, 2, 3, 2);
      this.motoryag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motoryag.Name = "motoryag";
      this.motoryag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motoryag.Properties.Appearance.Options.UseFont = true;
      this.motoryag.Properties.Mask.EditMask = "n0";
      this.motoryag.Properties.Mask.MaskType = MaskType.Numeric;
      this.motoryag.Size = new Size(222, 26);
      this.motoryag.StyleController = (IStyleController) this.layoutControl1;
      this.motoryag.TabIndex = 31;
      this.sanzimanyag.Location = new Point(1155, 232);
      this.sanzimanyag.Margin = new Padding(3, 2, 3, 2);
      this.sanzimanyag.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sanzimanyag.Name = "sanzimanyag";
      this.sanzimanyag.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sanzimanyag.Properties.Appearance.Options.UseFont = true;
      this.sanzimanyag.Properties.Mask.EditMask = "n0";
      this.sanzimanyag.Properties.Mask.MaskType = MaskType.Numeric;
      this.sanzimanyag.Size = new Size(222, 26);
      this.sanzimanyag.StyleController = (IStyleController) this.layoutControl1;
      this.sanzimanyag.TabIndex = 32;
      this.bakimozeti.Location = new Point(456, 262);
      this.bakimozeti.Margin = new Padding(3, 2, 3, 2);
      this.bakimozeti.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimozeti.Name = "bakimozeti";
      this.bakimozeti.Properties.ScrollBars = ScrollBars.None;
      this.bakimozeti.Size = new Size(921, 103);
      this.bakimozeti.StyleController = (IStyleController) this.layoutControl1;
      this.bakimozeti.TabIndex = 30;
      this.bakimturu.Location = new Point(456, 232);
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
      this.bakimturu.Size = new Size(233, 26);
      this.bakimturu.StyleController = (IStyleController) this.layoutControl1;
      this.bakimturu.TabIndex = 26;
      this.atolyesefi.Location = new Point(1022, 42);
      this.atolyesefi.Margin = new Padding(3, 2, 3, 2);
      this.atolyesefi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyesefi.Name = "atolyesefi";
      this.atolyesefi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyesefi.Properties.Appearance.Options.UseFont = true;
      this.atolyesefi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyesefi.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.atolyesefi.Properties.DisplayMember = "ADISOYADI";
      this.atolyesefi.Properties.NullText = "";
      this.atolyesefi.Properties.PopupView = (ColumnView) this.gridView5;
      this.atolyesefi.Properties.ValueMember = "ID";
      this.atolyesefi.Size = new Size(355, 26);
      this.atolyesefi.StyleController = (IStyleController) this.layoutControl1;
      this.atolyesefi.TabIndex = 28;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView5.Columns.AddRange(new GridColumn[2]
      {
        this.gridColumn7,
        this.gridColumn8
      });
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.gridColumn7.Caption = "Adı Soyadı";
      this.gridColumn7.FieldName = "ADISOYADI";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 0;
      this.gridColumn8.Caption = "T.C Kimlik No";
      this.gridColumn8.FieldName = "TCKIMLIKNO";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 1;
      this.bakimyeri.Location = new Point(456, 202);
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
      this.bakimyeri.Size = new Size(578, 26);
      this.bakimyeri.StyleController = (IStyleController) this.layoutControl1;
      this.bakimyeri.TabIndex = 14;
      this.tBLBAKIMYERIBindingSource.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.isemirturu.Location = new Point(134, 232);
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
      this.isemirturu.Size = new Size(213, 26);
      this.isemirturu.StyleController = (IStyleController) this.layoutControl1;
      this.isemirturu.TabIndex = 22;
      this.isemirturu.EditValueChanged += new EventHandler(this.isemirturu_EditValueChanged);
      this.tBLISEMIRDURUMBindingSource.DataMember = "TBLISEMIRDURUM";
      this.tBLISEMIRDURUMBindingSource.DataSource = (object) this.bellDataSet5;
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
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem17
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1389, 377);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.plakaCombo;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem1.Size = new Size(453, 30);
      this.layoutControlItem1.Text = "Araç Plaka";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(118, 21);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.isemirturu;
      this.layoutControlItem19.Location = new Point(0, 220);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem19.Size = new Size(339, 30);
      this.layoutControlItem19.Text = "İş Emir Durum";
      this.layoutControlItem19.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem19.TextSize = new Size(120, 16);
      this.layoutControlItem19.TextToControlDistance = 2;
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.textEdit9;
      this.layoutControlItem9.Location = new Point(453, 30);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(455, 30);
      this.layoutControlItem9.Text = "Araç Şoförü";
      this.layoutControlItem9.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem9.TextSize = new Size(100, 20);
      this.layoutControlItem9.TextToControlDistance = 2;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.isemirkodu;
      this.layoutControlItem5.Location = new Point(0, 96);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(339, 30);
      this.layoutControlItem5.Text = "İş Emir Kodu";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem5.TextSize = new Size(120, 16);
      this.layoutControlItem5.TextToControlDistance = 2;
      this.difransiyel.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.difransiyel.AppearanceItemCaption.Options.UseFont = true;
      this.difransiyel.Control = (Control) this.difransiyelyag;
      this.difransiyel.Location = new Point(1026, 190);
      this.difransiyel.Name = "difransiyel";
      this.difransiyel.Size = new Size(343, 30);
      this.difransiyel.Text = "Difrensiyel Yağ";
      this.difransiyel.TextAlignMode = TextAlignModeItem.CustomSize;
      this.difransiyel.TextSize = new Size(115, 16);
      this.difransiyel.TextToControlDistance = 2;
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.bakimKMsaat;
      this.layoutControlItem18.Location = new Point(0, 190);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(339, 30);
      this.layoutControlItem18.Text = "Bakım KM/Saat";
      this.layoutControlItem18.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem18.TextSize = new Size(120, 16);
      this.layoutControlItem18.TextToControlDistance = 2;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.aracAciklamaTxt;
      this.layoutControlItem3.Location = new Point(0, 60);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem3.Size = new Size(1369, 36);
      this.layoutControlItem3.Text = "Araç Açıklama";
      this.layoutControlItem3.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem3.TextSize = new Size(120, 16);
      this.layoutControlItem3.TextToControlDistance = 2;
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.no;
      this.layoutControlItem26.Location = new Point(339, 96);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem26.Size = new Size(687, 30);
      this.layoutControlItem26.Text = "No";
      this.layoutControlItem26.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem26.TextSize = new Size(100, 16);
      this.layoutControlItem26.TextToControlDistance = 5;
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.bakimyeri;
      this.layoutControlItem11.Location = new Point(339, 190);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(687, 30);
      this.layoutControlItem11.Text = "Bakım  Yeri";
      this.layoutControlItem11.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem11.TextSize = new Size(100, 16);
      this.layoutControlItem11.TextToControlDistance = 5;
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.bildirilenariza;
      this.layoutControlItem16.Location = new Point(0, 250);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem16.Size = new Size(339, 107);
      this.layoutControlItem16.Text = "Bildirilen Arıza";
      this.layoutControlItem16.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem16.TextSize = new Size(120, 16);
      this.layoutControlItem16.TextToControlDistance = 2;
      this.simpleLabelItem1.AllowHotTrack = false;
      this.simpleLabelItem1.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
      this.simpleLabelItem1.Location = new Point(1026, 96);
      this.simpleLabelItem1.Name = "simpleLabelItem1";
      this.simpleLabelItem1.Size = new Size(343, 28);
      this.simpleLabelItem1.Text = "Sonraki Bakım Km Bilgisi";
      this.simpleLabelItem1.TextSize = new Size(252, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.motoryag;
      this.layoutControlItem4.Location = new Point(1026, 158);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(343, 32);
      this.layoutControlItem4.Text = "Motor Yağ";
      this.layoutControlItem4.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem4.TextSize = new Size(115, 16);
      this.layoutControlItem4.TextToControlDistance = 2;
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.sanzimanyag;
      this.layoutControlItem12.Location = new Point(1026, 220);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(343, 30);
      this.layoutControlItem12.Text = "Şanzıman Yağ";
      this.layoutControlItem12.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem12.TextSize = new Size(115, 16);
      this.layoutControlItem12.TextToControlDistance = 2;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.dateEdit1;
      this.layoutControlItem20.Location = new Point(0, 126);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(339, 32);
      this.layoutControlItem20.Text = "Giriş Tarihi";
      this.layoutControlItem20.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem20.TextSize = new Size(120, 16);
      this.layoutControlItem20.TextToControlDistance = 2;
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.dateEdit2;
      this.layoutControlItem6.Location = new Point(0, 158);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(339, 32);
      this.layoutControlItem6.Text = "Çıkış Tarihi";
      this.layoutControlItem6.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem6.TextSize = new Size(120, 16);
      this.layoutControlItem6.TextToControlDistance = 2;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.genelbakim;
      this.layoutControlItem14.Location = new Point(1026, 124);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(343, 34);
      this.layoutControlItem14.Text = "Genek Bakım";
      this.layoutControlItem14.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem14.TextSize = new Size(115, 16);
      this.layoutControlItem14.TextToControlDistance = 2;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.textEdit8;
      this.layoutControlItem8.Location = new Point(453, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(455, 30);
      this.layoutControlItem8.Text = "Müdürlük";
      this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem8.TextSize = new Size(100, 20);
      this.layoutControlItem8.TextToControlDistance = 2;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.aracigetiren;
      this.layoutControlItem10.Location = new Point(0, 30);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(453, 30);
      this.layoutControlItem10.Text = "Araçı Getiren";
      this.layoutControlItem10.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem10.TextSize = new Size(120, 16);
      this.layoutControlItem10.TextToControlDistance = 2;
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.bakimozeti;
      this.layoutControlItem27.Location = new Point(339, 250);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(1030, 107);
      this.layoutControlItem27.Text = "Bakım Özeti";
      this.layoutControlItem27.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem27.TextSize = new Size(100, 16);
      this.layoutControlItem27.TextToControlDistance = 5;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.birimCombo;
      this.layoutControlItem2.Location = new Point(908, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(461, 30);
      this.layoutControlItem2.Text = "Birim";
      this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem2.TextSize = new Size(100, 16);
      this.layoutControlItem2.TextToControlDistance = 2;
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.atolyesefi;
      this.layoutControlItem25.Location = new Point(908, 30);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(461, 30);
      this.layoutControlItem25.Text = "Atölye Şefi";
      this.layoutControlItem25.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem25.TextSize = new Size(100, 16);
      this.layoutControlItem25.TextToControlDistance = 2;
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.bakimturu;
      this.layoutControlItem23.Location = new Point(339, 220);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem23.Size = new Size(342, 30);
      this.layoutControlItem23.Text = "Bakım Türü";
      this.layoutControlItem23.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem23.TextSize = new Size(100, 16);
      this.layoutControlItem23.TextToControlDistance = 5;
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.Control = (Control) this.arizanedeni;
      this.layoutControlItem21.Location = new Point(681, 220);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(345, 30);
      this.layoutControlItem21.Text = "Arıza nedeni";
      this.layoutControlItem21.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem21.TextSize = new Size(101, 16);
      this.layoutControlItem21.TextToControlDistance = 2;
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.girissaat;
      this.layoutControlItem15.Location = new Point(339, 126);
      this.layoutControlItem15.MinSize = new Size(321, 32);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(687, 32);
      this.layoutControlItem15.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem15.Text = "Giriş Saati";
      this.layoutControlItem15.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem15.TextLocation = Locations.Left;
      this.layoutControlItem15.TextSize = new Size(100, 20);
      this.layoutControlItem15.TextToControlDistance = 5;
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.cikissaat;
      this.layoutControlItem17.Location = new Point(339, 158);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.Size = new Size(687, 32);
      this.layoutControlItem17.Text = "Çıkış Saati";
      this.layoutControlItem17.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem17.TextSize = new Size(100, 20);
      this.layoutControlItem17.TextToControlDistance = 5;
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
      this.panelControl1.Controls.Add((Control) this.gridControl1);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(63, 129);
      this.panelControl1.Margin = new Padding(3, 2, 3, 2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1324, 164);
      this.panelControl1.TabIndex = 5;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Location = new Point(2, 2);
      this.gridControl1.MainView = (BaseView) this.gridView4;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1320, 160);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.gridView4.GridControl = this.gridControl1;
      this.gridView4.GroupSummary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridGroupSummaryItem(SummaryItemType.Sum, "tutar", (GridColumn) null, "")
      });
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.panelControl2.Controls.Add((Control) this.panelControl4);
      this.panelControl2.Controls.Add((Control) this.panelControl1);
      this.panelControl2.Controls.Add((Control) this.panelControl3);
      this.panelControl2.Controls.Add((Control) this.simpleButton2);
      this.panelControl2.Dock = DockStyle.Bottom;
      this.panelControl2.Location = new Point(0, 505);
      this.panelControl2.Margin = new Padding(3, 2, 3, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(1389, 295);
      this.panelControl2.TabIndex = 6;
      this.panelControl4.Controls.Add((Control) this.gridControl2);
      this.panelControl4.Dock = DockStyle.Top;
      this.panelControl4.Location = new Point(63, 2);
      this.panelControl4.Margin = new Padding(3, 2, 3, 2);
      this.panelControl4.Name = "panelControl4";
      this.panelControl4.Size = new Size(1324, 181);
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
        (RepositoryItem) this.usta,
        (RepositoryItem) this.repositoryItemLookUpEdit3
      });
      this.gridControl2.Size = new Size(1320, 177);
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
      this.gridColumn2.Caption = "Atölye";
      this.gridColumn2.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn2.FieldName = "ATOLYEID";
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
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.gridColumn3.Caption = "Usta Adı Soyadı";
      this.gridColumn3.ColumnEdit = (RepositoryItem) this.usta;
      this.gridColumn3.FieldName = "BAKIMYAPUSTAID";
      this.gridColumn3.MinWidth = 23;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.gridColumn3.Width = 87;
      this.usta.AutoHeight = false;
      this.usta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.usta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.usta.DisplayMember = "USTAADISOYADI";
      this.usta.Name = "usta";
      this.usta.ValueMember = "ID";
      this.gridColumn4.Caption = "Bakım Grubu";
      this.gridColumn4.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.gridColumn4.FieldName = "BAKIMGRUBUID";
      this.gridColumn4.MinWidth = 23;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 2;
      this.gridColumn4.Width = 87;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.repositoryItemLookUpEdit3.DisplayMember = "GRUPADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.gridColumn5.Caption = "Yapılan Bakım";
      this.gridColumn5.FieldName = "YAPILANBAKIM";
      this.gridColumn5.MinWidth = 23;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 3;
      this.gridColumn5.Width = 87;
      this.gridColumn6.Caption = "gridColumn6";
      this.gridColumn6.FieldName = "ID";
      this.gridColumn6.MinWidth = 23;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Width = 87;
      this.panelControl3.Controls.Add((Control) this.simpleButton3);
      this.panelControl3.Controls.Add((Control) this.simpleButton1);
      this.panelControl3.Dock = DockStyle.Left;
      this.panelControl3.Location = new Point(2, 2);
      this.panelControl3.Margin = new Padding(3, 2, 3, 2);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new Size(61, 291);
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
      this.searchControl1.Client = (ISearchControlClient) this.gridControl2;
      this.searchControl1.Location = new Point(650, 32);
      this.searchControl1.Margin = new Padding(3, 2, 3, 2);
      this.searchControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchControl1.Name = "searchControl1";
      this.searchControl1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchControl1.Properties.Appearance.Options.UseFont = true;
      this.searchControl1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.searchControl1.Properties.Client = (ISearchControlClient) this.gridControl2;
      this.searchControl1.Size = new Size(210, 30);
      this.searchControl1.TabIndex = 8;
      this.tBLISEMIRDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMYERITableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.arizanedeni.Location = new Point(796, 232);
      this.arizanedeni.Margin = new Padding(3, 2, 3, 2);
      this.arizanedeni.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.arizanedeni.Name = "arizanedeni";
      this.arizanedeni.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizanedeni.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ARIZANEDENI", "Arıza Nedeni")
      });
      this.arizanedeni.Properties.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.arizanedeni.Properties.DisplayMember = "ARIZANEDENI";
      this.arizanedeni.Properties.NullText = "";
      this.arizanedeni.Properties.PopupSizeable = false;
      this.arizanedeni.Properties.ValueMember = "ID";
      this.arizanedeni.Size = new Size(238, 22);
      this.arizanedeni.StyleController = (IStyleController) this.layoutControl1;
      this.arizanedeni.TabIndex = 24;
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.bellDataSet7;
      this.tAHARIZANEDENITableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1389, 800);
      this.Controls.Add((Control) this.searchControl1);
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (EkleFormu);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Kayıt Oluştur";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.araclarListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
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
      this.no.Properties.EndInit();
      this.plakaCombo.Properties.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.aracAciklamaTxt.Properties.EndInit();
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
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView5.EndInit();
      this.bakimyeri.Properties.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.isemirturu.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).EndInit();
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
      this.layoutControlItem14.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem17.EndInit();
      this.emptySpaceItem1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.gridControl1.EndInit();
      this.gridView4.EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl4.EndInit();
      this.panelControl4.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView6.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.usta.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.panelControl3.EndInit();
      this.panelControl3.ResumeLayout(false);
      this.searchControl1.Properties.EndInit();
      this.arizanedeni.Properties.EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
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
