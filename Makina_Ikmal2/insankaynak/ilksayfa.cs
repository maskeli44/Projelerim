// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.ilksayfa
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
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class ilksayfa : Form
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
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
    private GridView gridView1;
    private GridControl gridControl1;
    private RepositoryItemLookUpEdit beldiyebirim;
    private RepositoryItemLookUpEdit unvan;
    private RepositoryItemLookUpEdit arac;
    private RepositoryItemLookUpEdit mudurluk;
    private RepositoryItemLookUpEdit gorevunvan;
    private RepositoryItemLookUpEdit egitim;
    private RepositoryItemLookUpEdit ehliyet;
    private RepositoryItemLookUpEdit personelistihdamdurum;
    private RepositoryItemLookUpEdit durum;
    private RepositoryItemComboBox repositoryItemComboBox1;
    private RepositoryItemLookUpEdit aktifpasif;
    private RepositoryItemLookUpEdit istihdamdurum;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colTCKIMLIKNO;
    private GridColumn colSICILNO;
    private GridColumn colADISOYADI;
    private GridColumn colUNVANID;
    private GridColumn colGOREVUNVANID;
    private GridColumn colEGITIMID;
    private GridColumn colPERSISTIHDAMIID;
    private GridColumn colEHLIYETID;
    private GridColumn colEHLVERTARIH;
    private GridColumn colBELDBIRIMIID;
    private GridColumn colBELDMUDURLUKID;
    private GridColumn colGOREVYERI;
    private GridColumn colKANGRUPID;
    private GridColumn colYETKILIIMZAID;
    private GridColumn colIKMADRES;
    private GridColumn colARACID;
    private GridColumn colCEPTELEFON;
    private GridColumn colSIRANO;
    private GridColumn colPERSDURUMID;
    private GridColumn colISEGIRISTARIHI;
    private GridColumn colDOGUMTARIHI;
    private GridColumn colPARAFTANIM;
    private GridColumn colRESIM;
    private GridColumn colRESIMPER;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private BindingSource tBLPERSUNVANBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSUNVANTableAdapter tBLPERSUNVANTableAdapter;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private BindingSource tBLPERSKURUMGOREVBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSKURUMGOREVTableAdapter tBLPERSKURUMGOREVTableAdapter;
    private BindingSource tBLPERSEGITIMDRMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSEGITIMDRMTableAdapter tBLPERSEGITIMDRMTableAdapter;
    private BindingSource tBLPERSEHLIYETBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSEHLIYETTableAdapter tBLPERSEHLIYETTableAdapter;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter tBLPERSONELISTIHDAMDURUMTableAdapter;
    private BindingSource tBLPERSONELDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter tBLPERSONELDURUMTableAdapter;
    private BarButtonItem barButtonItem8;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem barButtonItem9;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource1;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter tBLPERSONELISTIHDAMDURUMTableAdapter1;
    private BindingSource tBLPERSONELBindingSource1;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter1;

    public ilksayfa() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayıt";
      new Ekle().Show();
    }

    private void Form6_Load(object sender, EventArgs e) => this.listele();

    private void listele()
    {
      this.tBLPERSONELDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELDURUM);
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.Fill(this.bellDataSet5.TBLPERSONELISTIHDAMDURUM);
      this.tBLPERSEHLIYETTableAdapter.Fill(this.bellDataSet5.TBLPERSEHLIYET);
      this.tBLPERSEGITIMDRMTableAdapter.Fill(this.bellDataSet5.TBLPERSEGITIMDRM);
      this.tBLPERSKURUMGOREVTableAdapter.Fill(this.bellDataSet5.TBLPERSKURUMGOREV);
      this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      this.tBLPERSUNVANTableAdapter.Fill(this.bellDataSet5.TBLPERSUNVAN);
      this.tBLPERSONELTableAdapter1.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLPERSONELISTIHDAMDURUMTableAdapter1.Fill(this.bellDataSet7.TBLPERSONELISTIHDAMDURUM);
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new Ekle().Show();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new Ekle().Show();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.yet.yetkiislemleri("PERSONEL");
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        LogEkle.Logs("Silme Yapti");
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLPERSONEL.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }).PERSDURUMID = new int?(2);
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
      }
    }

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new PersonelResimliYazdirma()).ShowPreviewDialog();

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new PersonelyazdirmaRapor()).ShowPreviewDialog();

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void filtre()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private string secmeislemi()
    {
      string str1 = "";
      string str2 = "";
      if (this.barCheckItem1.Checked)
        str1 += "[PERSDURUMID] =1 OR";
      if (this.barCheckItem2.Checked)
        str1 += "[PERSDURUMID] =2 OR";
      try
      {
        str2 = str1.Substring(0, str1.Length - 2);
      }
      catch (Exception ex)
      {
      }
      return str2;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ilksayfa));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLPERSONELBindingSource1 = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView1 = new GridView();
      this.colRESIMPER = new GridColumn();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colTCKIMLIKNO = new GridColumn();
      this.colUNVANID = new GridColumn();
      this.unvan = new RepositoryItemLookUpEdit();
      this.tBLPERSUNVANBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colGOREVUNVANID = new GridColumn();
      this.gorevunvan = new RepositoryItemLookUpEdit();
      this.tBLPERSKURUMGOREVBindingSource = new BindingSource(this.components);
      this.colEGITIMID = new GridColumn();
      this.egitim = new RepositoryItemLookUpEdit();
      this.tBLPERSEGITIMDRMBindingSource = new BindingSource(this.components);
      this.colPERSISTIHDAMIID = new GridColumn();
      this.istihdamdurum = new RepositoryItemLookUpEdit();
      this.tBLPERSONELISTIHDAMDURUMBindingSource1 = new BindingSource(this.components);
      this.colEHLIYETID = new GridColumn();
      this.ehliyet = new RepositoryItemLookUpEdit();
      this.tBLPERSEHLIYETBindingSource = new BindingSource(this.components);
      this.colEHLVERTARIH = new GridColumn();
      this.colBELDBIRIMIID = new GridColumn();
      this.beldiyebirim = new RepositoryItemLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.colBELDMUDURLUKID = new GridColumn();
      this.mudurluk = new RepositoryItemLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.colGOREVYERI = new GridColumn();
      this.colKANGRUPID = new GridColumn();
      this.colYETKILIIMZAID = new GridColumn();
      this.colIKMADRES = new GridColumn();
      this.colARACID = new GridColumn();
      this.arac = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.colCEPTELEFON = new GridColumn();
      this.colSICILNO = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colPERSDURUMID = new GridColumn();
      this.durum = new RepositoryItemLookUpEdit();
      this.tBLPERSONELDURUMBindingSource = new BindingSource(this.components);
      this.colISEGIRISTARIHI = new GridColumn();
      this.colDOGUMTARIHI = new GridColumn();
      this.colPARAFTANIM = new GridColumn();
      this.colRESIM = new GridColumn();
      this.personelistihdamdurum = new RepositoryItemLookUpEdit();
      this.tBLPERSONELISTIHDAMDURUMBindingSource = new BindingSource(this.components);
      this.repositoryItemComboBox1 = new RepositoryItemComboBox();
      this.aktifpasif = new RepositoryItemLookUpEdit();
      this.barButtonItem9 = new BarButtonItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDBIRIMLERTableAdapter();
      this.tBLPERSUNVANTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSUNVANTableAdapter();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBELDMUDURLUKTableAdapter();
      this.tBLPERSKURUMGOREVTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSKURUMGOREVTableAdapter();
      this.tBLPERSEGITIMDRMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSEGITIMDRMTableAdapter();
      this.tBLPERSEHLIYETTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSEHLIYETTableAdapter();
      this.tBLPERSONELISTIHDAMDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter();
      this.tBLPERSONELDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELDURUMTableAdapter();
      this.tBLPERSONELISTIHDAMDURUMTableAdapter1 = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELISTIHDAMDURUMTableAdapter();
      this.tBLPERSONELTableAdapter1 = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView1.BeginInit();
      this.unvan.BeginInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gorevunvan.BeginInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).BeginInit();
      this.egitim.BeginInit();
      ((ISupportInitialize) this.tBLPERSEGITIMDRMBindingSource).BeginInit();
      this.istihdamdurum.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource1).BeginInit();
      this.ehliyet.BeginInit();
      ((ISupportInitialize) this.tBLPERSEHLIYETBindingSource).BeginInit();
      this.beldiyebirim.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.mudurluk.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.arac.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.durum.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).BeginInit();
      this.personelistihdamdurum.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).BeginInit();
      this.repositoryItemComboBox1.BeginInit();
      this.aktifpasif.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
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
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barEditItem1,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2
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
      this.ribbonControl1.Size = new Size(862, 96);
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 9;
      this.barEditItem1.ItemAppearance.Disabled.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem1.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem1.RibbonStyle = RibbonItemStyles.Large;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLPERSONELBindingSource1;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 96);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[12]
      {
        (RepositoryItem) this.beldiyebirim,
        (RepositoryItem) this.unvan,
        (RepositoryItem) this.arac,
        (RepositoryItem) this.mudurluk,
        (RepositoryItem) this.gorevunvan,
        (RepositoryItem) this.egitim,
        (RepositoryItem) this.ehliyet,
        (RepositoryItem) this.personelistihdamdurum,
        (RepositoryItem) this.durum,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.aktifpasif,
        (RepositoryItem) this.istihdamdurum
      });
      this.gridControl1.Size = new Size(862, 477);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.UseEmbeddedNavigator = true;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLPERSONELBindingSource1.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource1.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.BackColor = Color.Transparent;
      this.gridView1.Appearance.Row.BackColor2 = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[26]
      {
        this.colRESIMPER,
        this.colID,
        this.colKOD,
        this.colADISOYADI,
        this.colTCKIMLIKNO,
        this.colUNVANID,
        this.colGOREVUNVANID,
        this.colEGITIMID,
        this.colPERSISTIHDAMIID,
        this.colEHLIYETID,
        this.colEHLVERTARIH,
        this.colBELDBIRIMIID,
        this.colBELDMUDURLUKID,
        this.colGOREVYERI,
        this.colKANGRUPID,
        this.colYETKILIIMZAID,
        this.colIKMADRES,
        this.colARACID,
        this.colCEPTELEFON,
        this.colSICILNO,
        this.colSIRANO,
        this.colPERSDURUMID,
        this.colISEGIRISTARIHI,
        this.colDOGUMTARIHI,
        this.colPARAFTANIM,
        this.colRESIM
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "GRUPLA";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.RowAutoHeight = true;
      this.gridView1.RowHeight = 49;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colID, ColumnSortOrder.Descending)
      });
      this.colRESIMPER.Caption = "Resim";
      this.colRESIMPER.FieldName = "RESIMPER";
      this.colRESIMPER.Fixed = FixedStyle.Left;
      this.colRESIMPER.MinWidth = 19;
      this.colRESIMPER.Name = "colRESIMPER";
      this.colRESIMPER.OptionsColumn.FixedWidth = true;
      this.colRESIMPER.Visible = true;
      this.colRESIMPER.VisibleIndex = 0;
      this.colRESIMPER.Width = 112;
      this.colID.FieldName = "ID";
      this.colID.Fixed = FixedStyle.Left;
      this.colID.MinWidth = 19;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.FixedWidth = true;
      this.colID.Width = 70;
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.Fixed = FixedStyle.Left;
      this.colKOD.MinWidth = 19;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.FixedWidth = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 1;
      this.colADISOYADI.Caption = "Adı Soyadı";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.Fixed = FixedStyle.Left;
      this.colADISOYADI.MinWidth = 19;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.OptionsColumn.FixedWidth = true;
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 2;
      this.colADISOYADI.Width = 187;
      this.colTCKIMLIKNO.Caption = "T.C No";
      this.colTCKIMLIKNO.FieldName = "TCKIMLIKNO";
      this.colTCKIMLIKNO.MinWidth = 19;
      this.colTCKIMLIKNO.Name = "colTCKIMLIKNO";
      this.colTCKIMLIKNO.Visible = true;
      this.colTCKIMLIKNO.VisibleIndex = 3;
      this.colTCKIMLIKNO.Width = 135;
      this.colUNVANID.Caption = "Ünvan";
      this.colUNVANID.ColumnEdit = (RepositoryItem) this.unvan;
      this.colUNVANID.FieldName = "UNVANID";
      this.colUNVANID.MinWidth = 19;
      this.colUNVANID.Name = "colUNVANID";
      this.colUNVANID.Visible = true;
      this.colUNVANID.VisibleIndex = 5;
      this.colUNVANID.Width = 90;
      this.unvan.AutoHeight = false;
      this.unvan.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.unvan.DataSource = (object) this.tBLPERSUNVANBindingSource;
      this.unvan.DisplayMember = "UNVAN";
      this.unvan.Name = "unvan";
      this.unvan.NullText = "";
      this.unvan.ValueMember = "ID";
      this.tBLPERSUNVANBindingSource.DataMember = "TBLPERSUNVAN";
      this.tBLPERSUNVANBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colGOREVUNVANID.Caption = "Görev Ünvan";
      this.colGOREVUNVANID.ColumnEdit = (RepositoryItem) this.gorevunvan;
      this.colGOREVUNVANID.FieldName = "GOREVUNVANID";
      this.colGOREVUNVANID.MinWidth = 19;
      this.colGOREVUNVANID.Name = "colGOREVUNVANID";
      this.colGOREVUNVANID.Visible = true;
      this.colGOREVUNVANID.VisibleIndex = 6;
      this.colGOREVUNVANID.Width = 90;
      this.gorevunvan.AutoHeight = false;
      this.gorevunvan.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gorevunvan.DataSource = (object) this.tBLPERSKURUMGOREVBindingSource;
      this.gorevunvan.DisplayMember = "KURUMGOREV";
      this.gorevunvan.Name = "gorevunvan";
      this.gorevunvan.NullText = "";
      this.gorevunvan.ValueMember = "ID";
      this.tBLPERSKURUMGOREVBindingSource.DataMember = "TBLPERSKURUMGOREV";
      this.tBLPERSKURUMGOREVBindingSource.DataSource = (object) this.bellDataSet5;
      this.colEGITIMID.Caption = "Eğitim Durum";
      this.colEGITIMID.ColumnEdit = (RepositoryItem) this.egitim;
      this.colEGITIMID.FieldName = "EGITIMID";
      this.colEGITIMID.MinWidth = 19;
      this.colEGITIMID.Name = "colEGITIMID";
      this.colEGITIMID.Visible = true;
      this.colEGITIMID.VisibleIndex = 7;
      this.colEGITIMID.Width = 90;
      this.egitim.AutoHeight = false;
      this.egitim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.egitim.DataSource = (object) this.tBLPERSEGITIMDRMBindingSource;
      this.egitim.DisplayMember = "EGITIMDURUM";
      this.egitim.Name = "egitim";
      this.egitim.NullText = "";
      this.egitim.ValueMember = "ID";
      this.tBLPERSEGITIMDRMBindingSource.DataMember = "TBLPERSEGITIMDRM";
      this.tBLPERSEGITIMDRMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colPERSISTIHDAMIID.Caption = "İstihdam";
      this.colPERSISTIHDAMIID.ColumnEdit = (RepositoryItem) this.istihdamdurum;
      this.colPERSISTIHDAMIID.FieldName = "PERSISTIHDAMIID";
      this.colPERSISTIHDAMIID.MinWidth = 19;
      this.colPERSISTIHDAMIID.Name = "colPERSISTIHDAMIID";
      this.colPERSISTIHDAMIID.Visible = true;
      this.colPERSISTIHDAMIID.VisibleIndex = 8;
      this.colPERSISTIHDAMIID.Width = 90;
      this.istihdamdurum.AutoHeight = false;
      this.istihdamdurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.istihdamdurum.DataSource = (object) this.tBLPERSONELISTIHDAMDURUMBindingSource1;
      this.istihdamdurum.DisplayMember = "ADI";
      this.istihdamdurum.Name = "istihdamdurum";
      this.istihdamdurum.NullText = "";
      this.istihdamdurum.ValueMember = "ID";
      this.tBLPERSONELISTIHDAMDURUMBindingSource1.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource1.DataSource = (object) this.bellDataSet7;
      this.colEHLIYETID.Caption = "Ehliyet";
      this.colEHLIYETID.ColumnEdit = (RepositoryItem) this.ehliyet;
      this.colEHLIYETID.FieldName = "EHLIYETID";
      this.colEHLIYETID.MinWidth = 19;
      this.colEHLIYETID.Name = "colEHLIYETID";
      this.colEHLIYETID.Visible = true;
      this.colEHLIYETID.VisibleIndex = 9;
      this.colEHLIYETID.Width = 90;
      this.ehliyet.AutoHeight = false;
      this.ehliyet.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ehliyet.DataSource = (object) this.tBLPERSEHLIYETBindingSource;
      this.ehliyet.DisplayMember = "EHLIYET";
      this.ehliyet.Name = "ehliyet";
      this.ehliyet.NullText = "";
      this.ehliyet.ValueMember = "ID";
      this.tBLPERSEHLIYETBindingSource.DataMember = "TBLPERSEHLIYET";
      this.tBLPERSEHLIYETBindingSource.DataSource = (object) this.bellDataSet5;
      this.colEHLVERTARIH.Caption = "Ehliyet Veriliş Tarih";
      this.colEHLVERTARIH.FieldName = "EHLVERTARIH";
      this.colEHLVERTARIH.MinWidth = 19;
      this.colEHLVERTARIH.Name = "colEHLVERTARIH";
      this.colEHLVERTARIH.Width = 90;
      this.colBELDBIRIMIID.Caption = "Birim";
      this.colBELDBIRIMIID.ColumnEdit = (RepositoryItem) this.beldiyebirim;
      this.colBELDBIRIMIID.FieldName = "BELDBIRIMIID";
      this.colBELDBIRIMIID.MinWidth = 19;
      this.colBELDBIRIMIID.Name = "colBELDBIRIMIID";
      this.colBELDBIRIMIID.Visible = true;
      this.colBELDBIRIMIID.VisibleIndex = 10;
      this.colBELDBIRIMIID.Width = 90;
      this.beldiyebirim.AutoHeight = false;
      this.beldiyebirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.beldiyebirim.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.beldiyebirim.DisplayMember = "BELDBIRIMADI";
      this.beldiyebirim.Name = "beldiyebirim";
      this.beldiyebirim.NullText = "";
      this.beldiyebirim.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBELDMUDURLUKID.Caption = "Müdürlük";
      this.colBELDMUDURLUKID.ColumnEdit = (RepositoryItem) this.mudurluk;
      this.colBELDMUDURLUKID.FieldName = "BELDMUDURLUKID";
      this.colBELDMUDURLUKID.MinWidth = 19;
      this.colBELDMUDURLUKID.Name = "colBELDMUDURLUKID";
      this.colBELDMUDURLUKID.Visible = true;
      this.colBELDMUDURLUKID.VisibleIndex = 11;
      this.colBELDMUDURLUKID.Width = 90;
      this.mudurluk.AutoHeight = false;
      this.mudurluk.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurluk.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.mudurluk.DisplayMember = "BELDMUDURLUK";
      this.mudurluk.Name = "mudurluk";
      this.mudurluk.NullText = "";
      this.mudurluk.ValueMember = "ID";
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.colGOREVYERI.Caption = "Görev Yeri";
      this.colGOREVYERI.FieldName = "GOREVYERI";
      this.colGOREVYERI.MinWidth = 19;
      this.colGOREVYERI.Name = "colGOREVYERI";
      this.colGOREVYERI.Visible = true;
      this.colGOREVYERI.VisibleIndex = 12;
      this.colGOREVYERI.Width = 90;
      this.colKANGRUPID.Caption = "Kan Grubu";
      this.colKANGRUPID.FieldName = "KANGRUPID";
      this.colKANGRUPID.MinWidth = 19;
      this.colKANGRUPID.Name = "colKANGRUPID";
      this.colKANGRUPID.Width = 90;
      this.colYETKILIIMZAID.FieldName = "YETKILIIMZAID";
      this.colYETKILIIMZAID.MinWidth = 19;
      this.colYETKILIIMZAID.Name = "colYETKILIIMZAID";
      this.colYETKILIIMZAID.Width = 90;
      this.colIKMADRES.Caption = "İkamet Adresi";
      this.colIKMADRES.FieldName = "IKMADRES";
      this.colIKMADRES.MinWidth = 19;
      this.colIKMADRES.Name = "colIKMADRES";
      this.colIKMADRES.Visible = true;
      this.colIKMADRES.VisibleIndex = 13;
      this.colIKMADRES.Width = 90;
      this.colARACID.Caption = "Zimmet Aracı";
      this.colARACID.ColumnEdit = (RepositoryItem) this.arac;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 19;
      this.colARACID.Name = "colARACID";
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 14;
      this.colARACID.Width = 90;
      this.arac.AutoHeight = false;
      this.arac.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arac.DataSource = (object) this.tBLARACLARBindingSource;
      this.arac.DisplayMember = "PLAKA";
      this.arac.Name = "arac";
      this.arac.NullText = "Zimmetinde Arac Yok";
      this.arac.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.colCEPTELEFON.Caption = "Telefon";
      this.colCEPTELEFON.FieldName = "CEPTELEFON";
      this.colCEPTELEFON.MinWidth = 19;
      this.colCEPTELEFON.Name = "colCEPTELEFON";
      this.colCEPTELEFON.Visible = true;
      this.colCEPTELEFON.VisibleIndex = 15;
      this.colCEPTELEFON.Width = 90;
      this.colSICILNO.Caption = "Sicil No";
      this.colSICILNO.FieldName = "SICILNO";
      this.colSICILNO.MinWidth = 19;
      this.colSICILNO.Name = "colSICILNO";
      this.colSICILNO.Visible = true;
      this.colSICILNO.VisibleIndex = 4;
      this.colSICILNO.Width = 90;
      this.colSIRANO.Caption = "Sıra No";
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.MinWidth = 19;
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.Width = 90;
      this.colPERSDURUMID.Caption = "Durumu";
      this.colPERSDURUMID.ColumnEdit = (RepositoryItem) this.durum;
      this.colPERSDURUMID.FieldName = "PERSDURUMID";
      this.colPERSDURUMID.MinWidth = 19;
      this.colPERSDURUMID.Name = "colPERSDURUMID";
      this.colPERSDURUMID.Visible = true;
      this.colPERSDURUMID.VisibleIndex = 16;
      this.colPERSDURUMID.Width = 90;
      this.durum.AutoHeight = false;
      this.durum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.durum.DataSource = (object) this.tBLPERSONELDURUMBindingSource;
      this.durum.DisplayMember = "DURUM";
      this.durum.Name = "durum";
      this.durum.ValueMember = "ID";
      this.tBLPERSONELDURUMBindingSource.DataMember = "TBLPERSONELDURUM";
      this.tBLPERSONELDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colISEGIRISTARIHI.Caption = "İşe Giriş Tarihi";
      this.colISEGIRISTARIHI.FieldName = "ISEGIRISTARIHI";
      this.colISEGIRISTARIHI.MinWidth = 19;
      this.colISEGIRISTARIHI.Name = "colISEGIRISTARIHI";
      this.colISEGIRISTARIHI.Visible = true;
      this.colISEGIRISTARIHI.VisibleIndex = 17;
      this.colISEGIRISTARIHI.Width = 90;
      this.colDOGUMTARIHI.Caption = "Doğum Tarihi";
      this.colDOGUMTARIHI.FieldName = "DOGUMTARIHI";
      this.colDOGUMTARIHI.MinWidth = 19;
      this.colDOGUMTARIHI.Name = "colDOGUMTARIHI";
      this.colDOGUMTARIHI.Visible = true;
      this.colDOGUMTARIHI.VisibleIndex = 18;
      this.colDOGUMTARIHI.Width = 90;
      this.colPARAFTANIM.FieldName = "PARAFTANIM";
      this.colPARAFTANIM.MinWidth = 19;
      this.colPARAFTANIM.Name = "colPARAFTANIM";
      this.colPARAFTANIM.Width = 90;
      this.colRESIM.FieldName = "RESIM";
      this.colRESIM.MinWidth = 19;
      this.colRESIM.Name = "colRESIM";
      this.colRESIM.Width = 90;
      this.personelistihdamdurum.AutoHeight = false;
      this.personelistihdamdurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personelistihdamdurum.DataSource = (object) this.tBLPERSONELISTIHDAMDURUMBindingSource;
      this.personelistihdamdurum.DisplayMember = "ADI";
      this.personelistihdamdurum.Name = "personelistihdamdurum";
      this.personelistihdamdurum.NullText = "";
      this.personelistihdamdurum.ValueMember = "ID";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.repositoryItemComboBox1.AutoHeight = false;
      this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemComboBox1.Items.AddRange(new object[3]
      {
        (object) "Belirtilmemiş",
        (object) "VAR",
        (object) "YOK"
      });
      this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
      this.aktifpasif.AutoHeight = false;
      this.aktifpasif.AutoSearchColumnIndex = 1;
      this.aktifpasif.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aktifpasif.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("(None)", "Name3", 15, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("Name1", "Var", 15, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("Yok", "Name2", 15, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.aktifpasif.DisplayMember = "DURUM";
      this.aktifpasif.Name = "aktifpasif";
      this.aktifpasif.NullText = "";
      this.aktifpasif.ValueMember = "ID";
      this.barButtonItem9.Caption = "Resimli Yazdırma";
      this.barButtonItem9.Id = 10;
      this.barButtonItem9.ImageOptions.Image = (Image) Resources.printtitles_16x16;
      this.barButtonItem9.ImageOptions.LargeImage = (Image) Resources.printtitles_32x32;
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barCheckItem1.Caption = "Aktif";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 11;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "Pasif";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 12;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem2.CheckedChanged += new ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barCheckItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barCheckItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem9);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLPERSUNVANTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.tBLPERSKURUMGOREVTableAdapter.ClearBeforeFill = true;
      this.tBLPERSEGITIMDRMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSEHLIYETTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELISTIHDAMDURUMTableAdapter1.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(862, 573);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (ilksayfa);
      this.Text = "Personel Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView1.EndInit();
      this.unvan.EndInit();
      ((ISupportInitialize) this.tBLPERSUNVANBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gorevunvan.EndInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).EndInit();
      this.egitim.EndInit();
      ((ISupportInitialize) this.tBLPERSEGITIMDRMBindingSource).EndInit();
      this.istihdamdurum.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource1).EndInit();
      this.ehliyet.EndInit();
      ((ISupportInitialize) this.tBLPERSEHLIYETBindingSource).EndInit();
      this.beldiyebirim.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.mudurluk.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.arac.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.durum.EndInit();
      ((ISupportInitialize) this.tBLPERSONELDURUMBindingSource).EndInit();
      this.personelistihdamdurum.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).EndInit();
      this.repositoryItemComboBox1.EndInit();
      this.aktifpasif.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
