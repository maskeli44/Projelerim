// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.Yetkililer
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

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
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Sabitler
{
  public class Yetkililer : RibbonForm
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
    private GridView gridView1;
    private GridControl gridControl1;
    private LabelControl labelControl1;
    private LabelControl labelControl2;
    private LookUpEdit yetkialani;
    private SearchLookUpEdit adisoyadi;
    private GridView searchLookUpEdit1View;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private SimpleButton simpleButton1;
    private GridColumn gridColumn1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;

    public Yetkililer() => this.InitializeComponent();

    private void EgitimDurumu_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.yetkialani.Properties.DataSource = (object) this.db.TBLBIRIMYETKILILERI.ToList<TBLBIRIMYETKILILERI>();
      this.yetkialani.Properties.DisplayMember = "YETKIALANI";
      this.yetkialani.Properties.ValueMember = "ID";
      this.listele();
    }

    private void yeniEgitimKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLBIRIMYETKILILERI.FirstOrDefault<TBLBIRIMYETKILILERI>((Expression<System.Func<TBLBIRIMYETKILILERI, bool>>) (x => x.ID == YetkiClass.secim_id)).YETKILIID = new int?(Convert.ToInt32(this.adisoyadi.EditValue));
      this.db.SaveChanges();
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
      this.yetkialani.Properties.DataSource = (object) this.db.TBLBIRIMYETKILILERI.ToList<TBLBIRIMYETKILILERI>();
      this.gridControl1.DataSource = (object) this.db.TBLBIRIMYETKILILERI.ToList<TBLBIRIMYETKILILERI>();
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
    }

    private void egitimSilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      string temp = YetkiClass.secim_id.ToString();
      this.db.TBLPERSONELISTIHDAMDURUM.FirstOrDefault<TBLPERSONELISTIHDAMDURUM>((Expression<System.Func<TBLPERSONELISTIHDAMDURUM, bool>>) (x => x.ID == temp));
      this.db.SaveChanges();
      this.listele();
    }

    private void kapatButton_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void yeniEgitimEkleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void yetkialani_Properties_EditValueChanged(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.yetkialani.EditValue);
      this.adisoyadi.EditValue = (object) this.db.TBLBIRIMYETKILILERI.FirstOrDefault<TBLBIRIMYETKILILERI>((Expression<System.Func<TBLBIRIMYETKILILERI, bool>>) (x => x.ID == YetkiClass.secim_id)).YETKILIID;
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Yetkililer));
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
      this.gridView1 = new GridView();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridColumn5 = new GridColumn();
      this.gridControl1 = new GridControl();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.yetkialani = new LookUpEdit();
      this.adisoyadi = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.simpleButton1 = new SimpleButton();
      this.ribbon.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridControl1.BeginInit();
      this.yetkialani.Properties.BeginInit();
      this.adisoyadi.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
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
      this.ribbon.Margin = new Padding(3, 4, 3, 4);
      this.ribbon.MaxItemId = 9;
      this.ribbon.Name = "ribbon";
      this.ribbon.OptionsMenuMinWidth = 385;
      this.ribbon.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbon.Size = new Size(726, 193);
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimEkleButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniEgitimKaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.egitimSilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.kapatButton);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonStatusBar.Location = new Point(0, 682);
      this.ribbonStatusBar.Margin = new Padding(3, 4, 3, 4);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new Size(726, 28);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.Name = "barButtonItem5";
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.Text = "ribbonPageGroup5";
      this.gridView1.Appearance.Row.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowHeight = 49;
      this.gridColumn3.Caption = "gridColumn3";
      this.gridColumn3.FieldName = "YETKIALANI";
      this.gridColumn3.MinWidth = 25;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 94;
      this.gridColumn4.Caption = "gridColumn4";
      this.gridColumn4.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn4.FieldName = "YETKILIID";
      this.gridColumn4.MinWidth = 25;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 1;
      this.gridColumn4.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridColumn5.Caption = "gridColumn5";
      this.gridColumn5.FieldName = "ID";
      this.gridColumn5.MinWidth = 25;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 2;
      this.gridColumn5.Width = 94;
      this.gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(12, 301);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbon;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(702, 379);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(219, 202);
      this.labelControl1.Margin = new Padding(3, 4, 3, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(87, 24);
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Yetki Alanı";
      this.labelControl1.Click += new EventHandler(this.labelControl1_Click);
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(219, 240);
      this.labelControl2.Margin = new Padding(3, 4, 3, 4);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(90, 24);
      this.labelControl2.TabIndex = 6;
      this.labelControl2.Text = "Adı Soyadı";
      this.labelControl2.Click += new EventHandler(this.labelControl1_Click);
      this.yetkialani.EditValue = (object) "";
      this.yetkialani.Location = new Point(317, 198);
      this.yetkialani.Margin = new Padding(3, 4, 3, 4);
      this.yetkialani.MenuManager = (IDXMenuManager) this.ribbon;
      this.yetkialani.Name = "yetkialani";
      this.yetkialani.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yetkialani.Properties.Appearance.Options.UseFont = true;
      this.yetkialani.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yetkialani.Properties.NullText = "";
      this.yetkialani.Properties.EditValueChanged += new EventHandler(this.yetkialani_Properties_EditValueChanged);
      this.yetkialani.Size = new Size(311, 30);
      this.yetkialani.TabIndex = 5;
      this.yetkialani.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.adisoyadi.EditValue = (object) "";
      this.adisoyadi.Location = new Point(317, 236);
      this.adisoyadi.Margin = new Padding(3, 4, 3, 4);
      this.adisoyadi.Name = "adisoyadi";
      this.adisoyadi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adisoyadi.Properties.Appearance.Options.UseFont = true;
      this.adisoyadi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.adisoyadi.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.adisoyadi.Properties.DisplayMember = "ADISOYADI";
      this.adisoyadi.Properties.NullText = "";
      this.adisoyadi.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.adisoyadi.Properties.ValueMember = "ID";
      this.adisoyadi.Size = new Size(311, 30);
      this.adisoyadi.TabIndex = 5;
      this.adisoyadi.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Adı Soyadı";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.simpleButton1.ImageOptions.Image = (Image) Resources.add_32x322;
      this.simpleButton1.Location = new Point(635, 190);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(46, 42);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(726, 710);
      this.Controls.Add((Control) this.simpleButton1);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonStatusBar);
      this.Controls.Add((Control) this.yetkialani);
      this.Controls.Add((Control) this.adisoyadi);
      this.Controls.Add((Control) this.ribbon);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (Yetkililer);
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Yetkiler";
      this.Load += new EventHandler(this.EgitimDurumu_Load);
      this.ribbon.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridControl1.EndInit();
      this.yetkialani.Properties.EndInit();
      this.adisoyadi.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
