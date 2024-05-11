// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.talepFisListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.DepoModel;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class talepFisListesi : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private TabNavigationPage tabNavigationPage3;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage1;
    private GridControl gridControl2;
    private GridView gridView2;
    private SimpleButton simpleButton1;
    private TabPane tabPane1;
    private GridControl gridControl1;
    private GridView gridView1;
    private BarButtonItem barButtonItem13;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private BarCheckItem barCheckItem6;
    private GridControl gridControl3;
    private GridView gridView3;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit6;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit7;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit8;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit3;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit4;
    private GridControl gridControl4;
    private GridView gridView4;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit9;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit10;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit11;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit12;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit13;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit14;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit15;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit16;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit5;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit6;
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private RepositoryItemSearchLookUpEdit IsEmri;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit AlanUsta;
    private GridView gridView5;
    private RepositoryItemSearchLookUpEdit Firma;
    private GridView gridView6;
    private RepositoryItemSearchLookUpEdit personel;
    private GridView gridView7;
    private talepFisListesi1 talepFisListesi1;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.DepoModel.talepFisListesi1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colTalepDurumu;
    private GridColumn colTalepFişKodu;
    private GridColumn colTalepKod;
    private GridColumn colTarih;
    private GridColumn colİşEmriKod;
    private GridColumn gridColumn1;
    private GridColumn colTalepEdenUsta;
    private GridColumn colAtölyeŞefi;
    private GridColumn colDepoYetkilis;
    private GridColumn colŞubeMüdürü;
    private GridColumn colOnayZamanı;
    private GridColumn colFirmaAdı;
    private GridColumn colİptalSebebi;
    private talepFishrktleri2 talepFishrktleri2;
    private BindingSource dataTable1BindingSource1;
    private Makina_Ikmal.DepoModel.talepFishrktleri2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn colID;
    private GridColumn colTARIH1;
    private GridColumn colKOD;
    private GridColumn colPLAKA;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private GridColumn colMALZEMEGRUP;
    private GridColumn colMIKTAR;
    private GridColumn colBOLUMADI;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private talepFisMalzeme3 talepFisMalzeme3;
    private BindingSource dataTable1BindingSource2;
    private Makina_Ikmal.DepoModel.talepFisMalzeme3TableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
    private GridColumn colMALZEMEADI1;
    private GridColumn colBIRIMADI1;
    private GridColumn colMALZEMEGRUP1;
    private GridColumn colExpr1;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLISEMRIBindingSource;
    private TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn gridColumn6;
    private RepositoryItemLookUpEdit atolye;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;

    public talepFisListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayıt";
      int num = (int) new TalepKayıt().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet7.TBLATOLYEBOLUM);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet7.TBLISEMRI);
      this.listele();
    }

    public void listele()
    {
      this.dataTable1TableAdapter2.Fill(this.talepFisMalzeme3.DataTable1);
      this.dataTable1TableAdapter1.Fill(this.talepFishrktleri2.DataTable1);
      this.dataTable1TableAdapter.Fill(this.talepFisListesi1.DataTable1);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl2_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (!((sender as GridView).GetRowCellValue(e.RowHandle, "Talep Durumu").ToString() == "Onaylandı"))
        return;
      e.Appearance.BackColor = Color.Green;
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e) => YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private string secmeislemi()
    {
      this.secme = "";
      string text = "";
      if (this.barCheckItem1.Checked)
        this.secme += "[ISEMRIDURUMID] = 1 OR";
      if (this.barCheckItem2.Checked)
        this.secme += "  [ISEMRIDURUMID] = 2 OR";
      if (this.barCheckItem3.Checked)
        this.secme += "[ISEMRIDURUMID] = 3 OR";
      if (this.barCheckItem4.Checked)
        this.secme += "[ISEMRIDURUMID] = 4 OR";
      if (this.barCheckItem5.Checked)
        this.secme += "[ISEMRIDURUMID] = 5 OR";
      if (this.barCheckItem6.Checked)
        this.secme += "[ISEMRIDURUMID] = 6 OR";
      try
      {
        text = this.secme.Substring(0, this.secme.Length - 2);
      }
      catch (Exception ex)
      {
      }
      int num = (int) XtraMessageBox.Show(text);
      return text;
    }

    private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e)
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new TalepDuzenleme().ShowDialog();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new TalepDuzenleme().ShowDialog();
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (talepFisListesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.talepFisListesi1 = new talepFisListesi1();
      this.gridView1 = new GridView();
      this.colTalepDurumu = new GridColumn();
      this.colTalepFişKodu = new GridColumn();
      this.colTalepKod = new GridColumn();
      this.colTarih = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.atolye = new RepositoryItemLookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.colİşEmriKod = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.colTalepEdenUsta = new GridColumn();
      this.AlanUsta = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.colAtölyeŞefi = new GridColumn();
      this.personel = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView7 = new GridView();
      this.colDepoYetkilis = new GridColumn();
      this.colŞubeMüdürü = new GridColumn();
      this.colOnayZamanı = new GridColumn();
      this.colFirmaAdı = new GridColumn();
      this.Firma = new RepositoryItemSearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.gridView6 = new GridView();
      this.colİptalSebebi = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.IsEmri = new RepositoryItemSearchLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.repositoryItemSearchLookUpEdit1View = new GridView();
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
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl4 = new GridControl();
      this.dataTable1BindingSource2 = new BindingSource(this.components);
      this.talepFisMalzeme3 = new talepFisMalzeme3();
      this.gridView4 = new GridView();
      this.colMALZEMEADI1 = new GridColumn();
      this.colBIRIMADI1 = new GridColumn();
      this.colMALZEMEGRUP1 = new GridColumn();
      this.colExpr1 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.repositoryItemLookUpEdit9 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit14 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit10 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit13 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit11 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit16 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit15 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit12 = new RepositoryItemLookUpEdit();
      this.repositoryItemTimeSpanEdit5 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit6 = new RepositoryItemTimeSpanEdit();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.talepFishrktleri2 = new talepFishrktleri2();
      this.gridView3 = new GridView();
      this.colID = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.colKOD = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit6 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit5 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit8 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit7 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit4 = new RepositoryItemLookUpEdit();
      this.repositoryItemTimeSpanEdit3 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit4 = new RepositoryItemTimeSpanEdit();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.simpleButton1 = new SimpleButton();
      this.tabPane1 = new TabPane();
      this.dataTable1TableAdapter = new Makina_Ikmal.DepoModel.talepFisListesi1TableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.DepoModel.talepFishrktleri2TableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter2 = new Makina_Ikmal.DepoModel.talepFisMalzeme3TableAdapters.DataTable1TableAdapter();
      this.tBLISEMRITableAdapter = new TBLISEMRITableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.talepFisListesi1.BeginInit();
      this.gridView1.BeginInit();
      this.atolye.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.AlanUsta.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.gridView5.BeginInit();
      this.personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView7.BeginInit();
      this.Firma.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.gridView6.BeginInit();
      this.IsEmri.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      this.talepFisMalzeme3.BeginInit();
      this.gridView4.BeginInit();
      this.repositoryItemLookUpEdit9.BeginInit();
      this.repositoryItemLookUpEdit14.BeginInit();
      this.repositoryItemLookUpEdit10.BeginInit();
      this.repositoryItemLookUpEdit13.BeginInit();
      this.repositoryItemLookUpEdit11.BeginInit();
      this.repositoryItemLookUpEdit16.BeginInit();
      this.repositoryItemLookUpEdit15.BeginInit();
      this.repositoryItemLookUpEdit12.BeginInit();
      this.repositoryItemTimeSpanEdit5.BeginInit();
      this.repositoryItemTimeSpanEdit6.BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.talepFishrktleri2.BeginInit();
      this.gridView3.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemLookUpEdit6.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.repositoryItemLookUpEdit5.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.repositoryItemLookUpEdit8.BeginInit();
      this.repositoryItemLookUpEdit7.BeginInit();
      this.repositoryItemLookUpEdit4.BeginInit();
      this.repositoryItemTimeSpanEdit3.BeginInit();
      this.repositoryItemTimeSpanEdit4.BeginInit();
      this.tabNavigationPage1.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView2.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[29]
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
        (BarItem) this.barButtonItem20
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 28;
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
      this.ribbonControl1.Size = new Size(1042, 96);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.DropDownEnabled = false;
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Düzenle";
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
      this.barButtonItem8.Caption = "barButtonItem8";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "barButtonItem9";
      this.barButtonItem9.Id = 9;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Filtrele";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 35;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem1.RibbonStyle = RibbonItemStyles.Large;
      this.repositoryItemSearchControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.IsEmri,
        (RepositoryItem) this.AlanUsta,
        (RepositoryItem) this.Firma,
        (RepositoryItem) this.personel,
        (RepositoryItem) this.atolye
      });
      this.gridControl1.Size = new Size(1042, 440);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.talepFisListesi1;
      this.talepFisListesi1.DataSetName = "talepFisListesi1";
      this.talepFisListesi1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = Color.Silver;
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[16]
      {
        this.colTalepDurumu,
        this.colTalepFişKodu,
        this.colTalepKod,
        this.colTarih,
        this.gridColumn6,
        this.colİşEmriKod,
        this.gridColumn1,
        this.colTalepEdenUsta,
        this.colAtölyeŞefi,
        this.colDepoYetkilis,
        this.colŞubeMüdürü,
        this.colOnayZamanı,
        this.colFirmaAdı,
        this.colİptalSebebi,
        this.gridColumn2,
        this.gridColumn5
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colTalepFişKodu, ColumnSortOrder.Descending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colTalepDurumu.AppearanceCell.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colTalepDurumu.AppearanceCell.Options.UseFont = true;
      this.colTalepDurumu.FieldName = "Talep Durumu";
      this.colTalepDurumu.MinWidth = 19;
      this.colTalepDurumu.Name = "colTalepDurumu";
      this.colTalepDurumu.OptionsColumn.AllowEdit = false;
      this.colTalepDurumu.OptionsColumn.ReadOnly = true;
      this.colTalepDurumu.Visible = true;
      this.colTalepDurumu.VisibleIndex = 0;
      this.colTalepDurumu.Width = 165;
      this.colTalepFişKodu.FieldName = "Talep Fiş Kodu";
      this.colTalepFişKodu.MinWidth = 19;
      this.colTalepFişKodu.Name = "colTalepFişKodu";
      this.colTalepFişKodu.OptionsColumn.AllowEdit = false;
      this.colTalepFişKodu.OptionsColumn.ReadOnly = true;
      this.colTalepFişKodu.Visible = true;
      this.colTalepFişKodu.VisibleIndex = 1;
      this.colTalepFişKodu.Width = 125;
      this.colTalepKod.FieldName = "Talep Kod";
      this.colTalepKod.MinWidth = 19;
      this.colTalepKod.Name = "colTalepKod";
      this.colTalepKod.OptionsColumn.AllowEdit = false;
      this.colTalepKod.OptionsColumn.ReadOnly = true;
      this.colTalepKod.Visible = true;
      this.colTalepKod.VisibleIndex = 2;
      this.colTalepKod.Width = 104;
      this.colTarih.FieldName = "Tarih";
      this.colTarih.MinWidth = 19;
      this.colTarih.Name = "colTarih";
      this.colTarih.OptionsColumn.AllowEdit = false;
      this.colTarih.OptionsColumn.ReadOnly = true;
      this.colTarih.Visible = true;
      this.colTarih.VisibleIndex = 3;
      this.colTarih.Width = 108;
      this.gridColumn6.Caption = "Atölye Adı";
      this.gridColumn6.ColumnEdit = (RepositoryItem) this.atolye;
      this.gridColumn6.FieldName = "ATOLYEID";
      this.gridColumn6.MinWidth = 19;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 5;
      this.gridColumn6.Width = 104;
      this.atolye.AutoHeight = false;
      this.atolye.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolye.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.atolye.DisplayMember = "BOLUMADI";
      this.atolye.Name = "atolye";
      this.atolye.NullText = "";
      this.atolye.ValueMember = "ID";
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colİşEmriKod.FieldName = "İş Emri Kod";
      this.colİşEmriKod.MinWidth = 19;
      this.colİşEmriKod.Name = "colİşEmriKod";
      this.colİşEmriKod.OptionsColumn.AllowEdit = false;
      this.colİşEmriKod.OptionsColumn.ReadOnly = true;
      this.colİşEmriKod.Visible = true;
      this.colİşEmriKod.VisibleIndex = 4;
      this.colİşEmriKod.Width = 105;
      this.gridColumn1.FieldName = "İşlem Yeri (Plaka)";
      this.gridColumn1.MinWidth = 19;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 6;
      this.gridColumn1.Width = 148;
      this.colTalepEdenUsta.ColumnEdit = (RepositoryItem) this.AlanUsta;
      this.colTalepEdenUsta.FieldName = "Talep Eden Usta";
      this.colTalepEdenUsta.MinWidth = 19;
      this.colTalepEdenUsta.Name = "colTalepEdenUsta";
      this.colTalepEdenUsta.OptionsColumn.AllowEdit = false;
      this.colTalepEdenUsta.OptionsColumn.ReadOnly = true;
      this.colTalepEdenUsta.Visible = true;
      this.colTalepEdenUsta.VisibleIndex = 7;
      this.colTalepEdenUsta.Width = (int) sbyte.MaxValue;
      this.AlanUsta.AutoHeight = false;
      this.AlanUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AlanUsta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.AlanUsta.DisplayMember = "USTAADISOYADI";
      this.AlanUsta.Name = "AlanUsta";
      this.AlanUsta.NullText = "";
      this.AlanUsta.PopupView = (ColumnView) this.gridView5;
      this.AlanUsta.ValueMember = "ID";
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colAtölyeŞefi.ColumnEdit = (RepositoryItem) this.personel;
      this.colAtölyeŞefi.FieldName = "Atölye Şefi";
      this.colAtölyeŞefi.MinWidth = 19;
      this.colAtölyeŞefi.Name = "colAtölyeŞefi";
      this.colAtölyeŞefi.OptionsColumn.AllowEdit = false;
      this.colAtölyeŞefi.OptionsColumn.ReadOnly = true;
      this.colAtölyeŞefi.Visible = true;
      this.colAtölyeŞefi.VisibleIndex = 8;
      this.colAtölyeŞefi.Width = 148;
      this.personel.AutoHeight = false;
      this.personel.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personel.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personel.DisplayMember = "ADISOYADI";
      this.personel.Name = "personel";
      this.personel.NullText = "";
      this.personel.PopupView = (ColumnView) this.gridView7;
      this.personel.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView7.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView7.OptionsView.ShowGroupPanel = false;
      this.colDepoYetkilis.ColumnEdit = (RepositoryItem) this.personel;
      this.colDepoYetkilis.FieldName = "Depo Yetkilis";
      this.colDepoYetkilis.MinWidth = 19;
      this.colDepoYetkilis.Name = "colDepoYetkilis";
      this.colDepoYetkilis.OptionsColumn.AllowEdit = false;
      this.colDepoYetkilis.OptionsColumn.ReadOnly = true;
      this.colDepoYetkilis.Visible = true;
      this.colDepoYetkilis.VisibleIndex = 9;
      this.colDepoYetkilis.Width = 175;
      this.colŞubeMüdürü.ColumnEdit = (RepositoryItem) this.personel;
      this.colŞubeMüdürü.FieldName = "Şube Müdürü";
      this.colŞubeMüdürü.MinWidth = 19;
      this.colŞubeMüdürü.Name = "colŞubeMüdürü";
      this.colŞubeMüdürü.OptionsColumn.AllowEdit = false;
      this.colŞubeMüdürü.OptionsColumn.ReadOnly = true;
      this.colŞubeMüdürü.Visible = true;
      this.colŞubeMüdürü.VisibleIndex = 10;
      this.colŞubeMüdürü.Width = 130;
      this.colOnayZamanı.FieldName = "Onay Zamanı";
      this.colOnayZamanı.MinWidth = 19;
      this.colOnayZamanı.Name = "colOnayZamanı";
      this.colOnayZamanı.OptionsColumn.AllowEdit = false;
      this.colOnayZamanı.OptionsColumn.ReadOnly = true;
      this.colOnayZamanı.Visible = true;
      this.colOnayZamanı.VisibleIndex = 11;
      this.colOnayZamanı.Width = 146;
      this.colFirmaAdı.ColumnEdit = (RepositoryItem) this.Firma;
      this.colFirmaAdı.FieldName = "Firma Adı";
      this.colFirmaAdı.MinWidth = 19;
      this.colFirmaAdı.Name = "colFirmaAdı";
      this.colFirmaAdı.OptionsColumn.AllowEdit = false;
      this.colFirmaAdı.OptionsColumn.ReadOnly = true;
      this.colFirmaAdı.Visible = true;
      this.colFirmaAdı.VisibleIndex = 12;
      this.colFirmaAdı.Width = 109;
      this.Firma.AutoHeight = false;
      this.Firma.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Firma.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.Firma.DisplayMember = "FIRMAADI";
      this.Firma.Name = "Firma";
      this.Firma.NullText = "";
      this.Firma.PopupView = (ColumnView) this.gridView6;
      this.Firma.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.colİptalSebebi.FieldName = "İptal Sebebi";
      this.colİptalSebebi.MinWidth = 19;
      this.colİptalSebebi.Name = "colİptalSebebi";
      this.colİptalSebebi.OptionsColumn.AllowEdit = false;
      this.colİptalSebebi.OptionsColumn.ReadOnly = true;
      this.colİptalSebebi.Visible = true;
      this.colİptalSebebi.VisibleIndex = 13;
      this.colİptalSebebi.Width = 92;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.MinWidth = 19;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Width = 101;
      this.gridColumn5.Caption = "gridColumn5";
      this.gridColumn5.FieldName = "ID";
      this.gridColumn5.MinWidth = 19;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.OptionsColumn.AllowEdit = false;
      this.gridColumn5.OptionsColumn.ReadOnly = true;
      this.gridColumn5.Width = 70;
      this.IsEmri.AutoHeight = false;
      this.IsEmri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IsEmri.DataSource = (object) this.tBLISEMRIBindingSource;
      this.IsEmri.DisplayMember = "KOD";
      this.IsEmri.Name = "IsEmri";
      this.IsEmri.NullText = "";
      this.IsEmri.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.IsEmri.ValueMember = "ID";
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet7;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem2.CheckedChanged += new ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.CheckedChanged += new ItemClickEventHandler(this.barCheckItem3_CheckedChanged);
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem4.CheckedChanged += new ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem5.CheckedChanged += new ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
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
      this.barCheckItem6.CheckedChanged += new ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
      this.barButtonItem17.Caption = "Excel";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem18.ItemClick += new ItemClickEventHandler(this.barButtonItem18_ItemClick);
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tabNavigationPage3.Caption = "Talep  Fiş Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabNavigationPage3.Margin = new Padding(2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1042, 444);
      this.gridControl4.DataSource = (object) this.dataTable1BindingSource2;
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.Margin = new Padding(2);
      this.gridControl4.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl4.Name = "gridControl4";
      this.gridControl4.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit9,
        (RepositoryItem) this.repositoryItemLookUpEdit14,
        (RepositoryItem) this.repositoryItemLookUpEdit10,
        (RepositoryItem) this.repositoryItemLookUpEdit13,
        (RepositoryItem) this.repositoryItemLookUpEdit11,
        (RepositoryItem) this.repositoryItemLookUpEdit16,
        (RepositoryItem) this.repositoryItemLookUpEdit15,
        (RepositoryItem) this.repositoryItemLookUpEdit12,
        (RepositoryItem) this.repositoryItemTimeSpanEdit5,
        (RepositoryItem) this.repositoryItemTimeSpanEdit6
      });
      this.gridControl4.Size = new Size(1042, 444);
      this.gridControl4.TabIndex = 7;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.talepFisMalzeme3;
      this.talepFisMalzeme3.DataSetName = "talepFisMalzeme3";
      this.talepFisMalzeme3.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView4.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView4.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView4.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView4.Appearance.Row.BackColor = Color.White;
      this.gridView4.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView4.Appearance.Row.Options.UseBackColor = true;
      this.gridView4.Appearance.Row.Options.UseFont = true;
      this.gridView4.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView4.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView4.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView4.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView4.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView4.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView4.Columns.AddRange(new GridColumn[5]
      {
        this.colMALZEMEADI1,
        this.colBIRIMADI1,
        this.colMALZEMEGRUP1,
        this.colExpr1,
        this.gridColumn4
      });
      this.gridView4.DetailHeight = 284;
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.MinWidth = 19;
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 0;
      this.colMALZEMEADI1.Width = 221;
      this.colBIRIMADI1.FieldName = "BIRIMADI";
      this.colBIRIMADI1.MinWidth = 19;
      this.colBIRIMADI1.Name = "colBIRIMADI1";
      this.colBIRIMADI1.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI1.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI1.Visible = true;
      this.colBIRIMADI1.VisibleIndex = 1;
      this.colBIRIMADI1.Width = 111;
      this.colMALZEMEGRUP1.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP1.MinWidth = 19;
      this.colMALZEMEGRUP1.Name = "colMALZEMEGRUP1";
      this.colMALZEMEGRUP1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP1.Visible = true;
      this.colMALZEMEGRUP1.VisibleIndex = 2;
      this.colMALZEMEGRUP1.Width = 115;
      this.colExpr1.FieldName = "Expr1";
      this.colExpr1.MinWidth = 19;
      this.colExpr1.Name = "colExpr1";
      this.colExpr1.OptionsColumn.AllowEdit = false;
      this.colExpr1.OptionsColumn.ReadOnly = true;
      this.colExpr1.Visible = true;
      this.colExpr1.VisibleIndex = 4;
      this.colExpr1.Width = 81;
      this.gridColumn4.Caption = "gridColumn4";
      this.gridColumn4.FieldName = "BOLUMADI";
      this.gridColumn4.MinWidth = 19;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.AllowEdit = false;
      this.gridColumn4.OptionsColumn.ReadOnly = true;
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 70;
      this.repositoryItemLookUpEdit9.AutoHeight = false;
      this.repositoryItemLookUpEdit9.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit9.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit9.Name = "repositoryItemLookUpEdit9";
      this.repositoryItemLookUpEdit9.NullText = "";
      this.repositoryItemLookUpEdit9.ValueMember = "ID";
      this.repositoryItemLookUpEdit14.AutoHeight = false;
      this.repositoryItemLookUpEdit14.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit14.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit14.Name = "repositoryItemLookUpEdit14";
      this.repositoryItemLookUpEdit14.NullText = "";
      this.repositoryItemLookUpEdit14.ValueMember = "ID";
      this.repositoryItemLookUpEdit10.AutoHeight = false;
      this.repositoryItemLookUpEdit10.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit10.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit10.Name = "repositoryItemLookUpEdit10";
      this.repositoryItemLookUpEdit10.NullText = "";
      this.repositoryItemLookUpEdit10.ValueMember = "ID";
      this.repositoryItemLookUpEdit13.AutoHeight = false;
      this.repositoryItemLookUpEdit13.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit13.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit13.Name = "repositoryItemLookUpEdit13";
      this.repositoryItemLookUpEdit13.NullText = "";
      this.repositoryItemLookUpEdit13.ValueMember = "ID";
      this.repositoryItemLookUpEdit11.AutoHeight = false;
      this.repositoryItemLookUpEdit11.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit11.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit11.Name = "repositoryItemLookUpEdit11";
      this.repositoryItemLookUpEdit11.NullText = "";
      this.repositoryItemLookUpEdit11.ValueMember = "ID";
      this.repositoryItemLookUpEdit16.AutoHeight = false;
      this.repositoryItemLookUpEdit16.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit16.DisplayMember = "BAKIMDERECE";
      this.repositoryItemLookUpEdit16.Name = "repositoryItemLookUpEdit16";
      this.repositoryItemLookUpEdit16.NullText = "";
      this.repositoryItemLookUpEdit16.ValueMember = "ID";
      this.repositoryItemLookUpEdit15.AutoHeight = false;
      this.repositoryItemLookUpEdit15.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit15.DisplayMember = "BAKIMTURU";
      this.repositoryItemLookUpEdit15.Name = "repositoryItemLookUpEdit15";
      this.repositoryItemLookUpEdit15.NullText = "";
      this.repositoryItemLookUpEdit15.ValueMember = "ID";
      this.repositoryItemLookUpEdit12.AutoHeight = false;
      this.repositoryItemLookUpEdit12.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit12.DisplayMember = "ARIZANEDENI";
      this.repositoryItemLookUpEdit12.Name = "repositoryItemLookUpEdit12";
      this.repositoryItemLookUpEdit12.NullText = "";
      this.repositoryItemLookUpEdit12.ValueMember = "ID";
      this.repositoryItemTimeSpanEdit5.AutoHeight = false;
      this.repositoryItemTimeSpanEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit5.Mask.EditMask = "t";
      this.repositoryItemTimeSpanEdit5.Name = "repositoryItemTimeSpanEdit5";
      this.repositoryItemTimeSpanEdit6.AutoHeight = false;
      this.repositoryItemTimeSpanEdit6.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit6.Name = "repositoryItemTimeSpanEdit6";
      this.tabNavigationPage2.Caption = "Talep Fiş Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabNavigationPage2.Margin = new Padding(2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1042, 444);
      this.gridControl3.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(2);
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit6,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit5,
        (RepositoryItem) this.repositoryItemLookUpEdit3,
        (RepositoryItem) this.repositoryItemLookUpEdit8,
        (RepositoryItem) this.repositoryItemLookUpEdit7,
        (RepositoryItem) this.repositoryItemLookUpEdit4,
        (RepositoryItem) this.repositoryItemTimeSpanEdit3,
        (RepositoryItem) this.repositoryItemTimeSpanEdit4
      });
      this.gridControl3.Size = new Size(1042, 444);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.talepFishrktleri2;
      this.talepFishrktleri2.DataSetName = "talepFishrktleri2";
      this.talepFishrktleri2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView3.Appearance.EvenRow.BackColor = Color.Silver;
      this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView3.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView3.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView3.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.BackColor = Color.White;
      this.gridView3.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView3.Appearance.Row.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.Options.UseFont = true;
      this.gridView3.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView3.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView3.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView3.Columns.AddRange(new GridColumn[10]
      {
        this.colID,
        this.colTARIH1,
        this.colKOD,
        this.colPLAKA,
        this.colMALZEMEADI,
        this.colBIRIMADI,
        this.colMALZEMEGRUP,
        this.colMIKTAR,
        this.colBOLUMADI,
        this.gridColumn3
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 19;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 70;
      this.colTARIH1.Caption = "Tarih";
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.MinWidth = 19;
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.OptionsColumn.AllowEdit = false;
      this.colTARIH1.OptionsColumn.ReadOnly = true;
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 0;
      this.colTARIH1.Width = 139;
      this.colKOD.Caption = "Talep Kodu";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 19;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 1;
      this.colKOD.Width = 118;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 19;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 2;
      this.colPLAKA.Width = 133;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 19;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 3;
      this.colMALZEMEADI.Width = 156;
      this.colBIRIMADI.Caption = "Birim";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 19;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 4;
      this.colBIRIMADI.Width = 145;
      this.colMALZEMEGRUP.Caption = "Grup 1";
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.MinWidth = 19;
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 5;
      this.colMALZEMEGRUP.Width = 150;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 19;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 6;
      this.colMIKTAR.Width = 148;
      this.colBOLUMADI.Caption = "Bölüm";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 19;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 7;
      this.colBOLUMADI.Width = 171;
      this.gridColumn3.Caption = "gridColumn3";
      this.gridColumn3.FieldName = "TalepId";
      this.gridColumn3.MinWidth = 19;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.AllowEdit = false;
      this.gridColumn3.OptionsColumn.ReadOnly = true;
      this.gridColumn3.Width = 70;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.repositoryItemLookUpEdit6.AutoHeight = false;
      this.repositoryItemLookUpEdit6.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit6.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit6.Name = "repositoryItemLookUpEdit6";
      this.repositoryItemLookUpEdit6.NullText = "";
      this.repositoryItemLookUpEdit6.ValueMember = "ID";
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.NullText = "";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.repositoryItemLookUpEdit5.AutoHeight = false;
      this.repositoryItemLookUpEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit5.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
      this.repositoryItemLookUpEdit5.NullText = "";
      this.repositoryItemLookUpEdit5.ValueMember = "ID";
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.NullText = "";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.repositoryItemLookUpEdit8.AutoHeight = false;
      this.repositoryItemLookUpEdit8.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit8.DisplayMember = "BAKIMDERECE";
      this.repositoryItemLookUpEdit8.Name = "repositoryItemLookUpEdit8";
      this.repositoryItemLookUpEdit8.NullText = "";
      this.repositoryItemLookUpEdit8.ValueMember = "ID";
      this.repositoryItemLookUpEdit7.AutoHeight = false;
      this.repositoryItemLookUpEdit7.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit7.DisplayMember = "BAKIMTURU";
      this.repositoryItemLookUpEdit7.Name = "repositoryItemLookUpEdit7";
      this.repositoryItemLookUpEdit7.NullText = "";
      this.repositoryItemLookUpEdit7.ValueMember = "ID";
      this.repositoryItemLookUpEdit4.AutoHeight = false;
      this.repositoryItemLookUpEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit4.DisplayMember = "ARIZANEDENI";
      this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
      this.repositoryItemLookUpEdit4.NullText = "";
      this.repositoryItemLookUpEdit4.ValueMember = "ID";
      this.repositoryItemTimeSpanEdit3.AutoHeight = false;
      this.repositoryItemTimeSpanEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit3.Mask.EditMask = "t";
      this.repositoryItemTimeSpanEdit3.Name = "repositoryItemTimeSpanEdit3";
      this.repositoryItemTimeSpanEdit4.AutoHeight = false;
      this.repositoryItemTimeSpanEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit4.Name = "repositoryItemTimeSpanEdit4";
      this.tabNavigationPage1.AccessibleDescription = "";
      this.tabNavigationPage1.Caption = "Talep Fiş Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabNavigationPage1.Margin = new Padding(2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1042, 440);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1042, 440);
      this.gridControl2.TabIndex = 4;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick_1);
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.DetailHeight = 284;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 2);
      this.simpleButton1.Margin = new Padding(2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(19, 20);
      this.simpleButton1.TabIndex = 3;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 96);
      this.tabPane1.Margin = new Padding(2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[3]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3
      });
      this.tabPane1.RegularSize = new Size(1042, 477);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1042, 477);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Talep Fiş Hareketleri";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.dataTable1TableAdapter2.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1042, 573);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (talepFisListesi);
      this.Text = "Talep Fiş Listesi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.talepFisListesi1.EndInit();
      this.gridView1.EndInit();
      this.atolye.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.AlanUsta.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.gridView5.EndInit();
      this.personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView7.EndInit();
      this.Firma.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.gridView6.EndInit();
      this.IsEmri.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      this.talepFisMalzeme3.EndInit();
      this.gridView4.EndInit();
      this.repositoryItemLookUpEdit9.EndInit();
      this.repositoryItemLookUpEdit14.EndInit();
      this.repositoryItemLookUpEdit10.EndInit();
      this.repositoryItemLookUpEdit13.EndInit();
      this.repositoryItemLookUpEdit11.EndInit();
      this.repositoryItemLookUpEdit16.EndInit();
      this.repositoryItemLookUpEdit15.EndInit();
      this.repositoryItemLookUpEdit12.EndInit();
      this.repositoryItemTimeSpanEdit5.EndInit();
      this.repositoryItemTimeSpanEdit6.EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.talepFishrktleri2.EndInit();
      this.gridView3.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemLookUpEdit6.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.repositoryItemLookUpEdit5.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.repositoryItemLookUpEdit8.EndInit();
      this.repositoryItemLookUpEdit7.EndInit();
      this.repositoryItemLookUpEdit4.EndInit();
      this.repositoryItemTimeSpanEdit3.EndInit();
      this.repositoryItemTimeSpanEdit4.EndInit();
      this.tabNavigationPage1.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView2.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
