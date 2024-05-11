// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Akaryakit.AracYakitKonrol
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
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Akaryakit
{
  public class AracYakitKonrol : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem düzenleButton;
    private BarButtonItem silButton;
    private BarButtonItem yenileButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem1;
    private BarButtonItem yeniButton;
    private BarButtonItem excelButton;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup3;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLYAKITKONTFORMBindingSource;
    private TBLYAKITKONTFORMTableAdapter tBLYAKITKONTFORMTableAdapter;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colPLAKA;
    private GridColumn colEBYSTARIH;
    private GridColumn colEBYSSAYI;
    private GridColumn colGIRISZAMAN;
    private GridColumn colCIKISZAMAN;
    private GridColumn colBIRIMID;
    private GridColumn colMUDURLUKID;
    private GridColumn colSOFOROPERATOR;
    private GridColumn colISTASYONPERSID;
    private GridColumn colILGILIBIRIMPERSID;
    private GridColumn colOTOMASYONPERSID;
    private RepositoryItemLookUpEdit birimID;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private RepositoryItemLookUpEdit mudurlukID;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private RepositoryItemLookUpEdit istasyonPersID;
    private RepositoryItemLookUpEdit ilgiliBirimPersonelID;
    private RepositoryItemLookUpEdit otomasyonPersID;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public AracYakitKonrol() => this.InitializeComponent();

    private void AracYakitKonrol_Load(object sender, EventArgs e) => this.Yenile();

    public void Yenile()
    {
      this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet2.TBLBELDMUDURLUK);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet2.TBLBELDBIRIMLER);
      this.tBLYAKITKONTFORMTableAdapter.Fill(this.bellDataSet2.TBLYAKITKONTFORM);
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void yenileButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.Yenile();
      this.gridView1.SelectRow(this.gridView1.RowCount);
    }

    private void excelButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      AracYakitKontrolKayit yakitKontrolKayit = new AracYakitKontrolKayit();
      yakitKontrolKayit.Show();
      yakitKontrolKayit.duzen = 2;
      yakitKontrolKayit.guncelleLoad(int32);
    }

    private void yeniButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      AracYakitKontrolKayit yakitKontrolKayit = new AracYakitKontrolKayit();
      yakitKontrolKayit.Show();
      yakitKontrolKayit.duzen = 1;
    }

    private void düzenleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int int32 = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      AracYakitKontrolKayit yakitKontrolKayit = new AracYakitKontrolKayit();
      yakitKontrolKayit.Show();
      yakitKontrolKayit.duzen = 2;
      yakitKontrolKayit.guncelleLoad(int32);
    }

    private void silButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.db.TBLYAKITKONTFORM.Remove(this.db.TBLYAKITKONTFORM.Find(new object[1]
      {
        (object) YetkiClass.secim_id
      }));
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
      LogEkle.Logs("Silme Yapti");
      this.tBLYAKITKONTFORMTableAdapter.Fill(this.bellDataSet2.TBLYAKITKONTFORM);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracYakitKonrol));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.düzenleButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.yenileButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.yeniButton = new BarButtonItem();
      this.excelButton = new BarButtonItem();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.gridControl1 = new GridControl();
      this.tBLYAKITKONTFORMBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colEBYSTARIH = new GridColumn();
      this.colEBYSSAYI = new GridColumn();
      this.colGIRISZAMAN = new GridColumn();
      this.colCIKISZAMAN = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.birimID = new RepositoryItemLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.colMUDURLUKID = new GridColumn();
      this.mudurlukID = new RepositoryItemLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.colSOFOROPERATOR = new GridColumn();
      this.colISTASYONPERSID = new GridColumn();
      this.istasyonPersID = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colILGILIBIRIMPERSID = new GridColumn();
      this.ilgiliBirimPersonelID = new RepositoryItemLookUpEdit();
      this.colOTOMASYONPERSID = new GridColumn();
      this.otomasyonPersID = new RepositoryItemLookUpEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.tBLYAKITKONTFORMTableAdapter = new TBLYAKITKONTFORMTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonControl1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLYAKITKONTFORMBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.gridView1.BeginInit();
      this.birimID.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.mudurlukID.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.istasyonPersID.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.ilgiliBirimPersonelID.BeginInit();
      this.otomasyonPersID.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[12]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.düzenleButton,
        (BarItem) this.silButton,
        (BarItem) this.yenileButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1,
        (BarItem) this.yeniButton,
        (BarItem) this.excelButton,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 14;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1110, 100);
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
      this.düzenleButton.Caption = "Düzenle";
      this.düzenleButton.Id = 2;
      this.düzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.Image");
      this.düzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("düzenleButton.ImageOptions.LargeImage");
      this.düzenleButton.LargeWidth = 100;
      this.düzenleButton.Name = "düzenleButton";
      this.düzenleButton.ItemClick += new ItemClickEventHandler(this.düzenleButton_ItemClick);
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
      this.silButton.ItemClick += new ItemClickEventHandler(this.silButton_ItemClick);
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
      this.barButtonItem7.Caption = "Kapat";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.LargeWidth = 100;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barButtonItem7.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem7.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.yeniButton.Caption = "Yeni";
      this.yeniButton.Id = 9;
      this.yeniButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.Image");
      this.yeniButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.LargeImage");
      this.yeniButton.LargeWidth = 100;
      this.yeniButton.Name = "yeniButton";
      this.yeniButton.ItemClick += new ItemClickEventHandler(this.yeniButton_ItemClick);
      this.excelButton.Caption = "Excel";
      this.excelButton.Id = 11;
      this.excelButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.Image");
      this.excelButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("excelButton.ImageOptions.LargeImage");
      this.excelButton.LargeWidth = 100;
      this.excelButton.Name = "excelButton";
      this.excelButton.ItemClick += new ItemClickEventHandler(this.excelButton_ItemClick);
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemTextEdit1.NullText = "Kayit Bul...";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.düzenleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.yenileButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.excelButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1110, 617);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.gridControl1.DataSource = (object) this.tBLYAKITKONTFORMBindingSource;
      this.gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(11, 10);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.birimID,
        (RepositoryItem) this.mudurlukID,
        (RepositoryItem) this.istasyonPersID,
        (RepositoryItem) this.ilgiliBirimPersonelID,
        (RepositoryItem) this.otomasyonPersID
      });
      this.gridControl1.Size = new Size(1088, 597);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_Click);
      this.tBLYAKITKONTFORMBindingSource.DataMember = "TBLYAKITKONTFORM";
      this.tBLYAKITKONTFORMBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.colID,
        this.colKOD,
        this.colPLAKA,
        this.colEBYSTARIH,
        this.colEBYSSAYI,
        this.colGIRISZAMAN,
        this.colCIKISZAMAN,
        this.colBIRIMID,
        this.colMUDURLUKID,
        this.colSOFOROPERATOR,
        this.colISTASYONPERSID,
        this.colILGILIBIRIMPERSID,
        this.colOTOMASYONPERSID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.ReadOnly = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colID.AppearanceCell.ForeColor = Color.Black;
      this.colID.AppearanceCell.Options.UseForeColor = true;
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colKOD.AppearanceCell.ForeColor = Color.Black;
      this.colKOD.AppearanceCell.Options.UseForeColor = true;
      this.colKOD.Caption = "Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colPLAKA.AppearanceCell.ForeColor = Color.Black;
      this.colPLAKA.AppearanceCell.Options.UseForeColor = true;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colEBYSTARIH.AppearanceCell.ForeColor = Color.Black;
      this.colEBYSTARIH.AppearanceCell.Options.UseForeColor = true;
      this.colEBYSTARIH.Caption = "EBYS Tarih";
      this.colEBYSTARIH.FieldName = "EBYSTARIH";
      this.colEBYSTARIH.Name = "colEBYSTARIH";
      this.colEBYSTARIH.OptionsColumn.AllowEdit = false;
      this.colEBYSTARIH.OptionsColumn.ReadOnly = true;
      this.colEBYSTARIH.Visible = true;
      this.colEBYSTARIH.VisibleIndex = 2;
      this.colEBYSSAYI.AppearanceCell.ForeColor = Color.Black;
      this.colEBYSSAYI.AppearanceCell.Options.UseForeColor = true;
      this.colEBYSSAYI.Caption = "EBYS Sayı";
      this.colEBYSSAYI.FieldName = "EBYSSAYI";
      this.colEBYSSAYI.Name = "colEBYSSAYI";
      this.colEBYSSAYI.OptionsColumn.AllowEdit = false;
      this.colEBYSSAYI.OptionsColumn.ReadOnly = true;
      this.colEBYSSAYI.Visible = true;
      this.colEBYSSAYI.VisibleIndex = 3;
      this.colGIRISZAMAN.AppearanceCell.ForeColor = Color.Black;
      this.colGIRISZAMAN.AppearanceCell.Options.UseForeColor = true;
      this.colGIRISZAMAN.Caption = "Giriş Zamanı";
      this.colGIRISZAMAN.FieldName = "GIRISZAMAN";
      this.colGIRISZAMAN.Name = "colGIRISZAMAN";
      this.colGIRISZAMAN.OptionsColumn.AllowEdit = false;
      this.colGIRISZAMAN.OptionsColumn.ReadOnly = true;
      this.colGIRISZAMAN.Visible = true;
      this.colGIRISZAMAN.VisibleIndex = 4;
      this.colCIKISZAMAN.AppearanceCell.ForeColor = Color.Black;
      this.colCIKISZAMAN.AppearanceCell.Options.UseForeColor = true;
      this.colCIKISZAMAN.Caption = "Çıkış Zamanı";
      this.colCIKISZAMAN.FieldName = "CIKISZAMAN";
      this.colCIKISZAMAN.Name = "colCIKISZAMAN";
      this.colCIKISZAMAN.OptionsColumn.AllowEdit = false;
      this.colCIKISZAMAN.OptionsColumn.ReadOnly = true;
      this.colCIKISZAMAN.Visible = true;
      this.colCIKISZAMAN.VisibleIndex = 5;
      this.colBIRIMID.AppearanceCell.ForeColor = Color.Black;
      this.colBIRIMID.AppearanceCell.Options.UseForeColor = true;
      this.colBIRIMID.Caption = "Birim Adı";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.birimID;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 6;
      this.birimID.AutoHeight = false;
      this.birimID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimID.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.birimID.DisplayMember = "BELDBIRIMADI";
      this.birimID.Name = "birimID";
      this.birimID.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet2;
      this.colMUDURLUKID.AppearanceCell.ForeColor = Color.Black;
      this.colMUDURLUKID.AppearanceCell.Options.UseForeColor = true;
      this.colMUDURLUKID.Caption = "Müdürlük Adı";
      this.colMUDURLUKID.ColumnEdit = (RepositoryItem) this.mudurlukID;
      this.colMUDURLUKID.FieldName = "MUDURLUKID";
      this.colMUDURLUKID.Name = "colMUDURLUKID";
      this.colMUDURLUKID.OptionsColumn.AllowEdit = false;
      this.colMUDURLUKID.OptionsColumn.ReadOnly = true;
      this.colMUDURLUKID.Visible = true;
      this.colMUDURLUKID.VisibleIndex = 7;
      this.mudurlukID.AutoHeight = false;
      this.mudurlukID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurlukID.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.mudurlukID.DisplayMember = "BELDMUDURLUK";
      this.mudurlukID.Name = "mudurlukID";
      this.mudurlukID.ValueMember = "ID";
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet2;
      this.colSOFOROPERATOR.AppearanceCell.ForeColor = Color.Black;
      this.colSOFOROPERATOR.AppearanceCell.Options.UseForeColor = true;
      this.colSOFOROPERATOR.Caption = "Şöför & Operatör";
      this.colSOFOROPERATOR.FieldName = "SOFOROPERATOR";
      this.colSOFOROPERATOR.Name = "colSOFOROPERATOR";
      this.colSOFOROPERATOR.OptionsColumn.AllowEdit = false;
      this.colSOFOROPERATOR.OptionsColumn.ReadOnly = true;
      this.colSOFOROPERATOR.Visible = true;
      this.colSOFOROPERATOR.VisibleIndex = 8;
      this.colISTASYONPERSID.AppearanceCell.ForeColor = Color.Black;
      this.colISTASYONPERSID.AppearanceCell.Options.UseForeColor = true;
      this.colISTASYONPERSID.Caption = "İstasyon Görevlisi";
      this.colISTASYONPERSID.ColumnEdit = (RepositoryItem) this.istasyonPersID;
      this.colISTASYONPERSID.FieldName = "ISTASYONPERSID";
      this.colISTASYONPERSID.Name = "colISTASYONPERSID";
      this.colISTASYONPERSID.OptionsColumn.AllowEdit = false;
      this.colISTASYONPERSID.OptionsColumn.ReadOnly = true;
      this.colISTASYONPERSID.Visible = true;
      this.colISTASYONPERSID.VisibleIndex = 9;
      this.istasyonPersID.AutoHeight = false;
      this.istasyonPersID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.istasyonPersID.DataSource = (object) this.tBLPERSONELBindingSource;
      this.istasyonPersID.DisplayMember = "ADISOYADI";
      this.istasyonPersID.Name = "istasyonPersID";
      this.istasyonPersID.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.colILGILIBIRIMPERSID.AppearanceCell.ForeColor = Color.Black;
      this.colILGILIBIRIMPERSID.AppearanceCell.Options.UseForeColor = true;
      this.colILGILIBIRIMPERSID.Caption = "Birim Personeli";
      this.colILGILIBIRIMPERSID.ColumnEdit = (RepositoryItem) this.ilgiliBirimPersonelID;
      this.colILGILIBIRIMPERSID.FieldName = "ILGILIBIRIMPERSID";
      this.colILGILIBIRIMPERSID.Name = "colILGILIBIRIMPERSID";
      this.colILGILIBIRIMPERSID.OptionsColumn.AllowEdit = false;
      this.colILGILIBIRIMPERSID.OptionsColumn.ReadOnly = true;
      this.colILGILIBIRIMPERSID.Visible = true;
      this.colILGILIBIRIMPERSID.VisibleIndex = 10;
      this.ilgiliBirimPersonelID.AutoHeight = false;
      this.ilgiliBirimPersonelID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilgiliBirimPersonelID.DataSource = (object) this.tBLPERSONELBindingSource;
      this.ilgiliBirimPersonelID.DisplayMember = "ADISOYADI";
      this.ilgiliBirimPersonelID.Name = "ilgiliBirimPersonelID";
      this.ilgiliBirimPersonelID.ValueMember = "ID";
      this.colOTOMASYONPERSID.AppearanceCell.ForeColor = Color.Black;
      this.colOTOMASYONPERSID.AppearanceCell.Options.UseForeColor = true;
      this.colOTOMASYONPERSID.Caption = "Otomasyon Görevlisi";
      this.colOTOMASYONPERSID.ColumnEdit = (RepositoryItem) this.otomasyonPersID;
      this.colOTOMASYONPERSID.FieldName = "OTOMASYONPERSID";
      this.colOTOMASYONPERSID.Name = "colOTOMASYONPERSID";
      this.colOTOMASYONPERSID.OptionsColumn.AllowEdit = false;
      this.colOTOMASYONPERSID.OptionsColumn.ReadOnly = true;
      this.colOTOMASYONPERSID.Visible = true;
      this.colOTOMASYONPERSID.VisibleIndex = 11;
      this.otomasyonPersID.AutoHeight = false;
      this.otomasyonPersID.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.otomasyonPersID.DataSource = (object) this.tBLPERSONELBindingSource;
      this.otomasyonPersID.DisplayMember = "ADISOYADI";
      this.otomasyonPersID.Name = "otomasyonPersID";
      this.otomasyonPersID.ValueMember = "ID";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1110, 617);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1092, 601);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.tBLYAKITKONTFORMTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 13;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1110, 717);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (AracYakitKonrol);
      this.Text = "Araç Yakıt Kontrol";
      this.Load += new EventHandler(this.AracYakitKonrol_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLYAKITKONTFORMBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.gridView1.EndInit();
      this.birimID.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.mudurlukID.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.istasyonPersID.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.ilgiliBirimPersonelID.EndInit();
      this.otomasyonPersID.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
