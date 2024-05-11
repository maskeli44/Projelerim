// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepTeknikSartname
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.TalepToplaTableAdapters;
using Makina_Ikmal.SatinAlma.TalepRaporlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TalepTeknikSartname : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int control = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup3;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem talebYukleButon;
    private BarButtonItem barButtonItem3;
    private LayoutControl layoutControl1;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridControl gridControl1;
    private GridView gridView1;
    private TextEdit isinAdiTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private GridColumn colID;
    private GridColumn colISINADI;
    private SimpleButton simpleButton3;
    private SimpleButton guncelleKaydet;
    private SimpleButton yeniKaydet;
    private ComboBoxEdit durumCombo;
    private TextEdit aciklamaTxt;
    private TextEdit siraNoTxt;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLTEKNIKSARTBindingSource;
    private TBLTEKNIKSARTTableAdapter tBLTEKNIKSARTTableAdapter;
    private BindingSource tBLTEKNIKSARTHRKTBindingSource;
    private TalepTopla talepTopla;
    private GridColumn colSIRANO;
    private GridColumn colACIKLAMA;
    private GridColumn colDURUM;
    private TBLTEKNIKSARTHRKTTableAdapter3 tBLTEKNIKSARTHRKTTableAdapter3;
    private SimpleButton simpleButton1;
    private LayoutControlItem layoutControlItem10;
    private GridColumn gridColumn1;

    public TalepTeknikSartname() => this.InitializeComponent();

    private void TeknikSartname_Load(object sender, EventArgs e) => this.tBLTEKNIKSARTTableAdapter.Fill(this.bellDataSet5.TBLTEKNIKSART);

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void YazdirButton_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new TeknikSartnameGoruntu()).ShowPreviewDialog();

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void gridView1_Click(object sender, EventArgs e)
    {
      this.tBLTEKNIKSARTHRKTTableAdapter3.Fill(this.talepTopla.TBLTEKNIKSARTHRKT, new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"))));
      this.isinAdiTxt.Text = this.gridView1.GetFocusedRowCellValue(this.colISINADI).ToString();
      if (this.gridView2.DataRowCount != 0)
      {
        this.aciklamaTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colACIKLAMA).ToString();
        this.siraNoTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colSIRANO).ToString();
        this.durumCombo.Text = this.gridView2.GetFocusedRowCellValue(this.colDURUM).ToString();
      }
      else
        this.siraNoTxt.Text = "1";
    }

    private void gridView2_Click(object sender, EventArgs e)
    {
      this.siraNoTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colSIRANO).ToString();
      this.aciklamaTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colACIKLAMA).ToString();
      this.durumCombo.Text = this.gridView2.GetFocusedRowCellValue(this.colDURUM).ToString();
    }

    private void Listele()
    {
      this.tBLTEKNIKSARTHRKTTableAdapter3.Fill(this.talepTopla.TBLTEKNIKSARTHRKT, new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"))));
      this.tBLTEKNIKSARTTableAdapter.Fill(this.bellDataSet5.TBLTEKNIKSART);
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.isinAdiTxt.Text != "")
      {
        try
        {
          this.db.TBLTEKNIKSART.Add(new TBLTEKNIKSART()
          {
            ISINADI = this.isinAdiTxt.Text
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

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (this.isinAdiTxt.Text != "" && guncelID != 0)
      {
        try
        {
          this.db.TBLTEKNIKSART.FirstOrDefault<TBLTEKNIKSART>((Expression<System.Func<TBLTEKNIKSART, bool>>) (x => x.ID == guncelID)).ISINADI = this.isinAdiTxt.Text;
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

    private void yeniKaydet_Click(object sender, EventArgs e)
    {
      this.siraNoTxt.Text = Convert.ToString(Convert.ToInt32(this.gridView2.DataRowCount) + 1);
      this.aciklamaTxt.Text = "";
      this.control = 1;
    }

    private bool BoslukKontrol() => this.isinAdiTxt.Text != "" && this.siraNoTxt.Text != "" && this.aciklamaTxt.Text != "" && this.durumCombo.SelectedItem.ToString() != "";

    private void guncelleKaydet_Click(object sender, EventArgs e)
    {
      if (this.BoslukKontrol() && this.control == 1)
      {
        try
        {
          this.db.TBLTEKNIKSARTHRKT.Add(new TBLTEKNIKSARTHRKT()
          {
            SIRANO = this.siraNoTxt.Text,
            TEKNIKID = new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID))),
            ACIKLAMA = this.aciklamaTxt.Text,
            DURUM = this.durumCombo.SelectedItem.ToString()
          });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
          this.Listele();
          this.control = 0;
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var Veya Yeni Kaydet Butonuna Basınız");
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      if (this.BoslukKontrol() && guncelID != 0 && this.control == 0)
      {
        try
        {
          TBLTEKNIKSARTHRKT tbltekniksarthrkt = this.db.TBLTEKNIKSARTHRKT.FirstOrDefault<TBLTEKNIKSARTHRKT>((Expression<System.Func<TBLTEKNIKSARTHRKT, bool>>) (x => x.ID == guncelID));
          tbltekniksarthrkt.TEKNIKID = new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID)));
          tbltekniksarthrkt.SIRANO = this.siraNoTxt.Text;
          tbltekniksarthrkt.ACIKLAMA = this.aciklamaTxt.Text;
          tbltekniksarthrkt.DURUM = this.durumCombo.SelectedItem.ToString();
          this.db.SaveChanges();
          this.Listele();
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

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      if (guncelID == 0)
        return;
      try
      {
        this.db.TBLTEKNIKSARTHRKT.Remove(this.db.TBLTEKNIKSARTHRKT.FirstOrDefault<TBLTEKNIKSARTHRKT>((Expression<System.Func<TBLTEKNIKSARTHRKT, bool>>) (x => x.ID == guncelID)));
        this.db.SaveChanges();
        this.Listele();
      }
      catch
      {
      }
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (guncelID == 0)
        return;
      try
      {
        IQueryable<TBLTEKNIKSARTHRKT> source = this.db.TBLTEKNIKSARTHRKT.Where<TBLTEKNIKSARTHRKT>((Expression<System.Func<TBLTEKNIKSARTHRKT, bool>>) (hd => hd.TEKNIKID == (int?) guncelID));
        if (source.Count<TBLTEKNIKSARTHRKT>() > 0)
        {
          foreach (TBLTEKNIKSARTHRKT tbltekniksarthrkt in (IEnumerable<TBLTEKNIKSARTHRKT>) source)
            this.db.TBLTEKNIKSARTHRKT.Remove(this.db.TBLTEKNIKSARTHRKT.Find(new object[1]
            {
              (object) tbltekniksarthrkt.ID
            }));
        }
        this.db.TBLTEKNIKSART.Remove(this.db.TBLTEKNIKSART.FirstOrDefault<TBLTEKNIKSART>((Expression<System.Func<TBLTEKNIKSART, bool>>) (x => x.ID == guncelID)));
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
        Console.WriteLine(ex.ToString());
      }
      this.tBLTEKNIKSARTTableAdapter.Fill(this.bellDataSet5.TBLTEKNIKSART);
    }

    public void Gizle(int hide)
    {
      if (hide != 1)
        return;
      this.talebYukleButon.Enabled = false;
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    private void talebYukleButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        for (int rowHandle = 0; rowHandle < this.gridView2.DataRowCount; ++rowHandle)
        {
          this.db.TBLTALEPTEKNIKSART.Add(new TBLTALEPTEKNIKSART()
          {
            SIRANO = Convert.ToString(this.gridView2.GetRowCellValue(rowHandle, "SIRANO")),
            TALEPID = new int?(YetkiClass.secim_id),
            ACIKLAMA = this.gridView2.GetRowCellValue(rowHandle, "ACIKLAMA").ToString()
          });
          this.db.SaveChanges();
        }
        YetkiClass.secim = this.gridView1.GetFocusedRowCellValue(this.colISINADI).ToString();
        ((TalepEkle) Application.OpenForms["TalepEkle"])?.Listele();
        this.Close();
      }
      catch
      {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepTeknikSartname));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLTEKNIKSARTBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colISINADI = new GridColumn();
      this.talebYukleButon = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.simpleButton1 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.guncelleKaydet = new SimpleButton();
      this.yeniKaydet = new SimpleButton();
      this.durumCombo = new ComboBoxEdit();
      this.aciklamaTxt = new TextEdit();
      this.siraNoTxt = new TextEdit();
      this.gridControl2 = new GridControl();
      this.tBLTEKNIKSARTHRKTBindingSource = new BindingSource(this.components);
      this.talepTopla = new TalepTopla();
      this.gridView2 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colACIKLAMA = new GridColumn();
      this.colDURUM = new GridColumn();
      this.isinAdiTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.tBLTEKNIKSARTTableAdapter = new TBLTEKNIKSARTTableAdapter();
      this.tBLTEKNIKSARTHRKTTableAdapter3 = new TBLTEKNIKSARTHRKTTableAdapter3();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLTEKNIKSARTBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.durumCombo.Properties.BeginInit();
      this.aciklamaTxt.Properties.BeginInit();
      this.siraNoTxt.Properties.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLTEKNIKSARTHRKTBindingSource).BeginInit();
      this.talepTopla.BeginInit();
      this.gridView2.BeginInit();
      this.isinAdiTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
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
        (BarItem) this.barEditItem1,
        (BarItem) this.talebYukleButon,
        (BarItem) this.barButtonItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 14;
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
      this.YazdirButton.ItemClick += new ItemClickEventHandler(this.YazdirButton_ItemClick);
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
      this.gridControl1.DataSource = (object) this.tBLTEKNIKSARTBindingSource;
      this.gridControl1.Location = new Point(12, 40);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1062, 150);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLTEKNIKSARTBindingSource.DataMember = "TBLTEKNIKSART";
      this.tBLTEKNIKSARTBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.gridView1.Appearance.EvenRow.BackColor2 = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.gridView1.Appearance.EvenRow.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.EvenRow.Options.UseFont = true;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
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
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colISINADI.Caption = "İşin Adı";
      this.colISINADI.FieldName = "ISINADI";
      this.colISINADI.Name = "colISINADI";
      this.colISINADI.OptionsColumn.AllowEdit = false;
      this.colISINADI.OptionsColumn.ReadOnly = true;
      this.colISINADI.Visible = true;
      this.colISINADI.VisibleIndex = 0;
      this.talebYukleButon.Caption = "Talebe Yükle";
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.talebYukleButon);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.YazdirButton, true);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.simpleButton3);
      this.layoutControl1.Controls.Add((Control) this.guncelleKaydet);
      this.layoutControl1.Controls.Add((Control) this.yeniKaydet);
      this.layoutControl1.Controls.Add((Control) this.durumCombo);
      this.layoutControl1.Controls.Add((Control) this.aciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.siraNoTxt);
      this.layoutControl1.Controls.Add((Control) this.gridControl2);
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
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton1.Location = new Point(960, 194);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(54, 36);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 14;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton3.Location = new Point(1018, 194);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(56, 36);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 13;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.guncelleKaydet.ImageOptions.Image = (Image) componentResourceManager.GetObject("guncelleKaydet.ImageOptions.Image");
      this.guncelleKaydet.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.guncelleKaydet.Location = new Point(902, 194);
      this.guncelleKaydet.Name = "guncelleKaydet";
      this.guncelleKaydet.PaintStyle = PaintStyles.Light;
      this.guncelleKaydet.Size = new Size(54, 36);
      this.guncelleKaydet.StyleController = (IStyleController) this.layoutControl1;
      this.guncelleKaydet.TabIndex = 12;
      this.guncelleKaydet.ToolTip = "Kaydet";
      this.guncelleKaydet.Click += new EventHandler(this.guncelleKaydet_Click);
      this.yeniKaydet.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniKaydet.ImageOptions.Image");
      this.yeniKaydet.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.yeniKaydet.Location = new Point(846, 194);
      this.yeniKaydet.Name = "yeniKaydet";
      this.yeniKaydet.PaintStyle = PaintStyles.Light;
      this.yeniKaydet.Size = new Size(52, 36);
      this.yeniKaydet.StyleController = (IStyleController) this.layoutControl1;
      this.yeniKaydet.TabIndex = 11;
      this.yeniKaydet.Click += new EventHandler(this.yeniKaydet_Click);
      this.durumCombo.Location = new Point(720, 200);
      this.durumCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.durumCombo.Name = "durumCombo";
      this.durumCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.durumCombo.Properties.Appearance.Options.UseFont = true;
      this.durumCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.durumCombo.Properties.Items.AddRange(new object[2]
      {
        (object) "AKTİF",
        (object) "PASİF"
      });
      this.durumCombo.Size = new Size(122, 24);
      this.durumCombo.StyleController = (IStyleController) this.layoutControl1;
      this.durumCombo.TabIndex = 10;
      this.aciklamaTxt.Location = new Point(234, 200);
      this.aciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aciklamaTxt.Name = "aciklamaTxt";
      this.aciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.aciklamaTxt.Size = new Size(482, 24);
      this.aciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.aciklamaTxt.TabIndex = 8;
      this.siraNoTxt.Location = new Point(75, 200);
      this.siraNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.siraNoTxt.Name = "siraNoTxt";
      this.siraNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.siraNoTxt.Properties.Appearance.Options.UseFont = true;
      this.siraNoTxt.Properties.Mask.EditMask = "n0";
      this.siraNoTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.siraNoTxt.Size = new Size(92, 24);
      this.siraNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.siraNoTxt.TabIndex = 7;
      this.gridControl2.DataSource = (object) this.tBLTEKNIKSARTHRKTBindingSource;
      this.gridControl2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(12, 234);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1062, 169);
      this.gridControl2.TabIndex = 6;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLTEKNIKSARTHRKTBindingSource.DataMember = "TBLTEKNIKSARTHRKT";
      this.tBLTEKNIKSARTHRKTBindingSource.DataSource = (object) this.talepTopla;
      this.talepTopla.DataSetName = "TalepTopla";
      this.talepTopla.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[4]
      {
        this.gridColumn1,
        this.colSIRANO,
        this.colACIKLAMA,
        this.colDURUM
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridView2.Click += new EventHandler(this.gridView2_Click);
      this.gridColumn1.Caption = "gridColumn1";
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.Name = "gridColumn1";
      this.colSIRANO.Caption = "Sıra No";
      this.colSIRANO.DisplayFormat.FormatType = FormatType.Numeric;
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.OptionsColumn.AllowEdit = false;
      this.colSIRANO.OptionsColumn.ReadOnly = true;
      this.colSIRANO.Visible = true;
      this.colSIRANO.VisibleIndex = 0;
      this.colSIRANO.Width = 87;
      this.colACIKLAMA.Caption = "Açıklama";
      this.colACIKLAMA.FieldName = "ACIKLAMA";
      this.colACIKLAMA.Name = "colACIKLAMA";
      this.colACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colACIKLAMA.Visible = true;
      this.colACIKLAMA.VisibleIndex = 1;
      this.colACIKLAMA.Width = 406;
      this.colDURUM.Caption = "Durum";
      this.colDURUM.FieldName = "DURUM";
      this.colDURUM.Name = "colDURUM";
      this.colDURUM.OptionsColumn.AllowEdit = false;
      this.colDURUM.OptionsColumn.ReadOnly = true;
      this.colDURUM.Visible = true;
      this.colDURUM.VisibleIndex = 2;
      this.colDURUM.Width = 126;
      this.isinAdiTxt.Location = new Point(75, 12);
      this.isinAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isinAdiTxt.Name = "isinAdiTxt";
      this.isinAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isinAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.isinAdiTxt.Size = new Size(999, 24);
      this.isinAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.isinAdiTxt.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[10]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10
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
      this.layoutControlItem1.Text = "İşin Adı";
      this.layoutControlItem1.TextSize = new Size(60, 18);
      this.layoutControlItem2.Control = (Control) this.gridControl1;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1066, 154);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.gridControl2;
      this.layoutControlItem3.Location = new Point(0, 222);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(1066, 173);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.siraNoTxt;
      this.layoutControlItem4.Location = new Point(0, 182);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2);
      this.layoutControlItem4.Size = new Size(159, 40);
      this.layoutControlItem4.Text = "Sira No";
      this.layoutControlItem4.TextSize = new Size(60, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.aciklamaTxt;
      this.layoutControlItem5.Location = new Point(159, 182);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2);
      this.layoutControlItem5.Size = new Size(549, 40);
      this.layoutControlItem5.Text = "Açıklama";
      this.layoutControlItem5.TextSize = new Size(60, 18);
      this.layoutControlItem7.Control = (Control) this.durumCombo;
      this.layoutControlItem7.Location = new Point(708, 182);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2);
      this.layoutControlItem7.Size = new Size(126, 40);
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.layoutControlItem6.Control = (Control) this.yeniKaydet;
      this.layoutControlItem6.Location = new Point(834, 182);
      this.layoutControlItem6.MaxSize = new Size(56, 40);
      this.layoutControlItem6.MinSize = new Size(56, 40);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(56, 40);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem8.Control = (Control) this.guncelleKaydet;
      this.layoutControlItem8.Location = new Point(890, 182);
      this.layoutControlItem8.MaxSize = new Size(58, 40);
      this.layoutControlItem8.MinSize = new Size(58, 40);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(58, 40);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.simpleButton3;
      this.layoutControlItem9.Location = new Point(1006, 182);
      this.layoutControlItem9.MaxSize = new Size(60, 40);
      this.layoutControlItem9.MinSize = new Size(60, 40);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(60, 40);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.simpleButton1;
      this.layoutControlItem10.Location = new Point(948, 182);
      this.layoutControlItem10.MaxSize = new Size(58, 40);
      this.layoutControlItem10.MinSize = new Size(58, 40);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(58, 40);
      this.layoutControlItem10.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.tBLTEKNIKSARTTableAdapter.ClearBeforeFill = true;
      this.tBLTEKNIKSARTHRKTTableAdapter3.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1086, 515);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (TalepTeknikSartname);
      this.Text = "TeknikSartname";
      this.Load += new EventHandler(this.TeknikSartname_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLTEKNIKSARTBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.durumCombo.Properties.EndInit();
      this.aciklamaTxt.Properties.EndInit();
      this.siraNoTxt.Properties.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLTEKNIKSARTHRKTBindingSource).EndInit();
      this.talepTopla.EndInit();
      this.gridView2.EndInit();
      this.isinAdiTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
