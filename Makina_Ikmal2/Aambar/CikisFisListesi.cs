// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.CikisFisListesi
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
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
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
    private GridColumn colID1;
    private GridColumn colDEPOFISID;
    private GridColumn colMALZEMEID;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colBIRIMID;
    private GridColumn colMIKTAR;
    private GridColumn colGIRISMIKTAR;
    private GridColumn colCIKISMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn colGIRISTUTAR;
    private GridColumn colCIKISTUTAR;
    private GridColumn colKDVORAN;
    private GridColumn colKDVTUTAR;
    private GridColumn colSATIRTUTAR;
    private GridColumn colGCKOD1;
    private GridColumn colDEPOID;
    private GridColumn colMALZMARKAID;
    private GridColumn colMALZSERINO;
    private GridColumn colMALZURTTARIH;
    private GridColumn colDEGISIMKMSI;
    private GridColumn colSONRAKIDEGKM;
    private RepositoryItemSearchLookUpEdit IsEmri;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit AlanUsta;
    private GridView gridView5;
    private RepositoryItemSearchLookUpEdit Firma;
    private GridView gridView6;
    private RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
    private GridView gridView7;
    private BindingSource cikisFisListelemeBindingSource;
    private GridColumn colGCKOD;
    private GridColumn colDepoFisID1;
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
    private GridColumn colTutar1;
    private GridColumn colKDVTutar1;
    private GridColumn colTalepFisKod;
    private GridColumn colFisTutar;

    public CikisFisListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) => new GirisFisEkle().Show();

    private void Form6_Load(object sender, EventArgs e) => this.listele();

    public void listele()
    {
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
      this.barButtonItem13 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.colGCKOD = new GridColumn();
      this.colDepoFisID1 = new GridColumn();
      this.colIsEmriID = new GridColumn();
      this.colIsEmriKod = new GridColumn();
      this.colARACID = new GridColumn();
      this.colIslemYeri = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colISLEMTIPI = new GridColumn();
      this.colIMZADEPOYETKILIID = new GridColumn();
      this.colFIRMAID = new GridColumn();
      this.colGirisFisKod = new GridColumn();
      this.colTarih = new GridColumn();
      this.colTutar1 = new GridColumn();
      this.colKDVTutar1 = new GridColumn();
      this.colTalepFisKod = new GridColumn();
      this.colFisTutar = new GridColumn();
      this.IsEmri = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.AlanUsta = new RepositoryItemSearchLookUpEdit();
      this.gridView5 = new GridView();
      this.Firma = new RepositoryItemSearchLookUpEdit();
      this.gridView6 = new GridView();
      this.repositoryItemSearchLookUpEdit1 = new RepositoryItemSearchLookUpEdit();
      this.gridView7 = new GridView();
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
      this.cikisFisListelemeBindingSource = new BindingSource(this.components);
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
      this.colID1 = new GridColumn();
      this.colDEPOFISID = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.colMALZACIKLAMA = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colGIRISMIKTAR = new GridColumn();
      this.colCIKISMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colGIRISTUTAR = new GridColumn();
      this.colCIKISTUTAR = new GridColumn();
      this.colKDVORAN = new GridColumn();
      this.colKDVTUTAR = new GridColumn();
      this.colSATIRTUTAR = new GridColumn();
      this.colGCKOD1 = new GridColumn();
      this.colDEPOID = new GridColumn();
      this.colMALZMARKAID = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colMALZURTTARIH = new GridColumn();
      this.colDEGISIMKMSI = new GridColumn();
      this.colSONRAKIDEGKM = new GridColumn();
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
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.IsEmri.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.AlanUsta.BeginInit();
      this.gridView5.BeginInit();
      this.Firma.BeginInit();
      this.gridView6.BeginInit();
      this.repositoryItemSearchLookUpEdit1.BeginInit();
      this.gridView7.BeginInit();
      ((ISupportInitialize) this.cikisFisListelemeBindingSource).BeginInit();
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
      this.ribbonControl1.Margin = new Padding(2, 2, 2, 2);
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
      this.ribbonControl1.Size = new Size(1042, 100);
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
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2, 2, 2, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.IsEmri,
        (RepositoryItem) this.AlanUsta,
        (RepositoryItem) this.Firma,
        (RepositoryItem) this.repositoryItemSearchLookUpEdit1
      });
      this.gridControl1.Size = new Size(1042, 444);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
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
      this.gridView1.Columns.AddRange(new GridColumn[17]
      {
        this.colGCKOD,
        this.colDepoFisID1,
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
        this.colTutar1,
        this.colKDVTutar1,
        this.colTalepFisKod,
        this.colFisTutar
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colGCKOD.FieldName = "GCKOD";
      this.colGCKOD.Name = "colGCKOD";
      this.colGCKOD.Visible = true;
      this.colGCKOD.VisibleIndex = 0;
      this.colDepoFisID1.FieldName = "DepoFisID";
      this.colDepoFisID1.Name = "colDepoFisID1";
      this.colDepoFisID1.Visible = true;
      this.colDepoFisID1.VisibleIndex = 1;
      this.colIsEmriID.FieldName = "IsEmriID";
      this.colIsEmriID.Name = "colIsEmriID";
      this.colIsEmriID.Visible = true;
      this.colIsEmriID.VisibleIndex = 2;
      this.colIsEmriKod.FieldName = "IsEmriKod";
      this.colIsEmriKod.Name = "colIsEmriKod";
      this.colIsEmriKod.Visible = true;
      this.colIsEmriKod.VisibleIndex = 3;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.Name = "colARACID";
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 4;
      this.colIslemYeri.FieldName = "IslemYeri";
      this.colIslemYeri.Name = "colIslemYeri";
      this.colIslemYeri.Visible = true;
      this.colIslemYeri.VisibleIndex = 5;
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 6;
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 7;
      this.colISLEMTIPI.FieldName = "ISLEMTIPI";
      this.colISLEMTIPI.Name = "colISLEMTIPI";
      this.colISLEMTIPI.Visible = true;
      this.colISLEMTIPI.VisibleIndex = 8;
      this.colIMZADEPOYETKILIID.FieldName = "IMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.Name = "colIMZADEPOYETKILIID";
      this.colIMZADEPOYETKILIID.Visible = true;
      this.colIMZADEPOYETKILIID.VisibleIndex = 9;
      this.colFIRMAID.FieldName = "FIRMAID";
      this.colFIRMAID.Name = "colFIRMAID";
      this.colFIRMAID.Visible = true;
      this.colFIRMAID.VisibleIndex = 10;
      this.colGirisFisKod.FieldName = "GirisFisKod";
      this.colGirisFisKod.Name = "colGirisFisKod";
      this.colGirisFisKod.Visible = true;
      this.colGirisFisKod.VisibleIndex = 11;
      this.colTarih.FieldName = "Tarih";
      this.colTarih.Name = "colTarih";
      this.colTarih.Visible = true;
      this.colTarih.VisibleIndex = 12;
      this.colTutar1.FieldName = "Tutar";
      this.colTutar1.Name = "colTutar1";
      this.colTutar1.Visible = true;
      this.colTutar1.VisibleIndex = 13;
      this.colKDVTutar1.FieldName = "KDVTutar";
      this.colKDVTutar1.Name = "colKDVTutar1";
      this.colKDVTutar1.Visible = true;
      this.colKDVTutar1.VisibleIndex = 14;
      this.colTalepFisKod.FieldName = "TalepFisKod";
      this.colTalepFisKod.Name = "colTalepFisKod";
      this.colTalepFisKod.Visible = true;
      this.colTalepFisKod.VisibleIndex = 15;
      this.colFisTutar.FieldName = "FisTutar";
      this.colFisTutar.Name = "colFisTutar";
      this.colFisTutar.Visible = true;
      this.colFisTutar.VisibleIndex = 16;
      this.IsEmri.AutoHeight = false;
      this.IsEmri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IsEmri.DisplayMember = "KOD";
      this.IsEmri.Name = "IsEmri";
      this.IsEmri.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.IsEmri.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.AlanUsta.AutoHeight = false;
      this.AlanUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AlanUsta.DisplayMember = "USTAADISOYADI";
      this.AlanUsta.Name = "AlanUsta";
      this.AlanUsta.PopupView = (ColumnView) this.gridView5;
      this.AlanUsta.ValueMember = "ID";
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.Firma.AutoHeight = false;
      this.Firma.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Firma.DisplayMember = "FIRMAADI";
      this.Firma.Name = "Firma";
      this.Firma.PopupView = (ColumnView) this.gridView6;
      this.Firma.ValueMember = "ID";
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
      this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
      this.repositoryItemSearchLookUpEdit1.PopupView = (ColumnView) this.gridView7;
      this.gridView7.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView7.OptionsView.ShowGroupPanel = false;
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
      this.tabNavigationPage3.Caption = "Çıkış  Fiş Toplamları";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Margin = new Padding(2, 2, 2, 2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1042, 444);
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.Margin = new Padding(2, 2, 2, 2);
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
      this.gridView4.DetailHeight = 284;
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn28, ColumnSortOrder.Descending)
      });
      this.gridColumn28.FieldName = "ID";
      this.gridColumn28.MinWidth = 19;
      this.gridColumn28.Name = "gridColumn28";
      this.gridColumn28.OptionsColumn.AllowEdit = false;
      this.gridColumn28.OptionsColumn.ReadOnly = true;
      this.gridColumn29.Caption = "İş Emir Kodu";
      this.gridColumn29.FieldName = "KOD";
      this.gridColumn29.MinWidth = 19;
      this.gridColumn29.Name = "gridColumn29";
      this.gridColumn29.OptionsColumn.AllowEdit = false;
      this.gridColumn29.OptionsColumn.ReadOnly = true;
      this.gridColumn29.Visible = true;
      this.gridColumn29.VisibleIndex = 0;
      this.gridColumn29.Width = 102;
      this.gridColumn30.Caption = "Yılı";
      this.gridColumn30.FieldName = "YIL";
      this.gridColumn30.MinWidth = 19;
      this.gridColumn30.Name = "gridColumn30";
      this.gridColumn30.Visible = true;
      this.gridColumn30.VisibleIndex = 1;
      this.gridColumn30.Width = 70;
      this.gridColumn31.Caption = "Giriş Tarih";
      this.gridColumn31.FieldName = "GIRISTARIH";
      this.gridColumn31.MinWidth = 19;
      this.gridColumn31.Name = "gridColumn31";
      this.gridColumn31.OptionsColumn.AllowEdit = false;
      this.gridColumn31.OptionsColumn.ReadOnly = true;
      this.gridColumn31.Visible = true;
      this.gridColumn31.VisibleIndex = 3;
      this.gridColumn31.Width = 133;
      this.gridColumn32.Caption = "Aracı Getiren";
      this.gridColumn32.FieldName = "ARACIGETIREN";
      this.gridColumn32.MinWidth = 19;
      this.gridColumn32.Name = "gridColumn32";
      this.gridColumn32.OptionsColumn.AllowEdit = false;
      this.gridColumn32.OptionsColumn.ReadOnly = true;
      this.gridColumn32.Visible = true;
      this.gridColumn32.VisibleIndex = 13;
      this.gridColumn32.Width = 169;
      this.gridColumn33.Caption = "Plaka";
      this.gridColumn33.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit9;
      this.gridColumn33.FieldName = "ARACID";
      this.gridColumn33.MinWidth = 19;
      this.gridColumn33.Name = "gridColumn33";
      this.gridColumn33.OptionsColumn.AllowEdit = false;
      this.gridColumn33.OptionsColumn.ReadOnly = true;
      this.gridColumn33.Visible = true;
      this.gridColumn33.VisibleIndex = 2;
      this.gridColumn33.Width = 154;
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
      this.gridColumn34.MinWidth = 19;
      this.gridColumn34.Name = "gridColumn34";
      this.gridColumn34.Visible = true;
      this.gridColumn34.VisibleIndex = 5;
      this.gridColumn34.Width = 354;
      this.gridColumn35.Caption = "Bildirilen Arıza";
      this.gridColumn35.FieldName = "BILDIRILENARIZA";
      this.gridColumn35.MinWidth = 19;
      this.gridColumn35.Name = "gridColumn35";
      this.gridColumn35.OptionsColumn.AllowEdit = false;
      this.gridColumn35.OptionsColumn.ReadOnly = true;
      this.gridColumn35.Visible = true;
      this.gridColumn35.VisibleIndex = 9;
      this.gridColumn35.Width = 168;
      this.gridColumn36.Caption = "İş Emir Durum";
      this.gridColumn36.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit10;
      this.gridColumn36.FieldName = "ISEMRIDURUMID";
      this.gridColumn36.MinWidth = 19;
      this.gridColumn36.Name = "gridColumn36";
      this.gridColumn36.OptionsColumn.AllowEdit = false;
      this.gridColumn36.OptionsColumn.ReadOnly = true;
      this.gridColumn36.Visible = true;
      this.gridColumn36.VisibleIndex = 10;
      this.gridColumn36.Width = 196;
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
      this.gridColumn37.MinWidth = 19;
      this.gridColumn37.Name = "gridColumn37";
      this.gridColumn37.OptionsColumn.AllowEdit = false;
      this.gridColumn37.OptionsColumn.ReadOnly = true;
      this.gridColumn37.Visible = true;
      this.gridColumn37.VisibleIndex = 22;
      this.gridColumn37.Width = 139;
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
      this.gridColumn38.MinWidth = 19;
      this.gridColumn38.Name = "gridColumn38";
      this.gridColumn38.OptionsColumn.AllowEdit = false;
      this.gridColumn38.OptionsColumn.ReadOnly = true;
      this.gridColumn38.Visible = true;
      this.gridColumn38.VisibleIndex = 6;
      this.gridColumn38.Width = 79;
      this.gridColumn39.Caption = "Çıkış Tarihi";
      this.gridColumn39.FieldName = "CIKISTARIH";
      this.gridColumn39.MinWidth = 19;
      this.gridColumn39.Name = "gridColumn39";
      this.gridColumn39.OptionsColumn.AllowEdit = false;
      this.gridColumn39.OptionsColumn.ReadOnly = true;
      this.gridColumn39.Visible = true;
      this.gridColumn39.VisibleIndex = 4;
      this.gridColumn39.Width = 157;
      this.gridColumn40.Caption = "Çıkış Saati";
      this.gridColumn40.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn40.DisplayFormat.FormatType = FormatType.DateTime;
      this.gridColumn40.FieldName = "CIKISSAAT";
      this.gridColumn40.MinWidth = 19;
      this.gridColumn40.Name = "gridColumn40";
      this.gridColumn40.OptionsColumn.AllowEdit = false;
      this.gridColumn40.OptionsColumn.ReadOnly = true;
      this.gridColumn40.Visible = true;
      this.gridColumn40.VisibleIndex = 7;
      this.gridColumn40.Width = 84;
      this.gridColumn41.Caption = "Arıza Nedeni";
      this.gridColumn41.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit12;
      this.gridColumn41.FieldName = "ARIZANEDENIID";
      this.gridColumn41.MinWidth = 19;
      this.gridColumn41.Name = "gridColumn41";
      this.gridColumn41.OptionsColumn.AllowEdit = false;
      this.gridColumn41.OptionsColumn.ReadOnly = true;
      this.gridColumn41.Visible = true;
      this.gridColumn41.VisibleIndex = 8;
      this.gridColumn41.Width = 248;
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
      this.gridColumn42.MinWidth = 19;
      this.gridColumn42.Name = "gridColumn42";
      this.gridColumn42.OptionsColumn.AllowEdit = false;
      this.gridColumn42.OptionsColumn.ReadOnly = true;
      this.gridColumn42.Visible = true;
      this.gridColumn42.VisibleIndex = 11;
      this.gridColumn42.Width = 156;
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
      this.gridColumn43.MinWidth = 19;
      this.gridColumn43.Name = "gridColumn43";
      this.gridColumn43.OptionsColumn.AllowEdit = false;
      this.gridColumn43.OptionsColumn.ReadOnly = true;
      this.gridColumn43.Visible = true;
      this.gridColumn43.VisibleIndex = 12;
      this.gridColumn43.Width = 164;
      this.gridColumn44.Caption = "Bakım Km";
      this.gridColumn44.FieldName = "BAKIMKMSI";
      this.gridColumn44.MinWidth = 19;
      this.gridColumn44.Name = "gridColumn44";
      this.gridColumn44.OptionsColumn.AllowEdit = false;
      this.gridColumn44.OptionsColumn.ReadOnly = true;
      this.gridColumn44.Visible = true;
      this.gridColumn44.VisibleIndex = 14;
      this.gridColumn44.Width = 187;
      this.gridColumn45.Caption = "Sonraki Bakım Km";
      this.gridColumn45.FieldName = "SONRAKIBKMKM";
      this.gridColumn45.MinWidth = 19;
      this.gridColumn45.Name = "gridColumn45";
      this.gridColumn45.OptionsColumn.AllowEdit = false;
      this.gridColumn45.OptionsColumn.ReadOnly = true;
      this.gridColumn45.Visible = true;
      this.gridColumn45.VisibleIndex = 15;
      this.gridColumn45.Width = 194;
      this.gridColumn46.Caption = "Sonraki Bakım Tarihi";
      this.gridColumn46.FieldName = "SONRAKIBKMTRH";
      this.gridColumn46.MinWidth = 19;
      this.gridColumn46.Name = "gridColumn46";
      this.gridColumn46.OptionsColumn.AllowEdit = false;
      this.gridColumn46.OptionsColumn.ReadOnly = true;
      this.gridColumn46.Visible = true;
      this.gridColumn46.VisibleIndex = 16;
      this.gridColumn46.Width = 199;
      this.gridColumn47.Caption = "Bakım Saati";
      this.gridColumn47.FieldName = "BAKIMSAATI";
      this.gridColumn47.MinWidth = 19;
      this.gridColumn47.Name = "gridColumn47";
      this.gridColumn47.OptionsColumn.AllowEdit = false;
      this.gridColumn47.OptionsColumn.ReadOnly = true;
      this.gridColumn47.Visible = true;
      this.gridColumn47.VisibleIndex = 17;
      this.gridColumn47.Width = 157;
      this.gridColumn48.Caption = "Sonraki Bakım Saati";
      this.gridColumn48.FieldName = "SONRAKIBKMSAAT";
      this.gridColumn48.MinWidth = 19;
      this.gridColumn48.Name = "gridColumn48";
      this.gridColumn48.OptionsColumn.AllowEdit = false;
      this.gridColumn48.OptionsColumn.ReadOnly = true;
      this.gridColumn48.Visible = true;
      this.gridColumn48.VisibleIndex = 18;
      this.gridColumn48.Width = 171;
      this.gridColumn49.FieldName = "ISEMRISIRANO";
      this.gridColumn49.MinWidth = 19;
      this.gridColumn49.Name = "gridColumn49";
      this.gridColumn49.OptionsColumn.AllowEdit = false;
      this.gridColumn49.OptionsColumn.ReadOnly = true;
      this.gridColumn49.Width = 149;
      this.gridColumn50.Caption = "Yapılan Bakım Özeti";
      this.gridColumn50.FieldName = "YAPILANBAKIMOZETI";
      this.gridColumn50.MinWidth = 19;
      this.gridColumn50.Name = "gridColumn50";
      this.gridColumn50.OptionsColumn.AllowEdit = false;
      this.gridColumn50.OptionsColumn.ReadOnly = true;
      this.gridColumn50.Visible = true;
      this.gridColumn50.VisibleIndex = 19;
      this.gridColumn50.Width = 185;
      this.gridColumn51.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit14;
      this.gridColumn51.FieldName = "IMZAATOLYESEFID";
      this.gridColumn51.MinWidth = 19;
      this.gridColumn51.Name = "gridColumn51";
      this.gridColumn51.OptionsColumn.AllowEdit = false;
      this.gridColumn51.OptionsColumn.ReadOnly = true;
      this.gridColumn51.Visible = true;
      this.gridColumn51.VisibleIndex = 20;
      this.gridColumn51.Width = 199;
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
      this.gridColumn52.MinWidth = 19;
      this.gridColumn52.Name = "gridColumn52";
      this.gridColumn52.OptionsColumn.AllowEdit = false;
      this.gridColumn52.OptionsColumn.ReadOnly = true;
      this.gridColumn52.Width = 199;
      this.gridColumn53.Caption = "Bakım Türü";
      this.gridColumn53.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit15;
      this.gridColumn53.FieldName = "BAKIMTURUID";
      this.gridColumn53.MinWidth = 19;
      this.gridColumn53.Name = "gridColumn53";
      this.gridColumn53.OptionsColumn.AllowEdit = false;
      this.gridColumn53.OptionsColumn.ReadOnly = true;
      this.gridColumn53.Visible = true;
      this.gridColumn53.VisibleIndex = 21;
      this.gridColumn53.Width = 153;
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
      this.gridColumn54.MinWidth = 19;
      this.gridColumn54.Name = "gridColumn54";
      this.gridColumn54.OptionsColumn.AllowEdit = false;
      this.gridColumn54.OptionsColumn.ReadOnly = true;
      this.gridColumn54.Visible = true;
      this.gridColumn54.VisibleIndex = 23;
      this.gridColumn54.Width = 153;
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
      this.tabNavigationPage2.Caption = "Çıkış  Fiş Hareketleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(2, 2, 2, 2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1042, 444);
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(2, 2, 2, 2);
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
        this.colID1,
        this.colDEPOFISID,
        this.colMALZEMEID,
        this.colMALZACIKLAMA,
        this.colBIRIMID,
        this.colMIKTAR,
        this.colGIRISMIKTAR,
        this.colCIKISMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.colGIRISTUTAR,
        this.colCIKISTUTAR,
        this.colKDVORAN,
        this.colKDVTUTAR,
        this.colSATIRTUTAR,
        this.colGCKOD1,
        this.colDEPOID,
        this.colMALZMARKAID,
        this.colMALZSERINO,
        this.colMALZURTTARIH,
        this.colDEGISIMKMSI,
        this.colSONRAKIDEGKM
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.colID1.FieldName = "ID";
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Width = 46;
      this.colDEPOFISID.FieldName = "DEPOFISID";
      this.colDEPOFISID.Name = "colDEPOFISID";
      this.colDEPOFISID.OptionsColumn.AllowEdit = false;
      this.colDEPOFISID.OptionsColumn.ReadOnly = true;
      this.colDEPOFISID.Visible = true;
      this.colDEPOFISID.VisibleIndex = 0;
      this.colDEPOFISID.Width = 105;
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 1;
      this.colMALZEMEID.Width = 117;
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colMALZACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 2;
      this.colMALZACIKLAMA.Width = 132;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 3;
      this.colBIRIMID.Width = 83;
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 4;
      this.colMIKTAR.Width = 87;
      this.colGIRISMIKTAR.FieldName = "GIRISMIKTAR";
      this.colGIRISMIKTAR.Name = "colGIRISMIKTAR";
      this.colGIRISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISMIKTAR.Visible = true;
      this.colGIRISMIKTAR.VisibleIndex = 5;
      this.colGIRISMIKTAR.Width = 129;
      this.colCIKISMIKTAR.FieldName = "CIKISMIKTAR";
      this.colCIKISMIKTAR.Name = "colCIKISMIKTAR";
      this.colCIKISMIKTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISMIKTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISMIKTAR.Visible = true;
      this.colCIKISMIKTAR.VisibleIndex = 6;
      this.colCIKISMIKTAR.Width = 111;
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 7;
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.OptionsColumn.AllowEdit = false;
      this.colTUTAR.OptionsColumn.ReadOnly = true;
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 8;
      this.colGIRISTUTAR.FieldName = "GIRISTUTAR";
      this.colGIRISTUTAR.Name = "colGIRISTUTAR";
      this.colGIRISTUTAR.OptionsColumn.AllowEdit = false;
      this.colGIRISTUTAR.OptionsColumn.ReadOnly = true;
      this.colGIRISTUTAR.Visible = true;
      this.colGIRISTUTAR.VisibleIndex = 9;
      this.colGIRISTUTAR.Width = 126;
      this.colCIKISTUTAR.FieldName = "CIKISTUTAR";
      this.colCIKISTUTAR.Name = "colCIKISTUTAR";
      this.colCIKISTUTAR.OptionsColumn.AllowEdit = false;
      this.colCIKISTUTAR.OptionsColumn.ReadOnly = true;
      this.colCIKISTUTAR.Visible = true;
      this.colCIKISTUTAR.VisibleIndex = 10;
      this.colCIKISTUTAR.Width = 121;
      this.colKDVORAN.FieldName = "KDVORAN";
      this.colKDVORAN.Name = "colKDVORAN";
      this.colKDVORAN.OptionsColumn.AllowEdit = false;
      this.colKDVORAN.OptionsColumn.ReadOnly = true;
      this.colKDVORAN.Visible = true;
      this.colKDVORAN.VisibleIndex = 11;
      this.colKDVTUTAR.FieldName = "KDVTUTAR";
      this.colKDVTUTAR.Name = "colKDVTUTAR";
      this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
      this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
      this.colKDVTUTAR.Visible = true;
      this.colKDVTUTAR.VisibleIndex = 12;
      this.colKDVTUTAR.Width = 116;
      this.colSATIRTUTAR.FieldName = "SATIRTUTAR";
      this.colSATIRTUTAR.Name = "colSATIRTUTAR";
      this.colSATIRTUTAR.OptionsColumn.AllowEdit = false;
      this.colSATIRTUTAR.OptionsColumn.ReadOnly = true;
      this.colSATIRTUTAR.Visible = true;
      this.colSATIRTUTAR.VisibleIndex = 13;
      this.colSATIRTUTAR.Width = 110;
      this.colGCKOD1.FieldName = "GCKOD";
      this.colGCKOD1.Name = "colGCKOD1";
      this.colGCKOD1.OptionsColumn.AllowEdit = false;
      this.colGCKOD1.OptionsColumn.ReadOnly = true;
      this.colGCKOD1.Visible = true;
      this.colGCKOD1.VisibleIndex = 14;
      this.colDEPOID.FieldName = "DEPOID";
      this.colDEPOID.Name = "colDEPOID";
      this.colDEPOID.OptionsColumn.AllowEdit = false;
      this.colDEPOID.OptionsColumn.ReadOnly = true;
      this.colDEPOID.Visible = true;
      this.colDEPOID.VisibleIndex = 15;
      this.colMALZMARKAID.FieldName = "MALZMARKAID";
      this.colMALZMARKAID.Name = "colMALZMARKAID";
      this.colMALZMARKAID.OptionsColumn.AllowEdit = false;
      this.colMALZMARKAID.OptionsColumn.ReadOnly = true;
      this.colMALZMARKAID.Visible = true;
      this.colMALZMARKAID.VisibleIndex = 16;
      this.colMALZMARKAID.Width = 154;
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 17;
      this.colMALZSERINO.Width = 133;
      this.colMALZURTTARIH.FieldName = "MALZURTTARIH";
      this.colMALZURTTARIH.Name = "colMALZURTTARIH";
      this.colMALZURTTARIH.OptionsColumn.AllowEdit = false;
      this.colMALZURTTARIH.OptionsColumn.ReadOnly = true;
      this.colMALZURTTARIH.Visible = true;
      this.colMALZURTTARIH.VisibleIndex = 18;
      this.colMALZURTTARIH.Width = 153;
      this.colDEGISIMKMSI.FieldName = "DEGISIMKMSI";
      this.colDEGISIMKMSI.Name = "colDEGISIMKMSI";
      this.colDEGISIMKMSI.OptionsColumn.AllowEdit = false;
      this.colDEGISIMKMSI.OptionsColumn.ReadOnly = true;
      this.colDEGISIMKMSI.Visible = true;
      this.colDEGISIMKMSI.VisibleIndex = 19;
      this.colDEGISIMKMSI.Width = 132;
      this.colSONRAKIDEGKM.FieldName = "SONRAKIDEGKM";
      this.colSONRAKIDEGKM.Name = "colSONRAKIDEGKM";
      this.colSONRAKIDEGKM.OptionsColumn.AllowEdit = false;
      this.colSONRAKIDEGKM.OptionsColumn.ReadOnly = true;
      this.colSONRAKIDEGKM.Visible = true;
      this.colSONRAKIDEGKM.VisibleIndex = 20;
      this.colSONRAKIDEGKM.Width = 131;
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
      this.tabNavigationPage1.Margin = new Padding(2, 2, 2, 2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1042, 444);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2, 2, 2, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1042, 444);
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
      this.simpleButton1.Margin = new Padding(2, 2, 2, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(19, 20);
      this.simpleButton1.TabIndex = 3;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 100);
      this.tabPane1.Margin = new Padding(2, 2, 2, 2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[3]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3
      });
      this.tabPane1.RegularSize = new Size(1042, 473);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1042, 473);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Giriş Fiş Hareketleri";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1042, 573);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = nameof (CikisFisListesi);
      this.Text = "Çıkış Fişi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.IsEmri.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.AlanUsta.EndInit();
      this.gridView5.EndInit();
      this.Firma.EndInit();
      this.gridView6.EndInit();
      this.repositoryItemSearchLookUpEdit1.EndInit();
      this.gridView7.EndInit();
      ((ISupportInitialize) this.cikisFisListelemeBindingSource).EndInit();
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
