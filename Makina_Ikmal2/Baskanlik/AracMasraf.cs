// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Baskanlik.AracMasraf
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
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.BaskanlikMasrafTableAdapters;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Baskanlik
{
  public class AracMasraf : XtraForm
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
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private BaskanlikMasraf baskanlikMasraf;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colARACID;
    private GridColumn colPLAKA;
    private GridColumn colGUNCELDEGERI;
    private GridColumn colARACMARKA;
    private GridColumn colGRUPADI;
    private GridColumn colToplam;
    private GridColumn colISLEMTIPIID;
    private GridColumn colYıl;
    private GridColumn colARACTIPIID;
    private GridColumn colMODEL;
    private GridColumn colBELDBIRIMID;
    private GridColumn colARACDURUMID;
    private GridColumn colAltGrup;

    public AracMasraf() => this.InitializeComponent();

    private void izinhakkiekleme_Load(object sender, EventArgs e) => this.dataTable1TableAdapter.Fill(this.baskanlikMasraf.DataTable1);

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracMasraf));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.baskanlikMasraf = new BaskanlikMasraf();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.colARACID = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colGUNCELDEGERI = new GridColumn();
      this.colARACMARKA = new GridColumn();
      this.colGRUPADI = new GridColumn();
      this.colToplam = new GridColumn();
      this.colISLEMTIPIID = new GridColumn();
      this.colYıl = new GridColumn();
      this.colARACTIPIID = new GridColumn();
      this.colMODEL = new GridColumn();
      this.colBELDBIRIMID = new GridColumn();
      this.colARACDURUMID = new GridColumn();
      this.colAltGrup = new GridColumn();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.baskanlikMasraf.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
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
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 9;
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
      this.ribbonControl1.Size = new Size(1509, 122);
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1509, 593);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.colARACID,
        this.colPLAKA,
        this.colGUNCELDEGERI,
        this.colARACMARKA,
        this.colGRUPADI,
        this.colToplam,
        this.colISLEMTIPIID,
        this.colYıl,
        this.colARACTIPIID,
        this.colMODEL,
        this.colBELDBIRIMID,
        this.colARACDURUMID,
        this.colAltGrup
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.baskanlikMasraf.DataSetName = "BaskanlikMasraf";
      this.baskanlikMasraf.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.baskanlikMasraf;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.MinWidth = 25;
      this.colARACID.Name = "colARACID";
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 0;
      this.colARACID.Width = 94;
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 94;
      this.colGUNCELDEGERI.FieldName = "GUNCELDEGERI";
      this.colGUNCELDEGERI.MinWidth = 25;
      this.colGUNCELDEGERI.Name = "colGUNCELDEGERI";
      this.colGUNCELDEGERI.Visible = true;
      this.colGUNCELDEGERI.VisibleIndex = 2;
      this.colGUNCELDEGERI.Width = 94;
      this.colARACMARKA.FieldName = "ARACMARKA";
      this.colARACMARKA.MinWidth = 25;
      this.colARACMARKA.Name = "colARACMARKA";
      this.colARACMARKA.Visible = true;
      this.colARACMARKA.VisibleIndex = 3;
      this.colARACMARKA.Width = 94;
      this.colGRUPADI.FieldName = "GRUPADI";
      this.colGRUPADI.MinWidth = 25;
      this.colGRUPADI.Name = "colGRUPADI";
      this.colGRUPADI.Visible = true;
      this.colGRUPADI.VisibleIndex = 4;
      this.colGRUPADI.Width = 94;
      this.colToplam.FieldName = "Toplam";
      this.colToplam.MinWidth = 25;
      this.colToplam.Name = "colToplam";
      this.colToplam.Visible = true;
      this.colToplam.VisibleIndex = 5;
      this.colToplam.Width = 94;
      this.colISLEMTIPIID.FieldName = "ISLEMTIPIID";
      this.colISLEMTIPIID.MinWidth = 25;
      this.colISLEMTIPIID.Name = "colISLEMTIPIID";
      this.colISLEMTIPIID.Visible = true;
      this.colISLEMTIPIID.VisibleIndex = 6;
      this.colISLEMTIPIID.Width = 94;
      this.colYıl.FieldName = "Yıl";
      this.colYıl.MinWidth = 25;
      this.colYıl.Name = "colYıl";
      this.colYıl.Visible = true;
      this.colYıl.VisibleIndex = 7;
      this.colYıl.Width = 94;
      this.colARACTIPIID.FieldName = "ARACTIPIID";
      this.colARACTIPIID.MinWidth = 25;
      this.colARACTIPIID.Name = "colARACTIPIID";
      this.colARACTIPIID.Visible = true;
      this.colARACTIPIID.VisibleIndex = 8;
      this.colARACTIPIID.Width = 94;
      this.colMODEL.FieldName = "MODEL";
      this.colMODEL.MinWidth = 25;
      this.colMODEL.Name = "colMODEL";
      this.colMODEL.Visible = true;
      this.colMODEL.VisibleIndex = 9;
      this.colMODEL.Width = 94;
      this.colBELDBIRIMID.FieldName = "BELDBIRIMID";
      this.colBELDBIRIMID.MinWidth = 25;
      this.colBELDBIRIMID.Name = "colBELDBIRIMID";
      this.colBELDBIRIMID.Visible = true;
      this.colBELDBIRIMID.VisibleIndex = 10;
      this.colBELDBIRIMID.Width = 94;
      this.colARACDURUMID.FieldName = "ARACDURUMID";
      this.colARACDURUMID.MinWidth = 25;
      this.colARACDURUMID.Name = "colARACDURUMID";
      this.colARACDURUMID.Visible = true;
      this.colARACDURUMID.VisibleIndex = 11;
      this.colARACDURUMID.Width = 94;
      this.colAltGrup.FieldName = "Alt Grup";
      this.colAltGrup.MinWidth = 25;
      this.colAltGrup.Name = "colAltGrup";
      this.colAltGrup.Visible = true;
      this.colAltGrup.VisibleIndex = 12;
      this.colAltGrup.Width = 94;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1509, 715);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.IconOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.Name = nameof (AracMasraf);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "YILLIK İZİN HAKKI";
      this.Load += new EventHandler(this.izinhakkiekleme_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.baskanlikMasraf.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
