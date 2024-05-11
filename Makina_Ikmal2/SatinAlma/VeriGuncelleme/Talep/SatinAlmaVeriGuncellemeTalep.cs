// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.VeriGuncelleme.Talep.SatinAlmaVeriGuncellemeTalep
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
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma.VeriGuncelleme.Talep
{
  public class SatinAlmaVeriGuncellemeTalep : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
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
    private GridColumn gridColumn13;
    private GridColumn gridColumn14;
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
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup3;
    private BarEditItem barEditItem3;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public SatinAlmaVeriGuncellemeTalep() => this.InitializeComponent();

    private void SatinAlmaVeriGuncellemeTalep_Load(object sender, EventArgs e)
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
            this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<Func<TBLTALEP, bool>>) (x => x.KOD == kod));
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
            }
            catch
            {
            }
            try
            {
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
      OleDbDataReader oleDbDataReader = new OleDbCommand("SELECT * from [Talep Fiş Listesi$] ", connection).ExecuteReader();
      while (oleDbDataReader.Read())
        this.gridControl1.DataSource = (object) oleDbDataReader;
      connection.Close();
    }

    private void ExceliGetir()
    {
      this.xtraOpenFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
      this.xtraOpenFileDialog1.Title = "Import Excel";
      this.xtraOpenFileDialog1.Multiselect = false;
      int num = (int) this.xtraOpenFileDialog1.ShowDialog();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => Application.Exit();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SatinAlmaVeriGuncellemeTalep));
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.TalepKodu = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.Tarih = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.gridColumn10 = new GridColumn();
      this.gridColumn11 = new GridColumn();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.xtraOpenFileDialog1 = new XtraOpenFileDialog(this.components);
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
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.SuspendLayout();
      this.gridControl1.Dock = DockStyle.Bottom;
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1034, 547);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.TalepKodu,
        this.gridColumn1,
        this.Tarih,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.gridColumn8,
        this.gridColumn9,
        this.gridColumn10,
        this.gridColumn11,
        this.gridColumn13,
        this.gridColumn14
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.TalepKodu.Caption = "Talep Kodu";
      this.TalepKodu.FieldName = "Talep Kodu";
      this.TalepKodu.Name = "TalepKodu";
      this.TalepKodu.Visible = true;
      this.TalepKodu.VisibleIndex = 0;
      this.TalepKodu.Width = 97;
      this.gridColumn1.Caption = "Teklif Kodu";
      this.gridColumn1.FieldName = "Teklif Kodu";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 1;
      this.gridColumn1.Width = 62;
      this.Tarih.Caption = "Tarih";
      this.Tarih.FieldName = "Tarih";
      this.Tarih.Name = "Tarih";
      this.Tarih.Visible = true;
      this.Tarih.VisibleIndex = 2;
      this.Tarih.Width = 83;
      this.gridColumn4.Caption = "Sayı";
      this.gridColumn4.FieldName = "Sayı";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 69;
      this.gridColumn5.Caption = "Konu";
      this.gridColumn5.FieldName = "Konu";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 4;
      this.gridColumn5.Width = 69;
      this.gridColumn6.Caption = "Durum";
      this.gridColumn6.FieldName = "Durum";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 5;
      this.gridColumn6.Width = 69;
      this.gridColumn7.Caption = "Teklif Sorumlusu";
      this.gridColumn7.FieldName = "Teklif Sorumlusu";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 6;
      this.gridColumn7.Width = 69;
      this.gridColumn8.Caption = "Depo Yetkilisi";
      this.gridColumn8.FieldName = "Depo Yetkilisi";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 7;
      this.gridColumn8.Width = 69;
      this.gridColumn9.Caption = "Atölye Şefi";
      this.gridColumn9.FieldName = "Atölye Şefi";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 8;
      this.gridColumn9.Width = 69;
      this.gridColumn10.Caption = "Şube Müdürü";
      this.gridColumn10.FieldName = "Şube Müdürü";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 9;
      this.gridColumn11.Caption = "Daire Başkanı";
      this.gridColumn11.FieldName = "Daire Başkanı";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 10;
      this.gridColumn13.Caption = "Genel Sekreter Yrd.";
      this.gridColumn13.FieldName = "Genel Sekreter Yrd.";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 11;
      this.gridColumn13.Width = 163;
      this.gridColumn14.Caption = "Genel Sekreter";
      this.gridColumn14.FieldName = "Genel Sekreter";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 12;
      this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
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
        (BarItem) this.barEditItem1,
        (BarItem) this.ExcelCek,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 16;
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
      this.ribbonControl1.Size = new Size(1034, 96);
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
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 14;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 15;
      this.barEditItem3.Name = "barEditItem3";
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
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem3);
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
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1034, 647);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Controls.Add((Control) this.gridControl1);
      this.Name = nameof (SatinAlmaVeriGuncellemeTalep);
      this.Text = "SatinAlmaVeriGuncelleme";
      this.Load += new EventHandler(this.SatinAlmaVeriGuncellemeTalep_Load);
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
