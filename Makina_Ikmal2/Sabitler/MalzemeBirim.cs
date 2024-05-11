// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.MalzemeBirim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
  public class MalzemeBirim : RibbonForm
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
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private GridColumn colID;
    private GridColumn colBIRIMADI;

    public MalzemeBirim() => this.InitializeComponent();

    private void EgitimDurumu_Load(object sender, EventArgs e) => this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet7.TBLMALZBIRIM);

    private void yeniEgitimKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLMALZBIRIM entity = new TBLMALZBIRIM();
      entity.BIRIMADI = this.egitimBilgisi.Text;
      if (this.db.TBLMALZBIRIM.Where<TBLMALZBIRIM>((Expression<System.Func<TBLMALZBIRIM, bool>>) (hd => hd.BIRIMADI == this.egitimBilgisi.Text)).Count<TBLMALZBIRIM>() > 0)
      {
        int num = (int) MessageBox.Show("Aynı kayıt tekrar kayıt edilemez.");
      }
      else
      {
        this.db.TBLMALZBIRIM.Add(entity);
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

    private void listele() => this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet7.TBLMALZBIRIM);

    private void gridControl1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.egitimBilgisi.Text = this.gridView1.GetFocusedRowCellValue("BIRIMADI").ToString();
    }

    private void egitimSilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLMALZBIRIM.FirstOrDefault<TBLMALZBIRIM>((Expression<System.Func<TBLMALZBIRIM, bool>>) (x => x.ID == YetkiClass.secim_id)).BIRIMADI = this.egitimBilgisi.Text;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MalzemeBirim));
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
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.egitimBilgisi = new TextEdit();
      this.labelControl1 = new LabelControl();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.ribbon.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView1.BeginInit();
      this.egitimBilgisi.Properties.BeginInit();
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
      this.ribbon.Size = new Size(766, 193);
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
      this.ribbonStatusBar.Location = new Point(0, 619);
      this.ribbonStatusBar.Margin = new Padding(3, 4, 3, 4);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new Size(766, 28);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.Name = "barButtonItem5";
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.Text = "ribbonPageGroup5";
      this.gridControl1.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 231);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbon;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(766, 379);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colBIRIMADI
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowHeight = 49;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 87;
      this.colBIRIMADI.Caption = "Birim Adı";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 25;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.OptionsColumn.AllowEdit = false;
      this.colBIRIMADI.OptionsColumn.ReadOnly = true;
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 0;
      this.colBIRIMADI.Width = 87;
      this.egitimBilgisi.EditValue = (object) "";
      this.egitimBilgisi.Location = new Point(317, 198);
      this.egitimBilgisi.Margin = new Padding(3, 4, 3, 4);
      this.egitimBilgisi.MenuManager = (IDXMenuManager) this.ribbon;
      this.egitimBilgisi.Name = "egitimBilgisi";
      this.egitimBilgisi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.egitimBilgisi.Properties.Appearance.Options.UseFont = true;
      this.egitimBilgisi.Size = new Size(311, 30);
      this.egitimBilgisi.TabIndex = 5;
      this.egitimBilgisi.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(129, 201);
      this.labelControl1.Margin = new Padding(3, 4, 3, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(171, 24);
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Yeni Birim Adı Bilgisi";
      this.labelControl1.Click += new EventHandler(this.labelControl1_Click);
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(766, 647);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.egitimBilgisi);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonStatusBar);
      this.Controls.Add((Control) this.ribbon);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (MalzemeBirim);
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Birim Adı";
      this.Load += new EventHandler(this.EgitimDurumu_Load);
      this.ribbon.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView1.EndInit();
      this.egitimBilgisi.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
