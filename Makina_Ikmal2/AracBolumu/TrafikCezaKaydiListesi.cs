// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.TrafikCezaKaydiListesi
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
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.AracTrafikCezaTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class TrafikCezaKaydiListesi : Form
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private string secme = "";
    private string secme2 = "";
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private GridView gridView1;
    private GridControl gridControl1;
    private RibbonPageGroup ribbonPageGroup2;
    private BarEditItem barEditItem1;
    private BarEditItem barEditItem2;
    private RepositoryItemCheckEdit repositoryItemCheckEdit1;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarEditItem barEditItem4;
    private RepositoryItemRadioGroup repositoryItemRadioGroup2;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarCheckItem barCheckItem6;
    private RibbonPageGroup ribbonPageGroup3;
    private BarEditItem barEditItem5;
    private RepositoryItemSearchControl repositoryItemSearchControl2;
    private BarCheckItem barCheckItem7;
    private BarCheckItem barCheckItem9;
    private BarCheckItem barCheckItem10;
    private BarCheckItem barCheckItem11;
    private BarCheckItem barCheckItem12;
    private BarCheckItem barCheckItem13;
    private BarEditItem barEditItem3;
    private BarCheckItem barCheckItem8;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem12;
    private RibbonPageGroup ribbonPageGroup6;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem13;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup4;
    private BarCheckItem barCheckItem14;
    private BarCheckItem barCheckItem15;
    private BarCheckItem barCheckItem16;
    private BarCheckItem barCheckItem17;
    private BarCheckItem barCheckItem18;
    private BarCheckItem barCheckItem19;
    private RibbonPageGroup ribbonPageGroup7;
    private RepositoryItemSearchLookUpEdit AracDurum;
    private GridView repositoryItemSearchLookUpEdit1View;
    private RepositoryItemSearchLookUpEdit Personel;
    private GridView gridView2;
    private AracTrafikCeza aracTrafikCeza;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colID;
    private GridColumn colODEMEDURUM;
    private GridColumn colKAYITTARIHI;
    private GridColumn colPLAKA;
    private GridColumn colFISNO;
    private GridColumn colCEZATARIHI;
    private GridColumn colCEZASAATI;
    private GridColumn colCEZATUTARI;
    private GridColumn colILGILINOT;
    private GridColumn colADISOYADI;
    private GridColumn colCEPTELEFON;
    private GridColumn colCEZAACIKLAMA;
    private GridColumn colARACDURUMID;
    private bellDataSet7 bellDataSet7;
    private BindingSource tAHARACDURUMBindingSource;
    private TAHARACDURUMTableAdapter tAHARACDURUMTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tAHARACTIPIBindingSource;
    private TAHARACTIPITableAdapter tAHARACTIPITableAdapter;
    private GridColumn colARACTIPIID;
    private RepositoryItemSearchLookUpEdit aracDurum1;
    private BindingSource tAHARACDURUMBindingSource1;
    private GridView gridView3;

    public TrafikCezaKaydiListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new TrafikCezaKaydiEkle().Show();
      this.listele();
    }

    private void Form6_Load(object sender, EventArgs e) => this.listele();

    public void listele()
    {
      this.yet.yetkiislemleri("Trafik Ceza Listesi");
      if (YetkiClass.ListelemeYetki != 1)
        return;
      this.tAHARACTIPITableAdapter.Fill(this.bellDataSet7.TAHARACTIPI);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tAHARACDURUMTableAdapter.Fill(this.bellDataSet7.TAHARACDURUM);
      this.dataTable1TableAdapter.Fill(this.aracTrafikCeza.DataTable1);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new TrafikCezaKaydiGuncelle().Show();
      this.listele();
    }

    private void barCheckItem8_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new TrafikCezaKaydiGuncelle().Show();
      this.listele();
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.yet.yetkiislemleri("Trafik Ceza Listesi");
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLARACTRFCEZA.Remove(this.db.TBLARACTRFCEZA.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
      }
      this.listele();
    }

    private void filtre()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void filtre2()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi2();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private string secmeislemi()
    {
      this.secme = "";
      string str = "";
      if (this.barCheckItem14.Checked)
        this.secme += "[ARACTIPIID] = 1  AND";
      if (this.barCheckItem15.Checked)
        this.secme += "[ARACTIPIID] = 2  AND";
      if (this.barCheckItem18.Checked)
        this.secme += "[ODEMEDURUM]='Ödendi'  OR";
      if (this.barCheckItem19.Checked)
        this.secme += "[ODEMEDURUM]='İptal'  OR";
      if (this.barCheckItem16.Checked)
        this.secme += "[ODEMEDURUM] ='Beklemede'  OR";
      if (this.barCheckItem17.Checked)
        this.secme += "[ODEMEDURUM] ='Tahsil Edildi'  OR";
      try
      {
        str = this.secme.Substring(0, this.secme.Length - 4);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private string secmeislemi2()
    {
      this.secme2 = "";
      string str = "";
      if (this.barCheckItem18.Checked)
        this.secme2 += "[ODEMEDURUM]='Ödendi' OR";
      if (this.barCheckItem19.Checked)
        this.secme2 += "  [ODEMEDURUM]='İptal' OR";
      if (this.barCheckItem16.Checked)
        this.secme2 += "[ODEMEDURUM] ='Beklemede' OR";
      if (this.barCheckItem17.Checked)
        this.secme2 += "[ODEMEDURUM] ='Tahsil Edildi' OR";
      try
      {
        str = this.secme2.Substring(0, this.secme2.Length - 3);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private void barCheckItem14_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem15_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem18_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem19_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem16_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void satirToplam()
    {
    }

    private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) => this.satirToplam();

    private void gridControl1_Load(object sender, EventArgs e) => this.satirToplam();

    private void gridControl1_FocusedViewChanged(object sender, ViewFocusEventArgs e) => this.satirToplam();

    private void gridControl1_DefaultViewChanged(object sender, EventArgs e) => this.satirToplam();

    private void barCheckItem17_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TrafikCezaKaydiListesi));
      this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem4 = new BarEditItem();
      this.repositoryItemRadioGroup2 = new RepositoryItemRadioGroup();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barEditItem5 = new BarEditItem();
      this.repositoryItemSearchControl2 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.aracTrafikCeza = new AracTrafikCeza();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colODEMEDURUM = new GridColumn();
      this.colKAYITTARIHI = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colFISNO = new GridColumn();
      this.colCEZATARIHI = new GridColumn();
      this.colARACTIPIID = new GridColumn();
      this.AracDurum = new RepositoryItemSearchLookUpEdit();
      this.tAHARACTIPIBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colCEZASAATI = new GridColumn();
      this.colCEZATUTARI = new GridColumn();
      this.colILGILINOT = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colCEPTELEFON = new GridColumn();
      this.colCEZAACIKLAMA = new GridColumn();
      this.colARACDURUMID = new GridColumn();
      this.aracDurum1 = new RepositoryItemSearchLookUpEdit();
      this.tAHARACDURUMBindingSource1 = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.Personel = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.barCheckItem7 = new BarCheckItem();
      this.barCheckItem9 = new BarCheckItem();
      this.barCheckItem10 = new BarCheckItem();
      this.barCheckItem11 = new BarCheckItem();
      this.barCheckItem12 = new BarCheckItem();
      this.barCheckItem13 = new BarCheckItem();
      this.barCheckItem8 = new BarCheckItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barCheckItem14 = new BarCheckItem();
      this.barCheckItem15 = new BarCheckItem();
      this.barCheckItem16 = new BarCheckItem();
      this.barCheckItem17 = new BarCheckItem();
      this.barCheckItem18 = new BarCheckItem();
      this.barCheckItem19 = new BarCheckItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup7 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.tAHARACDURUMBindingSource = new BindingSource(this.components);
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.barEditItem3 = new BarEditItem();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.tAHARACDURUMTableAdapter = new TAHARACDURUMTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tAHARACTIPITableAdapter = new TAHARACTIPITableAdapter();
      this.repositoryItemCheckEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.aracTrafikCeza.BeginInit();
      this.gridView1.BeginInit();
      this.AracDurum.BeginInit();
      ((ISupportInitialize) this.tAHARACTIPIBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.aracDurum1.BeginInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource1).BeginInit();
      this.gridView3.BeginInit();
      this.Personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource).BeginInit();
      this.SuspendLayout();
      this.repositoryItemCheckEdit1.AutoHeight = false;
      this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[38]
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
        (BarItem) this.barEditItem1,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem4,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barEditItem5,
        (BarItem) this.barCheckItem7,
        (BarItem) this.barCheckItem9,
        (BarItem) this.barCheckItem10,
        (BarItem) this.barCheckItem11,
        (BarItem) this.barCheckItem12,
        (BarItem) this.barCheckItem13,
        (BarItem) this.barCheckItem8,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barCheckItem14,
        (BarItem) this.barCheckItem15,
        (BarItem) this.barCheckItem16,
        (BarItem) this.barCheckItem17,
        (BarItem) this.barCheckItem18,
        (BarItem) this.barCheckItem19
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 45;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemRadioGroup2,
        (RepositoryItem) this.repositoryItemSearchControl2
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1263, 100);
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
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Caption = "barEditItem1";
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemCheckEdit1;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem2.Caption = "barEditItem2";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemRadioGroup1;
      this.barEditItem2.Id = 12;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem4.Caption = "barEditItem4";
      this.barEditItem4.Edit = (RepositoryItem) this.repositoryItemRadioGroup2;
      this.barEditItem4.Id = 14;
      this.barEditItem4.Name = "barEditItem4";
      this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
      this.barCheckItem1.Caption = "Resmi";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barCheckItem1.ItemAppearance.Disabled.Options.UseFont = true;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "barCheckItem2";
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "Diğer Kiralık";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barCheckItem4.Caption = "Destek Kiralık";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem5.Caption = "Ekipman";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem6.Caption = "Diğer Kiralık";
      this.barCheckItem6.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem6.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem6.Id = 20;
      this.barCheckItem6.Name = "barCheckItem6";
      this.barEditItem5.Edit = (RepositoryItem) this.repositoryItemSearchControl2;
      this.barEditItem5.EditHeight = 30;
      this.barEditItem5.EditWidth = 140;
      this.barEditItem5.Hint = "Kayıt Bul...";
      this.barEditItem5.Id = 22;
      this.barEditItem5.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Hovered.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Hovered.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Normal.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Normal.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Pressed.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Pressed.Options.UseFont = true;
      this.barEditItem5.Name = "barEditItem5";
      this.repositoryItemSearchControl2.AllowNullInput = DefaultBoolean.True;
      this.repositoryItemSearchControl2.AutoHeight = false;
      this.repositoryItemSearchControl2.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl2.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl2.Name = "repositoryItemSearchControl2";
      this.repositoryItemSearchControl2.NullValuePrompt = "Kayıt Bul...";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.AracDurum,
        (RepositoryItem) this.Personel,
        (RepositoryItem) this.aracDurum1
      });
      this.gridControl1.Size = new Size(1263, 475);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DefaultViewChanged += new EventHandler(this.gridControl1_DefaultViewChanged);
      this.gridControl1.Load += new EventHandler(this.gridControl1_Load);
      this.gridControl1.FocusedViewChanged += new ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.aracTrafikCeza;
      this.aracTrafikCeza.DataSetName = "AracTrafikCeza";
      this.aracTrafikCeza.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[14]
      {
        this.colID,
        this.colODEMEDURUM,
        this.colKAYITTARIHI,
        this.colPLAKA,
        this.colFISNO,
        this.colCEZATARIHI,
        this.colARACTIPIID,
        this.colCEZASAATI,
        this.colCEZATUTARI,
        this.colILGILINOT,
        this.colADISOYADI,
        this.colCEPTELEFON,
        this.colCEZAACIKLAMA,
        this.colARACDURUMID
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "GRUPLA";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.ShowFooter = true;
      this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colODEMEDURUM.Caption = "Ödeme Durumu";
      this.colODEMEDURUM.FieldName = "ODEMEDURUM";
      this.colODEMEDURUM.Name = "colODEMEDURUM";
      this.colODEMEDURUM.OptionsColumn.AllowEdit = false;
      this.colODEMEDURUM.OptionsColumn.ReadOnly = true;
      this.colODEMEDURUM.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "ODEMEDURUM", "Kayıt Sayısı = {0}")
      });
      this.colODEMEDURUM.Visible = true;
      this.colODEMEDURUM.VisibleIndex = 0;
      this.colODEMEDURUM.Width = 143;
      this.colKAYITTARIHI.Caption = "Kayıt Tarihi";
      this.colKAYITTARIHI.DisplayFormat.FormatString = "d";
      this.colKAYITTARIHI.DisplayFormat.FormatType = FormatType.DateTime;
      this.colKAYITTARIHI.FieldName = "KAYITTARIHI";
      this.colKAYITTARIHI.Name = "colKAYITTARIHI";
      this.colKAYITTARIHI.OptionsColumn.AllowEdit = false;
      this.colKAYITTARIHI.OptionsColumn.ReadOnly = true;
      this.colKAYITTARIHI.Visible = true;
      this.colKAYITTARIHI.VisibleIndex = 2;
      this.colKAYITTARIHI.Width = 139;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 3;
      this.colPLAKA.Width = 125;
      this.colFISNO.Caption = "Fiş No";
      this.colFISNO.FieldName = "FISNO";
      this.colFISNO.Name = "colFISNO";
      this.colFISNO.OptionsColumn.AllowEdit = false;
      this.colFISNO.OptionsColumn.ReadOnly = true;
      this.colFISNO.Visible = true;
      this.colFISNO.VisibleIndex = 4;
      this.colFISNO.Width = 131;
      this.colCEZATARIHI.Caption = "Ceza Tarihi";
      this.colCEZATARIHI.DisplayFormat.FormatString = "d";
      this.colCEZATARIHI.DisplayFormat.FormatType = FormatType.DateTime;
      this.colCEZATARIHI.FieldName = "CEZATARIHI";
      this.colCEZATARIHI.Name = "colCEZATARIHI";
      this.colCEZATARIHI.OptionsColumn.AllowEdit = false;
      this.colCEZATARIHI.OptionsColumn.ReadOnly = true;
      this.colCEZATARIHI.Visible = true;
      this.colCEZATARIHI.VisibleIndex = 5;
      this.colCEZATARIHI.Width = 140;
      this.colARACTIPIID.Caption = "Araç Tipi";
      this.colARACTIPIID.ColumnEdit = (RepositoryItem) this.AracDurum;
      this.colARACTIPIID.FieldName = "ARACTIPIID";
      this.colARACTIPIID.Name = "colARACTIPIID";
      this.colARACTIPIID.OptionsColumn.AllowEdit = false;
      this.colARACTIPIID.OptionsColumn.ReadOnly = true;
      this.colARACTIPIID.Visible = true;
      this.colARACTIPIID.VisibleIndex = 1;
      this.colARACTIPIID.Width = 105;
      this.AracDurum.AutoHeight = false;
      this.AracDurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AracDurum.DataSource = (object) this.tAHARACTIPIBindingSource;
      this.AracDurum.DisplayMember = "ARACTIPI";
      this.AracDurum.Name = "AracDurum";
      this.AracDurum.NullText = "";
      this.AracDurum.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.AracDurum.ValueMember = "ID";
      this.tAHARACTIPIBindingSource.DataMember = "TAHARACTIPI";
      this.tAHARACTIPIBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colCEZASAATI.Caption = "Ceza Saati";
      this.colCEZASAATI.DisplayFormat.FormatString = "HH:mm:ss";
      this.colCEZASAATI.DisplayFormat.FormatType = FormatType.DateTime;
      this.colCEZASAATI.FieldName = "CEZASAATI";
      this.colCEZASAATI.Name = "colCEZASAATI";
      this.colCEZASAATI.OptionsColumn.AllowEdit = false;
      this.colCEZASAATI.OptionsColumn.ReadOnly = true;
      this.colCEZASAATI.Visible = true;
      this.colCEZASAATI.VisibleIndex = 6;
      this.colCEZASAATI.Width = 146;
      this.colCEZATUTARI.Caption = "Ceza Tutarı";
      this.colCEZATUTARI.DisplayFormat.FormatString = "c";
      this.colCEZATUTARI.DisplayFormat.FormatType = FormatType.Numeric;
      this.colCEZATUTARI.FieldName = "CEZATUTARI";
      this.colCEZATUTARI.Name = "colCEZATUTARI";
      this.colCEZATUTARI.OptionsColumn.AllowEdit = false;
      this.colCEZATUTARI.OptionsColumn.ReadOnly = true;
      this.colCEZATUTARI.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "CEZATUTARI", "Toplam ={0:c}")
      });
      this.colCEZATUTARI.Visible = true;
      this.colCEZATUTARI.VisibleIndex = 7;
      this.colCEZATUTARI.Width = 161;
      this.colILGILINOT.Caption = "İlgili Not";
      this.colILGILINOT.FieldName = "ILGILINOT";
      this.colILGILINOT.Name = "colILGILINOT";
      this.colILGILINOT.OptionsColumn.AllowEdit = false;
      this.colILGILINOT.OptionsColumn.ReadOnly = true;
      this.colILGILINOT.Visible = true;
      this.colILGILINOT.VisibleIndex = 8;
      this.colILGILINOT.Width = 163;
      this.colADISOYADI.Caption = "Adı Soyadı";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.OptionsColumn.AllowEdit = false;
      this.colADISOYADI.OptionsColumn.ReadOnly = true;
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 9;
      this.colADISOYADI.Width = 162;
      this.colCEPTELEFON.Caption = "Telefon";
      this.colCEPTELEFON.FieldName = "CEPTELEFON";
      this.colCEPTELEFON.Name = "colCEPTELEFON";
      this.colCEPTELEFON.OptionsColumn.AllowEdit = false;
      this.colCEPTELEFON.OptionsColumn.ReadOnly = true;
      this.colCEPTELEFON.Visible = true;
      this.colCEPTELEFON.VisibleIndex = 10;
      this.colCEPTELEFON.Width = 175;
      this.colCEZAACIKLAMA.Caption = "Ceza Açıklama";
      this.colCEZAACIKLAMA.FieldName = "CEZAACIKLAMA";
      this.colCEZAACIKLAMA.Name = "colCEZAACIKLAMA";
      this.colCEZAACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colCEZAACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colCEZAACIKLAMA.Visible = true;
      this.colCEZAACIKLAMA.VisibleIndex = 11;
      this.colCEZAACIKLAMA.Width = 191;
      this.colARACDURUMID.Caption = "Araç Durum";
      this.colARACDURUMID.ColumnEdit = (RepositoryItem) this.aracDurum1;
      this.colARACDURUMID.FieldName = "ARACDURUMID";
      this.colARACDURUMID.Name = "colARACDURUMID";
      this.colARACDURUMID.OptionsColumn.AllowEdit = false;
      this.colARACDURUMID.OptionsColumn.ReadOnly = true;
      this.colARACDURUMID.Width = 124;
      this.aracDurum1.AutoHeight = false;
      this.aracDurum1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracDurum1.DataSource = (object) this.tAHARACDURUMBindingSource1;
      this.aracDurum1.DisplayMember = "ARACDURUM";
      this.aracDurum1.Name = "aracDurum1";
      this.aracDurum1.NullText = "";
      this.aracDurum1.PopupView = (ColumnView) this.gridView3;
      this.aracDurum1.ValueMember = "ID";
      this.tAHARACDURUMBindingSource1.DataMember = "TAHARACDURUM";
      this.tAHARACDURUMBindingSource1.DataSource = (object) this.bellDataSet7;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.Personel.AutoHeight = false;
      this.Personel.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Personel.DataSource = (object) this.tBLPERSONELBindingSource;
      this.Personel.DisplayMember = "ADISOYADI";
      this.Personel.Name = "Personel";
      this.Personel.PopupView = (ColumnView) this.gridView2;
      this.Personel.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.barCheckItem7.Caption = "Aktif";
      this.barCheckItem7.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem7.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem7.Id = 23;
      this.barCheckItem7.Name = "barCheckItem7";
      this.barCheckItem9.Caption = "Görevli Gelen";
      this.barCheckItem9.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem9.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem9.Id = 25;
      this.barCheckItem9.Name = "barCheckItem9";
      this.barCheckItem10.Caption = "Görevli Giden";
      this.barCheckItem10.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem10.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem10.Id = 26;
      this.barCheckItem10.Name = "barCheckItem10";
      this.barCheckItem11.Caption = "Hurda";
      this.barCheckItem11.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem11.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem11.Id = 27;
      this.barCheckItem11.Name = "barCheckItem11";
      this.barCheckItem12.Caption = "İş Görmez";
      this.barCheckItem12.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem12.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem12.Id = 28;
      this.barCheckItem12.Name = "barCheckItem12";
      this.barCheckItem13.Caption = "Çalıntı";
      this.barCheckItem13.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem13.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem13.Id = 29;
      this.barCheckItem13.Name = "barCheckItem13";
      this.barCheckItem8.Caption = "Pasif Kiralık";
      this.barCheckItem8.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem8.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem8.Id = 30;
      this.barCheckItem8.Name = "barCheckItem8";
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 31;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Caption = "Zimmet";
      this.barButtonItem9.Id = 32;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem10.Caption = "Yazdır";
      this.barButtonItem10.Id = 33;
      this.barButtonItem10.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.Image");
      this.barButtonItem10.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.LargeImage");
      this.barButtonItem10.LargeWidth = 100;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem12.Caption = "Excel";
      this.barButtonItem12.Id = 35;
      this.barButtonItem12.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.Image");
      this.barButtonItem12.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.LargeImage");
      this.barButtonItem12.LargeWidth = 100;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem12.ItemClick += new ItemClickEventHandler(this.barButtonItem12_ItemClick);
      this.barButtonItem11.Caption = "Kapat";
      this.barButtonItem11.Id = 36;
      this.barButtonItem11.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.Image");
      this.barButtonItem11.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.LargeImage");
      this.barButtonItem11.LargeWidth = 100;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem13.Caption = "Yazdır";
      this.barButtonItem13.Id = 37;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barCheckItem14.Caption = "Resmi";
      this.barCheckItem14.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem14.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem14.Id = 38;
      this.barCheckItem14.Name = "barCheckItem14";
      this.barCheckItem14.CheckedChanged += new ItemClickEventHandler(this.barCheckItem14_CheckedChanged);
      this.barCheckItem15.Caption = "Destek Kiralık";
      this.barCheckItem15.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem15.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem15.Id = 39;
      this.barCheckItem15.Name = "barCheckItem15";
      this.barCheckItem15.CheckedChanged += new ItemClickEventHandler(this.barCheckItem15_CheckedChanged);
      this.barCheckItem16.Caption = "Beklemede";
      this.barCheckItem16.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem16.Id = 40;
      this.barCheckItem16.Name = "barCheckItem16";
      this.barCheckItem16.CheckedChanged += new ItemClickEventHandler(this.barCheckItem16_CheckedChanged);
      this.barCheckItem17.Caption = "Tahsil Edildi";
      this.barCheckItem17.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem17.Id = 41;
      this.barCheckItem17.Name = "barCheckItem17";
      this.barCheckItem17.CheckedChanged += new ItemClickEventHandler(this.barCheckItem17_CheckedChanged);
      this.barCheckItem18.Caption = "Ödendi";
      this.barCheckItem18.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem18.Id = 42;
      this.barCheckItem18.Name = "barCheckItem18";
      this.barCheckItem18.CheckedChanged += new ItemClickEventHandler(this.barCheckItem18_CheckedChanged);
      this.barCheckItem19.Caption = "İptal";
      this.barCheckItem19.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem19.Id = 43;
      this.barCheckItem19.Name = "barCheckItem19";
      this.barCheckItem19.CheckedChanged += new ItemClickEventHandler(this.barCheckItem19_CheckedChanged);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[6]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup5,
        this.ribbonPageGroup7,
        this.ribbonPageGroup1,
        this.ribbonPageGroup6,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem5);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem14);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem15);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup7.ItemLinks.Add((BarItem) this.barCheckItem18);
      this.ribbonPageGroup7.ItemLinks.Add((BarItem) this.barCheckItem19);
      this.ribbonPageGroup7.ItemLinks.Add((BarItem) this.barCheckItem16);
      this.ribbonPageGroup7.ItemLinks.Add((BarItem) this.barCheckItem17);
      this.ribbonPageGroup7.Name = "ribbonPageGroup7";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem12);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem11);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.tAHARACDURUMBindingSource.DataMember = "TAHARACDURUM";
      this.tAHARACDURUMBindingSource.DataSource = (object) this.bellDataSet7;
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.barEditItem3.Caption = "Kayıt Bul..";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 100;
      this.barEditItem3.Id = 13;
      this.barEditItem3.Name = "barEditItem3";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tAHARACDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tAHARACTIPITableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1263, 575);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (TrafikCezaKaydiListesi);
      this.Text = "Trafik Ceza Kaydı Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.repositoryItemCheckEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.aracTrafikCeza.EndInit();
      this.gridView1.EndInit();
      this.AracDurum.EndInit();
      ((ISupportInitialize) this.tAHARACTIPIBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.aracDurum1.EndInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource1).EndInit();
      this.gridView3.EndInit();
      this.Personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView2.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      ((ISupportInitialize) this.tAHARACDURUMBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
