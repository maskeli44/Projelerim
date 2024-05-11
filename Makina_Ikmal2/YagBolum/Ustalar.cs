// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.YagBolum.Ustalar
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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet1TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.isemirlistesiTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.YagBolum
{
  public class Ustalar : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private BindingSource isemirlistesiBindingSource;
    private isemirlistesi isemirlistesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private BarEditItem barEditItem1;
    private RepositoryItemComboBox repositoryItemComboBox1;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarEditItem barEditItem3;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource dataTable1BindingSource1;
    private SearchLookUpEdit searchLookUpEdit1;
    private GridView searchLookUpEdit1View;
    private GridColumn ID;
    private GridColumn BOLUMADI;
    private SearchLookUpEdit searchLookUpEdit2;
    private GridView gridView2;
    private SearchLookUpEdit searchLookUpEdit3;
    private GridView gridView3;
    private SimpleButton simpleButton1;
    private bellDataSet1 bellDataSet1;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private GridColumn gridColumn2;

    public Ustalar() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet1.TBLBAKIMGRUBU);
      this.searchLookUpEdit1.Properties.ValueMember = "ID";
      this.searchLookUpEdit1.Properties.DisplayMember = "BOLUMADI";
      this.searchLookUpEdit1.Properties.DataSource = (object) this.db.TBLATOLYEBOLUM.ToList<TBLATOLYEBOLUM>();
      this.searchLookUpEdit1.Properties.PopupFormSize = new Size(80, 300);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void gridControl2_DoubleClick(object sender, EventArgs e)
    {
    }

    private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
      int deger = Convert.ToInt32(this.searchLookUpEdit1.EditValue);
      this.searchLookUpEdit2.Properties.ValueMember = "ID";
      this.searchLookUpEdit2.Properties.DisplayMember = "USTAADISOYADI";
      this.searchLookUpEdit2.Properties.DataSource = (object) this.db.TBLATOLYEUSTALAR.Where<TBLATOLYEUSTALAR>((Expression<System.Func<TBLATOLYEUSTALAR, bool>>) (x => x.ATOLYEID == (int?) deger)).Select(x => new
      {
        ID = x.ID,
        USTAADISOYADI = x.USTAADISOYADI
      }).ToList();
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      DegerAktarma.list.Add(new Makina_Ikmal.Classlar.ElemanlarDurum()
      {
        ATOLYEID = this.searchLookUpEdit1.EditValue.ToString(),
        BAKIMYAPUSTAID = this.searchLookUpEdit2.EditValue.ToString(),
        BAKIMGRUBUID = this.searchLookUpEdit3.EditValue.ToString(),
        YAPILANBAKIM = ""
      });
      YagEmri yagEmri = new YagEmri();
      ((YagEmri) Application.OpenForms["YagEmri"])?.tetikle();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Ustalar));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemComboBox1 = new RepositoryItemComboBox();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.isemirlistesiBindingSource = new BindingSource(this.components);
      this.isemirlistesi = new isemirlistesi();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.ID = new GridColumn();
      this.BOLUMADI = new GridColumn();
      this.searchLookUpEdit2 = new SearchLookUpEdit();
      this.gridView2 = new GridView();
      this.searchLookUpEdit3 = new SearchLookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.bellDataSet1 = new bellDataSet1();
      this.gridView3 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.simpleButton1 = new SimpleButton();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemComboBox1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource).BeginInit();
      this.isemirlistesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.searchLookUpEdit2.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.searchLookUpEdit3.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.bellDataSet1.BeginInit();
      this.gridView3.BeginInit();
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
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 11;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(768, 122);
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
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Caption = "Atölye";
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemComboBox1;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemComboBox1.AutoHeight = false;
      this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
      this.barEditItem2.Caption = "barEditItem2";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.Id = 9;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.barEditItem3.Caption = "Atölyeler ";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.barEditItem3.Id = 10;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.dataTable1BindingSource1;
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.isemirlistesiBindingSource;
      this.isemirlistesiBindingSource.DataSource = (object) this.isemirlistesi;
      this.isemirlistesiBindingSource.Position = 0;
      this.isemirlistesi.DataSetName = "isemirlistesi";
      this.isemirlistesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[1]
      {
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.isemirlistesi;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.searchLookUpEdit1.EditValue = (object) "";
      this.searchLookUpEdit1.Location = new Point(18, 144);
      this.searchLookUpEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.DisplayMember = "ID";
      this.searchLookUpEdit1.Properties.NullText = "";
      this.searchLookUpEdit1.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.searchLookUpEdit1.Properties.ValueMember = "BOLUMADI";
      this.searchLookUpEdit1.Size = new Size(289, 30);
      this.searchLookUpEdit1.TabIndex = 7;
      this.searchLookUpEdit1.EditValueChanged += new EventHandler(this.searchLookUpEdit1_EditValueChanged);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[2]
      {
        this.ID,
        this.BOLUMADI
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 100;
      this.searchLookUpEdit1View.OptionsFind.SearchInPreview = true;
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.ID.Caption = "gridColumn1";
      this.ID.FieldName = "ID";
      this.ID.Name = "ID";
      this.BOLUMADI.Caption = "gridColumn1";
      this.BOLUMADI.FieldName = "BOLUMADI";
      this.BOLUMADI.Name = "BOLUMADI";
      this.BOLUMADI.Visible = true;
      this.BOLUMADI.VisibleIndex = 0;
      this.searchLookUpEdit2.EditValue = (object) "";
      this.searchLookUpEdit2.Location = new Point(18, 180);
      this.searchLookUpEdit2.Name = "searchLookUpEdit2";
      this.searchLookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit2.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit2.Properties.NullText = "";
      this.searchLookUpEdit2.Properties.PopupView = (ColumnView) this.gridView2;
      this.searchLookUpEdit2.Size = new Size(289, 30);
      this.searchLookUpEdit2.TabIndex = 7;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit3.EditValue = (object) "";
      this.searchLookUpEdit3.Location = new Point(18, 216);
      this.searchLookUpEdit3.Name = "searchLookUpEdit3";
      this.searchLookUpEdit3.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit3.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit3.Properties.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.searchLookUpEdit3.Properties.DisplayMember = "GRUPADI";
      this.searchLookUpEdit3.Properties.NullText = "";
      this.searchLookUpEdit3.Properties.PopupView = (ColumnView) this.gridView3;
      this.searchLookUpEdit3.Properties.ValueMember = "ID";
      this.searchLookUpEdit3.Size = new Size(289, 30);
      this.searchLookUpEdit3.TabIndex = 7;
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet1;
      this.bellDataSet1.DataSetName = "bellDataSet1";
      this.bellDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.FieldName = "GRUPADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.simpleButton1.Location = new Point(322, 147);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(94, 99);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Text = "Ekle";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(768, 573);
      this.Controls.Add((Control) this.simpleButton1);
      this.Controls.Add((Control) this.searchLookUpEdit3);
      this.Controls.Add((Control) this.searchLookUpEdit2);
      this.Controls.Add((Control) this.searchLookUpEdit1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Ustalar);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form6";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemComboBox1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      ((ISupportInitialize) this.isemirlistesiBindingSource).EndInit();
      this.isemirlistesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.searchLookUpEdit2.Properties.EndInit();
      this.gridView2.EndInit();
      this.searchLookUpEdit3.Properties.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.bellDataSet1.EndInit();
      this.gridView3.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
