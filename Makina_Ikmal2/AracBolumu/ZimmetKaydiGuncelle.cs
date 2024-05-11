// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.ZimmetKaydiGuncelle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.AracBolumu.Raporlar;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Sabitler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class ZimmetKaydiGuncelle : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
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
    private BarButtonItem barButtonItem8;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private MemoEdit ilgiliNotTxt;
    private TextEdit oncekiAracTxt;
    private TimeEdit saatDate;
    private DateEdit tarihDate;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem15;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private SearchLookUpEdit plakaLook;
    private GridView searchLookUpEdit1View;
    private GridColumn gridColumn1;
    private SearchLookUpEdit zimmetAlanLook;
    private GridView gridView1;
    private GridColumn gridColumn2;
    private SearchLookUpEdit birimAdiLook;
    private GridView gridView2;
    private GridColumn gridColumn3;
    private SearchLookUpEdit mudurlukLook;
    private GridView gridView3;
    private GridColumn gridColumn4;
    private SearchLookUpEdit tahsisEdilenLook;
    private GridView gridView4;
    private GridColumn gridColumn5;

    public ZimmetKaydiGuncelle() => this.InitializeComponent();

    private void AracZimmetKaydi_Load(object sender, EventArgs e)
    {
      try
      {
        this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet5.TBLBELDMUDURLUK);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet5.TBLBELDBIRIMLER);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      }
      catch (Exception ex)
      {
      }
      this.yet.yetkiislemleri("Zimmet Listesi");
      this.guncelleload();
    }

    private void kayit()
    {
      TBLARACZIMMET entity = new TBLARACZIMMET();
      try
      {
        if (this.plakaLook.Text != "")
          entity.ARACID = new int?(Convert.ToInt32(this.plakaLook.EditValue));
        if (this.tarihDate.Text != "")
          entity.TARIH = new DateTime?(Convert.ToDateTime(this.tarihDate.EditValue));
        if (this.saatDate.Text != "")
          entity.SAAT = new DateTime?(Convert.ToDateTime(this.saatDate.EditValue));
        if (this.zimmetAlanLook.Text != "")
          entity.ZIMMETALANID = new int?(Convert.ToInt32(this.zimmetAlanLook.EditValue));
        if (this.birimAdiLook.Text != "")
          entity.BELDBIRIMID = new int?(Convert.ToInt32(this.birimAdiLook.EditValue));
        if (this.mudurlukLook.Text != "")
          entity.BELDMUDURLUKID = new int?(Convert.ToInt32(this.mudurlukLook.EditValue));
        if (this.tahsisEdilenLook.Text != "")
          entity.TAHSISEDILENID = new int?(Convert.ToInt32(this.tahsisEdilenLook.EditValue));
        if (this.oncekiAracTxt.Text != "")
          entity.ONCEKIARACI = this.oncekiAracTxt.Text;
        if (this.ilgiliNotTxt.Text != "")
          entity.ILGILINOT = this.ilgiliNotTxt.Text;
        this.db.TBLARACZIMMET.Add(entity);
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void guncelle()
    {
      TBLARACZIMMET tblaraczimmet = this.db.TBLARACZIMMET.FirstOrDefault<TBLARACZIMMET>((Expression<System.Func<TBLARACZIMMET, bool>>) (x => x.ID == YetkiClass.secim_id));
      TBLARACLAR tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == 1));
      try
      {
        if (this.plakaLook.Text != "")
        {
          tblaraczimmet.ARACID = new int?(Convert.ToInt32(this.plakaLook.EditValue));
          int ARACID = Convert.ToInt32(this.plakaLook.EditValue);
          tblaraclar = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (x => x.ID == ARACID));
        }
        if (this.tarihDate.Text != "")
          tblaraczimmet.TARIH = new DateTime?(Convert.ToDateTime(this.tarihDate.EditValue));
        if (this.saatDate.Text != "")
          tblaraczimmet.SAAT = new DateTime?(Convert.ToDateTime(this.saatDate.EditValue));
        if (this.zimmetAlanLook.Text != "")
        {
          tblaraczimmet.ZIMMETALANID = new int?(Convert.ToInt32(this.zimmetAlanLook.EditValue));
          tblaraclar.ARACKULPERSID = new int?(Convert.ToInt32(this.zimmetAlanLook.EditValue));
        }
        if (this.birimAdiLook.Text != "")
        {
          tblaraczimmet.BELDBIRIMID = new int?(Convert.ToInt32(this.birimAdiLook.EditValue));
          tblaraclar.BELDBIRIMID = new int?(Convert.ToInt32(this.birimAdiLook.EditValue));
        }
        if (this.mudurlukLook.Text != "")
        {
          tblaraczimmet.BELDMUDURLUKID = new int?(Convert.ToInt32(this.mudurlukLook.EditValue));
          tblaraclar.BELDMUDURLUKID = new int?(Convert.ToInt32(this.mudurlukLook.EditValue));
        }
        if (this.tahsisEdilenLook.Text != "")
        {
          int tahsisedilen = Convert.ToInt32(this.tahsisEdilenLook.EditValue);
          tblaraczimmet.TAHSISEDILENID = new int?(tahsisedilen);
          tblaraclar.TAHSISEDILENID = new int?(tahsisedilen);
          this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == tahsisedilen)).ARACID = new int?(tblaraclar.ID);
        }
        if (this.oncekiAracTxt.Text != "")
          tblaraczimmet.ONCEKIARACI = this.oncekiAracTxt.Text;
        if (this.ilgiliNotTxt.Text != "")
          tblaraczimmet.ILGILINOT = this.ilgiliNotTxt.Text;
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Guncelleme başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.guncelle();
        int num = (int) XtraMessageBox.Show("Guncelleme işlemi başarlı bir şekilde gerçekleşti.");
        LogEkle.Logs("Guncelleme Yapti");
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Guncelleme işlemi için yetkiniz yoktur.");
      }
      ((ZimmetListesi) Application.OpenForms["ZimmetListesi"])?.Yenile();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.plakaLook.EditValue = (object) null;
      this.tarihDate.EditValue = (object) null;
      this.saatDate.EditValue = (object) null;
      this.zimmetAlanLook.EditValue = (object) null;
      this.birimAdiLook.EditValue = (object) null;
      this.mudurlukLook.EditValue = (object) null;
      this.tahsisEdilenLook.EditValue = (object) null;
      this.oncekiAracTxt.EditValue = (object) null;
      this.ilgiliNotTxt.EditValue = (object) null;
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.db.TBLARACZIMMET.Remove(this.db.TBLARACZIMMET.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
      }
      ((ZimmetListesi) Application.OpenForms["ZimmetListesi"])?.Yenile();
    }

    private void guncelleload()
    {
      TBLARACZIMMET tblaraczimmet = this.db.TBLARACZIMMET.FirstOrDefault<TBLARACZIMMET>((Expression<System.Func<TBLARACZIMMET, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.plakaLook.EditValue = (object) tblaraczimmet.ARACID;
      this.tarihDate.EditValue = (object) tblaraczimmet.TARIH;
      this.saatDate.EditValue = (object) tblaraczimmet.SAAT;
      this.zimmetAlanLook.EditValue = (object) tblaraczimmet.ZIMMETALANID;
      this.birimAdiLook.EditValue = (object) tblaraczimmet.BELDBIRIMID;
      this.mudurlukLook.EditValue = (object) tblaraczimmet.BELDMUDURLUKID;
      this.tahsisEdilenLook.EditValue = (object) tblaraczimmet.TAHSISEDILENID;
      this.oncekiAracTxt.EditValue = (object) tblaraczimmet.ONCEKIARACI;
      this.ilgiliNotTxt.EditValue = (object) tblaraczimmet.ILGILINOT;
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "kayıt";
      int num = (int) new BirimAdi().ShowDialog();
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      int num = (int) new Mudurluk().ShowDialog();
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      ResmiAracTeslim resmiAracTeslim = new ResmiAracTeslim();
      resmiAracTeslim.Parameters["aracID"].Value = (object) YetkiClass.secim_id;
      resmiAracTeslim.Parameters["aracID"].Visible = false;
      resmiAracTeslim.Parameters["tarih"].Value = this.tarihDate.EditValue;
      resmiAracTeslim.Parameters["tarih"].Visible = false;
      resmiAracTeslim.Parameters["saat"].Value = this.saatDate.EditValue;
      resmiAracTeslim.Parameters["saat"].Visible = false;
      new ReportPrintTool((IReport) resmiAracTeslim).ShowPreviewDialog();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      ResmiAracTeslim resmiAracTeslim = new ResmiAracTeslim();
      resmiAracTeslim.Parameters["aracID"].Value = (object) YetkiClass.secim_id;
      resmiAracTeslim.Parameters["aracID"].Visible = false;
      resmiAracTeslim.Parameters["tarih"].Value = this.tarihDate.EditValue;
      resmiAracTeslim.Parameters["tarih"].Visible = false;
      resmiAracTeslim.Parameters["saat"].Value = this.saatDate.EditValue;
      resmiAracTeslim.Parameters["saat"].Visible = false;
      new ReportPrintTool((IReport) resmiAracTeslim).PrintDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ZimmetKaydiGuncelle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.layoutControl1 = new LayoutControl();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.ilgiliNotTxt = new MemoEdit();
      this.oncekiAracTxt = new TextEdit();
      this.saatDate = new TimeEdit();
      this.tarihDate = new DateEdit();
      this.plakaLook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.zimmetAlanLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.birimAdiLook = new SearchLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.gridColumn3 = new GridColumn();
      this.mudurlukLook = new SearchLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.gridColumn4 = new GridColumn();
      this.tahsisEdilenLook = new SearchLookUpEdit();
      this.gridView4 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.ribbonControl1.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.ilgiliNotTxt.Properties.BeginInit();
      this.oncekiAracTxt.Properties.BeginInit();
      this.saatDate.Properties.BeginInit();
      this.tarihDate.Properties.CalendarTimeProperties.BeginInit();
      this.tarihDate.Properties.BeginInit();
      this.plakaLook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.zimmetAlanLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView1.BeginInit();
      this.birimAdiLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.mudurlukLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.tahsisEdilenLook.Properties.BeginInit();
      this.gridView4.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
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
        (BarItem) this.barButtonItem8
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 9;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(939, 100);
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
      this.barButtonItem2.Caption = "Kaydet";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Önizle";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem5.Caption = "Yazdır";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
      this.barButtonItem8.Caption = "Yeni";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.layoutControl1.Controls.Add((Control) this.simpleButton2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.ilgiliNotTxt);
      this.layoutControl1.Controls.Add((Control) this.oncekiAracTxt);
      this.layoutControl1.Controls.Add((Control) this.saatDate);
      this.layoutControl1.Controls.Add((Control) this.tarihDate);
      this.layoutControl1.Controls.Add((Control) this.plakaLook);
      this.layoutControl1.Controls.Add((Control) this.zimmetAlanLook);
      this.layoutControl1.Controls.Add((Control) this.birimAdiLook);
      this.layoutControl1.Controls.Add((Control) this.mudurlukLook);
      this.layoutControl1.Controls.Add((Control) this.tahsisEdilenLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(939, 439);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(690, (int) sbyte.MaxValue);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(22, 22);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton2.TabIndex = 18;
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(690, 101);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(22, 22);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 17;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.layoutControl5.Location = new Point(183, 309);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(529, 118);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(529, 118);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl4.Location = new Point(487, 41);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(225, 24);
      this.layoutControl4.TabIndex = 15;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(225, 24);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(12, 12);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(167, 415);
      this.layoutControl3.TabIndex = 14;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(167, 415);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(716, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(211, 415);
      this.layoutControl2.TabIndex = 13;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(211, 415);
      this.layoutControlGroup1.TextVisible = false;
      this.ilgiliNotTxt.Location = new Point(274, 209);
      this.ilgiliNotTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ilgiliNotTxt.Name = "ilgiliNotTxt";
      this.ilgiliNotTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ilgiliNotTxt.Properties.Appearance.Options.UseFont = true;
      this.ilgiliNotTxt.Size = new Size(438, 96);
      this.ilgiliNotTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ilgiliNotTxt.TabIndex = 12;
      this.oncekiAracTxt.Location = new Point(274, 181);
      this.oncekiAracTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.oncekiAracTxt.Name = "oncekiAracTxt";
      this.oncekiAracTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.oncekiAracTxt.Properties.Appearance.Options.UseFont = true;
      this.oncekiAracTxt.Size = new Size(438, 24);
      this.oncekiAracTxt.StyleController = (IStyleController) this.layoutControl1;
      this.oncekiAracTxt.TabIndex = 11;
      this.saatDate.EditValue = (object) new DateTime(2021, 12, 24, 0, 0, 0, 0);
      this.saatDate.Location = new Point(402, 41);
      this.saatDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.saatDate.Name = "saatDate";
      this.saatDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.saatDate.Properties.Appearance.Options.UseFont = true;
      this.saatDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.saatDate.Properties.Mask.EditMask = "t";
      this.saatDate.Size = new Size(81, 24);
      this.saatDate.StyleController = (IStyleController) this.layoutControl1;
      this.saatDate.TabIndex = 6;
      this.tarihDate.EditValue = (object) null;
      this.tarihDate.Location = new Point(274, 41);
      this.tarihDate.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihDate.Name = "tarihDate";
      this.tarihDate.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarihDate.Properties.Appearance.Options.UseFont = true;
      this.tarihDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDate.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.tarihDate.Size = new Size(124, 24);
      this.tarihDate.StyleController = (IStyleController) this.layoutControl1;
      this.tarihDate.TabIndex = 5;
      this.plakaLook.Location = new Point(274, 12);
      this.plakaLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.plakaLook.Name = "plakaLook";
      this.plakaLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.plakaLook.Properties.Appearance.Options.UseFont = true;
      this.plakaLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plakaLook.Properties.DataSource = (object) this.tBLARACLARBindingSource;
      this.plakaLook.Properties.DisplayMember = "PLAKA";
      this.plakaLook.Properties.NullText = "";
      this.plakaLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.plakaLook.Properties.ValueMember = "ID";
      this.plakaLook.Size = new Size(438, 24);
      this.plakaLook.StyleController = (IStyleController) this.layoutControl1;
      this.plakaLook.TabIndex = 4;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.AppearanceCell.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn1.AppearanceCell.Options.UseFont = true;
      this.gridColumn1.Caption = "Plaka";
      this.gridColumn1.FieldName = "PLAKA";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.zimmetAlanLook.Location = new Point(274, 69);
      this.zimmetAlanLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.zimmetAlanLook.Name = "zimmetAlanLook";
      this.zimmetAlanLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.zimmetAlanLook.Properties.Appearance.Options.UseFont = true;
      this.zimmetAlanLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.zimmetAlanLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.zimmetAlanLook.Properties.DisplayMember = "ADISOYADI";
      this.zimmetAlanLook.Properties.NullText = "";
      this.zimmetAlanLook.Properties.PopupView = (ColumnView) this.gridView1;
      this.zimmetAlanLook.Properties.ValueMember = "ID";
      this.zimmetAlanLook.Size = new Size(438, 24);
      this.zimmetAlanLook.StyleController = (IStyleController) this.layoutControl1;
      this.zimmetAlanLook.TabIndex = 7;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.AppearanceCell.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn2.AppearanceCell.Options.UseFont = true;
      this.gridColumn2.Caption = "Zimmet Alan";
      this.gridColumn2.FieldName = "ADISOYADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.birimAdiLook.Location = new Point(274, 101);
      this.birimAdiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimAdiLook.Name = "birimAdiLook";
      this.birimAdiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.birimAdiLook.Properties.Appearance.Options.UseFont = true;
      this.birimAdiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimAdiLook.Properties.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.birimAdiLook.Properties.DisplayMember = "BELDBIRIMADI";
      this.birimAdiLook.Properties.NullText = "";
      this.birimAdiLook.Properties.PopupView = (ColumnView) this.gridView2;
      this.birimAdiLook.Properties.ValueMember = "ID";
      this.birimAdiLook.Size = new Size(412, 24);
      this.birimAdiLook.StyleController = (IStyleController) this.layoutControl1;
      this.birimAdiLook.TabIndex = 8;
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView2.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.AppearanceCell.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn3.AppearanceCell.Options.UseFont = true;
      this.gridColumn3.Caption = "Birim Adı";
      this.gridColumn3.FieldName = "BELDBIRIMADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.mudurlukLook.Location = new Point(274, (int) sbyte.MaxValue);
      this.mudurlukLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurlukLook.Name = "mudurlukLook";
      this.mudurlukLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mudurlukLook.Properties.Appearance.Options.UseFont = true;
      this.mudurlukLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurlukLook.Properties.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.mudurlukLook.Properties.DisplayMember = "BELDMUDURLUK";
      this.mudurlukLook.Properties.NullText = "";
      this.mudurlukLook.Properties.PopupView = (ColumnView) this.gridView3;
      this.mudurlukLook.Properties.ValueMember = "ID";
      this.mudurlukLook.Size = new Size(412, 24);
      this.mudurlukLook.StyleController = (IStyleController) this.layoutControl1;
      this.mudurlukLook.TabIndex = 9;
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.AppearanceCell.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn4.AppearanceCell.Options.UseFont = true;
      this.gridColumn4.Caption = "Müdürlük";
      this.gridColumn4.FieldName = "BELDMUDURLUK";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.tahsisEdilenLook.Location = new Point(274, 153);
      this.tahsisEdilenLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tahsisEdilenLook.Name = "tahsisEdilenLook";
      this.tahsisEdilenLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tahsisEdilenLook.Properties.Appearance.Options.UseFont = true;
      this.tahsisEdilenLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tahsisEdilenLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.tahsisEdilenLook.Properties.DisplayMember = "ADISOYADI";
      this.tahsisEdilenLook.Properties.NullText = "";
      this.tahsisEdilenLook.Properties.PopupView = (ColumnView) this.gridView4;
      this.tahsisEdilenLook.Properties.ValueMember = "ID";
      this.tahsisEdilenLook.Size = new Size(438, 24);
      this.tahsisEdilenLook.StyleController = (IStyleController) this.layoutControl1;
      this.tahsisEdilenLook.TabIndex = 10;
      this.gridView4.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.AppearanceCell.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridColumn5.AppearanceCell.Options.UseFont = true;
      this.gridColumn5.Caption = "Adı Soyadı";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[15]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(939, 439);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.plakaLook;
      this.layoutControlItem1.Location = new Point(171, 0);
      this.layoutControlItem1.MinSize = new Size(50, 25);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(533, 29);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Plaka";
      this.layoutControlItem1.TextSize = new Size(88, 18);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.tarihDate;
      this.layoutControlItem2.Location = new Point(171, 29);
      this.layoutControlItem2.MinSize = new Size(154, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(219, 28);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Tarih/Saat";
      this.layoutControlItem2.TextSize = new Size(88, 18);
      this.layoutControlItem3.Control = (Control) this.saatDate;
      this.layoutControlItem3.Location = new Point(390, 29);
      this.layoutControlItem3.MinSize = new Size(54, 28);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(85, 28);
      this.layoutControlItem3.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.zimmetAlanLook;
      this.layoutControlItem4.Location = new Point(171, 57);
      this.layoutControlItem4.MinSize = new Size(50, 25);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(533, 32);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Zimmet Alan";
      this.layoutControlItem4.TextSize = new Size(88, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.birimAdiLook;
      this.layoutControlItem5.Location = new Point(171, 89);
      this.layoutControlItem5.MinSize = new Size(50, 25);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(507, 26);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Birim Adı";
      this.layoutControlItem5.TextSize = new Size(88, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.mudurlukLook;
      this.layoutControlItem6.Location = new Point(171, 115);
      this.layoutControlItem6.MinSize = new Size(50, 25);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(507, 26);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.Text = "Müdürlüğü";
      this.layoutControlItem6.TextSize = new Size(88, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.tahsisEdilenLook;
      this.layoutControlItem7.Location = new Point(171, 141);
      this.layoutControlItem7.MinSize = new Size(50, 25);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(533, 28);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "Tahsis Edilen";
      this.layoutControlItem7.TextSize = new Size(88, 18);
      this.layoutControlItem10.Control = (Control) this.layoutControl2;
      this.layoutControlItem10.Location = new Point(704, 0);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(215, 419);
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.layoutControl3;
      this.layoutControlItem11.Location = new Point(0, 0);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(171, 419);
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.layoutControl4;
      this.layoutControlItem12.Location = new Point(475, 29);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(229, 28);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.oncekiAracTxt;
      this.layoutControlItem8.Location = new Point(171, 169);
      this.layoutControlItem8.MinSize = new Size(154, 28);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(533, 28);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "Önceki Aracı";
      this.layoutControlItem8.TextSize = new Size(88, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.ilgiliNotTxt;
      this.layoutControlItem9.Location = new Point(171, 197);
      this.layoutControlItem9.MinSize = new Size(114, 24);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(533, 100);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.Text = "İlgili Not";
      this.layoutControlItem9.TextSize = new Size(88, 18);
      this.layoutControlItem13.Control = (Control) this.layoutControl5;
      this.layoutControlItem13.Location = new Point(171, 297);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(533, 122);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem14.Control = (Control) this.simpleButton1;
      this.layoutControlItem14.Location = new Point(678, 89);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(26, 26);
      this.layoutControlItem14.TextSize = new Size(0, 0);
      this.layoutControlItem14.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.simpleButton2;
      this.layoutControlItem15.Location = new Point(678, 115);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(26, 26);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(939, 539);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (ZimmetKaydiGuncelle);
      this.Text = "AracZimmetKaydiGuncelle";
      this.Load += new EventHandler(this.AracZimmetKaydi_Load);
      this.ribbonControl1.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.ilgiliNotTxt.Properties.EndInit();
      this.oncekiAracTxt.Properties.EndInit();
      this.saatDate.Properties.EndInit();
      this.tarihDate.Properties.CalendarTimeProperties.EndInit();
      this.tarihDate.Properties.EndInit();
      this.plakaLook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.zimmetAlanLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView1.EndInit();
      this.birimAdiLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.gridView2.EndInit();
      this.mudurlukLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.gridView3.EndInit();
      this.tahsisEdilenLook.Properties.EndInit();
      this.gridView4.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
