// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.BakimTanimlari
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
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class BakimTanimlari : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private int id = YetkiClass.secim_id;
    private string kod = YetkiClass.secim_kodu;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private EmptySpaceItem emptySpaceItem1;
    private BarButtonItem barButtonItem8;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLBAKIMTANIMBindingSource;
    private TBLBAKIMTANIMTableAdapter tBLBAKIMTANIMTableAdapter;
    private GridColumn colID;
    private GridColumn colATOLYEID;
    private GridColumn colBAKIMGRUBUID;
    private GridColumn colYAPILANBAKIM;
    private RepositoryItemLookUpEdit atolye;
    private RepositoryItemLookUpEdit bakimgrubu;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;

    public BakimTanimlari() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet5.TBLBAKIMGRUBU);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
      this.tBLBAKIMTANIMTableAdapter.Fill(this.bellDataSet5.TBLBAKIMTANIM);
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void kayit()
    {
    }

    private void guncelle()
    {
    }

    private void sil()
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.db.TBLBAKIMTANIM.Remove(this.db.TBLBAKIMTANIM.Find(new object[1]
      {
        (object) YetkiClass.secim_id
      }));
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
      this.tBLBAKIMTANIMTableAdapter.Fill(this.bellDataSet5.TBLBAKIMTANIM);
    }

    private void listele()
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new BakimEkle().ShowDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.sil();
      LogEkle.Logs("Silme Yapti");
    }

    private void guncelleload()
    {
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet5.TBLBAKIMGRUBU);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
      this.tBLBAKIMTANIMTableAdapter.Fill(this.bellDataSet5.TBLBAKIMTANIM);
    }

    public void tetikle()
    {
    }

    private void gridView6_ValidateRow(object sender, ValidateRowEventArgs e)
    {
    }

    private void simpleButton1_Click_1(object sender, EventArgs e)
    {
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void simpleButton1_Click_2(object sender, EventArgs e)
    {
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new BakimEkle().ShowDialog();
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new BakimEkle().ShowDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BakimTanimlari));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLBAKIMTANIMBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colATOLYEID = new GridColumn();
      this.atolye = new RepositoryItemLookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.colBAKIMGRUBUID = new GridColumn();
      this.bakimgrubu = new RepositoryItemLookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.colYAPILANBAKIM = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.tBLBAKIMTANIMTableAdapter = new TBLBAKIMTANIMTableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMTANIMBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.atolye.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bakimgrubu.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.emptySpaceItem1.BeginInit();
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
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 10;
      this.ribbonControl1.Name = "ribbonControl1";
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
      this.ribbonControl1.Size = new Size(1130, 118);
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
      this.barButtonItem2.Caption = "Yeni Kayıt";
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
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
      this.barButtonItem8.Caption = "Düzenle";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) Resources.editdatasource_16x161;
      this.barButtonItem8.ImageOptions.LargeImage = (Image) Resources.editdatasource_32x321;
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
      this.barEditItem1.Id = 9;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLBAKIMTANIMBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 118);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.atolye,
        (RepositoryItem) this.bakimgrubu
      });
      this.gridControl1.Size = new Size(1130, 682);
      this.gridControl1.TabIndex = 10;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLBAKIMTANIMBindingSource.DataMember = "TBLBAKIMTANIM";
      this.tBLBAKIMTANIMBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[4]
      {
        this.colID,
        this.colATOLYEID,
        this.colBAKIMGRUBUID,
        this.colYAPILANBAKIM
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 94;
      this.colATOLYEID.Caption = "Atölye Bölüm";
      this.colATOLYEID.ColumnEdit = (RepositoryItem) this.atolye;
      this.colATOLYEID.FieldName = "ATOLYEID";
      this.colATOLYEID.MinWidth = 25;
      this.colATOLYEID.Name = "colATOLYEID";
      this.colATOLYEID.OptionsColumn.AllowEdit = false;
      this.colATOLYEID.OptionsColumn.ReadOnly = true;
      this.colATOLYEID.Visible = true;
      this.colATOLYEID.VisibleIndex = 0;
      this.colATOLYEID.Width = 94;
      this.atolye.AutoHeight = false;
      this.atolye.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolye.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.atolye.DisplayMember = "BOLUMADI";
      this.atolye.Name = "atolye";
      this.atolye.ValueMember = "ID";
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBAKIMGRUBUID.Caption = "Bakım Grubu";
      this.colBAKIMGRUBUID.ColumnEdit = (RepositoryItem) this.bakimgrubu;
      this.colBAKIMGRUBUID.FieldName = "BAKIMGRUBUID";
      this.colBAKIMGRUBUID.MinWidth = 25;
      this.colBAKIMGRUBUID.Name = "colBAKIMGRUBUID";
      this.colBAKIMGRUBUID.OptionsColumn.AllowEdit = false;
      this.colBAKIMGRUBUID.OptionsColumn.ReadOnly = true;
      this.colBAKIMGRUBUID.Visible = true;
      this.colBAKIMGRUBUID.VisibleIndex = 1;
      this.colBAKIMGRUBUID.Width = 94;
      this.bakimgrubu.AutoHeight = false;
      this.bakimgrubu.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimgrubu.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.bakimgrubu.DisplayMember = "GRUPADI";
      this.bakimgrubu.Name = "bakimgrubu";
      this.bakimgrubu.ValueMember = "ID";
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet5;
      this.colYAPILANBAKIM.Caption = "Yapılan Bakım";
      this.colYAPILANBAKIM.FieldName = "YAPILANBAKIM";
      this.colYAPILANBAKIM.MinWidth = 25;
      this.colYAPILANBAKIM.Name = "colYAPILANBAKIM";
      this.colYAPILANBAKIM.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIM.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIM.Visible = true;
      this.colYAPILANBAKIM.VisibleIndex = 2;
      this.colYAPILANBAKIM.Width = 94;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.tBLBAKIMTANIMTableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1130, 800);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (BakimTanimlari);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ekle2";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLBAKIMTANIMBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.atolye.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bakimgrubu.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.emptySpaceItem1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class Elemanlar
    {
    }
  }
}
