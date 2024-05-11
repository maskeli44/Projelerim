// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.AtolyeUstaEkle
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
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Sabitler
{
  public class AtolyeUstaEkle : RibbonForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbon;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonStatusBar ribbonStatusBar;
    private BarButtonItem yeniEgitimEkleButton;
    private BarButtonItem yeniEgitimKaydetButton;
    private BarButtonItem egitimSilButton;
    private BarButtonItem egitimBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem kapatButton;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup5;
    private GridControl gridControl1;
    private GridView gridView1;
    private TextEdit egitimBilgisi;
    private LabelControl labelControl1;
    private LookUpEdit birimCombo;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private LabelControl labelControl2;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private GridColumn colID;
    private GridColumn colATOLYEID;
    private GridColumn colUSTAADISOYADI;
    private GridColumn colSAVEUSER;
    private GridColumn colSAVEDATE;
    private GridColumn colEDITUSER;
    private GridColumn colEDITDATE;
    private GridColumn colSAVEMAC;
    private GridColumn colEDITMAC;
    private GridColumn colSAVEIP;
    private GridColumn colEDITIP;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;

    public AtolyeUstaEkle() => this.InitializeComponent();

    private void EgitimDurumu_Load(object sender, EventArgs e)
    {
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet7.TBLATOLYEBOLUM);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
    }

    private void yeniEgitimKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLATOLYEUSTALAR entity = new TBLATOLYEUSTALAR();
      entity.USTAADISOYADI = this.egitimBilgisi.Text;
      entity.ATOLYEID = new int?(Convert.ToInt32(this.birimCombo.EditValue));
      if (this.db.TBLATOLYEUSTALAR.Where<TBLATOLYEUSTALAR>((Expression<System.Func<TBLATOLYEUSTALAR, bool>>) (hd => hd.USTAADISOYADI == this.egitimBilgisi.Text)).Count<TBLATOLYEUSTALAR>() > 0)
      {
        int num = (int) MessageBox.Show("Aynı kayıt tekrar kayıt edilemez.");
      }
      else
      {
        this.db.TBLATOLYEUSTALAR.Add(entity);
        this.db.SaveChanges();
      }
      this.listele();
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void labelControl1_Click(object sender, EventArgs e)
    {
    }

    private void listele()
    {
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet7.TBLATOLYEBOLUM);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.egitimBilgisi.Text = this.gridView1.GetFocusedRowCellValue("USTAADISOYADI").ToString();
      this.birimCombo.EditValue = this.gridView1.GetFocusedRowCellValue("ATOLYEID");
    }

    private void egitimSilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLATOLYEUSTALAR tblatolyeustalar = this.db.TBLATOLYEUSTALAR.FirstOrDefault<TBLATOLYEUSTALAR>((Expression<System.Func<TBLATOLYEUSTALAR, bool>>) (x => x.ID == YetkiClass.secim_id));
      tblatolyeustalar.USTAADISOYADI = this.egitimBilgisi.Text;
      tblatolyeustalar.ATOLYEID = new int?(Convert.ToInt32(this.birimCombo.EditValue));
      this.db.SaveChanges();
      this.listele();
    }

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void yeniEgitimEkleButton_ItemClick(object sender, ItemClickEventArgs e) => this.egitimBilgisi.Text = "";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AtolyeUstaEkle));
      this.ribbon = new RibbonControl();
      this.yeniEgitimEkleButton = new BarButtonItem();
      this.yeniEgitimKaydetButton = new BarButtonItem();
      this.egitimSilButton = new BarButtonItem();
      this.egitimBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.kapatButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonStatusBar = new RibbonStatusBar();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colATOLYEID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.colUSTAADISOYADI = new GridColumn();
      this.colSAVEUSER = new GridColumn();
      this.colSAVEDATE = new GridColumn();
      this.colEDITUSER = new GridColumn();
      this.colEDITDATE = new GridColumn();
      this.colSAVEMAC = new GridColumn();
      this.colEDITMAC = new GridColumn();
      this.colSAVEIP = new GridColumn();
      this.colEDITIP = new GridColumn();
      this.egitimBilgisi = new TextEdit();
      this.labelControl1 = new LabelControl();
      this.birimCombo = new LookUpEdit();
      this.labelControl2 = new LabelControl();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.ribbon.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.egitimBilgisi.Properties.BeginInit();
      this.birimCombo.Properties.BeginInit();
      this.SuspendLayout();
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new BarItem[8]
      {
        (BarItem) this.ribbon.ExpandCollapseItem,
        (BarItem) this.ribbon.SearchEditItem,
        (BarItem) this.yeniEgitimEkleButton,
        (BarItem) this.yeniEgitimKaydetButton,
        (BarItem) this.egitimSilButton,
        (BarItem) this.egitimBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.kapatButton
      });
      this.ribbon.Location = new Point(0, 0);
      this.ribbon.MaxItemId = 9;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbon.Size = new Size(657, 158);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      this.yeniEgitimEkleButton.Caption = "Temizle";
      this.yeniEgitimEkleButton.Id = 1;
      this.yeniEgitimEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniEgitimEkleButton.ImageOptions.Image");
      this.yeniEgitimEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniEgitimEkleButton.ImageOptions.LargeImage");
      this.yeniEgitimEkleButton.LargeWidth = 100;
      this.yeniEgitimEkleButton.Name = "yeniEgitimEkleButton";
      this.yeniEgitimEkleButton.ItemClick += new ItemClickEventHandler(this.yeniEgitimEkleButton_ItemClick);
      this.yeniEgitimKaydetButton.Caption = "Kaydet";
      this.yeniEgitimKaydetButton.Id = 2;
      this.yeniEgitimKaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniEgitimKaydetButton.ImageOptions.Image");
      this.yeniEgitimKaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniEgitimKaydetButton.ImageOptions.LargeImage");
      this.yeniEgitimKaydetButton.LargeWidth = 100;
      this.yeniEgitimKaydetButton.Name = "yeniEgitimKaydetButton";
      this.yeniEgitimKaydetButton.ItemClick += new ItemClickEventHandler(this.yeniEgitimKaydetButton_ItemClick);
      this.egitimSilButton.Caption = "Düzenle";
      this.egitimSilButton.Id = 3;
      this.egitimSilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("egitimSilButton.ImageOptions.Image");
      this.egitimSilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("egitimSilButton.ImageOptions.LargeImage");
      this.egitimSilButton.LargeWidth = 100;
      this.egitimSilButton.Name = "egitimSilButton";
      this.egitimSilButton.ItemClick += new ItemClickEventHandler(this.egitimSilButton_ItemClick);
      this.egitimBulButton.Caption = "Kayit Bul";
      this.egitimBulButton.Id = 4;
      this.egitimBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("egitimBulButton.ImageOptions.Image");
      this.egitimBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("egitimBulButton.ImageOptions.LargeImage");
      this.egitimBulButton.LargeWidth = 100;
      this.egitimBulButton.Name = "egitimBulButton";
      this.barButtonItem6.Caption = "Kapat";
      this.barButtonItem6.Id = 6;
      this.barButtonItem6.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.Image");
      this.barButtonItem6.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.LargeImage");
      this.barButtonItem6.LargeWidth = 100;
      this.barButtonItem6.Name = "barButtonItem6";
      this.kapatButton.Alignment = BarItemLinkAlignment.Right;
      this.kapatButton.AllowDrawArrow = false;
      this.kapatButton.Caption = "Kapat";
      this.kapatButton.Id = 7;
      this.kapatButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.Image");
      this.kapatButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kapatButton.ImageOptions.LargeImage");
      this.kapatButton.LargeWidth = 100;
      this.kapatButton.Name = "kapatButton";
      this.kapatButton.ItemClick += new ItemClickEventHandler(this.kapatButton_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Atolye Usta Ekleme";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimEkleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimKaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.egitimSilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonStatusBar.Location = new Point(0, 504);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new Size(657, 22);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.Name = "barButtonItem5";
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.Text = "ribbonPageGroup5";
      this.gridControl1.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.gridControl1.Location = new Point(0, 188);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbon;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(657, 308);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.tBLATOLYEUSTALARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[11]
      {
        this.colID,
        this.colATOLYEID,
        this.colUSTAADISOYADI,
        this.colSAVEUSER,
        this.colSAVEDATE,
        this.colEDITUSER,
        this.colEDITDATE,
        this.colSAVEMAC,
        this.colEDITMAC,
        this.colSAVEIP,
        this.colEDITIP
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowHeight = 40;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 21;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 81;
      this.colATOLYEID.Caption = "Atolye";
      this.colATOLYEID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colATOLYEID.FieldName = "ATOLYEID";
      this.colATOLYEID.MinWidth = 21;
      this.colATOLYEID.Name = "colATOLYEID";
      this.colATOLYEID.OptionsColumn.AllowEdit = false;
      this.colATOLYEID.OptionsColumn.ReadOnly = true;
      this.colATOLYEID.Visible = true;
      this.colATOLYEID.VisibleIndex = 0;
      this.colATOLYEID.Width = 81;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet7;
      this.colUSTAADISOYADI.Caption = "Usta Adı Soyadı";
      this.colUSTAADISOYADI.FieldName = "USTAADISOYADI";
      this.colUSTAADISOYADI.MinWidth = 21;
      this.colUSTAADISOYADI.Name = "colUSTAADISOYADI";
      this.colUSTAADISOYADI.OptionsColumn.AllowEdit = false;
      this.colUSTAADISOYADI.OptionsColumn.ReadOnly = true;
      this.colUSTAADISOYADI.Visible = true;
      this.colUSTAADISOYADI.VisibleIndex = 1;
      this.colUSTAADISOYADI.Width = 81;
      this.colSAVEUSER.FieldName = "SAVEUSER";
      this.colSAVEUSER.MinWidth = 21;
      this.colSAVEUSER.Name = "colSAVEUSER";
      this.colSAVEUSER.OptionsColumn.AllowEdit = false;
      this.colSAVEUSER.OptionsColumn.ReadOnly = true;
      this.colSAVEUSER.Width = 81;
      this.colSAVEDATE.FieldName = "SAVEDATE";
      this.colSAVEDATE.MinWidth = 21;
      this.colSAVEDATE.Name = "colSAVEDATE";
      this.colSAVEDATE.OptionsColumn.AllowEdit = false;
      this.colSAVEDATE.OptionsColumn.ReadOnly = true;
      this.colSAVEDATE.Width = 81;
      this.colEDITUSER.FieldName = "EDITUSER";
      this.colEDITUSER.MinWidth = 21;
      this.colEDITUSER.Name = "colEDITUSER";
      this.colEDITUSER.OptionsColumn.AllowEdit = false;
      this.colEDITUSER.OptionsColumn.ReadOnly = true;
      this.colEDITUSER.Width = 81;
      this.colEDITDATE.FieldName = "EDITDATE";
      this.colEDITDATE.MinWidth = 21;
      this.colEDITDATE.Name = "colEDITDATE";
      this.colEDITDATE.OptionsColumn.AllowEdit = false;
      this.colEDITDATE.OptionsColumn.ReadOnly = true;
      this.colEDITDATE.Width = 81;
      this.colSAVEMAC.FieldName = "SAVEMAC";
      this.colSAVEMAC.MinWidth = 21;
      this.colSAVEMAC.Name = "colSAVEMAC";
      this.colSAVEMAC.OptionsColumn.AllowEdit = false;
      this.colSAVEMAC.OptionsColumn.ReadOnly = true;
      this.colSAVEMAC.Width = 81;
      this.colEDITMAC.FieldName = "EDITMAC";
      this.colEDITMAC.MinWidth = 21;
      this.colEDITMAC.Name = "colEDITMAC";
      this.colEDITMAC.OptionsColumn.AllowEdit = false;
      this.colEDITMAC.OptionsColumn.ReadOnly = true;
      this.colEDITMAC.Width = 81;
      this.colSAVEIP.FieldName = "SAVEIP";
      this.colSAVEIP.MinWidth = 21;
      this.colSAVEIP.Name = "colSAVEIP";
      this.colSAVEIP.OptionsColumn.AllowEdit = false;
      this.colSAVEIP.OptionsColumn.ReadOnly = true;
      this.colSAVEIP.Width = 81;
      this.colEDITIP.FieldName = "EDITIP";
      this.colEDITIP.MinWidth = 21;
      this.colEDITIP.Name = "colEDITIP";
      this.colEDITIP.OptionsColumn.AllowEdit = false;
      this.colEDITIP.OptionsColumn.ReadOnly = true;
      this.colEDITIP.Width = 81;
      this.egitimBilgisi.EditValue = (object) "";
      this.egitimBilgisi.Location = new Point(180, 162);
      this.egitimBilgisi.MenuManager = (IDXMenuManager) this.ribbon;
      this.egitimBilgisi.Name = "egitimBilgisi";
      this.egitimBilgisi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.egitimBilgisi.Properties.Appearance.Options.UseFont = true;
      this.egitimBilgisi.Size = new Size(217, 24);
      this.egitimBilgisi.TabIndex = 5;
      this.egitimBilgisi.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(12, 164);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(104, 18);
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Usta Adı Soyadı";
      this.labelControl1.Click += new EventHandler(this.labelControl1_Click);
      this.birimCombo.Location = new Point(483, 162);
      this.birimCombo.MenuManager = (IDXMenuManager) this.ribbon;
      this.birimCombo.Name = "birimCombo";
      this.birimCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimCombo.Properties.Appearance.Options.UseFont = true;
      this.birimCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimCombo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("BOLUMADI", "Bölüm Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.birimCombo.Properties.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.birimCombo.Properties.DisplayMember = "BOLUMADI";
      this.birimCombo.Properties.NullText = "";
      this.birimCombo.Properties.ValueMember = "ID";
      this.birimCombo.Size = new Size(145, 24);
      this.birimCombo.TabIndex = 9;
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(423, 165);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(40, 18);
      this.labelControl2.TabIndex = 12;
      this.labelControl2.Text = "Atolye";
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(657, 526);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.birimCombo);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.egitimBilgisi);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonStatusBar);
      this.Controls.Add((Control) this.ribbon);
      this.Name = nameof (AtolyeUstaEkle);
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Atolye";
      this.Load += new EventHandler(this.EgitimDurumu_Load);
      this.ribbon.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.egitimBilgisi.Properties.EndInit();
      this.birimCombo.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
