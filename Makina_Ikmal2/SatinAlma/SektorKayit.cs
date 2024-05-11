// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.SektorKayit
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
using DevExpress.XtraLayout;
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

namespace Makina_Ikmal.SatinAlma
{
  public class SektorKayit : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int control = 0;
    public int secim = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem talebYukleButon;
    private BarButtonItem barButtonItem3;
    private LayoutControl layoutControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private TextEdit isinAdiTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private GridColumn colID;
    private GridColumn colISINADI;
    private Makina_Ikmal.Model.TalepToplaTableAdapters.TBLTALEPTEKNIKSARTTableAdapter tBLTALEPTEKNIKSARTTableAdapter1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLFIRMASEKTORBindingSource;
    private TBLFIRMASEKTORTableAdapter tBLFIRMASEKTORTableAdapter;
    private BarButtonItem barButtonItem2;

    public SektorKayit() => this.InitializeComponent();

    private void SektorKayit_Load(object sender, EventArgs e)
    {
      this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet5.TBLFIRMASEKTOR);
      this.SilButton.Enabled = false;
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridView1_Click(object sender, EventArgs e)
    {
      Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      if (this.gridView1.GetFocusedRowCellValue(this.colISINADI).ToString() == null)
        return;
      this.isinAdiTxt.Text = this.gridView1.GetFocusedRowCellValue(this.colISINADI).ToString();
    }

    private void Listele() => this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet5.TBLFIRMASEKTOR);

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.isinAdiTxt.Text = "";
      this.isinAdiTxt.Focus();
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.isinAdiTxt.Text != "")
      {
        try
        {
          this.db.TBLFIRMASEKTOR.Add(new TBLFIRMASEKTOR()
          {
            SEKTORADI = this.isinAdiTxt.Text
          });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    private bool BoslukKontrol() => this.isinAdiTxt.Text != "";

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLFIRMASEKTOR.Remove(this.db.TBLFIRMASEKTOR.FirstOrDefault<TBLFIRMASEKTOR>((Expression<System.Func<TBLFIRMASEKTOR, bool>>) (x => x.ID == guncelID)));
        this.db.SaveChanges();
        this.Listele();
        int num = (int) XtraMessageBox.Show(guncelID.ToString());
        this.tBLFIRMASEKTORTableAdapter.Fill(this.bellDataSet5.TBLFIRMASEKTOR);
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    private void talebYukleButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      SektorAktarma.list.Add(new Sektorler()
      {
        ID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID))
      });
      ((FirmaKayit) Application.OpenForms["FirmaKayit"])?.liste();
      this.Close();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (this.isinAdiTxt.Text != "" && guncelID != 0)
      {
        try
        {
          this.db.TBLFIRMASEKTOR.FirstOrDefault<TBLFIRMASEKTOR>((Expression<System.Func<TBLFIRMASEKTOR, bool>>) (x => x.ID == guncelID)).SEKTORADI = this.isinAdiTxt.Text;
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Güncelleme başarı ile tamamlanmıştır.");
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    private void gridControl1_Click(object sender, EventArgs e) => this.SilButton.Enabled = true;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SektorKayit));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLFIRMASEKTORBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colISINADI = new GridColumn();
      this.talebYukleButon = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.isinAdiTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLFIRMASEKTORTableAdapter = new TBLFIRMASEKTORTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.isinAdiTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
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
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.talebYukleButon,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 15;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(1086, 100);
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
      this.KaydetButton.Caption = "Ekle";
      this.KaydetButton.Id = 2;
      this.KaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.Image");
      this.KaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.LargeImage");
      this.KaydetButton.LargeWidth = 100;
      this.KaydetButton.Name = "KaydetButton";
      this.KaydetButton.ItemClick += new ItemClickEventHandler(this.KaydetButton_ItemClick);
      this.SilButton.Caption = "Sil";
      this.SilButton.Id = 3;
      this.SilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.Image");
      this.SilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.LargeImage");
      this.SilButton.LargeWidth = 100;
      this.SilButton.Name = "SilButton";
      this.SilButton.RibbonStyle = RibbonItemStyles.Large;
      this.SilButton.ItemClick += new ItemClickEventHandler(this.SilButton_ItemClick);
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
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.LargeWidth = 100;
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLFIRMASEKTORBindingSource;
      this.gridControl1.Location = new Point(12, 40);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1062, 363);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLFIRMASEKTORBindingSource.DataMember = "TBLFIRMASEKTOR";
      this.tBLFIRMASEKTORBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.gridView1.Appearance.EvenRow.BackColor2 = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.gridView1.Appearance.EvenRow.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.gridView1.Appearance.EvenRow.Options.UseFont = true;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.Row.BackColor = Color.Aqua;
      this.gridView1.Appearance.Row.BackColor2 = Color.White;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.gridView1.Appearance.RowSeparator.BackColor2 = Color.Blue;
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colISINADI
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colISINADI, ColumnSortOrder.Descending)
      });
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colISINADI.Caption = "Sektör Adı";
      this.colISINADI.FieldName = "SEKTORADI";
      this.colISINADI.Name = "colISINADI";
      this.colISINADI.OptionsColumn.AllowEdit = false;
      this.colISINADI.OptionsColumn.ReadOnly = true;
      this.colISINADI.Visible = true;
      this.colISINADI.VisibleIndex = 0;
      this.talebYukleButon.Caption = "Kaydı Al";
      this.talebYukleButon.Id = 12;
      this.talebYukleButon.ImageOptions.Image = (Image) componentResourceManager.GetObject("talebYukleButon.ImageOptions.Image");
      this.talebYukleButon.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("talebYukleButon.ImageOptions.LargeImage");
      this.talebYukleButon.LargeWidth = 100;
      this.talebYukleButon.Name = "talebYukleButon";
      this.talebYukleButon.ItemClick += new ItemClickEventHandler(this.talebYukleButon_ItemClick);
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem2.Caption = "Güncelle";
      this.barButtonItem2.Id = 14;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.talebYukleButon);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Controls.Add((Control) this.isinAdiTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 267, 650, 400));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1086, 415);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.isinAdiTxt.Location = new Point(83, 12);
      this.isinAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isinAdiTxt.Name = "isinAdiTxt";
      this.isinAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isinAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.isinAdiTxt.Size = new Size(991, 24);
      this.isinAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.isinAdiTxt.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1086, 415);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.isinAdiTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1066, 28);
      this.layoutControlItem1.Text = "Sektör Adı";
      this.layoutControlItem1.TextSize = new Size(68, 18);
      this.layoutControlItem2.Control = (Control) this.gridControl1;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1066, 367);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.tBLFIRMASEKTORTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1086, 515);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (SektorKayit);
      this.Text = "Sektör Kayit";
      this.Load += new EventHandler(this.SektorKayit_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLFIRMASEKTORBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.isinAdiTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
