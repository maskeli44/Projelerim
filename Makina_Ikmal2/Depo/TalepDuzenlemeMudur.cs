// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.TalepDuzenlemeMudur
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.DepoModel;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class TalepDuzenlemeMudur : XtraForm
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
    private EmptySpaceItem emptySpaceItem1;
    private GridControl gridControl1;
    private GridView gridView4;
    private BarButtonItem barButtonItem8;
    private LabelControl labelControl1;
    private TextEdit fisKoduTxt;
    private LookUpEdit talepedenustaloop;
    private LookUpEdit depoyetkiliLoop;
    private DateEdit tarihdate;
    private TimeSpanEdit saattime;
    private LookUpEdit atolyeSefiLook;
    private LookUpEdit subemudurLoop;
    private LookUpEdit karsilayanfirmaLoop;
    private LabelControl labelControl2;
    private LabelControl labelControl3;
    private LabelControl labelControl4;
    private LabelControl labelControl5;
    private LabelControl labelControl6;
    private LabelControl labelControl7;
    private LabelControl labelControl8;
    private LabelControl labelControl9;
    private CheckEdit checkEdit1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private talepEmirliste talepEmirliste;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.Model.talepEmirlisteTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private SearchLookUpEdit isemriSearchLoop;
    private GridView searchLookUpEdit1View;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private LabelControl aracaciklamaLabel;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl2;
    private SimpleButton simpleButton1;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem3;
    private EmptySpaceItem emptySpaceItem2;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private SimpleButton simpleButton2;
    private LayoutControlItem layoutControlItem4;
    private SimpleButton simpleButton3;
    private LayoutControlItem layoutControlItem5;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private RepositoryItemLookUpEdit birimadi;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private CheckBox checkBox1;
    private TextEdit iptalaciklamaTxt;
    private BindingSource dataTable1BindingSource1;
    private talephkrtduzenleme talephkrtduzenleme;
    private GridColumn colID;
    private GridColumn colMALZEMEID;
    private GridColumn colBIRIMID;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn colMALZACIKLAMA;
    private GridColumn coldepofisId;
    private Makina_Ikmal.DepoModel.talephkrtduzenlemeTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;

    public TalepDuzenlemeMudur() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet5.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet5.TBLMALZEMELER);
      this.dataTable1TableAdapter.Fill(this.talepEmirliste.DataTable1);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet5.TBLFIRMALAR);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet5.TBLATOLYEUSTALAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet5.TBLISEMRI);
      this.isemriSearchLoop.Properties.DataSource = (object) this.db.TBLISEMRI.Join((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, (Expression<System.Func<TBLISEMRI, int?>>) (hd => hd.ARACID), (Expression<System.Func<TBLARACLAR, int?>>) (ht => (int?) ht.ID), (hd, ht) => new
      {
        hd = hd,
        ht = ht
      }).Join((IEnumerable<TBLISEMIRDURUM>) this.db.TBLISEMIRDURUM, data => data.hd.ISEMRIDURUMID, (Expression<System.Func<TBLISEMIRDURUM, int?>>) (hy => (int?) hy.ID), (data, hy) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        hy = hy
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier0.hd.ISEMRIDURUMID != (int?) 4).Select(data => new
      {
        ARACID = data.\u003C\u003Eh__TransparentIdentifier0.hd.ARACID,
        KOD = data.\u003C\u003Eh__TransparentIdentifier0.hd.KOD,
        ARACACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier0.ht.ARACACIKLAMA,
        PLAKA = data.\u003C\u003Eh__TransparentIdentifier0.ht.PLAKA,
        ADI = data.hy.ADI,
        ID = data.\u003C\u003Eh__TransparentIdentifier0.hd.ID
      }).ToList();
      this.isemriSearchLoop.Properties.DisplayMember = "KOD";
      this.isemriSearchLoop.Properties.ValueMember = "ID";
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void degerleri()
    {
    }

    private void guncelle()
    {
      try
      {
        TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
        tbltalepfis.ATOLYESEFID = new int?(Convert.ToInt32(this.atolyeSefiLook.EditValue));
        tbltalepfis.DEPOYETKILIID = new int?(Convert.ToInt32(this.depoyetkiliLoop.EditValue));
        tbltalepfis.FIRMAID = new int?(Convert.ToInt32(this.karsilayanfirmaLoop.EditValue));
        int deger = Convert.ToInt32(this.isemriSearchLoop.EditValue);
        TBLISEMRI tblisemri = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == deger));
        tbltalepfis.ISEMRIID = new int?(tblisemri.ID);
        tbltalepfis.MUDURID = new int?(Convert.ToInt32(this.subemudurLoop.EditValue));
        tbltalepfis.TARIH = new DateTime?(Convert.ToDateTime(this.tarihdate.EditValue));
        tbltalepfis.TALEPEDENUSTAID = new int?(Convert.ToInt32(this.talepedenustaloop.EditValue));
        tbltalepfis.ISEMRIID = new int?(Convert.ToInt32(this.isemriSearchLoop.EditValue));
        tbltalepfis.TALEPDURUMID = !this.checkBox1.Checked ? new int?(1) : new int?(2);
        this.db.SaveChanges();
        for (int rowHandle = 0; rowHandle < this.gridView4.DataRowCount; ++rowHandle)
        {
          try
          {
            int idff = Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "ID"));
            TBLTALEPFISHRKT tbltalepfishrkt = this.db.TBLTALEPFISHRKT.FirstOrDefault<TBLTALEPFISHRKT>((Expression<System.Func<TBLTALEPFISHRKT, bool>>) (x => x.ID == idff));
            tbltalepfishrkt.BIRIMID = new int?(Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "BIRIMID")));
            tbltalepfishrkt.MALZEMEID = new int?(Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "MALZEMEID")));
            tbltalepfishrkt.MIKTAR = new Decimal?((Decimal) Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "MIKTAR")));
            tbltalepfishrkt.FIYAT = new Decimal?(Convert.ToDecimal(this.gridView4.GetRowCellValue(rowHandle, "FIYAT")));
            tbltalepfishrkt.TUTAR = new Decimal?((Decimal) Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "TUTAR")));
            tbltalepfishrkt.ISTENENMIKTAR = new Decimal?((Decimal) Convert.ToInt32(this.gridView4.GetRowCellValue(rowHandle, "ISTENENMIKTAR")));
            tbltalepfishrkt.MALZACIKLAMA = this.gridView4.GetRowCellValue(rowHandle, "MALZACIKLAMA").ToString();
            this.db.SaveChanges();
          }
          catch (Exception ex)
          {
          }
        }
        int num = (int) XtraMessageBox.Show("Kayıt başarlı bir şekilde alındı");
      }
      catch (Exception ex)
      {
      }
    }

    private void sil()
    {
    }

    private void listele()
    {
      TBLISEMRI sorgu = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => x.ID == YetkiClass.secim_id));
      IQueryable<\u003C\u003Ef__AnonymousType38<\u003C\u003Ef__AnonymousType37<\u003C\u003Ef__AnonymousType36<TBLTALEPFISHRKT, TBLDEPOFIS>, TBLMALZBIRIM>, TBLMALZEMELER>> source = this.db.TBLTALEPFISHRKT.Join((IEnumerable<TBLDEPOFIS>) this.db.TBLDEPOFIS, (Expression<System.Func<TBLTALEPFISHRKT, int?>>) (hd => hd.TALEPFISID), (Expression<System.Func<TBLDEPOFIS, int?>>) (den => (int?) den.ID), (hd, den) => new
      {
        hd = hd,
        den = den
      }).Join((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, data => data.hd.BIRIMID, (Expression<System.Func<TBLMALZBIRIM, int?>>) (y => (int?) y.ID), (data, y) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        y = y
      }).Join((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.\u003C\u003Eh__TransparentIdentifier0.hd.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (t => (int?) t.ID), (data, t) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        t = t
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.den.ISEMRIID == (int?) sorgu.ID);
      Expression<System.Func<\u003C\u003Ef__AnonymousType38<\u003C\u003Ef__AnonymousType37<\u003C\u003Ef__AnonymousType36<TBLTALEPFISHRKT, TBLDEPOFIS>, TBLMALZBIRIM>, TBLMALZEMELER>, \u003C\u003Ef__AnonymousType43<string, int?, int?, string, string, Decimal?, Decimal?, Decimal?>>> selector = data => new
      {
        MALZEMEADI = data.t.MALZEMEADI,
        MALZEMEID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MALZEMEID,
        BIRIMID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.BIRIMID,
        MALZACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MALZACIKLAMA,
        BIRIMADI = data.\u003C\u003Eh__TransparentIdentifier1.y.BIRIMADI,
        MIKTAR = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MIKTAR,
        FIYAT = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.FIYAT,
        TUTAR = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TUTAR
      };
      foreach (var data in source.Select(selector))
        MalzemeDegerAktarma.list.Add(new ElemanlarDurum1()
        {
          MALZEMEID = Convert.ToInt32((object) data.MALZEMEID),
          MALZACIKLAMA = data.MALZACIKLAMA,
          BIRIMID = Convert.ToInt32((object) data.BIRIMID),
          FIYAT = Convert.ToDecimal((object) data.FIYAT),
          MIKTAR = Convert.ToDecimal((object) data.MIKTAR),
          TUTAR = Convert.ToDecimal((object) data.TUTAR)
        });
      this.gridControl1.DataSource = (object) MalzemeDegerAktarma.list.ToList<ElemanlarDurum1>();
    }

    private void listele(int deger)
    {
      IQueryable<\u003C\u003Ef__AnonymousType23<\u003C\u003Ef__AnonymousType22<TBLTALEPFISHRKT, TBLMALZBIRIM>, TBLMALZEMELER>> source = this.db.TBLTALEPFISHRKT.Join((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, (Expression<System.Func<TBLTALEPFISHRKT, int?>>) (hd => hd.BIRIMID), (Expression<System.Func<TBLMALZBIRIM, int?>>) (y => (int?) y.ID), (hd, y) => new
      {
        hd = hd,
        y = y
      }).Join((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.hd.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (t => (int?) t.ID), (data, t) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        t = t
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier0.hd.TALEPFISID == (int?) deger);
      Expression<System.Func<\u003C\u003Ef__AnonymousType23<\u003C\u003Ef__AnonymousType22<TBLTALEPFISHRKT, TBLMALZBIRIM>, TBLMALZEMELER>, \u003C\u003Ef__AnonymousType43<string, int?, int?, string, string, Decimal?, Decimal?, Decimal?>>> selector = data => new
      {
        MALZEMEADI = data.t.MALZEMEADI,
        MALZEMEID = data.\u003C\u003Eh__TransparentIdentifier0.hd.MALZEMEID,
        BIRIMID = data.\u003C\u003Eh__TransparentIdentifier0.hd.BIRIMID,
        MALZACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier0.hd.MALZACIKLAMA,
        BIRIMADI = data.\u003C\u003Eh__TransparentIdentifier0.y.BIRIMADI,
        MIKTAR = data.\u003C\u003Eh__TransparentIdentifier0.hd.MIKTAR,
        FIYAT = data.\u003C\u003Eh__TransparentIdentifier0.hd.FIYAT,
        TUTAR = data.\u003C\u003Eh__TransparentIdentifier0.hd.TUTAR
      };
      foreach (var data in source.Select(selector))
        MalzemeDegerAktarma.list.Add(new ElemanlarDurum1()
        {
          MALZEMEID = Convert.ToInt32((object) data.MALZEMEID),
          MALZACIKLAMA = data.MALZACIKLAMA,
          BIRIMID = Convert.ToInt32((object) data.BIRIMID),
          FIYAT = Convert.ToDecimal((object) data.FIYAT),
          MIKTAR = Convert.ToDecimal((object) data.MIKTAR),
          TUTAR = Convert.ToDecimal((object) data.TUTAR)
        });
      this.gridControl1.DataSource = (object) MalzemeDegerAktarma.list.ToList<ElemanlarDurum1>();
    }

    public void liste() => this.gridControl1.DataSource = (object) MalzemeDegerAktarma.list.ToList<ElemanlarDurum1>();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelle();
      LogEkle.Logs("Guncelleme Yapti");
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void guncelleload()
    {
      this.dataTable1TableAdapter1.Fill(this.talephkrtduzenleme.DataTable1, YetkiClass.secim_id);
      TBLTALEPFIS sorgu = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      TBLISEMRI isemri = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => (int?) x.ID == sorgu.ISEMRIID));
      TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => (int?) x.ID == isemri.ARACID));
      this.fisKoduTxt.Text = sorgu.KOD;
      this.tarihdate.EditValue = (object) sorgu.TARIH;
      this.talepedenustaloop.EditValue = (object) sorgu.TALEPEDENUSTAID;
      this.atolyeSefiLook.EditValue = (object) sorgu.ATOLYESEFID;
      this.isemriSearchLoop.EditValue = (object) sorgu.ISEMRIID;
      this.depoyetkiliLoop.EditValue = (object) sorgu.DEPOYETKILIID;
      this.subemudurLoop.EditValue = (object) sorgu.MUDURID;
      this.aracaciklamaLabel.Text = tblaraclar.ARACACIKLAMA;
      this.karsilayanfirmaLoop.EditValue = (object) sorgu.FIRMAID;
      this.isemriSearchLoop.Enabled = false;
      this.simpleButton1.Enabled = false;
      this.simpleButton2.Enabled = false;
      this.simpleButton3.Enabled = false;
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
      switch (YetkiClass.secim)
      {
        case "kayit":
          this.listele(Convert.ToInt32(this.isemriSearchLoop.EditValue));
          break;
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new MalzemeListesi().ShowDialog();
    }

    private void searchLookUpEdit1View_Click(object sender, EventArgs e) => this.aracaciklamaLabel.Text = (sender as GridView).GetFocusedRowCellValue("ARACACIKLAMA").ToString();

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox1.Checked)
        return;
      this.iptalaciklamaTxt.Enabled = true;
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      talepfisrapor talepfisrapor = new talepfisrapor();
      talepfisrapor.Parameters["id"].Value = (object) YetkiClass.secim_id;
      talepfisrapor.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) talepfisrapor).ShowPreviewDialog();
    }

    private void gridView4_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      GridView gridView = sender as GridView;
      if (e.Column.FieldName == "FIYAT")
      {
        Decimal num = Convert.ToDecimal(this.gridView4.GetRowCellValue(e.RowHandle, " FIYAT")) * Convert.ToDecimal(this.gridView4.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView4.SetRowCellValue(e.RowHandle, "TUTAR", (object) num);
      }
      else
      {
        if (!(e.Column.FieldName == "MIKTAR"))
          return;
        Decimal num = Convert.ToDecimal(this.gridView4.GetRowCellValue(e.RowHandle, "FIYAT")) * Convert.ToDecimal(this.gridView4.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView4.SetRowCellValue(e.RowHandle, "TUTAR", (object) num);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepDuzenleme));
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
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.talephkrtduzenleme = new talephkrtduzenleme();
      this.gridView4 = new GridView();
      this.colID = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colBIRIMID = new GridColumn();
      this.birimadi = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colMALZACIKLAMA = new GridColumn();
      this.coldepofisId = new GridColumn();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.talepEmirliste = new talepEmirliste();
      this.labelControl1 = new LabelControl();
      this.fisKoduTxt = new TextEdit();
      this.talepedenustaloop = new LookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.depoyetkiliLoop = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.tarihdate = new DateEdit();
      this.saattime = new TimeSpanEdit();
      this.atolyeSefiLook = new LookUpEdit();
      this.subemudurLoop = new LookUpEdit();
      this.karsilayanfirmaLoop = new LookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.labelControl2 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.labelControl4 = new LabelControl();
      this.labelControl5 = new LabelControl();
      this.labelControl6 = new LabelControl();
      this.labelControl7 = new LabelControl();
      this.labelControl8 = new LabelControl();
      this.labelControl9 = new LabelControl();
      this.checkEdit1 = new CheckEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.talepEmirlisteTableAdapters.DataTable1TableAdapter();
      this.isemriSearchLoop = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.aracaciklamaLabel = new LabelControl();
      this.layoutControl1 = new LayoutControl();
      this.layoutControl2 = new LayoutControl();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem3 = new LayoutControlItem();
      this.emptySpaceItem2 = new EmptySpaceItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.checkBox1 = new CheckBox();
      this.iptalaciklamaTxt = new TextEdit();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.DepoModel.talephkrtduzenlemeTableAdapters.DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.talephkrtduzenleme.BeginInit();
      this.gridView4.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.birimadi.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.talepEmirliste.BeginInit();
      this.fisKoduTxt.Properties.BeginInit();
      this.talepedenustaloop.Properties.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.depoyetkiliLoop.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.tarihdate.Properties.CalendarTimeProperties.BeginInit();
      this.tarihdate.Properties.BeginInit();
      this.saattime.Properties.BeginInit();
      this.atolyeSefiLook.Properties.BeginInit();
      this.subemudurLoop.Properties.BeginInit();
      this.karsilayanfirmaLoop.Properties.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.checkEdit1.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.isemriSearchLoop.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.emptySpaceItem2.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.iptalaciklamaTxt.Properties.BeginInit();
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
      this.ribbonControl1.Size = new Size(1316, 122);
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
      this.barButtonItem8.Caption = "Temizle";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) Resources.resetmodeldifferences_16x16;
      this.barButtonItem8.ImageOptions.LargeImage = (Image) Resources.resetmodeldifferences_32x32;
      this.barButtonItem8.LargeWidth = 100;
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Location = new Point(102, 12);
      this.gridControl1.MainView = (BaseView) this.gridView4;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.birimadi
      });
      this.gridControl1.Size = new Size(1105, 464);
      this.gridControl1.TabIndex = 3;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.talephkrtduzenleme;
      this.talephkrtduzenleme.DataSetName = "talephkrtduzenleme";
      this.talephkrtduzenleme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView4.Appearance.Row.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView4.Appearance.Row.Options.UseFont = true;
      this.gridView4.Columns.AddRange(new GridColumn[8]
      {
        this.colID,
        this.colMALZEMEID,
        this.colBIRIMID,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.colMALZACIKLAMA,
        this.coldepofisId
      });
      this.gridView4.GridControl = this.gridControl1;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ShowFooter = true;
      this.gridView4.CellValueChanged += new CellValueChangedEventHandler(this.gridView4_CellValueChanged);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Width = 94;
      this.colMALZEMEID.Caption = "Malzeme Adı";
      this.colMALZEMEID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.MinWidth = 25;
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 0;
      this.colMALZEMEID.Width = 278;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "MALZEMEADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.birimadi;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 25;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 2;
      this.colBIRIMID.Width = 126;
      this.birimadi.AutoHeight = false;
      this.birimadi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimadi.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.birimadi.DisplayMember = "BIRIMADI";
      this.birimadi.Name = "birimadi";
      this.birimadi.NullText = "";
      this.birimadi.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 25;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 3;
      this.colMIKTAR.Width = 107;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 25;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 4;
      this.colFIYAT.Width = 107;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 25;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 5;
      this.colTUTAR.Width = 111;
      this.colMALZACIKLAMA.Caption = "Açıklama";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.MinWidth = 25;
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 1;
      this.colMALZACIKLAMA.Width = 189;
      this.coldepofisId.FieldName = "depofisId";
      this.coldepofisId.MinWidth = 25;
      this.coldepofisId.Name = "coldepofisId";
      this.coldepofisId.Width = 94;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.talepEmirliste;
      this.talepEmirliste.DataSetName = "talepEmirliste";
      this.talepEmirliste.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(123, 141);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(59, 25);
      this.labelControl1.TabIndex = 5;
      this.labelControl1.Text = "İş Emri";
      this.fisKoduTxt.Enabled = false;
      this.fisKoduTxt.Location = new Point(188, 176);
      this.fisKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisKoduTxt.Name = "fisKoduTxt";
      this.fisKoduTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.fisKoduTxt.Properties.Appearance.Options.UseFont = true;
      this.fisKoduTxt.Size = new Size(161, 32);
      this.fisKoduTxt.TabIndex = 6;
      this.talepedenustaloop.Location = new Point(597, 169);
      this.talepedenustaloop.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.talepedenustaloop.Name = "talepedenustaloop";
      this.talepedenustaloop.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.talepedenustaloop.Properties.Appearance.Options.UseFont = true;
      this.talepedenustaloop.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.talepedenustaloop.Properties.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.talepedenustaloop.Properties.DisplayMember = "USTAADISOYADI";
      this.talepedenustaloop.Properties.NullText = "";
      this.talepedenustaloop.Properties.ValueMember = "ID";
      this.talepedenustaloop.Size = new Size(273, 32);
      this.talepedenustaloop.TabIndex = 7;
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet5;
      this.depoyetkiliLoop.Location = new Point(1024, 169);
      this.depoyetkiliLoop.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.depoyetkiliLoop.Name = "depoyetkiliLoop";
      this.depoyetkiliLoop.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.depoyetkiliLoop.Properties.Appearance.Options.UseFont = true;
      this.depoyetkiliLoop.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depoyetkiliLoop.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.depoyetkiliLoop.Properties.DisplayMember = "ADI";
      this.depoyetkiliLoop.Properties.NullText = "";
      this.depoyetkiliLoop.Properties.ValueMember = "ID";
      this.depoyetkiliLoop.Size = new Size(267, 32);
      this.depoyetkiliLoop.TabIndex = 8;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.tarihdate.EditValue = (object) null;
      this.tarihdate.Location = new Point(188, 214);
      this.tarihdate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihdate.Name = "tarihdate";
      this.tarihdate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarihdate.Properties.Appearance.Options.UseFont = true;
      this.tarihdate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihdate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihdate.Size = new Size(161, 32);
      this.tarihdate.TabIndex = 9;
      this.saattime.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.saattime.Location = new Point(400, 214);
      this.saattime.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saattime.Name = "saattime";
      this.saattime.Properties.AllowEditDays = false;
      this.saattime.Properties.AllowEditSeconds = false;
      this.saattime.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saattime.Properties.Appearance.Options.UseFont = true;
      this.saattime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saattime.Properties.Mask.EditMask = "t";
      this.saattime.Size = new Size(79, 32);
      this.saattime.TabIndex = 10;
      this.atolyeSefiLook.Location = new Point(597, 214);
      this.atolyeSefiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyeSefiLook.Name = "atolyeSefiLook";
      this.atolyeSefiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyeSefiLook.Properties.Appearance.Options.UseFont = true;
      this.atolyeSefiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyeSefiLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.atolyeSefiLook.Properties.DisplayMember = "ADISOYADI";
      this.atolyeSefiLook.Properties.NullText = "";
      this.atolyeSefiLook.Properties.ValueMember = "ID";
      this.atolyeSefiLook.Size = new Size(273, 32);
      this.atolyeSefiLook.TabIndex = 11;
      this.subemudurLoop.Location = new Point(1026, 210);
      this.subemudurLoop.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.subemudurLoop.Name = "subemudurLoop";
      this.subemudurLoop.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.subemudurLoop.Properties.Appearance.Options.UseFont = true;
      this.subemudurLoop.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.subemudurLoop.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.subemudurLoop.Properties.DisplayMember = "ADI";
      this.subemudurLoop.Properties.NullText = "";
      this.subemudurLoop.Properties.ValueMember = "ID";
      this.subemudurLoop.Size = new Size(265, 32);
      this.subemudurLoop.TabIndex = 12;
      this.karsilayanfirmaLoop.Location = new Point(188, 253);
      this.karsilayanfirmaLoop.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.karsilayanfirmaLoop.Name = "karsilayanfirmaLoop";
      this.karsilayanfirmaLoop.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.karsilayanfirmaLoop.Properties.Appearance.Options.UseFont = true;
      this.karsilayanfirmaLoop.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.karsilayanfirmaLoop.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.karsilayanfirmaLoop.Properties.DisplayMember = "FIRMAADI";
      this.karsilayanfirmaLoop.Properties.NullText = "";
      this.karsilayanfirmaLoop.Properties.ValueMember = "ID";
      this.karsilayanfirmaLoop.Size = new Size(682, 32);
      this.karsilayanfirmaLoop.TabIndex = 13;
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet5;
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(104, 181);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(78, 25);
      this.labelControl2.TabIndex = 5;
      this.labelControl2.Text = "Fiş Kodu";
      this.labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(137, 221);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(45, 25);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Tarih";
      this.labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(355, 217);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(42, 25);
      this.labelControl4.TabIndex = 5;
      this.labelControl4.Text = "Saat";
      this.labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(443, 172);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(146, 25);
      this.labelControl5.TabIndex = 5;
      this.labelControl5.Text = "Talep Eden Usta";
      this.labelControl6.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(901, 213);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(119, 25);
      this.labelControl6.TabIndex = 5;
      this.labelControl6.Text = "Şube Müdürü";
      this.labelControl7.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(494, 217);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(94, 25);
      this.labelControl7.TabIndex = 5;
      this.labelControl7.Text = "Atölye Şefi";
      this.labelControl8.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(901, 172);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(117, 25);
      this.labelControl8.TabIndex = 5;
      this.labelControl8.Text = "Depo Yetkilisi";
      this.labelControl9.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(36, 256);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(146, 25);
      this.labelControl9.TabIndex = 5;
      this.labelControl9.Text = "Karşılayan Firma";
      this.checkEdit1.Location = new Point(1035, 256);
      this.checkEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.checkEdit1.Name = "checkEdit1";
      this.checkEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkEdit1.Properties.Appearance.Options.UseFont = true;
      this.checkEdit1.Properties.Caption = "Müdür Onay";
      this.checkEdit1.Size = new Size(166, 29);
      this.checkEdit1.TabIndex = 14;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.isemriSearchLoop.Location = new Point(189, 140);
      this.isemriSearchLoop.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isemriSearchLoop.Name = "isemriSearchLoop";
      this.isemriSearchLoop.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemriSearchLoop.Properties.Appearance.Options.UseFont = true;
      this.isemriSearchLoop.Properties.AppearanceDropDown.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isemriSearchLoop.Properties.AppearanceDropDown.Options.UseFont = true;
      this.isemriSearchLoop.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isemriSearchLoop.Properties.NullText = "";
      this.isemriSearchLoop.Properties.PopupFormMinSize = new Size(800, 0);
      this.isemriSearchLoop.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.isemriSearchLoop.Size = new Size(160, 32);
      this.isemriSearchLoop.TabIndex = 16;
      this.isemriSearchLoop.EditValueChanged += new EventHandler(this.searchLookUpEdit1_EditValueChanged);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[4]
      {
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 900;
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.RowAutoHeight = true;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit1View.RowHeight = 35;
      this.searchLookUpEdit1View.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn1, ColumnSortOrder.Descending)
      });
      this.searchLookUpEdit1View.ViewCaptionHeight = 40;
      this.searchLookUpEdit1View.Click += new EventHandler(this.searchLookUpEdit1View_Click);
      this.gridColumn1.AppearanceCell.Font = new Font("Tahoma", 12f);
      this.gridColumn1.AppearanceCell.Options.UseFont = true;
      this.gridColumn1.AppearanceHeader.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.gridColumn1.AppearanceHeader.Options.UseFont = true;
      this.gridColumn1.Caption = "gridColumn1";
      this.gridColumn1.FieldName = "KOD";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 142;
      this.gridColumn2.AppearanceCell.Font = new Font("Tahoma", 12f);
      this.gridColumn2.AppearanceCell.Options.UseFont = true;
      this.gridColumn2.AppearanceHeader.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.gridColumn2.AppearanceHeader.Options.UseFont = true;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.FieldName = "PLAKA";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      this.gridColumn2.Width = 163;
      this.gridColumn3.AppearanceCell.Font = new Font("Tahoma", 12f);
      this.gridColumn3.AppearanceCell.Options.UseFont = true;
      this.gridColumn3.AppearanceHeader.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.gridColumn3.AppearanceHeader.Options.UseFont = true;
      this.gridColumn3.Caption = "gridColumn3";
      this.gridColumn3.FieldName = "ARACACIKLAMA";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      this.gridColumn3.Width = 352;
      this.gridColumn4.AppearanceCell.Font = new Font("Tahoma", 12f);
      this.gridColumn4.AppearanceCell.Options.UseFont = true;
      this.gridColumn4.AppearanceHeader.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.gridColumn4.AppearanceHeader.Options.UseFont = true;
      this.gridColumn4.Caption = "gridColumn4";
      this.gridColumn4.FieldName = "ID";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 140;
      this.aracaciklamaLabel.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracaciklamaLabel.Appearance.Options.UseFont = true;
      this.aracaciklamaLabel.Location = new Point(366, 143);
      this.aracaciklamaLabel.Name = "aracaciklamaLabel";
      this.aracaciklamaLabel.Size = new Size(0, 25);
      this.aracaciklamaLabel.TabIndex = 5;
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Location = new Point(13, 301);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1219, 488);
      this.layoutControl1.TabIndex = 18;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl2.Controls.Add((Control) this.simpleButton3);
      this.layoutControl2.Controls.Add((Control) this.simpleButton2);
      this.layoutControl2.Controls.Add((Control) this.simpleButton1);
      this.layoutControl2.Location = new Point(12, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(86, 464);
      this.layoutControl2.TabIndex = 4;
      this.layoutControl2.Text = "layoutControl2";
      this.simpleButton3.Enabled = false;
      this.simpleButton3.ImageOptions.Image = (Image) Resources.clearvalidationcircles_32x32;
      this.simpleButton3.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton3.Location = new Point(12, 170);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(62, 66);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton3.TabIndex = 6;
      this.simpleButton2.Enabled = false;
      this.simpleButton2.ImageOptions.Image = (Image) Resources.addnewdatasource_32x32;
      this.simpleButton2.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton2.Location = new Point(12, 98);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(62, 68);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton2.TabIndex = 5;
      this.simpleButton1.Enabled = false;
      this.simpleButton1.ImageOptions.Image = (Image) Resources.addparagraphtotableofcontents_32x32;
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(12, 12);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(62, 82);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton1.TabIndex = 4;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.emptySpaceItem2,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5
      });
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(86, 464);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.simpleButton1;
      this.layoutControlItem3.Location = new Point(0, 0);
      this.layoutControlItem3.MinSize = new Size(42, 40);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(66, 86);
      this.layoutControlItem3.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new Point(0, 228);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new Size(66, 216);
      this.emptySpaceItem2.TextSize = new Size(0, 0);
      this.layoutControlItem4.Control = (Control) this.simpleButton2;
      this.layoutControlItem4.Location = new Point(0, 86);
      this.layoutControlItem4.MinSize = new Size(42, 40);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(66, 72);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem5.Control = (Control) this.simpleButton3;
      this.layoutControlItem5.Location = new Point(0, 158);
      this.layoutControlItem5.MinSize = new Size(42, 40);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(66, 70);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1219, 488);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(90, 0);
      this.layoutControlItem1.MinSize = new Size(104, 24);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1109, 468);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.layoutControl2;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(90, 468);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkBox1.Location = new Point(77, 800);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(129, 28);
      this.checkBox1.TabIndex = 20;
      this.checkBox1.Text = "Talep İptal";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.iptalaciklamaTxt.Enabled = false;
      this.iptalaciklamaTxt.Location = new Point(216, 799);
      this.iptalaciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.iptalaciklamaTxt.Name = "iptalaciklamaTxt";
      this.iptalaciklamaTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.iptalaciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.iptalaciklamaTxt.Size = new Size(1004, 30);
      this.iptalaciklamaTxt.TabIndex = 21;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1316, 851);
      this.Controls.Add((Control) this.iptalaciklamaTxt);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.isemriSearchLoop);
      this.Controls.Add((Control) this.checkEdit1);
      this.Controls.Add((Control) this.karsilayanfirmaLoop);
      this.Controls.Add((Control) this.subemudurLoop);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Controls.Add((Control) this.atolyeSefiLook);
      this.Controls.Add((Control) this.saattime);
      this.Controls.Add((Control) this.labelControl8);
      this.Controls.Add((Control) this.labelControl6);
      this.Controls.Add((Control) this.aracaciklamaLabel);
      this.Controls.Add((Control) this.labelControl4);
      this.Controls.Add((Control) this.labelControl7);
      this.Controls.Add((Control) this.labelControl5);
      this.Controls.Add((Control) this.labelControl9);
      this.Controls.Add((Control) this.labelControl3);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.tarihdate);
      this.Controls.Add((Control) this.fisKoduTxt);
      this.Controls.Add((Control) this.depoyetkiliLoop);
      this.Controls.Add((Control) this.talepedenustaloop);
      this.DoubleBuffered = true;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = "TalepDuzenleme";
      this.Text = "Ekle2";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.talephkrtduzenleme.EndInit();
      this.gridView4.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.birimadi.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.talepEmirliste.EndInit();
      this.fisKoduTxt.Properties.EndInit();
      this.talepedenustaloop.Properties.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.depoyetkiliLoop.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.tarihdate.Properties.CalendarTimeProperties.EndInit();
      this.tarihdate.Properties.EndInit();
      this.saattime.Properties.EndInit();
      this.atolyeSefiLook.Properties.EndInit();
      this.subemudurLoop.Properties.EndInit();
      this.karsilayanfirmaLoop.Properties.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.checkEdit1.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.isemriSearchLoop.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem3.EndInit();
      this.emptySpaceItem2.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.iptalaciklamaTxt.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
