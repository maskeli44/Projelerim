// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.YakitKarti.YakitKarti
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDataLayout;
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
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Otomasyon.YakitKarti.Rapor;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Otomasyon.YakitKarti
{
  public class YakitKarti : XtraForm
  {
    private bellEntities db = new bellEntities();
    private Resimleme res = new Resimleme();
    private bool resimsec = false;
    private string resimyolu;
    private int kartId = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarEditItem barEditItem2;
    private BarEditItem barEditItem3;
    private BarEditItem barEditItem1;
    private BarButtonItem birimlereBtn;
    private BarButtonItem anaGrubaBtn;
    private BarButtonItem listeBtn;
    private BarEditItem arama;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private GridControl gridControl1;
    private GridView gridView1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup3;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private DataLayoutControl dataLayoutControl1;
    private LayoutControlGroup Root;
    private TextEdit kartNoTextEdit;
    private DateEdit dateEdit1;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private TextEdit soforAdiTextEdit;
    private TextEdit surucuBelgeTextEdit;
    private TextEdit tcTextEdit;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private TextEdit mudurlıkTextEdit;
    private TextEdit aciklamaTextEdit;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem d3;
    private TextEdit telefonTextEdit;
    private TextEdit birimiTextEdit;
    private LayoutControlItem d2;
    private LayoutControlItem d1;
    private TextEdit sicilTextEdit;
    private LayoutControlItem d4;
    private TextEdit teslimAlanUnvanTextEdit;
    private TextEdit teslimEdenUnvanTextEdit;
    private TextEdit teslimAlanAdTextEdit;
    private TextEdit teslimEdenAdıTextEdit;
    private DataLayoutControl dataLayoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LabelControl labelControl2;
    private LabelControl labelControl1;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private TextEdit siraNoTextEdit;
    private LayoutControlItem layoutControlItem15;
    private BarButtonItem barButtonItem4;
    private RibbonPageGroup ribbonPageGroup2;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
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
    private PictureEdit kimlifFotoButton;
    private LayoutControlItem layoutControlItem7;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem farklıKaydetToolStripMenuItem;
    private GridColumn gridColumn18;
    private BarButtonItem barButtonItem10;

    public YakitKarti() => this.InitializeComponent();

    private void YakitKarti_Load(object sender, EventArgs e)
    {
      this.teslimEdenUnvanTextEdit.Text = "Otomasyon PER.";
      this.Yenile();
    }

    public void Yenile() => this.gridControl1.DataSource = (object) this.db.TBLYAKITKARTI.Select<TBLYAKITKARTI, TBLYAKITKARTI>((Expression<Func<TBLYAKITKARTI, TBLYAKITKARTI>>) (hd => hd)).ToList<TBLYAKITKARTI>();

    private void Kaydet()
    {
      try
      {
        TBLYAKITKARTI entity = new TBLYAKITKARTI();
        if (this.kartNoTextEdit.Text != "")
        {
          entity.KARTNO = new int?(Convert.ToInt32(this.kartNoTextEdit.Text));
          entity.TARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.DateTime));
          entity.TCNO = this.tcTextEdit.Text;
          entity.SOFORADISOYADI = this.soforAdiTextEdit.Text;
          entity.SURUCUBELGE = this.surucuBelgeTextEdit.Text;
          entity.ACIKLAMA = this.aciklamaTextEdit.Text;
          entity.CALISTIGIMUDURLUK = this.mudurlıkTextEdit.Text;
          entity.CALISTIGIBIRIM = this.birimiTextEdit.Text;
          entity.TELEFON = this.telefonTextEdit.Text;
          entity.SICILNO = this.sicilTextEdit.Text;
          entity.TESLIMALAN = this.teslimAlanAdTextEdit.Text;
          entity.TESLIMALANUNVAN = this.teslimAlanUnvanTextEdit.Text;
          entity.TESLIMEDEN = this.teslimEdenAdıTextEdit.Text;
          entity.TESLIMEDENUNVAN = this.teslimEdenUnvanTextEdit.Text;
          entity.KIMLIKONYUZU = this.kimlifFotoButton.Image == null ? (byte[]) null : this.res.resimyukle(this.kimlifFotoButton.Image);
          this.db.TBLYAKITKARTI.Add(entity);
          this.db.SaveChanges();
          this.kartId = entity.ID;
          int num = (int) XtraMessageBox.Show("Kayıt Başarılı!");
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Kart Numarası Giriniz!");
        }
      }
      catch
      {
        int num = (int) XtraMessageBox.Show("Kart Kaydedilemedi1");
      }
    }

    private void Guncelle()
    {
      try
      {
        TBLYAKITKARTI tblyakitkarti = this.db.TBLYAKITKARTI.FirstOrDefault<TBLYAKITKARTI>((Expression<Func<TBLYAKITKARTI, bool>>) (x => x.ID == this.kartId));
        if (this.kartNoTextEdit.Text != "" || this.kartNoTextEdit.Text != null)
        {
          tblyakitkarti.KARTNO = new int?(Convert.ToInt32(this.kartNoTextEdit.Text));
          tblyakitkarti.TARIH = new DateTime?(Convert.ToDateTime(this.dateEdit1.DateTime));
          tblyakitkarti.TCNO = this.tcTextEdit.Text;
          tblyakitkarti.SOFORADISOYADI = this.soforAdiTextEdit.Text;
          tblyakitkarti.SURUCUBELGE = this.surucuBelgeTextEdit.Text;
          tblyakitkarti.ACIKLAMA = this.aciklamaTextEdit.Text;
          tblyakitkarti.CALISTIGIMUDURLUK = this.mudurlıkTextEdit.Text;
          tblyakitkarti.CALISTIGIBIRIM = this.birimiTextEdit.Text;
          tblyakitkarti.TELEFON = this.telefonTextEdit.Text;
          tblyakitkarti.SICILNO = this.sicilTextEdit.Text;
          tblyakitkarti.TESLIMALAN = this.teslimAlanAdTextEdit.Text;
          tblyakitkarti.TESLIMALANUNVAN = this.teslimAlanUnvanTextEdit.Text;
          tblyakitkarti.TESLIMEDEN = this.teslimEdenAdıTextEdit.Text;
          tblyakitkarti.TESLIMEDENUNVAN = this.teslimEdenUnvanTextEdit.Text;
          tblyakitkarti.KIMLIKONYUZU = this.kimlifFotoButton.Image == null ? (byte[]) null : this.res.resimyukle(this.kimlifFotoButton.Image);
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Güncelleme Başarılı!");
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Kart Numarası Giriniz!");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      YakıitKartiRapor yakıitKartiRapor = new YakıitKartiRapor();
      try
      {
        if (this.kartId != 0)
        {
          yakıitKartiRapor.Parameters["id"].Value = (object) this.kartId;
          yakıitKartiRapor.Parameters["id"].Visible = false;
          new ReportPrintTool((IReport) yakıitKartiRapor).ShowPreviewDialog();
        }
        else
        {
          int num = (int) XtraMessageBox.Show("Aradığınız kayıt bulunamadı veya bos belge");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e) => new YakitExcelVeriCekme().Show();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        if (this.db.TBLYAKITKARTI.FirstOrDefault<TBLYAKITKARTI>((Expression<Func<TBLYAKITKARTI, bool>>) (x => x.ID == this.kartId)) != null)
          this.Guncelle();
        else
          this.Kaydet();
        this.Yenile();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.Yenile();

    private void gridView1_Click(object sender, EventArgs e)
    {
      this.kartId = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.gridColumn18));
      TBLYAKITKARTI tblyakitkarti = this.db.TBLYAKITKARTI.FirstOrDefault<TBLYAKITKARTI>((Expression<Func<TBLYAKITKARTI, bool>>) (x => x.ID == this.kartId));
      this.kartNoTextEdit.Text = tblyakitkarti.KARTNO.ToString();
      this.dateEdit1.DateTime = Convert.ToDateTime((object) tblyakitkarti.TARIH);
      this.tcTextEdit.Text = tblyakitkarti.TCNO;
      this.soforAdiTextEdit.Text = tblyakitkarti.SOFORADISOYADI;
      this.surucuBelgeTextEdit.Text = tblyakitkarti.SURUCUBELGE;
      this.aciklamaTextEdit.Text = tblyakitkarti.ACIKLAMA;
      this.mudurlıkTextEdit.Text = tblyakitkarti.CALISTIGIMUDURLUK;
      this.birimiTextEdit.Text = tblyakitkarti.CALISTIGIBIRIM;
      this.telefonTextEdit.Text = tblyakitkarti.TELEFON;
      this.sicilTextEdit.Text = tblyakitkarti.SICILNO;
      this.teslimAlanAdTextEdit.Text = tblyakitkarti.TESLIMALAN;
      this.teslimAlanUnvanTextEdit.Text = tblyakitkarti.TESLIMALANUNVAN;
      this.teslimEdenAdıTextEdit.Text = tblyakitkarti.TESLIMEDEN;
      this.teslimEdenUnvanTextEdit.Text = tblyakitkarti.TESLIMEDENUNVAN;
      if (tblyakitkarti.KIMLIKONYUZU != null)
        this.kimlifFotoButton.Image = this.res.resimigetir(tblyakitkarti.KIMLIKONYUZU);
      else
        this.kimlifFotoButton.Image = (Image) null;
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
        int num = (int) openFileDialog.ShowDialog();
        this.resimyolu = openFileDialog.FileName;
        this.kimlifFotoButton.Image = Image.FromFile(openFileDialog.FileName);
        this.resimsec = true;
      }
      catch (Exception ex)
      {
      }
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e) => this.kimlifFotoButton.Image = (Image) null;

    private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
      saveFileDialog.Title = "Kayıt";
      saveFileDialog.FileName = "resim-" + this.kartNoTextEdit.Text;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.kimlifFotoButton.Image.Save(saveFileDialog.FileName);
    }

    private void Yeni()
    {
      this.kartId = 0;
      this.kartNoTextEdit.Text = "";
      this.dateEdit1.Text = "";
      this.tcTextEdit.Text = "";
      this.soforAdiTextEdit.Text = "";
      this.surucuBelgeTextEdit.Text = "";
      this.aciklamaTextEdit.Text = "";
      this.mudurlıkTextEdit.Text = "";
      this.birimiTextEdit.Text = "";
      this.telefonTextEdit.Text = "";
      this.sicilTextEdit.Text = "";
      this.teslimAlanAdTextEdit.Text = "";
      this.teslimAlanUnvanTextEdit.Text = "";
      this.teslimEdenAdıTextEdit.Text = "";
      this.teslimEdenUnvanTextEdit.Text = "Otomasyon PER.";
      this.kimlifFotoButton.Image = (Image) null;
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) => this.Yeni();

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
        args.Text = "Kayıt Silinecektir!!!";
        args.Caption = "Silme Uyarısı";
        args.Buttons = new DialogResult[2]
        {
          DialogResult.OK,
          DialogResult.No
        };
        switch (XtraMessageBox.Show(args))
        {
          case DialogResult.OK:
            if (this.kartId != 0)
            {
              this.db.TBLYAKITKARTI.Remove(this.db.TBLYAKITKARTI.FirstOrDefault<TBLYAKITKARTI>((Expression<Func<TBLYAKITKARTI, bool>>) (x => x.ID == this.kartId)));
              this.db.SaveChanges();
              this.Yeni();
              this.Yenile();
              int num = (int) XtraMessageBox.Show("Kayıt Silindi!");
              break;
            }
            int num1 = (int) XtraMessageBox.Show("Kart Yok!");
            break;
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show("Kayıt Silinemez");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Makina_Ikmal.Otomasyon.YakitKarti.YakitKarti));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem3 = new BarEditItem();
      this.barEditItem1 = new BarEditItem();
      this.birimlereBtn = new BarButtonItem();
      this.anaGrubaBtn = new BarButtonItem();
      this.listeBtn = new BarButtonItem();
      this.arama = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.gridColumn18 = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn15 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn16 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.gridColumn17 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.gridColumn11 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.gridColumn10 = new GridColumn();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.dataLayoutControl1 = new DataLayoutControl();
      this.kimlifFotoButton = new PictureEdit();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripMenuItem();
      this.farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
      this.siraNoTextEdit = new TextEdit();
      this.teslimAlanUnvanTextEdit = new TextEdit();
      this.teslimEdenUnvanTextEdit = new TextEdit();
      this.teslimAlanAdTextEdit = new TextEdit();
      this.teslimEdenAdıTextEdit = new TextEdit();
      this.dataLayoutControl2 = new DataLayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.labelControl2 = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.sicilTextEdit = new TextEdit();
      this.telefonTextEdit = new TextEdit();
      this.birimiTextEdit = new TextEdit();
      this.mudurlıkTextEdit = new TextEdit();
      this.aciklamaTextEdit = new TextEdit();
      this.soforAdiTextEdit = new TextEdit();
      this.surucuBelgeTextEdit = new TextEdit();
      this.tcTextEdit = new TextEdit();
      this.kartNoTextEdit = new TextEdit();
      this.dateEdit1 = new DateEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.d2 = new LayoutControlItem();
      this.d1 = new LayoutControlItem();
      this.d4 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.d3 = new LayoutControlItem();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.dataLayoutControl1.BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      this.kimlifFotoButton.Properties.BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.siraNoTextEdit.Properties.BeginInit();
      this.teslimAlanUnvanTextEdit.Properties.BeginInit();
      this.teslimEdenUnvanTextEdit.Properties.BeginInit();
      this.teslimAlanAdTextEdit.Properties.BeginInit();
      this.teslimEdenAdıTextEdit.Properties.BeginInit();
      this.dataLayoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.sicilTextEdit.Properties.BeginInit();
      this.telefonTextEdit.Properties.BeginInit();
      this.birimiTextEdit.Properties.BeginInit();
      this.mudurlıkTextEdit.Properties.BeginInit();
      this.aciklamaTextEdit.Properties.BeginInit();
      this.soforAdiTextEdit.Properties.BeginInit();
      this.surucuBelgeTextEdit.Properties.BeginInit();
      this.tcTextEdit.Properties.BeginInit();
      this.kartNoTextEdit.Properties.BeginInit();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.d2.BeginInit();
      this.d1.BeginInit();
      this.d4.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.d3.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[19]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem1,
        (BarItem) this.birimlereBtn,
        (BarItem) this.anaGrubaBtn,
        (BarItem) this.listeBtn,
        (BarItem) this.arama,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem10
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 28;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
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
      this.ribbonControl1.Size = new Size(1267, 96);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
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
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 12;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Caption = "Excel";
      this.barButtonItem9.Id = 13;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 15;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem3.Edit = (RepositoryItem) null;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 17;
      this.barEditItem3.Name = "barEditItem3";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 18;
      this.barEditItem1.Name = "barEditItem1";
      this.birimlereBtn.Caption = "Birimlere Göre Yazdır";
      this.birimlereBtn.Id = 19;
      this.birimlereBtn.Name = "birimlereBtn";
      this.anaGrubaBtn.Caption = "Ana Gruba Göre Yazdır";
      this.anaGrubaBtn.Id = 20;
      this.anaGrubaBtn.Name = "anaGrubaBtn";
      this.anaGrubaBtn.VisibleInSearchMenu = false;
      this.listeBtn.Caption = "Listeyi Yazdır";
      this.listeBtn.Id = 21;
      this.listeBtn.Name = "listeBtn";
      this.listeBtn.VisibleInSearchMenu = false;
      this.arama.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.arama.EditHeight = 25;
      this.arama.EditWidth = 140;
      this.arama.Id = 22;
      this.arama.Name = "arama";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl1.Location = new Point(0, 397);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1267, 360);
      this.gridControl1.TabIndex = 3;
      this.gridControl1.UseEmbeddedNavigator = true;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.gridColumn18,
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn15,
        this.gridColumn3,
        this.gridColumn16,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn17,
        this.gridColumn7,
        this.gridColumn11,
        this.gridColumn8,
        this.gridColumn12,
        this.gridColumn13,
        this.gridColumn14,
        this.gridColumn9,
        this.gridColumn10
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn1, ColumnSortOrder.Descending)
      });
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.gridColumn18.Caption = "ID";
      this.gridColumn18.FieldName = "ID";
      this.gridColumn18.Name = "gridColumn18";
      this.gridColumn1.Caption = "Kart No";
      this.gridColumn1.FieldName = "KARTNO";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.AllowFocus = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 60;
      this.gridColumn2.Caption = "T.C. No";
      this.gridColumn2.FieldName = "TCNO";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.AllowFocus = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      this.gridColumn15.Caption = "Sicil No";
      this.gridColumn15.FieldName = "SICILNO";
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.OptionsColumn.AllowEdit = false;
      this.gridColumn15.OptionsColumn.AllowFocus = false;
      this.gridColumn15.OptionsColumn.ReadOnly = true;
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 2;
      this.gridColumn3.Caption = "Şöför Adı Soyadı";
      this.gridColumn3.FieldName = "SOFORADISOYADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.AllowEdit = false;
      this.gridColumn3.OptionsColumn.AllowFocus = false;
      this.gridColumn3.OptionsColumn.ReadOnly = true;
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 3;
      this.gridColumn16.Caption = "Sürücü Belge";
      this.gridColumn16.FieldName = "SURUCUBELGE";
      this.gridColumn16.Name = "gridColumn16";
      this.gridColumn16.OptionsColumn.AllowEdit = false;
      this.gridColumn16.OptionsColumn.AllowFocus = false;
      this.gridColumn16.OptionsColumn.ReadOnly = true;
      this.gridColumn16.Visible = true;
      this.gridColumn16.VisibleIndex = 4;
      this.gridColumn4.Caption = "Çalıştığı Birim";
      this.gridColumn4.FieldName = "CALISTIGIBIRIM";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.AllowEdit = false;
      this.gridColumn4.OptionsColumn.AllowFocus = false;
      this.gridColumn4.OptionsColumn.ReadOnly = true;
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 5;
      this.gridColumn5.Caption = "Çalıştığı Müdürlük";
      this.gridColumn5.FieldName = "CALISTIGIMUDURLUK";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.OptionsColumn.AllowEdit = false;
      this.gridColumn5.OptionsColumn.AllowFocus = false;
      this.gridColumn5.OptionsColumn.ReadOnly = true;
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 6;
      this.gridColumn6.Caption = "Kimlik Ön Yüz";
      this.gridColumn6.FieldName = "KIMLIKONYUZU";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.OptionsColumn.AllowEdit = false;
      this.gridColumn6.OptionsColumn.AllowFocus = false;
      this.gridColumn6.OptionsColumn.ReadOnly = true;
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 7;
      this.gridColumn17.Caption = "Tarih";
      this.gridColumn17.FieldName = "TARIH";
      this.gridColumn17.Name = "gridColumn17";
      this.gridColumn17.OptionsColumn.AllowEdit = false;
      this.gridColumn17.OptionsColumn.AllowFocus = false;
      this.gridColumn17.OptionsColumn.ReadOnly = true;
      this.gridColumn17.Visible = true;
      this.gridColumn17.VisibleIndex = 8;
      this.gridColumn7.Caption = "Yuklenici Firma";
      this.gridColumn7.FieldName = "YUKLEYICIFIRMMA";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.OptionsColumn.AllowEdit = false;
      this.gridColumn7.OptionsColumn.AllowFocus = false;
      this.gridColumn7.OptionsColumn.ReadOnly = true;
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 9;
      this.gridColumn11.Caption = "Adres";
      this.gridColumn11.FieldName = "ADRES";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.OptionsColumn.AllowEdit = false;
      this.gridColumn11.OptionsColumn.AllowFocus = false;
      this.gridColumn11.OptionsColumn.ReadOnly = true;
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 10;
      this.gridColumn8.Caption = "Telefon";
      this.gridColumn8.FieldName = "TELEFON";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.OptionsColumn.AllowEdit = false;
      this.gridColumn8.OptionsColumn.AllowFocus = false;
      this.gridColumn8.OptionsColumn.ReadOnly = true;
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 11;
      this.gridColumn12.Caption = "Açıklama";
      this.gridColumn12.FieldName = "ACIKLAMA";
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.OptionsColumn.AllowEdit = false;
      this.gridColumn12.OptionsColumn.AllowFocus = false;
      this.gridColumn12.OptionsColumn.ReadOnly = true;
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 12;
      this.gridColumn13.Caption = "Teslim Eden";
      this.gridColumn13.FieldName = "TESLIMEDEN";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.OptionsColumn.AllowEdit = false;
      this.gridColumn13.OptionsColumn.AllowFocus = false;
      this.gridColumn13.OptionsColumn.ReadOnly = true;
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 13;
      this.gridColumn14.Caption = "Teslim Eden Ünvan";
      this.gridColumn14.FieldName = "TESLIMEDENUNVAN";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.OptionsColumn.AllowEdit = false;
      this.gridColumn14.OptionsColumn.AllowFocus = false;
      this.gridColumn14.OptionsColumn.ReadOnly = true;
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 14;
      this.gridColumn9.Caption = "Teslim Alan";
      this.gridColumn9.FieldName = "TESLIMALAN";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.OptionsColumn.AllowEdit = false;
      this.gridColumn9.OptionsColumn.AllowFocus = false;
      this.gridColumn9.OptionsColumn.ReadOnly = true;
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 15;
      this.gridColumn10.Caption = "Teslim Alan Unvan";
      this.gridColumn10.FieldName = "TESLIMALANUNVAN";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.OptionsColumn.AllowEdit = false;
      this.gridColumn10.OptionsColumn.AllowFocus = false;
      this.gridColumn10.OptionsColumn.ReadOnly = true;
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 16;
      this.barButtonItem1.Caption = "Yeni";
      this.barButtonItem1.Id = 23;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Kaydet";
      this.barButtonItem2.Id = 24;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Yazdır";
      this.barButtonItem3.Id = 25;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Yakıt Kartları Çek";
      this.barButtonItem4.Id = 26;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem10.Caption = "Sil";
      this.barButtonItem10.Id = 27;
      this.barButtonItem10.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.Image");
      this.barButtonItem10.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.LargeImage");
      this.barButtonItem10.LargeWidth = 100;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup2
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.arama);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem10);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem9);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.dataLayoutControl1.Controls.Add((Control) this.kimlifFotoButton);
      this.dataLayoutControl1.Controls.Add((Control) this.siraNoTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.teslimAlanUnvanTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.teslimEdenUnvanTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.teslimAlanAdTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.teslimEdenAdıTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.dataLayoutControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.labelControl2);
      this.dataLayoutControl1.Controls.Add((Control) this.labelControl1);
      this.dataLayoutControl1.Controls.Add((Control) this.sicilTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.telefonTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.birimiTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.mudurlıkTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.aciklamaTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.soforAdiTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.surucuBelgeTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.tcTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.kartNoTextEdit);
      this.dataLayoutControl1.Controls.Add((Control) this.dateEdit1);
      this.dataLayoutControl1.Dock = DockStyle.Top;
      this.dataLayoutControl1.Location = new Point(0, 96);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 149, 650, 400));
      this.dataLayoutControl1.Root = this.Root;
      this.dataLayoutControl1.Size = new Size(1267, 301);
      this.dataLayoutControl1.TabIndex = 2;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      this.kimlifFotoButton.Location = new Point(851, 12);
      this.kimlifFotoButton.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kimlifFotoButton.Name = "kimlifFotoButton";
      this.kimlifFotoButton.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.kimlifFotoButton.Properties.Appearance.Options.UseFont = true;
      this.kimlifFotoButton.Properties.ContextMenuStrip = this.contextMenuStrip1;
      this.kimlifFotoButton.Properties.NullText = "Kimlik Ön Yüzü";
      this.kimlifFotoButton.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.kimlifFotoButton.Properties.SizeMode = PictureSizeMode.Stretch;
      this.kimlifFotoButton.Size = new Size(404, 277);
      this.kimlifFotoButton.StyleController = (IStyleController) this.dataLayoutControl1;
      this.kimlifFotoButton.TabIndex = 23;
      this.contextMenuStrip1.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.farklıKaydetToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(205, 82);
      this.contextMenuStrip1.Text = "Sil";
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(204, 26);
      this.toolStripMenuItem1.Text = "Sil";
      this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(204, 26);
      this.toolStripMenuItem2.Text = "Dosyadan Yükle ...";
      this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
      this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
      this.farklıKaydetToolStripMenuItem.Size = new Size(204, 26);
      this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
      this.farklıKaydetToolStripMenuItem.Click += new EventHandler(this.farklıKaydetToolStripMenuItem_Click);
      this.siraNoTextEdit.Location = new Point(12, 264);
      this.siraNoTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.siraNoTextEdit.Name = "siraNoTextEdit";
      this.siraNoTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.siraNoTextEdit.Properties.Appearance.Options.UseFont = true;
      this.siraNoTextEdit.Size = new Size(175, 22);
      this.siraNoTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.siraNoTextEdit.TabIndex = 22;
      this.teslimAlanUnvanTextEdit.Location = new Point(600, 262);
      this.teslimAlanUnvanTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimAlanUnvanTextEdit.Name = "teslimAlanUnvanTextEdit";
      this.teslimAlanUnvanTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimAlanUnvanTextEdit.Properties.Appearance.Options.UseFont = true;
      this.teslimAlanUnvanTextEdit.Size = new Size(247, 22);
      this.teslimAlanUnvanTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.teslimAlanUnvanTextEdit.TabIndex = 21;
      this.teslimEdenUnvanTextEdit.Location = new Point(284, 262);
      this.teslimEdenUnvanTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimEdenUnvanTextEdit.Name = "teslimEdenUnvanTextEdit";
      this.teslimEdenUnvanTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimEdenUnvanTextEdit.Properties.Appearance.Options.UseFont = true;
      this.teslimEdenUnvanTextEdit.Size = new Size(219, 22);
      this.teslimEdenUnvanTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.teslimEdenUnvanTextEdit.TabIndex = 20;
      this.teslimAlanAdTextEdit.Location = new Point(602, 234);
      this.teslimAlanAdTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimAlanAdTextEdit.Name = "teslimAlanAdTextEdit";
      this.teslimAlanAdTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimAlanAdTextEdit.Properties.Appearance.Options.UseFont = true;
      this.teslimAlanAdTextEdit.Size = new Size(245, 22);
      this.teslimAlanAdTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.teslimAlanAdTextEdit.TabIndex = 19;
      this.teslimEdenAdıTextEdit.Location = new Point(286, 234);
      this.teslimEdenAdıTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teslimEdenAdıTextEdit.Name = "teslimEdenAdıTextEdit";
      this.teslimEdenAdıTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teslimEdenAdıTextEdit.Properties.Appearance.Options.UseFont = true;
      this.teslimEdenAdıTextEdit.Size = new Size(217, 22);
      this.teslimEdenAdıTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.teslimEdenAdıTextEdit.TabIndex = 18;
      this.dataLayoutControl2.Location = new Point(12, 152);
      this.dataLayoutControl2.Name = "dataLayoutControl2";
      this.dataLayoutControl2.Root = this.layoutControlGroup1;
      this.dataLayoutControl2.Size = new Size(175, 78);
      this.dataLayoutControl2.TabIndex = 17;
      this.dataLayoutControl2.Text = "dataLayoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(175, 78);
      this.layoutControlGroup1.TextVisible = false;
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.ForeColor = Color.Black;
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Appearance.Options.UseForeColor = true;
      this.labelControl2.Appearance.Options.UseTextOptions = true;
      this.labelControl2.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.labelControl2.Location = new Point(507, 152);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(340, 78);
      this.labelControl2.StyleController = (IStyleController) this.dataLayoutControl1;
      this.labelControl2.TabIndex = 16;
      this.labelControl2.Text = "Teslim Alan";
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.ForeColor = Color.Black;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.Appearance.Options.UseTextOptions = true;
      this.labelControl1.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.labelControl1.Location = new Point(191, 152);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(312, 78);
      this.labelControl1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.labelControl1.TabIndex = 15;
      this.labelControl1.Text = "Teslim Eden";
      this.sicilTextEdit.Location = new Point(513, 124);
      this.sicilTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sicilTextEdit.Name = "sicilTextEdit";
      this.sicilTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sicilTextEdit.Properties.Appearance.Options.UseFont = true;
      this.sicilTextEdit.Size = new Size(334, 22);
      this.sicilTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.sicilTextEdit.TabIndex = 13;
      this.telefonTextEdit.Location = new Point(513, 96);
      this.telefonTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.telefonTextEdit.Name = "telefonTextEdit";
      this.telefonTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.telefonTextEdit.Properties.Appearance.Options.UseFont = true;
      this.telefonTextEdit.Size = new Size(334, 22);
      this.telefonTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.telefonTextEdit.TabIndex = 12;
      this.birimiTextEdit.Location = new Point(513, 40);
      this.birimiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimiTextEdit.Name = "birimiTextEdit";
      this.birimiTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimiTextEdit.Properties.Appearance.Options.UseFont = true;
      this.birimiTextEdit.Size = new Size(334, 22);
      this.birimiTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.birimiTextEdit.TabIndex = 11;
      this.mudurlıkTextEdit.Location = new Point(513, 68);
      this.mudurlıkTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurlıkTextEdit.Name = "mudurlıkTextEdit";
      this.mudurlıkTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mudurlıkTextEdit.Properties.Appearance.Options.UseFont = true;
      this.mudurlıkTextEdit.Size = new Size(334, 22);
      this.mudurlıkTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.mudurlıkTextEdit.TabIndex = 10;
      this.aciklamaTextEdit.Location = new Point(513, 12);
      this.aciklamaTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aciklamaTextEdit.Name = "aciklamaTextEdit";
      this.aciklamaTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aciklamaTextEdit.Properties.Appearance.Options.UseFont = true;
      this.aciklamaTextEdit.Size = new Size(334, 22);
      this.aciklamaTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.aciklamaTextEdit.TabIndex = 9;
      this.soforAdiTextEdit.Location = new Point(175, 96);
      this.soforAdiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.soforAdiTextEdit.Name = "soforAdiTextEdit";
      this.soforAdiTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.soforAdiTextEdit.Properties.Appearance.Options.UseFont = true;
      this.soforAdiTextEdit.Size = new Size(171, 22);
      this.soforAdiTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.soforAdiTextEdit.TabIndex = 8;
      this.surucuBelgeTextEdit.Location = new Point(175, 124);
      this.surucuBelgeTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.surucuBelgeTextEdit.Name = "surucuBelgeTextEdit";
      this.surucuBelgeTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.surucuBelgeTextEdit.Properties.Appearance.Options.UseFont = true;
      this.surucuBelgeTextEdit.Size = new Size(171, 22);
      this.surucuBelgeTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.surucuBelgeTextEdit.TabIndex = 7;
      this.tcTextEdit.Location = new Point(175, 68);
      this.tcTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tcTextEdit.Name = "tcTextEdit";
      this.tcTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tcTextEdit.Properties.Appearance.Options.UseFont = true;
      this.tcTextEdit.Size = new Size(171, 22);
      this.tcTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.tcTextEdit.TabIndex = 6;
      this.kartNoTextEdit.Location = new Point(175, 40);
      this.kartNoTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kartNoTextEdit.Name = "kartNoTextEdit";
      this.kartNoTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kartNoTextEdit.Properties.Appearance.Options.UseFont = true;
      this.kartNoTextEdit.Properties.Mask.EditMask = "d";
      this.kartNoTextEdit.Properties.Mask.MaskType = MaskType.Numeric;
      this.kartNoTextEdit.Size = new Size(171, 22);
      this.kartNoTextEdit.StyleController = (IStyleController) this.dataLayoutControl1;
      this.kartNoTextEdit.TabIndex = 5;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(175, 12);
      this.dateEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateEdit1.Properties.Appearance.Options.UseFont = true;
      this.dateEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Size = new Size(171, 22);
      this.dateEdit1.StyleController = (IStyleController) this.dataLayoutControl1;
      this.dateEdit1.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[19]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.d2,
        (BaseLayoutItem) this.d1,
        (BaseLayoutItem) this.d4,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.d3
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1267, 301);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem1.Control = (Control) this.dateEdit1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(338, 28);
      this.layoutControlItem1.Text = "Tarih";
      this.layoutControlItem1.TextSize = new Size(160, 24);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem2.Control = (Control) this.kartNoTextEdit;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(338, 28);
      this.layoutControlItem2.Text = "Kart No";
      this.layoutControlItem2.TextSize = new Size(160, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem3.Control = (Control) this.tcTextEdit;
      this.layoutControlItem3.Location = new Point(0, 56);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(338, 28);
      this.layoutControlItem3.Text = "TC Kimlik No";
      this.layoutControlItem3.TextSize = new Size(160, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem4.Control = (Control) this.surucuBelgeTextEdit;
      this.layoutControlItem4.Location = new Point(0, 112);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(338, 28);
      this.layoutControlItem4.Text = "Sürücü Belgesi";
      this.layoutControlItem4.TextSize = new Size(160, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem5.Control = (Control) this.soforAdiTextEdit;
      this.layoutControlItem5.Location = new Point(0, 84);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(338, 28);
      this.layoutControlItem5.Text = "Şöför Adı Soyadı";
      this.layoutControlItem5.TextSize = new Size(160, 24);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.layoutControlItem6.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem6.Control = (Control) this.aciklamaTextEdit;
      this.layoutControlItem6.Location = new Point(338, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(501, 28);
      this.layoutControlItem6.Text = "Evrak Tarih ve Sayi";
      this.layoutControlItem6.TextSize = new Size(160, 24);
      this.d2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.d2.AppearanceItemCaption.ForeColor = Color.Black;
      this.d2.AppearanceItemCaption.Options.UseFont = true;
      this.d2.AppearanceItemCaption.Options.UseForeColor = true;
      this.d2.Control = (Control) this.birimiTextEdit;
      this.d2.Location = new Point(338, 28);
      this.d2.Name = "d2";
      this.d2.Size = new Size(501, 28);
      this.d2.Text = "Birimi";
      this.d2.TextSize = new Size(160, 24);
      this.d1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.d1.AppearanceItemCaption.ForeColor = Color.Black;
      this.d1.AppearanceItemCaption.Options.UseFont = true;
      this.d1.AppearanceItemCaption.Options.UseForeColor = true;
      this.d1.Control = (Control) this.telefonTextEdit;
      this.d1.Location = new Point(338, 84);
      this.d1.Name = "d1";
      this.d1.Size = new Size(501, 28);
      this.d1.Text = "Telefon";
      this.d1.TextSize = new Size(160, 24);
      this.d4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.d4.AppearanceItemCaption.ForeColor = Color.Black;
      this.d4.AppearanceItemCaption.Options.UseFont = true;
      this.d4.AppearanceItemCaption.Options.UseForeColor = true;
      this.d4.Control = (Control) this.sicilTextEdit;
      this.d4.Location = new Point(338, 112);
      this.d4.Name = "d4";
      this.d4.Size = new Size(501, 28);
      this.d4.Text = "Sicil No";
      this.d4.TextSize = new Size(160, 24);
      this.layoutControlItem8.Control = (Control) this.labelControl1;
      this.layoutControlItem8.Location = new Point(179, 140);
      this.layoutControlItem8.MinSize = new Size(67, 17);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(316, 82);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.dataLayoutControl2;
      this.layoutControlItem10.Location = new Point(0, 140);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(179, 82);
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.labelControl2;
      this.layoutControlItem9.Location = new Point(495, 140);
      this.layoutControlItem9.MinSize = new Size(67, 17);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(344, 82);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.layoutControlItem11.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem11.Control = (Control) this.teslimEdenAdıTextEdit;
      this.layoutControlItem11.Location = new Point(179, 222);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(316, 28);
      this.layoutControlItem11.Text = "Adı Soyadı";
      this.layoutControlItem11.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem11.TextSize = new Size(90, 24);
      this.layoutControlItem11.TextToControlDistance = 5;
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.layoutControlItem12.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem12.Control = (Control) this.teslimAlanAdTextEdit;
      this.layoutControlItem12.Location = new Point(495, 222);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(344, 28);
      this.layoutControlItem12.Text = "Adı Soyadı";
      this.layoutControlItem12.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem12.TextSize = new Size(90, 24);
      this.layoutControlItem12.TextToControlDistance = 5;
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.layoutControlItem13.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem13.Control = (Control) this.teslimEdenUnvanTextEdit;
      this.layoutControlItem13.Location = new Point(179, 250);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(316, 31);
      this.layoutControlItem13.Text = "Ünvanı      ";
      this.layoutControlItem13.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem13.TextSize = new Size(88, 24);
      this.layoutControlItem13.TextToControlDistance = 5;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.layoutControlItem14.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem14.Control = (Control) this.teslimAlanUnvanTextEdit;
      this.layoutControlItem14.Location = new Point(495, 250);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(344, 31);
      this.layoutControlItem14.Text = "Ünvanı      ";
      this.layoutControlItem14.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem14.TextSize = new Size(88, 24);
      this.layoutControlItem14.TextToControlDistance = 5;
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem15.Control = (Control) this.siraNoTextEdit;
      this.layoutControlItem15.Location = new Point(0, 222);
      this.layoutControlItem15.MinSize = new Size(54, 59);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(179, 59);
      this.layoutControlItem15.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem15.Text = "SıraNo";
      this.layoutControlItem15.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem15.TextLocation = Locations.Top;
      this.layoutControlItem15.TextSize = new Size(50, 20);
      this.layoutControlItem15.TextToControlDistance = 10;
      this.layoutControlItem7.Control = (Control) this.kimlifFotoButton;
      this.layoutControlItem7.Location = new Point(839, 0);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(408, 281);
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.d3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.d3.AppearanceItemCaption.ForeColor = Color.Black;
      this.d3.AppearanceItemCaption.Options.UseFont = true;
      this.d3.AppearanceItemCaption.Options.UseForeColor = true;
      this.d3.Control = (Control) this.mudurlıkTextEdit;
      this.d3.Location = new Point(338, 56);
      this.d3.Name = "d3";
      this.d3.Size = new Size(501, 28);
      this.d3.Text = "Müdürlüğü";
      this.d3.TextSize = new Size(160, 24);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1267, 757);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.dataLayoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (YakitKarti);
      this.Text = nameof (YakitKarti);
      this.Load += new EventHandler(this.YakitKarti_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.dataLayoutControl1.EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      this.kimlifFotoButton.Properties.EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.siraNoTextEdit.Properties.EndInit();
      this.teslimAlanUnvanTextEdit.Properties.EndInit();
      this.teslimEdenUnvanTextEdit.Properties.EndInit();
      this.teslimAlanAdTextEdit.Properties.EndInit();
      this.teslimEdenAdıTextEdit.Properties.EndInit();
      this.dataLayoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.sicilTextEdit.Properties.EndInit();
      this.telefonTextEdit.Properties.EndInit();
      this.birimiTextEdit.Properties.EndInit();
      this.mudurlıkTextEdit.Properties.EndInit();
      this.aciklamaTextEdit.Properties.EndInit();
      this.soforAdiTextEdit.Properties.EndInit();
      this.surucuBelgeTextEdit.Properties.EndInit();
      this.tcTextEdit.Properties.EndInit();
      this.kartNoTextEdit.Properties.EndInit();
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.d2.EndInit();
      this.d1.EndInit();
      this.d4.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem7.EndInit();
      this.d3.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
