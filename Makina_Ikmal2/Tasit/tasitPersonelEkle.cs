// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Tasit.tasitPersonelEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Tasit
{
  public class tasitPersonelEkle : FluentDesignForm
  {
    private bellEntities db = new bellEntities();
    public int hangisi = 0;
    private int unvanid;
    private IContainer components = (IContainer) null;
    private FluentDesignFormContainer fluentDesignFormContainer1;
    private AccordionControl accordionControl1;
    private FluentDesignFormControl fluentDesignFormControl1;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private SearchLookUpEdit perAdSoyadSluEdit;
    private GridView searchLookUpEdit1View;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem2;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn adiSoyadi;
    private TextEdit unvaniTextEdit;

    public tasitPersonelEkle() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.kaydet();
      LogEkle.Logs("Ekleme Yapti");
    }

    private void kaydet()
    {
      tasitGorevEmriAktarma.list.Add(new Personeller()
      {
        ID = 0,
        ADISOYADI = Convert.ToInt32(this.perAdSoyadSluEdit.EditValue),
        UNVANI = this.unvanid
      });
      if (this.hangisi == 1)
        ((TasitGorevEmri) Application.OpenForms["TasitGorevEmri"])?.tetikle();
      if (this.hangisi != 2)
        return;
      int num = (int) XtraMessageBox.Show(this.hangisi.ToString());
      ((TasitGorevEmriDuzenle) Application.OpenForms["TasitGorevEmriDuzenle"])?.tetikle();
    }

    private void tasitPersonelEkle_Load(object sender, EventArgs e) => this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);

    private void perAdSoyadSluEdit_EditValueChanged(object sender, EventArgs e)
    {
      int deger = Convert.ToInt32(this.perAdSoyadSluEdit.EditValue);
      TBLPERSONEL sorgu = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == deger));
      TBLPERSUNVAN tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<System.Func<TBLPERSUNVAN, bool>>) (x => (int?) x.ID == sorgu.UNVANID));
      this.unvaniTextEdit.Text = tblpersunvan.UNVAN;
      this.unvanid = tblpersunvan.ID;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (tasitPersonelEkle));
      this.fluentDesignFormContainer1 = new FluentDesignFormContainer();
      this.accordionControl1 = new AccordionControl();
      this.fluentDesignFormControl1 = new FluentDesignFormControl();
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.perAdSoyadSluEdit = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.searchLookUpEdit1View = new GridView();
      this.adiSoyadi = new GridColumn();
      this.unvaniTextEdit = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.accordionControl1.BeginInit();
      this.fluentDesignFormControl1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.perAdSoyadSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.unvaniTextEdit.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.SuspendLayout();
      this.fluentDesignFormContainer1.Dock = DockStyle.Fill;
      this.fluentDesignFormContainer1.Location = new Point(260, 0);
      this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
      this.fluentDesignFormContainer1.Size = new Size(38, 268);
      this.fluentDesignFormContainer1.TabIndex = 0;
      this.accordionControl1.Dock = DockStyle.Left;
      this.accordionControl1.Location = new Point(0, 0);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = ScrollBarMode.Touch;
      this.accordionControl1.Size = new Size(260, 268);
      this.accordionControl1.TabIndex = 1;
      this.accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
      this.fluentDesignFormControl1.Location = new Point(0, 0);
      this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
      this.fluentDesignFormControl1.Size = new Size(298, 0);
      this.fluentDesignFormControl1.TabIndex = 2;
      this.fluentDesignFormControl1.TabStop = false;
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[8]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
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
      this.ribbonControl1.Size = new Size(385, 122);
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
      this.barButtonItem2.Caption = "Kayıt";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.perAdSoyadSluEdit);
      this.layoutControl1.Controls.Add((Control) this.unvaniTextEdit);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(385, 102);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.perAdSoyadSluEdit.EditValue = (object) "";
      this.perAdSoyadSluEdit.Location = new Point(179, 14);
      this.perAdSoyadSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.perAdSoyadSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.perAdSoyadSluEdit.Name = "perAdSoyadSluEdit";
      this.perAdSoyadSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.perAdSoyadSluEdit.Properties.Appearance.Options.UseFont = true;
      this.perAdSoyadSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.perAdSoyadSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.perAdSoyadSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.perAdSoyadSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.perAdSoyadSluEdit.Properties.ValueMember = "ID";
      this.perAdSoyadSluEdit.Size = new Size(192, 30);
      this.perAdSoyadSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.perAdSoyadSluEdit.TabIndex = 4;
      this.perAdSoyadSluEdit.EditValueChanged += new EventHandler(this.perAdSoyadSluEdit_EditValueChanged);
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.adiSoyadi
      });
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.adiSoyadi.AppearanceCell.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adiSoyadi.AppearanceCell.Options.UseFont = true;
      this.adiSoyadi.AppearanceHeader.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adiSoyadi.AppearanceHeader.Options.UseFont = true;
      this.adiSoyadi.Caption = "ADI SOYADI";
      this.adiSoyadi.FieldName = "ADISOYADI";
      this.adiSoyadi.MinWidth = 23;
      this.adiSoyadi.Name = "adiSoyadi";
      this.adiSoyadi.Visible = true;
      this.adiSoyadi.VisibleIndex = 0;
      this.adiSoyadi.Width = 87;
      this.unvaniTextEdit.EditValue = (object) "";
      this.unvaniTextEdit.Location = new Point(179, 48);
      this.unvaniTextEdit.Margin = new Padding(3, 4, 3, 4);
      this.unvaniTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.unvaniTextEdit.Name = "unvaniTextEdit";
      this.unvaniTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.unvaniTextEdit.Properties.Appearance.Options.UseFont = true;
      this.unvaniTextEdit.Properties.NullText = "[EditValue is null]";
      this.unvaniTextEdit.Size = new Size(192, 30);
      this.unvaniTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.unvaniTextEdit.TabIndex = 5;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[3]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(385, 102);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.perAdSoyadSluEdit;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(361, 34);
      this.layoutControlItem1.Text = "Personel Ad Soyad";
      this.layoutControlItem1.TextSize = new Size(162, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 68);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(361, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.unvaniTextEdit;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(361, 34);
      this.layoutControlItem2.Text = "Unvanı";
      this.layoutControlItem2.TextSize = new Size(162, 24);
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(385, 224);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.IconOptions.Image = (Image) Resources.logo;
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (tasitPersonelEkle);
      this.Text = nameof (tasitPersonelEkle);
      this.Load += new EventHandler(this.tasitPersonelEkle_Load);
      this.accordionControl1.EndInit();
      this.fluentDesignFormControl1.EndInit();
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.perAdSoyadSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.unvaniTextEdit.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
