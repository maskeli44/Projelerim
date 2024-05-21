﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.AracHgsListesi
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
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class AracHgsListesi : Form
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
    private bellDataSet7 bellDataSet7;
    private BindingSource tAHARACHGSBindingSource;
    private TAHARACHGSTableAdapter tAHARACHGSTableAdapter;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private GridControl gridControl1;
    private GridView gridView1;
    private GridColumn colID;
    private GridColumn colHGSTARIH;
    private GridColumn colHGSETIKETNO;
    private GridColumn colGUNCELARAC;
    private GridColumn colGUNCELTARIH;
    private GridColumn colIPTALTARIH;
    private GridColumn colILGILINOT;
    private GridColumn colARACID;
    private RepositoryItemLookUpEdit Plaka;

    public AracHgsListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new AracHgsEkle().Show();
    }

    private void Form6_Load(object sender, EventArgs e) => this.Yenile();

    public void Yenile()
    {
      try
      {
        this.tAHARACHGSTableAdapter.Fill(this.bellDataSet7.TAHARACHGS);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new AracHgsGuncelle().Show();
      try
      {
        this.tAHARACHGSTableAdapter.Fill(this.bellDataSet7.TAHARACHGS);
      }
      catch (Exception ex)
      {
      }
    }

    private void barCheckItem8_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new AracHgsGuncelle().Show();
      try
      {
        this.tAHARACHGSTableAdapter.Fill(this.bellDataSet7.TAHARACHGS);
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.Yenile();

    private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.db.TAHARACHGS.Remove(this.db.TAHARACHGS.Find(new object[1]
      {
        (object) YetkiClass.secim_id
      }));
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
      LogEkle.Logs("Silme Yapti");
      try
      {
        this.tAHARACHGSTableAdapter.Fill(this.bellDataSet7.TAHARACHGS);
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_Load(object sender, EventArgs e) => this.satirToplam();

    private void satirToplam()
    {
    }

    private void gridControl1_FocusedViewChanged(object sender, ViewFocusEventArgs e) => this.satirToplam();

    private void gridControl1_DefaultViewChanged(object sender, EventArgs e) => this.satirToplam();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracHgsListesi));
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
      this.tAHARACHGSBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
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
      this.tAHARACHGSTableAdapter = new TAHARACHGSTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.Plaka = new RepositoryItemLookUpEdit();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colHGSTARIH = new GridColumn();
      this.colHGSETIKETNO = new GridColumn();
      this.colGUNCELARAC = new GridColumn();
      this.colGUNCELTARIH = new GridColumn();
      this.colIPTALTARIH = new GridColumn();
      this.colILGILINOT = new GridColumn();
      this.colARACID = new GridColumn();
      this.gridControl1 = new GridControl();
      this.repositoryItemCheckEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      ((ISupportInitialize) this.tAHARACHGSBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.Plaka.BeginInit();
      this.gridView1.BeginInit();
      this.gridControl1.BeginInit();
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
      this.ribbonControl1.Margin = new Padding(2, 2, 2, 2);
      this.ribbonControl1.MaxItemId = 36;
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
      this.ribbonControl1.Size = new Size(1231, 100);
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
      this.tAHARACHGSBindingSource.DataMember = "TAHARACHGS";
      this.tAHARACHGSBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
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
      this.tAHARACHGSTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.Plaka.AutoHeight = false;
      this.Plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.Plaka.DataSource = (object) this.tBLARACLARBindingSource;
      this.Plaka.DisplayMember = "PLAKA";
      this.Plaka.Name = "Plaka";
      this.Plaka.ValueMember = "ID";
      this.gridView1.Appearance.EvenRow.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = SystemColors.Control;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[8]
      {
        this.colID,
        this.colHGSTARIH,
        this.colHGSETIKETNO,
        this.colGUNCELARAC,
        this.colGUNCELTARIH,
        this.colIPTALTARIH,
        this.colILGILINOT,
        this.colARACID
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "GRUPLA";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.OptionsView.ShowFooter = true;
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colHGSTARIH.Caption = "Hgs Tarih";
      this.colHGSTARIH.DisplayFormat.FormatString = "d";
      this.colHGSTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colHGSTARIH.FieldName = "HGSTARIH";
      this.colHGSTARIH.Name = "colHGSTARIH";
      this.colHGSTARIH.OptionsColumn.AllowEdit = false;
      this.colHGSTARIH.OptionsColumn.ReadOnly = true;
      this.colHGSTARIH.Visible = true;
      this.colHGSTARIH.VisibleIndex = 1;
      this.colHGSTARIH.Width = 152;
      this.colHGSETIKETNO.Caption = "Hgs Etiket No";
      this.colHGSETIKETNO.FieldName = "HGSETIKETNO";
      this.colHGSETIKETNO.Name = "colHGSETIKETNO";
      this.colHGSETIKETNO.OptionsColumn.AllowEdit = false;
      this.colHGSETIKETNO.OptionsColumn.ReadOnly = true;
      this.colHGSETIKETNO.Visible = true;
      this.colHGSETIKETNO.VisibleIndex = 2;
      this.colHGSETIKETNO.Width = 153;
      this.colGUNCELARAC.Caption = "Güncel Arac";
      this.colGUNCELARAC.FieldName = "GUNCELARAC";
      this.colGUNCELARAC.Name = "colGUNCELARAC";
      this.colGUNCELARAC.OptionsColumn.AllowEdit = false;
      this.colGUNCELARAC.OptionsColumn.ReadOnly = true;
      this.colGUNCELARAC.Visible = true;
      this.colGUNCELARAC.VisibleIndex = 3;
      this.colGUNCELARAC.Width = 140;
      this.colGUNCELTARIH.Caption = "Güncel Tarih";
      this.colGUNCELTARIH.DisplayFormat.FormatString = "d";
      this.colGUNCELTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colGUNCELTARIH.FieldName = "GUNCELTARIH";
      this.colGUNCELTARIH.Name = "colGUNCELTARIH";
      this.colGUNCELTARIH.OptionsColumn.AllowEdit = false;
      this.colGUNCELTARIH.OptionsColumn.ReadOnly = true;
      this.colGUNCELTARIH.Visible = true;
      this.colGUNCELTARIH.VisibleIndex = 4;
      this.colGUNCELTARIH.Width = 148;
      this.colIPTALTARIH.Caption = "İptal Tarihi";
      this.colIPTALTARIH.DisplayFormat.FormatString = "d";
      this.colIPTALTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colIPTALTARIH.FieldName = "IPTALTARIH";
      this.colIPTALTARIH.Name = "colIPTALTARIH";
      this.colIPTALTARIH.OptionsColumn.AllowEdit = false;
      this.colIPTALTARIH.OptionsColumn.ReadOnly = true;
      this.colIPTALTARIH.Visible = true;
      this.colIPTALTARIH.VisibleIndex = 5;
      this.colIPTALTARIH.Width = 160;
      this.colILGILINOT.Caption = "İlgili Not";
      this.colILGILINOT.FieldName = "ILGILINOT";
      this.colILGILINOT.Name = "colILGILINOT";
      this.colILGILINOT.OptionsColumn.AllowEdit = false;
      this.colILGILINOT.OptionsColumn.ReadOnly = true;
      this.colILGILINOT.Visible = true;
      this.colILGILINOT.VisibleIndex = 6;
      this.colILGILINOT.Width = 141;
      this.colARACID.Caption = "Plaka";
      this.colARACID.ColumnEdit = (RepositoryItem) this.Plaka;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "ARACID", "Kayıt Sayısı = {0}")
      });
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 0;
      this.colARACID.Width = 141;
      this.gridControl1.DataSource = (object) this.tAHARACHGSBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.Plaka
      });
      this.gridControl1.Size = new Size(1231, 520);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DefaultViewChanged += new EventHandler(this.gridControl1_DefaultViewChanged);
      this.gridControl1.Load += new EventHandler(this.gridControl1_Load);
      this.gridControl1.FocusedViewChanged += new ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1231, 620);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = nameof (AracHgsListesi);
      this.Text = "HGS  Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.repositoryItemCheckEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      ((ISupportInitialize) this.tAHARACHGSBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.Plaka.EndInit();
      this.gridView1.EndInit();
      this.gridControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}