// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.FirmaListesi
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class FirmaListesi : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem yeniKayitButton;
    private BarButtonItem duzenleButton;
    private BarButtonItem silButton;
    private BarButtonItem excelButton;
    private BarButtonItem yenileButton;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem kapatButton;
    private RibbonPageGroup ribbonPageGroup4;
    private PopupMenu popupMenu1;
    private isemri isemri;
    private GridView gridView1;
    private GridControl gridControl1;
    private BarEditItem kayitBulButton;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPageGroup ribbonPageGroup3;
    private GridColumn colID;
    private GridColumn colSEKTORID;
    private GridColumn colFIRMAADI;
    private GridColumn colFALIYETALANI;
    private GridColumn colYETKILISI;
    private GridColumn colVERGIDAIRE;
    private GridColumn colVERGINO;
    private GridColumn colTELEFON;
    private GridColumn colCEPTELEFON;
    private GridColumn colEMAIL;
    private GridColumn colWEBADRES;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLFIRMASEKTORBindingSource;
    private Makina_Ikmal.bellDataSetTableAdapters.TBLFIRMASEKTORTableAdapter tBLFIRMASEKTORTableAdapter;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLFIRMALARBindingSource1;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter1;
    private BindingSource tBLFIRMASEKTORBindingSource1;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMASEKTORTableAdapter tBLFIRMASEKTORTableAdapter1;

    public FirmaListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new FirmaKayit() { secim = 1 }.ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLFIRMASEKTORTableAdapter1.Fill(this.bellDataSet5.TBLFIRMASEKTOR);
      this.tBLFIRMALARTableAdapter1.Fill(this.bellDataSet5.TBLFIRMALAR);
    }

    private void duzenleButton_ItemClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      FirmaKayit firmaKayit = new FirmaKayit();
      int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      firmaKayit.secim = 2;
      firmaKayit.Getir(int32);
      int num = (int) firmaKayit.ShowDialog();
    }

    public void Yenile()
    {
      this.tBLFIRMALARTableAdapter1.Fill(this.bellDataSet5.TBLFIRMALAR);
      this.tBLFIRMASEKTORTableAdapter1.Fill(this.bellDataSet5.TBLFIRMASEKTOR);
    }

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e) => this.Yenile();

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
    }

    private void silButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int gecerliID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      if (gecerliID == 0)
        return;
      try
      {
        this.db.TBLFIRMALAR.Remove(this.db.TBLFIRMALAR.FirstOrDefault<TBLFIRMALAR>((Expression<System.Func<TBLFIRMALAR, bool>>) (x => x.ID == gecerliID)));
        this.db.SaveChanges();
        this.tBLFIRMALARTableAdapter1.Fill(this.bellDataSet5.TBLFIRMALAR);
        int num = (int) XtraMessageBox.Show("Silme Başarı İle Tamamlanmıştır.");
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FirmaListesi));
      this.ribbonControl1 = new RibbonControl();
      this.yeniKayitButton = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.duzenleButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.yenileButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.kayitBulButton = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.isemri = new isemri();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colSEKTORID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLFIRMASEKTORBindingSource1 = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colFIRMAADI = new GridColumn();
      this.colFALIYETALANI = new GridColumn();
      this.colYETKILISI = new GridColumn();
      this.colVERGIDAIRE = new GridColumn();
      this.colVERGINO = new GridColumn();
      this.colTELEFON = new GridColumn();
      this.colCEPTELEFON = new GridColumn();
      this.colEMAIL = new GridColumn();
      this.colWEBADRES = new GridColumn();
      this.gridControl1 = new GridControl();
      this.tBLFIRMALARBindingSource1 = new BindingSource(this.components);
      this.tBLFIRMASEKTORBindingSource = new BindingSource(this.components);
      this.tBLFIRMASEKTORTableAdapter = new Makina_Ikmal.bellDataSetTableAdapters.TBLFIRMASEKTORTableAdapter();
      this.tBLFIRMALARTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMALARTableAdapter();
      this.tBLFIRMASEKTORTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLFIRMASEKTORTableAdapter();
      this.ribbonControl1.BeginInit();
      this.popupMenu1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.isemri.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource1).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource1).BeginInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[10]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.yeniKayitButton,
        (BarItem) this.duzenleButton,
        (BarItem) this.silButton,
        (BarItem) this.excelButton,
        (BarItem) this.yenileButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.kapatButton,
        (BarItem) this.kayitBulButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 9;
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
      this.ribbonControl1.Size = new Size(938, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.yeniKayitButton.ActAsDropDown = true;
      this.yeniKayitButton.ButtonStyle = BarButtonStyle.DropDown;
      this.yeniKayitButton.Caption = "Yeni Kayıt";
      this.yeniKayitButton.DropDownControl = (PopupControl) this.popupMenu1;
      this.yeniKayitButton.Id = 1;
      this.yeniKayitButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniKayitButton.ImageOptions.Image");
      this.yeniKayitButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniKayitButton.ImageOptions.LargeImage");
      this.yeniKayitButton.LargeWidth = 100;
      this.yeniKayitButton.Name = "yeniKayitButton";
      this.yeniKayitButton.RibbonStyle = RibbonItemStyles.Large;
      this.yeniKayitButton.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.duzenleButton.Caption = "Düzenle";
      this.duzenleButton.Id = 2;
      this.duzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.Image");
      this.duzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.LargeImage");
      this.duzenleButton.LargeWidth = 100;
      this.duzenleButton.Name = "duzenleButton";
      this.duzenleButton.ItemClick += new ItemClickEventHandler(this.duzenleButton_ItemClick);
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
      this.silButton.ItemClick += new ItemClickEventHandler(this.silButton_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 4;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.RibbonStyle = RibbonItemStyles.Large;
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
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
      this.kapatButton.Caption = "Kapat";
      this.kapatButton.Id = 7;
      this.kapatButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.Image");
      this.kapatButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.LargeImage");
      this.kapatButton.LargeWidth = 100;
      this.kapatButton.Name = "kapatButton";
      this.kapatButton.RibbonStyle = RibbonItemStyles.Large;
      this.kapatButton.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
      this.kayitBulButton.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.kayitBulButton.EditHeight = 25;
      this.kayitBulButton.EditWidth = 140;
      this.kayitBulButton.Hint = "Kayıt Bul...";
      this.kayitBulButton.Id = 8;
      this.kayitBulButton.Name = "kayitBulButton";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.repositoryItemSearchControl1.NullValuePrompt = "Kayıt Bul...";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.kayitBulButton);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniKayitButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.duzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.isemri.DataSetName = "isemri";
      this.isemri.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[11]
      {
        this.colID,
        this.colSEKTORID,
        this.colFIRMAADI,
        this.colFALIYETALANI,
        this.colYETKILISI,
        this.colVERGIDAIRE,
        this.colVERGINO,
        this.colTELEFON,
        this.colCEPTELEFON,
        this.colEMAIL,
        this.colWEBADRES
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.DoubleClick += new EventHandler(this.duzenleButton_ItemClick);
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.Width = 56;
      this.colSEKTORID.Caption = "Sektör Adı";
      this.colSEKTORID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colSEKTORID.FieldName = "SEKTORID";
      this.colSEKTORID.Name = "colSEKTORID";
      this.colSEKTORID.Visible = true;
      this.colSEKTORID.VisibleIndex = 0;
      this.colSEKTORID.Width = 56;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLFIRMASEKTORBindingSource1;
      this.repositoryItemLookUpEdit1.DisplayMember = "SEKTORADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLFIRMASEKTORBindingSource1.DataMember = "TBLFIRMASEKTOR";
      this.tBLFIRMASEKTORBindingSource1.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colFIRMAADI.Caption = "Firma Adı";
      this.colFIRMAADI.FieldName = "FIRMAADI";
      this.colFIRMAADI.Name = "colFIRMAADI";
      this.colFIRMAADI.Visible = true;
      this.colFIRMAADI.VisibleIndex = 1;
      this.colFIRMAADI.Width = 56;
      this.colFALIYETALANI.Caption = "Faliyet Alanı";
      this.colFALIYETALANI.FieldName = "FALIYETALANI";
      this.colFALIYETALANI.Name = "colFALIYETALANI";
      this.colFALIYETALANI.Visible = true;
      this.colFALIYETALANI.VisibleIndex = 2;
      this.colFALIYETALANI.Width = 56;
      this.colYETKILISI.Caption = "Yetkilisi";
      this.colYETKILISI.FieldName = "YETKILISI";
      this.colYETKILISI.Name = "colYETKILISI";
      this.colYETKILISI.Visible = true;
      this.colYETKILISI.VisibleIndex = 3;
      this.colYETKILISI.Width = 56;
      this.colVERGIDAIRE.Caption = "Vergi Dairesi";
      this.colVERGIDAIRE.FieldName = "VERGIDAIRE";
      this.colVERGIDAIRE.Name = "colVERGIDAIRE";
      this.colVERGIDAIRE.Visible = true;
      this.colVERGIDAIRE.VisibleIndex = 4;
      this.colVERGIDAIRE.Width = 56;
      this.colVERGINO.Caption = "Vergi No";
      this.colVERGINO.FieldName = "VERGINO";
      this.colVERGINO.Name = "colVERGINO";
      this.colVERGINO.Visible = true;
      this.colVERGINO.VisibleIndex = 5;
      this.colVERGINO.Width = 56;
      this.colTELEFON.Caption = "Telefon";
      this.colTELEFON.FieldName = "TELEFON";
      this.colTELEFON.Name = "colTELEFON";
      this.colTELEFON.Visible = true;
      this.colTELEFON.VisibleIndex = 6;
      this.colTELEFON.Width = 56;
      this.colCEPTELEFON.Caption = "Cep Teelefonu";
      this.colCEPTELEFON.FieldName = "CEPTELEFON";
      this.colCEPTELEFON.Name = "colCEPTELEFON";
      this.colCEPTELEFON.Visible = true;
      this.colCEPTELEFON.VisibleIndex = 7;
      this.colCEPTELEFON.Width = 56;
      this.colEMAIL.Caption = "Email";
      this.colEMAIL.FieldName = "EMAIL";
      this.colEMAIL.Name = "colEMAIL";
      this.colEMAIL.Visible = true;
      this.colEMAIL.VisibleIndex = 8;
      this.colEMAIL.Width = 56;
      this.colWEBADRES.Caption = "Web Adresi";
      this.colWEBADRES.FieldName = "WEBADRES";
      this.colWEBADRES.Name = "colWEBADRES";
      this.colWEBADRES.Visible = true;
      this.colWEBADRES.VisibleIndex = 9;
      this.colWEBADRES.Width = 56;
      this.gridControl1.DataSource = (object) this.tBLFIRMALARBindingSource1;
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
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(938, 473);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.tBLFIRMALARBindingSource1.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource1.DataSource = (object) this.bellDataSet5;
      this.tBLFIRMASEKTORTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter1.ClearBeforeFill = true;
      this.tBLFIRMASEKTORTableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(938, 573);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (FirmaListesi);
      this.Text = "Form6";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.popupMenu1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.isemri.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource1).EndInit();
      this.bellDataSet5.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource1).EndInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
