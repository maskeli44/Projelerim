// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Akaryakit.AracYakitKontrolKayit
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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Akaryakit
{
  public class AracYakitKontrolKayit : XtraForm
  {
    private CikisZamaniReport cikisZamaniReport = new CikisZamaniReport();
    private GirisZamaniReport girisZamaniReport = new GirisZamaniReport();
    private bellEntities db = new bellEntities();
    public int duzen = 0;
    private int guncelID = 0;
    private KullaniciSonId son = new KullaniciSonId();
    private string yeniTasitKod;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem kaydetButton;
    private BarButtonItem silButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem1;
    private BarButtonItem yeniButton;
    private BarEditItem barEditItem2;
    private BarButtonItem girisYazdirButton;
    private BarButtonItem cikisYazdirButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private SearchLookUpEdit otomasyonGorevlisiSluEdit;
    private GridView searchLookUpEdit5View;
    private SearchLookUpEdit birimPersSluEdit;
    private GridView searchLookUpEdit4View;
    private SearchLookUpEdit istasyonGorevlisiSluEdit;
    private GridView searchLookUpEdit3View;
    private TextEdit soforTxt;
    private SearchLookUpEdit mudurlukAdiSluEdit;
    private GridView searchLookUpEdit2View;
    private SearchLookUpEdit birimAdiSluEdit;
    private GridView searchLookUpEdit1View;
    private TextEdit ebysTxt;
    private DateEdit cikisDateEdit;
    private DateEdit girisDateEdit;
    private DateEdit ebysDateEdit;
    private TextEdit plakaTxt;
    private TextEdit kodTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutConrolItem6;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem12;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn otomasyonPers;
    private GridColumn birimPers;
    private GridColumn istasyonPers;
    private GridColumn mudurlukAd;
    private GridColumn birimaAdiSoyadi;

    public AracYakitKontrolKayit() => this.InitializeComponent();

    private void yeniButton_ItemClick(object sender, ItemClickEventArgs e) => this.AracYakitKontrolKayit_Load(sender, (EventArgs) e);

    private void AracYakitKontrolKayit_Load(object sender, EventArgs e)
    {
      this.yeniTasitKod = this.son.AkaryakitSonKod();
      this.kodTxt.Text = this.son.AkaryakitSonKod();
      this.kodTxt.Enabled = false;
      this.girisDateEdit.DateTime = DateTime.Now;
      this.cikisZamaniReport.PaperKind = PaperKind.A5Rotated;
      this.girisZamaniReport.PaperKind = PaperKind.A5Rotated;
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet2.TBLBELDMUDURLUK);
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet2.TBLBELDBIRIMLER);
      this.plakaTxt.Text = "";
      this.ebysDateEdit.Text = "";
      this.ebysTxt.Text = "";
      this.cikisDateEdit.Text = "";
      this.birimAdiSluEdit.EditValue = (object) "";
      this.mudurlukAdiSluEdit.EditValue = (object) "";
      this.soforTxt.Text = "";
      this.istasyonGorevlisiSluEdit.EditValue = (object) "";
      this.birimPersSluEdit.EditValue = (object) "";
      this.otomasyonGorevlisiSluEdit.EditValue = (object) "";
    }

    private void kaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.duzen == 1)
      {
        if (this.BoslukControl())
        {
          try
          {
            this.db.TBLYAKITKONTFORM.Add(new TBLYAKITKONTFORM()
            {
              KOD = this.kodTxt.Text,
              PLAKA = this.plakaTxt.Text,
              EBYSTARIH = new DateTime?(Convert.ToDateTime(this.ebysDateEdit.DateTime)),
              EBYSSAYI = this.ebysTxt.Text,
              GIRISZAMAN = new DateTime?(Convert.ToDateTime(this.girisDateEdit.DateTime)),
              BIRIMID = new int?(Convert.ToInt32(this.birimAdiSluEdit.EditValue)),
              MUDURLUKID = new int?(Convert.ToInt32(this.mudurlukAdiSluEdit.EditValue)),
              SOFOROPERATOR = this.soforTxt.Text,
              ISTASYONPERSID = new int?(Convert.ToInt32(this.istasyonGorevlisiSluEdit.EditValue)),
              ILGILIBIRIMPERSID = new int?(Convert.ToInt32(this.birimPersSluEdit.EditValue)),
              OTOMASYONPERSID = new int?(Convert.ToInt32(this.otomasyonGorevlisiSluEdit.EditValue))
            });
            this.db.SaveChanges();
            int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
            LogEkle.Logs("Ekleme Yapti");
            this.Close();
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
      if (this.duzen != 2)
        return;
      if (this.BoslukControl() && this.guncelID != 0)
      {
        try
        {
          TBLYAKITKONTFORM tblyakitkontform = this.db.TBLYAKITKONTFORM.FirstOrDefault<TBLYAKITKONTFORM>((Expression<System.Func<TBLYAKITKONTFORM, bool>>) (x => x.ID == this.guncelID));
          tblyakitkontform.KOD = this.kodTxt.Text;
          tblyakitkontform.PLAKA = this.plakaTxt.Text;
          tblyakitkontform.EBYSTARIH = new DateTime?(Convert.ToDateTime(this.ebysDateEdit.DateTime));
          tblyakitkontform.EBYSSAYI = this.ebysTxt.Text;
          tblyakitkontform.GIRISZAMAN = new DateTime?(Convert.ToDateTime(this.girisDateEdit.DateTime));
          tblyakitkontform.BIRIMID = new int?(Convert.ToInt32(this.birimAdiSluEdit.EditValue));
          tblyakitkontform.MUDURLUKID = new int?(Convert.ToInt32(this.mudurlukAdiSluEdit.EditValue));
          tblyakitkontform.SOFOROPERATOR = this.soforTxt.Text;
          tblyakitkontform.ISTASYONPERSID = new int?(Convert.ToInt32(this.istasyonGorevlisiSluEdit.EditValue));
          tblyakitkontform.ILGILIBIRIMPERSID = new int?(Convert.ToInt32(this.birimPersSluEdit.EditValue));
          tblyakitkontform.OTOMASYONPERSID = new int?(Convert.ToInt32(this.otomasyonGorevlisiSluEdit.EditValue));
          this.db.SaveChanges();
          int num2 = (int) XtraMessageBox.Show("Güncelleme başarı ile tamamlanmıştır.");
          LogEkle.Logs("Guncelleme Yapti");
        }
        catch (Exception ex)
        {
          int num3 = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num4 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    public void guncelleLoad(int guncelleID)
    {
      this.guncelID = guncelleID;
      this.yeniButton.Enabled = false;
      IQueryable<TBLYAKITKONTFORM> source = this.db.TBLYAKITKONTFORM.Where<TBLYAKITKONTFORM>((Expression<System.Func<TBLYAKITKONTFORM, bool>>) (hd => hd.ID == guncelleID));
      Expression<System.Func<TBLYAKITKONTFORM, \u003C\u003Ef__AnonymousType0<string, string, DateTime?, string, DateTime?, DateTime?, int?, int?, string, int?, int?, int?>>> selector = hd => new
      {
        KOD = hd.KOD,
        PLAKA = hd.PLAKA,
        EBYSTARIH = hd.EBYSTARIH,
        EBYSSAYI = hd.EBYSSAYI,
        GIRISZAMAN = hd.GIRISZAMAN,
        CIKISZAMAN = hd.CIKISZAMAN,
        BIRIMID = hd.BIRIMID,
        MUDURLUKID = hd.MUDURLUKID,
        SOFOROPERATOR = hd.SOFOROPERATOR,
        ISTASYONPERSID = hd.ISTASYONPERSID,
        ILGILIBIRIMPERSID = hd.ILGILIBIRIMPERSID,
        OTOMASYONPERSID = hd.OTOMASYONPERSID
      };
      foreach (var data in source.Select(selector))
      {
        this.kodTxt.Text = data.KOD;
        this.plakaTxt.Text = data.PLAKA;
        this.ebysDateEdit.DateTime = Convert.ToDateTime((object) data.EBYSTARIH);
        this.ebysTxt.Text = data.EBYSSAYI;
        this.girisDateEdit.DateTime = Convert.ToDateTime((object) data.GIRISZAMAN);
        this.cikisDateEdit.DateTime = Convert.ToDateTime((object) data.CIKISZAMAN);
        this.birimAdiSluEdit.EditValue = (object) Convert.ToInt32((object) data.BIRIMID);
        this.mudurlukAdiSluEdit.EditValue = (object) Convert.ToInt32((object) data.MUDURLUKID);
        this.soforTxt.Text = data.SOFOROPERATOR;
        this.istasyonGorevlisiSluEdit.EditValue = (object) Convert.ToInt32((object) data.ISTASYONPERSID);
        this.birimPersSluEdit.EditValue = (object) Convert.ToInt32((object) data.ILGILIBIRIMPERSID);
        this.otomasyonGorevlisiSluEdit.EditValue = (object) Convert.ToInt32((object) data.OTOMASYONPERSID);
      }
    }

    private bool BoslukControl()
    {
      DateTime dateTime1 = this.girisDateEdit.DateTime;
      DateTime dateTime2 = this.cikisDateEdit.DateTime;
      int num;
      if (this.plakaTxt.Text != "")
      {
        DateTime dateTime3 = this.ebysDateEdit.DateTime;
        if (this.ebysTxt.Text != "" && this.birimPersSluEdit.Text != "" && this.birimAdiSluEdit.Text != "" && this.soforTxt.Text != "" && this.istasyonGorevlisiSluEdit.Text != "")
        {
          num = this.otomasyonGorevlisiSluEdit.Text != "" ? 1 : 0;
          goto label_4;
        }
      }
      num = 0;
label_4:
      return num != 0;
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void girisYazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.BoslukControl() && this.guncelID != 0)
      {
        try
        {
          this.girisZamaniReport.Parameters["kod"].Value = (object) this.kodTxt.Text;
          this.girisZamaniReport.Parameters["plaka"].Value = (object) this.plakaTxt.Text;
          this.girisZamaniReport.Parameters["ebysTarih"].Value = (object) this.ebysDateEdit.DateTime;
          this.girisZamaniReport.Parameters["ebysSayi"].Value = (object) this.ebysTxt.Text;
          this.girisZamaniReport.Parameters["giris"].Value = (object) this.girisDateEdit.DateTime;
          this.girisZamaniReport.Parameters["cikis"].Value = (object) this.cikisDateEdit.DateTime;
          this.girisZamaniReport.Parameters["birimAD"].Value = (object) this.birimAdiSluEdit.Text;
          this.girisZamaniReport.Parameters["mudurluk"].Value = (object) this.mudurlukAdiSluEdit.Text;
          this.girisZamaniReport.Parameters["sofor"].Value = (object) this.soforTxt.Text;
          this.girisZamaniReport.Parameters["birimPers"].Value = (object) this.birimPersSluEdit.Text;
          this.girisZamaniReport.Parameters["istasyon"].Value = (object) this.istasyonGorevlisiSluEdit.Text;
          this.girisZamaniReport.Parameters["otomasyon"].Value = (object) this.otomasyonGorevlisiSluEdit.Text;
        }
        catch
        {
          int num = (int) XtraMessageBox.Show("Veri Yazdırma Hatasi");
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Kayitta boş alanlar var");
      }
      this.girisZamaniReport.Parameters["kod"].Visible = false;
      this.girisZamaniReport.Parameters["plaka"].Visible = false;
      this.girisZamaniReport.Parameters["ebysTarih"].Visible = false;
      this.girisZamaniReport.Parameters["ebysSayi"].Visible = false;
      this.girisZamaniReport.Parameters["giris"].Visible = false;
      this.girisZamaniReport.Parameters["cikis"].Visible = false;
      this.girisZamaniReport.Parameters["birimAD"].Visible = false;
      this.girisZamaniReport.Parameters["mudurluk"].Visible = false;
      this.girisZamaniReport.Parameters["sofor"].Visible = false;
      this.girisZamaniReport.Parameters["birimPers"].Visible = false;
      this.girisZamaniReport.Parameters["istasyon"].Visible = false;
      this.girisZamaniReport.Parameters["otomasyon"].Visible = false;
      new ReportPrintTool((IReport) this.girisZamaniReport).ShowPreviewDialog();
    }

    private void cikisYazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.BoslukControl())
      {
        try
        {
          this.cikisZamaniReport.Parameters["kod"].Value = (object) this.kodTxt.Text;
          this.cikisZamaniReport.Parameters["plaka"].Value = (object) this.plakaTxt.Text;
          this.cikisZamaniReport.Parameters["ebysTarih"].Value = (object) this.ebysDateEdit.DateTime;
          this.cikisZamaniReport.Parameters["ebysSayi"].Value = (object) this.ebysTxt.Text;
          this.cikisZamaniReport.Parameters["giris"].Value = (object) this.girisDateEdit.DateTime;
          this.cikisZamaniReport.Parameters["cikis"].Value = (object) this.cikisDateEdit.DateTime;
          this.cikisZamaniReport.Parameters["birimAd"].Value = (object) this.birimAdiSluEdit.Text;
          this.cikisZamaniReport.Parameters["mudurluk"].Value = (object) this.mudurlukAdiSluEdit.Text;
          this.cikisZamaniReport.Parameters["sofor"].Value = (object) this.soforTxt.Text;
          this.cikisZamaniReport.Parameters["birimPers"].Value = (object) this.birimPersSluEdit.Text;
          this.cikisZamaniReport.Parameters["istasyon"].Value = (object) this.istasyonGorevlisiSluEdit.Text;
          this.cikisZamaniReport.Parameters["otomasyon"].Value = (object) this.otomasyonGorevlisiSluEdit.Text;
        }
        catch
        {
          int num = (int) XtraMessageBox.Show("Veri Yazdırma Hatasi");
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Kayitta boş alanlar var");
      }
      this.cikisZamaniReport.Parameters["kod"].Visible = false;
      this.cikisZamaniReport.Parameters["plaka"].Visible = false;
      this.cikisZamaniReport.Parameters["ebysTarih"].Visible = false;
      this.cikisZamaniReport.Parameters["ebysSayi"].Visible = false;
      this.cikisZamaniReport.Parameters["giris"].Visible = false;
      this.cikisZamaniReport.Parameters["cikis"].Visible = false;
      this.cikisZamaniReport.Parameters["birimAd"].Visible = false;
      this.cikisZamaniReport.Parameters["mudurluk"].Visible = false;
      this.cikisZamaniReport.Parameters["sofor"].Visible = false;
      this.cikisZamaniReport.Parameters["birimPers"].Visible = false;
      this.cikisZamaniReport.Parameters["istasyon"].Visible = false;
      this.cikisZamaniReport.Parameters["otomasyon"].Visible = false;
      new ReportPrintTool((IReport) this.cikisZamaniReport).ShowPreviewDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracYakitKontrolKayit));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.kaydetButton = new BarButtonItem();
      this.silButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.yeniButton = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.girisYazdirButton = new BarButtonItem();
      this.cikisYazdirButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.otomasyonGorevlisiSluEdit = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.searchLookUpEdit5View = new GridView();
      this.otomasyonPers = new GridColumn();
      this.birimPersSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.birimPers = new GridColumn();
      this.istasyonGorevlisiSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.istasyonPers = new GridColumn();
      this.soforTxt = new TextEdit();
      this.mudurlukAdiSluEdit = new SearchLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit2View = new GridView();
      this.mudurlukAd = new GridColumn();
      this.birimAdiSluEdit = new SearchLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
      this.birimaAdiSoyadi = new GridColumn();
      this.ebysTxt = new TextEdit();
      this.cikisDateEdit = new DateEdit();
      this.girisDateEdit = new DateEdit();
      this.ebysDateEdit = new DateEdit();
      this.plakaTxt = new TextEdit();
      this.kodTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutConrolItem6 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.otomasyonGorevlisiSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.birimPersSluEdit.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.istasyonGorevlisiSluEdit.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.soforTxt.Properties.BeginInit();
      this.mudurlukAdiSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.birimAdiSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.ebysTxt.Properties.BeginInit();
      this.cikisDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.cikisDateEdit.Properties.BeginInit();
      this.girisDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.girisDateEdit.Properties.BeginInit();
      this.ebysDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.ebysDateEdit.Properties.BeginInit();
      this.plakaTxt.Properties.BeginInit();
      this.kodTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutConrolItem6.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
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
        (BarItem) this.kaydetButton,
        (BarItem) this.silButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barEditItem1,
        (BarItem) this.yeniButton,
        (BarItem) this.barEditItem2,
        (BarItem) this.girisYazdirButton,
        (BarItem) this.cikisYazdirButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 15;
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
      this.ribbonControl1.Size = new Size(1074, 118);
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
      this.kaydetButton.Caption = "Kaydet";
      this.kaydetButton.Id = 2;
      this.kaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kaydetButton.ImageOptions.Image");
      this.kaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("kaydetButton.ImageOptions.LargeImage");
      this.kaydetButton.LargeWidth = 100;
      this.kaydetButton.Name = "kaydetButton";
      this.kaydetButton.ItemClick += new ItemClickEventHandler(this.kaydetButton_ItemClick);
      this.silButton.Caption = "Sil";
      this.silButton.Id = 3;
      this.silButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("silButton.ImageOptions.Image");
      this.silButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("silButton.ImageOptions.LargeImage");
      this.silButton.LargeWidth = 100;
      this.silButton.Name = "silButton";
      this.silButton.RibbonStyle = RibbonItemStyles.Large;
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
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
      this.yeniButton.Caption = "Yeni";
      this.yeniButton.Id = 9;
      this.yeniButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.Image");
      this.yeniButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("yeniButton.ImageOptions.LargeImage");
      this.yeniButton.LargeWidth = 100;
      this.yeniButton.Name = "yeniButton";
      this.yeniButton.ItemClick += new ItemClickEventHandler(this.yeniButton_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 12;
      this.barEditItem2.Name = "barEditItem2";
      this.girisYazdirButton.Caption = "Giriş Yazdır";
      this.girisYazdirButton.Id = 13;
      this.girisYazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("girisYazdirButton.ImageOptions.Image");
      this.girisYazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("girisYazdirButton.ImageOptions.LargeImage");
      this.girisYazdirButton.LargeWidth = 100;
      this.girisYazdirButton.Name = "girisYazdirButton";
      this.girisYazdirButton.ItemClick += new ItemClickEventHandler(this.girisYazdirButton_ItemClick);
      this.cikisYazdirButton.Caption = "Çıkış Yazdır";
      this.cikisYazdirButton.Id = 14;
      this.cikisYazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("cikisYazdirButton.ImageOptions.Image");
      this.cikisYazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("cikisYazdirButton.ImageOptions.LargeImage");
      this.cikisYazdirButton.LargeWidth = 100;
      this.cikisYazdirButton.Name = "cikisYazdirButton";
      this.cikisYazdirButton.ItemClick += new ItemClickEventHandler(this.cikisYazdirButton_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.yeniButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.kaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.silButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.girisYazdirButton);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.cikisYazdirButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.otomasyonGorevlisiSluEdit);
      this.layoutControl1.Controls.Add((Control) this.birimPersSluEdit);
      this.layoutControl1.Controls.Add((Control) this.istasyonGorevlisiSluEdit);
      this.layoutControl1.Controls.Add((Control) this.soforTxt);
      this.layoutControl1.Controls.Add((Control) this.mudurlukAdiSluEdit);
      this.layoutControl1.Controls.Add((Control) this.birimAdiSluEdit);
      this.layoutControl1.Controls.Add((Control) this.ebysTxt);
      this.layoutControl1.Controls.Add((Control) this.cikisDateEdit);
      this.layoutControl1.Controls.Add((Control) this.girisDateEdit);
      this.layoutControl1.Controls.Add((Control) this.ebysDateEdit);
      this.layoutControl1.Controls.Add((Control) this.plakaTxt);
      this.layoutControl1.Controls.Add((Control) this.kodTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1074, 398);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.otomasyonGorevlisiSluEdit.EditValue = (object) "";
      this.otomasyonGorevlisiSluEdit.Location = new Point(617, 182);
      this.otomasyonGorevlisiSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.otomasyonGorevlisiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.otomasyonGorevlisiSluEdit.Name = "otomasyonGorevlisiSluEdit";
      this.otomasyonGorevlisiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.otomasyonGorevlisiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.otomasyonGorevlisiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.otomasyonGorevlisiSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.otomasyonGorevlisiSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.otomasyonGorevlisiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.otomasyonGorevlisiSluEdit.Properties.ValueMember = "ID";
      this.otomasyonGorevlisiSluEdit.Size = new Size(445, 30);
      this.otomasyonGorevlisiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.otomasyonGorevlisiSluEdit.TabIndex = 15;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit5View.Columns.AddRange(new GridColumn[1]
      {
        this.otomasyonPers
      });
      this.searchLookUpEdit5View.DetailHeight = 431;
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.otomasyonPers.Caption = "ADI SOYADI";
      this.otomasyonPers.FieldName = "ADISOYADI";
      this.otomasyonPers.MinWidth = 23;
      this.otomasyonPers.Name = "otomasyonPers";
      this.otomasyonPers.Visible = true;
      this.otomasyonPers.VisibleIndex = 0;
      this.otomasyonPers.Width = 87;
      this.birimPersSluEdit.EditValue = (object) "";
      this.birimPersSluEdit.Location = new Point(617, 148);
      this.birimPersSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.birimPersSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimPersSluEdit.Name = "birimPersSluEdit";
      this.birimPersSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimPersSluEdit.Properties.Appearance.Options.UseFont = true;
      this.birimPersSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimPersSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.birimPersSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.birimPersSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.birimPersSluEdit.Properties.ValueMember = "ID";
      this.birimPersSluEdit.Size = new Size(445, 30);
      this.birimPersSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.birimPersSluEdit.TabIndex = 14;
      this.searchLookUpEdit4View.Columns.AddRange(new GridColumn[1]
      {
        this.birimPers
      });
      this.searchLookUpEdit4View.DetailHeight = 431;
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.birimPers.Caption = "ADI SOYADI";
      this.birimPers.FieldName = "ADISOYADI";
      this.birimPers.MinWidth = 23;
      this.birimPers.Name = "birimPers";
      this.birimPers.Visible = true;
      this.birimPers.VisibleIndex = 0;
      this.birimPers.Width = 87;
      this.istasyonGorevlisiSluEdit.EditValue = (object) "";
      this.istasyonGorevlisiSluEdit.Location = new Point(617, 114);
      this.istasyonGorevlisiSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.istasyonGorevlisiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.istasyonGorevlisiSluEdit.Name = "istasyonGorevlisiSluEdit";
      this.istasyonGorevlisiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.istasyonGorevlisiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.istasyonGorevlisiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.istasyonGorevlisiSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.istasyonGorevlisiSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.istasyonGorevlisiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.istasyonGorevlisiSluEdit.Properties.ValueMember = "ID";
      this.istasyonGorevlisiSluEdit.Size = new Size(445, 30);
      this.istasyonGorevlisiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.istasyonGorevlisiSluEdit.TabIndex = 13;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.istasyonPers
      });
      this.searchLookUpEdit3View.DetailHeight = 431;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.istasyonPers.Caption = "ADI SOYADI";
      this.istasyonPers.FieldName = "ADISOYADI";
      this.istasyonPers.MinWidth = 23;
      this.istasyonPers.Name = "istasyonPers";
      this.istasyonPers.Visible = true;
      this.istasyonPers.VisibleIndex = 0;
      this.istasyonPers.Width = 87;
      this.soforTxt.Location = new Point(617, 80);
      this.soforTxt.Margin = new Padding(3, 4, 3, 4);
      this.soforTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.soforTxt.Name = "soforTxt";
      this.soforTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.soforTxt.Properties.Appearance.Options.UseFont = true;
      this.soforTxt.Size = new Size(445, 30);
      this.soforTxt.StyleController = (IStyleController) this.layoutControl1;
      this.soforTxt.TabIndex = 12;
      this.mudurlukAdiSluEdit.EditValue = (object) "";
      this.mudurlukAdiSluEdit.Location = new Point(617, 46);
      this.mudurlukAdiSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.mudurlukAdiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurlukAdiSluEdit.Name = "mudurlukAdiSluEdit";
      this.mudurlukAdiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mudurlukAdiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.mudurlukAdiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurlukAdiSluEdit.Properties.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.mudurlukAdiSluEdit.Properties.DisplayMember = "BELDMUDURLUK";
      this.mudurlukAdiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.mudurlukAdiSluEdit.Properties.ValueMember = "ID";
      this.mudurlukAdiSluEdit.Size = new Size(445, 30);
      this.mudurlukAdiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.mudurlukAdiSluEdit.TabIndex = 11;
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet2;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.mudurlukAd
      });
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.mudurlukAd.Caption = "Müdürlük Adı";
      this.mudurlukAd.FieldName = "BELDMUDURLUK";
      this.mudurlukAd.MinWidth = 23;
      this.mudurlukAd.Name = "mudurlukAd";
      this.mudurlukAd.Visible = true;
      this.mudurlukAd.VisibleIndex = 0;
      this.mudurlukAd.Width = 87;
      this.birimAdiSluEdit.EditValue = (object) "";
      this.birimAdiSluEdit.Location = new Point(617, 12);
      this.birimAdiSluEdit.Margin = new Padding(3, 4, 3, 4);
      this.birimAdiSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimAdiSluEdit.Name = "birimAdiSluEdit";
      this.birimAdiSluEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimAdiSluEdit.Properties.Appearance.Options.UseFont = true;
      this.birimAdiSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimAdiSluEdit.Properties.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.birimAdiSluEdit.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimAdiSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.birimAdiSluEdit.Properties.ValueMember = "ID";
      this.birimAdiSluEdit.Size = new Size(445, 30);
      this.birimAdiSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.birimAdiSluEdit.TabIndex = 10;
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet2;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.birimaAdiSoyadi
      });
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.birimaAdiSoyadi.Caption = "ADI SOYADI";
      this.birimaAdiSoyadi.FieldName = "BELDBIRIMADI";
      this.birimaAdiSoyadi.MinWidth = 23;
      this.birimaAdiSoyadi.Name = "birimaAdiSoyadi";
      this.birimaAdiSoyadi.Visible = true;
      this.birimaAdiSoyadi.VisibleIndex = 0;
      this.birimaAdiSoyadi.Width = 87;
      this.ebysTxt.Location = new Point(188, 114);
      this.ebysTxt.Margin = new Padding(3, 4, 3, 4);
      this.ebysTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ebysTxt.Name = "ebysTxt";
      this.ebysTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ebysTxt.Properties.Appearance.Options.UseFont = true;
      this.ebysTxt.Size = new Size(249, 30);
      this.ebysTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ebysTxt.TabIndex = 9;
      this.cikisDateEdit.EditValue = (object) null;
      this.cikisDateEdit.Location = new Point(188, 182);
      this.cikisDateEdit.Margin = new Padding(3, 4, 3, 4);
      this.cikisDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikisDateEdit.Name = "cikisDateEdit";
      this.cikisDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cikisDateEdit.Properties.Appearance.Options.UseFont = true;
      this.cikisDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisDateEdit.Size = new Size(249, 30);
      this.cikisDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.cikisDateEdit.TabIndex = 8;
      this.girisDateEdit.EditValue = (object) null;
      this.girisDateEdit.Location = new Point(188, 148);
      this.girisDateEdit.Margin = new Padding(3, 4, 3, 4);
      this.girisDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.girisDateEdit.Name = "girisDateEdit";
      this.girisDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girisDateEdit.Properties.Appearance.Options.UseFont = true;
      this.girisDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girisDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girisDateEdit.Size = new Size(249, 30);
      this.girisDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.girisDateEdit.TabIndex = 7;
      this.ebysDateEdit.EditValue = (object) null;
      this.ebysDateEdit.Location = new Point(188, 80);
      this.ebysDateEdit.Margin = new Padding(3, 4, 3, 4);
      this.ebysDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ebysDateEdit.Name = "ebysDateEdit";
      this.ebysDateEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ebysDateEdit.Properties.Appearance.Options.UseFont = true;
      this.ebysDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ebysDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ebysDateEdit.Size = new Size(249, 30);
      this.ebysDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.ebysDateEdit.TabIndex = 6;
      this.plakaTxt.Location = new Point(188, 46);
      this.plakaTxt.Margin = new Padding(3, 4, 3, 4);
      this.plakaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaTxt.Name = "plakaTxt";
      this.plakaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaTxt.Properties.Appearance.Options.UseFont = true;
      this.plakaTxt.Size = new Size(249, 30);
      this.plakaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.plakaTxt.TabIndex = 5;
      this.kodTxt.Location = new Point(188, 12);
      this.kodTxt.Margin = new Padding(3, 4, 3, 4);
      this.kodTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kodTxt.Name = "kodTxt";
      this.kodTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kodTxt.Properties.Appearance.Options.UseFont = true;
      this.kodTxt.Size = new Size(249, 30);
      this.kodTxt.StyleController = (IStyleController) this.layoutControl1;
      this.kodTxt.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[13]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutConrolItem6,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1074, 398);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem1.Control = (Control) this.kodTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(429, 34);
      this.layoutControlItem1.Text = "Kod";
      this.layoutControlItem1.TextSize = new Size(173, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 204);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(1054, 174);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem2.Control = (Control) this.plakaTxt;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(429, 34);
      this.layoutControlItem2.Text = "Plaka";
      this.layoutControlItem2.TextSize = new Size(173, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem3.Control = (Control) this.ebysDateEdit;
      this.layoutControlItem3.Location = new Point(0, 68);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(429, 34);
      this.layoutControlItem3.Text = "EBYS Tarih";
      this.layoutControlItem3.TextSize = new Size(173, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem4.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem4.Control = (Control) this.girisDateEdit;
      this.layoutControlItem4.Location = new Point(0, 136);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(429, 34);
      this.layoutControlItem4.Text = "Giriş Zamanı";
      this.layoutControlItem4.TextSize = new Size(173, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem5.Control = (Control) this.cikisDateEdit;
      this.layoutControlItem5.Location = new Point(0, 170);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(429, 34);
      this.layoutControlItem5.Text = "Çıkış Zamanı";
      this.layoutControlItem5.TextSize = new Size(173, 24);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem6.Control = (Control) this.ebysTxt;
      this.layoutControlItem6.Location = new Point(0, 102);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(429, 34);
      this.layoutControlItem6.Text = "EBYS Sayı";
      this.layoutControlItem6.TextSize = new Size(173, 24);
      this.layoutConrolItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutConrolItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutConrolItem6.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutConrolItem6.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutConrolItem6.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutConrolItem6.Control = (Control) this.birimAdiSluEdit;
      this.layoutConrolItem6.Location = new Point(429, 0);
      this.layoutConrolItem6.Name = "layoutConrolItem6";
      this.layoutConrolItem6.Size = new Size(625, 34);
      this.layoutConrolItem6.Text = "Birim Adı";
      this.layoutConrolItem6.TextSize = new Size(173, 24);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem8.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem8.Control = (Control) this.mudurlukAdiSluEdit;
      this.layoutControlItem8.Location = new Point(429, 34);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(625, 34);
      this.layoutControlItem8.Text = "Müdürlük Adı";
      this.layoutControlItem8.TextSize = new Size(173, 24);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem9.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem9.Control = (Control) this.soforTxt;
      this.layoutControlItem9.Location = new Point(429, 68);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(625, 34);
      this.layoutControlItem9.Text = "Şöför / Operatör";
      this.layoutControlItem9.TextSize = new Size(173, 24);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem10.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem10.Control = (Control) this.istasyonGorevlisiSluEdit;
      this.layoutControlItem10.Location = new Point(429, 102);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(625, 34);
      this.layoutControlItem10.Text = "İstasyon Görevlisi";
      this.layoutControlItem10.TextSize = new Size(173, 24);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem11.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem11.Control = (Control) this.birimPersSluEdit;
      this.layoutControlItem11.Location = new Point(429, 136);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(625, 34);
      this.layoutControlItem11.Text = "İlgili Birim Personeli";
      this.layoutControlItem11.TextSize = new Size(173, 24);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = true;
      this.layoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Far;
      this.layoutControlItem12.AppearanceItemCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControlItem12.Control = (Control) this.otomasyonGorevlisiSluEdit;
      this.layoutControlItem12.Location = new Point(429, 170);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(625, 34);
      this.layoutControlItem12.Text = "Otomasyon Görevlisi";
      this.layoutControlItem12.TextSize = new Size(173, 24);
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1074, 516);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AracYakitKontrolKayit);
      this.Text = "Araç Yakıt Kontrol Kayıt";
      this.Load += new EventHandler(this.AracYakitKontrolKayit_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.otomasyonGorevlisiSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.birimPersSluEdit.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.istasyonGorevlisiSluEdit.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.soforTxt.Properties.EndInit();
      this.mudurlukAdiSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.birimAdiSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.ebysTxt.Properties.EndInit();
      this.cikisDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.cikisDateEdit.Properties.EndInit();
      this.girisDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.girisDateEdit.Properties.EndInit();
      this.ebysDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.ebysDateEdit.Properties.EndInit();
      this.plakaTxt.Properties.EndInit();
      this.kodTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutConrolItem6.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
