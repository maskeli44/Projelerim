// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.GirisFisListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
  public class GirisFisListesi : Form
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
    private RepositoryItemSearchLookUpEdit FirmaId;
    private GridView gridView5;
    private RepositoryItemSearchLookUpEdit İmzalayanDepoYetkilisi;
    private GridView gridView6;
    private GridColumn colKOD;
    private GridColumn colİsEmirKodu;
    private GridColumn colTARIH;
    private GridColumn colALANUSTAID;
    private GridColumn colFIRMAID;
    private GridColumn colISLEMTIPIID;
    private GridColumn colTOPTUTAR;
    private GridColumn colFISTUTAR;
    private GridColumn colARACACIKLAMA;
    private GridColumn colPLAKA;
    private GridColumn colTOPKDVTUTAR;
    private GridColumn colGirişFisi;
    private GridColumn colIMZADEPOYETKILIID;
    private GridColumn gridColumn1;
    private girisfishrktleri girisfishrktleri;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.DepoModel.girisfishrktleriTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colDEPOFISID;
    private GridColumn colPLAKA1;
    private GridColumn colARACACIKLAMA1;
    private GridColumn colKOD1;
    private GridColumn colTARIH1;
    private GridColumn colMALZEMEID;
    private GridColumn colMALZEMEGRUP;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colBIRIMID;
    private GridColumn colMIKTAR;
    private GridColumn colGIRISMIKTAR;
    private GridColumn colCIKISMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colMALZEMEADI;
    private GridColumn colMALZEMEGRUP2;
    private GridColumn colTUTAR;
    private GridColumn colGIRISTUTAR;
    private GridColumn colCIKISTUTAR;
    private GridColumn colKDVORAN;
    private GridColumn colKDVTUTAR;
    private GridColumn colSATIRTUTAR;
    private GridColumn colGCKOD;
    private GridColumn colDEPOID;
    private GridColumn colMALZMARKAID;
    private GridColumn colMALZSERINO;
    private GridColumn colMALZURTTARIH;
    private GridColumn colExpr1;
    private GridColumn colBOLUMADI;
    private GridColumn colID;
    private GridColumn gridColumn2;
    private girisfisListesi girisfisListesi1;
    private BindingSource dataTable1BindingSource1;
    private Makina_Ikmal.Model.girisfisListesiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GirisfisHrkToplam girisfisHrkToplam;
    private BindingSource dataTable1BindingSource2;
    private Makina_Ikmal.DepoModel.GirisfisHrkToplamTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
    private GridColumn colPLAKA2;
    private GridColumn colARACACIKLAMA2;
    private GridColumn colKOD2;
    private GridColumn colMalzemeKod;
    private GridColumn colMALZACIKLAMA1;
    private GridColumn colMALZEMEADI1;
    private GridColumn colBOLUMID;
    private GridColumn colFIRMAID1;
    private GridColumn colBIRIMID1;
    private GridColumn colFIYAT1;
    private GridColumn colMIKTAR1;
    private GridColumn colTutari;
    private GridColumn colKDVORAN1;
    private GridColumn colKdvTutari;

    public GirisFisListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayit";
      int num = (int) new GirisFisEkle().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.dataTable1TableAdapter1.Fill(this.girisfisListesi1.DataTable1);
      this.dataTable1TableAdapter.Fill(this.girisfishrktleri.DataTable1);
      this.dataTable1TableAdapter2.Fill(this.girisfisHrkToplam.DataTable1);
      this.listele();
    }

    public void listele()
    {
      this.dataTable1TableAdapter1.Fill(this.girisfisListesi1.DataTable1);
      this.dataTable1TableAdapter.Fill(this.girisfishrktleri.DataTable1);
      this.dataTable1TableAdapter2.Fill(this.girisfisHrkToplam.DataTable1);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void sayfa()
    {
      if (this.tabPane1.SelectedPage.Name == "tabNavigationPage1")
      {
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
        this.listele();
      }
      else if (this.tabPane1.SelectedPage.Name == "tabNavigationPage2")
      {
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
        this.dataTable1TableAdapter.Fill(this.girisfishrktleri.DataTable1);
      }
      else
      {
        if (!(this.tabPane1.SelectedPage.Name == "tabNavigationPage3"))
          return;
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl4;
      }
    }

    private void gridControl2_DoubleClick_1(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new GirisFisEkle().ShowDialog();
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
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
    }

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e)
    {
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
      int num = (int) new GirisFisEkle().ShowDialog();
    }

    private void tabPane1_Click(object sender, EventArgs e) => this.sayfa();

    private void gridView3_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("DEPOFISID"));
      int num = (int) new GirisFisEkle().ShowDialog();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new GirisFisDuzenle().ShowDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GirisFisListesi));
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
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.girisfisListesi1 = new girisfisListesi();
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.colKOD = new GridColumn();
      this.colİsEmirKodu = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colALANUSTAID = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colTOPTUTAR = new GridColumn();
      this.colFISTUTAR = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colTOPKDVTUTAR = new GridColumn();
      this.colGirişFisi = new GridColumn();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.FirmaId = new RepositoryItemSearchLookUpEdit();
      this.gridView5 = new GridView();
      this.İmzalayanDepoYetkilisi = new RepositoryItemSearchLookUpEdit();
      this.gridView6 = new GridView();
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
      this.girisfisHrkToplam = new GirisfisHrkToplam();
      this.gridView4 = new GridView();
      this.colPLAKA2 = new GridColumn();
      this.colARACACIKLAMA2 = new GridColumn();
      this.colKOD2 = new GridColumn();
      this.colMalzemeKod = new GridColumn();
      this.colMALZACIKLAMA1 = new GridColumn();
      this.colMALZEMEADI1 = new GridColumn();
      this.colBOLUMID = new GridColumn();
      this.colFIRMAID1 = new GridColumn();
      this.colBIRIMID1 = new GridColumn();
      this.colFIYAT1 = new GridColumn();
      this.colMIKTAR1 = new GridColumn();
      this.colTutari = new GridColumn();
      this.colKDVORAN1 = new GridColumn();
      this.colKdvTutari = new GridColumn();
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
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.girisfishrktleri = new girisfishrktleri();
      this.gridView3 = new GridView();
      this.colDEPOFISID = new GridColumn();
      this.colPLAKA1 = new GridColumn();
      this.colARACACIKLAMA1 = new GridColumn();
      this.colKOD1 = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.colMALZACIKLAMA = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colGIRISMIKTAR = new GridColumn();
      this.colCIKISMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colMALZEMEGRUP2 = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colGIRISTUTAR = new GridColumn();
      this.colCIKISTUTAR = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.colKDVTUTAR = new GridColumn();
      this.colSATIRTUTAR = new GridColumn();
      this.colGCKOD = new GridColumn();
      this.colDEPOID = new GridColumn();
      this.colMALZMARKAID = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colExpr1 = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.colID = new GridColumn();
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
      this.dataTable1TableAdapter = new Makina_Ikmal.DepoModel.girisfishrktleriTableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.girisfisListesiTableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter2 = new Makina_Ikmal.DepoModel.GirisfisHrkToplamTableAdapters.DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.girisfisListesi1.BeginInit();
      this.gridView1.BeginInit();
      this.FirmaId.BeginInit();
      this.gridView5.BeginInit();
      this.İmzalayanDepoYetkilisi.BeginInit();
      this.gridView6.BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      this.girisfisHrkToplam.BeginInit();
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
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.girisfishrktleri.BeginInit();
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
      this.ribbonControl1.Items.AddRange(new BarItem[28]
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
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 28;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 329;
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
      this.ribbonControl1.Size = new Size(1389, 122);
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
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
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.FirmaId,
        (RepositoryItem) this.İmzalayanDepoYetkilisi
      });
      this.gridControl1.Size = new Size(1389, 547);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.girisfisListesi1;
      this.girisfisListesi1.DataSetName = "girisfisListesi";
      this.girisfisListesi1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView1.Columns.AddRange(new GridColumn[15]
      {
        this.gridColumn1,
        this.colKOD,
        this.colİsEmirKodu,
        this.colTARIH,
        this.colALANUSTAID,
        this.colFIRMAID,
        this.colISLEMTIPIID,
        this.colTOPTUTAR,
        this.colFISTUTAR,
        this.colARACACIKLAMA,
        this.colPLAKA,
        this.colTOPKDVTUTAR,
        this.colGirişFisi,
        this.colIMZADEPOYETKILIID,
        this.gridColumn2
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.gridColumn1.Caption = "gridColumn1";
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.MinWidth = 25;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Width = 153;
      this.colKOD.Caption = "Giriş Fiş Listesi";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 25;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 100;
      this.colİsEmirKodu.FieldName = "İs Emir Kodu";
      this.colİsEmirKodu.MinWidth = 25;
      this.colİsEmirKodu.Name = "colİsEmirKodu";
      this.colİsEmirKodu.OptionsColumn.AllowEdit = false;
      this.colİsEmirKodu.OptionsColumn.ReadOnly = true;
      this.colİsEmirKodu.Visible = true;
      this.colİsEmirKodu.VisibleIndex = 1;
      this.colİsEmirKodu.Width = 153;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 2;
      this.colTARIH.Width = 100;
      this.colALANUSTAID.Caption = "Alan Usta";
      this.colALANUSTAID.FieldName = "ALANUSTAID";
      this.colALANUSTAID.MinWidth = 25;
      this.colALANUSTAID.Name = "colALANUSTAID";
      this.colALANUSTAID.OptionsColumn.AllowEdit = false;
      this.colALANUSTAID.OptionsColumn.ReadOnly = true;
      this.colALANUSTAID.Visible = true;
      this.colALANUSTAID.VisibleIndex = 3;
      this.colALANUSTAID.Width = 121;
      this.colFIRMAID.Caption = "Firma";
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 25;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.OptionsColumn.AllowEdit = false;
      this.colFIRMAID.OptionsColumn.ReadOnly = true;
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 4;
      this.colFIRMAID.Width = 116;
      this.colISLEMTIPIID.Caption = "İşlem Tipi";
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 25;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 5;
      this.colISLEMTIPIID.Width = 125;
      this.colTOPTUTAR.Caption = "Toplam Tutar";
      this.colTOPTUTAR.FieldName = "TOPTUTAR";
      this.colTOPTUTAR.MinWidth = 25;
      this.colTOPTUTAR.Name = "colTOPTUTAR";
      this.colTOPTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPTUTAR.Visible = true;
      this.colTOPTUTAR.VisibleIndex = 6;
      this.colTOPTUTAR.Width = 160;
      this.colFISTUTAR.Caption = "Fiş Tutar";
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.MinWidth = 25;
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 7;
      this.colFISTUTAR.Width = 100;
      this.colARACACIKLAMA.Caption = "Araç Açıklama";
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.MinWidth = 25;
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 8;
      this.colARACACIKLAMA.Width = 165;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 9;
      this.colPLAKA.Width = 100;
      this.colTOPKDVTUTAR.Caption = "Toplam KDV Tutar";
      this.colTOPKDVTUTAR.FieldName = "TOPKDVTUTAR";
      this.colTOPKDVTUTAR.MinWidth = 25;
      this.colTOPKDVTUTAR.Name = "colTOPKDVTUTAR";
      this.colTOPKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPKDVTUTAR.Visible = true;
      this.colTOPKDVTUTAR.VisibleIndex = 10;
      this.colTOPKDVTUTAR.Width = 207;
      this.colGirişFisi.FieldName = "Giriş Fisi";
      this.colGirişFisi.MinWidth = 25;
      this.colGirişFisi.Name = "colGirişFisi";
      this.colGirişFisi.OptionsColumn.AllowEdit = false;
      this.colGirişFisi.OptionsColumn.ReadOnly = true;
      this.colGirişFisi.Visible = true;
      this.colGirişFisi.VisibleIndex = 11;
      this.colGirişFisi.Width = 111;
      this.colIMZADEPOYETKILIID.Caption = "İmzalayan Depo Yetkilisi";
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.MinWidth = 25;
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colIMZADEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 12;
      this.colIMZADEPOYETKILIID.Width = 261;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.FieldName = "DepoFisId";
      this.gridColumn2.MinWidth = 25;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Width = 153;
      this.FirmaId.AutoHeight = false;
      this.FirmaId.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.FirmaId.DisplayMember = "FIRMAADI";
      this.FirmaId.Name = "FirmaId";
      this.FirmaId.PopupView = (ColumnView) this.gridView5;
      this.FirmaId.ValueMember = "ID";
      this.gridView5.DetailHeight = 431;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.İmzalayanDepoYetkilisi.AutoHeight = false;
      this.İmzalayanDepoYetkilisi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.İmzalayanDepoYetkilisi.DisplayMember = "ADISOYADI";
      this.İmzalayanDepoYetkilisi.Name = "İmzalayanDepoYetkilisi";
      this.İmzalayanDepoYetkilisi.PopupView = (ColumnView) this.gridView6;
      this.İmzalayanDepoYetkilisi.ValueMember = "ID";
      this.gridView6.DetailHeight = 431;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
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
      this.tabNavigationPage3.Caption = "Giriş Fiş Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1389, 547);
      this.gridControl4.DataSource = (object) this.dataTable1BindingSource2;
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.Margin = new Padding(3, 2, 3, 2);
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
      this.gridControl4.Size = new Size(1389, 547);
      this.gridControl4.TabIndex = 7;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.girisfisHrkToplam;
      this.girisfisHrkToplam.DataSetName = "GirisfisHrkToplam";
      this.girisfisHrkToplam.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView4.Columns.AddRange(new GridColumn[14]
      {
        this.colPLAKA2,
        this.colARACACIKLAMA2,
        this.colKOD2,
        this.colMalzemeKod,
        this.colMALZACIKLAMA1,
        this.colMALZEMEADI1,
        this.colBOLUMID,
        this.colFIRMAID1,
        this.colBIRIMID1,
        this.colFIYAT1,
        this.colMIKTAR1,
        this.colTutari,
        this.colKDVORAN1,
        this.colKdvTutari
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
      this.colPLAKA2.Caption = "Plaka";
      this.colPLAKA2.FieldName = "PLAKA";
      this.colPLAKA2.MinWidth = 25;
      this.colPLAKA2.Name = "colPLAKA2";
      this.colPLAKA2.Visible = true;
      this.colPLAKA2.VisibleIndex = 0;
      this.colPLAKA2.Width = 93;
      this.colARACACIKLAMA2.Caption = "Araç Açıklama";
      this.colARACACIKLAMA2.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA2.MinWidth = 25;
      this.colARACACIKLAMA2.Name = "colARACACIKLAMA2";
      this.colARACACIKLAMA2.Visible = true;
      this.colARACACIKLAMA2.VisibleIndex = 1;
      this.colARACACIKLAMA2.Width = 165;
      this.colKOD2.FieldName = "KOD";
      this.colKOD2.MinWidth = 25;
      this.colKOD2.Name = "colKOD2";
      this.colKOD2.Width = 93;
      this.colMalzemeKod.FieldName = "MalzemeKod";
      this.colMalzemeKod.MinWidth = 25;
      this.colMalzemeKod.Name = "colMalzemeKod";
      this.colMalzemeKod.Visible = true;
      this.colMalzemeKod.VisibleIndex = 2;
      this.colMalzemeKod.Width = 155;
      this.colMALZACIKLAMA1.Caption = "Malzeme Açıklama";
      this.colMALZACIKLAMA1.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA1.MinWidth = 25;
      this.colMALZACIKLAMA1.Name = "colMALZACIKLAMA1";
      this.colMALZACIKLAMA1.Visible = true;
      this.colMALZACIKLAMA1.VisibleIndex = 3;
      this.colMALZACIKLAMA1.Width = 204;
      this.colMALZEMEADI1.Caption = "Malzeme Adı";
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.MinWidth = 25;
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 4;
      this.colMALZEMEADI1.Width = 151;
      this.colBOLUMID.Caption = "Bölüm";
      this.colBOLUMID.FieldName = "BOLUMID";
      this.colBOLUMID.MinWidth = 25;
      this.colBOLUMID.Name = "colBOLUMID";
      this.colBOLUMID.Visible = true;
      this.colBOLUMID.VisibleIndex = 5;
      this.colBOLUMID.Width = 93;
      this.colFIRMAID1.Caption = "Firma";
      this.colFIRMAID1.FieldName = "FIRMAID";
      this.colFIRMAID1.MinWidth = 25;
      this.colFIRMAID1.Name = "colFIRMAID1";
      this.colFIRMAID1.Visible = true;
      this.colFIRMAID1.VisibleIndex = 6;
      this.colFIRMAID1.Width = 93;
      this.colBIRIMID1.Caption = "Birim";
      this.colBIRIMID1.FieldName = "BIRIMID";
      this.colBIRIMID1.MinWidth = 25;
      this.colBIRIMID1.Name = "colBIRIMID1";
      this.colBIRIMID1.Visible = true;
      this.colBIRIMID1.VisibleIndex = 7;
      this.colBIRIMID1.Width = 93;
      this.colFIYAT1.Caption = "Fiyat";
      this.colFIYAT1.FieldName = "FIYAT";
      this.colFIYAT1.MinWidth = 25;
      this.colFIYAT1.Name = "colFIYAT1";
      this.colFIYAT1.Visible = true;
      this.colFIYAT1.VisibleIndex = 8;
      this.colFIYAT1.Width = 93;
      this.colMIKTAR1.Caption = "Miktar";
      this.colMIKTAR1.FieldName = "MIKTAR";
      this.colMIKTAR1.MinWidth = 25;
      this.colMIKTAR1.Name = "colMIKTAR1";
      this.colMIKTAR1.Visible = true;
      this.colMIKTAR1.VisibleIndex = 9;
      this.colMIKTAR1.Width = 93;
      this.colTutari.Caption = "Tutar";
      this.colTutari.FieldName = "Tutari";
      this.colTutari.MinWidth = 25;
      this.colTutari.Name = "colTutari";
      this.colTutari.Visible = true;
      this.colTutari.VisibleIndex = 10;
      this.colTutari.Width = 93;
      this.colKDVORAN1.Caption = "KDV Oran";
      this.colKDVORAN1.FieldName = "KDVORAN";
      this.colKDVORAN1.MinWidth = 25;
      this.colKDVORAN1.Name = "colKDVORAN1";
      this.colKDVORAN1.Visible = true;
      this.colKDVORAN1.VisibleIndex = 11;
      this.colKDVORAN1.Width = 124;
      this.colKdvTutari.FieldName = "KdvTutari";
      this.colKdvTutari.MinWidth = 25;
      this.colKdvTutari.Name = "colKdvTutari";
      this.colKdvTutari.Visible = true;
      this.colKdvTutari.VisibleIndex = 12;
      this.colKdvTutari.Width = 128;
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
      this.tabNavigationPage2.Caption = "Giriş Fiş Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1389, 547);
      this.gridControl3.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(3, 2, 3, 2);
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
      this.gridControl3.Size = new Size(1389, 547);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.girisfishrktleri;
      this.girisfishrktleri.DataSetName = "girisfishrktleri";
      this.girisfishrktleri.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView3.Columns.AddRange(new GridColumn[29]
      {
        this.colDEPOFISID,
        this.colPLAKA1,
        this.colARACACIKLAMA1,
        this.colKOD1,
        this.colTARIH1,
        this.colMALZEMEID,
        this.colMALZEMEGRUP,
        this.colMALZACIKLAMA,
        this.colBIRIMID,
        this.colMIKTAR,
        this.colGIRISMIKTAR,
        this.colCIKISMIKTAR,
        this.colFIYAT,
        this.colMALZEMEADI,
        this.colMALZEMEGRUP2,
        this.colTUTAR,
        this.colGIRISTUTAR,
        this.colCIKISTUTAR,
        this.colKDVORAN,
        this.colKDVTUTAR,
        this.colSATIRTUTAR,
        this.colGCKOD,
        this.colDEPOID,
        this.colMALZMARKAID,
        this.colMALZSERINO,
        this.colMALZURTTARIH,
        this.colExpr1,
        this.colBOLUMADI,
        this.colID
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsPrint.AutoWidth = false;
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView3.DoubleClick += new EventHandler(this.gridView3_DoubleClick);
      this.colDEPOFISID.FieldName = "DEPOFISID";
      this.colDEPOFISID.MinWidth = 25;
      this.colDEPOFISID.Name = "colDEPOFISID";
      this.colDEPOFISID.OptionsColumn.AllowEdit = false;
      this.colDEPOFISID.OptionsColumn.ReadOnly = true;
      this.colDEPOFISID.Width = 93;
      this.colPLAKA1.Caption = "Plaka";
      this.colPLAKA1.FieldName = "PLAKA";
      this.colPLAKA1.MinWidth = 25;
      this.colPLAKA1.Name = "colPLAKA1";
      this.colPLAKA1.OptionsColumn.AllowEdit = false;
      this.colPLAKA1.OptionsColumn.ReadOnly = true;
      this.colPLAKA1.Visible = true;
      this.colPLAKA1.VisibleIndex = 0;
      this.colPLAKA1.Width = 95;
      this.colARACACIKLAMA1.Caption = "Araç Açıklama";
      this.colARACACIKLAMA1.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA1.MinWidth = 25;
      this.colARACACIKLAMA1.Name = "colARACACIKLAMA1";
      this.colARACACIKLAMA1.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA1.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA1.Visible = true;
      this.colARACACIKLAMA1.VisibleIndex = 1;
      this.colARACACIKLAMA1.Width = 191;
      this.colKOD1.Caption = "Giriş Fiş Kod";
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.MinWidth = 25;
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.OptionsColumn.AllowEdit = false;
      this.colKOD1.OptionsColumn.ReadOnly = true;
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 2;
      this.colKOD1.Width = 93;
      this.colTARIH1.Caption = "Tarih";
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.MinWidth = 25;
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.OptionsColumn.AllowEdit = false;
      this.colTARIH1.OptionsColumn.ReadOnly = true;
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 3;
      this.colTARIH1.Width = 93;
      this.colMALZEMEID.Caption = "Malzeme ";
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.MinWidth = 25;
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 4;
      this.colMALZEMEID.Width = 119;
      this.colMALZEMEGRUP.Caption = "Malzeme Grup";
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.MinWidth = 25;
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 5;
      this.colMALZEMEGRUP.Width = 165;
      this.colMALZACIKLAMA.Caption = "Malzeme Açıklama";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.MinWidth = 25;
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colMALZACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 6;
      this.colMALZACIKLAMA.Width = 204;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 25;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 7;
      this.colBIRIMID.Width = 93;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 25;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 8;
      this.colMIKTAR.Width = 93;
      this.colGIRISMIKTAR.Caption = "Giriş Miktar";
      this.colGIRISMIKTAR.FieldName = "GIRISMIKTAR";
      this.colGIRISMIKTAR.MinWidth = 25;
      this.colGIRISMIKTAR.Name = "colGIRISMIKTAR";
      this.colGIRISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISMIKTAR.Visible = true;
      this.colGIRISMIKTAR.VisibleIndex = 9;
      this.colGIRISMIKTAR.Width = 137;
      this.colCIKISMIKTAR.Caption = "Çıkış Miktar";
      this.colCIKISMIKTAR.FieldName = "CIKISMIKTAR";
      this.colCIKISMIKTAR.MinWidth = 25;
      this.colCIKISMIKTAR.Name = "colCIKISMIKTAR";
      this.colCIKISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISMIKTAR.Visible = true;
      this.colCIKISMIKTAR.VisibleIndex = 10;
      this.colCIKISMIKTAR.Width = 139;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 25;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 11;
      this.colFIYAT.Width = 93;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 25;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 12;
      this.colMALZEMEADI.Width = 151;
      this.colMALZEMEGRUP2.Caption = "Malzeme Grup";
      this.colMALZEMEGRUP2.FieldName = "MALZEMEGRUP2";
      this.colMALZEMEGRUP2.MinWidth = 25;
      this.colMALZEMEGRUP2.Name = "colMALZEMEGRUP2";
      this.colMALZEMEGRUP2.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP2.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP2.Visible = true;
      this.colMALZEMEGRUP2.VisibleIndex = 13;
      this.colMALZEMEGRUP2.Width = 165;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 25;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.OptionsColumn.AllowEdit = false;
      this.colTUTAR.OptionsColumn.ReadOnly = true;
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 14;
      this.colTUTAR.Width = 93;
      this.colGIRISTUTAR.Caption = "Giriş Tutar";
      this.colGIRISTUTAR.FieldName = "GIRISTUTAR";
      this.colGIRISTUTAR.MinWidth = 25;
      this.colGIRISTUTAR.Name = "colGIRISTUTAR";
      this.colGIRISTUTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISTUTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISTUTAR.Visible = true;
      this.colGIRISTUTAR.VisibleIndex = 15;
      this.colGIRISTUTAR.Width = 131;
      this.colCIKISTUTAR.Caption = "Çıkış Tutar";
      this.colCIKISTUTAR.FieldName = "CIKISTUTAR";
      this.colCIKISTUTAR.MinWidth = 25;
      this.colCIKISTUTAR.Name = "colCIKISTUTAR";
      this.colCIKISTUTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISTUTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISTUTAR.Visible = true;
      this.colCIKISTUTAR.VisibleIndex = 16;
      this.colCIKISTUTAR.Width = 132;
      this.colKDVORAN.Caption = "KDV Oran";
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.MinWidth = 25;
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.OptionsColumn.AllowEdit = false;
      this.colKDVORAN.OptionsColumn.ReadOnly = true;
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 17;
      this.colKDVORAN.Width = 124;
      this.colKDVTUTAR.Caption = "KDV Tutar";
      this.colKDVTUTAR.FieldName = "KDVTUTAR";
      this.colKDVTUTAR.MinWidth = 25;
      this.colKDVTUTAR.Name = "colKDVTUTAR";
      this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colKDVTUTAR.Visible = true;
      this.colKDVTUTAR.VisibleIndex = 18;
      this.colKDVTUTAR.Width = 128;
      this.colSATIRTUTAR.Caption = "Satır Tutar";
      this.colSATIRTUTAR.FieldName = "SATIRTUTAR";
      this.colSATIRTUTAR.MinWidth = 25;
      this.colSATIRTUTAR.Name = "colSATIRTUTAR";
      this.colSATIRTUTAR.OptionsColumn.AllowEdit = false;
      this.colSATIRTUTAR.OptionsColumn.ReadOnly = true;
      this.colSATIRTUTAR.Visible = true;
      this.colSATIRTUTAR.VisibleIndex = 19;
      this.colSATIRTUTAR.Width = 131;
      this.colGCKOD.Caption = "Giriş Çıkış Kod";
      this.colGCKOD.FieldName = "GCKOD";
      this.colGCKOD.MinWidth = 25;
      this.colGCKOD.Name = "colGCKOD";
      this.colGCKOD.OptionsColumn.AllowEdit = false;
      this.colGCKOD.OptionsColumn.ReadOnly = true;
      this.colGCKOD.Width = 93;
      this.colDEPOID.Caption = "Depo";
      this.colDEPOID.FieldName = "DEPOID";
      this.colDEPOID.MinWidth = 25;
      this.colDEPOID.Name = "colDEPOID";
      this.colDEPOID.OptionsColumn.AllowEdit = false;
      this.colDEPOID.OptionsColumn.ReadOnly = true;
      this.colDEPOID.Visible = true;
      this.colDEPOID.VisibleIndex = 20;
      this.colDEPOID.Width = 93;
      this.colMALZMARKAID.Caption = "Malzeme Marka";
      this.colMALZMARKAID.FieldName = "MALZMARKAID";
      this.colMALZMARKAID.MinWidth = 25;
      this.colMALZMARKAID.Name = "colMALZMARKAID";
      this.colMALZMARKAID.OptionsColumn.AllowEdit = false;
      this.colMALZMARKAID.OptionsColumn.ReadOnly = true;
      this.colMALZMARKAID.Visible = true;
      this.colMALZMARKAID.VisibleIndex = 21;
      this.colMALZMARKAID.Width = 175;
      this.colMALZSERINO.Caption = "Malzeme Seri No";
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.MinWidth = 25;
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 22;
      this.colMALZSERINO.Width = 188;
      this.colMALZURTTARIH.Caption = "Malzeme Üretim Tarihi";
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 25;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.OptionsColumn.AllowEdit = false;
      this.colMALZURTTARIH.OptionsColumn.ReadOnly = true;
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 23;
      this.colMALZURTTARIH.Width = 244;
      this.colExpr1.FieldName = "Expr1";
      this.colExpr1.MinWidth = 25;
      this.colExpr1.Name = "colExpr1";
      this.colExpr1.OptionsColumn.AllowEdit = false;
      this.colExpr1.OptionsColumn.ReadOnly = true;
      this.colExpr1.Width = 93;
      this.colBOLUMADI.Caption = "Bölüm Adı";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 25;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 24;
      this.colBOLUMADI.Width = 129;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 93;
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
      this.tabNavigationPage1.Caption = "Giriş Fiş ";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1389, 547);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1389, 547);
      this.gridControl2.TabIndex = 4;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick_1);
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 2);
      this.simpleButton1.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(25, 25);
      this.simpleButton1.TabIndex = 3;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 122);
      this.tabPane1.Margin = new Padding(3, 2, 3, 2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[3]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3
      });
      this.tabPane1.RegularSize = new Size(1389, 583);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1389, 583);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Giriş Fiş Hareketleri";
      this.tabPane1.Click += new EventHandler(this.tabPane1_Click);
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.dataTable1TableAdapter2.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1389, 705);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (GirisFisListesi);
      this.Text = "Giriş Fiş Listesi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.girisfisListesi1.EndInit();
      this.gridView1.EndInit();
      this.FirmaId.EndInit();
      this.gridView5.EndInit();
      this.İmzalayanDepoYetkilisi.EndInit();
      this.gridView6.EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      this.girisfisHrkToplam.EndInit();
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
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.girisfishrktleri.EndInit();
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
