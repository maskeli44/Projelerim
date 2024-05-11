// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.VeriGuncelleme.Teklif.SatinAlmaVeriGuncelleme
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
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma.VeriGuncelleme.Teklif
{
  public class SatinAlmaVeriGuncelleme : XtraForm
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
    private BarEditItem barEditItem1;
    private BarButtonItem ExcelCek;
    private BarButtonItem barButtonItem3;
    private BarEditItem barEditItem2;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup3;
    private GridControl gridControl1;
    private GridView gridView1;
    private XtraOpenFileDialog xtraOpenFileDialog1;
    private GridColumn gridColumn1;
    private GridColumn TalepKodu;
    private GridColumn Tarih;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private GridColumn gridColumn8;
    private GridColumn gridColumn9;
    private GridColumn gridColumn10;
    private GridColumn gridColumn11;
    private GridColumn gridColumn12;
    private GridColumn gridColumn13;
    private GridColumn gridColumn14;
    private GridColumn gridColumn15;
    private GridColumn gridColumn16;
    private GridColumn gridColumn17;
    private GridColumn gridColumn18;
    private GridColumn gridColumn19;
    private GridColumn gridColumn20;
    private GridColumn gridColumn21;
    private GridColumn gridColumn22;
    private GridColumn gridColumn23;
    private GridColumn gridColumn24;

    public SatinAlmaVeriGuncelleme() => this.InitializeComponent();

    private void SatinAlmaVeriGuncelleme_Load(object sender, EventArgs e)
    {
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e) => this.Duzenle();

    private void Duzenle()
    {
      try
      {
        if (this.gridView1.DataRowCount > 0)
        {
          for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
          {
            string kod = this.gridView1.GetRowCellValue(rowHandle, this.gridColumn1).ToString();
            TBLTEKLIF tblteklif = this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<Func<TBLTEKLIF, bool>>) (x => x.KOD == kod));
            try
            {
              tblteklif.FATURATARIHI = new DateTime?(Convert.ToDateTime(this.gridView1.GetRowCellValue(rowHandle, "Fatura Tarihi")));
            }
            catch
            {
            }
            try
            {
              tblteklif.FATURANO = this.gridView1.GetRowCellValue(rowHandle, "Fatura No").ToString();
            }
            catch
            {
            }
            try
            {
              tblteklif.FATURATUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "Fatura Tutar")));
            }
            catch
            {
            }
            try
            {
              tblteklif.KDVTUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "Kdv Tutar")));
            }
            catch
            {
            }
            try
            {
              tblteklif.TOPLAMTUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, "Toplam Tutar")));
            }
            catch
            {
            }
            try
            {
              tblteklif.SAKARARTARIHI = new DateTime?(Convert.ToDateTime(this.gridView1.GetRowCellValue(rowHandle, "Karar Tarihi")));
            }
            catch
            {
            }
            try
            {
              tblteklif.SAKARARNO = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "Karar No")));
            }
            catch
            {
            }
            try
            {
              tblteklif.KESINLESTIR = Convert.ToString(this.gridView1.GetRowCellValue(rowHandle, "Kesinleştir"));
            }
            catch
            {
            }
            this.db.SaveChanges();
          }
          int num = (int) XtraMessageBox.Show("Kayit Başarılı");
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Tablo Eklenmesi Gerekir");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void ExcelCek_ItemClick(object sender, ItemClickEventArgs e) => this.Veriler();

    private void Veriler()
    {
      this.xtraOpenFileDialog1.Title = "Lütfen Dosya Seçiniz";
      this.xtraOpenFileDialog1.Filter = " (*.xlsx)|*.xlsx";
      this.xtraOpenFileDialog1.FilterIndex = 1;
      this.xtraOpenFileDialog1.Multiselect = true;
      if (this.xtraOpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.xtraOpenFileDialog1.FileName + ";Extended Properties=Excel 12.0");
      connection.Open();
      OleDbDataReader oleDbDataReader = new OleDbCommand("SELECT * from [Teklif Fiş Listesi$] ", connection).ExecuteReader();
      while (oleDbDataReader.Read())
        this.gridControl1.DataSource = (object) oleDbDataReader;
      connection.Close();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => Application.Exit();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SatinAlmaVeriGuncelleme));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.ExcelCek = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.TalepKodu = new GridColumn();
      this.Tarih = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.gridColumn10 = new GridColumn();
      this.gridColumn11 = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.gridColumn15 = new GridColumn();
      this.gridColumn16 = new GridColumn();
      this.gridColumn17 = new GridColumn();
      this.gridColumn18 = new GridColumn();
      this.gridColumn19 = new GridColumn();
      this.gridColumn20 = new GridColumn();
      this.gridColumn21 = new GridColumn();
      this.gridColumn22 = new GridColumn();
      this.gridColumn23 = new GridColumn();
      this.gridColumn24 = new GridColumn();
      this.xtraOpenFileDialog1 = new XtraOpenFileDialog(this.components);
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
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
        (BarItem) this.barEditItem1,
        (BarItem) this.ExcelCek,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barEditItem2
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
      this.ribbonControl1.Size = new Size(1034, 100);
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
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.ExcelCek.Caption = "Excel Çek";
      this.ExcelCek.Id = 12;
      this.ExcelCek.ImageOptions.Image = (Image) componentResourceManager.GetObject("ExcelCek.ImageOptions.Image");
      this.ExcelCek.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("ExcelCek.ImageOptions.LargeImage");
      this.ExcelCek.LargeWidth = 100;
      this.ExcelCek.Name = "ExcelCek";
      this.ExcelCek.ItemClick += new ItemClickEventHandler(this.ExcelCek_ItemClick);
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 14;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
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
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.ExcelCek);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.YazdirButton, true);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1034, 547);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[24]
      {
        this.gridColumn1,
        this.TalepKodu,
        this.Tarih,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.gridColumn8,
        this.gridColumn9,
        this.gridColumn10,
        this.gridColumn11,
        this.gridColumn12,
        this.gridColumn13,
        this.gridColumn14,
        this.gridColumn15,
        this.gridColumn16,
        this.gridColumn17,
        this.gridColumn18,
        this.gridColumn19,
        this.gridColumn20,
        this.gridColumn21,
        this.gridColumn22,
        this.gridColumn23,
        this.gridColumn24
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridColumn1.Caption = "Teklif Kodu";
      this.gridColumn1.FieldName = "Teklif Kodu";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 62;
      this.TalepKodu.Caption = "Talep Kodu";
      this.TalepKodu.FieldName = "Talep Kodu";
      this.TalepKodu.Name = "TalepKodu";
      this.TalepKodu.Visible = true;
      this.TalepKodu.VisibleIndex = 1;
      this.TalepKodu.Width = 97;
      this.Tarih.Caption = "Tarih";
      this.Tarih.FieldName = "Tarih";
      this.Tarih.Name = "Tarih";
      this.Tarih.Visible = true;
      this.Tarih.VisibleIndex = 2;
      this.Tarih.Width = 83;
      this.gridColumn4.Caption = "Teklifin Konusu";
      this.gridColumn4.FieldName = "Teklifin Konusu";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 69;
      this.gridColumn5.Caption = "Fatura Tarihi";
      this.gridColumn5.FieldName = "Fatura Tarihi";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 4;
      this.gridColumn5.Width = 69;
      this.gridColumn6.Caption = "Fatura No";
      this.gridColumn6.FieldName = "Fatura No";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 5;
      this.gridColumn6.Width = 69;
      this.gridColumn7.Caption = "Fatura Tutar";
      this.gridColumn7.FieldName = "Fatura Tutar";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 6;
      this.gridColumn7.Width = 69;
      this.gridColumn8.Caption = "Kdv Tutar";
      this.gridColumn8.FieldName = "Kdv Tutar";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 7;
      this.gridColumn8.Width = 69;
      this.gridColumn9.Caption = "Toplam Tutar";
      this.gridColumn9.FieldName = "Toplam Tutar";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 8;
      this.gridColumn9.Width = 69;
      this.gridColumn10.Caption = "Karar No";
      this.gridColumn10.FieldName = "Karar No";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 9;
      this.gridColumn11.Caption = "Karar Tarihi";
      this.gridColumn11.FieldName = "Karar Tarihi";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 10;
      this.gridColumn12.Caption = "Kazanan Firma";
      this.gridColumn12.FieldName = "Kazanan Firma";
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 11;
      this.gridColumn13.Caption = "Firma 1";
      this.gridColumn13.FieldName = "Firma 1";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 12;
      this.gridColumn13.Width = 163;
      this.gridColumn14.Caption = "Firma 2";
      this.gridColumn14.FieldName = "Firma 2";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 13;
      this.gridColumn15.Caption = "Firma 3";
      this.gridColumn15.FieldName = "Firma 3";
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 14;
      this.gridColumn16.Caption = "Firma 4";
      this.gridColumn16.FieldName = "Firma 4";
      this.gridColumn16.Name = "gridColumn16";
      this.gridColumn16.Visible = true;
      this.gridColumn16.VisibleIndex = 15;
      this.gridColumn17.Caption = "Firma 5";
      this.gridColumn17.FieldName = "Firma 5";
      this.gridColumn17.Name = "gridColumn17";
      this.gridColumn17.Visible = true;
      this.gridColumn17.VisibleIndex = 16;
      this.gridColumn18.Caption = "Sorumlu Personel";
      this.gridColumn18.FieldName = "Sorumlu Personel";
      this.gridColumn18.Name = "gridColumn18";
      this.gridColumn18.Visible = true;
      this.gridColumn18.VisibleIndex = 17;
      this.gridColumn19.Caption = "Müdür";
      this.gridColumn19.FieldName = "Müdür";
      this.gridColumn19.Name = "gridColumn19";
      this.gridColumn19.Visible = true;
      this.gridColumn19.VisibleIndex = 18;
      this.gridColumn20.Caption = "Daire Başkanı";
      this.gridColumn20.FieldName = "Daire Başkanı";
      this.gridColumn20.Name = "gridColumn20";
      this.gridColumn20.Visible = true;
      this.gridColumn20.VisibleIndex = 19;
      this.gridColumn21.Caption = "Kabul Kom.Üye1";
      this.gridColumn21.FieldName = "Kabul Kom.Üye1";
      this.gridColumn21.Name = "gridColumn21";
      this.gridColumn21.Visible = true;
      this.gridColumn21.VisibleIndex = 20;
      this.gridColumn22.Caption = "Kabul Kom.Üye2";
      this.gridColumn22.FieldName = "Kabul Kom.Üye2";
      this.gridColumn22.Name = "gridColumn22";
      this.gridColumn22.Visible = true;
      this.gridColumn22.VisibleIndex = 21;
      this.gridColumn23.Caption = "Kabul Kom. Başkanı";
      this.gridColumn23.FieldName = "Kabul Kom. Başkanı";
      this.gridColumn23.Name = "gridColumn23";
      this.gridColumn23.Visible = true;
      this.gridColumn23.VisibleIndex = 22;
      this.gridColumn24.Caption = "Kesinleştir";
      this.gridColumn24.FieldName = "Kesinleştir";
      this.gridColumn24.Name = "gridColumn24";
      this.gridColumn24.Visible = true;
      this.gridColumn24.VisibleIndex = 23;
      this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1034, 647);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (SatinAlmaVeriGuncelleme);
      this.Text = nameof (SatinAlmaVeriGuncelleme);
      this.Load += new EventHandler(this.SatinAlmaVeriGuncelleme_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
