// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.markaTanim
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSetTableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class markaTanim : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarButtonItem kayitBulButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private bellDataSet bellDataSet;
    private BindingSource tBLMALZMARKABindingSource;
    private TBLMALZMARKATableAdapter tBLMALZMARKATableAdapter;
    private GridColumn colMALZMARKA;
    private BehaviorManager behaviorManager1;
    private TextEdit textEdit1;
    private LayoutControlItem layoutControlItem2;

    public markaTanim() => this.InitializeComponent();

    private void markaTanim_Load(object sender, EventArgs e) => this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet.TBLMALZMARKA);

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e) => this.textEdit1.Text = "";

    private void gridControl1_Click(object sender, EventArgs e) => this.textEdit1.Text = this.gridView1.GetFocusedRowCellValue(this.colMALZMARKA).ToString();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        if (this.textEdit1.Text != "" || this.textEdit1.Text != null)
        {
          this.db.TBLMALZMARKA.Add(new TBLMALZMARKA()
          {
            MALZMARKA = this.textEdit1.Text
          });
          this.db.SaveChanges();
          LogEkle.Logs("Ekleme Yapti");
          this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet.TBLMALZMARKA);
        }
        else
        {
          int num = (int) XtraMessageBox.Show("Depo Adı Bilgisini Giriniz!");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLMALZMARKA.Remove(this.db.TBLMALZMARKA.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
        this.tBLMALZMARKATableAdapter.Fill(this.bellDataSet.TBLMALZMARKA);
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (markaTanim));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.kayitBulButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.textEdit1 = new TextEdit();
      this.gridControl1 = new GridControl();
      this.tBLMALZMARKABindingSource = new BindingSource(this.components);
      this.bellDataSet = new bellDataSet();
      this.gridView1 = new GridView();
      this.colMALZMARKA = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.tBLMALZMARKATableAdapter = new TBLMALZMARKATableAdapter();
      this.behaviorManager1 = new BehaviorManager(this.components);
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.textEdit1.Properties.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).BeginInit();
      this.bellDataSet.BeginInit();
      this.gridView1.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      ((ISupportInitialize) this.behaviorManager1).BeginInit();
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
        (BarItem) this.YazdirButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.kayitBulButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 12;
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
      this.ribbonControl1.Size = new Size(734, 118);
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
      this.KaydetButton.Caption = "Kaydet";
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
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.FisEkleButton.Caption = "Fiş Ekle";
      this.FisEkleButton.Id = 9;
      this.FisEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.Image");
      this.FisEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.LargeImage");
      this.FisEkleButton.Name = "FisEkleButton";
      this.FisEkleButton.RibbonStyle = RibbonItemStyles.Large;
      this.FisiCikarButton.Caption = "Fişi Çıkar";
      this.FisiCikarButton.Id = 10;
      this.FisiCikarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.Image");
      this.FisiCikarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.LargeImage");
      this.FisiCikarButton.Name = "FisiCikarButton";
      this.FisiCikarButton.RibbonStyle = RibbonItemStyles.Large;
      this.kayitBulButton.Caption = "Kayıt Bul";
      this.kayitBulButton.Id = 11;
      this.kayitBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kayitBulButton.ImageOptions.Image");
      this.kayitBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kayitBulButton.ImageOptions.LargeImage");
      this.kayitBulButton.LargeWidth = 100;
      this.kayitBulButton.Name = "kayitBulButton";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.textEdit1);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(734, 783);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.textEdit1.Location = new Point(115, 12);
      this.textEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Size = new Size(607, 34);
      this.textEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit1.TabIndex = 5;
      this.gridControl1.DataSource = (object) this.tBLMALZMARKABindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(12, 50);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(710, 721);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLMALZMARKABindingSource.DataMember = "TBLMALZMARKA";
      this.tBLMALZMARKABindingSource.DataSource = (object) this.bellDataSet;
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.ColumnPanelRowHeight = 37;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.colMALZMARKA
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colMALZMARKA.AppearanceCell.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.colMALZMARKA.AppearanceCell.Options.UseFont = true;
      this.colMALZMARKA.AppearanceHeader.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.colMALZMARKA.AppearanceHeader.Options.UseFont = true;
      this.colMALZMARKA.Caption = "Malzeme Marka";
      this.colMALZMARKA.FieldName = "MALZMARKA";
      this.colMALZMARKA.MinWidth = 23;
      this.colMALZMARKA.Name = "colMALZMARKA";
      this.colMALZMARKA.Visible = true;
      this.colMALZMARKA.VisibleIndex = 0;
      this.colMALZMARKA.Width = 87;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[2]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(734, 783);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.gridControl1;
      this.layoutControlItem1.Location = new Point(0, 38);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(714, 725);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Tahoma", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.textEdit1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(714, 38);
      this.layoutControlItem2.Text = "Marka Adı";
      this.layoutControlItem2.TextSize = new Size(100, 28);
      this.tBLMALZMARKATableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(734, 901);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (markaTanim);
      this.Text = nameof (markaTanim);
      this.Load += new EventHandler(this.markaTanim_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.textEdit1.Properties.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLMALZMARKABindingSource).EndInit();
      this.bellDataSet.EndInit();
      this.gridView1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      ((ISupportInitialize) this.behaviorManager1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
