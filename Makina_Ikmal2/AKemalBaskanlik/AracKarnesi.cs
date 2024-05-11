// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AKemalBaskanlik.AracKarnesi
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
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AKemalBaskanlik
{
  public class AracKarnesi : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private int tabdeger = 1;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
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
    private GridControl gridControl4;
    private GridView gridView4;
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private BarButtonItem barButtonItem1;
    private LayoutControl layoutControl1;
    private GridControl gridControl5;
    private GridView gridView7;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private BindingSource aracKarnesiListeBindingSource;
    private AracKarnesiListe aracKarnesiListe;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.Model.AracKarnesiListeTableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private GridColumn colBirimAdı;
    private GridColumn colPLAKA;
    private GridColumn colARACACIKLAMA2;
    private GridColumn colAnaGrup;
    private GridColumn colAltGrup;
    private GridColumn colB_Sayısı;
    private GridColumn colID;
    private GridColumn colRESIMON;
    private GridColumn colRESİMARKA;
    private RepositoryItemSearchLookUpEdit Birim;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private RepositoryItemSearchLookUpEdit AnaGrup;
    private GridView gridView8;
    private BindingSource tBLARACGRUBUBindingSource;
    private TBLARACGRUBUTableAdapter tBLARACGRUBUTableAdapter;
    private RepositoryItemSearchLookUpEdit AltGrup;
    private GridView gridView9;
    private BindingSource tBLARACGRUBU2BindingSource;
    private TBLARACGRUBU2TableAdapter tBLARACGRUBU2TableAdapter;
    private TabNavigationPage tabNavigationPage4;
    private TabNavigationPage tabNavigationPage5;
    private BindingSource tBLISEMRIBindingSource;
    private BindingSource aracKarnesiAtolyeIsEmirBindingSource;
    private AracKarnesiAtolyeIsEmir aracKarnesiAtolyeIsEmir;
    private GridColumn colArızaNedeni;
    private GridColumn colGIRISTARIH;
    private GridColumn colCIKISTARIH;
    private GridColumn colBILDIRILENARIZA;
    private GridColumn colBakımYeri;
    private GridColumn colBAKIMKMSI;
    private GridColumn colSONRAKIBKMKM;
    private GridColumn colSONRAKIBKMTRH;
    private GridColumn colBAKIMSAATI;
    private GridColumn colSONRAKIBKMSAAT;
    private GridColumn colYAPILANBAKIMOZETI;
    private GridColumn colARACID;
    private GridColumn colİşEmriKod;
    private GridColumn colIsEmriID;
    private RepositoryItemSearchLookUpEdit BakimYer;
    private GridView gridView5;
    private Makina_Ikmal.Model.AracKarnesiAtolyeIsEmirTableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLBAKIMYERIBindingSource;
    private TBLBAKIMYERITableAdapter tBLBAKIMYERITableAdapter;
    private LayoutControlItem layoutControlItem2;
    private BindingSource dataTable1BindingSource1;
    private AracKarnesiYapilanBakimlar aracKarnesiYapilanBakimlar;
    private RepositoryItemSearchLookUpEdit AtolyeAdi;
    private GridView gridView11;
    private BindingSource dataTable1BindingSource;
    private BindingSource aracKarnesiYagIsEmriBindingSource;
    private AracKarnesiYagIsEmri aracKarnesiYagIsEmri;
    private GridColumn colID1;
    private GridColumn colIsEmriKod;
    private GridColumn colGIRISTARIH1;
    private GridColumn colCIKISTARIH1;
    private GridColumn colBILDIRILENARIZA1;
    private GridColumn colBakımYeri1;
    private RepositoryItemSearchLookUpEdit BakimYeri;
    private BindingSource tBLBAKIMYERIBindingSource1;
    private GridView gridView6;
    private GridColumn colBAKIMKMSI1;
    private GridColumn colSONRAKIBKMKM1;
    private GridColumn colSONRAKIBKMTRH1;
    private GridColumn colBAKIMSAATI1;
    private GridColumn colSONRAKIBKMSAAT1;
    private GridColumn colYAPILANBAKIMOZETI1;
    private GridColumn colARACID1;
    private GridColumn colBELDBIRIMID;
    private RepositoryItemSearchLookUpEdit BirimAdi;
    private GridView gridView10;
    private Makina_Ikmal.Model.AracKarnesiYagIsEmriTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private Makina_Ikmal.Model.AracKarnesiYapilanBakimlarTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private RepositoryItemSearchLookUpEdit BakimGrubu;
    private GridView gridView12;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private RepositoryItemSearchLookUpEdit BakimYapanUsta;
    private GridView gridView13;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private GridControl gridControl6;
    private BindingSource dataTable1BindingSource2;
    private AracKarnesiKullanılanMalzemeler aracKarnesiKullanılanMalzemeler;
    private GridView gridView14;
    private GridColumn colIsEmriKod2;
    private GridColumn colIslemTipi;
    private GridColumn colFisKod;
    private GridColumn colTARIH;
    private GridColumn colMALZEMEID;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn colMALZSERINO;
    private GridColumn colDEGISIMKMSI;
    private GridColumn colSONRAKIDEGKM;
    private GridColumn colDEPOID;
    private GridColumn colALANUSTAID;
    private GridColumn colARACID3;
    private GridColumn colDepoFisHrktId;
    private GridColumn colDepoFisId;
    private GridColumn colISEMRIID2;
    private RepositoryItemSearchLookUpEdit MalzemeId;
    private GridView gridView15;
    private Makina_Ikmal.Model.AracKarnesiKullanılanMalzemelerTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private RepositoryItemSearchLookUpEdit IslemTipi;
    private GridView gridView16;
    private BindingSource tBLISLEMTIPIBindingSource;
    private TBLISLEMTIPITableAdapter tBLISLEMTIPITableAdapter;
    private RepositoryItemSearchLookUpEdit Depo;
    private GridView gridView17;
    private BindingSource tBLMALZDEPOBindingSource;
    private TBLMALZDEPOTableAdapter tBLMALZDEPOTableAdapter;
    private RepositoryItemSearchLookUpEdit AlanUsta;
    private GridView gridView18;
    private GridControl gridControl7;
    private BindingSource dataTable1BindingSource3;
    private BindingSource aracKarnesiMalzemeToplamlariBindingSource;
    private AracKarnesiMalzemeToplamlari aracKarnesiMalzemeToplamlari;
    private GridView gridView19;
    private GridColumn colDepoFisHrktID1;
    private GridColumn colMALZEMEID1;
    private RepositoryItemSearchLookUpEdit MalzemeAdi;
    private GridView gridView20;
    private GridColumn colMIKTAR1;
    private GridColumn colFIYAT1;
    private GridColumn colTUTAR1;
    private GridColumn colDepoFisID1;
    private GridColumn colIsEmriId3;
    private GridColumn colARACID4;
    private Makina_Ikmal.Model.AracKarnesiMalzemeToplamlariTableAdapters.DataTable1TableAdapter dataTable1TableAdapter3;
    private RepositoryItemSearchLookUpEdit ArizaNedeni;
    private GridView gridView21;
    private BindingSource tAHARIZANEDENIBindingSource;
    private TAHARIZANEDENITableAdapter tAHARIZANEDENITableAdapter;
    private BindingSource dataTable1BindingSource4;
    private BindingSource aracKarnesiYapilanBakimlarBindingSource;
    private GridColumn colARACID2;
    private GridColumn colISEMRIID1;
    private GridColumn colID2;
    private GridColumn colİşEmriKod1;
    private GridColumn colGIRISTARIH2;
    private GridColumn colCIKISTARIH2;
    private GridColumn colATOLYEID;
    private GridColumn colBAKIMYAPUSTAID;
    private GridColumn colBAKIMGRUBUID;
    private GridColumn colYAPILANBAKIM;

    public AracKarnesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      try
      {
        this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet6.TAHARIZANEDENI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet6.TBLMALZDEPO);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLISLEMTIPITableAdapter.Fill(this.bellDataSet6.TBLISLEMTIPI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet6.TBLMALZEMELER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet6.TBLATOLYEUSTALAR);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet6.TBLBAKIMGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet6.TBLATOLYEBOLUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet6.TBLBAKIMYERI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBU2TableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU2);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBUTableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet6.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.aracKarnesiListe.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
      this.listele();
    }

    public void listele()
    {
      try
      {
        this.tAHARIZANEDENITableAdapter.Fill(this.bellDataSet6.TAHARIZANEDENI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLMALZDEPOTableAdapter.Fill(this.bellDataSet6.TBLMALZDEPO);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLISLEMTIPITableAdapter.Fill(this.bellDataSet6.TBLISLEMTIPI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet6.TBLMALZEMELER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet6.TBLATOLYEUSTALAR);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet6.TBLBAKIMGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet6.TBLATOLYEBOLUM);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet6.TBLBAKIMYERI);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBU2TableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU2);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACGRUBUTableAdapter.Fill(this.bellDataSet6.TBLARACGRUBU);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet6.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.aracKarnesiListe.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
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
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

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

    private void gridView7_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(this.gridView7.GetFocusedRowCellValue("ID"));
      try
      {
        this.tBLISEMRITableAdapter.Fill(this.aracKarnesiAtolyeIsEmir.TBLISEMRI, new int?(int32));
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter.Fill(this.aracKarnesiYagIsEmri.DataTable1, new int?(int32));
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter1.Fill(this.aracKarnesiYapilanBakimlar.DataTable1, new int?(int32));
      }
      catch (Exception ex)
      {
        throw;
      }
      try
      {
        this.dataTable1TableAdapter2.Fill(this.aracKarnesiKullanılanMalzemeler.DataTable1, new int?(int32));
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.dataTable1TableAdapter3.Fill(this.aracKarnesiMalzemeToplamlari.DataTable1, new int?(int32));
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      if (this.tabdeger == 1)
        this.gridControl1.ExportToXlsx(str);
      if (this.tabdeger == 2)
        this.gridControl3.ExportToXlsx(str);
      if (this.tabdeger == 3)
        this.gridControl4.ExportToXlsx(str);
      if (this.tabdeger == 4)
        this.gridControl6.ExportToXlsx(str);
      if (this.tabdeger == 5)
        this.gridControl7.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void tabNavigationPage1_Click(object sender, EventArgs e) => this.tabdeger = 1;

    private void tabNavigationPage2_Click(object sender, EventArgs e) => this.tabdeger = 2;

    private void tabNavigationPage3_Click(object sender, EventArgs e) => this.tabdeger = 3;

    private void tabNavigationPage4_Click(object sender, EventArgs e) => this.tabdeger = 4;

    private void tabNavigationPage5_Click(object sender, EventArgs e) => this.tabdeger = 5;

    private void gridControl5_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracKarnesi));
      this.ribbonControl1 = new RibbonControl();
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
      this.gridControl5 = new GridControl();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.aracKarnesiListeBindingSource = new BindingSource(this.components);
      this.aracKarnesiListe = new AracKarnesiListe();
      this.gridView7 = new GridView();
      this.colBirimAdı = new GridColumn();
      this.Birim = new RepositoryItemSearchLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colPLAKA = new GridColumn();
      this.colARACACIKLAMA2 = new GridColumn();
      this.colAnaGrup = new GridColumn();
      this.AnaGrup = new RepositoryItemSearchLookUpEdit();
      this.tBLARACGRUBUBindingSource = new BindingSource(this.components);
      this.gridView8 = new GridView();
      this.colAltGrup = new GridColumn();
      this.AltGrup = new RepositoryItemSearchLookUpEdit();
      this.tBLARACGRUBU2BindingSource = new BindingSource(this.components);
      this.gridView9 = new GridView();
      this.colB_Sayısı = new GridColumn();
      this.colID = new GridColumn();
      this.colRESIMON = new GridColumn();
      this.colRESİMARKA = new GridColumn();
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
      this.barButtonItem1 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.aracKarnesiAtolyeIsEmirBindingSource = new BindingSource(this.components);
      this.aracKarnesiAtolyeIsEmir = new AracKarnesiAtolyeIsEmir();
      this.gridView1 = new GridView();
      this.colArızaNedeni = new GridColumn();
      this.ArizaNedeni = new RepositoryItemSearchLookUpEdit();
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.gridView21 = new GridView();
      this.colGIRISTARIH = new GridColumn();
      this.colCIKISTARIH = new GridColumn();
      this.colBILDIRILENARIZA = new GridColumn();
      this.colBakımYeri = new GridColumn();
      this.BakimYer = new RepositoryItemSearchLookUpEdit();
      this.tBLBAKIMYERIBindingSource = new BindingSource(this.components);
      this.gridView5 = new GridView();
      this.colBAKIMKMSI = new GridColumn();
      this.colSONRAKIBKMKM = new GridColumn();
      this.colSONRAKIBKMTRH = new GridColumn();
      this.colBAKIMSAATI = new GridColumn();
      this.colSONRAKIBKMSAAT = new GridColumn();
      this.colYAPILANBAKIMOZETI = new GridColumn();
      this.colARACID = new GridColumn();
      this.colİşEmriKod = new GridColumn();
      this.colIsEmriID = new GridColumn();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl4 = new GridControl();
      this.dataTable1BindingSource4 = new BindingSource(this.components);
      this.aracKarnesiYapilanBakimlarBindingSource = new BindingSource(this.components);
      this.aracKarnesiYapilanBakimlar = new AracKarnesiYapilanBakimlar();
      this.gridView4 = new GridView();
      this.colARACID2 = new GridColumn();
      this.colISEMRIID1 = new GridColumn();
      this.colID2 = new GridColumn();
      this.colİşEmriKod1 = new GridColumn();
      this.colGIRISTARIH2 = new GridColumn();
      this.colCIKISTARIH2 = new GridColumn();
      this.colATOLYEID = new GridColumn();
      this.AtolyeAdi = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.gridView11 = new GridView();
      this.colBAKIMYAPUSTAID = new GridColumn();
      this.BakimYapanUsta = new RepositoryItemSearchLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.gridView13 = new GridView();
      this.colBAKIMGRUBUID = new GridColumn();
      this.BakimGrubu = new RepositoryItemSearchLookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.gridView12 = new GridView();
      this.colYAPILANBAKIM = new GridColumn();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.tabNavigationPage2 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.aracKarnesiYagIsEmriBindingSource = new BindingSource(this.components);
      this.aracKarnesiYagIsEmri = new AracKarnesiYagIsEmri();
      this.gridView3 = new GridView();
      this.colID1 = new GridColumn();
      this.colIsEmriKod = new GridColumn();
      this.colGIRISTARIH1 = new GridColumn();
      this.colCIKISTARIH1 = new GridColumn();
      this.colBILDIRILENARIZA1 = new GridColumn();
      this.colBakımYeri1 = new GridColumn();
      this.BakimYeri = new RepositoryItemSearchLookUpEdit();
      this.tBLBAKIMYERIBindingSource1 = new BindingSource(this.components);
      this.gridView6 = new GridView();
      this.colBAKIMKMSI1 = new GridColumn();
      this.colSONRAKIBKMKM1 = new GridColumn();
      this.colSONRAKIBKMTRH1 = new GridColumn();
      this.colBAKIMSAATI1 = new GridColumn();
      this.colSONRAKIBKMSAAT1 = new GridColumn();
      this.colYAPILANBAKIMOZETI1 = new GridColumn();
      this.colARACID1 = new GridColumn();
      this.colBELDBIRIMID = new GridColumn();
      this.BirimAdi = new RepositoryItemSearchLookUpEdit();
      this.gridView10 = new GridView();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.simpleButton1 = new SimpleButton();
      this.tabPane1 = new TabPane();
      this.tabNavigationPage4 = new TabNavigationPage();
      this.gridControl6 = new GridControl();
      this.dataTable1BindingSource2 = new BindingSource(this.components);
      this.aracKarnesiKullanılanMalzemeler = new AracKarnesiKullanılanMalzemeler();
      this.gridView14 = new GridView();
      this.colIsEmriKod2 = new GridColumn();
      this.colIslemTipi = new GridColumn();
      this.IslemTipi = new RepositoryItemSearchLookUpEdit();
      this.tBLISLEMTIPIBindingSource = new BindingSource(this.components);
      this.gridView16 = new GridView();
      this.colFisKod = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.MalzemeId = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.gridView15 = new GridView();
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colMALZSERINO = new GridColumn();
      this.colDEGISIMKMSI = new GridColumn();
      this.colSONRAKIDEGKM = new GridColumn();
      this.colDEPOID = new GridColumn();
      this.Depo = new RepositoryItemSearchLookUpEdit();
      this.tBLMALZDEPOBindingSource = new BindingSource(this.components);
      this.gridView17 = new GridView();
      this.colALANUSTAID = new GridColumn();
      this.AlanUsta = new RepositoryItemSearchLookUpEdit();
      this.gridView18 = new GridView();
      this.colARACID3 = new GridColumn();
      this.colDepoFisHrktId = new GridColumn();
      this.colDepoFisId = new GridColumn();
      this.colISEMRIID2 = new GridColumn();
      this.tabNavigationPage5 = new TabNavigationPage();
      this.gridControl7 = new GridControl();
      this.dataTable1BindingSource3 = new BindingSource(this.components);
      this.aracKarnesiMalzemeToplamlariBindingSource = new BindingSource(this.components);
      this.aracKarnesiMalzemeToplamlari = new AracKarnesiMalzemeToplamlari();
      this.gridView19 = new GridView();
      this.colDepoFisHrktID1 = new GridColumn();
      this.colMALZEMEID1 = new GridColumn();
      this.MalzemeAdi = new RepositoryItemSearchLookUpEdit();
      this.gridView20 = new GridView();
      this.colMIKTAR1 = new GridColumn();
      this.colFIYAT1 = new GridColumn();
      this.colTUTAR1 = new GridColumn();
      this.colDepoFisID1 = new GridColumn();
      this.colIsEmriId3 = new GridColumn();
      this.colARACID4 = new GridColumn();
      this.layoutControl1 = new LayoutControl();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.Model.AracKarnesiListeTableAdapters.TBLARACLARTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLARACGRUBUTableAdapter = new TBLARACGRUBUTableAdapter();
      this.tBLARACGRUBU2TableAdapter = new TBLARACGRUBU2TableAdapter();
      this.tBLISEMRITableAdapter = new Makina_Ikmal.Model.AracKarnesiAtolyeIsEmirTableAdapters.TBLISEMRITableAdapter();
      this.tBLBAKIMYERITableAdapter = new TBLBAKIMYERITableAdapter();
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.AracKarnesiYagIsEmriTableAdapters.DataTable1TableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.AracKarnesiYapilanBakimlarTableAdapters.DataTable1TableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.dataTable1TableAdapter2 = new Makina_Ikmal.Model.AracKarnesiKullanılanMalzemelerTableAdapters.DataTable1TableAdapter();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLISLEMTIPITableAdapter = new TBLISLEMTIPITableAdapter();
      this.tBLMALZDEPOTableAdapter = new TBLMALZDEPOTableAdapter();
      this.dataTable1TableAdapter3 = new Makina_Ikmal.Model.AracKarnesiMalzemeToplamlariTableAdapters.DataTable1TableAdapter();
      this.tAHARIZANEDENITableAdapter = new TAHARIZANEDENITableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl5.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      ((ISupportInitialize) this.aracKarnesiListeBindingSource).BeginInit();
      this.aracKarnesiListe.BeginInit();
      this.gridView7.BeginInit();
      this.Birim.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.AnaGrup.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).BeginInit();
      this.gridView8.BeginInit();
      this.AltGrup.BeginInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).BeginInit();
      this.gridView9.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      ((ISupportInitialize) this.aracKarnesiAtolyeIsEmirBindingSource).BeginInit();
      this.aracKarnesiAtolyeIsEmir.BeginInit();
      this.gridView1.BeginInit();
      this.ArizaNedeni.BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
      this.gridView21.BeginInit();
      this.BakimYer.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).BeginInit();
      this.gridView5.BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource4).BeginInit();
      ((ISupportInitialize) this.aracKarnesiYapilanBakimlarBindingSource).BeginInit();
      this.aracKarnesiYapilanBakimlar.BeginInit();
      this.gridView4.BeginInit();
      this.AtolyeAdi.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.gridView11.BeginInit();
      this.BakimYapanUsta.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.gridView13.BeginInit();
      this.BakimGrubu.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.gridView12.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.aracKarnesiYagIsEmriBindingSource).BeginInit();
      this.aracKarnesiYagIsEmri.BeginInit();
      this.gridView3.BeginInit();
      this.BakimYeri.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource1).BeginInit();
      this.gridView6.BeginInit();
      this.BirimAdi.BeginInit();
      this.gridView10.BeginInit();
      this.tabNavigationPage1.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView2.BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.tabNavigationPage4.SuspendLayout();
      this.gridControl6.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      this.aracKarnesiKullanılanMalzemeler.BeginInit();
      this.gridView14.BeginInit();
      this.IslemTipi.BeginInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).BeginInit();
      this.gridView16.BeginInit();
      this.MalzemeId.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.gridView15.BeginInit();
      this.Depo.BeginInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).BeginInit();
      this.gridView17.BeginInit();
      this.AlanUsta.BeginInit();
      this.gridView18.BeginInit();
      this.tabNavigationPage5.SuspendLayout();
      this.gridControl7.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource3).BeginInit();
      ((ISupportInitialize) this.aracKarnesiMalzemeToplamlariBindingSource).BeginInit();
      this.aracKarnesiMalzemeToplamlari.BeginInit();
      this.gridView19.BeginInit();
      this.MalzemeAdi.BeginInit();
      this.gridView20.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
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
      this.ribbonControl1.Items.AddRange(new BarItem[28]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
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
        (BarItem) this.barButtonItem20,
        (BarItem) this.barButtonItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 29;
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
      this.ribbonControl1.Size = new Size(1519, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
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
      this.barEditItem1.AccessibleDescription = "Kayıt Bul...";
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
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl5;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl5.DataSource = (object) this.tBLARACLARBindingSource;
      this.gridControl5.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
      this.gridControl5.Location = new Point(16, 14);
      this.gridControl5.MainView = (BaseView) this.gridView7;
      this.gridControl5.Margin = new Padding(4, 4, 4, 4);
      this.gridControl5.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl5.Name = "gridControl5";
      this.gridControl5.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.Birim,
        (RepositoryItem) this.AnaGrup,
        (RepositoryItem) this.AltGrup
      });
      this.gridControl5.Size = new Size(1487, 422);
      this.gridControl5.TabIndex = 4;
      this.gridControl5.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView7
      });
      this.gridControl5.Click += new EventHandler(this.gridControl5_Click);
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.aracKarnesiListeBindingSource;
      this.aracKarnesiListeBindingSource.DataSource = (object) this.aracKarnesiListe;
      this.aracKarnesiListeBindingSource.Position = 0;
      this.aracKarnesiListe.DataSetName = "AracKarnesiListe";
      this.aracKarnesiListe.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView7.Columns.AddRange(new GridColumn[9]
      {
        this.colBirimAdı,
        this.colPLAKA,
        this.colARACACIKLAMA2,
        this.colAnaGrup,
        this.colAltGrup,
        this.colB_Sayısı,
        this.colID,
        this.colRESIMON,
        this.colRESİMARKA
      });
      this.gridView7.DetailHeight = 431;
      this.gridView7.GridControl = this.gridControl5;
      this.gridView7.Name = "gridView7";
      this.gridView7.Click += new EventHandler(this.gridView7_Click);
      this.colBirimAdı.ColumnEdit = (RepositoryItem) this.Birim;
      this.colBirimAdı.FieldName = "Birim Adı";
      this.colBirimAdı.MinWidth = 27;
      this.colBirimAdı.Name = "colBirimAdı";
      this.colBirimAdı.OptionsColumn.AllowEdit = false;
      this.colBirimAdı.OptionsColumn.ReadOnly = true;
      this.colBirimAdı.Visible = true;
      this.colBirimAdı.VisibleIndex = 0;
      this.colBirimAdı.Width = 100;
      this.Birim.AutoHeight = false;
      this.Birim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Birim.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.Birim.DisplayMember = "BELDBIRIMADI";
      this.Birim.Name = "Birim";
      this.Birim.NullText = "";
      this.Birim.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.Birim.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 431;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 27;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 100;
      this.colARACACIKLAMA2.Caption = "Araç Açıklama";
      this.colARACACIKLAMA2.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA2.MinWidth = 27;
      this.colARACACIKLAMA2.Name = "colARACACIKLAMA2";
      this.colARACACIKLAMA2.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA2.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA2.Visible = true;
      this.colARACACIKLAMA2.VisibleIndex = 2;
      this.colARACACIKLAMA2.Width = 100;
      this.colAnaGrup.ColumnEdit = (RepositoryItem) this.AnaGrup;
      this.colAnaGrup.FieldName = "Ana Grup";
      this.colAnaGrup.MinWidth = 27;
      this.colAnaGrup.Name = "colAnaGrup";
      this.colAnaGrup.OptionsColumn.AllowEdit = false;
      this.colAnaGrup.OptionsColumn.ReadOnly = true;
      this.colAnaGrup.Visible = true;
      this.colAnaGrup.VisibleIndex = 3;
      this.colAnaGrup.Width = 100;
      this.AnaGrup.AutoHeight = false;
      this.AnaGrup.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AnaGrup.DataSource = (object) this.tBLARACGRUBUBindingSource;
      this.AnaGrup.DisplayMember = "GRUPADI";
      this.AnaGrup.Name = "AnaGrup";
      this.AnaGrup.NullText = "";
      this.AnaGrup.PopupView = (ColumnView) this.gridView8;
      this.AnaGrup.ValueMember = "ID";
      this.tBLARACGRUBUBindingSource.DataMember = "TBLARACGRUBU";
      this.tBLARACGRUBUBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView8.DetailHeight = 431;
      this.gridView8.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView8.Name = "gridView8";
      this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView8.OptionsView.ShowGroupPanel = false;
      this.colAltGrup.ColumnEdit = (RepositoryItem) this.AltGrup;
      this.colAltGrup.FieldName = "Alt Grup";
      this.colAltGrup.MinWidth = 27;
      this.colAltGrup.Name = "colAltGrup";
      this.colAltGrup.OptionsColumn.AllowEdit = false;
      this.colAltGrup.OptionsColumn.ReadOnly = true;
      this.colAltGrup.Visible = true;
      this.colAltGrup.VisibleIndex = 4;
      this.colAltGrup.Width = 100;
      this.AltGrup.AutoHeight = false;
      this.AltGrup.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AltGrup.DataSource = (object) this.tBLARACGRUBU2BindingSource;
      this.AltGrup.DisplayMember = "GRUPADI";
      this.AltGrup.Name = "AltGrup";
      this.AltGrup.NullText = "";
      this.AltGrup.PopupView = (ColumnView) this.gridView9;
      this.AltGrup.ValueMember = "ID";
      this.tBLARACGRUBU2BindingSource.DataMember = "TBLARACGRUBU2";
      this.tBLARACGRUBU2BindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView9.DetailHeight = 431;
      this.gridView9.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView9.Name = "gridView9";
      this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView9.OptionsView.ShowGroupPanel = false;
      this.colB_Sayısı.FieldName = "B_ Sayısı";
      this.colB_Sayısı.MinWidth = 27;
      this.colB_Sayısı.Name = "colB_Sayısı";
      this.colB_Sayısı.OptionsColumn.AllowEdit = false;
      this.colB_Sayısı.OptionsColumn.ReadOnly = true;
      this.colB_Sayısı.Visible = true;
      this.colB_Sayısı.VisibleIndex = 5;
      this.colB_Sayısı.Width = 100;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 27;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 100;
      this.colRESIMON.Caption = "Resim Ön";
      this.colRESIMON.FieldName = "RESIMON";
      this.colRESIMON.MinWidth = 27;
      this.colRESIMON.Name = "colRESIMON";
      this.colRESIMON.OptionsColumn.AllowEdit = false;
      this.colRESIMON.OptionsColumn.ReadOnly = true;
      this.colRESIMON.Visible = true;
      this.colRESIMON.VisibleIndex = 6;
      this.colRESIMON.Width = 100;
      this.colRESİMARKA.Caption = "Resim Arka";
      this.colRESİMARKA.FieldName = "RESİMARKA";
      this.colRESİMARKA.MinWidth = 27;
      this.colRESİMARKA.Name = "colRESİMARKA";
      this.colRESİMARKA.OptionsColumn.AllowEdit = false;
      this.colRESİMARKA.OptionsColumn.ReadOnly = true;
      this.colRESİMARKA.Visible = true;
      this.colRESİMARKA.VisibleIndex = 7;
      this.colRESİMARKA.Width = 100;
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
      this.barButtonItem1.Caption = "Karne Yazdır";
      this.barButtonItem1.Id = 28;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridControl1.DataSource = (object) this.tBLISEMRIBindingSource;
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
        (RepositoryItem) this.BakimYer,
        (RepositoryItem) this.ArizaNedeni
      });
      this.gridControl1.Size = new Size(1487, 366);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.aracKarnesiAtolyeIsEmirBindingSource;
      this.aracKarnesiAtolyeIsEmirBindingSource.DataSource = (object) this.aracKarnesiAtolyeIsEmir;
      this.aracKarnesiAtolyeIsEmirBindingSource.Position = 0;
      this.aracKarnesiAtolyeIsEmir.DataSetName = "AracKarnesiAtolyeIsEmir";
      this.aracKarnesiAtolyeIsEmir.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView1.Columns.AddRange(new GridColumn[14]
      {
        this.colArızaNedeni,
        this.colGIRISTARIH,
        this.colCIKISTARIH,
        this.colBILDIRILENARIZA,
        this.colBakımYeri,
        this.colBAKIMKMSI,
        this.colSONRAKIBKMKM,
        this.colSONRAKIBKMTRH,
        this.colBAKIMSAATI,
        this.colSONRAKIBKMSAAT,
        this.colYAPILANBAKIMOZETI,
        this.colARACID,
        this.colİşEmriKod,
        this.colIsEmriID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colSONRAKIBKMKM, ColumnSortOrder.Descending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colArızaNedeni.ColumnEdit = (RepositoryItem) this.ArizaNedeni;
      this.colArızaNedeni.FieldName = "Arıza Nedeni";
      this.colArızaNedeni.MinWidth = 27;
      this.colArızaNedeni.Name = "colArızaNedeni";
      this.colArızaNedeni.OptionsColumn.AllowEdit = false;
      this.colArızaNedeni.OptionsColumn.ReadOnly = true;
      this.colArızaNedeni.Visible = true;
      this.colArızaNedeni.VisibleIndex = 0;
      this.colArızaNedeni.Width = 151;
      this.ArizaNedeni.AutoHeight = false;
      this.ArizaNedeni.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ArizaNedeni.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.ArizaNedeni.DisplayMember = "ARIZANEDENI";
      this.ArizaNedeni.Name = "ArizaNedeni";
      this.ArizaNedeni.NullText = "";
      this.ArizaNedeni.PopupView = (ColumnView) this.gridView21;
      this.ArizaNedeni.ValueMember = "ID";
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView21.DetailHeight = 431;
      this.gridView21.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView21.Name = "gridView21";
      this.gridView21.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView21.OptionsView.ShowGroupPanel = false;
      this.colGIRISTARIH.Caption = "Giriş Tarihi";
      this.colGIRISTARIH.FieldName = "GIRISTARIH";
      this.colGIRISTARIH.MinWidth = 27;
      this.colGIRISTARIH.Name = "colGIRISTARIH";
      this.colGIRISTARIH.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH.Visible = true;
      this.colGIRISTARIH.VisibleIndex = 2;
      this.colGIRISTARIH.Width = 151;
      this.colCIKISTARIH.Caption = "Çıkış Tarihi";
      this.colCIKISTARIH.FieldName = "CIKISTARIH";
      this.colCIKISTARIH.MinWidth = 27;
      this.colCIKISTARIH.Name = "colCIKISTARIH";
      this.colCIKISTARIH.OptionsColumn.AllowEdit = false;
      this.colCIKISTARIH.OptionsColumn.ReadOnly = true;
      this.colCIKISTARIH.Visible = true;
      this.colCIKISTARIH.VisibleIndex = 3;
      this.colCIKISTARIH.Width = 148;
      this.colBILDIRILENARIZA.Caption = "Bildirilen Arıza";
      this.colBILDIRILENARIZA.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA.MinWidth = 27;
      this.colBILDIRILENARIZA.Name = "colBILDIRILENARIZA";
      this.colBILDIRILENARIZA.OptionsColumn.AllowEdit = false;
      this.colBILDIRILENARIZA.OptionsColumn.ReadOnly = true;
      this.colBILDIRILENARIZA.Visible = true;
      this.colBILDIRILENARIZA.VisibleIndex = 4;
      this.colBILDIRILENARIZA.Width = 205;
      this.colBakımYeri.ColumnEdit = (RepositoryItem) this.BakimYer;
      this.colBakımYeri.FieldName = "Bakım Yeri";
      this.colBakımYeri.MinWidth = 27;
      this.colBakımYeri.Name = "colBakımYeri";
      this.colBakımYeri.OptionsColumn.AllowEdit = false;
      this.colBakımYeri.OptionsColumn.ReadOnly = true;
      this.colBakımYeri.Visible = true;
      this.colBakımYeri.VisibleIndex = 5;
      this.colBakımYeri.Width = 132;
      this.BakimYer.AutoHeight = false;
      this.BakimYer.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BakimYer.DataSource = (object) this.tBLBAKIMYERIBindingSource;
      this.BakimYer.DisplayMember = "ADI";
      this.BakimYer.Name = "BakimYer";
      this.BakimYer.NullText = "";
      this.BakimYer.PopupView = (ColumnView) this.gridView5;
      this.BakimYer.ValueMember = "ID";
      this.tBLBAKIMYERIBindingSource.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView5.DetailHeight = 431;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.colBAKIMKMSI.Caption = "Bakım KM'si";
      this.colBAKIMKMSI.FieldName = "BAKIMKMSI";
      this.colBAKIMKMSI.MinWidth = 27;
      this.colBAKIMKMSI.Name = "colBAKIMKMSI";
      this.colBAKIMKMSI.OptionsColumn.AllowEdit = false;
      this.colBAKIMKMSI.OptionsColumn.ReadOnly = true;
      this.colBAKIMKMSI.Visible = true;
      this.colBAKIMKMSI.VisibleIndex = 6;
      this.colBAKIMKMSI.Width = 141;
      this.colSONRAKIBKMKM.Caption = "Sonraki Bakım KM'si";
      this.colSONRAKIBKMKM.FieldName = "SONRAKIBKMKM";
      this.colSONRAKIBKMKM.MinWidth = 27;
      this.colSONRAKIBKMKM.Name = "colSONRAKIBKMKM";
      this.colSONRAKIBKMKM.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMKM.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMKM.Visible = true;
      this.colSONRAKIBKMKM.VisibleIndex = 7;
      this.colSONRAKIBKMKM.Width = 215;
      this.colSONRAKIBKMTRH.Caption = "Sonraki Bakım Tarihi";
      this.colSONRAKIBKMTRH.FieldName = "SONRAKIBKMTRH";
      this.colSONRAKIBKMTRH.MinWidth = 27;
      this.colSONRAKIBKMTRH.Name = "colSONRAKIBKMTRH";
      this.colSONRAKIBKMTRH.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMTRH.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMTRH.Visible = true;
      this.colSONRAKIBKMTRH.VisibleIndex = 8;
      this.colSONRAKIBKMTRH.Width = 203;
      this.colBAKIMSAATI.Caption = "Bakım Saati";
      this.colBAKIMSAATI.FieldName = "BAKIMSAATI";
      this.colBAKIMSAATI.MinWidth = 27;
      this.colBAKIMSAATI.Name = "colBAKIMSAATI";
      this.colBAKIMSAATI.OptionsColumn.AllowEdit = false;
      this.colBAKIMSAATI.OptionsColumn.ReadOnly = true;
      this.colBAKIMSAATI.Visible = true;
      this.colBAKIMSAATI.VisibleIndex = 9;
      this.colBAKIMSAATI.Width = 156;
      this.colSONRAKIBKMSAAT.Caption = "Sonraki Bakım Saati";
      this.colSONRAKIBKMSAAT.FieldName = "SONRAKIBKMSAAT";
      this.colSONRAKIBKMSAAT.MinWidth = 27;
      this.colSONRAKIBKMSAAT.Name = "colSONRAKIBKMSAAT";
      this.colSONRAKIBKMSAAT.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMSAAT.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMSAAT.Visible = true;
      this.colSONRAKIBKMSAAT.VisibleIndex = 10;
      this.colSONRAKIBKMSAAT.Width = 216;
      this.colYAPILANBAKIMOZETI.Caption = "Yapılan Bakım Özeti";
      this.colYAPILANBAKIMOZETI.FieldName = "YAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.MinWidth = 27;
      this.colYAPILANBAKIMOZETI.Name = "colYAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIMOZETI.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIMOZETI.Visible = true;
      this.colYAPILANBAKIMOZETI.VisibleIndex = 11;
      this.colYAPILANBAKIMOZETI.Width = 243;
      this.colARACID.Caption = "Plaka";
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 27;
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Width = 100;
      this.colİşEmriKod.FieldName = "İş Emri Kod";
      this.colİşEmriKod.MinWidth = 27;
      this.colİşEmriKod.Name = "colİşEmriKod";
      this.colİşEmriKod.OptionsColumn.AllowEdit = false;
      this.colİşEmriKod.OptionsColumn.ReadOnly = true;
      this.colİşEmriKod.Visible = true;
      this.colİşEmriKod.VisibleIndex = 1;
      this.colİşEmriKod.Width = 141;
      this.colIsEmriID.FieldName = "IsEmriID";
      this.colIsEmriID.MinWidth = 27;
      this.colIsEmriID.Name = "colIsEmriID";
      this.colIsEmriID.OptionsColumn.AllowEdit = false;
      this.colIsEmriID.OptionsColumn.ReadOnly = true;
      this.colIsEmriID.Width = 100;
      this.tabNavigationPage3.Caption = "Yapılan Bakımlar";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1487, 384);
      this.tabNavigationPage3.Click += new EventHandler(this.tabNavigationPage3_Click);
      this.gridControl4.DataSource = (object) this.dataTable1BindingSource4;
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.Margin = new Padding(3, 2, 3, 2);
      this.gridControl4.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl4.Name = "gridControl4";
      this.gridControl4.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.AtolyeAdi,
        (RepositoryItem) this.BakimGrubu,
        (RepositoryItem) this.BakimYapanUsta
      });
      this.gridControl4.Size = new Size(1487, 384);
      this.gridControl4.TabIndex = 7;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.dataTable1BindingSource4.DataMember = "DataTable1";
      this.dataTable1BindingSource4.DataSource = (object) this.aracKarnesiYapilanBakimlarBindingSource;
      this.aracKarnesiYapilanBakimlarBindingSource.DataSource = (object) this.aracKarnesiYapilanBakimlar;
      this.aracKarnesiYapilanBakimlarBindingSource.Position = 0;
      this.aracKarnesiYapilanBakimlar.DataSetName = "AracKarnesiYapilanBakimlar";
      this.aracKarnesiYapilanBakimlar.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView4.Columns.AddRange(new GridColumn[10]
      {
        this.colARACID2,
        this.colISEMRIID1,
        this.colID2,
        this.colİşEmriKod1,
        this.colGIRISTARIH2,
        this.colCIKISTARIH2,
        this.colATOLYEID,
        this.colBAKIMYAPUSTAID,
        this.colBAKIMGRUBUID,
        this.colYAPILANBAKIM
      });
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.colARACID2.FieldName = "ARACID";
      this.colARACID2.MinWidth = 27;
      this.colARACID2.Name = "colARACID2";
      this.colARACID2.OptionsColumn.AllowEdit = false;
      this.colARACID2.OptionsColumn.ReadOnly = true;
      this.colARACID2.Width = 100;
      this.colISEMRIID1.FieldName = "ISEMRIID";
      this.colISEMRIID1.MinWidth = 27;
      this.colISEMRIID1.Name = "colISEMRIID1";
      this.colISEMRIID1.OptionsColumn.AllowEdit = false;
      this.colISEMRIID1.OptionsColumn.ReadOnly = true;
      this.colISEMRIID1.Width = 100;
      this.colID2.FieldName = "ID";
      this.colID2.MinWidth = 27;
      this.colID2.Name = "colID2";
      this.colID2.OptionsColumn.AllowEdit = false;
      this.colID2.OptionsColumn.ReadOnly = true;
      this.colID2.Width = 100;
      this.colİşEmriKod1.FieldName = "İş Emri Kod";
      this.colİşEmriKod1.MinWidth = 27;
      this.colİşEmriKod1.Name = "colİşEmriKod1";
      this.colİşEmriKod1.OptionsColumn.AllowEdit = false;
      this.colİşEmriKod1.OptionsColumn.ReadOnly = true;
      this.colİşEmriKod1.Visible = true;
      this.colİşEmriKod1.VisibleIndex = 0;
      this.colİşEmriKod1.Width = 100;
      this.colGIRISTARIH2.FieldName = "GIRISTARIH";
      this.colGIRISTARIH2.MinWidth = 27;
      this.colGIRISTARIH2.Name = "colGIRISTARIH2";
      this.colGIRISTARIH2.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH2.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH2.Visible = true;
      this.colGIRISTARIH2.VisibleIndex = 1;
      this.colGIRISTARIH2.Width = 100;
      this.colCIKISTARIH2.FieldName = "CIKISTARIH";
      this.colCIKISTARIH2.MinWidth = 27;
      this.colCIKISTARIH2.Name = "colCIKISTARIH2";
      this.colCIKISTARIH2.OptionsColumn.AllowEdit = false;
      this.colCIKISTARIH2.OptionsColumn.ReadOnly = true;
      this.colCIKISTARIH2.Visible = true;
      this.colCIKISTARIH2.VisibleIndex = 2;
      this.colCIKISTARIH2.Width = 100;
      this.colATOLYEID.ColumnEdit = (RepositoryItem) this.AtolyeAdi;
      this.colATOLYEID.FieldName = "ATOLYEID";
      this.colATOLYEID.MinWidth = 27;
      this.colATOLYEID.Name = "colATOLYEID";
      this.colATOLYEID.OptionsColumn.AllowEdit = false;
      this.colATOLYEID.OptionsColumn.ReadOnly = true;
      this.colATOLYEID.Visible = true;
      this.colATOLYEID.VisibleIndex = 3;
      this.colATOLYEID.Width = 100;
      this.AtolyeAdi.AutoHeight = false;
      this.AtolyeAdi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AtolyeAdi.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.AtolyeAdi.DisplayMember = "BOLUMADI";
      this.AtolyeAdi.Name = "AtolyeAdi";
      this.AtolyeAdi.NullText = "";
      this.AtolyeAdi.PopupView = (ColumnView) this.gridView11;
      this.AtolyeAdi.ValueMember = "ID";
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView11.DetailHeight = 431;
      this.gridView11.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView11.Name = "gridView11";
      this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView11.OptionsView.ShowGroupPanel = false;
      this.colBAKIMYAPUSTAID.ColumnEdit = (RepositoryItem) this.BakimYapanUsta;
      this.colBAKIMYAPUSTAID.FieldName = "BAKIMYAPUSTAID";
      this.colBAKIMYAPUSTAID.MinWidth = 27;
      this.colBAKIMYAPUSTAID.Name = "colBAKIMYAPUSTAID";
      this.colBAKIMYAPUSTAID.OptionsColumn.AllowEdit = false;
      this.colBAKIMYAPUSTAID.OptionsColumn.ReadOnly = true;
      this.colBAKIMYAPUSTAID.Visible = true;
      this.colBAKIMYAPUSTAID.VisibleIndex = 4;
      this.colBAKIMYAPUSTAID.Width = 100;
      this.BakimYapanUsta.AutoHeight = false;
      this.BakimYapanUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BakimYapanUsta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.BakimYapanUsta.DisplayMember = "USTAADISOYADI";
      this.BakimYapanUsta.Name = "BakimYapanUsta";
      this.BakimYapanUsta.PopupView = (ColumnView) this.gridView13;
      this.BakimYapanUsta.ValueMember = "ID";
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView13.DetailHeight = 431;
      this.gridView13.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView13.Name = "gridView13";
      this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView13.OptionsView.ShowGroupPanel = false;
      this.colBAKIMGRUBUID.ColumnEdit = (RepositoryItem) this.BakimGrubu;
      this.colBAKIMGRUBUID.FieldName = "BAKIMGRUBUID";
      this.colBAKIMGRUBUID.MinWidth = 27;
      this.colBAKIMGRUBUID.Name = "colBAKIMGRUBUID";
      this.colBAKIMGRUBUID.OptionsColumn.AllowEdit = false;
      this.colBAKIMGRUBUID.OptionsColumn.ReadOnly = true;
      this.colBAKIMGRUBUID.Visible = true;
      this.colBAKIMGRUBUID.VisibleIndex = 5;
      this.colBAKIMGRUBUID.Width = 100;
      this.BakimGrubu.AutoHeight = false;
      this.BakimGrubu.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BakimGrubu.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.BakimGrubu.DisplayMember = "GRUPADI";
      this.BakimGrubu.Name = "BakimGrubu";
      this.BakimGrubu.PopupView = (ColumnView) this.gridView12;
      this.BakimGrubu.ValueMember = "ID";
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView12.DetailHeight = 431;
      this.gridView12.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView12.Name = "gridView12";
      this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView12.OptionsView.ShowGroupPanel = false;
      this.colYAPILANBAKIM.FieldName = "YAPILANBAKIM";
      this.colYAPILANBAKIM.MinWidth = 27;
      this.colYAPILANBAKIM.Name = "colYAPILANBAKIM";
      this.colYAPILANBAKIM.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIM.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIM.Visible = true;
      this.colYAPILANBAKIM.VisibleIndex = 6;
      this.colYAPILANBAKIM.Width = 100;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.aracKarnesiYapilanBakimlar;
      this.tabNavigationPage2.Caption = "Yağ İş Emirleri";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1487, 384);
      this.tabNavigationPage2.Click += new EventHandler(this.tabNavigationPage2_Click);
      this.gridControl3.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(3, 2, 3, 2);
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.BakimYeri,
        (RepositoryItem) this.BirimAdi
      });
      this.gridControl3.Size = new Size(1487, 384);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.aracKarnesiYagIsEmriBindingSource;
      this.aracKarnesiYagIsEmriBindingSource.DataSource = (object) this.aracKarnesiYagIsEmri;
      this.aracKarnesiYagIsEmriBindingSource.Position = 0;
      this.aracKarnesiYagIsEmri.DataSetName = "AracKarnesiYagIsEmri";
      this.aracKarnesiYagIsEmri.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.gridView3.Columns.AddRange(new GridColumn[14]
      {
        this.colID1,
        this.colIsEmriKod,
        this.colGIRISTARIH1,
        this.colCIKISTARIH1,
        this.colBILDIRILENARIZA1,
        this.colBakımYeri1,
        this.colBAKIMKMSI1,
        this.colSONRAKIBKMKM1,
        this.colSONRAKIBKMTRH1,
        this.colBAKIMSAATI1,
        this.colSONRAKIBKMSAAT1,
        this.colYAPILANBAKIMOZETI1,
        this.colARACID1,
        this.colBELDBIRIMID
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsPrint.AutoWidth = false;
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colARACID1, ColumnSortOrder.Ascending)
      });
      this.colID1.FieldName = "ID";
      this.colID1.MinWidth = 27;
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Width = 100;
      this.colIsEmriKod.FieldName = "IsEmriKod";
      this.colIsEmriKod.MinWidth = 27;
      this.colIsEmriKod.Name = "colIsEmriKod";
      this.colIsEmriKod.OptionsColumn.AllowEdit = false;
      this.colIsEmriKod.OptionsColumn.ReadOnly = true;
      this.colIsEmriKod.Visible = true;
      this.colIsEmriKod.VisibleIndex = 0;
      this.colIsEmriKod.Width = 141;
      this.colGIRISTARIH1.Caption = "Giriş Tarihi";
      this.colGIRISTARIH1.FieldName = "GIRISTARIH";
      this.colGIRISTARIH1.MinWidth = 27;
      this.colGIRISTARIH1.Name = "colGIRISTARIH1";
      this.colGIRISTARIH1.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH1.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH1.Visible = true;
      this.colGIRISTARIH1.VisibleIndex = 1;
      this.colGIRISTARIH1.Width = 133;
      this.colCIKISTARIH1.Caption = "Çıkış Tarihi";
      this.colCIKISTARIH1.FieldName = "CIKISTARIH";
      this.colCIKISTARIH1.MinWidth = 27;
      this.colCIKISTARIH1.Name = "colCIKISTARIH1";
      this.colCIKISTARIH1.OptionsColumn.AllowEdit = false;
      this.colCIKISTARIH1.OptionsColumn.ReadOnly = true;
      this.colCIKISTARIH1.Visible = true;
      this.colCIKISTARIH1.VisibleIndex = 2;
      this.colCIKISTARIH1.Width = 129;
      this.colBILDIRILENARIZA1.Caption = "Bildirilen Arıza";
      this.colBILDIRILENARIZA1.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA1.MinWidth = 27;
      this.colBILDIRILENARIZA1.Name = "colBILDIRILENARIZA1";
      this.colBILDIRILENARIZA1.OptionsColumn.AllowEdit = false;
      this.colBILDIRILENARIZA1.OptionsColumn.ReadOnly = true;
      this.colBILDIRILENARIZA1.Visible = true;
      this.colBILDIRILENARIZA1.VisibleIndex = 3;
      this.colBILDIRILENARIZA1.Width = 205;
      this.colBakımYeri1.ColumnEdit = (RepositoryItem) this.BakimYeri;
      this.colBakımYeri1.FieldName = "BakımYeri";
      this.colBakımYeri1.MinWidth = 27;
      this.colBakımYeri1.Name = "colBakımYeri1";
      this.colBakımYeri1.OptionsColumn.AllowEdit = false;
      this.colBakımYeri1.OptionsColumn.ReadOnly = true;
      this.colBakımYeri1.Visible = true;
      this.colBakımYeri1.VisibleIndex = 4;
      this.colBakımYeri1.Width = 132;
      this.BakimYeri.AutoHeight = false;
      this.BakimYeri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BakimYeri.DataSource = (object) this.tBLBAKIMYERIBindingSource1;
      this.BakimYeri.DisplayMember = "ADI";
      this.BakimYeri.Name = "BakimYeri";
      this.BakimYeri.PopupView = (ColumnView) this.gridView6;
      this.BakimYeri.ValueMember = "ID";
      this.tBLBAKIMYERIBindingSource1.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource1.DataSource = (object) this.bellDataSet6;
      this.gridView6.DetailHeight = 431;
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.colBAKIMKMSI1.Caption = "Bakım KM'si";
      this.colBAKIMKMSI1.FieldName = "BAKIMKMSI";
      this.colBAKIMKMSI1.MinWidth = 27;
      this.colBAKIMKMSI1.Name = "colBAKIMKMSI1";
      this.colBAKIMKMSI1.OptionsColumn.AllowEdit = false;
      this.colBAKIMKMSI1.OptionsColumn.ReadOnly = true;
      this.colBAKIMKMSI1.Visible = true;
      this.colBAKIMKMSI1.VisibleIndex = 5;
      this.colBAKIMKMSI1.Width = 141;
      this.colSONRAKIBKMKM1.Caption = "Sonraki Bakım KM'si";
      this.colSONRAKIBKMKM1.FieldName = "SONRAKIBKMKM";
      this.colSONRAKIBKMKM1.MinWidth = 27;
      this.colSONRAKIBKMKM1.Name = "colSONRAKIBKMKM1";
      this.colSONRAKIBKMKM1.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMKM1.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMKM1.Visible = true;
      this.colSONRAKIBKMKM1.VisibleIndex = 6;
      this.colSONRAKIBKMKM1.Width = 189;
      this.colSONRAKIBKMTRH1.Caption = "Sonraki Bakım Tarihi";
      this.colSONRAKIBKMTRH1.FieldName = "SONRAKIBKMTRH";
      this.colSONRAKIBKMTRH1.MinWidth = 27;
      this.colSONRAKIBKMTRH1.Name = "colSONRAKIBKMTRH1";
      this.colSONRAKIBKMTRH1.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMTRH1.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMTRH1.Visible = true;
      this.colSONRAKIBKMTRH1.VisibleIndex = 7;
      this.colSONRAKIBKMTRH1.Width = 228;
      this.colBAKIMSAATI1.Caption = "Bakım Saati";
      this.colBAKIMSAATI1.FieldName = "BAKIMSAATI";
      this.colBAKIMSAATI1.MinWidth = 27;
      this.colBAKIMSAATI1.Name = "colBAKIMSAATI1";
      this.colBAKIMSAATI1.OptionsColumn.AllowEdit = false;
      this.colBAKIMSAATI1.OptionsColumn.ReadOnly = true;
      this.colBAKIMSAATI1.Visible = true;
      this.colBAKIMSAATI1.VisibleIndex = 8;
      this.colBAKIMSAATI1.Width = 165;
      this.colSONRAKIBKMSAAT1.Caption = "Sonraki Bakım Saati";
      this.colSONRAKIBKMSAAT1.FieldName = "SONRAKIBKMSAAT";
      this.colSONRAKIBKMSAAT1.MinWidth = 27;
      this.colSONRAKIBKMSAAT1.Name = "colSONRAKIBKMSAAT1";
      this.colSONRAKIBKMSAAT1.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMSAAT1.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMSAAT1.Visible = true;
      this.colSONRAKIBKMSAAT1.VisibleIndex = 9;
      this.colSONRAKIBKMSAAT1.Width = 241;
      this.colYAPILANBAKIMOZETI1.Caption = "Yapılan Bakım ÖZeti";
      this.colYAPILANBAKIMOZETI1.FieldName = "YAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI1.MinWidth = 27;
      this.colYAPILANBAKIMOZETI1.Name = "colYAPILANBAKIMOZETI1";
      this.colYAPILANBAKIMOZETI1.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIMOZETI1.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIMOZETI1.Visible = true;
      this.colYAPILANBAKIMOZETI1.VisibleIndex = 10;
      this.colYAPILANBAKIMOZETI1.Width = 243;
      this.colARACID1.FieldName = "ARACID";
      this.colARACID1.MinWidth = 27;
      this.colARACID1.Name = "colARACID1";
      this.colARACID1.OptionsColumn.AllowEdit = false;
      this.colARACID1.OptionsColumn.ReadOnly = true;
      this.colARACID1.Width = 135;
      this.colBELDBIRIMID.Caption = "Birim";
      this.colBELDBIRIMID.ColumnEdit = (RepositoryItem) this.BirimAdi;
      this.colBELDBIRIMID.FieldName = "BELDBIRIMID";
      this.colBELDBIRIMID.MinWidth = 27;
      this.colBELDBIRIMID.Name = "colBELDBIRIMID";
      this.colBELDBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBELDBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBELDBIRIMID.Visible = true;
      this.colBELDBIRIMID.VisibleIndex = 11;
      this.colBELDBIRIMID.Width = 160;
      this.BirimAdi.AutoHeight = false;
      this.BirimAdi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BirimAdi.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.BirimAdi.DisplayMember = "BELDBIRIMADI";
      this.BirimAdi.Name = "BirimAdi";
      this.BirimAdi.PopupView = (ColumnView) this.gridView10;
      this.BirimAdi.ValueMember = "ID";
      this.gridView10.DetailHeight = 431;
      this.gridView10.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView10.Name = "gridView10";
      this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView10.OptionsView.ShowGroupPanel = false;
      this.tabNavigationPage1.AccessibleDescription = "";
      this.tabNavigationPage1.Caption = "Atolye İş Emirleri";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(3, 2, 3, 2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1487, 366);
      this.tabNavigationPage1.Click += new EventHandler(this.tabNavigationPage1_Click);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1487, 366);
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
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage4);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage5);
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(16, 440);
      this.tabPane1.Margin = new Padding(3, 2, 3, 2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[5]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3,
        (NavigationPageBase) this.tabNavigationPage4,
        (NavigationPageBase) this.tabNavigationPage5
      });
      this.tabPane1.RegularSize = new Size(1487, 424);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1487, 424);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "Giriş Fiş Hareketleri";
      this.tabNavigationPage4.Caption = "Kullanılan Malzemeler";
      this.tabNavigationPage4.Controls.Add((Control) this.gridControl6);
      this.tabNavigationPage4.Margin = new Padding(4, 4, 4, 4);
      this.tabNavigationPage4.Name = "tabNavigationPage4";
      this.tabNavigationPage4.Size = new Size(1487, 384);
      this.tabNavigationPage4.Click += new EventHandler(this.tabNavigationPage4_Click);
      this.gridControl6.DataSource = (object) this.dataTable1BindingSource2;
      this.gridControl6.Dock = DockStyle.Fill;
      this.gridControl6.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
      this.gridControl6.Location = new Point(0, 0);
      this.gridControl6.MainView = (BaseView) this.gridView14;
      this.gridControl6.Margin = new Padding(4, 4, 4, 4);
      this.gridControl6.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl6.Name = "gridControl6";
      this.gridControl6.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.MalzemeId,
        (RepositoryItem) this.IslemTipi,
        (RepositoryItem) this.Depo,
        (RepositoryItem) this.AlanUsta
      });
      this.gridControl6.Size = new Size(1487, 384);
      this.gridControl6.TabIndex = 0;
      this.gridControl6.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView14
      });
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.aracKarnesiKullanılanMalzemeler;
      this.aracKarnesiKullanılanMalzemeler.DataSetName = "AracKarnesiKullanılanMalzemeler";
      this.aracKarnesiKullanılanMalzemeler.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView14.Columns.AddRange(new GridColumn[17]
      {
        this.colIsEmriKod2,
        this.colIslemTipi,
        this.colFisKod,
        this.colTARIH,
        this.colMALZEMEID,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.colMALZSERINO,
        this.colDEGISIMKMSI,
        this.colSONRAKIDEGKM,
        this.colDEPOID,
        this.colALANUSTAID,
        this.colARACID3,
        this.colDepoFisHrktId,
        this.colDepoFisId,
        this.colISEMRIID2
      });
      this.gridView14.DetailHeight = 431;
      this.gridView14.GridControl = this.gridControl6;
      this.gridView14.Name = "gridView14";
      this.gridView14.OptionsView.ColumnAutoWidth = false;
      this.gridView14.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colDEGISIMKMSI, ColumnSortOrder.Ascending)
      });
      this.colIsEmriKod2.FieldName = "IsEmriKod";
      this.colIsEmriKod2.MinWidth = 27;
      this.colIsEmriKod2.Name = "colIsEmriKod2";
      this.colIsEmriKod2.OptionsColumn.AllowEdit = false;
      this.colIsEmriKod2.OptionsColumn.ReadOnly = true;
      this.colIsEmriKod2.Visible = true;
      this.colIsEmriKod2.VisibleIndex = 0;
      this.colIsEmriKod2.Width = 101;
      this.colIslemTipi.ColumnEdit = (RepositoryItem) this.IslemTipi;
      this.colIslemTipi.FieldName = "IslemTipi";
      this.colIslemTipi.MinWidth = 27;
      this.colIslemTipi.Name = "colIslemTipi";
      this.colIslemTipi.OptionsColumn.AllowEdit = false;
      this.colIslemTipi.OptionsColumn.ReadOnly = true;
      this.colIslemTipi.Visible = true;
      this.colIslemTipi.VisibleIndex = 1;
      this.colIslemTipi.Width = 89;
      this.IslemTipi.AutoHeight = false;
      this.IslemTipi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.IslemTipi.DataSource = (object) this.tBLISLEMTIPIBindingSource;
      this.IslemTipi.DisplayMember = "ISLEMTIPI";
      this.IslemTipi.Name = "IslemTipi";
      this.IslemTipi.PopupView = (ColumnView) this.gridView16;
      this.IslemTipi.ValueMember = "ID";
      this.tBLISLEMTIPIBindingSource.DataMember = "TBLISLEMTIPI";
      this.tBLISLEMTIPIBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView16.DetailHeight = 431;
      this.gridView16.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView16.Name = "gridView16";
      this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView16.OptionsView.ShowGroupPanel = false;
      this.colFisKod.FieldName = "FisKod";
      this.colFisKod.MinWidth = 27;
      this.colFisKod.Name = "colFisKod";
      this.colFisKod.OptionsColumn.AllowEdit = false;
      this.colFisKod.OptionsColumn.ReadOnly = true;
      this.colFisKod.Visible = true;
      this.colFisKod.VisibleIndex = 2;
      this.colFisKod.Width = 76;
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 27;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 3;
      this.colTARIH.Width = 72;
      this.colMALZEMEID.Caption = "Malzeme Adı";
      this.colMALZEMEID.ColumnEdit = (RepositoryItem) this.MalzemeId;
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.MinWidth = 27;
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 4;
      this.colMALZEMEID.Width = 107;
      this.MalzemeId.AutoHeight = false;
      this.MalzemeId.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MalzemeId.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.MalzemeId.DisplayMember = "MALZEMEADI";
      this.MalzemeId.Name = "MalzemeId";
      this.MalzemeId.PopupView = (ColumnView) this.gridView15;
      this.MalzemeId.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView15.DetailHeight = 431;
      this.gridView15.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView15.Name = "gridView15";
      this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView15.OptionsView.ShowGroupPanel = false;
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 27;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 5;
      this.colMIKTAR.Width = 81;
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 27;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 6;
      this.colFIYAT.Width = 69;
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 27;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.OptionsColumn.AllowEdit = false;
      this.colTUTAR.OptionsColumn.ReadOnly = true;
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 7;
      this.colMALZSERINO.Caption = "Malzeme Seri No";
      this.colMALZSERINO.FieldName = "MALZSERINO";
      this.colMALZSERINO.MinWidth = 27;
      this.colMALZSERINO.Name = "colMALZSERINO";
      this.colMALZSERINO.OptionsColumn.AllowEdit = false;
      this.colMALZSERINO.OptionsColumn.ReadOnly = true;
      this.colMALZSERINO.Visible = true;
      this.colMALZSERINO.VisibleIndex = 8;
      this.colMALZSERINO.Width = 116;
      this.colDEGISIMKMSI.Caption = "Değişim KM'si";
      this.colDEGISIMKMSI.FieldName = "DEGISIMKMSI";
      this.colDEGISIMKMSI.MinWidth = 27;
      this.colDEGISIMKMSI.Name = "colDEGISIMKMSI";
      this.colDEGISIMKMSI.OptionsColumn.AllowEdit = false;
      this.colDEGISIMKMSI.OptionsColumn.ReadOnly = true;
      this.colDEGISIMKMSI.Visible = true;
      this.colDEGISIMKMSI.VisibleIndex = 9;
      this.colDEGISIMKMSI.Width = 119;
      this.colSONRAKIDEGKM.Caption = "Sonraki Değişim KM'si";
      this.colSONRAKIDEGKM.FieldName = "SONRAKIDEGKM";
      this.colSONRAKIDEGKM.MinWidth = 27;
      this.colSONRAKIDEGKM.Name = "colSONRAKIDEGKM";
      this.colSONRAKIDEGKM.OptionsColumn.AllowEdit = false;
      this.colSONRAKIDEGKM.OptionsColumn.ReadOnly = true;
      this.colSONRAKIDEGKM.Visible = true;
      this.colSONRAKIDEGKM.VisibleIndex = 10;
      this.colSONRAKIDEGKM.Width = 136;
      this.colDEPOID.Caption = "Depo";
      this.colDEPOID.ColumnEdit = (RepositoryItem) this.Depo;
      this.colDEPOID.FieldName = "DEPOID";
      this.colDEPOID.MinWidth = 27;
      this.colDEPOID.Name = "colDEPOID";
      this.colDEPOID.OptionsColumn.AllowEdit = false;
      this.colDEPOID.OptionsColumn.ReadOnly = true;
      this.colDEPOID.Visible = true;
      this.colDEPOID.VisibleIndex = 11;
      this.colDEPOID.Width = 81;
      this.Depo.AutoHeight = false;
      this.Depo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Depo.DataSource = (object) this.tBLMALZDEPOBindingSource;
      this.Depo.DisplayMember = "DEPOADI";
      this.Depo.Name = "Depo";
      this.Depo.PopupView = (ColumnView) this.gridView17;
      this.Depo.ValueMember = "ID";
      this.tBLMALZDEPOBindingSource.DataMember = "TBLMALZDEPO";
      this.tBLMALZDEPOBindingSource.DataSource = (object) this.bellDataSet6;
      this.gridView17.DetailHeight = 431;
      this.gridView17.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView17.Name = "gridView17";
      this.gridView17.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView17.OptionsView.ShowGroupPanel = false;
      this.colALANUSTAID.Caption = "Alan Usta";
      this.colALANUSTAID.ColumnEdit = (RepositoryItem) this.AlanUsta;
      this.colALANUSTAID.FieldName = "ALANUSTAID";
      this.colALANUSTAID.MinWidth = 27;
      this.colALANUSTAID.Name = "colALANUSTAID";
      this.colALANUSTAID.OptionsColumn.AllowEdit = false;
      this.colALANUSTAID.OptionsColumn.ReadOnly = true;
      this.colALANUSTAID.Visible = true;
      this.colALANUSTAID.VisibleIndex = 12;
      this.colALANUSTAID.Width = 115;
      this.AlanUsta.AutoHeight = false;
      this.AlanUsta.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AlanUsta.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.AlanUsta.DisplayMember = "USTAADISOYADI";
      this.AlanUsta.Name = "AlanUsta";
      this.AlanUsta.PopupView = (ColumnView) this.gridView18;
      this.AlanUsta.ValueMember = "ID";
      this.gridView18.DetailHeight = 431;
      this.gridView18.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView18.Name = "gridView18";
      this.gridView18.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView18.OptionsView.ShowGroupPanel = false;
      this.colARACID3.FieldName = "ARACID";
      this.colARACID3.MinWidth = 27;
      this.colARACID3.Name = "colARACID3";
      this.colARACID3.OptionsColumn.AllowEdit = false;
      this.colARACID3.OptionsColumn.ReadOnly = true;
      this.colARACID3.Width = 83;
      this.colDepoFisHrktId.FieldName = "DepoFisHrktId";
      this.colDepoFisHrktId.MinWidth = 27;
      this.colDepoFisHrktId.Name = "colDepoFisHrktId";
      this.colDepoFisHrktId.OptionsColumn.AllowEdit = false;
      this.colDepoFisHrktId.OptionsColumn.ReadOnly = true;
      this.colDepoFisHrktId.Width = 133;
      this.colDepoFisId.FieldName = "DepoFisId";
      this.colDepoFisId.MinWidth = 27;
      this.colDepoFisId.Name = "colDepoFisId";
      this.colDepoFisId.OptionsColumn.AllowEdit = false;
      this.colDepoFisId.OptionsColumn.ReadOnly = true;
      this.colDepoFisId.Width = 103;
      this.colISEMRIID2.FieldName = "ISEMRIID";
      this.colISEMRIID2.MinWidth = 27;
      this.colISEMRIID2.Name = "colISEMRIID2";
      this.colISEMRIID2.OptionsColumn.AllowEdit = false;
      this.colISEMRIID2.OptionsColumn.ReadOnly = true;
      this.colISEMRIID2.Width = 92;
      this.tabNavigationPage5.Caption = "Malzeme Toplamları";
      this.tabNavigationPage5.Controls.Add((Control) this.gridControl7);
      this.tabNavigationPage5.Margin = new Padding(4, 4, 4, 4);
      this.tabNavigationPage5.Name = "tabNavigationPage5";
      this.tabNavigationPage5.Size = new Size(1487, 384);
      this.tabNavigationPage5.Click += new EventHandler(this.tabNavigationPage5_Click);
      this.gridControl7.DataSource = (object) this.dataTable1BindingSource3;
      this.gridControl7.Dock = DockStyle.Fill;
      this.gridControl7.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
      this.gridControl7.Location = new Point(0, 0);
      this.gridControl7.MainView = (BaseView) this.gridView19;
      this.gridControl7.Margin = new Padding(4, 4, 4, 4);
      this.gridControl7.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl7.Name = "gridControl7";
      this.gridControl7.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.MalzemeAdi
      });
      this.gridControl7.Size = new Size(1487, 384);
      this.gridControl7.TabIndex = 0;
      this.gridControl7.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView19
      });
      this.dataTable1BindingSource3.DataMember = "DataTable1";
      this.dataTable1BindingSource3.DataSource = (object) this.aracKarnesiMalzemeToplamlariBindingSource;
      this.aracKarnesiMalzemeToplamlariBindingSource.DataSource = (object) this.aracKarnesiMalzemeToplamlari;
      this.aracKarnesiMalzemeToplamlariBindingSource.Position = 0;
      this.aracKarnesiMalzemeToplamlari.DataSetName = "AracKarnesiMalzemeToplamlari";
      this.aracKarnesiMalzemeToplamlari.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView19.Columns.AddRange(new GridColumn[8]
      {
        this.colDepoFisHrktID1,
        this.colMALZEMEID1,
        this.colMIKTAR1,
        this.colFIYAT1,
        this.colTUTAR1,
        this.colDepoFisID1,
        this.colIsEmriId3,
        this.colARACID4
      });
      this.gridView19.DetailHeight = 431;
      this.gridView19.GridControl = this.gridControl7;
      this.gridView19.Name = "gridView19";
      this.gridView19.OptionsView.ColumnAutoWidth = false;
      this.colDepoFisHrktID1.FieldName = "DepoFisHrktID";
      this.colDepoFisHrktID1.MinWidth = 27;
      this.colDepoFisHrktID1.Name = "colDepoFisHrktID1";
      this.colDepoFisHrktID1.OptionsColumn.AllowEdit = false;
      this.colDepoFisHrktID1.OptionsColumn.ReadOnly = true;
      this.colDepoFisHrktID1.Width = 100;
      this.colMALZEMEID1.Caption = "Malzeme Adı";
      this.colMALZEMEID1.ColumnEdit = (RepositoryItem) this.MalzemeAdi;
      this.colMALZEMEID1.FieldName = "MALZEMEID";
      this.colMALZEMEID1.MinWidth = 27;
      this.colMALZEMEID1.Name = "colMALZEMEID1";
      this.colMALZEMEID1.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID1.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID1.Visible = true;
      this.colMALZEMEID1.VisibleIndex = 0;
      this.colMALZEMEID1.Width = 181;
      this.MalzemeAdi.AutoHeight = false;
      this.MalzemeAdi.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.MalzemeAdi.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.MalzemeAdi.DisplayMember = "MALZEMEADI";
      this.MalzemeAdi.Name = "MalzemeAdi";
      this.MalzemeAdi.PopupView = (ColumnView) this.gridView20;
      this.MalzemeAdi.ValueMember = "ID";
      this.gridView20.DetailHeight = 431;
      this.gridView20.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView20.Name = "gridView20";
      this.gridView20.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView20.OptionsView.ShowGroupPanel = false;
      this.colMIKTAR1.FieldName = "MIKTAR";
      this.colMIKTAR1.MinWidth = 27;
      this.colMIKTAR1.Name = "colMIKTAR1";
      this.colMIKTAR1.OptionsColumn.AllowEdit = false;
      this.colMIKTAR1.OptionsColumn.ReadOnly = true;
      this.colMIKTAR1.Visible = true;
      this.colMIKTAR1.VisibleIndex = 1;
      this.colMIKTAR1.Width = 108;
      this.colFIYAT1.FieldName = "FIYAT";
      this.colFIYAT1.MinWidth = 27;
      this.colFIYAT1.Name = "colFIYAT1";
      this.colFIYAT1.OptionsColumn.AllowEdit = false;
      this.colFIYAT1.OptionsColumn.ReadOnly = true;
      this.colFIYAT1.Visible = true;
      this.colFIYAT1.VisibleIndex = 2;
      this.colFIYAT1.Width = 120;
      this.colTUTAR1.FieldName = "TUTAR";
      this.colTUTAR1.MinWidth = 27;
      this.colTUTAR1.Name = "colTUTAR1";
      this.colTUTAR1.OptionsColumn.AllowEdit = false;
      this.colTUTAR1.OptionsColumn.ReadOnly = true;
      this.colTUTAR1.Visible = true;
      this.colTUTAR1.VisibleIndex = 3;
      this.colTUTAR1.Width = 207;
      this.colDepoFisID1.FieldName = "DepoFisID";
      this.colDepoFisID1.MinWidth = 27;
      this.colDepoFisID1.Name = "colDepoFisID1";
      this.colDepoFisID1.OptionsColumn.AllowEdit = false;
      this.colDepoFisID1.OptionsColumn.ReadOnly = true;
      this.colDepoFisID1.Width = 100;
      this.colIsEmriId3.FieldName = "IsEmriId";
      this.colIsEmriId3.MinWidth = 27;
      this.colIsEmriId3.Name = "colIsEmriId3";
      this.colIsEmriId3.OptionsColumn.AllowEdit = false;
      this.colIsEmriId3.OptionsColumn.ReadOnly = true;
      this.colIsEmriId3.Width = 100;
      this.colARACID4.FieldName = "ARACID";
      this.colARACID4.MinWidth = 27;
      this.colARACID4.Name = "colARACID4";
      this.colARACID4.OptionsColumn.AllowEdit = false;
      this.colARACID4.OptionsColumn.ReadOnly = true;
      this.colARACID4.Width = 100;
      this.layoutControl1.Controls.Add((Control) this.tabPane1);
      this.layoutControl1.Controls.Add((Control) this.gridControl5);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(4, 4, 4, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1519, 878);
      this.layoutControl1.TabIndex = 5;
      this.layoutControl1.Text = "layoutControl1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1519, 878);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl5;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1493, 426);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.tabPane1;
      this.layoutControlItem2.Location = new Point(0, 426);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1493, 428);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLARACGRUBUTableAdapter.ClearBeforeFill = true;
      this.tBLARACGRUBU2TableAdapter.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMYERITableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter2.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLISLEMTIPITableAdapter.ClearBeforeFill = true;
      this.tBLMALZDEPOTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter3.ClearBeforeFill = true;
      this.tAHARIZANEDENITableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1519, 996);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (AracKarnesi);
      this.Text = "Araç Karnesi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl5.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      ((ISupportInitialize) this.aracKarnesiListeBindingSource).EndInit();
      this.aracKarnesiListe.EndInit();
      this.gridView7.EndInit();
      this.Birim.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.AnaGrup.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBUBindingSource).EndInit();
      this.gridView8.EndInit();
      this.AltGrup.EndInit();
      ((ISupportInitialize) this.tBLARACGRUBU2BindingSource).EndInit();
      this.gridView9.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      ((ISupportInitialize) this.aracKarnesiAtolyeIsEmirBindingSource).EndInit();
      this.aracKarnesiAtolyeIsEmir.EndInit();
      this.gridView1.EndInit();
      this.ArizaNedeni.EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
      this.gridView21.EndInit();
      this.BakimYer.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).EndInit();
      this.gridView5.EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource4).EndInit();
      ((ISupportInitialize) this.aracKarnesiYapilanBakimlarBindingSource).EndInit();
      this.aracKarnesiYapilanBakimlar.EndInit();
      this.gridView4.EndInit();
      this.AtolyeAdi.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.gridView11.EndInit();
      this.BakimYapanUsta.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.gridView13.EndInit();
      this.BakimGrubu.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.gridView12.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.aracKarnesiYagIsEmriBindingSource).EndInit();
      this.aracKarnesiYagIsEmri.EndInit();
      this.gridView3.EndInit();
      this.BakimYeri.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource1).EndInit();
      this.gridView6.EndInit();
      this.BirimAdi.EndInit();
      this.gridView10.EndInit();
      this.tabNavigationPage1.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView2.EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.tabNavigationPage4.ResumeLayout(false);
      this.gridControl6.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      this.aracKarnesiKullanılanMalzemeler.EndInit();
      this.gridView14.EndInit();
      this.IslemTipi.EndInit();
      ((ISupportInitialize) this.tBLISLEMTIPIBindingSource).EndInit();
      this.gridView16.EndInit();
      this.MalzemeId.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.gridView15.EndInit();
      this.Depo.EndInit();
      ((ISupportInitialize) this.tBLMALZDEPOBindingSource).EndInit();
      this.gridView17.EndInit();
      this.AlanUsta.EndInit();
      this.gridView18.EndInit();
      this.tabNavigationPage5.ResumeLayout(false);
      this.gridControl7.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource3).EndInit();
      ((ISupportInitialize) this.aracKarnesiMalzemeToplamlariBindingSource).EndInit();
      this.aracKarnesiMalzemeToplamlari.EndInit();
      this.gridView19.EndInit();
      this.MalzemeAdi.EndInit();
      this.gridView20.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
