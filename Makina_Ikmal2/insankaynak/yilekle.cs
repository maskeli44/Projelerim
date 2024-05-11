// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.yilekle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet3TableAdapters;
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

namespace Makina_Ikmal.insankaynak
{
  public class yilekle : XtraForm
  {
    private bellEntities db = new bellEntities();
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
    private TextEdit izinsureTxt;
    private LabelControl labelControl3;
    private bellDataSet3 bellDataSet3;
    private BindingSource tBLPERIZINYILLARIBindingSource;
    private TBLPERIZINYILLARITableAdapter tBLPERIZINYILLARITableAdapter;
    private GridControl gridControl1;
    private GridView gridView1;
    private BindingSource tBLPERIZINYILLARIBindingSource1;
    private GridColumn colID;
    private GridColumn colYIL;

    public yilekle() => this.InitializeComponent();

    private void izinhakkiekleme_Load(object sender, EventArgs e) => this.tBLPERIZINYILLARITableAdapter.Fill(this.bellDataSet3.TBLPERIZINYILLARI);

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.db.TBLPERIZINYILLARI.Add(new TBLPERIZINYILLARI()
      {
        YIL = this.izinsureTxt.Text
      });
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Kayıt başarlı bir şekilde gerçekleştirilmiştir");
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      int id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.izinsureTxt.Text = this.db.TBLPERIZINYILLARI.FirstOrDefault<TBLPERIZINYILLARI>((Expression<System.Func<TBLPERIZINYILLARI, bool>>) (x => x.ID == id)).YIL.ToString();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (yilekle));
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
      this.tBLPERIZINYILLARIBindingSource = new BindingSource(this.components);
      this.bellDataSet3 = new bellDataSet3();
      this.izinsureTxt = new TextEdit();
      this.labelControl3 = new LabelControl();
      this.tBLPERIZINYILLARITableAdapter = new TBLPERIZINYILLARITableAdapter();
      this.gridControl1 = new GridControl();
      this.tBLPERIZINYILLARIBindingSource1 = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colYIL = new GridColumn();
      this.ribbonControl1.BeginInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource).BeginInit();
      this.bellDataSet3.BeginInit();
      this.izinsureTxt.Properties.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource1).BeginInit();
      this.gridView1.BeginInit();
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tBLPERIZINYILLARIBindingSource.DataMember = "TBLPERIZINYILLARI";
      this.tBLPERIZINYILLARIBindingSource.DataSource = (object) this.bellDataSet3;
      this.bellDataSet3.DataSetName = "bellDataSet3";
      this.bellDataSet3.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.izinsureTxt.Location = new Point(216, 138);
      this.izinsureTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinsureTxt.Name = "izinsureTxt";
      this.izinsureTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinsureTxt.Properties.Appearance.Options.UseFont = true;
      this.izinsureTxt.Size = new Size(125, 30);
      this.izinsureTxt.TabIndex = 4;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(192, 141);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(18, 22);
      this.labelControl3.TabIndex = 7;
      this.labelControl3.Text = "Yıl";
      this.tBLPERIZINYILLARITableAdapter.ClearBeforeFill = true;
      this.gridControl1.DataSource = (object) this.tBLPERIZINYILLARIBindingSource1;
      this.gridControl1.Dock = DockStyle.Bottom;
      this.gridControl1.Location = new Point(0, 188);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(883, 486);
      this.gridControl1.TabIndex = 10;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLPERIZINYILLARIBindingSource1.DataMember = "TBLPERIZINYILLARI";
      this.tBLPERIZINYILLARIBindingSource1.DataSource = (object) this.bellDataSet3;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colYIL
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Width = 94;
      this.colYIL.Caption = "Yıl";
      this.colYIL.FieldName = "YIL";
      this.colYIL.MinWidth = 25;
      this.colYIL.Name = "colYIL";
      this.colYIL.Visible = true;
      this.colYIL.VisibleIndex = 0;
      this.colYIL.Width = 94;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(883, 674);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.labelControl3);
      this.Controls.Add((Control) this.izinsureTxt);
      this.Controls.Add((Control) this.ribbonControl1);
      this.IconOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.Name = nameof (yilekle);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "YILLIK İZİN HAKKI";
      this.Load += new EventHandler(this.izinhakkiekleme_Load);
      this.ribbonControl1.EndInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource).EndInit();
      this.bellDataSet3.EndInit();
      this.izinsureTxt.Properties.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource1).EndInit();
      this.gridView1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
