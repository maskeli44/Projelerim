// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.CikisFisDuzenle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
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

namespace Makina_Ikmal.Depo
{
  public class CikisFisDuzenle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId kul = new KullaniciSonId();
    private int guncelle_id = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
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
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private DataLayoutControl dataLayoutControl1;
    private TimeEdit saat;
    private SearchLookUpEdit DepoYetkiliLook;
    private GridView searchLookUpEdit3View;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup3;
    private SearchLookUpEdit AlanUstaLook;
    private GridView searchLookUpEdit2View;
    private DateEdit tarih;
    private TextEdit FisKoduTxt;
    private SearchLookUpEdit IsEmriLook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem3;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem2;
    private BarButtonItem barButtonItem22;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private LayoutControl layoutControl4;
    private SimpleButton simpleButton4;
    private SimpleButton simpleButton1;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControlItem layoutControlItem12;
    private EmptySpaceItem emptySpaceItem2;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem11;
    private GridColumn IsEmriKod;
    private GridColumn IslemYeri;
    private GridColumn AracAciklama;
    private RepositoryItemSearchLookUpEdit Plaka;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit Aciklama;
    private GridView repositoryItemSearchLookUpEdit2View;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControlItem layoutControlItem8;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private LabelControl labelControl1;
    private LayoutControlItem layoutControlItem16;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private GridControl gridControl1;
    private GridView gridView1;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private RepositoryItemLookUpEdit MAL;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private RepositoryItemLookUpEdit birim;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private GridColumn gridColumn9;
    private RepositoryItemLookUpEdit marka;
    private GridColumn gridColumn10;
    private RepositoryItemLookUpEdit depo;
    private GridColumn degisimkm;
    private GridColumn gridColumn12;
    private LayoutControlItem layoutControlItem1;
    private GridColumn gridColumn8;
    private BarButtonItem barButtonItem21;
    private BarEditItem barEditItem3;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private RibbonPageGroup ribbonPageGroup3;
    private RadioGroup radioGroup1;
    private BehaviorManager behaviorManager1;
    private BindingSource tBLMALZMARKABindingSource;
    private TBLMALZMARKATableAdapter tBLMALZMARKATableAdapter;
    private BindingSource tBLMALZDEPOBindingSource;
    private TBLMALZDEPOTableAdapter tBLMALZDEPOTableAdapter;
    private GridColumn gridColumn11;
    private GridColumn gridColumn13;
    private GridColumn PlakaArac;

    public CikisFisDuzenle() => this.InitializeComponent();

    private void GirisFisEkle_Load(object sender, EventArgs e)
    {
      this.radioGroup1.SelectedIndex = 1;
      this.listemek();
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelle_id = YetkiClass.secim_id;
      this.guncelleload();
    }

