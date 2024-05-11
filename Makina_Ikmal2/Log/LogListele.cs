// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Log.LogListele
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Log
{
  public class LogListele : XtraForm
  {
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private BarEditItem barEditItem1;
    private BarEditItem barEditItem2;
    private BarButtonItem barButtonItem2;
    private BarEditItem barEditItem3;
    private BarEditItem barEditItem4;
    private BarEditItem barEditItem5;
    private BarEditItem barEditItem6;
    protected BarEditItem barEditItem7;
    private BarEditItem barEditItem8;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup3;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLLOGBindingSource;
    private Makina_Ikmal.bellDataSet6TableAdapters.TBLLOGTableAdapter tBLLOGTableAdapter;
    private BarButtonItem barButtonItem3;
    private RibbonPageGroup ribbonPageGroup1;
    private RepositoryItemSearchLookUpEdit AdSoyad;
    private GridView repositoryItemSearchLookUpEdit1View;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn colID;
    private GridColumn colISLEMSAYFASI;
    private GridColumn colISLEMTURU;
    private GridColumn colISLEMINID;
    private GridColumn colTARIH;
    private GridColumn colSAAT;
    private GridColumn colKULLANICIADI;
    private GridColumn colKULLANICIID;
    private GridColumn colIP;
    private GridColumn colMAC;

    public LogListele() => this.InitializeComponent();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void LogListele_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLLOGTableAdapter.Fill(this.bellDataSet6.TBLLOG);
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.tBLLOGTableAdapter.Fill(this.bellDataSet6.TBLLOG);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LogListele));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barEditItem2 = new BarEditItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barEditItem3 = new BarEditItem();
      this.barEditItem4 = new BarEditItem();
      this.barEditItem5 = new BarEditItem();
      this.barEditItem6 = new BarEditItem();
      this.barEditItem7 = new BarEditItem();
      this.barEditItem8 = new BarEditItem();
      this.barButtonItem3 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.tBLLOGBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colISLEMSAYFASI = new GridColumn();
      this.colISLEMTURU = new GridColumn();
      this.colISLEMINID = new GridColumn();
      this.colTARIH = new GridColumn();
      this.colSAAT = new GridColumn();
      this.colKULLANICIADI = new GridColumn();
      this.AdSoyad = new RepositoryItemSearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colKULLANICIID = new GridColumn();
      this.colIP = new GridColumn();
      this.colMAC = new GridColumn();
      this.tBLLOGTableAdapter = new Makina_Ikmal.bellDataSet6TableAdapters.TBLLOGTableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLLOGBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.gridView1.BeginInit();
      this.AdSoyad.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[18]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.barEditItem2,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem4,
        (BarItem) this.barEditItem5,
        (BarItem) this.barEditItem6,
        (BarItem) this.barEditItem7,
        (BarItem) this.barEditItem8,
        (BarItem) this.barButtonItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 28;
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
      this.ribbonControl1.Size = new Size(1090, 118);
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
      this.KayitBulButton.Caption = "Kayıt Bul";
      this.KayitBulButton.Id = 5;
      this.KayitBulButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.Image");
      this.KayitBulButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KayitBulButton.ImageOptions.LargeImage");
      this.KayitBulButton.LargeWidth = 100;
      this.KayitBulButton.Name = "KayitBulButton";
      this.KayitBulButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Caption = "barEditItem1";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.Id = 13;
      this.barEditItem2.Name = "barEditItem2";
      this.barButtonItem2.Caption = "barButtonItem2";
      this.barButtonItem2.Id = 14;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.RibbonStyle = RibbonItemStyles.Large | RibbonItemStyles.SmallWithoutText;
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.Id = 18;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem4.Edit = (RepositoryItem) null;
      this.barEditItem4.Id = 19;
      this.barEditItem4.Name = "barEditItem4";
      this.barEditItem5.Edit = (RepositoryItem) null;
      this.barEditItem5.Id = 20;
      this.barEditItem5.Name = "barEditItem5";
      this.barEditItem6.Caption = "barEditItem6";
      this.barEditItem6.Edit = (RepositoryItem) null;
      this.barEditItem6.Id = 22;
      this.barEditItem6.Name = "barEditItem6";
      this.barEditItem7.Edit = (RepositoryItem) null;
      this.barEditItem7.EditHeight = 80;
      this.barEditItem7.EditWidth = 70;
      this.barEditItem7.Id = 23;
      this.barEditItem7.Name = "barEditItem7";
      this.barEditItem7.RibbonStyle = RibbonItemStyles.Large;
      this.barEditItem8.Caption = "barEditItem8";
      this.barEditItem8.Edit = (RepositoryItem) null;
      this.barEditItem8.Id = 24;
      this.barEditItem8.Name = "barEditItem8";
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 27;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.gridControl1.DataSource = (object) this.tBLLOGBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 118);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.AdSoyad
      });
      this.gridControl1.Size = new Size(1090, 390);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLLOGBindingSource.DataMember = "TBLLOG";
      this.tBLLOGBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[10]
      {
        this.colID,
        this.colISLEMSAYFASI,
        this.colISLEMTURU,
        this.colISLEMINID,
        this.colTARIH,
        this.colSAAT,
        this.colKULLANICIADI,
        this.colKULLANICIID,
        this.colIP,
        this.colMAC
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 94;
      this.colISLEMSAYFASI.Caption = "İşlem Sayfası";
      this.colISLEMSAYFASI.FieldName = "ISLEMSAYFASI";
      this.colISLEMSAYFASI.MinWidth = 25;
      this.colISLEMSAYFASI.Name = "colISLEMSAYFASI";
      this.colISLEMSAYFASI.OptionsColumn.AllowEdit = false;
      this.colISLEMSAYFASI.OptionsColumn.ReadOnly = true;
      this.colISLEMSAYFASI.Visible = true;
      this.colISLEMSAYFASI.VisibleIndex = 1;
      this.colISLEMSAYFASI.Width = 94;
      this.colISLEMTURU.Caption = "İşlem Türü";
      this.colISLEMTURU.FieldName = "ISLEMTURU";
      this.colISLEMTURU.MinWidth = 25;
      this.colISLEMTURU.Name = "colISLEMTURU";
      this.colISLEMTURU.OptionsColumn.AllowEdit = false;
      this.colISLEMTURU.OptionsColumn.ReadOnly = true;
      this.colISLEMTURU.Visible = true;
      this.colISLEMTURU.VisibleIndex = 2;
      this.colISLEMTURU.Width = 94;
      this.colISLEMINID.Caption = "İşlemin Id'si";
      this.colISLEMINID.FieldName = "ISLEMINID";
      this.colISLEMINID.MinWidth = 25;
      this.colISLEMINID.Name = "colISLEMINID";
      this.colISLEMINID.OptionsColumn.AllowEdit = false;
      this.colISLEMINID.OptionsColumn.ReadOnly = true;
      this.colISLEMINID.Visible = true;
      this.colISLEMINID.VisibleIndex = 3;
      this.colISLEMINID.Width = 94;
      this.colTARIH.Caption = "Tarih";
      this.colTARIH.FieldName = "TARIH";
      this.colTARIH.MinWidth = 25;
      this.colTARIH.Name = "colTARIH";
      this.colTARIH.OptionsColumn.AllowEdit = false;
      this.colTARIH.OptionsColumn.ReadOnly = true;
      this.colTARIH.Visible = true;
      this.colTARIH.VisibleIndex = 4;
      this.colTARIH.Width = 94;
      this.colSAAT.Caption = "Saat";
      this.colSAAT.FieldName = "SAAT";
      this.colSAAT.MinWidth = 25;
      this.colSAAT.Name = "colSAAT";
      this.colSAAT.OptionsColumn.AllowEdit = false;
      this.colSAAT.OptionsColumn.ReadOnly = true;
      this.colSAAT.Visible = true;
      this.colSAAT.VisibleIndex = 5;
      this.colSAAT.Width = 94;
      this.colKULLANICIADI.Caption = "Kullanıcı Adı";
      this.colKULLANICIADI.ColumnEdit = (RepositoryItem) this.AdSoyad;
      this.colKULLANICIADI.FieldName = "KULLANICIADI";
      this.colKULLANICIADI.MinWidth = 25;
      this.colKULLANICIADI.Name = "colKULLANICIADI";
      this.colKULLANICIADI.OptionsColumn.AllowEdit = false;
      this.colKULLANICIADI.OptionsColumn.ReadOnly = true;
      this.colKULLANICIADI.Visible = true;
      this.colKULLANICIADI.VisibleIndex = 6;
      this.colKULLANICIADI.Width = 94;
      this.AdSoyad.AutoHeight = false;
      this.AdSoyad.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AdSoyad.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AdSoyad.DisplayMember = "ADISOYADI";
      this.AdSoyad.Name = "AdSoyad";
      this.AdSoyad.NullText = "";
      this.AdSoyad.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.AdSoyad.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colKULLANICIID.ColumnEdit = (RepositoryItem) this.AdSoyad;
      this.colKULLANICIID.FieldName = "KULLANICIID";
      this.colKULLANICIID.MinWidth = 25;
      this.colKULLANICIID.Name = "colKULLANICIID";
      this.colKULLANICIID.OptionsColumn.AllowEdit = false;
      this.colKULLANICIID.OptionsColumn.ReadOnly = true;
      this.colKULLANICIID.Width = 94;
      this.colIP.Caption = "IP Adresi";
      this.colIP.FieldName = "IP";
      this.colIP.MinWidth = 25;
      this.colIP.Name = "colIP";
      this.colIP.OptionsColumn.AllowEdit = false;
      this.colIP.OptionsColumn.ReadOnly = true;
      this.colIP.Visible = true;
      this.colIP.VisibleIndex = 7;
      this.colIP.Width = 94;
      this.colMAC.Caption = "Mac Adresi";
      this.colMAC.FieldName = "MAC";
      this.colMAC.MinWidth = 25;
      this.colMAC.Name = "colMAC";
      this.colMAC.OptionsColumn.AllowEdit = false;
      this.colMAC.OptionsColumn.ReadOnly = true;
      this.colMAC.Width = 94;
      this.tBLLOGTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1090, 508);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (LogListele);
      this.Text = nameof (LogListele);
      this.Load += new EventHandler(this.LogListele_Load);
      this.ribbonControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLLOGBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.gridView1.EndInit();
      this.AdSoyad.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
