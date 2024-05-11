// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.teklifHrktCekTableAdapters;
using Makina_Ikmal.SatinAlma.VeriGuncelleme.Teklif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TeklifListesi : Form
  {
    private RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
    private bellEntities db = new bellEntities();
    private int detay = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem duzenleButton;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private GridView gridView1;
    private GridControl gridControl1;
    private TabPane tabPane1;
    private TabNavigationPage tabNavigationPage1;
    private GridControl gridControl2;
    private GridView gridView2;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage3;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet1TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemProgressBar repositoryItemProgressBar1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLTEKLIFBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLTEKLIFTableAdapter tBLTEKLIFTableAdapter;
    private GridColumn colID1;
    private GridColumn colKOD1;
    private GridColumn colTARIH;
    private GridColumn colTEKLIFKONUSU;
    private GridColumn colKAZANANFIRMAID;
    private GridColumn colFATURATARIHI;
    private GridColumn colFATURANO;
    private GridColumn colFATURATUTAR;
    private GridColumn colKDVTUTAR;
    private GridColumn colTOPLAMTUTAR;
    private GridColumn colSAKARARTARIHI;
    private GridColumn colSAKARARNO;
    private GridColumn colIMZABIRIMAMIRIID;
    private GridColumn colIMZAMUDURID;
    private GridColumn colDAIREBSKID;
    private GridColumn colFIRMA1ID;
    private GridColumn colFIRMA2ID;
    private GridColumn colFIRMA3ID;
    private GridColumn colFIRMA4ID;
    private GridColumn colFIRMA5ID;
    private GridColumn colFIRMA6ID;
    private GridColumn colFIRMA7ID;
    private GridColumn colFIRMA8ID;
    private GridColumn colTALEPID;
    private GridColumn colKOMUYE1ID;
    private GridColumn colKOMUYE2ID;
    private GridColumn colKOMBSKID;
    private GridColumn colKESINLESTIR;
    private BarEditItem aramaTxt;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem excelButton;
    private RibbonPageGroup ribbonPageGroup5;
    private GridControl gridControl3;
    private GridView gridView3;
    private TabNavigationPage tabNavigationPage4;
    private RepositoryItemLookUpEdit talepKodu;
    private bellDataSet5 bellDataSet5;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter tBLTALEPTableAdapter;
    private RepositoryItemLookUpEdit firmalar;
    private BindingSource tBLFIRMALARBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private RepositoryItemLookUpEdit personeller;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLTALEPBindingSource;
    private GridColumn colID;
    private GridColumn colMIKTAR;
    private GridColumn colMARKA;
    private GridColumn colBIRIMADI;
    private GridColumn colPLAKA;
    private GridColumn colARACACIKLAMA;
    private GridColumn colF1BIRIMFIYAT;
    private GridColumn colF1TUTAR;
    private GridColumn colFIRMAADI;
    private GridColumn colMALZEMEADI;
    private GridColumn colTEKLIFKONUSU1;
    private GridColumn colTARIH1;
    private GridColumn colBIRIMADI1;
    private GridColumn colMALZEMEADI1;
    private GridColumn colMALZEMEGRUP;
    private GridColumn colBOLUMADI;
    private GridColumn colSum_MIKTAR;
    private teklifHrktCek teklifHrktCek;
    private BindingSource teklifToplamlariBindingSource;
    private TeklifToplamlariTableAdapter teklifToplamlariTableAdapter;
    private BindingSource teklifHrktCekBindingSource;
    private TeklifHrktCekTableAdapter teklifHrktCekTableAdapter;
    private BarButtonItem VeriGuncelle;
    private RibbonPageGroup ribbonPageGroup6;
    private GridControl gridControl4;
    private GridView gridView4;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private GridColumn gridColumn8;
    private GridColumn gridColumn9;
    private GridColumn gridColumn10;
    private GridColumn gridColumn11;
    private GridColumn gridColumn12;
    private GridColumn gridColumn13;
    private GridColumn gridColumn14;
    private GridColumn gridColumn15;

    public TeklifListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      TeklifFisi teklifFisi = new TeklifFisi();
      teklifFisi.secim = 1;
      TeklifFisi openForm = (TeklifFisi) Application.OpenForms["TeklifFisi"];
      if (openForm != null)
        openForm.Focus();
      else
        teklifFisi.Show();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.Listele();
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet5.TBLFIRMALAR);
      this.tBLTALEPTableAdapter.Fill(this.bellDataSet5.TBLTALEP);
      this.tBLTEKLIFTableAdapter.Fill(this.bellDataSet2.TBLTEKLIF);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet1.TBLARACLAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet1.TBLISEMRI);
      this.ritem.Minimum = 0;
      this.ritem.Maximum = 100;
      this.VeriGuncelle.Enabled = false;
    }

    private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      if (!(this.gridView2.GetRowCellValue(e.RowHandle, this.colKESINLESTIR).ToString() != "") || Convert.ToInt32(this.gridView2.GetRowCellValue(e.RowHandle, this.colKESINLESTIR)) != 1)
        return;
      e.Appearance.BackColor = Color.LimeGreen;
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void gridControl2_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id2 = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
      if (this.gridView2.GetFocusedRowCellValue(this.colTALEPID) != null)
        YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colTALEPID));
      else
        YetkiClass.secim_id = Convert.ToInt32(0);
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl2_Click(object sender, EventArgs e) => this.detay = this.gridView2.FocusedRowHandle;

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      TeklifFisi teklifFisi = new TeklifFisi();
      teklifFisi.secim = !(this.gridView2.GetFocusedRowCellValue(this.colKESINLESTIR).ToString() != "1") ? 4 : 3;
      teklifFisi.Getir(Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID1)));
      TeklifFisi openForm = (TeklifFisi) Application.OpenForms["TeklifFisi"];
      if (openForm != null)
        openForm.Focus();
      else
        teklifFisi.Show();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    public void Listele()
    {
      if (this.tabPane1.SelectedPageIndex == 0)
      {
        this.tBLTEKLIFTableAdapter.Fill(this.bellDataSet2.TBLTEKLIF);
        this.tBLTALEPTableAdapter.Fill(this.bellDataSet5.TBLTALEP);
      }
      if (this.tabPane1.SelectedPageIndex == 1)
        this.gridControl1.DataSource = (object) this.db.TBLTEKLIFHRKT.GroupJoin((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, (Expression<System.Func<TBLTEKLIFHRKT, int?>>) (hd => hd.BIRIMID), (Expression<System.Func<TBLMALZBIRIM, int?>>) (ha => (int?) ha.ID), (hd, pst) => new
        {
          hd = hd,
          pst = pst
        }).SelectMany(data => data.pst.DefaultIfEmpty<TBLMALZBIRIM>(), (data, ha) => new
        {
          \u003C\u003Eh__TransparentIdentifier0 = data,
          ha = ha
        }).Join((IEnumerable<TBLFIRMALAR>) this.db.TBLFIRMALAR, data => data.\u003C\u003Eh__TransparentIdentifier0.hd.FIRMA1ID, (Expression<System.Func<TBLFIRMALAR, int?>>) (fi => (int?) fi.ID), (data, fi) => new
        {
          \u003C\u003Eh__TransparentIdentifier1 = data,
          fi = fi
        }).GroupJoin((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (ma => (int?) ma.ID), (data, mas) => new
        {
          \u003C\u003Eh__TransparentIdentifier2 = data,
          mas = mas
        }).SelectMany(data => data.mas.DefaultIfEmpty<TBLMALZEMELER>(), (data, ma) => new
        {
          \u003C\u003Eh__TransparentIdentifier3 = data,
          ma = ma
        }).GroupJoin((IEnumerable<TBLTEKLIF>) this.db.TBLTEKLIF, data => data.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TEKLIFID, (Expression<System.Func<TBLTEKLIF, int?>>) (te => (int?) te.ID), (data, tes) => new
        {
          \u003C\u003Eh__TransparentIdentifier4 = data,
          tes = tes
        }).SelectMany(data => data.tes.DefaultIfEmpty<TBLTEKLIF>(), (data, te) => new
        {
          \u003C\u003Eh__TransparentIdentifier5 = data,
          te = te
        }).GroupJoin((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, data => data.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ARACID, (Expression<System.Func<TBLARACLAR, int?>>) (ar => (int?) ar.ID), (data, ars) => new
        {
          \u003C\u003Eh__TransparentIdentifier6 = data,
          ars = ars
        }).SelectMany(data => data.ars.DefaultIfEmpty<TBLARACLAR>(), (data, ar) => new
        {
          ID = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ID,
          MIKTAR = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MIKTAR,
          MARKA = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MARKA,
          BIRIMADI = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.ha.BIRIMADI,
          F1BIRIMFIYAT = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.F1BIRIMFIYAT,
          F1TUTAR = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.F1TUTAR,
          FIRMAADI = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.fi.FIRMAADI,
          MALZEMEADI = data.\u003C\u003Eh__TransparentIdentifier6.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.ma.MALZEMEADI,
          TEKLIFKONUSU = data.\u003C\u003Eh__TransparentIdentifier6.te.TEKLIFKONUSU,
          TARIH = data.\u003C\u003Eh__TransparentIdentifier6.te.TARIH,
          PLAKA = ar.PLAKA,
          ARACACIKLAMA = ar.ARACACIKLAMA
        }).ToList();
      if (this.tabPane1.SelectedPageIndex == 2)
        this.teklifToplamlariTableAdapter.Fill(this.teklifHrktCek.TeklifToplamlari);
      if (this.tabPane1.SelectedPageIndex != 3)
        return;
      IQueryable<\u003C\u003Ef__AnonymousType76<int, string, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?, Decimal?>> source = this.db.TBLTEKLIFHRKT.Join((IEnumerable<TBLTEKLIF>) this.db.TBLTEKLIF, (Expression<System.Func<TBLTEKLIFHRKT, int?>>) (hd => hd.TEKLIFID), (Expression<System.Func<TBLTEKLIF, int?>>) (tf => (int?) tf.ID), (hd, tf) => new
      {
        hd = hd,
        tf = tf
      }).Join((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, data => data.hd.ARACID, (Expression<System.Func<TBLARACLAR, int?>>) (ar => (int?) ar.ID), (data, ar) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        ar = ar
      }).OrderByDescending(data => data.\u003C\u003Eh__TransparentIdentifier0.tf.FATURATARIHI.Value.Year).Where(data => data.ar.PLAKA != default (string) && (int?) data.\u003C\u003Eh__TransparentIdentifier0.tf.FATURATARIHI.Value.Year != new int?() && data.\u003C\u003Eh__TransparentIdentifier0.tf.FATURATUTAR != new Decimal?()).GroupBy(data => new
      {
        Year = data.\u003C\u003Eh__TransparentIdentifier0.tf.FATURATARIHI.Value.Year,
        PLAKA = data.ar.PLAKA
      }, data => new
      {
        hd = data.\u003C\u003Eh__TransparentIdentifier0.hd,
        tf = data.\u003C\u003Eh__TransparentIdentifier0.tf,
        ar = data.ar
      }).Select(grup1 => new
      {
        yil = grup1.FirstOrDefault().tf.FATURATARIHI.Value.Year,
        PLAKA = grup1.FirstOrDefault().ar.PLAKA,
        Ocak = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 1).hd.TUTAR,
        Subat = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 2).hd.TUTAR,
        Mart = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 3).hd.TUTAR,
        Nisan = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 4).hd.TUTAR,
        Mayis = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 5).hd.TUTAR,
        Haziran = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 6).hd.TUTAR,
        Temmuz = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 7).hd.TUTAR,
        Agustos = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 8).hd.TUTAR,
        Eylul = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 9).hd.TUTAR,
        Ekim = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 10).hd.TUTAR,
        Kasim = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 11).hd.TUTAR,
        Aralik = grup1.FirstOrDefault(x => x.tf.FATURATARIHI.Value.Month == 12).hd.TUTAR
      });
      if (source != null)
      {
        this.gridControl4.DataSource = (object) source.ToList();
        Decimal num = 0M;
        for (int rowHandle = 0; rowHandle <= source.Count(); ++rowHandle)
        {
          for (int index = 3; index <= 13; ++index)
          {
            if (this.gridView4.GetRowCellValue(rowHandle, this.gridView4.Columns[index]) != null)
              num += Convert.ToDecimal(this.gridView4.GetRowCellValue(rowHandle, this.gridView4.Columns[index]));
          }
          this.gridView1.SetRowCellValue(rowHandle, this.gridColumn15, (object) num);
        }
      }
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      IdariSartname idariSartname = new IdariSartname();
      idariSartname.Gizle(1);
      int num = (int) idariSartname.ShowDialog();
    }

    private void duzenleButton_ItemClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("TALEPID"));
      try
      {
        YetkiClass.secim_id = Convert.ToInt32(this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.TALEPID == (int?) YetkiClass.secim_id)).ID);
      }
      catch (Exception ex)
      {
      }
      TeklifFisi teklifFisi = new TeklifFisi();
      teklifFisi.secim = !(this.gridView2.GetFocusedRowCellValue(this.colKESINLESTIR).ToString() != "1") ? 4 : 2;
      int int32 = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
      teklifFisi.guncelID = int32;
      TeklifFisi openForm = (TeklifFisi) Application.OpenForms["TeklifFisi"];
      if (openForm != null)
        openForm.Focus();
      else
        teklifFisi.Show();
      teklifFisi.Getir(int32);
    }

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string userName = Environment.UserName;
      string str = "";
      if (this.tabPane1.SelectedPageIndex == 0)
      {
        str = "c:\\users\\" + userName + "\\documents\\" + this.tabNavigationPage1.Caption + ".xlsx";
        this.gridControl2.ExportToXlsx(str);
      }
      if (this.tabPane1.SelectedPageIndex == 1)
      {
        str = "c:\\users\\" + userName + "\\documents\\" + this.tabNavigationPage2.Caption + ".xlsx";
        this.gridControl1.ExportToXlsx(str);
      }
      if (this.tabPane1.SelectedPageIndex == 2)
        str = "c:\\users\\" + userName + "\\documents\\" + this.tabNavigationPage3.Caption + ".xlsx";
      Process.Start(str);
    }

    private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.tabPane1.SelectedPageIndex == 0)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      if (this.tabPane1.SelectedPageIndex == 1)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      if (this.tabPane1.SelectedPageIndex == 2)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
      if (this.tabPane1.SelectedPageIndex != 3)
        ;
    }

    private void teklifHrktCekBindingSource_CurrentChanged(object sender, EventArgs e)
    {
    }

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new Aylik().ShowDialog();
    }

    private void tabPane1_Click(object sender, EventArgs e)
    {
      if (this.tabPane1.SelectedPageIndex == 0)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      if (this.tabPane1.SelectedPageIndex == 1)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      if (this.tabPane1.SelectedPageIndex == 2)
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
      if (this.tabPane1.SelectedPageIndex != 3)
        ;
      this.Listele();
    }

    private void VeriGuncelle_ItemClick(object sender, ItemClickEventArgs e) => new SatinAlmaVeriGuncelleme().Show();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TeklifListesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.duzenleButton = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.aramaTxt = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl2 = new GridControl();
      this.tBLTEKLIFBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.gridView2 = new GridView();
      this.colID1 = new GridColumn();
      this.colKOD1 = new GridColumn();
      this.colTALEPID = new GridColumn();
      this.talepKodu = new RepositoryItemLookUpEdit();
      this.tBLTALEPBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colTARIH = new GridColumn();
      this.colTEKLIFKONUSU = new GridColumn();
      this.colFATURATARIHI = new GridColumn();
      this.colFATURANO = new GridColumn();
      this.colFATURATUTAR = new GridColumn();
      this.colKDVTUTAR = new GridColumn();
      this.colTOPLAMTUTAR = new GridColumn();
      this.colSAKARARNO = new GridColumn();
      this.colSAKARARTARIHI = new GridColumn();
      this.colKAZANANFIRMAID = new GridColumn();
      this.firmalar = new RepositoryItemLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.colFIRMA1ID = new GridColumn();
      this.colFIRMA2ID = new GridColumn();
      this.colFIRMA3ID = new GridColumn();
      this.colFIRMA4ID = new GridColumn();
      this.colFIRMA5ID = new GridColumn();
      this.colFIRMA6ID = new GridColumn();
      this.colFIRMA7ID = new GridColumn();
      this.colFIRMA8ID = new GridColumn();
      this.colIMZABIRIMAMIRIID = new GridColumn();
      this.personeller = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colIMZAMUDURID = new GridColumn();
      this.colDAIREBSKID = new GridColumn();
      this.colKOMUYE1ID = new GridColumn();
      this.colKOMUYE2ID = new GridColumn();
      this.colKOMBSKID = new GridColumn();
      this.colKESINLESTIR = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.repositoryItemProgressBar1 = new RepositoryItemProgressBar();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.VeriGuncelle = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colMARKA = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colF1BIRIMFIYAT = new GridColumn();
      this.colF1TUTAR = new GridColumn();
      this.colFIRMAADI = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colTEKLIFKONUSU1 = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.gridControl1 = new GridControl();
      this.teklifHrktCekBindingSource = new BindingSource(this.components);
      this.teklifHrktCek = new teklifHrktCek();
      this.tabPane1 = new TabPane();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.teklifToplamlariBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.colBIRIMADI1 = new GridColumn();
      this.colMALZEMEADI1 = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.colSum_MIKTAR = new GridColumn();
      this.tabNavigationPage4 = new TabNavigationPage();
      this.gridControl4 = new GridControl();
      this.gridView4 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.gridColumn10 = new GridColumn();
      this.gridColumn11 = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.gridColumn15 = new GridColumn();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new Makina_Ikmal.bellDataSet1TableAdapters.TBLISEMRITableAdapter();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet1TableAdapters.TBLARACLARTableAdapter();
      this.tBLTEKLIFTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLTEKLIFTableAdapter();
      this.tBLTALEPTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter();
      this.tBLFIRMALARTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMALARTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.teklifToplamlariTableAdapter = new TeklifToplamlariTableAdapter();
      this.teklifHrktCekTableAdapter = new TeklifHrktCekTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.gridView2.BeginInit();
      this.talepKodu.BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.firmalar.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.personeller.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      this.repositoryItemProgressBar1.BeginInit();
      this.gridView1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.teklifHrktCekBindingSource).BeginInit();
      this.teklifHrktCek.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.tabNavigationPage1.SuspendLayout();
      this.tabNavigationPage2.SuspendLayout();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.teklifToplamlariBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.tabNavigationPage4.SuspendLayout();
      this.gridControl4.BeginInit();
      this.gridView4.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[14]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.duzenleButton,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.aramaTxt,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.excelButton,
        (BarItem) this.VeriGuncelle
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 13;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
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
      this.ribbonControl1.Size = new Size(1258, 96);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.duzenleButton.Caption = "Düzenle";
      this.duzenleButton.Id = 2;
      this.duzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.Image");
      this.duzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.LargeImage");
      this.duzenleButton.LargeWidth = 100;
      this.duzenleButton.Name = "duzenleButton";
      this.duzenleButton.ItemClick += new ItemClickEventHandler(this.duzenleButton_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Filtrele";
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
      this.aramaTxt.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.aramaTxt.EditHeight = 25;
      this.aramaTxt.EditWidth = 140;
      this.aramaTxt.Id = 8;
      this.aramaTxt.Name = "aramaTxt";
      this.aramaTxt.ItemClick += new ItemClickEventHandler(this.barEditItem1_ItemClick);
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl2.DataSource = (object) this.tBLTEKLIFBindingSource;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl2.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemProgressBar1,
        (RepositoryItem) this.talepKodu,
        (RepositoryItem) this.firmalar,
        (RepositoryItem) this.personeller
      });
      this.gridControl2.Size = new Size(1258, 611);
      this.gridControl2.TabIndex = 2;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.Click += new EventHandler(this.gridControl2_Click);
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick);
      this.tBLTEKLIFBindingSource.DataMember = "TBLTEKLIF";
      this.tBLTEKLIFBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet5";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Tahoma", 12f);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[28]
      {
        this.colID1,
        this.colKOD1,
        this.colTALEPID,
        this.colTARIH,
        this.colTEKLIFKONUSU,
        this.colFATURATARIHI,
        this.colFATURANO,
        this.colFATURATUTAR,
        this.colKDVTUTAR,
        this.colTOPLAMTUTAR,
        this.colSAKARARNO,
        this.colSAKARARTARIHI,
        this.colKAZANANFIRMAID,
        this.colFIRMA1ID,
        this.colFIRMA2ID,
        this.colFIRMA3ID,
        this.colFIRMA4ID,
        this.colFIRMA5ID,
        this.colFIRMA6ID,
        this.colFIRMA7ID,
        this.colFIRMA8ID,
        this.colIMZABIRIMAMIRIID,
        this.colIMZAMUDURID,
        this.colDAIREBSKID,
        this.colKOMUYE1ID,
        this.colKOMUYE2ID,
        this.colKOMBSKID,
        this.colKESINLESTIR
      });
      this.gridView2.DetailHeight = 284;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.GroupPanelText = "buraya ben yazarım";
      this.gridView2.HorzScrollVisibility = ScrollVisibility.Always;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ColumnAutoWidth = false;
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridView2.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD1, ColumnSortOrder.Descending)
      });
      this.gridView2.RowCellStyle += new RowCellStyleEventHandler(this.gridView2_RowCellStyle);
      this.gridView2.DoubleClick += new EventHandler(this.duzenleButton_ItemClick);
      this.colID1.FieldName = "ID";
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Width = 66;
      this.colKOD1.Caption = "Teklif Kodu";
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.OptionsColumn.AllowEdit = false;
      this.colKOD1.OptionsColumn.ReadOnly = true;
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 0;
      this.colKOD1.Width = 91;
      this.colTALEPID.Caption = "Talep Kodu";
      this.colTALEPID.ColumnEdit = (RepositoryItem) this.talepKodu;
      this.colTALEPID.FieldName = "TALEPID";
      this.colTALEPID.Name = "colTALEPID";
      this.colTALEPID.OptionsColumn.AllowEdit = false;
      this.colTALEPID.OptionsColumn.ReadOnly = true;
      this.colTALEPID.Visible = true;
      this.colTALEPID.VisibleIndex = 1;
      this.colTALEPID.Width = 102;
      this.talepKodu.AutoHeight = false;
      this.talepKodu.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.talepKodu.DataSource = (object) this.tBLTALEPBindingSource;
      this.talepKodu.DisplayMember = "KOD";
      this.talepKodu.Name = "talepKodu";
      this.talepKodu.NullText = "";
      this.talepKodu.ValueMember = "ID";
      this.tBLTALEPBindingSource.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 2;
      this.colTARIH.Width = 112;
      this.colTEKLIFKONUSU.Caption = "Teklif Konusu";
      this.colTEKLIFKONUSU.FieldName = "TEKLIFKONUSU";
      this.colTEKLIFKONUSU.Name = "colTEKLIFKONUSU";
      this.colTEKLIFKONUSU.OptionsColumn.AllowEdit = false;
      this.colTEKLIFKONUSU.OptionsColumn.ReadOnly = true;
      this.colTEKLIFKONUSU.Visible = true;
      this.colTEKLIFKONUSU.VisibleIndex = 3;
      this.colTEKLIFKONUSU.Width = 112;
      this.colFATURATARIHI.Caption = "Fatura Tarihi";
      this.colFATURATARIHI.FieldName = "FATURATARIHI";
      this.colFATURATARIHI.Name = "colFATURATARIHI";
      this.colFATURATARIHI.OptionsColumn.AllowEdit = false;
      this.colFATURATARIHI.OptionsColumn.ReadOnly = true;
      this.colFATURATARIHI.Visible = true;
      this.colFATURATARIHI.VisibleIndex = 4;
      this.colFATURATARIHI.Width = 112;
      this.colFATURANO.Caption = "Fatura No";
      this.colFATURANO.FieldName = "FATURANO";
      this.colFATURANO.Name = "colFATURANO";
      this.colFATURANO.OptionsColumn.AllowEdit = false;
      this.colFATURANO.OptionsColumn.ReadOnly = true;
      this.colFATURANO.Visible = true;
      this.colFATURANO.VisibleIndex = 5;
      this.colFATURANO.Width = 96;
      this.colFATURATUTAR.Caption = "Fatur Tutar";
      this.colFATURATUTAR.FieldName = "FATURATUTAR";
      this.colFATURATUTAR.Name = "colFATURATUTAR";
      this.colFATURATUTAR.OptionsColumn.AllowEdit = false;
      this.colFATURATUTAR.OptionsColumn.ReadOnly = true;
      this.colFATURATUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "FATURATUTAR", "{0:c2}")
      });
      this.colFATURATUTAR.Visible = true;
      this.colFATURATUTAR.VisibleIndex = 6;
      this.colFATURATUTAR.Width = 101;
      this.colKDVTUTAR.Caption = "Kdv Turar";
      this.colKDVTUTAR.FieldName = "KDVTUTAR";
      this.colKDVTUTAR.Name = "colKDVTUTAR";
      this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colKDVTUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "KDVTUTAR", "{0:c2}")
      });
      this.colKDVTUTAR.Visible = true;
      this.colKDVTUTAR.VisibleIndex = 7;
      this.colKDVTUTAR.Width = 86;
      this.colTOPLAMTUTAR.Caption = "Toplam Tutar";
      this.colTOPLAMTUTAR.FieldName = "TOPLAMTUTAR";
      this.colTOPLAMTUTAR.Name = "colTOPLAMTUTAR";
      this.colTOPLAMTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPLAMTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPLAMTUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TOPLAMTUTAR", "{0:c2}")
      });
      this.colTOPLAMTUTAR.Visible = true;
      this.colTOPLAMTUTAR.VisibleIndex = 8;
      this.colTOPLAMTUTAR.Width = 96;
      this.colSAKARARNO.Caption = "Karar No";
      this.colSAKARARNO.FieldName = "SAKARARNO";
      this.colSAKARARNO.Name = "colSAKARARNO";
      this.colSAKARARNO.OptionsColumn.AllowEdit = false;
      this.colSAKARARNO.OptionsColumn.ReadOnly = true;
      this.colSAKARARNO.Visible = true;
      this.colSAKARARNO.VisibleIndex = 9;
      this.colSAKARARNO.Width = 85;
      this.colSAKARARTARIHI.Caption = "Karar Tarihi";
      this.colSAKARARTARIHI.FieldName = "SAKARARTARIHI";
      this.colSAKARARTARIHI.Name = "colSAKARARTARIHI";
      this.colSAKARARTARIHI.OptionsColumn.AllowEdit = false;
      this.colSAKARARTARIHI.OptionsColumn.ReadOnly = true;
      this.colSAKARARTARIHI.Visible = true;
      this.colSAKARARTARIHI.VisibleIndex = 10;
      this.colSAKARARTARIHI.Width = 111;
      this.colKAZANANFIRMAID.Caption = "Kazanan Firma";
      this.colKAZANANFIRMAID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colKAZANANFIRMAID.FieldName = "KAZANANFIRMAID";
      this.colKAZANANFIRMAID.Name = "colKAZANANFIRMAID";
      this.colKAZANANFIRMAID.OptionsColumn.AllowEdit = false;
      this.colKAZANANFIRMAID.OptionsColumn.ReadOnly = true;
      this.colKAZANANFIRMAID.Visible = true;
      this.colKAZANANFIRMAID.VisibleIndex = 11;
      this.colKAZANANFIRMAID.Width = 139;
      this.firmalar.AutoHeight = false;
      this.firmalar.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmalar.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firmalar.DisplayMember = "FIRMAADI";
      this.firmalar.Name = "firmalar";
      this.firmalar.NullText = "";
      this.firmalar.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet5;
      this.colFIRMA1ID.Caption = "1. Firma";
      this.colFIRMA1ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA1ID.FieldName = "FIRMA1ID";
      this.colFIRMA1ID.Name = "colFIRMA1ID";
      this.colFIRMA1ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA1ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA1ID.Visible = true;
      this.colFIRMA1ID.VisibleIndex = 12;
      this.colFIRMA1ID.Width = 134;
      this.colFIRMA2ID.Caption = "2. Firma";
      this.colFIRMA2ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA2ID.FieldName = "FIRMA2ID";
      this.colFIRMA2ID.Name = "colFIRMA2ID";
      this.colFIRMA2ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA2ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA2ID.Visible = true;
      this.colFIRMA2ID.VisibleIndex = 13;
      this.colFIRMA2ID.Width = 137;
      this.colFIRMA3ID.Caption = "3. Firma";
      this.colFIRMA3ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA3ID.FieldName = "FIRMA3ID";
      this.colFIRMA3ID.Name = "colFIRMA3ID";
      this.colFIRMA3ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA3ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA3ID.Visible = true;
      this.colFIRMA3ID.VisibleIndex = 14;
      this.colFIRMA3ID.Width = 147;
      this.colFIRMA4ID.Caption = "4. Firma";
      this.colFIRMA4ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA4ID.FieldName = "FIRMA4ID";
      this.colFIRMA4ID.Name = "colFIRMA4ID";
      this.colFIRMA4ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA4ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA4ID.Visible = true;
      this.colFIRMA4ID.VisibleIndex = 15;
      this.colFIRMA4ID.Width = 133;
      this.colFIRMA5ID.Caption = "5. Firma";
      this.colFIRMA5ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA5ID.FieldName = "FIRMA5ID";
      this.colFIRMA5ID.Name = "colFIRMA5ID";
      this.colFIRMA5ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA5ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA5ID.Visible = true;
      this.colFIRMA5ID.VisibleIndex = 16;
      this.colFIRMA5ID.Width = 137;
      this.colFIRMA6ID.Caption = "6. Firma";
      this.colFIRMA6ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA6ID.FieldName = "FIRMA6ID";
      this.colFIRMA6ID.Name = "colFIRMA6ID";
      this.colFIRMA6ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA6ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA6ID.Visible = true;
      this.colFIRMA6ID.VisibleIndex = 17;
      this.colFIRMA6ID.Width = 140;
      this.colFIRMA7ID.Caption = "7. Firma";
      this.colFIRMA7ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA7ID.FieldName = "FIRMA7ID";
      this.colFIRMA7ID.Name = "colFIRMA7ID";
      this.colFIRMA7ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA7ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA7ID.Visible = true;
      this.colFIRMA7ID.VisibleIndex = 18;
      this.colFIRMA7ID.Width = 143;
      this.colFIRMA8ID.Caption = "8. Firma";
      this.colFIRMA8ID.ColumnEdit = (RepositoryItem) this.firmalar;
      this.colFIRMA8ID.FieldName = "FIRMA8ID";
      this.colFIRMA8ID.Name = "colFIRMA8ID";
      this.colFIRMA8ID.OptionsColumn.AllowEdit = false;
      this.colFIRMA8ID.OptionsColumn.ReadOnly = true;
      this.colFIRMA8ID.Visible = true;
      this.colFIRMA8ID.VisibleIndex = 19;
      this.colFIRMA8ID.Width = 121;
      this.colIMZABIRIMAMIRIID.Caption = "İmza Amiri";
      this.colIMZABIRIMAMIRIID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colIMZABIRIMAMIRIID.FieldName = "IMZABIRIMAMIRIID";
      this.colIMZABIRIMAMIRIID.Name = "colIMZABIRIMAMIRIID";
      this.colIMZABIRIMAMIRIID.OptionsColumn.AllowEdit = false;
      this.colIMZABIRIMAMIRIID.OptionsColumn.ReadOnly = true;
      this.colIMZABIRIMAMIRIID.Visible = true;
      this.colIMZABIRIMAMIRIID.VisibleIndex = 20;
      this.colIMZABIRIMAMIRIID.Width = 154;
      this.personeller.AllowNullInput = DefaultBoolean.False;
      this.personeller.AutoHeight = false;
      this.personeller.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personeller.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personeller.DisplayMember = "ADISOYADI";
      this.personeller.Name = "personeller";
      this.personeller.NullText = "";
      this.personeller.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.colIMZAMUDURID.Caption = "İmza Müdürü";
      this.colIMZAMUDURID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colIMZAMUDURID.FieldName = "IMZAMUDURID";
      this.colIMZAMUDURID.Name = "colIMZAMUDURID";
      this.colIMZAMUDURID.OptionsColumn.AllowEdit = false;
      this.colIMZAMUDURID.OptionsColumn.ReadOnly = true;
      this.colIMZAMUDURID.Visible = true;
      this.colIMZAMUDURID.VisibleIndex = 21;
      this.colIMZAMUDURID.Width = 139;
      this.colDAIREBSKID.Caption = "Daire Başkanı";
      this.colDAIREBSKID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colDAIREBSKID.FieldName = "DAIREBSKID";
      this.colDAIREBSKID.Name = "colDAIREBSKID";
      this.colDAIREBSKID.OptionsColumn.AllowEdit = false;
      this.colDAIREBSKID.OptionsColumn.ReadOnly = true;
      this.colDAIREBSKID.Visible = true;
      this.colDAIREBSKID.VisibleIndex = 22;
      this.colDAIREBSKID.Width = 123;
      this.colKOMUYE1ID.Caption = "Kabul Kom. Üye1";
      this.colKOMUYE1ID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colKOMUYE1ID.FieldName = "KOMUYE1ID";
      this.colKOMUYE1ID.Name = "colKOMUYE1ID";
      this.colKOMUYE1ID.OptionsColumn.AllowEdit = false;
      this.colKOMUYE1ID.OptionsColumn.ReadOnly = true;
      this.colKOMUYE1ID.Visible = true;
      this.colKOMUYE1ID.VisibleIndex = 23;
      this.colKOMUYE1ID.Width = 181;
      this.colKOMUYE2ID.Caption = "Kabul Kom. Üye2";
      this.colKOMUYE2ID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colKOMUYE2ID.FieldName = "KOMUYE2ID";
      this.colKOMUYE2ID.Name = "colKOMUYE2ID";
      this.colKOMUYE2ID.OptionsColumn.AllowEdit = false;
      this.colKOMUYE2ID.OptionsColumn.ReadOnly = true;
      this.colKOMUYE2ID.Visible = true;
      this.colKOMUYE2ID.VisibleIndex = 24;
      this.colKOMUYE2ID.Width = 198;
      this.colKOMBSKID.Caption = "Kabul Kom. Başkanı";
      this.colKOMBSKID.ColumnEdit = (RepositoryItem) this.personeller;
      this.colKOMBSKID.FieldName = "KOMBSKID";
      this.colKOMBSKID.Name = "colKOMBSKID";
      this.colKOMBSKID.OptionsColumn.AllowEdit = false;
      this.colKOMBSKID.OptionsColumn.ReadOnly = true;
      this.colKOMBSKID.Visible = true;
      this.colKOMBSKID.VisibleIndex = 25;
      this.colKOMBSKID.Width = 166;
      this.colKESINLESTIR.Caption = "Kesinleştir";
      this.colKESINLESTIR.FieldName = "KESINLESTIR";
      this.colKESINLESTIR.Name = "colKESINLESTIR";
      this.colKESINLESTIR.OptionsColumn.AllowEdit = false;
      this.colKESINLESTIR.OptionsColumn.ReadOnly = true;
      this.colKESINLESTIR.Visible = true;
      this.colKESINLESTIR.VisibleIndex = 26;
      this.colKESINLESTIR.Width = 82;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLARACLARBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
      this.barButtonItem8.Caption = "İdari Şartname";
      this.barButtonItem8.Id = 9;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Caption = "Aylık Grafik";
      this.barButtonItem9.Id = 10;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 11;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
      this.VeriGuncelle.Caption = "Teklif Verilerini Güncelleme(Sadece Admin)";
      this.VeriGuncelle.Id = 12;
      this.VeriGuncelle.ImageOptions.Image = (Image) componentResourceManager.GetObject("VeriGuncelle.ImageOptions.Image");
      this.VeriGuncelle.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("VeriGuncelle.ImageOptions.LargeImage");
      this.VeriGuncelle.Name = "VeriGuncelle";
      this.VeriGuncelle.ItemClick += new ItemClickEventHandler(this.VeriGuncelle_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[6]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup6
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.aramaTxt);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.duzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem9);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.VeriGuncelle);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[12]
      {
        this.colID,
        this.colMIKTAR,
        this.colMARKA,
        this.colBIRIMADI,
        this.colPLAKA,
        this.colARACACIKLAMA,
        this.colF1BIRIMFIYAT,
        this.colF1TUTAR,
        this.colFIRMAADI,
        this.colMALZEMEADI,
        this.colTEKLIFKONUSU1,
        this.colTARIH1
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 6;
      this.colMIKTAR.Width = 68;
      this.colMARKA.Caption = "Marka";
      this.colMARKA.FieldName = "MARKA";
      this.colMARKA.Name = "colMARKA";
      this.colMARKA.Visible = true;
      this.colMARKA.VisibleIndex = 7;
      this.colMARKA.Width = 78;
      this.colBIRIMADI.Caption = "Birim";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 5;
      this.colBIRIMADI.Width = 59;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 9;
      this.colPLAKA.Width = 108;
      this.colARACACIKLAMA.Caption = "Aracaç Açıklama";
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 10;
      this.colARACACIKLAMA.Width = 284;
      this.colF1BIRIMFIYAT.Caption = "Fiyat";
      this.colF1BIRIMFIYAT.FieldName = "F1BIRIMFIYAT";
      this.colF1BIRIMFIYAT.Name = "colF1BIRIMFIYAT";
      this.colF1BIRIMFIYAT.Visible = true;
      this.colF1BIRIMFIYAT.VisibleIndex = 4;
      this.colF1BIRIMFIYAT.Width = 102;
      this.colF1TUTAR.Caption = "Tutar";
      this.colF1TUTAR.FieldName = "F1TUTAR";
      this.colF1TUTAR.Name = "colF1TUTAR";
      this.colF1TUTAR.Visible = true;
      this.colF1TUTAR.VisibleIndex = 8;
      this.colF1TUTAR.Width = 69;
      this.colFIRMAADI.Caption = "Firma Adı";
      this.colFIRMAADI.FieldName = "FIRMAADI";
      this.colFIRMAADI.Name = "colFIRMAADI";
      this.colFIRMAADI.Visible = true;
      this.colFIRMAADI.VisibleIndex = 0;
      this.colFIRMAADI.Width = 192;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 3;
      this.colMALZEMEADI.Width = 277;
      this.colTEKLIFKONUSU1.Caption = "Teklifin Konusu";
      this.colTEKLIFKONUSU1.FieldName = "TEKLIFKONUSU";
      this.colTEKLIFKONUSU1.Name = "colTEKLIFKONUSU1";
      this.colTEKLIFKONUSU1.Visible = true;
      this.colTEKLIFKONUSU1.VisibleIndex = 2;
      this.colTEKLIFKONUSU1.Width = 136;
      this.colTARIH1.Caption = "Tarh";
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 1;
      this.colTARIH1.Width = 136;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1258, 611);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.teklifHrktCekBindingSource.DataMember = "TeklifHrktCek";
      this.teklifHrktCekBindingSource.DataSource = (object) this.teklifHrktCek;
      this.teklifHrktCek.DataSetName = "teklifHrktCek";
      this.teklifHrktCek.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage4);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 96);
      this.tabPane1.Margin = new Padding(2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[4]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3,
        (NavigationPageBase) this.tabNavigationPage4
      });
      this.tabPane1.RegularSize = new Size(1258, 648);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1258, 648);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "İş Emir Listesi";
      this.tabPane1.Click += new EventHandler(this.tabPane1_Click);
      this.tabNavigationPage1.Caption = "Teklif Fiş Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Margin = new Padding(2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1258, 611);
      this.tabNavigationPage2.Caption = "Telif Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage2.Margin = new Padding(2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1258, 611);
      this.tabNavigationPage3.Caption = "Teklif Fiş Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage3.Margin = new Padding(2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1258, 611);
      this.gridControl3.DataSource = (object) this.teklifToplamlariBindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.Size = new Size(1258, 611);
      this.gridControl3.TabIndex = 0;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.teklifToplamlariBindingSource.DataMember = "TeklifToplamlari";
      this.teklifToplamlariBindingSource.DataSource = (object) this.teklifHrktCek;
      this.gridView3.Columns.AddRange(new GridColumn[5]
      {
        this.colBIRIMADI1,
        this.colMALZEMEADI1,
        this.colMALZEMEGRUP,
        this.colBOLUMADI,
        this.colSum_MIKTAR
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.colBIRIMADI1.Caption = "Birim Adı";
      this.colBIRIMADI1.FieldName = "BIRIMADI";
      this.colBIRIMADI1.Name = "colBIRIMADI1";
      this.colBIRIMADI1.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI1.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI1.Visible = true;
      this.colBIRIMADI1.VisibleIndex = 4;
      this.colMALZEMEADI1.Caption = "Malzeme Adı";
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 3;
      this.colMALZEMEGRUP.Caption = "Malzem Grup";
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 2;
      this.colBOLUMADI.Caption = "Bölüm Adı";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 1;
      this.colSum_MIKTAR.Caption = "Miktar";
      this.colSum_MIKTAR.FieldName = "Sum_MIKTAR";
      this.colSum_MIKTAR.Name = "colSum_MIKTAR";
      this.colSum_MIKTAR.OptionsColumn.AllowEdit = false;
      this.colSum_MIKTAR.OptionsColumn.ReadOnly = true;
      this.colSum_MIKTAR.Visible = true;
      this.colSum_MIKTAR.VisibleIndex = 0;
      this.tabNavigationPage4.Caption = "Aylık Harcama Durumu";
      this.tabNavigationPage4.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage4.Name = "tabNavigationPage4";
      this.tabNavigationPage4.Size = new Size(1258, 611);
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl4.Name = "gridControl4";
      this.gridControl4.Size = new Size(1258, 611);
      this.gridControl4.TabIndex = 0;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.gridView4.Columns.AddRange(new GridColumn[15]
      {
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.gridColumn8,
        this.gridColumn9,
        this.gridColumn10,
        this.gridColumn11,
        this.gridColumn12,
        this.gridColumn13,
        this.gridColumn14,
        this.gridColumn15
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ShowFooter = true;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridView4.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn1, ColumnSortOrder.Descending)
      });
      this.gridColumn1.Caption = "Yıl";
      this.gridColumn1.FieldName = "yil";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.AllowFocus = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn2.Caption = "Plaka";
      this.gridColumn2.FieldName = "PLAKA";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.AllowFocus = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      this.gridColumn3.Caption = "Ocak";
      this.gridColumn3.FieldName = "Ocak";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.AllowEdit = false;
      this.gridColumn3.OptionsColumn.AllowFocus = false;
      this.gridColumn3.OptionsColumn.ReadOnly = true;
      this.gridColumn3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ocak", "{0:C2}")
      });
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      this.gridColumn4.Caption = "Şubat";
      this.gridColumn4.FieldName = "Subat";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.AllowEdit = false;
      this.gridColumn4.OptionsColumn.AllowFocus = false;
      this.gridColumn4.OptionsColumn.ReadOnly = true;
      this.gridColumn4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Subat", "{0:C2}")
      });
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn5.Caption = "Mart";
      this.gridColumn5.FieldName = "Mart";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.OptionsColumn.AllowEdit = false;
      this.gridColumn5.OptionsColumn.AllowFocus = false;
      this.gridColumn5.OptionsColumn.ReadOnly = true;
      this.gridColumn5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Mart", "{0:C2}")
      });
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 4;
      this.gridColumn6.Caption = "Nisan";
      this.gridColumn6.FieldName = "Nisan";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.OptionsColumn.AllowEdit = false;
      this.gridColumn6.OptionsColumn.AllowFocus = false;
      this.gridColumn6.OptionsColumn.ReadOnly = true;
      this.gridColumn6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Nisan", "{0:C2}")
      });
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 5;
      this.gridColumn7.Caption = "Mayıs";
      this.gridColumn7.FieldName = "Mayıs";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.OptionsColumn.AllowEdit = false;
      this.gridColumn7.OptionsColumn.AllowFocus = false;
      this.gridColumn7.OptionsColumn.ReadOnly = true;
      this.gridColumn7.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Mayıs", "{0:C2}")
      });
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 6;
      this.gridColumn8.Caption = "Haziran";
      this.gridColumn8.FieldName = "ay";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.OptionsColumn.AllowEdit = false;
      this.gridColumn8.OptionsColumn.AllowFocus = false;
      this.gridColumn8.OptionsColumn.ReadOnly = true;
      this.gridColumn8.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "ay", "{0:C2}")
      });
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 7;
      this.gridColumn9.Caption = "Temmuz";
      this.gridColumn9.FieldName = "Haziran";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.OptionsColumn.AllowEdit = false;
      this.gridColumn9.OptionsColumn.AllowFocus = false;
      this.gridColumn9.OptionsColumn.ReadOnly = true;
      this.gridColumn9.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Haziran", "{0:C2}")
      });
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 8;
      this.gridColumn10.Caption = "Ağustos";
      this.gridColumn10.FieldName = "Ağustos";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.OptionsColumn.AllowEdit = false;
      this.gridColumn10.OptionsColumn.AllowFocus = false;
      this.gridColumn10.OptionsColumn.ReadOnly = true;
      this.gridColumn10.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ağustos", "{0:C2}")
      });
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 9;
      this.gridColumn11.Caption = "Eylül";
      this.gridColumn11.FieldName = "Eylül";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.OptionsColumn.AllowEdit = false;
      this.gridColumn11.OptionsColumn.AllowFocus = false;
      this.gridColumn11.OptionsColumn.ReadOnly = true;
      this.gridColumn11.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Eylül", "{0:C2}")
      });
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 10;
      this.gridColumn12.Caption = "Ekim";
      this.gridColumn12.FieldName = "Ekim";
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.OptionsColumn.AllowEdit = false;
      this.gridColumn12.OptionsColumn.AllowFocus = false;
      this.gridColumn12.OptionsColumn.ReadOnly = true;
      this.gridColumn12.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ekim", "{0:C2}")
      });
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 11;
      this.gridColumn13.Caption = "Kasım";
      this.gridColumn13.FieldName = "ay";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.OptionsColumn.AllowEdit = false;
      this.gridColumn13.OptionsColumn.AllowFocus = false;
      this.gridColumn13.OptionsColumn.ReadOnly = true;
      this.gridColumn13.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "ay", "{0:C2}")
      });
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 12;
      this.gridColumn14.Caption = "Aralık";
      this.gridColumn14.FieldName = "Kasım";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.OptionsColumn.AllowEdit = false;
      this.gridColumn14.OptionsColumn.AllowFocus = false;
      this.gridColumn14.OptionsColumn.ReadOnly = true;
      this.gridColumn14.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Kasım", "{0:C2}")
      });
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 13;
      this.gridColumn15.Caption = "Toplam Tutar";
      this.gridColumn15.FieldName = "TUTAR";
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.OptionsColumn.AllowEdit = false;
      this.gridColumn15.OptionsColumn.AllowFocus = false;
      this.gridColumn15.OptionsColumn.ReadOnly = true;
      this.gridColumn15.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TUTAR", "{0:C2}")
      });
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 14;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet1;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLTEKLIFTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.teklifToplamlariTableAdapter.ClearBeforeFill = true;
      this.teklifHrktCekTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new Size(1258, 744);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (TeklifListesi);
      this.Text = "Form6";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.gridView2.EndInit();
      this.talepKodu.EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.firmalar.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.personeller.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      this.repositoryItemProgressBar1.EndInit();
      this.gridView1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.teklifHrktCekBindingSource).EndInit();
      this.teklifHrktCek.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.tabNavigationPage1.ResumeLayout(false);
      this.tabNavigationPage2.ResumeLayout(false);
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.teklifToplamlariBindingSource).EndInit();
      this.gridView3.EndInit();
      this.tabNavigationPage4.ResumeLayout(false);
      this.gridControl4.EndInit();
      this.gridView4.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
