// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.GirisFisDuzenle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
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
using Makina_Ikmal.DepoModel;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class GirisFisDuzenle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId kul = new KullaniciSonId();
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
    private SearchLookUpEdit depoYetkilisiLook;
    private GridView searchLookUpEdit3View;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup2;
    private SearchLookUpEdit firmaAdiLook;
    private GridView searchLookUpEdit2View;
    private DateEdit tarih;
    private TextEdit fisKoduTxt;
    private SearchLookUpEdit isEmriLook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem3;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem6;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private BarButtonItem barButtonItem22;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private GridColumn gridColumn1;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private LabelControl aracAciklamaLabel;
    private LayoutControlItem layoutControlItem11;
    private RepositoryItemLookUpEdit birimadi;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private RepositoryItemLookUpEdit malzeme;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private RepositoryItemLookUpEdit kdvid;
    private BindingSource tBLMALZKDVBindingSource;
    private TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private BindingSource tBLTALEPFISHRKTBindingSource;
    private talepharketlerini_id_ile talepharketlerini_id_ile;
    private GridColumn colID;
    private GridColumn colTALEPFISID;
    private GridColumn colMALZEMEID;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colBIRIMID;
    private GridColumn colISTENENMIKTAR;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private Makina_Ikmal.DepoModel.talepharketlerini_id_ileTableAdapters.TBLTALEPFISHRKTTableAdapter tBLTALEPFISHRKTTableAdapter;
    private GridColumn KDVORAN;
    private GridColumn KDVTUTAR;
    private GridColumn SATIRTUTAR;
    private RepositoryItemLookUpEdit depolook;
    private GridColumn depo;
    private RepositoryItemLookUpEdit markalook;
    private GridColumn marka;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private GridColumn degisimKm;
    private GridColumn serino;
    private GridColumn sonrakiKm;
    private GridColumn gridColumn2;

    public GirisFisDuzenle() => this.InitializeComponent();

    private void GirisFisEkle_Load(object sender, EventArgs e)
    {
      this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet7.TBLMALZKDV);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet7.TBLISEMRI);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet7.TBLMALZEMELER);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet7.TBLMALZBIRIM);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
        case "fis":
          this.talepFistenGelenVeri();
          break;
      }
    }

    public void talepFistenGelenVeri()
    {
      try
      {
        this.tBLTALEPFISHRKTTableAdapter.Fill(this.talepharketlerini_id_ile.TBLTALEPFISHRKT, new int?(YetkiClass.secim_id));
        TBLTALEPFIS isemri = this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
        this.isEmriLook.EditValue = (object) Convert.ToInt32((object) isemri.ISEMRIID);
        this.firmaAdiLook.EditValue = (object) isemri.FIRMAID;
        this.depoYetkilisiLook.EditValue = (object) isemri.DEPOYETKILIID;
        this.tarih.EditValue = (object) isemri.TARIH;
        this.saat.EditValue = (object) isemri.SAAT;
        TBLISEMRI acik = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => (int?) x.ID == isemri.ISEMRIID));
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => (int?) x.ID == acik.ARACID));
        try
        {
          this.aracAciklamaLabel.Text = tblaraclar.ARACACIKLAMA;
        }
        catch (Exception ex)
        {
        }
        this.isEmriLook.EditValue = (object) acik.ID;
        this.fisKoduTxt.Text = this.kul.giriskod();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) XtraMessageBox.Show("Giriş Fişi Talep Fişi ile Eşleştirilmiştir ikinci Talep Fişi ile Eşleştirelemez");
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelle();
      LogEkle.Logs("Guncelleme Yapti");
    }

    private void guncelle()
    {
      if (!(YetkiClass.secim == nameof (guncelle)))
        return;
      TBLDEPOFIS tbldepofis = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      tbldepofis.TARIH = new DateTime?(Convert.ToDateTime(this.tarih.EditValue));
      tbldepofis.SAAT = new DateTime?(Convert.ToDateTime(this.saat.EditValue));
      tbldepofis.IMZADEPOYETKILIID = new int?(Convert.ToInt32(this.depoYetkilisiLook.EditValue));
      this.db.SaveChanges();
      int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
    }

    private void guncelleload()
    {
      int secimId = YetkiClass.secim_id;
      if (false)
        return;
      TBLDEPOFIS sorgu = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.gridControl1.DataSource = (object) this.db.TBLDEPOFISHRKT.Where<TBLDEPOFISHRKT>((Expression<System.Func<TBLDEPOFISHRKT, bool>>) (hd => hd.DEPOFISID == (int?) YetkiClass.secim_id)).ToList<TBLDEPOFISHRKT>();
      this.isEmriLook.EditValue = (object) Convert.ToInt32((object) sorgu.ISEMRIID);
      this.firmaAdiLook.EditValue = (object) sorgu.FIRMAID;
      this.tarih.EditValue = (object) sorgu.TARIH;
      this.saat.EditValue = (object) sorgu.SAAT;
      this.depoYetkilisiLook.EditValue = (object) sorgu.IMZADEPOYETKILIID;
      TBLISEMRI acik = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<System.Func<TBLISEMRI, bool>>) (x => (int?) x.ID == sorgu.ISEMRIID));
      try
      {
        TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => (int?) x.ID == acik.ARACID));
        try
        {
          this.aracAciklamaLabel.Text = tblaraclar.ARACACIKLAMA;
        }
        catch (Exception ex)
        {
        }
        this.isEmriLook.EditValue = (object) acik.ID;
        this.fisKoduTxt.Text = sorgu.KOD;
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (XtraMessageBox.Show(" Silmek istediğinizden eminmisiniz", "UYARI", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
      {
        int id = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
        TBLDEPOFISHRKT sil = this.db.TBLDEPOFISHRKT.FirstOrDefault<TBLDEPOFISHRKT>((Expression<System.Func<TBLDEPOFISHRKT, bool>>) (x => x.ID == id));
        TBLMALZEMELER tblmalzemeler1 = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => (int?) x.ID == sil.MALZEMEID));
        TBLMALZEMELER tblmalzemeler2 = tblmalzemeler1;
        Decimal? nullable1 = tblmalzemeler2.KALAN;
        Decimal? nullable2 = sil.MIKTAR;
        tblmalzemeler2.KALAN = nullable1.HasValue & nullable2.HasValue ? new Decimal?(nullable1.GetValueOrDefault() - nullable2.GetValueOrDefault()) : new Decimal?();
        TBLMALZEMELER tblmalzemeler3 = tblmalzemeler1;
        nullable2 = tblmalzemeler3.GIRIS;
        nullable1 = sil.MIKTAR;
        tblmalzemeler3.GIRIS = nullable2.HasValue & nullable1.HasValue ? new Decimal?(nullable2.GetValueOrDefault() - nullable1.GetValueOrDefault()) : new Decimal?();
        this.db.TBLDEPOFISHRKT.Remove(sil);
      }
      TBLDEPOFIS fissil = this.db.TBLDEPOFIS.FirstOrDefault<TBLDEPOFIS>((Expression<System.Func<TBLDEPOFIS, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.db.TBLTALEPFIS.FirstOrDefault<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => (int?) x.ID == fissil.TALEPFISID)).SAVEUSER = "1";
      this.db.TBLDEPOFIS.Remove(fissil);
      this.db.SaveChanges();
    }

    private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
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

    private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e)
    {
      if (this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, this.gridView1.FocusedColumn) != null)
        return;
      if (this.gridView1.IsValidRowHandle(e.RowHandle))
        this.gridView1.DeleteRow(e.RowHandle);
      e.Valid = true;
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      girisFisiYazdir girisFisiYazdir = new girisFisiYazdir();
      girisFisiYazdir.Parameters["id"].Value = (object) YetkiClass.secim_id;
      girisFisiYazdir.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) girisFisiYazdir).ShowPreviewDialog();
    }

    private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GirisFisDuzenle));
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
      this.gridControl1 = new GridControl();
      this.tBLTALEPFISHRKTBindingSource = new BindingSource(this.components);
      this.talepharketlerini_id_ile = new talepharketlerini_id_ile();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colTALEPFISID = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.malzeme = new RepositoryItemLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.colMALZACIKLAMA = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.birimadi = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.colISTENENMIKTAR = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.KDVORAN = new GridColumn();
      this.kdvid = new RepositoryItemLookUpEdit();
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.KDVTUTAR = new GridColumn();
      this.SATIRTUTAR = new GridColumn();
      this.depo = new GridColumn();
      this.markalook = new RepositoryItemLookUpEdit();
      this.marka = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.degisimKm = new GridColumn();
      this.serino = new GridColumn();
      this.sonrakiKm = new GridColumn();
      this.depolook = new RepositoryItemLookUpEdit();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.dataLayoutControl1 = new DataLayoutControl();
      this.saat = new TimeEdit();
      this.depoYetkilisiLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.aracAciklamaLabel = new LabelControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControlItem11 = new LayoutControlItem();
      this.firmaAdiLook = new SearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.tarih = new DateEdit();
      this.fisKoduTxt = new TextEdit();
      this.isEmriLook = new SearchLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
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
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLMALZKDVTableAdapter = new TBLMALZKDVTableAdapter();
      this.tBLTALEPFISHRKTTableAdapter = new Makina_Ikmal.DepoModel.talepharketlerini_id_ileTableAdapters.TBLTALEPFISHRKTTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLTALEPFISHRKTBindingSource).BeginInit();
      this.talepharketlerini_id_ile.BeginInit();
      this.gridView1.BeginInit();
      this.malzeme.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.birimadi.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.kdvid.BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.markalook.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.depolook.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.dataLayoutControl1.BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      this.saat.Properties.BeginInit();
      this.depoYetkilisiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControlGroup2.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.firmaAdiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.tarih.Properties.CalendarTimeProperties.BeginInit();
      this.tarih.Properties.BeginInit();
      this.fisKoduTxt.Properties.BeginInit();
      this.isEmriLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
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
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[31]
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
        (BarItem) this.barButtonItem5
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 35;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 288;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1469, 122);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem2.Caption = "Sil";
      this.barButtonItem2.Enabled = false;
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
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLTALEPFISHRKTBindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 5, 3, 5);
      this.gridControl1.Location = new Point(12, 171);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[6]
      {
        (RepositoryItem) this.birimadi,
        (RepositoryItem) this.malzeme,
        (RepositoryItem) this.kdvid,
        (RepositoryItem) this.depolook,
        (RepositoryItem) this.markalook,
        (RepositoryItem) this.repositoryItemLookUpEdit3
      });
      this.gridControl1.Size = new Size(1445, 360);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLTALEPFISHRKTBindingSource.DataMember = "TBLTALEPFISHRKT";
      this.tBLTALEPFISHRKTBindingSource.DataSource = (object) this.talepharketlerini_id_ile;
      this.talepharketlerini_id_ile.DataSetName = "talepharketlerini_id_ile";
      this.talepharketlerini_id_ile.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[17]
      {
        this.colID,
        this.colTALEPFISID,
        this.colMALZEMEID,
        this.colMALZACIKLAMA,
        this.colBIRIMID,
        this.colISTENENMIKTAR,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.KDVORAN,
        this.KDVTUTAR,
        this.SATIRTUTAR,
        this.depo,
        this.marka,
        this.degisimKm,
        this.serino,
        this.sonrakiKm
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.CellValueChanged += new CellValueChangedEventHandler(this.gridView1_CellValueChanged);
      this.gridView1.CellValueChanging += new CellValueChangedEventHandler(this.gridView1_CellValueChanging);
      this.gridView1.ValidateRow += new ValidateRowEventHandler(this.gridView1_ValidateRow);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 94;
      this.colTALEPFISID.FieldName = "TALEPFISID";
      this.colTALEPFISID.MinWidth = 25;
      this.colTALEPFISID.Name = "colTALEPFISID";
      this.colTALEPFISID.OptionsColumn.AllowEdit = false;
      this.colTALEPFISID.OptionsColumn.ReadOnly = true;
      this.colTALEPFISID.Width = 94;
      this.colMALZEMEID.Caption = "Malzeme Adı";
      this.colMALZEMEID.ColumnEdit = (RepositoryItem) this.malzeme;
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.MinWidth = 25;
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 0;
      this.colMALZEMEID.Width = 94;
      this.malzeme.AutoHeight = false;
      this.malzeme.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.malzeme.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.malzeme.DisplayMember = "MALZEMEADI";
      this.malzeme.Name = "malzeme";
      this.malzeme.NullText = "";
      this.malzeme.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colMALZACIKLAMA.Caption = "Malzeme Açıklaması";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.MinWidth = 25;
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colMALZACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 1;
      this.colMALZACIKLAMA.Width = 94;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.birimadi;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 25;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 2;
      this.colBIRIMID.Width = 94;
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
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet7;
      this.colISTENENMIKTAR.FieldName = "ISTENENMIKTAR";
      this.colISTENENMIKTAR.MinWidth = 25;
      this.colISTENENMIKTAR.Name = "colISTENENMIKTAR";
      this.colISTENENMIKTAR.OptionsColumn.AllowEdit = false;
      this.colISTENENMIKTAR.OptionsColumn.ReadOnly = true;
      this.colISTENENMIKTAR.Width = 94;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 25;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 3;
      this.colMIKTAR.Width = 94;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 25;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 4;
      this.colFIYAT.Width = 94;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 25;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.OptionsColumn.AllowEdit = false;
      this.colTUTAR.OptionsColumn.ReadOnly = true;
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 5;
      this.colTUTAR.Width = 94;
      this.KDVORAN.Caption = "Kdv";
      this.KDVORAN.ColumnEdit = (RepositoryItem) this.kdvid;
      this.KDVORAN.FieldName = "KDVORAN";
      this.KDVORAN.MinWidth = 25;
      this.KDVORAN.Name = "KDVORAN";
      this.KDVORAN.OptionsColumn.AllowEdit = false;
      this.KDVORAN.OptionsColumn.ReadOnly = true;
      this.KDVORAN.Width = 94;
      this.kdvid.AutoHeight = false;
      this.kdvid.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kdvid.DataSource = (object) this.tBLMALZKDVBindingSource;
      this.kdvid.DisplayFormat.FormatString = "c2";
      this.kdvid.DisplayFormat.FormatType = FormatType.Numeric;
      this.kdvid.DisplayMember = "KDVORAN";
      this.kdvid.Name = "kdvid";
      this.kdvid.NullText = "0,0";
      this.kdvid.ValueMember = "ID";
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet7;
      this.KDVTUTAR.Caption = "Kdv Tutar";
      this.KDVTUTAR.ColumnEdit = (RepositoryItem) this.kdvid;
      this.KDVTUTAR.FieldName = "KDVTUTAR";
      this.KDVTUTAR.MinWidth = 25;
      this.KDVTUTAR.Name = "KDVTUTAR";
      this.KDVTUTAR.OptionsColumn.AllowEdit = false;
      this.KDVTUTAR.OptionsColumn.ReadOnly = true;
      this.KDVTUTAR.Width = 94;
      this.SATIRTUTAR.Caption = "Satır Tutar";
      this.SATIRTUTAR.ColumnEdit = (RepositoryItem) this.kdvid;
      this.SATIRTUTAR.FieldName = "SATIRTUTAR";
      this.SATIRTUTAR.MinWidth = 25;
      this.SATIRTUTAR.Name = "SATIRTUTAR";
      this.SATIRTUTAR.OptionsColumn.AllowEdit = false;
      this.SATIRTUTAR.OptionsColumn.ReadOnly = true;
      this.SATIRTUTAR.Width = 94;
      this.depo.Caption = "Depo Adı";
      this.depo.ColumnEdit = (RepositoryItem) this.markalook;
      this.depo.MinWidth = 25;
      this.depo.Name = "depo";
      this.depo.OptionsColumn.AllowEdit = false;
      this.depo.OptionsColumn.ReadOnly = true;
      this.depo.Visible = true;
      this.depo.VisibleIndex = 6;
      this.depo.Width = 94;
      this.markalook.AutoHeight = false;
      this.markalook.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.markalook.Name = "markalook";
      this.markalook.NullText = "";
      this.marka.Caption = "Marka";
      this.marka.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.marka.MinWidth = 25;
      this.marka.Name = "marka";
      this.marka.OptionsColumn.AllowEdit = false;
      this.marka.OptionsColumn.ReadOnly = true;
      this.marka.Visible = true;
      this.marka.VisibleIndex = 7;
      this.marka.Width = 94;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.NullText = "";
      this.degisimKm.Caption = "Değişim Km";
      this.degisimKm.MinWidth = 25;
      this.degisimKm.Name = "degisimKm";
      this.degisimKm.OptionsColumn.AllowEdit = false;
      this.degisimKm.OptionsColumn.ReadOnly = true;
      this.degisimKm.Visible = true;
      this.degisimKm.VisibleIndex = 8;
      this.degisimKm.Width = 94;
      this.serino.Caption = "Seri No";
      this.serino.MinWidth = 25;
      this.serino.Name = "serino";
      this.serino.OptionsColumn.AllowEdit = false;
      this.serino.OptionsColumn.ReadOnly = true;
      this.serino.Visible = true;
      this.serino.VisibleIndex = 9;
      this.serino.Width = 94;
      this.sonrakiKm.Caption = "Sonraki Km";
      this.sonrakiKm.MinWidth = 25;
      this.sonrakiKm.Name = "sonrakiKm";
      this.sonrakiKm.OptionsColumn.AllowEdit = false;
      this.sonrakiKm.OptionsColumn.ReadOnly = true;
      this.sonrakiKm.Visible = true;
      this.sonrakiKm.VisibleIndex = 10;
      this.sonrakiKm.Width = 94;
      this.depolook.AutoHeight = false;
      this.depolook.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depolook.Name = "depolook";
      this.depolook.NullText = "";
      this.barButtonItem1.Caption = "Kaydet";
      this.barButtonItem1.Id = 33;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem5.Caption = "Talep Yükle";
      this.barButtonItem5.Id = 34;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup5,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
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
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.dataLayoutControl1);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1469, 543);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.dataLayoutControl1.Controls.Add((Control) this.saat);
      this.dataLayoutControl1.Controls.Add((Control) this.depoYetkilisiLook);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl3);
      this.dataLayoutControl1.Controls.Add((Control) this.layoutControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.firmaAdiLook);
      this.dataLayoutControl1.Controls.Add((Control) this.tarih);
      this.dataLayoutControl1.Controls.Add((Control) this.fisKoduTxt);
      this.dataLayoutControl1.Controls.Add((Control) this.isEmriLook);
      this.dataLayoutControl1.Location = new Point(12, 12);
      this.dataLayoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.layoutControlGroup1;
      this.dataLayoutControl1.Size = new Size(1445, 155);
      this.dataLayoutControl1.TabIndex = 5;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      this.saat.EditValue = (object) new DateTime(2021, 12, 25, 0, 0, 0, 0);
      this.saat.Location = new Point(368, 98);
      this.saat.Margin = new Padding(3, 4, 3, 4);
      this.saat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saat.Name = "saat";
      this.saat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saat.Properties.Appearance.Options.UseFont = true;
      this.saat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saat.Size = new Size(113, 30);
      this.saat.StyleController = (IStyleController) this.dataLayoutControl1;
      this.saat.TabIndex = 12;
      this.depoYetkilisiLook.Location = new Point(600, 98);
      this.depoYetkilisiLook.Margin = new Padding(3, 4, 3, 4);
      this.depoYetkilisiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.depoYetkilisiLook.Name = "depoYetkilisiLook";
      this.depoYetkilisiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.depoYetkilisiLook.Properties.Appearance.Options.UseFont = true;
      this.depoYetkilisiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depoYetkilisiLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.depoYetkilisiLook.Properties.DisplayMember = "ADISOYADI";
      this.depoYetkilisiLook.Properties.NullText = "";
      this.depoYetkilisiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.depoYetkilisiLook.Properties.ValueMember = "ID";
      this.depoYetkilisiLook.Size = new Size(369, 30);
      this.depoYetkilisiLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.depoYetkilisiLook.TabIndex = 11;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit3View.DetailHeight = 431;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "AdıSoyadı";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.layoutControl3.Location = new Point(973, 12);
      this.layoutControl3.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup3;
      this.layoutControl3.Size = new Size(460, 131);
      this.layoutControl3.TabIndex = 10;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(460, 131);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl2.Controls.Add((Control) this.aracAciklamaLabel);
      this.layoutControl2.Location = new Point(485, 12);
      this.layoutControl2.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup2;
      this.layoutControl2.Size = new Size(484, 48);
      this.layoutControl2.TabIndex = 9;
      this.layoutControl2.Text = "layoutControl2";
      this.aracAciklamaLabel.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aracAciklamaLabel.Appearance.Options.UseFont = true;
      this.aracAciklamaLabel.Location = new Point(12, 12);
      this.aracAciklamaLabel.Name = "aracAciklamaLabel";
      this.aracAciklamaLabel.Size = new Size(460, 24);
      this.aracAciklamaLabel.StyleController = (IStyleController) this.layoutControl2;
      this.aracAciklamaLabel.TabIndex = 4;
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem11
      });
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(484, 48);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.aracAciklamaLabel;
      this.layoutControlItem11.Location = new Point(0, 0);
      this.layoutControlItem11.MinSize = new Size(4, 28);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(464, 28);
      this.layoutControlItem11.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.firmaAdiLook.Enabled = false;
      this.firmaAdiLook.Location = new Point(600, 64);
      this.firmaAdiLook.Margin = new Padding(3, 4, 3, 4);
      this.firmaAdiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firmaAdiLook.Name = "firmaAdiLook";
      this.firmaAdiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.firmaAdiLook.Properties.Appearance.Options.UseFont = true;
      this.firmaAdiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmaAdiLook.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firmaAdiLook.Properties.DisplayMember = "FIRMAADI";
      this.firmaAdiLook.Properties.NullText = "";
      this.firmaAdiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.firmaAdiLook.Properties.ValueMember = "ID";
      this.firmaAdiLook.Size = new Size(369, 30);
      this.firmaAdiLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.firmaAdiLook.TabIndex = 8;
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Firma Adı";
      this.gridColumn2.FieldName = "FIRMAADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.tarih.EditValue = (object) null;
      this.tarih.Location = new Point((int) sbyte.MaxValue, 98);
      this.tarih.Margin = new Padding(3, 4, 3, 4);
      this.tarih.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarih.Name = "tarih";
      this.tarih.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarih.Properties.Appearance.Options.UseFont = true;
      this.tarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarih.Size = new Size(237, 30);
      this.tarih.StyleController = (IStyleController) this.dataLayoutControl1;
      this.tarih.TabIndex = 6;
      this.fisKoduTxt.Enabled = false;
      this.fisKoduTxt.Location = new Point((int) sbyte.MaxValue, 64);
      this.fisKoduTxt.Margin = new Padding(3, 4, 3, 4);
      this.fisKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisKoduTxt.Name = "fisKoduTxt";
      this.fisKoduTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.fisKoduTxt.Properties.Appearance.Options.UseFont = true;
      this.fisKoduTxt.Size = new Size(354, 30);
      this.fisKoduTxt.StyleController = (IStyleController) this.dataLayoutControl1;
      this.fisKoduTxt.TabIndex = 5;
      this.fisKoduTxt.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.isEmriLook.Enabled = false;
      this.isEmriLook.Location = new Point((int) sbyte.MaxValue, 12);
      this.isEmriLook.Margin = new Padding(3, 4, 3, 4);
      this.isEmriLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isEmriLook.Name = "isEmriLook";
      this.isEmriLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isEmriLook.Properties.Appearance.Options.UseFont = true;
      this.isEmriLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isEmriLook.Properties.DataSource = (object) this.tBLISEMRIBindingSource;
      this.isEmriLook.Properties.DisplayMember = "KOD";
      this.isEmriLook.Properties.NullText = "";
      this.isEmriLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.isEmriLook.Properties.ValueMember = "ID";
      this.isEmriLook.Size = new Size(354, 30);
      this.isEmriLook.StyleController = (IStyleController) this.dataLayoutControl1;
      this.isEmriLook.TabIndex = 4;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
      this.layoutControlGroup1.Size = new Size(1445, 155);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.isEmriLook;
      this.layoutControlItem3.Location = new Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(473, 52);
      this.layoutControlItem3.Text = "İş Emri";
      this.layoutControlItem3.TextSize = new Size(112, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 120);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(961, 15);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.fisKoduTxt;
      this.layoutControlItem4.Location = new Point(0, 52);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(473, 34);
      this.layoutControlItem4.Text = "Fiş Kodu";
      this.layoutControlItem4.TextSize = new Size(112, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.tarih;
      this.layoutControlItem5.Location = new Point(0, 86);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(356, 34);
      this.layoutControlItem5.Text = "Tarih/Saat";
      this.layoutControlItem5.TextSize = new Size(112, 24);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.firmaAdiLook;
      this.layoutControlItem7.Location = new Point(473, 52);
      this.layoutControlItem7.MinSize = new Size(135, 30);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(488, 34);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Firma Adı";
      this.layoutControlItem7.TextSize = new Size(112, 24);
      this.layoutControlItem8.Control = (Control) this.layoutControl2;
      this.layoutControlItem8.Location = new Point(473, 0);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(488, 52);
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.layoutControl3;
      this.layoutControlItem9.Location = new Point(961, 0);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(464, 135);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.depoYetkilisiLook;
      this.layoutControlItem10.Location = new Point(473, 86);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(488, 34);
      this.layoutControlItem10.Text = "Depo Yetkilisi";
      this.layoutControlItem10.TextSize = new Size(112, 24);
      this.layoutControlItem6.Control = (Control) this.saat;
      this.layoutControlItem6.Location = new Point(356, 86);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(117, 34);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1469, 543);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 159);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1449, 364);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.dataLayoutControl1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1449, 159);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPFISHRKTTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1469, 665);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (GirisFisDuzenle);
      this.Text = "Giriş Fişi Düzenleme";
      this.Load += new EventHandler(this.GirisFisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLTALEPFISHRKTBindingSource).EndInit();
      this.talepharketlerini_id_ile.EndInit();
      this.gridView1.EndInit();
      this.malzeme.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.birimadi.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.kdvid.EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.markalook.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.depolook.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.dataLayoutControl1.EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      this.saat.Properties.EndInit();
      this.depoYetkilisiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControlGroup2.EndInit();
      this.layoutControlItem11.EndInit();
      this.firmaAdiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.tarih.Properties.CalendarTimeProperties.EndInit();
      this.tarih.Properties.EndInit();
      this.fisKoduTxt.Properties.EndInit();
      this.isEmriLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.searchLookUpEdit1View.EndInit();
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
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
