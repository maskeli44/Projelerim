// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.CikisFisListesi
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
  public class CikisFisListesi : Form
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
    private RepositoryItemSearchLookUpEdit IsEmri;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit AlanUsta;
    private GridView gridView5;
    private RepositoryItemSearchLookUpEdit Firma;
    private GridView gridView6;
    private RepositoryItemSearchLookUpEdit personel;
    private GridView gridView7;
    private cikisfisiListeleme cikisfisiListeleme;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.DepoModel.cikisfisiListelemeTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colKOD;
    private GridColumn colTARIH;
    private GridColumn colTOPTUTAR;
    private GridColumn colFISTUTAR;
    private GridColumn colİşEmirKodu;
    private GridColumn colPLAKA;
    private GridColumn colID;
    private GridColumn colALANUSTAID;
    private GridColumn colIMZADEPOYETKILIID;
    private GridColumn colİşlemTipi;
    private GridColumn colISLEMTIPIID;
    private GridColumn gridColumn1;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private cikisdepohrtklistesi cikisdepohrtklistesi;
    private BindingSource dataTable1BindingSource1;
    private Makina_Ikmal.DepoModel.cikisdepohrtklistesiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn colKOD1;
    private GridColumn colPLAKA1;
    private GridColumn colARACACIKLAMA;
    private GridColumn colExpr1;
    private GridColumn colTARIH1;
    private GridColumn colExpr2;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private GridColumn colBOLUMADI;
    private GridColumn colDEPOADI;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colKDVORAN;
    private GridColumn colKDVTUTAR;
    private GridColumn colSATIRTUTAR;
    private GridColumn colMALZSERINO;
    private GridColumn colMALZURTTARIH;
    private GridColumn colMALZEMEGRUP2;
    private GridColumn colMALZMARKA;
    private GridColumn colADISOYADI;
    private GridColumn colID1;
    private GridColumn colISLEMTIPIID1;
    private cikisfishrktMalzemeleri cikisfishrktMalzemeleri;
    private BindingSource dataTable1BindingSource2;
    private Makina_Ikmal.DepoModel.cikisfishrktMalzemeleriTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
    private GridColumn colMALZEMEADI1;
    private GridColumn colBIRIMADI1;
    private GridColumn colDEPOADI1;
    private GridColumn colMALZSERINO1;
    private GridColumn colBOLUMADI1;
    private GridColumn colMALZEMEGRUP;
    private GridColumn colISLEMTIPIID2;
    private GridColumn colMALZMARKA1;
    private GridColumn colMiktar1;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;

    public CikisFisListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayıt";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new CikisFisEkle().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet7.TBLFIRMALAR);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      try
      {
        this.dataTable1TableAdapter2.Fill(this.cikisfishrktMalzemeleri.DataTable1);
      }
      catch (Exception ex)
      {
      }
      this.listele();
    }

    public void listele()
    {
      this.dataTable1TableAdapter1.Fill(this.cikisdepohrtklistesi.DataTable1);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.dataTable1TableAdapter.Fill(this.cikisfisiListeleme.DataTable1);
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
      GridView gridView = sender as GridView;
      int int32 = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID"));
      if (Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID")) == 1)
      {
        e.Appearance.BackColor = Color.Yellow;
      }
      else
      {
        switch (int32)
        {
          case 2:
            e.Appearance.BackColor = Color.LightBlue;
            break;
          case 3:
            e.Appearance.BackColor = Color.PaleGreen;
            break;
          case 4:
            e.Appearance.BackColor = Color.Yellow;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.GreenYellow;
            break;
        }
      }
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
      int num = (int) new CikisFisDuzenle().ShowDialog();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new CikisFisDuzenle().ShowDialog();
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void tabPane1_Click(object sender, EventArgs e) => this.sayfa();

    private void sayfa()
    {
      if (this.tabPane1.SelectedPage.Name == "tabNavigationPage1")
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      else if (this.tabPane1.SelectedPage.Name == "tabNavigationPage2")
      {
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
      }
      else
      {
        if (!(this.tabPane1.SelectedPage.Name == "tabNavigationPage3"))
          return;
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl4;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CikisFisListesi));
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
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.cikisfisiListeleme = new cikisfisiListeleme();
      this.gridView1 = new GridView();
      this.colKOD = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colTOPTUTAR = new GridColumn();
      this.colFISTUTAR = new GridColumn();
      this.colİşEmirKodu = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colID = new GridColumn();
      this.colALANUSTAID = new GridColumn();
      this.AlanUsta = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView5 = new GridView();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.personel = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView7 = new GridView();
      this.colİşlemTipi = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.IsEmri = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.Firma = new RepositoryItemSearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
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
      this.cikisfishrktMalzemeleri = new cikisfishrktMalzemeleri();
      this.gridView4 = new GridView();
      this.colMALZEMEADI1 = new GridColumn();
      this.colBIRIMADI1 = new GridColumn();
      this.colDEPOADI1 = new GridColumn();
      this.colMALZSERINO1 = new GridColumn();
      this.colBOLUMADI1 = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.colISLEMTIPIID2 = new GridColumn();
      this.colMALZMARKA1 = new GridColumn();
      this.colMiktar1 = new GridColumn();
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
      this.cikisdepohrtklistesi = new cikisdepohrtklistesi();
      this.gridView3 = new GridView();
      this.colKOD1 = new GridColumn();
      this.colPLAKA1 = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colExpr1 = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.colExpr2 = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.colDEPOADI = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.colKDVTUTAR = new GridColumn();
      this.colSATIRTUTAR = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colMALZEMEGRUP2 = new GridColumn();
      this.colMALZMARKA = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colID1 = new GridColumn();
      this.colISLEMTIPIID1 = new GridColumn();
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
      this.dataTable1TableAdapter = new Makina_Ikmal.DepoModel.cikisfisiListelemeTableAdapters.DataTable1TableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.DepoModel.cikisdepohrtklistesiTableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter2 = new Makina_Ikmal.DepoModel.cikisfishrktMalzemeleriTableAdapters.DataTable1TableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.cikisfisiListeleme.BeginInit();
      this.gridView1.BeginInit();
      this.AlanUsta.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView5.BeginInit();
      this.personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView7.BeginInit();
      this.IsEmri.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.Firma.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.gridView6.BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      this.cikisfishrktMalzemeleri.BeginInit();
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
      this.cikisdepohrtklistesi.BeginInit();
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
      this.barEditItem1.EditHeight = 36;
      this.barEditItem1.EditWidth = 130;
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
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.IsEmri,
        (RepositoryItem) this.AlanUsta,
        (RepositoryItem) this.Firma,
        (RepositoryItem) this.personel
      });
      this.gridControl1.Size = new Size(1389, 547);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.cikisfisiListeleme;
      this.cikisfisiListeleme.DataSetName = "cikisfisiListeleme";
      this.cikisfisiListeleme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[12]
      {
        this.colKOD,
        this.colTARIH,
        this.colTOPTUTAR,
        this.colFISTUTAR,
        this.colİşEmirKodu,
        this.colPLAKA,
        this.colID,
        this.colALANUSTAID,
        this.colIMZADEPOYETKILIID,
        this.colİşlemTipi,
        this.colISLEMTIPIID,
        this.gridColumn1
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colKOD, ColumnSortOrder.Descending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colKOD.Caption = "Çıkış Fiş Kodu";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 25;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 118;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 1;
      this.colTARIH.Width = 162;
      this.colTOPTUTAR.Caption = "Tutar";
      this.colTOPTUTAR.FieldName = "TOPTUTAR";
      this.colTOPTUTAR.MinWidth = 25;
      this.colTOPTUTAR.Name = "colTOPTUTAR";
      this.colTOPTUTAR.OptionsColumn.AllowEdit = false;
      this.colTOPTUTAR.OptionsColumn.ReadOnly = true;
      this.colTOPTUTAR.Visible = true;
      this.colTOPTUTAR.VisibleIndex = 2;
      this.colTOPTUTAR.Width = 147;
      this.colFISTUTAR.Caption = "Fiş Tutar";
      this.colFISTUTAR.FieldName = "FISTUTAR";
      this.colFISTUTAR.MinWidth = 25;
      this.colFISTUTAR.Name = "colFISTUTAR";
      this.colFISTUTAR.OptionsColumn.AllowEdit = false;
      this.colFISTUTAR.OptionsColumn.ReadOnly = true;
      this.colFISTUTAR.Visible = true;
      this.colFISTUTAR.VisibleIndex = 4;
      this.colFISTUTAR.Width = 174;
      this.colİşEmirKodu.FieldName = "İş Emir Kodu";
      this.colİşEmirKodu.MinWidth = 25;
      this.colİşEmirKodu.Name = "colİşEmirKodu";
      this.colİşEmirKodu.OptionsColumn.AllowEdit = false;
      this.colİşEmirKodu.OptionsColumn.ReadOnly = true;
      this.colİşEmirKodu.Visible = true;
      this.colİşEmirKodu.VisibleIndex = 5;
      this.colİşEmirKodu.Width = 192;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 6;
      this.colPLAKA.Width = 168;
      this.colID.Caption = "Id";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 94;
      this.colALANUSTAID.Caption = "Alan Usta Adı Soyadı";
      this.colALANUSTAID.ColumnEdit = (RepositoryItem) this.AlanUsta;
      this.colALANUSTAID.FieldName = "ALANUSTAID";
      this.colALANUSTAID.MinWidth = 25;
      this.colALANUSTAID.Name = "colALANUSTAID";
      this.colALANUSTAID.OptionsColumn.AllowEdit = false;
      this.colALANUSTAID.OptionsColumn.ReadOnly = true;
      this.colALANUSTAID.Visible = true;
      this.colALANUSTAID.VisibleIndex = 7;
      this.colALANUSTAID.Width = 266;
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
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView5.DetailHeight = 431;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colIMZADEPOYETKILIID.Caption = "İmzalayan Depo Yetkilisi";
      this.colIMZADEPOYETKILIID.ColumnEdit = (RepositoryItem) this.personel;
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.MinWidth = 25;
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.OptionsColumn.AllowEdit = false;
      this.colIMZADEPOYETKILIID.OptionsColumn.ReadOnly = true;
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 8;
      this.colIMZADEPOYETKILIID.Width = 289;
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
      this.gridView7.DetailHeight = 431;
      this.gridView7.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView7.OptionsView.ShowGroupPanel = false;
      this.colİşlemTipi.FieldName = "İşlem Tipi";
      this.colİşlemTipi.MinWidth = 25;
      this.colİşlemTipi.Name = "colİşlemTipi";
      this.colİşlemTipi.OptionsColumn.AllowEdit = false;
      this.colİşlemTipi.OptionsColumn.ReadOnly = true;
      this.colİşlemTipi.Visible = true;
      this.colİşlemTipi.VisibleIndex = 9;
      this.colİşlemTipi.Width = 150;
      this.colISLEMTIPIID.Caption = "İşlem Tipi Id";
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 25;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 10;
      this.colISLEMTIPIID.Width = 94;
      this.gridColumn1.Caption = "Kdv Tutarı";
      this.gridColumn1.FieldName = "TOPKDVTUTAR";
      this.gridColumn1.MinWidth = 25;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 3;
      this.gridColumn1.Width = 164;
      this.IsEmri.AutoHeight = false;
      this.IsEmri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IsEmri.DisplayMember = "KOD";
      this.IsEmri.Name = "IsEmri";
      this.IsEmri.NullText = "";
      this.IsEmri.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.IsEmri.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
      this.tabNavigationPage3.Caption = "Çıkış  Fiş Toplamları";
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
      this.dataTable1BindingSource2.DataSource = (object) this.cikisfishrktMalzemeleri;
      this.cikisfishrktMalzemeleri.DataSetName = "cikisfishrktMalzemeleri";
      this.cikisfishrktMalzemeleri.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView4.Columns.AddRange(new GridColumn[9]
      {
        this.colMALZEMEADI1,
        this.colBIRIMADI1,
        this.colDEPOADI1,
        this.colMALZSERINO1,
        this.colBOLUMADI1,
        this.colMALZEMEGRUP,
        this.colISLEMTIPIID2,
        this.colMALZMARKA1,
        this.colMiktar1
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
      this.colMALZEMEADI1.FieldName = "MALZEMEADI";
      this.colMALZEMEADI1.MinWidth = 25;
      this.colMALZEMEADI1.Name = "colMALZEMEADI1";
      this.colMALZEMEADI1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI1.Visible = true;
      this.colMALZEMEADI1.VisibleIndex = 0;
      this.colMALZEMEADI1.Width = 94;
      this.colBIRIMADI1.FieldName = "BIRIMADI";
      this.colBIRIMADI1.MinWidth = 25;
      this.colBIRIMADI1.Name = "colBIRIMADI1";
      this.colBIRIMADI1.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI1.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI1.Visible = true;
      this.colBIRIMADI1.VisibleIndex = 1;
      this.colBIRIMADI1.Width = 94;
      this.colDEPOADI1.FieldName = "DEPOADI";
      this.colDEPOADI1.MinWidth = 25;
      this.colDEPOADI1.Name = "colDEPOADI1";
      this.colDEPOADI1.OptionsColumn.AllowEdit = false;
      this.colDEPOADI1.OptionsColumn.ReadOnly = true;
      this.colDEPOADI1.Visible = true;
      this.colDEPOADI1.VisibleIndex = 2;
      this.colDEPOADI1.Width = 94;
      this.colMALZSERINO1.FieldName = "MALZSERINO";
      this.colMALZSERINO1.MinWidth = 25;
      this.colMALZSERINO1.Name = "colMALZSERINO1";
      this.colMALZSERINO1.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO1.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO1.Visible = true;
      this.colMALZSERINO1.VisibleIndex = 3;
      this.colMALZSERINO1.Width = 94;
      this.colBOLUMADI1.FieldName = "BOLUMADI";
      this.colBOLUMADI1.MinWidth = 25;
      this.colBOLUMADI1.Name = "colBOLUMADI1";
      this.colBOLUMADI1.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI1.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI1.Visible = true;
      this.colBOLUMADI1.VisibleIndex = 4;
      this.colBOLUMADI1.Width = 94;
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.MinWidth = 25;
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 5;
      this.colMALZEMEGRUP.Width = 94;
      this.colISLEMTIPIID2.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID2.MinWidth = 25;
      this.colISLEMTIPIID2.Name = "colISLEMTIPIID2";
      this.colISLEMTIPIID2.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID2.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID2.Visible = true;
      this.colISLEMTIPIID2.VisibleIndex = 6;
      this.colISLEMTIPIID2.Width = 94;
      this.colMALZMARKA1.FieldName = "MALZMARKA";
      this.colMALZMARKA1.MinWidth = 25;
      this.colMALZMARKA1.Name = "colMALZMARKA1";
      this.colMALZMARKA1.OptionsColumn.AllowEdit = false;
      this.colMALZMARKA1.OptionsColumn.ReadOnly = true;
      this.colMALZMARKA1.Visible = true;
      this.colMALZMARKA1.VisibleIndex = 7;
      this.colMALZMARKA1.Width = 94;
      this.colMiktar1.FieldName = "Miktar";
      this.colMiktar1.MinWidth = 25;
      this.colMiktar1.Name = "colMiktar1";
      this.colMiktar1.OptionsColumn.AllowEdit = false;
      this.colMiktar1.OptionsColumn.ReadOnly = true;
      this.colMiktar1.Visible = true;
      this.colMiktar1.VisibleIndex = 8;
      this.colMiktar1.Width = 94;
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
      this.tabNavigationPage2.Caption = "Çıkış  Fiş Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1389, 547);
      this.gridControl3.DataSource = (object) this.dataTable1BindingSource1;
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
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.cikisdepohrtklistesi;
      this.cikisdepohrtklistesi.DataSetName = "cikisdepohrtklistesi";
      this.cikisdepohrtklistesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView3.Columns.AddRange(new GridColumn[22]
      {
        this.colKOD1,
        this.colPLAKA1,
        this.colARACACIKLAMA,
        this.colExpr1,
        this.colTARIH1,
        this.colExpr2,
        this.colMALZEMEADI,
        this.colBIRIMADI,
        this.colBOLUMADI,
        this.colDEPOADI,
        this.colMIKTAR,
        this.colFIYAT,
        this.colKDVORAN,
        this.colKDVTUTAR,
        this.colSATIRTUTAR,
        this.colMALZSERINO,
        this.colMALZURTTARIH,
        this.colMALZEMEGRUP2,
        this.colMALZMARKA,
        this.colADISOYADI,
        this.colID1,
        this.colISLEMTIPIID1
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
      this.colKOD1.FieldName = "KOD";
      this.colKOD1.MinWidth = 25;
      this.colKOD1.Name = "colKOD1";
      this.colKOD1.OptionsColumn.AllowEdit = false;
      this.colKOD1.OptionsColumn.ReadOnly = true;
      this.colKOD1.Visible = true;
      this.colKOD1.VisibleIndex = 0;
      this.colKOD1.Width = 94;
      this.colPLAKA1.FieldName = "PLAKA";
      this.colPLAKA1.MinWidth = 25;
      this.colPLAKA1.Name = "colPLAKA1";
      this.colPLAKA1.OptionsColumn.AllowEdit = false;
      this.colPLAKA1.OptionsColumn.ReadOnly = true;
      this.colPLAKA1.Visible = true;
      this.colPLAKA1.VisibleIndex = 1;
      this.colPLAKA1.Width = 94;
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.MinWidth = 25;
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 2;
      this.colARACACIKLAMA.Width = 94;
      this.colExpr1.FieldName = "Expr1";
      this.colExpr1.MinWidth = 25;
      this.colExpr1.Name = "colExpr1";
      this.colExpr1.OptionsColumn.AllowEdit = false;
      this.colExpr1.OptionsColumn.ReadOnly = true;
      this.colExpr1.Visible = true;
      this.colExpr1.VisibleIndex = 3;
      this.colExpr1.Width = 94;
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.MinWidth = 25;
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.OptionsColumn.AllowEdit = false;
      this.colTARIH1.OptionsColumn.ReadOnly = true;
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 4;
      this.colTARIH1.Width = 94;
      this.colExpr2.FieldName = "Expr2";
      this.colExpr2.MinWidth = 25;
      this.colExpr2.Name = "colExpr2";
      this.colExpr2.OptionsColumn.AllowEdit = false;
      this.colExpr2.OptionsColumn.ReadOnly = true;
      this.colExpr2.Visible = true;
      this.colExpr2.VisibleIndex = 5;
      this.colExpr2.Width = 94;
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 25;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 6;
      this.colMALZEMEADI.Width = 94;
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 25;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 7;
      this.colBIRIMADI.Width = 94;
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 25;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 8;
      this.colBOLUMADI.Width = 94;
      this.colDEPOADI.FieldName = "DEPOADI";
      this.colDEPOADI.MinWidth = 25;
      this.colDEPOADI.Name = "colDEPOADI";
      this.colDEPOADI.OptionsColumn.AllowEdit = false;
      this.colDEPOADI.OptionsColumn.ReadOnly = true;
      this.colDEPOADI.Visible = true;
      this.colDEPOADI.VisibleIndex = 9;
      this.colDEPOADI.Width = 94;
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 25;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 10;
      this.colMIKTAR.Width = 94;
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 25;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 11;
      this.colFIYAT.Width = 94;
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.MinWidth = 25;
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.OptionsColumn.AllowEdit = false;
      this.colKDVORAN.OptionsColumn.ReadOnly = true;
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 12;
      this.colKDVORAN.Width = 94;
      this.colKDVTUTAR.FieldName = "KDVTUTAR";
      this.colKDVTUTAR.MinWidth = 25;
      this.colKDVTUTAR.Name = "colKDVTUTAR";
      this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colKDVTUTAR.Visible = true;
      this.colKDVTUTAR.VisibleIndex = 13;
      this.colKDVTUTAR.Width = 94;
      this.colSATIRTUTAR.FieldName = "SATIRTUTAR";
      this.colSATIRTUTAR.MinWidth = 25;
      this.colSATIRTUTAR.Name = "colSATIRTUTAR";
      this.colSATIRTUTAR.OptionsColumn.AllowEdit = false;
      this.colSATIRTUTAR.OptionsColumn.ReadOnly = true;
      this.colSATIRTUTAR.Visible = true;
      this.colSATIRTUTAR.VisibleIndex = 14;
      this.colSATIRTUTAR.Width = 94;
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.MinWidth = 25;
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 15;
      this.colMALZSERINO.Width = 94;
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 25;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.OptionsColumn.AllowEdit = false;
      this.colMALZURTTARIH.OptionsColumn.ReadOnly = true;
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 16;
      this.colMALZURTTARIH.Width = 94;
      this.colMALZEMEGRUP2.FieldName = "MALZEMEGRUP2";
      this.colMALZEMEGRUP2.MinWidth = 25;
      this.colMALZEMEGRUP2.Name = "colMALZEMEGRUP2";
      this.colMALZEMEGRUP2.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP2.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP2.Visible = true;
      this.colMALZEMEGRUP2.VisibleIndex = 17;
      this.colMALZEMEGRUP2.Width = 94;
      this.colMALZMARKA.FieldName = "MALZMARKA";
      this.colMALZMARKA.MinWidth = 25;
      this.colMALZMARKA.Name = "colMALZMARKA";
      this.colMALZMARKA.OptionsColumn.AllowEdit = false;
      this.colMALZMARKA.OptionsColumn.ReadOnly = true;
      this.colMALZMARKA.Visible = true;
      this.colMALZMARKA.VisibleIndex = 18;
      this.colMALZMARKA.Width = 94;
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 25;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.OptionsColumn.AllowEdit = false;
      this.colADISOYADI.OptionsColumn.ReadOnly = true;
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 19;
      this.colADISOYADI.Width = 94;
      this.colID1.FieldName = "ID";
      this.colID1.MinWidth = 25;
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Visible = true;
      this.colID1.VisibleIndex = 20;
      this.colID1.Width = 94;
      this.colISLEMTIPIID1.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID1.MinWidth = 25;
      this.colISLEMTIPIID1.Name = "colISLEMTIPIID1";
      this.colISLEMTIPIID1.OptionsColumn.AllowEdit = false;
      this.colISLEMTIPIID1.OptionsColumn.ReadOnly = true;
      this.colISLEMTIPIID1.Visible = true;
      this.colISLEMTIPIID1.VisibleIndex = 21;
      this.colISLEMTIPIID1.Width = 94;
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
      this.tabNavigationPage1.Caption = "Çıkış Fiş Listesi";
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
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.dataTable1TableAdapter2.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1389, 705);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (CikisFisListesi);
      this.Text = "Çıkış Fiş Listesi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.cikisfisiListeleme.EndInit();
      this.gridView1.EndInit();
      this.AlanUsta.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView5.EndInit();
      this.personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView7.EndInit();
      this.IsEmri.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.Firma.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.gridView6.EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      this.cikisfishrktMalzemeleri.EndInit();
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
      this.cikisdepohrtklistesi.EndInit();
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
