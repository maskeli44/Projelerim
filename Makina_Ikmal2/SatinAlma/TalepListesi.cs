// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepListesi
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.ModelSatinAlma;
using Makina_Ikmal.Model.ModelSatinAlma.TalepHareketiTableAdapters;
using Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters;
using Makina_Ikmal.SatinAlma.VeriGuncelleme.Teklif;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TalepListesi : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem yeniKayitButton;
    private BarButtonItem düzenleButton;
    private BarButtonItem silButton;
    private BarButtonItem barButtonItem4;
    private BarButtonItem yenileButton;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private GridView gridView1;
    private GridControl gridControl1;
    private TabPane tabPane1;
    private TabNavigationPage tabNavigationPage1;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage3;
    private BindingSource isemirlistesiBindingSource;
    private isemirlistesi isemirlistesi;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.Model.isemirlistesiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private SimpleButton simpleButton1;
    private PopupMenu popupMenu1;
    private BarButtonItem barButtonItem8;
    private RibbonPageGroup ribbonPageGroup3;
    private BindingSource dataTable1BindingSource1;
    private BindingSource isemirlistesiBindingSource1;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private PopupMenu popupMenu2;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private BarEditItem barEditItem1;
    private RepositoryItemButtonEdit repositoryItemButtonEdit1;
    private BarButtonItem teknikButton;
    private BarButtonItem excelButton;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLTALEPBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPTableAdapter tBLTALEPTableAdapter;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridColumn colID1;
    private GridColumn colKOD1;
    private GridColumn colTEKLIFID;
    private GridColumn colTARIH;
    private GridColumn colBELGESAYI;
    private GridColumn colBELGEKONU;
    private GridColumn colIHALEUSULU;
    private GridColumn colSORUMLUID;
    private GridColumn colDEPOYETKILIID;
    private GridColumn colATOLYESEFID;
    private GridColumn colMUDURID;
    private GridColumn colDAIREBSKID;
    private GridColumn colGENELSEKYRDID;
    private GridColumn colGENELSEKRETERID;
    private BindingSource tBLTALEPFISBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPFISTableAdapter tBLTALEPFISTableAdapter;
    private BindingSource tBLTALEPBindingSource1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLTALEPBindingSource2;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter tBLTALEPTableAdapter1;
    private BindingSource tBLTALEPFISBindingSource1;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPFISTableAdapter tBLTALEPFISTableAdapter1;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemLookUpEdit teklifKod;
    private BindingSource tBLTEKLIFBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFTableAdapter tBLTEKLIFTableAdapter;
    private BindingSource tBLTEKLIFBindingSource1;
    private RepositoryItemLookUpEdit personelAd;
    private BarEditItem aramaKontrol;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl3;
    private GridView gridView3;
    private RepositoryItemLookUpEdit telepKod;
    private BindingSource talepKayitTabloCekBindingSource;
    private TalepKayitTabloCek talepKayitTabloCek;
    private RepositoryItemLookUpEdit talepFisKod;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource talepToplamlariCekBindingSource;
    private TalepToplamlariCekTableAdapter talepToplamlariCekTableAdapter;
    private GridColumn colMALZEMEADI1;
    private GridColumn colID;
    private GridColumn colBIRIMADI;
    private GridColumn colMALZEMEGRUP;
    private GridColumn colBOLUMADI;
    private GridColumn colMIKTAR1;
    private GridColumn colKOD;
    private GridColumn colTARIH1;
    private GridColumn colBELGESAYI1;
    private GridColumn colBELGEKONU1;
    private GridColumn colPLAKA;
    private GridColumn colARACACIKLAMA;
    private GridColumn colMALZEMEADI;
    private GridColumn colMalzemeKodu;
    private GridColumn colBIRIMADI1;
    private GridColumn colBOLUMADI1;
    private GridColumn colSORUMLUID1;
    private GridColumn colMALZEMEGRUP1;
    private GridColumn colMIKTAR;
    private GridColumn colŞubeMüdürü;
    private GridColumn colŞubeMüdürüÜnvanı;
    private TalepHareketi talepHareketi1;
    private GridColumn IDD;
    private BindingSource talepHareketleriBindingSource;
    private TalepHareketleriTableAdapter talepHareketleriTableAdapter;

    public TalepListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void TalepListesi_Load(object sender, EventArgs e) => this.listele();

    public void listele()
    {
      this.tBLTALEPTableAdapter1.Fill(this.bellDataSet5.TBLTALEP);
      this.talepHareketleriTableAdapter.Fill(this.talepHareketi1.TalepHareketleri);
      this.talepToplamlariCekTableAdapter.Fill(this.talepKayitTabloCek.TalepToplamlariCek);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet5.TBLISEMRI);
      this.tBLTEKLIFTableAdapter.Fill(this.bellDataSet5.TBLTEKLIF);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLTALEPFISTableAdapter1.Fill(this.bellDataSet5.TBLTALEPFIS);
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

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void yeniKayitButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
      if (openForm != null)
      {
        openForm.Focus();
      }
      else
      {
        int num = (int) new TalepEkle() { secim = 1 }.ShowDialog();
      }
    }

    private void teknikButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TalepTeknikSartname talepTeknikSartname = new TalepTeknikSartname();
      talepTeknikSartname.Gizle(1);
      int num = (int) talepTeknikSartname.ShowDialog();
    }

    private void düzenleButton_ItemClick(object sender, EventArgs e)
    {
      if (this.tabPane1.SelectedPageIndex == 0)
      {
        TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
        if (openForm != null)
        {
          openForm.Focus();
        }
        else
        {
          YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
          TalepEkle talepEkle = new TalepEkle();
          int int32 = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
          talepEkle.secim = 2;
          talepEkle.Getir(int32);
          talepEkle.Show();
        }
      }
      if (this.tabPane1.SelectedPageIndex != 1)
        return;
      TalepEkle openForm1 = (TalepEkle) Application.OpenForms["TalepEkle"];
      if (openForm1 != null)
      {
        openForm1.Focus();
      }
      else
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
        TalepEkle talepEkle = new TalepEkle();
        int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
        talepEkle.secim = 2;
        talepEkle.Getir(int32);
        talepEkle.Show();
      }
    }

    private void tabPane1_Click(object sender, EventArgs e)
    {
      if (this.tabPane1.SelectedPageIndex == 0)
      {
        this.silButton.Enabled = true;
        this.düzenleButton.Enabled = true;
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      }
      if (this.tabPane1.SelectedPageIndex == 1)
      {
        this.silButton.Enabled = true;
        this.düzenleButton.Enabled = true;
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      }
      if (this.tabPane1.SelectedPageIndex != 2)
        return;
      this.silButton.Enabled = false;
      this.düzenleButton.Enabled = false;
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
    }

    private void silButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.gridView2.GetFocusedRowCellValue(this.colTEKLIFID).ToString() == "" || this.gridView2.GetFocusedRowCellValue(this.colTEKLIFID).ToString() == "0")
      {
        if (this.tabPane1.SelectedPageIndex == 0)
        {
          TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
          if (openForm != null)
          {
            openForm.Focus();
          }
          else
          {
            YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
            int int32 = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
            TalepEkle talepEkle = new TalepEkle();
            talepEkle.Getir(int32);
            talepEkle.secim = 3;
            talepEkle.Show();
          }
        }
        if (this.tabPane1.SelectedPageIndex != 1)
          return;
        TalepEkle openForm1 = (TalepEkle) Application.OpenForms["TalepEkle"];
        if (openForm1 != null)
        {
          openForm1.Focus();
        }
        else
        {
          YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
          int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
          TalepEkle talepEkle = new TalepEkle();
          talepEkle.Getir(int32);
          talepEkle.secim = 3;
          talepEkle.Show();
        }
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Teklife Atılan Talepler Güncellenemez!");
      }
    }

    private void düzenleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.tabPane1.SelectedPageIndex == 0)
      {
        TalepEkle openForm = (TalepEkle) Application.OpenForms["TalepEkle"];
        if (openForm != null)
        {
          openForm.Focus();
        }
        else
        {
          YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
          TalepEkle talepEkle = new TalepEkle();
          int int32 = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
          talepEkle.secim = 2;
          talepEkle.Getir(int32);
          talepEkle.Show();
        }
      }
      if (this.tabPane1.SelectedPageIndex != 1)
        return;
      TalepEkle openForm1 = (TalepEkle) Application.OpenForms["TalepEkle"];
      if (openForm1 != null)
      {
        openForm1.Focus();
      }
      else
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
        TalepEkle talepEkle = new TalepEkle();
        int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("TALEPKAYITID"));
        talepEkle.secim = 2;
        talepEkle.Getir(int32);
        talepEkle.Show();
      }
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) => new SatinAlmaVeriGuncelleme().Show();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepListesi));
      this.ribbonControl1 = new RibbonControl();
      this.yeniKayitButton = new BarButtonItem();
      this.düzenleButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.yenileButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.teknikButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.aramaKontrol = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl2 = new GridControl();
      this.tBLTALEPBindingSource2 = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView2 = new GridView();
      this.colID1 = new GridColumn();
      this.colKOD1 = new GridColumn();
      this.colTEKLIFID = new GridColumn();
      this.teklifKod = new RepositoryItemLookUpEdit();
      this.tBLTEKLIFBindingSource1 = new BindingSource(this.components);
      this.colTARIH = new GridColumn();
      this.colBELGESAYI = new GridColumn();
      this.colBELGEKONU = new GridColumn();
      this.colIHALEUSULU = new GridColumn();
      this.colSORUMLUID = new GridColumn();
      this.personelAd = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colDEPOYETKILIID = new GridColumn();
      this.colATOLYESEFID = new GridColumn();
      this.colMUDURID = new GridColumn();
      this.colDAIREBSKID = new GridColumn();
      this.colGENELSEKYRDID = new GridColumn();
      this.colGENELSEKRETERID = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
      this.talepHareketi1 = new TalepHareketi();
      this.tBLTEKLIFBindingSource = new BindingSource(this.components);
      this.tBLTALEPFISBindingSource1 = new BindingSource(this.components);
      this.tBLTALEPFISBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.tBLTALEPBindingSource1 = new BindingSource(this.components);
      this.tBLTALEPBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.isemirlistesi = new isemirlistesi();
      this.gridView1 = new GridView();
      this.colKOD = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.colBELGESAYI1 = new GridColumn();
      this.colBELGEKONU1 = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colMalzemeKodu = new GridColumn();
      this.colBIRIMADI1 = new GridColumn();
      this.colBOLUMADI1 = new GridColumn();
      this.colSORUMLUID1 = new GridColumn();
      this.colMALZEMEGRUP1 = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colŞubeMüdürü = new GridColumn();
      this.colŞubeMüdürüÜnvanı = new GridColumn();
      this.IDD = new GridColumn();
      this.gridControl1 = new GridControl();
      this.talepHareketleriBindingSource = new BindingSource(this.components);
      this.telepKod = new RepositoryItemLookUpEdit();
      this.talepFisKod = new RepositoryItemLookUpEdit();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.talepKayitTabloCek = new TalepKayitTabloCek();
      this.talepKayitTabloCekBindingSource = new BindingSource(this.components);
      this.tabPane1 = new TabPane();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.simpleButton1 = new SimpleButton();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.talepToplamlariCekBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.colMALZEMEADI1 = new GridColumn();
      this.colID = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.colMIKTAR1 = new GridColumn();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.isemirlistesiBindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.isemirlistesiTableAdapters.DataTable1TableAdapter();
      this.isemirlistesiBindingSource1 = new BindingSource(this.components);
      this.popupMenu2 = new PopupMenu(this.components);
      this.tBLTALEPTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPTableAdapter();
      this.tBLTALEPFISTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPFISTableAdapter();
      this.tBLTALEPTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter();
      this.tBLTALEPFISTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPFISTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.tBLTEKLIFTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFTableAdapter();
      this.tBLISEMRITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter();
      this.talepToplamlariCekTableAdapter = new TalepToplamlariCekTableAdapter();
      this.talepHareketleriTableAdapter = new TalepHareketleriTableAdapter();
      this.ribbonControl1.BeginInit();
      this.popupMenu1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource2).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView2.BeginInit();
      this.teklifKod.BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource1).BeginInit();
      this.personelAd.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemButtonEdit1.BeginInit();
      this.talepHareketi1.BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.isemirlistesi.BeginInit();
      this.gridView1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.talepHareketleriBindingSource).BeginInit();
      this.telepKod.BeginInit();
      this.talepFisKod.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.talepKayitTabloCek.BeginInit();
      ((ISupportInitialize) this.talepKayitTabloCekBindingSource).BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.tabNavigationPage1.SuspendLayout();
      this.tabNavigationPage2.SuspendLayout();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.talepToplamlariCekBindingSource).BeginInit();
      this.gridView3.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource).BeginInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource1).BeginInit();
      this.popupMenu2.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[16]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.yeniKayitButton,
        (BarItem) this.düzenleButton,
        (BarItem) this.silButton,
        (BarItem) this.barButtonItem4,
        (BarItem) this.yenileButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barEditItem1,
        (BarItem) this.teknikButton,
        (BarItem) this.excelButton,
        (BarItem) this.aramaKontrol
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 24;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1192, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.yeniKayitButton.ActAsDropDown = true;
      this.yeniKayitButton.ButtonStyle = BarButtonStyle.DropDown;
      this.yeniKayitButton.Caption = "Yeni Kayıt";
      this.yeniKayitButton.Id = 1;
      this.yeniKayitButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniKayitButton.ImageOptions.Image");
      this.yeniKayitButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniKayitButton.ImageOptions.LargeImage");
      this.yeniKayitButton.LargeWidth = 100;
      this.yeniKayitButton.Name = "yeniKayitButton";
      this.yeniKayitButton.RibbonStyle = RibbonItemStyles.Large;
      this.yeniKayitButton.ItemClick += new ItemClickEventHandler(this.yeniKayitButton_ItemClick);
      this.düzenleButton.Caption = "Düzenle";
      this.düzenleButton.Id = 2;
      this.düzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.Image");
      this.düzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.LargeImage");
      this.düzenleButton.LargeWidth = 100;
      this.düzenleButton.Name = "düzenleButton";
      this.düzenleButton.ItemClick += new ItemClickEventHandler(this.düzenleButton_ItemClick);
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
      this.silButton.ItemClick += new ItemClickEventHandler(this.silButton_ItemClick);
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.DropDownControl = (PopupControl) this.popupMenu1;
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.yenileButton.Caption = "Yenile";
      this.yenileButton.Id = 5;
      this.yenileButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.Image");
      this.yenileButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yenileButton.ImageOptions.LargeImage");
      this.yenileButton.LargeWidth = 100;
      this.yenileButton.Name = "yenileButton";
      this.yenileButton.RibbonStyle = RibbonItemStyles.Large;
      this.yenileButton.ItemClick += new ItemClickEventHandler(this.yenileButton_ItemClick);
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
      this.barButtonItem8.Id = 19;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem11.Id = 20;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem12.Id = 21;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 15;
      this.barEditItem1.Name = "barEditItem1";
      this.teknikButton.Caption = "Teknik Şartname";
      this.teknikButton.Id = 17;
      this.teknikButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("teknikButton.ImageOptions.Image");
      this.teknikButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("teknikButton.ImageOptions.LargeImage");
      this.teknikButton.LargeWidth = 100;
      this.teknikButton.Name = "teknikButton";
      this.teknikButton.ItemClick += new ItemClickEventHandler(this.teknikButton_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 18;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
      this.aramaKontrol.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.aramaKontrol.EditHeight = 25;
      this.aramaKontrol.EditWidth = 140;
      this.aramaKontrol.Hint = "Kayit Bul...";
      this.aramaKontrol.Id = 22;
      this.aramaKontrol.Name = "aramaKontrol";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl2;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl2.DataSource = (object) this.tBLTALEPBindingSource2;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.teklifKod,
        (RepositoryItem) this.personelAd
      });
      this.gridControl2.Size = new Size(1192, 448);
      this.gridControl2.TabIndex = 4;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLTALEPBindingSource2.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource2.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[14]
      {
        this.colID1,
        this.colKOD1,
        this.colTEKLIFID,
        this.colTARIH,
        this.colBELGESAYI,
        this.colBELGEKONU,
        this.colIHALEUSULU,
        this.colSORUMLUID,
        this.colDEPOYETKILIID,
        this.colATOLYESEFID,
        this.colMUDURID,
        this.colDAIREBSKID,
        this.colGENELSEKYRDID,
        this.colGENELSEKRETERID
      });
      this.gridView2.DetailHeight = 284;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD1, ColumnSortOrder.Descending)
      });
      this.gridView2.DoubleClick += new EventHandler(this.düzenleButton_ItemClick);
      this.colID1.FieldName = "ID";
      this.colID1.Name = "colID1";
      this.colKOD1.Caption = "Kod";
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 0;
      this.colTEKLIFID.Caption = "Teklif Kodu";
      this.colTEKLIFID.ColumnEdit = (RepositoryItem) this.teklifKod;
      this.colTEKLIFID.FieldName = "TEKLIFID";
      this.colTEKLIFID.Name = "colTEKLIFID";
      this.colTEKLIFID.Visible = true;
      this.colTEKLIFID.VisibleIndex = 1;
      this.teklifKod.AutoHeight = false;
      this.teklifKod.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.teklifKod.DataSource = (object) this.tBLTEKLIFBindingSource1;
      this.teklifKod.DisplayMember = "KOD";
      this.teklifKod.Name = "teklifKod";
      this.teklifKod.NullText = "";
      this.teklifKod.ValueMember = "ID";
      this.tBLTEKLIFBindingSource1.DataMember = "TBLTEKLIF";
      this.tBLTEKLIFBindingSource1.DataSource = (object) this.bellDataSet5;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 2;
      this.colBELGESAYI.Caption = "Belge Sayısı";
      this.colBELGESAYI.FieldName = "BELGESAYI";
      this.colBELGESAYI.Name = "colBELGESAYI";
      this.colBELGESAYI.Visible = true;
      this.colBELGESAYI.VisibleIndex = 3;
      this.colBELGEKONU.Caption = "Belge Konu";
      this.colBELGEKONU.FieldName = "BELGEKONU";
      this.colBELGEKONU.Name = "colBELGEKONU";
      this.colBELGEKONU.Visible = true;
      this.colBELGEKONU.VisibleIndex = 4;
      this.colIHALEUSULU.Caption = "İhale Usulü";
      this.colIHALEUSULU.FieldName = "IHALEUSULU";
      this.colIHALEUSULU.Name = "colIHALEUSULU";
      this.colIHALEUSULU.Visible = true;
      this.colIHALEUSULU.VisibleIndex = 5;
      this.colSORUMLUID.Caption = "Teklif Sorumlusu";
      this.colSORUMLUID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colSORUMLUID.FieldName = "SORUMLUID";
      this.colSORUMLUID.Name = "colSORUMLUID";
      this.colSORUMLUID.Visible = true;
      this.colSORUMLUID.VisibleIndex = 6;
      this.personelAd.AutoHeight = false;
      this.personelAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personelAd.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personelAd.DisplayMember = "ADISOYADI";
      this.personelAd.Name = "personelAd";
      this.personelAd.NullText = "";
      this.personelAd.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.colDEPOYETKILIID.Caption = "Depo Yetkilisi";
      this.colDEPOYETKILIID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colDEPOYETKILIID.FieldName = "DEPOYETKILIID";
      this.colDEPOYETKILIID.Name = "colDEPOYETKILIID";
      this.colDEPOYETKILIID.Visible = true;
      this.colDEPOYETKILIID.VisibleIndex = 7;
      this.colATOLYESEFID.Caption = "Atölye Yetkilisi";
      this.colATOLYESEFID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colATOLYESEFID.FieldName = "ATOLYESEFID";
      this.colATOLYESEFID.Name = "colATOLYESEFID";
      this.colATOLYESEFID.Visible = true;
      this.colATOLYESEFID.VisibleIndex = 8;
      this.colMUDURID.Caption = "Şube Müdürü";
      this.colMUDURID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colMUDURID.FieldName = "MUDURID";
      this.colMUDURID.Name = "colMUDURID";
      this.colMUDURID.Visible = true;
      this.colMUDURID.VisibleIndex = 9;
      this.colDAIREBSKID.Caption = "Daire Başkanı";
      this.colDAIREBSKID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colDAIREBSKID.FieldName = "DAIREBSKID";
      this.colDAIREBSKID.Name = "colDAIREBSKID";
      this.colDAIREBSKID.Visible = true;
      this.colDAIREBSKID.VisibleIndex = 10;
      this.colGENELSEKYRDID.Caption = "Genel Sekreter Yrd.";
      this.colGENELSEKYRDID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colGENELSEKYRDID.FieldName = "GENELSEKYRDID";
      this.colGENELSEKYRDID.Name = "colGENELSEKYRDID";
      this.colGENELSEKYRDID.Visible = true;
      this.colGENELSEKYRDID.VisibleIndex = 11;
      this.colGENELSEKRETERID.Caption = "Genel Sekreter";
      this.colGENELSEKRETERID.ColumnEdit = (RepositoryItem) this.personelAd;
      this.colGENELSEKRETERID.FieldName = "GENELSEKRETERID";
      this.colGENELSEKRETERID.Name = "colGENELSEKRETERID";
      this.colGENELSEKRETERID.Visible = true;
      this.colGENELSEKRETERID.VisibleIndex = 12;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.aramaKontrol);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniKayitButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.düzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.teknikButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemButtonEdit1.AutoHeight = false;
      this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.repositoryItemButtonEdit1.ButtonsStyle = BorderStyles.NoBorder;
      this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
      this.talepHareketi1.DataSetName = "TalepHareketi";
      this.talepHareketi1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLTEKLIFBindingSource.DataMember = "TBLTEKLIF";
      this.tBLTEKLIFBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLTALEPFISBindingSource1.DataMember = "TBLTALEPFIS";
      this.tBLTALEPFISBindingSource1.DataSource = (object) this.bellDataSet5;
      this.tBLTALEPFISBindingSource.DataMember = "TBLTALEPFIS";
      this.tBLTALEPFISBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLTALEPBindingSource1.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource1.DataSource = (object) this.bellDataSet2;
      this.tBLTALEPBindingSource.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource.DataSource = (object) this.bellDataSet2;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.isemirlistesi;
      this.isemirlistesi.DataSetName = "isemirlistesi";
      this.isemirlistesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[16]
      {
        this.colKOD,
        this.colTARIH1,
        this.colBELGESAYI1,
        this.colBELGEKONU1,
        this.colPLAKA,
        this.colARACACIKLAMA,
        this.colMALZEMEADI,
        this.colMalzemeKodu,
        this.colBIRIMADI1,
        this.colBOLUMADI1,
        this.colSORUMLUID1,
        this.colMALZEMEGRUP1,
        this.colMIKTAR,
        this.colŞubeMüdürü,
        this.colŞubeMüdürüÜnvanı,
        this.IDD
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.DoubleClick += new EventHandler(this.düzenleButton_ItemClick);
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.Name = "colKOD";
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colTARIH1.Caption = "Tarih";
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 1;
      this.colBELGESAYI1.Caption = "Belge Sayısı";
      this.colBELGESAYI1.FieldName = "BELGESAYI";
      this.colBELGESAYI1.Name = "colBELGESAYI1";
      this.colBELGESAYI1.Visible = true;
      this.colBELGESAYI1.VisibleIndex = 2;
      this.colBELGEKONU1.Caption = "Belge Konusu";
      this.colBELGEKONU1.FieldName = "BELGEKONU";
      this.colBELGEKONU1.Name = "colBELGEKONU1";
      this.colBELGEKONU1.Visible = true;
      this.colBELGEKONU1.VisibleIndex = 3;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 4;
      this.colARACACIKLAMA.Caption = "Araç Açıklaması";
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 5;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 6;
      this.colMalzemeKodu.FieldName = "Malzeme Kodu";
      this.colMalzemeKodu.Name = "colMalzemeKodu";
      this.colMalzemeKodu.Visible = true;
      this.colMalzemeKodu.VisibleIndex = 7;
      this.colBIRIMADI1.Caption = "Birimi";
      this.colBIRIMADI1.FieldName = "BIRIMADI";
      this.colBIRIMADI1.Name = "colBIRIMADI1";
      this.colBIRIMADI1.Visible = true;
      this.colBIRIMADI1.VisibleIndex = 8;
      this.colBOLUMADI1.Caption = "Malzeme Bölümü";
      this.colBOLUMADI1.FieldName = "BOLUMADI";
      this.colBOLUMADI1.Name = "colBOLUMADI1";
      this.colBOLUMADI1.Visible = true;
      this.colBOLUMADI1.VisibleIndex = 9;
      this.colSORUMLUID1.Caption = "Birim Sorumlusu";
      this.colSORUMLUID1.FieldName = "SORUMLUID";
      this.colSORUMLUID1.Name = "colSORUMLUID1";
      this.colSORUMLUID1.Visible = true;
      this.colSORUMLUID1.VisibleIndex = 10;
      this.colMALZEMEGRUP1.Caption = "Malzeme Grubu";
      this.colMALZEMEGRUP1.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP1.Name = "colMALZEMEGRUP1";
      this.colMALZEMEGRUP1.Visible = true;
      this.colMALZEMEGRUP1.VisibleIndex = 11;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 12;
      this.colŞubeMüdürü.FieldName = "Şube Müdürü";
      this.colŞubeMüdürü.Name = "colŞubeMüdürü";
      this.colŞubeMüdürü.Visible = true;
      this.colŞubeMüdürü.VisibleIndex = 13;
      this.colŞubeMüdürüÜnvanı.FieldName = "Şube Müdürü Ünvanı";
      this.colŞubeMüdürüÜnvanı.Name = "colŞubeMüdürüÜnvanı";
      this.colŞubeMüdürüÜnvanı.Visible = true;
      this.colŞubeMüdürüÜnvanı.VisibleIndex = 14;
      this.IDD.Caption = "gridColumn1";
      this.IDD.FieldName = "TALEPKAYITID";
      this.IDD.Name = "IDD";
      this.gridControl1.DataSource = (object) this.talepHareketleriBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.telepKod,
        (RepositoryItem) this.talepFisKod
      });
      this.gridControl1.Size = new Size(1192, 448);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.talepHareketleriBindingSource.DataMember = "TalepHareketleri";
      this.talepHareketleriBindingSource.DataSource = (object) this.talepHareketi1;
      this.telepKod.AutoHeight = false;
      this.telepKod.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.telepKod.DataSource = (object) this.tBLTALEPBindingSource1;
      this.telepKod.DisplayMember = "KOD";
      this.telepKod.Name = "telepKod";
      this.telepKod.ValueMember = "ID";
      this.talepFisKod.AutoHeight = false;
      this.talepFisKod.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.talepFisKod.DataSource = (object) this.tBLTALEPFISBindingSource;
      this.talepFisKod.DisplayMember = "KOD";
      this.talepFisKod.Name = "talepFisKod";
      this.talepFisKod.ValueMember = "ID";
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet5;
      this.talepKayitTabloCek.DataSetName = "TalepKayitTabloCek";
      this.talepKayitTabloCek.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.talepKayitTabloCekBindingSource.DataSource = (object) this.talepKayitTabloCek;
      this.talepKayitTabloCekBindingSource.Position = 0;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 100);
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
      this.tabPane1.RegularSize = new Size(1192, 477);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1192, 477);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Talep Listesi";
      this.tabPane1.Click += new EventHandler(this.tabPane1_Click);
      this.tabNavigationPage1.Caption = "Talep Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1192, 448);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 2);
      this.simpleButton1.Margin = new Padding(2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(19, 20);
      this.simpleButton1.TabIndex = 3;
      this.tabNavigationPage2.Caption = "Talep Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage2.Margin = new Padding(2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1192, 448);
      this.tabNavigationPage3.Caption = "Talep Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage3.Margin = new Padding(2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1192, 448);
      this.gridControl3.DataSource = (object) this.talepToplamlariCekBindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.Size = new Size(1192, 448);
      this.gridControl3.TabIndex = 0;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.talepToplamlariCekBindingSource.DataMember = "TalepToplamlariCek";
      this.talepToplamlariCekBindingSource.DataSource = (object) this.talepKayitTabloCekBindingSource;
      this.gridView3.Columns.AddRange(new GridColumn[6]
      {
        this.colMALZEMEADI1,
        this.colID,
        this.colBIRIMADI,
        this.colMALZEMEGRUP,
        this.colBOLUMADI,
        this.colMIKTAR1
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.colMALZEMEADI1.Caption = "Malzeme Adı";
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 0;
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.Caption = "Birim Adı";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 1;
      this.colMALZEMEGRUP.Caption = "Malzeme Grup";
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 2;
      this.colBOLUMADI.Caption = "Bölüm Adı";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 3;
      this.colMIKTAR1.Caption = "Alınan Miktar";
      this.colMIKTAR1.FieldName = "MIKTAR";
      this.colMIKTAR1.Name = "colMIKTAR1";
      this.colMIKTAR1.OptionsColumn.AllowEdit = false;
      this.colMIKTAR1.Visible = true;
      this.colMIKTAR1.VisibleIndex = 4;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.isemirlistesi;
      this.isemirlistesiBindingSource.DataSource = (object) this.isemirlistesi;
      this.isemirlistesiBindingSource.Position = 0;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.isemirlistesiBindingSource1.DataSource = (object) this.isemirlistesi;
      this.isemirlistesiBindingSource1.Position = 0;
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem11);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem12);
      this.popupMenu2.Name = "popupMenu2";
      this.popupMenu2.Ribbon = this.ribbonControl1;
      this.tBLTALEPTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPFISTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPTableAdapter1.ClearBeforeFill = true;
      this.tBLTALEPFISTableAdapter1.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLTEKLIFTableAdapter.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.talepToplamlariCekTableAdapter.ClearBeforeFill = true;
      this.talepHareketleriTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1192, 577);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (TalepListesi);
      this.Text = "Form6";
      this.Load += new EventHandler(this.TalepListesi_Load);
      this.ribbonControl1.EndInit();
      this.popupMenu1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource2).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView2.EndInit();
      this.teklifKod.EndInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource1).EndInit();
      this.personelAd.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemButtonEdit1.EndInit();
      this.talepHareketi1.EndInit();
      ((ISupportInitialize) this.tBLTEKLIFBindingSource).EndInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.isemirlistesi.EndInit();
      this.gridView1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.talepHareketleriBindingSource).EndInit();
      this.telepKod.EndInit();
      this.talepFisKod.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.talepKayitTabloCek.EndInit();
      ((ISupportInitialize) this.talepKayitTabloCekBindingSource).EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.tabNavigationPage1.ResumeLayout(false);
      this.tabNavigationPage2.ResumeLayout(false);
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.talepToplamlariCekBindingSource).EndInit();
      this.gridView3.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource).EndInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource1).EndInit();
      this.popupMenu2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
