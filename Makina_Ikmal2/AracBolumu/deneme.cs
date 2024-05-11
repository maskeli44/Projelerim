// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.deneme
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class deneme : Form
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
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLARACZIMMETBindingSource;
    private TBLARACZIMMETTableAdapter tBLARACZIMMETTableAdapter;
    private GridColumn Araç;
    private GridColumn colTARIH;
    private GridColumn colSAAT;
    private GridColumn colZIMMETALANID;
    private GridColumn colTAHSISEDILENID;
    private GridColumn colONCEKIARACI;
    private GridColumn colBELDBIRIMID;
    private GridColumn colBELDMUDURLUKID;
    private GridColumn colILGILINOT;
    private RepositoryItemLookUpEdit Plaka;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemLookUpEdit ZimmetAlan;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemLookUpEdit TahsisEdilen;
    private RepositoryItemLookUpEdit BelediyeBirim;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private RepositoryItemLookUpEdit BelediyeMudurluk;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private GridColumn ID;
    private LayoutControl layoutControl1;
    private DataNavigator dataNavigator1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;

    public deneme() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new ZimmetKaydiEkle().Show();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      try
      {
        this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACZIMMETTableAdapter.Fill(this.bellDataSet5.TBLARACZIMMET);
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new ZimmetKaydiGuncelle().Show();
    }

    private void barCheckItem8_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new ZimmetKaydiGuncelle().Show();
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        this.tBLARACZIMMETTableAdapter.Fill(this.bellDataSet5.TBLARACZIMMET);
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.yet.yetkiislemleri("Zimmet Listesi");
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLARACZIMMET.Remove(this.db.TBLARACZIMMET.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
        this.tBLARACZIMMETTableAdapter.Fill(this.bellDataSet5.TBLARACZIMMET);
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (deneme));
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
      this.tBLARACZIMMETBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.Araç = new GridColumn();
      this.Plaka = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.colTARIH = new GridColumn();
      this.colSAAT = new GridColumn();
      this.colZIMMETALANID = new GridColumn();
      this.ZimmetAlan = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colTAHSISEDILENID = new GridColumn();
      this.TahsisEdilen = new RepositoryItemLookUpEdit();
      this.colONCEKIARACI = new GridColumn();
      this.colBELDBIRIMID = new GridColumn();
      this.BelediyeBirim = new RepositoryItemLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.colBELDMUDURLUKID = new GridColumn();
      this.BelediyeMudurluk = new RepositoryItemLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.colILGILINOT = new GridColumn();
      this.ID = new GridColumn();
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
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.barEditItem3 = new BarEditItem();
      this.tBLARACZIMMETTableAdapter = new TBLARACZIMMETTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.dataNavigator1 = new DataNavigator();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.repositoryItemCheckEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLARACZIMMETBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.Plaka.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.ZimmetAlan.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.TahsisEdilen.BeginInit();
      this.BelediyeBirim.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.BelediyeMudurluk.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
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
      this.ribbonControl1.Items.AddRange(new BarItem[30]
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
        (BarItem) this.barButtonItem12
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 36;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 329;
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
      this.ribbonControl1.Size = new Size(1641, 118);
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
      this.gridControl1.DataSource = (object) this.tBLARACZIMMETBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 118);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.Plaka,
        (RepositoryItem) this.ZimmetAlan,
        (RepositoryItem) this.TahsisEdilen,
        (RepositoryItem) this.BelediyeBirim,
        (RepositoryItem) this.BelediyeMudurluk
      });
      this.gridControl1.Size = new Size(1641, 567);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLARACZIMMETBindingSource.DataMember = "TBLARACZIMMET";
      this.tBLARACZIMMETBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = SystemColors.Control;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[10]
      {
        this.Araç,
        this.colTARIH,
        this.colSAAT,
        this.colZIMMETALANID,
        this.colTAHSISEDILENID,
        this.colONCEKIARACI,
        this.colBELDBIRIMID,
        this.colBELDMUDURLUKID,
        this.colILGILINOT,
        this.ID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.Araç.Caption = "Araç";
      this.Araç.ColumnEdit = (RepositoryItem) this.Plaka;
      this.Araç.FieldName = "ARACID";
      this.Araç.MinWidth = 27;
      this.Araç.Name = "Araç";
      this.Araç.Visible = true;
      this.Araç.VisibleIndex = 0;
      this.Araç.Width = 100;
      this.Plaka.AutoHeight = false;
      this.Plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Plaka.DataSource = (object) this.tBLARACLARBindingSource;
      this.Plaka.DisplayMember = "PLAKA";
      this.Plaka.Name = "Plaka";
      this.Plaka.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.DisplayFormat.FormatString = "d";
      this.colTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 27;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 1;
      this.colTARIH.Width = 116;
      this.colSAAT.Caption = "Saat";
      this.colSAAT.DisplayFormat.FormatString = "hh : mm";
      this.colSAAT.DisplayFormat.FormatType = FormatType.DateTime;
      this.colSAAT.FieldName = "SAAT";
      this.colSAAT.MinWidth = 27;
      this.colSAAT.Name = "colSAAT";
      this.colSAAT.Visible = true;
      this.colSAAT.VisibleIndex = 2;
      this.colSAAT.Width = 92;
      this.colZIMMETALANID.Caption = "Zimmet Alan";
      this.colZIMMETALANID.ColumnEdit = (RepositoryItem) this.ZimmetAlan;
      this.colZIMMETALANID.FieldName = "ZIMMETALANID";
      this.colZIMMETALANID.MinWidth = 27;
      this.colZIMMETALANID.Name = "colZIMMETALANID";
      this.colZIMMETALANID.Visible = true;
      this.colZIMMETALANID.VisibleIndex = 3;
      this.colZIMMETALANID.Width = 128;
      this.ZimmetAlan.AutoHeight = false;
      this.ZimmetAlan.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ZimmetAlan.DataSource = (object) this.tBLPERSONELBindingSource;
      this.ZimmetAlan.DisplayMember = "ADISOYADI";
      this.ZimmetAlan.Name = "ZimmetAlan";
      this.ZimmetAlan.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.colTAHSISEDILENID.Caption = "Tahsis Edilen";
      this.colTAHSISEDILENID.ColumnEdit = (RepositoryItem) this.TahsisEdilen;
      this.colTAHSISEDILENID.FieldName = "TAHSISEDILENID";
      this.colTAHSISEDILENID.MinWidth = 27;
      this.colTAHSISEDILENID.Name = "colTAHSISEDILENID";
      this.colTAHSISEDILENID.Visible = true;
      this.colTAHSISEDILENID.VisibleIndex = 4;
      this.colTAHSISEDILENID.Width = 121;
      this.TahsisEdilen.AutoHeight = false;
      this.TahsisEdilen.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.TahsisEdilen.DataSource = (object) this.tBLPERSONELBindingSource;
      this.TahsisEdilen.DisplayMember = "ADISOYADI";
      this.TahsisEdilen.Name = "TahsisEdilen";
      this.TahsisEdilen.ValueMember = "ID";
      this.colONCEKIARACI.Caption = "Önceki Araç";
      this.colONCEKIARACI.FieldName = "ONCEKIARACI";
      this.colONCEKIARACI.MinWidth = 27;
      this.colONCEKIARACI.Name = "colONCEKIARACI";
      this.colONCEKIARACI.Visible = true;
      this.colONCEKIARACI.VisibleIndex = 5;
      this.colONCEKIARACI.Width = 135;
      this.colBELDBIRIMID.Caption = "Belediye Birim";
      this.colBELDBIRIMID.ColumnEdit = (RepositoryItem) this.BelediyeBirim;
      this.colBELDBIRIMID.FieldName = "BELDBIRIMID";
      this.colBELDBIRIMID.MinWidth = 27;
      this.colBELDBIRIMID.Name = "colBELDBIRIMID";
      this.colBELDBIRIMID.Visible = true;
      this.colBELDBIRIMID.VisibleIndex = 6;
      this.colBELDBIRIMID.Width = 105;
      this.BelediyeBirim.AutoHeight = false;
      this.BelediyeBirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BelediyeBirim.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.BelediyeBirim.DisplayMember = "BELDBIRIMADI";
      this.BelediyeBirim.Name = "BelediyeBirim";
      this.BelediyeBirim.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBELDMUDURLUKID.Caption = "Belediye Müdürlük";
      this.colBELDMUDURLUKID.ColumnEdit = (RepositoryItem) this.BelediyeMudurluk;
      this.colBELDMUDURLUKID.FieldName = "BELDMUDURLUKID";
      this.colBELDMUDURLUKID.MinWidth = 27;
      this.colBELDMUDURLUKID.Name = "colBELDMUDURLUKID";
      this.colBELDMUDURLUKID.Visible = true;
      this.colBELDMUDURLUKID.VisibleIndex = 7;
      this.colBELDMUDURLUKID.Width = 133;
      this.BelediyeMudurluk.AutoHeight = false;
      this.BelediyeMudurluk.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BelediyeMudurluk.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.BelediyeMudurluk.DisplayMember = "BELDMUDURLUK";
      this.BelediyeMudurluk.Name = "BelediyeMudurluk";
      this.BelediyeMudurluk.ValueMember = "ID";
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.colILGILINOT.Caption = "İlgili Not";
      this.colILGILINOT.FieldName = "ILGILINOT";
      this.colILGILINOT.MinWidth = 27;
      this.colILGILINOT.Name = "colILGILINOT";
      this.colILGILINOT.Visible = true;
      this.colILGILINOT.VisibleIndex = 8;
      this.colILGILINOT.Width = 100;
      this.ID.Caption = "ID";
      this.ID.FieldName = "ID";
      this.ID.MinWidth = 27;
      this.ID.Name = "ID";
      this.ID.Width = 100;
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup6
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem5);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem12);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
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
      this.tBLARACZIMMETTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.layoutControl1.Controls.Add((Control) this.dataNavigator1);
      this.layoutControl1.Dock = DockStyle.Bottom;
      this.layoutControl1.Location = new Point(0, 685);
      this.layoutControl1.Margin = new Padding(4, 4, 4, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1641, 78);
      this.layoutControl1.TabIndex = 5;
      this.layoutControl1.Text = "layoutControl1";
      this.dataNavigator1.Location = new Point(16, 14);
      this.dataNavigator1.Margin = new Padding(4, 4, 4, 4);
      this.dataNavigator1.Name = "dataNavigator1";
      this.dataNavigator1.Size = new Size(273, 22);
      this.dataNavigator1.StyleController = (IStyleController) this.layoutControl1;
      this.dataNavigator1.TabIndex = 4;
      this.dataNavigator1.Text = "dataNavigator1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1641, 78);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.dataNavigator1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1615, 26);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 26);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(1615, 28);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1641, 763);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (deneme);
      this.Text = "Zimmet Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.repositoryItemCheckEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLARACZIMMETBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.Plaka.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.ZimmetAlan.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.TahsisEdilen.EndInit();
      this.BelediyeBirim.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.BelediyeMudurluk.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
