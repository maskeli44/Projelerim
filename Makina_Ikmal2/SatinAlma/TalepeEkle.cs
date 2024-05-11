// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepeEkle
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.TalepToplaTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TalepeEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    public int secim = 0;
    private int degerVar = 0;
    private int talepID = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarEditItem barEditItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet5 bellDataSet5;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private RepositoryItemLookUpEdit firmaAd;
    private TalepTopla talepTopla;
    private BindingSource talebiYukleBindingSource;
    private TalebiYukleTableAdapter talebiYukleTableAdapter;
    private GridColumn colTalepKodu;
    private GridColumn colTarih;
    private GridColumn colSayı;
    private GridColumn colKonu;
    private GridColumn colTeklifKodu;
    private GridColumn gridColumn1;

    public TalepeEkle() => this.InitializeComponent();

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.talebiYukleTableAdapter.Fill(this.talepTopla.TalebiYukle);

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.yap();

    private void yap()
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      try
      {
        TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (hd => hd.ID == YetkiClass.secim_id));
        int num1;
        if (tbltalep.TEKLIFID.HasValue)
        {
          int? teklifid = tbltalep.TEKLIFID;
          int num2 = 0;
          num1 = teklifid.GetValueOrDefault() <= num2 & teklifid.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
        if (num1 != 0)
        {
          YetkiClass.secim_id = tbltalep.ID;
          this.talepID = tbltalep.ID;
          try
          {
            if (this.db.TBLTALEPTEKNIKSART.Where<TBLTALEPTEKNIKSART>((Expression<System.Func<TBLTALEPTEKNIKSART, bool>>) (hd => hd.TALEPID == (int?) this.talepID)).Count<TBLTALEPTEKNIKSART>() <= 0)
            {
              int num3 = (int) XtraMessageBox.Show("Talebin Teknik Şartnmesi Olmalıdır.");
            }
            else
            {
              TeklifFisi openForm = (TeklifFisi) Application.OpenForms["TeklifFisi"];
              if (openForm != null)
              {
                openForm.liste2(this.talepID);
                int num4 = (int) XtraMessageBox.Show(tbltalep.KOD + " kodlu talebiniz listeye eklenmiştir.");
              }
              this.Close();
            }
          }
          catch (Exception ex)
          {
            int num5 = (int) MessageBox.Show(ex.ToString());
          }
        }
        else
        {
          int num6 = (int) XtraMessageBox.Show("Teklife Kaydedilen Fiş Eklenemez");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void FisEkle_Load(object sender, EventArgs e) => this.talebiYukleTableAdapter.Fill(this.talepTopla.TalebiYukle);

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridView1_DoubleClick(object sender, EventArgs e) => this.yap();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepeEkle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.talebiYukleBindingSource = new BindingSource(this.components);
      this.talepTopla = new TalepTopla();
      this.gridView1 = new GridView();
      this.colTalepKodu = new GridColumn();
      this.colTarih = new GridColumn();
      this.colSayı = new GridColumn();
      this.colKonu = new GridColumn();
      this.colTeklifKodu = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.firmaAd = new RepositoryItemLookUpEdit();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.bellDataSet5 = new bellDataSet5();
      this.talebiYukleTableAdapter = new TalebiYukleTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.talebiYukleBindingSource).BeginInit();
      this.talepTopla.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.firmaAd.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.bellDataSet5.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[13]
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
        (BarItem) this.barEditItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barEditItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 16;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1016, 122);
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
      this.SilButton.Caption = "Sil";
      this.SilButton.Id = 3;
      this.SilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.Image");
      this.SilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.LargeImage");
      this.SilButton.LargeWidth = 100;
      this.SilButton.Name = "SilButton";
      this.SilButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barButtonItem2.Caption = "Talebi Yükle";
      this.barButtonItem2.Id = 12;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Hint = "Kayit Bul..";
      this.barEditItem2.Id = 15;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.talebiYukleBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.firmaAd
      });
      this.gridControl1.Size = new Size(1016, 497);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.talebiYukleBindingSource.DataMember = "TalebiYukle";
      this.talebiYukleBindingSource.DataSource = (object) this.talepTopla;
      this.talepTopla.DataSetName = "TalepTopla";
      this.talepTopla.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[6]
      {
        this.colTalepKodu,
        this.colTarih,
        this.colSayı,
        this.colKonu,
        this.colTeklifKodu,
        this.gridColumn1
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colTalepKodu.FieldName = "KOD";
      this.colTalepKodu.MinWidth = 23;
      this.colTalepKodu.Name = "colTalepKodu";
      this.colTalepKodu.OptionsColumn.AllowEdit = false;
      this.colTalepKodu.OptionsColumn.ReadOnly = true;
      this.colTalepKodu.Visible = true;
      this.colTalepKodu.VisibleIndex = 4;
      this.colTalepKodu.Width = 87;
      this.colTarih.FieldName = "Tarih";
      this.colTarih.MinWidth = 23;
      this.colTarih.Name = "colTarih";
      this.colTarih.OptionsColumn.AllowEdit = false;
      this.colTarih.OptionsColumn.ReadOnly = true;
      this.colTarih.Visible = true;
      this.colTarih.VisibleIndex = 3;
      this.colTarih.Width = 87;
      this.colSayı.FieldName = "Sayı";
      this.colSayı.MinWidth = 23;
      this.colSayı.Name = "colSayı";
      this.colSayı.OptionsColumn.AllowEdit = false;
      this.colSayı.OptionsColumn.ReadOnly = true;
      this.colSayı.Visible = true;
      this.colSayı.VisibleIndex = 2;
      this.colSayı.Width = 87;
      this.colKonu.FieldName = "Konu";
      this.colKonu.MinWidth = 23;
      this.colKonu.Name = "colKonu";
      this.colKonu.OptionsColumn.AllowEdit = false;
      this.colKonu.OptionsColumn.ReadOnly = true;
      this.colKonu.Visible = true;
      this.colKonu.VisibleIndex = 1;
      this.colKonu.Width = 87;
      this.colTeklifKodu.FieldName = "Tekif";
      this.colTeklifKodu.MinWidth = 23;
      this.colTeklifKodu.Name = "colTeklifKodu";
      this.colTeklifKodu.OptionsColumn.AllowEdit = false;
      this.colTeklifKodu.OptionsColumn.ReadOnly = true;
      this.colTeklifKodu.Visible = true;
      this.colTeklifKodu.VisibleIndex = 0;
      this.colTeklifKodu.Width = 87;
      this.gridColumn1.Caption = "gridColumn1";
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Width = 87;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DisplayMember = "KOD";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.firmaAd.AutoHeight = false;
      this.firmaAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmaAd.DisplayMember = "FIRMAADI";
      this.firmaAd.Name = "firmaAd";
      this.firmaAd.ValueMember = "ID";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.talebiYukleTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1016, 619);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (TalepeEkle);
      this.Text = "FisEkle";
      this.Load += new EventHandler(this.FisEkle_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.talebiYukleBindingSource).EndInit();
      this.talepTopla.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.firmaAd.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.bellDataSet5.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