    private void listemek()
    {
      this.IsEmriLook.Properties.ValueMember = "ID";
      this.IsEmriLook.Properties.DisplayMember = "KOD";
      this.IsEmriLook.Properties.DataSource = (object) this.db.TBLISEMRI.GroupJoin((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, (Expression<System.Func<TBLISEMRI, int?>>) (hd => hd.ARACID), (Expression<System.Func<TBLARACLAR, int?>>) (ha => (int?) ha.ID), (hd, ps) => new
      {
        hd = hd,
        ps = ps
      }).SelectMany(data => data.ps.DefaultIfEmpty<TBLARACLAR>(), (data, ha) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        ha = ha
      }).GroupJoin((IEnumerable<TBLATOLYEBOLUM>) this.db.TBLATOLYEBOLUM, data => data.\u003C\u003Eh__TransparentIdentifier0.hd.ATOLYEID, (Expression<System.Func<TBLATOLYEBOLUM, int?>>) (hat => (int?) hat.ID), (data, pst) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        pst = pst
      }).SelectMany(data => data.pst.DefaultIfEmpty<TBLATOLYEBOLUM>(), (data, hat) => new
      {
        KOD = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.KOD,
        ID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ID,
        BOLUMADI = hat.BOLUMADI,
        PLAKA = data.\u003C\u003Eh__TransparentIdentifier1.ha.PLAKA,
        ARACACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier1.ha.ARACACIKLAMA
      }).OrderByDescending(x => x.ID).ToList();
      this.DepoYetkiliLook.Properties.ValueMember = "ID";
      this.DepoYetkiliLook.Properties.DisplayMember = "ADISOYADI";
      this.DepoYetkiliLook.Properties.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      MalzemeDegerAktarma.list.Clear();
      this.MAL.ValueMember = "ID";
      this.MAL.DisplayMember = "MALZEMEADI";
      this.MAL.DataSource = (object) this.db.TBLMALZEMELER.ToList<TBLMALZEMELER>();
      this.marka.ValueMember = "ID";
      this.marka.DisplayMember = "MALZMARKA";
      this.marka.DataSource = (object) this.db.TBLMALZMARKA.ToList<TBLMALZMARKA>();
      this.depo.ValueMember = "ID";
      this.depo.DisplayMember = "DEPOADI";
      this.depo.DataSource = (object) this.db.TBLMALZMARKA.ToList<TBLMALZMARKA>();
      this.birim.ValueMember = "ID";
      this.birim.DisplayMember = "BIRIMADI";
      this.birim.DataSource = (object) this.db.TBLMALZBIRIM.ToList<TBLMALZBIRIM>();
      this.AlanUstaLook.Properties.ValueMember = "ID";
      this.AlanUstaLook.Properties.DisplayMember = "USTAADISOYADI";
      this.AlanUstaLook.Properties.DataSource = (object) this.db.TBLATOLYEUSTALAR.ToList<TBLATOLYEUSTALAR>();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => new CikisFisGirisFisiEkle().Show();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.IsEmriLook.Focus();
      this.guncelleme();
      LogEkle.Logs("Guncelleme Yapti");
      ((CikisFisListesi) Application.OpenForms["CikisFisListesi"])?.listele();
    }

    private void guncelleload()
    {
      try
      {
        MalzemeDegerAktarma.list.Clear();
        DbSet<TBLDEPOFISHRKT> tbldepofishrkt1 = this.db.TBLDEPOFISHRKT;
        Expression<System.Func<TBLDEPOFISHRKT, bool>> predicate = (Expression<System.Func<TBLDEPOFISHRKT, bool>>) (hd => hd.DEPOFISID == (int?) YetkiClass.secim_id);
        foreach (TBLDEPOFISHRKT tbldepofishrkt2 in (IEnumerable<TBLDEPOFISHRKT>) tbldepofishrkt1.Where<TBLDEPOFISHRKT>(predicate))
          MalzemeDegerAktarma.list.Add(new ElemanlarDurum1()
          {
            MALZEMEID = Convert.ToInt32((object) tbldepofishrkt2.MALZEMEID),
            MALZACIKLAMA = tbldepofishrkt2.MALZACIKLAMA,
            BIRIMID = Convert.ToInt32((object) tbldepofishrkt2.BIRIMID),
            FIYAT = Convert.ToDecimal((object) tbldepofishrkt2.FIYAT),
            MIKTAR = Convert.ToDecimal((object) tbldepofishrkt2.MIKTAR),
            TUTAR = Convert.ToDecimal((object) tbldepofishrkt2.TUTAR),
            MARKAID = Convert.ToInt32((object) tbldepofishrkt2.MALZMARKAID),
            MALZSERINO = tbldepofishrkt2.MALZSERINO,
            DEGISIMKMSI = Convert.ToInt32(tbldepofishrkt2.DEGISIMKMSI),
            DEPOID = Convert.ToInt32((object) tbldepofishrkt2.DEPOID),
            ID = tbldepofishrkt2.ID
          });
        this.gridControl1.DataSource = (object) MalzemeDegerAktarma.list;
        TBLDEPOFIS isemri = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
        this.IsEmriLook.EditValue = (object) isemri.ISEMRIID;
        TBLISEMRI acik = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => (int?) x.ID == isemri.ISEMRIID));
        TBLATOLYEBOLUM tblatolyebolum = this.db.TBLATOLYEBOLUM.FirstOrDefault<TBLATOLYEBOLUM>((Expression<System.Func<TBLATOLYEBOLUM, bool>>) (x => (int?) x.ID == acik.ATOLYEID));
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => (int?) x.ID == acik.ARACID));
        try
        {
          this.AlanUstaLook.EditValue = (object) Convert.ToInt32((object) isemri.ALANUSTAID);
        }
        catch (Exception ex)
        {
        }
        this.DepoYetkiliLook.EditValue = (object) isemri.IMZADEPOYETKILIID;
        try
        {
          this.labelControl1.Text = tblaraclar.ARACACIKLAMA;
        }
        catch (Exception ex)
        {
          this.labelControl1.Text = tblatolyebolum.BOLUMADI;
        }
        this.FisKoduTxt.Text = isemri.KOD;
        this.tarih.EditValue = (object) isemri.TARIH;
        this.saat.EditValue = (object) isemri.SAAT;
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    public void listele() => this.gridControl1.DataSource = (object) MalzemeDegerAktarma.list.ToList<ElemanlarDurum1>();

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.radioGroup1.SelectedIndex == 1)
      {
        cikisFisiYazdir cikisFisiYazdir = new cikisFisiYazdir();
        cikisFisiYazdir.Parameters["id"].Value = (object) YetkiClass.secim_id;
        cikisFisiYazdir.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) cikisFisiYazdir).ShowPreviewDialog();
      }
      else
      {
        if (this.radioGroup1.SelectedIndex != 0)
          return;
        cikisFisiYazdir_4a cikisFisiYazdir4a = new cikisFisiYazdir_4a();
        cikisFisiYazdir4a.Parameters["id"].Value = (object) YetkiClass.secim_id;
        cikisFisiYazdir4a.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) cikisFisiYazdir4a).ShowPreviewDialog();
      }
    }

    private void simpleButton4_Click(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID")) == 0 || this.gridView1.GetFocusedRowCellValue("ID") == null)
      {
        this.gridView1.DeleteSelectedRows();
      }
      else
      {
        int id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        TBLDEPOFISHRKT sil = this.db.TBLDEPOFISHRKT.FirstOrDefault<TBLDEPOFISHRKT>((Expression<System.Func<TBLDEPOFISHRKT, bool>>) (x => x.ID == id));
        TBLMALZEMELER tblmalzemeler1 = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => (int?) x.ID == sil.MALZEMEID));
        TBLMALZEMELER tblmalzemeler2 = tblmalzemeler1;
        Decimal? nullable1 = tblmalzemeler2.KALAN;
        Decimal? nullable2 = sil.MIKTAR;
        tblmalzemeler2.KALAN = nullable1.HasValue & nullable2.HasValue ? new Decimal?(nullable1.GetValueOrDefault() + nullable2.GetValueOrDefault()) : new Decimal?();
        TBLMALZEMELER tblmalzemeler3 = tblmalzemeler1;
        nullable2 = tblmalzemeler3.CIKIS;
        nullable1 = sil.MIKTAR;
        tblmalzemeler3.CIKIS = nullable2.HasValue & nullable1.HasValue ? new Decimal?(nullable2.GetValueOrDefault() - nullable1.GetValueOrDefault()) : new Decimal?();
        this.db.TBLDEPOFISHRKT.Remove(sil);
        this.db.SaveChanges();
        this.guncelleload();
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new Makina_Ikmal.Atolye.MalzemeListesi().ShowDialog();
    }

    private void guncelleme()
    {
      try
      {
        TBLDEPOFIS tbldepofis = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == this.guncelle_id));
        TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == this.guncelle_id));
        try
        {
          tbldepofis.ALANUSTAID = tbltalepfis.TALEPEDENUSTAID;
        }
        catch (Exception ex)
        {
        }
        tbldepofis.ISEMRIID = new int?(Convert.ToInt32(this.IsEmriLook.EditValue));
        tbldepofis.TARIH = new DateTime?(Convert.ToDateTime(this.tarih.EditValue));
        tbldepofis.SAAT = new DateTime?(Convert.ToDateTime(this.saat.EditValue));
        tbldepofis.ALANUSTAID = new int?(Convert.ToInt32(this.AlanUstaLook.EditValue));
        tbldepofis.IMZADEPOYETKILIID = new int?(Convert.ToInt32(this.DepoYetkiliLook.EditValue));
        tbldepofis.ISLEMTIPIID = "3";
        tbldepofis.GCKOD = "C";
        try
        {
          tbldepofis.FISTUTAR = tbltalepfis.FISTUTAR;
        }
        catch (Exception ex)
        {
        }
        this.db.SaveChanges();
        for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
        {
          if (Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID")) == 0)
          {
            TBLDEPOFISHRKT entity = new TBLDEPOFISHRKT();
            entity.DEPOFISID = new int?(tbldepofis.ID);
            entity.BIRIMID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "BIRIMID")));
            entity.MIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR")));
            entity.MALZACIKLAMA = Convert.ToString(this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA"));
            entity.FIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "FIYAT")));
            entity.TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "TUTAR")));
            int malzeme_id = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "MALZEMEID"));
            try
            {
              entity.DEGISIMKMSI = this.gridView1.GetRowCellValue(rowHandle, "DEGISIMKMSI").ToString();
            }
            catch
            {
            }
            try
            {
              entity.SONRAKIDEGKM = this.gridView1.GetRowCellValue(rowHandle, "SONRAKIDEGKM").ToString();
            }
            catch
            {
            }
            try
            {
              entity.MALZSERINO = this.gridView1.GetRowCellValue(rowHandle, "MALZSERINO").ToString();
            }
            catch
            {
            }
            try
            {
              entity.MALZMARKAID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "MALZMARKAID")));
            }
            catch
            {
            }
            try
            {
              entity.DEPOID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "DEPOID")));
            }
            catch
            {
            }
            entity.GIRISMIKTAR = new Decimal?(0M);
            entity.CIKISMIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR")));
            entity.GIRISTUTAR = new Decimal?(0M);
            entity.CIKISTUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "TUTAR")));
            entity.MALZEMEID = new int?(malzeme_id);
            entity.KDVORAN = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "KDVORAN")));
            entity.GCKOD = "C";
            TBLMALZEMELER tblmalzemeler = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == malzeme_id));
            Decimal num1 = 0M;
            try
            {
              num1 = Convert.ToDecimal((object) tblmalzemeler.CIKIS);
            }
            catch (Exception ex)
            {
            }
            Decimal num2 = Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR"));
            tblmalzemeler.CIKIS = new Decimal?(num1 + num2);
            Decimal num3 = 0M;
            try
            {
              num3 = Convert.ToDecimal((object) tblmalzemeler.KALAN);
            }
            catch (Exception ex)
            {
            }
            Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR"));
            entity.DEPOFISID = new int?(YetkiClass.secim_id);
            this.db.TBLDEPOFISHRKT.Add(entity);
            this.db.SaveChanges();
          }
          else
          {
            int idx = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
            TBLDEPOFISHRKT tbldepofishrkt = this.db.TBLDEPOFISHRKT.FirstOrDefault<TBLDEPOFISHRKT>((Expression<System.Func<TBLDEPOFISHRKT, bool>>) (x => x.ID == idx));
            tbldepofishrkt.BIRIMID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "BIRIMID")));
            tbldepofishrkt.MIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR")));
            tbldepofishrkt.MALZACIKLAMA = Convert.ToString(this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA"));
            tbldepofishrkt.FIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "FIYAT")));
            tbldepofishrkt.TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "TUTAR")));
            int malzeme_id = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "MALZEMEID"));
            try
            {
              tbldepofishrkt.DEGISIMKMSI = this.gridView1.GetRowCellValue(rowHandle, "DEGISIMKMSI").ToString();
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.SONRAKIDEGKM = this.gridView1.GetRowCellValue(rowHandle, "SONRAKIDEGKM").ToString();
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.MALZSERINO = this.gridView1.GetRowCellValue(rowHandle, "MALZSERINO").ToString();
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.MALZMARKAID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "MALZMARKAID")));
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.DEPOID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "DEPOID")));
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.GIRISMIKTAR = new Decimal?(0M);
              tbldepofishrkt.CIKISMIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR")));
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.GIRISTUTAR = new Decimal?(0M);
              tbldepofishrkt.CIKISTUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "TUTAR")));
            }
            catch
            {
            }
            try
            {
              tbldepofishrkt.MALZEMEID = new int?(malzeme_id);
              tbldepofishrkt.KDVORAN = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "KDVORAN")));
            }
            catch
            {
            }
            try
            {
              TBLMALZEMELER tblmalzemeler = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == malzeme_id));
              Decimal num4 = 0M;
              try
              {
                num4 = Convert.ToDecimal((object) tblmalzemeler.CIKIS);
              }
              catch (Exception ex)
              {
              }
              Decimal num5 = Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR"));
              tblmalzemeler.CIKIS = new Decimal?(num4 + num5);
              Decimal num6 = 0M;
              try
              {
                num6 = Convert.ToDecimal((object) tblmalzemeler.KALAN);
              }
              catch (Exception ex)
              {
              }
              Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "MIKTAR"));
            }
            catch
            {
            }
            tbldepofishrkt.GCKOD = "C";
            this.db.SaveChanges();
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
      int num7 = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
    }

    private void kontrol()
    {
      for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
      {
        int id = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "MALZEMEID"));
        TBLMALZEMELER tblmalzemeler = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == id));
        Decimal num1 = Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "miktar").ToString());
        Decimal? kalan = tblmalzemeler.KALAN;
        Decimal num2 = num1;
        Decimal? nullable = kalan.HasValue ? new Decimal?(kalan.GetValueOrDefault() - num2) : new Decimal?();
        Decimal num3 = 0M;
        if (nullable.GetValueOrDefault() <= num3 & nullable.HasValue)
        {
          int num4 = (int) XtraMessageBox.Show("Girdiğiniz niktar Depoda kalan miktardan fazla");
        }
      }
    }

    private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (XtraMessageBox.Show(" Silmek istediğinizden eminmisiniz", "UYARI", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
      {
        if (Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID")) == 0 || this.gridView1.GetRowCellValue(rowHandle, "ID") == null)
        {
          this.gridView1.DeleteSelectedRows();
        }
        else
        {
          int id = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
          TBLDEPOFISHRKT sil = this.db.TBLDEPOFISHRKT.FirstOrDefault<TBLDEPOFISHRKT>((Expression<System.Func<TBLDEPOFISHRKT, bool>>) (x => x.ID == id));
          TBLMALZEMELER tblmalzemeler1 = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => (int?) x.ID == sil.MALZEMEID));
          TBLMALZEMELER tblmalzemeler2 = tblmalzemeler1;
          Decimal? nullable1 = tblmalzemeler2.KALAN;
          Decimal? nullable2 = sil.MIKTAR;
          tblmalzemeler2.KALAN = nullable1.HasValue & nullable2.HasValue ? new Decimal?(nullable1.GetValueOrDefault() + nullable2.GetValueOrDefault()) : new Decimal?();
          TBLMALZEMELER tblmalzemeler3 = tblmalzemeler1;
          nullable2 = tblmalzemeler3.CIKIS;
          nullable1 = sil.MIKTAR;
          tblmalzemeler3.CIKIS = nullable2.HasValue & nullable1.HasValue ? new Decimal?(nullable2.GetValueOrDefault() - nullable1.GetValueOrDefault()) : new Decimal?();
          this.db.TBLDEPOFISHRKT.Remove(sil);
          this.db.SaveChanges();
        }
      }
      TBLDEPOFIS entity = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      try
      {
        int id = Convert.ToInt32(entity.EDITUSER);
        this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == id)).SAVEUSER = "1";
        entity.EDITUSER = "";
      }
      catch (Exception ex)
      {
      }
      this.db.TBLDEPOFIS.Remove(entity);
      this.db.SaveChanges();
      ((CikisFisListesi) Application.OpenForms["CikisFisListesi"])?.listele();
      this.Close();
    }

    private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.radioGroup1.SelectedIndex == 1)
      {
        cikisFisiYazdir cikisFisiYazdir = new cikisFisiYazdir();
        cikisFisiYazdir.Parameters["id"].Value = (object) YetkiClass.secim_id;
        cikisFisiYazdir.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) cikisFisiYazdir).Print();
      }
      else
      {
        if (this.radioGroup1.SelectedIndex != 0)
          return;
        cikisFisiYazdir_4a cikisFisiYazdir4a = new cikisFisiYazdir_4a();
        cikisFisiYazdir4a.Parameters["id"].Value = (object) YetkiClass.secim_id;
        cikisFisiYazdir4a.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) cikisFisiYazdir4a).Print();
      }
    }

    private void barEditItem3_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void gridView1_CustomColumnDisplayText(
      object sender,
      CustomColumnDisplayTextEventArgs e)
    {
      if (!(e.Column.Caption == "S.No"))
        return;
      e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
    }

    private void gridView1_CellValueChanged_1(object sender, CellValueChangedEventArgs e)
    {
      GridView gridView = sender as GridView;
      if (e.Column.FieldName == "FIYAT")
      {
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "FIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "TUTAR", (object) num);
      }
      if (!(e.Column.FieldName == "MIKTAR"))
        return;
      Decimal num1 = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "FIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
      this.gridView1.SetRowCellValue(e.RowHandle, "TUTAR", (object) num1);
    }

    private void IsEmriLook_EditValueChanged(object sender, EventArgs e)
    {
      int isEmriID = Convert.ToInt32(this.IsEmriLook.EditValue);
      if (isEmriID == 0)
        return;
      this.labelControl1.Text = this.db.TBLISEMRI.Join((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, (Expression<System.Func<TBLISEMRI, int?>>) (hd => hd.ARACID), (Expression<System.Func<TBLARACLAR, int?>>) (ar => (int?) ar.ID), (hd, ar) => new
      {
        hd = hd,
        ar = ar
      }).Where(data => data.hd.ID == isEmriID).Select(data => data.ar.ARACACIKLAMA).ToList<string>()[0];
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CikisFisDuzenle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
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
      this.barButtonItem22 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem21 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.layoutControl1 = new LayoutControl();
      this.layoutControl4 = new LayoutControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.gridColumn11 = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.MAL = new RepositoryItemLookUpEdit();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.birim = new RepositoryItemLookUpEdit();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.marka = new RepositoryItemLookUpEdit();
      this.tBLMALZMARKABindingSource = new BindingSource(this.components);
      this.gridColumn10 = new GridColumn();
      this.depo = new RepositoryItemLookUpEdit();
      this.tBLMALZDEPOBindingSource = new BindingSource(this.components);
      this.degisimkm = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.simpleButton4 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControlItem12 = new LayoutControlItem();
      this.emptySpaceItem2 = new EmptySpaceItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.dataLayoutControl1 = new DataLayoutControl();
      this.saat = new TimeEdit();
      this.DepoYetkiliLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit3View = new GridView();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.labelControl1 = new LabelControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControlItem16 = new LayoutControlItem();
      this.AlanUstaLook = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn13 = new GridColumn();
      this.tarih = new DateEdit();
      this.FisKoduTxt = new TextEdit();
      this.IsEmriLook = new SearchLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
      this.IsEmriKod = new GridColumn();
      this.IslemYeri = new GridColumn();
      this.Plaka = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.AracAciklama = new GridColumn();
      this.Aciklama = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit2View = new GridView();
      this.PlakaArac = new GridColumn();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem3 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.radioGroup1 = new RadioGroup();
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.tBLMALZMARKATableAdapter = new TBLMALZMARKATableAdapter();
      this.tBLMALZDEPOTableAdapter = new TBLMALZDEPOTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl4.BeginInit();
      this.layoutControl4.SuspendLayout();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.MAL.BeginInit();
      this.birim.BeginInit();
      this.marka.BeginInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).BeginInit();
      this.depo.BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.emptySpaceItem2.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.dataLayoutControl1.BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      this.saat.Properties.BeginInit();
      this.DepoYetkiliLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControlGroup2.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.AlanUstaLook.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.tarih.Properties.CalendarTimeProperties.BeginInit();
      this.tarih.Properties.BeginInit();
      this.FisKoduTxt.Properties.BeginInit();
      this.IsEmriLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.Plaka.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.Aciklama.BeginInit();
      this.repositoryItemSearchLookUpEdit2View.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem11.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.radioGroup1.Properties.BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[33]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
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
        (BarItem) this.barButtonItem22,
        (BarItem) this.barEditItem2,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem21,
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 37;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemRadioGroup1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1259, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem2.Caption = "Sil";
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
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
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
      this.barButtonItem13.Caption = "Önizle";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditWidth = 100;
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
      this.barButtonItem17.Caption = "Yazdır";
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
      this.barButtonItem22.Caption = "Talep Yükle";
      this.barButtonItem22.Id = 29;
      this.barButtonItem22.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.Image");
      this.barButtonItem22.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem22.ImageOptions.LargeImage");
      this.barButtonItem22.LargeWidth = 100;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 120;
      this.barEditItem2.Hint = "Kayıt Bul..";
      this.barEditItem2.Id = 32;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem5.Caption = "Giriş Fişi Ekle";
      this.barButtonItem5.Id = 34;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
      this.barButtonItem21.Caption = "Yazdır";
      this.barButtonItem21.Id = 35;
      this.barButtonItem21.ImageOptions.Image = (Image) Resources.printdialog_16x161;
      this.barButtonItem21.ImageOptions.LargeImage = (Image) Resources.printdialog_32x321;
      this.barButtonItem21.Name = "barButtonItem21";
      this.barButtonItem21.ItemClick += new ItemClickEventHandler(this.barButtonItem21_ItemClick);
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemRadioGroup1;
      this.barEditItem3.EditHeight = 100;
      this.barEditItem3.EditWidth = 200;
      this.barEditItem3.Id = 36;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem3.EditValueChanged += new EventHandler(this.barEditItem3_EditValueChanged);
      this.repositoryItemRadioGroup1.Columns = 2;
      this.repositoryItemRadioGroup1.Items.AddRange(new RadioGroupItem[2]
      {
        new RadioGroupItem((object) true, "a4", true, (object) null, "A4"),
        new RadioGroupItem((object) null, "a5", true, (object) null, "A5")
      });
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup5,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem21);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet7;
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.dataLayoutControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1259, 440);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl4.Controls.Add((Control) this.gridControl1);
      this.layoutControl4.Controls.Add((Control) this.simpleButton4);
      this.layoutControl4.Controls.Add((Control) this.simpleButton1);
      this.layoutControl4.Location = new Point(12, 149);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup4;
      this.layoutControl4.Size = new Size(1235, 279);
      this.layoutControl4.TabIndex = 6;
      this.layoutControl4.Text = "layoutControl4";
      this.gridControl1.Location = new Point(68, 12);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.MAL,
        (RepositoryItem) this.birim,
        (RepositoryItem) this.depo,
        (RepositoryItem) this.marka
      });
      this.gridControl1.Size = new Size(1155, (int) byte.MaxValue);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 9f, FontStyle.Bold);
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 10.2f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.gridColumn11,
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.gridColumn9,
        this.gridColumn10,
        this.degisimkm,
        this.gridColumn12,
        this.gridColumn8
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.CellValueChanged += new CellValueChangedEventHandler(this.gridView1_CellValueChanged_1);
      this.gridView1.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
      this.gridColumn11.Caption = "S.No";
      this.gridColumn11.MinWidth = 21;
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 0;
      this.gridColumn11.Width = 34;
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.MinWidth = 21;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Width = 81;
      this.gridColumn2.Caption = "Malzeme Adı";
      this.gridColumn2.ColumnEdit = (RepositoryItem) this.MAL;
      this.gridColumn2.FieldName = "MALZEMEID";
      this.gridColumn2.MinWidth = 21;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      this.gridColumn2.Width = 138;
      this.MAL.AutoHeight = false;
      this.MAL.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MAL.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.MAL.DisplayMember = "MALZEMEADI";
      this.MAL.Name = "MAL";
      this.MAL.NullText = "";
      this.MAL.ValueMember = "ID";
      this.gridColumn3.Caption = "Açıklama";
      this.gridColumn3.FieldName = "MALZACIKLAMA";
      this.gridColumn3.MinWidth = 21;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      this.gridColumn3.Width = 117;
      this.gridColumn4.Caption = "Birim";
      this.gridColumn4.ColumnEdit = (RepositoryItem) this.birim;
      this.gridColumn4.FieldName = "BIRIMID";
      this.gridColumn4.MinWidth = 21;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 34;
      this.birim.AutoHeight = false;
      this.birim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birim.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.birim.DisplayMember = "BIRIMADI";
      this.birim.Name = "birim";
      this.birim.NullText = "";
      this.birim.ValueMember = "ID";
      this.gridColumn5.Caption = "Miktar";
      this.gridColumn5.FieldName = "MIKTAR";
      this.gridColumn5.MinWidth = 21;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 4;
      this.gridColumn5.Width = 33;
      this.gridColumn6.Caption = "Fiyat";
      this.gridColumn6.FieldName = "FIYAT";
      this.gridColumn6.MinWidth = 21;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 5;
      this.gridColumn6.Width = 33;
      this.gridColumn7.Caption = "Tutar";
      this.gridColumn7.FieldName = "TUTAR";
      this.gridColumn7.MinWidth = 21;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 6;
      this.gridColumn7.Width = 33;
      this.gridColumn9.Caption = "Marka";
      this.gridColumn9.ColumnEdit = (RepositoryItem) this.marka;
      this.gridColumn9.FieldName = "MALZMARKAID";
      this.gridColumn9.MinWidth = 21;
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 7;
      this.gridColumn9.Width = 33;
      this.marka.AutoHeight = false;
      this.marka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.marka.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("MALZMARKA", "Marka", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.marka.DataSource = (object) this.tBLMALZMARKABindingSource;
      this.marka.DisplayMember = "MALZMARKA";
      this.marka.Name = "marka";
      this.marka.NullText = "";
      this.marka.ValueMember = "ID";
      this.tBLMALZMARKABindingSource.DataMember = "TBLMALZMARKA";
      this.tBLMALZMARKABindingSource.DataSource = (object) this.bellDataSet7;
      this.gridColumn10.Caption = "Depo Adı";
      this.gridColumn10.ColumnEdit = (RepositoryItem) this.depo;
      this.gridColumn10.FieldName = "DEPOID";
      this.gridColumn10.MinWidth = 21;
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 11;
      this.gridColumn10.Width = 56;
      this.depo.AutoHeight = false;
      this.depo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depo.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("DEPOADI", "Depo Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.depo.DataSource = (object) this.tBLMALZDEPOBindingSource;
      this.depo.DisplayMember = "DEPOADI";
      this.depo.Name = "depo";
      this.depo.NullText = "";
      this.depo.ValueMember = "ID";
      this.tBLMALZDEPOBindingSource.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource.DataSource = (object) this.bellDataSet7;
      this.degisimkm.Caption = "Değişim Km";
      this.degisimkm.FieldName = "DEGISIMKMSI";
      this.degisimkm.MinWidth = 21;
      this.degisimkm.Name = "degisimkm";
      this.degisimkm.Visible = true;
      this.degisimkm.VisibleIndex = 9;
      this.degisimkm.Width = 58;
      this.gridColumn12.Caption = "Sonraki Km";
      this.gridColumn12.FieldName = "SONRAKIDEGKM";
      this.gridColumn12.MinWidth = 21;
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 10;
      this.gridColumn12.Width = 61;
      this.gridColumn8.Caption = "Seri No";
      this.gridColumn8.FieldName = "MALZSERINO";
      this.gridColumn8.MinWidth = 21;
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 8;
      this.gridColumn8.Width = 51;
      this.simpleButton4.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton4.ImageOptions.Image");
      this.simpleButton4.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton4.Location = new Point(12, 68);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.PaintStyle = PaintStyles.Light;
      this.simpleButton4.Size = new Size(52, 47);
      this.simpleButton4.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton4.TabIndex = 7;
      this.simpleButton4.Click += new EventHandler(this.simpleButton4_Click);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(12, 12);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(52, 52);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl4;
      this.simpleButton1.TabIndex = 4;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.emptySpaceItem2,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(1235, 279);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.simpleButton1;
      this.layoutControlItem12.Location = new Point(0, 0);
      this.layoutControlItem12.MinSize = new Size(36, 32);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(56, 56);
      this.layoutControlItem12.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new Point(0, 107);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new Size(56, 152);
      this.emptySpaceItem2.TextSize = new Size(0, 0);
      this.layoutControlItem15.Control = (Control) this.simpleButton4;
      this.layoutControlItem15.Location = new Point(0, 56);
      this.layoutControlItem15.MinSize = new Size(36, 32);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(56, 51);
      this.layoutControlItem15.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(56, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1159, 259);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.dataLayoutControl1.Controls.Add((Control) this.saat);
      this.dataLayoutControl1.Controls.Add((Control) this.DepoYetkiliLook);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl3);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.AlanUstaLook);
      this.dataLayoutControl1.Controls.Add((Control) this.tarih);
      this.dataLayoutControl1.Controls.Add((Control) this.FisKoduTxt);
      this.dataLayoutControl1.Controls.Add((Control) this.IsEmriLook);
      this.dataLayoutControl1.Location = new Point(12, 12);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.layoutControlGroup1;
      this.dataLayoutControl1.Size = new Size(1235, 133);
      this.dataLayoutControl1.TabIndex = 5;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      this.saat.EditValue = (object) new DateTime(2021, 12, 25, 0, 0, 0, 0);
      this.saat.Location = new Point(163, 82);
      this.saat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saat.Name = "saat";
      this.saat.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saat.Properties.Appearance.Options.UseFont = true;
      this.saat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saat.Size = new Size(208, 24);
      this.saat.StyleController = (IStyleController) this.dataLayoutControl1;
      this.saat.TabIndex = 12;
      this.DepoYetkiliLook.Location = new Point(440, 82);
      this.DepoYetkiliLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.DepoYetkiliLook.Name = "DepoYetkiliLook";
      this.DepoYetkiliLook.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.DepoYetkiliLook.Properties.Appearance.Options.UseFont = true;
      this.DepoYetkiliLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.DepoYetkiliLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.DepoYetkiliLook.Properties.DisplayMember = "ADISOYADI";
      this.DepoYetkiliLook.Properties.NullText = "";
      this.DepoYetkiliLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.DepoYetkiliLook.Properties.ValueMember = "ID";
      this.DepoYetkiliLook.Size = new Size(305, 26);
      this.DepoYetkiliLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.DepoYetkiliLook.TabIndex = 11;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.layoutControl3.Location = new Point(749, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup3;
      this.layoutControl3.Size = new Size(474, 109);
      this.layoutControl3.TabIndex = 10;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(474, 109);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl2.Controls.Add((Control) this.labelControl1);
      this.layoutControl2.Location = new Point(375, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup2;
      this.layoutControl2.Size = new Size(370, 36);
      this.layoutControl2.TabIndex = 9;
      this.layoutControl2.Text = "layoutControl2";
      this.labelControl1.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(12, 12);
      this.labelControl1.Margin = new Padding(3, 2, 3, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(346, 12);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl2;
      this.labelControl1.TabIndex = 4;
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem16
      });
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(370, 36);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControlItem16.Control = (Control) this.labelControl1;
      this.layoutControlItem16.Location = new Point(0, 0);
      this.layoutControlItem16.MinSize = new Size(68, 16);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(350, 16);
      this.layoutControlItem16.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.AlanUstaLook.Location = new Point(440, 52);
      this.AlanUstaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AlanUstaLook.Name = "AlanUstaLook";
      this.AlanUstaLook.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AlanUstaLook.Properties.Appearance.Options.UseFont = true;
      this.AlanUstaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AlanUstaLook.Properties.NullText = "";
      this.AlanUstaLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.AlanUstaLook.Size = new Size(305, 26);
      this.AlanUstaLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.AlanUstaLook.TabIndex = 8;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn13
      });
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn13.Caption = "Adı Soyadı";
      this.gridColumn13.FieldName = "USTAADISOYADI";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 0;
      this.gridColumn13.Width = 64;
      this.tarih.EditValue = (object) null;
      this.tarih.Location = new Point(77, 82);
      this.tarih.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarih.Name = "tarih";
      this.tarih.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarih.Properties.Appearance.Options.UseFont = true;
      this.tarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Size = new Size(82, 26);
      this.tarih.StyleController = (IStyleController) this.dataLayoutControl1;
      this.tarih.TabIndex = 6;
      this.FisKoduTxt.Enabled = false;
      this.FisKoduTxt.Location = new Point(77, 52);
      this.FisKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.FisKoduTxt.Name = "FisKoduTxt";
      this.FisKoduTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.FisKoduTxt.Properties.Appearance.Options.UseFont = true;
      this.FisKoduTxt.Size = new Size(294, 26);
      this.FisKoduTxt.StyleController = (IStyleController) this.dataLayoutControl1;
      this.FisKoduTxt.TabIndex = 5;
      this.IsEmriLook.Location = new Point(77, 12);
      this.IsEmriLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.IsEmriLook.Name = "IsEmriLook";
      this.IsEmriLook.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.IsEmriLook.Properties.Appearance.Options.UseFont = true;
      this.IsEmriLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IsEmriLook.Properties.DataSource = (object) this.tBLISEMRIBindingSource;
      this.IsEmriLook.Properties.DisplayMember = "KOD";
      this.IsEmriLook.Properties.NullText = "";
      this.IsEmriLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.IsEmriLook.Properties.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.Plaka,
        (RepositoryItem) this.Aciklama
      });
      this.IsEmriLook.Properties.ValueMember = "ID";
      this.IsEmriLook.Size = new Size(294, 26);
      this.IsEmriLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.IsEmriLook.TabIndex = 4;
      this.IsEmriLook.EditValueChanged += new EventHandler(this.IsEmriLook_EditValueChanged);
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[4]
      {
        this.IsEmriKod,
        this.IslemYeri,
        this.AracAciklama,
        this.PlakaArac
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.IsEmriKod.Caption = "İş Emri Kod";
      this.IsEmriKod.FieldName = "KOD";
      this.IsEmriKod.Name = "IsEmriKod";
      this.IsEmriKod.Visible = true;
      this.IsEmriKod.VisibleIndex = 0;
      this.IslemYeri.Caption = "İşlem Yeri";
      this.IslemYeri.FieldName = "BOLUMADI";
      this.IslemYeri.Name = "IslemYeri";
      this.IslemYeri.Visible = true;
      this.IslemYeri.VisibleIndex = 1;
      this.Plaka.AutoHeight = false;
      this.Plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Plaka.DisplayMember = "PLAKA";
      this.Plaka.Name = "Plaka";
      this.Plaka.NullText = "";
      this.Plaka.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.Plaka.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.AracAciklama.Caption = "Araç Açıklama";
      this.AracAciklama.FieldName = "ARACACIKLAMA";
      this.AracAciklama.Name = "AracAciklama";
      this.AracAciklama.Visible = true;
      this.AracAciklama.VisibleIndex = 2;
      this.Aciklama.AutoHeight = false;
      this.Aciklama.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Aciklama.DisplayMember = "ARACACIKLAMA";
      this.Aciklama.Name = "Aciklama";
      this.Aciklama.NullText = "";
      this.Aciklama.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit2View;
      this.Aciklama.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
      this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.PlakaArac.Caption = "Plaka";
      this.PlakaArac.FieldName = "PLAKA";
      this.PlakaArac.Name = "PlakaArac";
      this.PlakaArac.Visible = true;
      this.PlakaArac.VisibleIndex = 3;
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[9]
      {
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem6
      });
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(1235, 133);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.IsEmriLook;
      this.layoutControlItem3.Location = new Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(363, 40);
      this.layoutControlItem3.Text = "İş Emri";
      this.layoutControlItem3.TextSize = new Size(62, 13);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 100);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(737, 13);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem4.Control = (Control) this.FisKoduTxt;
      this.layoutControlItem4.Location = new Point(0, 40);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(363, 30);
      this.layoutControlItem4.Text = "Fiş Kodu";
      this.layoutControlItem4.TextSize = new Size(62, 13);
      this.layoutControlItem5.Control = (Control) this.tarih;
      this.layoutControlItem5.Location = new Point(0, 70);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(151, 30);
      this.layoutControlItem5.Text = "Tarih/Saat";
      this.layoutControlItem5.TextSize = new Size(62, 13);
      this.layoutControlItem7.Control = (Control) this.AlanUstaLook;
      this.layoutControlItem7.Location = new Point(363, 40);
      this.layoutControlItem7.MinSize = new Size(116, 24);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(374, 30);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Alan Usta";
      this.layoutControlItem7.TextSize = new Size(62, 13);
      this.layoutControlItem8.Control = (Control) this.layoutControl2;
      this.layoutControlItem8.Location = new Point(363, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(374, 40);
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.layoutControl3;
      this.layoutControlItem9.Location = new Point(737, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(478, 113);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.DepoYetkiliLook;
      this.layoutControlItem10.Location = new Point(363, 70);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(374, 30);
      this.layoutControlItem10.Text = "Depo Yetkilisi";
      this.layoutControlItem10.TextSize = new Size(62, 13);
      this.layoutControlItem6.Control = (Control) this.saat;
      this.layoutControlItem6.Location = new Point(151, 70);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(212, 30);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem11
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1259, 440);
      this.Root.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.dataLayoutControl1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1239, 137);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.layoutControl4;
      this.layoutControlItem11.Location = new Point(0, 137);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(1239, 283);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.radioGroup1.Location = new Point(584, 10);
      this.radioGroup1.Margin = new Padding(3, 2, 3, 2);
      this.radioGroup1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.radioGroup1.Name = "radioGroup1";
      this.radioGroup1.Properties.Appearance.BackColor = Color.Silver;
      this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
      this.radioGroup1.Properties.Items.AddRange(new RadioGroupItem[2]
      {
        new RadioGroupItem((object) null, "A4", true, (object) null, "A4"),
        new RadioGroupItem((object) null, "A5", true, (object) null, "A5")
      });
      this.radioGroup1.Size = new Size(86, 78);
      this.radioGroup1.TabIndex = 4;
      this.radioGroup1.SelectedIndexChanged += new EventHandler(this.radioGroup1_SelectedIndexChanged);
      this.tBLMALZMARKATableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1259, 540);
      this.Controls.Add((Control) this.radioGroup1);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (CikisFisDuzenle);
      this.Text = "Çıkış Fişi Düzenleme";
      this.Load += new EventHandler(this.GirisFisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl4.EndInit();
      this.layoutControl4.ResumeLayout(false);
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.MAL.EndInit();
      this.birim.EndInit();
      this.marka.EndInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).EndInit();
      this.depo.EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControlItem12.EndInit();
      this.emptySpaceItem2.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem1.EndInit();
      this.dataLayoutControl1.EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      this.saat.Properties.EndInit();
      this.DepoYetkiliLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControlGroup2.EndInit();
      this.layoutControlItem16.EndInit();
      this.AlanUstaLook.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.tarih.Properties.CalendarTimeProperties.EndInit();
      this.tarih.Properties.EndInit();
      this.FisKoduTxt.Properties.EndInit();
      this.IsEmriLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.Plaka.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.Aciklama.EndInit();
      this.repositoryItemSearchLookUpEdit2View.EndInit();
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem3.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem6.EndInit();
      this.Root.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem11.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.radioGroup1.Properties.EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
