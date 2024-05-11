// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.Mudurluk
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
using Makina_Ikmal.bellDataSet5TableAdapters;
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
  public class Mudurluk : RibbonForm
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
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private GridColumn colID;
    private GridColumn colBELDBIRIMID;
    private GridColumn colBELDMUDURLUK;
    private LookUpEdit birimCombo;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private LabelControl labelControl2;

    public Mudurluk() => this.InitializeComponent();

    private void EgitimDurumu_Load(object sender, EventArgs e)
    {
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
    }

    private void yeniEgitimKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLBELDMUDURLUK entity = new TBLBELDMUDURLUK();
      entity.BELDMUDURLUK = this.egitimBilgisi.Text;
      entity.BELDBIRIMID = new int?(Convert.ToInt32(this.birimCombo.EditValue));
      if (this.db.TBLBELDMUDURLUK.Where<TBLBELDMUDURLUK>((Expression<System.Func<TBLBELDMUDURLUK, bool>>) (hd => hd.BELDMUDURLUK == this.egitimBilgisi.Text)).Count<TBLBELDMUDURLUK>() > 0)
      {
        int num = (int) MessageBox.Show("Aynı kayıt tekrar kayıt edilemez.");
      }
      else
      {
        this.db.TBLBELDMUDURLUK.Add(entity);
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

    private void listele() => this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);

    private void gridControl1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.egitimBilgisi.Text = this.gridView1.GetFocusedRowCellValue("BELDMUDURLUK").ToString();
      this.birimCombo.EditValue = this.gridView1.GetFocusedRowCellValue("BELDBIRIMID");
    }

    private void egitimSilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLBELDMUDURLUK.FirstOrDefault<TBLBELDMUDURLUK>((Expression<System.Func<TBLBELDMUDURLUK, bool>>) (x => x.ID == YetkiClass.secim_id)).BELDMUDURLUK = this.egitimBilgisi.Text;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Mudurluk));
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
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colBELDBIRIMID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.colBELDMUDURLUK = new GridColumn();
      this.egitimBilgisi = new TextEdit();
      this.labelControl1 = new LabelControl();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.birimCombo = new LookUpEdit();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.labelControl2 = new LabelControl();
      this.ribbon.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
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
      this.ribbonPage1.Text = "Personel Tanımları";
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
      this.gridControl1.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 231);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbon;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(766, 379);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.colID,
        this.colBELDBIRIMID,
        this.colBELDMUDURLUK
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowHeight = 49;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 23;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 87;
      this.colBELDBIRIMID.Caption = "Birim";
      this.colBELDBIRIMID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colBELDBIRIMID.FieldName = "BELDBIRIMID";
      this.colBELDBIRIMID.MinWidth = 23;
      this.colBELDBIRIMID.Name = "colBELDBIRIMID";
      this.colBELDBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBELDBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBELDBIRIMID.Visible = true;
      this.colBELDBIRIMID.VisibleIndex = 0;
      this.colBELDBIRIMID.Width = 87;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "BELDBIRIMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBELDMUDURLUK.Caption = "Müdürlük";
      this.colBELDMUDURLUK.FieldName = "BELDMUDURLUK";
      this.colBELDMUDURLUK.MinWidth = 23;
      this.colBELDMUDURLUK.Name = "colBELDMUDURLUK";
      this.colBELDMUDURLUK.OptionsColumn.AllowEdit = false;
      this.colBELDMUDURLUK.OptionsColumn.ReadOnly = true;
      this.colBELDMUDURLUK.Visible = true;
      this.colBELDMUDURLUK.VisibleIndex = 1;
      this.colBELDMUDURLUK.Width = 87;
      this.egitimBilgisi.EditValue = (object) "";
      this.egitimBilgisi.Location = new Point(210, 200);
      this.egitimBilgisi.Margin = new Padding(3, 4, 3, 4);
      this.egitimBilgisi.MenuManager = (IDXMenuManager) this.ribbon;
      this.egitimBilgisi.Name = "egitimBilgisi";
      this.egitimBilgisi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.egitimBilgisi.Properties.Appearance.Options.UseFont = true;
      this.egitimBilgisi.Size = new Size(253, 30);
      this.egitimBilgisi.TabIndex = 5;
      this.egitimBilgisi.EditValueChanged += new EventHandler(this.textEdit1_EditValueChanged);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(14, 202);
      this.labelControl1.Margin = new Padding(3, 4, 3, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(175, 24);
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Yeni Müdürlük Bilgisi";
      this.labelControl1.Click += new EventHandler(this.labelControl1_Click);
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.birimCombo.Location = new Point(597, 199);
      this.birimCombo.Margin = new Padding(3, 4, 3, 4);
      this.birimCombo.MenuManager = (IDXMenuManager) this.ribbon;
      this.birimCombo.Name = "birimCombo";
      this.birimCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimCombo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 23, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("BELDBIRIMADI", "BELDBIRIMADI", 23, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.birimCombo.Properties.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.birimCombo.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimCombo.Properties.NullText = "";
      this.birimCombo.Properties.ValueMember = "ID";
      this.birimCombo.Size = new Size(155, 22);
      this.birimCombo.TabIndex = 9;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(547, 203);
      this.labelControl2.Margin = new Padding(3, 4, 3, 4);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(46, 24);
      this.labelControl2.TabIndex = 12;
      this.labelControl2.Text = "Birimi";
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(766, 647);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.birimCombo);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.egitimBilgisi);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonStatusBar);
      this.Controls.Add((Control) this.ribbon);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (Mudurluk);
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Müdürlük";
      this.Load += new EventHandler(this.EgitimDurumu_Load);
      this.ribbon.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.egitimBilgisi.Properties.EndInit();
      this.birimCombo.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
