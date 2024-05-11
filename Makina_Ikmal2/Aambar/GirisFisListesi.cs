// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.GirisFisListesi
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
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
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
    private GridColumn gridColumn28;
    private GridColumn gridColumn29;
    private GridColumn gridColumn30;
    private GridColumn gridColumn31;
    private GridColumn gridColumn32;
    private GridColumn gridColumn33;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit9;
    private GridColumn gridColumn34;
    private GridColumn gridColumn35;
    private GridColumn gridColumn36;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit10;
    private GridColumn gridColumn37;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit11;
    private GridColumn gridColumn38;
    private GridColumn gridColumn39;
    private GridColumn gridColumn40;
    private GridColumn gridColumn41;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit12;
    private GridColumn gridColumn42;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit13;
    private GridColumn gridColumn43;
    private GridColumn gridColumn44;
    private GridColumn gridColumn45;
    private GridColumn gridColumn46;
    private GridColumn gridColumn47;
    private GridColumn gridColumn48;
    private GridColumn gridColumn49;
    private GridColumn gridColumn50;
    private GridColumn gridColumn51;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit14;
    private GridColumn gridColumn52;
    private GridColumn gridColumn53;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit15;
    private GridColumn gridColumn54;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit16;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit5;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit6;
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private BindingSource girisfisBindingSource;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemSearchLookUpEdit FirmaId;
    private GridView gridView5;
    private BindingSource tBLFIRMALARBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private RepositoryItemSearchLookUpEdit İmzalayanDepoYetkilisi;
    private GridView gridView6;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLISLEMTIPIBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLISLEMTIPITableAdapter tBLISLEMTIPITableAdapter;
    private BindingSource bellDataSet5BindingSource;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLARACLARBindingSource1;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter1;
    private BindingSource tBLDEPOFISBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLDEPOFISTableAdapter tBLDEPOFISTableAdapter;
    private BindingSource tBLDEPOFISBindingSource1;
    private BindingSource tBLDEPOFISHRKTBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLDEPOFISHRKTTableAdapter tBLDEPOFISHRKTTableAdapter;
    private GridColumn colGCKOD;
    private GridColumn colIsEmriID;
    private GridColumn colIsEmriKod;
    private GridColumn colARACID;
    private GridColumn colIslemYeri;
    private GridColumn colARACACIKLAMA;
    private GridColumn colISLEMTIPIID;
    private GridColumn colISLEMTIPI;
    private GridColumn colIMZADEPOYETKILIID;
    private GridColumn colFIRMAID;
    private GridColumn colGirisFisKod;
    private GridColumn colTarih;
    private GridColumn colTutar;
    private GridColumn colKDVTutar;
    private GridColumn colTalepFisKod;
    private GridColumn colFisTutar;
    private BindingSource girisFisHareketleriBindingSource;
    private GridColumn colİşlemYeri;
    private GridColumn colARACACIKLAMA1;
    private GridColumn colGirisFisKod1;
    private GridColumn colTARIH1;
    private GridColumn colSAAT;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colMalzemeKod;
    private GridColumn colBirim;
    private GridColumn colDepoAdi;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR1;
    private GridColumn colKDVORAN;
    private GridColumn colSATIRTUTAR;
    private GridColumn colGCKOD1;
    private GridColumn colMALZSERINO;
    private GridColumn colMALZURTTARIH;
    private GridColumn colIMZADEPOYETKILIID1;
    private GridColumn colMalzGrup;
    private GridColumn colMalzGrup2;
    private GridColumn colMalzBolum;
    private GridColumn colMalzMarka;

    public GirisFisListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new GirisFisEkle().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

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
      this.barButtonItem13 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
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
      this.gridView1 = new GridView();
      this.colGCKOD = new GridColumn();
      this.colIsEmriID = new GridColumn();
      this.colIsEmriKod = new GridColumn();
      this.colARACID = new GridColumn();
      this.colIslemYeri = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colISLEMTIPI = new GridColumn();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.İmzalayanDepoYetkilisi = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.gridView6 = new GridView();
      this.colFIRMAID = new GridColumn();
      this.FirmaId = new RepositoryItemSearchLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.colGirisFisKod = new GridColumn();
      this.colTarih = new GridColumn();
      this.colTutar = new GridColumn();
      this.colKDVTutar = new GridColumn();
      this.colTalepFisKod = new GridColumn();
      this.colFisTutar = new GridColumn();
      this.tBLARACLARBindingSource1 = new BindingSource(this.components);
      this.bellDataSet5BindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.tBLISLEMTIPIBindingSource = new BindingSource(this.components);
      this.tBLDEPOFISHRKTBindingSource = new BindingSource(this.components);
      this.tBLDEPOFISBindingSource = new BindingSource(this.components);
      this.girisfisBindingSource = new BindingSource(this.components);
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl4 = new GridControl();
      this.gridView4 = new GridView();
      this.gridColumn28 = new GridColumn();
      this.gridColumn29 = new GridColumn();
      this.gridColumn30 = new GridColumn();
      this.gridColumn31 = new GridColumn();
      this.gridColumn32 = new GridColumn();
      this.gridColumn33 = new GridColumn();
      this.repositoryItemLookUpEdit9 = new RepositoryItemLookUpEdit();
      this.gridColumn34 = new GridColumn();
      this.gridColumn35 = new GridColumn();
      this.gridColumn36 = new GridColumn();
      this.repositoryItemLookUpEdit10 = new RepositoryItemLookUpEdit();
      this.gridColumn37 = new GridColumn();
      this.repositoryItemLookUpEdit11 = new RepositoryItemLookUpEdit();
      this.gridColumn38 = new GridColumn();
      this.gridColumn39 = new GridColumn();
      this.gridColumn40 = new GridColumn();
      this.gridColumn41 = new GridColumn();
      this.repositoryItemLookUpEdit12 = new RepositoryItemLookUpEdit();
      this.gridColumn42 = new GridColumn();
      this.repositoryItemLookUpEdit13 = new RepositoryItemLookUpEdit();
      this.gridColumn43 = new GridColumn();
      this.gridColumn44 = new GridColumn();
      this.gridColumn45 = new GridColumn();
      this.gridColumn46 = new GridColumn();
      this.gridColumn47 = new GridColumn();
      this.gridColumn48 = new GridColumn();
      this.gridColumn49 = new GridColumn();
      this.gridColumn50 = new GridColumn();
      this.gridColumn51 = new GridColumn();
      this.repositoryItemLookUpEdit14 = new RepositoryItemLookUpEdit();
      this.gridColumn52 = new GridColumn();
      this.gridColumn53 = new GridColumn();
      this.repositoryItemLookUpEdit15 = new RepositoryItemLookUpEdit();
      this.gridColumn54 = new GridColumn();
      this.repositoryItemLookUpEdit16 = new RepositoryItemLookUpEdit();
      this.repositoryItemTimeSpanEdit5 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit6 = new RepositoryItemTimeSpanEdit();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.gridView3 = new GridView();
      this.colİşlemYeri = new GridColumn();
      this.colARACACIKLAMA1 = new GridColumn();
      this.colGirisFisKod1 = new GridColumn();
      this.colTARIH1 = new GridColumn();
      this.colSAAT = new GridColumn();
      this.colMALZACIKLAMA = new GridColumn();
      this.colMalzemeKod = new GridColumn();
      this.colBirim = new GridColumn();
      this.colDepoAdi = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR1 = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.colSATIRTUTAR = new GridColumn();
      this.colGCKOD1 = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colIMZADEPOYETKILIID1 = new GridColumn();
      this.colMalzGrup = new GridColumn();
      this.colMalzGrup2 = new GridColumn();
      this.colMalzBolum = new GridColumn();
      this.colMalzMarka = new GridColumn();
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
      this.tBLDEPOFISBindingSource1 = new BindingSource(this.components);
      this.tabNavigationPage1 = new TabNavigationPage();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.simpleButton1 = new SimpleButton();
      this.tabPane1 = new TabPane();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLARACLARTableAdapter();
      this.tBLFIRMALARTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLFIRMALARTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLPERSONELTableAdapter();
      this.tBLISLEMTIPITableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLISLEMTIPITableAdapter();
      this.tBLARACLARTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter();
      this.tBLDEPOFISTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLDEPOFISTableAdapter();
      this.tBLDEPOFISHRKTTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLDEPOFISHRKTTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridView1.BeginInit();
      this.İmzalayanDepoYetkilisi.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.gridView6.BeginInit();
      this.FirmaId.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.gridView5.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).BeginInit();
      ((ISupportInitialize) this.bellDataSet5BindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLDEPOFISHRKTBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).BeginInit();
      ((ISupportInitialize) this.girisfisBindingSource).BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      this.gridView4.BeginInit();
      this.repositoryItemLookUpEdit9.BeginInit();
      this.repositoryItemLookUpEdit10.BeginInit();
      this.repositoryItemLookUpEdit11.BeginInit();
      this.repositoryItemLookUpEdit12.BeginInit();
      this.repositoryItemLookUpEdit13.BeginInit();
      this.repositoryItemLookUpEdit14.BeginInit();
      this.repositoryItemLookUpEdit15.BeginInit();
      this.repositoryItemLookUpEdit16.BeginInit();
      this.repositoryItemTimeSpanEdit5.BeginInit();
      this.repositoryItemTimeSpanEdit6.BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.gridControl3.BeginInit();
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
      ((ISupportInitialize) this.tBLDEPOFISBindingSource1).BeginInit();
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
      this.ribbonControl1.Size = new Size(1389, 118);
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
      this.barEditItem1.EditWidth = 100;
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
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
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
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
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
        this.colGCKOD,
        this.colIsEmriID,
        this.colIsEmriKod,
        this.colARACID,
        this.colIslemYeri,
        this.colARACACIKLAMA,
        this.colISLEMTIPIID,
        this.colISLEMTIPI,
        this.colIMZADEPOYETKILIID,
        this.colFIRMAID,
        this.colGirisFisKod,
        this.colTarih,
        this.colTutar,
        this.colKDVTutar,
        this.colTalepFisKod,
        this.colFisTutar
      });
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colGCKOD.FieldName = "GCKOD";
      this.colGCKOD.MinWidth = 27;
      this.colGCKOD.Name = "colGCKOD";
      this.colGCKOD.Width = 100;
      this.colIsEmriID.FieldName = "IsEmriID";
      this.colIsEmriID.MinWidth = 27;
      this.colIsEmriID.Name = "colIsEmriID";
      this.colIsEmriID.Width = 100;
      this.colIsEmriKod.FieldName = "IsEmriKod";
      this.colIsEmriKod.MinWidth = 27;
      this.colIsEmriKod.Name = "colIsEmriKod";
      this.colIsEmriKod.Visible = true;
      this.colIsEmriKod.VisibleIndex = 5;
      this.colIsEmriKod.Width = 148;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 27;
      this.colARACID.Name = "colARACID";
      this.colARACID.Width = 100;
      this.colIslemYeri.FieldName = "IslemYeri";
      this.colIslemYeri.MinWidth = 27;
      this.colIslemYeri.Name = "colIslemYeri";
      this.colIslemYeri.Visible = true;
      this.colIslemYeri.VisibleIndex = 6;
      this.colIslemYeri.Width = 147;
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.MinWidth = 27;
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 7;
      this.colARACACIKLAMA.Width = 151;
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 27;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.Width = 100;
      this.colISLEMTIPI.FieldName = "ISLEMTIPI";
      this.colISLEMTIPI.MinWidth = 27;
      this.colISLEMTIPI.Name = "colISLEMTIPI";
      this.colISLEMTIPI.Visible = true;
      this.colISLEMTIPI.VisibleIndex = 8;
      this.colISLEMTIPI.Width = 169;
      this.colIMZADEPOYETKILIID.ColumnEdit = (RepositoryItem) this.İmzalayanDepoYetkilisi;
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.MinWidth = 27;
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 10;
      this.colIMZADEPOYETKILIID.Width = 223;
      this.İmzalayanDepoYetkilisi.AutoHeight = false;
      this.İmzalayanDepoYetkilisi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.İmzalayanDepoYetkilisi.DataSource = (object) this.tBLPERSONELBindingSource;
      this.İmzalayanDepoYetkilisi.DisplayMember = "ADISOYADI";
      this.İmzalayanDepoYetkilisi.Name = "İmzalayanDepoYetkilisi";
      this.İmzalayanDepoYetkilisi.PopupView = (ColumnView) this.gridView6;
      this.İmzalayanDepoYetkilisi.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView6.DetailHeight = 431;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.colFIRMAID.Caption = "Firma Adı";
      this.colFIRMAID.ColumnEdit = (RepositoryItem) this.FirmaId;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.MinWidth = 27;
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 9;
      this.colFIRMAID.Width = 159;
      this.FirmaId.AutoHeight = false;
      this.FirmaId.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.FirmaId.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.FirmaId.DisplayMember = "FIRMAADI";
      this.FirmaId.Name = "FirmaId";
      this.FirmaId.PopupView = (ColumnView) this.gridView5;
      this.FirmaId.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView5.DetailHeight = 431;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colGirisFisKod.FieldName = "GirisFisKod";
      this.colGirisFisKod.MinWidth = 27;
      this.colGirisFisKod.Name = "colGirisFisKod";
      this.colGirisFisKod.Visible = true;
      this.colGirisFisKod.VisibleIndex = 0;
      this.colGirisFisKod.Width = 177;
      this.colTarih.FieldName = "Tarih";
      this.colTarih.MinWidth = 27;
      this.colTarih.Name = "colTarih";
      this.colTarih.Visible = true;
      this.colTarih.VisibleIndex = 1;
      this.colTarih.Width = 167;
      this.colTutar.FieldName = "Tutar";
      this.colTutar.MinWidth = 27;
      this.colTutar.Name = "colTutar";
      this.colTutar.Visible = true;
      this.colTutar.VisibleIndex = 2;
      this.colTutar.Width = 112;
      this.colKDVTutar.FieldName = "KDVTutar";
      this.colKDVTutar.MinWidth = 27;
      this.colKDVTutar.Name = "colKDVTutar";
      this.colKDVTutar.Visible = true;
      this.colKDVTutar.VisibleIndex = 3;
      this.colKDVTutar.Width = 159;
      this.colTalepFisKod.FieldName = "TalepFisKod";
      this.colTalepFisKod.MinWidth = 27;
      this.colTalepFisKod.Name = "colTalepFisKod";
      this.colTalepFisKod.Visible = true;
      this.colTalepFisKod.VisibleIndex = 11;
      this.colTalepFisKod.Width = 177;
      this.colFisTutar.FieldName = "FisTutar";
      this.colFisTutar.MinWidth = 27;
      this.colFisTutar.Name = "colFisTutar";
      this.colFisTutar.Visible = true;
      this.colFisTutar.VisibleIndex = 4;
      this.colFisTutar.Width = 144;
      this.tBLARACLARBindingSource1.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource1.DataSource = (object) this.bellDataSet5BindingSource;
      this.bellDataSet5BindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5BindingSource.Position = 0;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet6;
      this.tBLISLEMTIPIBindingSource.DataMember = "TBLISLEMTIPI";
      this.tBLISLEMTIPIBindingSource.DataSource = (object) this.bellDataSet6;
      this.tBLDEPOFISHRKTBindingSource.DataMember = "TBLDEPOFISHRKT";
      this.tBLDEPOFISHRKTBindingSource.DataSource = (object) this.bellDataSet6;
      this.tBLDEPOFISBindingSource.DataMember = "TBLDEPOFIS";
      this.tBLDEPOFISBindingSource.DataSource = (object) this.bellDataSet6;
      this.tabNavigationPage3.Caption = "Giriş Fiş Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1389, 541);
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
      this.gridControl4.Size = new Size(1389, 541);
      this.gridControl4.TabIndex = 7;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
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
      this.gridView4.Columns.AddRange(new GridColumn[27]
      {
        this.gridColumn28,
        this.gridColumn29,
        this.gridColumn30,
        this.gridColumn31,
        this.gridColumn32,
        this.gridColumn33,
        this.gridColumn34,
        this.gridColumn35,
        this.gridColumn36,
        this.gridColumn37,
        this.gridColumn38,
        this.gridColumn39,
        this.gridColumn40,
        this.gridColumn41,
        this.gridColumn42,
        this.gridColumn43,
        this.gridColumn44,
        this.gridColumn45,
        this.gridColumn46,
        this.gridColumn47,
        this.gridColumn48,
        this.gridColumn49,
        this.gridColumn50,
        this.gridColumn51,
        this.gridColumn52,
        this.gridColumn53,
        this.gridColumn54
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn28, ColumnSortOrder.Descending)
      });
      this.gridColumn28.FieldName = "ID";
      this.gridColumn28.MinWidth = 25;
      this.gridColumn28.Name = "gridColumn28";
      this.gridColumn28.OptionsColumn.AllowEdit = false;
      this.gridColumn28.OptionsColumn.ReadOnly = true;
      this.gridColumn28.Width = 100;
      this.gridColumn29.Caption = "İş Emir Kodu";
      this.gridColumn29.FieldName = "KOD";
      this.gridColumn29.MinWidth = 25;
      this.gridColumn29.Name = "gridColumn29";
      this.gridColumn29.OptionsColumn.AllowEdit = false;
      this.gridColumn29.OptionsColumn.ReadOnly = true;
      this.gridColumn29.Visible = true;
      this.gridColumn29.VisibleIndex = 0;
      this.gridColumn29.Width = 136;
      this.gridColumn30.Caption = "Yılı";
      this.gridColumn30.FieldName = "YIL";
      this.gridColumn30.MinWidth = 25;
      this.gridColumn30.Name = "gridColumn30";
      this.gridColumn30.Visible = true;
      this.gridColumn30.VisibleIndex = 1;
      this.gridColumn30.Width = 93;
      this.gridColumn31.Caption = "Giriş Tarih";
      this.gridColumn31.FieldName = "GIRISTARIH";
      this.gridColumn31.MinWidth = 25;
      this.gridColumn31.Name = "gridColumn31";
      this.gridColumn31.OptionsColumn.AllowEdit = false;
      this.gridColumn31.OptionsColumn.ReadOnly = true;
      this.gridColumn31.Visible = true;
      this.gridColumn31.VisibleIndex = 3;
      this.gridColumn31.Width = 177;
      this.gridColumn32.Caption = "Aracı Getiren";
      this.gridColumn32.FieldName = "ARACIGETIREN";
      this.gridColumn32.MinWidth = 25;
      this.gridColumn32.Name = "gridColumn32";
      this.gridColumn32.OptionsColumn.AllowEdit = false;
      this.gridColumn32.OptionsColumn.ReadOnly = true;
      this.gridColumn32.Visible = true;
      this.gridColumn32.VisibleIndex = 13;
      this.gridColumn32.Width = 225;
      this.gridColumn33.Caption = "Plaka";
      this.gridColumn33.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit9;
      this.gridColumn33.FieldName = "ARACID";
      this.gridColumn33.MinWidth = 25;
      this.gridColumn33.Name = "gridColumn33";
      this.gridColumn33.OptionsColumn.AllowEdit = false;
      this.gridColumn33.OptionsColumn.ReadOnly = true;
      this.gridColumn33.Visible = true;
      this.gridColumn33.VisibleIndex = 2;
      this.gridColumn33.Width = 205;
      this.repositoryItemLookUpEdit9.AutoHeight = false;
      this.repositoryItemLookUpEdit9.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit9.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit9.Name = "repositoryItemLookUpEdit9";
      this.repositoryItemLookUpEdit9.NullText = "";
      this.repositoryItemLookUpEdit9.ValueMember = "ID";
      this.gridColumn34.Caption = "Arac Acıklama";
      this.gridColumn34.FieldName = "ARACACIKLAMA";
      this.gridColumn34.MinWidth = 25;
      this.gridColumn34.Name = "gridColumn34";
      this.gridColumn34.Visible = true;
      this.gridColumn34.VisibleIndex = 5;
      this.gridColumn34.Width = 472;
      this.gridColumn35.Caption = "Bildirilen Arıza";
      this.gridColumn35.FieldName = "BILDIRILENARIZA";
      this.gridColumn35.MinWidth = 25;
      this.gridColumn35.Name = "gridColumn35";
      this.gridColumn35.OptionsColumn.AllowEdit = false;
      this.gridColumn35.OptionsColumn.ReadOnly = true;
      this.gridColumn35.Visible = true;
      this.gridColumn35.VisibleIndex = 9;
      this.gridColumn35.Width = 224;
      this.gridColumn36.Caption = "İş Emir Durum";
      this.gridColumn36.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit10;
      this.gridColumn36.FieldName = "ISEMRIDURUMID";
      this.gridColumn36.MinWidth = 25;
      this.gridColumn36.Name = "gridColumn36";
      this.gridColumn36.OptionsColumn.AllowEdit = false;
      this.gridColumn36.OptionsColumn.ReadOnly = true;
      this.gridColumn36.Visible = true;
      this.gridColumn36.VisibleIndex = 10;
      this.gridColumn36.Width = 261;
      this.repositoryItemLookUpEdit10.AutoHeight = false;
      this.repositoryItemLookUpEdit10.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit10.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit10.Name = "repositoryItemLookUpEdit10";
      this.repositoryItemLookUpEdit10.NullText = "";
      this.repositoryItemLookUpEdit10.ValueMember = "ID";
      this.gridColumn37.Caption = "Atölye";
      this.gridColumn37.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit11;
      this.gridColumn37.FieldName = "ATOLYEID";
      this.gridColumn37.MinWidth = 25;
      this.gridColumn37.Name = "gridColumn37";
      this.gridColumn37.OptionsColumn.AllowEdit = false;
      this.gridColumn37.OptionsColumn.ReadOnly = true;
      this.gridColumn37.Visible = true;
      this.gridColumn37.VisibleIndex = 22;
      this.gridColumn37.Width = 185;
      this.repositoryItemLookUpEdit11.AutoHeight = false;
      this.repositoryItemLookUpEdit11.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit11.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit11.Name = "repositoryItemLookUpEdit11";
      this.repositoryItemLookUpEdit11.NullText = "";
      this.repositoryItemLookUpEdit11.ValueMember = "ID";
      this.gridColumn38.Caption = "Giriş Saati";
      this.gridColumn38.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn38.DisplayFormat.FormatType = FormatType.Custom;
      this.gridColumn38.FieldName = "GIRISSAAT";
      this.gridColumn38.MinWidth = 25;
      this.gridColumn38.Name = "gridColumn38";
      this.gridColumn38.OptionsColumn.AllowEdit = false;
      this.gridColumn38.OptionsColumn.ReadOnly = true;
      this.gridColumn38.Visible = true;
      this.gridColumn38.VisibleIndex = 6;
      this.gridColumn38.Width = 105;
      this.gridColumn39.Caption = "Çıkış Tarihi";
      this.gridColumn39.FieldName = "CIKISTARIH";
      this.gridColumn39.MinWidth = 25;
      this.gridColumn39.Name = "gridColumn39";
      this.gridColumn39.OptionsColumn.AllowEdit = false;
      this.gridColumn39.OptionsColumn.ReadOnly = true;
      this.gridColumn39.Visible = true;
      this.gridColumn39.VisibleIndex = 4;
      this.gridColumn39.Width = 209;
      this.gridColumn40.Caption = "Çıkış Saati";
      this.gridColumn40.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn40.DisplayFormat.FormatType = FormatType.DateTime;
      this.gridColumn40.FieldName = "CIKISSAAT";
      this.gridColumn40.MinWidth = 25;
      this.gridColumn40.Name = "gridColumn40";
      this.gridColumn40.OptionsColumn.AllowEdit = false;
      this.gridColumn40.OptionsColumn.ReadOnly = true;
      this.gridColumn40.Visible = true;
      this.gridColumn40.VisibleIndex = 7;
      this.gridColumn40.Width = 112;
      this.gridColumn41.Caption = "Arıza Nedeni";
      this.gridColumn41.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit12;
      this.gridColumn41.FieldName = "ARIZANEDENIID";
      this.gridColumn41.MinWidth = 25;
      this.gridColumn41.Name = "gridColumn41";
      this.gridColumn41.OptionsColumn.AllowEdit = false;
      this.gridColumn41.OptionsColumn.ReadOnly = true;
      this.gridColumn41.Visible = true;
      this.gridColumn41.VisibleIndex = 8;
      this.gridColumn41.Width = 331;
      this.repositoryItemLookUpEdit12.AutoHeight = false;
      this.repositoryItemLookUpEdit12.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit12.DisplayMember = "ARIZANEDENI";
      this.repositoryItemLookUpEdit12.Name = "repositoryItemLookUpEdit12";
      this.repositoryItemLookUpEdit12.NullText = "";
      this.repositoryItemLookUpEdit12.ValueMember = "ID";
      this.gridColumn42.Caption = "Bakım Yeri";
      this.gridColumn42.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit13;
      this.gridColumn42.FieldName = "BAKIMYERIID";
      this.gridColumn42.MinWidth = 25;
      this.gridColumn42.Name = "gridColumn42";
      this.gridColumn42.OptionsColumn.AllowEdit = false;
      this.gridColumn42.OptionsColumn.ReadOnly = true;
      this.gridColumn42.Visible = true;
      this.gridColumn42.VisibleIndex = 11;
      this.gridColumn42.Width = 208;
      this.repositoryItemLookUpEdit13.AutoHeight = false;
      this.repositoryItemLookUpEdit13.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit13.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit13.Name = "repositoryItemLookUpEdit13";
      this.repositoryItemLookUpEdit13.NullText = "";
      this.repositoryItemLookUpEdit13.ValueMember = "ID";
      this.gridColumn43.Caption = "Bakım Acıklaması";
      this.gridColumn43.FieldName = "BAKIMYERACKLM";
      this.gridColumn43.MinWidth = 25;
      this.gridColumn43.Name = "gridColumn43";
      this.gridColumn43.OptionsColumn.AllowEdit = false;
      this.gridColumn43.OptionsColumn.ReadOnly = true;
      this.gridColumn43.Visible = true;
      this.gridColumn43.VisibleIndex = 12;
      this.gridColumn43.Width = 219;
      this.gridColumn44.Caption = "Bakım Km";
      this.gridColumn44.FieldName = "BAKIMKMSI";
      this.gridColumn44.MinWidth = 25;
      this.gridColumn44.Name = "gridColumn44";
      this.gridColumn44.OptionsColumn.AllowEdit = false;
      this.gridColumn44.OptionsColumn.ReadOnly = true;
      this.gridColumn44.Visible = true;
      this.gridColumn44.VisibleIndex = 14;
      this.gridColumn44.Width = 249;
      this.gridColumn45.Caption = "Sonraki Bakım Km";
      this.gridColumn45.FieldName = "SONRAKIBKMKM";
      this.gridColumn45.MinWidth = 25;
      this.gridColumn45.Name = "gridColumn45";
      this.gridColumn45.OptionsColumn.AllowEdit = false;
      this.gridColumn45.OptionsColumn.ReadOnly = true;
      this.gridColumn45.Visible = true;
      this.gridColumn45.VisibleIndex = 15;
      this.gridColumn45.Width = 259;
      this.gridColumn46.Caption = "Sonraki Bakım Tarihi";
      this.gridColumn46.FieldName = "SONRAKIBKMTRH";
      this.gridColumn46.MinWidth = 25;
      this.gridColumn46.Name = "gridColumn46";
      this.gridColumn46.OptionsColumn.AllowEdit = false;
      this.gridColumn46.OptionsColumn.ReadOnly = true;
      this.gridColumn46.Visible = true;
      this.gridColumn46.VisibleIndex = 16;
      this.gridColumn46.Width = 265;
      this.gridColumn47.Caption = "Bakım Saati";
      this.gridColumn47.FieldName = "BAKIMSAATI";
      this.gridColumn47.MinWidth = 25;
      this.gridColumn47.Name = "gridColumn47";
      this.gridColumn47.OptionsColumn.AllowEdit = false;
      this.gridColumn47.OptionsColumn.ReadOnly = true;
      this.gridColumn47.Visible = true;
      this.gridColumn47.VisibleIndex = 17;
      this.gridColumn47.Width = 209;
      this.gridColumn48.Caption = "Sonraki Bakım Saati";
      this.gridColumn48.FieldName = "SONRAKIBKMSAAT";
      this.gridColumn48.MinWidth = 25;
      this.gridColumn48.Name = "gridColumn48";
      this.gridColumn48.OptionsColumn.AllowEdit = false;
      this.gridColumn48.OptionsColumn.ReadOnly = true;
      this.gridColumn48.Visible = true;
      this.gridColumn48.VisibleIndex = 18;
      this.gridColumn48.Width = 228;
      this.gridColumn49.FieldName = "ISEMRISIRANO";
      this.gridColumn49.MinWidth = 25;
      this.gridColumn49.Name = "gridColumn49";
      this.gridColumn49.OptionsColumn.AllowEdit = false;
      this.gridColumn49.OptionsColumn.ReadOnly = true;
      this.gridColumn49.Width = 199;
      this.gridColumn50.Caption = "Yapılan Bakım Özeti";
      this.gridColumn50.FieldName = "YAPILANBAKIMOZETI";
      this.gridColumn50.MinWidth = 25;
      this.gridColumn50.Name = "gridColumn50";
      this.gridColumn50.OptionsColumn.AllowEdit = false;
      this.gridColumn50.OptionsColumn.ReadOnly = true;
      this.gridColumn50.Visible = true;
      this.gridColumn50.VisibleIndex = 19;
      this.gridColumn50.Width = 247;
      this.gridColumn51.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit14;
      this.gridColumn51.FieldName = "IMZAATOLYESEFID";
      this.gridColumn51.MinWidth = 25;
      this.gridColumn51.Name = "gridColumn51";
      this.gridColumn51.OptionsColumn.AllowEdit = false;
      this.gridColumn51.OptionsColumn.ReadOnly = true;
      this.gridColumn51.Visible = true;
      this.gridColumn51.VisibleIndex = 20;
      this.gridColumn51.Width = 265;
      this.repositoryItemLookUpEdit14.AutoHeight = false;
      this.repositoryItemLookUpEdit14.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit14.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit14.Name = "repositoryItemLookUpEdit14";
      this.repositoryItemLookUpEdit14.NullText = "";
      this.repositoryItemLookUpEdit14.ValueMember = "ID";
      this.gridColumn52.FieldName = "ISBITIMORANI";
      this.gridColumn52.MinWidth = 25;
      this.gridColumn52.Name = "gridColumn52";
      this.gridColumn52.OptionsColumn.AllowEdit = false;
      this.gridColumn52.OptionsColumn.ReadOnly = true;
      this.gridColumn52.Width = 265;
      this.gridColumn53.Caption = "Bakım Türü";
      this.gridColumn53.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit15;
      this.gridColumn53.FieldName = "BAKIMTURUID";
      this.gridColumn53.MinWidth = 25;
      this.gridColumn53.Name = "gridColumn53";
      this.gridColumn53.OptionsColumn.AllowEdit = false;
      this.gridColumn53.OptionsColumn.ReadOnly = true;
      this.gridColumn53.Visible = true;
      this.gridColumn53.VisibleIndex = 21;
      this.gridColumn53.Width = 204;
      this.repositoryItemLookUpEdit15.AutoHeight = false;
      this.repositoryItemLookUpEdit15.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit15.DisplayMember = "BAKIMTURU";
      this.repositoryItemLookUpEdit15.Name = "repositoryItemLookUpEdit15";
      this.repositoryItemLookUpEdit15.NullText = "";
      this.repositoryItemLookUpEdit15.ValueMember = "ID";
      this.gridColumn54.Caption = "Bakım Derecesi";
      this.gridColumn54.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit16;
      this.gridColumn54.FieldName = "BAKIMDERECESIID";
      this.gridColumn54.MinWidth = 25;
      this.gridColumn54.Name = "gridColumn54";
      this.gridColumn54.OptionsColumn.AllowEdit = false;
      this.gridColumn54.OptionsColumn.ReadOnly = true;
      this.gridColumn54.Visible = true;
      this.gridColumn54.VisibleIndex = 23;
      this.gridColumn54.Width = 204;
      this.repositoryItemLookUpEdit16.AutoHeight = false;
      this.repositoryItemLookUpEdit16.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit16.DisplayMember = "BAKIMDERECE";
      this.repositoryItemLookUpEdit16.Name = "repositoryItemLookUpEdit16";
      this.repositoryItemLookUpEdit16.NullText = "";
      this.repositoryItemLookUpEdit16.ValueMember = "ID";
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
      this.tabNavigationPage2.Size = new Size(1389, 541);
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
      this.gridControl3.Size = new Size(1389, 541);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
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
        this.colİşlemYeri,
        this.colARACACIKLAMA1,
        this.colGirisFisKod1,
        this.colTARIH1,
        this.colSAAT,
        this.colMALZACIKLAMA,
        this.colMalzemeKod,
        this.colBirim,
        this.colDepoAdi,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR1,
        this.colKDVORAN,
        this.colSATIRTUTAR,
        this.colGCKOD1,
        this.colMALZSERINO,
        this.colMALZURTTARIH,
        this.colIMZADEPOYETKILIID1,
        this.colMalzGrup,
        this.colMalzGrup2,
        this.colMalzBolum,
        this.colMalzMarka
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsPrint.AutoWidth = false;
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.colİşlemYeri.FieldName = "İşlemYeri";
      this.colİşlemYeri.MinWidth = 27;
      this.colİşlemYeri.Name = "colİşlemYeri";
      this.colİşlemYeri.Visible = true;
      this.colİşlemYeri.VisibleIndex = 0;
      this.colİşlemYeri.Width = 100;
      this.colARACACIKLAMA1.Caption = "Araç Açıklama";
      this.colARACACIKLAMA1.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA1.MinWidth = 27;
      this.colARACACIKLAMA1.Name = "colARACACIKLAMA1";
      this.colARACACIKLAMA1.Visible = true;
      this.colARACACIKLAMA1.VisibleIndex = 1;
      this.colARACACIKLAMA1.Width = 100;
      this.colGirisFisKod1.FieldName = "GirisFisKod";
      this.colGirisFisKod1.MinWidth = 27;
      this.colGirisFisKod1.Name = "colGirisFisKod1";
      this.colGirisFisKod1.Visible = true;
      this.colGirisFisKod1.VisibleIndex = 2;
      this.colGirisFisKod1.Width = 100;
      this.colTARIH1.Caption = "Tarih";
      this.colTARIH1.FieldName = "TARIH";
      this.colTARIH1.MinWidth = 27;
      this.colTARIH1.Name = "colTARIH1";
      this.colTARIH1.Visible = true;
      this.colTARIH1.VisibleIndex = 3;
      this.colTARIH1.Width = 100;
      this.colSAAT.Caption = "Saat";
      this.colSAAT.FieldName = "SAAT";
      this.colSAAT.MinWidth = 27;
      this.colSAAT.Name = "colSAAT";
      this.colSAAT.Visible = true;
      this.colSAAT.VisibleIndex = 4;
      this.colSAAT.Width = 100;
      this.colMALZACIKLAMA.Caption = "Malzeme Açıklama";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.MinWidth = 27;
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 5;
      this.colMALZACIKLAMA.Width = 100;
      this.colMalzemeKod.FieldName = "MalzemeKod";
      this.colMalzemeKod.MinWidth = 27;
      this.colMalzemeKod.Name = "colMalzemeKod";
      this.colMalzemeKod.Visible = true;
      this.colMalzemeKod.VisibleIndex = 6;
      this.colMalzemeKod.Width = 100;
      this.colBirim.Caption = "Brim";
      this.colBirim.FieldName = "Birim";
      this.colBirim.MinWidth = 27;
      this.colBirim.Name = "colBirim";
      this.colBirim.Visible = true;
      this.colBirim.VisibleIndex = 7;
      this.colBirim.Width = 100;
      this.colDepoAdi.FieldName = "DepoAdi";
      this.colDepoAdi.MinWidth = 27;
      this.colDepoAdi.Name = "colDepoAdi";
      this.colDepoAdi.Visible = true;
      this.colDepoAdi.VisibleIndex = 8;
      this.colDepoAdi.Width = 100;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 27;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 9;
      this.colMIKTAR.Width = 100;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 27;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 10;
      this.colFIYAT.Width = 100;
      this.colTUTAR1.Caption = "Tutar";
      this.colTUTAR1.FieldName = "TUTAR";
      this.colTUTAR1.MinWidth = 27;
      this.colTUTAR1.Name = "colTUTAR1";
      this.colTUTAR1.Visible = true;
      this.colTUTAR1.VisibleIndex = 11;
      this.colTUTAR1.Width = 100;
      this.colKDVORAN.Caption = "Kdv Oran";
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.MinWidth = 27;
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 12;
      this.colKDVORAN.Width = 100;
      this.colSATIRTUTAR.Caption = "Satir Tutar";
      this.colSATIRTUTAR.FieldName = "SATIRTUTAR";
      this.colSATIRTUTAR.MinWidth = 27;
      this.colSATIRTUTAR.Name = "colSATIRTUTAR";
      this.colSATIRTUTAR.Visible = true;
      this.colSATIRTUTAR.VisibleIndex = 13;
      this.colSATIRTUTAR.Width = 100;
      this.colGCKOD1.FieldName = "GCKOD";
      this.colGCKOD1.MinWidth = 27;
      this.colGCKOD1.Name = "colGCKOD1";
      this.colGCKOD1.Visible = true;
      this.colGCKOD1.VisibleIndex = 14;
      this.colGCKOD1.Width = 100;
      this.colMALZSERINO.Caption = "Malzeme Seri No";
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.MinWidth = 27;
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 15;
      this.colMALZSERINO.Width = 100;
      this.colMALZURTTARIH.Caption = "Malzeme Üretim Tarihi";
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.MinWidth = 27;
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 16;
      this.colMALZURTTARIH.Width = 100;
      this.colIMZADEPOYETKILIID1.Caption = "İmzalayan Depo Yetkilisi";
      this.colIMZADEPOYETKILIID1.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID1.MinWidth = 27;
      this.colIMZADEPOYETKILIID1.Name = "colIMZADEPOYETKILIID1";
      this.colIMZADEPOYETKILIID1.Visible = true;
      this.colIMZADEPOYETKILIID1.VisibleIndex = 17;
      this.colIMZADEPOYETKILIID1.Width = 100;
      this.colMalzGrup.Caption = "Malzeme Grup 1";
      this.colMalzGrup.FieldName = "MalzGrup";
      this.colMalzGrup.MinWidth = 27;
      this.colMalzGrup.Name = "colMalzGrup";
      this.colMalzGrup.Visible = true;
      this.colMalzGrup.VisibleIndex = 18;
      this.colMalzGrup.Width = 100;
      this.colMalzGrup2.Caption = "Malzeme Grup2";
      this.colMalzGrup2.FieldName = "MalzGrup2";
      this.colMalzGrup2.MinWidth = 27;
      this.colMalzGrup2.Name = "colMalzGrup2";
      this.colMalzGrup2.Visible = true;
      this.colMalzGrup2.VisibleIndex = 19;
      this.colMalzGrup2.Width = 100;
      this.colMalzBolum.Caption = "Malzeme Bölüm";
      this.colMalzBolum.FieldName = "MalzBolum";
      this.colMalzBolum.MinWidth = 27;
      this.colMalzBolum.Name = "colMalzBolum";
      this.colMalzBolum.Visible = true;
      this.colMalzBolum.VisibleIndex = 20;
      this.colMalzBolum.Width = 100;
      this.colMalzMarka.Caption = "Malzeme Marka";
      this.colMalzMarka.FieldName = "MalzMarka";
      this.colMalzMarka.MinWidth = 27;
      this.colMalzMarka.Name = "colMalzMarka";
      this.colMalzMarka.Visible = true;
      this.colMalzMarka.VisibleIndex = 21;
      this.colMalzMarka.Width = 100;
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
      this.tBLDEPOFISBindingSource1.DataMember = "TBLDEPOFIS";
      this.tBLDEPOFISBindingSource1.DataSource = (object) this.bellDataSet6;
      this.tabNavigationPage1.AccessibleDescription = "";
      this.tabNavigationPage1.Caption = "Giriş Fiş ";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1389, 541);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1389, 541);
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
      this.tabPane1.Location = new Point(0, 118);
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
      this.tabPane1.RegularSize = new Size(1389, 587);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1389, 587);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Giriş Fiş Hareketleri";
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLISLEMTIPITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter1.ClearBeforeFill = true;
      this.tBLDEPOFISTableAdapter.ClearBeforeFill = true;
      this.tBLDEPOFISHRKTTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1389, 705);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (GirisFisListesi);
      this.Text = "Giriş Fişi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridView1.EndInit();
      this.İmzalayanDepoYetkilisi.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.gridView6.EndInit();
      this.FirmaId.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.gridView5.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).EndInit();
      ((ISupportInitialize) this.bellDataSet5BindingSource).EndInit();
      this.bellDataSet5.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).EndInit();
      ((ISupportInitialize) this.tBLDEPOFISHRKTBindingSource).EndInit();
      ((ISupportInitialize) this.tBLDEPOFISBindingSource).EndInit();
      ((ISupportInitialize) this.girisfisBindingSource).EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      this.gridView4.EndInit();
      this.repositoryItemLookUpEdit9.EndInit();
      this.repositoryItemLookUpEdit10.EndInit();
      this.repositoryItemLookUpEdit11.EndInit();
      this.repositoryItemLookUpEdit12.EndInit();
      this.repositoryItemLookUpEdit13.EndInit();
      this.repositoryItemLookUpEdit14.EndInit();
      this.repositoryItemLookUpEdit15.EndInit();
      this.repositoryItemLookUpEdit16.EndInit();
      this.repositoryItemTimeSpanEdit5.EndInit();
      this.repositoryItemTimeSpanEdit6.EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.gridControl3.EndInit();
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
      ((ISupportInitialize) this.tBLDEPOFISBindingSource1).EndInit();
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
