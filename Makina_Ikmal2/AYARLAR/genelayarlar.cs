// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AYARLAR.genelayarlar
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
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.AYARLAR
{
  public class genelayarlar : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int id;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private SearchLookUpEdit searchLookUpEdit1;
    private GridView searchLookUpEdit1View;
    private LabelControl labelControl1;
    private LabelControl labelControl3;
    private GridColumn gridColumn1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private SearchLookUpEdit izinsureTxt;
    private GridView searchLookUpEdit2View;
    private bellDataSet4 bellDataSet4;
    private BindingSource tBLAYARLARBindingSource;
    private Makina_Ikmal.bellDataSet4TableAdapters.TBLAYARLARTableAdapter tBLAYARLARTableAdapter;
    private GridColumn colID;
    private GridColumn colBIRIMADI;
    private GridColumn colPERSONEID;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private BindingSource tBLPERSKURUMGOREVBindingSource;
    private TBLPERSKURUMGOREVTableAdapter tBLPERSKURUMGOREVTableAdapter;

    public genelayarlar() => this.InitializeComponent();

    private void izinhakkiekleme_Load(object sender, EventArgs e)
    {
      this.tBLPERSKURUMGOREVTableAdapter.Fill(this.bellDataSet2.TBLPERSKURUMGOREV);
      this.tBLAYARLARTableAdapter.Fill(this.bellDataSet4.TBLAYARLAR);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLPERSIZINDURUM.Add(new TBLPERSIZINDURUM()
      {
        PERSONELID = new int?(Convert.ToInt32(this.searchLookUpEdit1.EditValue)),
        IZINHAKKI = new int?(Convert.ToInt32(this.izinsureTxt.Text)),
        KULLANILANIZIN = new int?(0)
      });
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarlı bir şekilde gerçekleştirilmiştir");
    }

    private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == this.id));
      tblpersizindurum.IZINHAKKI = new int?(Convert.ToInt32(this.izinsureTxt.Text));
      tblpersizindurum.KULLANILANIZIN = new int?(0);
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Güncelleme başarlı bir şekilde gerçekleştirilmiştir");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (genelayarlar));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.labelControl1 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.gridControl1 = new GridControl();
      this.tBLAYARLARBindingSource = new BindingSource(this.components);
      this.bellDataSet4 = new bellDataSet4();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.colPERSONEID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.izinsureTxt = new SearchLookUpEdit();
      this.tBLPERSKURUMGOREVBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.tBLAYARLARTableAdapter = new Makina_Ikmal.bellDataSet4TableAdapters.TBLAYARLARTableAdapter();
      this.tBLPERSKURUMGOREVTableAdapter = new TBLPERSKURUMGOREVTableAdapter();
      this.ribbonControl1.BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLAYARLARBindingSource).BeginInit();
      this.bellDataSet4.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.izinsureTxt.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[9]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 8;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(883, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem2.Caption = "Kayıt";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) Resources.saveto_16x16;
      this.barButtonItem2.ImageOptions.LargeImage = (Image) Resources.saveto_32x32;
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Düzenle";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) Resources.editdatasource_16x16;
      this.barButtonItem3.ImageOptions.LargeImage = (Image) Resources.editdatasource_32x32;
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.searchLookUpEdit1.Location = new Point(216, 165);
      this.searchLookUpEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.searchLookUpEdit1.Properties.DisplayMember = "ADISOYADI";
      this.searchLookUpEdit1.Properties.NullText = "";
      this.searchLookUpEdit1.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.searchLookUpEdit1.Properties.ValueMember = "ID";
      this.searchLookUpEdit1.Size = new Size(245, 30);
      this.searchLookUpEdit1.TabIndex = 2;
      this.searchLookUpEdit1.EditValueChanged += new EventHandler(this.searchLookUpEdit1_EditValueChanged);
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "gridColumn1";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(106, 168);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(103, 22);
      this.labelControl1.TabIndex = 5;
      this.labelControl1.Text = "Personel Adı ";
      this.labelControl3.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(122, 218);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(87, 22);
      this.labelControl3.TabIndex = 7;
      this.labelControl3.Text = "İzin Miktarı";
      this.gridControl1.DataSource = (object) this.tBLAYARLARBindingSource;
      this.gridControl1.Dock = DockStyle.Bottom;
      this.gridControl1.Location = new Point(0, 302);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(883, 372);
      this.gridControl1.TabIndex = 10;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLAYARLARBindingSource.DataMember = "TBLAYARLAR";
      this.tBLAYARLARBindingSource.DataSource = (object) this.bellDataSet4;
      this.bellDataSet4.DataSetName = "bellDataSet4";
      this.bellDataSet4.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.colID,
        this.colBIRIMADI,
        this.colPERSONEID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 94;
      this.colBIRIMADI.Caption = "Birim Adı";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 25;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 1;
      this.colBIRIMADI.Width = 94;
      this.colPERSONEID.Caption = "Personel Adı";
      this.colPERSONEID.FieldName = "PERSONEID";
      this.colPERSONEID.MinWidth = 25;
      this.colPERSONEID.Name = "colPERSONEID";
      this.colPERSONEID.Visible = true;
      this.colPERSONEID.VisibleIndex = 2;
      this.colPERSONEID.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.izinsureTxt.Location = new Point(216, 213);
      this.izinsureTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinsureTxt.Name = "izinsureTxt";
      this.izinsureTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinsureTxt.Properties.Appearance.Options.UseFont = true;
      this.izinsureTxt.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.izinsureTxt.Properties.DataSource = (object) this.tBLPERSKURUMGOREVBindingSource;
      this.izinsureTxt.Properties.DisplayMember = "KURUMGOREV";
      this.izinsureTxt.Properties.NullText = "";
      this.izinsureTxt.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.izinsureTxt.Properties.ValueMember = "ID";
      this.izinsureTxt.Size = new Size(219, 30);
      this.izinsureTxt.TabIndex = 4;
      this.tBLPERSKURUMGOREVBindingSource.DataMember = "TBLPERSKURUMGOREV";
      this.tBLPERSKURUMGOREVBindingSource.DataSource = (object) this.bellDataSet2;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[2]
      {
        this.gridColumn2,
        this.gridColumn3
      });
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "gridColumn2";
      this.gridColumn2.FieldName = "ID";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn3.Caption = "gridColumn3";
      this.gridColumn3.FieldName = "KURUMGOREV";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.tBLAYARLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSKURUMGOREVTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(883, 674);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.labelControl3);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.searchLookUpEdit1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Controls.Add((Control) this.izinsureTxt);
      this.IconOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.Name = nameof (genelayarlar);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "YILLIK İZİN HAKKI";
      this.Load += new EventHandler(this.izinhakkiekleme_Load);
      this.ribbonControl1.EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLAYARLARBindingSource).EndInit();
      this.bellDataSet4.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.izinsureTxt.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSKURUMGOREVBindingSource).EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
